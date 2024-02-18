Public Class Form6
    Dim cnn As New OleDb.OleDbConnection
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As String
        a = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\MyPro\Book_lab\Book_lab\Elab.accdb"
        cnn.ConnectionString = a
        cnn.Open()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = "insert into issue values(" & TextBox3.Text & ",'" & TextBox4.Text & "'," & TextBox2.Text & ",'" & TextBox1.Text & "'," & TextBox5.Text & ")"
        cmd.ExecuteNonQuery()
        Dim con As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = "insert into [temp] values(" & TextBox3.Text & ",'" & TextBox4.Text & "'," & TextBox2.Text & ",'" & TextBox1.Text & "'," & TextBox5.Text & ")"
        cmd.ExecuteNonQuery()
        cnn.Close()
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\MyPro\Book_lab\Book_lab\Elab.accdb"
        cnn.Open()
        Dim s As String = "select * from issue"
        Dim da As New OleDb.OleDbDataAdapter(s, cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cnn.Close()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class