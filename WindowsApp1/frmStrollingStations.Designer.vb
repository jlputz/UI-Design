<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStrollingStations
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
        Me.lblStrollingStations = New System.Windows.Forms.Label()
        Me.chkPastaStation = New System.Windows.Forms.CheckBox()
        Me.lblPastaItems = New System.Windows.Forms.Label()
        Me.cboPastaItems = New System.Windows.Forms.ComboBox()
        Me.cmdAddPastaItems = New System.Windows.Forms.Button()
        Me.cmdAddSeafoodItems = New System.Windows.Forms.Button()
        Me.cboSeafoodItems = New System.Windows.Forms.ComboBox()
        Me.lblSeafoodItems = New System.Windows.Forms.Label()
        Me.chkSeafood = New System.Windows.Forms.CheckBox()
        Me.cmdAddGardenItems = New System.Windows.Forms.Button()
        Me.cboGardenItems = New System.Windows.Forms.ComboBox()
        Me.lblGardenItems = New System.Windows.Forms.Label()
        Me.chkGarden = New System.Windows.Forms.CheckBox()
        Me.cmdCarvedEntreeAddItems = New System.Windows.Forms.Button()
        Me.cboCarvedEntreeItems = New System.Windows.Forms.ComboBox()
        Me.lblCarvedEntreeItems = New System.Windows.Forms.Label()
        Me.chkCarvedEntrees = New System.Windows.Forms.CheckBox()
        Me.cmdAddTacoTruckItems = New System.Windows.Forms.Button()
        Me.cboTacoTruckItems = New System.Windows.Forms.ComboBox()
        Me.lblTacoTruckItems = New System.Windows.Forms.Label()
        Me.chkTacoTruck = New System.Windows.Forms.CheckBox()
        Me.cmdAddBBQSidesItems = New System.Windows.Forms.Button()
        Me.cboBBQSidesItems = New System.Windows.Forms.ComboBox()
        Me.chkBBQSidesItems = New System.Windows.Forms.Label()
        Me.chkBBQSides = New System.Windows.Forms.CheckBox()
        Me.lstStrollingDinnerSelections = New System.Windows.Forms.ListBox()
        Me.lblStationsSelected = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAddStationSelections = New System.Windows.Forms.Button()
        Me.lblPastaAddons = New System.Windows.Forms.Label()
        Me.cboPastaAddons = New System.Windows.Forms.ComboBox()
        Me.cmdAddPastaAddons = New System.Windows.Forms.Button()
        Me.cmdAddStrollingDinnerItems = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStrollingStations
        '
        Me.lblStrollingStations.AutoSize = True
        Me.lblStrollingStations.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrollingStations.ForeColor = System.Drawing.Color.Wheat
        Me.lblStrollingStations.Location = New System.Drawing.Point(12, 9)
        Me.lblStrollingStations.Name = "lblStrollingStations"
        Me.lblStrollingStations.Size = New System.Drawing.Size(334, 32)
        Me.lblStrollingStations.TabIndex = 3
        Me.lblStrollingStations.Text = "Strolling Dinner Stations"
        '
        'chkPastaStation
        '
        Me.chkPastaStation.AutoSize = True
        Me.chkPastaStation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPastaStation.ForeColor = System.Drawing.Color.Wheat
        Me.chkPastaStation.Location = New System.Drawing.Point(19, 63)
        Me.chkPastaStation.Name = "chkPastaStation"
        Me.chkPastaStation.Size = New System.Drawing.Size(68, 22)
        Me.chkPastaStation.TabIndex = 4
        Me.chkPastaStation.Text = "Pasta"
        Me.chkPastaStation.UseVisualStyleBackColor = True
        '
        'lblPastaItems
        '
        Me.lblPastaItems.AutoSize = True
        Me.lblPastaItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastaItems.ForeColor = System.Drawing.Color.Wheat
        Me.lblPastaItems.Location = New System.Drawing.Point(16, 93)
        Me.lblPastaItems.Name = "lblPastaItems"
        Me.lblPastaItems.Size = New System.Drawing.Size(49, 18)
        Me.lblPastaItems.TabIndex = 5
        Me.lblPastaItems.Text = "Items:"
        '
        'cboPastaItems
        '
        Me.cboPastaItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPastaItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPastaItems.FormattingEnabled = True
        Me.cboPastaItems.Location = New System.Drawing.Point(76, 90)
        Me.cboPastaItems.Name = "cboPastaItems"
        Me.cboPastaItems.Size = New System.Drawing.Size(165, 26)
        Me.cboPastaItems.TabIndex = 6
        '
        'cmdAddPastaItems
        '
        Me.cmdAddPastaItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddPastaItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPastaItems.ForeColor = System.Drawing.Color.Wheat
        Me.cmdAddPastaItems.Location = New System.Drawing.Point(245, 86)
        Me.cmdAddPastaItems.Name = "cmdAddPastaItems"
        Me.cmdAddPastaItems.Size = New System.Drawing.Size(94, 31)
        Me.cmdAddPastaItems.TabIndex = 7
        Me.cmdAddPastaItems.Text = "Add Item"
        Me.cmdAddPastaItems.UseVisualStyleBackColor = False
        '
        'cmdAddSeafoodItems
        '
        Me.cmdAddSeafoodItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddSeafoodItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddSeafoodItems.ForeColor = System.Drawing.Color.Wheat
        Me.cmdAddSeafoodItems.Location = New System.Drawing.Point(242, 218)
        Me.cmdAddSeafoodItems.Name = "cmdAddSeafoodItems"
        Me.cmdAddSeafoodItems.Size = New System.Drawing.Size(94, 31)
        Me.cmdAddSeafoodItems.TabIndex = 11
        Me.cmdAddSeafoodItems.Text = "Add Item"
        Me.cmdAddSeafoodItems.UseVisualStyleBackColor = False
        '
        'cboSeafoodItems
        '
        Me.cboSeafoodItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeafoodItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSeafoodItems.FormattingEnabled = True
        Me.cboSeafoodItems.Location = New System.Drawing.Point(71, 222)
        Me.cboSeafoodItems.Name = "cboSeafoodItems"
        Me.cboSeafoodItems.Size = New System.Drawing.Size(165, 26)
        Me.cboSeafoodItems.TabIndex = 10
        '
        'lblSeafoodItems
        '
        Me.lblSeafoodItems.AutoSize = True
        Me.lblSeafoodItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeafoodItems.ForeColor = System.Drawing.Color.Wheat
        Me.lblSeafoodItems.Location = New System.Drawing.Point(16, 224)
        Me.lblSeafoodItems.Name = "lblSeafoodItems"
        Me.lblSeafoodItems.Size = New System.Drawing.Size(49, 18)
        Me.lblSeafoodItems.TabIndex = 9
        Me.lblSeafoodItems.Text = "Items:"
        '
        'chkSeafood
        '
        Me.chkSeafood.AutoSize = True
        Me.chkSeafood.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeafood.ForeColor = System.Drawing.Color.Wheat
        Me.chkSeafood.Location = New System.Drawing.Point(19, 194)
        Me.chkSeafood.Name = "chkSeafood"
        Me.chkSeafood.Size = New System.Drawing.Size(87, 22)
        Me.chkSeafood.TabIndex = 8
        Me.chkSeafood.Text = "Seafood"
        Me.chkSeafood.UseVisualStyleBackColor = True
        '
        'cmdAddGardenItems
        '
        Me.cmdAddGardenItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddGardenItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddGardenItems.ForeColor = System.Drawing.Color.Wheat
        Me.cmdAddGardenItems.Location = New System.Drawing.Point(242, 277)
        Me.cmdAddGardenItems.Name = "cmdAddGardenItems"
        Me.cmdAddGardenItems.Size = New System.Drawing.Size(94, 31)
        Me.cmdAddGardenItems.TabIndex = 15
        Me.cmdAddGardenItems.Text = "Add Item"
        Me.cmdAddGardenItems.UseVisualStyleBackColor = False
        '
        'cboGardenItems
        '
        Me.cboGardenItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGardenItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGardenItems.FormattingEnabled = True
        Me.cboGardenItems.Location = New System.Drawing.Point(71, 280)
        Me.cboGardenItems.Name = "cboGardenItems"
        Me.cboGardenItems.Size = New System.Drawing.Size(165, 26)
        Me.cboGardenItems.TabIndex = 14
        '
        'lblGardenItems
        '
        Me.lblGardenItems.AutoSize = True
        Me.lblGardenItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGardenItems.ForeColor = System.Drawing.Color.Wheat
        Me.lblGardenItems.Location = New System.Drawing.Point(16, 283)
        Me.lblGardenItems.Name = "lblGardenItems"
        Me.lblGardenItems.Size = New System.Drawing.Size(49, 18)
        Me.lblGardenItems.TabIndex = 13
        Me.lblGardenItems.Text = "Items:"
        '
        'chkGarden
        '
        Me.chkGarden.AutoSize = True
        Me.chkGarden.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarden.ForeColor = System.Drawing.Color.Wheat
        Me.chkGarden.Location = New System.Drawing.Point(19, 253)
        Me.chkGarden.Name = "chkGarden"
        Me.chkGarden.Size = New System.Drawing.Size(79, 22)
        Me.chkGarden.TabIndex = 12
        Me.chkGarden.Text = "Garden"
        Me.chkGarden.UseVisualStyleBackColor = True
        '
        'cmdCarvedEntreeAddItems
        '
        Me.cmdCarvedEntreeAddItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdCarvedEntreeAddItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCarvedEntreeAddItems.ForeColor = System.Drawing.Color.Wheat
        Me.cmdCarvedEntreeAddItems.Location = New System.Drawing.Point(242, 336)
        Me.cmdCarvedEntreeAddItems.Name = "cmdCarvedEntreeAddItems"
        Me.cmdCarvedEntreeAddItems.Size = New System.Drawing.Size(94, 31)
        Me.cmdCarvedEntreeAddItems.TabIndex = 19
        Me.cmdCarvedEntreeAddItems.Text = "Add Item"
        Me.cmdCarvedEntreeAddItems.UseVisualStyleBackColor = False
        '
        'cboCarvedEntreeItems
        '
        Me.cboCarvedEntreeItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCarvedEntreeItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarvedEntreeItems.FormattingEnabled = True
        Me.cboCarvedEntreeItems.Location = New System.Drawing.Point(71, 339)
        Me.cboCarvedEntreeItems.Name = "cboCarvedEntreeItems"
        Me.cboCarvedEntreeItems.Size = New System.Drawing.Size(165, 26)
        Me.cboCarvedEntreeItems.TabIndex = 18
        '
        'lblCarvedEntreeItems
        '
        Me.lblCarvedEntreeItems.AutoSize = True
        Me.lblCarvedEntreeItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarvedEntreeItems.ForeColor = System.Drawing.Color.Wheat
        Me.lblCarvedEntreeItems.Location = New System.Drawing.Point(16, 342)
        Me.lblCarvedEntreeItems.Name = "lblCarvedEntreeItems"
        Me.lblCarvedEntreeItems.Size = New System.Drawing.Size(49, 18)
        Me.lblCarvedEntreeItems.TabIndex = 17
        Me.lblCarvedEntreeItems.Text = "Items:"
        '
        'chkCarvedEntrees
        '
        Me.chkCarvedEntrees.AutoSize = True
        Me.chkCarvedEntrees.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCarvedEntrees.ForeColor = System.Drawing.Color.Wheat
        Me.chkCarvedEntrees.Location = New System.Drawing.Point(19, 313)
        Me.chkCarvedEntrees.Name = "chkCarvedEntrees"
        Me.chkCarvedEntrees.Size = New System.Drawing.Size(136, 22)
        Me.chkCarvedEntrees.TabIndex = 16
        Me.chkCarvedEntrees.Text = "Carved Entrees"
        Me.chkCarvedEntrees.UseVisualStyleBackColor = True
        '
        'cmdAddTacoTruckItems
        '
        Me.cmdAddTacoTruckItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddTacoTruckItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddTacoTruckItems.ForeColor = System.Drawing.Color.Wheat
        Me.cmdAddTacoTruckItems.Location = New System.Drawing.Point(242, 395)
        Me.cmdAddTacoTruckItems.Name = "cmdAddTacoTruckItems"
        Me.cmdAddTacoTruckItems.Size = New System.Drawing.Size(94, 31)
        Me.cmdAddTacoTruckItems.TabIndex = 23
        Me.cmdAddTacoTruckItems.Text = "Add Item"
        Me.cmdAddTacoTruckItems.UseVisualStyleBackColor = False
        '
        'cboTacoTruckItems
        '
        Me.cboTacoTruckItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTacoTruckItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTacoTruckItems.FormattingEnabled = True
        Me.cboTacoTruckItems.Location = New System.Drawing.Point(71, 398)
        Me.cboTacoTruckItems.Name = "cboTacoTruckItems"
        Me.cboTacoTruckItems.Size = New System.Drawing.Size(165, 26)
        Me.cboTacoTruckItems.TabIndex = 22
        '
        'lblTacoTruckItems
        '
        Me.lblTacoTruckItems.AutoSize = True
        Me.lblTacoTruckItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTacoTruckItems.ForeColor = System.Drawing.Color.Wheat
        Me.lblTacoTruckItems.Location = New System.Drawing.Point(16, 401)
        Me.lblTacoTruckItems.Name = "lblTacoTruckItems"
        Me.lblTacoTruckItems.Size = New System.Drawing.Size(49, 18)
        Me.lblTacoTruckItems.TabIndex = 21
        Me.lblTacoTruckItems.Text = "Items:"
        '
        'chkTacoTruck
        '
        Me.chkTacoTruck.AutoSize = True
        Me.chkTacoTruck.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTacoTruck.ForeColor = System.Drawing.Color.Wheat
        Me.chkTacoTruck.Location = New System.Drawing.Point(19, 371)
        Me.chkTacoTruck.Name = "chkTacoTruck"
        Me.chkTacoTruck.Size = New System.Drawing.Size(101, 22)
        Me.chkTacoTruck.TabIndex = 20
        Me.chkTacoTruck.Text = "Taco Truck"
        Me.chkTacoTruck.UseVisualStyleBackColor = True
        '
        'cmdAddBBQSidesItems
        '
        Me.cmdAddBBQSidesItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddBBQSidesItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddBBQSidesItems.ForeColor = System.Drawing.Color.Wheat
        Me.cmdAddBBQSidesItems.Location = New System.Drawing.Point(242, 454)
        Me.cmdAddBBQSidesItems.Name = "cmdAddBBQSidesItems"
        Me.cmdAddBBQSidesItems.Size = New System.Drawing.Size(94, 31)
        Me.cmdAddBBQSidesItems.TabIndex = 27
        Me.cmdAddBBQSidesItems.Text = "Add Item"
        Me.cmdAddBBQSidesItems.UseVisualStyleBackColor = False
        '
        'cboBBQSidesItems
        '
        Me.cboBBQSidesItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBBQSidesItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBBQSidesItems.FormattingEnabled = True
        Me.cboBBQSidesItems.Location = New System.Drawing.Point(71, 457)
        Me.cboBBQSidesItems.Name = "cboBBQSidesItems"
        Me.cboBBQSidesItems.Size = New System.Drawing.Size(165, 26)
        Me.cboBBQSidesItems.TabIndex = 26
        '
        'chkBBQSidesItems
        '
        Me.chkBBQSidesItems.AutoSize = True
        Me.chkBBQSidesItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBBQSidesItems.ForeColor = System.Drawing.Color.Wheat
        Me.chkBBQSidesItems.Location = New System.Drawing.Point(16, 460)
        Me.chkBBQSidesItems.Name = "chkBBQSidesItems"
        Me.chkBBQSidesItems.Size = New System.Drawing.Size(49, 18)
        Me.chkBBQSidesItems.TabIndex = 25
        Me.chkBBQSidesItems.Text = "Items:"
        '
        'chkBBQSides
        '
        Me.chkBBQSides.AutoSize = True
        Me.chkBBQSides.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBBQSides.ForeColor = System.Drawing.Color.Wheat
        Me.chkBBQSides.Location = New System.Drawing.Point(19, 430)
        Me.chkBBQSides.Name = "chkBBQSides"
        Me.chkBBQSides.Size = New System.Drawing.Size(136, 22)
        Me.chkBBQSides.TabIndex = 24
        Me.chkBBQSides.Text = "BBQ and Sides"
        Me.chkBBQSides.UseVisualStyleBackColor = True
        '
        'lstStrollingDinnerSelections
        '
        Me.lstStrollingDinnerSelections.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lstStrollingDinnerSelections.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStrollingDinnerSelections.ForeColor = System.Drawing.Color.Wheat
        Me.lstStrollingDinnerSelections.FormattingEnabled = True
        Me.lstStrollingDinnerSelections.ItemHeight = 18
        Me.lstStrollingDinnerSelections.Items.AddRange(New Object() {"Pasta Station (Choose 2 - $10):", "" & Global.Microsoft.VisualBasic.ChrW(9) & "-Fettucini & Alfredo", "" & Global.Microsoft.VisualBasic.ChrW(9) & "-Traditional Lasagna"})
        Me.lstStrollingDinnerSelections.Location = New System.Drawing.Point(345, 87)
        Me.lstStrollingDinnerSelections.Name = "lstStrollingDinnerSelections"
        Me.lstStrollingDinnerSelections.Size = New System.Drawing.Size(382, 310)
        Me.lstStrollingDinnerSelections.TabIndex = 28
        '
        'lblStationsSelected
        '
        Me.lblStationsSelected.AutoSize = True
        Me.lblStationsSelected.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStationsSelected.ForeColor = System.Drawing.Color.Wheat
        Me.lblStationsSelected.Location = New System.Drawing.Point(339, 63)
        Me.lblStationsSelected.Name = "lblStationsSelected"
        Me.lblStationsSelected.Size = New System.Drawing.Size(160, 18)
        Me.lblStationsSelected.TabIndex = 29
        Me.lblStationsSelected.Text = "Stations/Items Added:"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Coral
        Me.cmdCancel.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(372, 548)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(282, 44)
        Me.cmdCancel.TabIndex = 31
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdAddStationSelections
        '
        Me.cmdAddStationSelections.BackColor = System.Drawing.Color.Gold
        Me.cmdAddStationSelections.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddStationSelections.Location = New System.Drawing.Point(84, 548)
        Me.cmdAddStationSelections.Name = "cmdAddStationSelections"
        Me.cmdAddStationSelections.Size = New System.Drawing.Size(282, 44)
        Me.cmdAddStationSelections.TabIndex = 30
        Me.cmdAddStationSelections.Text = "Add Items to Food Selections"
        Me.cmdAddStationSelections.UseVisualStyleBackColor = False
        '
        'lblPastaAddons
        '
        Me.lblPastaAddons.AutoSize = True
        Me.lblPastaAddons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastaAddons.ForeColor = System.Drawing.Color.Wheat
        Me.lblPastaAddons.Location = New System.Drawing.Point(0, 135)
        Me.lblPastaAddons.Name = "lblPastaAddons"
        Me.lblPastaAddons.Size = New System.Drawing.Size(71, 18)
        Me.lblPastaAddons.TabIndex = 32
        Me.lblPastaAddons.Text = "Add-ons:"
        '
        'cboPastaAddons
        '
        Me.cboPastaAddons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPastaAddons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPastaAddons.FormattingEnabled = True
        Me.cboPastaAddons.Location = New System.Drawing.Point(76, 131)
        Me.cboPastaAddons.Name = "cboPastaAddons"
        Me.cboPastaAddons.Size = New System.Drawing.Size(165, 26)
        Me.cboPastaAddons.TabIndex = 33
        '
        'cmdAddPastaAddons
        '
        Me.cmdAddPastaAddons.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddPastaAddons.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPastaAddons.ForeColor = System.Drawing.Color.Wheat
        Me.cmdAddPastaAddons.Location = New System.Drawing.Point(245, 125)
        Me.cmdAddPastaAddons.Name = "cmdAddPastaAddons"
        Me.cmdAddPastaAddons.Size = New System.Drawing.Size(94, 31)
        Me.cmdAddPastaAddons.TabIndex = 34
        Me.cmdAddPastaAddons.Text = "Edit Item"
        Me.cmdAddPastaAddons.UseVisualStyleBackColor = False
        '
        'cmdAddStrollingDinnerItems
        '
        Me.cmdAddStrollingDinnerItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmdAddStrollingDinnerItems.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddStrollingDinnerItems.ForeColor = System.Drawing.Color.Wheat
        Me.cmdAddStrollingDinnerItems.Location = New System.Drawing.Point(29, 499)
        Me.cmdAddStrollingDinnerItems.Name = "cmdAddStrollingDinnerItems"
        Me.cmdAddStrollingDinnerItems.Size = New System.Drawing.Size(152, 39)
        Me.cmdAddStrollingDinnerItems.TabIndex = 35
        Me.cmdAddStrollingDinnerItems.Text = "Add to Event"
        Me.cmdAddStrollingDinnerItems.UseVisualStyleBackColor = False
        '
        'frmStrollingStations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(743, 550)
        Me.Controls.Add(Me.cmdAddStrollingDinnerItems)
        Me.Controls.Add(Me.cmdAddPastaAddons)
        Me.Controls.Add(Me.cboPastaAddons)
        Me.Controls.Add(Me.lblPastaAddons)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAddStationSelections)
        Me.Controls.Add(Me.lblStationsSelected)
        Me.Controls.Add(Me.lstStrollingDinnerSelections)
        Me.Controls.Add(Me.cmdAddBBQSidesItems)
        Me.Controls.Add(Me.cboBBQSidesItems)
        Me.Controls.Add(Me.chkBBQSidesItems)
        Me.Controls.Add(Me.chkBBQSides)
        Me.Controls.Add(Me.cmdAddTacoTruckItems)
        Me.Controls.Add(Me.cboTacoTruckItems)
        Me.Controls.Add(Me.lblTacoTruckItems)
        Me.Controls.Add(Me.chkTacoTruck)
        Me.Controls.Add(Me.cmdCarvedEntreeAddItems)
        Me.Controls.Add(Me.cboCarvedEntreeItems)
        Me.Controls.Add(Me.lblCarvedEntreeItems)
        Me.Controls.Add(Me.chkCarvedEntrees)
        Me.Controls.Add(Me.cmdAddGardenItems)
        Me.Controls.Add(Me.cboGardenItems)
        Me.Controls.Add(Me.lblGardenItems)
        Me.Controls.Add(Me.chkGarden)
        Me.Controls.Add(Me.cmdAddSeafoodItems)
        Me.Controls.Add(Me.cboSeafoodItems)
        Me.Controls.Add(Me.lblSeafoodItems)
        Me.Controls.Add(Me.chkSeafood)
        Me.Controls.Add(Me.cmdAddPastaItems)
        Me.Controls.Add(Me.cboPastaItems)
        Me.Controls.Add(Me.lblPastaItems)
        Me.Controls.Add(Me.chkPastaStation)
        Me.Controls.Add(Me.lblStrollingStations)
        Me.ForeColor = System.Drawing.Color.Wheat
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmStrollingStations"
        Me.Text = "Strolling Dinner Stations - The Treasury"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStrollingStations As Label
    Friend WithEvents chkPastaStation As CheckBox
    Friend WithEvents lblPastaItems As Label
    Friend WithEvents cboPastaItems As ComboBox
    Friend WithEvents cmdAddPastaItems As Button
    Friend WithEvents cmdAddSeafoodItems As Button
    Friend WithEvents cboSeafoodItems As ComboBox
    Friend WithEvents lblSeafoodItems As Label
    Friend WithEvents chkSeafood As CheckBox
    Friend WithEvents cmdAddGardenItems As Button
    Friend WithEvents cboGardenItems As ComboBox
    Friend WithEvents lblGardenItems As Label
    Friend WithEvents chkGarden As CheckBox
    Friend WithEvents cmdCarvedEntreeAddItems As Button
    Friend WithEvents cboCarvedEntreeItems As ComboBox
    Friend WithEvents lblCarvedEntreeItems As Label
    Friend WithEvents chkCarvedEntrees As CheckBox
    Friend WithEvents cmdAddTacoTruckItems As Button
    Friend WithEvents cboTacoTruckItems As ComboBox
    Friend WithEvents lblTacoTruckItems As Label
    Friend WithEvents chkTacoTruck As CheckBox
    Friend WithEvents cmdAddBBQSidesItems As Button
    Friend WithEvents cboBBQSidesItems As ComboBox
    Friend WithEvents chkBBQSidesItems As Label
    Friend WithEvents chkBBQSides As CheckBox
    Friend WithEvents lstStrollingDinnerSelections As ListBox
    Friend WithEvents lblStationsSelected As Label
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdAddStationSelections As Button
    Friend WithEvents lblPastaAddons As Label
    Friend WithEvents cboPastaAddons As ComboBox
    Friend WithEvents cmdAddPastaAddons As Button
    Friend WithEvents cmdAddStrollingDinnerItems As Button
End Class
