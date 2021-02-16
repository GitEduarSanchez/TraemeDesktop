Imports System.Net
Imports System.Windows.Forms
Imports CapaDatos
Imports System.Drawing
Imports MySql.Data.MySqlClient
Public Class frm_config
    Dim cnn As New MySqlConnection
    Dim objcnn As New CapaDatos.ClassConexion
    Dim cadena As New ClassConexionPortable
    Dim data As String
    Dim IP As New ClassIP
    Private Sub frm_config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bnt_probar_Click(sender As Object, e As EventArgs) Handles bnt_probar.Click
        Try


            If IP.EsIP(Me.txt_servidor.Text) = False Then
                MessageBox.Show("ip invalida")
                Exit Sub
            End If
            With Me.txt_servidor
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el ip del servidor", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            With Me.txt_db
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el nombre de la base de dato", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            With Me.txt_usuario
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el nombre de usuario", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            Data = "Server=" & txt_servidor.Text & ";Database=" & txt_db.Text & ";Uid=" & txt_usuario.Text & ";Pwd=" & txt_contraseña.Text & ""
            If cadena.ProbarConexion(Data) Then
                MessageBox.Show("ok")
            Else
                MessageBox.Show("faile")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            If IP.EsIP(Me.txt_servidor.Text) = False Then
                MessageBox.Show("ip invalida")
                Exit Sub
            End If
            With Me.txt_servidor
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el ip del servidor", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            With Me.txt_db
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el nombre de la base de dato", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            With Me.txt_usuario
                If .Text = String.Empty Then
                    MessageBox.Show("Debes indicar el nombre de usuario", "rectifica",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .Text = Convert.ToDouble(0)
                    .Focus()
                    .BackColor = Color.Aquamarine
                    Exit Sub
                Else
                    .BackColor = Color.White
                End If
            End With
            CapaDatos.My.Settings.cnn = "Server=" & txt_servidor.Text & ";Database=" & txt_db.Text & ";Uid=" & txt_usuario.Text & ";Pwd=" & txt_contraseña.Text & ""
            CapaDatos.My.Settings.Save()
            MessageBox.Show("La Conexion se guardo correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class