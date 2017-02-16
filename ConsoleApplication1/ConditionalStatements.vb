Module ConditionalStatements
    'Elseif Example
    Sub main()
        Console.WriteLine("Enter ur Marks :")
        Dim num = Console.ReadLine()
        If (num > 90) Then
            Console.WriteLine("Your grade is A")
        ElseIf ((num < 90) And (num >= 80)) Then
            Console.WriteLine("Your grade is B")
        ElseIf ((num < 80) And (num >= 70)) Then
            Console.WriteLine("Your grade is C")
        ElseIf (num < 70) Then
            Console.WriteLine("You iz fail !!!")
        End If
        Console.ReadKey()
    End Sub
End Module
