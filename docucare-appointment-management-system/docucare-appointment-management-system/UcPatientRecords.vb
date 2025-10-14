Public Class UcPatientRecords
    Private MainContentPanel As Panel

    Public Sub New(parent As Panel)
        InitializeComponent()
        MainContentPanel = parent
    End Sub

    Private Sub UcPatientRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatientCards()
    End Sub

    Public Sub LoadPatientCards()
        FlowLayoutPanel1.Controls.Clear()

        ' Loop through all patients
        For Each p As Patient In PatientData.Patients
            ' ✅ Pass both MainContentPanel and patient data
            Dim card As New UcPatientCard(MainContentPanel, p)
            card.Width = 280   ' wider for more info
            card.Height = 200  ' taller for readability
           
            FlowLayoutPanel1.Controls.Add(card)
        Next

        ' ✅ Add "+ Add New Patient" card-style button
        Dim btnAdd As New Button With {
            .Text = "+ Add New Patient",
            .Width = 280,
            .Height = 200,
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .BackColor = Color.White,
            .FlatStyle = FlatStyle.Flat
        }
        btnAdd.FlatAppearance.BorderColor = Color.LightGray
        btnAdd.FlatAppearance.BorderSize = 1
        AddHandler btnAdd.Click, AddressOf OpenAddPatientForm
        FlowLayoutPanel1.Controls.Add(btnAdd)

    End Sub

    Private Sub OpenAddPatientForm(sender As Object, e As EventArgs)
        Dim frmAdd As New AddPatient()
        frmAdd.ShowDialog()  ' Wait for user to finish adding

        ' Refresh cards after closing AddPatient
        LoadPatientCards()
    End Sub

    Private Sub NavbarMenu_Click(sender As Object, e As EventArgs) Handles NavbarMenu.Click
        MainContentPanel.Controls.Clear()
        Dim addMainMenu As New UcMainMenu(MainContentPanel)
        addMainMenu.Dock = DockStyle.Fill
        MainContentPanel.Controls.Add(addMainMenu)
    End Sub
End Class
