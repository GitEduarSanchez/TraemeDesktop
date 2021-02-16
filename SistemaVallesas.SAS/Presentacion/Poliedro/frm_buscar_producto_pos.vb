Public Class frm_buscar_producto_pos

    Private Sub txt_buscar_producto_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_producto.TextChanged
        Dim dtg As New CapaNegocio.ClassConsultarDtg(Me.DataGridView1, Convert.ToString(txt_buscar_producto.Text), "*", "v_producto", "producto")
        DataGridView1.DataSource = dtg.getdtg
    End Sub

    Private Sub frm_buscar_producto_pos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_buscar_producto.Focus()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Enter
                frm_pos.txt_buscar_producto.Text = Convert.ToString(Me.DataGridView1.CurrentRow.Cells("codigo").Value)
                Me.Close()
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
End Class