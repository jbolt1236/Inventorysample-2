<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Cashier
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
        Me.BtnAdmin = New System.Windows.Forms.Button()
        Me.BtnCashier = New System.Windows.Forms.Button()
        Me.BtnLoan = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAdmin
        '
        Me.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdmin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmin.Location = New System.Drawing.Point(3, 12)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Size = New System.Drawing.Size(224, 75)
        Me.BtnAdmin.TabIndex = 0
        Me.BtnAdmin.Text = "Admin"
        Me.BtnAdmin.UseVisualStyleBackColor = True
        '
        'BtnCashier
        '
        Me.BtnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCashier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCashier.Location = New System.Drawing.Point(233, 12)
        Me.BtnCashier.Name = "BtnCashier"
        Me.BtnCashier.Size = New System.Drawing.Size(224, 75)
        Me.BtnCashier.TabIndex = 1
        Me.BtnCashier.Text = "Cashier"
        Me.BtnCashier.UseVisualStyleBackColor = True
        '
        'BtnLoan
        '
        Me.BtnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoan.Location = New System.Drawing.Point(3, 93)
        Me.BtnLoan.Name = "BtnLoan"
        Me.BtnLoan.Size = New System.Drawing.Size(224, 75)
        Me.BtnLoan.TabIndex = 2
        Me.BtnLoan.Text = "Loan"
        Me.BtnLoan.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(233, 93)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(224, 75)
        Me.BtnLogout.TabIndex = 3
        Me.BtnLogout.Text = "Log-out"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'Admin_Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(463, 179)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnLoan)
        Me.Controls.Add(Me.BtnCashier)
        Me.Controls.Add(Me.BtnAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Admin_Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Cashier"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAdmin As System.Windows.Forms.Button
    Friend WithEvents BtnCashier As System.Windows.Forms.Button
    Friend WithEvents BtnLoan As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
End Class
