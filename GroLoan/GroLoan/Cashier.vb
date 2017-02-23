Imports System.Drawing.Printing

Public Class Cashier

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Grocerytime.Text = TimeOfDay
        Me.Grocerydate.Text = Today

    End Sub

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        DisplayPurchasedItem()
        ColumnTotal()
    End Sub

    Private Sub Textitems_TextChanged(sender As Object, e As EventArgs) Handles Textitems.TextChanged
        getPriceData(Me.LPricePurchs.Text)
        getQuantityData(Me.LStockPurchs.Text)
    End Sub

    Private Sub BtnAddPrchs_Click(sender As Object, e As EventArgs) Handles BtnAddPrchs.Click
        If LStockPurchs.Text <= 0 Then
            MsgBox("Transaction not valid", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Out-of-Stock!")
            Textitems.Clear()
            TextQuantityPurchs.Clear()
            LPricePurchs.Text = 0
            LStockPurchs.Text = 0
        Else

            AddPurchaseItem()
            AddOnTransacFilter()
            QuantityDeduct()
            ColumnTotal()
            Textitems.Clear()
            TextQuantityPurchs.Clear()
            LPricePurchs.Text = 0
            LStockPurchs.Text = 0
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Admin_Cashier.Show()
        Admin_Cashier.Focus()
        Me.Hide()
    End Sub

    Private Sub LPricePurchs_Click(sender As Object, e As EventArgs) Handles LPricePurchs.Click

    End Sub

    Private Sub BtnDeletePurchs_Click(sender As Object, e As EventArgs) Handles BtnDeletePurchs.Click
        Cashier_DELSEA.Show()
        Cashier_DELSEA.Focus()
        Cashier_DELSEA.BtnSearchCash.Enabled = False
    End Sub

    Private Sub BtnSrchPurchs_Click(sender As Object, e As EventArgs) Handles BtnSrchPurchs.Click
        Cashier_DELSEA.Show()
        Cashier_DELSEA.Focus()
        Cashier_DELSEA.BtnDeleteCash.Enabled = False
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DisplayPurchasedItem()
    End Sub

    Dim i As Integer = 0

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try

            Dim height As Integer = 0
            Dim height2 As Integer = 100
            Dim width As Integer = 0
            Dim p = New Pen(Brushes.Black, 2.5F)
            Dim colW As Integer = DataGridView1.Columns(1).Width
            Dim RowH As Integer = DataGridView1.Rows(1).Height
            Dim col2W As Integer = DataGridView2.Columns(0).Width
            Dim Row2H As Integer = DataGridView2.Rows(0).Height
            Dim margins As New Margins(50, 50, 50, 50)
            Dim Total As String = "TOTAL:" + DataGridView2.Rows(0).Cells(0).FormattedValue.ToString()
            PrintDocument1.DefaultPageSettings.Margins = New Margins(0.25, 0.25, 0.5, 0.5)
            Dim sagradafont As New Font("Arial", 11, FontStyle.Bold)
            Dim regularfont As New Font("Arial", 8)
            Dim Totalfont As New Font("Arial", 8, FontStyle.Bold)
            Dim randomvalue As Integer = CInt(Int((9999 * Rnd()) + 1))
            Dim val As String = randomvalue
            Dim YY As String = Grocerydate.Text
            YY.Split()

            Dim stringlist As String = Grocerydate.Text
            Dim datalist() As String = stringlist.Split("/")
            Dim RMM As String = datalist(0)
            Dim RDD As String = datalist(1)
            Dim RYY As String = datalist(2)

        


        'Dim T As Double = Grocerytime.Text
            Dim ReceiptNumber As String = "Receipt Number : " + "GRL-" + RYY + " OA-" + RMM + RDD + " N-" + val
        '  Debug.WriteLine(e.PageSettings.PaperSize.Kind.ToString() + "" + e.PageSettings.PaperSize.PaperName + "" + e.PageSettings.PaperSize.Width + "" + e.PageSettings.PaperSize.Height)
        ' PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Test", 822, 792)

        'Dim pkCustomSize1 As New System.Drawing.Printing.PaperSize("Custom Size", 288, 792)

        'PrintDocument1.PrinterSettings.DefaultPageSettings.PaperSize = pkCustomSize1

        'For Each psize As PaperSize In PrintDocument1.PrinterSettings.PaperSizes
        '    If psize.PaperName = "Custom Paper Size" Then
        '        PrintDocument1.PrinterSettings.DefaultPageSettings.PaperSize = psize
        '        PrintDocument1.DefaultPageSettings.PaperSize = psize
        '    End If
        'Next psize

        ' PrintDocument1.PrinterSettings.DefaultPageSettings.Margins.Top = 0.25
        e.Graphics.DrawString(Grocerydate.Text, regularfont, Brushes.Black, New Rectangle(25, 75, colW, RowH))
        e.Graphics.DrawString("Sagrada Familia Grocery", sagradafont, Brushes.Black, New Rectangle(75, 50, 170 + colW, RowH))
        e.Graphics.DrawString(LCashierName.Text, regularfont, Brushes.Black, New Rectangle(150, 75, colW, RowH))
            e.Graphics.DrawString(ReceiptNumber, Totalfont, Brushes.Black, New Rectangle(25, 100, 500 + colW, RowH))
        'Items
        e.Graphics.FillRectangle(Brushes.DarkGray, New Rectangle(25, 125, colW, RowH))
        'e.Graphics.DrawRectangle(p, New Rectangle(100, 100, colW, RowH))
        e.Graphics.DrawString(DataGridView1.Columns(1).HeaderText.ToString(), regularfont, Brushes.Black, New Rectangle(25, 125, colW, RowH))
        'Quantity
        e.Graphics.FillRectangle(Brushes.DarkGray, New Rectangle(25 + colW, 125, colW, RowH))
        'e.Graphics.DrawRectangle(p, New Rectangle(100 + colW, 100, colW, RowH))
        e.Graphics.DrawString(DataGridView1.Columns(2).HeaderText.ToString(), regularfont, Brushes.Black, New Rectangle(25 + colW, 125, colW, RowH))
        'Price
        e.Graphics.FillRectangle(Brushes.DarkGray, New Rectangle(110 + colW, 125, colW, RowH))
        'e.Graphics.DrawRectangle(p, New Rectangle(185 + colW, 100, colW, RowH))
        e.Graphics.DrawString(DataGridView1.Columns(3).HeaderText.ToString(), regularfont, Brushes.Black, New Rectangle(110 + colW, 125, colW, RowH))
        'Total
        e.Graphics.FillRectangle(Brushes.DarkGray, New Rectangle(195 + colW, 125, colW, RowH))
        'e.Graphics.DrawRectangle(p, New Rectangle(270 + colW, 100, colW, RowH))
        e.Graphics.DrawString(DataGridView1.Columns(4).HeaderText.ToString(), regularfont, Brushes.Black, New Rectangle(195 + colW, 125, colW, RowH))
        e.Graphics.DrawString(Total, Totalfont, Brushes.Black, New Rectangle(195 + colW, 75, colW, RowH))

        Height = 125
        While (i < DataGridView1.Rows.Count)

            If (Height > e.MarginBounds.Height) Then
                e.HasMorePages = True
                Return
            End If

            'Items
            Height += DataGridView1.Rows(0).Height
            'e.Graphics.DrawRectangle(p, New Rectangle(100, height, colW, RowH))
            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(1).FormattedValue.ToString(), regularfont, Brushes.Black, New Rectangle(25, Height, colW, RowH))
            'Quantity
            'e.Graphics.DrawRectangle(p, New Rectangle(100 + colW, height, colW, RowH))
            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(2).FormattedValue.ToString(), regularfont, Brushes.Black, New Rectangle(25 + colW, Height, colW, RowH))
            'Price
            'e.Graphics.DrawRectangle(p, New Rectangle(185 + colW, height, colW, RowH))
            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(3).FormattedValue.ToString(), regularfont, Brushes.Black, New Rectangle(110 + colW, Height, colW, RowH))
            'Total
            ' e.Graphics.DrawRectangle(p, New Rectangle(270 + colW, height, colW, RowH))
            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(4).FormattedValue.ToString(), regularfont, Brushes.Black, New Rectangle(195 + colW, Height, colW, RowH))
            'GrandTotal

            i = i + 1
        End While


        Catch ex As IndexOutOfRangeException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'Receipt.ShowDialog()
        ' PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem1.Click
        
        PrintPreviewDialog1.ShowDialog()
    End Sub

    
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        ColumnTotal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DeleteAll()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load
        Dim pkCustomSize1 As New System.Drawing.Printing.PaperSize("Custom Size", 288, 792)

        PrintDocument1.PrinterSettings.DefaultPageSettings.PaperSize = pkCustomSize1
    End Sub


   


End Class