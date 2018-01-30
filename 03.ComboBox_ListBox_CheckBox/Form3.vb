Public Class Form3
    Private Sub RemoveItem(ByVal lbx As ListBox)
        While (lbx.SelectedIndex <> -1)
            lbx.Items.RemoveAt(lbx.SelectedIndex)
        End While
    End Sub
    Private Sub MoveItem(ByVal source As ListBox, ByVal target As ListBox)
        For Each itm As Object In source.SelectedItems
            target.Items.Add(itm)
        Next
        RemoveItem(source)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveForward.Click
        MoveItem(lbxBook, lbxSelectBook)
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMoveBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveBack.Click
        MoveItem(lbxSelectBook, lbxBook)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim itm As String
        If (tbxItem.Text = "") Then
            MessageBox.Show("กรุณาป้อนชื้อหนังสือก่อน", "ผิดพลาด")
            tbxItem.Focus()
        Else
            itm = tbxItem.Text
            lbxBook.Items.Add(itm)
            tbxItem.Text = ""
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        RemoveItem(lbxBook)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lbxSelectBook.Items.Clear()
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim temp As Object
        Dim oldIndex, newIndex As Integer
        oldIndex = lbxSelectBook.SelectedIndex
        If (oldIndex = 0) Or (oldIndex = -1) Then
            Return
        End If
        newIndex = oldIndex - 1
        temp = lbxSelectBook.SelectedItem
        lbxSelectBook.Items.Insert(newIndex, temp)
        lbxSelectBook.Items.RemoveAt(oldIndex + 1)
        lbxSelectBook.SetSelected(newIndex, True)
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim temp As Object
        Dim oldIndex, newIndex As Integer
        oldIndex = lbxSelectBook.SelectedIndex
        If (oldIndex = lbxSelectBook.Items.Count - 1) Or (oldIndex = -1) Then
            Return
        End If
        temp = lbxSelectBook.SelectedItem
        newIndex = oldIndex + 2
        lbxSelectBook.Items.Insert(newIndex, temp)
        lbxSelectBook.Items.RemoveAt(oldIndex)
        lbxSelectBook.SetSelected(newIndex - 1, True)
    End Sub
End Class