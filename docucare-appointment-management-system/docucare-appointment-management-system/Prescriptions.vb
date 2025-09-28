Public Class Prescriptions

    Public Property SelectedMedicine As String
    Public Property SelectedDose As String
    Public Property SelectedDuration As String

    Private Sub Prescriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add medicine options
        Medicine.Items.AddRange(New String() {
            "Paracetamol",
            "Ibuprofen",
            "Amoxicillin",
            "Cephalexin",
            "Azithromycin",
            "Ciprofloxacin",
            "Metformin",
            "Lisinopril",
            "Cetirizine",
            "Loratadine",
            "Omeprazole",
            "Ranitidine",
            "Salbutamol",
            "Hydrocortisone cream",
            "Loperamide"
        })
        Medicine.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    ' Save button click
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        If String.IsNullOrWhiteSpace(Medicine.Text) Or String.IsNullOrWhiteSpace(Dose.Text) Or String.IsNullOrWhiteSpace(Duration.Text) Then
            MessageBox.Show("Please select medicine, dose, and duration.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SelectedMedicine = Medicine.Text
        SelectedDose = Dose.Text
        SelectedDuration = Duration.Text

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' Cancel button click
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dose_TextChanged(sender As Object, e As EventArgs) Handles Dose.TextChanged
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Keep only digits
        tb.Text = System.Text.RegularExpressions.Regex.Replace(tb.Text, "[^\d]", "")

        ' Limit to 3 characters (e.g., max age 999)
        If tb.Text.Length > 3 Then
            tb.Text = tb.Text.Substring(0, 3)
        End If

        ' Fix cursor position
        tb.SelectionStart = tb.Text.Length
    End Sub

    Private Sub Duration_TextChanged(sender As Object, e As EventArgs) Handles Duration.TextChanged
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Keep only digits
        tb.Text = System.Text.RegularExpressions.Regex.Replace(tb.Text, "[^\d]", "")

        ' Limit to 3 characters (e.g., max age 999)
        If tb.Text.Length > 3 Then
            tb.Text = tb.Text.Substring(0, 3)
        End If

        ' Fix cursor position
        tb.SelectionStart = tb.Text.Length
    End Sub
End Class
