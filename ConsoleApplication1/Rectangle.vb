'Console App to find Area of Rectangle
Module module1
    Public Class rectangle
        Private length As Double
        Private width As Double
        Private Sub get_details()
            Console.WriteLine("Enter length of rectangle :")
            length = Console.ReadLine()
            Console.WriteLine("Enter width of rectangle :")
            width = Console.ReadLine()
        End Sub
        Public Function area() As Double
            Dim ar As Double
            ar = length * width
            Return ar
        End Function
        Private Sub display()
            Console.WriteLine("Length is :{0}", length)
            Console.WriteLine("Width is :{0}", width)
            Console.WriteLine("Area is ={0}", area())
        End Sub
        Shared Sub Main()
            Dim r As New rectangle
            r.get_details()
            r.display()
            Console.ReadKey()
        End Sub
    End Class
End Module

