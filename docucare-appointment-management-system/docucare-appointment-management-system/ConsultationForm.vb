Public Class ConsultationForm

    Private Sub ConsultationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup unbound DataGridView
        DataGridViewPrescriptions.ColumnCount = 3
        DataGridViewPrescriptions.Columns(0).Name = "Medicine"
        DataGridViewPrescriptions.Columns(1).Name = "Dose"
        DataGridViewPrescriptions.Columns(2).Name = "Duration"
        DataGridViewPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Add Remove button column
        Dim btnColumn As New DataGridViewButtonColumn()
        btnColumn.Name = "Remove"
        btnColumn.Text = "Remove"
        btnColumn.UseColumnTextForButtonValue = True
        DataGridViewPrescriptions.Columns.Add(btnColumn)

        ' Optional: prevent user from editing Remove button column text
        DataGridViewPrescriptions.Columns("Remove").ReadOnly = True
    End Sub

    ' Add Prescription button click
    Private Sub ButtonAddPrescription_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim presForm As New Prescriptions()
        ' Show modal form
        If presForm.ShowDialog() = DialogResult.OK Then
            ' Add new row with selected prescription
            DataGridViewPrescriptions.Rows.Add(presForm.SelectedMedicine, presForm.SelectedDose, presForm.SelectedDuration)
        End If
    End Sub

    ' Handle Remove button clicks safely
    Private Sub DataGridViewPrescriptions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPrescriptions.CellContentClick
        ' Check if clicked column is Remove button
        If e.ColumnIndex = DataGridViewPrescriptions.Columns("Remove").Index AndAlso e.RowIndex >= 0 Then
            ' Ignore the new row placeholder
            If Not DataGridViewPrescriptions.Rows(e.RowIndex).IsNewRow Then
                DataGridViewPrescriptions.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles CreateConsultation.Click
        ' Validation: Required fields
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

        Dim hasPrescriptions As Boolean = False
        For Each row As DataGridViewRow In DataGridViewPrescriptions.Rows
            If Not row.IsNewRow Then
                hasPrescriptions = True
                Exit For
            End If
        Next

        If Not hasPrescriptions Then
            MessageBox.Show("Please add at least one prescription.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Build summary
        Dim summary As String = "=== Consultation Summary ===" & Environment.NewLine & Environment.NewLine
        summary &= "Symptoms: " & Symptoms.Text & Environment.NewLine
        summary &= "Diagnosis: " & Diagnosis.Text & Environment.NewLine
        summary &= Environment.NewLine & "Prescriptions:" & Environment.NewLine

        For Each row As DataGridViewRow In DataGridViewPrescriptions.Rows
            If Not row.IsNewRow Then
                summary &= "- Medicine: " & row.Cells("Medicine").Value.ToString() & ", "
                summary &= "Dose: " & row.Cells("Dose").Value.ToString() & ", "
                summary &= "Duration: " & row.Cells("Duration").Value.ToString() & Environment.NewLine
            End If
        Next

        summary &= Environment.NewLine & "Additional Notes: " & If(String.IsNullOrWhiteSpace(Notes.Text), "None", Notes.Text) & Environment.NewLine

        ' Show summary
        MessageBox.Show(summary, "Consultation Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Symptoms.TextChanged

    End Sub

    Private Sub Diagnosis_TextChanged(sender As Object, e As EventArgs) Handles Diagnosis.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Notes.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show(
       "Are you sure you want to cancel? Any unsaved information will be lost.",
       "Exit Application",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
   )
        If result = DialogResult.Yes Then
            Me.Close() ' closes the Add Patient form
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class
