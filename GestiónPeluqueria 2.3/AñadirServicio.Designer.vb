<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirServicio
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
        Me.txtboxDuracion = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtboxPrecio = New System.Windows.Forms.TextBox()
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.btnEngadirServicio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxNombre = New System.Windows.Forms.TextBox()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtboxDuracion
        '
        Me.txtboxDuracion.Location = New System.Drawing.Point(95, 70)
        Me.txtboxDuracion.MaxLength = 40
        Me.txtboxDuracion.Name = "txtboxDuracion"
        Me.txtboxDuracion.Size = New System.Drawing.Size(177, 20)
        Me.txtboxDuracion.TabIndex = 27
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(24, 70)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(53, 13)
        Me.lblStock.TabIndex = 26
        Me.lblStock.Text = "Duracion:"
        '
        'txtboxPrecio
        '
        Me.txtboxPrecio.Location = New System.Drawing.Point(95, 112)
        Me.txtboxPrecio.MaxLength = 40
        Me.txtboxPrecio.Name = "txtboxPrecio"
        Me.txtboxPrecio.Size = New System.Drawing.Size(177, 20)
        Me.txtboxPrecio.TabIndex = 29
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Location = New System.Drawing.Point(171, 275)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarProducto.TabIndex = 31
        Me.btnCancelarProducto.Text = "Cerrar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'btnEngadirServicio
        '
        Me.btnEngadirServicio.Location = New System.Drawing.Point(54, 275)
        Me.btnEngadirServicio.Name = "btnEngadirServicio"
        Me.btnEngadirServicio.Size = New System.Drawing.Size(75, 23)
        Me.btnEngadirServicio.TabIndex = 30
        Me.btnEngadirServicio.Text = "Aceptar"
        Me.btnEngadirServicio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Precio:"
        '
        'txtBoxNombre
        '
        Me.txtBoxNombre.Location = New System.Drawing.Point(95, 27)
        Me.txtBoxNombre.MaxLength = 40
        Me.txtBoxNombre.Name = "txtBoxNombre"
        Me.txtBoxNombre.Size = New System.Drawing.Size(177, 20)
        Me.txtBoxNombre.TabIndex = 25
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(24, 30)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreProducto.TabIndex = 22
        Me.lblNombreProducto.Text = "Nombre:"
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(95, 160)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(121, 21)
        Me.cmbProductos.TabIndex = 33
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(25, 163)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(53, 13)
        Me.lblProducto.TabIndex = 32
        Me.lblProducto.Text = "Producto:"
        '
        'AñadirServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 375)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.txtboxDuracion)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txtboxPrecio)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnEngadirServicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxNombre)
        Me.Controls.Add(Me.lblNombreProducto)
        Me.Name = "AñadirServicio"
        Me.Text = "AñadirServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxDuracion As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents txtboxPrecio As TextBox
    Friend WithEvents btnCancelarProducto As Button
    Friend WithEvents btnEngadirServicio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxNombre As TextBox
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents lblProducto As Label
End Class
