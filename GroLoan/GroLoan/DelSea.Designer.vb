<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DelSea
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
        Me.BtnSearchReg = New System.Windows.Forms.Button()
        Me.BtnDeleteReg = New System.Windows.Forms.Button()
        Me.TextDelSea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSearchReg)
        Me.GroupBox1.Controls.Add(Me.BtnDeleteReg)
        Me.GroupBox1.Controls.Add(Me.TextDelSea)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 142)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delete/Search Registered Data"
        '
        'BtnSearchReg
        '
        Me.BtnSearchReg.Image = Global.GroLoan.My.Resources.Resources.search2
        Me.BtnSearchReg.Location = New System.Drawing.Point(185, 82)
        Me.BtnSearchReg.Name = "BtnSearchReg"
        Me.BtnSearchReg.Size = New System.Drawing.Size(151, 41)
        Me.BtnSearchReg.TabIndex = 3
        Me.BtnSearchReg.Text = "Search"
        Me.BtnSearchReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearchReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSearchReg.UseVisualStyleBackColor = True
        '
        'BtnDeleteReg
        '
        Me.BtnDeleteReg.Image = Global.GroLoan.My.Resources.Resources.delete
        Me.BtnDeleteReg.Location = New System.Drawing.Point(28, 82)
        Me.BtnDeleteReg.Name = "BtnDeleteReg"
        Me.BtnDeleteReg.Size = New System.Drawing.Size(151, 41)
        Me.BtnDeleteReg.TabIndex = 2
        Me.BtnDeleteReg.Text = "Delete"
        Me.BtnDeleteReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDeleteReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDeleteReg.UseVisualStyleBackColor = True
        '
        'TextDelSea
        '
        Me.TextDelSea.Location = New System.Drawing.Point(123, 46)
        Me.TextDelSea.Name = "TextDelSea"
        Me.TextDelSea.Size = New System.Drawing.Size(105, 26)
        Me.TextDelSea.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client #:"
        '
        'DelSea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(389, 179)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DelSea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DelSea"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSearchReg As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteReg As System.Windows.Forms.Button
    Friend WithEvents TextDelSea As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
