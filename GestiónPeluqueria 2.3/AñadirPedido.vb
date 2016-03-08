Imports System.Data.OleDb
Public Class AñadirPedido

    Dim dtsProductos, dtsProveedores As DataSet
    Dim dtaProductos, dtaProveedores As OleDbDataAdapter
    Public cita As Boolean
    Public idproducto As Integer
    Private Sub AñadirPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtsProductos = New DataSet
        dtaProductos = New OleDbDataAdapter("Select * from Productos where not(IdProducto=7) order by Nombre", cnnPeluqueria)
        dtaProductos.Fill(dtsProductos, "Productos")

        dtsProveedores = New DataSet
        dtaProveedores = New OleDbDataAdapter("Select * from Proveedores order by Nombre", cnnPeluqueria)
        dtaProveedores.Fill(dtsProveedores, "Proveedores")

        cargarDatos()
    End Sub

    Private Sub cargarDatos()
        cmbProductos.DataSource = dtsProductos.Tables("Productos")
        cmbProductos.DisplayMember = "Nombre"
        cmbProductos.ValueMember = "IdProducto"

        cmbProveedores.DataSource = dtsProveedores.Tables("Proveedores")
        cmbProveedores.DisplayMember = "Empresa"
        cmbProveedores.ValueMember = "IdProveedor"

        If (cita = True) Then
            cmbProductos.SelectedValue = idproducto
        End If
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectionChangeCommitted
        calcularTotal()
    End Sub

    Private Sub calcularTotal()
        Dim cmdprecioproducto As New OleDbCommand("select PrecioCompra from Productos where IdProducto=" & cmbProductos.SelectedValue, cnnPeluqueria)
        cnnPeluqueria.Open()
        Dim precio As Double
        precio = cmdprecioproducto.ExecuteScalar
        cnnPeluqueria.Close()
        If Not txtbCantidade.Text = vbNullString Then
            precio = Math.Round(precio, 2)
            lblPrecioTotal.Text = precio * CInt(txtbCantidade.Text)
        End If
    End Sub

    Private Sub txtbCantidade_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtbCantidade.KeyPress
        Dim validos As String = "1234567890" & Chr(8)

        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbCantidade_TextChanged(sender As Object, e As EventArgs) Handles txtbCantidade.TextChanged, txtbCantidade.KeyPress
        calcularTotal()
    End Sub

    Private Sub btnEngadirProducto_Click(sender As Object, e As EventArgs) Handles btnEngadirPedido.Click
        If txtbCantidade.Text = vbNullString Or txtbCantidade.Text = "0" Then
            MsgBox("Datos inválidos", MsgBoxStyle.Exclamation, "Atención")
            sender.Focus()
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarPedido.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class