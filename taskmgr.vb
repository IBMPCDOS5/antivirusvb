Public Class taskmgr
    Private Sub taskmgr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Shows your processes
        Dim Process As New Process()
        Dim Count As Integer = 0
        processViewer.Items.Clear()
        For Each Process In Process.GetProcesses(My.Computer.Name)
            On Error Resume Next
            processViewer.Items.Add(Process.ProcessName)
            processViewer.Items(Count).SubItems.Add(FormatNumber(Math.Round(Process.PrivateMemorySize64 / 1024), 0))
            processViewer.Items(Count).SubItems.Add(Process.Responding)
            processViewer.Items(Count).SubItems.Add(Process.StartTime.ToString.Trim)
            processViewer.Items(Count).SubItems.Add(Process.Id)
            Count += 1
        Next
        processAmountlbl.Text = "Number of Processes: " & processViewer.Items.Count

    End Sub

    Private Sub endButton_Click(sender As Object, e As EventArgs) Handles endButton.Click
        For Each Process As ListViewItem In processViewer.SelectedItems
            System.Diagnostics.Process.GetProcessById(Process.SubItems(4).Text).Kill()
        Next
        taskmgr_Load(Nothing, Nothing)


    End Sub

    Private Sub taskTimer_Tick(sender As Object, e As EventArgs) Handles taskTimer.Tick
        taskmgr_Load(Nothing, Nothing)
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        Dim Process As New Process()
        Dim Count As Integer = 0
        processViewer.Items.Clear()
        For Each Process In Process.GetProcesses(My.Computer.Name)
            On Error Resume Next
            processViewer.Items.Add(Process.ProcessName)
            processViewer.Items(Count).SubItems.Add(FormatNumber(Math.Round(Process.PrivateMemorySize64 / 1024), 0))
            processViewer.Items(Count).SubItems.Add(Process.Responding)
            processViewer.Items(Count).SubItems.Add(Process.StartTime.ToString.Trim)
            processViewer.Items(Count).SubItems.Add(Process.Id)
            Count += 1
        Next
        processAmountlbl.Text = "Number of Processes: " & processViewer.Items.Count
    End Sub
End Class