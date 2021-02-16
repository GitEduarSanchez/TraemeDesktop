Imports MySql.Data.MySqlClient

Public Class ClassCobId
    Private cob As ComboBox
    Private campo As String
    Private tabla As String
    Private filtro As String
    Private id As Integer
    Dim cnn As MySqlConnection
    Dim query As String
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader

    Sub New(ByVal cob As ComboBox, ByVal campo As String, ByVal tabla As String, ByVal filtro As String)
        Try
            Me.cob = cob
            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            Dim cnn As MySqlConnection
            cnn = New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            cnn.Open()
            query = "SELECT " + Trim(Me.campo) + " FROM " + Trim(Me.tabla) + " WHERE " + Trim(Me.filtro) + "='" & Me.cob.Text & "';"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            If r.Read Then
                id = r(0)
            End If
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try

    End Sub
    Function getid()
        Return id
    End Function
End Class
