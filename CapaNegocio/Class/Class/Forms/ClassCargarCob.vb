Imports MySql.Data.MySqlClient
Public Class ClassCargarCob
    Dim cnn As MySqlConnection
    Dim query As String
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Private cob As ComboBox
    Private campo As String
    Private tabla As String
    Private filtro As String
    Private busqueda As String
    Sub New(ByVal cob As ComboBox, ByVal campo As String, ByVal tabla As String)
        Try
            Me.campo = campo
            Me.tabla = tabla
            Me.cob = cob
            Dim cnn As MySqlConnection
            cnn = New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            cnn.Open()
            query = "select distinct " & Me.campo & " from " & Me.tabla & ";"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            Me.cob.Items.Clear()
            Do While r.Read
                Me.cob.Items.Add(r(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try
    End Sub
    Sub New(ByVal cob As ComboBox, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal busqueda As String)
        Try
            Me.campo = campo
            Me.tabla = tabla
            Me.cob = cob
            Me.filtro = filtro
            Me.busqueda = busqueda
            Dim cnn As MySqlConnection
            cnn = New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            cnn.Open()
            query = "select distinct " & Me.campo & " from " & Me.tabla & " where " & Me.filtro & " =" & Me.busqueda & ";"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            Me.cob.Items.Clear()
            Do While r.Read
                Me.cob.Items.Add(r(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try
    End Sub
    Function getcob()
        Return Me.cob
    End Function

End Class
