Public Class Loan

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Loantime.Text = TimeOfDay
        Loandate.Text = Today

    End Sub

    Private Sub Loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Admin_Cashier.Show()
        Admin_Cashier.Focus()
        Me.Hide()
    End Sub

    Private Sub MembershipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembershipToolStripMenuItem.Click
        Registration.Show()
        Registration.Focus()
        Me.Hide()
    End Sub

    Private Sub LoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanToolStripMenuItem.Click
        LoanList.Show()
        LoanList.Focus()
        Me.Hide()
    End Sub
End Class