Public Class Change_account

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangeCredentials()
        textChangePass.Text = ""
        textChangeUname.Text = ""
    End Sub
End Class