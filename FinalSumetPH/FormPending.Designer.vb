<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPending
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
        Me.ComboMonth = New System.Windows.Forms.ComboBox()
        Me.ComboYear = New System.Windows.Forms.ComboBox()
        Me.ButtonShowData = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ประจำเดือน"
        '
        'ComboMonth
        '
        Me.ComboMonth.FormattingEnabled = True
        Me.ComboMonth.Location = New System.Drawing.Point(52, 64)
        Me.ComboMonth.Name = "ComboMonth"
        Me.ComboMonth.Size = New System.Drawing.Size(121, 24)
        Me.ComboMonth.TabIndex = 1
        '
        'ComboYear
        '
        Me.ComboYear.FormattingEnabled = True
        Me.ComboYear.Location = New System.Drawing.Point(201, 64)
        Me.ComboYear.Name = "ComboYear"
        Me.ComboYear.Size = New System.Drawing.Size(121, 24)
        Me.ComboYear.TabIndex = 2
        '
        'ButtonShowData
        '
        Me.ButtonShowData.BackColor = System.Drawing.Color.Red
        Me.ButtonShowData.ForeColor = System.Drawing.Color.White
        Me.ButtonShowData.Location = New System.Drawing.Point(352, 60)
        Me.ButtonShowData.Name = "ButtonShowData"
        Me.ButtonShowData.Size = New System.Drawing.Size(124, 30)
        Me.ButtonShowData.TabIndex = 3
        Me.ButtonShowData.Text = "แสดงข้อมูล"
        Me.ButtonShowData.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(484, 343)
        Me.DataGridView1.TabIndex = 4
        '
        'FormPending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final.My.Resources.Resources.g
        Me.ClientSize = New System.Drawing.Size(539, 470)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonShowData)
        Me.Controls.Add(Me.ComboYear)
        Me.Controls.Add(Me.ComboMonth)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPending"
        Me.Text = "ตรวจสอบผู้ค้างชำระ"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents ComboYear As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonShowData As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
