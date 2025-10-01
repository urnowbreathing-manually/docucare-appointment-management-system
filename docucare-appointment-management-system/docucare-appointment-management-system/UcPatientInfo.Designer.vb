<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcPatientInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PatientInfoPanel = New System.Windows.Forms.Panel()
        Me.EditPatientBtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Patient = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_Header_3 = New System.Windows.Forms.Label()
        Me.Allergies_Lbl = New System.Windows.Forms.Label()
        Me.MedCond_Lbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Weight_Lbl = New System.Windows.Forms.Label()
        Me.Height_Lbl = New System.Windows.Forms.Label()
        Me.Lbl_Header2 = New System.Windows.Forms.Label()
        Me.EmContactNo_Lbl = New System.Windows.Forms.Label()
        Me.ContactNo_Lbl = New System.Windows.Forms.Label()
        Me.Gender_Lbl = New System.Windows.Forms.Label()
        Me.Age_Lbl = New System.Windows.Forms.Label()
        Me.FullName_Lbl = New System.Windows.Forms.Label()
        Me.Lbl_Header1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Consultation = New System.Windows.Forms.TabPage()
        Me.Billing = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NavbarMenu = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BloodType_Lbl = New System.Windows.Forms.Label()
        Me.PatientInfoPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Patient.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientInfoPanel
        '
        Me.PatientInfoPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PatientInfoPanel.Controls.Add(Me.EditPatientBtn)
        Me.PatientInfoPanel.Controls.Add(Me.TabControl1)
        Me.PatientInfoPanel.Location = New System.Drawing.Point(0, 98)
        Me.PatientInfoPanel.Name = "PatientInfoPanel"
        Me.PatientInfoPanel.Size = New System.Drawing.Size(784, 400)
        Me.PatientInfoPanel.TabIndex = 3
        '
        'EditPatientBtn
        '
        Me.EditPatientBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EditPatientBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EditPatientBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EditPatientBtn.FlatAppearance.BorderSize = 0
        Me.EditPatientBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditPatientBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EditPatientBtn.Location = New System.Drawing.Point(271, 355)
        Me.EditPatientBtn.Name = "EditPatientBtn"
        Me.EditPatientBtn.Size = New System.Drawing.Size(293, 36)
        Me.EditPatientBtn.TabIndex = 6
        Me.EditPatientBtn.Text = "Edit Info"
        Me.EditPatientBtn.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Patient)
        Me.TabControl1.Controls.Add(Me.Consultation)
        Me.TabControl1.Controls.Add(Me.Billing)
        Me.TabControl1.Location = New System.Drawing.Point(53, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(732, 336)
        Me.TabControl1.TabIndex = 4
        '
        'Patient
        '
        Me.Patient.Controls.Add(Me.Panel3)
        Me.Patient.Controls.Add(Me.Panel6)
        Me.Patient.Location = New System.Drawing.Point(4, 22)
        Me.Patient.Name = "Patient"
        Me.Patient.Padding = New System.Windows.Forms.Padding(3)
        Me.Patient.Size = New System.Drawing.Size(724, 310)
        Me.Patient.TabIndex = 0
        Me.Patient.Text = "Patient"
        Me.Patient.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Location = New System.Drawing.Point(-2, -3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(670, 316)
        Me.Panel3.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_Header_3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Allergies_Lbl, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MedCond_Lbl, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(361, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(309, 158)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'Lbl_Header_3
        '
        Me.Lbl_Header_3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_Header_3.AutoSize = True
        Me.Lbl_Header_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Header_3.Location = New System.Drawing.Point(3, 16)
        Me.Lbl_Header_3.Name = "Lbl_Header_3"
        Me.Lbl_Header_3.Size = New System.Drawing.Size(167, 20)
        Me.Lbl_Header_3.TabIndex = 1
        Me.Lbl_Header_3.Text = "Medical Information"
        '
        'Allergies_Lbl
        '
        Me.Allergies_Lbl.AutoSize = True
        Me.Allergies_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Allergies_Lbl.Location = New System.Drawing.Point(3, 52)
        Me.Allergies_Lbl.Name = "Allergies_Lbl"
        Me.Allergies_Lbl.Size = New System.Drawing.Size(49, 13)
        Me.Allergies_Lbl.TabIndex = 2
        Me.Allergies_Lbl.Text = "Allergies:"
        '
        'MedCond_Lbl
        '
        Me.MedCond_Lbl.AutoSize = True
        Me.MedCond_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedCond_Lbl.Location = New System.Drawing.Point(3, 104)
        Me.MedCond_Lbl.Name = "MedCond_Lbl"
        Me.MedCond_Lbl.Size = New System.Drawing.Size(99, 13)
        Me.MedCond_Lbl.TabIndex = 3
        Me.MedCond_Lbl.Text = "Medical Conditions:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BloodType_Lbl, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Weight_Lbl, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Height_Lbl, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Lbl_Header2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.EmContactNo_Lbl, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ContactNo_Lbl, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Gender_Lbl, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Age_Lbl, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FullName_Lbl, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Lbl_Header1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(362, 316)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Weight_Lbl
        '
        Me.Weight_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Weight_Lbl.AutoSize = True
        Me.Weight_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weight_Lbl.Location = New System.Drawing.Point(3, 257)
        Me.Weight_Lbl.Name = "Weight_Lbl"
        Me.Weight_Lbl.Size = New System.Drawing.Size(44, 13)
        Me.Weight_Lbl.TabIndex = 8
        Me.Weight_Lbl.Text = "Weight:"
        '
        'Height_Lbl
        '
        Me.Height_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Height_Lbl.AutoSize = True
        Me.Height_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Height_Lbl.Location = New System.Drawing.Point(3, 226)
        Me.Height_Lbl.Name = "Height_Lbl"
        Me.Height_Lbl.Size = New System.Drawing.Size(41, 13)
        Me.Height_Lbl.TabIndex = 7
        Me.Height_Lbl.Text = "Height:"
        '
        'Lbl_Header2
        '
        Me.Lbl_Header2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_Header2.AutoSize = True
        Me.Lbl_Header2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Header2.Location = New System.Drawing.Point(3, 191)
        Me.Lbl_Header2.Name = "Lbl_Header2"
        Me.Lbl_Header2.Size = New System.Drawing.Size(159, 20)
        Me.Lbl_Header2.TabIndex = 6
        Me.Lbl_Header2.Text = "Health Information"
        '
        'EmContactNo_Lbl
        '
        Me.EmContactNo_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.EmContactNo_Lbl.AutoSize = True
        Me.EmContactNo_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmContactNo_Lbl.Location = New System.Drawing.Point(3, 164)
        Me.EmContactNo_Lbl.Name = "EmContactNo_Lbl"
        Me.EmContactNo_Lbl.Size = New System.Drawing.Size(123, 13)
        Me.EmContactNo_Lbl.TabIndex = 5
        Me.EmContactNo_Lbl.Text = "Emergency Contact No.:"
        '
        'ContactNo_Lbl
        '
        Me.ContactNo_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ContactNo_Lbl.AutoSize = True
        Me.ContactNo_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNo_Lbl.Location = New System.Drawing.Point(3, 133)
        Me.ContactNo_Lbl.Name = "ContactNo_Lbl"
        Me.ContactNo_Lbl.Size = New System.Drawing.Size(67, 13)
        Me.ContactNo_Lbl.TabIndex = 4
        Me.ContactNo_Lbl.Text = "Contact No.:"
        '
        'Gender_Lbl
        '
        Me.Gender_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Gender_Lbl.AutoSize = True
        Me.Gender_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender_Lbl.Location = New System.Drawing.Point(3, 102)
        Me.Gender_Lbl.Name = "Gender_Lbl"
        Me.Gender_Lbl.Size = New System.Drawing.Size(45, 13)
        Me.Gender_Lbl.TabIndex = 3
        Me.Gender_Lbl.Text = "Gender:"
        '
        'Age_Lbl
        '
        Me.Age_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Age_Lbl.AutoSize = True
        Me.Age_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age_Lbl.Location = New System.Drawing.Point(3, 71)
        Me.Age_Lbl.Name = "Age_Lbl"
        Me.Age_Lbl.Size = New System.Drawing.Size(29, 13)
        Me.Age_Lbl.TabIndex = 2
        Me.Age_Lbl.Text = "Age:"
        '
        'FullName_Lbl
        '
        Me.FullName_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FullName_Lbl.AutoSize = True
        Me.FullName_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName_Lbl.Location = New System.Drawing.Point(3, 40)
        Me.FullName_Lbl.Name = "FullName_Lbl"
        Me.FullName_Lbl.Size = New System.Drawing.Size(57, 13)
        Me.FullName_Lbl.TabIndex = 1
        Me.FullName_Lbl.Text = "Full Name:"
        '
        'Lbl_Header1
        '
        Me.Lbl_Header1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_Header1.AutoSize = True
        Me.Lbl_Header1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Header1.Location = New System.Drawing.Point(3, 5)
        Me.Lbl_Header1.Name = "Lbl_Header1"
        Me.Lbl_Header1.Size = New System.Drawing.Size(176, 20)
        Me.Lbl_Header1.TabIndex = 0
        Me.Lbl_Header1.Text = "Personal Information"
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(-5, 149)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(365, 27)
        Me.Panel6.TabIndex = 5
        '
        'Consultation
        '
        Me.Consultation.Location = New System.Drawing.Point(4, 22)
        Me.Consultation.Name = "Consultation"
        Me.Consultation.Padding = New System.Windows.Forms.Padding(3)
        Me.Consultation.Size = New System.Drawing.Size(724, 310)
        Me.Consultation.TabIndex = 1
        Me.Consultation.Text = "Consultation"
        Me.Consultation.UseVisualStyleBackColor = True
        '
        'Billing
        '
        Me.Billing.Location = New System.Drawing.Point(4, 22)
        Me.Billing.Name = "Billing"
        Me.Billing.Size = New System.Drawing.Size(724, 310)
        Me.Billing.TabIndex = 2
        Me.Billing.Text = "Billing"
        Me.Billing.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.NavbarMenu)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 38)
        Me.Panel1.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(335, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 20)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Patient Information"
        '
        'NavbarMenu
        '
        Me.NavbarMenu.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.NavbarMenu.Location = New System.Drawing.Point(700, 3)
        Me.NavbarMenu.Name = "NavbarMenu"
        Me.NavbarMenu.Size = New System.Drawing.Size(75, 29)
        Me.NavbarMenu.TabIndex = 6
        Me.NavbarMenu.Text = "Menu"
        Me.NavbarMenu.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.docucare_appointment_management_system.My.Resources.Resources.banner
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 35)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'BloodType_Lbl
        '
        Me.BloodType_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BloodType_Lbl.AutoSize = True
        Me.BloodType_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodType_Lbl.Location = New System.Drawing.Point(3, 291)
        Me.BloodType_Lbl.Name = "BloodType_Lbl"
        Me.BloodType_Lbl.Size = New System.Drawing.Size(64, 13)
        Me.BloodType_Lbl.TabIndex = 9
        Me.BloodType_Lbl.Text = "Blood Type:"
        '
        'UcPatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.docucare_appointment_management_system.My.Resources.Resources.bg_alt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PatientInfoPanel)
        Me.Name = "UcPatientInfo"
        Me.Size = New System.Drawing.Size(784, 501)
        Me.PatientInfoPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Patient.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PatientInfoPanel As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Patient As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents EditPatientBtn As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents MedCond_Lbl As Label
    Friend WithEvents Lbl_Header_3 As Label
    Friend WithEvents Allergies_Lbl As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Weight_Lbl As Label
    Friend WithEvents Height_Lbl As Label
    Friend WithEvents Lbl_Header2 As Label
    Friend WithEvents EmContactNo_Lbl As Label
    Friend WithEvents ContactNo_Lbl As Label
    Friend WithEvents Gender_Lbl As Label
    Friend WithEvents Age_Lbl As Label
    Friend WithEvents FullName_Lbl As Label
    Friend WithEvents Lbl_Header1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Consultation As TabPage
    Friend WithEvents Billing As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents NavbarMenu As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents BloodType_Lbl As Label
End Class
