Public Class If_Demo
    Private Sub btnChek_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'Declare a variable and get the name from the text box
        Dim strName As String
        strName = txtName.Text
        'Is the name Wendy?
        If strName <> "Wendy" Then
            MessageBox.Show("The name is *not* Wendy.", "If Demo")
        End If
    End Sub

    Private Sub btnChekNumbers_Click(sender As Object, e As EventArgs) Handles btnChekNumbers.Click
        'Declare variable
        Dim intNumber As Integer
        Try
            'Get the number from the text box
            intNumber = CType(txtValue.Text, Integer)
        Catch
            Exit Sub
        End Try
        'Is intNumber less than 27?
        If intNumber < 27 Then
            MessageBox.Show("Is 'intNumber' less than 27? Yes!", "If Demo")
        Else
            MessageBox.Show("Is 'intNumber' less than 27? No!", "If Demo")
        End If
    End Sub

    Private Sub btnCheckNumbers1_Click(sender As Object, e As EventArgs) Handles btnCheckNumbers1.Click
        Dim intNumber As Integer
        Try
            'Get the number from the text box
            intNumber = CType(txtValue.Text, Integer)
        Catch
            Exit Sub
        End Try
        'Is intNumber less than or equal to 27?
        If intNumber <= 27 Then
            MessageBox.Show("Is 'intNumber' less than or equal to 27? Yes!",
"If Demo")
        Else
            MessageBox.Show("Is 'intNumber' less than or equal to 27? No!",
"If Demo")
        End If
    End Sub

    Private Sub btnCheckNumbers2_Click(sender As Object, e As EventArgs) Handles btnCheckNumbers2.Click
        Dim intNumber As Integer
        Try
            'Get the number from the text box
            intNumber = CType(txtValue.Text, Integer)
        Catch
            Exit Sub
        End Try
        'Is intNumber less than or equal to 27?
        If intNumber <= 27 Then
            MessageBox.Show("Is 'intNumber' less than or equal to 27? Yes!",
"If Demo")
        Else
            MessageBox.Show("Is 'intNumber' less than or equal to 27? No!",
"If Demo")
        End If
        'Is intNumber less than or equal to 27?
        If intNumber <= 27 Then
            MessageBox.Show("Is 'intNumber' less than or equal to 27? Yes!",
"If Demo")
        Else
            MessageBox.Show("Is 'intNumber' less than or equal to 27? No!",
"If Demo")
        End If
        'Is intNumber greater than 27?
        If intNumber > 27 Then
            MessageBox.Show("Is 'intNumber' greater than 27? Yes!",
"If Demo")
        Else
            MessageBox.Show("Is 'intNumber' greater than 27? No!",
"If Demo")
        End If
        'Is intNumber greater than or equal to 27?
        If intNumber >= 27 Then
            MessageBox.Show("Is 'intNumber' greater than or equal to 27?
Yes!",
"If Demo")
        Else
            MessageBox.Show("Is 'intNumber' greater than or equal to 27?
No!",
"If Demo")
        End If
    End Sub
End Class