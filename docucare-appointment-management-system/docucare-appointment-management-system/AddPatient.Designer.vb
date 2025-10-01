<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Age = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.ContactNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Allergies = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Height = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Weight = New System.Windows.Forms.TextBox()
        Me.Weigh = New System.Windows.Forms.Label()
        Me.BloodType = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EmergencyContact = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MedicalConditions = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MiddleName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(28, 32)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(368, 20)
        Me.FirstName.TabIndex = 0
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(28, 126)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(368, 20)
        Me.LastName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name:"
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(28, 181)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(33, 20)
        Me.Age.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gender:"
        '
        'Gender
        '
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gender.Location = New System.Drawing.Point(78, 180)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(122, 21)
        Me.Gender.TabIndex = 4
        '
        'ContactNum
        '
        Me.ContactNum.Location = New System.Drawing.Point(28, 394)
        Me.ContactNum.Name = "ContactNum"
        Me.ContactNum.Size = New System.Drawing.Size(368, 20)
        Me.ContactNum.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contact No.:"
        '
        'Allergies
        '
        Me.Allergies.Location = New System.Drawing.Point(28, 284)
        Me.Allergies.Name = "Allergies"
        Me.Allergies.Size = New System.Drawing.Size(368, 20)
        Me.Allergies.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Allergies (if any):"
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.Save.FlatAppearance.BorderSize = 6
        Me.Save.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.ForeColor = System.Drawing.Color.Transparent
        Me.Save.Location = New System.Drawing.Point(28, 515)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(200, 35)
        Me.Save.TabIndex = 12
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.FlatAppearance.BorderSize = 6
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(235, 515)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 35)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Height
        '
        Me.Height.Location = New System.Drawing.Point(222, 181)
        Me.Height.Name = "Height"
        Me.Height.Size = New System.Drawing.Size(72, 20)
        Me.Height.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Height (in cm):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(277, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 16
        '
        'Weight
        '
        Me.Weight.Location = New System.Drawing.Point(319, 181)
        Me.Weight.Name = "Weight"
        Me.Weight.Size = New System.Drawing.Size(74, 20)
        Me.Weight.TabIndex = 6
        '
        'Weigh
        '
        Me.Weigh.AutoSize = True
        Me.Weigh.Location = New System.Drawing.Point(316, 165)
        Me.Weigh.Name = "Weigh"
        Me.Weigh.Size = New System.Drawing.Size(76, 13)
        Me.Weigh.TabIndex = 17
        Me.Weigh.Text = "Weight (in kg):"
        '
        'BloodType
        '
        Me.BloodType.FormattingEnabled = True
        Me.BloodType.Items.AddRange(New Object() {"Male", "Female"})
        Me.BloodType.Location = New System.Drawing.Point(28, 232)
        Me.BloodType.Name = "BloodType"
        Me.BloodType.Size = New System.Drawing.Size(122, 21)
        Me.BloodType.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Blood Type:"
        '
        'EmergencyContact
        '
        Me.EmergencyContact.Location = New System.Drawing.Point(28, 450)
        Me.EmergencyContact.Name = "EmergencyContact"
        Me.EmergencyContact.Size = New System.Drawing.Size(368, 20)
        Me.EmergencyContact.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 434)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Emergency Contact No.:"
        '
        'MedicalConditions
        '
        Me.MedicalConditions.Location = New System.Drawing.Point(28, 340)
        Me.MedicalConditions.Name = "MedicalConditions"
        Me.MedicalConditions.Size = New System.Drawing.Size(368, 20)
        Me.MedicalConditions.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Medical Conditions (if any):"
        '
        'MiddleName
        '
        Me.MiddleName.Location = New System.Drawing.Point(28, 78)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(368, 20)
        Me.MiddleName.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Middle Name:"
        '
        'AddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 662)
        Me.Controls.Add(Me.MiddleName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MedicalConditions)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.EmergencyContact)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BloodType)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Weight)
        Me.Controls.Add(Me.Weigh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Height)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Allergies)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ContactNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddPatient"
        Me.Text = "Add New Patient Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FirstName As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Age As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Gender As ComboBox
    Friend WithEvents ContactNum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Allergies As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Save As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Height As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Weight As TextBox
    Friend WithEvents Weigh As Label
    Friend WithEvents BloodType As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents EmergencyContact As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents MedicalConditions As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents MiddleName As TextBox
    Friend WithEvents Label9 As Label
End Class
