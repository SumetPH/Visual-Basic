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
        Me.lblShow = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkRegular = New System.Windows.Forms.CheckBox()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.chkUnderline = New System.Windows.Forms.CheckBox()
        Me.chkStrikeout = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblShow
        '
        Me.lblShow.BackColor = System.Drawing.Color.White
        Me.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShow.ForeColor = System.Drawing.Color.Blue
        Me.lblShow.Location = New System.Drawing.Point(22, 34)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(633, 214)
        Me.lblShow.TabIndex = 0
        Me.lblShow.Text = "Visual Basic 2010"
        Me.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Font Style :"
        '
        'chkRegular
        '
        Me.chkRegular.AutoSize = True
        Me.chkRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRegular.Location = New System.Drawing.Point(39, 328)
        Me.chkRegular.Name = "chkRegular"
        Me.chkRegular.Size = New System.Drawing.Size(101, 29)
        Me.chkRegular.TabIndex = 2
        Me.chkRegular.Text = "Regular"
        Me.chkRegular.UseVisualStyleBackColor = True
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBold.Location = New System.Drawing.Point(39, 381)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(73, 29)
        Me.chkBold.TabIndex = 3
        Me.chkBold.Text = "Bold"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'chkItalic
        '
        Me.chkItalic.AutoSize = True
        Me.chkItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItalic.Location = New System.Drawing.Point(177, 381)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(73, 29)
        Me.chkItalic.TabIndex = 4
        Me.chkItalic.Text = "Italic"
        Me.chkItalic.UseVisualStyleBackColor = True
        '
        'chkUnderline
        '
        Me.chkUnderline.AutoSize = True
        Me.chkUnderline.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUnderline.Location = New System.Drawing.Point(304, 381)
        Me.chkUnderline.Name = "chkUnderline"
        Me.chkUnderline.Size = New System.Drawing.Size(117, 29)
        Me.chkUnderline.TabIndex = 5
        Me.chkUnderline.Text = "Underline"
        Me.chkUnderline.UseVisualStyleBackColor = True
        '
        'chkStrikeout
        '
        Me.chkStrikeout.AutoSize = True
        Me.chkStrikeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStrikeout.Location = New System.Drawing.Point(477, 381)
        Me.chkStrikeout.Name = "chkStrikeout"
        Me.chkStrikeout.Size = New System.Drawing.Size(111, 29)
        Me.chkStrikeout.TabIndex = 6
        Me.chkStrikeout.Text = "Strikeout"
        Me.chkStrikeout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 453)
        Me.Controls.Add(Me.chkStrikeout)
        Me.Controls.Add(Me.chkUnderline)
        Me.Controls.Add(Me.chkItalic)
        Me.Controls.Add(Me.chkBold)
        Me.Controls.Add(Me.chkRegular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblShow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblShow As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkRegular As System.Windows.Forms.CheckBox
    Friend WithEvents chkBold As System.Windows.Forms.CheckBox
    Friend WithEvents chkItalic As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnderline As System.Windows.Forms.CheckBox
    Friend WithEvents chkStrikeout As System.Windows.Forms.CheckBox

End Class
