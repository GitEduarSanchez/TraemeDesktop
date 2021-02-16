<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cantidad_pos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cantidad_pos = New System.Windows.Forms.TextBox()
        Me.btn_aceptar_cnt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad"
        '
        'txt_cantidad_pos
        '
        Me.txt_cantidad_pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad_pos.Location = New System.Drawing.Point(102, 14)
        Me.txt_cantidad_pos.Multiline = True
        Me.txt_cantidad_pos.Name = "txt_cantidad_pos"
        Me.txt_cantidad_pos.Size = New System.Drawing.Size(149, 32)
        Me.txt_cantidad_pos.TabIndex = 1
        Me.txt_cantidad_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_aceptar_cnt
        '
        Me.btn_aceptar_cnt.Location = New System.Drawing.Point(102, 60)
        Me.btn_aceptar_cnt.Name = "btn_aceptar_cnt"
        Me.btn_aceptar_cnt.Size = New System.Drawing.Size(93, 35)
        Me.btn_aceptar_cnt.TabIndex = 2
        Me.btn_aceptar_cnt.Text = "Aceptar"
        Me.btn_aceptar_cnt.UseVisualStyleBackColor = True
        '
        'frm_cantidad_pos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 107)
        Me.Controls.Add(Me.btn_aceptar_cnt)
        Me.Controls.Add(Me.txt_cantidad_pos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_cantidad_pos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_pos As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar_cnt As System.Windows.Forms.Button
End Class
