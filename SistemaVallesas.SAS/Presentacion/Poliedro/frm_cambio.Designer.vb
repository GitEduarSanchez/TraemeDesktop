<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cambio
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
        Me.lbl_total_pos = New System.Windows.Forms.Label()
        Me.txt_efectivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cambio = New System.Windows.Forms.Label()
        Me.date_fecha_pos = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tarjeta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_total_pos
        '
        Me.lbl_total_pos.AutoSize = True
        Me.lbl_total_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_pos.ForeColor = System.Drawing.Color.Teal
        Me.lbl_total_pos.Location = New System.Drawing.Point(415, 9)
        Me.lbl_total_pos.Name = "lbl_total_pos"
        Me.lbl_total_pos.Size = New System.Drawing.Size(235, 108)
        Me.lbl_total_pos.TabIndex = 7
        Me.lbl_total_pos.Text = "0.00"
        '
        'txt_efectivo
        '
        Me.txt_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_efectivo.Location = New System.Drawing.Point(429, 142)
        Me.txt_efectivo.Multiline = True
        Me.txt_efectivo.Name = "txt_efectivo"
        Me.txt_efectivo.Size = New System.Drawing.Size(628, 114)
        Me.txt_efectivo.TabIndex = 9
        Me.txt_efectivo.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(29, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 108)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Efectivo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(29, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 108)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(29, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(380, 108)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cambio"
        '
        'lbl_cambio
        '
        Me.lbl_cambio.AutoSize = True
        Me.lbl_cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cambio.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_cambio.Location = New System.Drawing.Point(415, 374)
        Me.lbl_cambio.Name = "lbl_cambio"
        Me.lbl_cambio.Size = New System.Drawing.Size(235, 108)
        Me.lbl_cambio.TabIndex = 14
        Me.lbl_cambio.Text = "0.00"
        '
        'date_fecha_pos
        '
        Me.date_fecha_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_fecha_pos.Location = New System.Drawing.Point(47, 507)
        Me.date_fecha_pos.Name = "date_fecha_pos"
        Me.date_fecha_pos.Size = New System.Drawing.Size(933, 80)
        Me.date_fecha_pos.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(61, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "F1 CLIENTE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 43)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "F2 CREDITO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(234, 105)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 43)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "F3 TIPO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(29, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(350, 108)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tarjeta"
        '
        'txt_tarjeta
        '
        Me.txt_tarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tarjeta.Location = New System.Drawing.Point(429, 262)
        Me.txt_tarjeta.Multiline = True
        Me.txt_tarjeta.Name = "txt_tarjeta"
        Me.txt_tarjeta.Size = New System.Drawing.Size(628, 114)
        Me.txt_tarjeta.TabIndex = 21
        Me.txt_tarjeta.Text = "0"
        '
        'frm_cambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 603)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_tarjeta)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.date_fecha_pos)
        Me.Controls.Add(Me.lbl_cambio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_efectivo)
        Me.Controls.Add(Me.lbl_total_pos)
        Me.Name = "frm_cambio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_total_pos As System.Windows.Forms.Label
    Friend WithEvents txt_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_cambio As System.Windows.Forms.Label
    Friend WithEvents date_fecha_pos As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_tarjeta As System.Windows.Forms.TextBox
End Class
