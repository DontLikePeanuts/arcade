Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Variável utilizada no menu 'Pause', para saber em que formulário o menu 'Pause' é ativado.
        Form1.F = 1
        PictureBox7.Hide()
        Timer1.Start()
        Timer1.Interval = 1
        'Atribui -300 e -99999 às respetivas pictureboxes ao carregar do formulário.
        PictureBox6.Top = -300
        PictureBox4.Top = -300
        PictureBox2.Top = -300
        PictureBox5.Top = -99999
    End Sub
    Dim Lateral As Integer
    Dim collision, VAR_UP, VAR_DOWN, VAR_LEFT, VAR_RIGHT As Boolean
    'Procedimento para registar teclas pressionadas
    Private Sub Game_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Set the Form's KeyPreview property to True
        Select Case e.KeyCode
            Case Keys.Escape
                If Form1.F = 1 Then
                    Form3.Show()
                    Hide()
                    Timer1.Stop()
                ElseIf Form1.F = 2 Then
                    Form3.Show()
                    Form5.Hide()
                ElseIf Form1.F = 3 Then
                    Form3.Show()
                    Form6.Hide()
                End If
            Case Keys.Up, Keys.W
                VAR_UP = True
            Case Keys.Left, Keys.A
                VAR_LEFT = True
            Case Keys.Right, Keys.D
                VAR_RIGHT = True
            Case Keys.Down, Keys.S
                VAR_DOWN = True
        End Select
    End Sub
    'Regista quando as teclas não estão pressionadas
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
        If PictureBox6.Top > 610 Then
            Randomize()
            Lateral = Int((Rnd() * 440) + 50)
            PictureBox6.Left = Lateral
            PictureBox6.Top = -30
        Else
            PictureBox6.Top = PictureBox6.Top + 20
        End If
        If PictureBox4.Top > 610 Then
            Randomize()
            Lateral = Int((Rnd() * 440) + 50)
            PictureBox4.Left = Lateral
            PictureBox4.Top = -30
        Else
            PictureBox4.Top = PictureBox4.Top + 20
        End If
        If PictureBox2.Top > 610 Then
            Randomize()
            Lateral = Int((Rnd() * 440) + 50)
            PictureBox2.Left = Lateral
            PictureBox2.Top = -30
        Else
            PictureBox2.Top = PictureBox2.Top + 20
        End If

        If VAR_UP = True Then
            PictureBox3.Top = PictureBox3.Top - 20
            'Se o utilizador sair do formulário visivel, aparece uma messagebox e vai para o menu 'Pause'
            If PictureBox3.Left < 0 Or PictureBox3.Left > 560 Then
                MsgBox("CHEATER!")
                Close()
                Form3.Show()
            End If
        ElseIf VAR_LEFT = True Then
            PictureBox3.Left = PictureBox3.Left - 20
            If PictureBox3.Left < 0 Or PictureBox3.Left > 560 Then
                MsgBox("CHEATER!")
                Close()
                Form3.Show()
            End If
        ElseIf VAR_RIGHT = True Then
            PictureBox3.Left = PictureBox3.Left + 20
            If PictureBox3.Left < 0 Or PictureBox3.Left > 560 Then
                MsgBox("CHEATER!")
                Close()
                Form3.Show()
            End If
        ElseIf VAR_DOWN = True Then
            PictureBox3.Top = PictureBox3.Top + 20
            If PictureBox3.Left < 0 Or PictureBox3.Left > 560 Then
                MsgBox("CHEATER!")
                Close()
                Form3.Show()
            End If
        End If
        'Atribui valores à textbox
        TextBox1.Text = Val(TextBox1.Text) + 1
        'collision = False
        'For Each PictureBox In Me.Controls
        'If PictureBox IsNot PictureBox3 AndAlso PictureBox3.Bounds.IntersectsWith(PictureBox.Bounds) Then
        'collision = True
        'Exit For
        'End If
        'Next

        'Verifica se o utilizador teve um acidente
        If PictureBox3.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            collision = True
            PictureBox5.Top = 129
            PictureBox5.Left = -273
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            'Verifica se o utilizador teve um acidente
        ElseIf PictureBox3.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            collision = True
            PictureBox5.Top = 129
            PictureBox5.Left = -273
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            'Verifica se o utilizador teve um acidente
        ElseIf PictureBox3.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            collision = True
            PictureBox5.Top = 129
            PictureBox5.Left = -273
            PictureBox2.Hide()
            PictureBox4.Hide()
            PictureBox6.Hide()
            'Verifica se alguns dos carros encontram-se em cima dos outros
        ElseIf PictureBox2.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            collision = False
            Randomize()
            Lateral = Int((Rnd() * 440) + 50)
            PictureBox2.Left = Lateral
            PictureBox2.Top = -(30 + 5)
            'Verifica se alguns dos carros encontram-se em cima dos outros
        ElseIf PictureBox2.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            collision = False
            Randomize()
            Lateral = Int((Rnd() * 440) + 50)
            PictureBox2.Left = Lateral
            PictureBox2.Top = -(30 + 5)
            'Verifica se alguns dos carros encontram-se em cima dos outros
        ElseIf PictureBox4.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            collision = False
            Randomize()
            Lateral = Int((Rnd() * 440) + 50)
            PictureBox4.Left = Lateral
            PictureBox4.Top = -(30 + 5)
            'Verifica se alguns dos carros encontram-se em cima dos outros
        ElseIf PictureBox4.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            collision = False
            Randomize()
            Lateral = Int((Rnd() * 440) + 50)
            PictureBox4.Left = Lateral
            PictureBox4.Top = -(30 + 5)
            'Verifica se alguns dos carros encontram-se em cima dos outros
        ElseIf PictureBox6.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            collision = False
            Randomize()
            Lateral = Int((Rnd() * 440) + 50)
            PictureBox6.Left = Lateral
            PictureBox6.Top = -(30 + 5)
            'Verifica se alguns dos carros encontram-se em cima dos outros
        ElseIf PictureBox6.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            collision = False
            Randomize()
            Lateral = Int((Rnd() * 440) + 50)
            PictureBox6.Left = Lateral
            PictureBox6.Top = -(30 + 5)
        Else
            collision = False
        End If
        'Se ocorreu um acidente, aparece uma messagebox.
        If collision = True Then
            Timer1.Stop()
            MsgBox("YOU CRASHED!" & vbCrLf & "FINAL SCORE = " & Val(TextBox1.Text))
            PictureBox7.Show()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Close()
        Form2.Show()
    End Sub
End Class