Public Class Update_Item

    Private Sub BtnUpdateIname_Click(sender As Object, e As EventArgs) Handles BtnUpdateIname.Click
        UpdateInventoryStocks()
        DisplayItem()
        TextIname.Clear()
        TextQuantt.Clear()
        TextPrice.Clear()
    End Sub
End Class