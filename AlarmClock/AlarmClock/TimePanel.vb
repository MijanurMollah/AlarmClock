Public Class TimePanel

    Dim obj As New DigitLED
    Public x As New Boolean
    Public z As New Boolean
    Public a As New Boolean
    Public b As New Boolean
    Public c As New Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub TimePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DigitLED1.Font = obj.Var
        DigitLED2.Font = obj.Var
        DigitLED3.Font = obj.Var
        DigitLED4.Font = obj.Var
        Label1.Font = obj.Var
    End Sub

    Public Sub Setting(y As Integer)
        Form1.Timer1.Enabled = False
        If (z) Then
            Form1.TimePanel1.DigitLED1.Text = y
            If (y = 0) Then
                x = False
            End If
            z = False
                Cool()
                Exit Sub
            End If

            If (a) Then
            Form1.TimePanel1.DigitLED2.Text = y
            a = False
            Cool()
            If (Not x) Then
                For i As Integer = 5 To 8
                    Form1.btn(i).Enabled = False
                Next
            End If
            Exit Sub
            End If

            If (b) Then
            Form1.TimePanel1.DigitLED3.Text = y
            b = False
            Cool()
            Exit Sub
        End If


        If (c) Then
            Form1.TimePanel1.DigitLED4.Text = y
            c = False
            Cool()
            Exit Sub
        End If
    End Sub


    Public Sub Setting2(y As Integer, x As AlarmPanel)
        If (z) Then
            Form1.x.TimePanel1.DigitLED1.Text = y
            If (y = 0) Then
                Me.x = False
            End If
            z = False
            Cool()
            Exit Sub
        End If

        If (a) Then
            Form1.x.TimePanel1.DigitLED2.Text = y
            a = False
            Cool()
            If (Not Me.x) Then
                For i As Integer = 5 To 8
                    Form1.btn(i).Enabled = False
                Next
            End If
            Exit Sub
        End If

        If (b) Then
            Form1.x.TimePanel1.DigitLED3.Text = y
            b = False
            Cool()
            Exit Sub
        End If


        If (c) Then
            Form1.x.TimePanel1.DigitLED4.Text = y
            c = False
            Cool()
            Exit Sub
        End If
    End Sub

    Public Sub Cool()
        If (Not z) Then
            Form1.btn(1).Enabled = True
        End If
        If (Not x) Then
            For i As Integer = 0 To 9
                Form1.btn(i).Enabled = True
            Next
        End If
        If (Not a) Then
            For i As Integer = 2 To 4
                Form1.btn(i).Enabled = True
            Next
        End If
        If (Not b) Then
            For i As Integer = 5 To 9
                Form1.btn(i).Enabled = True
            Next
        End If
        If (Not c) Then
            For i As Integer = 0 To 9
                Form1.btn(i).Enabled = False
            Next
            Form1.Button_Ok.Enabled = True
        End If
    End Sub

    Public Sub reset()
        If (Form1.TabControl1.SelectedIndex = 0) Then
            Form1.TimePanel1.DigitLED1.Text = 0
            Form1.TimePanel1.DigitLED2.Text = 0
            Form1.TimePanel1.DigitLED3.Text = 0
            Form1.TimePanel1.DigitLED4.Text = 0
        End If
        If (Form1.TabControl1.SelectedIndex = 1) Then
            Form1.AlarmPanel1.TimePanel1.RadioButton1.Checked = True
            Form1.AlarmPanel1.TimePanel1.DigitLED1.Text = 0
            Form1.AlarmPanel1.TimePanel1.DigitLED2.Text = 0
            Form1.AlarmPanel1.TimePanel1.DigitLED3.Text = 0
            Form1.AlarmPanel1.TimePanel1.DigitLED4.Text = 0
        End If
        If (Form1.TabControl1.SelectedIndex = 2) Then
            Form1.AlarmPanel2.TimePanel1.RadioButton1.Checked = True
            Form1.AlarmPanel2.TimePanel1.DigitLED1.Text = 0
            Form1.AlarmPanel2.TimePanel1.DigitLED2.Text = 0
            Form1.AlarmPanel2.TimePanel1.DigitLED3.Text = 0
            Form1.AlarmPanel2.TimePanel1.DigitLED4.Text = 0
        End If
        If (Form1.TabControl1.SelectedIndex = 3) Then
            Form1.AlarmPanel3.TimePanel1.RadioButton1.Checked = True
            Form1.AlarmPanel3.TimePanel1.DigitLED1.Text = 0
            Form1.AlarmPanel3.TimePanel1.DigitLED2.Text = 0
            Form1.AlarmPanel3.TimePanel1.DigitLED3.Text = 0
            Form1.AlarmPanel3.TimePanel1.DigitLED4.Text = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Timer1.Enabled = False
        reset()
        Form1.Button_Ok.Enabled = False
        Form1.Height = 500
        Form1.Panel1.Visible = True
        For i As Integer = 0 To 9
            Form1.btn(i).Enabled = False
            If (Form1.btn(i).Text = 0 Or Form1.btn(i).Text = 1) Then
                Form1.btn(i).Enabled = True
            End If
        Next
        z = True
        a = True
        b = True
        c = True
        x = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.y = True
        reset()
    End Sub
End Class
