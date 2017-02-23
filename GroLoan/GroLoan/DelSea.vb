Public Class DelSea

    Private Sub BtnDeleteReg_Click(sender As Object, e As EventArgs) Handles BtnDeleteReg.Click
        DeleteRegistrationData()
        TextDelSea.Clear()
    End Sub

    Private Sub BtnSearchReg_Click(sender As Object, e As EventArgs) Handles BtnSearchReg.Click
        SearchRegisteredRecord()
        TextDelSea.Clear()
    End Sub
End Class