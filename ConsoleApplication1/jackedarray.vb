Module jackedarray
    Sub main()
        Dim marks As Integer()() = New Integer(3)() {}
        marks(0) = {0, 0}
        marks(1) = {1, 2}
        marks(2) = {3, 4}
        marks(3) = {5, 6}
        For i = 0 To 3
            For j = 0 To 1
                Console.WriteLine("Marks[{0},{1}]={2}", i, j, marks(i)(j))
            Next
        Next
        Console.ReadKey()
        'String based Books Jacked Array
        Dim mybooks(2) As String
        mybooks = {"VB.Net", "Vb Studio", "Visual Basic"}
        Dim yourbooks(3) As String
        yourbooks = {"Neeraj", "Shailesh", "Teddy", "Feddy"}
        Dim books As String()() = New String(1)() {}
        books(0) = mybooks
        books(1) = yourbooks
        For i = 0 To 0
            For j = 0 To 2
                Console.WriteLine("{0}", books(i)(j))
            Next
        Next
        For i = 1 To 1
            For j = 0 To 3
                Console.WriteLine("{0}", books(i)(j))
            Next
        Next
        Console.ReadKey()
    End Sub
End Module
