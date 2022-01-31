'Seth Nieslen Rasmussen
'RCET0265
'Spring 2022
'Say My Name Again
'https://github.com/SethRas/ConsoleApp1.git

Option Explicit On
Option Strict On
Option Compare Text

Module SayMyNameAgain

    Sub Main()

        Dim name As String
        Dim runAgain As Boolean

        Do

            Console.WriteLine("Your name?")
            name = Console.ReadLine()

            Dim comment1 As String
            Dim comment2 As String
            Dim comment3 As String
            Dim comment4 As String

            comment1 = name & " Cuoio!"
            comment2 = name & " I'm Sorry, please take me back!"
            comment3 = name & " Aren't you glad this isn't labVIEW?"
            comment4 = name & " Look I did it!!!"

            Select Case name

                Case "Joe"
                    Console.WriteLine(comment1)
                    runAgain = True
                Case "Emily"
                    Console.WriteLine(comment2)
                    runAgain = True
                Case "Seth"
                    Console.WriteLine(comment3)
                    runAgain = True
                Case "Tim"
                    Console.WriteLine(comment4)
                    runAgain = True
                Case Else
                    Console.WriteLine("Who are you? What are you doing here?")
                    runAgain = False

            End Select
        Loop Until runAgain = False

        Console.ReadLine()




    End Sub


End Module
