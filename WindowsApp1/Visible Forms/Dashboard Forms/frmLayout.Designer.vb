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
        Me.cmbNew = New System.Windows.Forms.ComboBox()
        Me.cmbExisting = New System.Windows.Forms.ComboBox()
        Me.AxDrawingControl1 = New AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl()
        Me.btnLoad = New System.Windows.Forms.Button()
        CType(Me.AxDrawingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cmbNew
        '
        Me.cmbNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNew.FormattingEnabled = True
        Me.cmbNew.Location = New System.Drawing.Point(25, 90)
        Me.cmbNew.Name = "cmbNew"
        Me.cmbNew.Size = New System.Drawing.Size(326, 33)
        Me.cmbNew.TabIndex = 86
        '
        'cmbExisting
        '
        Me.cmbExisting.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExisting.FormattingEnabled = True
        Me.cmbExisting.Location = New System.Drawing.Point(739, 90)
        Me.cmbExisting.Name = "cmbExisting"
        Me.cmbExisting.Size = New System.Drawing.Size(326, 33)
        Me.cmbExisting.TabIndex = 87
        '
        'AxDrawingControl1
        '
        Me.AxDrawingControl1.Enabled = True
        Me.AxDrawingControl1.Location = New System.Drawing.Point(25, 168)
        Me.AxDrawingControl1.Name = "AxDrawingControl1"
        Me.AxDrawingControl1.Size = New System.Drawing.Size(1040, 507)
        Me.AxDrawingControl1.TabIndex = 88
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(484, 79)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(140, 58)
        Me.btnLoad.TabIndex = 89
        Me.btnLoad.Text = "Load File"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'frmLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1077, 687)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.AxDrawingControl1)
        Me.Controls.Add(Me.cmbExisting)
        Me.Controls.Add(Me.cmbNew)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLayout"
        Me.Text = "LayoutForm"
        CType(Me.AxDrawingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents cmbNew As ComboBox
    Friend WithEvents cmbExisting As ComboBox
    Friend WithEvents AxDrawingControl1 As AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl
    Friend WithEvents btnLoad As Button
End Class
