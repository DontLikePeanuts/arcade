Public Class Form3
    'Variável global
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'Fecha o formulário 4
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        'Mostra o formulário 2
        Form2.Show()
        Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Ciclo IF para saber que formulário reiniciar
        If Form1.F = 1 Then
            Form4.Close()
            Form4.Show()
            Close()
        ElseIf Form1.F = 2 Then
            Form5.Close()
            Form5.Show()
            Close()
        ElseIf Form1.F = 3 Then
            Form6.Close()
            Form6.Show()
            Close()
        ElseIf Form1.F = 0 Then
            Form7.Close()
            Form7.Show()
            Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Ciclo IF para saber que formulário mostrar
        If Form1.F = 1 Then
            Form4.Timer1.Start()
            Form4.Show()
            Close()
        ElseIf Form1.F = 2 Then
            Form5.Show()
            Close()
        ElseIf Form1.F = 3 Then
            Form6.Show()
            Close()
        ElseIf Form1.F = 0 Then
            Form7.Show()
            Close()
        End If
    End Sub
End Class