Module Thing

    Sub Main()
        'Dim userResponse As String


        'Console.WriteLine("What's your name?")
        'userResponse = Console.ReadLine()


        'Dim message As String
        'message = userResponse & " Wow... you're parents really waited 9 months for a baby and named you" ${ userResponse } "huh"
        'Do
        '    Select Case userResponse
        '        Case "GTA 4"
        '            Console.WriteLine(message)
        '        Case "Battlefield 3"
        '            Console.WriteLine(message)
        '        Case "GRID"
        '            Console.WriteLine(message)
        '        Case "Infamous"
        '            Console.WriteLine(message)
        '        Case Else
        '            Console.WriteLine("Looks like your game is not on my list")

        '    End Select
        'Loop

        'Console.ReadLine()

        Dim name As String


        Console.WriteLine("Your name?")
        name = Console.ReadLine()


        Dim message As String
        Dim message1 As String
        message = name & " is your favourite game!"
        message1 = name & " is alright"

        Select Case name


                Case "GTA 4"
                    Console.WriteLine(message)
                Case "Battlefield 3"
                    Console.WriteLine(message1)
                Case "GRID"
                    Console.WriteLine(message2)
                Case "Infamous"
                    Console.WriteLine(message3)
                Case Else
                    Console.WriteLine("Looks like your game is not on my list")


            End Select

        Console.ReadLine()


    End Sub


End Module
