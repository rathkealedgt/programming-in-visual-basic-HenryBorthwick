''' <summary>
'''     This exercise will introduce you to if statements and while loops.
''' </summary>
''' <author> Mr Macri </author>
''' <date> 13Jun19 </date>
''' 
Module Module1

    Sub Main()
        ' Housekeeping
        Dim UserResponse As String
        Dim KeepGoing As String = ""


        While KeepGoing = ""
            ' Ask user if they like coffee and record their answer.
            Console.WriteLine("Do you like coffee?")
        UserResponse = Console.ReadLine().ToLower()

        ' Check input and respond
        If UserResponse = "yes" Or UserResponse = "y" Then
            Console.WriteLine("I like coffee too!")
        ElseIf (UserResponse = "no") Or UserResponse = "n" Then
                Console.WriteLine("You're not alone")
            Else
            Console.WriteLine("I Don't Understand")
        End If


            ' Pause program to let the user read 
            Console.WriteLine("Press q followed by <Enter> to quit")
            KeepGoing = Console.ReadLine()
        End While
    End Sub

End Module
