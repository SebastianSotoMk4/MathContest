'Sebastian Soto
'RCET0265
'Fall 2021
'Math Contest Form
'
Option Strict On
Option Explicit On
Public Class MathContestForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles FirstNumberLabel.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged

    End Sub

    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'On start up the add button is checked to prevent floating inputs
        AddRadioButton.Checked = True
    End Sub
End Class
