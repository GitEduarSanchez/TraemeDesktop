Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports CapaDatos
Public Class ClassPolimorfismoGetid
    Inherits ClassConexion
    Private cob As ComboBox
    Private campo As String
    Private tabla As String
    Private filtro As String
    Private busqueda As String
    Private id As Integer
    Private reg As String
    Dim cnn As New MySqlConnection
    Dim query As String
    Dim cmd As New MySqlCommand
    Dim r As MySqlDataReader

    Sub New(ByVal cod As String, ByVal campo As String, ByVal tabla As String)
        Try

            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            cnn = conectar()
            query = "SELECT " + Trim(Me.campo) + " as suma FROM " + Trim(Me.tabla) + " WHERE codigo ='" & cod & "';"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            If r.Read Then
                id = Convert.ToInt64(r("suma"))
            End If
            cnn.Close()
            r.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try

    End Sub
    Sub New(ByVal cob As ComboBox, ByVal campo As String, ByVal tabla As String, ByVal filtro As String)
        Try
            Me.cob = cob
            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            cnn = conectar()
            query = "SELECT " + Trim(Me.campo) + " FROM " + Trim(Me.tabla) + " WHERE " + Trim(Me.filtro) + "='" & Me.cob.Text & "';"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            If r.Read Then
                id = r(0)
            End If
            cnn.Close()
            r.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try

    End Sub
    Sub New(ByVal documento As String, ByVal campo As String, ByVal tabla As String, ByVal filtro As String)
        Try
            Me.busqueda = documento
            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            cnn = conectar()
            query = "SELECT " + Trim(Me.campo) + " FROM " + Trim(Me.tabla) + " WHERE " + Trim(Me.filtro) + "='" & Me.busqueda & "';"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            If r.Read Then
                id = r(0)
            End If
            cnn.Close()
            r.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try

    End Sub
    Sub New(ByVal documento As String, ByVal campo As String, ByVal tabla As String, ByVal filtro As String, ByVal pos As Boolean)
        Try
            Me.busqueda = documento
            Me.campo = campo
            Me.tabla = tabla
            Me.filtro = filtro
            cnn = conectar()
            query = "SELECT " + Trim(Me.campo) + " FROM " + Trim(Me.tabla) + " WHERE " + Trim(Me.filtro) + "='" & Me.busqueda & "';"
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            If r.Read Then
                reg = r(0)
            End If
            cnn.Close()
            r.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Information, "rectifica")
        End Try
    End Sub

    Function getid()
        Return id
    End Function
    Function getregistro()
        Return reg
    End Function


End Class
