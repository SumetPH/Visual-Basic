<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRef
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextRental = New System.Windows.Forms.TextBox()
        Me.TextNumFloors = New System.Windows.Forms.TextBox()
        Me.TextRoomsPerFloor = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "จำนวนชั้นของอาคาร"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "จำนวนห้องของแต่ล่ะชั้น"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(88, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ค่าเช่าเดือนล่ะ"
        '
        'TextRental
        '
        Me.TextRental.Location = New System.Drawing.Point(246, 214)
        Me.TextRental.Name = "TextRental"
        Me.TextRental.Size = New System.Drawing.Size(144, 22)
        Me.TextRental.TabIndex = 2
        '
        'TextNumFloors
        '
        Me.TextNumFloors.Location = New System.Drawing.Point(246, 88)
        Me.TextNumFloors.Name = "TextNumFloors"
        Me.TextNumFloors.Size = New System.Drawing.Size(144, 22)
        Me.TextNumFloors.TabIndex = 0
        '
        'TextRoomsPerFloor
        '
        Me.TextRoomsPerFloor.Location = New System.Drawing.Point(246, 149)
        Me.TextRoomsPerFloor.Name = "TextRoomsPerFloor"
        Me.TextRoomsPerFloor.Size = New System.Drawing.Size(144, 22)
        Me.TextRoomsPerFloor.TabIndex = 1
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSave.ForeColor = System.Drawing.Color.Black
        Me.ButtonSave.Location = New System.Drawing.Point(189, 302)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(105, 30)
        Me.ButtonSave.TabIndex = 3
        Me.ButtonSave.Text = "บันทึกข้อมูล"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'FormRef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final.My.Resources.Resources.f
        Me.ClientSize = New System.Drawing.Size(481, 390)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextRental)
        Me.Controls.Add(Me.TextRoomsPerFloor)
        Me.Controls.Add(Me.TextNumFloors)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormRef"
        Me.Text = "กำหนดค่าอ้างอิง"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextRental As System.Windows.Forms.TextBox
    Friend WithEvents TextNumFloors As System.Windows.Forms.TextBox
    Friend WithEvents TextRoomsPerFloor As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button

End Class
