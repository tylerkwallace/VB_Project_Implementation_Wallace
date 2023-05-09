Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If radWeekly.Checked Then
            Dim expensesStr As String = MaskedTextBox1.Text
            Dim expensesArr As String() = expensesStr.Split(","c)

            If expensesArr.Length <> 4 Then
                MessageBox.Show("Please enter exactly 4 numbers separated by commas.")
                Return
            End If

            Dim expenses As New List(Of Double)
            For Each expenseStr As String In expensesArr
                Dim expense As Double
                If Double.TryParse(expenseStr, expense) Then
                    expenses.Add(expense)
                Else
                    MessageBox.Show("Please enter only numeric values separated by commas.")
                    MaskedTextBox1.Clear()
                    MaskedTextBox1.Focus()
                    Return
                End If
            Next

            Dim averageExpense As Double = expenses.Average()

            lblAverage.Text = "The average weekly expense is: " & averageExpense.ToString("C")
            lblAverage.Visible = True
        End If


        If radMonthly.Checked Then
            Dim expensesStr As String = MaskedTextBox1.Text
            Dim expensesArr As String() = expensesStr.Split(","c)

            If expensesArr.Length <> 12 Then
                MessageBox.Show("Please enter exactly 12 numbers separated by commas.")
                MaskedTextBox1.Clear()
                MaskedTextBox1.Focus()
                Return
            End If

            Dim expenses As New List(Of Double)
            For Each expenseStr As String In expensesArr
                Dim expense As Double
                If Double.TryParse(expenseStr, expense) Then
                    expenses.Add(expense)
                Else
                    MessageBox.Show("Please enter only numeric values separated by commas.")
                    Return
                End If
            Next

            Dim averageExpense As Double = expenses.Average()

            lblAverage.Text = "The average monthly expense is: " & averageExpense.ToString("C")
            lblAverage.Visible = True
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAverage.Visible = False
        radWeekly.Select()
        MaskedTextBox1.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub radWeekly_CheckedChanged(sender As Object, e As EventArgs) Handles radWeekly.CheckedChanged
        lblInstructions.Visible = True
        lblInstructions.Text = "Please enter four expenses separated by commas."
        MaskedTextBox1.Clear()
        MaskedTextBox1.Focus()
    End Sub

    Private Sub radMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles radMonthly.CheckedChanged
        lblInstructions.Visible = True
        lblInstructions.Text = "Please enter twelve expenses separated by commas."
        MaskedTextBox1.Clear()
        MaskedTextBox1.Focus()
    End Sub

End Class
