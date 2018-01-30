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
        Me.f2 = New System.Windows.Forms.Button()
        Me.f3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'f2
        '
        Me.f2.Location = New System.Drawing.Point(97, 58)
        Me.f2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.f2.Name = "f2"
        Me.f2.Size = New System.Drawing.Size(133, 37)
        Me.f2.TabIndex = 0
        Me.f2.Text = "EX Button"
        Me.f2.UseVisualStyleBackColor = True
        '
        'f3
        '
        Me.f3.Location = New System.Drawing.Point(97, 145)
        Me.f3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.f3.Name = "f3"
        Me.f3.Size = New System.Drawing.Size(133, 37)
        Me.f3.TabIndex = 1
        Me.f3.Text = "EX TextBox"
        Me.f3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 270)
        Me.Controls.Add(Me.f3)
        Me.Controls.Add(Me.f2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents f2 As System.Windows.Forms.Button
    Friend WithEvents f3 As System.Windows.Forms.Button

End Class
