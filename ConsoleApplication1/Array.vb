Module Array
    Sub main()

        Dim roll(6) As Integer
        Console.WriteLine("Enter ur roll number:")
        For x = 0 To 5
            roll(x) = Console.ReadLine()
        Next
        Console.WriteLine("Your Roll Numbers are :")
        For x = 0 To 5
            Console.WriteLine("{0}", roll(x))
        Next
        Console.ReadKey()
    End Sub
End Module
