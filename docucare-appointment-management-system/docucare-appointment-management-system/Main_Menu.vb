Public Class Main_Menu


    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartupAnimation()
    End Sub

    Private Sub StartupAnimation()
        Startup_Fade.Show(Me)
        Startup_Fade.Location = Me.Location
        Startup_Fade.Location = New Point(Startup_Fade.Location.X + 8, Startup_Fade.Location.Y)
        FadeTimer.Interval = 25

        Dim path As String = My.Application.Info.DirectoryPath
        path = path.Replace("docucare-appointment-management-system\docucare-appointment-management-system\bin\Debug", "Assets\open.wav")
        My.Computer.Audio.Play(path)

        FadeTimer.Start()

    End Sub

    Private Sub FadeTimer_Tick(sender As System.Object, e As System.EventArgs) Handles FadeTimer.Tick
        If Startup_Fade.Opacity = 0 Then
            Startup_Fade.Hide()
            Startup_Fade.Close()
            FadeTimer.Stop()
        Else
            Startup_Fade.Opacity -= 0.01
        End If
    End Sub

    Private Sub MM_NewBtn_Click(sender As Object, e As EventArgs) Handles MM_NewBtn.Click
        AddPatient.Show()
    End Sub

    Private Sub MM_Panel_Paint(sender As Object, e As PaintEventArgs) Handles MM_Panel.Paint

    End Sub
End Class
