Imports MySql.Data.MySqlClient
Imports CapaDatos
Imports System.Windows.Forms

Public Class ClassEmpresa
    Inherits ClassConexion
    Public razon As String
    Public direccion As String
    Public nit As String
    Public telefono As String
    Public email As String
    Dim query As String
    Dim cnn As New MySqlConnection
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Dim da As MySqlDataAdapter

    Public Function empresa(ByVal tabla As String) As Boolean
        Dim state As Boolean = True
        Try
            cnn = conectar()
            query = "select * from " + tabla + ";"
            da = New MySqlDataAdapter(query, cnn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count() = 0 Then
                state = False
            Else

            End If
            cmd = New MySqlCommand(query, cnn)
            Dim r As MySqlDataReader
            r = cmd.ExecuteReader
            If r.Read Then
                Me.razon = Convert.ToString(r(1))
                Me.direccion = Convert.ToString(r(2))
                Me.nit = Convert.ToString(r(3))
                Me.telefono = Convert.ToString(r(4))
                Me.email = Convert.ToString(r(5))
            End If
            cnn.Close()
            r.Close()
            cnn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cnn.Close()
            cnn = Nothing
        End Try
        Return state
    End Function
    Public Function geterazon() As String
        Return Me.razon
    End Function
    Public Function getdireccion() As String
        Return Me.direccion
    End Function
    Public Function getnit() As String
        Return Me.nit
    End Function
    Public Function gettelefono() As String
        Return Me.telefono
    End Function
    Public Function getemail() As String
        Return Me.email
    End Function


End Class
