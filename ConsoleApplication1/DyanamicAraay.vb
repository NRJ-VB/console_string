Module DyanamicAraay
    Sub main()
        Console.ReadKey()
        Console.WriteLine(" ")
        Console.WriteLine("-----------------Dyanamic Array-----------------")
        Console.WriteLine(" ")
        Dim marks() As Integer
        ReDim marks(3)
        marks = {1, 2, 3, 4}
        For x = 0 To 3
            Console.WriteLine("Values are :{0}", marks(x))
        Next
        Console.ReadKey()
        Console.WriteLine(" ")
        Console.WriteLine("-----------------Preserve Array-----------------")
        Console.WriteLine(" ")
        ReDim Preserve marks(10)
        For x = 0 To 10
            Console.WriteLine("Values are :{0}", marks(x))
        Next
        Console.ReadKey()
    End Sub
End Module
