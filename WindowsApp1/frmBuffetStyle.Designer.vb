<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuffetStyle
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
        Me.lblTraditionalBuffet = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSideDishes = New System.Windows.Forms.Label()
        Me.cboSaladSelections = New System.Windows.Forms.ComboBox()
        Me.cboSideDishes = New System.Windows.Forms.ComboBox()
        Me.lblEntrees = New System.Windows.Forms.Label()
        Me.cboEntrees = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblBuffetSelections = New System.Windows.Forms.Label()
        Me.cmdAddToBuffetSelections = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTraditionalBuffet
        '
        Me.lblTraditionalBuffet.AutoSize = True
        Me.lblTraditionalBuffet.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTraditionalBuffet.ForeColor = System.Drawing.Color.Wheat
        Me.lblTraditionalBuffet.Location = New System.Drawing.Point(12, 9)
        Me.lblTraditionalBuffet.Name = "lblTraditionalBuffet"
        Me.lblTraditionalBuffet.Size = New System.Drawing.Size(315, 32)
        Me.lblTraditionalBuffet.TabIndex = 4
        Me.lblTraditionalBuffet.Text = "Traditional Buffet Style"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Salad Selections:"
        '
        'lblSideDishes
        '
        Me.lblSideDishes.AutoSize = True
        Me.lblSideDishes.Location = New System.Drawing.Point(58, 123)
        Me.lblSideDishes.Name = "lblSideDishes"
        Me.lblSideDishes.Size = New System.Drawing.Size(87, 15)
        Me.lblSideDishes.TabIndex = 6
        Me.lblSideDishes.Text = "Side Dishes:"
        '
        'cboSaladSelections
        '
        Me.cboSaladSelections.FormattingEnabled = True
        Me.cboSaladSelections.Location = New System.Drawing.Point(151, 75)
        Me.cboSaladSelections.Name = "cboSaladSelections"
        Me.cboSaladSelections.Size = New System.Drawing.Size(194, 23)
        Me.cboSaladSelections.TabIndex = 7
        '
        'cboSideDishes
        '
        Me.cboSideDishes.FormattingEnabled = True
        Me.cboSideDishes.Location = New System.Drawing.Point(151, 120)
        Me.cboSideDishes.Name = "cboSideDishes"
        Me.cboSideDishes.Size = New System.Drawing.Size(194, 23)
        Me.cboSideDishes.TabIndex = 8
        '
        'lblEntrees
        '
        Me.lblEntrees.AutoSize = True
        Me.lblEntrees.Location = New System.Drawing.Point(83, 166)
        Me.lblEntrees.Name = "lblEntrees"
        Me.lblEntrees.Size = New System.Drawing.Size(62, 15)
        Me.lblEntrees.TabIndex = 9
        Me.lblEntrees.Text = "Entrees:"
        '
        'cboEntrees
        '
        Me.cboEntrees.FormattingEnabled = True
        Me.cboEntrees.Location = New System.Drawing.Point(151, 163)
        Me.cboEntrees.Name = "cboEntrees"
        Me.cboEntrees.Size = New System.Drawing.Size(194, 23)
        Me.cboEntrees.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.Wheat
        Me.TextBox1.Location = New System.Drawing.Point(371, 76)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(432, 431)
        Me.TextBox1.TabIndex = 11
        '
        'lblBuffetSelections
        '
        Me.lblBuffetSelections.AutoSize = True
        Me.lblBuffetSelections.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuffetSelections.Location = New System.Drawing.Point(368, 55)
        Me.lblBuffetSelections.Name = "lblBuffetSelections"
        Me.lblBuffetSelections.Size = New System.Drawing.Size(149, 18)
        Me.lblBuffetSelections.TabIndex = 12
        Me.lblBuffetSelections.Text = "Buffet Selections:"
        '
        'cmdAddToBuffetSelections
        '
        Me.cmdAddToBuffetSelections.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddToBuffetSelections.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddToBuffetSelections.ForeColor = System.Drawing.Color.Wheat
        Me.cmdAddToBuffetSelections.Location = New System.Drawing.Point(86, 211)
        Me.cmdAddToBuffetSelections.Name = "cmdAddToBuffetSelections"
        Me.cmdAddToBuffetSelections.Size = New System.Drawing.Size(213, 39)
        Me.cmdAddToBuffetSelections.TabIndex = 36
        Me.cmdAddToBuffetSelections.Text = "Add to Buffet Selections"
        Me.cmdAddToBuffetSelections.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Wheat
        Me.Button1.Location = New System.Drawing.Point(450, 515)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(279, 39)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Add to Event Food Selections"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmBuffetStyle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 566)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdAddToBuffetSelections)
        Me.Controls.Add(Me.lblBuffetSelections)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cboEntrees)
        Me.Controls.Add(Me.lblEntrees)
        Me.Controls.Add(Me.cboSideDishes)
        Me.Controls.Add(Me.cboSaladSelections)
        Me.Controls.Add(Me.lblSideDishes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTraditionalBuffet)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Wheat
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmBuffetStyle"
        Me.Text = "frmBuffetStyle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTraditionalBuffet As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSideDishes As Label
    Friend WithEvents cboSaladSelections As ComboBox
    Friend WithEvents cboSideDishes As ComboBox
    Friend WithEvents lblEntrees As Label
    Friend WithEvents cboEntrees As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblBuffetSelections As Label
    Friend WithEvents cmdAddToBuffetSelections As Button
    Friend WithEvents Button1 As Button
End Class
