Module Module1

    Sub Main()
        Call testRandom(50)
    End Sub

    Sub testRandom(ByVal UB As Integer)
        Dim c, n, i As Integer
        Dim rn As New Random
        Dim ABC(UB) As Boolean

        For i = 1 To UB
            ABC(i) = False
        Next

        For i = 1 To UB
            Do
                c = c + 1
                n = rn.Next(1, UB + 1)
            Loop Until ABC(n) = False
            ABC(n) = True
        Next
        Console.WriteLine("Total count for the generation of " & UB & " numbers = " & c)
        Console.ReadKey()
    End Sub
End Module
