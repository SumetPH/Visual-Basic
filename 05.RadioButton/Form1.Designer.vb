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
        Me.lblColor = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoRed = New System.Windows.Forms.RadioButton()
        Me.rdoGreen = New System.Windows.Forms.RadioButton()
        Me.rdoBlue = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColor
        '
        Me.lblColor.BackColor = System.Drawing.Color.White
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColor.Location = New System.Drawing.Point(72, 33)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(566, 208)
        Me.lblColor.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoBlue)
        Me.GroupBox1.Controls.Add(Me.rdoGreen)
        Me.GroupBox1.Controls.Add(Me.rdoRed)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COLOR"
        '
        'rdoRed
        '
        Me.rdoRed.AutoSize = True
        Me.rdoRed.Location = New System.Drawing.Point(31, 47)
        Me.rdoRed.Name = "rdoRed"
        Me.rdoRed.Size = New System.Drawing.Size(58, 21)
        Me.rdoRed.TabIndex = 0
        Me.rdoRed.TabStop = True
        Me.rdoRed.Text = "RED"
        Me.rdoRed.UseVisualStyleBackColor = True
        '
        'rdoGreen
        '
        Me.rdoGreen.AutoSize = True
        Me.rdoGreen.Location = New System.Drawing.Point(189, 46)
        Me.rdoGreen.Name = "rdoGreen"
        Me.rdoGreen.Size = New System.Drawing.Size(78, 21)
        Me.rdoGreen.TabIndex = 1
        Me.rdoGreen.TabStop = True
        Me.rdoGreen.Text = "GREEN"
        Me.rdoGreen.UseVisualStyleBackColor = True
        '
        'rdoBlue
        '
        Me.rdoBlue.AutoSize = True
        Me.rdoBlue.Location = New System.Drawing.Point(350, 47)
        Me.rdoBlue.Name = "rdoBlue"
        Me.rdoBlue.Size = New System.Drawing.Size(65, 21)
        Me.rdoBlue.TabIndex = 2
        Me.rdoBlue.TabStop = True
        Me.rdoBlue.Text = "BLUE"
        Me.rdoBlue.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(299, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 453)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rdoGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRed As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
