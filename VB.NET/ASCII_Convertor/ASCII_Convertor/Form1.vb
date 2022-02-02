Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateDate()
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub

    Private Sub Convert_Click(sender As Object, e As EventArgs) Handles Convert.Click
        Dim str = Convert_String_Input.Text
        For i As Integer = 0 To str.Length - 1
            Convert_ASCII_Input.Text += Asc(str(i)) & " "
        Next

    End Sub

    Private Sub Deconvert_Click(sender As Object, e As EventArgs) Handles Deconvert.Click
        Deconvert_String_input.Text = ""
        Dim ascii() As String = Split(Deconvert_ASCII_input.Text, " ")
        For i As Integer = 0 To ascii.Length - 1
            Deconvert_String_input.Text += CStr(Chr(ascii(i)))
        Next

    End Sub

    Private Sub updateDate()
        Current_Date.Text = Date.Now
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        updateDate()
    End Sub
End Class
