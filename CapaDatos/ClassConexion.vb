Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Configuration.ConfigurationManager
Public Class ClassConexion
    Dim cnn As New MySqlConnection
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim query As String
    'funcion que devuelve la conexion mysql
    '*********************************************
    Public Function conectar() As MySqlConnection
        Try
            '192.99.201.31
            cnn = New MySqlConnection("server=localhost;Port=3306;user id=root;password=;database=traeme_express") 'local
            'cnn = New MySqlConnection("server=192.168.0.119;Port=3306;user id=vallesar;password=1091658551edwar20;database=prueba") 'local-cliente servidor
            'cnn = New MySqlConnection(ConfigurationManager.ConnectionStrings("cnn").ConnectionString)
            'cnn = New MySqlConnection()
            'cnn = New MySqlConnection("server='isasport.com.co';user id='isasport_isa';password='1091658551edwar20';database='isasport_macondo'") 'servidor
            'cnn = New MySqlConnection("server='198.50.152.66';user id='isasport_isa';password='1091658551edwar20';database='isasport_bascula'") 'servidor
            ''cnn.ConnectionString = myconecctionstring
            'cnn = New MySqlConnection(myconecctionstring)
            ' <add name="cnn"
            ' connectionString="server=127.0.0.1;Port=3306;user id=root;password=;database=bascula" providerName="Mysql.Data.MysqlClient" />
            cnn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return cnn
    End Function
    Public Sub cerre_conexion()
        cnn.Close()
    End Sub
    Public Sub desconexion()
        cnn.Close()
    End Sub
End Class
