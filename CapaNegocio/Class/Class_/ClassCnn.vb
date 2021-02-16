'Imports MySql.Data.MySqlClient
'Public Class ClassCnn
'    Dim cnn As MySqlConnection
'    Dim dt As DataTable
'    Dim cmd As MySqlCommand
'    Dim r As MySqlDataReader
'    Dim da As MySqlDataAdapter
'    Dim query As String
'    Public Sub conexion()
'        Try
'            Dim cnn As MySqlConnection
'            ' My.Computer.FileSystem.CurrentDirectory 'ruta de carpeta debug 
'            cnn = New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
'            cnn.Open()
'        Catch ex As Exception
'            MessageBox.Show("Error en la coneccion a la base de datos", "Error...!!!", _
'                            MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub
'    Public Sub desconexion()
'        cnn.Close()
'    End Sub
'    'funcion que devuelve la conexion mysql
'    Public Function getcnn() As MySqlConnection
'        getcnn = cnn
'        Return getcnn
'    End Function
'End Class
'Imports MySql.Data.MySqlClient
'Public Class conexion

'    'aqui coloca tu cadena de conexion de xampp, wampp o lo que sea que uses
'    Private con As New MySqlConnection("server=localhost; user=root;password=pelon1976; database=sistema-matriculas")

'    'procedimiento que abre la conexion mysql
'    Public Sub conectar()
'        con.Open()
'    End Sub

'    'procedimiento quecierra la conexion mysql
'    Public Sub desconectar()
'        con.Close()
'    End Sub

'    'funcion que devuelve la conexion mysql
'    Function conex() As MySqlConnection
'        conex = con
'        Return conex
'    End Function

'End Class
'Public Class conexion
'    Public t, rol As Integer
'    Public nrol As String
'    Public idusuario As Integer
'    Dim colo As Boolean = False
'    Private Const user As String = "root"
'    Private Const server As String = "localhost"
'    Private Const pass As String = ""
'    Private Const db As String = "tutoriales"
'    Dim conexion As New MySqlConnection(datosserv)
'    Dim datosserv = "server=" & server & ";" &
'                "user id=" & user & ";" &
'                "password=" & pass & ";" &
'                 "database=" & db & ";"
'    'VALIDACION DE USUARIOS Y ROLES

'    'INSERTAR
'    Sub insertar(ByVal query As String)
'        Try
'            If Not conexion.State = ConnectionState.Open Then
'                conexion.ConnectionString = datosserv
'                conexion.Open()
'            End If
'            Dim comando As New MySqlCommand(query, conexion)
'            Dim adaptador = New MySqlDataAdapter(comando)
'            comando.ExecuteNonQuery()
'            conexion.Close()
'        Catch ex As Exception
'            'control.correo(ex.Message)
'            MsgBox(ex.Message)
'        End Try
'    End Sub
'    'ACTUALIZAR
'    Sub actualizar(ByVal query As String)
'        Try
'            If Not conexion.State = ConnectionState.Open Then
'                conexion.ConnectionString = datosserv
'                conexion.Open()
'            End If
'            Dim comando As New MySqlCommand(query, conexion)
'            Dim adaptador = New MySqlDataAdapter(comando)
'            comando.ExecuteNonQuery()
'            conexion.Close()
'        Catch ex As Exception
'            'control.correo(ex.Message)
'            MsgBox(ex.Message)
'        End Try
'    End Sub

'    Public Function param(ByVal procedimiento As String)
'        conexion.Open()
'        Dim comando As New MySqlCommand
'        'Dim i As Integer
'        Try
'            comando.CommandText = procedimiento
'            comando.CommandType = CommandType.StoredProcedure
'            comando.Connection = conexion
'            comando.ExecuteReader()
'            conexion.Close()
'            Return Nothing
'        Catch ex As Exception
'            MsgBox(ex.Message.ToString)
'            Return Nothing
'        End Try
'    End Function
'End Class