<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class taskmgr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(taskmgr))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.endButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.processAmountlbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.processViewer = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.taskTimer = New System.Windows.Forms.Timer(Me.components)
        Me.refreshBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.endButton, Me.refreshBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(428, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'endButton
        '
        Me.endButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.endButton.Image = CType(resources.GetObject("endButton.Image"), System.Drawing.Image)
        Me.endButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.endButton.Name = "endButton"
        Me.endButton.Size = New System.Drawing.Size(74, 22)
        Me.endButton.Text = "End Process"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.processAmountlbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 379)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(428, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'processAmountlbl
        '
        Me.processAmountlbl.Name = "processAmountlbl"
        Me.processAmountlbl.Size = New System.Drawing.Size(131, 17)
        Me.processAmountlbl.Text = "Number of Processes: 0"
        '
        'processViewer
        '
        Me.processViewer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.processViewer.Location = New System.Drawing.Point(0, 28)
        Me.processViewer.Name = "processViewer"
        Me.processViewer.Size = New System.Drawing.Size(427, 349)
        Me.processViewer.TabIndex = 2
        Me.processViewer.UseCompatibleStateImageBehavior = False
        Me.processViewer.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 118
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Memory"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Working"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Intialized"
        Me.ColumnHeader4.Width = 109
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Process ID"
        Me.ColumnHeader5.Width = 76
        '
        'taskTimer
        '
        Me.taskTimer.Interval = 15000
        '
        'refreshBtn
        '
        Me.refreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.refreshBtn.Image = CType(resources.GetObject("refreshBtn.Image"), System.Drawing.Image)
        Me.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(50, 22)
        Me.refreshBtn.Text = "Refresh"
        '
        'taskmgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 401)
        Me.Controls.Add(Me.processViewer)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "taskmgr"
        Me.Text = "reganaM ksaT"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents endButton As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents processAmountlbl As ToolStripStatusLabel
    Friend WithEvents processViewer As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents taskTimer As Timer
    Friend WithEvents refreshBtn As ToolStripButton
End Class
