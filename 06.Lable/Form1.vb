Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ex1.Select
    End Sub

    Private Sub ts1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts1.Click
        Dim FirstName As String
        FirstName = "Sumet"
        lb1.Text = FirstName
        FirstName = "สุเมธ"
        lb2.Text = FirstName
    End Sub

    Private Sub ts2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts2.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณากรอกชื่อและนาสกุลของคุณ"
        FullName = InputBox(Prompt)
        lb1.Text = FullName
    End Sub

    Private Sub ts3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts3.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณากรอกชื่อและนาสกุลของคุณ"
        FullName = InputBox(Prompt)
        MsgBox(FullName, , "ซื่อและนามสกุลของคุุณ")
    End Sub

    Private Sub ex1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ex1.Click
        End
    End Sub
End Class
