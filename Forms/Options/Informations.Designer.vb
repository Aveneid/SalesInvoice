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
        Me.Headline_info = New System.Windows.Forms.RichTextBox()
        Me.lbHeaderText = New System.Windows.Forms.Label()
        Me.tbFooter = New System.Windows.Forms.TabPage()
        Me.lbFooterText = New System.Windows.Forms.Label()
        Me.rtbFooterText = New System.Windows.Forms.RichTextBox()
        Me.tbSeller = New System.Windows.Forms.TabPage()
        Me.lbPostal = New System.Windows.Forms.Label()
        Me.Address_4 = New System.Windows.Forms.TextBox()
        Me.lbAddressNo = New System.Windows.Forms.Label()
        Me.Address_2 = New System.Windows.Forms.TextBox()
        Me.lbCity = New System.Windows.Forms.Label()
        Me.Address_3 = New System.Windows.Forms.TextBox()
        Me.Pesel = New System.Windows.Forms.TextBox()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.lbPesel = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.rtbSellerName = New System.Windows.Forms.RichTextBox()
        Me.Address_1 = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbBank = New System.Windows.Forms.TabPage()
        Me.BankAddress = New System.Windows.Forms.TextBox()
        Me.lbAccountNo = New System.Windows.Forms.Label()
        Me.lbBankAddress = New System.Windows.Forms.Label()
        Me.AccountNo = New System.Windows.Forms.TextBox()
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
        Me.tbHeader.Controls.Add(Me.Headline_info)
        Me.tbHeader.Controls.Add(Me.lbHeaderText)
        resources.ApplyResources(Me.tbHeader, "tbHeader")
        Me.tbHeader.Name = "tbHeader"
        '
        'Headline_info
        '
        resources.ApplyResources(Me.Headline_info, "Headline_info")
        Me.Headline_info.Name = "Headline_info"
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
        Me.tbSeller.Controls.Add(Me.lbPostal)
        Me.tbSeller.Controls.Add(Me.Address_4)
        Me.tbSeller.Controls.Add(Me.lbAddressNo)
        Me.tbSeller.Controls.Add(Me.Address_2)
        Me.tbSeller.Controls.Add(Me.lbCity)
        Me.tbSeller.Controls.Add(Me.Address_3)
        Me.tbSeller.Controls.Add(Me.Pesel)
        Me.tbSeller.Controls.Add(Me.lbPhone)
        Me.tbSeller.Controls.Add(Me.lbAddress)
        Me.tbSeller.Controls.Add(Me.lbPesel)
        Me.tbSeller.Controls.Add(Me.Phone)
        Me.tbSeller.Controls.Add(Me.rtbSellerName)
        Me.tbSeller.Controls.Add(Me.Address_1)
        Me.tbSeller.Controls.Add(Me.lbName)
        resources.ApplyResources(Me.tbSeller, "tbSeller")
        Me.tbSeller.Name = "tbSeller"
        '
        'lbPostal
        '
        resources.ApplyResources(Me.lbPostal, "lbPostal")
        Me.lbPostal.Name = "lbPostal"
        '
        'Address_4
        '
        resources.ApplyResources(Me.Address_4, "Address_4")
        Me.Address_4.Name = "Address_4"
        '
        'lbAddressNo
        '
        resources.ApplyResources(Me.lbAddressNo, "lbAddressNo")
        Me.lbAddressNo.Name = "lbAddressNo"
        '
        'Address_2
        '
        resources.ApplyResources(Me.Address_2, "Address_2")
        Me.Address_2.Name = "Address_2"
        '
        'lbCity
        '
        resources.ApplyResources(Me.lbCity, "lbCity")
        Me.lbCity.Name = "lbCity"
        '
        'Address_3
        '
        resources.ApplyResources(Me.Address_3, "Address_3")
        Me.Address_3.Name = "Address_3"
        '
        'Pesel
        '
        resources.ApplyResources(Me.Pesel, "Pesel")
        Me.Pesel.Name = "Pesel"
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
        'lbPesel
        '
        resources.ApplyResources(Me.lbPesel, "lbPesel")
        Me.lbPesel.Name = "lbPesel"
        '
        'Phone
        '
        resources.ApplyResources(Me.Phone, "Phone")
        Me.Phone.Name = "Phone"
        '
        'rtbSellerName
        '
        resources.ApplyResources(Me.rtbSellerName, "rtbSellerName")
        Me.rtbSellerName.Name = "rtbSellerName"
        '
        'Address_1
        '
        resources.ApplyResources(Me.Address_1, "Address_1")
        Me.Address_1.Name = "Address_1"
        '
        'lbName
        '
        resources.ApplyResources(Me.lbName, "lbName")
        Me.lbName.Name = "lbName"
        '
        'tbBank
        '
        Me.tbBank.BackColor = System.Drawing.SystemColors.Control
        Me.tbBank.Controls.Add(Me.BankAddress)
        Me.tbBank.Controls.Add(Me.lbAccountNo)
        Me.tbBank.Controls.Add(Me.lbBankAddress)
        Me.tbBank.Controls.Add(Me.AccountNo)
        resources.ApplyResources(Me.tbBank, "tbBank")
        Me.tbBank.Name = "tbBank"
        '
        'BankAddress
        '
        resources.ApplyResources(Me.BankAddress, "BankAddress")
        Me.BankAddress.Name = "BankAddress"
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
        'AccountNo
        '
        resources.ApplyResources(Me.AccountNo, "AccountNo")
        Me.AccountNo.Name = "AccountNo"
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
    Friend WithEvents lbPostal As Label
    Friend WithEvents Address_4 As TextBox
    Friend WithEvents lbAddressNo As Label
    Friend WithEvents Address_2 As TextBox
    Friend WithEvents lbCity As Label
    Friend WithEvents Address_3 As TextBox
    Friend WithEvents Pesel As TextBox
    Friend WithEvents lbPhone As Label
    Friend WithEvents lbAddress As Label
    Friend WithEvents lbPesel As Label
    Friend WithEvents Phone As TextBox
    Friend WithEvents rtbSellerName As RichTextBox
    Friend WithEvents Address_1 As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents Headline_info As RichTextBox
    Friend WithEvents lbHeaderText As Label
    Friend WithEvents BankAddress As TextBox
    Friend WithEvents lbAccountNo As Label
    Friend WithEvents lbBankAddress As Label
    Friend WithEvents AccountNo As TextBox
End Class
