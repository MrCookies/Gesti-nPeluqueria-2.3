<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblNombreLogin = New System.Windows.Forms.Label()
        Me.lblpassLogin = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombreLogin
        '
        Me.lblNombreLogin.AutoSize = True
        Me.lblNombreLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreLogin.Location = New System.Drawing.Point(60, 113)
        Me.lblNombreLogin.Name = "lblNombreLogin"
        Me.lblNombreLogin.Size = New System.Drawing.Size(100, 25)
        Me.lblNombreLogin.TabIndex = 0
        Me.lblNombreLogin.Text = "Nombre:"
        '
        'lblpassLogin
        '
        Me.lblpassLogin.AutoSize = True
        Me.lblpassLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassLogin.Location = New System.Drawing.Point(60, 190)
        Me.lblpassLogin.Name = "lblpassLogin"
        Me.lblpassLogin.Size = New System.Drawing.Size(140, 25)
        Me.lblpassLogin.TabIndex = 1
        Me.lblpassLogin.Text = "Contraseña:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(238, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(238, 196)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(232, 20)
        Me.TextBox2.TabIndex = 3
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(125, 244)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "Log in"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(417, 244)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 300)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblpassLogin)
        Me.Controls.Add(Me.lblNombreLogin)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreLogin As System.Windows.Forms.Label
    Friend WithEvents lblpassLogin As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
