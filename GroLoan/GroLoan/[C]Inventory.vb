Imports System.Data.SQLite
Module _C_Inventory

    Public Sub AddItem()

        Connection.Connection()
        Dim itemstring As String
        Dim itemcommand As New SQLiteCommand
        Dim itemadpater As New SQLiteDataAdapter
        Dim itemtable As New DataTable
        Dim itemsource As New BindingSource

        itemstring = "INSERT INTO Grocery(`item_name`,`Quantity`,`Price`,`Date`) VALUES('" & Add.TextIname.Text & "','" & Add.TextQuantt.Text & "','" & Add.TextPrice.Text & "','" & Inventory.AdmnInvdate.Text & "')"
        itemcommand.CommandText = itemstring
        itemcommand.Connection = connect
        itemadpater.SelectCommand = itemcommand
        itemadpater.Fill(itemtable)
       
    End Sub

    Public Sub DisplayItem()

        Connection.Connection()
        Dim itemstring As String
        Dim itemcommand As New SQLiteCommand
        Dim itemadpater As New SQLiteDataAdapter
        Dim itemtable As New DataTable
        Dim itemsource As New BindingSource

        itemstring = "SELECT * FROM Grocery"
        itemcommand.CommandText = itemstring
        itemcommand.Connection = connect
        itemadpater.SelectCommand = itemcommand
        itemadpater.Fill(itemtable)
        itemsource.DataSource = itemtable
        Inventory.DataGridView1.DataSource = itemsource
        itemadpater.Update(itemtable)

    End Sub

    Public Sub DeleteItem()

        Connection.Connection()
        Dim itemstring As String
        Dim itemcommand As New SQLiteCommand
        Dim itemadpater As New SQLiteDataAdapter
        Dim itemtable As New DataTable
        Dim itemsource As New BindingSource

        itemstring = "DELETE FROM Grocery WHERE item_name = '" & Delete_item.TextDelIt.Text & "'"
        itemcommand.CommandText = itemstring
        itemcommand.Connection = connect
        itemadpater.SelectCommand = itemcommand
        itemadpater.Fill(itemtable)
        itemsource.DataSource = itemtable
        Inventory.DataGridView1.DataSource = itemsource
        itemadpater.Update(itemtable)

    End Sub

    Public Sub SearchItem()

        Connection.Connection()
        Dim itemstring As String
        Dim itemcommand As New SQLiteCommand
        Dim itemadpater As New SQLiteDataAdapter
        Dim itemtable As New DataTable
        Dim itemsource As New BindingSource

        itemstring = "SELECT * FROM Grocery WHERE item_name = '" & Search_item.TextSrchIt.Text & "'"
        itemcommand.CommandText = itemstring
        itemcommand.Connection = connect
        itemadpater.SelectCommand = itemcommand
        itemadpater.Fill(itemtable)
        itemsource.DataSource = itemtable
        Inventory.DataGridView1.DataSource = itemsource
        itemadpater.Update(itemtable)

    End Sub

    Public Sub UpdateInventoryStocks()

        Connection.Connection()
        Dim itemstring As String
        Dim itemcommand As New SQLiteCommand
        Dim itemadpater As New SQLiteDataAdapter
        Dim itemtable As New DataTable
        Dim itemsource As New BindingSource

        itemstring = "UPDATE Grocery SET item_name ='" & Update_Item.TextIname.Text & "', Quantity='" & Update_Item.TextQuantt.Text & "', Price='" & Update_Item.TextPrice.Text & "', Date='" & Inventory.AdmnInvdate.Text & "' WHERE item_name='" & Update_Item.TextIname.Text & "'"
        itemcommand.CommandText = itemstring
        itemcommand.Connection = connect
        itemadpater.SelectCommand = itemcommand
        itemadpater.Fill(itemtable)
        itemsource.DataSource = itemtable
        Inventory.DataGridView1.DataSource = itemsource
        itemadpater.Update(itemtable)

    End Sub
End Module
