Public Class Form4
    Dim cnn As New OleDb.OleDbConnection
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As String
        a = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\MyPro\Book_lab\Book_lab\Elab.accdb"
        cnn.ConnectionString = a
        cnn.Open()

        Dim s As String = "SELECT*FROM[user]"
        Dim da As New OleDb.OleDbDataAdapter(s, cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cnn.Close()

    End Sub
End Class