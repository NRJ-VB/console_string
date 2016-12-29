'Common String Operations
Module Module3
    Sub main()
        Dim str1, str2, str4, str5 As String
        str1 = " This is test"
        str2 = "This is text"
        str4 = "Hello"
        Dim str3 As String() = {"Hello", "BCA", "class"}
        If (String.Compare(str1, str2) = 0) Then
            Console.WriteLine("Equal")
        Else
            Console.WriteLine("Not Equal")
        End If
        str5 = (String.Concat(str1, str2, str4))
        Console.WriteLine("Concated String ={0}", str5)
        If (str1.Contains("is")) Then
            Console.WriteLine("Yes it contains")
        Else
            Console.WriteLine("It doesn't contain")
        End If
        str5 = String.Copy(str1)
        Console.WriteLine("Copied String : {0}", str5)
        If str1.EndsWith("test") = True Then
            Console.WriteLine("It ends")
        Else
            Console.WriteLine("It doesn't end")
        End If
        If String.Equals(str1, str2) Then
            Console.WriteLine("Equals")
        Else
            Console.WriteLine("Not Equals")
        End If
        str5 = str1.IndexOf("t")
        Console.WriteLine("Index of Char ={0}", str5)
        str5 = str1.IndexOf("is")
        Console.WriteLine("Index of String ={0}", str5)
        str5 = str1.Insert(9, "Hello")
        Console.WriteLine("Inserted String ={0}", str5)
        str5 = str1.ToUpper
        Console.WriteLine("Uppered String ={0}", str5)
        str5 = str1.ToLower
        Console.WriteLine("Lowered String ={0}", str5)
        str5 = str1.Trim
        Console.WriteLine("Trimmed String ={0}", str5)
        str5 = String.Join(",", str1, str2)
        Console.WriteLine("Joined String ={0}", str5)
        str5 = String.Join(vbCrLf, str3)
        Console.Write("Joined String ={0}", str5)
        Console.ReadKey()
    End Sub
End Module
