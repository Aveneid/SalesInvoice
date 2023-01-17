<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomReportGenerator
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
        Me.pbGenerating = New System.Windows.Forms.ProgressBar()
        Me.lbGenerating = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pbGenerating
        '
        Me.pbGenerating.Location = New System.Drawing.Point(12, 22)
        Me.pbGenerating.Name = "pbGenerating"
        Me.pbGenerating.Size = New System.Drawing.Size(208, 23)
        Me.pbGenerating.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbGenerating.TabIndex = 0
        '
        'lbGenerating
        '
        Me.lbGenerating.AutoSize = True
        Me.lbGenerating.Location = New System.Drawing.Point(97, 58)
        Me.lbGenerating.Name = "lbGenerating"
        Me.lbGenerating.Size = New System.Drawing.Size(39, 13)
        Me.lbGenerating.TabIndex = 1
        Me.lbGenerating.Text = "Label1"
        '
        'CustomReportGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 91)
        Me.Controls.Add(Me.lbGenerating)
        Me.Controls.Add(Me.pbGenerating)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomReportGenerator"
        Me.Text = "CustomReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbGenerating As ProgressBar
    Friend WithEvents lbGenerating As Label
End Class
