Option Explicit On
Option Strict On
Option Compare Text

Module Thing

    Sub Main()


        Dim name As String
        Dim runAgain As Boolean

        Do


            Console.WriteLine("Your name?")
            name = Console.ReadLine()


            Dim message As String
            Dim message1 As String
            Dim message2 As String
            Dim message3 As String

            message = name & " Cuoio!"
            message1 = name & " I'm Sorry, please take me back!"
            message2 = name & " Aren't you glad this isn't labVIEW?"
            message3 = name & " Look I did it!!!"



            Select Case name


                Case "Joe"
                    Console.WriteLine(message)
                    runAgain = True
                Case "Emily"
                    Console.WriteLine(message1)
                    runAgain = True
                Case "Seth"
                    Console.WriteLine(message2)
                    runAgain = True
                Case "Tim"
                    Console.WriteLine(message3)
                    runAgain = True
                Case Else
                    Console.WriteLine("Who dat boi? Who him is?")
                    runAgain = False

            End Select
        Loop Until runAgain = False
        Console.ReadLine()




    End Sub


End Module
