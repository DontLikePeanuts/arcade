Public Class Form6
    'Estrutura semelhante à do formulário 4
    Dim VAR_UP, VAR_LEFT, VAR_RIGHT, VAR_DOWN, VAR_SHOOT, Collision, CollisionF As Boolean
    Dim VAR_SHOW, ALIEN_HORI As Integer

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.F = 3
        Timer1.Start()
        Timer1.Interval = 1
        Timer2.Start()
        Timer2.Interval = 1
        Timer3.Start()
        Timer3.Interval = 1
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        PictureBox10.Hide()
    End Sub
    Private Sub Game_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Set the Form's KeyPreview property to True
        Select Case e.KeyCode
            Case Keys.Escape
                If Form1.F = 1 Then
                    Form3.Show()
                    Hide()
                ElseIf Form1.F = 2 Then
                    Form3.Show()
                    Form5.Hide()
                ElseIf Form1.F = 3 Then
                    Form3.Show()
                    Hide()
                End If
            Case Keys.Up, Keys.W
                VAR_UP = True
            Case Keys.Left, Keys.A
                VAR_LEFT = True
            Case Keys.Right, Keys.D
                VAR_RIGHT = True
            Case Keys.Down, Keys.S
                VAR_DOWN = True
            Case Keys.Space
                If VAR_SHOW = 1 Then
                    VAR_SHOOT = True
                End If
        End Select
    End Sub
    Private Sub Game_KeyUP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
            Case Keys.Up, Keys.W
                VAR_UP = False
            Case Keys.Left, Keys.A
                VAR_LEFT = False
            Case Keys.Right, Keys.D
                VAR_RIGHT = False
            Case Keys.Down, Keys.S
                VAR_DOWN = False
        End Select
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If VAR_UP = True Then
            VAR_SHOW = 1
            PictureBox2.Show()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox2.Top = PictureBox2.Top - 3
            PictureBox3.Top = PictureBox2.Top
            PictureBox4.Top = PictureBox2.Top
            PictureBox5.Top = PictureBox2.Top
            PictureBox10.Top = PictureBox2.Top
        ElseIf VAR_LEFT = True Then
            VAR_SHOW = 0
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox5.Show()
            PictureBox2.Left = PictureBox2.Left - 3
            PictureBox3.Left = PictureBox2.Left
            PictureBox4.Left = PictureBox2.Left
            PictureBox5.Left = PictureBox2.Left
            PictureBox10.Left = PictureBox2.Left
        ElseIf VAR_RIGHT = True Then
            VAR_SHOW = 0
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Show()
            PictureBox5.Hide()
            PictureBox2.Left = PictureBox2.Left + 3
            PictureBox3.Left = PictureBox2.Left
            PictureBox4.Left = PictureBox2.Left
            PictureBox5.Left = PictureBox2.Left
            PictureBox10.Left = PictureBox2.Left
        ElseIf VAR_DOWN = True Then
            VAR_SHOW = 0
            PictureBox2.Hide()
            PictureBox3.Show()
            PictureBox4.Hide()
            PictureBox5.Hide()
            PictureBox2.Top = PictureBox2.Top + 3
            PictureBox3.Top = PictureBox2.Top
            PictureBox4.Top = PictureBox2.Top
            PictureBox5.Top = PictureBox2.Top
            PictureBox10.Top = PictureBox2.Top
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox6.Top > 350 Then
            Randomize()
            ALIEN_HORI = Int((Rnd() * 590) + 2)
            PictureBox6.Left = ALIEN_HORI
            PictureBox6.Top = -45
        Else
            PictureBox6.Top = PictureBox6.Top + 3
        End If
        If PictureBox7.Top > 350 Then
            Randomize()
            ALIEN_HORI = Int((Rnd() * 590) + 2)
            PictureBox7.Left = ALIEN_HORI
            PictureBox7.Top = -45
        Else
            PictureBox7.Top = PictureBox7.Top + 3
        End If
        If PictureBox8.Top > 350 Then
            Randomize()
            ALIEN_HORI = Int((Rnd() * 590) + 2)
            PictureBox8.Left = ALIEN_HORI
            PictureBox8.Top = -45
        Else
            PictureBox8.Top = PictureBox8.Top + 3
        End If
        If PictureBox9.Top > 350 Then
            Randomize()
            ALIEN_HORI = Int((Rnd() * 590) + 2)
            PictureBox9.Left = ALIEN_HORI
            PictureBox9.Top = -45
        Else
            PictureBox9.Top = PictureBox9.Top + 3
        End If
        If PictureBox3.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            Collision = True
            PictureBox5.Top = 129
            PictureBox5.Left = -273
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
        ElseIf PictureBox3.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            Collision = True
            PictureBox5.Top = 129
            PictureBox5.Left = -273
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
        ElseIf PictureBox3.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            Collision = True
            PictureBox5.Top = 129
            PictureBox5.Left = -273
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
        ElseIf PictureBox3.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            Collision = True
            PictureBox5.Top = 129
            PictureBox5.Left = -273
            PictureBox6.Hide()
            PictureBox7.Hide()
            PictureBox8.Hide()
            PictureBox9.Hide()
        ElseIf PictureBox6.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox6.Left = ALIEN_HORI
            PictureBox6.Top = -(30 + 5)
        ElseIf PictureBox6.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox6.Left = ALIEN_HORI
            PictureBox6.Top = -(30 + 5)
        ElseIf PictureBox6.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox6.Left = ALIEN_HORI
            PictureBox6.Top = -(30 + 5)
        ElseIf PictureBox7.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox7.Left = ALIEN_HORI
            PictureBox7.Top = -(30 + 5)
        ElseIf PictureBox7.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox7.Left = ALIEN_HORI
            PictureBox7.Top = -(30 + 5)
        ElseIf PictureBox7.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox7.Left = ALIEN_HORI
            PictureBox7.Top = -(30 + 5)
        ElseIf PictureBox8.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox8.Left = ALIEN_HORI
            PictureBox8.Top = -(30 + 5)
        ElseIf PictureBox8.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox8.Left = ALIEN_HORI
            PictureBox8.Top = -(30 + 5)
        ElseIf PictureBox8.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox8.Left = ALIEN_HORI
            PictureBox8.Top = -(30 + 5)
        ElseIf PictureBox9.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox9.Left = ALIEN_HORI
            PictureBox9.Top = -(30 + 5)
        ElseIf PictureBox9.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox9.Left = ALIEN_HORI
            PictureBox9.Top = -(30 + 5)
        ElseIf PictureBox9.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            Collision = False
            Randomize()
            ALIEN_HORI = Int((Rnd() * 440) + 50)
            PictureBox9.Left = ALIEN_HORI
            PictureBox9.Top = -(30 + 5)
        ElseIf PictureBox10.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            CollisionF = True
            PictureBox6.Enabled = False
            TextBox1.Text = Val(TextBox1.Text) + 100
        ElseIf PictureBox10.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            CollisionF = True
            PictureBox7.Enabled = False
            TextBox1.Text = Val(TextBox1.Text) + 100
        ElseIf PictureBox10.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            CollisionF = True
            PictureBox8.Enabled = False
            TextBox1.Text = Val(TextBox1.Text) + 100
        ElseIf PictureBox10.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            CollisionF = True
            PictureBox9.Enabled = False
            TextBox1.Text = Val(TextBox1.Text) + 100
        Else
            Collision = False
        End If
        If Collision = True Then
            Timer1.Stop()
            MsgBox("YOU CRASHED YOUR SPACESHIP!" & vbCrLf & "FINAL SCORE = " & Val(TextBox1.Text))
            PictureBox7.Show()
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If VAR_SHOOT = True Then
            If VAR_SHOW = 1 Then
                PictureBox10.Show()
                If PictureBox10.Top < -30 Or CollisionF = True Then
                    PictureBox10.Top = PictureBox10.Top - 50
                    VAR_SHOOT = False
                    PictureBox10.Hide()
                    Collision = False
                ElseIf VAR_SHOOT = True Then
                    PictureBox10.Top = PictureBox10.Top - 10
                End If
            End If
        End If
    End Sub
End Class