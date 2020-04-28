Module Module1

    Sub Main()
        Dim x As New Random
        Dim a As Integer
        While (True)
            'a = x.Next()
            'Console.WriteLine(a)

            'a = x.Next(7)
            'Console.WriteLine(a)

            a = x.Next(5, 12)
            Console.WriteLine(a)

            Console.ReadKey()
            End While 
    End Sub

End Module
