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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxNum1 = New System.Windows.Forms.TextBox()
        Me.tbxNum2 = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMutiple = New System.Windows.Forms.Button()
        Me.btnDivid = New System.Windows.Forms.Button()
        Me.tbxResult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ตัวเลขตตัวที่ 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ตัวเลขตัวที่ 2"
        '
        'tbxNum1
        '
        Me.tbxNum1.Location = New System.Drawing.Point(227, 53)
        Me.tbxNum1.Name = "tbxNum1"
        Me.tbxNum1.Size = New System.Drawing.Size(130, 20)
        Me.tbxNum1.TabIndex = 3
        '
        'tbxNum2
        '
        Me.tbxNum2.Location = New System.Drawing.Point(227, 101)
        Me.tbxNum2.Name = "tbxNum2"
        Me.tbxNum2.Size = New System.Drawing.Size(130, 20)
        Me.tbxNum2.TabIndex = 4
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(191, 155)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(30, 30)
        Me.btnPlus.TabIndex = 5
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(248, 155)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(30, 30)
        Me.btnSubtract.TabIndex = 6
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMutiple
        '
        Me.btnMutiple.Location = New System.Drawing.Point(305, 155)
        Me.btnMutiple.Name = "btnMutiple"
        Me.btnMutiple.Size = New System.Drawing.Size(30, 30)
        Me.btnMutiple.TabIndex = 7
        Me.btnMutiple.Text = "x"
        Me.btnMutiple.UseVisualStyleBackColor = True
        '
        'btnDivid
        '
        Me.btnDivid.Location = New System.Drawing.Point(363, 155)
        Me.btnDivid.Name = "btnDivid"
        Me.btnDivid.Size = New System.Drawing.Size(30, 30)
        Me.btnDivid.TabIndex = 8
        Me.btnDivid.Text = "/"
        Me.btnDivid.UseVisualStyleBackColor = True
        '
        'tbxResult
        '
        Me.tbxResult.Location = New System.Drawing.Point(227, 225)
        Me.tbxResult.Name = "tbxResult"
        Me.tbxResult.ReadOnly = True
        Me.tbxResult.Size = New System.Drawing.Size(130, 20)
        Me.tbxResult.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ผลลัพธ์"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 312)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxResult)
        Me.Controls.Add(Me.btnDivid)
        Me.Controls.Add(Me.btnMutiple)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.tbxNum2)
        Me.Controls.Add(Me.tbxNum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxNum1 As System.Windows.Forms.TextBox
    Friend WithEvents tbxNum2 As System.Windows.Forms.TextBox
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents btnMutiple As System.Windows.Forms.Button
    Friend WithEvents btnDivid As System.Windows.Forms.Button
    Friend WithEvents tbxResult As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
