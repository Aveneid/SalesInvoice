<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientDetails))
        Me.ClientNameLabel = New System.Windows.Forms.Label()
        Me.ClientName = New System.Windows.Forms.TextBox()
        Me.ClientPhoneLabel = New System.Windows.Forms.Label()
        Me.ClientPhone = New System.Windows.Forms.TextBox()
        Me.ClientIdLabel = New System.Windows.Forms.Label()
        Me.ClientId = New System.Windows.Forms.TextBox()
        Me.ClientAddressLabel = New System.Windows.Forms.Label()
        Me.ClientAddress = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClientNameLabel
        '
        resources.ApplyResources(Me.ClientNameLabel, "ClientNameLabel")
        Me.ClientNameLabel.Name = "ClientNameLabel"
        '
        'ClientName
        '
        resources.ApplyResources(Me.ClientName, "ClientName")
        Me.ClientName.Name = "ClientName"
        Me.ClientName.ReadOnly = True
        '
        'ClientPhoneLabel
        '
        resources.ApplyResources(Me.ClientPhoneLabel, "ClientPhoneLabel")
        Me.ClientPhoneLabel.Name = "ClientPhoneLabel"
        '
        'ClientPhone
        '
        resources.ApplyResources(Me.ClientPhone, "ClientPhone")
        Me.ClientPhone.Name = "ClientPhone"
        '
        'ClientIdLabel
        '
        resources.ApplyResources(Me.ClientIdLabel, "ClientIdLabel")
        Me.ClientIdLabel.Name = "ClientIdLabel"
        '
        'ClientId
        '
        resources.ApplyResources(Me.ClientId, "ClientId")
        Me.ClientId.Name = "ClientId"
        '
        'ClientAddressLabel
        '
        resources.ApplyResources(Me.ClientAddressLabel, "ClientAddressLabel")
        Me.ClientAddressLabel.Name = "ClientAddressLabel"
        '
        'ClientAddress
        '
        resources.ApplyResources(Me.ClientAddress, "ClientAddress")
        Me.ClientAddress.Name = "ClientAddress"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ClientDetails
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ClientAddress)
        Me.Controls.Add(Me.ClientAddressLabel)
        Me.Controls.Add(Me.ClientId)
        Me.Controls.Add(Me.ClientIdLabel)
        Me.Controls.Add(Me.ClientPhone)
        Me.Controls.Add(Me.ClientPhoneLabel)
        Me.Controls.Add(Me.ClientName)
        Me.Controls.Add(Me.ClientNameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClientDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientNameLabel As System.Windows.Forms.Label
    Friend WithEvents ClientName As System.Windows.Forms.TextBox
    Friend WithEvents ClientPhoneLabel As System.Windows.Forms.Label
    Friend WithEvents ClientPhone As System.Windows.Forms.TextBox
    Friend WithEvents ClientIdLabel As System.Windows.Forms.Label
    Friend WithEvents ClientId As System.Windows.Forms.TextBox
    Friend WithEvents ClientAddressLabel As System.Windows.Forms.Label
    Friend WithEvents ClientAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
