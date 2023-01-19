Imports System.IO
Imports SalesInvoice.Utils
Imports System.Configuration
Imports System.Collections.Specialized
Public Class ChooseDBWindow
    Sub updateFiles()
        cbSelectDb.Items.Clear()
        Dim files() As String
        files = Directory.GetFiles(Application.StartupPath & "\databases", "*.sdf", SearchOption.TopDirectoryOnly)
        For Each FileName As String In files
            cbSelectDb.Items.Add(Path.GetFileName(FileName))
        Next
        If cbSelectDb.Items.Count > 0 Then cbSelectDb.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If cbSelectDb.SelectedItem IsNot Nothing Then
            Globals.DB.currentDatabase = cbSelectDb.SelectedItem
            MainWindow.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        CreateDBWindow.ShowDialog()
        updateFiles()
    End Sub

    Private Sub ChooseDBWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile) Then
            Dim rm = My.Resources.Language_pl.ResourceManager
            MsgBox(Globals.rm.GetString("msgAppDatabaseHelper.configError"))
            Application.Exit()
        End If
        Globals.reloadLanguage()
        setLanguage()
        Me.CenterToScreen()


        If Globals.asSettings.Settings.Item("firsttimerun").Value = "true" Then
            FirstRunWizard.ShowDialog()
            Globals.cAppConfig.Save(ConfigurationSaveMode.Modified)
        End If
        If Globals.asSettings.Settings.Item("autostart_database").Value IsNot "false" Then
            If Globals.fileExists(Application.StartupPath & "\databases\" & Globals.asSettings.Settings.Item("autostart_database").Value) Then
                Globals.DB.currentDatabase = Globals.asSettings.Settings.Item("autostart_database").Value
                MainWindow.Show()
                Me.Close()
            End If
        End If
        ' End If
        If Not Directory.Exists(Application.StartupPath & "\databases") Then FileSystem.MkDir("databases")
        updateFiles()
        btnOk.Select()
    End Sub
    Sub setLanguage()
        btnNew.Text = Globals.rm.GetString("lbNew")
        btnOk.Text = Globals.rm.GetString("lbOk")
        lbDatabase.Text = Globals.rm.GetString("lbDatabase")
        Me.Text = Globals.rm.GetString("lbSelectDB")
        Me.Refresh()
    End Sub
End Class