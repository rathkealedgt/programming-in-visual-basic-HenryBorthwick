Module Module1
    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 1
    '''     Get initial amount from user and check that it is valid.
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        'Housekeeping
        'Dim HowMuch As Integer

        'Console.WriteLine("Please enter how much money you would like to play with?")
        'HowMuch = IntegerCheck(1, 10)
        'Console.ReadLine()

        'For counter As Integer = 1 To 5
        LuckeyUnicornV_2.Main()


        'Next counter


    End Sub

        ''' <summary>
        '''     Integer checking function. Checks if user input is an integer between the values given.
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

    End Module


