Module Loops
    Sub main()
        'DoWhile Loop
        Console.WriteLine("-----------------------Do While Loop-----------------------")
        Dim x As Integer = 1
        Do While (x <= 5)
            Console.WriteLine("Value of X :{0}", x)
            x = x + 1
        Loop
        Console.ReadKey()

        'DoUntil Loop
        Console.WriteLine("-----------------------Do Until Loop-----------------------")
        x = 1
        Do Until (x = 5)
            Console.WriteLine("Value of X :{0}", x)
            x = x + 1
        Loop
        Console.ReadKey()
        'For Next Loop
        Console.WriteLine("-----------------------For Next-----------------------")
        For x = 1 To 20
            Console.WriteLine("Value of x ={0}", x)
        Next
        Console.ReadKey()
        'For Each Loop
        Dim myarray() As Integer = {1, 3, 5, 6}
        Dim myvalue As Integer
        Console.WriteLine("-----------------------For Each----------------------")
        For Each myvalue In myarray
            Console.WriteLine(myvalue)
        Next
        Console.ReadKey()
    End Sub
End Module
