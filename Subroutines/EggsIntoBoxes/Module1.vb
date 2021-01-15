Module Module1

    Sub Main()
        Dim NOE, NOB, ELO As Integer
        NOE = 0
        NOB = 0
        ELO = 0

        Console.Write("Enter Number of Eggs: ") : NOE = Console.ReadLine
        Call EggsIntoBoxes(NOE, NOB, ELO)

        Console.WriteLine("Number of eggs: " & NOE)
        Console.WriteLine("Number of full boxes: " & NOB)
        Console.WriteLine("Number of eggs left over: " & ELO)
        Console.ReadKey()
    End Sub

    Sub EggsIntoBoxes(ByVal NumberOfEggs As Integer, ByRef NumberOfBoxes As Integer, _
                      ByRef EggsLeftOver As Integer)
        NumberOfBoxes = NumberOfEggs \ 6
        EggsLeftOver = NumberOfEggs Mod 6
    End Sub

End Module
