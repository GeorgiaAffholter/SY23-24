Public Class clicker
    Public Property count As Integer
    Public Property increment As Integer = 1
    Public Sub click()
        count = count + increment
    End Sub
    Public Sub reset()
        count = 0
    End Sub
End Class
