Module Module1

    Sub Main()
        Dim x As Double = 12345.356
        Console.WriteLine(x)
        Console.WriteLine(Format(x, "00000000.00"))
        Console.WriteLine(x.ToString("########.00"))
        Console.WriteLine(x.ToString("$##,###.00"))
        Console.WriteLine(x.ToString("(###) ###-####"))

        x = 1234567890
        Console.WriteLine(x.ToString("(###) ###-####"))


        Console.ReadKey()
    End Sub

End Module
