'Sebastian Soto
'RCET0265
'Fall 2021
'Math Contest Form
'https://github.com/SebastianSotoMk4/MathContest.git
Option Strict On
Option Explicit On
Public Class MathContestForm
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
            AddRadioButton.Checked = True
        Else
            SubmitButton.Enabled = False
            SummeryButton.Enabled = False
            MathProblemGroupBox.Enabled = False
            MathProblemTypeBox.Enabled = False
            FirstNumberTextBox.Text = ""
            SecondNumberTextBox.Text = ""
            If ageOkay = False And gradeCheck = False Then
                MsgBox("Student not elegible to compete, must be in grades 1 to 4 and age 7 to 11.")
                AgeTextBox.Text = ""
                GradeTextBox.Text = ""
                AgeTextBox.Select()


            ElseIf gradeCheck = False Then
                MsgBox("Student not eligible to compete, must be in grades 1 to 4.")
                GradeTextBox.Text = ""
                GradeTextBox.Select()

            ElseIf ageOkay = False Then
                MsgBox("Student not eligible to compete, Age Must be 7 to 11 years old.")
                AgeTextBox.Text = ""
                AgeTextBox.Select()

            End If
        End If
    End Sub
    Sub SetDefaults()
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        SubmitButton.Enabled = False
        'AddRadioButton.Checked = True
        MathProblemGroupBox.Enabled = False
        MathProblemTypeBox.Enabled = False

    End Sub
    Sub RunCalculation()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim answer As Integer
        Dim studentAnswer As String
        firstNumber = RandomNumber(10)
        secondNumber = RandomNumber(10)

        If AddRadioButton.Checked = True Then
            answer = firstNumber + secondNumber
        ElseIf SubtractRadioButton.Checked = True Then
            answer = firstNumber - secondNumber
        ElseIf MultiplyRadioButton.Checked = True Then
            answer = firstNumber * secondNumber
        ElseIf DivideRadioButton.Checked = True Then
            answer = firstNumber \ secondNumber
        End If
        FirstNumberTextBox.Text = CStr(firstNumber)
        SecondNumberTextBox.Text = CStr(secondNumber)
        studentAnswer = StudentAnswerTextBox.Text
    End Sub
    Function RandomNumber(max As Integer) As Integer
        Dim rndNum As Double
        Dim NumRnd As Integer

        Randomize(Now.Millisecond)
        rndNum = System.Math.Floor(CDbl(Rnd() * (max)))
        NumRnd = CInt(rndNum) + 1
        Return NumRnd
    End Function
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub AgeTextBox_LostFocus(sender As Object, e As EventArgs) Handles AgeTextBox.LostFocus, GradeTextBox.LostFocus, NameTextBox.LostFocus
        If NameTextBox.Text <> "" And AgeTextBox.Text <> "" And GradeTextBox.Text <> "" Then
            CheckName()
        End If
    End Sub
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'On start up the add button is checked to prevent floating inputs
        SetDefaults()

    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim answer As Integer
        Dim studentAnswer As String

        firstNumber = CInt(FirstNumberTextBox.Text)
        secondNumber = CInt(SecondNumberTextBox.Text)
        If AddRadioButton.Checked = True Then
            answer = firstNumber + secondNumber
        ElseIf SubtractRadioButton.Checked = True Then
            answer = firstNumber - secondNumber
        ElseIf MultiplyRadioButton.Checked = True Then
            answer = firstNumber * secondNumber
        ElseIf DivideRadioButton.Checked = True Then
            answer = firstNumber \ secondNumber
        End If
        studentAnswer = StudentAnswerTextBox.Text
        If CStr(answer) = studentAnswer Then
            MsgBox("Congratulations")
            RunCalculation()
            CorrectCount += 1
            StudentAnswerTextBox.Text = ""

        ElseIf CStr(answer) <> studentAnswer Then
            MsgBox($"Incorect the answer was {answer}")
            RunCalculation()
            IncorrectCount += 1
            StudentAnswerTextBox.Text = ""
        End If
    End Sub
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged, DivideRadioButton.CheckedChanged, SubtractRadioButton.CheckedChanged, MultiplyRadioButton.CheckedChanged
        RunCalculation()
    End Sub
    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        MsgBox($"{CorrectCount} were correct and {IncorrectCount} were incorrect")
    End Sub

    Private CorrectCount As Integer
    Private IncorrectCount As Integer
End Class