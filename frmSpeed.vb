Public Class frmSpeed
    ' Program Name: Internet Speed Test Survey
    ' Developer: Maria Jackson
    ' Date: March 4, 2023
    ' Purpose: This program allows the user to enter up to 10 internet speeds at a time
    ''          The program calculates the average speed from the entries received &
    ''          Displays the average to the user.
    ''          The user may clear all input to reset their entry and average at any time

    Private Sub frmSpeed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide lblAverage on load
        lblAverage.Visible = False
        lstSpeeds.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSpeeds.Text = ""
        lblAverage.Visible = False
        btnSpeed.Enabled = True
    End Sub

    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        ' Initializes input box, takes & validates user input for up to 10 internet speeds
        ' Calculates average speed, and exits input box when user selects ok, cancel, or
        '  when the max input amount is reached

        'Speed variables:
        Dim strSpeed As String          'speed entered
        Dim decSpeed As Decimal         'speed converted to decimal
        Dim decSumOfSpeeds As Decimal   'sum of all speeds entered
        Dim decAverage As Decimal = 0D  'average of speeds

        'input box variables: intructions & err msgs:
        Dim strBoxMsg As String = "Please enter the your home Internet Speed in Mbps:"
        Dim strBoxTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error. Please enter your home Internet Speed in Mbps:"
        Dim strNegErrMsg As String = "Error. Please enter speeds as a positive number of Mbps:"

        'Loop variables:
        Dim intMaxEntries As Integer = 10
        Dim intNumEntries As Integer = 1

        'Initialize input box with instruction msg, numEntries, and the boxTitle
        strSpeed = InputBox(strBoxMsg & intNumEntries, strBoxTitle)


    End Sub
End Class
