Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = TimeOfDay
        Label5.Text = Today
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Logined()
        TextPW.Text = ""
        TextUname.Text = ""
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Change_account.Show()
        Change_account.Focus()
    End Sub

    Private Sub Label8_MouseHover(sender As Object, e As EventArgs) Handles Label8.MouseHover
        Label8.ForeColor = Color.White
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Label8.ForeColor = Color.Teal
    End Sub
End Class
