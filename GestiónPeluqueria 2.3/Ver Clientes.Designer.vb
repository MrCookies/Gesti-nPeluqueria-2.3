<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ver_Clientes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgClientes = New System.Windows.Forms.DataGridView()
        Me.mnStripClientes = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarPorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApellidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtbBuscar = New System.Windows.Forms.TextBox()
        Me.btnPrimeiro = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbApellidos = New System.Windows.Forms.TextBox()
        Me.btnAcabar = New System.Windows.Forms.Button()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnStripClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgClientes
        '
        Me.dtgClientes.AllowUserToAddRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgClientes.Location = New System.Drawing.Point(12, 36)
        Me.dtgClientes.Name = "dtgClientes"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dtgClientes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgClientes.Size = New System.Drawing.Size(795, 360)
        Me.dtgClientes.TabIndex = 2
        '
        'mnStripClientes
        '
        Me.mnStripClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.mnStripClientes.Location = New System.Drawing.Point(0, 0)
        Me.mnStripClientes.Name = "mnStripClientes"
        Me.mnStripClientes.Size = New System.Drawing.Size(1008, 24)
        Me.mnStripClientes.TabIndex = 6
        Me.mnStripClientes.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoClienteToolStripMenuItem, Me.ModificarClienteToolStripMenuItem, Me.EliminarClienteToolStripMenuItem, Me.OrdenarPorToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'NovoClienteToolStripMenuItem
        '
        Me.NovoClienteToolStripMenuItem.Name = "NovoClienteToolStripMenuItem"
        Me.NovoClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NovoClienteToolStripMenuItem.Text = "Novo Cliente"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar Cliente"
        '
        'EliminarClienteToolStripMenuItem
        '
        Me.EliminarClienteToolStripMenuItem.Name = "EliminarClienteToolStripMenuItem"
        Me.EliminarClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EliminarClienteToolStripMenuItem.Text = "Eliminar Cliente"
        '
        'OrdenarPorToolStripMenuItem
        '
        Me.OrdenarPorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NombreToolStripMenuItem, Me.ApellidosToolStripMenuItem, Me.EdadToolStripMenuItem})
        Me.OrdenarPorToolStripMenuItem.Name = "OrdenarPorToolStripMenuItem"
        Me.OrdenarPorToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.OrdenarPorToolStripMenuItem.Text = "Ordenar por..."
        '
        'NombreToolStripMenuItem
        '
        Me.NombreToolStripMenuItem.Name = "NombreToolStripMenuItem"
        Me.NombreToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.NombreToolStripMenuItem.Text = "Nombre"
        '
        'ApellidosToolStripMenuItem
        '
        Me.ApellidosToolStripMenuItem.Name = "ApellidosToolStripMenuItem"
        Me.ApellidosToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ApellidosToolStripMenuItem.Text = "Apellidos"
        '
        'EdadToolStripMenuItem
        '
        Me.EdadToolStripMenuItem.Name = "EdadToolStripMenuItem"
        Me.EdadToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.EdadToolStripMenuItem.Text = "Edad"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(816, 344)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(170, 23)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar Cliente"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtbBuscar
        '
        Me.txtbBuscar.Location = New System.Drawing.Point(816, 47)
        Me.txtbBuscar.Name = "txtbBuscar"
        Me.txtbBuscar.Size = New System.Drawing.Size(180, 20)
        Me.txtbBuscar.TabIndex = 8
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Location = New System.Drawing.Point(12, 402)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(170, 23)
        Me.btnPrimeiro.TabIndex = 9
        Me.btnPrimeiro.Text = "<<"
        Me.btnPrimeiro.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(214, 402)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(170, 23)
        Me.btnAnterior.TabIndex = 10
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(430, 402)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(170, 23)
        Me.btnSiguiente.TabIndex = 11
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(637, 402)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(170, 23)
        Me.btnUltimo.TabIndex = 12
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(813, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Buscar por Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(813, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Buscar por Apellido:"
        '
        'txtbApellidos
        '
        Me.txtbApellidos.Location = New System.Drawing.Point(816, 101)
        Me.txtbApellidos.Name = "txtbApellidos"
        Me.txtbApellidos.Size = New System.Drawing.Size(180, 20)
        Me.txtbApellidos.TabIndex = 14
        '
        'btnAcabar
        '
        Me.btnAcabar.Location = New System.Drawing.Point(816, 373)
        Me.btnAcabar.Name = "btnAcabar"
        Me.btnAcabar.Size = New System.Drawing.Size(170, 23)
        Me.btnAcabar.TabIndex = 16
        Me.btnAcabar.Text = "Acabar búsqueda"
        Me.btnAcabar.UseVisualStyleBackColor = True
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Ver_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 430)
        Me.Controls.Add(Me.btnAcabar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbApellidos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimeiro)
        Me.Controls.Add(Me.txtbBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dtgClientes)
        Me.Controls.Add(Me.mnStripClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.mnStripClientes
        Me.Name = "Ver_Clientes"
        Me.Text = "Ver_Clientes"
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnStripClientes.ResumeLayout(False)
        Me.mnStripClientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents mnStripClientes As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtbBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnPrimeiro As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents OrdenarPorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApellidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbApellidos As System.Windows.Forms.TextBox
    Friend WithEvents btnAcabar As System.Windows.Forms.Button
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
