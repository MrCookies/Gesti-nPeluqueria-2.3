Imports System.Data.OleDb
Public Class Ver_Clientes

    Dim dtsClientes, dtsBusca As DataSet
    Dim dtaClientes, dtaBusca As OleDbDataAdapter
    Dim cbCliente As OleDbCommandBuilder

    Private Sub Ver_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtsClientes = New DataSet
        dtaClientes = New OleDbDataAdapter("Select * from Clientes order by Nombre", cnnPeluqueria)
        dtaClientes.Fill(dtsClientes, "Clientes")

        dtsClientes.Tables("Clientes").DefaultView.Sort = "Nombre"
        cbCliente = New OleDbCommandBuilder(dtaClientes)

        configurarDataGrid(dtsClientes)
    End Sub

    'Enviamoslle o metodo do datagrid un dataset para poder facer búsquedas

    Private Sub configurarDataGrid(tabla As DataSet)
        dtgClientes.DataSource = tabla.Tables("Clientes").DefaultView

        dtgClientes.Columns(0).Visible = False
        dtgClientes.Columns(1).Width = 170
        dtgClientes.Columns(2).Width = 200
        dtgClientes.Columns(3).Width = 50
        dtgClientes.Columns(4).Width = 130
        dtgClientes.Columns(5).Width = 202

        For index = 0 To dtgClientes.Columns.Count - 1
            dtgClientes.Columns(index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgClientes.Columns(index).DefaultCellStyle.Font = New Font("Times New Roman", 10, FontStyle.Regular)
        Next

    End Sub

    'Novo Cliente

    Private Sub btnNovoCliente_Click(sender As Object, e As EventArgs) Handles NovoClienteToolStripMenuItem.Click
        Dim formCliente As New Añadir_Cliente
        With formCliente
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            Dim fcliente As DataRow
            fcliente = dtsClientes.Tables("Clientes").NewRow

            fcliente("Nombre") = .txtBoxNombreCliente.Text
            fcliente("Apellidos") = .txtBoxApelidosCliente.Text
            fcliente("Edad") = CInt(.txtBoxIdadeCliente.Text)
            fcliente("Genero") = .cmbBoxXeneroCliente.SelectedItem
            fcliente("Telefono") = .txtBoxTelf.Text

            dtsClientes.Tables("Clientes").Rows.Add(fcliente)

            dtaClientes.Update(dtsClientes, "Clientes")
            dtsClientes.AcceptChanges()

            MsgBox("Engadiuse o novo cliente correctamente", MsgBoxStyle.Information, "Cliente gardado")
        End With
    End Sub

    'Botón modificar. Non funciona coller o valor da celda xénero e poñelo no combobox do outro formulario.

    Private Sub btnModCliente_Click(sender As Object, e As EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        If dtgClientes.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar antes unha fila", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim formCliente As New Añadir_Cliente

        With formCliente
            .txtBoxNombreCliente.Text = CStr(dtgClientes.CurrentRow.Cells(1).Value)
            .txtBoxApelidosCliente.Text = CStr(dtgClientes.CurrentRow.Cells(2).Value)
            .txtBoxIdadeCliente.Text = CStr(dtgClientes.CurrentRow.Cells(3).Value)
            .xenero = dtgClientes.CurrentRow.Cells(4).Value
            .txtBoxTelf.Text = CStr(dtgClientes.CurrentRow.Cells(5).Value)

            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            Dim posicion = dtgClientes.CurrentRow.Index
            Dim fcliente = dtsClientes.Tables("Clientes").Rows(posicion)

            fcliente.BeginEdit()

            fcliente("Nombre") = .txtBoxNombreCliente.Text
            fcliente("Apellidos") = .txtBoxApelidosCliente.Text
            fcliente("Edad") = CInt(.txtBoxIdadeCliente.Text)
            fcliente("Genero") = .cmbBoxXeneroCliente.SelectedItem
            fcliente("Telefono") = .txtBoxTelf.Text

            fcliente.EndEdit()
            dtaClientes.Update(dtsClientes, "Clientes")
            dtsClientes.AcceptChanges()

            MsgBox("Modificouse o cliente correctamente", MsgBoxStyle.Information, "Cliente gardado")
        End With
    End Sub

    'Botón borrar. Funciona ben, pero vólvese un pouco tolo cando ordenamos os dataset.

    Private Sub btnDelCliente_Click(sender As Object, e As EventArgs) Handles EliminarClienteToolStripMenuItem.Click
        If dtgClientes.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar antes unha fila", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim posicion = dtgClientes.CurrentRow.Index
        Dim fcliente = dtsClientes.Tables("Clientes").Rows(posicion)

        If MsgBox("Estás seguro/a de eliminar o cliente " & fcliente("Nombre"),
          MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.Yes Then

            fcliente.Delete()

            dtaClientes.Update(dtsClientes, "Clientes")
            dtsClientes.Tables("Clientes").AcceptChanges()
            MsgBox("Eliminouse o cliente", MsgBoxStyle.Information, "Atención")
        End If
    End Sub

    'Botón de buscar. Impedimos que busque por dous campos e creamos un novo dataset cos datos da búsqueda

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dtsBusca = New DataSet

        If Not txtbApellidos.Text = vbNullString And Not txtbBuscar.Text = vbNullString Then
            dtaBusca = New OleDbDataAdapter("Select * from Clientes where Apellidos like '" & txtbApellidos.Text & "%' and Nombre like '" & txtbBuscar.Text & "'", cnnPeluqueria)
            dtaBusca.Fill(dtsBusca, "Clientes")
            configurarDataGrid(dtsBusca)
            txtbApellidos.Clear()
            txtbBuscar.Clear()
        ElseIf txtbApellidos.Text = vbNullString And txtbBuscar.Text = vbNullString Then
            MsgBox("Non hai campo polo que buscar", MsgBoxStyle.Information, "Atención")
            Exit Sub
        ElseIf txtbApellidos.Text = vbNullString And Not txtbBuscar.Text = vbNullString Then
            dtaBusca = New OleDbDataAdapter("Select * from Clientes where Nombre like '" & txtbBuscar.Text & "%' order by Apellidos", cnnPeluqueria)
            dtaBusca.Fill(dtsBusca, "Clientes")
            configurarDataGrid(dtsBusca)
            txtbBuscar.Clear()
        ElseIf Not txtbApellidos.Text = vbNullString And txtbBuscar.Text = vbNullString Then
            dtaBusca = New OleDbDataAdapter("Select * from Clientes where Apellidos like '" & txtbApellidos.Text & "%' order by Nombre", cnnPeluqueria)
            dtaBusca.Fill(dtsBusca, "Clientes")
            configurarDataGrid(dtsBusca)
            txtbApellidos.Clear()
        End If
    End Sub

    'Botóns de navegacion. Nestes comprobamos que o dataset de busca este iniciado para que non tire excepción

    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Me.BindingContext(dtsClientes.Tables("Clientes").DefaultView).Position = 0

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Clientes").DefaultView).Position = 0
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Me.BindingContext(dtsClientes.Tables("Clientes").DefaultView).Position -= 1

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Clientes").DefaultView).Position -= 1
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Me.BindingContext(dtsClientes.Tables("Clientes").DefaultView).Position += 1

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Clientes").DefaultView).Position += 1
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Me.BindingContext(dtsClientes.Tables("Clientes").DefaultView).Position = Me.BindingContext(dtsClientes.Tables("Clientes").DefaultView).Count - 1

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Clientes").DefaultView).Position = Me.BindingContext(dtsBusca.Tables("Clientes").DefaultView).Count - 1
        End If
    End Sub

    'Botóns de ordenar. Comprobamos que o dataset de busca exista para que non tire excepción

    Private Sub NombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NombreToolStripMenuItem.Click
        dtsClientes.Tables("Clientes").DefaultView.Sort = "Nombre"

        If Not dtsBusca Is Nothing Then
            dtsBusca.Tables("Clientes").DefaultView.Sort = "Nombre"
        End If
    End Sub

    Private Sub ApellidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApellidosToolStripMenuItem.Click
        dtsClientes.Tables("Clientes").DefaultView.Sort = "Apellidos"

        If Not dtsBusca Is Nothing Then
            dtsBusca.Tables("Clientes").DefaultView.Sort = "Apellidos"
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub EdadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdadToolStripMenuItem.Click
        dtsClientes.Tables("Clientes").DefaultView.Sort = "Edad"

        If Not dtsBusca Is Nothing Then
            dtsBusca.Tables("Clientes").DefaultView.Sort = "Edad"
        End If
    End Sub

    'Cando acabamos de ver os datos da busca volvemos recargar o datagrid co dataset enteiro

    Private Sub btnAcabar_Click(sender As Object, e As EventArgs) Handles btnAcabar.Click
        configurarDataGrid(dtsClientes)
    End Sub
End Class