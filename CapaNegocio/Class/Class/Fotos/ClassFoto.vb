'Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ClassFoto
    'Dim cnn As MySqlConnection
    'Dim dt As DataTable
    'Dim cmd As MySqlCommand
    'Dim r As MySqlDataReader
    'Dim da As MySqlDataAdapter
    'Dim query As String
    Sub New(ByVal ofd As OpenFileDialog, ByVal sender As TextBox, ByVal p As PictureBox)
        Try
            With ofd
                '.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
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
    Sub New(ByVal ofd As OpenFileDialog, ByVal f As Form)
        Try
            With ofd
                .Filter = ("Archivo pdf|*.pdf")
                .FilterIndex = 1
                .Title = "Selecciona un archivo pdf"
                .FileName = String.Empty
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                If .ShowDialog = DialogResult.OK Then
                    'pdf.src = .FileName
                    f.ShowDialog()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try
    End Sub
    'Sub cargar_foto(ByVal id As TextBox, ByVal foto As TextBox, ByVal p As PictureBox)
    '    Try
    '        Dim ruta As String = ""
    '        Dim cnn As MySqlConnection
    '        cnn = New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
    '        cnn.Open()
    '        query = "select foto  from vista_estudiante where id='" & id.Text & "';"
    '        cmd = New MySqlCommand(query, cnn)
    '        Dim r As MySqlDataReader
    '        r = cmd.ExecuteReader
    '        If r.Read Then
    '            foto.Text = r(0)
    '            ruta = "C:\Users\Public\Documents\fotos\" & foto.Text & ""
    '        End If
    '        p.Image = Image.FromFile(ruta)
    '        p.SizeMode = PictureBoxSizeMode.StretchImage
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
    '    End Try
    'End Sub
    Sub New(ByVal pict As PictureBox)

    End Sub
    'Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
    '    Dim file As New OpenFileDialog()
    '    file.Filter = "Archivo JPG|*.jpg"
    '    If file.ShowDialog() = DialogResult.OK Then
    '        pictureBox1.Image = Image.FromFile(file.FileName)
    '    End If
    'End Sub
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function
    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class