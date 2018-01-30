Public Class Form1

    Private Sub bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.Click
        Const Pi As Double = 3.14159
        Const Slice_Area As Double = 12.5

        Dim dblDiameter As Double
        dblDiameter = CDbl(tb1.Text)

        Dim dblPizzaArea As Double
        dblPizzaArea = Pi * (dblDiameter / 2) ^ 2

        Dim intNumberofSlice As Integer
        intNumberofSlice = dblPizzaArea / Slice_Area

        tb2.Text = CStr(intNumberofSlice)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb1.Select
    End Sub
End Class
