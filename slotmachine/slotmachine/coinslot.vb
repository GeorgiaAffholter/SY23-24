Public Class coinslot
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Event buyevent(p As Image)
    Public Property quarters As Integer
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = dollars + quarters * 0.25 + dimes * 0.1 + nickels * 0.05
            Return _total
        End Get
    End Property
    Sub coinreturn()
        RaiseEvent coinreturnevent(dollars, quarters, dimes, nickels)
        dollars = 0
        quarters = 0
        nickels = 0
        dimes = 0
    End Sub
    Sub insertquarter()
        quarters = quarters + 1
    End Sub
    Sub insertnickel()
        nickels = nickels + 1
    End Sub
    Sub insertdime()
        dimes = dimes + 1
    End Sub
    Sub insertdollar()
        dollars = dollars + 1
    End Sub
    Sub spin()
        If _total >= 1 Then
            _total = total - 1
            quarters = 0
            nickels = _total / 0.05
            dimes = 0
            dollars = 0
        End If
    End Sub




End Class
