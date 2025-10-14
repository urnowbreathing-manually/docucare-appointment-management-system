Public Class UcPatientCard
    Private MainContentPanel As Panel
    Public Property PatientData As Patient

    Public Sub New(parent As Panel, p As Patient)
        InitializeComponent()
        MainContentPanel = parent
        PatientData = p

        ' Display patient info on the card
        lblName.Text = "Patient Name: " & p.FullName
        lblContact.Text = "Contact: " & p.ContactNum
        lblEmergency.Text = "Emergency: " & p.EmergencyContact
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ' ✅ Clear previous controls first
        MainContentPanel.Controls.Clear()

        ' ✅ Create and load patient info user control
        Dim patientInfo As New UcPatientInfo(MainContentPanel)

        ' ✅ Pass this card’s patient data
        patientInfo.selectedpatient = Me.PatientData

        ' ✅ Dock and show
        patientInfo.Dock = DockStyle.Fill
        MainContentPanel.Controls.Add(patientInfo)
    End Sub
End Class
