<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRoomer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboRoom = New System.Windows.Forms.ComboBox()
        Me.ComboFloor = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.ComboTitle = New System.Windows.Forms.ComboBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextIDCardNo = New System.Windows.Forms.TextBox()
        Me.DateTimeBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextAge = New System.Windows.Forms.TextBox()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.TextPhone = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชั้น/ห้อง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ผู้เช่า"
        '
        'ComboRoom
        '
        Me.ComboRoom.FormattingEnabled = True
        Me.ComboRoom.Location = New System.Drawing.Point(160, 29)
        Me.ComboRoom.Name = "ComboRoom"
        Me.ComboRoom.Size = New System.Drawing.Size(96, 24)
        Me.ComboRoom.TabIndex = 2
        '
        'ComboFloor
        '
        Me.ComboFloor.FormattingEnabled = True
        Me.ComboFloor.Location = New System.Drawing.Point(88, 29)
        Me.ComboFloor.Name = "ComboFloor"
        Me.ComboFloor.Size = New System.Drawing.Size(66, 24)
        Me.ComboFloor.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(88, 75)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(168, 308)
        Me.ListBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(296, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "รหัส"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(304, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ชื่อ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(267, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 34)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เลขบัตร" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ประชาชน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(283, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "วันเกิด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(297, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ที่อยู่"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(297, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "โทร"
        '
        'TextID
        '
        Me.TextID.Location = New System.Drawing.Point(349, 29)
        Me.TextID.Name = "TextID"
        Me.TextID.ReadOnly = True
        Me.TextID.Size = New System.Drawing.Size(149, 22)
        Me.TextID.TabIndex = 3
        '
        'ComboTitle
        '
        Me.ComboTitle.FormattingEnabled = True
        Me.ComboTitle.Location = New System.Drawing.Point(349, 72)
        Me.ComboTitle.Name = "ComboTitle"
        Me.ComboTitle.Size = New System.Drawing.Size(66, 24)
        Me.ComboTitle.TabIndex = 4
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(421, 72)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(150, 22)
        Me.TextName.TabIndex = 5
        '
        'TextIDCardNo
        '
        Me.TextIDCardNo.Location = New System.Drawing.Point(349, 137)
        Me.TextIDCardNo.Name = "TextIDCardNo"
        Me.TextIDCardNo.Size = New System.Drawing.Size(222, 22)
        Me.TextIDCardNo.TabIndex = 6
        '
        'DateTimeBirth
        '
        Me.DateTimeBirth.Location = New System.Drawing.Point(350, 189)
        Me.DateTimeBirth.Name = "DateTimeBirth"
        Me.DateTimeBirth.Size = New System.Drawing.Size(128, 22)
        Me.DateTimeBirth.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(494, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "อายุ"
        '
        'TextAge
        '
        Me.TextAge.Location = New System.Drawing.Point(528, 189)
        Me.TextAge.Name = "TextAge"
        Me.TextAge.ReadOnly = True
        Me.TextAge.Size = New System.Drawing.Size(43, 22)
        Me.TextAge.TabIndex = 3
        '
        'TextAddress
        '
        Me.TextAddress.Location = New System.Drawing.Point(350, 252)
        Me.TextAddress.Multiline = True
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.Size = New System.Drawing.Size(222, 64)
        Me.TextAddress.TabIndex = 8
        '
        'TextPhone
        '
        Me.TextPhone.Location = New System.Drawing.Point(349, 338)
        Me.TextPhone.Name = "TextPhone"
        Me.TextPhone.Size = New System.Drawing.Size(222, 22)
        Me.TextPhone.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(544, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "รูปภาพ"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.Location = New System.Drawing.Point(699, 189)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(57, 17)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "เลือกภาพ"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Location = New System.Drawing.Point(613, 252)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(143, 30)
        Me.ButtonAdd.TabIndex = 11
        Me.ButtonAdd.Text = "เพิ่มข้อมูล"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Red
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(613, 293)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(143, 30)
        Me.ButtonSave.TabIndex = 12
        Me.ButtonSave.Text = "บันทึกการเพิ่มข้อมูล"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.BackColor = System.Drawing.Color.Blue
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.Location = New System.Drawing.Point(613, 335)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(143, 30)
        Me.ButtonUpdate.TabIndex = 13
        Me.ButtonUpdate.Text = "บันทึกการแก้ไข"
        Me.ButtonUpdate.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Fuchsia
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(613, 377)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(143, 30)
        Me.ButtonDelete.TabIndex = 14
        Me.ButtonDelete.Text = "ลบข้อมูล"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(613, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'FormRoomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final.My.Resources.Resources.a
        Me.ClientSize = New System.Drawing.Size(773, 461)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DateTimeBirth)
        Me.Controls.Add(Me.TextAddress)
        Me.Controls.Add(Me.TextPhone)
        Me.Controls.Add(Me.TextIDCardNo)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.TextAge)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboFloor)
        Me.Controls.Add(Me.ComboTitle)
        Me.Controls.Add(Me.ComboRoom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormRoomer"
        Me.Text = "ข้อมูลผู้เช่า"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboRoom As System.Windows.Forms.ComboBox
    Friend WithEvents ComboFloor As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextID As System.Windows.Forms.TextBox
    Friend WithEvents ComboTitle As System.Windows.Forms.ComboBox
    Friend WithEvents TextName As System.Windows.Forms.TextBox
    Friend WithEvents TextIDCardNo As System.Windows.Forms.TextBox
    Friend WithEvents DateTimeBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextAge As System.Windows.Forms.TextBox
    Friend WithEvents TextAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
