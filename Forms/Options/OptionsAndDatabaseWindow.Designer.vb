<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionsAndDatabaseWindow
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSelectDb = New System.Windows.Forms.TabPage()
        Me.chkSetDefault = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lbDatabase = New System.Windows.Forms.Label()
        Me.cbDbNameSelect = New System.Windows.Forms.ComboBox()
        Me.TabCreateDb = New System.Windows.Forms.TabPage()
        Me.btnCreateDb = New System.Windows.Forms.Button()
        Me.lbDbName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabImportDb = New System.Windows.Forms.TabPage()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.TabExportDb = New System.Windows.Forms.TabPage()
        Me.btnCreateTask = New System.Windows.Forms.Button()
        Me.lbDatabase1 = New System.Windows.Forms.Label()
        Me.cbExportDB = New System.Windows.Forms.ComboBox()
        Me.btnExportDb = New System.Windows.Forms.Button()
        Me.TabDeleteDb = New System.Windows.Forms.TabPage()
        Me.btnDeleteDB = New System.Windows.Forms.Button()
        Me.lbDatabase2 = New System.Windows.Forms.Label()
        Me.cbSelectDbName2 = New System.Windows.Forms.ComboBox()
        Me.TabCleaning = New System.Windows.Forms.TabPage()
        Me.btnClearReceipts = New System.Windows.Forms.Button()
        Me.btnClearItems = New System.Windows.Forms.Button()
        Me.btnClearClients = New System.Windows.Forms.Button()
        Me.TabExtras = New System.Windows.Forms.TabPage()
        Me.cbTemplate = New System.Windows.Forms.ComboBox()
        Me.lbTemplate = New System.Windows.Forms.Label()
        Me.lbLanguage = New System.Windows.Forms.Label()
        Me.cbSelectLanguage = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabSelectDb.SuspendLayout()
        Me.TabCreateDb.SuspendLayout()
        Me.TabImportDb.SuspendLayout()
        Me.TabExportDb.SuspendLayout()
        Me.TabDeleteDb.SuspendLayout()
        Me.TabCleaning.SuspendLayout()
        Me.TabExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabSelectDb)
        Me.TabControl1.Controls.Add(Me.TabCreateDb)
        Me.TabControl1.Controls.Add(Me.TabImportDb)
        Me.TabControl1.Controls.Add(Me.TabExportDb)
        Me.TabControl1.Controls.Add(Me.TabDeleteDb)
        Me.TabControl1.Controls.Add(Me.TabCleaning)
        Me.TabControl1.Controls.Add(Me.TabExtras)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(495, 210)
        Me.TabControl1.TabIndex = 0
        '
        'TabSelectDb
        '
        Me.TabSelectDb.Controls.Add(Me.chkSetDefault)
        Me.TabSelectDb.Controls.Add(Me.btnOk)
        Me.TabSelectDb.Controls.Add(Me.lbDatabase)
        Me.TabSelectDb.Controls.Add(Me.cbDbNameSelect)
        Me.TabSelectDb.Location = New System.Drawing.Point(4, 22)
        Me.TabSelectDb.Name = "TabSelectDb"
        Me.TabSelectDb.Size = New System.Drawing.Size(487, 184)
        Me.TabSelectDb.TabIndex = 2
        Me.TabSelectDb.Text = "selectdb"
        Me.TabSelectDb.UseVisualStyleBackColor = True
        '
        'chkSetDefault
        '
        Me.chkSetDefault.Location = New System.Drawing.Point(158, 84)
        Me.chkSetDefault.Name = "chkSetDefault"
        Me.chkSetDefault.Size = New System.Drawing.Size(104, 24)
        Me.chkSetDefault.TabIndex = 1
        Me.chkSetDefault.Text = "checkbox"
        Me.chkSetDefault.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(318, 55)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lbDatabase
        '
        Me.lbDatabase.Location = New System.Drawing.Point(127, 60)
        Me.lbDatabase.Name = "lbDatabase"
        Me.lbDatabase.Size = New System.Drawing.Size(25, 23)
        Me.lbDatabase.TabIndex = 4
        Me.lbDatabase.Text = "label"
        '
        'cbDbNameSelect
        '
        Me.cbDbNameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDbNameSelect.FormattingEnabled = True
        Me.cbDbNameSelect.Location = New System.Drawing.Point(158, 57)
        Me.cbDbNameSelect.Name = "cbDbNameSelect"
        Me.cbDbNameSelect.Size = New System.Drawing.Size(133, 21)
        Me.cbDbNameSelect.TabIndex = 0
        '
        'TabCreateDb
        '
        Me.TabCreateDb.Controls.Add(Me.btnCreateDb)
        Me.TabCreateDb.Controls.Add(Me.lbDbName)
        Me.TabCreateDb.Controls.Add(Me.TextBox1)
        Me.TabCreateDb.Location = New System.Drawing.Point(4, 22)
        Me.TabCreateDb.Name = "TabCreateDb"
        Me.TabCreateDb.Size = New System.Drawing.Size(487, 184)
        Me.TabCreateDb.TabIndex = 0
        Me.TabCreateDb.Text = "createdb"
        Me.TabCreateDb.UseVisualStyleBackColor = True
        '
        'btnCreateDb
        '
        Me.btnCreateDb.Location = New System.Drawing.Point(277, 78)
        Me.btnCreateDb.Name = "btnCreateDb"
        Me.btnCreateDb.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateDb.TabIndex = 3
        Me.btnCreateDb.UseVisualStyleBackColor = True
        '
        'lbDbName
        '
        Me.lbDbName.Location = New System.Drawing.Point(69, 38)
        Me.lbDbName.Name = "lbDbName"
        Me.lbDbName.Size = New System.Drawing.Size(10, 23)
        Me.lbDbName.TabIndex = 1
        Me.lbDbName.Text = "label"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TabImportDb
        '
        Me.TabImportDb.Controls.Add(Me.btnImport)
        Me.TabImportDb.Location = New System.Drawing.Point(4, 22)
        Me.TabImportDb.Name = "TabImportDb"
        Me.TabImportDb.Size = New System.Drawing.Size(487, 184)
        Me.TabImportDb.TabIndex = 0
        Me.TabImportDb.Text = "importdb"
        Me.TabImportDb.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(154, 67)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(125, 51)
        Me.btnImport.TabIndex = 0
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'TabExportDb
        '
        Me.TabExportDb.Controls.Add(Me.btnCreateTask)
        Me.TabExportDb.Controls.Add(Me.lbDatabase1)
        Me.TabExportDb.Controls.Add(Me.cbExportDB)
        Me.TabExportDb.Controls.Add(Me.btnExportDb)
        Me.TabExportDb.Location = New System.Drawing.Point(4, 22)
        Me.TabExportDb.Name = "TabExportDb"
        Me.TabExportDb.Size = New System.Drawing.Size(487, 184)
        Me.TabExportDb.TabIndex = 5
        Me.TabExportDb.Text = "exportdb"
        Me.TabExportDb.UseVisualStyleBackColor = True
        '
        'btnCreateTask
        '
        Me.btnCreateTask.Enabled = False
        Me.btnCreateTask.Location = New System.Drawing.Point(8, 158)
        Me.btnCreateTask.Name = "btnCreateTask"
        Me.btnCreateTask.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateTask.TabIndex = 6
        Me.btnCreateTask.UseVisualStyleBackColor = True
        '
        'lbDatabase1
        '
        Me.lbDatabase1.Location = New System.Drawing.Point(57, 53)
        Me.lbDatabase1.Name = "lbDatabase1"
        Me.lbDatabase1.Size = New System.Drawing.Size(10, 23)
        Me.lbDatabase1.TabIndex = 5
        Me.lbDatabase1.Text = "label"
        '
        'cbExportDB
        '
        Me.cbExportDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbExportDB.FormattingEnabled = True
        Me.cbExportDB.Location = New System.Drawing.Point(73, 50)
        Me.cbExportDB.Name = "cbExportDB"
        Me.cbExportDB.Size = New System.Drawing.Size(323, 21)
        Me.cbExportDB.TabIndex = 3
        '
        'btnExportDb
        '
        Me.btnExportDb.Location = New System.Drawing.Point(321, 97)
        Me.btnExportDb.Name = "btnExportDb"
        Me.btnExportDb.Size = New System.Drawing.Size(75, 23)
        Me.btnExportDb.TabIndex = 4
        Me.btnExportDb.UseVisualStyleBackColor = True
        '
        'TabDeleteDb
        '
        Me.TabDeleteDb.Controls.Add(Me.btnDeleteDB)
        Me.TabDeleteDb.Controls.Add(Me.lbDatabase2)
        Me.TabDeleteDb.Controls.Add(Me.cbSelectDbName2)
        Me.TabDeleteDb.Location = New System.Drawing.Point(4, 22)
        Me.TabDeleteDb.Name = "TabDeleteDb"
        Me.TabDeleteDb.Size = New System.Drawing.Size(487, 184)
        Me.TabDeleteDb.TabIndex = 3
        Me.TabDeleteDb.Text = "deletedb"
        Me.TabDeleteDb.UseVisualStyleBackColor = True
        '
        'btnDeleteDB
        '
        Me.btnDeleteDB.Location = New System.Drawing.Point(301, 101)
        Me.btnDeleteDB.Name = "btnDeleteDB"
        Me.btnDeleteDB.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteDB.TabIndex = 1
        Me.btnDeleteDB.UseVisualStyleBackColor = True
        '
        'lbDatabase2
        '
        Me.lbDatabase2.Location = New System.Drawing.Point(100, 65)
        Me.lbDatabase2.Name = "lbDatabase2"
        Me.lbDatabase2.Size = New System.Drawing.Size(10, 23)
        Me.lbDatabase2.TabIndex = 7
        Me.lbDatabase2.Text = "label"
        '
        'cbSelectDbName2
        '
        Me.cbSelectDbName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectDbName2.FormattingEnabled = True
        Me.cbSelectDbName2.Location = New System.Drawing.Point(116, 62)
        Me.cbSelectDbName2.Name = "cbSelectDbName2"
        Me.cbSelectDbName2.Size = New System.Drawing.Size(260, 21)
        Me.cbSelectDbName2.TabIndex = 0
        '
        'TabCleaning
        '
        Me.TabCleaning.Controls.Add(Me.btnClearReceipts)
        Me.TabCleaning.Controls.Add(Me.btnClearItems)
        Me.TabCleaning.Controls.Add(Me.btnClearClients)
        Me.TabCleaning.Location = New System.Drawing.Point(4, 22)
        Me.TabCleaning.Name = "TabCleaning"
        Me.TabCleaning.Size = New System.Drawing.Size(487, 184)
        Me.TabCleaning.TabIndex = 4
        Me.TabCleaning.Text = "cleaning"
        Me.TabCleaning.UseVisualStyleBackColor = True
        '
        'btnClearReceipts
        '
        Me.btnClearReceipts.Location = New System.Drawing.Point(277, 67)
        Me.btnClearReceipts.Name = "btnClearReceipts"
        Me.btnClearReceipts.Size = New System.Drawing.Size(101, 50)
        Me.btnClearReceipts.TabIndex = 2
        Me.btnClearReceipts.UseVisualStyleBackColor = True
        '
        'btnClearItems
        '
        Me.btnClearItems.Location = New System.Drawing.Point(164, 67)
        Me.btnClearItems.Name = "btnClearItems"
        Me.btnClearItems.Size = New System.Drawing.Size(101, 50)
        Me.btnClearItems.TabIndex = 1
        Me.btnClearItems.UseVisualStyleBackColor = True
        '
        'btnClearClients
        '
        Me.btnClearClients.Location = New System.Drawing.Point(51, 67)
        Me.btnClearClients.Name = "btnClearClients"
        Me.btnClearClients.Size = New System.Drawing.Size(101, 50)
        Me.btnClearClients.TabIndex = 0
        Me.btnClearClients.UseVisualStyleBackColor = True
        '
        'TabExtras
        '
        Me.TabExtras.Controls.Add(Me.cbTemplate)
        Me.TabExtras.Controls.Add(Me.lbTemplate)
        Me.TabExtras.Controls.Add(Me.lbLanguage)
        Me.TabExtras.Controls.Add(Me.cbSelectLanguage)
        Me.TabExtras.Location = New System.Drawing.Point(4, 22)
        Me.TabExtras.Name = "TabExtras"
        Me.TabExtras.Size = New System.Drawing.Size(487, 184)
        Me.TabExtras.TabIndex = 6
        Me.TabExtras.Text = "extras"
        Me.TabExtras.UseVisualStyleBackColor = True
        '
        'cbTemplate
        '
        Me.cbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTemplate.FormattingEnabled = True
        Me.cbTemplate.Location = New System.Drawing.Point(53, 15)
        Me.cbTemplate.Name = "cbTemplate"
        Me.cbTemplate.Size = New System.Drawing.Size(158, 21)
        Me.cbTemplate.TabIndex = 4
        '
        'lbTemplate
        '
        Me.lbTemplate.AutoSize = True
        Me.lbTemplate.Location = New System.Drawing.Point(8, 18)
        Me.lbTemplate.Name = "lbTemplate"
        Me.lbTemplate.Size = New System.Drawing.Size(39, 13)
        Me.lbTemplate.TabIndex = 3
        Me.lbTemplate.Text = "Label1"
        '
        'lbLanguage
        '
        Me.lbLanguage.Location = New System.Drawing.Point(282, 154)
        Me.lbLanguage.Name = "lbLanguage"
        Me.lbLanguage.Size = New System.Drawing.Size(10, 23)
        Me.lbLanguage.TabIndex = 2
        '
        'cbSelectLanguage
        '
        Me.cbSelectLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectLanguage.FormattingEnabled = True
        Me.cbSelectLanguage.Items.AddRange(New Object() {"Polski", "English"})
        Me.cbSelectLanguage.Location = New System.Drawing.Point(298, 151)
        Me.cbSelectLanguage.Name = "cbSelectLanguage"
        Me.cbSelectLanguage.Size = New System.Drawing.Size(121, 21)
        Me.cbSelectLanguage.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(408, 216)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "sdf"
        Me.OpenFileDialog1.Filter = "Database Files |*.sdf| Zip file|*.zip"
        '
        'OptionsAndDatabaseWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 251)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(511, 290)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(511, 290)
        Me.Name = "OptionsAndDatabaseWindow"
        Me.Text = "Options"
        Me.TabControl1.ResumeLayout(False)
        Me.TabSelectDb.ResumeLayout(False)
        Me.TabCreateDb.ResumeLayout(False)
        Me.TabCreateDb.PerformLayout()
        Me.TabImportDb.ResumeLayout(False)
        Me.TabExportDb.ResumeLayout(False)
        Me.TabDeleteDb.ResumeLayout(False)
        Me.TabCleaning.ResumeLayout(False)
        Me.TabExtras.ResumeLayout(False)
        Me.TabExtras.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabCreateDb As System.Windows.Forms.TabPage
    Friend WithEvents TabImportDb As System.Windows.Forms.TabPage
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCreateDb As System.Windows.Forms.Button
    Friend WithEvents lbDbName As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabSelectDb As System.Windows.Forms.TabPage
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lbDatabase As System.Windows.Forms.Label
    Friend WithEvents cbDbNameSelect As System.Windows.Forms.ComboBox
    Friend WithEvents TabDeleteDb As System.Windows.Forms.TabPage
    Friend WithEvents btnDeleteDB As System.Windows.Forms.Button
    Friend WithEvents lbDatabase2 As System.Windows.Forms.Label
    Friend WithEvents cbSelectDbName2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabCleaning As System.Windows.Forms.TabPage
    Friend WithEvents btnClearReceipts As System.Windows.Forms.Button
    Friend WithEvents btnClearItems As System.Windows.Forms.Button
    Friend WithEvents btnClearClients As System.Windows.Forms.Button
    Friend WithEvents chkSetDefault As System.Windows.Forms.CheckBox
    Friend WithEvents TabExportDb As System.Windows.Forms.TabPage
    Friend WithEvents lbDatabase1 As System.Windows.Forms.Label
    Friend WithEvents cbExportDB As System.Windows.Forms.ComboBox
    Friend WithEvents btnExportDb As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnCreateTask As System.Windows.Forms.Button
    Friend WithEvents TabExtras As System.Windows.Forms.TabPage
    Friend WithEvents lbLanguage As System.Windows.Forms.Label
    Friend WithEvents cbSelectLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents cbTemplate As ComboBox
    Friend WithEvents lbTemplate As Label
End Class
