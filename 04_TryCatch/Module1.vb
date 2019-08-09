''' <summary>
'''     This program asks the user for a number until they enter a number between 1 and 10.
''' </summary>
''' <author> Mr M </author>
''' <date> 13Jun19 </date>
Module Module1

    Sub Main()
        'Housekeeping
        Dim UserResponse As Integer
        Const ERROR_MESSAGE As String = "Please enter an integer"
        Dim ValidInput As Boolean = False

        While Not ValidInput

            Try
                ' Ask user for a number and store it.
                Console.WriteLine("Please enter an integer between 1 and 10.")
                UserResponse = Console.ReadLine()

                If 1 <= UserResponse And UserResponse <= 10 Then
                    ValidInput = True
                End If

            Catch ex As Exception
                Console.WriteLine(ERROR_MESSAGE)
                Console.ReadLine()

            End Try
        End While

        ' Pause the program to view output.
        Dim Output As String = String.Format("You have entered the number {0}.", UserResponse.ToString)
            Console.WriteLine(Output)
            Console.ReadLine()


    End Sub

End Module
