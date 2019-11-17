<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAfterglow
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
        Me.lblAfterglowSelectionsTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAfterglowSelectionsTitle
        '
        Me.lblAfterglowSelectionsTitle.AutoSize = True
        Me.lblAfterglowSelectionsTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfterglowSelectionsTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblAfterglowSelectionsTitle.Name = "lblAfterglowSelectionsTitle"
        Me.lblAfterglowSelectionsTitle.Size = New System.Drawing.Size(287, 32)
        Me.lblAfterglowSelectionsTitle.TabIndex = 2
        Me.lblAfterglowSelectionsTitle.Text = "Afterglow Selections"
        '
        'frmAfterglow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 519)
        Me.Controls.Add(Me.lblAfterglowSelectionsTitle)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Wheat
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmAfterglow"
        Me.Text = "Afterglow Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAfterglowSelectionsTitle As Label
End Class
