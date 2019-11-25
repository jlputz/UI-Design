<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreausryEmail
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
        Me.btnUpdateEmail = New System.Windows.Forms.Button()
        Me.txtRecipientEmail = New System.Windows.Forms.TextBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUpdateEmail
        '
        Me.btnUpdateEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnUpdateEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateEmail.ForeColor = System.Drawing.Color.Wheat
        Me.btnUpdateEmail.Location = New System.Drawing.Point(37, 101)
        Me.btnUpdateEmail.Name = "btnUpdateEmail"
        Me.btnUpdateEmail.Size = New System.Drawing.Size(459, 31)
        Me.btnUpdateEmail.TabIndex = 8
        Me.btnUpdateEmail.Text = "Update Email"
        Me.btnUpdateEmail.UseVisualStyleBackColor = False
        '
        'txtRecipientEmail
        '
        Me.txtRecipientEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtRecipientEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecipientEmail.ForeColor = System.Drawing.Color.Wheat
        Me.txtRecipientEmail.Location = New System.Drawing.Point(144, 45)
        Me.txtRecipientEmail.Name = "txtRecipientEmail"
        Me.txtRecipientEmail.Size = New System.Drawing.Size(352, 20)
        Me.txtRecipientEmail.TabIndex = 7
        Me.txtRecipientEmail.Text = "hayley@treasury.com"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.ForeColor = System.Drawing.Color.Wheat
        Me.lblEmailAddress.Location = New System.Drawing.Point(34, 48)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(76, 13)
        Me.lblEmailAddress.TabIndex = 6
        Me.lblEmailAddress.Text = "Email Address:"
        '
        'frmTreausryEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 172)
        Me.Controls.Add(Me.btnUpdateEmail)
        Me.Controls.Add(Me.txtRecipientEmail)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTreausryEmail"
        Me.Text = "Update Treasury Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdateEmail As Button
    Friend WithEvents txtRecipientEmail As TextBox
    Friend WithEvents lblEmailAddress As Label
End Class
