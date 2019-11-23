<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendMail
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
        Me.lblSendEmail = New System.Windows.Forms.Label()
        Me.lblReportType = New System.Windows.Forms.Label()
        Me.cboReportType = New System.Windows.Forms.ComboBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.txtRecipientEmail = New System.Windows.Forms.TextBox()
        Me.cmdSendEmail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSendEmail
        '
        Me.lblSendEmail.AutoSize = True
        Me.lblSendEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSendEmail.Location = New System.Drawing.Point(12, 9)
        Me.lblSendEmail.Name = "lblSendEmail"
        Me.lblSendEmail.Size = New System.Drawing.Size(207, 32)
        Me.lblSendEmail.TabIndex = 0
        Me.lblSendEmail.Text = "Email a Report"
        '
        'lblReportType
        '
        Me.lblReportType.AutoSize = True
        Me.lblReportType.Location = New System.Drawing.Point(67, 68)
        Me.lblReportType.Name = "lblReportType"
        Me.lblReportType.Size = New System.Drawing.Size(55, 15)
        Me.lblReportType.TabIndex = 1
        Me.lblReportType.Text = "Report:"
        '
        'cboReportType
        '
        Me.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReportType.FormattingEnabled = True
        Me.cboReportType.Items.AddRange(New Object() {"BEO", "Floorplan", "Invoice"})
        Me.cboReportType.Location = New System.Drawing.Point(128, 65)
        Me.cboReportType.Name = "cboReportType"
        Me.cboReportType.Size = New System.Drawing.Size(352, 23)
        Me.cboReportType.TabIndex = 2
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(18, 115)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(104, 15)
        Me.lblEmailAddress.TabIndex = 3
        Me.lblEmailAddress.Text = "Email Address:"
        '
        'txtRecipientEmail
        '
        Me.txtRecipientEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtRecipientEmail.ForeColor = System.Drawing.Color.Wheat
        Me.txtRecipientEmail.Location = New System.Drawing.Point(128, 112)
        Me.txtRecipientEmail.Name = "txtRecipientEmail"
        Me.txtRecipientEmail.Size = New System.Drawing.Size(352, 23)
        Me.txtRecipientEmail.TabIndex = 4
        '
        'cmdSendEmail
        '
        Me.cmdSendEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSendEmail.Location = New System.Drawing.Point(21, 168)
        Me.cmdSendEmail.Name = "cmdSendEmail"
        Me.cmdSendEmail.Size = New System.Drawing.Size(459, 31)
        Me.cmdSendEmail.TabIndex = 5
        Me.cmdSendEmail.Text = "Email Report"
        Me.cmdSendEmail.UseVisualStyleBackColor = False
        '
        'frmSendMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(505, 218)
        Me.Controls.Add(Me.cmdSendEmail)
        Me.Controls.Add(Me.txtRecipientEmail)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.cboReportType)
        Me.Controls.Add(Me.lblReportType)
        Me.Controls.Add(Me.lblSendEmail)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Wheat
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmSendMail"
        Me.Text = "Send Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSendEmail As Label
    Friend WithEvents lblReportType As Label
    Friend WithEvents cboReportType As ComboBox
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents txtRecipientEmail As TextBox
    Friend WithEvents cmdSendEmail As Button
End Class
