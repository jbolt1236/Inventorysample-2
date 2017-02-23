Public Class Admin_Cashier

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        Password.Show()
        Password.Focus()
    End Sub

    Private Sub BtnCashier_Click(sender As Object, e As EventArgs) Handles BtnCashier.Click
        Cashier_Login.Show()
        Cashier_Login.Focus()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Form1.Show()
        Form1.Focus()
        Me.Hide()
    End Sub

    Private Sub BtnLoan_Click(sender As Object, e As EventArgs) Handles BtnLoan.Click
        Loan.Show()
        Loan.Focus()
        Me.Hide()
    End Sub
End Class