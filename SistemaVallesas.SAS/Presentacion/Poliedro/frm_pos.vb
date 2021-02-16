Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class frm_pos
    'Dim az As String     'utilizada para almacenar los datos que se reciben por el puerto
    'Dim sib As Integer    ' sera utilizada como contador
    'Dim msn(1000) As String    'vector que servira de buffer para los datos que van llegando al puerto
    'Public obj_insert_detalle_venta As New CapaDato.ClassEntidad.ClassCapaDatoDetalleVenta
    'Public obj_insert_venta As New CapaDato.ClassEntidad.ClassCapaDatoventa
    'Public obj_entidad_venta As New CapaEntidad.ClassEntidadVentaPos
    'Public obj_entidad_detalle_venta As New CapaEntidad.ClassEntidadDetalleVentaPos
    'Public obj_asesor As New CapaEntidad.ClassAsesor
    'Public subtd As Double
    'Dim reset As New CapaNegocio.ClassReset
    'Private ComBuffer As Byte()                       'bascula
    'Dim _idresolucion As Integer
    'Public _pagado As Double
    'Public _cambio As Double
    'Private Delegate Sub UpdateFormDelegate()         'bascula
    'Private UpdateFormDelegate1 As UpdateFormDelegate 'bascula
    ''Creamos las variables a usar en el procedimiento de UpdateDisplay
    'Dim strReturn As String                            'bascula
    'Dim strPeso As String                              'bascula
    'Dim car As String                                  'bascula
    'Public impresora As String
    'Public _idcliente As Integer = 0
    'Public _idtipo_documento_venta As Integer
    'Public _idtipo_pago_venta As Integer
    'Public _idproveedor As Integer
    'Dim objproducto As New CapaEntidad.ClassEntidadProductoPos
    'Dim ConfiguracionesDeImpresion As New PrinterSettings
    'Dim objcnn As New CapaDatos.ClassConexion
    'Dim cnn As New MySqlConnection

    'Public vencimiento As Date
    'Public textnum As New CapaNegocio.ClassNumeroLetras
    'Public _sku As String
    'Public iva As Double
    'Public tasa As Double
    'Public base As Double
    'Public total_iva As Double

    'Private Sub frm_pos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim tool As New CapaNegocio.ClassTooltip
    '    tool.ayuda_boton("Poliedro Software", Me.btn_cobrar, "Cobrar")
    '    'Dim objcargarcliente As New CapaNegocio.ClassPolimorfismoSearch(Me.cob_cliente_pos, "razon_social", "cliente")

    '    _idtipo_documento_venta = Convert.ToInt64(1)
    '    Me.WindowState = FormWindowState.Maximized
    '    Me.txt_buscar_producto.Focus()
    '    'Me.cob_cliente_pos.SelectedIndex = 0
    '    impresora = ConfiguracionesDeImpresion.PrinterName
    '    With Me.DataGridView1
    '        .ColumnCount = 25
    '        .Columns(0).Name = "id"
    '        .Columns(1).Name = "codigo"
    '        .Columns(2).Name = "producto"
    '        .Columns(3).Name = "cant/peso"
    '        .Columns(4).Name = "precio"
    '        .Columns(5).Name = "iva"
    '        .Columns(6).Name = "idproducto"
    '        .Columns(7).Name = "descripcion"
    '        .Columns(8).Name = "referencia"
    '        .Columns(9).Name = "categoria"
    '        .Columns(10).Name = "tipo_producto"
    '        .Columns(11).Name = "proveedor"
    '        .Columns(12).Name = "marca"
    '        .Columns(13).Name = "vencimiento"
    '        .Columns(14).Name = "metodo_fiscal"
    '        .Columns(15).Name = "stok_minimo"
    '        .Columns(16).Name = "precio_costo"
    '        .Columns(17).Name = "inventario_inicial"
    '        .Columns(18).Name = "stok_minimo"
    '        .Columns(19).Name = "lote"
    '        .Columns(20).Name = "registro_invima"
    '        .Columns(21).Name = "laboratorio"
    '        .Columns(22).Name = "pesaje"
    '        .Columns(23).Name = "subtotal"
    '        .Columns(24).Name = "inventario"


    '        '.Columns(2).Width = "380"
    '        '.Columns(3).Width = "70"
    '        '.Columns(5).Width = "500"
    '        '.Columns(4).Width = "200"
    '        .Columns(0).Visible = True
    '        .Columns(1).Visible = False
    '        .Columns(2).Visible = True
    '        .Columns(3).Visible = True
    '        .Columns(4).Visible = True
    '        .Columns(5).Visible = True
    '        .Columns(6).Visible = False
    '        .Columns(7).Visible = False
    '        .Columns(8).Visible = False
    '        .Columns(9).Visible = False
    '        .Columns(10).Visible = False
    '        .Columns(11).Visible = False
    '        .Columns(12).Visible = False
    '        .Columns(13).Visible = False
    '        .Columns(14).Visible = False
    '        .Columns(15).Visible = False
    '        .Columns(16).Visible = False
    '        .Columns(17).Visible = False
    '        .Columns(18).Visible = False
    '        .Columns(19).Visible = False
    '        .Columns(20).Visible = False
    '        .Columns(21).Visible = False
    '        .Columns(22).Visible = False
    '        .Columns(23).Visible = True
    '        .Columns(24).Visible = True
    '        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '        .AllowUserToAddRows = False
    '        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    '        '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    End With
    'End Sub

    'Sub GetSerialPortNames()
    '    For Each sp As String In My.Computer.Ports.SerialPortNames
    '        'cob_puertos.Items.Add(sp)
    '    Next
    'End Sub
    'Sub Setup_Puerto_Serie()
    '    Try
    '        With SerialPort1
    '            If .IsOpen Then
    '                .Close()
    '            End If
    '            '.PortName = ComboPorts.Text
    '            .BaudRate = 9600 '// 19200 baud rate
    '            .DataBits = 8 '// 8 data bits
    '            .StopBits = IO.Ports.StopBits.One '// 1 Stop bit
    '            .Parity = IO.Ports.Parity.None '
    '            .DtrEnable = False
    '            .Handshake = IO.Ports.Handshake.None
    '            .ReadBufferSize = 2048
    '            .WriteBufferSize = 1024
    '            '.ReceivedBytesThreshold = 1
    '            .WriteTimeout = 500
    '            .Encoding = System.Text.Encoding.Default
    '            .Open() ' ABRE EL PUERTO SERIE
    '        End With
    '    Catch ex As Exception

    '        MsgBox("Error al abrir el puerto serial: " & ex.Message, MsgBoxStyle.Critical)

    '    End Try

    'End Sub
    'Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
    '    Dim n As Integer
    '    Try
    '        UpdateFormDelegate1 = New UpdateFormDelegate(AddressOf UpdateDisplay)
    '        n = SerialPort1.BytesToRead ' capturamos el numero de bytes leidos
    '        If n > 1 Then
    '            ComBuffer = New Byte(n - 1) {} 'redimensionamos
    '            SerialPort1.Read(ComBuffer, 0, n) 'leemos el dato
    '            Me.Invoke(UpdateFormDelegate1)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    'Private Sub UpdateDisplay()
    '    'variables locales
    '    Dim incoming As String = ""
    '    Dim longBuffer As Long
    '    Dim i As Integer
    '    'calcularmos la longitud del buffer y guardamos la información en una variable
    '    longBuffer = ComBuffer.Length
    '    For i = 0 To longBuffer - 1
    '        incoming = incoming & Chr(ComBuffer(i))
    '    Next
    '    strReturn = incoming.ToString
    '    'ahora solo tenemos que formatear la cadena tal como deseemos.
    '    'Yo conecte el puerto a una báscula por tanto necesito capturar el dato del pesaje
    '    '------------------------------------------------
    '    If strReturn.Length > 2 Then
    '        i = 0
    '        strPeso = ""
    '        Dim blnLeyoNumero As Boolean
    '        For i = 1 To strReturn.Length
    '            car = Mid(strReturn, i, 1)
    '            If IsNumeric(car) Or car = "." Then
    '                strPeso = strPeso & car
    '                blnLeyoNumero = True
    '            Else
    '                If blnLeyoNumero Then Exit For
    '            End If
    '        Next
    '    End If
    '    '--------------------------------------------------
    '    'Listo ahora el dato lo mostramos en la cajita de texto, ahora si a probarlo
    '    'Me.TextBox2.Text = strPeso
    'End Sub
    'Sub conexionserial()
    '    Try
    '        With SerialPort1
    '            .Close()
    '            .BaudRate = 9600
    '            .DataBits = 8
    '            .Parity = IO.Ports.Parity.None
    '            .StopBits = 1
    '            .PortName = "COM5"
    '            .Open()
    '            If .IsOpen Then
    '                'lbl_bascula.Text = "Conectado"
    '            Else
    '                MessageBox.Show("Conexion Fallido!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
    'Sub imprimir()
    '    'Dim subtotal As Double
    '    'Dim Ticket As New CapaDato.CrearTicket
    '    'Ticket.TextoCentro(Convert.ToString(UCase(("POLIEDRO SOFTWARE SAS"))))
    '    'Ticket.TextoCentro(Convert.ToString(UCase(("NIT: 901351995"))))
    '    'Ticket.TextoCentro(Convert.ToString(UCase(("DIR: CLL 10 # 14-01 CC ANDALUCIA LOCAL 201"))))
    '    'Ticket.TextoExtremos("RESOLUCION DE FACTURACION", "# 123456788")
    '    'Ticket.TextoIzquierda("")
    '    'Ticket.TextoExtremos("NUMERACION", "# " & Convert.ToString(UCase(1)))
    '    'Ticket.lineasIgual()
    '    'Ticket.TextoIzquierda("")
    '    'Ticket.TextoIzquierda("CLIENTE: CONSUMIDOR FINAL")
    '    'Ticket.TextoExtremos("FECHA:" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString())
    '    ''Ticket.TextoIzquierda("DURACION: " & TimeValue(DateDiff(DateInterval.Minute, Me.DataGridView1.CurrentRow.Cells.Item(5).Value, Date.Now) & ":" & DateDiff(DateInterval.Second, Me.DataGridView1.CurrentRow.Cells.Item(5).Value, Date.Now)))
    '    'Ticket.TextoIzquierda("")
    '    'Ticket.TextoCentro(Convert.ToString(UCase("factura de venta tipo pos")))
    '    'Ticket.TextoIzquierda("")
    '    'With Me.DataGridView1
    '    '    Ticket.lineasGuio()
    '    '    Ticket.EncabezadoVenta()
    '    '    Ticket.lineasGuio()
    '    '    For Each rd As DataGridViewRow In .Rows
    '    '        Ticket.AgregaArticulo(Convert.ToString(rd.Cells.Item(2).Value), Convert.ToString(rd.Cells.Item(3).Value), rd.Cells.Item(4).Value, rd.Cells.Item(5).Value)
    '    '        Ticket.lineasGuio()
    '    '        subtotal += rd.Cells.Item(5).Value
    '    '    Next
    '    'End With
    '    'Ticket.lineasIgual()

    '    'Ticket.AgregarTotales("             Subtotal", Double.Parse(subtotal))
    '    'Ticket.AgregarTotales("             IVA", Double.Parse(0))
    '    'Ticket.AgregarTotales("             Retefuente", Double.Parse(0))
    '    'Ticket.AgregarTotales("             Descuento", Double.Parse(0))
    '    'Ticket.AgregarTotales("             Recargos", Double.Parse(0))
    '    'Ticket.AgregarTotales("             Total", Double.Parse(0))
    '    'With Me.DataGridView1
    '    '    Ticket.lineasGuio()
    '    '    Ticket.EncabezadoIva()
    '    '    Ticket.lineasGuio()
    '    '    'For Each rd As DataGridViewRow In .Rows
    '    '    '    'Ticket.AgregaArticulo(Convert.ToString(rd.Cells.Item(2).Value), Convert.ToString(rd.Cells.Item(3).Value), rd.Cells.Item(4).Value, rd.Cells.Item(5).Value)
    '    '    '    Ticket.lineasGuio()
    '    '    'Next
    '    'End With
    '    'Ticket.TextoIzquierda(Me.lbl_letras_pos.Text)
    '    'Ticket.TextoIzquierda("")
    '    'Ticket.TextoCentro("¡GRACIAS POR PREFERIRNOS!")
    '    'Ticket.TextoIzquierda("")
    '    'Ticket.TextoIzquierda("")
    '    'Ticket.TextoIzquierda("")
    '    'Ticket.TextoIzquierda("")
    '    'Ticket.CortaTicket()
    '    'Ticket.ImprimirTicket(Convert.ToString(impresora))
    'End Sub

    'Private Sub TabPage1_Click(sender As Object, e As EventArgs)
    '    Me.txt_buscar_producto.Focus()
    'End Sub
    'Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Me.txt_buscar_producto.Focus()
    'End Sub

    'Sub metadatos()
    '    Try
    '        If IsNumeric(Me.txt_buscar_producto.Text) Then
    '            If Me.txt_buscar_producto.Text.Length > 12 Then
    '                _sku = Convert.ToString(Me.txt_buscar_producto.Text)
    '                objproducto.getsku = Convert.ToString(Me.txt_buscar_producto.Text)
    '                cnn = objcnn.conectar
    '                Dim cmd As New MySqlCommand("sp_search_producto_codigo", cnn)
    '                cmd.CommandType = CommandType.StoredProcedure
    '                Dim r As MySqlDataReader
    '                Dim p As New MySqlParameter
    '                p = New MySqlParameter("?_name", MySql.Data.MySqlClient.MySqlDbType.VarChar)
    '                p.Value = objproducto.getsku
    '                p.Direction = ParameterDirection.Input
    '                cmd.Parameters.Add(p)
    '                r = cmd.ExecuteReader
    '                If r.Read Then
    '                    Me.lbl_producto.Text = Convert.ToString(r("producto").ToString)
    '                    Me.lbl_total_pos.Text = FormatNumber(r("precio_venta").ToString, 0)
    '                End If
    '                r.Close()
    '                cnn.Close()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error  al buscar el producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Sub consultardtg()
    '    Try
    '        If IsNumeric(Me.txt_buscar_producto.Text) Then
    '            If Me.txt_buscar_producto.Text.Length > 12 Then

    '                objproducto.getsku = Convert.ToString(Me.txt_buscar_producto.Text)
    '                cnn = objcnn.conectar
    '                Dim cmd As New MySqlCommand("sp_search_producto_codigo", cnn)
    '                cmd.CommandType = CommandType.StoredProcedure
    '                Dim r As MySqlDataReader
    '                Dim p As New MySqlParameter
    '                p = New MySqlParameter("?_name", MySql.Data.MySqlClient.MySqlDbType.VarChar)
    '                p.Value = objproducto.getsku
    '                p.Direction = ParameterDirection.Input
    '                cmd.Parameters.Add(p)
    '                r = cmd.ExecuteReader
    '                If r.Read Then
    '                    With Me.DataGridView1
    '                        .ColumnHeadersVisible = True
    '                        For Each rd As DataGridViewRow In .Rows
    '                            If Convert.ToString(rd.Cells.Item("codigo").Value) = Convert.ToString(Me.txt_buscar_producto.Text) Then
    '                                rd.Cells.Item("cant/peso").Value = Convert.ToInt64(rd.Cells.Item("cant/peso").Value + Convert.ToDouble(Me.txt_cantidad.Text)) 'cant/peso
    '                                rd.Cells.Item("subtotal").Value = FormatNumber(Convert.ToDouble(rd.Cells.Item("cant/peso").Value) * Convert.ToDouble(rd.Cells.Item("precio").Value), 0) 'subtotal
    '                                Dim inv As New CapaNegocio.ClassPolimorfismoGetid(Convert.ToString(Me.txt_buscar_producto.Text), "inventario", "v_inventario", "codigo")
    '                                If String.IsNullOrEmpty(inv.getid) Then
    '                                    rd.Cells.Item("inventario").Value = 0
    '                                Else
    '                                    rd.Cells.Item("inventario").Value = inv.getid
    '                                End If
    '                                Me.txt_buscar_producto.Clear()
    '                                For Each rdd As DataGridViewRow In .Rows
    '                                    subtd += FormatNumber(Convert.ToDouble(rdd.Cells.Item("subtotal").Value), 0)
    '                                    Me.lbl_total_pos.Text = FormatNumber(Convert.ToDouble(subtd), 0)
    '                                    Me.lbl_letras_pos.Text = Convert.ToString(textnum.Num2Text(subtd)) & " DE PESOS"
    '                                    Call calcular_pos()
    '                                    r.Close()
    '                                    cnn.Close()
    '                                    Me.txt_cantidad.Text = String.Empty
    '                                    Me.txt_buscar_producto.Focus()
    '                                    Exit Sub
    '                                Next
    '                            Else

    '                            End If
    '                        Next

    '                        .Rows.Add(Convert.ToInt64(r("id").ToString),
    '                                 Convert.ToString(r("codigo").ToString),
    '                                 Convert.ToString(r("producto").ToString),
    '                                 Double.Parse(Me.txt_cantidad.Text),
    '                                 Convert.ToString(r("precio_venta").ToString),
    '                                 Convert.ToString(r("iva").ToString),
    '                                 Convert.ToString(r("idproducto").ToString),
    '                                 Convert.ToString(r("descripcion").ToString),
    '                                 Convert.ToString(r("referencia").ToString),
    '                                 Convert.ToString(r("categoria").ToString),
    '                                 Convert.ToString(r("tipo_producto").ToString),
    '                                 Convert.ToString(r("proveedor").ToString),
    '                                 Convert.ToString(r("marca").ToString),
    '                                 Convert.ToString(FormatDateTime(r("vencimiento").ToString, DateFormat.ShortDate)),
    '                                 Convert.ToString(r("metodo_fiscal").ToString),
    '                                 Convert.ToString(r("sotck_minimo").ToString),
    '                                 Convert.ToString(r("precio_costo").ToString),
    '                                 Convert.ToString(r("inventario_inicial").ToString),
    '                                 Convert.ToString(r("sotck_minimo").ToString),
    '                                 Convert.ToString(r("lote").ToString),
    '                                 Convert.ToString(r("registro_invima").ToString),
    '                                 Convert.ToString(r("laboratorio").ToString),
    '                                 Convert.ToString(r("pesaje").ToString))
    '                        Dim invx As New CapaNegocio.ClassPolimorfismoGetid(Convert.ToString(r("codigo").ToString), "inventario", "v_inventario", "codigo")
    '                        For Each rd As DataGridViewRow In .Rows
    '                            If String.IsNullOrEmpty(invx.getid) Then
    '                                rd.Cells.Item("inventario").Value = 0
    '                            Else
    '                                rd.Cells.Item("inventario").Value = invx.getid
    '                            End If
    '                        Next
    '                        '.Columns(5).DefaultCellStyle.Format = fm
    '                    End With
    '                    Me.lbl_producto.Text = Convert.ToString(r("producto").ToString) + "  " + FormatNumber(r("precio_venta").ToString, 0)
    '                End If
    '                r.Close()
    '                cnn.Close()
    '            End If
    '        Else
    '            'MessageBox.Show("letras")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error  al buscar el producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Sub consultardtgletras()
    '    Try
    '        If Not IsNumeric(Me.txt_buscar_producto.Text) Then
    '            If Me.txt_buscar_producto.Text.Length > 3 Then
    '                objproducto.getsku = Convert.ToString(Me.txt_buscar_producto.Text)
    '                cnn = objcnn.conectar
    '                Dim cmd As New MySqlCommand("sp_search_producto", cnn)
    '                cmd.CommandType = CommandType.StoredProcedure
    '                Dim r As MySqlDataReader
    '                Dim p As New MySqlParameter
    '                'Dim prefijo As String
    '                p = New MySqlParameter("?_name", MySql.Data.MySqlClient.MySqlDbType.VarChar)
    '                p.Value = objproducto.getsku
    '                p.Direction = ParameterDirection.Input
    '                cmd.Parameters.Add(p)
    '                r = cmd.ExecuteReader
    '                If r.Read Then
    '                    With Me.DataGridView1
    '                        Try
    '                            For i As Integer = 0 To .Rows.Count() - 1
    '                                'MessageBox.Show(.Item(2, i).Value)
    '                            Next
    '                        Catch ex As Exception
    '                        End Try
    '                    End With

    '                End If
    '                r.Close()
    '                cnn.Close()
    '            End If
    '        Else

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error  al buscar el producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub txt_buscar_producto_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_producto.TextChanged
    '    If Not IsNumeric(Me.txt_buscar_producto.Text) Then
    '        'consultardtgletras()
    '    Else
    '        Call metadatos()
    '        Me.txt_cantidad.Text = 1
    '        Me.txt_cantidad.Focus()
    '    End If
    'End Sub
    'Sub calcular_pos()
    '    Try
    '        Dim subt As Double
    '        With Me.DataGridView1
    '            For Each rd As DataGridViewRow In .Rows
    '                rd.Cells.Item("subtotal").Value = FormatNumber(Convert.ToDouble(rd.Cells.Item("cant/peso").Value) * Convert.ToDouble(rd.Cells.Item("precio").Value), 0)
    '                subt += FormatNumber(Convert.ToDouble(rd.Cells.Item("subtotal").Value), 0)
    '            Next
    '            Me.lbl_total_pos.Text = FormatNumber(Convert.ToDouble(subt), 0)
    '            Me.lbl_letras_pos.Text = Convert.ToString(textnum.Num2Text(subt)) & " DE PESOS"
    '            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '        End With
    '    Catch ex As Exception
    '        'MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub

    'Sub eliminar_reg()
    '    Try
    '        With Me.DataGridView1
    '            If .RowCount > 0 Then
    '                .ColumnHeadersVisible = True
    '                .Rows.RemoveAt(.CurrentRow.Index)
    '                Call calcular_pos()
    '                Me.txt_buscar_producto.Focus()
    '                Me.txt_cantidad.Text = String.Empty
    '                Me.lbl_producto.Text = String.Empty
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub

    'Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
    '    Me.txt_buscar_producto.Clear()
    '    Call calcular_pos()
    '    Me.txt_cantidad.Text = String.Empty
    '    Me.txt_buscar_producto.Focus()
    'End Sub
    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    Try
    '        With Me.DataGridView1
    '            If .RowCount > 0 Then
    '                If .CurrentCell.ColumnIndex = 0 Then
    '                    .Cursor = Cursors.Hand
    '                    Call eliminar_reg()
    '                End If
    '                If .CurrentCell.ColumnIndex = 2 Then
    '                    .Cursor = Cursors.Hand
    '                    Dim prp As New frm_producto_por_cliente
    '                    Dim llave As New CapaNegocio.ClassPolimorfismoGetid(.SelectedCells.Item(1).Value, "nombre", "producto", "sku", True)
    '                    Dim gps As New CapaNegocio.ClassConsultarDtg(prp.DataGridView1, Convert.ToString(llave.getregistro), "*", "v_presentacion_por_producto", "producto")
    '                    With prp.DataGridView1
    '                        .DataSource = gps.getdtg
    '                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '                        .AllowUserToAddRows = False
    '                        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    '                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '                        prp.WindowState = FormWindowState.Normal
    '                        prp.StartPosition = FormStartPosition.CenterParent
    '                        prp.ShowDialog()
    '                    End With
    '                End If
    '                If .CurrentCell.ColumnIndex = 3 Then
    '                    .Cursor = Cursors.Hand
    '                    Dim cnt As New frm_cantidad_pos
    '                    cnt.StartPosition = FormStartPosition.CenterScreen
    '                    cnt.Show()
    '                End If
    '                If .CurrentCell.ColumnIndex = 4 Then
    '                    .Cursor = Cursors.Hand
    '                    Dim gp As New frm_grupo_precios
    '                    Dim gps As New CapaNegocio.ClassConsultarDtg(gp.DataGridView1, "v_grupo_precio")
    '                    With gp.DataGridView1
    '                        .DataSource = gps.getdtg
    '                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '                        .AllowUserToAddRows = False
    '                        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    '                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '                        gp.WindowState = FormWindowState.Normal
    '                        gp.StartPosition = FormStartPosition.CenterParent
    '                        gp.ShowDialog()
    '                    End With

    '                End If
    '            End If
    '        End With
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub DataGridView1_Enter(sender As Object, e As EventArgs) Handles DataGridView1.Enter
    '    'With Me.DataGridView1
    '    '    If .CurrentCell.ColumnIndex = 3 Then
    '    '        Call calcular_pos()
    '    '    End If
    '    'End With
    'End Sub
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Me.lbl_hora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    '    Me.lbl_hora.Text = FormatDateTime(Me.lbl_hora.Text, DateFormat.LongTime)
    'End Sub
    'Sub registrar()
    '    'Dim Ticket As New CapaDato.CrearTicket

    '    'Ticket.TextoCentro(Convert.ToString(UCase("POLIEDRO SOFTWARE SAS")))
    '    'Ticket.TextoIzquierda("Nit:901351995 ")
    '    'Ticket.TextoIzquierda("CENTRO DE TRABAJO: OCAÑA")
    '    'Ticket.TextoIzquierda("TELEFONO: 3154286798")
    '    'Ticket.TextoIzquierda("EMAIL: poliedrosoftware@gmail.com")
    '    'Ticket.TextoIzquierda("")
    '    'Ticket.lineasAsteriscos()

    '    ''Sub cabecera.
    '    ' ''Ticket.TextoIzquierda("")
    '    ' ''Ticket.TextoIzquierda("TITULO: " & Convert.ToString(UCase(Me.cob_titulo.Text)))
    '    ' ''Ticket.TextoIzquierda("DESPACHADOR: " & Convert.ToString(UCase(Me.cob_despachador.Text)))
    '    ' ''Ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL")
    '    ' ''Ticket.TextoIzquierda("TIPO VEHICULO: " & Convert.ToString(UCase(Me.txt_tipo_vehiculo.Text)))
    '    ' ''Ticket.TextoIzquierda("PLACA: " & Convert.ToString(UCase(Me.txt_placa.Text)))
    '    ' ''Ticket.TextoIzquierda("CONDUCTOR: " & Convert.ToString(UCase(Me.txt_conductor.Text)))
    '    ' ''Ticket.TextoIzquierda("DOCUMENTO: " & Convert.ToString(UCase(Me.txt_docuemento.Text)))
    '    ' ''Ticket.TextoIzquierda("# RECIBO: " & Convert.ToString(UCase(Me.txt_recibo.Text)))
    '    ' ''Ticket.TextoIzquierda("CONTRATO: " & Convert.ToString(UCase(Me.cob_contrato.Text)))
    '    ' ''Ticket.TextoIzquierda("PRODUCTO: " & Convert.ToString(UCase(Me.cob_producto.Text)))
    '    ' ''Ticket.TextoIzquierda("PRESINTOS: " & Convert.ToString(UCase(Me.txt_observaciones.Text)))
    '    '' ''Ticket.TextoExtremos("ENTRADA:" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString())
    '    '' ''Ticket.TextoExtremos("SALIDA:" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString())
    '    ' ''Ticket.TextoExtremos("ENTRADA:" + FormatDateTime(Me.DataGridView1.CurrentRow.Cells.Item(5).Value, DateFormat.ShortDate), "HORA: " + FormatDateTime(Me.DataGridView1.CurrentRow.Cells.Item(5).Value, DateFormat.LongTime))
    '    ' ''Ticket.TextoExtremos("SALIDA :" + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString())
    '    '' ''Ticket.TextoIzquierda("DURACION: " & TimeValue(DateDiff(DateInterval.Minute, Me.DataGridView1.CurrentRow.Cells.Item(5).Value, Date.Now) & ":" & DateDiff(DateInterval.Second, Me.DataGridView1.CurrentRow.Cells.Item(5).Value, Date.Now)))
    '    ' ''Ticket.lineasAsteriscos()
    '    '' ''If Me.cob_movimiento.Text = "ENTRADA" Then
    '    '' ''    Ticket.AgregarTotales("         PESOBRUTO...KG", Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(13).Value))
    '    '' ''    Ticket.AgregarTotales("         TARA........KG", Double.Parse(num.SoloNumeros(Me.txt_pesobruto.Text)))
    '    '' ''    Ticket.AgregarTotales("         PESONETO....KG", Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(13).Value - Double.Parse(num.SoloNumeros(Me.txt_pesobruto.Text))))
    '    '' ''End If
    '    '' ''If Me.cob_movimiento.Text = "SALIDA" Then
    '    '' ''    Ticket.AgregarTotales("         PESOBRUTO...KG", Double.Parse(Double.Parse(num.SoloNumeros(Me.txt_pesobruto.Text))))
    '    '' ''    Ticket.AgregarTotales("         TARA........KG", Double.Parse(Me.DataGridView1.CurrentRow.Cells.Item(14).Value))
    '    '' ''    Ticket.AgregarTotales("         PESONETO....KG", Double.Parse(Double.Parse(num.SoloNumeros(Me.txt_pesobruto.Text)) - Me.DataGridView1.CurrentRow.Cells.Item(14).Value))
    '    '' ''End If
    '    ' ''Ticket.TextoIzquierda("")
    '    ' ''Ticket.TextoCentro("¡GRACIAS POR PREFERIRNOS!")
    '    ' ''Ticket.TextoIzquierda("")
    '    ' ''Ticket.TextoIzquierda("")
    '    ' ''Ticket.TextoIzquierda("")
    '    ' ''Ticket.TextoIzquierda("")
    '    ' ''Ticket.CortaTicket()
    '    'Ticket.ImprimirTicket(Convert.ToString(impresora))
    'End Sub



    ''------------------------------------------------------
    ''------------funcion de atajos de teclado--------------
    ''******************************************************
    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
    '    Select Case keyData
    '        Case Keys.Enter
    '            If Me.txt_cantidad.Text <> String.Empty Then
    '                consultardtg()
    '            Else
    '                With Me.DataGridView1
    '                    If .RowCount() > 0 Then
    '                        Dim f_cambio As New frm_cambio
    '                        f_cambio.WindowState = FormWindowState.Maximized
    '                        f_cambio.lbl_total_pos.Text = Me.lbl_total_pos.Text
    '                        f_cambio.txt_efectivo.Text = Me.lbl_total_pos.Text
    '                        f_cambio.Text = 0
    '                        f_cambio.ShowDialog()
    '                    End If
    '                End With
    '            End If
    '        Case Keys.Escape
    '            'If MessageBox.Show("Deseas salir de la Aplicacion ?", "Empresa",
    '            '                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
    '            'Application.Exit()
    '            Me.Close()
    '            'Else
    '            'End If
    '            Me.Close()
    '        Case Keys.Delete
    '            eliminar_reg()
    '        Case Keys.F1
    '            frm_credito_pos.Show()
    '        Case Keys.F2
    '            Dim buscador As New frm_buscar_producto_pos
    '            With buscador
    '                Dim dtg As New CapaNegocio.ClassConsultarDtg(.DataGridView1, Convert.ToString(.txt_buscar_producto.Text), "*", "v_producto", "producto")
    '                .DataGridView1.DataSource = dtg.getdtg
    '                .StartPosition = FormStartPosition.CenterScreen
    '                With buscador.DataGridView1
    '                    For i As Integer = 0 To 20
    '                        .Columns(i).Visible = False
    '                    Next
    '                    .Columns("producto").Visible = True
    '                    .Columns("codigo").Visible = True
    '                    .Columns("precio_venta").Visible = True
    '                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '                    .AllowUserToAddRows = False
    '                End With
    '                .Show()
    '            End With
    '        Case Keys.F3
    '            frm_bolsa.txt_cantidad.Focus()
    '            Dim bolsa As New CapaNegocio.ClassPolimorfismoGetid(Convert.ToString(Date.Now.Year()), "valor", "inc", "anio")
    '            frm_bolsa.lbl_valor_bolsa.Text = Convert.ToString(bolsa.getid)
    '            frm_bolsa.Show()
    '        Case Keys.F4

    '        Case Else
    '            Return MyBase.ProcessCmdKey(msg, keyData)
    '    End Select
    '    Return True
    'End Function
    'Private Sub TabControl1_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    Try
    '        Select Case e.KeyChar.ToString
    '            Case Keys.Enter
    '                'If Me.DataGridView1.RowCount > 0 Then
    '                '    MessageBox.Show("ok")
    '                'End If
    '            Case Keys.Escape
    '                'If MessageBox.Show("Deseas salir de la Aplicacion ?", "Poliedro",
    '                '                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                '    Me.Close()
    '                '    'Application.Exit()
    '                'Else
    '                'End If
    '            Case Keys.X
    '            Case Else
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Public Sub insert_venta_pos()
    '    obj_entidad_venta.getfecha = Date.Now()
    '    obj_entidad_venta.getidcliente = Integer.Parse(1)
    '    obj_entidad_venta.getidtipo_documento = Integer.Parse(_idtipo_documento_venta)
    '    obj_entidad_venta.getidtipo_pago = Integer.Parse(_idtipo_pago_venta)
    '    obj_entidad_venta.getobservacion = Convert.ToString("Poliedro")
    '    obj_entidad_venta.getidestado_venta = Integer.Parse(1)
    '    obj_entidad_venta.getreteica = Double.Parse(0)
    '    obj_entidad_venta.getreteiva = Double.Parse(0)
    '    obj_entidad_venta.gettotal = Double.Parse(Me.lbl_total_pos.Text)
    '    obj_entidad_venta.getidtipo_movimiento = Integer.Parse(2)
    '    obj_entidad_venta.getidresolucion = Convert.ToInt64(_idresolucion)
    '    obj_entidad_venta.getpagado = Convert.ToDouble(_pagado)
    '    obj_entidad_venta.getcambio = Convert.ToDouble(_cambio)
    '    obj_entidad_venta.getnumeracion = Convert.ToDouble(numeracion())
    '    obj_entidad_venta.getcaja_idcaja = Convert.ToInt64(1)
    '    obj_entidad_venta.getidsucursal = Convert.ToInt64(1)
    '    If obj_insert_venta.insertventa(obj_entidad_venta) Then
    '    Else
    '        MessageBox.Show("No se registro la venta", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    '    _idventa_pos = Convert.ToInt64(numeracion() - 1)

    '    With Me.DataGridView1
    '        If .Rows.Count() > 0 Then
    '            For i As Integer = 0 To .Rows.Count() - 1
    '                obj_entidad_detalle_venta.getidproducto = Convert.ToInt64(Me.DataGridView1("idproducto", i).Value)
    '                obj_entidad_detalle_venta.getsku = Convert.ToString(Me.DataGridView1("codigo", i).Value)
    '                obj_entidad_detalle_venta.getnumeracion = Convert.ToDouble(numeracion())
    '                obj_entidad_detalle_venta.getcantidad = Convert.ToDouble(Me.DataGridView1("cant/peso", i).Value)
    '                obj_entidad_detalle_venta.getprecio = Double.Parse(Me.DataGridView1("precio", i).Value)
    '                Dim obj_tasa As New CapaNegocio.ClassPolimorfismoGetid(Convert.ToString(Me.DataGridView1("iva", i).Value), "valor", "impuesto", "descripcion")
    '                tasa = Convert.ToDouble(obj_tasa.getid() / 100)
    '                base = ((Convert.ToDouble(Me.DataGridView1("precio", i).Value) * Convert.ToDouble(Me.DataGridView1("cant/peso", i).Value)) / (1 + tasa))
    '                iva = base * tasa
    '                obj_entidad_detalle_venta.getiva = Convert.ToDouble(iva)
    '                obj_entidad_detalle_venta.getretencion = Double.Parse(0)
    '                obj_entidad_detalle_venta.getdescuento = Double.Parse(0)
    '                obj_entidad_detalle_venta.getrecargo = Double.Parse(0)
    '                obj_entidad_detalle_venta.getsubtotal = Double.Parse(Convert.ToDouble(Me.DataGridView1("subtotal", i).Value))
    '                obj_entidad_detalle_venta.gettotal = Double.Parse(subtd)
    '                obj_entidad_detalle_venta.getobservacion = Convert.ToString("ok")
    '                Dim idpro As New CapaNegocio.ClassPolimorfismoGetid(Convert.ToString(Me.DataGridView1("proveedor", i).Value), "idproveedor", "proveedor", "razon_social")
    '                obj_entidad_detalle_venta.getidproveedor = Convert.ToInt64(idpro.getid)
    '                obj_entidad_detalle_venta.getidventa = Convert.ToInt64(numeracion())
    '                obj_entidad_detalle_venta.getidresolucion = Convert.ToInt64(_idresolucion)

    '                If obj_insert_detalle_venta.insert_detalle_venta(obj_entidad_detalle_venta) Then
    '                Else
    '                    MessageBox.Show("No se registro la detalle venta", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                End If
    '            Next
    '        End If
    '    End With
    '    limpiar_pos()

    'End Sub
    'Public Function numeracion() As Double
    '    Dim _numeracion_pos As New CapaNegocio.ClassMaxID_("numeracion", "venta")
    '    Return _numeracion_pos.getid + 1
    'End Function

    'Private Sub btn_cobrar_Click(sender As Object, e As EventArgs) Handles btn_cobrar.Click
    '    Call insert_venta_pos()
    '    imprimir()
    'End Sub
    'Public Sub limpiar_pos()
    '    With Me.DataGridView1
    '        For i As Integer = 0 To .Rows.Count - 1
    '            .Rows.Clear()
    '        Next
    '        Me.lbl_letras_pos.Text = String.Empty
    '        Me.txt_cantidad.Text = String.Empty
    '        Me.lbl_producto.Text = String.Empty
    '        Me.txt_buscar_producto.Focus()
    '        _idcliente = 0
    '    End With
    'End Sub
    'Private Sub txt_efectivo_pos_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    Try
    '        'Dim solonumero As New CapaNegocio.ClassSoloNumeros(Me.txt_efectivo_pos, e, "x")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al digitar solo numero", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    'Me.btn_pc.Cursor = Cursors.Hand
    '    Dim pc As New frm_producto_por_cliente
    '    pc.StartPosition = FormStartPosition.CenterScreen
    '    With pc.DataGridView1
    '        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '        .AllowUserToAddRows = False
    '        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    '        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '        pc.AutoSize = True
    '        'Dim negocio As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_cliente_pos, "idcliente", "cliente", "razon_social")
    '        '_idcliente = Convert.ToInt64(negocio.getid)
    '        Dim objpc As New CapaNegocio.ClassConsultarDtg(pc.DataGridView1, _idcliente, "*", "v_producto_por_cliente", "llave", "ASC")
    '        pc.DataGridView1.DataSource = objpc.getdtg
    '        .Columns("llave").Visible = False
    '        pc.AutoSize = True
    '        pc.ShowDialog()
    '    End With
    'End Sub
    'Private Sub cob_cliente_pos_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Try
    '        'Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_cliente_pos, "idcliente", "cliente", "razon_social")
    '        '_idcliente = Integer.Parse(objgetid.getid)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub cob_tipo_documento_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Try
    '        'Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_tipo_documento, "idtipo_documento", "tipo_documento_venta", "descripcion")
    '        '_idtipo_documento_venta = Integer.Parse(objgetid.getid)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el tipo de documento", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub cob_tipo_venta_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Try
    '        'Dim objgetid As New CapaNegocio.ClassPolimorfismoGetid(Me.cob_tipo_venta, "idtipo_pago", "tipo_pago", "descripcion")
    '        '_idtipo_pago_venta = Integer.Parse(objgetid.getid)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al cargar el tipo de pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs)
    '    Dim ac As New frm_cliente
    '    ac.Show()

    'End Sub

    'Private Sub DataGridView1_MouseHover(sender As Object, e As EventArgs) Handles DataGridView1.MouseHover
    '    With Me.DataGridView1
    '        '.CurrentCell.ToolTipText(
    '    End With
    'End Sub

    'Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged

    'End Sub

    'Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
    '    Try
    '        Dim solonumero As New CapaNegocio.ClassSoloNumeros(Me.txt_cantidad, e, "x")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error al digitar solo numero", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub



    'Private Sub frm_pos_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
    '    Me.txt_buscar_producto.Focus()
    'End Sub
End Class