Imports System.Data.OleDb
Public Class Servicios
    Dim dtsServicios As DataSet
    Dim dtaServicios As OleDbDataAdapter
    Dim cbServicio As OleDbCommandBuilder

    Private Sub Servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtsServicios = New DataSet
        dtaServicios = New OleDbDataAdapter("Select * from Servicios", cnnPeluqueria)
        dtaServicios.Fill(dtsServicios, "Servicios")

        cbServicio = New OleDbCommandBuilder(dtaServicios)
        configurarDatagrid()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub configurarDatagrid()
        dtgServicios.DataSource = dtsServicios.Tables("Servicios")

        dtgServicios.Columns(0).Visible = False
        dtgServicios.Columns(4).Visible = False
        dtgServicios.Columns(5).Width = 102

        For index = 0 To dtgServicios.Columns.Count - 1
            dtgServicios.Columns(index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgServicios.Columns(index).DefaultCellStyle.Font = New Font("Times New Roman", 10, FontStyle.Regular)
        Next
    End Sub
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Dim formServicio As New AñadirServicio
        With formServicio
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If

            Dim fservicio As DataRow
            fservicio = dtsServicios.Tables("Servicios").NewRow

            fservicio("Nombre") = .txtBoxNombre.Text
            fservicio("Duracion") = .txtboxDuracion.Text
            fservicio("Precio") = .txtboxPrecio.Text
            fservicio("IdProducto") = .cmbProductos.SelectedValue
            fservicio("Producto") = .producto

            dtsServicios.Tables("Servicios").Rows.Add(fservicio)

            dtaServicios.Update(dtsServicios, "Servicios")
            dtsServicios.AcceptChanges()

            MsgBox("Engadiuse o novo servicio correctamente", MsgBoxStyle.Information, "Servicio gardado")
        End With
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If dtgServicios.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar antes unha fila", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim formServicio As New AñadirServicio

        With formServicio
            .txtBoxNombre.Text = dtgServicios.CurrentRow.Cells(1).Value
            .txtboxDuracion.Text = dtgServicios.CurrentRow.Cells(2).Value
            .txtboxPrecio.Text = dtgServicios.CurrentRow.Cells(3).Value
            .idProducto = dtgServicios.CurrentRow.Cells(4).Value
            .producto = dtgServicios.CurrentRow.Cells(5).Value

            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            Dim posicion = dtgServicios.CurrentRow.Index
            Dim fservicio = dtsServicios.Tables("Servicios").Rows(posicion)

            fservicio.BeginEdit()

            fservicio("Nombre") = .txtBoxNombre.Text
            fservicio("Duracion") = .txtboxDuracion.Text
            fservicio("Precio") = .txtboxPrecio.Text
            fservicio("IdProducto") = .cmbProductos.SelectedValue
            fservicio("Producto") = .producto

            fservicio.EndEdit()
            dtaServicios.Update(dtsServicios, "Servicios")
            dtsServicios.AcceptChanges()

            MsgBox("Modificouse o servicio correctamente", MsgBoxStyle.Information, "Servicio gardado")
        End With
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        If dtgServicios.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar antes unha fila", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim posicion = dtgServicios.CurrentRow.Index
        Dim fservicio = dtsServicios.Tables("Servicios").Rows(posicion)

        If MsgBox("Estás seguro/a de eliminar o servicio " & fservicio("Nombre"),
          MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.Yes Then

            fservicio.Delete()

            dtaServicios.Update(dtsServicios, "Servicios")
            dtsServicios.Tables("Servicios").AcceptChanges()
            MsgBox("Eliminouse o servicio", MsgBoxStyle.Information, "Servicio Eliminado")
        End If
    End Sub

    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Me.BindingContext(dtsServicios.Tables("Servicios")).Position = 0
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Me.BindingContext(dtsServicios.Tables("Servicios")).Position -= 1
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Me.BindingContext(dtsServicios.Tables("Servicios")).Position += 1
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Me.BindingContext(dtsServicios.Tables("Servicios")).Position = Me.BindingContext(dtsServicios.Tables("Servicios")).Count - 1
    End Sub
End Class