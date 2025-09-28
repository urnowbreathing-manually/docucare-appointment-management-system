Public Class UcMainMenu
    Inherits UserControl

    Private MainContentPanel As Panel
    ' Constructor receives parent panel
    Public Sub New(parent As Panel)
        InitializeComponent()
        MainContentPanel = parent
    End Sub
    Private Sub UcMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'StartupAnimation() ' Disabled for now, no animation or sound
    End Sub

    'Private Sub StartupAnimation()
    '    Startup_Fade.Show(Me)
    '    Startup_Fade.Location = Me.Location
    '    Startup_Fade.Location = New Point(Startup_Fade.Location.X + 8, Startup_Fade.Location.Y)
    '    FadeTimer.Interval = 25
    '
    '    Dim path As String = My.Application.Info.DirectoryPath
    '    path = path.Replace("docucare-appointment-management-system\docucare-appointment-management-system\bin\Debug", "Assets\open.wav")
    '    My.Computer.Audio.Play(path)
    '
    '    FadeTimer.Start()
    'End Sub

    'Private Sub FadeTimer_Tick(sender As System.Object, e As System.EventArgs) Handles FadeTimer.Tick
    '    If Startup_Fade.Opacity = 0 Then
    '        Startup_Fade.Hide()
    '        Startup_Fade.Close()
    '        FadeTimer.Stop()
    '    Else
    '        Startup_Fade.Opacity -= 0.01
    '    End If
    'End Sub

    Private Sub MM_NewBtn_Click(sender As Object, e As EventArgs) Handles MM_NewBtn.Click
        AddPatient.Show()
    End Sub

    Private Sub MM_Panel_Paint(sender As Object, e As PaintEventArgs) Handles MM_Panel.Paint
        ' Optional custom drawing
    End Sub

    Private Sub MM_QuitBtn_Click(sender As Object, e As EventArgs) Handles MM_QuitBtn.Click
        ' Confirm before exiting
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to quit?",
            "Exit Application",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub MM_RecordsBtn_Click(sender As Object, e As EventArgs) Handles MM_RecordsBtn.Click
        MainContentPanel.Controls.Clear()
        Dim addPatientInfo As New UcPatientInfo(MainContentPanel)
        addPatientInfo.Dock = DockStyle.Fill
        MainContentPanel.Controls.Add(addPatientInfo)
    End Sub

    Private Sub MM_ApptBtn_Click(sender As Object, e As EventArgs) Handles MM_ApptBtn.Click
        ConsultationForm.Show()
    End Sub
End Class
