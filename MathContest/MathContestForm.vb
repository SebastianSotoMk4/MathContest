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
    Function Calculation(ByVal firstNumber As Integer, ByVal secondNumber As Integer, ByVal mathSymbol As String) As Integer
        Dim answer As Integer
        firstNumber = RandomNumber(100)
        secondNumber = RandomNumber(100)
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

        If NameTextBox.Text <> "" And AgeTextBox.Text <> "" And GradeTextBox.Text <> "" Then
            SubmitButton.Enabled = True
            MathProblemGroupBox.Enabled = True
            MathProblemTypeBox.Enabled = True
        Else
            SubmitButton.Enabled = False
            MathProblemGroupBox.Enabled = False
            MathProblemTypeBox.Enabled = False
        End If
    End Sub
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged, SubtractRadioButton.CheckedChanged, MultiplyRadioButton.CheckedChanged, DivideRadioButton.CheckedChanged
        'Calculation(1, 2, "a:")
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim answer As Integer
        Dim userAnswer As String

        'firstNumber = RandomNumber(3)
        'secondNumber = RandomNumber(3)
        'FirstNumberTextBox.Text = CStr(firstNumber)
        'SecondNumberTextBox.Text = CStr(secondNumber)
        If SubtractRadioButton.Checked = True Then
            answer = firstNumber - secondNumber

        End If
        CheckAnswer(answer, userAnswer, " ")

        'userAnswer = StudentAnswerTextBox.Text
        'If userAnswer = CStr(answer) Then
        '    MsgBox("gg")
        'End If
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
        CheckAnswer()
    End Sub
End Class
