Imports System.Windows.Forms
Public Class ClassPosicionTamaño
    Sub New(ByVal t As TextBox, ByVal w As Integer, ByVal h As Integer)
        t.Multiline = True
        t.Size = New System.Drawing.Size(w, h)
    End Sub
    Sub New(ByVal f As Form, ByVal w As Integer, ByVal h As Integer, ByRef t As Integer)
        f.Top = t
        f.Left = (Screen.PrimaryScreen.WorkingArea.Width - f.Width) / 2
        f.Width = w
        f.Height = h

    End Sub
    ''Form1
    ''
    '    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    '    Me.ClientSize = New System.Drawing.Size(416, 294)
    '    Me.Controls.Add(Me.Button2)
    '    Me.Controls.Add(Me.TextBox2)
    '    Me.Controls.Add(Me.TextBox1)
    '    Me.Name = "Form1"
    '    Me.Text = "Form1"
    '    Me.ResumeLayout(False)
End Class
