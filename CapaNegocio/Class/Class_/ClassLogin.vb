Imports MySql.Data.MySqlClient
Public Class ClassLogin
    Dim query As String
    Dim cnn As MySqlConnection
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Dim da As MySqlDataAdapter

    Public Function login(ByVal user As String, ByVal password As String) As Boolean
        Dim state As Boolean = True
        Try
            Dim cnn As MySqlConnection
            cnn = New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            cnn.Open()
            query = "select * from usuario where usuario ='" & user & "' and clave ='" & password & "';"
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count() = 0 Then
                state = False
            End If
            cnn.Close()
            cnn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cnn.Close()
            cnn = Nothing
        End Try
        Return state
    End Function
   
End Class
