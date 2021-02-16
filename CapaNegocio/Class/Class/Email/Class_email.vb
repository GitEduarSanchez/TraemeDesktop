Imports System.Text.RegularExpressions

Public Class Class_email
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                  "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Private Sub ValidateEmailAddress(ByVal txt As TextBox)

        If txt.TextLength = 0 Then
            Throw New Exception("Email address is a required field")
        Else

            If txt.Text.IndexOf(".") = -1 Or txt.Text.IndexOf("@") = -1 Then
                Throw New Exception("E-mail address must be valid e-mail " & _
                    "address format." & ControlChars.Cr & "For example " & _
                    "'someone@microsoft.com'")
            End If
        End If
    End Sub
    'Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
    'With odlgAttachment
    '    .InitialDirectory = "C:\"
    '    .Filter = "All Files (*.*)|*.*|HTML Files (*.htm;*.html)|*.htm|Microsoft Mail Documents (*.msg)|*.msg|Word Documents (*.doc)|*.doc|Excel Files(*.xl*)|*.xl*|Excel Worksheets (*.xls)|*.xls|Excel Charts (*.xlc)|*.xlc|PowerPoint Presentations (*.ppt)|*.ppt|Text Files (*.txt)|*.txt"
    '    .FilterIndex = 1


    '    If .ShowDialog() = DialogResult.OK Then
    '        If IsNothing(arlAttachments) Then
    '            arlAttachments = New ArrayList()
    '            lstAttachments.Items.Clear()
    '        End If
    '        arlAttachments.Add(New MailAttachment(.FileName))

    '        Dim strFileName() As String = .FileName.Split(New Char() {CChar("\")})
    '        strFileName.Reverse(strFileName)
    '        lstAttachments.Items.Add(strFileName(0))
    '    End If
    'End With
    'End Sub
    'Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

    '    Try
    '        ValidateEmailAddress(txtFrom)
    '    Catch ex As Exception
    '        txtFrom.Select(0, txtFrom.Text.Length)

    '        erpEmailAddresses.SetError(txtFrom, ex.Message)
    '        Exit Sub
    '    End Try

    '    Try
    '        ValidateEmailAddress(txtTo)
    '    Catch exp As Exception
    '        txtTo.Select(0, txtTo.Text.Length)

    '        erpEmailAddresses.SetError(txtTo, exp.Message)
    '        Exit Sub
    '    End Try

    '    Dim sb As New StringBuilder

    '    sb.Append("Correo enviado por la aplicación ENVIO DE CORREOS, " & _
    '        "")
    '    sb.Append(vbCrLf)
    '    sb.Append(vbCrLf)
    '    sb.Append("SUBJECT: ")
    '    sb.Append(Trim(txtSubject.Text))
    '    sb.Append(vbCrLf)
    '    sb.Append(vbCrLf)
    '    sb.Append("MESSAGE: ")
    '    sb.Append(Trim(txtBody.Text))
    '    sb.Append(vbCrLf)


    '    Dim mailMsg As New MailMessage
    '    With mailMsg
    '        .From = txtFrom.Text.Trim
    '        .To = txtTo.Text.Trim
    '        .Cc = txtCC.Text.Trim
    '        .Bcc = txtBCC.Text.Trim
    '        .Subject = txtSubject.Text.Trim
    '        .Body = sb.ToString
    '        .Priority = CType(cboPriority.SelectedIndex, MailPriority)

    '        If Not IsNothing(arlAttachments) Then
    '            Dim mailAttachment As Object
    '            For Each mailAttachment In arlAttachments
    '                .Attachments.Add(mailAttachment)
    '            Next
    '        End If
    '    End With

    '    Try
    '        SmtpMail.Send(mailMsg)
    '        lstAttachments.Items.Clear()
    '        lstAttachments.Items.Add("(No Adjuntado)")

    '        MessageBox.Show("Correo enviado satisfactoriamente!", _
    '            "Status del Envio", MessageBoxButtons.OK, _
    '            MessageBoxIcon.Information)
    '    Catch exp As Exception
    '        MessageBox.Show("Ha ocurrido un problema, al intentar enviar el mensaje, " & _
    '         "intente de nuevo o " & exp.Message, _
    '          Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class
