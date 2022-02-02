Public Class Form1
    Public Shared n1, n2, n3, n4 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text
        n4 = TextBox4.Text
        Form2.Show()
        Me.Visible = False
    End Sub
End Class
