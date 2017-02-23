Public Class Add

    Private Sub BtnAddIname_Click(sender As Object, e As EventArgs) Handles BtnAddIname.Click
        AddItem()
        TextIname.Clear()
        TextQuantt.Clear()
        TextPrice.Clear()
        Me.Hide()
        Inventory.Focus()
        DisplayItem()
    End Sub
End Class