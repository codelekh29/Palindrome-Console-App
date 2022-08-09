Imports System

Module program
    Sub main(args As String())

        Dim inputWord As String
        Dim input As String
        Dim word As String
        Console.WriteLine("Type a Word: ")
        word = Console.ReadLine()
        inputWord = UCase(word)
        input = StrReverse(UCase(inputWord))

        If input.Equals(inputWord) Then
            Console.WriteLine("This is a Palindrome")
        Else
            Console.WriteLine("This Is  NOT a Palindrome")
        End If
    End Sub
End Module
