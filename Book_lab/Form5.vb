Public Class Form5
    Dim con As New OleDb.OleDbConnection
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As String
        a = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\MyPro\Book_lab\Book_lab\Elab.accdb"
        con.ConnectionString = a
        con.Open()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "insert into [user] values('" & TextBox1.Text & "','" & TextBox7.Text & "','" & TextBox2.Text & "','" & TextBox6.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("inserted")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class