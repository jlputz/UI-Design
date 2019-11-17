<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlButtonMover = New System.Windows.Forms.Panel()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnLayout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblNotifs = New System.Windows.Forms.Label()
        Me.pboxNotif = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlForms = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pboxNotif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlButtonMover)
        Me.Panel1.Controls.Add(Me.btnClient)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnLayout)
        Me.Panel1.Controls.Add(Me.btnSettings)
        Me.Panel1.Location = New System.Drawing.Point(0, 122)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 914)
        Me.Panel1.TabIndex = 6
        '
        'pnlButtonMover
        '
        Me.pnlButtonMover.BackColor = System.Drawing.Color.Wheat
        Me.pnlButtonMover.Location = New System.Drawing.Point(0, 3)
        Me.pnlButtonMover.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlButtonMover.Name = "pnlButtonMover"
        Me.pnlButtonMover.Size = New System.Drawing.Size(7, 100)
        Me.pnlButtonMover.TabIndex = 9
        '
        'btnClient
        '
        Me.btnClient.FlatAppearance.BorderSize = 0
        Me.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClient.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClient.ForeColor = System.Drawing.Color.White
        Me.btnClient.Image = CType(resources.GetObject("btnClient.Image"), System.Drawing.Image)
        Me.btnClient.Location = New System.Drawing.Point(0, 105)
        Me.btnClient.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(137, 99)
        Me.btnClient.TabIndex = 8
        Me.btnClient.Text = "Clients"
        Me.btnClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClient.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.Location = New System.Drawing.Point(0, 3)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(133, 99)
        Me.btnHome.TabIndex = 7
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnLayout
        '
        Me.btnLayout.FlatAppearance.BorderSize = 0
        Me.btnLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLayout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLayout.ForeColor = System.Drawing.Color.White
        Me.btnLayout.Image = CType(resources.GetObject("btnLayout.Image"), System.Drawing.Image)
        Me.btnLayout.Location = New System.Drawing.Point(0, 209)
        Me.btnLayout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLayout.Name = "btnLayout"
        Me.btnLayout.Size = New System.Drawing.Size(137, 99)
        Me.btnLayout.TabIndex = 11
        Me.btnLayout.Text = "Layout"
        Me.btnLayout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLayout.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.Location = New System.Drawing.Point(0, 321)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(137, 99)
        Me.btnSettings.TabIndex = 10
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Wheat
        Me.btnExit.Location = New System.Drawing.Point(1400, 12)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(31, 27)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Wheat
        Me.Panel2.Location = New System.Drawing.Point(0, 121)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1656, 6)
        Me.Panel2.TabIndex = 30
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.ForeColor = System.Drawing.Color.Wheat
        Me.btnMin.Location = New System.Drawing.Point(1569, 14)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(31, 27)
        Me.btnMin.TabIndex = 31
        Me.btnMin.Text = "-"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Wheat
        Me.lblDate.Location = New System.Drawing.Point(166, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(22, 32)
        Me.lblDate.TabIndex = 30
        Me.lblDate.Text = " "
        '
        'lblNotifs
        '
        Me.lblNotifs.AutoSize = True
        Me.lblNotifs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotifs.ForeColor = System.Drawing.Color.Wheat
        Me.lblNotifs.Location = New System.Drawing.Point(205, 68)
        Me.lblNotifs.Name = "lblNotifs"
        Me.lblNotifs.Size = New System.Drawing.Size(224, 22)
        Me.lblNotifs.TabIndex = 35
        Me.lblNotifs.Text = " Event Today at 5:00pm"
        '
        'pboxNotif
        '
        Me.pboxNotif.Image = CType(resources.GetObject("pboxNotif.Image"), System.Drawing.Image)
        Me.pboxNotif.Location = New System.Drawing.Point(168, 60)
        Me.pboxNotif.Name = "pboxNotif"
        Me.pboxNotif.Size = New System.Drawing.Size(37, 40)
        Me.pboxNotif.TabIndex = 36
        Me.pboxNotif.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 115)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'pnlForms
        '
        Me.pnlForms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlForms.Location = New System.Drawing.Point(155, 142)
        Me.pnlForms.Name = "pnlForms"
        Me.pnlForms.Size = New System.Drawing.Size(1257, 713)
        Me.pnlForms.TabIndex = 42
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1444, 881)
        Me.Controls.Add(Me.pboxNotif)
        Me.Controls.Add(Me.lblNotifs)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlForms)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmDashboard"
        Me.Text = "The Treasury"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pboxNotif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnClient As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlButtonMover As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnLayout As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblNotifs As Label
    Friend WithEvents pboxNotif As PictureBox
    Friend WithEvents pnlForms As Panel
End Class
