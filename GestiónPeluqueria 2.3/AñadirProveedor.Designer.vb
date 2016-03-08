<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirProveedor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtboxApellidos = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtboxdni = New System.Windows.Forms.TextBox()
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.btnEngadirProducto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxNombre = New System.Windows.Forms.TextBox()
        Me.lblprecioCompra = New System.Windows.Forms.Label()
        Me.txtBoxEmpresa = New System.Windows.Forms.TextBox()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxTelefono = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtboxApellidos
        '
        Me.txtboxApellidos.Location = New System.Drawing.Point(97, 123)
        Me.txtboxApellidos.MaxLength = 40
        Me.txtboxApellidos.Name = "txtboxApellidos"
        Me.txtboxApellidos.Size = New System.Drawing.Size(177, 20)
        Me.txtboxApellidos.TabIndex = 15
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(26, 126)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(52, 13)
        Me.lblStock.TabIndex = 14
        Me.lblStock.Text = "Apellidos:"
        '
        'txtboxdni
        '
        Me.txtboxdni.Location = New System.Drawing.Point(97, 171)
        Me.txtboxdni.MaxLength = 40
        Me.txtboxdni.Name = "txtboxdni"
        Me.txtboxdni.Size = New System.Drawing.Size(177, 20)
        Me.txtboxdni.TabIndex = 17
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Location = New System.Drawing.Point(173, 271)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarProducto.TabIndex = 19
        Me.btnCancelarProducto.Text = "Cerrar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'btnEngadirProducto
        '
        Me.btnEngadirProducto.Location = New System.Drawing.Point(56, 271)
        Me.btnEngadirProducto.Name = "btnEngadirProducto"
        Me.btnEngadirProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnEngadirProducto.TabIndex = 18
        Me.btnEngadirProducto.Text = "Aceptar"
        Me.btnEngadirProducto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "DNI:"
        '
        'txtBoxNombre
        '
        Me.txtBoxNombre.Location = New System.Drawing.Point(97, 74)
        Me.txtBoxNombre.MaxLength = 40
        Me.txtBoxNombre.Name = "txtBoxNombre"
        Me.txtBoxNombre.Size = New System.Drawing.Size(177, 20)
        Me.txtBoxNombre.TabIndex = 13
        '
        'lblprecioCompra
        '
        Me.lblprecioCompra.AutoSize = True
        Me.lblprecioCompra.Location = New System.Drawing.Point(26, 74)
        Me.lblprecioCompra.Name = "lblprecioCompra"
        Me.lblprecioCompra.Size = New System.Drawing.Size(47, 13)
        Me.lblprecioCompra.TabIndex = 12
        Me.lblprecioCompra.Text = "Nombre:"
        '
        'txtBoxEmpresa
        '
        Me.txtBoxEmpresa.Location = New System.Drawing.Point(97, 23)
        Me.txtBoxEmpresa.MaxLength = 25
        Me.txtBoxEmpresa.Name = "txtBoxEmpresa"
        Me.txtBoxEmpresa.Size = New System.Drawing.Size(177, 20)
        Me.txtBoxEmpresa.TabIndex = 11
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(26, 26)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(51, 13)
        Me.lblNombreProducto.TabIndex = 10
        Me.lblNombreProducto.Text = "Empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Teléfono:"
        '
        'txtboxTelefono
        '
        Me.txtboxTelefono.Location = New System.Drawing.Point(97, 218)
        Me.txtboxTelefono.MaxLength = 40
        Me.txtboxTelefono.Name = "txtboxTelefono"
        Me.txtboxTelefono.Size = New System.Drawing.Size(177, 20)
        Me.txtboxTelefono.TabIndex = 21
        '
        'AñadirProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 323)
        Me.Controls.Add(Me.txtboxTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxApellidos)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txtboxdni)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnEngadirProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxNombre)
        Me.Controls.Add(Me.lblprecioCompra)
        Me.Controls.Add(Me.txtBoxEmpresa)
        Me.Controls.Add(Me.lblNombreProducto)
        Me.Name = "AñadirProveedor"
        Me.Text = "AñadirProveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxApellidos As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents txtboxdni As TextBox
    Friend WithEvents btnCancelarProducto As Button
    Friend WithEvents btnEngadirProducto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxNombre As TextBox
    Friend WithEvents lblprecioCompra As Label
    Friend WithEvents txtBoxEmpresa As TextBox
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxTelefono As TextBox
End Class
