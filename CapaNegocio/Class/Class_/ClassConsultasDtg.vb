Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class ClassConsultasDtg
    Dim cnn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim query As String
    Private dtg As DataGridView
    Private cob As ComboBox
    Private campo As String
    Private tabla As String
    Private filtro As String
    Private variable As TextBox
    Private text As TextBox
    Private sqlt As String
    Private sqln As String

    Sub New(ByVal dtg As DataGridView, ByVal cob As ComboBox, ByVal campo As String, ByVal tabla As String, ByVal filtro As String)
        Try
            Me.dtg = dtg
            Me.cob = cob
            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            Dim cnn As New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            cnn.Open()
            query = "select " & Me.campo & " from " & Me.tabla & " where " & Me.filtro & " like '" & Me.cob.Text & "%';"
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            With dtg
                .DataSource = dt
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "error ")
        End Try
    End Sub
    Sub New(ByVal dtg As DataGridView, ByVal text As TextBox, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal sqlt As String, ByVal sqln As String)
        Try
            Me.dtg = dtg
            Me.text = text
            Me.campo = campo
            Me.tabla = tabla
            Me.variable = variable
            Me.sqlt = sqlt
            Me.sqln = sqln
            Me.filtro = filtro
            If IsNumeric(Me.text.Text) Then
                Me.filtro = Me.sqln
            Else
                Me.filtro = Me.sqlt
            End If
            'MsgBox(sql)
            Dim cnn As New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            cnn.Open()
            query = "select " & Me.campo & " from " & Me.tabla & " where " & Me.filtro & " like '" & Me.text.Text & "%';"
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            With dtg
                .DataSource = dt
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "error ")
        End Try
    End Sub
    Function getdtg()
        Return dt
    End Function
End Class
