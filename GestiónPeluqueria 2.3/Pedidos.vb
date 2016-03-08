Imports System.Data.OleDb
Public Class Pedidos
    Dim dtsPedidos, dtsBusca As DataSet
    Dim dtaPedidos, dtaBusca As OleDbDataAdapter
    Dim cbPedido As OleDbCommandBuilder


    'Funciona igual que os demais, non poñemos a opcion de modificar e borrar pedidos porque me parece 
    'unha tonteria.

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtsPedidos = New DataSet
        dtaPedidos = New OleDbDataAdapter("Select * from Pedidos order by FechaPedido", cnnPeluqueria)
        dtaPedidos.Fill(dtsPedidos, "Pedidos")

        dtsPedidos.Tables("Pedidos").DefaultView.Sort = "FechaPedido"
        cbPedido = New OleDbCommandBuilder(dtaPedidos)

        configurarDataGrid(dtsPedidos)
    End Sub

    'Configuramos o datagrid
    Private Sub configurarDataGrid(tabla As DataSet)
        dtgPedidos.DataSource = tabla.Tables("Pedidos").DefaultView

        dtgPedidos.Columns(0).Visible = False
        dtgPedidos.Columns(1).Width = 170
        dtgPedidos.Columns(2).Width = 200
        dtgPedidos.Columns(3).Width = 100
        dtgPedidos.Columns(4).Visible = False
        dtgPedidos.Columns(5).Visible = False

        For index = 0 To dtgPedidos.Columns.Count - 1
            dtgPedidos.Columns(index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPedidos.Columns(index).DefaultCellStyle.Font = New Font("Times New Roman", 10, FontStyle.Regular)
        Next

    End Sub

    'Novo pedido
    Private Sub btnNovoPedido_Click(sender As Object, e As EventArgs) Handles NovoPedidoToolStripMenuItem.Click
        Dim formPedido As New AñadirPedido
        With formPedido
            .cita = False
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If

            Dim fpedido As DataRow
            fpedido = dtsPedidos.Tables("Pedidos").NewRow

            Dim idproducto, cantidade As Integer

            idproducto = CInt(.cmbProductos.SelectedValue)
            cantidade = CInt(.txtbCantidade.Text)

            fpedido("PrecioPedido") = CDbl(.lblPrecioTotal.Text)
            fpedido("IdProducto") = idproducto
            fpedido("FechaPedido") = .dtpPedidos.Value
            fpedido("Cantidade") = cantidade
            fpedido("IdProveedor") = CInt(.cmbProveedores.SelectedValue)

            dtsPedidos.Tables("Pedidos").Rows.Add(fpedido)

            dtaPedidos.Update(dtsPedidos, "Pedidos")
            dtsPedidos.AcceptChanges()

            Dim cmdupdate As New OleDbCommand("update Productos set Stock=Stock+" & cantidade & " where IdProducto=" & idproducto, cnnPeluqueria)
            cnnPeluqueria.Open()
            cmdupdate.ExecuteNonQuery()
            cnnPeluqueria.Close()

            MsgBox("Engadiuse o novo pedido correctamente", MsgBoxStyle.Information, "Pedido gardado")
        End With
    End Sub

    'Cada vez que cambiamos a fila seleccionada cargamos os datos do producto e proveedor nos labels
    Private Sub dtgPedidos_SelectionChanged(sender As Object, e As EventArgs) Handles dtgPedidos.SelectionChanged
        Dim cmdNombre, cmdcompra, cmdStock, cmdPVP, cmdNombrep, cmdtlf, cmdEmpresa, cmdapellidos, cmddni As New OleDbCommand
        Dim nombre, compra, Stock, PVP, nombrep, tlf, empresa, apellidos, dni As String

        If Not dtgPedidos.CurrentRow Is Nothing Then
            cmdNombre = New OleDbCommand("Select Nombre from Productos where IdProducto=" & dtgPedidos.CurrentRow.Cells(4).Value, cnnPeluqueria)
            cmdcompra = New OleDbCommand("Select PrecioCompra from Productos where IdProducto=" & dtgPedidos.CurrentRow.Cells(4).Value, cnnPeluqueria)
            cmdStock = New OleDbCommand("Select Stock from Productos where IdProducto=" & dtgPedidos.CurrentRow.Cells(4).Value, cnnPeluqueria)
            cmdPVP = New OleDbCommand("Select PVP from Productos where IdProducto=" & dtgPedidos.CurrentRow.Cells(4).Value, cnnPeluqueria)
            cmdNombrep = New OleDbCommand("Select Nombre from Proveedores where IdProveedor=" & dtgPedidos.CurrentRow.Cells(5).Value, cnnPeluqueria)
            cmdtlf = New OleDbCommand("Select Telefono from Proveedores where IdProveedor=" & dtgPedidos.CurrentRow.Cells(5).Value, cnnPeluqueria)
            cmdEmpresa = New OleDbCommand("Select Empresa from Proveedores where IdProveedor=" & dtgPedidos.CurrentRow.Cells(5).Value, cnnPeluqueria)
            cmdapellidos = New OleDbCommand("Select Apellidos from Proveedores where IdProveedor=" & dtgPedidos.CurrentRow.Cells(5).Value, cnnPeluqueria)
            cmddni = New OleDbCommand("Select DNI from Proveedores where IdProveedor=" & dtgPedidos.CurrentRow.Cells(5).Value, cnnPeluqueria)
            lblIDProveedor.Text = dtgPedidos.CurrentRow.Cells(5).Value
            lblIDProducto.Text = dtgPedidos.CurrentRow.Cells(4).Value


            cnnPeluqueria.Open()

            nombre = cmdNombre.ExecuteScalar
            compra = cmdcompra.ExecuteScalar
            Stock = cmdStock.ExecuteScalar
            PVP = cmdPVP.ExecuteScalar
            nombrep = cmdNombrep.ExecuteScalar
            tlf = cmdtlf.ExecuteScalar
            empresa = cmdEmpresa.ExecuteScalar
            apellidos = cmdapellidos.ExecuteScalar
            dni = cmddni.ExecuteScalar

            cnnPeluqueria.Close()

            lblNombreProducto.Text = nombre
            lblcompraProducto.Text = compra
            lblstockProducto.Text = Stock
            lblPVPProducto.Text = PVP
            lblNombreProveedor.Text = nombrep
            lblEmpresaProveedor.Text = empresa
            lblDNIProveedor.Text = dni
            lbltlfProveedor.Text = tlf
            lblApellidosProveedor.Text = apellidos
        End If

    End Sub

    'Botons de navegacion
    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Me.BindingContext(dtsPedidos.Tables("Pedidos").DefaultView).Position = 0
        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Pedidos").DefaultView).Position = 0
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Me.BindingContext(dtsPedidos.Tables("Pedidos").DefaultView).Position -= 1

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Pedidos").DefaultView).Position -= 1
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Me.BindingContext(dtsPedidos.Tables("Pedidos").DefaultView).Position += 1

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Pedidos").DefaultView).Position += 1
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Me.BindingContext(dtsPedidos.Tables("Pedidos").DefaultView).Position = Me.BindingContext(dtsPedidos.Tables("Pedidos").DefaultView).Count - 1
        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Pedidos").DefaultView).Position = Me.BindingContext(dtsBusca.Tables("Pedidos").DefaultView).Count - 1
        End If
    End Sub

    Private Sub txtboxPrecioBusca_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtboxPrecioBusca.KeyPress
        Dim validos As String = "1234567890,." & Chr(8)

        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.KeyChar = "."
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnFecha.Click

    End Sub

    'Botons de buscar e acabar a busqueda.

    Private Sub btnBuscarPedido_Click(sender As Object, e As EventArgs) Handles btnBuscarPedido.Click
        dtsBusca = New DataSet
        Dim dtaBusca As OleDbDataAdapter

        If txtboxPrecioBusca.Text = vbNullString Then
            MsgBox("Introduce un precio", MsgBoxStyle.Information, "Atención")
            Exit Sub
        ElseIf rdbtnmaisPrecio.Checked = True Then
            dtaBusca = New OleDbDataAdapter("Select * from Pedidos where PrecioPedido > " & txtboxPrecioBusca.Text, cnnPeluqueria)
        ElseIf rdbtnmenosPrecio.Checked = True Then
            dtaBusca = New OleDbDataAdapter("Select * from Pedidos where PrecioPedido < " & txtboxPrecioBusca.Text, cnnPeluqueria)
        ElseIf rdbtnigualPrecio.Checked = True Then
            dtaBusca = New OleDbDataAdapter("Select * from Pedidos where PrecioPedido = " & txtboxPrecioBusca.Text, cnnPeluqueria)
        End If

        dtaBusca.Fill(dtsBusca, "Pedidos")
        configurarDataGrid(dtsBusca)
        txtboxPrecioBusca.Clear()
    End Sub

    Private Sub btnacabarPedido_Click(sender As Object, e As EventArgs) Handles btnacabarPedido.Click
        configurarDataGrid(dtsPedidos)
    End Sub

End Class