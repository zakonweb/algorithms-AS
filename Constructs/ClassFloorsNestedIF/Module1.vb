Module Module1

    Sub Main()
        Dim ClassID As Integer = Console.ReadLine
        If ClassID >= 1 And ClassID <= 50 Then
            Console.WriteLine("1")
        Else
            If ClassID >= 51 And ClassID <= 100 Then
                If ClassID Mod 2 = 0 Then
                    Console.WriteLine("2A")
                Else
                    Console.WriteLine("2B")
                End If
            End If
        End If
        Console.ReadKey()
    End Sub

End Module
