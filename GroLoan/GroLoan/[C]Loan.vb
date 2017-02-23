Imports System.Data.SQLite
Imports System.Data
Module _C_Loan

    Public Sub InsertLoanRegistration()

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable

            LaonString = "INSERT INTO Loan (`ClientNo`,`Name`,`Address`,`ContactNo`,`Type`,`Amount`,`Period`,`Date`,`Monthly_Payment`,`Deduction`,`Total`) VALUES('" & LoanForm.TextCLnoReq.Text & "','" & LoanForm.TextLFName.Text & "','" & LoanForm.TextLFAddrss.Text & "','" & LoanForm.TextLFCno.Text & "','" & LoanForm.ComboLFLoantype.Text & "','" & LoanForm.TextLFLAmount.Text & "','" & LoanForm.TextLFMPeriod.Text & "','" & LoanForm.DateTimePicker1.Text & "','" & LoanForm.TextMonthlyP.Text & "','" & LoanForm.LLFDeduction.Text & "','" & LoanForm.LLFTLAmount.Text & "')"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanAdapter.Fill(LoanTable)

            DisplayLoanRegistration()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub DisplayLoanRegistration()


        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT * FROM Loan"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanAdapter.Fill(LoanTable)
            LoanSource.DataSource = LoanTable
            LoanList.DataGridView1.DataSource = LoanSource
            LoanAdapter.Update(LoanTable)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getRegistrantsInfo2(ByVal name As String)

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT Name FROM Registered WHERE ClientNo = '" & LoanForm.TextCLnoReq.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanCommand.Parameters.AddWithValue("Name", name)
            LoanAdapter.Fill(LoanTable)

            If LoanTable.Rows.Count > 0 Then
                LoanForm.LNameGet.Text = LoanTable.Rows(0)("Name").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getRegistrantsInfo(ByVal name As String)

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT Name FROM Registered WHERE ClientNo = '" & LoanForm.TextCLnoReq.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanCommand.Parameters.AddWithValue("Name", name)
            LoanAdapter.Fill(LoanTable)

            If LoanTable.Rows.Count > 0 Then
                LoanForm.TextLFName.Text = LoanTable.Rows(0)("Name").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getRegistrantsInfoAddress(ByVal address As String)

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT Address FROM Registered WHERE ClientNo = '" & LoanForm.TextCLnoReq.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanCommand.Parameters.AddWithValue("Address", address)
            LoanAdapter.Fill(LoanTable)

            If LoanTable.Rows.Count > 0 Then
                LoanForm.TextLFAddrss.Text = LoanTable.Rows(0)("Address").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getRegistrantsInfoContact(ByVal contact As String)

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT ContactNo FROM Registered WHERE ClientNo = '" & LoanForm.TextCLnoReq.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanCommand.Parameters.AddWithValue("ContactNo", contact)
            LoanAdapter.Fill(LoanTable)

            If LoanTable.Rows.Count > 0 Then
                LoanForm.TextLFCno.Text = LoanTable.Rows(0)("ContactNo").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getRegistrantsInfoAmount(ByVal adeposited As String)

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT Amount_Deposited FROM Registered WHERE ClientNo = '" & LoanForm.TextCLnoReq.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanCommand.Parameters.AddWithValue("Amount_Deposited", adeposited)
            LoanAdapter.Fill(LoanTable)

            If LoanTable.Rows.Count > 0 Then
                LoanForm.LGetDeposit.Text = LoanTable.Rows(0)("Amount_Deposited").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

   

    Public Sub AddToDeposit()

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "UPDATE Registered SET Amount_Deposited = '" & LoanForm.LGetDeposit.Text & "' WHERE ClientNo = '" & LoanForm.TextCLnoReq.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanAdapter.Fill(LoanTable)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub DeleteInfoRegistrants()

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "DELETE FROM Loan WHERE TransactionNo = '" & SearchDeleteLoan.TextSDL.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanAdapter.Fill(LoanTable)
            LoanSource.DataSource = LoanTable
            LoanList.DataGridView1.DataSource = LoanSource
            LoanAdapter.Update(LoanTable)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub SearchInfoRegistrants()

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT * FROM Loan WHERE TransactionNo = '" & SearchDeleteLoan.TextSDL.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanAdapter.Fill(LoanTable)
            LoanSource.DataSource = LoanTable
            LoanList.DataGridView1.DataSource = LoanSource
            LoanAdapter.Update(LoanTable)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '========================================          PAYMENT            ================================================
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub getLoanBalance(ByVal balance As String)

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT Total FROM Loan WHERE TransactionNo = '" & Payment.TextBox1.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanCommand.Parameters.AddWithValue("Total", balance)
            LoanAdapter.Fill(LoanTable)

            If LoanTable.Rows.Count > 0 Then
                Payment.Label4.Text = LoanTable.Rows(0)("Total").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getLoanMonthly(ByVal month As String)

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT Monthly_Payment FROM Loan WHERE TransactionNo = '" & Payment.TextBox1.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanCommand.Parameters.AddWithValue("Monthly_Payment", month)
            LoanAdapter.Fill(LoanTable)

            If LoanTable.Rows.Count > 0 Then
                Payment.TextBox2.Text = LoanTable.Rows(0)("Monthly_Payment").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Public Sub TotalBalance()

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "UPDATE Loan SET Total='" & Payment.Label4.Text - Payment.TextBox2.Text & "' WHERE TransactionNo = '" & Payment.TextBox1.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanAdapter.Fill(LoanTable)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '=========================================              PENALTY               ==============================================
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub getLoanType(ByVal type As String)

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT Type FROM Loan WHERE TransactionNo = '" & Payment.TextTransactionPenalty.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanCommand.Parameters.AddWithValue("Type", type)
            LoanAdapter.Fill(LoanTable)

            If LoanTable.Rows.Count > 0 Then
                Payment.LblPenaltyType.Text = LoanTable.Rows(0)("Type").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getLoanBalancePenalty(ByVal balance As String)

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT Total FROM Loan WHERE TransactionNo = '" & Payment.TextTransactionPenalty.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanCommand.Parameters.AddWithValue("Total", balance)
            LoanAdapter.Fill(LoanTable)

            If LoanTable.Rows.Count > 0 Then
                Payment.LblBalancePenalty.Text = LoanTable.Rows(0)("Total").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getLoanMonthlyPenalty(ByVal month As String)

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource

            LaonString = "SELECT Monthly_Payment FROM Loan WHERE TransactionNo = '" & Payment.TextTransactionPenalty.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanCommand.Parameters.AddWithValue("Monthly_Payment", month)
            LoanAdapter.Fill(LoanTable)

            If LoanTable.Rows.Count > 0 Then
                Payment.LblMonthPenalty.Text = LoanTable.Rows(0)("Monthly_Payment").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub TotalPenaltyBalance()

        Try
            Connection.Connection()

            Dim LaonString As String
            Dim LoanCommand As New SQLiteCommand
            Dim LoanAdapter As New SQLiteDataAdapter
            Dim LoanTable As New DataTable
            Dim LoanSource As New BindingSource
            Dim month As Double = Payment.LblMonthPenalty.Text
            Dim period As Double = Payment.TextPeriodPenalty.Text
            Dim deduction As Double = month * period

            LaonString = "UPDATE Loan SET Total='" & Payment.LblBalancePenalty.Text - deduction & "' WHERE TransactionNo = '" & Payment.TextTransactionPenalty.Text & "'"
            LoanCommand.CommandText = LaonString
            LoanCommand.Connection = connect
            LoanAdapter.SelectCommand = LoanCommand
            LoanAdapter.Fill(LoanTable)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Module
