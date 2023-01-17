<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClientWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddClientWindow))
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.NAMEDATA = New System.Windows.Forms.RichTextBox()
        Me.ADDRESSDATA = New System.Windows.Forms.RichTextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.NIPDATA = New System.Windows.Forms.MaskedTextBox()
        Me.PESELDATA = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NOTHINGRADIO = New System.Windows.Forms.RadioButton()
        Me.NIPRADIO = New System.Windows.Forms.RadioButton()
        Me.PESELRADIO = New System.Windows.Forms.RadioButton()
        Me.PHONEDATA = New System.Windows.Forms.MaskedTextBox()
        Me.lbDownloadGUS = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbName
        '
        resources.ApplyResources(Me.lbName, "lbName")
        Me.lbName.Name = "lbName"
        '
        'lbPhone
        '
        resources.ApplyResources(Me.lbPhone, "lbPhone")
        Me.lbPhone.Name = "lbPhone"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'lbAddress
        '
        resources.ApplyResources(Me.lbAddress, "lbAddress")
        Me.lbAddress.Name = "lbAddress"
        '
        'NAMEDATA
        '
        resources.ApplyResources(Me.NAMEDATA, "NAMEDATA")
        Me.NAMEDATA.Name = "NAMEDATA"
        '
        'ADDRESSDATA
        '
        resources.ApplyResources(Me.ADDRESSDATA, "ADDRESSDATA")
        Me.ADDRESSDATA.Name = "ADDRESSDATA"
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'NIPDATA
        '
        resources.ApplyResources(Me.NIPDATA, "NIPDATA")
        Me.NIPDATA.Name = "NIPDATA"
        '
        'PESELDATA
        '
        resources.ApplyResources(Me.PESELDATA, "PESELDATA")
        Me.PESELDATA.Name = "PESELDATA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NOTHINGRADIO)
        Me.GroupBox1.Controls.Add(Me.NIPRADIO)
        Me.GroupBox1.Controls.Add(Me.PESELRADIO)
        Me.GroupBox1.Controls.Add(Me.NIPDATA)
        Me.GroupBox1.Controls.Add(Me.PESELDATA)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'NOTHINGRADIO
        '
        resources.ApplyResources(Me.NOTHINGRADIO, "NOTHINGRADIO")
        Me.NOTHINGRADIO.Checked = True
        Me.NOTHINGRADIO.Name = "NOTHINGRADIO"
        Me.NOTHINGRADIO.TabStop = True
        Me.NOTHINGRADIO.UseVisualStyleBackColor = True
        '
        'NIPRADIO
        '
        resources.ApplyResources(Me.NIPRADIO, "NIPRADIO")
        Me.NIPRADIO.Name = "NIPRADIO"
        Me.NIPRADIO.UseVisualStyleBackColor = True
        '
        'PESELRADIO
        '
        resources.ApplyResources(Me.PESELRADIO, "PESELRADIO")
        Me.PESELRADIO.Name = "PESELRADIO"
        Me.PESELRADIO.UseVisualStyleBackColor = True
        '
        'PHONEDATA
        '
        resources.ApplyResources(Me.PHONEDATA, "PHONEDATA")
        Me.PHONEDATA.Name = "PHONEDATA"
        '
        'lbDownloadGUS
        '
        resources.ApplyResources(Me.lbDownloadGUS, "lbDownloadGUS")
        Me.lbDownloadGUS.Name = "lbDownloadGUS"
        Me.lbDownloadGUS.TabStop = True
        '
        'AddClientWindow
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbDownloadGUS)
        Me.Controls.Add(Me.PHONEDATA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NAMEDATA)
        Me.Controls.Add(Me.ADDRESSDATA)
        Me.Controls.Add(Me.lbAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbPhone)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddClientWindow"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbPhone As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbAddress As System.Windows.Forms.Label

    Friend WithEvents NAMEDATA As System.Windows.Forms.RichTextBox
    Friend WithEvents ADDRESSDATA As System.Windows.Forms.RichTextBox

    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents NIPDATA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PESELDATA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NIPRADIO As System.Windows.Forms.RadioButton
    Friend WithEvents PESELRADIO As System.Windows.Forms.RadioButton
    Friend WithEvents PHONEDATA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents NOTHINGRADIO As System.Windows.Forms.RadioButton
    Friend WithEvents lbDownloadGUS As System.Windows.Forms.LinkLabel

End Class
