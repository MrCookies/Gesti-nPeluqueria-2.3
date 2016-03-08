Imports System.Data.OleDb
Public Class Almacen

    Dim dtsProductos, dtsBusca As DataSet
    Dim dtaProductos As OleDbDataAdapter
    Dim cbProductos As OleDbCommandBuilder

    'Hai un producto na base de datos chamado Ningun que por casualidade ten o id 7. Este producto esta para evitar
    'nulos, e non damos a opcion de traballar sobre el.

    Private Sub Almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtsProductos = New DataSet
        dtaProductos = New OleDbDataAdapter("Select * from Productos where not(IdProducto=7) order by Nombre", cnnPeluqueria)
        dtaProductos.Fill(dtsProductos, "Productos")

        cbProductos = New OleDbCommandBuilder(dtaProductos)

        configurarDataGrid(dtsProductos)
    End Sub

    'Configuramos o datagrid
    Private Sub configurarDataGrid(tabla As DataSet)
        dtgProductos.DataSource = tabla.Tables("Productos").DefaultView

        dtgProductos.Columns(0).Visible = False
        dtgProductos.Columns(1).Width = 247
        dtgProductos.Columns(2).Width = 170
        dtgProductos.Columns(3).Width = 90
        dtgProductos.Columns(4).Width = 80

        For index = 0 To dtgProductos.Columns.Count - 1
            dtgProductos.Columns(index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgProductos.Columns(index).DefaultCellStyle.Font = New Font("Times New Roman", 10, FontStyle.Regular)
        Next
    End Sub

    'Novo producto
    Private Sub NovoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoProductoToolStripMenuItem.Click
        Dim formProducto As New AñadirProducto
        With formProducto
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If

            Dim fproducto As DataRow
            fproducto = dtsProductos.Tables("Productos").NewRow

            fproducto("Nombre") = .txtBoxNombreProducto.Text
            fproducto("PrecioCompra") = CDbl(.txtBoxprecioCompra.Text)
            fproducto("Stock") = CInt(.txtboxStock.Text)
            fproducto("PVP") = CDbl(.txtboxPVP.Text)

            dtsProductos.Tables("Productos").Rows.Add(fproducto)

            dtaProductos.Update(dtsProductos, "Productos")
            dtsProductos.AcceptChanges()

            MsgBox("Engadiuse o novo producto correctamente", MsgBoxStyle.Information, "Producto gardado")
        End With
    End Sub

    'Modificar producto
    Private Sub ModificarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProductoToolStripMenuItem.Click
        If dtgProductos.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar antes unha fila", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim formproducto As New AñadirProducto

        With formproducto
            .txtBoxNombreProducto.Text = CStr(dtgProductos.CurrentRow.Cells(1).Value)
            .txtBoxprecioCompra.Text = CStr(dtgProductos.CurrentRow.Cells(2).Value)
            .txtboxStock.Text = CStr(dtgProductos.CurrentRow.Cells(3).Value)
            .txtboxPVP.Text = CStr(dtgProductos.CurrentRow.Cells(4).Value)

            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            Dim posicion = dtgProductos.CurrentRow.Index
            Dim fproducto = dtsProductos.Tables("Productos").Rows(posicion)

            fproducto.BeginEdit()

            fproducto("Nombre") = .txtBoxNombreProducto.Text
            fproducto("PrecioCompra") = CDbl(.txtBoxprecioCompra.Text)
            fproducto("Stock") = CInt(.txtboxStock.Text)
            fproducto("PVP") = CDbl(.txtboxPVP.Text)

            fproducto.EndEdit()
            dtaProductos.Update(dtsProductos, "Productos")
            dtsProductos.AcceptChanges()

            MsgBox("Modificouse o producto correctamente", MsgBoxStyle.Information, "Producto gardado")
        End With
    End Sub

    'Borrar Producto
    Private Sub EliminarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarProductoToolStripMenuItem.Click
        If dtgProductos.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar antes unha fila", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim posicion = dtgProductos.CurrentRow.Index
        Dim fproducto = dtsProductos.Tables("Productos").Rows(posicion)

        If MsgBox("Estás seguro/a de eliminar o producto " & fproducto("Nombre"),
          MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.Yes Then

            fproducto.Delete()

            dtaProductos.Update(dtsProductos, "Productos")
            dtsProductos.Tables("Productos").AcceptChanges()
            MsgBox("Eliminouse o producto", MsgBoxStyle.Information, "Producto Eliminado")
        End If
    End Sub

    'Botons de navegacion
    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Me.BindingContext(dtsProductos.Tables("Productos").DefaultView).Position = 0
        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Productos").DefaultView).Position = 0
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Me.BindingContext(dtsProductos.Tables("Productos").DefaultView).Position -= 1

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Productos").DefaultView).Position -= 1
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Me.BindingContext(dtsProductos.Tables("Productos").DefaultView).Position += 1

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Productos").DefaultView).Position += 1
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Me.BindingContext(dtsProductos.Tables("Productos").DefaultView).Position = Me.BindingContext(dtsProductos.Tables("Productos").DefaultView).Count - 1
        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Productos").DefaultView).Position = Me.BindingContext(dtsBusca.Tables("Productos").DefaultView).Count - 1
        End If
    End Sub


    'Botons de buscar e acabar busca
    Private Sub btnacabarbusca_Click(sender As Object, e As EventArgs) Handles btnacabarbusca.Click
        configurarDataGrid(dtsProductos)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click, SalirToolStripMenuItem.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        Dim formPedidos As New Pedidos
        formPedidos.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim formProveedores As New Proveedores
        formProveedores.ShowDialog()
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        dtsBusca = New DataSet
        Dim dtaBusca As OleDbDataAdapter

        If txtbbuscaProducto.Text = vbNullString Then
            MsgBox("Introduce un nome", MsgBoxStyle.Information, "Atención")
            Exit Sub
        ElseIf Not txtbbuscaProducto.Text = vbNullString Then
            dtaBusca = New OleDbDataAdapter("Select * from Productos where Nombre like '" & txtbbuscaProducto.Text & "%'", cnnPeluqueria)
            dtaBusca.Fill(dtsBusca, "Productos")
            configurarDataGrid(dtsBusca)
        End If
        txtbbuscaProducto.Clear()
    End Sub

End Class