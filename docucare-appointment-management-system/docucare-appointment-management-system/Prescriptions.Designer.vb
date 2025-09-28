<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prescriptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Medicine = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dose = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Duration = New System.Windows.Forms.TextBox()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Medicine Name:"
        '
        'Medicine
        '
        Me.Medicine.FormattingEnabled = True
        Me.Medicine.Location = New System.Drawing.Point(15, 37)
        Me.Medicine.Name = "Medicine"
        Me.Medicine.Size = New System.Drawing.Size(188, 21)
        Me.Medicine.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Dose (in mg):"
        '
        'Dose
        '
        Me.Dose.Location = New System.Drawing.Point(15, 90)
        Me.Dose.Name = "Dose"
        Me.Dose.Size = New System.Drawing.Size(81, 20)
        Me.Dose.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Duration (in days):"
        '
        'Duration
        '
        Me.Duration.Location = New System.Drawing.Point(15, 147)
        Me.Duration.Name = "Duration"
        Me.Duration.Size = New System.Drawing.Size(81, 20)
        Me.Duration.TabIndex = 20
        '
        'buttonSave
        '
        Me.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.buttonSave.ForeColor = System.Drawing.SystemColors.Control
        Me.buttonSave.Location = New System.Drawing.Point(12, 243)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(216, 32)
        Me.buttonSave.TabIndex = 21
        Me.buttonSave.Text = "Add"
        Me.buttonSave.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(12, 294)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(216, 32)
        Me.ButtonCancel.TabIndex = 22
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Prescriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 338)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.Duration)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Medicine)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Prescriptions"
        Me.Text = "Prescriptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Medicine As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Dose As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Duration As TextBox
    Friend WithEvents buttonSave As Button
    Friend WithEvents ButtonCancel As Button
End Class
