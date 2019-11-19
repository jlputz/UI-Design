<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrinkTableEditior
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
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblBaseRate = New System.Windows.Forms.Label()
        Me.lblAdditionalHours = New System.Windows.Forms.Label()
        Me.lblLocationFee = New System.Windows.Forms.Label()
        Me.lblBartenderFee = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.mtbBaseRate = New System.Windows.Forms.MaskedTextBox()
        Me.mtbAdditionalHoursRate = New System.Windows.Forms.MaskedTextBox()
        Me.mtbLocationFee = New System.Windows.Forms.MaskedTextBox()
        Me.mtbBartenderFee = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(13, 13)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(54, 18)
        Me.lblItemName.TabIndex = 0
        Me.lblItemName.Text = "Name:"
        '
        'lblBaseRate
        '
        Me.lblBaseRate.AutoSize = True
        Me.lblBaseRate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaseRate.Location = New System.Drawing.Point(13, 49)
        Me.lblBaseRate.Name = "lblBaseRate"
        Me.lblBaseRate.Size = New System.Drawing.Size(86, 18)
        Me.lblBaseRate.TabIndex = 1
        Me.lblBaseRate.Text = "Base Rate:"
        '
        'lblAdditionalHours
        '
        Me.lblAdditionalHours.AutoSize = True
        Me.lblAdditionalHours.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditionalHours.Location = New System.Drawing.Point(13, 85)
        Me.lblAdditionalHours.Name = "lblAdditionalHours"
        Me.lblAdditionalHours.Size = New System.Drawing.Size(127, 18)
        Me.lblAdditionalHours.TabIndex = 2
        Me.lblAdditionalHours.Text = "Additional Hours:"
        '
        'lblLocationFee
        '
        Me.lblLocationFee.AutoSize = True
        Me.lblLocationFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocationFee.Location = New System.Drawing.Point(13, 121)
        Me.lblLocationFee.Name = "lblLocationFee"
        Me.lblLocationFee.Size = New System.Drawing.Size(104, 18)
        Me.lblLocationFee.TabIndex = 3
        Me.lblLocationFee.Text = "Location Fee:"
        '
        'lblBartenderFee
        '
        Me.lblBartenderFee.AutoSize = True
        Me.lblBartenderFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBartenderFee.Location = New System.Drawing.Point(13, 157)
        Me.lblBartenderFee.Name = "lblBartenderFee"
        Me.lblBartenderFee.Size = New System.Drawing.Size(113, 18)
        Me.lblBartenderFee.TabIndex = 4
        Me.lblBartenderFee.Text = "Bartender Fee:"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Coral
        Me.Button7.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(278, 206)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(256, 44)
        Me.Button7.TabIndex = 53
        Me.Button7.Text = "Cancel"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'cmd
        '
        Me.cmd.BackColor = System.Drawing.Color.Gold
        Me.cmd.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Location = New System.Drawing.Point(16, 206)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(256, 44)
        Me.cmd.TabIndex = 52
        Me.cmd.Text = "Update Timeline"
        Me.cmd.UseVisualStyleBackColor = False
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(146, 10)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(212, 26)
        Me.txtItemName.TabIndex = 55
        '
        'mtbBaseRate
        '
        Me.mtbBaseRate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbBaseRate.Location = New System.Drawing.Point(146, 46)
        Me.mtbBaseRate.Mask = "$00000.00"
        Me.mtbBaseRate.Name = "mtbBaseRate"
        Me.mtbBaseRate.Size = New System.Drawing.Size(100, 26)
        Me.mtbBaseRate.TabIndex = 56
        Me.mtbBaseRate.ValidatingType = GetType(Integer)
        '
        'mtbAdditionalHoursRate
        '
        Me.mtbAdditionalHoursRate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbAdditionalHoursRate.Location = New System.Drawing.Point(146, 82)
        Me.mtbAdditionalHoursRate.Mask = "$00000.00"
        Me.mtbAdditionalHoursRate.Name = "mtbAdditionalHoursRate"
        Me.mtbAdditionalHoursRate.Size = New System.Drawing.Size(100, 26)
        Me.mtbAdditionalHoursRate.TabIndex = 57
        Me.mtbAdditionalHoursRate.ValidatingType = GetType(Integer)
        '
        'mtbLocationFee
        '
        Me.mtbLocationFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbLocationFee.Location = New System.Drawing.Point(146, 118)
        Me.mtbLocationFee.Mask = "$00000.00"
        Me.mtbLocationFee.Name = "mtbLocationFee"
        Me.mtbLocationFee.Size = New System.Drawing.Size(100, 26)
        Me.mtbLocationFee.TabIndex = 58
        Me.mtbLocationFee.ValidatingType = GetType(Integer)
        '
        'mtbBartenderFee
        '
        Me.mtbBartenderFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbBartenderFee.Location = New System.Drawing.Point(146, 154)
        Me.mtbBartenderFee.Mask = "$00000.00"
        Me.mtbBartenderFee.Name = "mtbBartenderFee"
        Me.mtbBartenderFee.Size = New System.Drawing.Size(100, 26)
        Me.mtbBartenderFee.TabIndex = 59
        Me.mtbBartenderFee.ValidatingType = GetType(Integer)
        '
        'frmDrinkTableEditior
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mtbBartenderFee)
        Me.Controls.Add(Me.mtbLocationFee)
        Me.Controls.Add(Me.mtbAdditionalHoursRate)
        Me.Controls.Add(Me.mtbBaseRate)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.lblBartenderFee)
        Me.Controls.Add(Me.lblLocationFee)
        Me.Controls.Add(Me.lblAdditionalHours)
        Me.Controls.Add(Me.lblBaseRate)
        Me.Controls.Add(Me.lblItemName)
        Me.Name = "frmDrinkTableEditior"
        Me.Text = "frmDrinkTableEditior"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItemName As Label
    Friend WithEvents lblBaseRate As Label
    Friend WithEvents lblAdditionalHours As Label
    Friend WithEvents lblLocationFee As Label
    Friend WithEvents lblBartenderFee As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents cmd As Button
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents mtbBaseRate As MaskedTextBox
    Friend WithEvents mtbAdditionalHoursRate As MaskedTextBox
    Friend WithEvents mtbLocationFee As MaskedTextBox
    Friend WithEvents mtbBartenderFee As MaskedTextBox
End Class
