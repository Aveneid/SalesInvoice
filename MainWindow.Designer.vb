<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Splitcontainer1 = New System.Windows.Forms.SplitContainer()
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.RibbonSettingsBtn = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator1 = New System.Windows.Forms.RibbonSeparator()
        Me.RibbonInfoBtn = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator3 = New System.Windows.Forms.RibbonSeparator()
        Me.RibbonExitBtn = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonMainTab = New System.Windows.Forms.RibbonTab()
        Me.RibbonNewPanel = New System.Windows.Forms.RibbonPanel()
        Me.NewClientBtn = New System.Windows.Forms.RibbonButton()
        Me.NewReceiptBtn = New System.Windows.Forms.RibbonButton()
        Me.NewItemBtn = New System.Windows.Forms.RibbonButton()
        Me.RibbonDatabasePanel = New System.Windows.Forms.RibbonPanel()
        Me.ShowClientsBtn = New System.Windows.Forms.RibbonButton()
        Me.ShowReceiptsBtn = New System.Windows.Forms.RibbonButton()
        Me.ShowItemsBtn = New System.Windows.Forms.RibbonButton()
        Me.RaportsTab = New System.Windows.Forms.RibbonTab()
        Me.RaportsVar = New System.Windows.Forms.RibbonPanel()
        Me.repItems = New System.Windows.Forms.RibbonButton()
        Me.repCategories = New System.Windows.Forms.RibbonButton()
        Me.RaportsRanged = New System.Windows.Forms.RibbonPanel()
        Me.repMonth = New System.Windows.Forms.RibbonButton()
        Me.repRange = New System.Windows.Forms.RibbonButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusGC = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MainGridView = New System.Windows.Forms.DataGridView()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GCTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Splitcontainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitcontainer1.Panel1.SuspendLayout()
        Me.Splitcontainer1.Panel2.SuspendLayout()
        Me.Splitcontainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.MainGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitcontainer1
        '
        Me.Splitcontainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Splitcontainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Splitcontainer1.Location = New System.Drawing.Point(0, 0)
        Me.Splitcontainer1.Name = "Splitcontainer1"
        Me.Splitcontainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Splitcontainer1.Panel1
        '
        Me.Splitcontainer1.Panel1.Controls.Add(Me.Ribbon1)
        '
        'Splitcontainer1.Panel2
        '
        Me.Splitcontainer1.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Splitcontainer1.Panel2.Controls.Add(Me.MainGridView)
        Me.Splitcontainer1.Size = New System.Drawing.Size(724, 458)
        Me.Splitcontainer1.SplitterDistance = 123
        Me.Splitcontainer1.TabIndex = 5
        '
        'Ribbon1
        '
        Me.Ribbon1.CaptionBarVisible = False
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonSettingsBtn)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonSeparator1)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonInfoBtn)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonSeparator3)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonExitBtn)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 210)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbImage = Global.SalesInvoice.My.Resources.Resources.menu
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        '
        '
        '
        Me.Ribbon1.QuickAccessToolbar.DropDownButtonVisible = False
        Me.Ribbon1.QuickAccessToolbar.Enabled = False
        Me.Ribbon1.QuickAccessToolbar.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        Me.Ribbon1.QuickAccessToolbar.Visible = False
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(724, 126)
        Me.Ribbon1.TabIndex = 4
        Me.Ribbon1.Tabs.Add(Me.RibbonMainTab)
        Me.Ribbon1.Tabs.Add(Me.RaportsTab)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(5, 2, 20, 0)
        Me.Ribbon1.TabSpacing = 4
        Me.Ribbon1.Text = "Ribbon1"
        '
        'RibbonSettingsBtn
        '
        Me.RibbonSettingsBtn.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Right
        Me.RibbonSettingsBtn.Image = CType(resources.GetObject("RibbonSettingsBtn.Image"), System.Drawing.Image)
        Me.RibbonSettingsBtn.LargeImage = CType(resources.GetObject("RibbonSettingsBtn.LargeImage"), System.Drawing.Image)
        Me.RibbonSettingsBtn.Name = "RibbonSettingsBtn"
        Me.RibbonSettingsBtn.SmallImage = Global.SalesInvoice.My.Resources.Resources.database_32xLG
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.Name = "RibbonSeparator1"
        '
        'RibbonInfoBtn
        '
        Me.RibbonInfoBtn.Image = Global.SalesInvoice.My.Resources.Resources.gear_32xLG
        Me.RibbonInfoBtn.LargeImage = Global.SalesInvoice.My.Resources.Resources.gear_32xLG
        Me.RibbonInfoBtn.Name = "RibbonInfoBtn"
        Me.RibbonInfoBtn.SmallImage = Global.SalesInvoice.My.Resources.Resources.gear_32xLG
        '
        'RibbonSeparator3
        '
        Me.RibbonSeparator3.Name = "RibbonSeparator3"
        '
        'RibbonExitBtn
        '
        Me.RibbonExitBtn.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonExitBtn.Image = CType(resources.GetObject("RibbonExitBtn.Image"), System.Drawing.Image)
        Me.RibbonExitBtn.LargeImage = CType(resources.GetObject("RibbonExitBtn.LargeImage"), System.Drawing.Image)
        Me.RibbonExitBtn.Name = "RibbonExitBtn"
        Me.RibbonExitBtn.SmallImage = CType(resources.GetObject("RibbonExitBtn.SmallImage"), System.Drawing.Image)
        '
        'RibbonMainTab
        '
        Me.RibbonMainTab.Name = "RibbonMainTab"
        Me.RibbonMainTab.Panels.Add(Me.RibbonNewPanel)
        Me.RibbonMainTab.Panels.Add(Me.RibbonDatabasePanel)
        Me.RibbonMainTab.Text = "Główne"
        '
        'RibbonNewPanel
        '
        Me.RibbonNewPanel.ButtonMoreEnabled = False
        Me.RibbonNewPanel.ButtonMoreVisible = False
        Me.RibbonNewPanel.Items.Add(Me.NewClientBtn)
        Me.RibbonNewPanel.Items.Add(Me.NewReceiptBtn)
        Me.RibbonNewPanel.Items.Add(Me.NewItemBtn)
        Me.RibbonNewPanel.Name = "RibbonNewPanel"
        Me.RibbonNewPanel.Text = "Nowy"
        '
        'NewClientBtn
        '
        Me.NewClientBtn.Image = CType(resources.GetObject("NewClientBtn.Image"), System.Drawing.Image)
        Me.NewClientBtn.LargeImage = CType(resources.GetObject("NewClientBtn.LargeImage"), System.Drawing.Image)
        Me.NewClientBtn.MinimumSize = New System.Drawing.Size(50, 0)
        Me.NewClientBtn.Name = "NewClientBtn"
        Me.NewClientBtn.SmallImage = CType(resources.GetObject("NewClientBtn.SmallImage"), System.Drawing.Image)
        Me.NewClientBtn.Text = "New client"
        '
        'NewReceiptBtn
        '
        Me.NewReceiptBtn.Image = Global.SalesInvoice.My.Resources.Resources.UserInterfaceEditor_5845_32x
        Me.NewReceiptBtn.LargeImage = Global.SalesInvoice.My.Resources.Resources.UserInterfaceEditor_5845_32x
        Me.NewReceiptBtn.MinimumSize = New System.Drawing.Size(50, 0)
        Me.NewReceiptBtn.Name = "NewReceiptBtn"
        Me.NewReceiptBtn.SmallImage = CType(resources.GetObject("NewReceiptBtn.SmallImage"), System.Drawing.Image)
        Me.NewReceiptBtn.Text = "New receipt"
        '
        'NewItemBtn
        '
        Me.NewItemBtn.Image = Global.SalesInvoice.My.Resources.Resources.asset_treeView_24x24_on
        Me.NewItemBtn.LargeImage = Global.SalesInvoice.My.Resources.Resources.asset_treeView_24x24_on
        Me.NewItemBtn.Name = "NewItemBtn"
        Me.NewItemBtn.SmallImage = CType(resources.GetObject("NewItemBtn.SmallImage"), System.Drawing.Image)
        Me.NewItemBtn.Text = "New item"
        '
        'RibbonDatabasePanel
        '
        Me.RibbonDatabasePanel.ButtonMoreEnabled = False
        Me.RibbonDatabasePanel.ButtonMoreVisible = False
        Me.RibbonDatabasePanel.Items.Add(Me.ShowClientsBtn)
        Me.RibbonDatabasePanel.Items.Add(Me.ShowReceiptsBtn)
        Me.RibbonDatabasePanel.Items.Add(Me.ShowItemsBtn)
        Me.RibbonDatabasePanel.Name = "RibbonDatabasePanel"
        Me.RibbonDatabasePanel.Text = "Baza"
        '
        'ShowClientsBtn
        '
        Me.ShowClientsBtn.Image = CType(resources.GetObject("ShowClientsBtn.Image"), System.Drawing.Image)
        Me.ShowClientsBtn.LargeImage = CType(resources.GetObject("ShowClientsBtn.LargeImage"), System.Drawing.Image)
        Me.ShowClientsBtn.MinimumSize = New System.Drawing.Size(50, 0)
        Me.ShowClientsBtn.Name = "ShowClientsBtn"
        Me.ShowClientsBtn.SmallImage = CType(resources.GetObject("ShowClientsBtn.SmallImage"), System.Drawing.Image)
        Me.ShowClientsBtn.Text = "Show clients"
        '
        'ShowReceiptsBtn
        '
        Me.ShowReceiptsBtn.Image = Global.SalesInvoice.My.Resources.Resources.manifest_32xLG
        Me.ShowReceiptsBtn.LargeImage = Global.SalesInvoice.My.Resources.Resources.manifest_32xLG
        Me.ShowReceiptsBtn.Name = "ShowReceiptsBtn"
        Me.ShowReceiptsBtn.SmallImage = CType(resources.GetObject("ShowReceiptsBtn.SmallImage"), System.Drawing.Image)
        Me.ShowReceiptsBtn.Text = "Show receipts"
        '
        'ShowItemsBtn
        '
        Me.ShowItemsBtn.Image = Global.SalesInvoice.My.Resources.Resources.asset_treeView_24x24_on
        Me.ShowItemsBtn.LargeImage = Global.SalesInvoice.My.Resources.Resources.asset_treeView_24x24_on
        Me.ShowItemsBtn.Name = "ShowItemsBtn"
        Me.ShowItemsBtn.SmallImage = CType(resources.GetObject("ShowItemsBtn.SmallImage"), System.Drawing.Image)
        Me.ShowItemsBtn.Text = "Show items"
        '
        'RaportsTab
        '
        Me.RaportsTab.Name = "RaportsTab"
        Me.RaportsTab.Panels.Add(Me.RaportsVar)
        Me.RaportsTab.Panels.Add(Me.RaportsRanged)
        Me.RaportsTab.Text = "Raporty"
        '
        'RaportsVar
        '
        Me.RaportsVar.Items.Add(Me.repItems)
        Me.RaportsVar.Items.Add(Me.repCategories)
        Me.RaportsVar.Name = "RaportsVar"
        Me.RaportsVar.Text = "Raporty zmienne"
        '
        'repItems
        '
        Me.repItems.Image = Global.SalesInvoice.My.Resources.Resources.Textfile_818_32x
        Me.repItems.LargeImage = Global.SalesInvoice.My.Resources.Resources.Textfile_818_32x
        Me.repItems.Name = "repItems"
        Me.repItems.SmallImage = CType(resources.GetObject("repItems.SmallImage"), System.Drawing.Image)
        Me.repItems.Text = "Raport po przedmiotach"
        '
        'repCategories
        '
        Me.repCategories.Image = Global.SalesInvoice.My.Resources.Resources.CABProject_5818_32x
        Me.repCategories.LargeImage = Global.SalesInvoice.My.Resources.Resources.CABProject_5818_32x
        Me.repCategories.Name = "repCategories"
        Me.repCategories.SmallImage = CType(resources.GetObject("repCategories.SmallImage"), System.Drawing.Image)
        Me.repCategories.Text = "Raport po kategoriach"
        '
        'RaportsRanged
        '
        Me.RaportsRanged.Items.Add(Me.repMonth)
        Me.RaportsRanged.Items.Add(Me.repRange)
        Me.RaportsRanged.Name = "RaportsRanged"
        Me.RaportsRanged.Text = "Raporty stałe"
        '
        'repMonth
        '
        Me.repMonth.Image = Global.SalesInvoice.My.Resources.Resources.RSReport_32xLG
        Me.repMonth.LargeImage = Global.SalesInvoice.My.Resources.Resources.RSReport_32xLG
        Me.repMonth.Name = "repMonth"
        Me.repMonth.SmallImage = CType(resources.GetObject("repMonth.SmallImage"), System.Drawing.Image)
        Me.repMonth.Text = "Raport miesieczny"
        '
        'repRange
        '
        Me.repRange.Image = Global.SalesInvoice.My.Resources.Resources.IntelliTrace_48x
        Me.repRange.LargeImage = Global.SalesInvoice.My.Resources.Resources.IntelliTrace_48x
        Me.repRange.Name = "repRange"
        Me.repRange.SmallImage = CType(resources.GetObject("repRange.SmallImage"), System.Drawing.Image)
        Me.repRange.Text = "Raport z zakresu"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusGC, Me.StatusTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 309)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(724, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusGC
        '
        Me.StatusGC.Name = "StatusGC"
        Me.StatusGC.Size = New System.Drawing.Size(0, 17)
        '
        'StatusTime
        '
        Me.StatusTime.Name = "StatusTime"
        Me.StatusTime.Size = New System.Drawing.Size(709, 17)
        Me.StatusTime.Spring = True
        Me.StatusTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainGridView
        '
        Me.MainGridView.AllowUserToAddRows = False
        Me.MainGridView.AllowUserToDeleteRows = False
        Me.MainGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MainGridView.Location = New System.Drawing.Point(0, 0)
        Me.MainGridView.MultiSelect = False
        Me.MainGridView.Name = "MainGridView"
        Me.MainGridView.ReadOnly = True
        Me.MainGridView.Size = New System.Drawing.Size(724, 306)
        Me.MainGridView.TabIndex = 4
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel1.Text = "Delete"
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'GCTimer
        '
        Me.GCTimer.Interval = 600000
        '
        'TimeTimer
        '
        Me.TimeTimer.Enabled = True
        Me.TimeTimer.Interval = 1000
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 458)
        Me.Controls.Add(Me.Splitcontainer1)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(740, 496)
        Me.Name = "MainWindow"
        Me.Text = "Form1"
        Me.Splitcontainer1.Panel1.ResumeLayout(False)
        Me.Splitcontainer1.Panel2.ResumeLayout(False)
        Me.Splitcontainer1.Panel2.PerformLayout()
        CType(Me.Splitcontainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitcontainer1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.MainGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RibbonMainTab As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonNewPanel As System.Windows.Forms.RibbonPanel
    Friend WithEvents NewClientBtn As System.Windows.Forms.RibbonButton
    Friend WithEvents NewReceiptBtn As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonDatabasePanel As System.Windows.Forms.RibbonPanel
    Friend WithEvents ShowClientsBtn As System.Windows.Forms.RibbonButton
    Friend WithEvents ShowReceiptsBtn As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSettingsBtn As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator1 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents RibbonOrbMenuItem3 As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents RibbonExitBtn As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents RibbonSeparator3 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents NewItemBtn As System.Windows.Forms.RibbonButton
    Friend WithEvents ShowItemsBtn As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel4 As System.Windows.Forms.RibbonPanel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents MainGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RibbonOrbMenuItem1 As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents RibbonSeparator2 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents Splitcontainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Ribbon1 As System.Windows.Forms.Ribbon
    Friend WithEvents RibbonInfoBtn As System.Windows.Forms.RibbonButton
    Friend WithEvents RaportsTab As System.Windows.Forms.RibbonTab
    Friend WithEvents RaportsVar As RibbonPanel
    Friend WithEvents repItems As RibbonButton
    Friend WithEvents repCategories As RibbonButton
    Friend WithEvents RaportsRanged As RibbonPanel
    Friend WithEvents repMonth As RibbonButton
    Friend WithEvents repRange As RibbonButton
    Friend WithEvents contextMenuStrip1 As ContextMenuStrip
    Protected WithEvents GCTimer As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusGC As ToolStripStatusLabel
    Friend WithEvents StatusTime As ToolStripStatusLabel
    Friend WithEvents TimeTimer As Timer
End Class
