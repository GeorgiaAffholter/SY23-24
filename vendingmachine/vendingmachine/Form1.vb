Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickels()
        totallabel.Text = cs.total.ToString("c2")



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdimes()
        totallabel.Text = cs.total.ToString("c2")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarter()
        totallabel.Text = cs.total.ToString("c2")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertdollars()
        totallabel.Text = cs.total.ToString("c2")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        totallabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            dollarpb.Visible = True
        Else
            dollarpb.Visible = False
        End If
        If di > 0 Then
            dimepb.Visible = True
        Else
            dimepb.Visible = False
        End If
        If n > 0 Then
                nickelpb.Visible = True
            Else
                nickelpb.Visible = False
            End If
            If q > 0 Then
                quarterpb.Visible = True
            Else
                quarterpb.Visible = False


        End If
    End Sub




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case Idtextbox.Text
            Case Productcontrol1.productid
                cs.buy(Productcontrol1)
            Case Productcontrol4.productid
                cs.buy(Productcontrol4)
            Case Productcontrol5.productid
                cs.buy(Productcontrol5)

            Case 2

            Case Else

        End Select
        totallabel.Text = cs.total.ToString("c2")




    End Sub

    Private Sub cs_buyevent(p As Image) Handles cs.buyevent
        Productpicture.Image = p
    End Sub
End Class
