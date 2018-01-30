Public Class Form1
    Dim s As String
    Dim iii As String
    Private Sub friendData(ByVal list As String)
        If String.Equals(list, "สุเมธ ผงพิลา") Then
            s &= "ชื่อ : สุเมธ" & vbNewLine
            s &= "นามสกุล : ผงพิลา" & vbNewLine
            s &= "ชื่อเล่น : น็อต" & vbNewLine
            s &= "เพศ : ชาย" & vbNewLine
            s &= "Facebook : facebook.com/notsumet1" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "ทักษิณ เพชรพรรณ") Then
            s &= "ชื่อ : ทักษิณ" & vbNewLine
            s &= "นามสกุล : เพชรพรรณ" & vbNewLine
            s &= "ชื่อเล่น : ที" & vbNewLine
            s &= "เพศ : ชาย" & vbNewLine
            s &= "Facebook : facebook.com/profile.php?id=100002246414023" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "ศรัญ สารธะวงศ์") Then
            s &= "ชื่อ : ศรัญ" & vbNewLine
            s &= "นามสกุล : สารธะวงศ์" & vbNewLine
            s &= "ชื่อเล่น : ยิว" & vbNewLine
            s &= "เพศ : ชาย" & vbNewLine
            s &= "Facebook : facebook.com/Yiw.saran" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "ณัฐวุฒิ เขียวขำ") Then
            s &= "ชื่อ : ณัฐวุฒิ" & vbNewLine
            s &= "นามสกุล : เขียวขำ" & vbNewLine
            s &= "ชื่อเล่น : หมี" & vbNewLine
            s &= "เพศ : ชาย" & vbNewLine
            s &= "Facebook : facebook.com/nutty.nattawut" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "กิตติศักดิ์ คำใบ") Then
            s &= "ชื่อ : กิตติศักดิ์" & vbNewLine
            s &= "นามสกุล : คำใบ" & vbNewLine
            s &= "ชื่อเล่น : โต้ง" & vbNewLine
            s &= "เพศ : ชาย" & vbNewLine
            s &= "Facebook : facebook.com/tongtang407" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "อิศรากร รัตนพระกริ่ง") Then
            s &= "ชื่อ : อิศรากร" & vbNewLine
            s &= "นามสกุล : รัตนพระกริ่ง" & vbNewLine
            s &= "ชื่อเล่น : ฟลุค" & vbNewLine
            s &= "Facebook : facebook.com/isarakorn" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "เสาวนีย์ นิยะนุช") Then
            s &= "ชื่อ : เสาวนีย์" & vbNewLine
            s &= "นามสกุล : นิยะนุช" & vbNewLine
            s &= "ชื่อเล่น : โตเกียว" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/saowanee.ni" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "วิลดา กุดทิง") Then
            s &= "ชื่อ : วิลดา" & vbNewLine
            s &= "นามสกุล : กุดทิง" & vbNewLine
            s &= "ชื่อเล่น : อาย" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/karasu112" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "ขวัญเกล้า อุปพงษ์") Then
            s &= "ชื่อ : ขวัญเกล้า" & vbNewLine
            s &= "นามสกุล : อุปพงษ์" & vbNewLine
            s &= "ชื่อเล่น : หงส์" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/Kwunkaw.9" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "สุมิตรา เรืองบุญ") Then
            s &= "ชื่อ : สุมิตรา" & vbNewLine
            s &= "นามสกุล : เรืองบุญ" & vbNewLine
            s &= "ชื่อเล่น : เจน" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/janekang.seednomnam" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "จิรประภา โชติพันธ์") Then
            s &= "ชื่อ : จิรประภา" & vbNewLine
            s &= "นามสกุล : โชติพันธ์" & vbNewLine
            s &= "ชื่อเล่น : จุบแจง" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/jub.jang.716970" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "กาญจนา จันทคูณ") Then
            s &= "ชื่อ : กาญจนา" & vbNewLine
            s &= "นามสกุล : จันทคูณ" & vbNewLine
            s &= "ชื่อเล่น : วาย" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/kanjana.jantacoon" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "ขวัญจิตร นูจันทร์") Then
            s &= "ชื่อ : ขวัญจิตร" & vbNewLine
            s &= "นามสกุล : นูจันทร์" & vbNewLine
            s &= "ชื่อเล่น : โอ๋" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/khwanjit.nuchan.1" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "มยุลี โยชนา") Then
            s &= "ชื่อ : มยุลี" & vbNewLine
            s &= "นามสกุล : โยชนา" & vbNewLine
            s &= "ชื่อเล่น : แกรน" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/gran.mayulee" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "นันทิยา วงค์สิม") Then
            s &= "ชื่อ : นันทิยา" & vbNewLine
            s &= "นามสกุล : วงค์สิม" & vbNewLine
            s &= "ชื่อเล่น : กี้" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/Nunthiya.Wongsim" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "พัทริยาพร ปัญญาวุฒิ") Then
            s &= "ชื่อ : พัทริยาพร" & vbNewLine
            s &= "นามสกุล : ปัญญาวุฒิ" & vbNewLine
            s &= "ชื่อเล่น : นัท" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/pattariyaporn.panyawut" & vbNewLine
            s &= vbNewLine
        End If

        If String.Equals(list, "พลอยฤดี แก้วก่า") Then
            s &= "ชื่อ : พลอยฤดี" & vbNewLine
            s &= "นามสกุล : แก้วก่า" & vbNewLine
            s &= "ชื่อเล่น : พลอย" & vbNewLine
            s &= "เพศ : หญิง" & vbNewLine
            s &= "Facebook : facebook.com/ployluedee.kaewka" & vbNewLine
            s &= vbNewLine
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        s = ""
        For i = 0 To ListBox1.SelectedItems.Count - 1
            friendData(ListBox1.SelectedItems(i))
        Next
        MessageBox.Show(s, "ข้อมูลประจำตัว")
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem
            Case "สุเมธ ผงพิลา"
                pb1.Image = My.Resources.ResourceManager.GetObject("sumet")
            Case "ทักษิณ เพชรพรรณ"
                pb1.Image = My.Resources.ResourceManager.GetObject("t")
            Case "ศรัญ สารธะวงศ์"
                pb1.Image = My.Resources.ResourceManager.GetObject("yiw")
            Case "ณัฐวุฒิ เขียวขำ"
                pb1.Image = My.Resources.ResourceManager.GetObject("bear")
            Case "กิตติศักดิ์ คำใบ"
                pb1.Image = My.Resources.ResourceManager.GetObject("tong")
            Case "อิศรากร รัตนพระกริ่ง"
                pb1.Image = My.Resources.ResourceManager.GetObject("fuk")
            Case "เสาวนีย์ นิยะนุช"
                pb1.Image = My.Resources.ResourceManager.GetObject("tokyo")
            Case "วิลดา กุดทิง"
                pb1.Image = My.Resources.ResourceManager.GetObject("eye")
            Case "ขวัญเกล้า อุปพงษ์"
                pb1.Image = My.Resources.ResourceManager.GetObject("hong")
            Case "สุมิตรา เรืองบุญ"
                pb1.Image = My.Resources.ResourceManager.GetObject("jane")
            Case "จิรประภา โชติพันธ์"
                pb1.Image = My.Resources.ResourceManager.GetObject("jang")
            Case "กาญจนา จันทคูณ"
                pb1.Image = My.Resources.ResourceManager.GetObject("y")
            Case "ขวัญจิตร นูจันทร์"
                pb1.Image = My.Resources.ResourceManager.GetObject("o")
            Case "มยุลี โยชนา"
                pb1.Image = My.Resources.ResourceManager.GetObject("gran")
            Case "นันทิยา วงค์สิม"
                pb1.Image = My.Resources.ResourceManager.GetObject("kee")
            Case "พัทริยาพร ปัญญาวุฒิ"
                pb1.Image = My.Resources.ResourceManager.GetObject("nut")
            Case "พลอยฤดี แก้วก่า"
                pb1.Image = My.Resources.ResourceManager.GetObject("ploy")
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pb1.Image = My.Resources.ResourceManager.GetObject("clear")
        ListBox1.SelectedItem = Nothing
    End Sub
End Class
