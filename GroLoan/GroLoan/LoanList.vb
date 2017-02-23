Public Class LoanList

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoanList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        DisplayLoanRegistration()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LLtime.Text = TimeOfDay
        LLdate.Text = Today
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnLLReg_Click(sender As Object, e As EventArgs) Handles BtnLLReg.Click
        LoanForm.Show()
        LoanForm.Focus()
    End Sub

    Private Sub LoanPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanPageToolStripMenuItem.Click
        Loan.Show()
        Loan.Focus()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Admin_Cashier.Show()
        Admin_Cashier.Focus()
        Me.Hide()
    End Sub

    Private Sub BtnLLDel_Click(sender As Object, e As EventArgs) Handles BtnLLDel.Click
        SearchDeleteLoan.Show()
        SearchDeleteLoan.Focus()

    End Sub

    Private Sub BtnLLSearch_Click(sender As Object, e As EventArgs) Handles BtnLLSearch.Click
        SearchDeleteLoan.Show()
        SearchDeleteLoan.Focus()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        DisplayLoanRegistration()
    End Sub

    Private Sub PaymentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem1.Click
        Payment.Show()
        Payment.Focus()
        Payment.GroupBox2.Enabled = False
    End Sub

    Private Sub PenaltyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenaltyToolStripMenuItem.Click
        Payment.Show()
        Payment.Focus()
        Payment.GroupBox1.Enabled = False
    End Sub

    Private Sub BtnLLEdit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnLLReset_Click(sender As Object, e As EventArgs)
        DisplayLoanRegistration()
    End Sub
End Class