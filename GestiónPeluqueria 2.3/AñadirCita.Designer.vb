<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirCita
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
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.cmbServicios = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dtpCitasHora = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNovoCliente = New System.Windows.Forms.Button()
        Me.btnNovoServicio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(71, 25)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(121, 21)
        Me.cmbClientes.TabIndex = 0
        '
        'cmbServicios
        '
        Me.cmbServicios.FormattingEnabled = True
        Me.cmbServicios.Location = New System.Drawing.Point(71, 79)
        Me.cmbServicios.Name = "cmbServicios"
        Me.cmbServicios.Size = New System.Drawing.Size(121, 21)
        Me.cmbServicios.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Servicio:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(46, 193)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(170, 193)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dtpCitasHora
        '
        Me.dtpCitasHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCitasHora.Location = New System.Drawing.Point(71, 134)
        Me.dtpCitasHora.Name = "dtpCitasHora"
        Me.dtpCitasHora.Size = New System.Drawing.Size(200, 20)
        Me.dtpCitasHora.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha:"
        '
        'btnNovoCliente
        '
        Me.btnNovoCliente.Location = New System.Drawing.Point(214, 22)
        Me.btnNovoCliente.Name = "btnNovoCliente"
        Me.btnNovoCliente.Size = New System.Drawing.Size(57, 23)
        Me.btnNovoCliente.TabIndex = 12
        Me.btnNovoCliente.Text = "Novo"
        Me.btnNovoCliente.UseVisualStyleBackColor = True
        '
        'btnNovoServicio
        '
        Me.btnNovoServicio.Location = New System.Drawing.Point(214, 77)
        Me.btnNovoServicio.Name = "btnNovoServicio"
        Me.btnNovoServicio.Size = New System.Drawing.Size(57, 23)
        Me.btnNovoServicio.TabIndex = 13
        Me.btnNovoServicio.Text = "Novo"
        Me.btnNovoServicio.UseVisualStyleBackColor = True
        '
        'AñadirCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 242)
        Me.Controls.Add(Me.btnNovoServicio)
        Me.Controls.Add(Me.btnNovoCliente)
        Me.Controls.Add(Me.dtpCitasHora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbServicios)
        Me.Controls.Add(Me.cmbClientes)
        Me.Name = "AñadirCita"
        Me.Text = "AñadirCita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbServicios As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dtpCitasHora As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNovoCliente As Button
    Friend WithEvents btnNovoServicio As Button
End Class
