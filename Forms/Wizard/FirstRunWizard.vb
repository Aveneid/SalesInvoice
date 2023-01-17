Imports System.Configuration
Imports System.Collections.Specialized
Imports SalesInvoice.Utils
Imports System.ComponentModel

Public Class FirstRunWizard
    Dim appClosing = False
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
        MenuLabel1.Text = Globals.rm.GetString("lbIdData")
        MenuLabel2.Text = Globals.rm.GetString("lbHeadInfo")
        MenuLabel3.Text = Globals.rm.GetString("lbBankInfo")
        MenuLabel4.Text = Globals.rm.GetString("lbWizardEnd")

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
        lbAddressNo.Text = Globals.rm.GetString("lbAddressNo")

        lbCity.Text = Globals.rm.GetString("lbCity")

        lbPostal.Text = Globals.rm.GetString("lbPostal")
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

    Private Sub btnNext_click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnNext.Text = Globals.rm.GetString("lbNext") Then
            Select Case tbWizardCards.SelectedIndex
                Case 1
                    If SellerName.Text.Length = 0 Or Address_1.Text.Length = 0 Or
                        Address_2.Text.Length = 0 Or Address_3.Text.Length = 0 Or
                        Address_4.Text.Length = 0 Or Phone.Text.Length = 0 Then
                        MsgBox(Globals.rm.GetString("lbEnterAllData"))
                        Return
                    End If
                Case 2
                    If Headline_info.Text.Length = 0 Then
                        MsgBox(Globals.rm.GetString("lbEnterAllData"))
                        Return
                    End If
            End Select

            tbWizardCards.SelectedIndex = tbWizardCards.SelectedIndex + 1



        ElseIf btnNext.Text = Globals.rm.GetString("lbEnd") Then

            Globals.asSettings.Settings.Item("sellerName").Value = SellerName.Text
            Globals.asSettings.Settings.Item("address").Value = Address_1.Text
            Globals.asSettings.Settings.Item("buildingNo").Value = Address_2.Text
            Globals.asSettings.Settings.Item("city").Value = Address_3.Text
            Globals.asSettings.Settings.Item("postalCode").Value = Address_4.Text
            Globals.asSettings.Settings.Item("phone").Value = Phone.Text
            Globals.asSettings.Settings.Item("pesel").Value = Pesel.Text


            Globals.asSettings.Settings.Item("headlineInfo").Value = Headline_info.Text
            Globals.asSettings.Settings.Item("footerText").Value = rtbFooterText.Text

            'Globals.asSettings.Settings.Item("headlineInfoAligment").Value = ali

            If AccountNo.Text IsNot Nothing And BankAddress.Text IsNot Nothing Then
                Globals.asSettings.Settings.Item("accountNo").Value = AccountNo.Text
                Globals.asSettings.Settings.Item("bankAddress").Value = BankAddress.Text
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


    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
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