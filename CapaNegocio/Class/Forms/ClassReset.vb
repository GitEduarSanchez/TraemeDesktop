Imports System.Windows.Forms

Public Class ClassReset
    Public Sub Reset(ByVal group As Object)
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(RichTextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                ctrl.Text = Nothing
            End If
        Next
    End Sub
    Public Sub bloqueo(ByVal group As Object, ByVal enable As Boolean)
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Enabled = enable
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(RichTextBox) Then
                ctrl.Enabled = enable
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                ctrl.Enabled = enable
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(Button) Then
                ctrl.Enabled = enable
            End If
        Next
    End Sub
    Sub New()
    End Sub
    Sub New(ByVal dtg As DataGridView)
        With dtg
            For i As Integer = 0 To .Rows.Count - 1
                .Rows.Clear()
            Next
        End With
    End Sub
End Class
