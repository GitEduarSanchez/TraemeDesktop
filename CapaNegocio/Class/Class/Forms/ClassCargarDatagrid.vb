Imports MySql.Data.MySqlClient
Public Class ClassCargarDatagrid
    Dim cnn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim query As String
    Dim dt As DataTable
    Private dtg As DataGridView
    Private campo As String
    Private tabla As String
    Private order As String
    Private modo As String

    Sub New(ByVal dtg As DataGridView, ByVal campo As String, ByVal tabla As String, ByVal order As String, ByRef modo As String)

        Try
            Me.dtg = dtg
            Me.campo = campo
            Me.tabla = tabla
            Me.order = order
            Me.modo = modo
            Dim cnn As New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            cnn.Open()
            query = "select " & Me.campo & " from " & Me.tabla & " order by " & Me.order & " " & Me.modo & ";"
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            With Me.dtg
                .DataSource = dt
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "error ")
        End Try
    End Sub
    Sub New(ByVal dtg As DataGridView, ByVal campo As String, ByVal tabla As String)

        Try
            Me.dtg = dtg
            Me.campo = campo
            Me.tabla = tabla
            Dim cnn As New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            cnn.Open()
            query = "select " & Me.campo & " from " & Me.tabla & ";"
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            With Me.dtg
                .DataSource = dt
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "error ")
        End Try
    End Sub
    Function getcdtg()
        Return Me.dt
    End Function
    Sub recorrer_gatagrid()
        'For Each row As DataGridViewRow In dgvLineaCompra.Rows
        '    '
        '    ' inicializo las linea de error
        '    ' en caso de tener un mensaje de error previo
        '    '
        '    row.ErrorText = ""

        '    '
        '    ' se validan los campos de la fila
        '    '
        '    If String.IsNullOrEmpty(Convert.ToString(row.Cells("Track").Value)) Then
        '        row.ErrorText = "Debe seleccionar in item de compra."
        '        result = False
        '    End If

        '    If String.IsNullOrEmpty(Convert.ToString(row.Cells("Cantidad").Value)) Then
        '        row.ErrorText = "Debe ingresar una cantidad"
        '        result = False
        '    Else
        '        Dim cantidad As Integer = 0
        '        If Not Int32.TryParse(Convert.ToString(row.Cells("Cantidad").Value), cantidad) Then
        '            row.ErrorText = "La cantidad ingresada debe ser un valor numerico"
        '            result = False
        '        End If

        '    End If
        'Next
    End Sub
End Class
