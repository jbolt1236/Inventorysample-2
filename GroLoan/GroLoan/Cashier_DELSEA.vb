Public Class Cashier_DELSEA


    Private Sub BtnDeleteCash_Click(sender As Object, e As EventArgs) Handles BtnDeleteCash.Click
        DeletePurchaseItem()
        ColumnTotal()
        TextDelSeaCash.Clear()
    End Sub

    Private Sub BtnSearchCash_Click(sender As Object, e As EventArgs) Handles BtnSearchCash.Click
        SearchPurcahseItem()
        TextDelSeaCash.Clear()
    End Sub
End Class