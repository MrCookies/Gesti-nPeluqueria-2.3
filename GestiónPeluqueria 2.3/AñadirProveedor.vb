Public Class AñadirProveedor


    Private Sub btnEngadirProducto_Click(sender As Object, e As EventArgs) Handles btnEngadirProducto.Click
        If txtBoxEmpresa.Text = "" Or txtBoxNombre.Text = "" Or txtboxApellidos.Text = "" Or txtboxdni.Text = "" Or txtboxTelefono.Text = "" Then
            MsgBox("Faltan datos", MsgBoxStyle.Exclamation, "Atención")
            sender.Focus()
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarProducto.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtBoxEmpresa_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtBoxEmpresa.KeyPress, txtBoxNombre.KeyPress, txtboxApellidos.KeyPress
        Dim validos As String = "ÁÉÍÓÚáíéúóqwertyuiopñlkjhgfdsazxcvbnmQWERTYUIOPÑLKJHGFDSAZXCVBNM. " & Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxdni_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtboxdni.KeyPress
        Dim validos As String = "1234567890QWERTYUIOPASDFGHJKLÑZXCVBNM-" & Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxTelefono_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtboxTelefono.KeyPress
        Dim validos As String = "1234567890+()/" & Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class