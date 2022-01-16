Public Class Form1
    Dim totalGuess As Integer = 0
    Dim correctGuess As Integer = 0
    Dim guessLimit As Integer
    Dim randomAnswer As Integer
    Dim randomNumber As Integer = 0
    Dim guessPercent As Double
    Dim randGen As New Random(Now.Millisecond)

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles GuessTextBox.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckMyGuessButton.Enabled = False
    End Sub

    Private Sub NewGameButton_Click(sender As Object, e As EventArgs) Handles NewGameButton.Click

        Dim number As Integer
        number = randGen.Next(1, 11)
        randomNumber = number
        CheckMyGuessButton.Enabled = True
        guessLimit = 0
        RandomTextBox.Text = randomNumber.ToString

    End Sub
    Private Sub CheckMyGuessButton_Click(sender As Object, e As EventArgs) Handles CheckMyGuessButton.Click

        guessLimit += 1
        totalGuess += 1

        Single.TryParse(GuessTextBox.Text, randomAnswer)

        If randomAnswer > 10 Or randomAnswer < 1 Then
            MessageBox.Show("Sorry!!! Enter a number between 1 and 10. " & Environment.NewLine & "    Click the Check My Guess button.")

        End If


        If randomAnswer = randomNumber Then
            MessageBox.Show("Correct!!! :)")
            correctGuess += 1
            CheckMyGuessButton.Enabled = False
            GuessTextBox.Text = String.Empty

        ElseIf randomAnswer > 0 And randomAnswer < 11 Then
            MessageBox.Show("Wrong!!!  :( " & Environment.NewLine & "Please Try Again")
            GuessTextBox.Text = String.Empty





            If guessLimit = 5 Then
                MessageBox.Show("Sorry! You have used all 5 chances, start a new game")
                CheckMyGuessButton.Enabled = False
            End If

        End If


    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        guessPercent = (correctGuess / totalGuess) * 100
        MessageBox.Show("You have " & correctGuess & " correct guesses, Out of a total of " & totalGuess & " guesses" & Environment.NewLine & " For a win percentage of " & guessPercent & "%" & Environment.NewLine & " Please play again :)")
        Me.Close()


    End Sub

    Private Sub RandomTextBox_TextChanged(sender As Object, e As EventArgs) Handles RandomTextBox.TextChanged

    End Sub
End Class
