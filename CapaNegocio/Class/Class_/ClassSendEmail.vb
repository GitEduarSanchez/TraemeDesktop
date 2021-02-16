Imports System.Net.Mail
Imports System.Net
Imports System.Windows.Forms
Public Class ClassSendEmail
    Sub New(ByVal email As String, ByVal pass As String, ByVal de As String, ByVal para As String, ByVal adj As String, ByVal asun As String, ByVal msj As String)
        Try
            'instancio la variable del mensaje
            '-----------------------------------------------
            Dim mensaje As New MailMessage
            'indica la direccion del email remitente
            '-----------------------------------------------
            mensaje.From = New MailAddress(email)
            'inidca el motivo del msj 
            '----------------------------------------------
            mensaje.Subject = asun
            'inidica la direccion del destinatario
            '----------------------------------------------
            mensaje.To.Add(para)
            'indica el cuerpo o texto del mensaje
            mensaje.Body = msj
            'ahora adjuntamos el archivo
            '---------------------------------------------
            Dim adjuntar As New Net.Mail.Attachment(adj)
            'añadimos el mensaje adjunto al mensaje
            '--------------------------------------------
            mensaje.Attachments.Add(adjuntar)
            'ahora ajustamos el servidor
            '--------------------------------------------
            'servidor 
            'sirve para determinar el protocolo de transferencia
            '--------------------------------------------
            Dim smtp As New SmtpClient
            'configuramos la prioridad del email
            '--------------------------------------------
            mensaje.Priority = MailPriority.Normal
            'creamos un cifrado
            '-------------------------------------------
            smtp.EnableSsl = True
            'habilitamos el puerto
            '-------------------------------------------
            smtp.Port = "587"
            'creamos la opcion de hotmail, outlook
            'para gmail es smtp.gmail.com o yahoo es otra dirreccion
            '------------------------------------------
            smtp.Host = "smtp.live.com"
            'ahora autenticamos el usuario y la contraseña para la credencial
            '------------------------------------------
            smtp.Credentials = New Net.NetworkCredential(email, pass)
            'al finalizar todo enviamos el codigo
            '----------------------------------------
            smtp.Send(mensaje)

            MsgBox("correo electronico enviado con exito", MsgBoxStyle.Information, "ok")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ok", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MsgBox("No se pudo enviar el correo electrónico, comprueba la coneccion a internet o verifica que la dirección de correo de remitente y destinatario esten bien escrita", MsgBoxStyle.Critical, "rectifica")
        End Try
    End Sub
    'Public Function buscar_adjunto() As String
    '    Try
    '    Dim abrir As New OpenFileDialog
    '    Dim str_archivo As String
    '    abrir.Title = "Buscar Archivo?"
    '    abrir.Filter = "Archivos de datos |*.*"
    '    If abrir.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        str_archivo = abrir.FileName
    '        If (IO.Path.GetExtension(str_archivo) = ".exe") Then
    '            MessageBox.Show("El archivo a adjuntar no debe de ser ejecutable", _
    '                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Return False
    '            Exit Function
    '        Else
    '            Return str_archivo
    '        End If
    '        Return str_archivo
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Function
    Sub enviar_email_todos_contactos()
        'Dim sql As New MySqlCommand("select correo_electronico  from contratos", cn)
        'Dim da As New MySqlDataAdapter
        'da.SelectCommand = sql
        'Dim dt As New DataTable
        'da.Fill(dt)

        'Dim numeros = dt.Rows.Count() - 1

        'For i = 0 To numeros
        '    Dim row As DataRow = dt.Rows(i)

        '    txtPara.Text = txtPara.Text & CStr(row("correo_electronico")) + ","

        'Next
    End Sub
    Sub enviar_mail()
        Try
            'mail.To.Clear()
            'mail.Body = ""
            'mail.Subject = ""
            'mail.Body = Me.txtMensaje.Text
            'mail.Subject = Me.txtAsunto.Text
            'mail.IsBodyHtml = True
            'mail.To.Add(Trim(Me.txtPara.Text))
            'mail.Attachments.Add(New Attachment(lblAdjunto.Text))
            'mail.From = New MailAddress(Me.txtDe.Text.Trim, "[Enviado por:]" & txtDe.Text)

            'If cboMail.SelectedIndex = 1 Then
            '    direccioncompleta = txtCorreo.Text & "@gmail.com"

            'ElseIf cboMail.SelectedIndex = 2 Then
            '    direccioncompleta = txtCorreo.Text & "@hotmail.com"

            'End If
            'send.Credentials = New NetworkCredential(direccioncompleta, Me.txtContraseña.Text.Trim)

            'If cboMail.SelectedIndex = 1 Then
            '    send.Host = "smtp.gmail.com"
            '    send.Port = 587
            '    send.EnableSsl = True
            'End If
            'If cboMail.SelectedIndex = 2 Then
            '    send.Host = "smtp.live.com"
            '    send.Port = 587
            '    send.EnableSsl = True
            'End If
            'send.Send(mail)

            'Me.Cursor = Cursors.Default
            'Me.Text = "Enviar Mensaje"
            'MsgBox("El mensaje fue enviado correctamente", MsgBoxStyle.Information, "Mensaje")

            'txtAsunto.Text = String.Empty
            'txtPara.Text = String.Empty
            'txtMensaje.Text = String.Empty
            'lblAdjunto.Text = String.Empty
            'str_archivo = ""
            'btnAdjuntar.Enabled = True
            'btnCancelarAdjunto.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
