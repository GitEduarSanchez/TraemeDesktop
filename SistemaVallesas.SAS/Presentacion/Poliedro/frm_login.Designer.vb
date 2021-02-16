<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.Login = New System.Windows.Forms.GroupBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Controls.Add(Me.txt_clave)
        Me.Login.Controls.Add(Me.txt_usuario)
        Me.Login.Controls.Add(Me.Button1)
        Me.Login.Controls.Add(Me.Label2)
        Me.Login.Controls.Add(Me.Label1)
        Me.Login.Location = New System.Drawing.Point(12, 12)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(303, 147)
        Me.Login.TabIndex = 5
        Me.Login.TabStop = False
        Me.Login.Text = "Login"
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(129, 54)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(139, 20)
        Me.txt_clave.TabIndex = 9
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(129, 19)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(139, 20)
        Me.txt_usuario.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuario"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 171)
        Me.Controls.Add(Me.Login)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Login.ResumeLayout(False)
        Me.Login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Login As System.Windows.Forms.GroupBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
