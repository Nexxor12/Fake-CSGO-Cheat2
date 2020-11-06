Public Class Inject
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = ProgressBar1.Maximum Then Label2.Text = "Injected"
        If ProgressBar1.Value = ProgressBar1.Maximum Then Label2.ForeColor = Color.Green
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        If Label2.Text = "Injected" Then MsgBox("Error Config Is Already Injected", MessageBoxIcon.Error)
    End Sub
End Class