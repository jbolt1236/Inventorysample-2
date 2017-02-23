Imports System.Data.SQLite
Module _C_FilterTransac

    Public Sub FilterMonth()

        Dim FString As String
        Dim FCommand As New SQLiteCommand
        Dim FAdapter As New SQLiteDataAdapter
        Dim FTable As New DataTable
        Dim FSource As New BindingSource
        Try
            Connection.Connection()

            FString = "SELECT * FROM TransacFilter WHERE Date LIKE '%" & Sales.TextBox1.Text & "%'"
            FCommand.CommandText = FString
            FCommand.Connection = connect
            FAdapter.SelectCommand = FCommand
            ' FAdapter.SelectCommand.Parameters.AddWithValue("@DateParam", Sales.DateTimePicker1.Value.Date)
            FAdapter.Fill(FTable)
            FSource.DataSource = FTable
            Sales.DataGridView1.DataSource = FSource
            FAdapter.Update(FTable)

        Catch ex As Exception
            MsgBox(ex.ToString.Trim, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Public Sub DisplaySales()

        Dim FString As String
        Dim FCommand As New SQLiteCommand
        Dim FAdapter As New SQLiteDataAdapter
        Dim FTable As New DataTable
        Dim FSource As New BindingSource
        Try
            Connection.Connection()

            FString = "SELECT * FROM TransacFilter"
            FCommand.CommandText = FString
            FCommand.Connection = connect
            FAdapter.SelectCommand = FCommand
            FAdapter.Fill(FTable)
            FSource.DataSource = FTable
            Sales.DataGridView1.DataSource = FSource
            FAdapter.Update(FTable)

        Catch ex As Exception
            MsgBox(ex.ToString.Trim, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

End Module
