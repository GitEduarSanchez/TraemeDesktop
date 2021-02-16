<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_huella
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_n = New System.Windows.Forms.Label()
        Me.pict_huella = New System.Windows.Forms.PictureBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pict_huella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_n)
        Me.GroupBox1.Controls.Add(Me.pict_huella)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 310)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Capturar Huella"
        '
        'lbl_n
        '
        Me.lbl_n.AutoSize = True
        Me.lbl_n.Location = New System.Drawing.Point(6, 288)
        Me.lbl_n.Name = "lbl_n"
        Me.lbl_n.Size = New System.Drawing.Size(11, 13)
        Me.lbl_n.TabIndex = 1
        Me.lbl_n.Text = "*"
        '
        'pict_huella
        '
        Me.pict_huella.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pict_huella.Location = New System.Drawing.Point(6, 31)
        Me.pict_huella.Name = "pict_huella"
        Me.pict_huella.Size = New System.Drawing.Size(188, 245)
        Me.pict_huella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pict_huella.TabIndex = 0
        Me.pict_huella.TabStop = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(26, 328)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(200, 23)
        Me.btn_aceptar.TabIndex = 1
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'frm_huella
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 368)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_huella"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pict_huella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pict_huella As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_n As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
End Class
