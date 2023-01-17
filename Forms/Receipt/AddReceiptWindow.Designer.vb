<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddReceiptWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddReceiptWindow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ItemsInReceipt = New System.Windows.Forms.DataGridView()
        Me.CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbClient = New System.Windows.Forms.Label()
        Me.BuyerCombo = New System.Windows.Forms.ComboBox()
        Me.ReceiptDate = New System.Windows.Forms.DateTimePicker()
        Me.lbSummary = New System.Windows.Forms.Label()
        Me.SumAll = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbReceiptNo = New System.Windows.Forms.Label()
        Me.lbReceiptNoVal = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ItemsInReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ItemsInReceipt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 297)
        Me.Panel1.TabIndex = 5
        '
        'ItemsInReceipt
        '
        Me.ItemsInReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsInReceipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODE, Me.Item, Me.Amount, Me.Unit, Me.Value, Me.Sum})
        Me.ItemsInReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsInReceipt.Location = New System.Drawing.Point(0, 0)
        Me.ItemsInReceipt.Name = "ItemsInReceipt"
        Me.ItemsInReceipt.Size = New System.Drawing.Size(694, 297)
        Me.ItemsInReceipt.TabIndex = 0
        '
        'CODE
        '
        Me.CODE.HeaderText = "Code"
        Me.CODE.Name = "CODE"
        Me.CODE.ReadOnly = True
        Me.CODE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CODE.Width = 40
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Item.HeaderText = "Item"
        Me.Item.MinimumWidth = 2
        Me.Item.Name = "Item"
        Me.Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Amount
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle1
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Amount.Width = 50
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        Me.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Unit.Width = 75
        '
        'Value
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Value.DefaultCellStyle = DataGridViewCellStyle2
        Me.Value.HeaderText = "Value"
        Me.Value.MinimumWidth = 2
        Me.Value.Name = "Value"
        Me.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Sum
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Sum.DefaultCellStyle = DataGridViewCellStyle3
        Me.Sum.HeaderText = "Sum"
        Me.Sum.Name = "Sum"
        Me.Sum.ReadOnly = True
        Me.Sum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lbClient
        '
        Me.lbClient.AutoSize = True
        Me.lbClient.Location = New System.Drawing.Point(8, 59)
        Me.lbClient.Name = "lbClient"
        Me.lbClient.Size = New System.Drawing.Size(35, 13)
        Me.lbClient.TabIndex = 6
        Me.lbClient.Text = "Name"
        '
        'BuyerCombo
        '
        Me.BuyerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuyerCombo.FormattingEnabled = True
        Me.BuyerCombo.Location = New System.Drawing.Point(65, 56)
        Me.BuyerCombo.Name = "BuyerCombo"
        Me.BuyerCombo.Size = New System.Drawing.Size(225, 21)
        Me.BuyerCombo.TabIndex = 0
        '
        'ReceiptDate
        '
        Me.ReceiptDate.CustomFormat = "MM/dd/yyyy"
        Me.ReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReceiptDate.Location = New System.Drawing.Point(482, 30)
        Me.ReceiptDate.Name = "ReceiptDate"
        Me.ReceiptDate.Size = New System.Drawing.Size(200, 20)
        Me.ReceiptDate.TabIndex = 1
        Me.ReceiptDate.Value = New Date(2021, 2, 19, 0, 0, 0, 0)
        '
        'lbSummary
        '
        Me.lbSummary.AutoSize = True
        Me.lbSummary.Location = New System.Drawing.Point(318, 104)
        Me.lbSummary.Name = "lbSummary"
        Me.lbSummary.Size = New System.Drawing.Size(56, 13)
        Me.lbSummary.TabIndex = 9
        Me.lbSummary.Text = "Summary: "
        '
        'SumAll
        '
        Me.SumAll.AutoSize = True
        Me.SumAll.Location = New System.Drawing.Point(380, 104)
        Me.SumAll.Name = "SumAll"
        Me.SumAll.Size = New System.Drawing.Size(0, 13)
        Me.SumAll.TabIndex = 10
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(526, 99)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(296, 54)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(47, 23)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(607, 99)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteRowToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(131, 26)
        '
        'DeleteRowToolStripMenuItem
        '
        Me.DeleteRowToolStripMenuItem.Name = "DeleteRowToolStripMenuItem"
        Me.DeleteRowToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DeleteRowToolStripMenuItem.Text = "Delete row"
        '
        'lbReceiptNo
        '
        Me.lbReceiptNo.AutoSize = True
        Me.lbReceiptNo.Location = New System.Drawing.Point(13, 13)
        Me.lbReceiptNo.Name = "lbReceiptNo"
        Me.lbReceiptNo.Size = New System.Drawing.Size(68, 13)
        Me.lbReceiptNo.TabIndex = 14
        Me.lbReceiptNo.Text = "Receipt no. :"
        '
        'lbReceiptNoVal
        '
        Me.lbReceiptNoVal.AutoSize = True
        Me.lbReceiptNoVal.Location = New System.Drawing.Point(87, 13)
        Me.lbReceiptNoVal.Name = "lbReceiptNoVal"
        Me.lbReceiptNoVal.Size = New System.Drawing.Size(0, 13)
        Me.lbReceiptNoVal.TabIndex = 15
        Me.lbReceiptNoVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AddReceiptWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 426)
        Me.Controls.Add(Me.lbReceiptNoVal)
        Me.Controls.Add(Me.lbReceiptNo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.SumAll)
        Me.Controls.Add(Me.lbSummary)
        Me.Controls.Add(Me.ReceiptDate)
        Me.Controls.Add(Me.BuyerCombo)
        Me.Controls.Add(Me.lbClient)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(611, 464)
        Me.Name = "AddReceiptWindow"
        Me.Text = "New receipt"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ItemsInReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ItemsInReceipt As System.Windows.Forms.DataGridView
    Friend WithEvents lbClient As System.Windows.Forms.Label
    Friend WithEvents BuyerCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ReceiptDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbSummary As System.Windows.Forms.Label
    Friend WithEvents SumAll As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbReceiptNo As System.Windows.Forms.Label
    Friend WithEvents lbReceiptNoVal As System.Windows.Forms.Label
    Friend WithEvents CODE As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents Sum As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
End Class
