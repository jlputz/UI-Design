<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Me.SuspendLayout()
        '
        'clndrHome
        '
        Me.clndrHome.CalendarDimensions = New System.Drawing.Size(3, 1)
        Me.clndrHome.Location = New System.Drawing.Point(18, 18)
        Me.clndrHome.Name = "clndrHome"
        Me.clndrHome.TabIndex = 38
        '
        'lblDayInfo
        '
        Me.lblDayInfo.AutoSize = True
        Me.lblDayInfo.ForeColor = System.Drawing.Color.Wheat
        Me.lblDayInfo.Location = New System.Drawing.Point(15, 227)
        Me.lblDayInfo.Name = "lblDayInfo"
        Me.lblDayInfo.Size = New System.Drawing.Size(53, 13)
        Me.lblDayInfo.TabIndex = 39
        Me.lblDayInfo.Text = "Event at: "
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1095, 726)
        Me.Controls.Add(Me.lblDayInfo)
        Me.Controls.Add(Me.clndrHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clndrHome As MonthCalendar
    Friend WithEvents lblDayInfo As Label
End Class
