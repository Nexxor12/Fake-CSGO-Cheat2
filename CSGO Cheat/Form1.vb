Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Inject
            .TopLevel = False
            Panel2.Controls.Add(Inject)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Inject.Label2.Text = "Not Injected!" Then MsgBox("Error! DLL Is Not Injected", MessageBoxIcon.Error)
        If Inject.Label2.Text = "Injected" Then Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With Aimbot
            .TopLevel = False
            Panel2.Controls.Add(Aimbot)
            .BringToFront()
            .Show()
            Timer1.Stop()
        End With
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        With Visual
            .TopLevel = False
            Panel2.Controls.Add(Visual)
            .BringToFront()
            .Show()
            Timer2.Stop()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Inject.Label2.Text = "Not Injected!" Then MsgBox("Error! DLL Is Not Injected", MessageBoxIcon.Error)
        If Inject.Label2.Text = "Injected" Then Timer2.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Inject.Label2.Text = "Not Injected!" Then MsgBox("Error! DLL Is Not Injected", MessageBoxIcon.Error)
        If Inject.Label2.Text = "Injected" Then Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        With World
            .TopLevel = False
            Panel2.Controls.Add(World)
            .BringToFront()
            .Show()
            Timer3.Stop()
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With Settings
            .TopLevel = False
            Panel2.Controls.Add(Settings)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        With Inject
            .TopLevel = False
            Panel2.Controls.Add(Inject)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        With Credits
            .TopLevel = False
            Panel2.Controls.Add(Credits)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
