Public Class AlarmPanel
    Private Sub AlarmPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("train")
        ListBox1.Items.Add("cow")
        ListBox1.Items.Add("crickets")
        ListBox1.SelectedIndex = 0
    End Sub

    Public Sub play()
        If (ListBox1.SelectedItem = "cow") Then
            My.Computer.Audio.Play(My.Resources.cow, AudioPlayMode.Background)
        End If
        If (ListBox1.SelectedItem = "crickets") Then
            My.Computer.Audio.Play(My.Resources.crickets, AudioPlayMode.Background)
        End If
        If (ListBox1.SelectedItem = "train") Then
            My.Computer.Audio.Play(My.Resources.train1, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (Form1.AlarmPanel1.CheckBox1.Checked) Then
            Form1.CheckBox1.Checked = True
        Else
            Form1.CheckBox1.Checked = False
        End If
        If (Form1.AlarmPanel2.CheckBox1.Checked) Then
            Form1.CheckBox2.Checked = True
        Else
            Form1.CheckBox2.Checked = False
        End If
        If (Form1.AlarmPanel3.CheckBox1.Checked) Then
            Form1.CheckBox3.Checked = True
        Else
            Form1.CheckBox3.Checked = False
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Stop()
        If (Form1.TabControl1.SelectedIndex = 1) Then
            Form1.AlarmPanel1.PictureBox1.Image = AlarmClock.My.Resources.bee1
        End If
        If (Form1.TabControl1.SelectedIndex = 2) Then
            Form1.AlarmPanel2.PictureBox1.Image = AlarmClock.My.Resources.heart1
        End If
        If (Form1.TabControl1.SelectedIndex = 3) Then
            Form1.AlarmPanel3.PictureBox1.Image = AlarmClock.My.Resources.lily1
        End If
    End Sub
End Class
