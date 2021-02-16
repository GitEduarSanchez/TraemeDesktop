Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class ClassFechas
    Dim cnn As MySqlConnection
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim query As String
    Private desde As DateTimePicker
    Private hasta As DateTimePicker
    Private campo As String
    Private tabla As String
    Private filtro As String
    Private order As String
    Private patron As String
    Private dtg As DataGridView
    Private cob As ComboBox



    Sub New(ByVal dtg As DataGridView, ByVal desde As DateTimePicker, ByVal hasta As DateTimePicker, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal order As String, ByVal patron As String)

        Try
            Me.desde = desde
            Me.hasta = hasta
            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            Me.order = order
            Me.patron = patron
            Me.dtg = dtg



            Dim x As String = Me.desde.Value.Date
            Dim fecha As Date = x
            Dim fechaformada As String
            fechaformada = fecha.ToString("yyyy-MM-dd")
            Dim x1 As String = Me.hasta.Value.Date
            Dim fecha1 As Date = x1
            Dim fechaformada1 As String
            fechaformada1 = fecha1.ToString("yyyy-MM-dd")

            Dim cnn As MySqlConnection
            cnn = New MySqlConnection("server=localhost;user id=root;password=;database=correspondencia_sena")
            cnn.Open()
            query = "SELECT " & Me.campo & " from " & Me.tabla & " WHERE " & Me.filtro & " >= '" _
                & fechaformada & "' and " & Me.filtro & " <= '" & fechaformada1 & "' ORDER BY  " & Me.order & "  " & Me.patron & ""
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            dtg.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "rectifica")
            cnn.Close()
        End Try
    End Sub
    Sub New(ByVal dtg As DataGridView, ByVal cob As ComboBox, ByVal campo As String, ByVal tabla As String, ByVal filtro As String)

        Try
            Me.cob = cob
            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            Me.order = order
            Me.patron = patron
            Me.dtg = dtg

            Dim cnn As New MySqlConnection("server=localhost;user id=root;password=;database=correspondencia_sena")
            cnn.Open()
            query = "select " & Me.campo & " from " & Me.tabla & " where " & Me.filtro & "  like '" & Me.cob.Text & "%' ;"
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            With dtg
                .DataSource = dt
                .AutoResizeColumns()
            End With
            cnn.Close()
            cnn = Nothing
            r = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "rectifica")
            cnn.Close()
        End Try
    End Sub
    Function getdt()
        Return Me.dt
    End Function
End Class
