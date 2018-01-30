Public Class Form1
    Private Sub ChangeFontStyle()
        Dim fs As FontStyle
        If chkBold.Checked Then
            chkRegular.Checked = False
            fs = fs Or FontStyle.Bold
        End If
        If chkItalic.Checked Then
            chkRegular.Checked = False
            fs = fs Or FontStyle.Italic
        End If
        If chkUnderline.Checked Then
            chkRegular.Checked = False
            fs = fs Or FontStyle.Underline
        End If
        If chkStrikeout.Checked Then
            chkRegular.Checked = False
            fs = fs Or FontStyle.Strikeout
        End If
        Dim f As New Font("Microsoft Sans Serif", 20, fs)
        lblShow.Font = f
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkRegular_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegular.CheckedChanged
        Dim fs As FontStyle
        If chkRegular.Checked Then
            chkBold.Checked = False
            chkItalic.Checked = False
            chkUnderline.Checked = False
            chkStrikeout.Checked = False
            fs = FontStyle.Regular
            Dim f As New Font("Microsoft Sans Serif", 20, fs)
            lblShow.Font = f
        End If
    End Sub

    Private Sub chkBold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBold.CheckedChanged
        ChangeFontStyle()
    End Sub

    Private Sub chkItalic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItalic.CheckedChanged
        ChangeFontStyle()
    End Sub

    Private Sub chkUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUnderline.Click
        ChangeFontStyle()
    End Sub

    Private Sub chkStrikeout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStrikeout.Click
        ChangeFontStyle()
    End Sub
End Class
