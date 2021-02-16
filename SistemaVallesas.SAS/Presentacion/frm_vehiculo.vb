Public Class frm_vehiculo

    Dim obj_e_vehiculo As New CapaDato.ClassCapaEntidadVehiculo
    Dim obj_d_vehiculo As New CapaDato.ClassCapaDatoVehiculo


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insertar()
    End Sub
    Sub insertar()
        obj_e_vehiculo.getplaca = Convert.ToString(Me.txt_placa.Text)
        If obj_d_vehiculo.insert_vehiculo(obj_e_vehiculo) Then
            MessageBox.Show("Registro exitoso", "Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_placa.Text = String.Empty
        Else
            MessageBox.Show("no")
        End If
       
    End Sub
End Class