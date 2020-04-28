Module Module1

    Sub Main()
        Dim count As Integer
        Dim value As Integer

        Randomize()

        For count = 1 To 6
            value = Int((8 * Rnd()) + 1)
            Console.WriteLine(value)
        Next
        Console.ReadKey()
    End Sub

End Module
