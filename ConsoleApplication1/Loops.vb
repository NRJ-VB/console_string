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
        Console.WriteLine("-----------------------For Loop-----------------------")
        For x = 1 To 10 Step 3
            Console.WriteLine("Value of X :{0}", x)
        Next x
        Console.ReadKey()
    End Sub
End Module
