Imports System.Data.OleDb
Public Class GestionPeluqueria

    Dim dtsCitas, dtsBusca As DataSet
    Dim dtaCitas, dtaBusca As OleDbDataAdapter
    Dim cbCitas As OleDbCommandBuilder

    Dim nombreCliente, nombreServicio As String
    Dim idcliente, idservicio, duracion As Integer
    Private Sub GestionPeluqueria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtsCitas = New DataSet
        dtaCitas = New OleDbDataAdapter("Select * from Citas order by Fecha desc, Hora", cnnPeluqueria)
        dtaCitas.Fill(dtsCitas, "Citas")
        dtsCitas.Tables("Citas").DefaultView.Sort = "Fecha DESC"

        cbCitas = New OleDbCommandBuilder(dtaCitas)

        dtpCitas_ValueChanged(Nothing, Nothing)
    End Sub

    Private Sub configurarDataGrid(tabla As DataSet)
        dtgCitas.DataSource = tabla.Tables("Citas").DefaultView

        dtgCitas.Columns(0).Visible = False
        dtgCitas.Columns(3).Visible = False
        dtgCitas.Columns(4).Visible = False
        dtgCitas.Columns(6).Width = 152

        For index = 0 To dtgCitas.Columns.Count - 1
            dtgCitas.Columns(index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgCitas.Columns(index).DefaultCellStyle.Font = New Font("Times New Roman", 10, FontStyle.Regular)
        Next
    End Sub

    Private Sub btnTodas_Click(sender As Object, e As EventArgs) Handles btnTodas.Click
        dtpCitas.Value = Now
        configurarDataGrid(dtsCitas)
        lblCitas.Text = "Todas as citas"
    End Sub

    Private Sub dtpCitas_ValueChanged(sender As Object, e As EventArgs) Handles dtpCitas.ValueChanged
        Dim fecha = dtpCitas.Value.Day & "/" & dtpCitas.Value.Month & "/" & dtpCitas.Value.Year
        dtsBusca = New DataSet
        dtaBusca = New OleDbDataAdapter("Select * from Citas where Fecha='" & fecha & "' order by Hora", cnnPeluqueria)
        dtaBusca.Fill(dtsBusca, "Citas")

        dtsBusca.Tables("Citas").DefaultView.Sort = "Fecha DESC"

        lblCitas.Text = "Citas do día " & fecha
        configurarDataGrid(dtsBusca)
    End Sub

    Private Sub GestionPeluqueria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MsgBox("Desea salir de la Aplicación", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atención") = MsgBoxResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ErrorSalir As System.ComponentModel.Win32Exception
        End Try
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        Dim formServicios As New Servicios
        formServicios.showDialog()
    End Sub

    Private Sub NovaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaToolStripMenuItem.Click
        Dim formCita As New AñadirCita
        With formCita
            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            .modi = False
            Dim fcita As DataRow
            fcita = dtsCitas.Tables("Citas").NewRow

            fcita("IdCliente") = .cmbClientes.SelectedValue
            fcita("IdServicio") = .cmbServicios.SelectedValue
            fcita("Duracion") = .duracion
            fcita("Fecha") = .fecha
            fcita("Cliente") = .cliente & " " & .apellido
            fcita("Servicio") = .servicio
            fcita("Hora") = .hora

            dtsCitas.Tables("Citas").Rows.Add(fcita)

            dtaCitas.Update(dtsCitas, "Citas")
            dtsCitas.AcceptChanges()

            MsgBox("Engadiuse a cita correctamente", MsgBoxStyle.Information, "Servicio gardado")
        End With
    End Sub


    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim formVerClientes As New Ver_Clientes
        formVerClientes.ShowDialog()
    End Sub

    Private Sub AlmacénToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacénToolStripMenuItem.Click
        Dim formAlmacen As New Almacen
        formAlmacen.ShowDialog()
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        If dtgCitas.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar antes unha fila", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim posicion = dtgCitas.CurrentRow.Index
        Dim fcita = dtsCitas.Tables("Citas").Rows(posicion)

        If MsgBox("Estás seguro/a de eliminar a cita con " & fcita("Cliente") & " do dia " & dtgCitas.CurrentRow.Cells(1).Value,
          MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.Yes Then

            fcita.Delete()

            dtaCitas.Update(dtsCitas, "Citas")
            dtsCitas.Tables("Citas").AcceptChanges()
            MsgBox("Eliminouse a cita", MsgBoxStyle.Information, "Cita Eliminada")
        End If
    End Sub

    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Me.BindingContext(dtsCitas.Tables("Citas").DefaultView).Position = 0

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Citas").DefaultView).Position = 0
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Me.BindingContext(dtsCitas.Tables("Citas").DefaultView).Position -= 1

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Citas").DefaultView).Position -= 1
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Me.BindingContext(dtsCitas.Tables("Citas").DefaultView).Position += 1

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Citas").DefaultView).Position += 1
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Me.BindingContext(dtsCitas.Tables("Citas").DefaultView).Position = Me.BindingContext(dtsCitas.Tables("Citas").DefaultView).Count - 1

        If Not dtsBusca Is Nothing Then
            Me.BindingContext(dtsBusca.Tables("Citas").DefaultView).Position = Me.BindingContext(dtsBusca.Tables("Citas").DefaultView).Count - 1
        End If
    End Sub
End Class
