Module Array1
    Sub main()
        Dim numseq() As Integer = {1, 2, 3, 4, 5, 6, 7}
        For Each number As Integer In numseq
            If (number >= 3 And number <= 5) Then
                Continue For
            End If
            If (number = 6) Then
                Exit For
            End If
            MsgBox(number)
        Next
        Console.ReadKey()
    End Sub

End Module
