Public Class Payment

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try

            getLoanBalance(Me.Label4.Text)
            getLoanMonthly(Me.TextBox1.Text)
            If TextBox1.Text = "" Then
                Label4.BackColor = Color.Transparent
                Label4.Text = "0.0"
            Else
                Label4.BackColor = Color.LightGreen
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click
        TotalBalance()
    End Sub

    Private Sub TextTransactionPenalty_TextChanged(sender As Object, e As EventArgs) Handles TextTransactionPenalty.TextChanged
        Try

            getLoanBalancePenalty(Me.LblBalancePenalty.Text)
            getLoanMonthlyPenalty(Me.LblMonthPenalty.Text)
            getLoanType(Me.LblPenaltyType.Text)
            If TextTransactionPenalty.Text = "" Then
                LblBalancePenalty.BackColor = Color.Transparent
                LblInterestPenalty.BackColor = Color.Transparent
                LblMonthPenalty.BackColor = Color.Transparent
                LblPenaltyType.BackColor = Color.Transparent

                LblPenaltyType.Text = "Type of Loan:"
                LblBalancePenalty.Text = "0.0"
                LblInterestPenalty.Text = "0%"
                LblMonthPenalty.Text = "0.0"
            Else
                LblBalancePenalty.BackColor = Color.LightGreen
                LblInterestPenalty.BackColor = Color.LightGreen
                LblMonthPenalty.BackColor = Color.LightGreen
                LblPenaltyType.BackColor = Color.LightGreen
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblPenaltyType_TextChanged(sender As Object, e As EventArgs) Handles LblPenaltyType.TextChanged
        If LblPenaltyType.Text = "Regular Loan" Then
            LblInterestPenalty.Text = "1%"
        Else
            LblInterestPenalty.Text = "1.5%"
        End If
    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub TextPeriodPenalty_TextChanged(sender As Object, e As EventArgs) Handles TextPeriodPenalty.TextChanged
        Try
            If TextPeriodPenalty.Text = "" Then
                TextValuePenalty.Text = ""
           Else

                If LblInterestPenalty.Text = "1%" Then
                    Dim inter As Double = 0.01
                    Dim bal As Double = LblMonthPenalty.Text
                    Dim answer As Double
                    Dim penalty As Integer = TextPeriodPenalty.Text
                    Dim final As Double

                    answer = bal * inter
                    final = penalty * answer + bal
                    TextValuePenalty.Text = final

                Else
                    Dim interx As Double = 0.015
                    Dim balx As Double = LblMonthPenalty.Text
                    Dim answerx As Double
                    Dim penaltyx As Integer = TextPeriodPenalty.Text
                    Dim finalx As Double
                    answerx = balx * interx
                    finalx = penaltyx * answerx + balx
                    TextValuePenalty.Text = finalx

                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnUpdatePenalty_Click(sender As Object, e As EventArgs) Handles BtnUpdatePenalty.Click
        TotalPenaltyBalance()
    End Sub
End Class