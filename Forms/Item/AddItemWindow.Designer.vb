<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItemWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddItemWindow))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lbName = New System.Windows.Forms.Label()
        Me.ITEMNAME = New System.Windows.Forms.TextBox()
        Me.ITEMCATEGORY = New System.Windows.Forms.ComboBox()
        Me.lbCategories = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ITEMPRICE = New System.Windows.Forms.TextBox()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UNITCOMBO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lbName
        '
        resources.ApplyResources(Me.lbName, "lbName")
        Me.lbName.Name = "lbName"
        '
        'ITEMNAME
        '
        resources.ApplyResources(Me.ITEMNAME, "ITEMNAME")
        Me.ITEMNAME.Name = "ITEMNAME"
        '
        'ITEMCATEGORY
        '
        Me.ITEMCATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ITEMCATEGORY.FormattingEnabled = True
        Me.ITEMCATEGORY.Items.AddRange(New Object() {resources.GetString("ITEMCATEGORY.Items"), resources.GetString("ITEMCATEGORY.Items1")})
        resources.ApplyResources(Me.ITEMCATEGORY, "ITEMCATEGORY")
        Me.ITEMCATEGORY.Name = "ITEMCATEGORY"
        '
        'lbCategories
        '
        resources.ApplyResources(Me.lbCategories, "lbCategories")
        Me.lbCategories.Name = "lbCategories"
        '
        'ITEMPRICE
        '
        resources.ApplyResources(Me.ITEMPRICE, "ITEMPRICE")
        Me.ITEMPRICE.Name = "ITEMPRICE"
        '
        'lbPrice
        '
        resources.ApplyResources(Me.lbPrice, "lbPrice")
        Me.lbPrice.Name = "lbPrice"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.SizingGrip = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        '
        'UNITCOMBO
        '
        Me.UNITCOMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UNITCOMBO.FormattingEnabled = True
        resources.ApplyResources(Me.UNITCOMBO, "UNITCOMBO")
        Me.UNITCOMBO.Name = "UNITCOMBO"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'AddItemWindow
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UNITCOMBO)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.ITEMPRICE)
        Me.Controls.Add(Me.lbCategories)
        Me.Controls.Add(Me.ITEMCATEGORY)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.ITEMNAME)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddItemWindow"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents ITEMNAME As System.Windows.Forms.TextBox
    Friend WithEvents ITEMCATEGORY As System.Windows.Forms.ComboBox
    Friend WithEvents lbCategories As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ITEMPRICE As System.Windows.Forms.TextBox
    Friend WithEvents lbPrice As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UNITCOMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
