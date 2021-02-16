Imports System.Net
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Imports System.Web
Imports System.Windows.Forms

'Imports WhatsAppApi
Public Class ClassInternet
    Public Function compruebaConexion() As Boolean
        Dim request As WebRequest
        Dim response As WebResponse
        Dim Url As New Uri("http://www.google.com")
        Try
            'Creamos la request
            request = System.Net.WebRequest.Create(Url)
            'POnemos un tiempo limite
            request.Timeout = 5000
            'ejecutamos la request
            response = request.GetResponse
            response.Close()
            request = Nothing
            'Label2.Text = System.Environment.MachineName & "si hay conexion a internet"
            Return True
        Catch ex As Exception
            'si ocurre un error, devolvemos error
            request = Nothing
            'Label2.Text = "No hay conexion a internet"
            Return False
        End Try
    End Function
    Public Function VerificarConexionURL(ByVal mURL As String) As Boolean
        Dim Peticion As System.Net.WebRequest
        Dim Respuesta As System.Net.HttpWebResponse
        Try
            Peticion = System.Net.WebRequest.Create(mURL)
            Respuesta = Peticion.GetResponse()
            Return True
        Catch ex As System.Net.WebException
            If ex.Status = Net.WebExceptionStatus.NameResolutionFailure Then
                Return False
            End If
            Return False
        End Try
    End Function
    Public Function funConexion() As Boolean
        Dim Req As HttpWebRequest = WebRequest.Create("http://www.google.com")
        Dim res As System.Net.HttpWebResponse
        Try
            Req = DirectCast(System.Net.WebRequest.Create("http://www.google.com"), System.Net.HttpWebRequest)
            res = DirectCast(Req.GetResponse(), System.Net.HttpWebResponse)
            Req.Abort()
            If res.StatusCode = System.Net.HttpStatusCode.OK Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
    Public Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
    Sub SMSFunc(ByVal st1 As String, ByVal st2 As String, ByVal st3 As String)
        Try
            st3 = st3.Replace("@MobileNo", st1).Replace("@Message", st2)
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim myUri As New Uri(st3)
            request = DirectCast(WebRequest.Create(myUri), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Function Encrypt(password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function

    Public Function Decrypt(encryptpwd As String) As String
        Dim decryptpwd As String = String.Empty
        Dim encodepwd As New UTF8Encoding()
        Dim Decode As Decoder = encodepwd.GetDecoder()
        Dim todecode_byte As Byte() = Convert.FromBase64String(encryptpwd)
        Dim charCount As Integer = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
        Dim decoded_char As Char() = New Char(charCount - 1) {}
        Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
        decryptpwd = New [String](decoded_char)
        Return decryptpwd
    End Function
    Sub RefreshRecords()
        'Dim obj As frmMainMenu = DirectCast(Application.OpenForms("frmMainMenu"), frmMainMenu)
        'obj.Getdata()
        'obj.DataGridView1.Refresh()
        'obj.DataGridView1.Update()
    End Sub
    Sub LogFunc(ByVal st1 As String, ByVal st2 As String)
        'con = New SqlConnection(cs)
        'con.Open()
        'Dim cb As String = "insert into Logs(UserID,Date,Operation) VALUES (@d1,@d2,@d3)"
        'cmd = New SqlCommand(cb)
        'cmd.Connection = con
        'cmd.Parameters.AddWithValue("@d1", st1)
        'cmd.Parameters.AddWithValue("@d2", System.DateTime.Now)
        'cmd.Parameters.AddWithValue("@d3", st2)
        'cmd.ExecuteReader()
        'con.Close()
    End Sub
#Region "LOADING FORM / CHECK INTERNET"
    'LOADING FORM & CHECK INTERNET CONNECTION
    ''Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ''    'Try
    ''    '    My.Computer.Network.Ping("www.Google.com")
    ''    'Catch
    ''    '    MsgBox("Unable to connect to the Internet." & vbNewLine & "Messenger will be closed.", MsgBoxStyle.Critical, "Error")
    ''    '    End
    ''    'End Try
    ''End Sub
#End Region
End Class
'Module mWhatsApp
'    Dim WAPass As String
'    Const WANum As String = "5492236685519"
'    Dim wa As WhatsApp
'    Public Sub InitWA(ByVal NickName As String, Optional ByVal debug As Boolean = False)
'        .WAPass = File.ReadAllText(My.Application.Info.DirectoryPath & "\WAPASS.txt")
'        .wa = New WhatsApp(WANum, WAPass, NickName, debug)
'        .AddHandler(wa.OnLoginSuccess, AddressOf wa_OnLoginSuccess)
'        .AddHandler(wa.OnLoginFailed, AddressOf wa_OnLoginFailed)
'        .AddHandler(wa.OnGetMessage, AddressOf wa_OnGetMessage)
'        .AddHandler(wa.OnGetMessageReceivedClient, AddressOf wa_OnGetMessageReceivedClient)
'        .AddHandler(wa.OnGetMessageReceivedServer, AddressOf wa_OnGetMessageReceivedServer)
'        .AddHandler(wa.OnNotificationPicture, AddressOf wa_OnNotificationPicture)
'        .AddHandler(wa.OnGetPresence, AddressOf wa_OnGetPresence)
'        .AddHandler(wa.OnGetGroupParticipants, AddressOf wa_OnGetGroupParticipants)
'        .AddHandler(wa.OnGetLastSeen, AddressOf wa_OnGetLastSeen)
'        .AddHandler(wa.OnGetTyping, AddressOf wa_OnGetTyping)
'        .AddHandler(wa.OnGetPaused, AddressOf wa_OnGetPaused)
'        .AddHandler(wa.OnGetMessageImage, AddressOf wa_OnGetMessageImage)
'        .AddHandler(wa.OnGetMessageAudio, AddressOf wa_OnGetMessageAudio)
'        .AddHandler(wa.OnGetMessageVideo, AddressOf wa_OnGetMessageVideo)
'        .AddHandler(wa.OnGetMessageLocation, AddressOf wa_OnGetMessageLocation)
'        .AddHandler(wa.OnGetMessageVcard, AddressOf wa_OnGetMessageVcard)
'        .AddHandler(wa.OnGetPhoto, AddressOf wa_OnGetPhoto)
'        .AddHandler(wa.OnGetPhotoPreview, AddressOf wa_OnGetPhotoPreview)
'        .AddHandler(wa.OnGetGroups, AddressOf wa_OnGetGroups)
'        .AddHandler(wa.OnGetSyncResult, AddressOf wa_OnGetSyncResult)
'        .AddHandler(wa.OnGetStatus, AddressOf wa_OnGetStatus)
'        .AddHandler(wa.OnGetPrivacySettings, AddressOf wa_OnGetPrivacySettings)
'        .AddHandler(WhatsAppApi.Helper.DebugAdapter.Instance.OnPrintDebug, AddressOf Instance_OnPrintDebug)
'        .wa.Connect()
'        Dim datFile As String = getDatFileName(WANum)
'        Dim nextChallenge() As Byte
'        If (File.Exists(datFile)) Then
'            Dim foo As String = File.ReadAllText(datFile)
'            .nextChallenge = Convert.FromBase64String(foo)
'        End If
'        .wa.Login(nextChallenge)
'        : .ProcessChat(wa)
'    End Sub
'    Public Function SendWA(ByVal MSG As String, Num As String) As Boolean
'        Dim usrMan As New WhatsUserManager()
'        .Dim tmpUser = usrMan.CreateUser(Num, "User")
'        .wa.SendMessage(Num, MSG)


'        .Return True
'    End Function
'    Public Sub Instance_OnPrintDebug(value As Object)
'        .Debug.Print(value)
'    End Sub
'    Public Sub wa_OnGetPrivacySettings(settings As Dictionary(Of WhatsApp.VisibilityCategory, WhatsApp.VisibilitySetting))

'    End Sub
'    Public Sub wa_OnGetStatus(form As String, type As String, name As String, status As String)

'    End Sub
'    Public Function getDatFileName(pn As String) As String
'        Dim filename As String = String.Format("{0}.next.dat", pn)
'        .Return Path.Combine(Directory.GetCurrentDirectory(), filename)
'    End Function
'    Public Sub wa_OnGetSyncResult(index As Integer, sid As String, existingUsers As Dictionary(Of String, String), failedNumbers As String())

'    End Sub
'    Public Sub wa_OnGetGroups(groups As WaGroupInfo())

'    End Sub
'    Public Sub wa_OnGetPhotoPreview(from As String, id As String, data() As Byte)
'        .File.WriteAllBytes(String.Format("preview_{0}.jpg", from), data)
'    End Sub
'    Public Sub wa_OnGetPhoto(from As String, id As String, data() As Byte)
'        .File.WriteAllBytes(String.Format("{0}.jpg", from), data)
'    End Sub
'    Public Sub wa_OnGetMessageVcard(from As String, id As String, name As String, data() As Byte)
'        .File.WriteAllBytes(String.Format("{0}.vcf", name), data)
'    End Sub
'    Public Sub wa_OnGetMessageLocation(from As String, id As String, lon As Double, lat As Double, url As String, name As String, preview() As Byte)
'        .File.WriteAllBytes(String.Format("{0}{1end sub.jpg", lat, lon), preview)
'    End Sub
'    Public Sub wa_OnGetMessageVideo(from As String, id As String, filename As String, fileSize As Integer, url As String, preview() As Byte)
'        .OnGetMedia(filename, url, preview)
'    End Sub
'    Public Sub OnGetMedia(file As String, url As String, data() As Byte)
'        .My.COMPUTER.FileSystem.WriteAllBytes(String.Format("preview_{0}.jpg", file), data, False)
'        Dim WA_WC As New WebClient
'        .WA_WC.DownloadFileAsync(New Uri(url), file, 0)
'    End Sub
'    Public Sub wa_OnGetMessageAudio(from As String, id As String, filename As String, filesize As Integer, url As String, preview() As Byte)
'        .OnGetMedia(filename, url, preview)
'    End Sub
'    Public Sub wa_OnGetMessageImage(from As String, id As String, filename As String, size As Integer, url As String, preview() As Byte)
'        .OnGetMedia(filename, url, preview)
'    End Sub
'    Public Sub wa_OnGetPaused(from As String)

'    End Sub
'    Public Sub wa_OnGetTyping(from As String)

'    End Sub
'    Public Sub wa_OnGetLastSeen(from As String, lastseen As DateTime)

'    End Sub
'    Public Sub wa_OnGetMessageReceivedServer(from As String, id As String)

'    End Sub
'    Public Sub wa_OnGetMessageReceivedClient(from As String, id As String)

'    End Sub
'    Public Sub wa_OnGetGroupParticipants(gjid As String, jids() As String)

'    End Sub
'    Public Sub wa_OnGetPresence(from As String, type As String)

'    End Sub
'    Public Sub wa_OnNotificationPicture(type As String, jid As String, id As String)

'    End Sub
'    Public Sub wa_OnGetMessage(node As ProtocolTreeNode, from As String, id As String, name As String, message As String, receipt_sent As Boolean)
'        Dim Number As String = Split(from, "@")(0)

'    End Sub
'    Private Sub wa_OnLoginFailed(data As String)
'        .End()
'    End Sub
'    Private Sub wa_OnLoginSuccess(phoneNumber As String, data() As Byte)
'        ' next password
'        Dim sdata As String = Convert.ToBase64String(data)
'        .My.COMPUTER.FileSystem.WriteAllText(getDatFileName(WANum), sdata, False)
'    End Sub
'    Private Sub ProcessChat(wa As WhatsApp)
'        .Dim thRecv = New Thread(AddressOf ProcessChatT) : thRecv.IsBackground = True
'        .thRecv.Start()
'    End Sub
'    .Sub ProcessChatT(t)
'    .Try()
'   .While wa IsNot Nothing
'    .wa.PollMessages()
'    .Thread.Sleep(100)
'	                Continue While
'	            End While
'	        Catch generatedExceptionName As ThreadAbortException
'	        End Try

'	    End Sub
'End Module
