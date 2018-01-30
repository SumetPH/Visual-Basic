<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lbxBook = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMoveForward = New System.Windows.Forms.Button()
        Me.btnMoveBack = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tbxItem = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lbxSelectBook = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รายการหนังสือ : "
        '
        'lbxBook
        '
        Me.lbxBook.FormattingEnabled = True
        Me.lbxBook.ItemHeight = 16
        Me.lbxBook.Items.AddRange(New Object() {"3DsMax", "Visual Basic 2010", "Microsoft Office 2010", "Ulead Video Studio 10", "DreamWeaver CS5", "Flash Professional CS5", "Illustrator CS5", "Photoshop CS5", "Visual C# 2010", "Database Programing", "Data Structure", "System Analysis"})
        Me.lbxBook.Location = New System.Drawing.Point(12, 65)
        Me.lbxBook.Name = "lbxBook"
        Me.lbxBook.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbxBook.Size = New System.Drawing.Size(282, 324)
        Me.lbxBook.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(426, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รายการหนังสือ : "
        '
        'btnMoveForward
        '
        Me.btnMoveForward.Location = New System.Drawing.Point(327, 178)
        Me.btnMoveForward.Name = "btnMoveForward"
        Me.btnMoveForward.Size = New System.Drawing.Size(75, 31)
        Me.btnMoveForward.TabIndex = 3
        Me.btnMoveForward.Text = ">>"
        Me.btnMoveForward.UseVisualStyleBackColor = True
        '
        'btnMoveBack
        '
        Me.btnMoveBack.Location = New System.Drawing.Point(327, 225)
        Me.btnMoveBack.Name = "btnMoveBack"
        Me.btnMoveBack.Size = New System.Drawing.Size(75, 36)
        Me.btnMoveBack.TabIndex = 4
        Me.btnMoveBack.Text = "<<"
        Me.btnMoveBack.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(723, 178)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 31)
        Me.btnUp.TabIndex = 5
        Me.btnUp.Text = "ขั้น"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(723, 225)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 36)
        Me.btnDown.TabIndex = 6
        Me.btnDown.Text = "ลง"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(533, 425)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tbxItem
        '
        Me.tbxItem.Location = New System.Drawing.Point(52, 416)
        Me.tbxItem.Name = "tbxItem"
        Me.tbxItem.Size = New System.Drawing.Size(203, 22)
        Me.tbxItem.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(52, 470)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 33)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(180, 470)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 33)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "ลบ"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lbxSelectBook
        '
        Me.lbxSelectBook.FormattingEnabled = True
        Me.lbxSelectBook.ItemHeight = 16
        Me.lbxSelectBook.Location = New System.Drawing.Point(429, 65)
        Me.lbxSelectBook.Name = "lbxSelectBook"
        Me.lbxSelectBook.Size = New System.Drawing.Size(279, 324)
        Me.lbxSelectBook.TabIndex = 11
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 525)
        Me.Controls.Add(Me.lbxSelectBook)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbxItem)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnMoveBack)
        Me.Controls.Add(Me.btnMoveForward)
        Me.Controls.Add(Me.lbxBook)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbxBook As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMoveForward As System.Windows.Forms.Button
    Friend WithEvents btnMoveBack As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents tbxItem As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lbxSelectBook As System.Windows.Forms.ListBox
End Class
