Public Class Credits
    Dim YT As String = "https://www.youtube.com/channel/UCzhcWjXA8d6Wjd3VttWrJOQ"
    Dim CRACKED As String = "https://cracked.to/JAYDAHACKER1234"
    Dim GITHUB As String = "https://github.com/JAYEXPLOITZ"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(GITHUB)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(CRACKED)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start(YT)
    End Sub
End Class