Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decSpeed As Decimal
        Dim decNumOfHours As Decimal
        Dim decDistanceTravelled As Decimal
        Dim intSpeed As Integer
        Dim intNumOfHours As Integer
        Dim intDistanceTravelled As Integer

        decSpeed = InputBox("Please enter speed limit", "Vehicle Speed")
        decNumOfHours = InputBox("Please enter number of hours you travelled", "Hours Traveled")
        intSpeed = CInt(decSpeed)
        intNumOfHours = CInt(decNumOfHours)

        If intSpeed > 0 Then
            decDistanceTravelled = decSpeed * decNumOfHours
            intDistanceTravelled = CInt(decDistanceTravelled)
            lstOutput.Items.Add(" Vehicle speed: " & decSpeed & " MPH")
            lstOutput.Items.Add(" Time traveled: " & decNumOfHours & " hours")
            lstOutput.Items.Add(" Hours   Distance Traveled")
            lstOutput.Items.Add(" ----------------------------------------")

            For intCount = 1 To intNumOfHours
                intDistanceTravelled = intCount * intSpeed
                lstOutput.Items.Add("  " & intCount & vbTab & intDistanceTravelled)
            Next intCount
            lstOutput.Items.Add(" Total Distance:" & intDistanceTravelled)

        Else
            MessageBox.Show("Please enter a number greater than zero.")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
