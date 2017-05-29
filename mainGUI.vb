Public Class mainGUI
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub taskmgrOpen_Click(sender As Object, e As EventArgs) Handles taskmgrOpen.Click
        taskmgr.Show()
    End Sub


End Class
