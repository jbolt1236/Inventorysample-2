Public Class Registration

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        DisplayRegistrationData()
        Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoanRgttime.Text = TimeOfDay
        LoanRgtdate.Text = Today

    End Sub

    Private Sub LoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanToolStripMenuItem.Click
        Loan.Show()
        Loan.Focus()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Admin_Cashier.Show()
        Admin_Cashier.Focus()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Requirements.Show()
        Requirements.Focus()
        Requirements.BtnUpdatereq.Enabled = False
        DisplayRegistrationData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Requirements.Show()
        Requirements.Focus()
        Requirements.BtnRegister.Enabled = False
        DisplayRegistrationData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Requirements.Show()
        Requirements.Focus()
        Requirements.BtnRegister.Enabled = False
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            Requirements.TextName.Text = row.Cells("Name").Value.ToString
            Requirements.TextAddrss.Text = row.Cells("Address").Value.ToString
            Requirements.TextEmail.Text = row.Cells("Email").Value.ToString
            Requirements.ComboPos.Text = row.Cells("Position").Value.ToString
            Requirements.TextCnmbr.Text = row.Cells("ContactNo").Value.ToString
            Requirements.TextAmntDpstd.Text = row.Cells("Amount_Deposited").Value.ToString
            Requirements.TextAge.Text = row.Cells("Age").Value.ToString
            Requirements.TextTnmbr.Text = row.Cells("TeleponeNo").Value.ToString
            Requirements.ComboCVS.Text = row.Cells("Civil_status").Value.ToString
            Requirements.ComboSex.Text = row.Cells("Sex").Value.ToString
            Requirements.DateTimePicker1.Text = row.Cells("Birthdate").Value.ToString

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DelSea.Show()
        DelSea.Focus()
        DelSea.BtnSearchReg.Enabled = False
        DisplayRegistrationData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DelSea.Show()
        DelSea.Focus()
        DelSea.BtnDeleteReg.Enabled = False
        DisplayRegistrationData()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        DisplayRegistrationData()
    End Sub
End Class