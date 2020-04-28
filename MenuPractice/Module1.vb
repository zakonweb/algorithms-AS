Module Module1

    Sub Main()
        Dim choice, first, second, result As Integer

        choice = 0
        Do
            Call displayOptions()
            Do
                Console.Write("Enter choice (1..5) ")
                choice = Console.ReadLine
            Loop Until choice >= 1 And choice <= 5

            If choice <> 5 Then
                Console.Write("Enter first value: ")
                first = Console.ReadLine

                Console.Write("Enter second value: ")
                second = Console.ReadLine()

                If choice = 1 Then result = addData(first, second)
                If choice = 2 Then result = subData(first, second)
                If choice = 3 Then result = mulData(first, second)
                If choice = 4 Then result = divData(first, second)

                Console.WriteLine("Your result is = " & result)
                Console.ReadKey()
            End If
        Loop Until choice = 5
    End Sub

    Sub displayOptions()
        Console.Clear()
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Subtract")
        Console.WriteLine("3. Multiply")
        Console.WriteLine("4. Divide")
        Console.WriteLine("5. Exit")
    End Sub

    Function addData(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim z As Integer = 0
        z = x + y
        Return z
    End Function

    Function subData(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim z As Integer = 0
        z = x - y
        Return z
    End Function

    Function mulData(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim z As Integer = 0
        z = x * y
        Return z
    End Function

    Function divData(ByVal x As Integer, ByVal y As Integer) As Single
        Dim z As Single = 0
        z = x / y
        Return z
    End Function
End Module
