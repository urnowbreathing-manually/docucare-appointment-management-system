﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Patient = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.EditPatientBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_Header_3 = New System.Windows.Forms.Label()
        Me.Allergies_Lbl = New System.Windows.Forms.Label()
        Me.MedCond_Lbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BloodType_Lbl = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewPrescriptions = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Billing = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NavbarMenu = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientInfoPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Patient.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Consultation.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DataGridViewPrescriptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Billing.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientInfoPanel
        '
        Me.PatientInfoPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PatientInfoPanel.Controls.Add(Me.TabControl1)
        Me.PatientInfoPanel.Location = New System.Drawing.Point(0, 98)
        Me.PatientInfoPanel.Name = "PatientInfoPanel"
        Me.PatientInfoPanel.Size = New System.Drawing.Size(784, 400)
        Me.PatientInfoPanel.TabIndex = 3
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
        Me.Panel3.Controls.Add(Me.EditPatientBtn)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Location = New System.Drawing.Point(-2, -3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(670, 316)
        Me.Panel3.TabIndex = 6
        '
        'EditPatientBtn
        '
        Me.EditPatientBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EditPatientBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EditPatientBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EditPatientBtn.FlatAppearance.BorderSize = 0
        Me.EditPatientBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditPatientBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EditPatientBtn.Location = New System.Drawing.Point(370, 271)
        Me.EditPatientBtn.Name = "EditPatientBtn"
        Me.EditPatientBtn.Size = New System.Drawing.Size(293, 36)
        Me.EditPatientBtn.TabIndex = 6
        Me.EditPatientBtn.Text = "Edit Info"
        Me.EditPatientBtn.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 3)
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
        Me.FullName_Lbl.Size = New System.Drawing.Size(74, 13)
        Me.FullName_Lbl.TabIndex = 1
        Me.FullName_Lbl.Text = "Patient Name:"
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
        Me.Consultation.Controls.Add(Me.TableLayoutPanel4)
        Me.Consultation.Controls.Add(Me.TableLayoutPanel3)
        Me.Consultation.Location = New System.Drawing.Point(4, 22)
        Me.Consultation.Name = "Consultation"
        Me.Consultation.Padding = New System.Windows.Forms.Padding(3)
        Me.Consultation.Size = New System.Drawing.Size(724, 310)
        Me.Consultation.TabIndex = 1
        Me.Consultation.Text = "Consultation"
        Me.Consultation.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.DataGridViewPrescriptions, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label17, 0, 2)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(362, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(362, 310)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'DataGridViewPrescriptions
        '
        Me.DataGridViewPrescriptions.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewPrescriptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewPrescriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPrescriptions.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridViewPrescriptions.Location = New System.Drawing.Point(3, 34)
        Me.DataGridViewPrescriptions.Name = "DataGridViewPrescriptions"
        Me.DataGridViewPrescriptions.Size = New System.Drawing.Size(356, 149)
        Me.DataGridViewPrescriptions.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Prescriptions"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Additional Notes:"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(362, 316)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Consultation ID:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Consultation Information"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Diagnosis:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Symptoms:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Reason:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Gender:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Age:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Patient Name:"
        '
        'Billing
        '
        Me.Billing.Controls.Add(Me.TableLayoutPanel7)
        Me.Billing.Controls.Add(Me.TableLayoutPanel6)
        Me.Billing.Controls.Add(Me.TableLayoutPanel5)
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
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.DataGridView1, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(362, 60)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(362, 250)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Billing ID:"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Patient Name:"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 94)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Date:"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label20, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label19, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label18, 0, 2)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 60)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(362, 121)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(724, 54)
        Me.TableLayoutPanel7.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Billing Information:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.Quantity, Me.UnitPrice, Me.Subtotal})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(356, 244)
        Me.DataGridView1.TabIndex = 7
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Width = 60
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.Name = "UnitPrice"
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
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
        Me.Consultation.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.DataGridViewPrescriptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Billing.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ContactNo_Lbl As Label
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
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Allergies_Lbl As Label
    Friend WithEvents BloodType_Lbl As Label
    Friend WithEvents Weight_Lbl As Label
    Friend WithEvents Height_Lbl As Label
    Friend WithEvents Lbl_Header2 As Label
    Friend WithEvents EmContactNo_Lbl As Label
    Friend WithEvents Gender_Lbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DataGridViewPrescriptions As DataGridView
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
End Class
