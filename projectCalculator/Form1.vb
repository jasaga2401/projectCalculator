Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Declare variables
        Dim num1 As Integer = txtNumber1.Text
        Dim num2 As Integer = txtNumber2.Text

        Dim result As Integer = 0

        ' Calculate the result
        result = num1 + num2

        ' Display the result
        MessageBox.Show("The result is: " & result)


    End Sub
End Class
