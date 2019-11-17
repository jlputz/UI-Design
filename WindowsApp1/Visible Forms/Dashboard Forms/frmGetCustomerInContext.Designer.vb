<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetCustomerInContext
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGetCustomerInContext))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EventDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNewClient = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventDate, Me.EventType, Me.lName, Me.fName})
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(35, 100)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(731, 469)
        Me.DataGridView1.TabIndex = 33
        '
        'EventDate
        '
        Me.EventDate.HeaderText = "Event Date"
        Me.EventDate.MinimumWidth = 6
        Me.EventDate.Name = "EventDate"
        Me.EventDate.ReadOnly = True
        Me.EventDate.Width = 125
        '
        'EventType
        '
        Me.EventType.HeaderText = "Event Type"
        Me.EventType.MinimumWidth = 6
        Me.EventType.Name = "EventType"
        Me.EventType.ReadOnly = True
        Me.EventType.Width = 125
        '
        'lName
        '
        Me.lName.HeaderText = "Last Name"
        Me.lName.MinimumWidth = 6
        Me.lName.Name = "lName"
        Me.lName.ReadOnly = True
        Me.lName.Width = 125
        '
        'fName
        '
        Me.fName.HeaderText = "First Name"
        Me.fName.MinimumWidth = 6
        Me.fName.Name = "fName"
        Me.fName.ReadOnly = True
        Me.fName.Width = 125
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(450, 44)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(264, 25)
        Me.txtsearch.TabIndex = 53
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(721, 35)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(45, 40)
        Me.btnSearch.TabIndex = 54
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnNewClient
        '
        Me.btnNewClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewClient.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewClient.ForeColor = System.Drawing.Color.Wheat
        Me.btnNewClient.Location = New System.Drawing.Point(501, 585)
        Me.btnNewClient.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNewClient.Name = "btnNewClient"
        Me.btnNewClient.Size = New System.Drawing.Size(265, 40)
        Me.btnNewClient.TabIndex = 55
        Me.btnNewClient.Text = "Load Client"
        Me.btnNewClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNewClient.UseVisualStyleBackColor = False
        '
        'GetCustomerInContext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(837, 646)
        Me.Controls.Add(Me.btnNewClient)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GetCustomerInContext"
        Me.Text = "GetCustomerInContext"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EventDate As DataGridViewTextBoxColumn
    Friend WithEvents EventType As DataGridViewTextBoxColumn
    Friend WithEvents lName As DataGridViewTextBoxColumn
    Friend WithEvents fName As DataGridViewTextBoxColumn
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnNewClient As Button
End Class
