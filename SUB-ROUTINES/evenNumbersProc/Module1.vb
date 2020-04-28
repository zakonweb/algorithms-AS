Module Module1

    Sub Main()
        Dim a, b, c As Integer

        Call evenNumbers(a, b, c)
        Console.WriteLine(a & " numbers")
        Console.WriteLine("sum = " & b)
        Console.WriteLine(c & " evens")

        Console.ReadKey()
    End Sub

    Sub evenNumbers(ByRef nums As Integer, ByRef sums As Integer, ByRef evens As Integer)
        Dim lineStr As String
        FileOpen(1, "c:\filePractice\numbers.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, lineStr)
            nums = nums + 1
            sums = sums + Val(lineStr)
            If Val(lineStr) Mod 2 = 0 Then evens = evens + 1
        End While
        FileClose(1)
    End Sub
End Module
