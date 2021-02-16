Public Class frm_bolsa
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Enter
                With Me.txt_cantidad
                    If Not String.IsNullOrEmpty(.Text) And .Text > 0 Then
                        _cantidad_bolsa = Convert.ToInt64(Me.txt_cantidad.Text)
                        _valor_bolsa = Convert.ToDouble(Me.lbl_valor_bolsa.Text)
                        Me.Close()
                    End If
                End With

            Case Keys.Escape
               
                Me.Close()
            Case Keys.Delete

            Case Keys.F1

            Case Keys.F2

            Case Keys.F3
              
            Case Keys.F4

            Case Else
                Return MyBase.ProcessCmdKey(msg, keyData)
        End Select
        Return True
    End Function
    Private Sub frm_bolsa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged
        Try
            With Me.txt_cantidad
                If Not String.IsNullOrEmpty(.Text) And .Text > 0 Then
                    Me.lbl_subtotal_bolsa.Text = Convert.ToDouble(Me.lbl_valor_bolsa.Text) * Convert.ToDouble(Me.txt_cantidad.Text)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class