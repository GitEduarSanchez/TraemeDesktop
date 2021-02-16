<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bolsa
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_valor_bolsa = New System.Windows.Forms.Label()
        Me.lbl_subtotal_bolsa = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(21, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 55)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Cantidad"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(244, 21)
        Me.txt_cantidad.Multiline = True
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(208, 54)
        Me.txt_cantidad.TabIndex = 72
        Me.txt_cantidad.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(21, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 55)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Valor"
        '
        'lbl_valor_bolsa
        '
        Me.lbl_valor_bolsa.AutoSize = True
        Me.lbl_valor_bolsa.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor_bolsa.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_valor_bolsa.Location = New System.Drawing.Point(234, 91)
        Me.lbl_valor_bolsa.Name = "lbl_valor_bolsa"
        Me.lbl_valor_bolsa.Size = New System.Drawing.Size(51, 55)
        Me.lbl_valor_bolsa.TabIndex = 76
        Me.lbl_valor_bolsa.Text = "0"
        '
        'lbl_subtotal_bolsa
        '
        Me.lbl_subtotal_bolsa.AutoSize = True
        Me.lbl_subtotal_bolsa.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal_bolsa.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_subtotal_bolsa.Location = New System.Drawing.Point(234, 161)
        Me.lbl_subtotal_bolsa.Name = "lbl_subtotal_bolsa"
        Me.lbl_subtotal_bolsa.Size = New System.Drawing.Size(51, 55)
        Me.lbl_subtotal_bolsa.TabIndex = 78
        Me.lbl_subtotal_bolsa.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(21, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 55)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Subtotal"
        '
        'frm_bolsa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 237)
        Me.Controls.Add(Me.lbl_subtotal_bolsa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_valor_bolsa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Name = "frm_bolsa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_valor_bolsa As System.Windows.Forms.Label
    Friend WithEvents lbl_subtotal_bolsa As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
