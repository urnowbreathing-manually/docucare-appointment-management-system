Public Class AddAppointment
    Private Sub AddAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        patientDropDown.Items.AddRange(New String() {
            "patientName1", "patientName2", "patientName3", "patientName4", "patientName5"
        })
        patientDropDown.DropDownStyle = ComboBoxStyle.DropDownList
        AppointmentType.Items.AddRange(New String() {
        "General Consultation",
        "Follow-up",
        "Check-up",
        "Laboratory Test"
    })
        AppointmentType.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles patientDropDown.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        ' Validate required fields
        If String.IsNullOrWhiteSpace(patientDropDown.Text) Or
       String.IsNullOrWhiteSpace(AppointmentType.Text) Or
       String.IsNullOrWhiteSpace(Reason.Text) Or
       String.IsNullOrWhiteSpace(Notes.Text) Or
       String.IsNullOrWhiteSpace(DateVal.Text) Then

            MessageBox.Show("Please fill out all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' pseudosave
        Dim info As String =
        "Appointment Saved!" & vbCrLf &
        "Patient: " & patientDropDown.Text & vbCrLf &
        "Type: " & AppointmentType.Text & vbCrLf &
        "Date: " & DateVal.Text & vbCrLf &
        "Reason: " & Reason.Text & vbCrLf &
        "Notes: " & Notes.Text

        MessageBox.Show(info, "Pseudo-Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub


    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class