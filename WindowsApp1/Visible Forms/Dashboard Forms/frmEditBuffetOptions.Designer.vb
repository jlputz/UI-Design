<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditBuffetOptions
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FoodType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodUpcharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEditBuffet = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodType, Me.FoodName, Me.FoodDescription, Me.FoodUpcharge})
        Me.DataGridView1.Location = New System.Drawing.Point(35, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(732, 327)
        Me.DataGridView1.TabIndex = 0
        '
        'FoodType
        '
        Me.FoodType.HeaderText = "Food Type"
        Me.FoodType.Name = "FoodType"
        Me.FoodType.ReadOnly = True
        Me.FoodType.Width = 77
        '
        'FoodName
        '
        Me.FoodName.HeaderText = "Food Name"
        Me.FoodName.Name = "FoodName"
        Me.FoodName.ReadOnly = True
        Me.FoodName.Width = 80
        '
        'FoodDescription
        '
        Me.FoodDescription.HeaderText = "Food Description"
        Me.FoodDescription.Name = "FoodDescription"
        Me.FoodDescription.ReadOnly = True
        Me.FoodDescription.Width = 103
        '
        'FoodUpcharge
        '
        Me.FoodUpcharge.HeaderText = "Food Upcharge"
        Me.FoodUpcharge.Name = "FoodUpcharge"
        Me.FoodUpcharge.ReadOnly = True
        Me.FoodUpcharge.Width = 97
        '
        'btnEditBuffet
        '
        Me.btnEditBuffet.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEditBuffet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBuffet.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBuffet.ForeColor = System.Drawing.Color.Wheat
        Me.btnEditBuffet.Location = New System.Drawing.Point(35, 386)
        Me.btnEditBuffet.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEditBuffet.Name = "btnEditBuffet"
        Me.btnEditBuffet.Size = New System.Drawing.Size(265, 40)
        Me.btnEditBuffet.TabIndex = 34
        Me.btnEditBuffet.Text = "Save Buffet Options"
        Me.btnEditBuffet.UseVisualStyleBackColor = False
        '
        'frmEditBuffetOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEditBuffet)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEditBuffetOptions"
        Me.Text = "Edit Buffet Options"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FoodType As DataGridViewTextBoxColumn
    Friend WithEvents FoodName As DataGridViewTextBoxColumn
    Friend WithEvents FoodDescription As DataGridViewTextBoxColumn
    Friend WithEvents FoodUpcharge As DataGridViewTextBoxColumn
    Friend WithEvents btnEditBuffet As Button
End Class
