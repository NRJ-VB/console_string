Module Cases
    Sub main()
        Dim day As Integer
        Console.WriteLine("Enter any number b/w 1-7")
        day = Console.ReadLine
        Select Case day
            Case 1
                MsgBox("Monday")
            Case 2
                MsgBox("Tuesday")
            Case 3
                MsgBox("Wednesday")
            Case 4
                MsgBox("Thursday")
            Case 5
                MsgBox("Friday")
            Case 6
                MsgBox("Saturday")
            Case 7
                MsgBox("Sunday")
            Case Else
                MsgBox("Wrong Number")

        End Select

    End Sub
End Module
