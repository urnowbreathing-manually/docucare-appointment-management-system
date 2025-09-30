Public Class UcPatientInfo

    Inherits UserControl

    Private MainContentPanel As Panel
    ' Constructor receives parent panel
    Public Sub New(parent As Panel)
        InitializeComponent()
        MainContentPanel = parent
    End Sub

    Private Sub NavbarMenu_Click(sender As Object, e As EventArgs) Handles NavbarMenu.Click
        MainContentPanel.Controls.Clear()
        Dim addMainMenu As New UcMainMenu(MainContentPanel)
        addMainMenu.Dock = DockStyle.Fill
        MainContentPanel.Controls.Add(addMainMenu)
    End Sub

    Private Sub UcPatientInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim patientInfoSplit() As String = UcMainMenu.patientInfo.Split("|")
        If UcMainMenu.patientInfo <> "" Then
            FullName_Lbl.Text = "Full Name: " + patientInfoSplit(1) + ", " + patientInfoSplit(0)
            Age_Lbl.Text = "Age: " + patientInfoSplit(2)
            Height_Lbl.Text = "Height: " + patientInfoSplit(3)
            Weight_Lbl.Text = "Weight: " + patientInfoSplit(4)
            Gender_Lbl.Text = "Gender: " + patientInfoSplit(5)
            ContactNo_Lbl.Text = "Contact No.: " + patientInfoSplit(6)
            EmContactNo_Lbl.Text = "Emergency Contact No.: " + patientInfoSplit(7)
            BloodType_Lbl.Text = "Blood Type: " + patientInfoSplit(8)
            Allergies_Lbl.Text = "Allergies: " + patientInfoSplit(9)
            MedCond_Lbl.Text = "Medical Conditions: " + patientInfoSplit(10)

        End If
    End Sub


End Class
