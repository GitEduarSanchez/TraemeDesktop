Public Class frm_cambio
    'Public pos As New frm_pos
    'Public _idtipo_documento_venta As Integer
    'Public _numeracion As Double

    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
    '    Select Case keyData
    '        Case Keys.Enter
    '            If credito_pos = False Then
    '                insert_venta_pos()
    '                frm_pos.lbl_total_pos.Text = String.Empty
    '                frm_pos.txt_buscar_producto.Focus()
    '            Else
    '                frm_pos.lbl_total_pos.Text = String.Empty
    '                frm_pos.limpiar_pos()
    '                frm_pos.txt_buscar_producto.Focus()
    '                Me.Close()
    '            End If

    '        Case Keys.Escape
    '            Me.Close()
    '        Case Keys.Delete

    '        Case Keys.F1
    '            frm_buscar_cliente_pos.StartPosition = FormStartPosition.CenterScreen
    '            frm_buscar_cliente_pos.Show()
    '        Case Keys.F2

    '            frm_tipo_documento.StartPosition = FormStartPosition.CenterScreen
    '            frm_credito_pos.Show()
    '        Case Keys.F3
    '            With frm_tipo_documento
    '                Dim dtg As New CapaNegocio.ClassConsultarDtg(.DataGridView1, "descripcion", "tipo_documento_venta")
    '                .DataGridView1.DataSource = dtg.getdtg
    '                .StartPosition = FormStartPosition.CenterScreen
    '                .Show()
    '            End With

    '        Case Keys.F4

    '        Case Else
    '            Return MyBase.ProcessCmdKey(msg, keyData)
    '    End Select
    '    Return True
    'End Function
    'Private Sub txt_efectivo_TextChanged(sender As Object, e As EventArgs) Handles txt_efectivo.TextChanged
    '    Try
    '        Dim saldo As Double = Double.Parse(Me.lbl_total_pos.Text)
    '        If Double.Parse(Me.txt_efectivo.Text) > saldo Then
    '            Me.lbl_cambio.Text = FormatNumber(Convert.ToString(Double.Parse(Me.txt_efectivo.Text) - saldo), 0)
    '        Else
    '            Me.lbl_cambio.Text = "0.0"
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Public Sub insert_venta_pos()
    '    frm_pos._idtipo_pago_venta = Convert.ToInt64(1)
    '    frm_pos._pagado = Convert.ToDouble(Me.txt_efectivo.Text)
    '    frm_pos._cambio = Convert.ToDouble(Me.lbl_cambio.Text)
    '    frm_pos.obj_entidad_venta.getfecha = Me.date_fecha_pos.Value.ToString("yyyy-MM-dd hh:mm:ss")
    '    If frm_pos._idcliente = 0 Then
    '        frm_pos.obj_entidad_venta.getidcliente = Integer.Parse(1)
    '    Else
    '        frm_pos.obj_entidad_venta.getidcliente = Integer.Parse(frm_pos._idcliente)
    '    End If
    '    frm_pos.obj_entidad_venta.getidtipo_documento = Integer.Parse(tipo_documento_pos)
    '    frm_pos.obj_entidad_venta.getidtipo_pago = Integer.Parse(frm_pos._idtipo_pago_venta)
    '    frm_pos.obj_entidad_venta.getobservacion = Convert.ToString("Poliedro")
    '    frm_pos.obj_entidad_venta.getidestado_venta = Integer.Parse(1)
    '    frm_pos.obj_entidad_venta.getreteica = Double.Parse(0)
    '    frm_pos.obj_entidad_venta.getreteiva = Double.Parse(0)
    '    frm_pos.obj_entidad_venta.gettotal = Double.Parse(frm_pos.lbl_total_pos.Text)
    '    frm_pos.obj_entidad_venta.getidtipo_movimiento = Integer.Parse(2)
    '    frm_pos.obj_entidad_venta.getvencimiento = Date.Now
    '    frm_pos.obj_entidad_venta.getpagado = frm_pos._pagado
    '    frm_pos.obj_entidad_venta.getcambio = frm_pos._cambio
    '    frm_pos.obj_entidad_venta.getnumeracion = Convert.ToDouble(frm_pos.numeracion())
    '    frm_pos.obj_entidad_venta.getcaja_idcaja = Convert.ToInt64(1)
    '    frm_pos.obj_entidad_venta.getidsucursal = Convert.ToInt64(1)
    '    frm_pos.obj_entidad_venta.getidusuario = Convert.ToInt64(1)
    '    _numeracion = Convert.ToDouble(frm_pos.numeracion())
    '    If frm_pos.obj_insert_venta.insertventa(frm_pos.obj_entidad_venta) Then
    '    Else
    '        MessageBox.Show("No se registro la venta", "frm_pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    '    With frm_pos.DataGridView1
    '        If .Rows.Count() > 0 Then
    '            For i As Integer = 0 To .Rows.Count() - 1
    '                frm_pos.obj_entidad_detalle_venta.getidproducto = 1 ' Convert.ToInt64(frm_pos.DataGridView1("idproducto", i).Value)
    '                frm_pos.obj_entidad_detalle_venta.getsku = Convert.ToString(frm_pos.DataGridView1("codigo", i).Value)
    '                frm_pos.obj_entidad_detalle_venta.getcantidad = Convert.ToDouble(frm_pos.DataGridView1("cant/peso", i).Value)
    '                frm_pos.obj_entidad_detalle_venta.getprecio = Double.Parse(frm_pos.DataGridView1("precio", i).Value)
    '                Dim obj_tasa As New CapaNegocio.ClassPolimorfismoGetid(Convert.ToString(frm_pos.DataGridView1("iva", i).Value), "valor", "impuesto", "descripcion")
    '                frm_pos.tasa = Convert.ToDouble(obj_tasa.getid() / 100)
    '                frm_pos.base = ((Convert.ToDouble(frm_pos.DataGridView1("precio", i).Value) * Convert.ToDouble(frm_pos.DataGridView1("cant/peso", i).Value)) / (1 + frm_pos.tasa))
    '                frm_pos.iva = frm_pos.base * frm_pos.tasa
    '                frm_pos.obj_entidad_detalle_venta.getiva = Convert.ToDouble(frm_pos.iva)
    '                frm_pos.obj_entidad_detalle_venta.getretencion = Double.Parse(0)
    '                frm_pos.obj_entidad_detalle_venta.getdescuento = Double.Parse(0)
    '                frm_pos.obj_entidad_detalle_venta.getrecargo = Double.Parse(0)
    '                frm_pos.obj_entidad_detalle_venta.getsubtotal = Double.Parse(Convert.ToDouble(frm_pos.DataGridView1("subtotal", i).Value))
    '                frm_pos.obj_entidad_detalle_venta.gettotal = Double.Parse(frm_pos.subtd)
    '                frm_pos.obj_entidad_detalle_venta.getobservacion = Convert.ToString("ok")
    '                Dim idpro As New CapaNegocio.ClassPolimorfismoGetid(Convert.ToString(frm_pos.DataGridView1("proveedor", i).Value), "idproveedor", "proveedor", "razon_social")
    '                frm_pos.obj_entidad_detalle_venta.getidproveedor = Convert.ToInt64(idpro.getid)
    '                frm_pos.obj_entidad_detalle_venta.getidventa = Convert.ToInt64(_numeracion)

    '                If frm_pos.obj_insert_detalle_venta.insert_detalle_venta(frm_pos.obj_entidad_detalle_venta) Then
    '                Else
    '                    MessageBox.Show("No se registro la detalle venta", "frm_pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                End If
    '            Next
    '        End If
    '    End With
    '    frm_pos.txt_buscar_producto.Focus()
    '    frm_pos.limpiar_pos()
    '    Me.Close()
    'End Sub
    'Private Sub txt_efectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_efectivo.KeyPress
    '    Dim solonumero As New CapaNegocio.ClassSoloNumeros(Me.txt_efectivo, e, "x")
    'End Sub

    'Private Sub frm_cambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub
End Class