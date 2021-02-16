<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.txt_registro_invima = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_lote = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cob_laboratorio = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cob_variacion = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cob_bodega = New System.Windows.Forms.ComboBox()
        Me.txt_inv_inicial_producto = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_precio_venta_producto = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_margen_producto = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_precio_costo_producto = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cob_mt_fiscal_producto = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.cob_iva_producto = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cob_frecuencia = New System.Windows.Forms.ComboBox()
        Me.txt_garantia_producto = New System.Windows.Forms.TextBox()
        Me.cob_garantia_producto = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtg_grupo_precio_producto = New System.Windows.Forms.DataGridView()
        Me.btn_salir_producto = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.foto_producto = New System.Windows.Forms.PictureBox()
        Me.orden_producto = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cob_pesaje_producto = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cob_mostrar_pos = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_stock_minimo_producto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dt_vencimiento_producto = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.cob_marca_producto = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cob_proveedor_producto = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cob_presentacion_producto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cob_subcategoria_producto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cob_categoria_producto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_referencia_producto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_descripcion_producto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_codigo_producto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar_tipo_producto = New System.Windows.Forms.Button()
        Me.cob_tipo_producto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_guardar_producto = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtg_grupo_precio_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.foto_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1057, 508)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.txt_registro_invima)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.txt_lote)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.cob_laboratorio)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.cob_variacion)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.cob_frecuencia)
        Me.TabPage1.Controls.Add(Me.txt_garantia_producto)
        Me.TabPage1.Controls.Add(Me.cob_garantia_producto)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Button12)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.btn_salir_producto)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.orden_producto)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.cob_pesaje_producto)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.cob_mostrar_pos)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txt_stock_minimo_producto)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.dt_vencimiento_producto)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.cob_marca_producto)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.cob_proveedor_producto)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.cob_presentacion_producto)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.cob_subcategoria_producto)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cob_categoria_producto)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_referencia_producto)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_descripcion_producto)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_producto)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_codigo_producto)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btn_buscar_tipo_producto)
        Me.TabPage1.Controls.Add(Me.cob_tipo_producto)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btn_guardar_producto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1049, 482)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agregar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(341, 349)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(150, 23)
        Me.Button9.TabIndex = 71
        Me.Button9.Text = "Agregar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'txt_registro_invima
        '
        Me.txt_registro_invima.Location = New System.Drawing.Point(507, 450)
        Me.txt_registro_invima.Name = "txt_registro_invima"
        Me.txt_registro_invima.Size = New System.Drawing.Size(142, 20)
        Me.txt_registro_invima.TabIndex = 70
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(446, 456)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(55, 13)
        Me.Label29.TabIndex = 69
        Me.Label29.Text = "Rg Invima"
        '
        'txt_lote
        '
        Me.txt_lote.Location = New System.Drawing.Point(333, 452)
        Me.txt_lote.Name = "txt_lote"
        Me.txt_lote.Size = New System.Drawing.Size(107, 20)
        Me.txt_lote.TabIndex = 68
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(304, 459)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(28, 13)
        Me.Label28.TabIndex = 67
        Me.Label28.Text = "Lote"
        '
        'cob_laboratorio
        '
        Me.cob_laboratorio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_laboratorio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_laboratorio.FormattingEnabled = True
        Me.cob_laboratorio.Location = New System.Drawing.Point(124, 449)
        Me.cob_laboratorio.Name = "cob_laboratorio"
        Me.cob_laboratorio.Size = New System.Drawing.Size(174, 21)
        Me.cob_laboratorio.TabIndex = 66
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(21, 456)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 13)
        Me.Label27.TabIndex = 65
        Me.Label27.Text = "Laboratorio"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(379, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 20)
        Me.TextBox1.TabIndex = 64
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(341, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(28, 13)
        Me.Label26.TabIndex = 63
        Me.Label26.Text = "Lote"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(604, 143)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(74, 23)
        Me.Button8.TabIndex = 62
        Me.Button8.Text = "Agregar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(717, 117)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(238, 121)
        Me.GroupBox5.TabIndex = 61
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Valor Variacion"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(232, 102)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(684, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 60
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cob_variacion
        '
        Me.cob_variacion.FormattingEnabled = True
        Me.cob_variacion.Location = New System.Drawing.Point(516, 120)
        Me.cob_variacion.Name = "cob_variacion"
        Me.cob_variacion.Size = New System.Drawing.Size(162, 21)
        Me.cob_variacion.TabIndex = 59
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(446, 126)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "Variaciones"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.cob_bodega)
        Me.GroupBox4.Controls.Add(Me.txt_inv_inicial_producto)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txt_precio_venta_producto)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txt_margen_producto)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txt_precio_costo_producto)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.cob_mt_fiscal_producto)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.cob_iva_producto)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(446, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(509, 98)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Costos e Impuestos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(230, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Bodega"
        '
        'cob_bodega
        '
        Me.cob_bodega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_bodega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_bodega.FormattingEnabled = True
        Me.cob_bodega.Location = New System.Drawing.Point(319, 13)
        Me.cob_bodega.Name = "cob_bodega"
        Me.cob_bodega.Size = New System.Drawing.Size(81, 21)
        Me.cob_bodega.TabIndex = 51
        '
        'txt_inv_inicial_producto
        '
        Me.txt_inv_inicial_producto.Location = New System.Drawing.Point(319, 49)
        Me.txt_inv_inicial_producto.Name = "txt_inv_inicial_producto"
        Me.txt_inv_inicial_producto.Size = New System.Drawing.Size(81, 20)
        Me.txt_inv_inicial_producto.TabIndex = 50
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(230, 52)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 13)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "Inventario inicial"
        '
        'txt_precio_venta_producto
        '
        Me.txt_precio_venta_producto.Location = New System.Drawing.Point(378, 71)
        Me.txt_precio_venta_producto.Name = "txt_precio_venta_producto"
        Me.txt_precio_venta_producto.Size = New System.Drawing.Size(107, 20)
        Me.txt_precio_venta_producto.TabIndex = 48
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(304, 74)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 13)
        Me.Label23.TabIndex = 47
        Me.Label23.Text = "Precio Venta"
        '
        'txt_margen_producto
        '
        Me.txt_margen_producto.Location = New System.Drawing.Point(244, 71)
        Me.txt_margen_producto.Name = "txt_margen_producto"
        Me.txt_margen_producto.Size = New System.Drawing.Size(54, 20)
        Me.txt_margen_producto.TabIndex = 46
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(184, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 13)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Margen %"
        '
        'txt_precio_costo_producto
        '
        Me.txt_precio_costo_producto.Location = New System.Drawing.Point(97, 71)
        Me.txt_precio_costo_producto.Name = "txt_precio_costo_producto"
        Me.txt_precio_costo_producto.Size = New System.Drawing.Size(81, 20)
        Me.txt_precio_costo_producto.TabIndex = 44
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Precio Costo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Metodo Fiscal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Iva"
        '
        'cob_mt_fiscal_producto
        '
        Me.cob_mt_fiscal_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_mt_fiscal_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_mt_fiscal_producto.FormattingEnabled = True
        Me.cob_mt_fiscal_producto.Location = New System.Drawing.Point(97, 44)
        Me.cob_mt_fiscal_producto.Name = "cob_mt_fiscal_producto"
        Me.cob_mt_fiscal_producto.Size = New System.Drawing.Size(81, 21)
        Me.cob_mt_fiscal_producto.TabIndex = 39
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(184, 13)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(27, 23)
        Me.Button7.TabIndex = 37
        Me.Button7.UseVisualStyleBackColor = True
        '
        'cob_iva_producto
        '
        Me.cob_iva_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_iva_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_iva_producto.FormattingEnabled = True
        Me.cob_iva_producto.Location = New System.Drawing.Point(97, 15)
        Me.cob_iva_producto.Name = "cob_iva_producto"
        Me.cob_iva_producto.Size = New System.Drawing.Size(81, 21)
        Me.cob_iva_producto.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(-49, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Iva"
        '
        'cob_frecuencia
        '
        Me.cob_frecuencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_frecuencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_frecuencia.FormattingEnabled = True
        Me.cob_frecuencia.Location = New System.Drawing.Point(179, 369)
        Me.cob_frecuencia.Name = "cob_frecuencia"
        Me.cob_frecuencia.Size = New System.Drawing.Size(82, 21)
        Me.cob_frecuencia.TabIndex = 56
        '
        'txt_garantia_producto
        '
        Me.txt_garantia_producto.Location = New System.Drawing.Point(267, 369)
        Me.txt_garantia_producto.Name = "txt_garantia_producto"
        Me.txt_garantia_producto.Size = New System.Drawing.Size(46, 20)
        Me.txt_garantia_producto.TabIndex = 55
        '
        'cob_garantia_producto
        '
        Me.cob_garantia_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_garantia_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_garantia_producto.FormattingEnabled = True
        Me.cob_garantia_producto.Location = New System.Drawing.Point(124, 369)
        Me.cob_garantia_producto.Name = "cob_garantia_producto"
        Me.cob_garantia_producto.Size = New System.Drawing.Size(49, 21)
        Me.cob_garantia_producto.TabIndex = 53
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(24, 377)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Garantia"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(507, 215)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(74, 23)
        Me.Button12.TabIndex = 51
        Me.Button12.Text = "Agregar"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtg_grupo_precio_producto)
        Me.GroupBox3.Location = New System.Drawing.Point(513, 244)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 146)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grupo de Precios"
        '
        'dtg_grupo_precio_producto
        '
        Me.dtg_grupo_precio_producto.AllowUserToOrderColumns = True
        Me.dtg_grupo_precio_producto.BackgroundColor = System.Drawing.Color.White
        Me.dtg_grupo_precio_producto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_grupo_precio_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_grupo_precio_producto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg_grupo_precio_producto.Location = New System.Drawing.Point(3, 16)
        Me.dtg_grupo_precio_producto.Name = "dtg_grupo_precio_producto"
        Me.dtg_grupo_precio_producto.Size = New System.Drawing.Size(436, 127)
        Me.dtg_grupo_precio_producto.TabIndex = 0
        '
        'btn_salir_producto
        '
        Me.btn_salir_producto.Location = New System.Drawing.Point(835, 399)
        Me.btn_salir_producto.Name = "btn_salir_producto"
        Me.btn_salir_producto.Size = New System.Drawing.Size(120, 23)
        Me.btn_salir_producto.TabIndex = 48
        Me.btn_salir_producto.Text = "Salir"
        Me.btn_salir_producto.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.foto_producto)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 201)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fotografia"
        '
        'foto_producto
        '
        Me.foto_producto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.foto_producto.Location = New System.Drawing.Point(3, 16)
        Me.foto_producto.Name = "foto_producto"
        Me.foto_producto.Size = New System.Drawing.Size(144, 182)
        Me.foto_producto.TabIndex = 0
        Me.foto_producto.TabStop = False
        '
        'orden_producto
        '
        Me.orden_producto.Location = New System.Drawing.Point(123, 423)
        Me.orden_producto.Name = "orden_producto"
        Me.orden_producto.Size = New System.Drawing.Size(50, 20)
        Me.orden_producto.TabIndex = 46
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(24, 426)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 13)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Orden"
        '
        'cob_pesaje_producto
        '
        Me.cob_pesaje_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_pesaje_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_pesaje_producto.FormattingEnabled = True
        Me.cob_pesaje_producto.Location = New System.Drawing.Point(239, 395)
        Me.cob_pesaje_producto.Name = "cob_pesaje_producto"
        Me.cob_pesaje_producto.Size = New System.Drawing.Size(74, 21)
        Me.cob_pesaje_producto.TabIndex = 43
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(194, 399)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Pesaje"
        '
        'cob_mostrar_pos
        '
        Me.cob_mostrar_pos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_mostrar_pos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_mostrar_pos.FormattingEnabled = True
        Me.cob_mostrar_pos.Location = New System.Drawing.Point(124, 396)
        Me.cob_mostrar_pos.Name = "cob_mostrar_pos"
        Me.cob_mostrar_pos.Size = New System.Drawing.Size(64, 21)
        Me.cob_mostrar_pos.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 403)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Mostar en el pos"
        '
        'txt_stock_minimo_producto
        '
        Me.txt_stock_minimo_producto.Location = New System.Drawing.Point(124, 342)
        Me.txt_stock_minimo_producto.Name = "txt_stock_minimo_producto"
        Me.txt_stock_minimo_producto.Size = New System.Drawing.Size(162, 20)
        Me.txt_stock_minimo_producto.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 349)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Stock Minimo"
        '
        'dt_vencimiento_producto
        '
        Me.dt_vencimiento_producto.Location = New System.Drawing.Point(124, 316)
        Me.dt_vencimiento_producto.Name = "dt_vencimiento_producto"
        Me.dt_vencimiento_producto.Size = New System.Drawing.Size(200, 20)
        Me.dt_vencimiento_producto.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Fecha Vencimiento"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(292, 286)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 23)
        Me.Button6.TabIndex = 26
        Me.Button6.UseVisualStyleBackColor = True
        '
        'cob_marca_producto
        '
        Me.cob_marca_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_marca_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_marca_producto.FormattingEnabled = True
        Me.cob_marca_producto.Location = New System.Drawing.Point(124, 288)
        Me.cob_marca_producto.Name = "cob_marca_producto"
        Me.cob_marca_producto.Size = New System.Drawing.Size(162, 21)
        Me.cob_marca_producto.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 296)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Marca"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(292, 259)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 23)
        Me.Button5.TabIndex = 23
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cob_proveedor_producto
        '
        Me.cob_proveedor_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_proveedor_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_proveedor_producto.FormattingEnabled = True
        Me.cob_proveedor_producto.Location = New System.Drawing.Point(124, 261)
        Me.cob_proveedor_producto.Name = "cob_proveedor_producto"
        Me.cob_proveedor_producto.Size = New System.Drawing.Size(162, 21)
        Me.cob_proveedor_producto.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Proveedor"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(292, 232)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(292, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(292, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cob_presentacion_producto
        '
        Me.cob_presentacion_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_presentacion_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_presentacion_producto.FormattingEnabled = True
        Me.cob_presentacion_producto.Location = New System.Drawing.Point(124, 234)
        Me.cob_presentacion_producto.Name = "cob_presentacion_producto"
        Me.cob_presentacion_producto.Size = New System.Drawing.Size(162, 21)
        Me.cob_presentacion_producto.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Presentacion"
        '
        'cob_subcategoria_producto
        '
        Me.cob_subcategoria_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_subcategoria_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_subcategoria_producto.FormattingEnabled = True
        Me.cob_subcategoria_producto.Location = New System.Drawing.Point(124, 207)
        Me.cob_subcategoria_producto.Name = "cob_subcategoria_producto"
        Me.cob_subcategoria_producto.Size = New System.Drawing.Size(162, 21)
        Me.cob_subcategoria_producto.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Subcategoria"
        '
        'cob_categoria_producto
        '
        Me.cob_categoria_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_categoria_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_categoria_producto.FormattingEnabled = True
        Me.cob_categoria_producto.Location = New System.Drawing.Point(124, 180)
        Me.cob_categoria_producto.Name = "cob_categoria_producto"
        Me.cob_categoria_producto.Size = New System.Drawing.Size(162, 21)
        Me.cob_categoria_producto.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Categoria"
        '
        'txt_referencia_producto
        '
        Me.txt_referencia_producto.Location = New System.Drawing.Point(124, 154)
        Me.txt_referencia_producto.Name = "txt_referencia_producto"
        Me.txt_referencia_producto.Size = New System.Drawing.Size(88, 20)
        Me.txt_referencia_producto.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Referencia"
        '
        'txt_descripcion_producto
        '
        Me.txt_descripcion_producto.Location = New System.Drawing.Point(124, 95)
        Me.txt_descripcion_producto.Multiline = True
        Me.txt_descripcion_producto.Name = "txt_descripcion_producto"
        Me.txt_descripcion_producto.Size = New System.Drawing.Size(316, 53)
        Me.txt_descripcion_producto.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Descripcion"
        '
        'txt_producto
        '
        Me.txt_producto.Location = New System.Drawing.Point(124, 69)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(316, 20)
        Me.txt_producto.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Producto"
        '
        'txt_codigo_producto
        '
        Me.txt_codigo_producto.Location = New System.Drawing.Point(124, 43)
        Me.txt_codigo_producto.Name = "txt_codigo_producto"
        Me.txt_codigo_producto.Size = New System.Drawing.Size(211, 20)
        Me.txt_codigo_producto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo"
        '
        'btn_buscar_tipo_producto
        '
        Me.btn_buscar_tipo_producto.Location = New System.Drawing.Point(293, 13)
        Me.btn_buscar_tipo_producto.Name = "btn_buscar_tipo_producto"
        Me.btn_buscar_tipo_producto.Size = New System.Drawing.Size(27, 23)
        Me.btn_buscar_tipo_producto.TabIndex = 3
        Me.btn_buscar_tipo_producto.UseVisualStyleBackColor = True
        '
        'cob_tipo_producto
        '
        Me.cob_tipo_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cob_tipo_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cob_tipo_producto.FormattingEnabled = True
        Me.cob_tipo_producto.Location = New System.Drawing.Point(124, 16)
        Me.cob_tipo_producto.Name = "cob_tipo_producto"
        Me.cob_tipo_producto.Size = New System.Drawing.Size(162, 21)
        Me.cob_tipo_producto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de producto"
        '
        'btn_guardar_producto
        '
        Me.btn_guardar_producto.Location = New System.Drawing.Point(709, 399)
        Me.btn_guardar_producto.Name = "btn_guardar_producto"
        Me.btn_guardar_producto.Size = New System.Drawing.Size(120, 23)
        Me.btn_guardar_producto.TabIndex = 0
        Me.btn_guardar_producto.Text = "Guardar"
        Me.btn_guardar_producto.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1049, 482)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Inventario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(1075, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(180, 461)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ultimo producto registrado"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 532)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_productos"
        Me.Text = "Productos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtg_grupo_precio_producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.foto_producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btn_buscar_tipo_producto As System.Windows.Forms.Button
    Friend WithEvents cob_tipo_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar_producto As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_referencia_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cob_subcategoria_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cob_categoria_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cob_presentacion_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cob_proveedor_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dt_vencimiento_producto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cob_marca_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_stock_minimo_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cob_mostrar_pos As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_salir_producto As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents foto_producto As System.Windows.Forms.PictureBox
    Friend WithEvents orden_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cob_pesaje_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtg_grupo_precio_producto As System.Windows.Forms.DataGridView
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents txt_garantia_producto As System.Windows.Forms.TextBox
    Friend WithEvents cob_garantia_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cob_frecuencia As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cob_mt_fiscal_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents cob_iva_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_costo_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_inv_inicial_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_venta_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_margen_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cob_bodega As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cob_variacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_registro_invima As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txt_lote As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cob_laboratorio As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
