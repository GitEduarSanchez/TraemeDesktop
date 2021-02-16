'Imports System.Web.RegularExpressions
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class ClassEmail
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna false si la direccion es incorrecta  
        Return Regex.IsMatch(sMail,
                  "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Private Sub ValidateEmailAddress(ByVal txt As TextBox)

        If txt.TextLength = 0 Then
            Throw New Exception("Debes rectificar la direccion de correo electronico")
        Else

            If txt.Text.IndexOf(".") = -1 Or txt.Text.IndexOf("@") = -1 Then
                Throw New Exception("Debes rectificar la direccion de correo electronico " &
                    "formato de direccion." & ControlChars.Cr & "por ejemplo " &
                    "'ejemplo@outlook.com'")
            End If
        End If
    End Sub
End Class
