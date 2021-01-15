Module Module1

    Sub Main()
        Console.WriteLine(isDivisible(Console.ReadLine, Console.ReadLine))
        Console.ReadKey()
    End Sub

    Function isDivisible(ByVal x As Integer, ByVal y As Integer) As Boolean
        If x Mod y = 0 Then
            Return True
        Else
            Return False
        End If

        'Return IIf(x Mod y = 0, True, False)
    End Function
End Module
