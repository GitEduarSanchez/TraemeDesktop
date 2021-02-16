Imports System.Windows.Forms

Public Class ClassTooltip
    Public Sub ayuda_boton(ByVal titulo As String, ByVal objeto As Object, ByVal mensaje As String)
        Dim boton As New ToolTip()
        boton.ToolTipTitle = titulo
        boton.UseFading = True
        boton.UseAnimation = True
        boton.IsBalloon = True
        boton.ShowAlways = True
        boton.AutoPopDelay = 5000
        boton.InitialDelay = 1000
        boton.ReshowDelay = 500
        boton.SetToolTip(objeto, mensaje)
    End Sub
    
End Class