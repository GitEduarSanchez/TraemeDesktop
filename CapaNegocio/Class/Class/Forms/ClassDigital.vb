Public Class ClassDigital
    Private lbl As Label
    Sub New(ByVal lbl As Label)
        Me.lbl = lbl
        Me.lbl.Text = Mid(Me.lbl.Text, 2) + Microsoft.VisualBasic.Left(Me.lbl.Text, 1)
    End Sub
   
    Public Function getdig()
        Return Mid(Me.lbl.Text, 2) + Microsoft.VisualBasic.Left(Me.lbl.Text, 1)
    End Function
End Class
