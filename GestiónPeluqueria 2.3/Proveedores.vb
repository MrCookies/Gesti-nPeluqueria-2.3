Imports System.Data.OleDb
Public Class Proveedores
    Dim dtsProveedores, dtsBusca As DataSet
    Dim dtaProveedores As OleDbDataAdapter
    Dim cbProveedores As OleDbCommandBuilder
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtsProveedores = New DataSet
        dtaProveedores = New OleDbDataAdapter("Select * from Proveedores order by Empresa", cnnPeluqueria)
        dtaProveedores.Fill(dtsProveedores, "Proveedores")

        cbProveedores = New OleDbCommandBuilder(dtaProveedores)

        configurarDataGrid(dtsProveedores)
    End Sub

    Private Sub configurarDataGrid(tabla As DataSet)
        dtgProveedores.DataSource = tabla.Tables("Proveedores").DefaultView

        dtgProveedores.Columns(0).Visible = False
        dtgProveedores.Columns(1).Width = 181
        dtgProveedores.Columns(2).Width = 120
        dtgProveedores.Columns(3).Width = 150
        dtgProveedores.Columns(4).Width = 200
        dtgProveedores.Columns(5).Width = 200

        For index = 0 To dtgProveedores.Columns.Count - 1
            dtgProveedores.Columns(index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgProveedores.Columns(index).DefaultCellStyle.Font = New Font("Times New Roman", 10, FontStyle.Regular)
        Next
    End Sub

    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Me.BindingContext(dtsProveedores.Tables("Proveedores").DefaultView).Position = 0
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Me.BindingContext(dtsProveedores.Tables("Proveedores").DefaultView).Position -= 1
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Me.BindingContext(dtsProveedores.Tables("Proveedores").DefaultView).Position += 1
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Me.BindingContext(dtsProveedores.Tables("Proveedores").DefaultView).Position = Me.BindingContext(dtsProveedores.Tables("Proveedores").DefaultView).Count - 1
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Dim formProveedor As New AñadirProveedor
        With formProveedor
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If

            Dim fproveedor As DataRow
            fproveedor = dtsProveedores.Tables("Proveedores").NewRow

            fproveedor("Empresa") = .txtBoxEmpresa.Text
            fproveedor("Nombre") = .txtBoxNombre.Text
            fproveedor("Apellidos") = .txtboxApellidos.Text
            fproveedor("Telefono") = .txtboxTelefono.Text
            fproveedor("DNI") = .txtboxdni.Text

            dtsProveedores.Tables("Proveedores").Rows.Add(fproveedor)

            dtaProveedores.Update(dtsProveedores, "Proveedores")
            dtsProveedores.AcceptChanges()

            MsgBox("Engadiuse o novo proveedor correctamente", MsgBoxStyle.Information, "Proveedor gardado")
        End With
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If dtgProveedores.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar antes unha fila", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim formproveedor As New AñadirProveedor

        With formproveedor
            .txtBoxNombre.Text = dtgProveedores.CurrentRow.Cells(3).Value
            .txtBoxEmpresa.Text = dtgProveedores.CurrentRow.Cells(1).Value
            .txtboxdni.Text = dtgProveedores.CurrentRow.Cells(2).Value
            .txtboxApellidos.Text = dtgProveedores.CurrentRow.Cells(4).Value
            .txtboxTelefono.Text = dtgProveedores.CurrentRow.Cells(5).Value

            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            Dim posicion = dtgProveedores.CurrentRow.Index
            Dim fproveedor = dtsProveedores.Tables("Proveedores").Rows(posicion)

            fproveedor.BeginEdit()

            fproveedor("Empresa") = .txtBoxEmpresa.Text
            fproveedor("Nombre") = .txtBoxNombre.Text
            fproveedor("Apellidos") = .txtboxApellidos.Text
            fproveedor("Telefono") = .txtboxTelefono.Text
            fproveedor("DNI") = .txtboxdni.Text

            fproveedor.EndEdit()
            dtaProveedores.Update(dtsProveedores, "Proveedores")
            dtsProveedores.AcceptChanges()

            MsgBox("Modificouse o proveedor correctamente", MsgBoxStyle.Information, "Proveedor gardado")
        End With
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click, SalirToolStripMenuItem.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        If dtgProveedores.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar antes unha fila", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim posicion = dtgProveedores.CurrentRow.Index
        Dim fproveedor = dtsProveedores.Tables("Proveedores").Rows(posicion)

        If MsgBox("Estás seguro/a de eliminar o proveedor " & fproveedor("Nombre"),
          MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.Yes Then

            fproveedor.Delete()

            dtaProveedores.Update(dtsProveedores, "Proveedores")
            dtsProveedores.Tables("Proveedores").AcceptChanges()
            MsgBox("Eliminouse o proveedor", MsgBoxStyle.Information, "Proveedor Eliminado")
        End If
    End Sub
End Class