Module Module1

    Sub Main()
        Dim Choice As Integer = 0
        Do
            Choice = 0
            While Choice < 1 Or Choice > 5
                Console.Clear()
                Console.WriteLine("1. Addition")
                Console.WriteLine("2. Multiplication")
                Console.WriteLine("3. Subtraction")
                Console.WriteLine("4. Division")
                Console.WriteLine("5. Exit")

                Choice = Console.ReadLine()

                If Choice = 1 Then Call adder()
                If Choice = 2 Then Call prod()
                If Choice = 3 Then Call subtract()
                If Choice = 4 Then Call div()
                Console.ReadKey()
            End While
        Loop Until Choice = 5
    End Sub

    Sub adder()
        Console.WriteLine("Fake Adder routine. Press Key.")
    End Sub

    Sub prod()
        Console.WriteLine("Fake product routine.  Press Key.")
    End Sub

    Sub subtract()
        Console.WriteLine("Fake subtraction routine.  Press Key.")
    End Sub

    Sub div()
        Console.WriteLine("Fake division routine.  Press Key.")
    End Sub





End Module
