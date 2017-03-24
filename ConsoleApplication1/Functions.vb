Module Functions
    Sub main()
        Dim digits() As Integer
        digits = {1, 2, 3, 4}
        Dim result() As Integer
        For i = 0 To 3
            Console.WriteLine("Original elements are={0}", digits(i))
        Next
        result = xyz(digits)
        For i = 0 To 3
            Console.WriteLine("Modified Elements are :{0}", result(i))
        Next
        Console.ReadKey()
    End Sub
    Public Function xyz(ByRef myarray() As Integer) As Array
        Dim ret() As Integer
        For i = 0 To 3
            myarray(i) = myarray(i) + 1

        Next

        ret = myarray
        Return ret
    End Function
End Module
