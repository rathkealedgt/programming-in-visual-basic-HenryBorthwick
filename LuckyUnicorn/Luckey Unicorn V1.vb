Module Luckey_Unicorn_V1

    Sub Main()
        Payout()
        'Ask How Much
        'Generate Token
        'Payout
        'End Game

    End Sub

    ''' <summary>
    '''     Integer checking function. Checks if user input is an integer between the values given.  And asks for how much they want to play with
    ''' </summary>
    ''' <param name="LowNumber"> Lower bound of the valid range. </param>
    ''' <param name="HighNumber"> Upper bound of the valid range. </param>
    ''' <returns> The valid user input as an integer. </returns>
    Function IntegerCheck(LowNumber As Integer, HighNumber As Integer) As Integer
        'Housekeeping
        Dim UserResponse As Integer
        Const ERROR_MESSAGE As String = "Whoops! Please enter an integer."
        Dim ValidInput As Boolean = False
        Dim OUTPUT_MESSAGE As String = String.Format("Please enter an integer between {0} and {1}.", LowNumber, HighNumber)

        While Not ValidInput
            Try
                ' Ask user for a number and store it.
                Console.WriteLine(OUTPUT_MESSAGE)
                UserResponse = Console.ReadLine()

                If LowNumber <= UserResponse And UserResponse <= HighNumber Then
                    ValidInput = True
                    Console.WriteLine("You have entered ${0}", UserResponse)

                End If

            Catch ex As Exception
                Console.WriteLine(ERROR_MESSAGE)

            End Try

        End While

        ' Pause program to view output.
        Return UserResponse
    End Function

    ''' <summary>
    ''' Generate token biased towards house
    ''' </summary>
    Function GetToken() As String
        Randomize()
        Dim tokens = {"Horse", "Horse", "Horse", "Zebra", "Zebra", "Zebra", "Donkey", "Donkey", "Donkey", "Unicorn"}
        Static rand As Random = New Random()
        Dim index As Integer = rand.Next(0, 10)
        Return tokens(index)
    End Function

    Public Sub Payout()

        'Payout()
        'House Keeping
        Dim Total As Double = 10.0 
        Dim Token As String = ""
        Dim Feedback As String = ""
        Dim KeepGoing = ""

        Console.WriteLine("How much would you like to play with?")
        Total = IntegerCheck(1, 10)
        Console.WriteLine("Press <Enter> to play")
        Console.ReadLine()


        While KeepGoing = ""


            'Input a token manually
            'Console.WriteLine("Please enter a token.")
            'Token = Console.ReadLine()
            Token = GetToken()

            'Adjust total based on token
            If Token = "Unicorn" Then
                Total += 4
                Feedback = "Congratulations! You won $5.00."

            ElseIf Token = "Donkey" Then
                Total -= 1
                Feedback = "Sorry, You didn't win anything this round."

            Else
                Total -= 0.5
                Feedback = "Congratulations! You won 50 cents."

            End If

            'Display winnings 
            Console.WriteLine(Feedback)

            'Display New Winnings
            Console.WriteLine(String.Format("You have ${0} to play with", Total.ToString("##0.00")))
            Console.WriteLine()

            If Total < 1 Then
                Console.WriteLine("Sorry, you don't have enough money to countinue")
                KeepGoing = "END"
            Else
                Console.WriteLine("Please <ENTER> key to play again or any key to quit followed by enter to quit")
                KeepGoing = Console.ReadLine()
            End If

        End While
        Console.WriteLine("Thanks for Playing press <ENTER> to exit")
        Console.ReadLine()

    End Sub
End Module