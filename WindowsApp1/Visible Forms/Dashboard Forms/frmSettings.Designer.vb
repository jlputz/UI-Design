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
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.pnlSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSettings
        '
        Me.pnlSettings.Controls.Add(Me.Button9)
        Me.pnlSettings.Controls.Add(Me.Button4)
        Me.pnlSettings.Location = New System.Drawing.Point(24, 12)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(608, 100)
        Me.pnlSettings.TabIndex = 34
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Wheat
        Me.Button9.Location = New System.Drawing.Point(320, 30)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(265, 40)
        Me.Button9.TabIndex = 34
        Me.Button9.Text = "Edit Beverage Options"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Wheat
        Me.Button4.Location = New System.Drawing.Point(16, 30)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(265, 40)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Edit Food Options"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 681)
        Me.Controls.Add(Me.pnlSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsForm"
        Me.Text = "SettingsForm"
        Me.pnlSettings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSettings As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button4 As Button
End Class
