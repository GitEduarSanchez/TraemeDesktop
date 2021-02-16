Public Class ClassValidaciones
    Sub New(ByVal f As Form)
        '---------------------------------------------------------------------------
        '-------- recorrer todos los controles del formulario indicado  ------------
        '***************************************************************************
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                If String.IsNullOrEmpty(c.Text) Then
                    MessageBox.Show("'" + c.Name + "'")
                    c.Focus()
                    c.BackColor = Color.Aquamarine
                    MessageBox.Show("empty", "rectifica", MessageBoxButtons.OK)
                    ' Exit Sub
                Else
                    c.BackColor = Color.White
                End If
            End If
            If TypeOf c Is ComboBox Then
            End If
            If TypeOf c Is PictureBox Then
            End If
        Next
    End Sub
    Sub New(ByVal f As Form, ByVal t1 As TextBox, ByVal t2 As TextBox)
        '---------------------------------------------------------------------------
        '-------- recorrer todos los controles del formulario indicado  ------------
        '***************************************************************************
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                If t1.Text = String.Empty Then
                    MessageBox.Show("'" + c.Name + "'")
                    c.Focus()
                    c.BackColor = Color.Aquamarine
                    'MessageBox.Show("empty", "rectifica", MessageBoxButtons.OK)
                    Exit Sub
                Else
                    c.BackColor = Color.White
                End If
            End If
            If TypeOf c Is ComboBox Then
            End If
            If TypeOf c Is PictureBox Then
            End If
        Next
    End Sub
End Class
