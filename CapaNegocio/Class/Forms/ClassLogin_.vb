Imports MySql.Data.MySqlClient
Imports CapaDatos
Imports System.Windows.Forms
Public Class ClassLogin_
    Inherits ClassConexion
    Public username As String
    Dim query As String
    Dim cnn As New MySqlConnection
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim id As Integer
    Dim tipousuario As Integer
    Public Function login(ByVal user As String, ByVal password As String) As Boolean
        Dim state As Boolean = True
        Try
            cnn = conectar()
            query = "select idusuario, usuario, clave, idtipousuario from usuario where usuario ='" & user & "' and clave ='" & password & "';"
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count() = 0 Then
                state = False
            Else
            End If
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            If r.Read Then
                Me.username = Convert.ToString(r(1))
                Me.id = Convert.ToInt64(r(0))
                Me.tipousuario = Convert.ToInt64(r(3))
            End If
            cnn.Close()
            r.Close()
            cnn = Nothing
        Catch ex As Exception
            MessageBox.Show("No se podido conectar con el servidor", "servidor", MessageBoxButtons.OK)
            cnn.Close()
            cnn = Nothing
            Return state
        End Try
        Return state
    End Function
    Public Function getusername() As String
        Return Me.username
    End Function
    Public Function getid() As Integer
        Return Me.id
    End Function
    Public Function getipousuario() As Integer
        Return Me.tipousuario
    End Function
End Class
