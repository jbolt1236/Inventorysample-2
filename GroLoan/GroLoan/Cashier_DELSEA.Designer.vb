<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashier_DELSEA
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
        Me.BtnSearchCash = New System.Windows.Forms.Button()
        Me.BtnDeleteCash = New System.Windows.Forms.Button()
        Me.TextDelSeaCash = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSearchCash)
        Me.GroupBox1.Controls.Add(Me.BtnDeleteCash)
        Me.GroupBox1.Controls.Add(Me.TextDelSeaCash)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 142)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delete/Search Item"
        '
        'BtnSearchCash
        '
        Me.BtnSearchCash.Image = Global.GroLoan.My.Resources.Resources.search2
        Me.BtnSearchCash.Location = New System.Drawing.Point(185, 82)
        Me.BtnSearchCash.Name = "BtnSearchCash"
        Me.BtnSearchCash.Size = New System.Drawing.Size(151, 41)
        Me.BtnSearchCash.TabIndex = 3
        Me.BtnSearchCash.Text = "Search"
        Me.BtnSearchCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearchCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSearchCash.UseVisualStyleBackColor = True
        '
        'BtnDeleteCash
        '
        Me.BtnDeleteCash.Image = Global.GroLoan.My.Resources.Resources.delete
        Me.BtnDeleteCash.Location = New System.Drawing.Point(28, 82)
        Me.BtnDeleteCash.Name = "BtnDeleteCash"
        Me.BtnDeleteCash.Size = New System.Drawing.Size(151, 41)
        Me.BtnDeleteCash.TabIndex = 2
        Me.BtnDeleteCash.Text = "Delete"
        Me.BtnDeleteCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDeleteCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDeleteCash.UseVisualStyleBackColor = True
        '
        'TextDelSeaCash
        '
        Me.TextDelSeaCash.Location = New System.Drawing.Point(123, 50)
        Me.TextDelSeaCash.Name = "TextDelSeaCash"
        Me.TextDelSeaCash.Size = New System.Drawing.Size(213, 26)
        Me.TextDelSeaCash.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item name:"
        '
        'Cashier_DELSEA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(385, 182)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Cashier_DELSEA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier_DELSEA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSearchCash As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteCash As System.Windows.Forms.Button
    Friend WithEvents TextDelSeaCash As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
