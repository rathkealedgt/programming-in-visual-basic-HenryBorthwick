Module Module4


    Public Sub Payout()
        'House Keeping
        Dim Total As Double = 10.0 'Assume starting amount is 10
        Dim Token As String = ""
        Dim Feedback As String = ""
        Dim KeepGoing = ""

        Console.WriteLine("How much would you like to play with?")
        Total = Console.ReadLine()

        While KeepGoing = ""


            'Input a token manually
            Console.WriteLine("Please enter a token.")
        Token = Console.ReadLine()

        'Adjust total based on token
        If Token = "Unicorn" Then
            Total += 5
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
        Console.WriteLine("Thanks for Playing")
        Console.ReadLine()

    End Sub

End Module

