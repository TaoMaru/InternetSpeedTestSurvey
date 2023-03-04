Public Class frmSpeed
    ' Program Name: Internet Speed Test Survey
    ' Developer: Maria Jackson
    ' Date: March 4, 2023
    ' Purpose: This program allows the user to enter up to 10 internet speeds at a time
    ''          The program calculates the average speed from the entries received &
    ''          Displays the average to the user.
    ''          The user may clear all input to reset their entry and average at any time

    Private Sub frmSpeed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide lblAverage & enable btnSpeed on load
        lblAverage.Visible = False
        btnSpeed.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' resets item list in lstSpeeds, hide lblAverage, & enable btnSpeed
        lstSpeeds.Items.Clear()
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
        Dim strIBoxMsg As String = "Please enter the your home Internet Speed in Mbps: #"
        Dim strIBoxEnding As String = vbCrLf & "Click Cancel when done!"
        Dim strIBoxTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error. Please enter your home Internet Speed in Mbps:"
        Dim strNegErrMsg As String = "Error. Please enter speeds as a positive number of Mbps:"

        'Loop variables:
        Dim intMaxEntries As Integer = 10
        Dim intNumEntries As Integer = 1

        'Initialize input box with instruction msg, numEntries, and the boxTitle
        strSpeed = InputBox(strIBoxMsg & intNumEntries & strIBoxEnding, strIBoxTitle)

        'Get user input until max of 10 entries or user clicks OK or Cancel
        Do Until intNumEntries > intMaxEntries Or strSpeed.Equals("")
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed > 0 Then
                    'valid input received
                    lstSpeeds.Items.Add(strSpeed) 'add speed to list
                    decSumOfSpeeds += decSpeed    'add speed to sum
                    intNumEntries += 1            'increment numEntries
                    strIBoxMsg = strIBoxMsg       'set instruction msg
                Else
                    ' input negative, set msg to negative error msg
                    strIBoxMsg = strNegErrMsg
                End If
            Else
                ' input not numeric, set msg to not a number error msg
                strIBoxMsg = strNotNumericErrMsg
            End If
            'get new speed input:
            If intNumEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMsg & intNumEntries & strIBoxEnding, strIBoxTitle)
            End If
        Loop

        'calculate average
        If intNumEntries > 1 Then
            decAverage = decSumOfSpeeds / (intNumEntries - 1)
            lblAverage.Text = "Average Internet Speed: " & decAverage.ToString("F2")
        Else
            ' no entries were input, display no speeds msg
            lblAverage.Text = "No Speeds Entered"
        End If

        lblAverage.Visible = True 'show average
        btnSpeed.Enabled = False  'disable speed btn

    End Sub
End Class
