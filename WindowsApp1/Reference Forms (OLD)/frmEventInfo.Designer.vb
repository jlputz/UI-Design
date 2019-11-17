<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventInfo
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
        Me.lblEventInfo = New System.Windows.Forms.Label()
        Me.lblEventType = New System.Windows.Forms.Label()
        Me.chkCeremonyEvent = New System.Windows.Forms.CheckBox()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.lblRehearsalDate = New System.Windows.Forms.Label()
        Me.lblGuestCount = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtEventType = New System.Windows.Forms.TextBox()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpRehearsalDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdEnterEventInfo = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEventInfo
        '
        Me.lblEventInfo.AutoSize = True
        Me.lblEventInfo.Font = New System.Drawing.Font("Franklin Gothic Medium", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblEventInfo.Name = "lblEventInfo"
        Me.lblEventInfo.Size = New System.Drawing.Size(261, 37)
        Me.lblEventInfo.TabIndex = 1
        Me.lblEventInfo.Text = "Event Information"
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventType.Location = New System.Drawing.Point(16, 66)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(88, 18)
        Me.lblEventType.TabIndex = 2
        Me.lblEventType.Text = "Event Type:"
        '
        'chkCeremonyEvent
        '
        Me.chkCeremonyEvent.AutoSize = True
        Me.chkCeremonyEvent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCeremonyEvent.Location = New System.Drawing.Point(19, 106)
        Me.chkCeremonyEvent.Name = "chkCeremonyEvent"
        Me.chkCeremonyEvent.Size = New System.Drawing.Size(281, 22)
        Me.chkCeremonyEvent.TabIndex = 3
        Me.chkCeremonyEvent.Text = "Does this event include a ceremony?"
        Me.chkCeremonyEvent.UseVisualStyleBackColor = True
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDate.Location = New System.Drawing.Point(16, 148)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(89, 18)
        Me.lblEventDate.TabIndex = 4
        Me.lblEventDate.Text = "Event Date:"
        '
        'lblRehearsalDate
        '
        Me.lblRehearsalDate.AutoSize = True
        Me.lblRehearsalDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRehearsalDate.Location = New System.Drawing.Point(16, 192)
        Me.lblRehearsalDate.Name = "lblRehearsalDate"
        Me.lblRehearsalDate.Size = New System.Drawing.Size(121, 18)
        Me.lblRehearsalDate.TabIndex = 5
        Me.lblRehearsalDate.Text = "Rehearsal Date:"
        '
        'lblGuestCount
        '
        Me.lblGuestCount.AutoSize = True
        Me.lblGuestCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestCount.Location = New System.Drawing.Point(16, 232)
        Me.lblGuestCount.Name = "lblGuestCount"
        Me.lblGuestCount.Size = New System.Drawing.Size(173, 18)
        Me.lblGuestCount.TabIndex = 6
        Me.lblGuestCount.Text = "Estimated Guest Count:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(195, 229)
        Me.MaskedTextBox1.Mask = "000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(37, 26)
        Me.MaskedTextBox1.TabIndex = 7
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'txtEventType
        '
        Me.txtEventType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventType.Location = New System.Drawing.Point(195, 63)
        Me.txtEventType.Name = "txtEventType"
        Me.txtEventType.Size = New System.Drawing.Size(272, 26)
        Me.txtEventType.TabIndex = 8
        '
        'dtpEventDate
        '
        Me.dtpEventDate.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventDate.Location = New System.Drawing.Point(195, 142)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(272, 26)
        Me.dtpEventDate.TabIndex = 9
        '
        'dtpRehearsalDate
        '
        Me.dtpRehearsalDate.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRehearsalDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRehearsalDate.Location = New System.Drawing.Point(195, 186)
        Me.dtpRehearsalDate.Name = "dtpRehearsalDate"
        Me.dtpRehearsalDate.Size = New System.Drawing.Size(272, 26)
        Me.dtpRehearsalDate.TabIndex = 10
        '
        'cmdEnterEventInfo
        '
        Me.cmdEnterEventInfo.BackColor = System.Drawing.Color.Gold
        Me.cmdEnterEventInfo.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnterEventInfo.Location = New System.Drawing.Point(19, 261)
        Me.cmdEnterEventInfo.Name = "cmdEnterEventInfo"
        Me.cmdEnterEventInfo.Size = New System.Drawing.Size(199, 44)
        Me.cmdEnterEventInfo.TabIndex = 14
        Me.cmdEnterEventInfo.Text = "Enter Event Info"
        Me.cmdEnterEventInfo.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Coral
        Me.cmdCancel.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(264, 261)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(199, 44)
        Me.cmdCancel.TabIndex = 15
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'frmEventInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 320)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdEnterEventInfo)
        Me.Controls.Add(Me.dtpRehearsalDate)
        Me.Controls.Add(Me.dtpEventDate)
        Me.Controls.Add(Me.txtEventType)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.lblGuestCount)
        Me.Controls.Add(Me.lblRehearsalDate)
        Me.Controls.Add(Me.lblEventDate)
        Me.Controls.Add(Me.chkCeremonyEvent)
        Me.Controls.Add(Me.lblEventType)
        Me.Controls.Add(Me.lblEventInfo)
        Me.Name = "frmEventInfo"
        Me.Text = "Event Information - The Treasury"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEventInfo As Label
    Friend WithEvents lblEventType As Label
    Friend WithEvents chkCeremonyEvent As CheckBox
    Friend WithEvents lblEventDate As Label
    Friend WithEvents lblRehearsalDate As Label
    Friend WithEvents lblGuestCount As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents txtEventType As TextBox
    Friend WithEvents dtpEventDate As DateTimePicker
    Friend WithEvents dtpRehearsalDate As DateTimePicker
    Friend WithEvents cmdEnterEventInfo As Button
    Friend WithEvents cmdCancel As Button
End Class
