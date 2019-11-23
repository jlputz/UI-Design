<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUploadReports
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
        Me.lblUploadToGoogleDrive = New System.Windows.Forms.Label()
        Me.cboReportType = New System.Windows.Forms.ComboBox()
        Me.lblReportType = New System.Windows.Forms.Label()
        Me.lblGoogleDriveFolder = New System.Windows.Forms.Label()
        Me.txtUploadFolder = New System.Windows.Forms.TextBox()
        Me.cmdChooseDriveFolder = New System.Windows.Forms.Button()
        Me.cmdUploadToDrive = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUploadToGoogleDrive
        '
        Me.lblUploadToGoogleDrive.AutoSize = True
        Me.lblUploadToGoogleDrive.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUploadToGoogleDrive.Location = New System.Drawing.Point(12, 9)
        Me.lblUploadToGoogleDrive.Name = "lblUploadToGoogleDrive"
        Me.lblUploadToGoogleDrive.Size = New System.Drawing.Size(319, 32)
        Me.lblUploadToGoogleDrive.TabIndex = 1
        Me.lblUploadToGoogleDrive.Text = "Upload to Google Drive"
        '
        'cboReportType
        '
        Me.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReportType.FormattingEnabled = True
        Me.cboReportType.Items.AddRange(New Object() {"BEO", "Floorplan", "Invoice"})
        Me.cboReportType.Location = New System.Drawing.Point(123, 74)
        Me.cboReportType.Name = "cboReportType"
        Me.cboReportType.Size = New System.Drawing.Size(352, 23)
        Me.cboReportType.TabIndex = 4
        '
        'lblReportType
        '
        Me.lblReportType.AutoSize = True
        Me.lblReportType.Location = New System.Drawing.Point(62, 77)
        Me.lblReportType.Name = "lblReportType"
        Me.lblReportType.Size = New System.Drawing.Size(55, 15)
        Me.lblReportType.TabIndex = 3
        Me.lblReportType.Text = "Report:"
        '
        'lblGoogleDriveFolder
        '
        Me.lblGoogleDriveFolder.AutoSize = True
        Me.lblGoogleDriveFolder.Location = New System.Drawing.Point(15, 124)
        Me.lblGoogleDriveFolder.Name = "lblGoogleDriveFolder"
        Me.lblGoogleDriveFolder.Size = New System.Drawing.Size(102, 15)
        Me.lblGoogleDriveFolder.TabIndex = 5
        Me.lblGoogleDriveFolder.Text = "Upload Folder:"
        '
        'txtUploadFolder
        '
        Me.txtUploadFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtUploadFolder.ForeColor = System.Drawing.Color.Wheat
        Me.txtUploadFolder.Location = New System.Drawing.Point(123, 121)
        Me.txtUploadFolder.Name = "txtUploadFolder"
        Me.txtUploadFolder.Size = New System.Drawing.Size(352, 23)
        Me.txtUploadFolder.TabIndex = 6
        '
        'cmdChooseDriveFolder
        '
        Me.cmdChooseDriveFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdChooseDriveFolder.Location = New System.Drawing.Point(481, 115)
        Me.cmdChooseDriveFolder.Name = "cmdChooseDriveFolder"
        Me.cmdChooseDriveFolder.Size = New System.Drawing.Size(185, 33)
        Me.cmdChooseDriveFolder.TabIndex = 7
        Me.cmdChooseDriveFolder.Text = "Select Upload Destination"
        Me.cmdChooseDriveFolder.UseVisualStyleBackColor = False
        '
        'cmdUploadToDrive
        '
        Me.cmdUploadToDrive.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdUploadToDrive.Location = New System.Drawing.Point(111, 194)
        Me.cmdUploadToDrive.Name = "cmdUploadToDrive"
        Me.cmdUploadToDrive.Size = New System.Drawing.Size(457, 33)
        Me.cmdUploadToDrive.TabIndex = 8
        Me.cmdUploadToDrive.Text = "Upload to Google Drive"
        Me.cmdUploadToDrive.UseVisualStyleBackColor = False
        '
        'frmUploadReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(678, 239)
        Me.Controls.Add(Me.cmdUploadToDrive)
        Me.Controls.Add(Me.cmdChooseDriveFolder)
        Me.Controls.Add(Me.txtUploadFolder)
        Me.Controls.Add(Me.lblGoogleDriveFolder)
        Me.Controls.Add(Me.cboReportType)
        Me.Controls.Add(Me.lblReportType)
        Me.Controls.Add(Me.lblUploadToGoogleDrive)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Wheat
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmUploadReports"
        Me.Text = "Upload to Google Drive"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUploadToGoogleDrive As Label
    Friend WithEvents cboReportType As ComboBox
    Friend WithEvents lblReportType As Label
    Friend WithEvents lblGoogleDriveFolder As Label
    Friend WithEvents txtUploadFolder As TextBox
    Friend WithEvents cmdChooseDriveFolder As Button
    Friend WithEvents cmdUploadToDrive As Button
End Class
