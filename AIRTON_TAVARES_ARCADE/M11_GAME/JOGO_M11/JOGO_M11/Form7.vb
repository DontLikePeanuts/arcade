Public Class Form7
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Top <> 12 Then
            PictureBox1.Top = PictureBox1.Top + 1
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 1
        PictureBox1.Top = -100
        Form1.F = 0
    End Sub
    Private Sub Game_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Set the Form's KeyPreview property to True
        Select Case e.KeyCode
            Case Keys.Escape
                Form3.Show()
                Hide()
        End Select
    End Sub
End Class