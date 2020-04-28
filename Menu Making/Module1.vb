Module Module1
    Sub Main()
        Dim choice As Integer = 0
        Do 'Repeatedly show menu until user opts to get out by pressing 0
            Call choicesDaisplay()

            Do 'Choice input validation
                Console.Write("Enter your choice (0...3) :")
                choice = Console.ReadLine
                If choice < 0 Or choice > 3 Then
                    Console.WriteLine("Invalid choice. Enter between 0..3 ")
                    Console.ReadKey()
                End If
            Loop Until choice >= 0 And choice <= 3
        Select choice
                Case 0
                Case 1 : Call Choice1()
                Case 2 : Call Choice2()
                Case 3 : Call Choice3()
                Case Else : Console.WriteLine("Invalid choice. Enter between 0..3 ")
            End Select

        Loop Until choice = 0
    End Sub

    Sub choicesDaisplay()
        Console.Clear()
        Console.WriteLine("0. Quit program.")
        Console.WriteLine("1. Choose 1 for the program option 1.")
        Console.WriteLine("2. Choose 2 for the program option 2.")
        Console.WriteLine("3. Choose 3 for the program option 3.")
    End Sub

    Sub Choice1()
        Console.WriteLine("Procedure 1 is called for choice 1")
        Console.ReadKey()
    End Sub

    Sub Choice2()
        Console.WriteLine("Procedure 2 is called for choice 2")
        Console.ReadKey()
    End Sub

    Sub Choice3()
        Console.WriteLine("Procedure 3 is called for choice 3")
        Console.ReadKey()
    End Sub
End Module
