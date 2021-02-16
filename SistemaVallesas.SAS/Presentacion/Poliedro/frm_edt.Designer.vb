<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edt
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
        Me.btn_n0 = New System.Windows.Forms.Button()
        Me.btn_n1 = New System.Windows.Forms.Button()
        Me.btn_n2 = New System.Windows.Forms.Button()
        Me.btn_n3 = New System.Windows.Forms.Button()
        Me.btn_n4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtg_preliminares = New System.Windows.Forms.DataGridView()
        Me.btn_preliminares = New System.Windows.Forms.Button()
        Me.btn_movimiento_de_tierra = New System.Windows.Forms.Button()
        Me.btn_est_concreto = New System.Windows.Forms.Button()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actividades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subactividades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gb_1 = New System.Windows.Forms.GroupBox()
        Me.gb_2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtg_preliminares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_1.SuspendLayout()
        Me.gb_2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_n0
        '
        Me.btn_n0.Location = New System.Drawing.Point(20, 44)
        Me.btn_n0.Name = "btn_n0"
        Me.btn_n0.Size = New System.Drawing.Size(160, 56)
        Me.btn_n0.TabIndex = 0
        Me.btn_n0.Text = "Planta Nivel 0-N + 0.0"
        Me.btn_n0.UseVisualStyleBackColor = True
        '
        'btn_n1
        '
        Me.btn_n1.Location = New System.Drawing.Point(20, 106)
        Me.btn_n1.Name = "btn_n1"
        Me.btn_n1.Size = New System.Drawing.Size(160, 56)
        Me.btn_n1.TabIndex = 1
        Me.btn_n1.Text = "Planta Nivel 1-N + 3.70"
        Me.btn_n1.UseVisualStyleBackColor = True
        '
        'btn_n2
        '
        Me.btn_n2.Location = New System.Drawing.Point(20, 168)
        Me.btn_n2.Name = "btn_n2"
        Me.btn_n2.Size = New System.Drawing.Size(160, 56)
        Me.btn_n2.TabIndex = 2
        Me.btn_n2.Text = "Planta Nivel 2-N + 7.30"
        Me.btn_n2.UseVisualStyleBackColor = True
        '
        'btn_n3
        '
        Me.btn_n3.Location = New System.Drawing.Point(20, 230)
        Me.btn_n3.Name = "btn_n3"
        Me.btn_n3.Size = New System.Drawing.Size(160, 56)
        Me.btn_n3.TabIndex = 3
        Me.btn_n3.Text = "Planta Nivel 3-N + 10.90"
        Me.btn_n3.UseVisualStyleBackColor = True
        '
        'btn_n4
        '
        Me.btn_n4.Location = New System.Drawing.Point(20, 292)
        Me.btn_n4.Name = "btn_n4"
        Me.btn_n4.Size = New System.Drawing.Size(160, 56)
        Me.btn_n4.TabIndex = 4
        Me.btn_n4.Text = "Planta Nivel 4-N + 14.50"
        Me.btn_n4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Teal
        Me.Button6.Location = New System.Drawing.Point(394, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(401, 43)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "EDT EF.C.AA"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.gb_2)
        Me.GroupBox1.Controls.Add(Me.gb_1)
        Me.GroupBox1.Controls.Add(Me.lbl_descripcion)
        Me.GroupBox1.Controls.Add(Me.dtg_preliminares)
        Me.GroupBox1.Controls.Add(Me.btn_n0)
        Me.GroupBox1.Controls.Add(Me.btn_n1)
        Me.GroupBox1.Controls.Add(Me.btn_n4)
        Me.GroupBox1.Controls.Add(Me.btn_n2)
        Me.GroupBox1.Controls.Add(Me.btn_n3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1279, 449)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EDT UNIVERSIDAD FRANCISCO DE PAULA SANTANDER"
        '
        'dtg_preliminares
        '
        Me.dtg_preliminares.BackgroundColor = System.Drawing.Color.White
        Me.dtg_preliminares.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_preliminares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_preliminares.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.actividades, Me.subactividades})
        Me.dtg_preliminares.Location = New System.Drawing.Point(373, 44)
        Me.dtg_preliminares.Name = "dtg_preliminares"
        Me.dtg_preliminares.Size = New System.Drawing.Size(607, 319)
        Me.dtg_preliminares.TabIndex = 5
        '
        'btn_preliminares
        '
        Me.btn_preliminares.Location = New System.Drawing.Point(6, 19)
        Me.btn_preliminares.Name = "btn_preliminares"
        Me.btn_preliminares.Size = New System.Drawing.Size(160, 56)
        Me.btn_preliminares.TabIndex = 6
        Me.btn_preliminares.Text = "Preliminares"
        Me.btn_preliminares.UseVisualStyleBackColor = True
        '
        'btn_movimiento_de_tierra
        '
        Me.btn_movimiento_de_tierra.Location = New System.Drawing.Point(6, 81)
        Me.btn_movimiento_de_tierra.Name = "btn_movimiento_de_tierra"
        Me.btn_movimiento_de_tierra.Size = New System.Drawing.Size(160, 56)
        Me.btn_movimiento_de_tierra.TabIndex = 7
        Me.btn_movimiento_de_tierra.Text = "Movimiento de tierra"
        Me.btn_movimiento_de_tierra.UseVisualStyleBackColor = True
        '
        'btn_est_concreto
        '
        Me.btn_est_concreto.Location = New System.Drawing.Point(6, 143)
        Me.btn_est_concreto.Name = "btn_est_concreto"
        Me.btn_est_concreto.Size = New System.Drawing.Size(160, 56)
        Me.btn_est_concreto.TabIndex = 8
        Me.btn_est_concreto.Text = "Estructuras en concreto"
        Me.btn_est_concreto.UseVisualStyleBackColor = True
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.Location = New System.Drawing.Point(1015, 16)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(244, 276)
        Me.lbl_descripcion.TabIndex = 9
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'item
        '
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 50
        '
        'actividades
        '
        Me.actividades.HeaderText = "Actividades"
        Me.actividades.Name = "actividades"
        Me.actividades.ReadOnly = True
        Me.actividades.Width = 330
        '
        'subactividades
        '
        Me.subactividades.HeaderText = "Subactividades"
        Me.subactividades.Name = "subactividades"
        '
        'gb_1
        '
        Me.gb_1.Controls.Add(Me.btn_preliminares)
        Me.gb_1.Controls.Add(Me.btn_movimiento_de_tierra)
        Me.gb_1.Controls.Add(Me.btn_est_concreto)
        Me.gb_1.Location = New System.Drawing.Point(186, 44)
        Me.gb_1.Name = "gb_1"
        Me.gb_1.Size = New System.Drawing.Size(181, 229)
        Me.gb_1.TabIndex = 10
        Me.gb_1.TabStop = False
        '
        'gb_2
        '
        Me.gb_2.Controls.Add(Me.Button4)
        Me.gb_2.Controls.Add(Me.Button1)
        Me.gb_2.Controls.Add(Me.Button2)
        Me.gb_2.Controls.Add(Me.Button3)
        Me.gb_2.Location = New System.Drawing.Point(186, 106)
        Me.gb_2.Name = "gb_2"
        Me.gb_2.Size = New System.Drawing.Size(181, 288)
        Me.gb_2.TabIndex = 11
        Me.gb_2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 56)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Estructuras en concreto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 56)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Manmposteria y acabados"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 56)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Instalaciones"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 205)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 56)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Urbanismo y Accesos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frm_edt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1283, 523)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Name = "frm_edt"
        Me.Text = "EDT"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtg_preliminares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_1.ResumeLayout(False)
        Me.gb_2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_n0 As System.Windows.Forms.Button
    Friend WithEvents btn_n1 As System.Windows.Forms.Button
    Friend WithEvents btn_n2 As System.Windows.Forms.Button
    Friend WithEvents btn_n3 As System.Windows.Forms.Button
    Friend WithEvents btn_n4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtg_preliminares As System.Windows.Forms.DataGridView
    Friend WithEvents btn_est_concreto As System.Windows.Forms.Button
    Friend WithEvents btn_movimiento_de_tierra As System.Windows.Forms.Button
    Friend WithEvents btn_preliminares As System.Windows.Forms.Button
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actividades As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subactividades As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gb_1 As System.Windows.Forms.GroupBox
    Friend WithEvents gb_2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
