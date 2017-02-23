<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblBalancePenalty = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextValuePenalty = New System.Windows.Forms.TextBox()
        Me.TextTransactionPenalty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextPeriodPenalty = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblMonthPenalty = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblInterestPenalty = New System.Windows.Forms.Label()
        Me.LblPenaltyType = New System.Windows.Forms.Label()
        Me.BtnUpdatePenalty = New System.Windows.Forms.Button()
        Me.BtnPayment = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPayment)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Balance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Value:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(283, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(89, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction#:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox2.Controls.Add(Me.TextPeriodPenalty)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.BtnUpdatePenalty)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextValuePenalty)
        Me.GroupBox2.Controls.Add(Me.TextTransactionPenalty)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 224)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Penalty"
        '
        'LblBalancePenalty
        '
        Me.LblBalancePenalty.AutoSize = True
        Me.LblBalancePenalty.Location = New System.Drawing.Point(86, 0)
        Me.LblBalancePenalty.Name = "LblBalancePenalty"
        Me.LblBalancePenalty.Size = New System.Drawing.Size(31, 19)
        Me.LblBalancePenalty.TabIndex = 5
        Me.LblBalancePenalty.Text = "0.0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Balance:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Value:"
        '
        'TextValuePenalty
        '
        Me.TextValuePenalty.Location = New System.Drawing.Point(283, 108)
        Me.TextValuePenalty.Name = "TextValuePenalty"
        Me.TextValuePenalty.Size = New System.Drawing.Size(100, 26)
        Me.TextValuePenalty.TabIndex = 2
        '
        'TextTransactionPenalty
        '
        Me.TextTransactionPenalty.Location = New System.Drawing.Point(140, 108)
        Me.TextTransactionPenalty.Name = "TextTransactionPenalty"
        Me.TextTransactionPenalty.Size = New System.Drawing.Size(62, 26)
        Me.TextTransactionPenalty.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Transaction#:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 19)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Penalty period:"
        '
        'TextPeriodPenalty
        '
        Me.TextPeriodPenalty.Location = New System.Drawing.Point(140, 143)
        Me.TextPeriodPenalty.Name = "TextPeriodPenalty"
        Me.TextPeriodPenalty.Size = New System.Drawing.Size(62, 26)
        Me.TextPeriodPenalty.TabIndex = 8
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblBalancePenalty)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblMonthPenalty)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblInterestPenalty)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblPenaltyType)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(10, 25)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(373, 80)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(123, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 19)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Monthly:"
        '
        'LblMonthPenalty
        '
        Me.LblMonthPenalty.AutoSize = True
        Me.LblMonthPenalty.Location = New System.Drawing.Point(205, 0)
        Me.LblMonthPenalty.Name = "LblMonthPenalty"
        Me.LblMonthPenalty.Size = New System.Drawing.Size(31, 19)
        Me.LblMonthPenalty.TabIndex = 11
        Me.LblMonthPenalty.Text = "0.0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(242, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 19)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Interest:"
        '
        'LblInterestPenalty
        '
        Me.LblInterestPenalty.AutoSize = True
        Me.LblInterestPenalty.Location = New System.Drawing.Point(320, 0)
        Me.LblInterestPenalty.Name = "LblInterestPenalty"
        Me.LblInterestPenalty.Size = New System.Drawing.Size(34, 19)
        Me.LblInterestPenalty.TabIndex = 13
        Me.LblInterestPenalty.Text = "0%"
        '
        'LblPenaltyType
        '
        Me.LblPenaltyType.AutoSize = True
        Me.LblPenaltyType.Location = New System.Drawing.Point(3, 19)
        Me.LblPenaltyType.Name = "LblPenaltyType"
        Me.LblPenaltyType.Size = New System.Drawing.Size(114, 19)
        Me.LblPenaltyType.TabIndex = 14
        Me.LblPenaltyType.Text = "Type of Loan:"
        '
        'BtnUpdatePenalty
        '
        Me.BtnUpdatePenalty.Image = Global.GroLoan.My.Resources.Resources.update
        Me.BtnUpdatePenalty.Location = New System.Drawing.Point(9, 175)
        Me.BtnUpdatePenalty.Name = "BtnUpdatePenalty"
        Me.BtnUpdatePenalty.Size = New System.Drawing.Size(165, 43)
        Me.BtnUpdatePenalty.TabIndex = 6
        Me.BtnUpdatePenalty.Text = "Update"
        Me.BtnUpdatePenalty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdatePenalty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnUpdatePenalty.UseVisualStyleBackColor = True
        '
        'BtnPayment
        '
        Me.BtnPayment.Image = Global.GroLoan.My.Resources.Resources.update
        Me.BtnPayment.Location = New System.Drawing.Point(10, 96)
        Me.BtnPayment.Name = "BtnPayment"
        Me.BtnPayment.Size = New System.Drawing.Size(165, 43)
        Me.BtnPayment.TabIndex = 6
        Me.BtnPayment.Text = "Update"
        Me.BtnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPayment.UseVisualStyleBackColor = True
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(417, 402)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnPayment As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnUpdatePenalty As System.Windows.Forms.Button
    Friend WithEvents LblBalancePenalty As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextValuePenalty As System.Windows.Forms.TextBox
    Friend WithEvents TextTransactionPenalty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblMonthPenalty As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblInterestPenalty As System.Windows.Forms.Label
    Friend WithEvents LblPenaltyType As System.Windows.Forms.Label
    Friend WithEvents TextPeriodPenalty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
