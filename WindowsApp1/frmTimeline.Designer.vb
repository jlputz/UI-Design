<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeline
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
        Me.lblAVLightingSelection = New System.Windows.Forms.Label()
        Me.txtTimelineInfo = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdUpdateTimeline = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAVLightingSelection
        '
        Me.lblAVLightingSelection.AutoSize = True
        Me.lblAVLightingSelection.Font = New System.Drawing.Font("Franklin Gothic Medium", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAVLightingSelection.Location = New System.Drawing.Point(10, 9)
        Me.lblAVLightingSelection.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAVLightingSelection.Name = "lblAVLightingSelection"
        Me.lblAVLightingSelection.Size = New System.Drawing.Size(135, 37)
        Me.lblAVLightingSelection.TabIndex = 15
        Me.lblAVLightingSelection.Text = "Timeline"
        '
        'txtTimelineInfo
        '
        Me.txtTimelineInfo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimelineInfo.Location = New System.Drawing.Point(17, 49)
        Me.txtTimelineInfo.Multiline = True
        Me.txtTimelineInfo.Name = "txtTimelineInfo"
        Me.txtTimelineInfo.Size = New System.Drawing.Size(520, 339)
        Me.txtTimelineInfo.TabIndex = 16
        Me.txtTimelineInfo.Text = "4:00 - Ceremony" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4:30 - Guests to Reception" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4:30 - Hors'D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5:00 - Bar Starts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5:" &
    "30 - Toasts/Prayer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5:45 - Dinner"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Coral
        Me.cmdCancel.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(281, 394)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(256, 44)
        Me.cmdCancel.TabIndex = 25
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdUpdateTimeline
        '
        Me.cmdUpdateTimeline.BackColor = System.Drawing.Color.Gold
        Me.cmdUpdateTimeline.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateTimeline.Location = New System.Drawing.Point(17, 394)
        Me.cmdUpdateTimeline.Name = "cmdUpdateTimeline"
        Me.cmdUpdateTimeline.Size = New System.Drawing.Size(256, 44)
        Me.cmdUpdateTimeline.TabIndex = 24
        Me.cmdUpdateTimeline.Text = "Update Timeline"
        Me.cmdUpdateTimeline.UseVisualStyleBackColor = False
        '
        'frmTimeline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 450)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdUpdateTimeline)
        Me.Controls.Add(Me.txtTimelineInfo)
        Me.Controls.Add(Me.lblAVLightingSelection)
        Me.Name = "frmTimeline"
        Me.Text = "Timeline - The Treasury"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAVLightingSelection As Label
    Friend WithEvents txtTimelineInfo As TextBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdUpdateTimeline As Button
End Class
