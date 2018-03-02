<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPayment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboFloor = New System.Windows.Forms.ComboBox()
        Me.ComboRoom = New System.Windows.Forms.ComboBox()
        Me.TextRental = New System.Windows.Forms.TextBox()
        Me.TextWater = New System.Windows.Forms.TextBox()
        Me.TextElectric = New System.Windows.Forms.TextBox()
        Me.TextPhone = New System.Windows.Forms.TextBox()
        Me.TextOthers = New System.Windows.Forms.TextBox()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.CheckPaid = New System.Windows.Forms.CheckBox()
        Me.ComboMonth = New System.Windows.Forms.ComboBox()
        Me.ComboYear = New System.Windows.Forms.ComboBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonPreview = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(57, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อห้อง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(57, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ค่าเช่าห้อง"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(57, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ค่าน้ำ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(57, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ค่าไฟ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(57, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ค่าโทรศัพท์"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(57, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "อิ่นๆ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(57, 374)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "รวม"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(359, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ประจำเดิอน/ปี"
        '
        'ComboFloor
        '
        Me.ComboFloor.FormattingEnabled = True
        Me.ComboFloor.Location = New System.Drawing.Point(149, 51)
        Me.ComboFloor.Name = "ComboFloor"
        Me.ComboFloor.Size = New System.Drawing.Size(67, 24)
        Me.ComboFloor.TabIndex = 1
        '
        'ComboRoom
        '
        Me.ComboRoom.FormattingEnabled = True
        Me.ComboRoom.Location = New System.Drawing.Point(222, 51)
        Me.ComboRoom.Name = "ComboRoom"
        Me.ComboRoom.Size = New System.Drawing.Size(82, 24)
        Me.ComboRoom.TabIndex = 2
        '
        'TextRental
        '
        Me.TextRental.Location = New System.Drawing.Point(149, 111)
        Me.TextRental.Name = "TextRental"
        Me.TextRental.Size = New System.Drawing.Size(155, 22)
        Me.TextRental.TabIndex = 3
        Me.TextRental.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextWater
        '
        Me.TextWater.Location = New System.Drawing.Point(149, 158)
        Me.TextWater.Name = "TextWater"
        Me.TextWater.Size = New System.Drawing.Size(155, 22)
        Me.TextWater.TabIndex = 4
        Me.TextWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextElectric
        '
        Me.TextElectric.Location = New System.Drawing.Point(149, 205)
        Me.TextElectric.Name = "TextElectric"
        Me.TextElectric.Size = New System.Drawing.Size(155, 22)
        Me.TextElectric.TabIndex = 5
        Me.TextElectric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextPhone
        '
        Me.TextPhone.Location = New System.Drawing.Point(149, 251)
        Me.TextPhone.Name = "TextPhone"
        Me.TextPhone.Size = New System.Drawing.Size(155, 22)
        Me.TextPhone.TabIndex = 6
        Me.TextPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextOthers
        '
        Me.TextOthers.Location = New System.Drawing.Point(149, 303)
        Me.TextOthers.Name = "TextOthers"
        Me.TextOthers.Size = New System.Drawing.Size(155, 22)
        Me.TextOthers.TabIndex = 7
        Me.TextOthers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextTotal
        '
        Me.TextTotal.Location = New System.Drawing.Point(149, 371)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.ReadOnly = True
        Me.TextTotal.Size = New System.Drawing.Size(155, 22)
        Me.TextTotal.TabIndex = 8
        Me.TextTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckPaid
        '
        Me.CheckPaid.AutoSize = True
        Me.CheckPaid.BackColor = System.Drawing.Color.Transparent
        Me.CheckPaid.ForeColor = System.Drawing.Color.Black
        Me.CheckPaid.Location = New System.Drawing.Point(362, 370)
        Me.CheckPaid.Name = "CheckPaid"
        Me.CheckPaid.Size = New System.Drawing.Size(79, 21)
        Me.CheckPaid.TabIndex = 15
        Me.CheckPaid.Text = "ชำระแล้ว"
        Me.CheckPaid.UseVisualStyleBackColor = False
        '
        'ComboMonth
        '
        Me.ComboMonth.FormattingEnabled = True
        Me.ComboMonth.Location = New System.Drawing.Point(457, 51)
        Me.ComboMonth.Name = "ComboMonth"
        Me.ComboMonth.Size = New System.Drawing.Size(98, 24)
        Me.ComboMonth.TabIndex = 9
        '
        'ComboYear
        '
        Me.ComboYear.FormattingEnabled = True
        Me.ComboYear.Location = New System.Drawing.Point(561, 51)
        Me.ComboYear.Name = "ComboYear"
        Me.ComboYear.Size = New System.Drawing.Size(81, 24)
        Me.ComboYear.TabIndex = 10
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.LimeGreen
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(457, 108)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(185, 30)
        Me.ButtonSave.TabIndex = 11
        Me.ButtonSave.Text = "บันทึกข้อมูล"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Red
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(457, 155)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(185, 30)
        Me.ButtonDelete.TabIndex = 12
        Me.ButtonDelete.Text = "ลบข้อมูล"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonPrint
        '
        Me.ButtonPrint.BackColor = System.Drawing.Color.Fuchsia
        Me.ButtonPrint.ForeColor = System.Drawing.Color.White
        Me.ButtonPrint.Location = New System.Drawing.Point(457, 202)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(185, 30)
        Me.ButtonPrint.TabIndex = 13
        Me.ButtonPrint.Text = "พิมพ์ใบเสร็จ"
        Me.ButtonPrint.UseVisualStyleBackColor = False
        '
        'ButtonPreview
        '
        Me.ButtonPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonPreview.ForeColor = System.Drawing.Color.White
        Me.ButtonPreview.Location = New System.Drawing.Point(457, 248)
        Me.ButtonPreview.Name = "ButtonPreview"
        Me.ButtonPreview.Size = New System.Drawing.Size(185, 30)
        Me.ButtonPreview.TabIndex = 14
        Me.ButtonPreview.Text = "ตัวอย่างก่อนพิมพ์"
        Me.ButtonPreview.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FormPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final.My.Resources.Resources.e
        Me.ClientSize = New System.Drawing.Size(705, 482)
        Me.Controls.Add(Me.ButtonPreview)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.CheckPaid)
        Me.Controls.Add(Me.TextTotal)
        Me.Controls.Add(Me.TextOthers)
        Me.Controls.Add(Me.TextPhone)
        Me.Controls.Add(Me.TextElectric)
        Me.Controls.Add(Me.TextWater)
        Me.Controls.Add(Me.TextRental)
        Me.Controls.Add(Me.ComboMonth)
        Me.Controls.Add(Me.ComboRoom)
        Me.Controls.Add(Me.ComboYear)
        Me.Controls.Add(Me.ComboFloor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPayment"
        Me.Text = "บันทึกการชำระ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboFloor As System.Windows.Forms.ComboBox
    Friend WithEvents ComboRoom As System.Windows.Forms.ComboBox
    Friend WithEvents TextRental As System.Windows.Forms.TextBox
    Friend WithEvents TextWater As System.Windows.Forms.TextBox
    Friend WithEvents TextElectric As System.Windows.Forms.TextBox
    Friend WithEvents TextPhone As System.Windows.Forms.TextBox
    Friend WithEvents TextOthers As System.Windows.Forms.TextBox
    Friend WithEvents TextTotal As System.Windows.Forms.TextBox
    Friend WithEvents CheckPaid As System.Windows.Forms.CheckBox
    Friend WithEvents ComboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents ComboYear As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents ButtonPreview As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class
