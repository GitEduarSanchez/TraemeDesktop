Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Imports CapaDatos
Public Class ClassFoto
    Inherits CapaDatos.ClassConexion
    Dim cnn As New MySqlConnection
    Dim query As String
    Dim cmd As New MySqlCommand
    Dim r As MySqlDataReader
    Dim pict As PictureBox
    Sub New(ByVal ofd As OpenFileDialog, ByVal sender As TextBox, ByVal p As PictureBox)
        Try
            With ofd
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
                .Filter = ("Imagenes |*.png; *.bmp; *.jpg;*.jpeg; *.gif;*.ico;")
                .FilterIndex = 6
                .Title = "Selecciona una foto"
                .FileName = String.Empty
                p.BackgroundImage = Nothing
                If .ShowDialog = DialogResult.OK Then
                    sender.Text = .SafeFileName
                    sender.Visible = False
                    p.Image = Image.FromFile(.FileName)
                    p.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    p.Image = p.ErrorImage
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try
    End Sub
    Sub New(ByVal ofd As OpenFileDialog, ByVal p As PictureBox)
        Try
            With ofd
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
                .Filter = ("Imagenes |*.png; *.bmp; *.jpg;*.jpeg; *.gif;*.ico;")
                .FilterIndex = 6
                .Title = "Selecciona una foto"
                .FileName = String.Empty
                p.BackgroundImage = Nothing
                If .ShowDialog = DialogResult.OK Then
                    p.Image = Image.FromFile(.FileName)
                    p.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    p.Image = p.ErrorImage
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try
    End Sub
    Sub New(ByVal pict As PictureBox, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal id As Integer)
        Try
            Me.pict = pict
            cnn = conectar()
            query = "select " & campo & " from " & tabla & " where " & filtro & " = '" & id & "' ;"
            cmd = New MySqlCommand(query, cnn)
            r = cmd.ExecuteReader
            Dim bytImage() As Byte
            If r.Read() Then
                bytImage = CType(r(0), Byte())
                Dim ms As New System.IO.MemoryStream(bytImage)
                Dim bmImage As New Bitmap(ms)
                ms.Close()
                pict.Image = bmImage
                pict.SizeMode = PictureBoxSizeMode.StretchImage
                pict.Refresh()
                r.Close()
                cnn.Close()
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Me.pict.Image = pict.ErrorImage
            Me.pict.SizeMode = PictureBoxSizeMode.StretchImage
            Me.pict.Refresh()
            cnn.Close()
        End Try

        cnn.Close()
    End Sub
    Public Function getimage()
        Return Me.pict
    End Function
    'Private Function GrabarImagen(ByVal prmIDASOC As String) As Boolean
    '    Dim SaveImage As Boolean = False
    '    Dim curFileName As String = ""
    '    Try
    '        Dim openDlg As OpenFileDialog = New OpenFileDialog()
    '        openDlg.Filter = "All Bitmap files|*.bmp"
    '        Dim filter As String = openDlg.Filter
    '        openDlg.Title = "Open a Bitmap File"
    '        If (openDlg.ShowDialog() = DialogResult.OK) Then
    '            curFileName = openDlg.FileName
    '            SaveImage = True
    '        Else
    '            Return False
    '            Exit Function
    '        End If
    '        If SaveImage = True Then
    '            Dim fsFoto As FileStream
    '            fsFoto = New FileStream(curFileName, FileMode.Open)
    '            Dim fiFoto As FileInfo = New FileInfo(curFileName)
    '            Dim Temp As Long = fiFoto.Length
    '        &nbs;   Dim lung As Long = Convert.ToInt32(Temp)
    '            Dim picture(lung) As Byte
    '            fsFoto.Read(picture, 0, lung)
    '            fsFoto.Close()
    '            Dim cmdFoto As New OleDbCommand("Carga_Foto", Con)
    '            cmdFoto.CommandType = CommandType.StoredProcedure
    '            Dim sql_IDAsoc = New OleDbParameter("@IdSocio", prmIDASOC)
    '            Dim sql_Foto As New OleDbParameter("@IMAGEN", SqlDbType.Image)
    '            sql_Foto.Value = picture
    '            cmdFoto.Parameters.Add(sql_IDAsoc)
    '            cmdFoto.Parameters.Add(sql_Foto)
    '            cmdFoto.ExecuteNonQuery()
    '            cmdFoto.Dispose()
    '            sql_Foto = Nothing
    '            picture = Nothing
    '            Return True
    '            Exit Function
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        Return False
    '    End Try
    'End Function
    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)
    End Function

    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function



End Class
