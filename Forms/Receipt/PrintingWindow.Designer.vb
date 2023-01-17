<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintingWindow
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
        Me.PdfViewer1 = New Spire.PdfViewer.Forms.PdfViewer()
        Me.SuspendLayout()
        '
        'PdfViewer1
        '
        Me.PdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PdfViewer1.IgnoreCase = False
        Me.PdfViewer1.IsToolBarVisible = True
        Me.PdfViewer1.Location = New System.Drawing.Point(0, 0)
        Me.PdfViewer1.MultiPagesThreshold = 60
        Me.PdfViewer1.Name = "PdfViewer1"
        Me.PdfViewer1.Size = New System.Drawing.Size(814, 411)
        Me.PdfViewer1.TabIndex = 2
        Me.PdfViewer1.Text = "Print Preview"
        Me.PdfViewer1.Threshold = 60
        Me.PdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        '
        'PrintingWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 411)
        Me.Controls.Add(Me.PdfViewer1)
        Me.MinimumSize = New System.Drawing.Size(830, 450)
        Me.Name = "PrintingWindow"
        Me.Text = "PrintingWindow"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents PdfViewer1 As Spire.PdfViewer.Forms.PdfViewer
End Class
