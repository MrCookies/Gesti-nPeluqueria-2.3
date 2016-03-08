<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimeiro = New System.Windows.Forms.Button()
        Me.dtgPedidos = New System.Windows.Forms.DataGridView()
        Me.grpboxProducto = New System.Windows.Forms.GroupBox()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.lblcompraProducto = New System.Windows.Forms.Label()
        Me.lblstockProducto = New System.Windows.Forms.Label()
        Me.lblPVPProducto = New System.Windows.Forms.Label()
        Me.lblIDProducto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpboxProveedor = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblApellidosProveedor = New System.Windows.Forms.Label()
        Me.lblNombreProveedor = New System.Windows.Forms.Label()
        Me.lblDNIProveedor = New System.Windows.Forms.Label()
        Me.lblEmpresaProveedor = New System.Windows.Forms.Label()
        Me.lbltlfProveedor = New System.Windows.Forms.Label()
        Me.lblIDProveedor = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBuscarPedido = New System.Windows.Forms.Button()
        Me.btnacabarPedido = New System.Windows.Forms.Button()
        Me.txtboxPrecioBusca = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpboxprecioBusca = New System.Windows.Forms.GroupBox()
        Me.rdbtnmaisPrecio = New System.Windows.Forms.RadioButton()
        Me.rdbtnmenosPrecio = New System.Windows.Forms.RadioButton()
        Me.rdbtnigualPrecio = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NovoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdbtnFecha = New System.Windows.Forms.RadioButton()
        CType(Me.dtgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxProducto.SuspendLayout()
        Me.grpboxProveedor.SuspendLayout()
        Me.grpboxprecioBusca.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(442, 398)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(85, 23)
        Me.btnUltimo.TabIndex = 27
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(315, 398)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(85, 23)
        Me.btnSiguiente.TabIndex = 26
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(147, 398)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(85, 23)
        Me.btnAnterior.TabIndex = 25
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Location = New System.Drawing.Point(14, 398)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(85, 23)
        Me.btnPrimeiro.TabIndex = 24
        Me.btnPrimeiro.Text = "<<"
        Me.btnPrimeiro.UseVisualStyleBackColor = True
        '
        'dtgPedidos
        '
        Me.dtgPedidos.AllowUserToAddRows = False
        Me.dtgPedidos.AllowUserToDeleteRows = False
        Me.dtgPedidos.AllowUserToResizeColumns = False
        Me.dtgPedidos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPedidos.Location = New System.Drawing.Point(14, 27)
        Me.dtgPedidos.Name = "dtgPedidos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPedidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgPedidos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgPedidos.Size = New System.Drawing.Size(513, 360)
        Me.dtgPedidos.TabIndex = 20
        '
        'grpboxProducto
        '
        Me.grpboxProducto.Controls.Add(Me.lblNombreProducto)
        Me.grpboxProducto.Controls.Add(Me.lblcompraProducto)
        Me.grpboxProducto.Controls.Add(Me.lblstockProducto)
        Me.grpboxProducto.Controls.Add(Me.lblPVPProducto)
        Me.grpboxProducto.Controls.Add(Me.lblIDProducto)
        Me.grpboxProducto.Controls.Add(Me.Label5)
        Me.grpboxProducto.Controls.Add(Me.Label4)
        Me.grpboxProducto.Controls.Add(Me.Label3)
        Me.grpboxProducto.Controls.Add(Me.Label2)
        Me.grpboxProducto.Controls.Add(Me.Label1)
        Me.grpboxProducto.Location = New System.Drawing.Point(544, 27)
        Me.grpboxProducto.Name = "grpboxProducto"
        Me.grpboxProducto.Size = New System.Drawing.Size(235, 210)
        Me.grpboxProducto.TabIndex = 28
        Me.grpboxProducto.TabStop = False
        Me.grpboxProducto.Text = "Producto"
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProducto.Location = New System.Drawing.Point(82, 68)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(2, 15)
        Me.lblNombreProducto.TabIndex = 9
        '
        'lblcompraProducto
        '
        Me.lblcompraProducto.AutoSize = True
        Me.lblcompraProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcompraProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcompraProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompraProducto.Location = New System.Drawing.Point(82, 145)
        Me.lblcompraProducto.Name = "lblcompraProducto"
        Me.lblcompraProducto.Size = New System.Drawing.Size(2, 15)
        Me.lblcompraProducto.TabIndex = 8
        '
        'lblstockProducto
        '
        Me.lblstockProducto.AutoSize = True
        Me.lblstockProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblstockProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblstockProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstockProducto.Location = New System.Drawing.Point(82, 104)
        Me.lblstockProducto.Name = "lblstockProducto"
        Me.lblstockProducto.Size = New System.Drawing.Size(2, 15)
        Me.lblstockProducto.TabIndex = 7
        '
        'lblPVPProducto
        '
        Me.lblPVPProducto.AutoSize = True
        Me.lblPVPProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPVPProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPVPProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPVPProducto.Location = New System.Drawing.Point(82, 183)
        Me.lblPVPProducto.Name = "lblPVPProducto"
        Me.lblPVPProducto.Size = New System.Drawing.Size(2, 15)
        Me.lblPVPProducto.TabIndex = 6
        '
        'lblIDProducto
        '
        Me.lblIDProducto.AutoSize = True
        Me.lblIDProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIDProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIDProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDProducto.Location = New System.Drawing.Point(82, 32)
        Me.lblIDProducto.Name = "lblIDProducto"
        Me.lblIDProducto.Size = New System.Drawing.Size(2, 15)
        Me.lblIDProducto.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PVP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stock:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'grpboxProveedor
        '
        Me.grpboxProveedor.Controls.Add(Me.Label6)
        Me.grpboxProveedor.Controls.Add(Me.lblApellidosProveedor)
        Me.grpboxProveedor.Controls.Add(Me.lblNombreProveedor)
        Me.grpboxProveedor.Controls.Add(Me.lblDNIProveedor)
        Me.grpboxProveedor.Controls.Add(Me.lblEmpresaProveedor)
        Me.grpboxProveedor.Controls.Add(Me.lbltlfProveedor)
        Me.grpboxProveedor.Controls.Add(Me.lblIDProveedor)
        Me.grpboxProveedor.Controls.Add(Me.Label11)
        Me.grpboxProveedor.Controls.Add(Me.Label12)
        Me.grpboxProveedor.Controls.Add(Me.Label13)
        Me.grpboxProveedor.Controls.Add(Me.Label14)
        Me.grpboxProveedor.Controls.Add(Me.Label15)
        Me.grpboxProveedor.Location = New System.Drawing.Point(544, 260)
        Me.grpboxProveedor.Name = "grpboxProveedor"
        Me.grpboxProveedor.Size = New System.Drawing.Size(235, 239)
        Me.grpboxProveedor.TabIndex = 29
        Me.grpboxProveedor.TabStop = False
        Me.grpboxProveedor.Text = "Proveedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Teléfono:"
        '
        'lblApellidosProveedor
        '
        Me.lblApellidosProveedor.AutoSize = True
        Me.lblApellidosProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblApellidosProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblApellidosProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosProveedor.Location = New System.Drawing.Point(82, 138)
        Me.lblApellidosProveedor.Name = "lblApellidosProveedor"
        Me.lblApellidosProveedor.Size = New System.Drawing.Size(2, 15)
        Me.lblApellidosProveedor.TabIndex = 20
        '
        'lblNombreProveedor
        '
        Me.lblNombreProveedor.AutoSize = True
        Me.lblNombreProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProveedor.Location = New System.Drawing.Point(82, 97)
        Me.lblNombreProveedor.Name = "lblNombreProveedor"
        Me.lblNombreProveedor.Size = New System.Drawing.Size(2, 15)
        Me.lblNombreProveedor.TabIndex = 19
        '
        'lblDNIProveedor
        '
        Me.lblDNIProveedor.AutoSize = True
        Me.lblDNIProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDNIProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDNIProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNIProveedor.Location = New System.Drawing.Point(82, 176)
        Me.lblDNIProveedor.Name = "lblDNIProveedor"
        Me.lblDNIProveedor.Size = New System.Drawing.Size(2, 15)
        Me.lblDNIProveedor.TabIndex = 18
        '
        'lblEmpresaProveedor
        '
        Me.lblEmpresaProveedor.AutoSize = True
        Me.lblEmpresaProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEmpresaProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmpresaProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaProveedor.Location = New System.Drawing.Point(82, 61)
        Me.lblEmpresaProveedor.Name = "lblEmpresaProveedor"
        Me.lblEmpresaProveedor.Size = New System.Drawing.Size(2, 15)
        Me.lblEmpresaProveedor.TabIndex = 17
        '
        'lbltlfProveedor
        '
        Me.lbltlfProveedor.AutoSize = True
        Me.lbltlfProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltlfProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltlfProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltlfProveedor.Location = New System.Drawing.Point(82, 215)
        Me.lbltlfProveedor.Name = "lbltlfProveedor"
        Me.lbltlfProveedor.Size = New System.Drawing.Size(2, 15)
        Me.lbltlfProveedor.TabIndex = 16
        '
        'lblIDProveedor
        '
        Me.lblIDProveedor.AutoSize = True
        Me.lblIDProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIDProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIDProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDProveedor.Location = New System.Drawing.Point(82, 25)
        Me.lblIDProveedor.Name = "lblIDProveedor"
        Me.lblIDProveedor.Size = New System.Drawing.Size(2, 15)
        Me.lblIDProveedor.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "DNI:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Apellidos:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Empresa:"
        '
        'btnBuscarPedido
        '
        Me.btnBuscarPedido.Location = New System.Drawing.Point(14, 436)
        Me.btnBuscarPedido.Name = "btnBuscarPedido"
        Me.btnBuscarPedido.Size = New System.Drawing.Size(161, 23)
        Me.btnBuscarPedido.TabIndex = 30
        Me.btnBuscarPedido.Text = "Buscar Pedido"
        Me.btnBuscarPedido.UseVisualStyleBackColor = True
        '
        'btnacabarPedido
        '
        Me.btnacabarPedido.Location = New System.Drawing.Point(14, 465)
        Me.btnacabarPedido.Name = "btnacabarPedido"
        Me.btnacabarPedido.Size = New System.Drawing.Size(161, 23)
        Me.btnacabarPedido.TabIndex = 31
        Me.btnacabarPedido.Text = "Acabar Búsqueda"
        Me.btnacabarPedido.UseVisualStyleBackColor = True
        '
        'txtboxPrecioBusca
        '
        Me.txtboxPrecioBusca.Location = New System.Drawing.Point(255, 433)
        Me.txtboxPrecioBusca.Name = "txtboxPrecioBusca"
        Me.txtboxPrecioBusca.Size = New System.Drawing.Size(100, 20)
        Me.txtboxPrecioBusca.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 436)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Precio:"
        '
        'grpboxprecioBusca
        '
        Me.grpboxprecioBusca.Controls.Add(Me.rdbtnmaisPrecio)
        Me.grpboxprecioBusca.Controls.Add(Me.rdbtnmenosPrecio)
        Me.grpboxprecioBusca.Controls.Add(Me.rdbtnigualPrecio)
        Me.grpboxprecioBusca.Location = New System.Drawing.Point(395, 425)
        Me.grpboxprecioBusca.Name = "grpboxprecioBusca"
        Me.grpboxprecioBusca.Size = New System.Drawing.Size(111, 34)
        Me.grpboxprecioBusca.TabIndex = 42
        Me.grpboxprecioBusca.TabStop = False
        '
        'rdbtnmaisPrecio
        '
        Me.rdbtnmaisPrecio.AutoSize = True
        Me.rdbtnmaisPrecio.Location = New System.Drawing.Point(6, 9)
        Me.rdbtnmaisPrecio.Name = "rdbtnmaisPrecio"
        Me.rdbtnmaisPrecio.Size = New System.Drawing.Size(31, 17)
        Me.rdbtnmaisPrecio.TabIndex = 38
        Me.rdbtnmaisPrecio.Text = ">"
        Me.rdbtnmaisPrecio.UseVisualStyleBackColor = True
        '
        'rdbtnmenosPrecio
        '
        Me.rdbtnmenosPrecio.AutoSize = True
        Me.rdbtnmenosPrecio.Location = New System.Drawing.Point(80, 9)
        Me.rdbtnmenosPrecio.Name = "rdbtnmenosPrecio"
        Me.rdbtnmenosPrecio.Size = New System.Drawing.Size(31, 17)
        Me.rdbtnmenosPrecio.TabIndex = 40
        Me.rdbtnmenosPrecio.Text = "<"
        Me.rdbtnmenosPrecio.UseVisualStyleBackColor = True
        '
        'rdbtnigualPrecio
        '
        Me.rdbtnigualPrecio.AutoSize = True
        Me.rdbtnigualPrecio.Checked = True
        Me.rdbtnigualPrecio.Location = New System.Drawing.Point(43, 9)
        Me.rdbtnigualPrecio.Name = "rdbtnigualPrecio"
        Me.rdbtnigualPrecio.Size = New System.Drawing.Size(31, 17)
        Me.rdbtnigualPrecio.TabIndex = 39
        Me.rdbtnigualPrecio.TabStop = True
        Me.rdbtnigualPrecio.Text = "="
        Me.rdbtnigualPrecio.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoPedidoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(791, 24)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NovoPedidoToolStripMenuItem
        '
        Me.NovoPedidoToolStripMenuItem.Name = "NovoPedidoToolStripMenuItem"
        Me.NovoPedidoToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.NovoPedidoToolStripMenuItem.Text = "Novo Pedido"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(255, 467)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Fecha:"
        '
        'rdbtnFecha
        '
        Me.rdbtnFecha.AutoSize = True
        Me.rdbtnFecha.Checked = True
        Me.rdbtnFecha.Location = New System.Drawing.Point(395, 470)
        Me.rdbtnFecha.Name = "rdbtnFecha"
        Me.rdbtnFecha.Size = New System.Drawing.Size(83, 17)
        Me.rdbtnFecha.TabIndex = 41
        Me.rdbtnFecha.TabStop = True
        Me.rdbtnFecha.Text = "Incluir fecha"
        Me.rdbtnFecha.UseVisualStyleBackColor = True
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 505)
        Me.Controls.Add(Me.rdbtnFecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.grpboxprecioBusca)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtboxPrecioBusca)
        Me.Controls.Add(Me.btnacabarPedido)
        Me.Controls.Add(Me.btnBuscarPedido)
        Me.Controls.Add(Me.grpboxProveedor)
        Me.Controls.Add(Me.grpboxProducto)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimeiro)
        Me.Controls.Add(Me.dtgPedidos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        CType(Me.dtgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxProducto.ResumeLayout(False)
        Me.grpboxProducto.PerformLayout()
        Me.grpboxProveedor.ResumeLayout(False)
        Me.grpboxProveedor.PerformLayout()
        Me.grpboxprecioBusca.ResumeLayout(False)
        Me.grpboxprecioBusca.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimeiro As Button
    Friend WithEvents dtgPedidos As DataGridView
    Friend WithEvents grpboxProducto As GroupBox
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblcompraProducto As Label
    Friend WithEvents lblstockProducto As Label
    Friend WithEvents lblPVPProducto As Label
    Friend WithEvents lblIDProducto As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpboxProveedor As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblApellidosProveedor As Label
    Friend WithEvents lblNombreProveedor As Label
    Friend WithEvents lblDNIProveedor As Label
    Friend WithEvents lblEmpresaProveedor As Label
    Friend WithEvents lbltlfProveedor As Label
    Friend WithEvents lblIDProveedor As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnBuscarPedido As Button
    Friend WithEvents btnacabarPedido As Button
    Friend WithEvents txtboxPrecioBusca As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents grpboxprecioBusca As GroupBox
    Friend WithEvents rdbtnmaisPrecio As RadioButton
    Friend WithEvents rdbtnmenosPrecio As RadioButton
    Friend WithEvents rdbtnigualPrecio As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NovoPedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents rdbtnFecha As RadioButton
End Class
