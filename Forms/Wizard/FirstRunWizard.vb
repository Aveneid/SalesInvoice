Imports System.Configuration
Imports System.Collections.Specialized
Imports SalesInvoice.Utils
Imports System.ComponentModel
Imports System.Data.SqlServerCe

Public Class FirstRunWizard
    Dim appClosing = False
    Dim databaseName As String = ""
    Private Sub FirstRunWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.reloadLanguage()
        setLanguage()
        cbLang.SelectedIndex = 0

        tbWizardCards.Appearance = TabAppearance.FlatButtons
        tbWizardCards.ItemSize = New Size(0, 1)
        tbWizardCards.SizeMode = TabSizeMode.Fixed
        MenuLabel0.Font = New Font(MenuLabel0.Font, FontStyle.Bold)
        Me.Text = Globals.rm.GetString("lbFisrtRun") & " - " & tbWizardCards.SelectedTab.Text
    End Sub
    Sub setLanguage()
        btnBack.Text = Globals.rm.GetString("lbBack")
        btnCancel.Text = Globals.rm.GetString("lbCancel")
        btnNext.Text = Globals.rm.GetString("lbNext")

        MenuLabel0.Text = Globals.rm.GetString("lbWelcome")
        MenuLabel2.Text = Globals.rm.GetString("lbIdData")
        MenuLabel3.Text = Globals.rm.GetString("lbHeadInfo")
        MenuLabel4.Text = Globals.rm.GetString("lbBankInfo")
        MenuLabel5.Text = Globals.rm.GetString("lbWizardEnd")

        TabPage1.Text = Globals.rm.GetString("lbWelcome")
        TabPage2.Text = Globals.rm.GetString("lbIdData")
        TabPage3.Text = Globals.rm.GetString("lbHeadInfo")
        TabPage4.Text = Globals.rm.GetString("lbBankInfo")
        TabPage5.Text = Globals.rm.GetString("lbWizardEnd")

        lbHi.Text = Globals.rm.GetString("lbHi")
        lbWelcomeInfo.Text = Globals.rm.GetString("lbWelcomeInfo")
        lbIdInfo.Text = Globals.rm.GetString("lbIdInfo")

        lbName.Text = Globals.rm.GetString("lbItemName")


        lbAddress.Text = Globals.rm.GetString("lbAddress")
        ' lbAddressNo.Text = Globals.rm.GetString("lbAddressNo")

        'lbCity.Text = Globals.rm.GetString("lbCity")

        ' lbPostal.Text = Globals.rm.GetString("lbPostal")
        lbPhone.Text = Globals.rm.GetString("lbPhone")

        lbPesel.Text = Globals.rm.GetString("lbPESEL") & " (*)"


        lbHeadInfo.Text = Globals.rm.GetString("lbHeadInfoWizard")

        lbHeaderText.Text = Globals.rm.GetString("lbHeaderText")

        lbFooterText.Text = Globals.rm.GetString("lbFooterText")


        lbBankInfo.Text = Globals.rm.GetString("lbBankInfoWizard")
        lbAccountNo.Text = Globals.rm.GetString("lbAccountNO")
        lbBankAddress.Text = Globals.rm.GetString("lbBankAddress")

        lbEndingInfo.Text = Globals.rm.GetString("lbWizardEnding")

        lbLang.Text = Globals.rm.GetString("lbLang")


        Me.Text = Globals.rm.GetString("lbFirstRun")
        Me.Text = Me.Text & " "
        Me.Refresh()
        Me.Update()
    End Sub

    Sub createDatabase()
        Try
            Dim connectionString = "Data Source=""" & Application.StartupPath & "\databases\" & txtDatabaseName.Text & ".sdf"""
            Dim en = New SqlCeEngine(connectionString)

            en.CreateDatabase()
            Dim conTest = New SqlCeConnection("Data Source=""" & Application.StartupPath & "\databases\" & txtDatabaseName.Text & ".sdf""")
            conTest.Open()
            If conTest.State = ConnectionState.Open Then
                Dim cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableCategories"), conTest)
                cmdTest.ExecuteNonQuery()

                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableClients"), conTest)
                cmdTest.ExecuteNonQuery()
                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableItems"), conTest)
                cmdTest.ExecuteNonQuery()
                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableReceipts"), conTest)
                cmdTest.ExecuteNonQuery()
                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableReceiptsDetails"), conTest)
                cmdTest.ExecuteNonQuery()
                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableUnits"), conTest)
                cmdTest.ExecuteNonQuery()
                cmdTest = New SqlCeCommand(Globals.DBobjects.getstring("tableConfig"), conTest)
                cmdTest.ExecuteNonQuery()

                Dim query As String() = Globals.DBobjects.getString("table_alters").Split(New Char() {";"c})

                For Each w As String In query
                    If w.Length > 0 Then
                        cmdTest = New SqlCeCommand(w, conTest)
                        cmdTest.ExecuteNonQuery()
                    End If
                Next

                query = Globals.DBobjects.getstring("tableConfig_data").Split(New Char() {";"c})
                For Each w As String In query
                    If w.Length > 0 Then
                        cmdTest = New SqlCeCommand(w, conTest)
                        cmdTest.ExecuteNonQuery()
                    End If
                Next

                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableCategories_data"), conTest)
                cmdTest.ExecuteNonQuery()

                query = Globals.DBobjects.getString("tableUnits_data").Split(New Char() {";"c})

                For Each w As String In query
                    If w.Length > 0 Then
                        cmdTest = New SqlCeCommand(w, conTest)
                        cmdTest.ExecuteNonQuery()
                    End If
                Next


                MessageBox.Show(Globals.rm.GetString("msgDatabaseCreatedSuccess"),
                           "Info", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                conTest.Close()
                databaseName = txtDatabaseName.Text
            Else
                MsgBox(Globals.rm.GetString("msgDatabaseConnectionError"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub btnNext_click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnNext.Text = Globals.rm.GetString("lbNext") Then
            Select Case tbWizardCards.SelectedIndex
                Case 1
                    createDatabase()
                Case 2
                    If rtbSellerName.Text.Length = 0 Or rtbAddress.Text.Length = 0 Or txtPhone.Text.Length = 0 Then
                        MsgBox(Globals.rm.GetString("lbEnterAllData"))
                        Return
                    End If
                Case 3
                    If rtbHeadlineInfo.Text.Length = 0 Then
                        MsgBox(Globals.rm.GetString("lbEnterAllData"))
                        Return
                    End If
            End Select

            tbWizardCards.SelectedIndex = tbWizardCards.SelectedIndex + 1



        ElseIf btnNext.Text = Globals.rm.GetString("lbEnd") Then


            'insert data into database
            Dim conConfig = New SqlCeConnection("Data Source='" & Application.StartupPath & "\databases\" & txtDatabaseName.Text & ".sdf'")
            conConfig.Open()

            Dim cmdUpdate = New SqlCeCommand("UPDATE config SET config_value='" & rtbSellerName.Text & "' WHERE config_key='sellerName'", conConfig)
            cmdUpdate.ExecuteNonQuery()
            cmdUpdate = New SqlCeCommand("UPDATE config SET config_value='" & rtbAddress.Text & "' WHERE config_key='sellerAddress'", conConfig)
            cmdUpdate.ExecuteNonQuery()
            cmdUpdate = New SqlCeCommand("UPDATE config SET config_value='" & txtPhone.Text & "' WHERE config_key='sellerPhone'", conConfig)
            cmdUpdate.ExecuteNonQuery()
            cmdUpdate = New SqlCeCommand("UPDATE config SET config_value='" & txtPesel.Text & "' WHERE config_key='sellerID'", conConfig)
            cmdUpdate.ExecuteNonQuery()

            cmdUpdate = New SqlCeCommand("UPDATE config SET config_value='" & rtbHeadlineInfo.Text & "' WHERE config_key='sellerHeader'", conConfig)
            cmdUpdate.ExecuteNonQuery()
            cmdUpdate = New SqlCeCommand("UPDATE config SET config_value='" & rtbFooterText.Text & "' WHERE config_key='sellerFooter'", conConfig)
            cmdUpdate.ExecuteNonQuery()


            If txtAccountNo.Text IsNot Nothing And txtBankAddress.Text IsNot Nothing Then
                cmdUpdate = New SqlCeCommand("UPDATE config SET config_value='" & txtAccountNo.Text & "' WHERE config_key='sellerAccountNo'", conConfig)
                cmdUpdate.ExecuteNonQuery()
                cmdUpdate = New SqlCeCommand("UPDATE config SET config_value='" & txtBankAddress.Text & "' WHERE config_key='sellerBankInfo'", conConfig)
                cmdUpdate.ExecuteNonQuery()
            End If

            Globals.asSettings.Settings.Item("firsttimerun").Value = "false"
            Globals.cAppConfig.Save(ConfigurationSaveMode.Modified)
            appClosing = True
            Me.Close()
        End If
        Me.Refresh()
        Me.Update()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        tbWizardCards.SelectedIndex = tbWizardCards.SelectedIndex - 1
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbWizardCards.SelectedIndexChanged
        If tbWizardCards.SelectedIndex = 0 Then
            btnBack.Enabled = False
        Else
            btnBack.Enabled = True
        End If
        If tbWizardCards.SelectedIndex = tbWizardCards.TabCount - 1 Then
            btnNext.Text = Globals.rm.GetString("lbEnd")
        Else
            btnNext.Text = Globals.rm.GetString("lbNext")
        End If
        MenuLabel0.Font = New Font(MenuLabel0.Font, FontStyle.Regular)
        MenuLabel1.Font = New Font(MenuLabel1.Font, FontStyle.Regular)
        MenuLabel2.Font = New Font(MenuLabel2.Font, FontStyle.Regular)
        MenuLabel3.Font = New Font(MenuLabel3.Font, FontStyle.Regular)
        MenuLabel4.Font = New Font(MenuLabel4.Font, FontStyle.Regular)
        MenuLabel5.Font = New Font(MenuLabel5.Font, FontStyle.Regular)

        Select Case tbWizardCards.SelectedIndex()
            Case 0
                MenuLabel0.Font = New Font(MenuLabel0.Font, FontStyle.Bold)
            Case 1
                MenuLabel1.Font = New Font(MenuLabel1.Font, FontStyle.Bold)
            Case 2
                MenuLabel2.Font = New Font(MenuLabel2.Font, FontStyle.Bold)
            Case 3
                MenuLabel3.Font = New Font(MenuLabel3.Font, FontStyle.Bold)
            Case 4
                MenuLabel4.Font = New Font(MenuLabel4.Font, FontStyle.Bold)
            Case 5
                MenuLabel5.Font = New Font(MenuLabel5.Font, FontStyle.Bold)
        End Select
        Me.Text = Globals.rm.GetString("lbFisrtRun") & " - " & tbWizardCards.SelectedTab.Text
    End Sub

    Private Sub btnCancel_click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox(Globals.rm.GetString("lbWizardExit"), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            appClosing = True
            ChooseDBWindow.Close()
            Me.Close()
            Me.Dispose()
            Application.Exit()
            End
        Else
            Application.DoEvents()
        End If
    End Sub
    Private Sub cbLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLang.SelectedIndexChanged
        If cbLang.SelectedIndex = 0 Then
            Globals.asSettings.Settings.Item("lang").Value = "en-US"
        ElseIf cbLang.SelectedIndex = 1 Then
            Globals.asSettings.Settings.Item("lang").Value = "pl-PL"
        End If

        Globals.reloadLanguage()
        setLanguage()
    End Sub

    Private Sub FirstRunWizard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not e.CloseReason = CloseReason.ApplicationExitCall And Not appClosing Then
            If MsgBox(Globals.rm.GetString("lbWizardExit"), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub


    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub FirstRunWizard_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F8 Then
            If Globals.asSettings.Settings.Item("lang").Value = "en-US" Then
                Globals.asSettings.Settings.Item("lang").Value = "pl-PL"
            Else
                Globals.asSettings.Settings.Item("lang").Value = "en-US"
            End If
            Globals.reloadLanguage()
            setLanguage()
        End If
    End Sub
End Class