Imports System.Data.SQLite
Imports System.Data
Module _C_Cashier

    Public Sub AddPurchaseItem()


        Connection.Connection()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable

        PurchaseString = "INSERT INTO Transac(`Items`,`Quantity`,`Price`,`Total`) VALUES('" & Cashier.Textitems.Text & "','" & Cashier.TextQuantityPurchs.Text & "','" & Cashier.LPricePurchs.Text & "','" & Cashier.TextQuantityPurchs.Text * Cashier.LPricePurchs.Text & "')"
        PurchaseCommand.CommandText = PurchaseString
        PurchaseCommand.Connection = connect
        PurchaseAdapter.SelectCommand = PurchaseCommand
        PurchaseAdapter.Fill(PurchaseTable)

        DisplayPurchasedItem()

    End Sub

    Public Sub AddOnTransacFilter()


        Connection.Connection()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable

        PurchaseString = "INSERT INTO TransacFilter(`Items`,`Quantity`,`Price`,`Total`,`Date`) VALUES('" & Cashier.Textitems.Text & "','" & Cashier.TextQuantityPurchs.Text & "','" & Cashier.LPricePurchs.Text & "','" & Cashier.TextQuantityPurchs.Text * Cashier.LPricePurchs.Text & "','" & Cashier.Grocerydate.Text & "')"
        PurchaseCommand.CommandText = PurchaseString
        PurchaseCommand.Connection = connect
        PurchaseAdapter.SelectCommand = PurchaseCommand
        PurchaseAdapter.Fill(PurchaseTable)

        DisplayPurchasedItem()

    End Sub

    Public Sub DisplayPurchasedItem()

        Connection.Connection()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable
        Dim PurchaseSource As New BindingSource

        PurchaseString = "SELECT id,Items,Quantity,Price,Total FROM Transac"
        PurchaseCommand.CommandText = PurchaseString
        PurchaseCommand.Connection = connect
        PurchaseAdapter.SelectCommand = PurchaseCommand
        PurchaseAdapter.Fill(PurchaseTable)
        PurchaseSource.DataSource = PurchaseTable
        Cashier.DataGridView1.DataSource = PurchaseSource
        PurchaseAdapter.Update(PurchaseTable)

    End Sub

    Public Sub SearchItemPrice()

        Connection.Connection()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable
        Dim PurchaseSource As New BindingSource

        PurchaseString = "SELECT Price FROM Grocery WHERE Item_name = '" & Cashier.Textitems.Text & "'"
        PurchaseCommand.CommandText = PurchaseString
        PurchaseCommand.Connection = connect
        PurchaseAdapter.SelectCommand = PurchaseCommand
        PurchaseAdapter.Fill(PurchaseTable)
        PurchaseSource.DataSource = PurchaseTable
        ' Cashier.LPricePurchs.Text = PurchaseSource
        PurchaseAdapter.Update(PurchaseTable)

    End Sub

    Public Sub getPriceData(ByVal user As String)

        Connection.Connection()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable
        Dim PurchaseSource As New BindingSource

        PurchaseString = "SELECT Price FROM Grocery WHERE Item_name = '" & Cashier.Textitems.Text & "'"
        PurchaseCommand.CommandText = PurchaseString
        PurchaseCommand.Connection = connect
        PurchaseAdapter.SelectCommand = PurchaseCommand
        PurchaseCommand.Parameters.AddWithValue("Price", user)
        PurchaseAdapter.Fill(PurchaseTable)

        If PurchaseTable.Rows.Count > 0 Then
            Cashier.LPricePurchs.Text = PurchaseTable.Rows(0)("Price").ToString
        End If
    End Sub

    Public Sub getQuantityData(ByVal user As String)

        Connection.Connection()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable
        Dim PurchaseSource As New BindingSource

        PurchaseString = "SELECT Quantity FROM Grocery WHERE Item_name = '" & Cashier.Textitems.Text & "'"
        PurchaseCommand.CommandText = PurchaseString
        PurchaseCommand.Connection = connect
        PurchaseAdapter.SelectCommand = PurchaseCommand
        PurchaseCommand.Parameters.AddWithValue("Quantity", user)
        PurchaseAdapter.Fill(PurchaseTable)

        If PurchaseTable.Rows.Count > 0 Then
            Cashier.LStockPurchs.Text = PurchaseTable.Rows(0)("Quantity").ToString
        End If
    End Sub



    ' Private Sub getData(ByVal user As String)
    'Dim dt As New DataTable()
    ' Dim connection As New SqlConnection("YOUR CONNECTION STRING HERE")
    '     connection.Open()
    '  Dim sqlCmd As New SqlCommand("SELECT * from TABLE1 WHERE UserID = @username", Connection)
    '  Dim sqlDa As New SqlDataAdapter(sqlCmd)

    '    sqlCmd.Parameters.AddWithValue("@username", user)
    '   sqlDa.Fill(dt)
    '  If dt.Rows.Count > 0 Then
    ' TextBox1.Text = dt.Rows(0)("ColumnName1").ToString ColumnName is the Field from the DB that you want to display 
    '    TextBox2.Text = dt.Rows(0)("ColumnName2").ToString
    '   Label1.Text = dt.Rows(0)("ColumnName3").ToString
    '  Label2.Text = dt.Rows(0)("ColumnName4").ToString
    '     End If
    '    connection.Close()
    ' End Sub

    Public Sub QuantityDeduct()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable
        Dim PurchaseSource As New BindingSource

        Connection.Connection()

        PurchaseString = "UPDATE Grocery SET Quantity = '" & Cashier.LStockPurchs.Text - Cashier.TextQuantityPurchs.Text & "' WHERE item_name = '" & Cashier.Textitems.Text & "'"
        PurchaseCommand.CommandText = PurchaseString
        PurchaseCommand.Connection = connect
        PurchaseAdapter.SelectCommand = PurchaseCommand
        PurchaseAdapter.Fill(PurchaseTable)
        
    End Sub

    Public Sub DeletePurchaseItem()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable
        Dim PurchaseSource As New BindingSource

        Connection.Connection()

        PurchaseString = "DELETE FROM Transac WHERE Items='" & Cashier_DELSEA.TextDelSeaCash.Text & "'"
        PurchaseCommand.CommandText = PurchaseString
        PurchaseCommand.Connection = connect
        PurchaseAdapter.SelectCommand = PurchaseCommand
        PurchaseAdapter.Fill(PurchaseTable)
        DisplayPurchasedItem()
    End Sub

    Public Sub SearchPurcahseItem()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable
        Dim PurchaseSource As New BindingSource

        Connection.Connection()

        PurchaseString = "SELECT * FROM Transac WHERE Items='" & Cashier_DELSEA.TextDelSeaCash.Text & "'"
        PurchaseCommand.CommandText = PurchaseString
        PurchaseCommand.Connection = connect
        PurchaseAdapter.SelectCommand = PurchaseCommand
        PurchaseAdapter.Fill(PurchaseTable)
        PurchaseSource.DataSource = PurchaseTable
        Cashier.DataGridView1.DataSource = PurchaseSource
        PurchaseAdapter.Update(PurchaseTable)
    End Sub

    Public Sub ColumnTotal()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable
        Dim PurchaseSource As New BindingSource
        Try

            Connection.Connection()

            PurchaseString = "SELECT SUM(Total) AS GrandTotal FROM Transac"
            PurchaseCommand.CommandText = PurchaseString
            PurchaseCommand.Connection = connect
            PurchaseAdapter.SelectCommand = PurchaseCommand
            PurchaseAdapter.Fill(PurchaseTable)
            PurchaseSource.DataSource = PurchaseTable
            Cashier.DataGridView2.DataSource = PurchaseSource
            PurchaseAdapter.Update(PurchaseTable)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub DeleteAll()

        Dim PurchaseString As String
        Dim PurchaseCommand As New SQLiteCommand
        Dim PurchaseAdapter As New SQLiteDataAdapter
        Dim PurchaseTable As New DataTable
        Dim PurchaseSource As New BindingSource
        Try

            Connection.Connection()

            PurchaseString = "DELETE FROM Transac"
            PurchaseCommand.CommandText = PurchaseString
            PurchaseCommand.Connection = connect
            PurchaseAdapter.SelectCommand = PurchaseCommand
            PurchaseAdapter.Fill(PurchaseTable)
            PurchaseSource.DataSource = PurchaseTable
            Cashier.DataGridView1.DataSource = PurchaseSource
            PurchaseAdapter.Update(PurchaseTable)
            DisplayPurchasedItem()
            ColumnTotal()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub



End Module
