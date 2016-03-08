Imports System.Data.OleDb
Public Class AñadirServicio
    Dim dtsProductos As DataSet
    Dim dtaProductos As OleDbDataAdapter
    Public producto As String
    Public idProducto As Integer
    Private Sub AñadirServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtsProductos = New DataSet
        dtaProductos = New OleDbDataAdapter("Select * from Productos order by Nombre", cnnPeluqueria)
        dtaProductos.Fill(dtsProductos, "Productos")

        cargarDatos()
    End Sub

    Private Sub cargarDatos()
        cmbProductos.DataSource = dtsProductos.Tables("Productos")
        cmbProductos.DisplayMember = "Nombre"
        cmbProductos.ValueMember = "IdProducto"
        cmbProductos.SelectedValue = idProducto
    End Sub

    Private Sub btnCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarProducto.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectionChangeCommitted
        idProducto = cmbProductos.SelectedValue
        If idProducto = 7 Then
            MsgBox("O producto Nulo solo se debe escoller para aqueles servicios que non requiran un producto.", MsgBoxStyle.Exclamation, "Coidado!")
        End If

        Dim cmdnombreproducto As New OleDbCommand("Select Nombre from Productos where IdProducto=" & idProducto, cnnPeluqueria)
        cnnPeluqueria.Open()
        producto = cmdnombreproducto.ExecuteScalar
        cnnPeluqueria.Close()
    End Sub

    Private Sub btnEngadirProducto_Click(sender As Object, e As EventArgs) Handles btnEngadirServicio.Click
        If txtBoxNombre.Text = "" Or txtboxDuracion.Text = "" Or txtboxPrecio.Text = "" Then
            MsgBox("Faltan datos", MsgBoxStyle.Exclamation, "Atención")
            sender.Focus()
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class