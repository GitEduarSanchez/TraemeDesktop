Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Windows.Forms
Public Class ClassConexionPortable
    Private ConexionBD As New MySqlConnection(My.Settings.cnn)
    Public Function ProbarConexion(ByVal nuevaconexion As String) As Boolean
        ConexionBD.ConnectionString = nuevaconexion
        If AbrirConexion() Then
            ProbarConexion = True
            CerrarConexion()
        Else
            ProbarConexion = False
        End If
    End Function

    Private Function AbrirConexion() As Boolean
        Try
            ConexionBD.Open()
            AbrirConexion = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            AbrirConexion = False
        End Try

    End Function

    Private Function CerrarConexion() As Boolean
        Try
            ConexionBD.Close()
            CerrarConexion = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CerrarConexion = False
        End Try

    End Function

End Class
