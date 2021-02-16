Imports MySql.Data.MySqlClient
Public Class ClassMaxID_
    Inherits CapaDatos.ClassConexion
    Dim cnn As MySqlConnection
    Dim query As String
    Dim cmd As MySqlCommand
    Dim id As Integer
    Dim campo As String
    Dim tabla As String
    Sub New(ByVal campo As String, ByVal tabla As String)
        Try
            Me.campo = campo
            Me.tabla = tabla
            Dim cnn As MySqlConnection
            cnn = conectar()
            query = "select max(" & Me.campo & ") from " & Me.tabla & ";"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            If r.Read Then
                Me.id = r(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try
    End Sub
    Function getid()
        Return Me.id
    End Function

End Class
