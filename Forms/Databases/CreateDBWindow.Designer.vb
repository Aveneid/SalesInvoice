<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateDBWindow
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lbName = New System.Windows.Forms.Label()
        Me.DATABASENAME = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(222, 55)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "Utwórz"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(21, 30)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(43, 13)
        Me.lbName.TabIndex = 6
        Me.lbName.Text = "Nazwa:"
        '
        'DATABASENAME
        '
        Me.DATABASENAME.Location = New System.Drawing.Point(92, 27)
        Me.DATABASENAME.Name = "DATABASENAME"
        Me.DATABASENAME.Size = New System.Drawing.Size(205, 20)
        Me.DATABASENAME.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 55)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Anuluj"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CreateDBWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 90)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.DATABASENAME)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(325, 128)
        Me.Name = "CreateDBWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utwórz bazę"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents DATABASENAME As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
