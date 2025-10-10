Public Class ConsultationForm

    Private Sub ConsultationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure FlowLayoutPanel for prescriptions
        FlowPanelPrescriptions.AutoScroll = True
        FlowPanelPrescriptions.FlowDirection = FlowDirection.TopDown
        FlowPanelPrescriptions.WrapContents = False
        FlowPanelPrescriptions.BackColor = Color.WhiteSmoke
        FlowPanelPrescriptions.BorderStyle = BorderStyle.FixedSingle
        FlowPanelPrescriptions.HorizontalScroll.Enabled = False
        FlowPanelPrescriptions.HorizontalScroll.Visible = False

        ' Resize cards whenever panel resizes
        AddHandler FlowPanelPrescriptions.SizeChanged, AddressOf ResizePrescriptionCards
    End Sub

    Private Sub ResizePrescriptionCards(sender As Object, e As EventArgs)
        Dim panel = FlowPanelPrescriptions
        Dim newWidth As Integer = panel.ClientSize.Width - panel.Padding.Horizontal - 5
        For Each card As Panel In panel.Controls
            card.Width = newWidth
        Next
    End Sub

    ' Add Prescription
    Private Sub ButtonAddPrescription_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim presForm As New Prescriptions()

        If presForm.ShowDialog() = DialogResult.OK Then
            ' Calculate card width
            Dim cardWidth As Integer = FlowPanelPrescriptions.ClientSize.Width - FlowPanelPrescriptions.Padding.Horizontal - 5

            ' Create prescription card
            Dim prescriptionCard As New Panel()
            prescriptionCard.BackColor = Color.White
            prescriptionCard.BorderStyle = BorderStyle.FixedSingle
            prescriptionCard.Width = cardWidth
            prescriptionCard.Height = 50
            prescriptionCard.Margin = New Padding(3)

            ' Create label
            Dim lbl As New Label()
            lbl.AutoSize = False
            lbl.Text = $"{presForm.SelectedMedicine} {presForm.SelectedDose} mg, {presForm.SelectedDuration} days, every {presForm.SelectedFrequency} hours"
            lbl.Font = New Font("Segoe UI", 9, FontStyle.Regular)
            lbl.TextAlign = ContentAlignment.MiddleLeft
            lbl.Dock = DockStyle.Fill
            lbl.Padding = New Padding(5, 0, 0, 0)

            ' Remove button
            Dim btnRemove As New Button()
            btnRemove.Text = "Remove"
            btnRemove.Width = 70
            btnRemove.Height = 28
            btnRemove.BackColor = Color.Firebrick
            btnRemove.ForeColor = Color.White
            btnRemove.FlatStyle = FlatStyle.Flat
            btnRemove.Dock = DockStyle.Right
            btnRemove.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            btnRemove.Margin = New Padding(0)
            AddHandler btnRemove.Click, Sub()
                                            FlowPanelPrescriptions.Controls.Remove(prescriptionCard)
                                            ResizePrescriptionCards(Nothing, Nothing)
                                        End Sub

            ' Add to card
            prescriptionCard.Controls.Add(btnRemove)
            prescriptionCard.Controls.Add(lbl)

            ' Add to FlowLayoutPanel
            FlowPanelPrescriptions.Controls.Add(prescriptionCard)

            ' Re-adjust widths after adding
            ResizePrescriptionCards(Nothing, Nothing)
        End If
    End Sub

    ' Save Consultation
    Private Sub CreateConsultation_Click(sender As Object, e As EventArgs) Handles CreateConsultation.Click
        If String.IsNullOrWhiteSpace(Symptoms.Text) Then
            MessageBox.Show("Please enter symptoms.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Symptoms.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(Diagnosis.Text) Then
            MessageBox.Show("Please enter a diagnosis.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Diagnosis.Focus()
            Return
        End If

        If FlowPanelPrescriptions.Controls.Count = 0 Then
            MessageBox.Show("Please add at least one prescription.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Build summary
        Dim summary As String = "=== Consultation Summary ===" & Environment.NewLine & Environment.NewLine
        summary &= "Symptoms: " & Symptoms.Text & Environment.NewLine
        summary &= "Diagnosis: " & Diagnosis.Text & Environment.NewLine
        summary &= Environment.NewLine & "Prescriptions:" & Environment.NewLine

        For Each card As Panel In FlowPanelPrescriptions.Controls
            For Each ctrl As Control In card.Controls
                If TypeOf ctrl Is Label Then
                    summary &= "- " & CType(ctrl, Label).Text & Environment.NewLine
                End If
            Next
        Next

        summary &= Environment.NewLine & "Additional Notes: " &
                   If(String.IsNullOrWhiteSpace(Notes.Text), "None", Notes.Text) & Environment.NewLine

        MessageBox.Show(summary, "Consultation Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    ' Cancel button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show(
           "Are you sure you want to cancel? Any unsaved information will be lost.",
           "Cancel Consultation",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning
       )
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
