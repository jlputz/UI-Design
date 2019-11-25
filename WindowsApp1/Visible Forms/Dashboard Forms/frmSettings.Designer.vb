<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.cbTheme = New System.Windows.Forms.CheckBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btnEditBuffet = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEditApps = New System.Windows.Forms.Button()
        Me.pnlSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSettings
        '
        Me.pnlSettings.Controls.Add(Me.Button1)
        Me.pnlSettings.Controls.Add(Me.cbTheme)
        Me.pnlSettings.Location = New System.Drawing.Point(24, 12)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(964, 171)
        Me.pnlSettings.TabIndex = 34
        '
        'cbTheme
        '
        Me.cbTheme.AutoSize = True
        Me.cbTheme.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!)
        Me.cbTheme.ForeColor = System.Drawing.Color.Wheat
        Me.cbTheme.Location = New System.Drawing.Point(16, 101)
        Me.cbTheme.Name = "cbTheme"
        Me.cbTheme.Size = New System.Drawing.Size(141, 30)
        Me.cbTheme.TabIndex = 35
        Me.cbTheme.Text = "Light Theme"
        Me.cbTheme.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Wheat
        Me.Button9.Location = New System.Drawing.Point(40, 629)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(265, 40)
        Me.Button9.TabIndex = 34
        Me.Button9.Text = "Edit Beverage Options"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btnEditBuffet
        '
        Me.btnEditBuffet.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEditBuffet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBuffet.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBuffet.ForeColor = System.Drawing.Color.Wheat
        Me.btnEditBuffet.Location = New System.Drawing.Point(40, 223)
        Me.btnEditBuffet.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEditBuffet.Name = "btnEditBuffet"
        Me.btnEditBuffet.Size = New System.Drawing.Size(265, 40)
        Me.btnEditBuffet.TabIndex = 33
        Me.btnEditBuffet.Text = "Edit Buffet Options"
        Me.btnEditBuffet.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Wheat
        Me.Button1.Location = New System.Drawing.Point(16, 26)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 40)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Edit Treasury Email"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnEditApps
        '
        Me.btnEditApps.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEditApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditApps.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditApps.ForeColor = System.Drawing.Color.Wheat
        Me.btnEditApps.Location = New System.Drawing.Point(40, 304)
        Me.btnEditApps.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEditApps.Name = "btnEditApps"
        Me.btnEditApps.Size = New System.Drawing.Size(265, 40)
        Me.btnEditApps.TabIndex = 35
        Me.btnEditApps.Text = "Edit Appetizer Options"
        Me.btnEditApps.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 681)
        Me.Controls.Add(Me.btnEditApps)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.btnEditBuffet)
        Me.Controls.Add(Me.Button9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.Text = "SettingsForm"
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSettings As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents btnEditBuffet As Button
    Friend WithEvents cbTheme As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEditApps As Button
End Class
