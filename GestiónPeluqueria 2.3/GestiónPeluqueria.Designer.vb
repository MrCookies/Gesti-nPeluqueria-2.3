<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionPeluqueria
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacénToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpCitas = New System.Windows.Forms.DateTimePicker()
        Me.dtgCitas = New System.Windows.Forms.DataGridView()
        Me.btnTodas = New System.Windows.Forms.Button()
        Me.lblCitas = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimeiro = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dtgCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CitasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.AlmacénToolStripMenuItem, Me.ServiciosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(618, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CitasToolStripMenuItem
        '
        Me.CitasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaToolStripMenuItem, Me.BorrarToolStripMenuItem})
        Me.CitasToolStripMenuItem.Name = "CitasToolStripMenuItem"
        Me.CitasToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.CitasToolStripMenuItem.Text = "Citas"
        '
        'NovaToolStripMenuItem
        '
        Me.NovaToolStripMenuItem.Name = "NovaToolStripMenuItem"
        Me.NovaToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.NovaToolStripMenuItem.Text = "Nova"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AlmacénToolStripMenuItem
        '
        Me.AlmacénToolStripMenuItem.Name = "AlmacénToolStripMenuItem"
        Me.AlmacénToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.AlmacénToolStripMenuItem.Text = "Almacén"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha:"
        '
        'dtpCitas
        '
        Me.dtpCitas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCitas.Location = New System.Drawing.Point(250, 30)
        Me.dtpCitas.Name = "dtpCitas"
        Me.dtpCitas.Size = New System.Drawing.Size(200, 20)
        Me.dtpCitas.TabIndex = 11
        '
        'dtgCitas
        '
        Me.dtgCitas.AllowUserToAddRows = False
        Me.dtgCitas.AllowUserToDeleteRows = False
        Me.dtgCitas.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCitas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCitas.Location = New System.Drawing.Point(12, 76)
        Me.dtgCitas.Name = "dtgCitas"
        Me.dtgCitas.Size = New System.Drawing.Size(595, 312)
        Me.dtgCitas.TabIndex = 12
        '
        'btnTodas
        '
        Me.btnTodas.Location = New System.Drawing.Point(12, 27)
        Me.btnTodas.Name = "btnTodas"
        Me.btnTodas.Size = New System.Drawing.Size(170, 23)
        Me.btnTodas.TabIndex = 13
        Me.btnTodas.Text = "Mostrar Todas"
        Me.btnTodas.UseVisualStyleBackColor = True
        '
        'lblCitas
        '
        Me.lblCitas.AutoSize = True
        Me.lblCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitas.Location = New System.Drawing.Point(12, 53)
        Me.lblCitas.Name = "lblCitas"
        Me.lblCitas.Size = New System.Drawing.Size(126, 20)
        Me.lblCitas.TabIndex = 14
        Me.lblCitas.Text = "Citas de Hoxe:"
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(521, 394)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(86, 23)
        Me.btnUltimo.TabIndex = 18
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(376, 394)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(86, 23)
        Me.btnSiguiente.TabIndex = 17
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(158, 394)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(86, 23)
        Me.btnAnterior.TabIndex = 16
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Location = New System.Drawing.Point(12, 394)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(86, 23)
        Me.btnPrimeiro.TabIndex = 15
        Me.btnPrimeiro.Text = "<<"
        Me.btnPrimeiro.UseVisualStyleBackColor = True
        '
        'GestionPeluqueria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 424)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimeiro)
        Me.Controls.Add(Me.lblCitas)
        Me.Controls.Add(Me.btnTodas)
        Me.Controls.Add(Me.dtgCitas)
        Me.Controls.Add(Me.dtpCitas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestionPeluqueria"
        Me.Text = "Gestion Peluquería"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dtgCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CitasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpCitas As DateTimePicker
    Friend WithEvents dtgCitas As DataGridView
    Friend WithEvents btnTodas As Button
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlmacénToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCitas As System.Windows.Forms.Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimeiro As Button
End Class
