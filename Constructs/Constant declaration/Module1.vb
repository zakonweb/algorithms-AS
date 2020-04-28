Module Module1

    Sub Main()
        Dim cirArea, r As Single
        Const pi = 3.142

        r = Console.ReadLine()
        cirArea = pi * r ^ 2
        Console.WriteLine(cirArea)

        Console.ReadKey()
    End Sub

End Module
