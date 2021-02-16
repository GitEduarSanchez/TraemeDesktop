Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports CapaDatos
Imports System.Web.UI.WebControls
Public Class ClassConsultarDtg
    Inherits ClassConexion
    Dim cnn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Public dt As New DataTable
    Dim cmd As New MySqlCommand
    Dim query As String
    Private dtg As DataGridView
    Private cob As ComboBox
    Private campo As String
    Private tabla As String
    Private filtro As String
    Private variable As System.Windows.Forms.TextBox
    Private text As String
    Private sqlt As String
    Private sqln As String
    Private orden As String
    Private dtg_web As GridView
    Sub New(ByVal dtg As DataGridView, ByVal cob As ComboBox, ByVal campo As String, ByVal tabla As String, ByVal filtro As String)
        Try
            Me.dtg = dtg
            Me.cob = cob
            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            cnn = conectar()
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
    Sub New(ByVal dtg As DataGridView, ByVal cob As ComboBox, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal movimiento As String)
        Try
            Me.dtg = dtg
            Me.cob = cob
            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            cnn = conectar()
            query = "select " & Me.campo & " from " & Me.tabla & " where   movimiento ='" & movimiento & "' and " & Me.filtro & "  like '" & Me.cob.Text & "%';"
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
    Sub New(ByVal text As String, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal array As Boolean)
        Try
            Me.dtg = dtg
            Me.text = text
            Me.campo = campo
            Me.tabla = tabla
            Me.variable = variable
            Me.sqlt = sqlt
            Me.sqln = sqln
            Me.filtro = filtro
            cnn = conectar()
            query = "select " & Me.campo & " from " & Me.tabla & " where " & Me.filtro & " like '" & Me.text & "%';"
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            'For Each reg In dt.Rows
            '    MessageBox.Show(DataTable(reg))
            'Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "error ")
        End Try
    End Sub
    Sub New(ByVal dtg As DataGridView, ByVal text As String, ByVal campo As String, ByVal tabla As String, ByVal filtro As String)
        Try
            Me.dtg = dtg
            Me.text = text
            Me.campo = campo
            Me.tabla = tabla
            Me.variable = variable
            Me.sqlt = sqlt
            Me.sqln = sqln
            Me.filtro = filtro
            cnn = conectar()
            query = "select " & Me.campo & " from " & Me.tabla & " where " & Me.filtro & " like '" & Me.text & "%';"
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
   
    Sub New(ByVal dtg As DataGridView, ByVal text As String, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal colum As String, ByVal stado As String)
        Try
            Me.dtg = dtg
            Me.text = text
            Me.campo = campo
            Me.tabla = tabla
            Me.variable = variable
            Me.sqlt = sqlt
            Me.sqln = sqln
            Me.filtro = filtro
            cnn = conectar()
            query = "select " & Me.campo & " from " & Me.tabla & " where " & Me.filtro & " like '" & Me.text & "%' and " & colum & " = '" & stado & "';"
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
    Sub New(ByVal dtg As DataGridView, ByVal factura As Integer, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal order As String)
        Try
            Me.dtg = dtg
            Me.text = text
            Me.campo = campo
            Me.tabla = tabla
            Me.variable = variable
            Me.sqlt = sqlt
            Me.sqln = sqln
            Me.filtro = filtro
            Me.orden = orden
            cnn = conectar()
            query = "select " & Me.campo & " from " & Me.tabla & " where " & Me.filtro & " = '" & factura & "';"
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
    Sub New(ByVal dtg As DataGridView, ByVal status As String, ByVal movimiento As String, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal order As String, ByVal patron As String, ByVal bascula As Boolean)
        Try
            Me.dtg = dtg
            Me.text = text
            Me.campo = campo
            Me.tabla = tabla
            Me.variable = variable
            Me.sqlt = sqlt
            Me.sqln = sqln
            Me.filtro = filtro
            Me.orden = orden
            cnn = conectar()
            query = "select " & Me.campo & " from " & Me.tabla & " where status = '" & status & "' and movimiento ='" & movimiento & "' order by " & Me.filtro & " " & patron & ";"
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
    Sub New(ByVal dtg As DataGridView, ByVal status As String, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal order As String, ByVal patron As String, ByVal bascula As Boolean)
        Try
            Me.dtg = dtg
            Me.text = text
            Me.campo = campo
            Me.tabla = tabla
            Me.variable = variable
            Me.sqlt = sqlt
            Me.sqln = sqln
            Me.filtro = filtro
            Me.orden = orden
            cnn = conectar()
            query = "select " & Me.campo & " from " & Me.tabla & " where status = '" & status & "'  order by " & Me.filtro & " " & patron & ";"
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
    Sub New(ByVal dtg As DataGridView, ByVal tabla As String)
        Try
            Me.dtg = dtg
            Me.text = text
            Me.campo = campo
            Me.tabla = tabla
            Me.variable = variable
            Me.sqlt = sqlt
            Me.sqln = sqln
            Me.filtro = filtro
            cnn = conectar()
            query = "select * from " & Me.tabla & ";"
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
    'Sub New(ByVal dtg As DataGridView, ByVal _name As String, ByVal subconsulta As String)
    '    Try
    '        cnn = conectar()
    '        query = " SELECT * FROM v_full_kardex where codigo = select codigo from producto where producto=?; "
    '        da = New MySqlDataAdapter(query, cnn)
    '        dt = New DataTable
    '        da.Fill(dt)
    '        With dtg
    '            .DataSource = dt
    '            .AutoResizeColumns()
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "error ")
    '    End Try
    'End Sub
    'Sub New(ByVal dtg As DataGridView, ByVal status As String, ByVal tabla As String)
    '    Try
    '        Me.dtg = dtg
    '        Me.text = text
    '        Me.campo = campo
    '        Me.tabla = tabla
    '        Me.variable = variable
    '        Me.sqlt = sqlt
    '        Me.sqln = sqln
    '        Me.filtro = filtro
    '        cnn = conectar()
    '        query = "select * from " & Me.tabla & " where status like '" & status & "%';"
    '        da = New MySqlDataAdapter(query, cnn)
    '        dt = New DataTable
    '        da.Fill(dt)
    '        With dtg
    '            .DataSource = dt
    '            .AutoResizeColumns()
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "error ")
    '    End Try
    'End Sub
    Sub New(ByVal dtg As DataGridView, ByVal campo As String, ByVal tabla As String)
        Try
            Me.dtg = dtg
            Me.text = text
            Me.campo = campo
            Me.tabla = tabla
            Me.variable = variable
            Me.sqlt = sqlt
            Me.sqln = sqln
            Me.filtro = filtro
            cnn = conectar()
            query = "select " & Me.campo & " from " & Me.tabla & ";"
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
    Sub New(ByVal dtg_web As GridView, ByVal campo As String, ByVal tabla As String)
        Try
            Me.dtg_web = dtg_web
            Me.text = text
            Me.campo = campo
            Me.tabla = tabla
            Me.variable = variable
            Me.sqlt = sqlt
            Me.sqln = sqln
            Me.filtro = filtro
            cnn = conectar()
            query = "select " & Me.campo & " from " & Me.tabla & ";"
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            With dtg_web
                .DataSource = dt
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "error ")
        End Try
    End Sub
    Function getdtg()
        Return dt
    End Function


End Class
