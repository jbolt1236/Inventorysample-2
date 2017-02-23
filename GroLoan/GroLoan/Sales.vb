Imports System.Drawing.Printing

Public Class Sales



    Private Sub BtnAddIn_Click(sender As Object, e As EventArgs) Handles BtnAddIn.Click
        Try
            printButton.Visible = True
            Dim total As String = 0
            For i As Integer = 0 To DataGridView1.RowCount - 1
                total += DataGridView1.Rows(i).Cells(4).Value
            Next

            If TextBox1.Text = 1 Then
                TextBox2.Text = "Total sale of January : = " + total
            ElseIf TextBox1.Text = 2 Then
                TextBox2.Text = "Total sale of February : = " + total
            ElseIf TextBox1.Text = 3 Then
                TextBox2.Text = "Total sale of March : = " + total
            ElseIf TextBox1.Text = 4 Then
                TextBox2.Text = "Total sale of April : = " + total
            ElseIf TextBox1.Text = 5 Then
                TextBox2.Text = "Total sale of May : = " + total
            ElseIf TextBox1.Text = 6 Then
                TextBox2.Text = "Total sale of June : = " + total
            ElseIf TextBox1.Text = 7 Then
                TextBox2.Text = "Total sale of July : = " + total
            ElseIf TextBox1.Text = 8 Then
                TextBox2.Text = "Total sale of August : = " + total
            ElseIf TextBox1.Text = 9 Then
                TextBox2.Text = "Total sale of September : = " + total
            ElseIf TextBox1.Text = 10 Then
                TextBox2.Text = "Total sale of October : = " + total
            ElseIf TextBox1.Text = 11 Then
                TextBox2.Text = "Total sale of November : = " + total
            ElseIf TextBox1.Text = 12 Then
                TextBox2.Text = "Total sale of December : = " + total
            Else
                MsgBox("No such MONTH", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + "Try Again!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString.Trim)
        End Try
        'TextBox2.Text = TextBox2.Text + total
    End Sub

    Private Sub BtnUpIn_Click(sender As Object, e As EventArgs) Handles BtnUpIn.Click
        DisplaySales()
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySales()
        Timer1.Enabled = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
        FilterMonth()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        FilterMonth()
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
            '  Dim col2W As Integer = DataGridView2.Columns(0).Width
            ' Dim Row2H As Integer = DataGridView2.Rows(0).Height
            Dim margins As New Margins(50, 50, 50, 50)
            ' Dim Total As String = "TOTAL:" + DataGridView2.Rows(0).Cells(0).FormattedValue.ToString()
            PrintDocument1.DefaultPageSettings.Margins = New Margins(0.25, 0.25, 0.5, 0.5)
            Dim sagradafont As New Font("Arial", 16, FontStyle.Bold)
            Dim regularfont As New Font("Arial", 11)
            Dim Totalfont As New Font("Arial", 11, FontStyle.Bold)

            'HEADER
            e.Graphics.DrawString("Monthly Grocery Sales", sagradafont, Brushes.Black, New Rectangle(300, 100, 200 + colW, 50 + RowH))
            e.Graphics.DrawString("Date: " + AdmnInvdate.Text, regularfont, Brushes.Black, New Rectangle(350, 125, colW, RowH))
            e.Graphics.DrawString("Month:  " + TextBox1.Text + "/2016", regularfont, Brushes.Black, New Rectangle(350, 150, colW, RowH))
            e.Graphics.DrawString(TextBox2.Text + " pesos", Totalfont, Brushes.Black, New Rectangle(350, 175, 200 + colW, RowH))

            'DataGridView HEADER
            e.Graphics.FillRectangle(Brushes.DarkGray, New Rectangle(200, 200, colW, RowH))
            e.Graphics.DrawString(DataGridView1.Columns(1).HeaderText.ToString, regularfont, Brushes.Black, New Rectangle(200, 200, colW, RowH))

            e.Graphics.FillRectangle(Brushes.DarkGray, New Rectangle(200 + colW, 200, colW, RowH))
            e.Graphics.DrawString(DataGridView1.Columns(2).HeaderText.ToString, regularfont, Brushes.Black, New Rectangle(200 + colW, 200, colW, RowH))

            e.Graphics.FillRectangle(Brushes.DarkGray, New Rectangle(285 + colW, 200, colW, RowH))
            e.Graphics.DrawString(DataGridView1.Columns(3).HeaderText.ToString, regularfont, Brushes.Black, New Rectangle(285 + colW, 200, colW, RowH))

            e.Graphics.FillRectangle(Brushes.DarkGray, New Rectangle(370 + colW, 200, colW, RowH))
            e.Graphics.DrawString(DataGridView1.Columns(4).HeaderText.ToString, regularfont, Brushes.Black, New Rectangle(370 + colW, 200, colW, RowH))

            e.Graphics.FillRectangle(Brushes.DarkGray, New Rectangle(455 + colW, 200, colW, RowH))
            e.Graphics.DrawString(DataGridView1.Columns(5).HeaderText.ToString, regularfont, Brushes.Black, New Rectangle(455 + colW, 200, colW, RowH))

            height = 200
            While (i < DataGridView1.Rows.Count)

                If (height > e.MarginBounds.Height) Then
                    e.HasMorePages = True
                    Return
                End If

                'Items
                height += DataGridView1.Rows(0).Height

                e.Graphics.DrawString(DataGridView1.Rows(i).Cells(1).FormattedValue.ToString(), regularfont, Brushes.Black, New Rectangle(200, height, colW, RowH))

                e.Graphics.DrawString(DataGridView1.Rows(i).Cells(2).FormattedValue.ToString(), regularfont, Brushes.Black, New Rectangle(200 + colW, height, colW, RowH))

                e.Graphics.DrawString(DataGridView1.Rows(i).Cells(3).FormattedValue.ToString(), regularfont, Brushes.Black, New Rectangle(285 + colW, height, colW, RowH))

                e.Graphics.DrawString(DataGridView1.Rows(i).Cells(4).FormattedValue.ToString(), regularfont, Brushes.Black, New Rectangle(370 + colW, height, colW, RowH))

                e.Graphics.DrawString(DataGridView1.Rows(i).Cells(5).FormattedValue.ToString(), regularfont, Brushes.Black, New Rectangle(455 + colW, height, colW, RowH))

                i = i + 1

            End While

        Catch ex As Exception
            MsgBox(ex.ToString.Trim)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Admntime.Text = TimeOfDay
        AdmnInvdate.Text = Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles printButton.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

End Class