



Public Class Form3
        Dim amount As Integer

        Private Sub TotalL_TextChanged(sender As Object, e As EventArgs) Handles TotalL.TextChanged

        End Sub
        ' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' amount = amount + 13
        'TotalL.Text = amount.ToString("C2")


        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            amount = amount + 13
            TotalL.Text = amount.ToString("C2")
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            amount = amount + 20
            TotalL.Text = amount.ToString("C2")
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            amount = amount + 20
            TotalL.Text = amount.ToString("C2")
        End Sub


        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            amount = amount + 13
            TotalL.Text = amount.ToString("C2")
        End Sub
End Class