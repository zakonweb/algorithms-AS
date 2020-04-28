Module Module1

    Sub Main()
        Dim a, b As Integer
        a = 8
        b = 7
        Console.WriteLine("a = " & a & " , b = " & b)

        Call SA(a, b)

        Console.WriteLine("a = " & a & " , b = " & b)

        a = sum(456, 55)
    End Sub

    Sub SA(ByVal x As Integer, ByRef y As Integer)
        x = 15
        y = 75

        Console.WriteLine("x = " & x & " , y = " & y)
    End Sub

    Function sum(ByVal n As Integer, ByVal m As Integer) As Integer
        Dim s As Integer
        s = n + m
        Return s
    End Function
End Module
