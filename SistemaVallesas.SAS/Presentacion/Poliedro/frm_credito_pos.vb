Imports MySql.Data.MySqlClient
Public Class frm_credito_pos
    'Dim objcliente As New CapaEntidad.ClassCliente
    'Dim cnn As New MySqlConnection
    'Dim objcnn As New CapaDatos.ClassConexion
    'Dim fecha As Date = Now
    'Dim obj_abono_venta As New CapaEntidad.ClassEntidadAbonoVenta
    'Dim obj_dato_abono_venta As New CapaDato.ClassEntidad.ClassCapaDatoAbonoVenta


    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

    '    Select Case keyData
    '        Case Keys.Enter
    '            If String.IsNullOrEmpty(Me.lbl_cliente.Text) Then
    '                metadatos()
    '            Else
    '                insert_venta_pos()
    '            End If
    '        Case Keys.Escape

    '        Case Keys.Delete

    '        Case Keys.F1

    '        Case Keys.F2

    '        Case Keys.F3

    '        Case Keys.F4

    '        Case Else
    '            Return MyBase.ProcessCmdKey(msg, keyData)
    '    End Select
    '    Return True
    'End Function
    'Sub metadatos()
    '    Try
    '        If Me.txt_documento.Text > 0 Then
    '            objcliente.getdocumento = Convert.ToString(Me.txt_documento.Text)
    '            cnn = objcnn.conectar
    '            Dim cmd As New MySqlCommand("sp_search_cliente_pos", cnn)
    '            cmd.CommandType = CommandType.StoredProcedure
    '            Dim r As MySqlDataReader
    '            Dim p As New MySqlParameter
    '            p = New MySqlParameter("?_name", MySql.Data.MySqlClient.MySqlDbType.VarChar)
    '            p.Value = objcliente.getdocumento
    '            p.Direction = ParameterDirection.Input
    '            cmd.Parameters.Add(p)
    '            r = cmd.ExecuteReader
    '            If r.Read Then
    '                Me.lbl_cliente.Text = Convert.ToString(r("cliente").ToString)
    '                frm_pos._idcliente = Convert.ToUInt64(r("idcliente"))
    '            End If
    '            r.Close()
    '            cnn.Close()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error  al buscar el cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Public Sub abono_venta()
    '    obj_abono_venta.getfecha = Date.Now
    '    obj_abono_venta.getidcliente = Convert.ToInt64(frm_pos._idcliente)
    '    obj_abono_venta.getmonto = Convert.ToDecimal(Me.txt_abono.Text)
    '    obj_abono_venta.getidcaja = Convert.ToInt64(1)
    '    obj_abono_venta.getidventa = Convert.ToInt64(_idventa_pos)
    '    obj_abono_venta.getobservacion = Convert.ToString(Me.txt_observacion.Text)
    '    If obj_dato_abono_venta.insertventa(obj_abono_venta) Then
    '    Else
    '        MessageBox.Show("No se ingreso abono venta")
    '    End If

    'End Sub
    'Public Sub insert_venta_pos()
    '    frm_pos._idtipo_pago_venta = Convert.ToInt64(2)
    '    frm_pos.obj_entidad_venta.getfecha = Date.Now
    '    If frm_pos._idcliente = 0 Then
    '        frm_pos.obj_entidad_venta.getidcliente = Integer.Parse(1)
    '    Else
    '        frm_pos.obj_entidad_venta.getidcliente = Integer.Parse(frm_pos._idcliente)
    '    End If
    '    frm_pos.obj_entidad_venta.getidtipo_documento = Integer.Parse(frm_pos._idtipo_documento_venta)
    '    frm_pos.obj_entidad_venta.getidtipo_pago = Integer.Parse(2)
    '    frm_pos.obj_entidad_venta.getobservacion = Convert.ToString("Poliedro")
    '    frm_pos.obj_entidad_venta.getidestado_venta = Integer.Parse(1)
    '    frm_pos.obj_entidad_venta.getreteica = Double.Parse(0)
    '    frm_pos.obj_entidad_venta.getreteiva = Double.Parse(0)
    '    frm_pos.obj_entidad_venta.gettotal = Double.Parse(frm_pos.lbl_total_pos.Text)
    '    frm_pos.obj_entidad_venta.getidtipo_movimiento = Integer.Parse(2)
    '    frm_pos.obj_entidad_venta.getnumeracion = Convert.ToDouble(frm_pos.numeracion())
    '    frm_pos.obj_entidad_venta.getcaja_idcaja = Convert.ToInt64(1)
    '    frm_pos.obj_entidad_venta.getidsucursal = Convert.ToInt64(1)
    '    frm_pos.obj_entidad_venta.getidusuario = Convert.ToInt64(1)
    '    If String.IsNullOrEmpty(Me.txt_plazo.Text) Then
    '        frm_pos.obj_entidad_venta.getvencimiento = fecha
    '    Else
    '        frm_pos.obj_entidad_venta.getvencimiento = DateAdd(DateInterval.Day, Convert.ToDouble(Me.txt_plazo.Text), fecha)
    '    End If

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
    '                frm_pos.obj_entidad_detalle_venta.gettotal = Double.Parse(frm_pos.lbl_total_pos.Text)
    '                frm_pos.obj_entidad_detalle_venta.getobservacion = Convert.ToString("ok")
    '                Dim idpro As New CapaNegocio.ClassPolimorfismoGetid(Convert.ToString(frm_pos.DataGridView1("proveedor", i).Value), "idproveedor", "proveedor", "razon_social")
    '                frm_pos.obj_entidad_detalle_venta.getidproveedor = Convert.ToInt64(idpro.getid)
    '                frm_pos.obj_entidad_detalle_venta.getidventa = Convert.ToInt64(frm_pos.numeracion())
    '                If frm_pos.obj_insert_detalle_venta.insert_detalle_venta(frm_pos.obj_entidad_detalle_venta) Then
    '                Else
    '                    MessageBox.Show("No se registro la detalle venta", "frm_pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                End If
    '            Next
    '        End If
    '    End With
    '    If Me.txt_abono.Text > 0 Then
    '        Call abono_venta()
    '    End If
    '    frm_pos.txt_buscar_producto.Focus()
    '    frm_pos.limpiar_pos()
    '    Me.Close()
    '    frm_cambio.Hide()
    'End Sub

    'Private Sub frm_credito_pos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    frm_cambio.Close()
    'End Sub

    'Private Sub frm_credito_pos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    credito_pos = True
    'End Sub
End Class