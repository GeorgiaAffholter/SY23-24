Imports System.Reflection.Emit
Imports System.Threading

Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cs.total >= 1 Then
            Timer1.Enabled = True
            Reelcontrol2.spin()
            Reelcontrol3.spin()
            Reelcontrol4.spin()
            cs.spin()
            Moneyamountlabel.Text = cs.total.ToString("c2")

        End If

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cs.insertdollar()
        Moneyamountlabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Label1.Text = Reelcontrol1.itemvalue
        Label2.Text = Reelcontrol2.itemvalue
        Label3.Text = Reelcontrol3.itemvalue
        Timer1.Enabled = False
        If Reelcontrol1.itemvalue = Reelcontrol2.itemvalue And Reelcontrol2.itemvalue = Reelcontrol3.itemvalue Then
            cs.insertdollar()
            cs.insertdollar()
        End If
        MoneyAmountlabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertquarter()
        MoneyAmountlabel.text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdime()
        Moneyamountlabel.text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertdollar()
        MoneyAmountlabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Moneyamountlabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cs.insertnickel()
        MoneyAmountlabel.Text = cs.total.ToString("c2")
    End Sub
End Class
