<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcMainMenu
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
        Me.MM_Panel = New System.Windows.Forms.Panel()
        Me.MM_RPanel = New System.Windows.Forms.Panel()
        Me.MM_Dashboard = New System.Windows.Forms.DataGridView()
        Me.MM_Calendar = New System.Windows.Forms.MonthCalendar()
        Me.MM_LPanel = New System.Windows.Forms.Panel()
        Me.MM_Buttons = New System.Windows.Forms.TableLayoutPanel()
        Me.MM_QuitBtn = New System.Windows.Forms.Button()
        Me.HistoryBtn = New System.Windows.Forms.Button()
        Me.AppointmentBtn = New System.Windows.Forms.Button()
        Me.PatientRecordsBtn = New System.Windows.Forms.Button()
        Me.MM_NewBtn = New System.Windows.Forms.Button()
        Me.MM_Title = New System.Windows.Forms.PictureBox()
        Me.MM_Panel.SuspendLayout()
        Me.MM_RPanel.SuspendLayout()
        CType(Me.MM_Dashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MM_LPanel.SuspendLayout()
        Me.MM_Buttons.SuspendLayout()
        CType(Me.MM_Title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MM_Panel
        '
        Me.MM_Panel.BackgroundImage = Global.docucare_appointment_management_system.My.Resources.Resources.bg_alt
        Me.MM_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MM_Panel.Controls.Add(Me.MM_RPanel)
        Me.MM_Panel.Controls.Add(Me.MM_LPanel)
        Me.MM_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MM_Panel.Location = New System.Drawing.Point(0, 0)
        Me.MM_Panel.Name = "MM_Panel"
        Me.MM_Panel.Size = New System.Drawing.Size(784, 501)
        Me.MM_Panel.TabIndex = 1
        '
        'MM_RPanel
        '
        Me.MM_RPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MM_RPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MM_RPanel.Controls.Add(Me.MM_Dashboard)
        Me.MM_RPanel.Controls.Add(Me.MM_Calendar)
        Me.MM_RPanel.Location = New System.Drawing.Point(557, 0)
        Me.MM_RPanel.Name = "MM_RPanel"
        Me.MM_RPanel.Size = New System.Drawing.Size(227, 501)
        Me.MM_RPanel.TabIndex = 3
        '
        'MM_Dashboard
        '
        Me.MM_Dashboard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MM_Dashboard.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.MM_Dashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MM_Dashboard.Location = New System.Drawing.Point(0, 212)
        Me.MM_Dashboard.Name = "MM_Dashboard"
        Me.MM_Dashboard.Size = New System.Drawing.Size(227, 289)
        Me.MM_Dashboard.TabIndex = 1
        '
        'MM_Calendar
        '
        Me.MM_Calendar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MM_Calendar.BackColor = System.Drawing.SystemColors.Window
        Me.MM_Calendar.Location = New System.Drawing.Point(0, 0)
        Me.MM_Calendar.Name = "MM_Calendar"
        Me.MM_Calendar.TabIndex = 0
        '
        'MM_LPanel
        '
        Me.MM_LPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MM_LPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MM_LPanel.Controls.Add(Me.MM_Buttons)
        Me.MM_LPanel.Controls.Add(Me.MM_Title)
        Me.MM_LPanel.Location = New System.Drawing.Point(0, 0)
        Me.MM_LPanel.Name = "MM_LPanel"
        Me.MM_LPanel.Size = New System.Drawing.Size(227, 501)
        Me.MM_LPanel.TabIndex = 2
        '
        'MM_Buttons
        '
        Me.MM_Buttons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MM_Buttons.BackColor = System.Drawing.Color.Transparent
        Me.MM_Buttons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MM_Buttons.ColumnCount = 1
        Me.MM_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MM_Buttons.Controls.Add(Me.MM_QuitBtn, 0, 4)
        Me.MM_Buttons.Controls.Add(Me.HistoryBtn, 0, 3)
        Me.MM_Buttons.Controls.Add(Me.AppointmentBtn, 0, 2)
        Me.MM_Buttons.Controls.Add(Me.PatientRecordsBtn, 0, 1)
        Me.MM_Buttons.Controls.Add(Me.MM_NewBtn, 0, 0)
        Me.MM_Buttons.Location = New System.Drawing.Point(0, 117)
        Me.MM_Buttons.Name = "MM_Buttons"
        Me.MM_Buttons.RowCount = 6
        Me.MM_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.MM_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.MM_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.MM_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.MM_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.MM_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.MM_Buttons.Size = New System.Drawing.Size(227, 384)
        Me.MM_Buttons.TabIndex = 2
        '
        'MM_QuitBtn
        '
        Me.MM_QuitBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MM_QuitBtn.Location = New System.Drawing.Point(20, 187)
        Me.MM_QuitBtn.Name = "MM_QuitBtn"
        Me.MM_QuitBtn.Size = New System.Drawing.Size(186, 39)
        Me.MM_QuitBtn.TabIndex = 4
        Me.MM_QuitBtn.Text = "Quit to Desktop"
        Me.MM_QuitBtn.UseVisualStyleBackColor = True
        '
        'HistoryBtn
        '
        Me.HistoryBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HistoryBtn.Location = New System.Drawing.Point(20, 141)
        Me.HistoryBtn.Name = "HistoryBtn"
        Me.HistoryBtn.Size = New System.Drawing.Size(186, 39)
        Me.HistoryBtn.TabIndex = 3
        Me.HistoryBtn.Text = "History"
        Me.HistoryBtn.UseVisualStyleBackColor = True
        '
        'AppointmentBtn
        '
        Me.AppointmentBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AppointmentBtn.Location = New System.Drawing.Point(20, 95)
        Me.AppointmentBtn.Name = "AppointmentBtn"
        Me.AppointmentBtn.Size = New System.Drawing.Size(186, 39)
        Me.AppointmentBtn.TabIndex = 2
        Me.AppointmentBtn.Text = "Appointments"
        Me.AppointmentBtn.UseVisualStyleBackColor = True
        '
        'PatientRecordsBtn
        '
        Me.PatientRecordsBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PatientRecordsBtn.Location = New System.Drawing.Point(20, 49)
        Me.PatientRecordsBtn.Name = "PatientRecordsBtn"
        Me.PatientRecordsBtn.Size = New System.Drawing.Size(186, 39)
        Me.PatientRecordsBtn.TabIndex = 1
        Me.PatientRecordsBtn.Text = "Patient Records"
        Me.PatientRecordsBtn.UseVisualStyleBackColor = True
        '
        'MM_NewBtn
        '
        Me.MM_NewBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MM_NewBtn.Location = New System.Drawing.Point(20, 3)
        Me.MM_NewBtn.Name = "MM_NewBtn"
        Me.MM_NewBtn.Size = New System.Drawing.Size(186, 39)
        Me.MM_NewBtn.TabIndex = 0
        Me.MM_NewBtn.Text = "Add New Patient"
        Me.MM_NewBtn.UseVisualStyleBackColor = True
        '
        'MM_Title
        '
        Me.MM_Title.BackgroundImage = Global.docucare_appointment_management_system.My.Resources.Resources.banner
        Me.MM_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MM_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MM_Title.Location = New System.Drawing.Point(0, 0)
        Me.MM_Title.Name = "MM_Title"
        Me.MM_Title.Size = New System.Drawing.Size(227, 78)
        Me.MM_Title.TabIndex = 1
        Me.MM_Title.TabStop = False
        '
        'UcMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MM_Panel)
        Me.Name = "UcMainMenu"
        Me.Size = New System.Drawing.Size(784, 501)
        Me.MM_Panel.ResumeLayout(False)
        Me.MM_RPanel.ResumeLayout(False)
        CType(Me.MM_Dashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MM_LPanel.ResumeLayout(False)
        Me.MM_Buttons.ResumeLayout(False)
        CType(Me.MM_Title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MM_Panel As Panel
    Friend WithEvents MM_RPanel As Panel
    Friend WithEvents MM_Dashboard As DataGridView
    Friend WithEvents MM_Calendar As MonthCalendar
    Friend WithEvents MM_LPanel As Panel
    Friend WithEvents MM_Buttons As TableLayoutPanel
    Friend WithEvents MM_QuitBtn As Button
    Friend WithEvents HistoryBtn As Button
    Friend WithEvents AppointmentBtn As Button
    Friend WithEvents PatientRecordsBtn As Button
    Friend WithEvents MM_NewBtn As Button
    Friend WithEvents MM_Title As PictureBox
End Class
