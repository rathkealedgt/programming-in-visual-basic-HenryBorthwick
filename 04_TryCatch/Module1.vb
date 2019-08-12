''' <summary>
'''     This program asks the user for a number until they enter a number between 1 and 10.
''' </summary>
''' <author> Mr M </author>
''' <date> 13Jun19 </date>
Module Module1

    Sub Main()
        'House Keeping
        Dim UserResponse As Integer

        UserResponse = IntegerCheek(1, 5)
        Console.WriteLine("You entered the vaild number {0}.", UserResponse)

        UserResponse = IntegerCheek(20, 40)
        Console.WriteLine("You entered the vaild number {0}.", UserResponse)

        Console.ReadLine()

    End Sub

    Function IntegerCheek(LowNumber As Integer, HighNumber As Integer) As Integer
        'Housekeeping
        Dim UserResponse As Integer
        Const ERROR_MESSAGE As String = "Please enter an integer"
        Dim ValidInput As Boolean = False
        Dim OUTPUT_MESSAGE As String = String.Format("Please enter an integer between {0} and {1}.", LowNumber, HighNumber)

        While Not ValidInput

            Try
                ' Ask user for a number and store it.
                Console.WriteLine(OUTPUT_MESSAGE)
                UserResponse = Console.ReadLine()

                If LowNumber <= UserResponse And UserResponse <= HighNumber Then
                    ValidInput = True
                End If

            Catch ex As Exception
                Console.WriteLine(ERROR_MESSAGE)


            End Try
        End While

        'Pause program to view response
        Return UserResponse

    End Function
End Module
