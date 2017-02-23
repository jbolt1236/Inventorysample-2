Public Class SearchDeleteLoan

    Private Sub BtnDeleteLoan_Click(sender As Object, e As EventArgs) Handles BtnDeleteLoan.Click
        DeleteInfoRegistrants()
    End Sub

    Private Sub BtnSearchLoan_Click(sender As Object, e As EventArgs) Handles BtnSearchLoan.Click
        SearchInfoRegistrants()
    End Sub
End Class