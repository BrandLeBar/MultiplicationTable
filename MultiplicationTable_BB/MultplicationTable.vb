'Brandon Barrera
'Spring 2025
'RCET2265
'Multiplication Table 
'https://github.com/BrandLeBar/MultiplicationTable.git

Option Compare Text
Option Strict On
Option Explicit On

Module MultplicationTable

    Sub Main()
        Dim userInput As Integer
        Dim result As String

        Console.WriteLine("Please enter a number you want a multiplication table of.")
        userInput = CInt(Console.ReadLine())
        Console.WriteLine($"Enjoy your {userInput} X {userInput} Multiplication Table:")

        For i As Integer = 1 To userInput

            For d As Integer = 1 To userInput

                result = CStr(i * d)
                result = result.PadLeft(4)
                Console.Write(result)

            Next

            Console.WriteLine()

        Next

    End Sub

End Module
