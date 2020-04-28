Module Module1
    Dim X, Y As Integer

    Sub Main()
        Dim op, myAns As Integer

        Console.Clear()

        Console.Write("Enter first value: ")
        X = Console.ReadLine

        Console.Write("Enter second value: ")
        Y = Console.ReadLine

        Console.WriteLine("Press 1 to ADD.")
        Console.WriteLine("Press 2 to SUB.")
        Console.WriteLine("Press 3 to MUL.")
        Console.WriteLine("Press 4 to DIV.")
        Console.WriteLine("Press 5 to Exit.")
        op = Console.ReadLine()

        If op = 1 Then
            myAns = ADD(X, Y)
        End If

        If op = 2 Then
            myAns = SUBT(X, Y)
        End If

        If op = 4 Then
            myAns = DIVI(X, Y)
        End If

        If op = 3 Then
            myAns = MUL(X, Y)
        End If

        Console.WriteLine("Answer is = " & myAns)
        Console.ReadKey()
    End Sub

    Function ADD(ByVal v1 As Integer, ByVal v2 As Integer) As Integer
        Dim n As Integer
        n = v1 + v2

        ADD = n

    End Function

    Function SUBT(ByVal v1 As Integer, ByVal v2 As Integer) As Integer
        Dim n As Integer
        n = v1 - v2

        Return n
    End Function

    Function DIVI(ByVal v1 As Integer, ByVal v2 As Integer) As Integer
        Dim n As Integer
        n = v1 / v2

        Return n
    End Function

    Function MUL(ByVal v1 As Integer, ByVal v2 As Integer) As Integer
        Dim n As Integer
        n = v1 * v2

        Return n
    End Function

End Module
