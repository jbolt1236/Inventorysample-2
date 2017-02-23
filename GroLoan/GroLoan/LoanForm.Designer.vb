<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LNameGet = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LGetDeposit = New System.Windows.Forms.Label()
        Me.BtnRegLoanForm = New System.Windows.Forms.Button()
        Me.LLFTLAmount = New System.Windows.Forms.Label()
        Me.LLFDeduction = New System.Windows.Forms.Label()
        Me.LLFServiceC = New System.Windows.Forms.Label()
        Me.LLFShareC = New System.Windows.Forms.Label()
        Me.TextMonthlyP = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextLFMPeriod = New System.Windows.Forms.TextBox()
        Me.TextLFLAmount = New System.Windows.Forms.TextBox()
        Me.ComboLFLoantype = New System.Windows.Forms.ComboBox()
        Me.TextLFCno = New System.Windows.Forms.TextBox()
        Me.TextLFAddrss = New System.Windows.Forms.TextBox()
        Me.TextLFName = New System.Windows.Forms.TextBox()
        Me.TextCLnoReq = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.BtnRegLoanForm)
        Me.GroupBox1.Controls.Add(Me.LLFTLAmount)
        Me.GroupBox1.Controls.Add(Me.LLFDeduction)
        Me.GroupBox1.Controls.Add(Me.LLFServiceC)
        Me.GroupBox1.Controls.Add(Me.LLFShareC)
        Me.GroupBox1.Controls.Add(Me.TextMonthlyP)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextLFMPeriod)
        Me.GroupBox1.Controls.Add(Me.TextLFLAmount)
        Me.GroupBox1.Controls.Add(Me.ComboLFLoantype)
        Me.GroupBox1.Controls.Add(Me.TextLFCno)
        Me.GroupBox1.Controls.Add(Me.TextLFAddrss)
        Me.GroupBox1.Controls.Add(Me.TextLFName)
        Me.GroupBox1.Controls.Add(Me.TextCLnoReq)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 307)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Requirements"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LNameGet)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label15)
        Me.FlowLayoutPanel1.Controls.Add(Me.LGetDeposit)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 22)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(629, 34)
        Me.FlowLayoutPanel1.TabIndex = 32
        '
        'LNameGet
        '
        Me.LNameGet.AutoSize = True
        Me.LNameGet.Location = New System.Drawing.Point(3, 0)
        Me.LNameGet.Name = "LNameGet"
        Me.LNameGet.Size = New System.Drawing.Size(117, 19)
        Me.LNameGet.TabIndex = 30
        Me.LNameGet.Text = "Name of client"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(126, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 19)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Deposit:"
        '
        'LGetDeposit
        '
        Me.LGetDeposit.AutoSize = True
        Me.LGetDeposit.Location = New System.Drawing.Point(206, 0)
        Me.LGetDeposit.Name = "LGetDeposit"
        Me.LGetDeposit.Size = New System.Drawing.Size(31, 19)
        Me.LGetDeposit.TabIndex = 32
        Me.LGetDeposit.Text = "0.0"
        '
        'BtnRegLoanForm
        '
        Me.BtnRegLoanForm.Image = Global.GroLoan.My.Resources.Resources.registration
        Me.BtnRegLoanForm.Location = New System.Drawing.Point(10, 261)
        Me.BtnRegLoanForm.Name = "BtnRegLoanForm"
        Me.BtnRegLoanForm.Size = New System.Drawing.Size(185, 39)
        Me.BtnRegLoanForm.TabIndex = 29
        Me.BtnRegLoanForm.Text = "Register"
        Me.BtnRegLoanForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegLoanForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRegLoanForm.UseVisualStyleBackColor = True
        '
        'LLFTLAmount
        '
        Me.LLFTLAmount.AutoSize = True
        Me.LLFTLAmount.Location = New System.Drawing.Point(464, 224)
        Me.LLFTLAmount.Name = "LLFTLAmount"
        Me.LLFTLAmount.Size = New System.Drawing.Size(31, 19)
        Me.LLFTLAmount.TabIndex = 28
        Me.LLFTLAmount.Text = "0.0"
        '
        'LLFDeduction
        '
        Me.LLFDeduction.AutoSize = True
        Me.LLFDeduction.Location = New System.Drawing.Point(464, 202)
        Me.LLFDeduction.Name = "LLFDeduction"
        Me.LLFDeduction.Size = New System.Drawing.Size(31, 19)
        Me.LLFDeduction.TabIndex = 27
        Me.LLFDeduction.Text = "0.0"
        '
        'LLFServiceC
        '
        Me.LLFServiceC.AutoSize = True
        Me.LLFServiceC.Location = New System.Drawing.Point(464, 180)
        Me.LLFServiceC.Name = "LLFServiceC"
        Me.LLFServiceC.Size = New System.Drawing.Size(31, 19)
        Me.LLFServiceC.TabIndex = 26
        Me.LLFServiceC.Text = "0.0"
        '
        'LLFShareC
        '
        Me.LLFShareC.AutoSize = True
        Me.LLFShareC.Location = New System.Drawing.Point(464, 158)
        Me.LLFShareC.Name = "LLFShareC"
        Me.LLFShareC.Size = New System.Drawing.Size(31, 19)
        Me.LLFShareC.TabIndex = 25
        Me.LLFShareC.Text = "0.0"
        '
        'TextMonthlyP
        '
        Me.TextMonthlyP.Location = New System.Drawing.Point(468, 129)
        Me.TextMonthlyP.Name = "TextMonthlyP"
        Me.TextMonthlyP.Size = New System.Drawing.Size(152, 26)
        Me.TextMonthlyP.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(468, 98)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(152, 26)
        Me.DateTimePicker1.TabIndex = 23
        Me.DateTimePicker1.Value = New Date(2016, 7, 5, 0, 0, 0, 0)
        '
        'TextLFMPeriod
        '
        Me.TextLFMPeriod.Location = New System.Drawing.Point(468, 69)
        Me.TextLFMPeriod.Name = "TextLFMPeriod"
        Me.TextLFMPeriod.Size = New System.Drawing.Size(152, 26)
        Me.TextLFMPeriod.TabIndex = 22
        '
        'TextLFLAmount
        '
        Me.TextLFLAmount.Location = New System.Drawing.Point(130, 229)
        Me.TextLFLAmount.Name = "TextLFLAmount"
        Me.TextLFLAmount.Size = New System.Drawing.Size(152, 26)
        Me.TextLFLAmount.TabIndex = 21
        '
        'ComboLFLoantype
        '
        Me.ComboLFLoantype.FormattingEnabled = True
        Me.ComboLFLoantype.Items.AddRange(New Object() {"Regular Loan", "Character Loan", "Quick Cash Loan", "Special Loan"})
        Me.ComboLFLoantype.Location = New System.Drawing.Point(130, 196)
        Me.ComboLFLoantype.Name = "ComboLFLoantype"
        Me.ComboLFLoantype.Size = New System.Drawing.Size(152, 27)
        Me.ComboLFLoantype.TabIndex = 20
        '
        'TextLFCno
        '
        Me.TextLFCno.Location = New System.Drawing.Point(130, 165)
        Me.TextLFCno.Name = "TextLFCno"
        Me.TextLFCno.Size = New System.Drawing.Size(152, 26)
        Me.TextLFCno.TabIndex = 19
        '
        'TextLFAddrss
        '
        Me.TextLFAddrss.Location = New System.Drawing.Point(130, 133)
        Me.TextLFAddrss.Name = "TextLFAddrss"
        Me.TextLFAddrss.Size = New System.Drawing.Size(152, 26)
        Me.TextLFAddrss.TabIndex = 18
        '
        'TextLFName
        '
        Me.TextLFName.Location = New System.Drawing.Point(130, 101)
        Me.TextLFName.Name = "TextLFName"
        Me.TextLFName.Size = New System.Drawing.Size(152, 26)
        Me.TextLFName.TabIndex = 17
        '
        'TextCLnoReq
        '
        Me.TextCLnoReq.Location = New System.Drawing.Point(130, 69)
        Me.TextCLnoReq.Name = "TextCLnoReq"
        Me.TextCLnoReq.Size = New System.Drawing.Size(152, 26)
        Me.TextCLnoReq.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(288, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 19)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Total Loan Amount:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(288, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 19)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Deduction:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(288, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 19)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Service Capital:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(288, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 19)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Share Capital:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(288, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 19)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Monthly Payment:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(288, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(288, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Months of payment:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Loan Amount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Loan type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contact #:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Client #:"
        '
        'LoanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(657, 325)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LoanForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoanForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextLFCno As System.Windows.Forms.TextBox
    Friend WithEvents TextLFAddrss As System.Windows.Forms.TextBox
    Friend WithEvents TextLFName As System.Windows.Forms.TextBox
    Friend WithEvents TextCLnoReq As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LLFServiceC As System.Windows.Forms.Label
    Friend WithEvents LLFShareC As System.Windows.Forms.Label
    Friend WithEvents TextMonthlyP As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextLFMPeriod As System.Windows.Forms.TextBox
    Friend WithEvents TextLFLAmount As System.Windows.Forms.TextBox
    Friend WithEvents ComboLFLoantype As System.Windows.Forms.ComboBox
    Friend WithEvents LLFDeduction As System.Windows.Forms.Label
    Friend WithEvents LLFTLAmount As System.Windows.Forms.Label
    Friend WithEvents BtnRegLoanForm As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LNameGet As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LGetDeposit As System.Windows.Forms.Label
End Class
