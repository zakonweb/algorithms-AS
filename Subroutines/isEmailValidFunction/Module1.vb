Module Module1

    Sub Main()
        Console.WriteLine(isEmailValid(Console.ReadLine))
        Console.ReadKey()
    End Sub

    Function isEmailValid(ByVal Email As String) As Boolean
        Dim atCounter As Integer = 0
        Dim a As Integer = 0
        Dim ch As Char = ""

        For a = 1 To Len(Email)
            ch = Mid(Email, a, 1)
            If ch = "@" Then atCounter = atCounter + 1
        Next

        If atCounter > 1 Or _
            Left(Email, 1) = "@" Or _
            InStr(Email, "@") > Len(Email) - 3 Then

            Return False
        Else
            Return True
        End If

    End Function

End Module
