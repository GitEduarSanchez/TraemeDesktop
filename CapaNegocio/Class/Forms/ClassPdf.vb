Imports System.IO
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports CapaDatos
Public Class ClassPdf
    Sub New()

    End Sub
    Dim exists As Boolean
    Dim objcnn As New CapaDatos.ClassConexion
    Dim cnn As New MySqlConnection
    Dim pdf As String
    Sub New(ByVal opd As OpenFileDialog, ByVal text As TextBox)
        Try
            With opd
                ' Comprobar que el archivo seleccionado existe.
                'El cuadro de diálogo muestra una advertencia en caso contrario.
                .CheckFileExists = True
                ' Comprobar que la ruta de acceso seleccionada existe.
                'El cuadro de diálogo muestra una advertencia en caso contrario.
                .CheckPathExists = True
                ' Obtener o establecer una extensión predeterminada.
                'No incluye el "." inicial.
                .DefaultExt = "pdf"
                .Filter = "Ficheros PDF (*.pdf)|*.pdf"
                .Multiselect = False
                ' ¿Restaurar el directorio original después de seleccionar un archivo? Si False, el directorio actual cambia al directorio en el que seleccionó el archivo.
                ' Establézcalo como True para poner la carpeta actual de nuevo donde estaba cuando comenzó.
                ' El valor predeterminado es False.
                .RestoreDirectory = True
                .Title = "Seleccione el Fichero"
                ' ¿Aceptar sólo nombres de archivo Win32 válidos?
                .ValidateNames = True
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    text.Text = .FileName
                    'Me.AxAcroPDF1.src = .FileName
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "btnPath_Click", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Function lF_FicheroToByteArray(ByVal vsFichero As String) As Byte()
        ' abrir el archivo con un objeto stream
        Dim oFileStream As FileStream = New FileStream(vsFichero, FileMode.Open)
        ' crear un array byte que tenga el tamaño del archivo
        Dim aBytImagen() As Byte = New Byte(CInt(oFileStream.Length - 1)) {}
        ' leer con el stream el contenido del archivo y volcarlo al array
        oFileStream.Read(aBytImagen, 0, CInt(oFileStream.Length - 1))
        oFileStream.Close()
        Return aBytImagen
    End Function
    Sub New(ByVal id As Integer, ByVal campo As String, ByVal tabla As String, ByVal filtro As String)
        Try
            Dim byteaPdf() As Byte = Nothing


            Dim oFileStream As FileStream
            Dim Query As String = "Select " & campo & " From " & tabla & " Where " & filtro & " =@id"
            cnn = objcnn.conectar

            Dim cmd As New MySqlCommand(Query, cnn)
            cmd.Parameters.Add(New MySqlParameter("@id", Convert.ToInt64(id)))
            Dim r As MySqlDataReader = cmd.ExecuteReader()
            Do While r.Read()
                byteaPdf = CType(r(0), Byte())
            Loop

            exists = System.IO.File.Exists("C:\Users\USER\Documents\edwar.pdf")
            If exists = True Then
                pdf = "C:\Users\USER\Documents\edwar.pdf"
                System.IO.File.Delete("C:\Users\USER\Documents\edwar.pdf")
            End If

            oFileStream = New FileStream("C:\Users\USER\Documents\edwar.pdf", FileMode.CreateNew, FileAccess.Write)
            oFileStream.Write(byteaPdf, 0, byteaPdf.Length)
            oFileStream.Close()

            'MessageBox.Show("Documento generado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function getruta() As String
        Return pdf
    End Function
End Class
