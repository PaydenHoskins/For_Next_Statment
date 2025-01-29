'Payden Hoskins
'Spring 2025
'RCET2265
'OperatorsExample

Option Explicit On
Option Strict On

Module ForNextStatments

    Sub Main()
        Dim Result As String
        For i As Integer = 1 To 10 Step 1
            Console.WriteLine(i)
        Next

        Console.WriteLine(StrDup(80, "*"))

        For i = 1 To 10 Step 0.5
            Console.WriteLine(i)
        Next

        Console.WriteLine(StrDup(80, "*"))

        For i = 1 To 10
            Console.WriteLine(i)
        Next

        Console.WriteLine(StrDup(80, "*"))

        'Nested For Loop

        For i = 1 To 10
            Console.WriteLine($"{i}. ")
            For j = 1 To 10

                'Result = (Str(i + j))
                'Result = Result.PadLeft(3)
                'Console.Write(Result)

                'Console.Write($"{i + j}".PadLeft(3) & "|")

                Result = (j + i).ToString("")
                Result = Result.PadLeft(8)
                Console.Write(Result)
            Next
            Console.WriteLine()

        Next


    End Sub

End Module
