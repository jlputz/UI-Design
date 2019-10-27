<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableManager
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblTableManager = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblTableName = New System.Windows.Forms.Label()
        Me.cmdExitManager = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 88)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(794, 345)
        Me.DataGridView1.TabIndex = 0
        '
        'lblTableManager
        '
        Me.lblTableManager.AutoSize = True
        Me.lblTableManager.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableManager.Location = New System.Drawing.Point(6, 7)
        Me.lblTableManager.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTableManager.Name = "lblTableManager"
        Me.lblTableManager.Size = New System.Drawing.Size(153, 28)
        Me.lblTableManager.TabIndex = 1
        Me.lblTableManager.Text = "Table Manager"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(108, 56)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'lblTableName
        '
        Me.lblTableName.AutoSize = True
        Me.lblTableName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableName.Location = New System.Drawing.Point(8, 53)
        Me.lblTableName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTableName.Name = "lblTableName"
        Me.lblTableName.Size = New System.Drawing.Size(97, 18)
        Me.lblTableName.TabIndex = 3
        Me.lblTableName.Text = "Select Table:"
        '
        'cmdExitManager
        '
        Me.cmdExitManager.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExitManager.Location = New System.Drawing.Point(324, 448)
        Me.cmdExitManager.Name = "cmdExitManager"
        Me.cmdExitManager.Size = New System.Drawing.Size(151, 38)
        Me.cmdExitManager.TabIndex = 4
        Me.cmdExitManager.Text = "Exit Manager"
        Me.cmdExitManager.UseVisualStyleBackColor = True
        '
        'frmTableManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 507)
        Me.Controls.Add(Me.cmdExitManager)
        Me.Controls.Add(Me.lblTableName)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblTableManager)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmTableManager"
        Me.Text = "frmTableManager"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblTableManager As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblTableName As Label
    Friend WithEvents cmdExitManager As Button
End Class
