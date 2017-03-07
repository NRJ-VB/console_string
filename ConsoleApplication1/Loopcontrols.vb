Module Loopcontrols
    Sub main()
        'Exit Statement
        Dim a As Integer = 1
        While (a < 20)
            Console.WriteLine("value of a ={0}", a)
            a = a + 1
            If (a = 15) Then
                Exit While
            End If
        End While
        Console.ReadKey()
        'Continue Statement
        a = 10
        Do
            If (a = 15) Then
                a = a + 1
                Continue Do
            End If
            Console.WriteLine("Value of a ={0}", a)
            a = a + 1
        Loop While (a < 20)
        Console.ReadKey()
    End Sub
End Module
