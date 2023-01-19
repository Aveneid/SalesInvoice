<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informations))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbHeader = New System.Windows.Forms.TabPage()
        Me.rtbHeaderText = New System.Windows.Forms.RichTextBox()
        Me.lbHeaderText = New System.Windows.Forms.Label()
        Me.tbFooter = New System.Windows.Forms.TabPage()
        Me.lbFooterText = New System.Windows.Forms.Label()
        Me.rtbFooterText = New System.Windows.Forms.RichTextBox()
        Me.tbSeller = New System.Windows.Forms.TabPage()
        Me.rtbSellerAddress = New System.Windows.Forms.RichTextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.rtbSellerName = New System.Windows.Forms.RichTextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbBank = New System.Windows.Forms.TabPage()
        Me.txtBankAddress = New System.Windows.Forms.TextBox()
        Me.lbAccountNo = New System.Windows.Forms.Label()
        Me.lbBankAddress = New System.Windows.Forms.Label()
        Me.txtAccountNo = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tbHeader.SuspendLayout()
        Me.tbFooter.SuspendLayout()
        Me.tbSeller.SuspendLayout()
        Me.tbBank.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbHeader)
        Me.TabControl1.Controls.Add(Me.tbFooter)
        Me.TabControl1.Controls.Add(Me.tbSeller)
        Me.TabControl1.Controls.Add(Me.tbBank)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'tbHeader
        '
        Me.tbHeader.BackColor = System.Drawing.SystemColors.Control
        Me.tbHeader.Controls.Add(Me.rtbHeaderText)
        Me.tbHeader.Controls.Add(Me.lbHeaderText)
        resources.ApplyResources(Me.tbHeader, "tbHeader")
        Me.tbHeader.Name = "tbHeader"
        '
        'rtbHeaderText
        '
        resources.ApplyResources(Me.rtbHeaderText, "rtbHeaderText")
        Me.rtbHeaderText.Name = "rtbHeaderText"
        '
        'lbHeaderText
        '
        resources.ApplyResources(Me.lbHeaderText, "lbHeaderText")
        Me.lbHeaderText.Name = "lbHeaderText"
        '
        'tbFooter
        '
        Me.tbFooter.BackColor = System.Drawing.SystemColors.Control
        Me.tbFooter.Controls.Add(Me.lbFooterText)
        Me.tbFooter.Controls.Add(Me.rtbFooterText)
        resources.ApplyResources(Me.tbFooter, "tbFooter")
        Me.tbFooter.Name = "tbFooter"
        '
        'lbFooterText
        '
        resources.ApplyResources(Me.lbFooterText, "lbFooterText")
        Me.lbFooterText.Name = "lbFooterText"
        '
        'rtbFooterText
        '
        resources.ApplyResources(Me.rtbFooterText, "rtbFooterText")
        Me.rtbFooterText.Name = "rtbFooterText"
        '
        'tbSeller
        '
        Me.tbSeller.BackColor = System.Drawing.SystemColors.Control
        Me.tbSeller.Controls.Add(Me.rtbSellerAddress)
        Me.tbSeller.Controls.Add(Me.txtID)
        Me.tbSeller.Controls.Add(Me.lbPhone)
        Me.tbSeller.Controls.Add(Me.lbAddress)
        Me.tbSeller.Controls.Add(Me.lbID)
        Me.tbSeller.Controls.Add(Me.txtPhone)
        Me.tbSeller.Controls.Add(Me.rtbSellerName)
        Me.tbSeller.Controls.Add(Me.lbName)
        resources.ApplyResources(Me.tbSeller, "tbSeller")
        Me.tbSeller.Name = "tbSeller"
        '
        'rtbSellerAddress
        '
        resources.ApplyResources(Me.rtbSellerAddress, "rtbSellerAddress")
        Me.rtbSellerAddress.Name = "rtbSellerAddress"
        '
        'txtID
        '
        resources.ApplyResources(Me.txtID, "txtID")
        Me.txtID.Name = "txtID"
        '
        'lbPhone
        '
        resources.ApplyResources(Me.lbPhone, "lbPhone")
        Me.lbPhone.Name = "lbPhone"
        '
        'lbAddress
        '
        resources.ApplyResources(Me.lbAddress, "lbAddress")
        Me.lbAddress.Name = "lbAddress"
        '
        'lbID
        '
        resources.ApplyResources(Me.lbID, "lbID")
        Me.lbID.Name = "lbID"
        '
        'txtPhone
        '
        resources.ApplyResources(Me.txtPhone, "txtPhone")
        Me.txtPhone.Name = "txtPhone"
        '
        'rtbSellerName
        '
        resources.ApplyResources(Me.rtbSellerName, "rtbSellerName")
        Me.rtbSellerName.Name = "rtbSellerName"
        '
        'lbName
        '
        resources.ApplyResources(Me.lbName, "lbName")
        Me.lbName.Name = "lbName"
        '
        'tbBank
        '
        Me.tbBank.BackColor = System.Drawing.SystemColors.Control
        Me.tbBank.Controls.Add(Me.txtBankAddress)
        Me.tbBank.Controls.Add(Me.lbAccountNo)
        Me.tbBank.Controls.Add(Me.lbBankAddress)
        Me.tbBank.Controls.Add(Me.txtAccountNo)
        resources.ApplyResources(Me.tbBank, "tbBank")
        Me.tbBank.Name = "tbBank"
        '
        'txtBankAddress
        '
        resources.ApplyResources(Me.txtBankAddress, "txtBankAddress")
        Me.txtBankAddress.Name = "txtBankAddress"
        '
        'lbAccountNo
        '
        resources.ApplyResources(Me.lbAccountNo, "lbAccountNo")
        Me.lbAccountNo.Name = "lbAccountNo"
        '
        'lbBankAddress
        '
        resources.ApplyResources(Me.lbBankAddress, "lbBankAddress")
        Me.lbBankAddress.Name = "lbBankAddress"
        '
        'txtAccountNo
        '
        resources.ApplyResources(Me.txtAccountNo, "txtAccountNo")
        Me.txtAccountNo.Name = "txtAccountNo"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Informations
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Informations"
        Me.TabControl1.ResumeLayout(False)
        Me.tbHeader.ResumeLayout(False)
        Me.tbHeader.PerformLayout()
        Me.tbFooter.ResumeLayout(False)
        Me.tbFooter.PerformLayout()
        Me.tbSeller.ResumeLayout(False)
        Me.tbSeller.PerformLayout()
        Me.tbBank.ResumeLayout(False)
        Me.tbBank.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbHeader As System.Windows.Forms.TabPage
    Friend WithEvents tbSeller As System.Windows.Forms.TabPage
    Friend WithEvents tbBank As System.Windows.Forms.TabPage
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tbFooter As TabPage
    Friend WithEvents lbFooterText As Label
    Friend WithEvents rtbFooterText As RichTextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lbPhone As Label
    Friend WithEvents lbAddress As Label
    Friend WithEvents lbID As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents rtbSellerName As RichTextBox
    Friend WithEvents lbName As Label
    Friend WithEvents rtbHeaderText As RichTextBox
    Friend WithEvents lbHeaderText As Label
    Friend WithEvents txtBankAddress As TextBox
    Friend WithEvents lbAccountNo As Label
    Friend WithEvents lbBankAddress As Label
    Friend WithEvents txtAccountNo As TextBox
    Friend WithEvents rtbSellerAddress As RichTextBox
End Class
