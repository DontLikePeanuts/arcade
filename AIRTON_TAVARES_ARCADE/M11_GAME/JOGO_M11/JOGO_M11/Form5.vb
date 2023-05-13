Public Class Form5
    'Estrutura semelhante à do formulário 4
    Dim VAR_LEFT, VAR_RIGHT, VAR_NOKEY, VAR_NOKEY1, VAR_SHOOTL, VAR_SHOOTR, Collisionl, CollisionR As Boolean
    Dim VAR_SHOW, VAR_ZSPEED As Integer

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.F = 2
        VAR_SHOW = 2
        Timer1.Start()
        Timer1.Interval = 1
        Timer2.Start()
        Timer2.Interval = 1
        Timer3.Start()
        Timer3.Interval = 1
        Timer4.Start()
        Timer4.Interval = 1
        Timer5.Start()
        Timer5.Interval = 1
        Timer6.Start()
        Timer6.Interval = 1
        Timer7.Start()
        Timer7.Interval = 1
        VAR_ZSPEED = 3
        PictureBox5.Hide()
        PictureBox7.Hide()
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
                    Hide()
                ElseIf Form1.F = 3 Then
                    Form3.Show()
                    Form6.Hide()
                End If
            Case Keys.Left, Keys.A
                VAR_LEFT = True
                VAR_SHOW = 1
            Case Keys.Right, Keys.D
                VAR_RIGHT = True
                VAR_SHOW = 2
            Case Keys.Space
                If VAR_SHOW = 1 Then
                    VAR_SHOOTL = True
                    VAR_SHOOTR = False
                ElseIf VAR_SHOW = 2 Then
                    VAR_SHOOTL = False
                    VAR_SHOOTR = True
                End If
        End Select
    End Sub

    Private Sub Game_KeyUP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
            Case Keys.Left, Keys.A
                VAR_LEFT = False
                VAR_NOKEY1 = False
                VAR_NOKEY = True
            Case Keys.Right, Keys.D
                VAR_RIGHT = False
                VAR_NOKEY = False
                VAR_NOKEY1 = True
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If VAR_LEFT = True And VAR_SHOOTL = True Then
            PictureBox3.Show()
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox2.Left = PictureBox3.Left
            PictureBox3.Left = PictureBox3.Left - 5
            PictureBox4.Left = PictureBox2.Left
            PictureBox6.Left = PictureBox2.Left
        ElseIf VAR_LEFT = True And VAR_SHOOTL = False Then
            PictureBox3.Show()
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox2.Left = PictureBox3.Left
            PictureBox3.Left = PictureBox3.Left - 5
            PictureBox4.Left = PictureBox2.Left
            PictureBox6.Left = PictureBox2.Left
            PictureBox5.Left = PictureBox2.Left
        ElseIf VAR_RIGHT = True And VAR_SHOOTL = True Then
            PictureBox2.Show()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox2.Left = PictureBox2.Left + 5
            PictureBox3.Left = PictureBox2.Left
            PictureBox4.Left = PictureBox2.Left
            PictureBox6.Left = PictureBox2.Left
        ElseIf VAR_RIGHT = True And VAR_SHOOTL = False Then
            PictureBox2.Show()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox2.Left = PictureBox2.Left + 5
            PictureBox3.Left = PictureBox2.Left
            PictureBox4.Left = PictureBox2.Left
            PictureBox6.Left = PictureBox2.Left
            PictureBox5.Left = PictureBox2.Left
        ElseIf VAR_NOKEY = True Then
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Show()
            PictureBox6.Hide()
            PictureBox4.Left = PictureBox2.Left
        ElseIf VAR_NOKEY1 = True Then
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox6.Show()
            PictureBox6.Left = PictureBox2.Left
        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If VAR_LEFT = True And VAR_SHOOTR = True Then
            PictureBox3.Show()
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox2.Left = PictureBox3.Left
            PictureBox3.Left = PictureBox3.Left - 5
            PictureBox4.Left = PictureBox2.Left
            PictureBox6.Left = PictureBox2.Left
        ElseIf VAR_LEFT = True And VAR_SHOOTR = False Then
            PictureBox3.Show()
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox2.Left = PictureBox3.Left
            PictureBox3.Left = PictureBox3.Left - 5
            PictureBox4.Left = PictureBox2.Left
            PictureBox6.Left = PictureBox2.Left
            PictureBox7.Left = PictureBox2.Left
        ElseIf VAR_RIGHT = True And VAR_SHOOTR = True Then
            PictureBox2.Show()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox2.Left = PictureBox2.Left + 5
            PictureBox3.Left = PictureBox2.Left
            PictureBox4.Left = PictureBox2.Left
            PictureBox6.Left = PictureBox2.Left
        ElseIf VAR_RIGHT = True And VAR_SHOOTR = False Then
            PictureBox2.Show()
            PictureBox3.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            PictureBox2.Left = PictureBox2.Left + 5
            PictureBox3.Left = PictureBox2.Left
            PictureBox4.Left = PictureBox2.Left
            PictureBox6.Left = PictureBox2.Left
            PictureBox7.Left = PictureBox2.Left
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If VAR_SHOOTL = True Then
            PictureBox5.Show()
            If PictureBox5.Left < -10 Or Collisionl = True Then
                PictureBox5.Left = PictureBox2.Left
                VAR_SHOOTL = False
                PictureBox5.Hide()
                Collisionl = False
            ElseIf VAR_SHOOTL = True Then
                PictureBox5.Left = PictureBox5.Left - 10
            End If
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If VAR_SHOOTR = True Then
            PictureBox7.Show()
            If PictureBox7.Left > 860 Or CollisionR = True Then
                PictureBox7.Left = PictureBox2.Left + 50
                VAR_SHOOTR = False
                PictureBox7.Hide()
                CollisionR = False
            ElseIf VAR_SHOOTR = True Then
                PictureBox7.Left = PictureBox7.Left + 10
            End If
        End If
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If PictureBox8.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            Collisionl = True
            PictureBox8.Left = -100
            VAR_ZSPEED = VAR_ZSPEED + 1
            TextBox1.Text = Val(TextBox1.Text) + 25
        Else
            PictureBox8.Left = PictureBox8.Left + VAR_ZSPEED
        End If
    End Sub
    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If PictureBox9.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            CollisionR = True
            PictureBox9.Left = 880
            VAR_ZSPEED = VAR_ZSPEED + 1
            TextBox1.Text = Val(TextBox1.Text) + 25
        Else
            PictureBox9.Left = PictureBox9.Left - VAR_ZSPEED
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If PictureBox2.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            Timer6.Stop()
            Timer1.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer7.Stop()
            MsgBox("A ZOMBIE ATE YOUR BRAINS")
            Close()
            Form3.Show()
        ElseIf PictureBox2.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            Timer6.Stop()
            Timer1.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer7.Stop()
            MsgBox("A ZOMBIE ATE YOUR BRAINS")
            Close()
            Form3.Show()
        End If
    End Sub
End Class