Public Class Inventory


    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        DisplayItem()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Admntime.Text = TimeOfDay
        Me.AdmnInvdate.Text = Today
    End Sub

    Private Sub BtnAddIn_Click(sender As Object, e As EventArgs) Handles BtnAddIn.Click
        Add.Show()
        Add.Focus()

    End Sub

    Private Sub BtnDelIn_Click(sender As Object, e As EventArgs) Handles BtnDelIn.Click
        Delete_item.Show()
        Delete_item.Focus()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Update_Item.Show()
        Update_Item.Focus()

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            Update_Item.TextIname.Text = row.Cells("item_name").Value.ToString
            Update_Item.TextQuantt.Text = row.Cells("Quantity").Value.ToString
            Update_Item.TextPrice.Text = row.Cells("Price").Value.ToString

        End If
    End Sub

    Private Sub BtnUpIn_Click(sender As Object, e As EventArgs)
        Update_Item.Show()
        Update_Item.Focus()
    End Sub

    Private Sub BtnSrchIn_Click(sender As Object, e As EventArgs) Handles BtnSrchIn.Click
        Search_item.Show()
        Search_item.Focus()
    End Sub

    Private Sub BtnUpIn_Click_1(sender As Object, e As EventArgs) Handles BtnUpIn.Click
        DisplayItem()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Admin_Cashier.Show()
        Admin_Cashier.Focus()
        Me.Hide()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Sales.Show()
        Sales.Focus()

    End Sub
End Class