<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.AdmnInvtry = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AdmnInvntry1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Admntime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AdmnInvdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnUpIn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnSrchIn = New System.Windows.Forms.Button()
        Me.BtnDelIn = New System.Windows.Forms.Button()
        Me.BtnAddIn = New System.Windows.Forms.Button()
        Me.InventoryListBox = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.InventoryListBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Admin Inventory"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SalesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.GroLoan.My.Resources.Resources.File
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.GroLoan.My.Resources.Resources.close
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdmnInvtry, Me.AdmnInvntry1, Me.ToolStripStatusLabel1, Me.Admntime, Me.ToolStripStatusLabel2, Me.AdmnInvdate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 538)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'AdmnInvtry
        '
        Me.AdmnInvtry.BackColor = System.Drawing.Color.Transparent
        Me.AdmnInvtry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdmnInvtry.Font = New System.Drawing.Font("Segoe WP Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmnInvtry.Image = Global.GroLoan.My.Resources.Resources.admin
        Me.AdmnInvtry.Name = "AdmnInvtry"
        Me.AdmnInvtry.Size = New System.Drawing.Size(49, 19)
        Me.AdmnInvtry.Text = "User:"
        '
        'AdmnInvntry1
        '
        Me.AdmnInvntry1.BackColor = System.Drawing.Color.Transparent
        Me.AdmnInvntry1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.AdmnInvntry1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.AdmnInvntry1.Font = New System.Drawing.Font("Segoe WP Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmnInvntry1.Name = "AdmnInvntry1"
        Me.AdmnInvntry1.Size = New System.Drawing.Size(103, 19)
        Me.AdmnInvntry1.Text = "Admin-Inventory"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe WP Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Image = Global.GroLoan.My.Resources.Resources.time
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(50, 3, 0, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(53, 19)
        Me.ToolStripStatusLabel1.Text = "Time:"
        '
        'Admntime
        '
        Me.Admntime.BackColor = System.Drawing.Color.Transparent
        Me.Admntime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Admntime.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Admntime.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.Admntime.Font = New System.Drawing.Font("Segoe WP Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admntime.Name = "Admntime"
        Me.Admntime.Size = New System.Drawing.Size(35, 19)
        Me.Admntime.Text = "time"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe WP Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Image = Global.GroLoan.My.Resources.Resources.calendar
        Me.ToolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(50, 3, 0, 2)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(51, 19)
        Me.ToolStripStatusLabel2.Text = "Date:"
        '
        'AdmnInvdate
        '
        Me.AdmnInvdate.BackColor = System.Drawing.Color.Transparent
        Me.AdmnInvdate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.AdmnInvdate.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.AdmnInvdate.Font = New System.Drawing.Font("Segoe WP Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmnInvdate.Name = "AdmnInvdate"
        Me.AdmnInvdate.Size = New System.Drawing.Size(34, 19)
        Me.AdmnInvdate.Text = "date"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.InventoryListBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 100)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(784, 438)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnUpIn)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.BtnSrchIn)
        Me.Panel2.Controls.Add(Me.BtnDelIn)
        Me.Panel2.Controls.Add(Me.BtnAddIn)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 435)
        Me.Panel2.TabIndex = 0
        '
        'BtnUpIn
        '
        Me.BtnUpIn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpIn.Location = New System.Drawing.Point(3, 354)
        Me.BtnUpIn.Name = "BtnUpIn"
        Me.BtnUpIn.Size = New System.Drawing.Size(194, 69)
        Me.BtnUpIn.TabIndex = 5
        Me.BtnUpIn.Text = "Reset Display"
        Me.BtnUpIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnUpIn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.GroLoan.My.Resources.Resources.regcard
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 3
        '
        'BtnSrchIn
        '
        Me.BtnSrchIn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSrchIn.Image = Global.GroLoan.My.Resources.Resources.search2
        Me.BtnSrchIn.Location = New System.Drawing.Point(3, 279)
        Me.BtnSrchIn.Name = "BtnSrchIn"
        Me.BtnSrchIn.Size = New System.Drawing.Size(194, 69)
        Me.BtnSrchIn.TabIndex = 4
        Me.BtnSrchIn.Text = "Search"
        Me.BtnSrchIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSrchIn.UseVisualStyleBackColor = True
        '
        'BtnDelIn
        '
        Me.BtnDelIn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelIn.Image = Global.GroLoan.My.Resources.Resources.delete
        Me.BtnDelIn.Location = New System.Drawing.Point(3, 204)
        Me.BtnDelIn.Name = "BtnDelIn"
        Me.BtnDelIn.Size = New System.Drawing.Size(194, 69)
        Me.BtnDelIn.TabIndex = 3
        Me.BtnDelIn.Text = "Delete"
        Me.BtnDelIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnDelIn.UseVisualStyleBackColor = True
        '
        'BtnAddIn
        '
        Me.BtnAddIn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddIn.Image = Global.GroLoan.My.Resources.Resources.add
        Me.BtnAddIn.Location = New System.Drawing.Point(3, 129)
        Me.BtnAddIn.Name = "BtnAddIn"
        Me.BtnAddIn.Size = New System.Drawing.Size(194, 69)
        Me.BtnAddIn.TabIndex = 1
        Me.BtnAddIn.Text = "Add"
        Me.BtnAddIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnAddIn.UseVisualStyleBackColor = True
        '
        'InventoryListBox
        '
        Me.InventoryListBox.Controls.Add(Me.DataGridView1)
        Me.InventoryListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryListBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.InventoryListBox.Location = New System.Drawing.Point(209, 3)
        Me.InventoryListBox.Name = "InventoryListBox"
        Me.InventoryListBox.Size = New System.Drawing.Size(563, 432)
        Me.InventoryListBox.TabIndex = 1
        Me.InventoryListBox.TabStop = False
        Me.InventoryListBox.Text = "Inventory List"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(551, 395)
        Me.DataGridView1.TabIndex = 0
        '
        'Timer1
        '
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.InventoryListBox.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents AdmnInvtry As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AdmnInvntry1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Admntime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AdmnInvdate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnSrchIn As System.Windows.Forms.Button
    Friend WithEvents BtnDelIn As System.Windows.Forms.Button
    Friend WithEvents BtnAddIn As System.Windows.Forms.Button
    Friend WithEvents InventoryListBox As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnUpIn As System.Windows.Forms.Button
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
