Imports MySql.Data.MySqlClient
Imports CapaDatos
Imports System.Windows.Forms

Public Class ClassGetConexion
    Inherits ClassConexion
    Dim cnn As MySqlConnection
    Dim f As New CapaDatos.frm_config
    Public Function getconexion() As MySqlConnection
        Try
            'cnn = getconextion()
            Return cnn
        Catch ex As Exception
            Return cnn
        End Try

    End Function
    Public Sub getconfig()
        Try
            f.ShowDialog()
        Catch ex As Exception
        End Try
        f.ShowDialog()
    End Sub
End Class
