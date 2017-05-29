<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.aboutlbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.okbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'aboutlbl
        '
        Me.aboutlbl.AutoSize = True
        Me.aboutlbl.Location = New System.Drawing.Point(4, 9)
        Me.aboutlbl.Name = "aboutlbl"
        Me.aboutlbl.Size = New System.Drawing.Size(285, 91)
        Me.aboutlbl.TabIndex = 0
        Me.aboutlbl.Text = resources.GetString("aboutlbl.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Originally written by IBMPCDOS5 on June 28th of 2017."
        '
        'okbtn
        '
        Me.okbtn.Location = New System.Drawing.Point(102, 213)
        Me.okbtn.Name = "okbtn"
        Me.okbtn.Size = New System.Drawing.Size(75, 23)
        Me.okbtn.TabIndex = 2
        Me.okbtn.Text = "OK"
        Me.okbtn.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.okbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.aboutlbl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.Text = "About AntivirusVB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents aboutlbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents okbtn As Button
End Class
