Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form1
    Dim amount As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim f2 As New Form2
        f2.ShowDialog()
        'Jewlerycount.Text = f2.2Jewlerycount.Value
        Me.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim f3 As New Form3
        f3.ShowDialog()
        'Jewlerycount.Text = f2.2Jewlerycount.Value
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        amount = amount + 18
        TotalLab.Text = amount.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        amount = amount + 22
        TotalLab.Text = amount.ToString("C2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        amount = amount + 22
        TotalLab.Text = amount.ToString("C2")
    End Sub
End Class
