<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirProducto
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
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.btnEngadirProducto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxprecioCompra = New System.Windows.Forms.TextBox()
        Me.lblprecioCompra = New System.Windows.Forms.Label()
        Me.txtBoxNombreProducto = New System.Windows.Forms.TextBox()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.txtboxPVP = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtboxStock = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Location = New System.Drawing.Point(167, 236)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarProducto.TabIndex = 9
        Me.btnCancelarProducto.Text = "Cerrar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'btnEngadirProducto
        '
        Me.btnEngadirProducto.Location = New System.Drawing.Point(50, 236)
        Me.btnEngadirProducto.Name = "btnEngadirProducto"
        Me.btnEngadirProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnEngadirProducto.TabIndex = 8
        Me.btnEngadirProducto.Text = "Aceptar"
        Me.btnEngadirProducto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PVP"
        '
        'txtBoxprecioCompra
        '
        Me.txtBoxprecioCompra.Location = New System.Drawing.Point(131, 78)
        Me.txtBoxprecioCompra.MaxLength = 40
        Me.txtBoxprecioCompra.Name = "txtBoxprecioCompra"
        Me.txtBoxprecioCompra.Size = New System.Drawing.Size(64, 20)
        Me.txtBoxprecioCompra.TabIndex = 3
        '
        'lblprecioCompra
        '
        Me.lblprecioCompra.AutoSize = True
        Me.lblprecioCompra.Location = New System.Drawing.Point(32, 81)
        Me.lblprecioCompra.Name = "lblprecioCompra"
        Me.lblprecioCompra.Size = New System.Drawing.Size(93, 13)
        Me.lblprecioCompra.TabIndex = 2
        Me.lblprecioCompra.Text = "Precio de compra:"
        '
        'txtBoxNombreProducto
        '
        Me.txtBoxNombreProducto.Location = New System.Drawing.Point(131, 33)
        Me.txtBoxNombreProducto.MaxLength = 25
        Me.txtBoxNombreProducto.Name = "txtBoxNombreProducto"
        Me.txtBoxNombreProducto.Size = New System.Drawing.Size(177, 20)
        Me.txtBoxNombreProducto.TabIndex = 1
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(32, 33)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreProducto.TabIndex = 0
        Me.lblNombreProducto.Text = "Nombre:"
        '
        'txtboxPVP
        '
        Me.txtboxPVP.Location = New System.Drawing.Point(131, 178)
        Me.txtboxPVP.MaxLength = 40
        Me.txtboxPVP.Name = "txtboxPVP"
        Me.txtboxPVP.Size = New System.Drawing.Size(64, 20)
        Me.txtboxPVP.TabIndex = 7
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(32, 133)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(38, 13)
        Me.lblStock.TabIndex = 4
        Me.lblStock.Text = "Stock:"
        '
        'txtboxStock
        '
        Me.txtboxStock.Location = New System.Drawing.Point(131, 126)
        Me.txtboxStock.MaxLength = 40
        Me.txtboxStock.Name = "txtboxStock"
        Me.txtboxStock.Size = New System.Drawing.Size(64, 20)
        Me.txtboxStock.TabIndex = 5
        '
        'AñadirProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 299)
        Me.Controls.Add(Me.txtboxStock)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txtboxPVP)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnEngadirProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxprecioCompra)
        Me.Controls.Add(Me.lblprecioCompra)
        Me.Controls.Add(Me.txtBoxNombreProducto)
        Me.Controls.Add(Me.lblNombreProducto)
        Me.Name = "AñadirProducto"
        Me.Text = "AñadirProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarProducto As Button
    Friend WithEvents btnEngadirProducto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxprecioCompra As TextBox
    Friend WithEvents lblprecioCompra As Label
    Friend WithEvents txtBoxNombreProducto As TextBox
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents txtboxPVP As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents txtboxStock As TextBox
End Class
