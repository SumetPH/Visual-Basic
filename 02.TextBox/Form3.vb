Public Class Form3
    Private Function isNum(ByVal strNum As String) As Boolean
        If (Not IsNumeric(strNum)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function Calculate(ByVal op As Char) As Double
        Dim num1, num2 As Double
        num1 = CDbl(tbxNum1.Text)
        num2 = CDbl(tbxNum2.Text)

        Select Case op
            Case "+" : Return num1 + num2
            Case "-" : Return num1 - num2
            Case "x" : Return num1 * num2
            Case "/" : Return num1 / num2
            Case Else
                Return 0.0
        End Select
    End Function

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbxNum1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxNum1.TextChanged
        If (tbxNum1.Text = "") Then
            Return
        End If
        If (Not isNum(tbxNum1.Text)) Then
            MessageBox.Show("กรุณาป้อนตัวเลขเท่านั้น")
            tbxNum1.Clear()
            tbxNum1.Focus()
        End If
    End Sub

    Private Sub tbxNum2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxNum2.TextChanged
        If (tbxNum2.Text = "") Then
            Return
        End If
        If (Not isNum(tbxNum2.Text)) Then
            MessageBox.Show("กรุณาป้อนตัวเลขเท่านั้น")
            tbxNum2.Clear()
            tbxNum2.Focus()
        End If
    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        tbxResult.Text = Calculate(btnPlus.Text)
    End Sub

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        tbxResult.Text = Calculate(btnSubtract.Text)
    End Sub

    Private Sub btnMutiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMutiple.Click
        tbxResult.Text = Calculate(btnMutiple.Text)
    End Sub

    Private Sub btnDivid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivid.Click
        tbxResult.Text = Calculate(btnDivid.Text)
    End Sub
End Class