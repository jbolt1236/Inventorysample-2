Public Class Cashier_Login

    Private Sub BtnCashier_Click(sender As Object, e As EventArgs) Handles BtnCashier.Click
        Cashier.Show()
        Cashier.Focus()
        Cashier.LCashierName.Text = "Cashier 1"
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cashier.Show()
        Cashier.Focus()
        Cashier.LCashierName.Text = "Cashier 2"
        Me.Hide()
    End Sub
End Class