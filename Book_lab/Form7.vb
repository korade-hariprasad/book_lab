Public Class Form7
    Dim con As New OleDb.OleDbConnection
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim a As String
        a = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\MyPro\Book_lab\Book_lab\Elab.accdb"
        con.ConnectionString = a
        con.Open()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "insert into [return] values('" & TextBox5.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "')"
        cmd.ExecuteNonQuery()
        cmd.Connection = con
        cmd.CommandText = "delete *from issue"
        cmd.ExecuteNonQuery()
        MsgBox("returned")


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class