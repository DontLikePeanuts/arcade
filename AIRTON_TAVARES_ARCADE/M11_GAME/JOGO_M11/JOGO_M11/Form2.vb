Public Class Form2
    Dim Vert As Integer
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'Fecha a aplicação
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Abre o formulário 4
        Form4.Show()
        My.Computer.Audio.Stop()
        'Fecha o formulário atual
        Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form5.Show()
        My.Computer.Audio.Stop()
        Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Close()
        My.Computer.Audio.Stop()
        Form6.Show()
        'Assim que abrir o formulário 6 irá aparecer uma messagebox.
        MsgBox("AVAILABLE SOON!")
        'Após o utilizador clicar no botão 'OK' da messagebox fecha o formulário 6 e abre o formulário do menu 'Pause'.
        Form6.Close()
        Form3.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Close()
        Form7.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Musica
        My.Computer.Audio.Play(My.Resources.Retro, AudioPlayMode.Background)
        Timer1.Start()
        Timer1.Interval = 1
        'Atribui a localização de -300 na horizontal.
        PictureBox8.Left = -300
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Se a picturebox não sair do formulário visível, irá continuar a mover-se para a direita.
        If PictureBox8.Left <> 520 Then
            PictureBox8.Top = Vert
            PictureBox8.Left = PictureBox8.Left + 2
            'Após saida do formulário visivel, será gerado um valor random para atribuir uma nova localização vertical à picturebox8.
        ElseIf PictureBox8.Left = 520 Then
            PictureBox8.Left = -300
            Randomize()
            Vert = Int((Rnd() * 200) + 0)
        End If
    End Sub
End Class