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
        Me.SuspendLayout()
        '
        'lblStrollingStations
        '
        Me.lblStrollingStations.AutoSize = True
        Me.lblStrollingStations.Font = New System.Drawing.Font("Franklin Gothic Medium", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrollingStations.Location = New System.Drawing.Point(24, 17)
        Me.lblStrollingStations.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblStrollingStations.Name = "lblStrollingStations"
        Me.lblStrollingStations.Size = New System.Drawing.Size(707, 81)
        Me.lblStrollingStations.TabIndex = 3
        Me.lblStrollingStations.Text = "Strolling Dinner Stations"
        '
        'chkPastaStation
        '
        Me.chkPastaStation.AutoSize = True
        Me.chkPastaStation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPastaStation.Location = New System.Drawing.Point(38, 121)
        Me.chkPastaStation.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkPastaStation.Name = "chkPastaStation"
        Me.chkPastaStation.Size = New System.Drawing.Size(127, 40)
        Me.chkPastaStation.TabIndex = 4
        Me.chkPastaStation.Text = "Pasta"
        Me.chkPastaStation.UseVisualStyleBackColor = True
        '
        'lblPastaItems
        '
        Me.lblPastaItems.AutoSize = True
        Me.lblPastaItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastaItems.Location = New System.Drawing.Point(32, 179)
        Me.lblPastaItems.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPastaItems.Name = "lblPastaItems"
        Me.lblPastaItems.Size = New System.Drawing.Size(102, 36)
        Me.lblPastaItems.TabIndex = 5
        Me.lblPastaItems.Text = "Items:"
        '
        'cboPastaItems
        '
        Me.cboPastaItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPastaItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPastaItems.FormattingEnabled = True
        Me.cboPastaItems.Location = New System.Drawing.Point(152, 173)
        Me.cboPastaItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboPastaItems.Name = "cboPastaItems"
        Me.cboPastaItems.Size = New System.Drawing.Size(326, 44)
        Me.cboPastaItems.TabIndex = 6
        '
        'cmdAddPastaItems
        '
        Me.cmdAddPastaItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPastaItems.Location = New System.Drawing.Point(490, 166)
        Me.cmdAddPastaItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdAddPastaItems.Name = "cmdAddPastaItems"
        Me.cmdAddPastaItems.Size = New System.Drawing.Size(188, 60)
        Me.cmdAddPastaItems.TabIndex = 7
        Me.cmdAddPastaItems.Text = "Add Item"
        Me.cmdAddPastaItems.UseVisualStyleBackColor = True
        '
        'cmdAddSeafoodItems
        '
        Me.cmdAddSeafoodItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddSeafoodItems.Location = New System.Drawing.Point(484, 420)
        Me.cmdAddSeafoodItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdAddSeafoodItems.Name = "cmdAddSeafoodItems"
        Me.cmdAddSeafoodItems.Size = New System.Drawing.Size(188, 60)
        Me.cmdAddSeafoodItems.TabIndex = 11
        Me.cmdAddSeafoodItems.Text = "Add Item"
        Me.cmdAddSeafoodItems.UseVisualStyleBackColor = True
        '
        'cboSeafoodItems
        '
        Me.cboSeafoodItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeafoodItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSeafoodItems.FormattingEnabled = True
        Me.cboSeafoodItems.Location = New System.Drawing.Point(142, 426)
        Me.cboSeafoodItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboSeafoodItems.Name = "cboSeafoodItems"
        Me.cboSeafoodItems.Size = New System.Drawing.Size(326, 44)
        Me.cboSeafoodItems.TabIndex = 10
        '
        'lblSeafoodItems
        '
        Me.lblSeafoodItems.AutoSize = True
        Me.lblSeafoodItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeafoodItems.Location = New System.Drawing.Point(32, 431)
        Me.lblSeafoodItems.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSeafoodItems.Name = "lblSeafoodItems"
        Me.lblSeafoodItems.Size = New System.Drawing.Size(102, 36)
        Me.lblSeafoodItems.TabIndex = 9
        Me.lblSeafoodItems.Text = "Items:"
        '
        'chkSeafood
        '
        Me.chkSeafood.AutoSize = True
        Me.chkSeafood.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeafood.Location = New System.Drawing.Point(38, 374)
        Me.chkSeafood.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkSeafood.Name = "chkSeafood"
        Me.chkSeafood.Size = New System.Drawing.Size(163, 40)
        Me.chkSeafood.TabIndex = 8
        Me.chkSeafood.Text = "Seafood"
        Me.chkSeafood.UseVisualStyleBackColor = True
        '
        'cmdAddGardenItems
        '
        Me.cmdAddGardenItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddGardenItems.Location = New System.Drawing.Point(484, 533)
        Me.cmdAddGardenItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdAddGardenItems.Name = "cmdAddGardenItems"
        Me.cmdAddGardenItems.Size = New System.Drawing.Size(188, 60)
        Me.cmdAddGardenItems.TabIndex = 15
        Me.cmdAddGardenItems.Text = "Add Item"
        Me.cmdAddGardenItems.UseVisualStyleBackColor = True
        '
        'cboGardenItems
        '
        Me.cboGardenItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGardenItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGardenItems.FormattingEnabled = True
        Me.cboGardenItems.Location = New System.Drawing.Point(142, 539)
        Me.cboGardenItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboGardenItems.Name = "cboGardenItems"
        Me.cboGardenItems.Size = New System.Drawing.Size(326, 44)
        Me.cboGardenItems.TabIndex = 14
        '
        'lblGardenItems
        '
        Me.lblGardenItems.AutoSize = True
        Me.lblGardenItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGardenItems.Location = New System.Drawing.Point(32, 545)
        Me.lblGardenItems.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblGardenItems.Name = "lblGardenItems"
        Me.lblGardenItems.Size = New System.Drawing.Size(102, 36)
        Me.lblGardenItems.TabIndex = 13
        Me.lblGardenItems.Text = "Items:"
        '
        'chkGarden
        '
        Me.chkGarden.AutoSize = True
        Me.chkGarden.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarden.Location = New System.Drawing.Point(38, 487)
        Me.chkGarden.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkGarden.Name = "chkGarden"
        Me.chkGarden.Size = New System.Drawing.Size(152, 40)
        Me.chkGarden.TabIndex = 12
        Me.chkGarden.Text = "Garden"
        Me.chkGarden.UseVisualStyleBackColor = True
        '
        'cmdCarvedEntreeAddItems
        '
        Me.cmdCarvedEntreeAddItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCarvedEntreeAddItems.Location = New System.Drawing.Point(484, 647)
        Me.cmdCarvedEntreeAddItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdCarvedEntreeAddItems.Name = "cmdCarvedEntreeAddItems"
        Me.cmdCarvedEntreeAddItems.Size = New System.Drawing.Size(188, 60)
        Me.cmdCarvedEntreeAddItems.TabIndex = 19
        Me.cmdCarvedEntreeAddItems.Text = "Add Item"
        Me.cmdCarvedEntreeAddItems.UseVisualStyleBackColor = True
        '
        'cboCarvedEntreeItems
        '
        Me.cboCarvedEntreeItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCarvedEntreeItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarvedEntreeItems.FormattingEnabled = True
        Me.cboCarvedEntreeItems.Location = New System.Drawing.Point(142, 652)
        Me.cboCarvedEntreeItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboCarvedEntreeItems.Name = "cboCarvedEntreeItems"
        Me.cboCarvedEntreeItems.Size = New System.Drawing.Size(326, 44)
        Me.cboCarvedEntreeItems.TabIndex = 18
        '
        'lblCarvedEntreeItems
        '
        Me.lblCarvedEntreeItems.AutoSize = True
        Me.lblCarvedEntreeItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarvedEntreeItems.Location = New System.Drawing.Point(32, 658)
        Me.lblCarvedEntreeItems.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCarvedEntreeItems.Name = "lblCarvedEntreeItems"
        Me.lblCarvedEntreeItems.Size = New System.Drawing.Size(102, 36)
        Me.lblCarvedEntreeItems.TabIndex = 17
        Me.lblCarvedEntreeItems.Text = "Items:"
        '
        'chkCarvedEntrees
        '
        Me.chkCarvedEntrees.AutoSize = True
        Me.chkCarvedEntrees.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCarvedEntrees.Location = New System.Drawing.Point(38, 601)
        Me.chkCarvedEntrees.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkCarvedEntrees.Name = "chkCarvedEntrees"
        Me.chkCarvedEntrees.Size = New System.Drawing.Size(265, 40)
        Me.chkCarvedEntrees.TabIndex = 16
        Me.chkCarvedEntrees.Text = "Carved Entrees"
        Me.chkCarvedEntrees.UseVisualStyleBackColor = True
        '
        'cmdAddTacoTruckItems
        '
        Me.cmdAddTacoTruckItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddTacoTruckItems.Location = New System.Drawing.Point(484, 760)
        Me.cmdAddTacoTruckItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdAddTacoTruckItems.Name = "cmdAddTacoTruckItems"
        Me.cmdAddTacoTruckItems.Size = New System.Drawing.Size(188, 60)
        Me.cmdAddTacoTruckItems.TabIndex = 23
        Me.cmdAddTacoTruckItems.Text = "Add Item"
        Me.cmdAddTacoTruckItems.UseVisualStyleBackColor = True
        '
        'cboTacoTruckItems
        '
        Me.cboTacoTruckItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTacoTruckItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTacoTruckItems.FormattingEnabled = True
        Me.cboTacoTruckItems.Location = New System.Drawing.Point(142, 766)
        Me.cboTacoTruckItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboTacoTruckItems.Name = "cboTacoTruckItems"
        Me.cboTacoTruckItems.Size = New System.Drawing.Size(326, 44)
        Me.cboTacoTruckItems.TabIndex = 22
        '
        'lblTacoTruckItems
        '
        Me.lblTacoTruckItems.AutoSize = True
        Me.lblTacoTruckItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTacoTruckItems.Location = New System.Drawing.Point(32, 772)
        Me.lblTacoTruckItems.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTacoTruckItems.Name = "lblTacoTruckItems"
        Me.lblTacoTruckItems.Size = New System.Drawing.Size(102, 36)
        Me.lblTacoTruckItems.TabIndex = 21
        Me.lblTacoTruckItems.Text = "Items:"
        '
        'chkTacoTruck
        '
        Me.chkTacoTruck.AutoSize = True
        Me.chkTacoTruck.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTacoTruck.Location = New System.Drawing.Point(38, 714)
        Me.chkTacoTruck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkTacoTruck.Name = "chkTacoTruck"
        Me.chkTacoTruck.Size = New System.Drawing.Size(199, 40)
        Me.chkTacoTruck.TabIndex = 20
        Me.chkTacoTruck.Text = "Taco Truck"
        Me.chkTacoTruck.UseVisualStyleBackColor = True
        '
        'cmdAddBBQSidesItems
        '
        Me.cmdAddBBQSidesItems.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddBBQSidesItems.Location = New System.Drawing.Point(484, 874)
        Me.cmdAddBBQSidesItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdAddBBQSidesItems.Name = "cmdAddBBQSidesItems"
        Me.cmdAddBBQSidesItems.Size = New System.Drawing.Size(188, 60)
        Me.cmdAddBBQSidesItems.TabIndex = 27
        Me.cmdAddBBQSidesItems.Text = "Add Item"
        Me.cmdAddBBQSidesItems.UseVisualStyleBackColor = True
        '
        'cboBBQSidesItems
        '
        Me.cboBBQSidesItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBBQSidesItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBBQSidesItems.FormattingEnabled = True
        Me.cboBBQSidesItems.Location = New System.Drawing.Point(142, 879)
        Me.cboBBQSidesItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboBBQSidesItems.Name = "cboBBQSidesItems"
        Me.cboBBQSidesItems.Size = New System.Drawing.Size(326, 44)
        Me.cboBBQSidesItems.TabIndex = 26
        '
        'chkBBQSidesItems
        '
        Me.chkBBQSidesItems.AutoSize = True
        Me.chkBBQSidesItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBBQSidesItems.Location = New System.Drawing.Point(32, 885)
        Me.chkBBQSidesItems.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.chkBBQSidesItems.Name = "chkBBQSidesItems"
        Me.chkBBQSidesItems.Size = New System.Drawing.Size(102, 36)
        Me.chkBBQSidesItems.TabIndex = 25
        Me.chkBBQSidesItems.Text = "Items:"
        '
        'chkBBQSides
        '
        Me.chkBBQSides.AutoSize = True
        Me.chkBBQSides.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBBQSides.Location = New System.Drawing.Point(38, 827)
        Me.chkBBQSides.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkBBQSides.Name = "chkBBQSides"
        Me.chkBBQSides.Size = New System.Drawing.Size(262, 40)
        Me.chkBBQSides.TabIndex = 24
        Me.chkBBQSides.Text = "BBQ and Sides"
        Me.chkBBQSides.UseVisualStyleBackColor = True
        '
        'lstStrollingDinnerSelections
        '
        Me.lstStrollingDinnerSelections.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStrollingDinnerSelections.FormattingEnabled = True
        Me.lstStrollingDinnerSelections.ItemHeight = 36
        Me.lstStrollingDinnerSelections.Items.AddRange(New Object() {"Pasta Station (Choose 2 - $10):", "" & Global.Microsoft.VisualBasic.ChrW(9) & "-Fettucini & Alfredo", "" & Global.Microsoft.VisualBasic.ChrW(9) & "-Traditional Lasagna"})
        Me.lstStrollingDinnerSelections.Location = New System.Drawing.Point(690, 167)
        Me.lstStrollingDinnerSelections.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstStrollingDinnerSelections.Name = "lstStrollingDinnerSelections"
        Me.lstStrollingDinnerSelections.Size = New System.Drawing.Size(760, 616)
        Me.lstStrollingDinnerSelections.TabIndex = 28
        '
        'lblStationsSelected
        '
        Me.lblStationsSelected.AutoSize = True
        Me.lblStationsSelected.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStationsSelected.Location = New System.Drawing.Point(678, 121)
        Me.lblStationsSelected.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblStationsSelected.Name = "lblStationsSelected"
        Me.lblStationsSelected.Size = New System.Drawing.Size(321, 36)
        Me.lblStationsSelected.TabIndex = 29
        Me.lblStationsSelected.Text = "Stations/Items Added:"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Coral
        Me.cmdCancel.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(743, 1054)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(564, 85)
        Me.cmdCancel.TabIndex = 31
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdAddStationSelections
        '
        Me.cmdAddStationSelections.BackColor = System.Drawing.Color.Gold
        Me.cmdAddStationSelections.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddStationSelections.Location = New System.Drawing.Point(167, 1054)
        Me.cmdAddStationSelections.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdAddStationSelections.Name = "cmdAddStationSelections"
        Me.cmdAddStationSelections.Size = New System.Drawing.Size(564, 85)
        Me.cmdAddStationSelections.TabIndex = 30
        Me.cmdAddStationSelections.Text = "Add Items to Food Selections"
        Me.cmdAddStationSelections.UseVisualStyleBackColor = False
        '
        'lblPastaAddons
        '
        Me.lblPastaAddons.AutoSize = True
        Me.lblPastaAddons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastaAddons.Location = New System.Drawing.Point(-1, 259)
        Me.lblPastaAddons.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPastaAddons.Name = "lblPastaAddons"
        Me.lblPastaAddons.Size = New System.Drawing.Size(141, 36)
        Me.lblPastaAddons.TabIndex = 32
        Me.lblPastaAddons.Text = "Add-ons:"
        '
        'cboPastaAddons
        '
        Me.cboPastaAddons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPastaAddons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPastaAddons.FormattingEnabled = True
        Me.cboPastaAddons.Location = New System.Drawing.Point(152, 251)
        Me.cboPastaAddons.Margin = New System.Windows.Forms.Padding(6)
        Me.cboPastaAddons.Name = "cboPastaAddons"
        Me.cboPastaAddons.Size = New System.Drawing.Size(326, 44)
        Me.cboPastaAddons.TabIndex = 33
        '
        'cmdAddPastaAddons
        '
        Me.cmdAddPastaAddons.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPastaAddons.Location = New System.Drawing.Point(490, 241)
        Me.cmdAddPastaAddons.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdAddPastaAddons.Name = "cmdAddPastaAddons"
        Me.cmdAddPastaAddons.Size = New System.Drawing.Size(188, 60)
        Me.cmdAddPastaAddons.TabIndex = 34
        Me.cmdAddPastaAddons.Text = "Edit Item"
        Me.cmdAddPastaAddons.UseVisualStyleBackColor = True
        '
        'frmStrollingStations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1735, 1285)
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
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
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
End Class
