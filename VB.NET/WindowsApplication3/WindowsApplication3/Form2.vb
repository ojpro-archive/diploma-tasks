Public Class Form2
    Private some As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        some = Form1.n1 + Form1.n2 + Form1.n3 + Form1.n4
        TextBox1.Text = some
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = some / 4
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False
        Form1.Visible = True
        Form1.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class