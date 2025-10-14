Public Class UcPatientInfo

    Inherits UserControl

    Private MainContentPanel As Panel
    ' Constructor receives parent panel

    Public Property selectedpatient As Patient
    Public Sub New(parent As Panel)
        InitializeComponent()
        MainContentPanel = parent
    End Sub
    Private Sub UcPatientInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If selectedpatient IsNot Nothing Then
            Label2.Text = "Full Name: " & selectedpatient.FullName
            Label3.Text = "Age: " & selectedpatient.Age.ToString()
            Label4.Text = "Gender: " & selectedpatient.Gender
            Label5.Text = "Contact No.: " & selectedpatient.ContactNum
            Label6.Text = "Emeregency Contact No.: " & selectedpatient.EmergencyContact
            Label8.Text = "Height: " & selectedpatient.Height.ToString()
            Label9.Text = "Weight: " & selectedpatient.Weight.ToString()
            Label10.Text = "Blood Type: " & selectedpatient.BloodType
            Label12.Text = "Allergies: " & selectedpatient.Allergies
            Label13.Text = "Medical Conditions: " & selectedpatient.MedicalConditions
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub NavbarMenu_Click(sender As Object, e As EventArgs) Handles NavbarMenu.Click
        MainContentPanel.Controls.Clear()
        Dim addMainMenu As New UcMainMenu(MainContentPanel)
        addMainMenu.Dock = DockStyle.Fill
        MainContentPanel.Controls.Add(addMainMenu)
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddPatient.ShowDialog()
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub
End Class
