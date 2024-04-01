Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim f2 As New Form2
        f2.ShowDialog()
        'Jewlerycount.Text = f2.2Jewlerycount.Value
        Me.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim f3 As New Form3
        f3.ShowDialog()
        'Jewlerycount.Text = f2.2Jewlerycount.Value
        Me.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Jewlerycount.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
