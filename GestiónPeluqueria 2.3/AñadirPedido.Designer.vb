<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirPedido
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
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.cmbProveedores = New System.Windows.Forms.ComboBox()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpPedidos = New System.Windows.Forms.DateTimePicker()
        Me.lblCantidade = New System.Windows.Forms.Label()
        Me.txtbCantidade = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.btnCancelarPedido = New System.Windows.Forms.Button()
        Me.btnEngadirPedido = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(12, 38)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(53, 13)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Producto:"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(12, 150)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(59, 13)
        Me.lblProveedor.TabIndex = 1
        Me.lblProveedor.Text = "Proveedor:"
        '
        'cmbProveedores
        '
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(112, 150)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(121, 21)
        Me.cmbProveedores.TabIndex = 2
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(112, 35)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(121, 21)
        Me.cmbProductos.TabIndex = 3
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(12, 204)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Fecha:"
        '
        'dtpPedidos
        '
        Me.dtpPedidos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPedidos.Location = New System.Drawing.Point(112, 204)
        Me.dtpPedidos.Name = "dtpPedidos"
        Me.dtpPedidos.Size = New System.Drawing.Size(121, 20)
        Me.dtpPedidos.TabIndex = 5
        '
        'lblCantidade
        '
        Me.lblCantidade.AutoSize = True
        Me.lblCantidade.Location = New System.Drawing.Point(12, 94)
        Me.lblCantidade.Name = "lblCantidade"
        Me.lblCantidade.Size = New System.Drawing.Size(58, 13)
        Me.lblCantidade.TabIndex = 6
        Me.lblCantidade.Text = "Cantidade:"
        '
        'txtbCantidade
        '
        Me.txtbCantidade.Location = New System.Drawing.Point(112, 91)
        Me.txtbCantidade.Name = "txtbCantidade"
        Me.txtbCantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtbCantidade.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(12, 267)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(37, 13)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total: "
        '
        'lblPrecioTotal
        '
        Me.lblPrecioTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTotal.Location = New System.Drawing.Point(112, 267)
        Me.lblPrecioTotal.Name = "lblPrecioTotal"
        Me.lblPrecioTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblPrecioTotal.TabIndex = 9
        Me.lblPrecioTotal.Text = "0"
        Me.lblPrecioTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCancelarPedido
        '
        Me.btnCancelarPedido.Location = New System.Drawing.Point(201, 315)
        Me.btnCancelarPedido.Name = "btnCancelarPedido"
        Me.btnCancelarPedido.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarPedido.TabIndex = 11
        Me.btnCancelarPedido.Text = "Cerrar"
        Me.btnCancelarPedido.UseVisualStyleBackColor = True
        '
        'btnEngadirPedido
        '
        Me.btnEngadirPedido.Location = New System.Drawing.Point(15, 315)
        Me.btnEngadirPedido.Name = "btnEngadirPedido"
        Me.btnEngadirPedido.Size = New System.Drawing.Size(75, 23)
        Me.btnEngadirPedido.TabIndex = 10
        Me.btnEngadirPedido.Text = "Aceptar"
        Me.btnEngadirPedido.UseVisualStyleBackColor = True
        '
        'AñadirPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 372)
        Me.Controls.Add(Me.btnCancelarPedido)
        Me.Controls.Add(Me.btnEngadirPedido)
        Me.Controls.Add(Me.lblPrecioTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtbCantidade)
        Me.Controls.Add(Me.lblCantidade)
        Me.Controls.Add(Me.dtpPedidos)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.cmbProveedores)
        Me.Controls.Add(Me.lblProveedor)
        Me.Controls.Add(Me.lblProducto)
        Me.Name = "AñadirPedido"
        Me.Text = "AñadirPedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProducto As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents cmbProveedores As ComboBox
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpPedidos As DateTimePicker
    Friend WithEvents lblCantidade As Label
    Friend WithEvents txtbCantidade As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents btnCancelarPedido As Button
    Friend WithEvents btnEngadirPedido As Button
End Class
