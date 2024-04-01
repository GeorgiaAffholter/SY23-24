Public Class Form2
    Dim amount As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        amount = amount + 18
        TotalLabel.Text = amount.ToString("C2")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        amount = amount + 18
        TotalLabel.Text = amount.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        amount = amount + 22
        TotalLabel.Text = amount.ToString("C2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        amount = amount + 22
        TotalLabel.Text = amount.ToString("C2")
    End Sub
End Class