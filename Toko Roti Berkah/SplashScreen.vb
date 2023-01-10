Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Myprogress.Value += 1
        If Myprogress.Value >= 100 Then
            Timer1.Stop()
            lbl_loading.Text = "Complate"
            Me.Hide()
            FLogin.Show()
        End If
    End Sub
End Class