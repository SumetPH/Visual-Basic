<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ts1 = New System.Windows.Forms.Button()
        Me.ts2 = New System.Windows.Forms.Button()
        Me.ts3 = New System.Windows.Forms.Button()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.ex1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ts1
        '
        Me.ts1.Location = New System.Drawing.Point(53, 45)
        Me.ts1.Name = "ts1"
        Me.ts1.Size = New System.Drawing.Size(75, 23)
        Me.ts1.TabIndex = 0
        Me.ts1.Text = "ทดสอบ 1"
        Me.ts1.UseVisualStyleBackColor = True
        '
        'ts2
        '
        Me.ts2.Location = New System.Drawing.Point(153, 45)
        Me.ts2.Name = "ts2"
        Me.ts2.Size = New System.Drawing.Size(75, 23)
        Me.ts2.TabIndex = 0
        Me.ts2.Text = "ทดสอบ 2"
        Me.ts2.UseVisualStyleBackColor = True
        '
        'ts3
        '
        Me.ts3.Location = New System.Drawing.Point(257, 45)
        Me.ts3.Name = "ts3"
        Me.ts3.Size = New System.Drawing.Size(75, 23)
        Me.ts3.TabIndex = 0
        Me.ts3.Text = "ทดสอบ 3"
        Me.ts3.UseVisualStyleBackColor = True
        '
        'lb1
        '
        Me.lb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb1.Location = New System.Drawing.Point(53, 108)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(279, 23)
        Me.lb1.TabIndex = 1
        Me.lb1.Text = "Label1"
        Me.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb2
        '
        Me.lb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb2.Location = New System.Drawing.Point(53, 156)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(279, 23)
        Me.lb2.TabIndex = 1
        Me.lb2.Text = "Label2"
        Me.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ex1
        '
        Me.ex1.Location = New System.Drawing.Point(153, 216)
        Me.ex1.Name = "ex1"
        Me.ex1.Size = New System.Drawing.Size(75, 23)
        Me.ex1.TabIndex = 2
        Me.ex1.Text = "ปิดโปรแกรม"
        Me.ex1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 281)
        Me.Controls.Add(Me.ex1)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.ts3)
        Me.Controls.Add(Me.ts2)
        Me.Controls.Add(Me.ts1)
        Me.Name = "Form1"
        Me.Text = "VariableDemo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ts1 As System.Windows.Forms.Button
    Friend WithEvents ts2 As System.Windows.Forms.Button
    Friend WithEvents ts3 As System.Windows.Forms.Button
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents lb2 As System.Windows.Forms.Label
    Friend WithEvents ex1 As System.Windows.Forms.Button

End Class
