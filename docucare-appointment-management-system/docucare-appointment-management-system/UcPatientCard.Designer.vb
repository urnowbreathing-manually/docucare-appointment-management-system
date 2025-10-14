<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcPatientCard
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
        Me.btnView = New System.Windows.Forms.Button()
        Me.lblEmergency = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(60, 196)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(266, 35)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View Patient Info"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lblEmergency
        '
        Me.lblEmergency.AutoSize = True
        Me.lblEmergency.BackColor = System.Drawing.Color.White
        Me.lblEmergency.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmergency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEmergency.Location = New System.Drawing.Point(18, 150)
        Me.lblEmergency.Name = "lblEmergency"
        Me.lblEmergency.Size = New System.Drawing.Size(165, 23)
        Me.lblEmergency.TabIndex = 11
        Me.lblEmergency.Text = "Emergency Contact"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.White
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblID.Location = New System.Drawing.Point(18, 71)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(95, 23)
        Me.lblID.TabIndex = 10
        Me.lblID.Text = "Patient ID:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.White
        Me.lblContact.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblContact.Location = New System.Drawing.Point(18, 113)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(115, 23)
        Me.lblContact.TabIndex = 9
        Me.lblContact.Text = "Contact No. :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblName.Location = New System.Drawing.Point(18, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(124, 23)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Patient Name:"
        '
        'UcPatientCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblEmergency)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnView)
        Me.Name = "UcPatientCard"
        Me.Size = New System.Drawing.Size(398, 253)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As Button
    Friend WithEvents lblEmergency As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblName As Label
End Class
