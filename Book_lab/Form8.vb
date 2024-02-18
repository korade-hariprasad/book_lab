Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "pass@123" Then
            Me.Hide()
            MsgBox("Login successful. Welcome ")
            Form1.Show()
        End If
    End Sub
End Class