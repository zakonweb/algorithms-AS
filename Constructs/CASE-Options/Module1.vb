Module Module1

    Sub Main()
        Dim x, b As Integer

        x = Console.ReadLine

        Select Case x
            Case 2 : Console.WriteLine("Two 2")
            Case 3 To 5 : Console.WriteLine("3 to 5")
            Case Is > 5
                Console.WriteLine("is > 5")
                b = x
            Case 8, 7, 6 : Console.WriteLine("8,7,6")
            Case Else : Console.WriteLine("case else")
        End Select
    End Sub

End Module
