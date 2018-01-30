<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cbxItem = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoSimple = New System.Windows.Forms.RadioButton()
        Me.rdoDropDownList = New System.Windows.Forms.RadioButton()
        Me.rdoDropDown = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxItem
        '
        Me.cbxItem.FormattingEnabled = True
        Me.cbxItem.Location = New System.Drawing.Point(70, 79)
        Me.cbxItem.Name = "cbxItem"
        Me.cbxItem.Size = New System.Drawing.Size(232, 24)
        Me.cbxItem.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoSimple)
        Me.GroupBox1.Controls.Add(Me.rdoDropDownList)
        Me.GroupBox1.Controls.Add(Me.rdoDropDown)
        Me.GroupBox1.Location = New System.Drawing.Point(410, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 307)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drop Down Style"
        '
        'rdoSimple
        '
        Me.rdoSimple.AutoSize = True
        Me.rdoSimple.Location = New System.Drawing.Point(48, 206)
        Me.rdoSimple.Name = "rdoSimple"
        Me.rdoSimple.Size = New System.Drawing.Size(71, 21)
        Me.rdoSimple.TabIndex = 2
        Me.rdoSimple.Text = "Simple"
        Me.rdoSimple.UseVisualStyleBackColor = True
        '
        'rdoDropDownList
        '
        Me.rdoDropDownList.AutoSize = True
        Me.rdoDropDownList.Location = New System.Drawing.Point(48, 143)
        Me.rdoDropDownList.Name = "rdoDropDownList"
        Me.rdoDropDownList.Size = New System.Drawing.Size(117, 21)
        Me.rdoDropDownList.TabIndex = 1
        Me.rdoDropDownList.Text = "DropDownList"
        Me.rdoDropDownList.UseVisualStyleBackColor = True
        '
        'rdoDropDown
        '
        Me.rdoDropDown.AutoSize = True
        Me.rdoDropDown.Checked = True
        Me.rdoDropDown.Location = New System.Drawing.Point(48, 77)
        Me.rdoDropDown.Name = "rdoDropDown"
        Me.rdoDropDown.Size = New System.Drawing.Size(95, 21)
        Me.rdoDropDown.TabIndex = 0
        Me.rdoDropDown.TabStop = True
        Me.rdoDropDown.Text = "DropDown"
        Me.rdoDropDown.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.btnDel)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.tbxInput)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 230)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายการใน ComboBox"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(224, 156)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(128, 156)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(25, 156)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbxInput
        '
        Me.tbxInput.Location = New System.Drawing.Point(59, 66)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(199, 22)
        Me.tbxInput.TabIndex = 0
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(234, 397)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(51, 17)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "รายการ ComboBox ที่เลือก : "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 453)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbxItem)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxItem As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoSimple As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDropDownList As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDropDown As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents tbxInput As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
