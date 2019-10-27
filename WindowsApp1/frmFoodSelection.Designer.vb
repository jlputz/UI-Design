<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoodSelection
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
        Me.lblEventInfo = New System.Windows.Forms.Label()
        Me.lblCateringCompany = New System.Windows.Forms.Label()
        Me.lblCateringCompanyName = New System.Windows.Forms.Label()
        Me.lblCateringCompanyPhone = New System.Windows.Forms.Label()
        Me.lblCateringCompanyEmail = New System.Windows.Forms.Label()
        Me.chkFlatwareFee = New System.Windows.Forms.CheckBox()
        Me.cmdStrollingStations = New System.Windows.Forms.Button()
        Me.cmdTraditionalBuffet = New System.Windows.Forms.Button()
        Me.cmdPlatedMeals = New System.Windows.Forms.Button()
        Me.cmdHorsD = New System.Windows.Forms.Button()
        Me.cmdDessert = New System.Windows.Forms.Button()
        Me.cmdAfterglow = New System.Windows.Forms.Button()
        Me.lblDietaryRestrictions = New System.Windows.Forms.Label()
        Me.txtDietaryRestrictions = New System.Windows.Forms.TextBox()
        Me.lblSpecialNotes = New System.Windows.Forms.Label()
        Me.txtSpecialNotes = New System.Windows.Forms.TextBox()
        Me.cboCateringCompany = New System.Windows.Forms.ComboBox()
        Me.txtCateringCompanyEmail = New System.Windows.Forms.TextBox()
        Me.txtCateringCompanyName = New System.Windows.Forms.TextBox()
        Me.mtbCateringPhone = New System.Windows.Forms.MaskedTextBox()
        Me.cmdAddFoodSelections = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEventInfo
        '
        Me.lblEventInfo.AutoSize = True
        Me.lblEventInfo.Font = New System.Drawing.Font("Franklin Gothic Medium", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventInfo.Location = New System.Drawing.Point(24, 17)
        Me.lblEventInfo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblEventInfo.Name = "lblEventInfo"
        Me.lblEventInfo.Size = New System.Drawing.Size(443, 81)
        Me.lblEventInfo.TabIndex = 2
        Me.lblEventInfo.Text = "Food Selection"
        '
        'lblCateringCompany
        '
        Me.lblCateringCompany.AutoSize = True
        Me.lblCateringCompany.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCateringCompany.Location = New System.Drawing.Point(32, 119)
        Me.lblCateringCompany.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCateringCompany.Name = "lblCateringCompany"
        Me.lblCateringCompany.Size = New System.Drawing.Size(286, 36)
        Me.lblCateringCompany.TabIndex = 3
        Me.lblCateringCompany.Text = "Catering Company:"
        '
        'lblCateringCompanyName
        '
        Me.lblCateringCompanyName.AutoSize = True
        Me.lblCateringCompanyName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCateringCompanyName.Location = New System.Drawing.Point(32, 181)
        Me.lblCateringCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCateringCompanyName.Name = "lblCateringCompanyName"
        Me.lblCateringCompanyName.Size = New System.Drawing.Size(379, 36)
        Me.lblCateringCompanyName.TabIndex = 4
        Me.lblCateringCompanyName.Text = "Catering Company Name:"
        '
        'lblCateringCompanyPhone
        '
        Me.lblCateringCompanyPhone.AutoSize = True
        Me.lblCateringCompanyPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCateringCompanyPhone.Location = New System.Drawing.Point(32, 246)
        Me.lblCateringCompanyPhone.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCateringCompanyPhone.Name = "lblCateringCompanyPhone"
        Me.lblCateringCompanyPhone.Size = New System.Drawing.Size(386, 36)
        Me.lblCateringCompanyPhone.TabIndex = 5
        Me.lblCateringCompanyPhone.Text = "Catering Company Phone:"
        '
        'lblCateringCompanyEmail
        '
        Me.lblCateringCompanyEmail.AutoSize = True
        Me.lblCateringCompanyEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCateringCompanyEmail.Location = New System.Drawing.Point(32, 313)
        Me.lblCateringCompanyEmail.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCateringCompanyEmail.Name = "lblCateringCompanyEmail"
        Me.lblCateringCompanyEmail.Size = New System.Drawing.Size(507, 36)
        Me.lblCateringCompanyEmail.TabIndex = 6
        Me.lblCateringCompanyEmail.Text = "Catering Company E-Mail Address:"
        '
        'chkFlatwareFee
        '
        Me.chkFlatwareFee.AutoSize = True
        Me.chkFlatwareFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFlatwareFee.Location = New System.Drawing.Point(38, 379)
        Me.chkFlatwareFee.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkFlatwareFee.Name = "chkFlatwareFee"
        Me.chkFlatwareFee.Size = New System.Drawing.Size(642, 40)
        Me.chkFlatwareFee.TabIndex = 7
        Me.chkFlatwareFee.Text = "Flatware/China Fee (outside catering only)"
        Me.chkFlatwareFee.UseVisualStyleBackColor = True
        '
        'cmdStrollingStations
        '
        Me.cmdStrollingStations.BackColor = System.Drawing.Color.Chartreuse
        Me.cmdStrollingStations.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStrollingStations.Location = New System.Drawing.Point(38, 462)
        Me.cmdStrollingStations.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdStrollingStations.Name = "cmdStrollingStations"
        Me.cmdStrollingStations.Size = New System.Drawing.Size(442, 85)
        Me.cmdStrollingStations.TabIndex = 8
        Me.cmdStrollingStations.Text = "Strolling Dinner Stations"
        Me.cmdStrollingStations.UseVisualStyleBackColor = False
        '
        'cmdTraditionalBuffet
        '
        Me.cmdTraditionalBuffet.BackColor = System.Drawing.Color.Chartreuse
        Me.cmdTraditionalBuffet.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTraditionalBuffet.Location = New System.Drawing.Point(492, 462)
        Me.cmdTraditionalBuffet.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdTraditionalBuffet.Name = "cmdTraditionalBuffet"
        Me.cmdTraditionalBuffet.Size = New System.Drawing.Size(442, 85)
        Me.cmdTraditionalBuffet.TabIndex = 9
        Me.cmdTraditionalBuffet.Text = "Traditional Buffet Menu"
        Me.cmdTraditionalBuffet.UseVisualStyleBackColor = False
        '
        'cmdPlatedMeals
        '
        Me.cmdPlatedMeals.BackColor = System.Drawing.Color.Chartreuse
        Me.cmdPlatedMeals.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlatedMeals.Location = New System.Drawing.Point(946, 462)
        Me.cmdPlatedMeals.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdPlatedMeals.Name = "cmdPlatedMeals"
        Me.cmdPlatedMeals.Size = New System.Drawing.Size(442, 85)
        Me.cmdPlatedMeals.TabIndex = 10
        Me.cmdPlatedMeals.Text = "Plated Meal Menu"
        Me.cmdPlatedMeals.UseVisualStyleBackColor = False
        '
        'cmdHorsD
        '
        Me.cmdHorsD.BackColor = System.Drawing.Color.Chartreuse
        Me.cmdHorsD.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHorsD.Location = New System.Drawing.Point(38, 558)
        Me.cmdHorsD.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdHorsD.Name = "cmdHorsD"
        Me.cmdHorsD.Size = New System.Drawing.Size(442, 85)
        Me.cmdHorsD.TabIndex = 11
        Me.cmdHorsD.Text = "Hors d'oeuvre Menu"
        Me.cmdHorsD.UseVisualStyleBackColor = False
        '
        'cmdDessert
        '
        Me.cmdDessert.BackColor = System.Drawing.Color.Chartreuse
        Me.cmdDessert.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDessert.Location = New System.Drawing.Point(946, 558)
        Me.cmdDessert.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdDessert.Name = "cmdDessert"
        Me.cmdDessert.Size = New System.Drawing.Size(442, 85)
        Me.cmdDessert.TabIndex = 12
        Me.cmdDessert.Text = "Dessert Menu"
        Me.cmdDessert.UseVisualStyleBackColor = False
        '
        'cmdAfterglow
        '
        Me.cmdAfterglow.BackColor = System.Drawing.Color.Chartreuse
        Me.cmdAfterglow.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAfterglow.Location = New System.Drawing.Point(492, 558)
        Me.cmdAfterglow.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdAfterglow.Name = "cmdAfterglow"
        Me.cmdAfterglow.Size = New System.Drawing.Size(442, 85)
        Me.cmdAfterglow.TabIndex = 13
        Me.cmdAfterglow.Text = "Afterglow Menu"
        Me.cmdAfterglow.UseVisualStyleBackColor = False
        '
        'lblDietaryRestrictions
        '
        Me.lblDietaryRestrictions.AutoSize = True
        Me.lblDietaryRestrictions.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDietaryRestrictions.Location = New System.Drawing.Point(32, 969)
        Me.lblDietaryRestrictions.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDietaryRestrictions.Name = "lblDietaryRestrictions"
        Me.lblDietaryRestrictions.Size = New System.Drawing.Size(298, 36)
        Me.lblDietaryRestrictions.TabIndex = 14
        Me.lblDietaryRestrictions.Text = "Dietary Restrictions:"
        '
        'txtDietaryRestrictions
        '
        Me.txtDietaryRestrictions.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDietaryRestrictions.Location = New System.Drawing.Point(340, 888)
        Me.txtDietaryRestrictions.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtDietaryRestrictions.Multiline = True
        Me.txtDietaryRestrictions.Name = "txtDietaryRestrictions"
        Me.txtDietaryRestrictions.Size = New System.Drawing.Size(1044, 192)
        Me.txtDietaryRestrictions.TabIndex = 15
        '
        'lblSpecialNotes
        '
        Me.lblSpecialNotes.AutoSize = True
        Me.lblSpecialNotes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecialNotes.Location = New System.Drawing.Point(32, 1190)
        Me.lblSpecialNotes.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSpecialNotes.Name = "lblSpecialNotes"
        Me.lblSpecialNotes.Size = New System.Drawing.Size(217, 36)
        Me.lblSpecialNotes.TabIndex = 16
        Me.lblSpecialNotes.Text = "Special Notes:"
        '
        'txtSpecialNotes
        '
        Me.txtSpecialNotes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpecialNotes.Location = New System.Drawing.Point(340, 1095)
        Me.txtSpecialNotes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSpecialNotes.Multiline = True
        Me.txtSpecialNotes.Name = "txtSpecialNotes"
        Me.txtSpecialNotes.Size = New System.Drawing.Size(1044, 192)
        Me.txtSpecialNotes.TabIndex = 17
        '
        'cboCateringCompany
        '
        Me.cboCateringCompany.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCateringCompany.FormattingEnabled = True
        Me.cboCateringCompany.Location = New System.Drawing.Point(552, 113)
        Me.cboCateringCompany.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboCateringCompany.Name = "cboCateringCompany"
        Me.cboCateringCompany.Size = New System.Drawing.Size(334, 44)
        Me.cboCateringCompany.TabIndex = 18
        '
        'txtCateringCompanyEmail
        '
        Me.txtCateringCompanyEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCateringCompanyEmail.Location = New System.Drawing.Point(552, 308)
        Me.txtCateringCompanyEmail.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtCateringCompanyEmail.Name = "txtCateringCompanyEmail"
        Me.txtCateringCompanyEmail.Size = New System.Drawing.Size(620, 44)
        Me.txtCateringCompanyEmail.TabIndex = 19
        '
        'txtCateringCompanyName
        '
        Me.txtCateringCompanyName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCateringCompanyName.Location = New System.Drawing.Point(552, 175)
        Me.txtCateringCompanyName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtCateringCompanyName.Name = "txtCateringCompanyName"
        Me.txtCateringCompanyName.Size = New System.Drawing.Size(620, 44)
        Me.txtCateringCompanyName.TabIndex = 20
        '
        'mtbCateringPhone
        '
        Me.mtbCateringPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCateringPhone.Location = New System.Drawing.Point(552, 240)
        Me.mtbCateringPhone.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.mtbCateringPhone.Mask = "(999) 000-0000"
        Me.mtbCateringPhone.Name = "mtbCateringPhone"
        Me.mtbCateringPhone.Size = New System.Drawing.Size(250, 44)
        Me.mtbCateringPhone.TabIndex = 21
        '
        'cmdAddFoodSelections
        '
        Me.cmdAddFoodSelections.BackColor = System.Drawing.Color.Gold
        Me.cmdAddFoodSelections.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddFoodSelections.Location = New System.Drawing.Point(162, 1303)
        Me.cmdAddFoodSelections.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdAddFoodSelections.Name = "cmdAddFoodSelections"
        Me.cmdAddFoodSelections.Size = New System.Drawing.Size(564, 85)
        Me.cmdAddFoodSelections.TabIndex = 22
        Me.cmdAddFoodSelections.Text = "Add Food Selections to Event"
        Me.cmdAddFoodSelections.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Coral
        Me.cmdCancel.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(738, 1303)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(564, 85)
        Me.cmdCancel.TabIndex = 23
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(340, 684)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1044, 192)
        Me.TextBox1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 755)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 36)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Selected Menu Items:"
        '
        'frmFoodSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1408, 1406)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAddFoodSelections)
        Me.Controls.Add(Me.mtbCateringPhone)
        Me.Controls.Add(Me.txtCateringCompanyName)
        Me.Controls.Add(Me.txtCateringCompanyEmail)
        Me.Controls.Add(Me.cboCateringCompany)
        Me.Controls.Add(Me.txtSpecialNotes)
        Me.Controls.Add(Me.lblSpecialNotes)
        Me.Controls.Add(Me.txtDietaryRestrictions)
        Me.Controls.Add(Me.lblDietaryRestrictions)
        Me.Controls.Add(Me.cmdAfterglow)
        Me.Controls.Add(Me.cmdDessert)
        Me.Controls.Add(Me.cmdHorsD)
        Me.Controls.Add(Me.cmdPlatedMeals)
        Me.Controls.Add(Me.cmdTraditionalBuffet)
        Me.Controls.Add(Me.cmdStrollingStations)
        Me.Controls.Add(Me.chkFlatwareFee)
        Me.Controls.Add(Me.lblCateringCompanyEmail)
        Me.Controls.Add(Me.lblCateringCompanyPhone)
        Me.Controls.Add(Me.lblCateringCompanyName)
        Me.Controls.Add(Me.lblCateringCompany)
        Me.Controls.Add(Me.lblEventInfo)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmFoodSelection"
        Me.Text = "Food Selection - The Treasury"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEventInfo As Label
    Friend WithEvents lblCateringCompany As Label
    Friend WithEvents lblCateringCompanyName As Label
    Friend WithEvents lblCateringCompanyPhone As Label
    Friend WithEvents lblCateringCompanyEmail As Label
    Friend WithEvents chkFlatwareFee As CheckBox
    Friend WithEvents cmdStrollingStations As Button
    Friend WithEvents cmdTraditionalBuffet As Button
    Friend WithEvents cmdPlatedMeals As Button
    Friend WithEvents cmdHorsD As Button
    Friend WithEvents cmdDessert As Button
    Friend WithEvents cmdAfterglow As Button
    Friend WithEvents lblDietaryRestrictions As Label
    Friend WithEvents txtDietaryRestrictions As TextBox
    Friend WithEvents lblSpecialNotes As Label
    Friend WithEvents txtSpecialNotes As TextBox
    Friend WithEvents cboCateringCompany As ComboBox
    Friend WithEvents txtCateringCompanyEmail As TextBox
    Friend WithEvents txtCateringCompanyName As TextBox
    Friend WithEvents mtbCateringPhone As MaskedTextBox
    Friend WithEvents cmdAddFoodSelections As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
