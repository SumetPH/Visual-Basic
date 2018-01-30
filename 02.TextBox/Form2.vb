Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnContinue.Enabled = False
    End Sub

    Private Sub btnEnterdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterdata.Click
        Dim data As String
        data = InputBox("ใส่ข้อมูล")
        If data = "" Then
            btnContinue.Enabled = False
        Else
            btnContinue.Enabled = True
        End If
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        MessageBox.Show("ดำเนินการเสร็จแล้ว")
        btnContinue.Enabled = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class