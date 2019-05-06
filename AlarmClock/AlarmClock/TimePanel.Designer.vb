<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DigitLED4 = New AlarmClock.DigitLED()
        Me.DigitLED1 = New AlarmClock.DigitLED()
        Me.DigitLED2 = New AlarmClock.DigitLED()
        Me.DigitLED3 = New AlarmClock.DigitLED()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = ":"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.DigitLED4)
        Me.Panel1.Controls.Add(Me.DigitLED1)
        Me.Panel1.Controls.Add(Me.DigitLED2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DigitLED3)
        Me.Panel1.Location = New System.Drawing.Point(31, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 55)
        Me.Panel1.TabIndex = 5
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(125, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "PM"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(125, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "AM"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DigitLED4
        '
        Me.DigitLED4.AutoSize = True
        Me.DigitLED4.Location = New System.Drawing.Point(101, 16)
        Me.DigitLED4.Name = "DigitLED4"
        Me.DigitLED4.Size = New System.Drawing.Size(13, 13)
        Me.DigitLED4.TabIndex = 3
        Me.DigitLED4.Text = "0"
        '
        'DigitLED1
        '
        Me.DigitLED1.AutoSize = True
        Me.DigitLED1.Location = New System.Drawing.Point(28, 16)
        Me.DigitLED1.Name = "DigitLED1"
        Me.DigitLED1.Size = New System.Drawing.Size(13, 13)
        Me.DigitLED1.TabIndex = 0
        Me.DigitLED1.Text = "0"
        '
        'DigitLED2
        '
        Me.DigitLED2.AutoSize = True
        Me.DigitLED2.Location = New System.Drawing.Point(47, 16)
        Me.DigitLED2.Name = "DigitLED2"
        Me.DigitLED2.Size = New System.Drawing.Size(13, 13)
        Me.DigitLED2.TabIndex = 1
        Me.DigitLED2.Text = "0"
        '
        'DigitLED3
        '
        Me.DigitLED3.AutoSize = True
        Me.DigitLED3.Location = New System.Drawing.Point(82, 16)
        Me.DigitLED3.Name = "DigitLED3"
        Me.DigitLED3.Size = New System.Drawing.Size(13, 13)
        Me.DigitLED3.TabIndex = 2
        Me.DigitLED3.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TimePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TimePanel"
        Me.Size = New System.Drawing.Size(281, 144)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DigitLED1 As DigitLED
    Friend WithEvents DigitLED2 As DigitLED
    Friend WithEvents DigitLED3 As DigitLED
    Friend WithEvents Label1 As Label
    Friend WithEvents DigitLED4 As DigitLED
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
