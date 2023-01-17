Imports System.Windows.Forms
Imports SalesInvoice.Utils
Imports System.IO
Imports System.Configuration

Public Class ChooseReceiptTemplate

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Globals.cAppConfig.Save(ConfigurationSaveMode.Modified)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Sub setLanguage()
        Me.Text = Globals.rm.GetString("lbChooseTemplate")
        lbTemplate.Text = Globals.rm.GetString("lbTemplate")
        chAsDefault.Text = Globals.rm.GetString("lbDefault")
        OK_Button.Text = Globals.rm.GetString("lbChoose")
        Cancel_Button.Text = Globals.rm.GetString("lbCancel")
    End Sub
    Sub updateFiles()
        cbTemplate.Items.Clear()
        Dim files() As String
        files = Directory.GetFiles(Application.StartupPath & "\Resources", "*.doc", SearchOption.TopDirectoryOnly)
        For Each FileName As String In files
            cbTemplate.Items.Add(Path.GetFileName(FileName))
        Next
        If cbTemplate.Items.Count > 0 Then cbTemplate.SelectedIndex = 0
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateFiles()
        If Globals.asSettings.Settings("defaultPrintTemplate").Value <> "none" Then
            If cbTemplate.FindStringExact(Globals.asSettings.Settings("defaultPrintTemplate").Value) > -1 Then
                cbTemplate.SelectedText = Globals.asSettings.Settings("defaultPrintTemplate").Value
                OK_Button.PerformClick()
            Else
                cbTemplate.SelectedItem = 0
            End If
        End If
        setLanguage()
        Me.CenterToScreen()

    End Sub

    Private Sub chAsDefault_CheckedChanged(sender As Object, e As EventArgs) Handles chAsDefault.CheckedChanged
        If chAsDefault.Checked = True Then
            Globals.asSettings.Settings.Item("defaultPrintTemplate").Value = cbTemplate.SelectedText
            Globals.cAppConfig.Save(ConfigurationSaveMode.Modified)
        End If
    End Sub
End Class
