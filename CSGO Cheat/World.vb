Public Class World
    Dim Process1 As String = "csgo"
    Dim website As String = "https://youtu.be/dQw4w9WgXcQ"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Settings.CheckBox1.Checked = False Then MsgBox("Warning You Just Tried To Run " & Button1.Text & " Exploit And This Is Risky And Could Result In A Ban Turn On Risk Mode In Settings To Do This", MessageBoxIcon.Information)
        If Settings.CheckBox1.Checked = True Then killcsgo()
    End Sub
    Private Sub killcsgo()
        For Each p As Process In Process.GetProcessesByName(Process1)
            If Settings.CheckBox1.Checked = True Then p.Kill()
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Settings.CheckBox1.Checked = False Then MsgBox("Warning You Just Tried To Run " & Button3.Text & " Exploit And This Is Risky And Could Result In A Ban Turn On Risk Mode In Settings To Do This", MessageBoxIcon.Information)
        If Settings.CheckBox1.Checked = True Then MsgBox("Sorry But This Exploit Has Been Patched By VAC", MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Settings.CheckBox1.Checked = False Then MsgBox("Warning You Just Tried To Run " & Button2.Text & " Exploit And This Is Risky And Could Result In A Ban Turn On Risk Mode In Settings To Do This", MessageBoxIcon.Information)
        If Settings.CheckBox1.Checked = True Then Process.Start(website)
    End Sub
End Class