Module Module1

    Sub Main()
        Dim x, choice, valA, valB As Integer
        choice = 0
        valA = 0
        valB = 0
        x = 0
        Do
            Console.Clear()
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Subtract")
            Console.WriteLine("3. Multiply")
            Console.WriteLine("4. Divide")
            Console.WriteLine("5. Exit")

            Do
                Console.Write("Enter you choice (1..5) : ") : choice = Console.ReadLine
            Loop Until choice >= 1 And choice <= 5

            If choice <> 5 Then
                Console.Write("Input first value: ") : valA = Console.ReadLine
                Console.Write("Input second value: ") : valB = Console.ReadLine
            End If

            If choice = 1 Then Call Addition(valA, valB)
            If choice = 3 Then
                x = Multiply(valA, valB)
                Console.WriteLine("Multiply " & valA & " * " & valB & " = " & x)
                Console.ReadKey()
            End If

        Loop Until choice = 5
    End Sub

    Sub Addition(ByVal a As Integer, ByVal b As Integer)
        Dim x As Integer
        x = a + b
        Console.WriteLine("Addition " & a & " + " & b & " = " & x)
        Console.ReadKey()
    End Sub

    Function Multiply(ByVal m1 As Integer, ByVal m2 As Integer) As Integer
        Dim x As Integer
        x = m1 * m2
        Return x
    End Function
End Module
