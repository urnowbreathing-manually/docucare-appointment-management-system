<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcAppointment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NavbarMenu = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PatientInfoPanel = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AppointmentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateSched = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeSched = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addAppointmentBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientInfoPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.NavbarMenu)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 38)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Appointments"
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
        'PatientInfoPanel
        '
        Me.PatientInfoPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PatientInfoPanel.Controls.Add(Me.addAppointmentBtn)
        Me.PatientInfoPanel.Controls.Add(Me.MonthCalendar1)
        Me.PatientInfoPanel.Controls.Add(Me.DataGridView1)
        Me.PatientInfoPanel.Location = New System.Drawing.Point(0, 101)
        Me.PatientInfoPanel.Name = "PatientInfoPanel"
        Me.PatientInfoPanel.Size = New System.Drawing.Size(784, 400)
        Me.PatientInfoPanel.TabIndex = 7
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(548, 9)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentID, Me.PatientID, Me.PatientName, Me.DateSched, Me.TimeSched, Me.AppointmentType})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(527, 382)
        Me.DataGridView1.TabIndex = 2
        '
        'AppointmentID
        '
        Me.AppointmentID.HeaderText = "AppointmentID"
        Me.AppointmentID.Name = "AppointmentID"
        '
        'PatientID
        '
        Me.PatientID.HeaderText = "PatientID"
        Me.PatientID.Name = "PatientID"
        '
        'PatientName
        '
        Me.PatientName.HeaderText = "PatientName"
        Me.PatientName.Name = "PatientName"
        '
        'DateSched
        '
        Me.DateSched.HeaderText = "DateSched"
        Me.DateSched.Name = "DateSched"
        '
        'TimeSched
        '
        Me.TimeSched.HeaderText = "TimeSched"
        Me.TimeSched.Name = "TimeSched"
        '
        'AppointmentType
        '
        Me.AppointmentType.HeaderText = "AppointmentType"
        Me.AppointmentType.Name = "AppointmentType"
        '
        'addAppointmentBtn
        '
        Me.addAppointmentBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.addAppointmentBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addAppointmentBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.addAppointmentBtn.Location = New System.Drawing.Point(600, 266)
        Me.addAppointmentBtn.Name = "addAppointmentBtn"
        Me.addAppointmentBtn.Size = New System.Drawing.Size(137, 29)
        Me.addAppointmentBtn.TabIndex = 13
        Me.addAppointmentBtn.Text = "Add an appointment"
        Me.addAppointmentBtn.UseVisualStyleBackColor = False
        '
        'UcAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.docucare_appointment_management_system.My.Resources.Resources.bg_alt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.PatientInfoPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UcAppointment"
        Me.Size = New System.Drawing.Size(784, 501)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientInfoPanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents NavbarMenu As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PatientInfoPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AppointmentID As DataGridViewTextBoxColumn
    Friend WithEvents PatientID As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents DateSched As DataGridViewTextBoxColumn
    Friend WithEvents TimeSched As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentType As DataGridViewTextBoxColumn
    Friend WithEvents addAppointmentBtn As Button
End Class
