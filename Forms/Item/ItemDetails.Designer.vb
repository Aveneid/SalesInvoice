<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemDetails
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
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.itemPrice = New System.Windows.Forms.TextBox()
        Me.itemUnit = New System.Windows.Forms.ComboBox()
        Me.lbUnit = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.itemCategory = New System.Windows.Forms.ComboBox()
        Me.lbCategory = New System.Windows.Forms.Label()
        Me.itemCode = New System.Windows.Forms.TextBox()
        Me.lbCode = New System.Windows.Forms.Label()
        Me.itemName = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbCategoryEdit = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lbPrice
        '
        Me.lbPrice.Location = New System.Drawing.Point(13, 94)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(40, 23)
        Me.lbPrice.TabIndex = 26
        '
        'itemPrice
        '
        Me.itemPrice.Location = New System.Drawing.Point(68, 91)
        Me.itemPrice.Name = "itemPrice"
        Me.itemPrice.Size = New System.Drawing.Size(207, 20)
        Me.itemPrice.TabIndex = 25
        '
        'itemUnit
        '
        Me.itemUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemUnit.FormattingEnabled = True
        Me.itemUnit.Location = New System.Drawing.Point(68, 117)
        Me.itemUnit.Name = "itemUnit"
        Me.itemUnit.Size = New System.Drawing.Size(179, 21)
        Me.itemUnit.TabIndex = 23
        '
        'lbUnit
        '
        Me.lbUnit.Location = New System.Drawing.Point(13, 119)
        Me.lbUnit.Name = "lbUnit"
        Me.lbUnit.Size = New System.Drawing.Size(100, 23)
        Me.lbUnit.TabIndex = 22
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(281, 147)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 21
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'itemCategory
        '
        Me.itemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemCategory.FormattingEnabled = True
        Me.itemCategory.Location = New System.Drawing.Point(68, 64)
        Me.itemCategory.Name = "itemCategory"
        Me.itemCategory.Size = New System.Drawing.Size(207, 21)
        Me.itemCategory.TabIndex = 17
        '
        'lbCategory
        '
        Me.lbCategory.Location = New System.Drawing.Point(13, 67)
        Me.lbCategory.Name = "lbCategory"
        Me.lbCategory.Size = New System.Drawing.Size(100, 23)
        Me.lbCategory.TabIndex = 16
        '
        'itemCode
        '
        Me.itemCode.Location = New System.Drawing.Point(68, 38)
        Me.itemCode.Name = "itemCode"
        Me.itemCode.ReadOnly = True
        Me.itemCode.Size = New System.Drawing.Size(207, 20)
        Me.itemCode.TabIndex = 15
        '
        'lbCode
        '
        Me.lbCode.Location = New System.Drawing.Point(13, 41)
        Me.lbCode.Name = "lbCode"
        Me.lbCode.Size = New System.Drawing.Size(100, 23)
        Me.lbCode.TabIndex = 14
        '
        'itemName
        '
        Me.itemName.Location = New System.Drawing.Point(68, 12)
        Me.itemName.Name = "itemName"
        Me.itemName.Size = New System.Drawing.Size(288, 20)
        Me.itemName.TabIndex = 13
        '
        'lbName
        '
        Me.lbName.Location = New System.Drawing.Point(13, 15)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(100, 23)
        Me.lbName.TabIndex = 12
        '
        'lbCategoryEdit
        '
        Me.lbCategoryEdit.AutoSize = True
        Me.lbCategoryEdit.Location = New System.Drawing.Point(281, 67)
        Me.lbCategoryEdit.Name = "lbCategoryEdit"
        Me.lbCategoryEdit.Size = New System.Drawing.Size(59, 13)
        Me.lbCategoryEdit.TabIndex = 27
        Me.lbCategoryEdit.TabStop = True
        Me.lbCategoryEdit.Text = "LinkLabel1"
        '
        'ItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 183)
        Me.Controls.Add(Me.lbCategoryEdit)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.itemPrice)
        Me.Controls.Add(Me.itemUnit)
        Me.Controls.Add(Me.lbUnit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.itemCategory)
        Me.Controls.Add(Me.lbCategory)
        Me.Controls.Add(Me.itemCode)
        Me.Controls.Add(Me.lbCode)
        Me.Controls.Add(Me.itemName)
        Me.Controls.Add(Me.lbName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ItemDetails"
        Me.Text = "ItemDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbPrice As System.Windows.Forms.Label
    Friend WithEvents itemPrice As System.Windows.Forms.TextBox
    Friend WithEvents itemUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lbUnit As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents itemCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lbCategory As System.Windows.Forms.Label
    Friend WithEvents itemCode As System.Windows.Forms.TextBox
    Friend WithEvents lbCode As System.Windows.Forms.Label
    Friend WithEvents itemName As System.Windows.Forms.TextBox
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbCategoryEdit As LinkLabel
End Class
