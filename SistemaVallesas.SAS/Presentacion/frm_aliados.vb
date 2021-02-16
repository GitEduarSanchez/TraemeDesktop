

Public Class frm_aliados
    Dim obj_e_aliado As New CapaDato.ClassCapaEntidadAliado
    Dim obj_d_aliado As New CapaDato.ClassCapaDatoAliado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insertar()
    End Sub
    Sub insertar()
        obj_e_aliado.getnombre = Convert.ToString(Me.txt_aliado.Text)
        obj_e_aliado.getdireccion = Convert.ToString(Me.txt_direccion.Text)
        obj_e_aliado.gettelefono = Convert.ToString(Me.txt_telefono.Text)
        If obj_d_aliado.insert_aliado(obj_e_aliado) = False Then
            MessageBox.Show("No se guardo los datos")
        Else
            MessageBox.Show("Registro exitiso", "aliado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_aliado.Text = String.Empty
            Me.txt_direccion.Text = String.Empty
            Me.txt_telefono.Text = String.Empty
        End If
    End Sub
End Class