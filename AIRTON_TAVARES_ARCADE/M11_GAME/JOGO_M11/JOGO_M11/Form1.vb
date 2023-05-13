Public Class Form1
    Public F As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dará inicio ao timer1
        Timer1.Start()
        'Define o intervalo de cada thick, sendo 1000 = 1 segundo.
        Timer1.Interval = 15
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Ciclo que irá incrementar valores na progressabar1 até chegar ao valor de 100.
        If ProgressBar1.Value = 100 Then
            'Esconde o formulário atual
            Hide()
            'Abre o formulário que contém o menu principal da aplicação.
            Form2.Show()
            'Form3.Show()
            'Form4.Show()
            Timer1.Stop()
        Else
            'ProgressBar1.Increment(10)
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
    End Sub
End Class
