Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports CapaDatos
Public Class ClassConsultarFechas
    Inherits ClassConexion
    Dim cnn As New MySqlConnection
    Dim dt As DataTable
    Dim cmd As New MySqlCommand
    Dim r As MySqlDataReader
    Dim da As New MySqlDataAdapter
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
    Private documento As String
    Private documento_ As String
    Private centro As String
    Private mina As String
    Private centro_ As String
    Private mina_ As String

    Sub New(ByVal dtg As DataGridView,
           ByVal desde As DateTimePicker,
           ByVal hasta As DateTimePicker,
           ByVal campo As String,
           ByVal tabla As String,
           ByVal filtro As String,
           ByVal placa As String,
           ByVal movimiento As String,
           ByVal origen As String,
           ByVal producto As String,
           ByVal titulo As String,
           ByVal despachador As String,
           ByVal destino As String,
           ByVal status As String)

        Try
            Me.desde = desde
            Me.hasta = hasta
            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            Me.dtg = dtg

            Dim x As String = DateAdd(DateInterval.Day, -1, Me.desde.Value.Date)
            Dim fecha As Date = x
            Dim fechaformada As String
            'fechaformada = fecha.ToString("yyyy-MM-dd HH:MM:SS")
            fechaformada = fecha.ToString("yyyy-MM-dd")
            Dim x1 As String = Me.hasta.Value.Date
            Dim fecha1 As Date = x1
            Dim fechaformada1 As String
            'fechaformada1 = fecha1.ToString("yyyy-MM-dd HH:MM:SS")
            fechaformada1 = fecha1.ToString("yyyy-MM-dd")
            cnn = conectar()
            query = "SELECT " & Me.campo & " from " & Me.tabla & " WHERE " & Me.filtro & " >= '" _
                & fechaformada & "' and " & Me.filtro & " <= '" & fechaformada1 & "'"
            If placa <> String.Empty Then
                query += "and placa ='" & placa & "'"
            End If
            If movimiento <> String.Empty Then
                query += "and movimiento ='" & movimiento & "'"
            End If
            If origen <> String.Empty Then
                query += "and origen ='" & origen & "'"
            End If
            If producto <> String.Empty Then
                query += "and producto ='" & producto & "'"
            End If
            If titulo <> String.Empty Then
                query += "and titulo ='" & titulo & "'"
            End If
            If despachador <> String.Empty Then
                query += "and despachador ='" & despachador & "'"
            End If
            If destino <> String.Empty Then
                query += "and destino ='" & destino & "'"
            End If
            If status <> String.Empty Then
                query += "and status ='" & status & "'"
            End If
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
    Function getdatetable()
        Return Me.dt
    End Function
End Class
