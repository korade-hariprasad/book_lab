Public Class Form3
    Dim cnn As New OleDb.OleDbConnection

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As String
        a = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\MyPro\Book_lab\Book_lab\Elab.accdb"
        cnn.ConnectionString = a
        cnn.Open()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = "insert into [stock] values('" & TextBox5.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("inserted")
        cnn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim s As String = "select * from [stock]"
        Dim da As New OleDb.OleDbDataAdapter(s, cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cnn.Close()
    End Sub
End Class