Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Private connecton As SqlConnection
    Private command As SqlCommand
    Private dataSt As DataSet
    Private adapter As SqlDataAdapter
    Private bindingSrc As BindingSource
    Private sql As String

    Private Sub UpdateBinding()
        TextID.DataBindings.Clear()
        TextName.DataBindings.Clear()
        TextDes.DataBindings.Clear()
        PictureBox1.DataBindings.Clear()

        sql = "select * from DB_Product"
        command = New SqlCommand(sql, connecton)
        adapter = New SqlDataAdapter(command)
        dataSt = New DataSet()
        adapter.Fill(dataSt, "category")

        bindingSrc = New BindingSource
        bindingSrc.DataSource = dataSt.Tables("category")

        TextID.DataBindings.Add("Text", bindingSrc, "CategoryID")
        TextName.DataBindings.Add("Text", bindingSrc, "CategoryName")
        TextDes.DataBindings.Add("Text", bindingSrc, "Description")
        PictureBox1.DataBindings.Add("Image", bindingSrc, "Picture", True)

        ListBox1.DataSource = dataSt.Tables("category")
        ListBox1.DisplayMember = "CategoryName"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conStr As String = "Data Source=.\SQLEXPRESS;" & _
                "AttachDbFilename=|DataDirectory|Database1.mdf;" & _
                "Integrated Security=True;User Instance=True;"
        connecton = New SqlConnection(conStr)
        connecton.Open()
        ButtonSave.Enabled = False
        UpdateBinding()
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        connecton.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        bindingSrc.Position = ListBox1.SelectedIndex
        ToolStripStatusLabel1.Text = "แถวที่ : " & (bindingSrc.Position + 1) & " / " & bindingSrc.Count
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        TextID.Text = ""
        TextName.Text = ""
        TextDes.Text = ""
        PictureBox1.Image = Nothing

        If ButtonAdd.Text = "เพิ่มข้อมูล" Then
            ButtonAdd.Text = "ยกเลิก"
            ButtonSave.Enabled = True
            ListBox1.Enabled = False
        ElseIf ButtonAdd.Text = "ยกเลิก" Then
            ButtonAdd.Text = "เพิ่มข้อมูล"
            ButtonSave.Enabled = False
            ListBox1.Enabled = True
            UpdateBinding()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog1.Filter = "ImageFile(*.jpg,*.png,*.gif,*.bmp)|*.jpg;*.png;*.gif;*.bmp"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        If isDataComplete() = False Then
            Exit Sub
        End If

        sql = "insert into DB_Product"
        If Not (PictureBox1.Image Is Nothing) Then
            sql &= "(CategoryName, Description, Picture)"
            sql &= "values(@name,@descr,@pic)"
        Else
            sql &= "(CategoryName, Description)"
            sql &= "values(@name,@descr)"
        End If

        command.Parameters.Clear()
        command.CommandText = sql
        command.Parameters.AddWithValue("name", TextName.Text)
        command.Parameters.AddWithValue("descr", TextDes.Text)

        If Not (PictureBox1.Image Is Nothing) Then
            Dim pic() As Byte = ReadImage()
            command.Parameters.AddWithValue("pic", pic)
        End If

        Dim result As Integer = command.ExecuteNonQuery()
        If result = -1 Then
            MessageBox.Show("เกดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้")
        Else
            MessageBox.Show("บันทึกข้อมูลแล้ว")
        End If
        ButtonAdd.PerformClick()
    End Sub

    Private Function ReadImage() As Byte()
        Dim memStream As New IO.MemoryStream()
        PictureBox1.Image.Save(memStream, Drawing.Imaging.ImageFormat.Bmp)
        Return memStream.ToArray()
    End Function

    Private Function IsDataComplete()
        TextName.Text.Trim()
        TextDes.Text.Trim()
        If TextName.Text = "" OrElse TextDes.Text = "" Then
            MessageBox.Show("กรุณาใส่ข้อมูลให้ครบ")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        If TextID.Text = "" Or IsDataComplete() = False Then
            Exit Sub
        End If

        Dim s As String
        If Not (PictureBox1.Image Is Nothing) Then
            s = ", Picture = @pic "
        Else
            s = " "
        End If

        sql = "update DB_Product set CategoryName = @name, Description = @descr" & s & _
            "where CategoryID = @id"
        command.Parameters.Clear()
        command.CommandText = sql
        command.Parameters.AddWithValue("name", TextName.Text)
        command.Parameters.AddWithValue("descr", TextDes.Text)
        command.Parameters.AddWithValue("id", TextID.Text)

        If Not (PictureBox1.Image Is Nothing) Then
            Dim byteArr() As Byte = ReadImage()
            command.Parameters.AddWithValue("pic", byteArr)
        End If

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("บันทึกการเปลี่ยนแปลงแล้ว")
            UpdateBinding()
        Else
            MessageBox.Show("เกิดข้อผิดพลาด")
        End If
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If TextID.Text = "" Then
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("ท่านต้องการลบข้อมูลแถวนี้จริงหรือไม่",
                        "ยืนยันการลบ", MessageBoxButtons.OKCancel)

        If result = DialogResult.Cancel Then
            Exit Sub
        End If

        sql = "delete from DB_Product where CategoryID = " & TextID.Text
        command.Parameters.Clear()
        command.CommandText = sql
        command.ExecuteNonQuery()
        UpdateBinding()
    End Sub
End Class
