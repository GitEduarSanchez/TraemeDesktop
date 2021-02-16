'Imports DPFP
'Imports DPFP.Capture
'Imports DPFP.Processing
'Imports System.Text

'Public Class frm_huella
'    Implements DPFP.Capture.EventHandler
'    Public captura As DPFP.Capture.Capture
'    Public enrolar As New DPFP.Processing.Enrollment
'    Dim objcnn As New CapaDatos.ClassConexion
'    Private Delegate Sub _delegadomuetra(ByVal text As String)
'    Public template As New DPFP.Template
'    Private Sub mostrarveces(ByVal texto As String)
'        If lbl_n.InvokeRequired Then
'            Dim deleg As New _delegadomuetra(AddressOf mostrarveces)
'            Me.Invoke(deleg, New Object() {texto})
'        Else
'            Me.lbl_n.Text = texto
'        End If
'    End Sub

'    Protected Overridable Sub init()
'        Try
'            captura = New Capture()
'            If Not captura Is Nothing Then
'                captura.EventHandler = Me
'                enrolar = New DPFP.Processing.Enrollment()
'                Dim text As New StringBuilder()
'                text.AppendFormat("Necesitas pasar el dedo {0} veces", enrolar.FeaturesNeeded)
'                lbl_n.Text = text.ToString()
'            Else
'                MessageBox.Show("no se pudo instanciar la captura", "digital person", MessageBoxButtons.OK)
'            End If
'        Catch ex As Exception
'            MessageBox.Show("no se pudo instanciar la captura", "digital person", MessageBoxButtons.OK)
'        End Try
'    End Sub
'    Protected Overridable Sub iniciarcaptura()
'        If Not captura Is Nothing Then
'            Try
'                captura.StartCapture()
'            Catch ex As Exception
'                MessageBox.Show("no se pudo instanciar la captura", "digital person", MessageBoxButtons.OK)
'            End Try
'        End If
'    End Sub
'    Protected Sub pararcaptura()
'        If Not captura Is Nothing Then
'            Try
'                captura.StopCapture()
'            Catch ex As Exception
'                MessageBox.Show("no se pudo instanciar la captura", "digital person", MessageBoxButtons.OK)
'            End Try
'        End If
'    End Sub
'    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
'        pararcaptura()
'    End Sub

'    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

'    End Sub
'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        pict_huella.Image = Nothing
'        init()
'        iniciarcaptura()
'    End Sub

'    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
'        ponerimagen(convertirSampleaMapaBits(Sample))
'        procesar(Sample)
'    End Sub

'    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

'    End Sub

'    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
'        'MessageBox.Show("se ha tocado el dispositivo", "digital person", MessageBoxButtons.OK)
'    End Sub

'    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
'        'MessageBox.Show("se ha tocado el dispositivo", "digital person", MessageBoxButtons.OK)
'    End Sub

'    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

'    End Sub

'    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

'    End Sub
'    Protected Function convertirSampleaMapaBits(ByVal sample As DPFP.Sample) As Bitmap
'        Dim conversor As New DPFP.Capture.SampleConversion()
'        Dim mapabits As Bitmap = Nothing
'        conversor.ConvertToPicture(sample, mapabits)
'        Return mapabits
'    End Function
'    Public Sub ponerimagen(ByVal bmp)
'        Me.pict_huella.Image = bmp
'    End Sub

'    Protected Function extrarcaracteristicas(ByVal sample As DPFP.Sample, ByVal purpose As DataPurpose) As DPFP.FeatureSet
'        Dim extractor As New DPFP.Processing.FeatureExtraction()
'        Dim alimentacion As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
'        Dim caracteristicas As New DPFP.FeatureSet()
'        extractor.CreateFeatureSet(sample, purpose, alimentacion, caracteristicas)
'        If alimentacion = DPFP.Capture.CaptureFeedback.Good Then
'            Return caracteristicas
'        Else
'            Return Nothing
'            MessageBox.Show("no se pudo capturar la huella")
'        End If
'    End Function
'    Protected Sub procesar(ByVal sample As DPFP.Sample)
'        Dim caracteriscas As DPFP.FeatureSet = extrarcaracteristicas(sample, DPFP.Processing.DataPurpose.Enrollment)
'        If Not caracteriscas Is Nothing Then
'            Try
'                enrolar.AddFeatures(caracteriscas)
'                Dim text As New StringBuilder()
'                text.AppendFormat("Necesitas pasar el dedo {0} veces", enrolar.FeaturesNeeded)
'                mostrarveces(text.ToString)
'                Select Case enrolar.TemplateStatus
'                    Case DPFP.Processing.Enrollment.Status.Ready
'                        Me.template = enrolar.Template
'                        pararcaptura()
'                    Case DPFP.Processing.Enrollment.Status.Failed
'                        MessageBox.Show("error en la huella")
'                        enrolar.Clear()
'                        pararcaptura()
'                        iniciarcaptura()
'                End Select

'            Catch ex As Exception
'                MessageBox.Show(ex.Message)
'            Finally
'            End Try
'        End If
'    End Sub
'    Public Sub transladar_huella()

'    End Sub
'    '    private void button1_Click(object sender, EventArgs e)
'    '{
'    '    Form2 secondForm = new Form2();

'    '//Hacemos una conversión Cast del valor devuelto por la colección Controls.
'    '    ((PictureBox)secondForm.Controls["pictureBox2"]).Image = this.pictureBox1.Image;

'    '    secondForm.Show();
'    '}
'    '    Dim d As New OpenFileDialog
'    '        d.Filter = "Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg"
'    'If d.ShowDialog = DialogResult.OK Then
'    '    Dim bmp As New Bitmap(d.FileName)
'    '   PictureBox1.Image = CType(bmp, Image)
'    'End If
'    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
'        'frm_empleados.pic_huella.Image = CType(Me.pict_huella.Image, Image)
'        'frm_empleados.pic_huella.Refresh()
'        'frm_empleados.insertar_empleado()
'        Me.Hide()
'    End Sub
'End Class


