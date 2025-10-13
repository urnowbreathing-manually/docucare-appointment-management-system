﻿Public Class UcAuthForm
    Private MainContentPanel As Panel
    ' Constructor receives parent panel
    Public Sub New(parent As Panel)
        InitializeComponent()
        MainContentPanel = parent
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        'error handling
        If String.IsNullOrWhiteSpace(UserName.Text) Then
            MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UserName.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(Password.Text) Then
            MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Password.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(VerifiedID.Text) Then
            MessageBox.Show("Verified ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            VerifiedID.Focus()
            Exit Sub
        End If

        'Account Verification
        For i As Integer = 0 To 3
            If UserName.Text = DataStore.personnelDB(i, 0) Then
                If Password.Text = DataStore.personnelDB(i, 1) Then
                    If VerifiedID.Text = DataStore.personnelDB(i, 2) Then
                        MainContentPanel.Controls.Clear()
                        Dim addMainMenu As New UcMainMenu(MainContentPanel)
                        addMainMenu.Dock = DockStyle.Fill
                        MainContentPanel.Controls.Add(addMainMenu)
                        Exit For
                    ElseIf i = 3 Then
                        MessageBox.Show("Incorrect ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        VerifiedID.Focus()
                        Exit Sub
                    End If
                ElseIf i = 3 Then
                    MessageBox.Show("Incorrect Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Password.Focus()
                    Exit Sub
                End If
            ElseIf i = 3 Then
                MessageBox.Show("User does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                UserName.Focus()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UserName.TextChanged
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Remove anything that's not a letter or space
        tb.Text = System.Text.RegularExpressions.Regex.Replace(tb.Text, "[^a-zA-Z\s]", "")

        ' Move cursor to the end (otherwise it jumps back)
        tb.SelectionStart = tb.Text.Length
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub VerifiedID_TextChanged(sender As Object, e As EventArgs) Handles VerifiedID.TextChanged

    End Sub
End Class
