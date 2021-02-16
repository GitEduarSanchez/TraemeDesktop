Imports System.Drawing.Imaging
Imports System.IO

Public Class ClassFuncionImage
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
'  Imports System.Data.SqlClient
'Imports System.Configuration

'Module Datos
'    Public Function Cargar() As DataTable
'        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
'            Dim dt As New DataTable()
'            Dim query As String = "SELECT * FROM PERSONAS"
'            Dim cmd As New SqlCommand(query, conn)
'            Dim adap As New SqlDataAdapter(cmd)
'            adap.Fill(dt)
'            Return dt
'        End Using
'    End Function

'    Public Sub Insert(ByVal nombre As String, ByVal apellido As String, ByVal foto As Byte())
'        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
'            Dim query As String = "INSERT INTO Personas(nombre,apellido,foto) VALUES(@nombre,@apellido,@foto)"
'            Dim cmd As New SqlCommand(query, conn)

'            cmd.Parameters.AddWithValue("@nombre", nombre)
'            cmd.Parameters.AddWithValue("@apellido", apellido)
'            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto
'            conn.Open()
'            Try
'                cmd.ExecuteNonQuery()
'                MessageBox.Show("Registro Ingresado con Exito...")
'            Catch ex As Exception
'                MessageBox.Show(ex.ToString())
'            End Try
'        End Using
'    End Sub

'End Module