Module SwapNum
    Sub swap(ByVal a As Integer, ByVal b As Integer)
        Dim temp As Integer
        temp = a
        a = b
        b = temp
    End Sub
    Sub main()
        'Byval Swap
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Enter value of a :")
        a = Console.ReadLine
        Console.WriteLine("Emter value of b :")
        b = Console.ReadLine
        Swap(a, b)
        Console.WriteLine("Swapped values are : {0},{1}", a, b)
    End Sub
End Module
