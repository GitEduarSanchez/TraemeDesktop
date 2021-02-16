Public Class frm_tipo_documento
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Enter
                Dim index As New CapaNegocio.ClassPolimorfismoGetid(Convert.ToString(Me.DataGridView1.CurrentRow.Cells(0).Value), "idtipo_documento", "tipo_documento_venta", "descripcion")
                tipo_documento_pos = Convert.ToInt64(index.getid)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class