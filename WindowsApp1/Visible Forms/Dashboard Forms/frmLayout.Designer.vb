<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLayout
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Wheat
        Me.Button6.Location = New System.Drawing.Point(25, 12)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(280, 47)
        Me.Button6.TabIndex = 84
        Me.Button6.Text = "Create Layout"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Wheat
        Me.Button8.Location = New System.Drawing.Point(438, 14)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(222, 43)
        Me.Button8.TabIndex = 82
        Me.Button8.Text = "Select Floor"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Wheat
        Me.Button7.Location = New System.Drawing.Point(764, 14)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(280, 45)
        Me.Button7.TabIndex = 83
        Me.Button7.Text = "Select Layout"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(25, 96)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(1019, 564)
        Me.Button10.TabIndex = 85
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'LayoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1077, 687)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LayoutForm"
        Me.Text = "LayoutForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Private WithEvents Button10 As Button
End Class
