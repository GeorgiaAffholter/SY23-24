Imports System.Threading

Public Class Reelcontrol
    Public Property itemvalue As Integer

    Public Property spintime As Integer = 2000

    Dim rand As New Random

    Public Sub spin()
        Timer1.Enabled = True


    End Sub
    Private Sub ReelControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(r)
        itemvalue = r
        Timer1.Enabled = False
        Timer1.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
