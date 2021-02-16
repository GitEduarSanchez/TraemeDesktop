'Imports MySql.Data.MySqlClient
'Imports System.IO

'Public Class Form1

'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        If Me.txtId.Text.Length = 0 Then
'            MessageBox.Show("Falta el identificador", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Return
'        End If
'        If Me.txtPath.Text.Length = 0 Then
'            MessageBox.Show("Falta la ruta del Fichero PDF", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Return
'        End If
'        Dim aBytFichero() As Byte = Nothing
'        If Me.txtPath.Text.Length > 0 Then
'            aBytFichero = lF_FicheroToByteArray(Me.txtPath.Text)
'        End If
'        Try
'            Dim lsQuery As String = "Insert Into pdf (idpdf, archivo) Values (@idpdf, @archivo)"
'            Dim msCadenaMySql = "data source=localhost;user id=root;password='';database=pdf"

'            Using loConexion As New MySqlConnection(msCadenaMySql)
'                ' crear comando
'                Using loComando As New MySqlCommand(lsQuery, loConexion)
'                    'añadir parametros al comando 
'                    loComando.Parameters.Add(New MySqlParameter("@idpdf", CInt(Me.txtId.Text)))
'                    loComando.Parameters.Add(New MySqlParameter("@archivo", aBytFichero))
'                    loConexion.Open()   ' abrir conexión
'                    loComando.ExecuteNonQuery()
'                End Using
'            End Using
'            MessageBox.Show("REGISTRO GRABADO", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Me.txtId.Text = ""
'            Me.txtPath.Text = ""
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        End Try
'    End Sub
'    Private Function lF_FicheroToByteArray(ByVal vsFichero As String) As Byte()
'        ' abrir el archivo con un objeto stream
'        Dim oFileStream As FileStream = New FileStream(vsFichero, FileMode.Open)
'        ' crear un array byte que tenga el tamaño del archivo
'        Dim aBytImagen() As Byte = New Byte(CInt(oFileStream.Length - 1)) {}
'        ' leer con el stream el contenido del archivo y volcarlo al array
'        oFileStream.Read(aBytImagen, 0, CInt(oFileStream.Length - 1))
'        oFileStream.Close()
'        Return aBytImagen
'    End Function

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        Try
'            With Me.dlgAbrirArchivo
'                ' Comprobar que el archivo seleccionado existe. El cuadro de diálogo muestra una advertencia en caso contrario.
'                .CheckFileExists = True
'                ' Comprobar que la ruta de acceso seleccionada existe. El cuadro de diálogo muestra una advertencia en caso contrario.
'                .CheckPathExists = True
'                ' Obtener o establecer una extensión predeterminada. No incluye el "." inicial.
'                .DefaultExt = "jpg"
'                .Filter = "Ficheros PDF (*.pdf)|*.pdf"
'                .Multiselect = False
'                ' ¿Restaurar el directorio original después de seleccionar un archivo? Si False, el directorio actual cambia al directorio en el que seleccionó el archivo.
'                ' Establézcalo como True para poner la carpeta actual de nuevo donde estaba cuando comenzó.
'                ' El valor predeterminado es False.
'                .RestoreDirectory = True
'                .Title = "Seleccione el Fichero"
'                ' ¿Aceptar sólo nombres de archivo Win32 válidos?
'                .ValidateNames = True
'                If .ShowDialog = Windows.Forms.DialogResult.OK Then
'                    Me.txtPath.Text = .FileName
'                    AxAcroPDF1.src = .FileName
'                End If
'            End With
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "btnPath_Click", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        End Try
'    End Sub

'    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
'        '' recuperamos el documento de la base de datos y lo pasamos a un fichero
'        Try
'            Dim aBytDocumento() As Byte = Nothing
'            Dim oFileStream As FileStream
'            Dim lsQuery As String = "Select archivo From pdf Where idpdf =@ID"
'            Using loConexion As New MySqlConnection("server=localhost;user id=root;password=;database=pdf")
'                loConexion.Open()
'                Using loComando As New MySqlCommand(lsQuery, loConexion)
'                    loComando.Parameters.Add(New MySqlParameter("@ID", Convert.ToInt64(Me.txtId.Text)))
'                    Using loDataReader As MySqlDataReader = loComando.ExecuteReader()
'                        Do While loDataReader.Read()
'                            aBytDocumento = CType(loDataReader("archivo"), Byte())
'                        Loop
'                    End Using
'                End Using
'            End Using
'            oFileStream = New FileStream("C:\archivo" & Convert.ToInt64(Me.txtId.Text) & ".pdf", FileMode.CreateNew, FileAccess.Write)
'            oFileStream.Write(aBytDocumento, 0, aBytDocumento.Length)
'            oFileStream.Close()
'            Dim ArchivoBorrar As String
'            ArchivoBorrar = "c:\archivo" & Convert.ToInt64(Me.txtId.Text) & ".pdf"
'            If System.IO.File.Exists(ArchivoBorrar) = True Then
'                System.IO.File.Delete(ArchivoBorrar)
'            End If

'            oFileStream = New FileStream("C:\archivo" & Convert.ToInt64(Me.txtId.Text) & ".pdf", FileMode.CreateNew, FileAccess.Write)
'            oFileStream.Write(aBytDocumento, 0, aBytDocumento.Length)
'            oFileStream.Close()
'            Me.AxAcroPDF1.src = "D:\archivo" & Convert.ToInt64(Me.txtId.Text) & ".pdf"


'            'MessageBox.Show("Documento generado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        End Try
'    End Sub

'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        WindowState = FormWindowState.Maximized
'    End Sub
'End Class
