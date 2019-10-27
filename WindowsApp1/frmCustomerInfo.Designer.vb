<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerInfo
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
        Me.lblCustomerInfo = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblAlternatePhone = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.mtbZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.mtbCustomerPhone = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCustomerAlternatePhone = New System.Windows.Forms.MaskedTextBox()
        Me.cmdEnterCustomerInfo = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCustomerInfo
        '
        Me.lblCustomerInfo.AutoSize = True
        Me.lblCustomerInfo.Font = New System.Drawing.Font("Franklin Gothic Medium", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerInfo.Location = New System.Drawing.Point(13, 13)
        Me.lblCustomerInfo.Name = "lblCustomerInfo"
        Me.lblCustomerInfo.Size = New System.Drawing.Size(320, 37)
        Me.lblCustomerInfo.TabIndex = 0
        Me.lblCustomerInfo.Text = "Customer Information"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(17, 72)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(126, 18)
        Me.lblCustomerName.TabIndex = 1
        Me.lblCustomerName.Text = "Customer Name:"
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreetAddress.Location = New System.Drawing.Point(17, 112)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(116, 18)
        Me.lblStreetAddress.TabIndex = 2
        Me.lblStreetAddress.Text = "Street Address:"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.Location = New System.Drawing.Point(17, 154)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(77, 18)
        Me.lblZipCode.TabIndex = 3
        Me.lblZipCode.Text = "Zip Code:"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.Location = New System.Drawing.Point(14, 194)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(119, 18)
        Me.lblEmailAddress.TabIndex = 4
        Me.lblEmailAddress.Text = "E-Mail Address:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(14, 236)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(116, 18)
        Me.lblPhoneNumber.TabIndex = 5
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblAlternatePhone
        '
        Me.lblAlternatePhone.AutoSize = True
        Me.lblAlternatePhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlternatePhone.Location = New System.Drawing.Point(14, 278)
        Me.lblAlternatePhone.Name = "lblAlternatePhone"
        Me.lblAlternatePhone.Size = New System.Drawing.Size(182, 18)
        Me.lblAlternatePhone.TabIndex = 6
        Me.lblAlternatePhone.Text = "Alternate Phone Number:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(149, 68)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(192, 26)
        Me.txtCustomerName.TabIndex = 7
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress.Location = New System.Drawing.Point(149, 108)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(192, 26)
        Me.txtCustomerAddress.TabIndex = 8
        '
        'mtbZipCode
        '
        Me.mtbZipCode.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbZipCode.Location = New System.Drawing.Point(149, 150)
        Me.mtbZipCode.Mask = "00000"
        Me.mtbZipCode.Name = "mtbZipCode"
        Me.mtbZipCode.Size = New System.Drawing.Size(50, 26)
        Me.mtbZipCode.TabIndex = 9
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerEmail.Location = New System.Drawing.Point(149, 190)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(192, 26)
        Me.txtCustomerEmail.TabIndex = 10
        '
        'mtbCustomerPhone
        '
        Me.mtbCustomerPhone.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCustomerPhone.Location = New System.Drawing.Point(149, 232)
        Me.mtbCustomerPhone.Mask = "(999) 000-0000"
        Me.mtbCustomerPhone.Name = "mtbCustomerPhone"
        Me.mtbCustomerPhone.Size = New System.Drawing.Size(100, 26)
        Me.mtbCustomerPhone.TabIndex = 11
        '
        'mtbCustomerAlternatePhone
        '
        Me.mtbCustomerAlternatePhone.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCustomerAlternatePhone.Location = New System.Drawing.Point(205, 274)
        Me.mtbCustomerAlternatePhone.Mask = "(999) 000-0000"
        Me.mtbCustomerAlternatePhone.Name = "mtbCustomerAlternatePhone"
        Me.mtbCustomerAlternatePhone.Size = New System.Drawing.Size(100, 26)
        Me.mtbCustomerAlternatePhone.TabIndex = 12
        '
        'cmdEnterCustomerInfo
        '
        Me.cmdEnterCustomerInfo.BackColor = System.Drawing.Color.Gold
        Me.cmdEnterCustomerInfo.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnterCustomerInfo.Location = New System.Drawing.Point(17, 326)
        Me.cmdEnterCustomerInfo.Name = "cmdEnterCustomerInfo"
        Me.cmdEnterCustomerInfo.Size = New System.Drawing.Size(199, 44)
        Me.cmdEnterCustomerInfo.TabIndex = 13
        Me.cmdEnterCustomerInfo.Text = "Enter Customer Info"
        Me.cmdEnterCustomerInfo.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Coral
        Me.cmdCancel.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(226, 326)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(199, 44)
        Me.cmdCancel.TabIndex = 14
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'frmCustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 379)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdEnterCustomerInfo)
        Me.Controls.Add(Me.mtbCustomerAlternatePhone)
        Me.Controls.Add(Me.mtbCustomerPhone)
        Me.Controls.Add(Me.txtCustomerEmail)
        Me.Controls.Add(Me.mtbZipCode)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblAlternatePhone)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.lblStreetAddress)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblCustomerInfo)
        Me.Name = "frmCustomerInfo"
        Me.Text = "frmCustomerInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomerInfo As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblStreetAddress As Label
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblAlternatePhone As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents mtbZipCode As MaskedTextBox
    Friend WithEvents txtCustomerEmail As TextBox
    Friend WithEvents mtbCustomerPhone As MaskedTextBox
    Friend WithEvents mtbCustomerAlternatePhone As MaskedTextBox
    Friend WithEvents cmdEnterCustomerInfo As Button
    Friend WithEvents cmdCancel As Button
End Class
