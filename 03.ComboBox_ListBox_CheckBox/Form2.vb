Public Class Form2

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim itm As String = tbxInput.Text
        If (itm <> "") Then
            If (cbxItem.FindStringExact(itm) <> -1) Then
                MessageBox.Show("รายการที่เพิ่มมีอยู่แล้ว", "ผิดพลาด", _
                               MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim idx As Integer
            idx = cbxItem.Items.Add(itm)
            cbxItem.SelectedIndex = idx
            tbxInput.Text = ""
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If (tbxInput.Text <> "") Then
            cbxItem.Items.Remove(tbxInput.Text)
            tbxInput.Text = ""
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim idx As Integer
        If (tbxInput.Text <> "") Then
            idx = cbxItem.FindStringExact(tbxInput.Text)
            If (idx <> -1) Then
                MessageBox.Show("พบรายการ : " & tbxInput.Text & " ในลำดับที่ " & _
                                idx + 1)
            Else
                MessageBox.Show("ไม่พบรายการ : " & tbxInput.Text)
            End If
        End If
    End Sub

    Private Sub rdoDropDown_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDropDown.CheckedChanged
        cbxItem.DropDownStyle = ComboBoxStyle.DropDown
    End Sub

    Private Sub rdoDropDownList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDropDownList.CheckedChanged
        cbxItem.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub rdoSimple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSimple.CheckedChanged
        cbxItem.DropDownStyle = ComboBoxStyle.Simple
    End Sub

    Private Sub cbxItem_SelectedValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxItem.SelectedValueChanged
        lblResult.Text = cbxItem.SelectedItem
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbxInput.Select()
    End Sub
End Class