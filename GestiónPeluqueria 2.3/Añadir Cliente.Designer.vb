<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Añadir_Cliente
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
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtBoxNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblApelidosCliente = New System.Windows.Forms.Label()
        Me.txtBoxApelidosCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblXeneroCliente = New System.Windows.Forms.Label()
        Me.cmbBoxXeneroCliente = New System.Windows.Forms.ComboBox()
        Me.txtBoxIdadeCliente = New System.Windows.Forms.TextBox()
        Me.btnEngadirCliente = New System.Windows.Forms.Button()
        Me.btnCancelarCliente = New System.Windows.Forms.Button()
        Me.lblTelf = New System.Windows.Forms.Label()
        Me.txtBoxTelf = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(13, 33)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreCliente.TabIndex = 0
        Me.lblNombreCliente.Text = "Nombre:"
        '
        'txtBoxNombreCliente
        '
        Me.txtBoxNombreCliente.Location = New System.Drawing.Point(66, 30)
        Me.txtBoxNombreCliente.MaxLength = 25
        Me.txtBoxNombreCliente.Name = "txtBoxNombreCliente"
        Me.txtBoxNombreCliente.Size = New System.Drawing.Size(177, 20)
        Me.txtBoxNombreCliente.TabIndex = 1
        '
        'lblApelidosCliente
        '
        Me.lblApelidosCliente.AutoSize = True
        Me.lblApelidosCliente.Location = New System.Drawing.Point(13, 81)
        Me.lblApelidosCliente.Name = "lblApelidosCliente"
        Me.lblApelidosCliente.Size = New System.Drawing.Size(50, 13)
        Me.lblApelidosCliente.TabIndex = 2
        Me.lblApelidosCliente.Text = "Apelidos:"
        '
        'txtBoxApelidosCliente
        '
        Me.txtBoxApelidosCliente.Location = New System.Drawing.Point(66, 78)
        Me.txtBoxApelidosCliente.MaxLength = 40
        Me.txtBoxApelidosCliente.Name = "txtBoxApelidosCliente"
        Me.txtBoxApelidosCliente.Size = New System.Drawing.Size(269, 20)
        Me.txtBoxApelidosCliente.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Idade:"
        '
        'lblXeneroCliente
        '
        Me.lblXeneroCliente.AutoSize = True
        Me.lblXeneroCliente.Location = New System.Drawing.Point(12, 236)
        Me.lblXeneroCliente.Name = "lblXeneroCliente"
        Me.lblXeneroCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblXeneroCliente.TabIndex = 8
        Me.lblXeneroCliente.Text = "Xenero: "
        '
        'cmbBoxXeneroCliente
        '
        Me.cmbBoxXeneroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxXeneroCliente.FormattingEnabled = True
        Me.cmbBoxXeneroCliente.Location = New System.Drawing.Point(66, 233)
        Me.cmbBoxXeneroCliente.Name = "cmbBoxXeneroCliente"
        Me.cmbBoxXeneroCliente.Size = New System.Drawing.Size(121, 21)
        Me.cmbBoxXeneroCliente.TabIndex = 9
        '
        'txtBoxIdadeCliente
        '
        Me.txtBoxIdadeCliente.Location = New System.Drawing.Point(66, 127)
        Me.txtBoxIdadeCliente.MaxLength = 3
        Me.txtBoxIdadeCliente.Name = "txtBoxIdadeCliente"
        Me.txtBoxIdadeCliente.Size = New System.Drawing.Size(48, 20)
        Me.txtBoxIdadeCliente.TabIndex = 5
        '
        'btnEngadirCliente
        '
        Me.btnEngadirCliente.Location = New System.Drawing.Point(66, 307)
        Me.btnEngadirCliente.Name = "btnEngadirCliente"
        Me.btnEngadirCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnEngadirCliente.TabIndex = 10
        Me.btnEngadirCliente.Text = "Aceptar"
        Me.btnEngadirCliente.UseVisualStyleBackColor = True
        '
        'btnCancelarCliente
        '
        Me.btnCancelarCliente.Location = New System.Drawing.Point(201, 307)
        Me.btnCancelarCliente.Name = "btnCancelarCliente"
        Me.btnCancelarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarCliente.TabIndex = 11
        Me.btnCancelarCliente.Text = "Cerrar"
        Me.btnCancelarCliente.UseVisualStyleBackColor = True
        '
        'lblTelf
        '
        Me.lblTelf.AutoSize = True
        Me.lblTelf.Location = New System.Drawing.Point(11, 186)
        Me.lblTelf.Name = "lblTelf"
        Me.lblTelf.Size = New System.Drawing.Size(52, 13)
        Me.lblTelf.TabIndex = 6
        Me.lblTelf.Text = "Teléfono:"
        '
        'txtBoxTelf
        '
        Me.txtBoxTelf.Location = New System.Drawing.Point(66, 183)
        Me.txtBoxTelf.Name = "txtBoxTelf"
        Me.txtBoxTelf.Size = New System.Drawing.Size(152, 20)
        Me.txtBoxTelf.TabIndex = 7
        '
        'Añadir_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 357)
        Me.Controls.Add(Me.txtBoxTelf)
        Me.Controls.Add(Me.lblTelf)
        Me.Controls.Add(Me.btnCancelarCliente)
        Me.Controls.Add(Me.btnEngadirCliente)
        Me.Controls.Add(Me.txtBoxIdadeCliente)
        Me.Controls.Add(Me.cmbBoxXeneroCliente)
        Me.Controls.Add(Me.lblXeneroCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxApelidosCliente)
        Me.Controls.Add(Me.lblApelidosCliente)
        Me.Controls.Add(Me.txtBoxNombreCliente)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Añadir_Cliente"
        Me.Text = "Añadir_Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
    Friend WithEvents txtBoxNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblApelidosCliente As System.Windows.Forms.Label
    Friend WithEvents txtBoxApelidosCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblXeneroCliente As System.Windows.Forms.Label
    Friend WithEvents cmbBoxXeneroCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtBoxIdadeCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnEngadirCliente As System.Windows.Forms.Button
    Friend WithEvents btnCancelarCliente As System.Windows.Forms.Button
    Friend WithEvents lblTelf As System.Windows.Forms.Label
    Friend WithEvents txtBoxTelf As System.Windows.Forms.TextBox
End Class
