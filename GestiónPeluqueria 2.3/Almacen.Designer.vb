<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgProductos = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimeiro = New System.Windows.Forms.Button()
        Me.btnAcabar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbApellidos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnacabarbusca = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbbuscaProducto = New System.Windows.Forms.TextBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dtgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgProductos
        '
        Me.dtgProductos.AllowUserToAddRows = False
        Me.dtgProductos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProductos.Location = New System.Drawing.Point(12, 27)
        Me.dtgProductos.Name = "dtgProductos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgProductos.Size = New System.Drawing.Size(630, 360)
        Me.dtgProductos.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.PedidosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(829, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoProductoToolStripMenuItem, Me.ModificarProductoToolStripMenuItem, Me.EliminarProductoToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'NovoProductoToolStripMenuItem
        '
        Me.NovoProductoToolStripMenuItem.Name = "NovoProductoToolStripMenuItem"
        Me.NovoProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NovoProductoToolStripMenuItem.Text = "Novo Producto"
        '
        'ModificarProductoToolStripMenuItem
        '
        Me.ModificarProductoToolStripMenuItem.Name = "ModificarProductoToolStripMenuItem"
        Me.ModificarProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ModificarProductoToolStripMenuItem.Text = "Modificar Producto"
        '
        'EliminarProductoToolStripMenuItem
        '
        Me.EliminarProductoToolStripMenuItem.Name = "EliminarProductoToolStripMenuItem"
        Me.EliminarProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.EliminarProductoToolStripMenuItem.Text = "Eliminar Producto"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(543, 393)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(85, 23)
        Me.btnUltimo.TabIndex = 19
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(403, 393)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(85, 23)
        Me.btnSiguiente.TabIndex = 18
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(164, 393)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(85, 23)
        Me.btnAnterior.TabIndex = 17
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Location = New System.Drawing.Point(24, 393)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(85, 23)
        Me.btnPrimeiro.TabIndex = 16
        Me.btnPrimeiro.Text = "<<"
        Me.btnPrimeiro.UseVisualStyleBackColor = True
        '
        'btnAcabar
        '
        Me.btnAcabar.Location = New System.Drawing.Point(928, 363)
        Me.btnAcabar.Name = "btnAcabar"
        Me.btnAcabar.Size = New System.Drawing.Size(170, 23)
        Me.btnAcabar.TabIndex = 25
        Me.btnAcabar.Text = "Acabar búsqueda"
        Me.btnAcabar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(922, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Buscar por Apellido:"
        '
        'txtbApellidos
        '
        Me.txtbApellidos.Location = New System.Drawing.Point(925, 153)
        Me.txtbApellidos.Name = "txtbApellidos"
        Me.txtbApellidos.Size = New System.Drawing.Size(180, 20)
        Me.txtbApellidos.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(922, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Buscar por Nombre:"
        '
        'txtbBuscar
        '
        Me.txtbBuscar.Location = New System.Drawing.Point(925, 79)
        Me.txtbBuscar.Name = "txtbBuscar"
        Me.txtbBuscar.Size = New System.Drawing.Size(180, 20)
        Me.txtbBuscar.TabIndex = 21
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(928, 300)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(170, 23)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "Buscar Cliente"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnacabarbusca
        '
        Me.btnacabarbusca.Location = New System.Drawing.Point(648, 364)
        Me.btnacabarbusca.Name = "btnacabarbusca"
        Me.btnacabarbusca.Size = New System.Drawing.Size(170, 23)
        Me.btnacabarbusca.TabIndex = 31
        Me.btnacabarbusca.Text = "Acabar búsqueda"
        Me.btnacabarbusca.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(645, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Buscar por nombre:"
        '
        'txtbbuscaProducto
        '
        Me.txtbbuscaProducto.Location = New System.Drawing.Point(648, 49)
        Me.txtbbuscaProducto.Name = "txtbbuscaProducto"
        Me.txtbbuscaProducto.Size = New System.Drawing.Size(170, 20)
        Me.txtbbuscaProducto.TabIndex = 27
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Location = New System.Drawing.Point(648, 321)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(170, 23)
        Me.btnBuscarProducto.TabIndex = 26
        Me.btnBuscarProducto.Text = "Buscar Producto"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(284, 393)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(85, 23)
        Me.btnSalir.TabIndex = 43
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 425)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnacabarbusca)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbbuscaProducto)
        Me.Controls.Add(Me.btnBuscarProducto)
        Me.Controls.Add(Me.btnAcabar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbApellidos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimeiro)
        Me.Controls.Add(Me.dtgProductos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Almacen"
        Me.Text = "Almacen"
        CType(Me.dtgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgProductos As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimeiro As Button
    Friend WithEvents btnAcabar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbApellidos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnacabarbusca As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbbuscaProducto As TextBox
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSalir As Button
End Class
