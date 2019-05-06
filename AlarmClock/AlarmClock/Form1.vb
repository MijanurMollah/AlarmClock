Public Class Form1

    Dim tp As New DigitLED
    Public x As AlarmPanel
    Public btn(9) As Button
    Public y As Boolean = True
    Dim s As Integer = 1
    Dim s0 As String
    Dim s1 As String
    Dim s2 As String
    Dim s3 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shade()
        AlarmPanel1.PictureBox1.Image = AlarmClock.My.Resources.bee1
        AlarmPanel2.PictureBox1.Image = AlarmClock.My.Resources.heart1
        AlarmPanel3.PictureBox1.Image = AlarmClock.My.Resources.lily1
        PictureBox1.Image = AlarmClock.My.Resources.Flower
        AlarmPanel1.TimePanel1.RadioButton1.Checked = True
        AlarmPanel2.TimePanel1.RadioButton1.Checked = True
        AlarmPanel3.TimePanel1.RadioButton1.Checked = True
        btn = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button0}
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (y) Then
            TimePanel1.DigitLED1.Text = Date.Now.ToString("hh").Substring(0, 1)
            TimePanel1.DigitLED2.Text = Date.Now.ToString("hh").Substring(1)
            TimePanel1.DigitLED3.Text = Date.Now.ToString("mm").Substring(0, 1)
            TimePanel1.DigitLED4.Text = Date.Now.ToString("mm").Substring(1)
            If (Date.Now.ToString("tt") = "AM") Then
                TimePanel1.RadioButton1.Checked = True
            Else
                TimePanel1.RadioButton2.Checked = True
            End If
        Else
            s = s + 1
            If (s Mod 600 = 0) Then
                TimePanel1.DigitLED4.Text += 1
                If (TimePanel1.DigitLED4.Text = 10) Then
                    TimePanel1.DigitLED4.Text = 0
                    TimePanel1.DigitLED3.Text += 1
                    If (TimePanel1.DigitLED3.Text = 6) Then
                        TimePanel1.DigitLED3.Text = 0
                        If (TimePanel1.DigitLED1.Text = 0) Then
                            TimePanel1.DigitLED2.Text += 1
                            If (TimePanel1.DigitLED2.Text = 10) Then
                                TimePanel1.DigitLED2.Text = 0
                                TimePanel1.DigitLED1.Text = 1
                            End If
                        Else
                            If (TimePanel1.DigitLED2.Text < 2) Then
                                TimePanel1.DigitLED2.Text += 1
                                If (TimePanel1.RadioButton1.Checked And TimePanel1.DigitLED2.Text = 2) Then
                                    TimePanel1.RadioButton2.Checked = True
                                Else
                                    TimePanel1.RadioButton1.Checked = True
                                End If
                            Else
                                TimePanel1.DigitLED2.Text = 1
                                TimePanel1.DigitLED1.Text = 0

                            End If
                        End If
                    End If
                End If
            End If
        End If
        s0 = TimePanel1.DigitLED1.Text & TimePanel1.DigitLED2.Text & ":" & TimePanel1.DigitLED3.Text &
        TimePanel1.DigitLED4.Text
        If (AlarmPanel1.CheckBox1.Checked And s1 = s0) Then
            If (AlarmPanel1.TimePanel1.RadioButton1.Checked And TimePanel1.RadioButton1.Checked) Then
                AlarmPanel1.PictureBox1.Image = AlarmClock.My.Resources.Bee
                AlarmPanel1.play()
            ElseIf (AlarmPanel1.TimePanel1.RadioButton2.Checked And TimePanel1.RadioButton2.Checked) Then
                AlarmPanel1.PictureBox1.Image = AlarmClock.My.Resources.Bee
                AlarmPanel1.play()
            End If
        End If
        If (AlarmPanel2.CheckBox1.Checked And s2 = s0) Then
            If (AlarmPanel2.TimePanel1.RadioButton1.Checked And TimePanel1.RadioButton1.Checked) Then
                AlarmPanel2.PictureBox1.Image = AlarmClock.My.Resources.Heart
                AlarmPanel2.play()
            ElseIf (AlarmPanel2.TimePanel1.RadioButton2.Checked And TimePanel1.RadioButton2.Checked) Then
                AlarmPanel2.PictureBox1.Image = AlarmClock.My.Resources.Heart
                AlarmPanel2.play()
            End If
        End If
        If (AlarmPanel3.CheckBox1.Checked And s3 = s0) Then
            If (AlarmPanel3.TimePanel1.RadioButton1.Checked And TimePanel1.RadioButton1.Checked) Then
                AlarmPanel3.PictureBox1.Image = AlarmClock.My.Resources.Lily
                AlarmPanel3.play()
            ElseIf (AlarmPanel3.TimePanel1.RadioButton2.Checked And TimePanel1.RadioButton2.Checked) Then
                AlarmPanel3.PictureBox1.Image = AlarmClock.My.Resources.Lily
                AlarmPanel3.play()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click,
            Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button0.Click
        Dim button As Button = sender
        If (TabControl1.SelectedIndex = 0) Then
            TimePanel1.Setting(button.Text)
        Else
            If (TabControl1.SelectedIndex = 1) Then
                x = AlarmPanel1
                x.TimePanel1.Setting2(button.Text, x)
            End If
            If (TabControl1.SelectedIndex = 2) Then
                x = AlarmPanel2
                x.TimePanel1.Setting2(button.Text, x)
            End If
            If (TabControl1.SelectedIndex = 3) Then
                x = AlarmPanel3
                x.TimePanel1.Setting2(button.Text, x)
            End If
        End If
    End Sub

    Public Sub shade()
        Panel1.Visible = False
        Me.Height = 370
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        y = True
        Timer1.Enabled = True
        shade()
        If (TabControl1.SelectedIndex = 1) Then
            AlarmPanel1.TimePanel1.DigitLED1.Text = 0
            AlarmPanel1.TimePanel1.DigitLED2.Text = 0
            AlarmPanel1.TimePanel1.DigitLED3.Text = 0
            AlarmPanel1.TimePanel1.DigitLED4.Text = 0
        End If
        If (TabControl1.SelectedIndex = 2) Then
            AlarmPanel2.TimePanel1.DigitLED1.Text = 0
            AlarmPanel2.TimePanel1.DigitLED2.Text = 0
            AlarmPanel2.TimePanel1.DigitLED3.Text = 0
            AlarmPanel2.TimePanel1.DigitLED4.Text = 0
        End If
        If (TabControl1.SelectedIndex = 3) Then
            AlarmPanel3.TimePanel1.DigitLED1.Text = 0
            AlarmPanel3.TimePanel1.DigitLED2.Text = 0
            AlarmPanel3.TimePanel1.DigitLED3.Text = 0
            AlarmPanel3.TimePanel1.DigitLED4.Text = 0
        End If
    End Sub

    Private Sub Button_Ok_Click(sender As Object, e As EventArgs) Handles Button_Ok.Click
        shade()
        s1 = AlarmPanel1.TimePanel1.DigitLED1.Text & AlarmPanel1.TimePanel1.DigitLED2.Text & ":" &
            AlarmPanel1.TimePanel1.DigitLED3.Text & AlarmPanel1.TimePanel1.DigitLED4.Text
        s2 = AlarmPanel2.TimePanel1.DigitLED1.Text & AlarmPanel2.TimePanel1.DigitLED2.Text & ":" &
            AlarmPanel2.TimePanel1.DigitLED3.Text & AlarmPanel2.TimePanel1.DigitLED4.Text
        s3 = AlarmPanel3.TimePanel1.DigitLED1.Text & AlarmPanel3.TimePanel1.DigitLED2.Text & ":" &
            AlarmPanel3.TimePanel1.DigitLED3.Text & AlarmPanel3.TimePanel1.DigitLED4.Text
        If (TabControl1.SelectedIndex = 0) Then
            y = False
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            AlarmPanel1.CheckBox1.Checked = True
        Else
            AlarmPanel1.CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            AlarmPanel2.CheckBox1.Checked = True
        Else
            AlarmPanel2.CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            AlarmPanel3.CheckBox1.Checked = True
        Else
            AlarmPanel3.CheckBox1.Checked = False
        End If
    End Sub
End Class
