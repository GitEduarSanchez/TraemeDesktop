Module ModuleFactura
    Sub agregar_datagridview()
        'txtsubtotal.Text = (txtcantidad.Text) * (txtpreciounitario.Text)
        'DataGridView1.Rows.Add(Txtcodigo.Text, txtnombre.Text, txtdescripcion.Text, txtpreciounitario.Text, txtcantidad.Text, txtsubtotal.Text)
        'Dim total As Double = 0
        'Dim fila As DataGridViewRow = New DataGridViewRow()
        'For Each fila In DataGridView1.Rows
        '    total += Convert.ToDouble(fila.Cells("Column6").Value)
        'Next
        'TextBox1.Text = Convert.ToString(total)
    End Sub
End Module
'Imports MySql.Data.MySqlClient
'Imports MySql.Data.Types

'Public Class Form1

'    Dim conexion As MySqlConnection = New MySqlConnection("server=127.0.0.1; database=ejemplo; uid=root; pwd=;")

'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        Dim agregar As MySqlCommand = New MySqlCommand("INSERT INTO datos VALUES(?clave, ?nombre, ?apellido)", conexion)
'        conexion.Open()

'        Dim fila As DataGridViewRow = New DataGridViewRow()

'        Try
'            For Each fila In DataGridView1.Rows
'                agregar.Parameters.Clear()

'                agregar.Parameters.Add("?clave", MySqlDbType.Int16).Value = Convert.ToString(fila.Cells("Column1").Value)
'                agregar.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column2").Value)
'                agregar.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column3").Value)

'                agregar.ExecuteNonQuery()
'            Next
'        Catch ex As Exception
'            MessageBox.Show("Datos agregados")
'        End Try
'    End Sub
'End Class