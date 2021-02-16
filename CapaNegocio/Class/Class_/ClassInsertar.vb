Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class ClassInsertar
    Dim cnn As MySqlConnection
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim query As String

    Sub insertar(ByVal sender As TextBox)
        Try
            Dim cnn As MySqlConnection
            cnn = New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            query = "INSERT INTO `foto`(`id_foto`, `foto`) VALUES (null,'" & sender.Text & "');"
            cnn.Open()
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Registros guardados con exito", MsgBoxStyle.Information, "okey")
            sender.Text = String.Empty
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
            cnn.Close()
        End Try
    End Sub
End Class
