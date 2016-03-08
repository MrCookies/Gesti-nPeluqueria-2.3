Public Class Añadir_Cliente
    Public xenero As String
    Private Sub Añadir_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim muller = "Muller"
        Dim home = "Home"
        Dim pos As Integer
        cmbBoxXeneroCliente.Items.Add(muller)
        cmbBoxXeneroCliente.Items.Add(home)

        pos = cmbBoxXeneroCliente.FindStringExact(xenero)
        cmbBoxXeneroCliente.SelectedIndex = pos

    End Sub

    Private Sub txtBoxNombreCliente_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtBoxNombreCliente.KeyPress, txtBoxApelidosCliente.KeyPress
        Dim validos As String = "áíéúóqwertyuiopñlkjhgfdsazxcvbnmQWERTYUIOPÑLKJHGFDSAZXCVBNM " & Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBoxIdadeCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxIdadeCliente.KeyPress
        Dim validos As String = "1234567890" & Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBoxTelf_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtBoxTelf.KeyPress
        Dim validos As String = "1234567890+()/" & Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEngadirCliente_Click(sender As Object, e As EventArgs) Handles btnEngadirCliente.Click
        If txtBoxNombreCliente.Text = "" Or txtBoxApelidosCliente.Text = "" Or txtBoxIdadeCliente.Text = "" Or txtBoxTelf.Text = "" Then
            MsgBox("Faltan datos", MsgBoxStyle.Exclamation, "Atención")
            sender.Focus()
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelarCliente_Click(sender As Object, e As EventArgs) Handles btnCancelarCliente.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class