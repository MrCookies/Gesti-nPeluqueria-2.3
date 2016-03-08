Imports System.Data.OleDb
Class AñadirCita
    Dim dtsClientes, dtsServicios, dtsPedidos As DataSet
    Dim dtaClientes, dtaServicios, dtaPedidos As OleDbDataAdapter
    Dim cmmbPedidos, cmmbClientes, cmmbServicios As OleDbCommandBuilder
    Public modi As Boolean
    Public cliente, apellido, servicio, hora, fecha As String
    Public duracion, idc, ids, stockProducto, idproducto As Integer

    Private Sub AñadirCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cmbServicios_SelectedIndexChanged(Nothing, Nothing)
        cmbClientes_SelectedIndexChanged(Nothing, Nothing)
        dtpCitasHora_ValueChanged(Nothing, Nothing)

        If modi = True Then
            cmbClientes.SelectedValue = idc
            cmbServicios.SelectedValue = ids
        End If
    End Sub

    Private Sub btnNovoCliente_Click(sender As Object, e As EventArgs) Handles btnNovoCliente.Click
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

    Private Sub btnNovoServicio_Click(sender As Object, e As EventArgs) Handles btnNovoServicio.Click
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectionChangeCommitted
        Dim cmdnombrecliente As New OleDbCommand("Select Nombre from Clientes where IdCliente=" & cmbClientes.SelectedValue, cnnPeluqueria)
        Dim cmdapellidoscliente As New OleDbCommand("Select Apellidos from Clientes where IdCliente=" & cmbClientes.SelectedValue, cnnPeluqueria)
        cnnPeluqueria.Open()
        cliente = cmdnombrecliente.ExecuteScalar
        apellido = cmdapellidoscliente.ExecuteScalar
        cnnPeluqueria.Close()
    End Sub

    Private Sub dtpCitasHora_ValueChanged(sender As Object, e As EventArgs) Handles dtpCitasHora.ValueChanged
        hora = dtpCitasHora.Value.ToString("HH:mm")
        fecha = dtpCitasHora.Value.Day & "/" & dtpCitasHora.Value.Month & "/" & dtpCitasHora.Value.Year
    End Sub

    'Miramos o stock do producto necesario para a cita, excepto si e o producto nulo e damos opcion a facer pedido
    'si o stock é 0. Facemos update dos productos

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim cmdupdate As New OleDbCommand("update Productos set Stock=Stock-1 where IdProducto=" & idproducto, cnnPeluqueria)
        If idproducto = 7 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Exit Sub
        End If

        If Not stockProducto = 0 Then
            cnnPeluqueria.Open()
            cmdupdate.ExecuteNonQuery()
            cnnPeluqueria.Close()
        Else
            If MsgBox("O producto necesario para dar este servicio ten un stock de 0. Queres facer un pedido ahora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atención") = MsgBoxResult.Yes Then
                Dim formPedido As New AñadirPedido
                dtsPedidos = New DataSet
                dtaPedidos = New OleDbDataAdapter("Select * from Pedidos", cnnPeluqueria)
                dtaPedidos.Fill(dtsPedidos, "Pedidos")
                cmmbPedidos = New OleDbCommandBuilder(dtaPedidos)

                With formPedido
                    .idproducto = idproducto
                    .cita = True
                    If .ShowDialog = DialogResult.Cancel Then
                        Exit Sub
                    End If

                    Dim fpedido As DataRow
                    fpedido = dtsPedidos.Tables("Pedidos").NewRow

                    Dim cantidade As Integer

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

                    Dim cmdupdateStock As New OleDbCommand("update Productos set Stock=Stock+" & cantidade & " where IdProducto=" & idproducto, cnnPeluqueria)
                    cnnPeluqueria.Open()
                    cmdupdateStock.ExecuteNonQuery()
                    cnnPeluqueria.Close()

                    MsgBox("Engadiuse o novo pedido correctamente", MsgBoxStyle.Information, "Pedido gardado")
                End With
            Else
                Exit Sub
            End If
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmbServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServicios.SelectionChangeCommitted
        Dim cmdDuracioncita As New OleDbCommand("Select Duracion from Servicios where IdServicio=" & cmbServicios.SelectedValue, cnnPeluqueria)
        Dim cmdprodServ As New OleDbCommand("Select IdProducto from Servicios where IdServicio=" & cmbServicios.SelectedValue, cnnPeluqueria)
        Dim cmdnombreServicio As New OleDbCommand("Select Nombre from Servicios where IdServicio=" & cmbServicios.SelectedValue, cnnPeluqueria)

        cnnPeluqueria.Open()
        duracion = cmdDuracioncita.ExecuteScalar
        servicio = cmdnombreServicio.ExecuteScalar
        idproducto = cmdprodServ.ExecuteScalar
        Dim cmdstockProducto As New OleDbCommand("Select Stock from Productos where IdProducto=" & idproducto, cnnPeluqueria)
        stockProducto = cmdstockProducto.ExecuteScalar
        cnnPeluqueria.Close()
    End Sub

    Private Sub cargarDatos()
        dtsClientes = New DataSet
        dtaClientes = New OleDbDataAdapter("Select * from Clientes order by Nombre", cnnPeluqueria)
        dtaClientes.Fill(dtsClientes, "Clientes")
        cmmbClientes = New OleDbCommandBuilder(dtaClientes)

        dtsClientes.Tables("Clientes").DefaultView.Sort = "Nombre"

        cmbClientes.DataSource = dtsClientes.Tables("Clientes")
        cmbClientes.DisplayMember = "Nombre"
        cmbClientes.ValueMember = "IdCliente"

        dtsServicios = New DataSet
        dtaServicios = New OleDbDataAdapter("Select * from Servicios order by Nombre", cnnPeluqueria)
        dtaServicios.Fill(dtsServicios, "Servicios")
        cmmbServicios = New OleDbCommandBuilder(dtaServicios)

        dtsServicios.Tables("Servicios").DefaultView.Sort = "Nombre"

        cmbServicios.DataSource = dtsServicios.Tables("Servicios")
        cmbServicios.DisplayMember = "Nombre"
        cmbServicios.ValueMember = "IdServicio"
    End Sub
End Class