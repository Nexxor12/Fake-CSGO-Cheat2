Public Class Settings
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then Label1.Text = "On"
        If CheckBox1.Checked = False Then Label1.Text = "Off"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Panel1.BackColor = Color.DarkRed
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Panel1.BackColor = Color.DarkCyan
    End Sub
End Class