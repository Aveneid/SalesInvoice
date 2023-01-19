<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FirstRunWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstRunWizard))
        Me.tbWizardCards = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbLang = New System.Windows.Forms.Label()
        Me.cbLang = New System.Windows.Forms.ComboBox()
        Me.lbWelcomeInfo = New System.Windows.Forms.Label()
        Me.lbHi = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDatabaseName = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.rtbAddress = New System.Windows.Forms.RichTextBox()
        Me.txtPesel = New System.Windows.Forms.TextBox()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.lbPesel = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.rtbSellerName = New System.Windows.Forms.RichTextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbIdInfo = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lbFooterText = New System.Windows.Forms.Label()
        Me.rtbFooterText = New System.Windows.Forms.RichTextBox()
        Me.lbHeadInfo = New System.Windows.Forms.Label()
        Me.rtbHeadlineInfo = New System.Windows.Forms.RichTextBox()
        Me.lbHeaderText = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lbBankInfo = New System.Windows.Forms.Label()
        Me.txtBankAddress = New System.Windows.Forms.TextBox()
        Me.lbAccountNo = New System.Windows.Forms.Label()
        Me.lbBankAddress = New System.Windows.Forms.Label()
        Me.txtAccountNo = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.lbEndingInfo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuLabel1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuLabel5 = New System.Windows.Forms.Label()
        Me.MenuLabel4 = New System.Windows.Forms.Label()
        Me.MenuLabel3 = New System.Windows.Forms.Label()
        Me.MenuLabel2 = New System.Windows.Forms.Label()
        Me.MenuLabel0 = New System.Windows.Forms.Label()
        Me.tbWizardCards.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbWizardCards
        '
        Me.tbWizardCards.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbWizardCards.Controls.Add(Me.TabPage1)
        Me.tbWizardCards.Controls.Add(Me.TabPage2)
        Me.tbWizardCards.Controls.Add(Me.TabPage3)
        Me.tbWizardCards.Controls.Add(Me.TabPage4)
        Me.tbWizardCards.Controls.Add(Me.TabPage5)
        Me.tbWizardCards.Controls.Add(Me.TabPage6)
        Me.tbWizardCards.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbWizardCards.Location = New System.Drawing.Point(138, 0)
        Me.tbWizardCards.Name = "tbWizardCards"
        Me.tbWizardCards.SelectedIndex = 0
        Me.tbWizardCards.Size = New System.Drawing.Size(348, 332)
        Me.tbWizardCards.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TabPage1.Controls.Add(Me.lbLang)
        Me.TabPage1.Controls.Add(Me.cbLang)
        Me.TabPage1.Controls.Add(Me.lbWelcomeInfo)
        Me.TabPage1.Controls.Add(Me.lbHi)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(340, 303)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Witaj!"
        '
        'lbLang
        '
        Me.lbLang.AutoSize = True
        Me.lbLang.Location = New System.Drawing.Point(238, 260)
        Me.lbLang.Name = "lbLang"
        Me.lbLang.Size = New System.Drawing.Size(34, 13)
        Me.lbLang.TabIndex = 3
        Me.lbLang.Text = "Język"
        '
        'cbLang
        '
        Me.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLang.FormattingEnabled = True
        Me.cbLang.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cbLang.Items.AddRange(New Object() {"English", "Polski"})
        Me.cbLang.Location = New System.Drawing.Point(241, 276)
        Me.cbLang.Name = "cbLang"
        Me.cbLang.Size = New System.Drawing.Size(91, 21)
        Me.cbLang.TabIndex = 2
        '
        'lbWelcomeInfo
        '
        Me.lbWelcomeInfo.AutoSize = True
        Me.lbWelcomeInfo.Location = New System.Drawing.Point(32, 110)
        Me.lbWelcomeInfo.Name = "lbWelcomeInfo"
        Me.lbWelcomeInfo.Size = New System.Drawing.Size(275, 52)
        Me.lbWelcomeInfo.TabIndex = 1
        Me.lbWelcomeInfo.Text = "Zanim zaczniemy pracę musimy uzupełnić klika ważnych" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "informacji. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To będzie s" &
    "zybkie i łatwe!"
        '
        'lbHi
        '
        Me.lbHi.AutoSize = True
        Me.lbHi.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.lbHi.Location = New System.Drawing.Point(26, 50)
        Me.lbHi.Name = "lbHi"
        Me.lbHi.Size = New System.Drawing.Size(105, 33)
        Me.lbHi.TabIndex = 0
        Me.lbHi.Text = "Cześć!"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtDatabaseName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(340, 303)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Baza danych"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 78)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nazwa:"
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.Location = New System.Drawing.Point(91, 133)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(205, 20)
        Me.txtDatabaseName.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.rtbAddress)
        Me.TabPage3.Controls.Add(Me.txtPesel)
        Me.TabPage3.Controls.Add(Me.lbPhone)
        Me.TabPage3.Controls.Add(Me.lbAddress)
        Me.TabPage3.Controls.Add(Me.lbPesel)
        Me.TabPage3.Controls.Add(Me.txtPhone)
        Me.TabPage3.Controls.Add(Me.rtbSellerName)
        Me.TabPage3.Controls.Add(Me.lbName)
        Me.TabPage3.Controls.Add(Me.lbIdInfo)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(340, 303)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Dane Identyfikacyjne"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'rtbAddress
        '
        Me.rtbAddress.Location = New System.Drawing.Point(117, 140)
        Me.rtbAddress.Name = "rtbAddress"
        Me.rtbAddress.Size = New System.Drawing.Size(215, 56)
        Me.rtbAddress.TabIndex = 32
        Me.rtbAddress.Text = ""
        '
        'txtPesel
        '
        Me.txtPesel.Location = New System.Drawing.Point(117, 228)
        Me.txtPesel.Name = "txtPesel"
        Me.txtPesel.Size = New System.Drawing.Size(215, 20)
        Me.txtPesel.TabIndex = 6
        '
        'lbPhone
        '
        Me.lbPhone.AutoSize = True
        Me.lbPhone.Location = New System.Drawing.Point(21, 205)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(41, 13)
        Me.lbPhone.TabIndex = 29
        Me.lbPhone.Text = "Phone:"
        '
        'lbAddress
        '
        Me.lbAddress.AutoSize = True
        Me.lbAddress.Location = New System.Drawing.Point(21, 142)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(45, 13)
        Me.lbAddress.TabIndex = 28
        Me.lbAddress.Text = "Address"
        '
        'lbPesel
        '
        Me.lbPesel.AutoSize = True
        Me.lbPesel.Location = New System.Drawing.Point(21, 231)
        Me.lbPesel.Name = "lbPesel"
        Me.lbPesel.Size = New System.Drawing.Size(54, 13)
        Me.lbPesel.TabIndex = 30
        Me.lbPesel.Text = "PESEL (*)"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(117, 202)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(215, 20)
        Me.txtPhone.TabIndex = 5
        '
        'rtbSellerName
        '
        Me.rtbSellerName.Location = New System.Drawing.Point(117, 77)
        Me.rtbSellerName.Name = "rtbSellerName"
        Me.rtbSellerName.Size = New System.Drawing.Size(215, 56)
        Me.rtbSellerName.TabIndex = 0
        Me.rtbSellerName.Text = ""
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(21, 80)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(35, 13)
        Me.lbName.TabIndex = 31
        Me.lbName.Text = "Name"
        '
        'lbIdInfo
        '
        Me.lbIdInfo.AutoSize = True
        Me.lbIdInfo.Location = New System.Drawing.Point(15, 16)
        Me.lbIdInfo.Name = "lbIdInfo"
        Me.lbIdInfo.Size = New System.Drawing.Size(265, 52)
        Me.lbIdInfo.TabIndex = 0
        Me.lbIdInfo.Text = "Te dane są danymi podstawowymi jakie są wymagane " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "do prawidłowego druku rachunku" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proszę wypełnić ten formularz."
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lbFooterText)
        Me.TabPage4.Controls.Add(Me.rtbFooterText)
        Me.TabPage4.Controls.Add(Me.lbHeadInfo)
        Me.TabPage4.Controls.Add(Me.rtbHeadlineInfo)
        Me.TabPage4.Controls.Add(Me.lbHeaderText)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(340, 303)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "Informacje nagłówka"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lbFooterText
        '
        Me.lbFooterText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFooterText.Location = New System.Drawing.Point(3, 157)
        Me.lbFooterText.Name = "lbFooterText"
        Me.lbFooterText.Size = New System.Drawing.Size(329, 18)
        Me.lbFooterText.TabIndex = 12
        Me.lbFooterText.Text = "Info:"
        Me.lbFooterText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rtbFooterText
        '
        Me.rtbFooterText.Location = New System.Drawing.Point(63, 184)
        Me.rtbFooterText.Name = "rtbFooterText"
        Me.rtbFooterText.Size = New System.Drawing.Size(229, 108)
        Me.rtbFooterText.TabIndex = 11
        Me.rtbFooterText.Text = ""
        '
        'lbHeadInfo
        '
        Me.lbHeadInfo.AutoSize = True
        Me.lbHeadInfo.Location = New System.Drawing.Point(19, 13)
        Me.lbHeadInfo.Name = "lbHeadInfo"
        Me.lbHeadInfo.Size = New System.Drawing.Size(253, 26)
        Me.lbHeadInfo.TabIndex = 10
        Me.lbHeadInfo.Text = "Informacje nagłówka " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(będą umieszczone w lewym górnym rogu rachunku)"
        '
        'rtbHeadlineInfo
        '
        Me.rtbHeadlineInfo.Location = New System.Drawing.Point(63, 64)
        Me.rtbHeadlineInfo.Name = "rtbHeadlineInfo"
        Me.rtbHeadlineInfo.Size = New System.Drawing.Size(229, 90)
        Me.rtbHeadlineInfo.TabIndex = 0
        Me.rtbHeadlineInfo.Text = ""
        '
        'lbHeaderText
        '
        Me.lbHeaderText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbHeaderText.Location = New System.Drawing.Point(3, 40)
        Me.lbHeaderText.Name = "lbHeaderText"
        Me.lbHeaderText.Size = New System.Drawing.Size(329, 21)
        Me.lbHeaderText.TabIndex = 8
        Me.lbHeaderText.Text = "Info:"
        Me.lbHeaderText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lbBankInfo)
        Me.TabPage5.Controls.Add(Me.txtBankAddress)
        Me.TabPage5.Controls.Add(Me.lbAccountNo)
        Me.TabPage5.Controls.Add(Me.lbBankAddress)
        Me.TabPage5.Controls.Add(Me.txtAccountNo)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(340, 303)
        Me.TabPage5.TabIndex = 3
        Me.TabPage5.Text = "Informacje bankowe"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lbBankInfo
        '
        Me.lbBankInfo.AutoSize = True
        Me.lbBankInfo.Location = New System.Drawing.Point(27, 23)
        Me.lbBankInfo.Name = "lbBankInfo"
        Me.lbBankInfo.Size = New System.Drawing.Size(303, 65)
        Me.lbBankInfo.TabIndex = 32
        Me.lbBankInfo.Text = "Here's your bank information. If you will receive money by bank" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " transfer please" &
    " fill this form, otherwise payment via bank" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " transfer will be locked." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You ca" &
    "n fill this later in options window." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtBankAddress
        '
        Me.txtBankAddress.Location = New System.Drawing.Point(58, 209)
        Me.txtBankAddress.Multiline = True
        Me.txtBankAddress.Name = "txtBankAddress"
        Me.txtBankAddress.Size = New System.Drawing.Size(226, 47)
        Me.txtBankAddress.TabIndex = 1
        '
        'lbAccountNo
        '
        Me.lbAccountNo.AutoSize = True
        Me.lbAccountNo.Location = New System.Drawing.Point(133, 141)
        Me.lbAccountNo.Name = "lbAccountNo"
        Me.lbAccountNo.Size = New System.Drawing.Size(68, 13)
        Me.lbAccountNo.TabIndex = 28
        Me.lbAccountNo.Text = "Numer konta"
        '
        'lbBankAddress
        '
        Me.lbBankAddress.AutoSize = True
        Me.lbBankAddress.Location = New System.Drawing.Point(133, 193)
        Me.lbBankAddress.Name = "lbBankAddress"
        Me.lbBankAddress.Size = New System.Drawing.Size(67, 13)
        Me.lbBankAddress.TabIndex = 30
        Me.lbBankAddress.Text = "Adres banku"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.Location = New System.Drawing.Point(58, 157)
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(226, 20)
        Me.txtAccountNo.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.lbEndingInfo)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(340, 303)
        Me.TabPage6.TabIndex = 4
        Me.TabPage6.Text = "Możemy zaczynać!"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'lbEndingInfo
        '
        Me.lbEndingInfo.AutoSize = True
        Me.lbEndingInfo.Location = New System.Drawing.Point(23, 36)
        Me.lbEndingInfo.Name = "lbEndingInfo"
        Me.lbEndingInfo.Size = New System.Drawing.Size(45, 13)
        Me.lbEndingInfo.TabIndex = 0
        Me.lbEndingInfo.Text = "Label14"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 332)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 50)
        Me.Panel1.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Enabled = False
        Me.btnBack.Location = New System.Drawing.Point(215, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Wstecz"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(296, 15)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Dalej"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(399, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Anuluj"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuLabel1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.MenuLabel5)
        Me.Panel2.Controls.Add(Me.MenuLabel4)
        Me.Panel2.Controls.Add(Me.MenuLabel3)
        Me.Panel2.Controls.Add(Me.MenuLabel2)
        Me.Panel2.Controls.Add(Me.MenuLabel0)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(136, 332)
        Me.Panel2.TabIndex = 2
        '
        'MenuLabel1
        '
        Me.MenuLabel1.AutoSize = True
        Me.MenuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.MenuLabel1.Location = New System.Drawing.Point(12, 165)
        Me.MenuLabel1.Name = "MenuLabel1"
        Me.MenuLabel1.Size = New System.Drawing.Size(68, 13)
        Me.MenuLabel1.TabIndex = 6
        Me.MenuLabel1.Text = "Baza danych"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SalesInvoice.My.Resources.Resources.wizard
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'MenuLabel5
        '
        Me.MenuLabel5.AutoSize = True
        Me.MenuLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.MenuLabel5.Location = New System.Drawing.Point(12, 289)
        Me.MenuLabel5.Name = "MenuLabel5"
        Me.MenuLabel5.Size = New System.Drawing.Size(95, 13)
        Me.MenuLabel5.TabIndex = 4
        Me.MenuLabel5.Text = "Możemy zaczynać!"
        '
        'MenuLabel4
        '
        Me.MenuLabel4.AutoSize = True
        Me.MenuLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.MenuLabel4.Location = New System.Drawing.Point(12, 258)
        Me.MenuLabel4.Name = "MenuLabel4"
        Me.MenuLabel4.Size = New System.Drawing.Size(101, 13)
        Me.MenuLabel4.TabIndex = 3
        Me.MenuLabel4.Text = "Informacje bankowe"
        '
        'MenuLabel3
        '
        Me.MenuLabel3.AutoSize = True
        Me.MenuLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.MenuLabel3.Location = New System.Drawing.Point(12, 227)
        Me.MenuLabel3.MaximumSize = New System.Drawing.Size(107, 30)
        Me.MenuLabel3.Name = "MenuLabel3"
        Me.MenuLabel3.Size = New System.Drawing.Size(81, 13)
        Me.MenuLabel3.TabIndex = 2
        Me.MenuLabel3.Text = "Dane nagłówka"
        '
        'MenuLabel2
        '
        Me.MenuLabel2.AutoSize = True
        Me.MenuLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.MenuLabel2.Location = New System.Drawing.Point(12, 196)
        Me.MenuLabel2.Name = "MenuLabel2"
        Me.MenuLabel2.Size = New System.Drawing.Size(105, 13)
        Me.MenuLabel2.TabIndex = 1
        Me.MenuLabel2.Text = "Dane Identyfikacyjne"
        '
        'MenuLabel0
        '
        Me.MenuLabel0.AutoSize = True
        Me.MenuLabel0.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.MenuLabel0.Location = New System.Drawing.Point(12, 134)
        Me.MenuLabel0.Name = "MenuLabel0"
        Me.MenuLabel0.Size = New System.Drawing.Size(32, 13)
        Me.MenuLabel0.TabIndex = 0
        Me.MenuLabel0.Text = "Witaj!"
        '
        'FirstRunWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 382)
        Me.Controls.Add(Me.tbWizardCards)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FirstRunWizard"
        Me.Text = "Pierwsze uruchomienie - Zapraszamy!"
        Me.tbWizardCards.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbWizardCards As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtPesel As System.Windows.Forms.TextBox
    Friend WithEvents lbPhone As System.Windows.Forms.Label
    Friend WithEvents lbAddress As System.Windows.Forms.Label
    Friend WithEvents lbPesel As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents rtbSellerName As System.Windows.Forms.RichTextBox
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbIdInfo As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents lbHeadInfo As System.Windows.Forms.Label
    Friend WithEvents rtbHeadlineInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents lbHeaderText As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents MenuLabel5 As System.Windows.Forms.Label
    Friend WithEvents MenuLabel4 As System.Windows.Forms.Label
    Friend WithEvents MenuLabel3 As System.Windows.Forms.Label
    Friend WithEvents MenuLabel2 As System.Windows.Forms.Label
    Friend WithEvents MenuLabel0 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbBankInfo As System.Windows.Forms.Label
    Friend WithEvents txtBankAddress As System.Windows.Forms.TextBox
    Friend WithEvents lbAccountNo As System.Windows.Forms.Label
    Friend WithEvents lbBankAddress As System.Windows.Forms.Label
    Friend WithEvents txtAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents lbWelcomeInfo As System.Windows.Forms.Label
    Friend WithEvents lbHi As System.Windows.Forms.Label
    Friend WithEvents lbLang As System.Windows.Forms.Label
    Friend WithEvents cbLang As System.Windows.Forms.ComboBox
    Friend WithEvents lbEndingInfo As System.Windows.Forms.Label
    Friend WithEvents lbFooterText As Label
    Friend WithEvents rtbFooterText As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MenuLabel1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDatabaseName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rtbAddress As RichTextBox
End Class
