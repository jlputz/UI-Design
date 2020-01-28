<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.clndrHome = New System.Windows.Forms.MonthCalendar()
        Me.lblDayInfo = New System.Windows.Forms.Label()
        Me.rtbUpcoming = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'clndrHome
        '
        Me.clndrHome.CalendarDimensions = New System.Drawing.Size(4, 1)
        Me.clndrHome.Location = New System.Drawing.Point(24, 22)
        Me.clndrHome.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.clndrHome.Name = "clndrHome"
        Me.clndrHome.TabIndex = 38
        '
        'lblDayInfo
        '
        Me.lblDayInfo.AutoSize = True
        Me.lblDayInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayInfo.ForeColor = System.Drawing.Color.Wheat
        Me.lblDayInfo.Location = New System.Drawing.Point(17, 250)
        Me.lblDayInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDayInfo.Name = "lblDayInfo"
        Me.lblDayInfo.Size = New System.Drawing.Size(235, 31)
        Me.lblDayInfo.TabIndex = 39
        Me.lblDayInfo.Text = "Upcoming Events:"
        '
        'rtbUpcoming
        '
        Me.rtbUpcoming.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.rtbUpcoming.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbUpcoming.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbUpcoming.ForeColor = System.Drawing.Color.Wheat
        Me.rtbUpcoming.Location = New System.Drawing.Point(24, 309)
        Me.rtbUpcoming.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtbUpcoming.Name = "rtbUpcoming"
        Me.rtbUpcoming.Size = New System.Drawing.Size(919, 480)
        Me.rtbUpcoming.TabIndex = 40
        Me.rtbUpcoming.Text = ""
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1460, 894)
        Me.Controls.Add(Me.rtbUpcoming)
        Me.Controls.Add(Me.lblDayInfo)
        Me.Controls.Add(Me.clndrHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmHome"
        Me.Text = "HomeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clndrHome As MonthCalendar
    Friend WithEvents lblDayInfo As Label
    Friend WithEvents rtbUpcoming As RichTextBox
End Class
