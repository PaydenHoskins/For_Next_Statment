'Payden Hoskins
'Spring 2025
'RCET2265
'OperatorsExample

Option Explicit On
Option Strict On

Module ForNextStatments

    Sub Main()
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
    End Sub

End Module
