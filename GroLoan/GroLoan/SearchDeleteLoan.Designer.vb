<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchDeleteLoan
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
        Me.BtnSearchLoan = New System.Windows.Forms.Button()
        Me.BtnDeleteLoan = New System.Windows.Forms.Button()
        Me.TextSDL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSearchLoan)
        Me.GroupBox1.Controls.Add(Me.BtnDeleteLoan)
        Me.GroupBox1.Controls.Add(Me.TextSDL)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 142)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delete/Search Registered Data"
        '
        'BtnSearchLoan
        '
        Me.BtnSearchLoan.Image = Global.GroLoan.My.Resources.Resources.search2
        Me.BtnSearchLoan.Location = New System.Drawing.Point(181, 68)
        Me.BtnSearchLoan.Name = "BtnSearchLoan"
        Me.BtnSearchLoan.Size = New System.Drawing.Size(151, 41)
        Me.BtnSearchLoan.TabIndex = 3
        Me.BtnSearchLoan.Text = "Search"
        Me.BtnSearchLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearchLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSearchLoan.UseVisualStyleBackColor = True
        '
        'BtnDeleteLoan
        '
        Me.BtnDeleteLoan.Image = Global.GroLoan.My.Resources.Resources.delete
        Me.BtnDeleteLoan.Location = New System.Drawing.Point(24, 68)
        Me.BtnDeleteLoan.Name = "BtnDeleteLoan"
        Me.BtnDeleteLoan.Size = New System.Drawing.Size(151, 41)
        Me.BtnDeleteLoan.TabIndex = 2
        Me.BtnDeleteLoan.Text = "Delete"
        Me.BtnDeleteLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDeleteLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDeleteLoan.UseVisualStyleBackColor = True
        '
        'TextSDL
        '
        Me.TextSDL.Location = New System.Drawing.Point(140, 36)
        Me.TextSDL.Name = "TextSDL"
        Me.TextSDL.Size = New System.Drawing.Size(192, 26)
        Me.TextSDL.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction#:"
        '
        'SearchDeleteLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(381, 174)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SearchDeleteLoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchDeleteLoan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSearchLoan As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteLoan As System.Windows.Forms.Button
    Friend WithEvents TextSDL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
