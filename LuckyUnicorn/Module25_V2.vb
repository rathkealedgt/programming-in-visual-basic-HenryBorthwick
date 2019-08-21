Module Module25_V2
    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 1
    '''     Generate a random token from a list and display it to user
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping
        Const How_MUCH As Integer = 100 'Start Amount
        Dim CounterUnicorn As Integer = 0
        Dim CounterDonkey As Integer = 0
        Dim CounterZebHor As Integer = 0

        'Counting System
        For counter As Integer = 1 To How_MUCH
            Dim token As String = GetToken()
            'Add One to each Counter
            If token = "Unicorn" Then
                CounterUnicorn += 1
            ElseIf token = "Donkey" Then
                CounterDonkey += 1
            Else
                CounterZebHor += 1

            End If
            Console.WriteLine(token)

        Next counter


        'Calculate the winnings
        Dim Winnings As Double = CounterUnicorn * 5 + (CounterZebHor * 0.5)
        Console.WriteLine(vbNewLine & String.Format("You Spent ${0}", How_MUCH.ToString("##.0.00")))
        Console.WriteLine("You go home with ${0}", Winnings)

        'End Counter display
        Console.WriteLine(vbNewLine & "**** Win/Loss Calculations ****")
        Console.WriteLine(String.Format(" Unicorns = {0}", CounterUnicorn))
        Console.WriteLine(String.Format(" Zebra/Hourse = {0}", CounterZebHor))
        Console.WriteLine(String.Format(" Donkeys = {0}", CounterDonkey))
        Console.ReadLine()

    End Sub

    Function GetToken() As String
        Randomize()
        Dim tokens = {"Horse", "Horse", "Horse", "Zebra", "Zebra", "Zebra", "Donkey", "Donkey", "Donkey", "Unicorn"}
        Static rand As Random = New Random()
        Dim index As Integer = rand.Next(0, 10)

        Return tokens(index)
    End Function
End Module

