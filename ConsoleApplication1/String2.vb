Module String2
    Sub main()
        'Use of "&" sign
        Dim age As Integer = 19
        Console.WriteLine("Neeraj's age is " & age)
        Console.ReadKey()
        'Formatting Functions in VB
        MsgBox(FormatNumber(1834))
        MsgBox(FormatCurrency(5000))
        MsgBox(FormatPercent(46))
    End Sub
End Module
