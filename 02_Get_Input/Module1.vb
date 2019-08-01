Module Module1
    ''' <summary>
    '''     This program will show you how to get input from the user.
    ''' </summary>
    ''' <author> Mr Macri </author>
    ''' <date> 10Jun19 </date>
    ''' 
    Sub Main()
        ' Housekeeping
        Dim UserName, OutputMessage As String
        Dim FirstNumber, SecondNumber, Sum, Product, SubtractedValue As Integer

        ' Ask for user name
        Console.WriteLine("Please enter your name here")
        UserName = Console.ReadLine()
        Console.WriteLine(StrReverse(UserName))

        ' Ask user for two numbers
        Console.WriteLine("Please enter your favorite number")
        FirstNumber = Console.ReadLine()

        Console.WriteLine("Please enter your second favorite number")
        SecondNumber = Console.ReadLine()

        ' Add numbers together
        Sum = FirstNumber + SecondNumber

        ' Multiply numbers together
        Product = FirstNumber * SecondNumber

        'Subtract numbers
        SubtractedValue = FirstNumber - SecondNumber

        ' Greet user and display maths
        OutputMessage = String.Format("Hello, {0}.  The sum of your number is {1}.  The product of your number is {2}.  And the subtracted value is {3}.", UserName, Sum, Product, SubtractedValue)
        Console.WriteLine(OutputMessage)

        Console.ReadLine()

    End Sub

End Module
