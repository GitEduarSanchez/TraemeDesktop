Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports CapaDatos
Imports System.Web.UI.WebControls
Public Class ClassPolimorfismoSearch
    Inherits ClassConexion
    Dim cnn As MySqlConnection
    Dim query As String
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Private cob As ComboBox
    Private dro As DropDownList
    Private campo As String
    Private tabla As String
    Private filtro As String
    Private busqueda As String
    Private _dropDownList As DropDownList
   

    Sub New()
    End Sub
    Sub New(ByVal cob As DropDownList, ByVal campo As String, ByVal tabla As String, ByVal web As Boolean)
        Try
            Me.campo = campo
            Me.tabla = tabla
            Me.dro = cob
            cnn = conectar()
            query = "select distinct " & Me.campo & " from " & Me.tabla & ";"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            Me.dro.Items.Clear()
            Do While r.Read
                Me.dro.Items.Add(r(0))
            Loop
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try
    End Sub
    Sub New(ByVal cob As ComboBox, ByVal campo As String, ByVal tabla As String)
        Try
            Me.campo = campo
            Me.tabla = tabla
            Me.cob = cob
            cnn = conectar()
            query = "select distinct " & Me.campo & " from " & Me.tabla & ";"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            Me.cob.Items.Clear()
            Do While r.Read
                Me.cob.Items.Add(r(0))
            Loop
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try
    End Sub
    Sub New(ByVal cob As ComboBox, ByVal query As String, ByVal tabla As String, ByVal resolucion As Boolean)
        Try
            Me.campo = query
            Me.tabla = tabla
            Me.cob = cob
            cnn = conectar()
            query = "select  " & Me.campo & " from " & Me.tabla & ";"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            Me.cob.Items.Clear()
            Do While r.Read
                Me.cob.Items.Add(r(0))
            Loop
            cnn.Close()
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
            cnn = conectar()
            query = "select distinct " & Me.campo & " from " & Me.tabla & " where " & Me.filtro & " =" & Me.busqueda & ";"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            Me.cob.Items.Clear()
            Do While r.Read
                Me.cob.Items.Add(r(0))
            Loop
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try
    End Sub

    

    Function getcob()
        Return Me.cob
    End Function


End Class
