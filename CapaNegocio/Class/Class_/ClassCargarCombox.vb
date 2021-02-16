Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class ClassCargarCombox
    Dim cnn As MySqlConnection
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim query As String
   
    Sub carga_combox(sender As ComboBox, campo As String, tabla As String)
        Try
            Dim cnn As MySqlConnection
            cnn = New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            cnn.Open()
            query = "select '" & campo & "' from '" & tabla & "' ;"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            sender.Items.Clear()
            Do While r.Read
                sender.Items.Add(r(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try

    End Sub
End Class
