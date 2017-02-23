Public Class LoanForm

 
    Private Sub BtnRegLoanForm_Click(sender As Object, e As EventArgs) Handles BtnRegLoanForm.Click
        InsertLoanRegistration()
        AddToDeposit()
    End Sub

  
    Private Sub TextCLnoReq_TextChanged(sender As Object, e As EventArgs) Handles TextCLnoReq.TextChanged
        If TextCLnoReq.Text = "" Then

            TextLFAddrss.Text = ""
            TextLFName.Text = ""
            TextLFCno.Text = ""
            LGetDeposit.Text = 0.0
            LNameGet.Text = "Name of client"
            LGetDeposit.BackColor = Color.Transparent
            LNameGet.BackColor = Color.Transparent
        Else
            getRegistrantsInfo(Me.LNameGet.Text)
            getRegistrantsInfo2(Me.TextLFName.Text)
            getRegistrantsInfoAddress(Me.TextLFAddrss.Text)
            getRegistrantsInfoContact(Me.TextLFCno.Text)
            getRegistrantsInfoAmount(Me.LGetDeposit.Text)

            LNameGet.BackColor = Color.LightGreen
            LGetDeposit.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub TextLFLAmount_TextChanged(sender As Object, e As EventArgs) Handles TextLFLAmount.TextChanged
        Try
            If TextLFLAmount.Text = "" Then
                LLFDeduction.Text = 0.0
                LLFServiceC.Text = 0.0
                LLFShareC.Text = 0.0
                LLFTLAmount.Text = 0.0
            Else
                Dim share As Double = TextLFLAmount.Text * 0.05
                LLFShareC.Text = share

                Dim serv As Double = TextLFLAmount.Text * 0.02
                LLFServiceC.Text = serv

                Dim deduc As Double = share + serv
                LLFDeduction.Text = deduc

                Dim total As Double = TextLFLAmount.Text - deduc
                LLFTLAmount.Text = total
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextLFMPeriod_TextChanged(sender As Object, e As EventArgs) Handles TextLFMPeriod.TextChanged
        Try

            Dim x As Double = LLFTLAmount.Text
            Dim n As Integer = TextLFMPeriod.Text
            Dim answer As Double
           
            If ComboLFLoantype.SelectedIndex = 0 Then
               
                    answer = x / n
                TextMonthlyP.Text = answer
            ElseIf ComboLFLoantype.SelectedIndex = 1 Then
                answer = x / n
                TextMonthlyP.Text = answer
            ElseIf ComboLFLoantype.SelectedIndex = 2 Then
                answer = x / n
                TextMonthlyP.Text = answer
            ElseIf ComboLFLoantype.SelectedIndex = 3 Then
                answer = x / n
                TextMonthlyP.Text = answer
            End If

            Dim deduc As Integer = LLFDeduction.Text
            Dim bal As Integer = LGetDeposit.Text + deduc
            LGetDeposit.Text = bal


        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class