Module Module25
    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 1
    '''     Generate a random token from a list and display it to user
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping
        Const How_MUCH As Integer = 100
        Dim CounterUnicorn As Integer = 0
        Dim CounterDonkey As Integer = 0
        Dim CounterZebHor As Integer = 0

        For counter As Integer = 1 To How_MUCH
            Dim token As String = GetToken()

            If token = "Unicorn" Then
                CounterUnicorn += 1
            ElseIf token = "Donkey" Then
                CounterDonkey += 1
            Else
                CounterZebHor += 1

            End If
            Console.WriteLine(token)

        Next counter

        Console.WriteLine(vbNewLine & "**** Win/Loss Calculations ****")
        Console.WriteLine(String.Format(" Unicorns = {0}", CounterUnicorn))
        Console.WriteLine(String.Format(" Zebra/Hourse = {0}", CounterZebHor))
        Console.WriteLine(String.Format(" Donkeys = {0}", CounterDonkey))
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

