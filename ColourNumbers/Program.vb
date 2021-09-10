Imports System.Console

Module Program
    
    'DIMENSIONS'
    '----------'
    
    Dim name As String 'Name of user 
    Dim age As Integer  'Age of user 
    Dim feeling As String 'How the user feels
    Dim NumberCount As Integer 'The current number the program is counting 
    Dim MaxNumber As Integer 'The maximum number the program will count up to
    Dim CurrentColour As Integer 'The current colour of the foreground 
    
         Sub Main(args As String())
             WriteLine("Hello! What's your name?")
             name = ReadLine()
             WriteLine("How old are you, " & name & " ?")
             age = ReadLine()
             WriteLine("How are you today then, " & name & " ?")
             feeling = ReadLine()
             WriteLine("I'm feeling " & feeling & " too!") 'Prints "I'm feeling arg1 too!"
             
             '------------------'
             'COUNTING & COLOURS'
             '------------------'
             
             CurrentColour = 0 'Sets the current colour to 0, so that the program always starts on the same colour.
             NumberCount = 1 'Makes the script start counting from 0
             
             WriteLine("How high do you want me to count?")
             MaxNumber = ReadLine()
             
             For NumberCount = 1 To MaxNumber
                 ForegroundColor = CurrentColour
                 WriteLine(NumberCount)
                 CurrentColour = CurrentColour + 1
                 If CurrentColour = 15 Then 'If the current colour has reached the max (16) then set it back to 0 to avoid crashing 
                     CurrentColour = 0
                 End If
             Next
         WriteLine("Done!")
         End Sub
End Module
