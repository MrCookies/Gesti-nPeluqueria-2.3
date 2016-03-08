Public Class AñadirProducto

    Private Sub AñadirProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBoxNombreProducto_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtBoxNombreProducto.KeyPress
        Dim validos As String = "áíéúóqwertyuiopñlkjhgfdsazxcvbnmQWERTYUIOPÑLKJHGFDSAZXCVBNMÉÁÍÓÚ " & Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBoxprecioCompra_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtBoxprecioCompra.KeyPress, txtboxPVP.KeyPress
        Dim validos As String = "1234567890,." & Chr(8)

        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub txtboxStock_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtboxStock.KeyPress
        Dim validos As String = "1234567890" & Chr(8)

        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEngadirProducto_Click(sender As Object, e As EventArgs) Handles btnEngadirProducto.Click
        If txtBoxNombreProducto.Text = "" Or txtBoxprecioCompra.Text = "" Or txtboxPVP.Text = "" Or txtboxStock.Text = "" Then
            MsgBox("Faltan datos", MsgBoxStyle.Exclamation, "Atención")
            sender.Focus()
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarProducto.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class