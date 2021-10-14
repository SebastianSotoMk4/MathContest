'Sebastian Soto
'RCET0265
'Fall 2021
'Math Contest Form
'
Option Strict On
Option Explicit On
Public Class MathContestForm
    Sub SetDefaults()
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        SubmitButton.Enabled = False
        AddRadioButton.Checked = True
        'AddRadioButton.Checked = True
        MathProblemGroupBox.Enabled = False
        MathProblemTypeBox.Enabled = False

    End Sub
    Function Number() As String
        Dim num As Integer
        Dim returnNumber As String
        num = RandomNumber(10)
        returnNumber = CStr(num)
        Return returnNumber
    End Function
    Function Calculation(ByVal firstNumber As Integer, ByVal secondNumber As Integer, ByVal mathSymbol As String) As Integer
        Dim answer As Integer
        firstNumber = RandomNumber(10)
        secondNumber = RandomNumber(10)
        FirstNumberTextBox.Text = CStr(firstNumber)
        SecondNumberTextBox.Text = CStr(secondNumber)
        Return answer
    End Function
    Function CheckAnswer(ByRef answer As Integer, ByRef userAnswer As String, ByRef mesage As String) As String
        userAnswer = StudentAnswerTextBox.Text

        If userAnswer = CStr(answer) Then
            mesage = "Goood joshe"

        End If

        MsgBox("gg")
        Return mesage
    End Function
    Function RandomNumber(max As Integer) As Integer
        Dim rndNum As Double
        Dim NumRnd As Integer
        Randomize(Now.Millisecond)
        rndNum = System.Math.Floor(CDbl(Rnd() * (max)))
        NumRnd = CInt(rndNum)
        Return NumRnd
    End Function
    Sub CheckName()
        Dim ageOkay As Boolean
        Dim gradeCheck As Boolean
        Select Case AgeTextBox.Text
            Case = "7"
                ageOkay = True
            Case = "8"
                ageOkay = True
            Case = "9"
                ageOkay = True
            Case = "10"
                ageOkay = True
            Case = "11"
                ageOkay = True
        End Select
        Select Case GradeTextBox.Text
            Case = "1"
                gradeCheck = True
            Case = "2"
                gradeCheck = True
            Case = "3"
                gradeCheck = True
            Case = "4"
                gradeCheck = True
        End Select
        If NameTextBox.Text <> "" And ageOkay = True And gradeCheck = True Then
            SubmitButton.Enabled = True
            MathProblemGroupBox.Enabled = True
            MathProblemTypeBox.Enabled = True
            Calculation(1, 1, "")
        Else
            SubmitButton.Enabled = False
            MathProblemGroupBox.Enabled = False
            MathProblemTypeBox.Enabled = False
            FirstNumberTextBox.Text = ""
            SecondNumberTextBox.Text = ""
        End If
    End Sub
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        'Calculation(1, 2, "a:")
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim answer As Integer
        Dim userAnswer As String

        firstNumber = RandomNumber(3)
        secondNumber = RandomNumber(3)
        answer = firstNumber + secondNumber

        FirstNumberTextBox.Text = CStr(firstNumber)
        SecondNumberTextBox.Text = CStr(secondNumber)
        userAnswer = StudentAnswerTextBox.Text

        If StudentAnswerTextBox.Text = CStr(answer) Then
            MsgBox("GG")

        End If

        If SubtractRadioButton.Checked = True Then
            answer = firstNumber - secondNumber

        End If
    End Sub
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'On start up the add button is checked to prevent floating inputs
        SetDefaults()

    End Sub
    Private Sub NameTextBox_LostFocus(sender As Object, e As EventArgs) Handles NameTextBox.LostFocus, AgeTextBox.LostFocus, GradeTextBox.LostFocus
        CheckName()
    End Sub
    Private Sub NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameTextBox.KeyPress, AgeTextBox.KeyPress, GradeTextBox.KeyPress
        CheckName()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'CheckAnswer()
    End Sub

    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged

    End Sub
End Class
