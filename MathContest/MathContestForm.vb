'Sebastian Soto
'RCET0265
'Fall 2021
'Math Contest Form
'
Option Strict On
Option Explicit On
Public Class MathContestForm
    Sub SetDefaults()
        AddRadioButton.Checked = True
        ' MathProblemGroupBox.Enabled = False
        ' MathProblemTypeBox.Enabled = False
        AddRadioButton.Checked = True
        SecondNumberTextBox.Text = " "
        StudentAnswerTextBox.Text = " "
        FirstNumberTextBox.Text = " "
        NameTextBox.Text = " "
        AgeTextBox.Text = " "
        GradeTextBox.Text = " "

    End Sub
    Sub CheckName()
        'Dim nameCheck As Boolean
        'Dim ageCheck As Boolean
        'Dim gradeCheck As Boolean

        If NameTextBox.Text <> "" And AgeTextBox.Text <> "" And GradeTextBox.Text <> "" Then
            SubmitButton.Enabled = True
            MathProblemGroupBox.Enabled = True
            MathProblemTypeBox.Enabled = True
        Else
            SubmitButton.Enabled = False
            MathProblemGroupBox.Enabled = False
            MathProblemTypeBox.Enabled = False
        End If
        'If AgeTextBox.Text <> "" Then
        '    ageCheck = True
        'End If
        'If GradeTextBox.Text <> "" Then
        '    gradeCheck = True
        'End If
        'If nameCheck And ageCheck And gradeCheck = True Then
        '   
        'End If
    End Sub
    Private Sub NameTextBox_LostFocus(sender As Object, e As EventArgs) Handles NameTextBox.LostFocus, AgeTextBox.LostFocus, GradeTextBox.LostFocus
        CheckName()
    End Sub
    Private Sub NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameTextBox.KeyPress, AgeTextBox.KeyPress, GradeTextBox.KeyPress
        CheckName()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles FirstNumberLabel.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles FirstNumberTextBox.TextChanged

        'FisrtNumberTextBox = RandomNumber(20)
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles SecondNumberTextBox.TextChanged

    End Sub

    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged

    End Sub

    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'On start up the add button is checked to prevent floating inputs
        SetDefaults()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Function RandomNumber(max As Integer) As Integer
        Dim rndNum As Double
        Dim NumRnd As Integer
        Randomize(Now.Millisecond)
        rndNum = System.Math.Floor(CDbl(Rnd() * (max)))
        NumRnd = CInt(rndNum)
        Return NumRnd
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub


End Class
