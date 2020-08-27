Public Class CalculatorForm

    Private Sub CalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        Dim result As MsgBoxResult

        result = MsgBox("Are you sure? All data will be lost.", vbOKCancel)
        If result = MsgBoxResult.Ok Then
            Me.Close()
        Else
        End If

    End Sub

    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        OutputListBox.Items.Add(InputTextBox.Text)
        InputTextBox.Clear()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        InputTextBox.Clear()
    End Sub

    Private Sub OneButton_Click(sender As Object, e As EventArgs) Handles OneButton.Click
        InputTextBox.AppendText(1)
    End Sub

    Private Sub TwoButton_Click(sender As Object, e As EventArgs) Handles TwoButton.Click
        InputTextBox.AppendText(2)
    End Sub

    Private Sub ThreeButton_Click(sender As Object, e As EventArgs) Handles ThreeButton.Click
        InputTextBox.AppendText(3)
    End Sub

    Private Sub FourButton_Click(sender As Object, e As EventArgs) Handles FourButton.Click
        InputTextBox.AppendText(4)
    End Sub

    Private Sub FiveButton_Click(sender As Object, e As EventArgs) Handles FiveButton.Click
        InputTextBox.AppendText(5)
    End Sub

    Private Sub SixButton_Click(sender As Object, e As EventArgs) Handles SixButton.Click
        InputTextBox.AppendText(6)
    End Sub

    Private Sub SevenButton_Click(sender As Object, e As EventArgs) Handles SevenButton.Click
        InputTextBox.AppendText(7)
    End Sub

    Private Sub EightButton_Click(sender As Object, e As EventArgs) Handles EightButton.Click
        InputTextBox.AppendText(8)
    End Sub

    Private Sub NineButton_Click(sender As Object, e As EventArgs) Handles NineButton.Click
        InputTextBox.AppendText(9)
    End Sub

    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles ZeroButton.Click
        InputTextBox.AppendText(0)
    End Sub

    Private Sub AdditionButton_Click(sender As Object, e As EventArgs) Handles AdditionButton.Click
        InputTextBox.AppendText("+")
    End Sub

    Private Sub SubtractButton_Click(sender As Object, e As EventArgs) Handles SubtractButton.Click
        InputTextBox.AppendText("-")
    End Sub

    Private Sub MultiplicationButton_Click(sender As Object, e As EventArgs) Handles MultiplicationButton.Click
        InputTextBox.AppendText("*")
    End Sub

    Private Sub DivisionButton_Click(sender As Object, e As EventArgs) Handles DivisionButton.Click
        InputTextBox.AppendText("/")
    End Sub

    Private Sub ExponentButton_Click(sender As Object, e As EventArgs) Handles ExponentButton.Click
        InputTextBox.AppendText("^")
    End Sub

End Class
