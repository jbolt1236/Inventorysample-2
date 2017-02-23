Imports Microsoft.Reporting.WinForms
Public Class Receipt

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim param As New ReportParameter("ReportParamater1", Cashier.PrintDocument1.ToString())

        'ReportViewer1.LocalReport.SetParameters(param)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class