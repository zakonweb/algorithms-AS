Module Module1

    Sub Main()
        Dim myCurr As Decimal
        myCurr = Console.ReadLine
        Console.WriteLine("Currency Format: " & Format(myCurr, "Currency"))
        Console.WriteLine("Currency Format: " & Format(myCurr, "$#,##0.00"))
        Console.WriteLine("Currency Format: " & Format(myCurr, "$,000,000,000.00"))
        Console.ReadKey()

    End Sub

End Module
