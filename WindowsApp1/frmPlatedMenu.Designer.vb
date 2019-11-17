<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlatedMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStarches = New System.Windows.Forms.ComboBox()
        Me.lblStarches = New System.Windows.Forms.Label()
        Me.cboVegetable = New System.Windows.Forms.ComboBox()
        Me.cboSaladSelections = New System.Windows.Forms.ComboBox()
        Me.lblSideDishes = New System.Windows.Forms.Label()
        Me.lblSaladSelections = New System.Windows.Forms.Label()
        Me.cmdAddSaladsToMeal = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cboEntrees = New System.Windows.Forms.ComboBox()
        Me.lblEntrees = New System.Windows.Forms.Label()
        Me.cmdAddVegetables = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblBuffetSelections = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblPastaCourse = New System.Windows.Forms.Label()
        Me.cmdAddToEventFoodSelections = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plated Dinner Selections"
        '
        'cboStarches
        '
        Me.cboStarches.FormattingEnabled = True
        Me.cboStarches.Location = New System.Drawing.Point(109, 147)
        Me.cboStarches.Name = "cboStarches"
        Me.cboStarches.Size = New System.Drawing.Size(194, 23)
        Me.cboStarches.TabIndex = 16
        '
        'lblStarches
        '
        Me.lblStarches.AutoSize = True
        Me.lblStarches.Location = New System.Drawing.Point(33, 150)
        Me.lblStarches.Name = "lblStarches"
        Me.lblStarches.Size = New System.Drawing.Size(70, 15)
        Me.lblStarches.TabIndex = 15
        Me.lblStarches.Text = "Starches:"
        '
        'cboVegetable
        '
        Me.cboVegetable.FormattingEnabled = True
        Me.cboVegetable.Location = New System.Drawing.Point(109, 107)
        Me.cboVegetable.Name = "cboVegetable"
        Me.cboVegetable.Size = New System.Drawing.Size(194, 23)
        Me.cboVegetable.TabIndex = 14
        '
        'cboSaladSelections
        '
        Me.cboSaladSelections.FormattingEnabled = True
        Me.cboSaladSelections.Location = New System.Drawing.Point(109, 67)
        Me.cboSaladSelections.Name = "cboSaladSelections"
        Me.cboSaladSelections.Size = New System.Drawing.Size(194, 23)
        Me.cboSaladSelections.TabIndex = 13
        '
        'lblSideDishes
        '
        Me.lblSideDishes.AutoSize = True
        Me.lblSideDishes.Location = New System.Drawing.Point(26, 110)
        Me.lblSideDishes.Name = "lblSideDishes"
        Me.lblSideDishes.Size = New System.Drawing.Size(77, 15)
        Me.lblSideDishes.TabIndex = 12
        Me.lblSideDishes.Text = "Vegetable:"
        '
        'lblSaladSelections
        '
        Me.lblSaladSelections.AutoSize = True
        Me.lblSaladSelections.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaladSelections.Location = New System.Drawing.Point(55, 70)
        Me.lblSaladSelections.Name = "lblSaladSelections"
        Me.lblSaladSelections.Size = New System.Drawing.Size(48, 15)
        Me.lblSaladSelections.TabIndex = 11
        Me.lblSaladSelections.Text = "Salad:"
        '
        'cmdAddSaladsToMeal
        '
        Me.cmdAddSaladsToMeal.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddSaladsToMeal.Location = New System.Drawing.Point(309, 63)
        Me.cmdAddSaladsToMeal.Name = "cmdAddSaladsToMeal"
        Me.cmdAddSaladsToMeal.Size = New System.Drawing.Size(111, 28)
        Me.cmdAddSaladsToMeal.TabIndex = 39
        Me.cmdAddSaladsToMeal.Text = "Add Salad"
        Me.cmdAddSaladsToMeal.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(309, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 28)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Add Entrée"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cboEntrees
        '
        Me.cboEntrees.FormattingEnabled = True
        Me.cboEntrees.Location = New System.Drawing.Point(109, 187)
        Me.cboEntrees.Name = "cboEntrees"
        Me.cboEntrees.Size = New System.Drawing.Size(194, 23)
        Me.cboEntrees.TabIndex = 42
        '
        'lblEntrees
        '
        Me.lblEntrees.AutoSize = True
        Me.lblEntrees.Location = New System.Drawing.Point(41, 190)
        Me.lblEntrees.Name = "lblEntrees"
        Me.lblEntrees.Size = New System.Drawing.Size(62, 15)
        Me.lblEntrees.TabIndex = 41
        Me.lblEntrees.Text = "Entrées:"
        '
        'cmdAddVegetables
        '
        Me.cmdAddVegetables.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddVegetables.Location = New System.Drawing.Point(309, 103)
        Me.cmdAddVegetables.Name = "cmdAddVegetables"
        Me.cmdAddVegetables.Size = New System.Drawing.Size(111, 28)
        Me.cmdAddVegetables.TabIndex = 44
        Me.cmdAddVegetables.Text = "Add Vegetable"
        Me.cmdAddVegetables.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(309, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 28)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Add Vegetable"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(434, 63)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(542, 329)
        Me.TextBox1.TabIndex = 46
        '
        'lblBuffetSelections
        '
        Me.lblBuffetSelections.AutoSize = True
        Me.lblBuffetSelections.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuffetSelections.Location = New System.Drawing.Point(431, 42)
        Me.lblBuffetSelections.Name = "lblBuffetSelections"
        Me.lblBuffetSelections.Size = New System.Drawing.Size(199, 18)
        Me.lblBuffetSelections.TabIndex = 47
        Me.lblBuffetSelections.Text = "Plated Menu Selections:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(309, 222)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 28)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Add Entrée"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(109, 226)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 23)
        Me.ComboBox1.TabIndex = 49
        '
        'lblPastaCourse
        '
        Me.lblPastaCourse.AutoSize = True
        Me.lblPastaCourse.Location = New System.Drawing.Point(5, 229)
        Me.lblPastaCourse.Name = "lblPastaCourse"
        Me.lblPastaCourse.Size = New System.Drawing.Size(98, 15)
        Me.lblPastaCourse.TabIndex = 48
        Me.lblPastaCourse.Text = "Pasta Course:"
        '
        'cmdAddToEventFoodSelections
        '
        Me.cmdAddToEventFoodSelections.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddToEventFoodSelections.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddToEventFoodSelections.ForeColor = System.Drawing.Color.Wheat
        Me.cmdAddToEventFoodSelections.Location = New System.Drawing.Point(583, 398)
        Me.cmdAddToEventFoodSelections.Name = "cmdAddToEventFoodSelections"
        Me.cmdAddToEventFoodSelections.Size = New System.Drawing.Size(279, 39)
        Me.cmdAddToEventFoodSelections.TabIndex = 52
        Me.cmdAddToEventFoodSelections.Text = "Add to Event Food Selections"
        Me.cmdAddToEventFoodSelections.UseVisualStyleBackColor = False
        '
        'frmPlatedMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(988, 447)
        Me.Controls.Add(Me.cmdAddToEventFoodSelections)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblPastaCourse)
        Me.Controls.Add(Me.lblBuffetSelections)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdAddVegetables)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cboEntrees)
        Me.Controls.Add(Me.lblEntrees)
        Me.Controls.Add(Me.cmdAddSaladsToMeal)
        Me.Controls.Add(Me.cboStarches)
        Me.Controls.Add(Me.lblStarches)
        Me.Controls.Add(Me.cboVegetable)
        Me.Controls.Add(Me.cboSaladSelections)
        Me.Controls.Add(Me.lblSideDishes)
        Me.Controls.Add(Me.lblSaladSelections)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Wheat
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmPlatedMenu"
        Me.Text = "frmPlatedMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboStarches As ComboBox
    Friend WithEvents lblStarches As Label
    Friend WithEvents cboVegetable As ComboBox
    Friend WithEvents cboSaladSelections As ComboBox
    Friend WithEvents lblSideDishes As Label
    Friend WithEvents lblSaladSelections As Label
    Friend WithEvents cmdAddSaladsToMeal As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cboEntrees As ComboBox
    Friend WithEvents lblEntrees As Label
    Friend WithEvents cmdAddVegetables As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblBuffetSelections As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblPastaCourse As Label
    Friend WithEvents cmdAddToEventFoodSelections As Button
End Class
