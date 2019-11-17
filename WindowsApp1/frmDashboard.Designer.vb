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
        Me.btnNewClient = New System.Windows.Forms.Button()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnCancelNewClient = New System.Windows.Forms.Button()
        Me.lblNotifs = New System.Windows.Forms.Label()
        Me.clndrHome = New System.Windows.Forms.MonthCalendar()
        Me.lblDayInfo = New System.Windows.Forms.Label()
        Me.pnlLayout = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.pboxNotif = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLoadClient = New System.Windows.Forms.Button()
        Me.pnlForms = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnlSettings.SuspendLayout()
        Me.pnlLayout.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(1608, 14)
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
        'btnNewClient
        '
        Me.btnNewClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewClient.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewClient.ForeColor = System.Drawing.Color.Wheat
        Me.btnNewClient.Location = New System.Drawing.Point(173, 159)
        Me.btnNewClient.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNewClient.Name = "btnNewClient"
        Me.btnNewClient.Size = New System.Drawing.Size(265, 40)
        Me.btnNewClient.TabIndex = 32
        Me.btnNewClient.Text = "New Client"
        Me.btnNewClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNewClient.UseVisualStyleBackColor = False
        '
        'pnlSettings
        '
        Me.pnlSettings.Controls.Add(Me.Button9)
        Me.pnlSettings.Controls.Add(Me.Button4)
        Me.pnlSettings.Location = New System.Drawing.Point(173, 157)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(608, 100)
        Me.pnlSettings.TabIndex = 33
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
        'btnCancelNewClient
        '
        Me.btnCancelNewClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnCancelNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelNewClient.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelNewClient.ForeColor = System.Drawing.Color.Wheat
        Me.btnCancelNewClient.Location = New System.Drawing.Point(171, 156)
        Me.btnCancelNewClient.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancelNewClient.Name = "btnCancelNewClient"
        Me.btnCancelNewClient.Size = New System.Drawing.Size(265, 40)
        Me.btnCancelNewClient.TabIndex = 39
        Me.btnCancelNewClient.Text = "Cancel New Client"
        Me.btnCancelNewClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelNewClient.UseVisualStyleBackColor = False
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
        'clndrHome
        '
        Me.clndrHome.CalendarDimensions = New System.Drawing.Size(3, 1)
        Me.clndrHome.Location = New System.Drawing.Point(172, 158)
        Me.clndrHome.Name = "clndrHome"
        Me.clndrHome.TabIndex = 37
        '
        'lblDayInfo
        '
        Me.lblDayInfo.AutoSize = True
        Me.lblDayInfo.ForeColor = System.Drawing.Color.Wheat
        Me.lblDayInfo.Location = New System.Drawing.Point(174, 362)
        Me.lblDayInfo.Name = "lblDayInfo"
        Me.lblDayInfo.Size = New System.Drawing.Size(67, 15)
        Me.lblDayInfo.TabIndex = 38
        Me.lblDayInfo.Text = "Event at: "
        '
        'pnlLayout
        '
        Me.pnlLayout.Controls.Add(Me.Button6)
        Me.pnlLayout.Controls.Add(Me.Button7)
        Me.pnlLayout.Controls.Add(Me.Button8)
        Me.pnlLayout.Controls.Add(Me.Button10)
        Me.pnlLayout.Location = New System.Drawing.Point(171, 359)
        Me.pnlLayout.Name = "pnlLayout"
        Me.pnlLayout.Size = New System.Drawing.Size(1125, 539)
        Me.pnlLayout.TabIndex = 40
        Me.pnlLayout.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Wheat
        Me.Button6.Location = New System.Drawing.Point(21, 19)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(280, 47)
        Me.Button6.TabIndex = 84
        Me.Button6.Text = "Create Layout"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Wheat
        Me.Button7.Location = New System.Drawing.Point(705, 19)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(280, 47)
        Me.Button7.TabIndex = 83
        Me.Button7.Text = "Select Layout"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Wheat
        Me.Button8.Location = New System.Drawing.Point(385, 21)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(222, 43)
        Me.Button8.TabIndex = 82
        Me.Button8.Text = "Select Floor"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(21, 83)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(964, 396)
        Me.Button10.TabIndex = 81
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'pboxNotif
        '
        Me.pboxNotif.Image = CType(resources.GetObject("pboxNotif.Image"), System.Drawing.Image)
        Me.pboxNotif.Location = New System.Drawing.Point(171, 61)
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
        'btnLoadClient
        '
        Me.btnLoadClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLoadClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadClient.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadClient.ForeColor = System.Drawing.Color.Wheat
        Me.btnLoadClient.Location = New System.Drawing.Point(476, 158)
        Me.btnLoadClient.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLoadClient.Name = "btnLoadClient"
        Me.btnLoadClient.Size = New System.Drawing.Size(265, 40)
        Me.btnLoadClient.TabIndex = 41
        Me.btnLoadClient.Text = "Load Client"
        Me.btnLoadClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLoadClient.UseVisualStyleBackColor = False
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
        Me.Controls.Add(Me.pnlForms)
        Me.Controls.Add(Me.btnLoadClient)
        Me.Controls.Add(Me.lblDayInfo)
        Me.Controls.Add(Me.pboxNotif)
        Me.Controls.Add(Me.lblNotifs)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNewClient)
        Me.Controls.Add(Me.btnCancelNewClient)
        Me.Controls.Add(Me.pnlLayout)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.clndrHome)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmDashboard"
        Me.Text = "The Treasury"
        Me.Panel1.ResumeLayout(False)
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlLayout.ResumeLayout(False)
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
    Friend WithEvents btnNewClient As Button
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents lblNotifs As Label
    Friend WithEvents pboxNotif As PictureBox
    Friend WithEvents clndrHome As MonthCalendar
    Friend WithEvents lblDayInfo As Label
    Friend WithEvents btnCancelNewClient As Button
    Friend WithEvents pnlLayout As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Private WithEvents Button10 As Button
    Friend WithEvents btnLoadClient As Button
    Friend WithEvents pnlForms As Panel
End Class
