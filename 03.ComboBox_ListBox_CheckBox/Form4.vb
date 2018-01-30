Public Class Form4

    Private Sub chkOnClick_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOnClick.CheckedChanged
        chklbColor.CheckOnClick = chkOnClick.Checked
    End Sub

    Private Sub btnAdditem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdditem.Click
        Dim itm As String
        Dim idx As Integer
        itm = tbxItem.Text
        If (itm <> " ") Then
            If (chklbColor.FindStringExact(itm) <> -1) Then
                MessageBox.Show("รายการนี้มีอยู่แล้ว กรุณาป้อนใหม่")
                Return
            Else
                idx = chklbColor.Items.Add(itm, chkNewItem.Checked)
                chklbColor.SetSelected(idx, True)
                tbxItem.Text = ""
                tbxItem.Focus()
            End If
        End If
    End Sub

    Private Sub btnShowSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSelected.Click
        Dim selectedItem As String = ""
        For Each itm In chklbColor.CheckedItems
            selectedItem &= " - " & itm & vbNewLine
        Next
        If selectedItem = "" Then
            MessageBox.Show("กรุณาเลื่อนรายการที่ต้องการ", "ผิดพลาด")
            Return
        End If
        MessageBox.Show("รายการที่เลือก : " & vbNewLine & selectedItem, "ผลการเลือกรายการ")
    End Sub

    Private Sub btnRemoveSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSelected.Click
        For i = (chklbColor.Items.Count - 1) To 0 Step -1
            If (chklbColor.GetItemChecked(i)) Then
                chklbColor.Items.RemoveAt(i)
            End If
        Next
    End Sub
End Class