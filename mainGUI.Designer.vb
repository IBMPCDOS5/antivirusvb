<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainGUI))
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.scanTabControl = New System.Windows.Forms.TabControl()
        Me.mainTabPage = New System.Windows.Forms.TabPage()
        Me.dirLabel = New System.Windows.Forms.Label()
        Me.taskManagerf = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.taskmgrOpen = New System.Windows.Forms.Button()
        Me.scanOpen = New System.Windows.Forms.OpenFileDialog()
        Me.menuStrip.SuspendLayout()
        Me.scanTabControl.SuspendLayout()
        Me.mainTabPage.SuspendLayout()
        Me.taskManagerf.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(784, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'scanTabControl
        '
        Me.scanTabControl.Controls.Add(Me.mainTabPage)
        Me.scanTabControl.Controls.Add(Me.taskManagerf)
        Me.scanTabControl.Location = New System.Drawing.Point(0, 27)
        Me.scanTabControl.Multiline = True
        Me.scanTabControl.Name = "scanTabControl"
        Me.scanTabControl.SelectedIndex = 0
        Me.scanTabControl.Size = New System.Drawing.Size(784, 536)
        Me.scanTabControl.TabIndex = 1
        '
        'mainTabPage
        '
        Me.mainTabPage.Controls.Add(Me.dirLabel)
        Me.mainTabPage.Location = New System.Drawing.Point(4, 22)
        Me.mainTabPage.Name = "mainTabPage"
        Me.mainTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.mainTabPage.Size = New System.Drawing.Size(776, 510)
        Me.mainTabPage.TabIndex = 0
        Me.mainTabPage.Text = "Scan Files"
        Me.mainTabPage.UseVisualStyleBackColor = True
        '
        'dirLabel
        '
        Me.dirLabel.AutoSize = True
        Me.dirLabel.Location = New System.Drawing.Point(6, 146)
        Me.dirLabel.Name = "dirLabel"
        Me.dirLabel.Size = New System.Drawing.Size(442, 13)
        Me.dirLabel.TabIndex = 0
        Me.dirLabel.Text = "Welcome to the AntivirusVB Virus Scanner. Please choose a directory that you wish" &
    " to scan:"
        '
        'taskManagerf
        '
        Me.taskManagerf.Controls.Add(Me.Label1)
        Me.taskManagerf.Controls.Add(Me.taskmgrOpen)
        Me.taskManagerf.Location = New System.Drawing.Point(4, 22)
        Me.taskManagerf.Name = "taskManagerf"
        Me.taskManagerf.Padding = New System.Windows.Forms.Padding(3)
        Me.taskManagerf.Size = New System.Drawing.Size(776, 510)
        Me.taskManagerf.TabIndex = 1
        Me.taskManagerf.Text = "Task Manager"
        Me.taskManagerf.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'taskmgrOpen
        '
        Me.taskmgrOpen.Location = New System.Drawing.Point(325, 181)
        Me.taskmgrOpen.Name = "taskmgrOpen"
        Me.taskmgrOpen.Size = New System.Drawing.Size(128, 23)
        Me.taskmgrOpen.TabIndex = 0
        Me.taskmgrOpen.Text = "Open Task Manager"
        Me.taskmgrOpen.UseVisualStyleBackColor = True
        '
        'scanOpen
        '
        Me.scanOpen.FileName = "scanOpen"
        '
        'mainGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.scanTabControl)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.Name = "mainGUI"
        Me.Text = "AntivirusVB"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.scanTabControl.ResumeLayout(False)
        Me.mainTabPage.ResumeLayout(False)
        Me.mainTabPage.PerformLayout()
        Me.taskManagerf.ResumeLayout(False)
        Me.taskManagerf.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents menuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents scanTabControl As TabControl
    Friend WithEvents mainTabPage As TabPage
    Friend WithEvents taskManagerf As TabPage
    Friend WithEvents taskmgrOpen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dirLabel As Label
    Friend WithEvents scanOpen As OpenFileDialog
End Class
