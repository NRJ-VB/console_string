Imports System.Exception
Module Excptn
    Sub div(ByVal a As Integer, ByVal b As Integer)
        Dim result As Integer
        Try
            result = a \ b
        Catch e As DivideByZeroException
            Console.WriteLine("Exception Caught :{0}", e)
        Finally
            Console.WriteLine("Result ={0}", result)
        End Try
    End Sub
    Sub Main()
        div(5, 0)
        Console.ReadKey()
    End Sub
End Module
