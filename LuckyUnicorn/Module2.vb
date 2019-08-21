Module Module2
    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 1
    '''     Generate a random token from a list and display it to user
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping
        For counter As Integer = 1 To 15
            Dim token As String = GetToken()
            Console.WriteLine(token)
        Next counter

        Console.ReadLine()

    End Sub

    Function GetToken() As String
        Randomize()
        Dim tokens = {"Horse", "Zebra", "Donkey", "Unicorn"}
        Static rand As Random = New Random()
        Dim index As Integer = rand.Next(0, 4)

        Return tokens(index)
    End Function
End Module

