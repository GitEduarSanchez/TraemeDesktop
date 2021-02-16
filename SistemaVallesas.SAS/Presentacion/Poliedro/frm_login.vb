
Public Class frm_login
    Public Shared username As String
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Normal
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As New CapaNegocio.ClassLogin_
        Try
        If login.login(Me.txt_usuario.Text, Me.txt_clave.Text) Then
            username = login.getusername
                'user = login.getusername
                '    iduser = login.getid
                '    tipousuario = login.getid
            Me.Hide()
            MDIParent1.ShowDialog()
                Me.Close()
            Else
            End If
            MessageBox.Show("Acceso Denegado", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
          
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class