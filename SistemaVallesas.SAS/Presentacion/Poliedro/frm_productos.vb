Public Class frm_productos

    Private Sub frm_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim objcargartipoproducto As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_tipo_producto, "descripcion", "tipo_producto")
        Dim objcargarcategoria As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_categoria_producto, "descripcion", "categoria")
        Dim objcargarsubcategoria As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_subcategoria_producto, "descripcion", "subcategoria")
        Dim objcargarpresentacion As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_presentacion_producto, "descripcion", "presentacion")
        Dim objcargarproveedor As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_proveedor_producto, "razon_social", "proveedor")
        Dim objcargarmarcar As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_marca_producto, "descripcion", "marca")
        Dim objcargarlaboratorio As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_laboratorio, "nombre", "laboratorio")
        Dim objcargariva As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_iva_producto, "descripcion", "impuesto")
        Dim objcargarmetodo As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_mt_fiscal_producto, "descripcion", "metodo_fiscal")
        Dim objcargarbodega As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_bodega, "descripcion", "bodega")
        Dim objcaegarvariacion As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_variacion, "descripcion", "variacion")
        Me.cob_pesaje_producto.Items.Add("Si")
        Me.cob_pesaje_producto.Items.Add("No")
        Me.cob_garantia_producto.Items.Add("Si")
        Me.cob_garantia_producto.Items.Add("No")
        Me.cob_frecuencia.Items.Add("Dias")
        Me.cob_frecuencia.Items.Add("Meses")

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_iva_producto.SelectedIndexChanged

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim foto As New CapaNegocio.ClassFoto(Me.OpenFileDialog1, Me.foto_producto)
    End Sub

    Private Sub btn_guardar_producto_Click(sender As Object, e As EventArgs) Handles btn_guardar_producto.Click

    End Sub
End Class