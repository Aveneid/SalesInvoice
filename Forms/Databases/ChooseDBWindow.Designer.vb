<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseDBWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChooseDBWindow))
        Me.cbSelectDb = New System.Windows.Forms.ComboBox()
        Me.lbDatabase = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbSelectDb
        '
        resources.ApplyResources(Me.cbSelectDb, "cbSelectDb")
        Me.cbSelectDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectDb.FormattingEnabled = True
        Me.cbSelectDb.Name = "cbSelectDb"
        '
        'lbDatabase
        '
        resources.ApplyResources(Me.lbDatabase, "lbDatabase")
        Me.lbDatabase.Name = "lbDatabase"
        '
        'btnOk
        '
        resources.ApplyResources(Me.btnOk, "btnOk")
        Me.btnOk.Name = "btnOk"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        resources.ApplyResources(Me.btnNew, "btnNew")
        Me.btnNew.Name = "btnNew"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'ChooseDBWindow
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lbDatabase)
        Me.Controls.Add(Me.cbSelectDb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChooseDBWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbSelectDb As System.Windows.Forms.ComboBox
    Friend WithEvents lbDatabase As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
