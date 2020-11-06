Public Class Visual
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then My.Computer.Audio.Play("D:\[ontiva.com] Crazy Realistic Knocking Sound (Troll Twitch Streamers)-320k.wav")
        If CheckBox1.Checked = False Then My.Computer.Audio.Stop()
    End Sub
End Class