<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.chklbColor = New System.Windows.Forms.CheckedListBox()
        Me.chkOnClick = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkNewItem = New System.Windows.Forms.CheckBox()
        Me.tbxItem = New System.Windows.Forms.TextBox()
        Me.btnAdditem = New System.Windows.Forms.Button()
        Me.btnShowSelected = New System.Windows.Forms.Button()
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รายการ"
        '
        'chklbColor
        '
        Me.chklbColor.FormattingEnabled = True
        Me.chklbColor.Items.AddRange(New Object() {"Red", "Green", "Blue", "Yellow", "Cyan", "Magenta", "Black"})
        Me.chklbColor.Location = New System.Drawing.Point(12, 29)
        Me.chklbColor.Name = "chklbColor"
        Me.chklbColor.Size = New System.Drawing.Size(323, 378)
        Me.chklbColor.TabIndex = 1
        '
        'chkOnClick
        '
        Me.chkOnClick.AutoSize = True
        Me.chkOnClick.Location = New System.Drawing.Point(410, 29)
        Me.chkOnClick.Name = "chkOnClick"
        Me.chkOnClick.Size = New System.Drawing.Size(125, 21)
        Me.chkOnClick.TabIndex = 2
        Me.chkOnClick.Text = "Check On Click"
        Me.chkOnClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkOnClick.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdditem)
        Me.GroupBox1.Controls.Add(Me.tbxItem)
        Me.GroupBox1.Controls.Add(Me.chkNewItem)
        Me.GroupBox1.Location = New System.Drawing.Point(410, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 189)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เพิ่มรายการ"
        '
        'chkNewItem
        '
        Me.chkNewItem.AutoSize = True
        Me.chkNewItem.Location = New System.Drawing.Point(36, 81)
        Me.chkNewItem.Name = "chkNewItem"
        Me.chkNewItem.Size = New System.Drawing.Size(139, 21)
        Me.chkNewItem.TabIndex = 0
        Me.chkNewItem.Text = "Checked รายการนี้"
        Me.chkNewItem.UseVisualStyleBackColor = True
        '
        'tbxItem
        '
        Me.tbxItem.Location = New System.Drawing.Point(36, 37)
        Me.tbxItem.Name = "tbxItem"
        Me.tbxItem.Size = New System.Drawing.Size(220, 22)
        Me.tbxItem.TabIndex = 1
        '
        'btnAdditem
        '
        Me.btnAdditem.Location = New System.Drawing.Point(100, 132)
        Me.btnAdditem.Name = "btnAdditem"
        Me.btnAdditem.Size = New System.Drawing.Size(110, 34)
        Me.btnAdditem.TabIndex = 2
        Me.btnAdditem.Text = "เพิ่มรายการ"
        Me.btnAdditem.UseVisualStyleBackColor = True
        '
        'btnShowSelected
        '
        Me.btnShowSelected.Location = New System.Drawing.Point(108, 438)
        Me.btnShowSelected.Name = "btnShowSelected"
        Me.btnShowSelected.Size = New System.Drawing.Size(154, 31)
        Me.btnShowSelected.TabIndex = 4
        Me.btnShowSelected.Text = "แสดงรายการที่เลือก"
        Me.btnShowSelected.UseVisualStyleBackColor = True
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.Location = New System.Drawing.Point(460, 438)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(136, 31)
        Me.btnRemoveSelected.TabIndex = 5
        Me.btnRemoveSelected.Text = "ลบรายการที่เลือก"
        Me.btnRemoveSelected.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 496)
        Me.Controls.Add(Me.btnRemoveSelected)
        Me.Controls.Add(Me.btnShowSelected)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkOnClick)
        Me.Controls.Add(Me.chklbColor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chklbColor As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkOnClick As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdditem As System.Windows.Forms.Button
    Friend WithEvents tbxItem As System.Windows.Forms.TextBox
    Friend WithEvents chkNewItem As System.Windows.Forms.CheckBox
    Friend WithEvents btnShowSelected As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSelected As System.Windows.Forms.Button
End Class
