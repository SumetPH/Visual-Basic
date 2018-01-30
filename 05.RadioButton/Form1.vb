Public Class Form1

    Private Sub rdoRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoRed.CheckedChanged
        lblColor.BackColor = Color.Red
    End Sub

    Private Sub rdoGreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoGreen.CheckedChanged
        lblColor.BackColor = Color.FromName("green")
    End Sub

    Private Sub rdoBlue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoBlue.CheckedChanged
        lblColor.BackColor = Color.FromArgb(0, 0, 255)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rdoRed.Checked = False
        rdoGreen.Checked = False
        rdoBlue.Checked = False
        lblColor.BackColor = Color.FromName("control")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class
