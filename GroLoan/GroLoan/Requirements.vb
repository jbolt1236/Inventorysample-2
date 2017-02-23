Public Class Requirements

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        UserRegistration()
        TextName.Clear()
        TextAddrss.Clear()
        TextAge.Clear()
        TextAmntDpstd.Clear()
        TextCnmbr.Clear()
        ComboPos.Items.Clear()
        TextTnmbr.Clear()
        ComboCVS.Items.Clear()
        ComboSex.Items.Clear()
        TextEmail.Clear()

    End Sub

   
    Private Sub BtnUpdatereq_Click(sender As Object, e As EventArgs) Handles BtnUpdatereq.Click
        EditRegistration()
    End Sub

    Private Sub Requirements_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class