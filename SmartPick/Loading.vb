Public Class Loading
    Public CONTADOR As Integer

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CONTADOR < 100 Then
            ProgressBar1.Value = CONTADOR
            CONTADOR = CONTADOR + 1
        Else
            Timer1.Enabled = False
            Me.Hide()

        End If
    End Sub

End Class