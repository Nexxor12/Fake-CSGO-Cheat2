Public Class TOS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False Then MsgBox("Agree To The Terms Of Service!", MessageBoxIcon.Error)
        If CheckBox1.Checked = True Then Form1.Show()
    End Sub

    Private Sub TOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class