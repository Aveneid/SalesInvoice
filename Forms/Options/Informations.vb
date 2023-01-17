Imports System.Configuration
Imports System.Collections.Specialized
Imports SalesInvoice.Utils
Public Class Informations
    Sub setLanguage()

        'header
        tbHeader.Text = Globals.rm.GetString("lbHeaderText")
        lbHeaderText.Text = Globals.rm.GetString("lbHeaderText")
        lbHeaderText.Location = New Point(Me.Width / 2 - lbHeaderText.Width / 2, lbHeaderText.Location.Y)

        'footer
        tbFooter.Text = Globals.rm.GetString("lbFooterText")
        lbFooterText.Text = Globals.rm.GetString("lbFooterText")
        lbFooterText.Location = New Point(Me.Width / 2 - lbFooterText.Width / 2, lbFooterText.Location.Y)


        'seller
        tbSeller.Text = Globals.rm.GetString("lbIdData")
        lbName.Text = Globals.rm.GetString("lbItemName")
        lbAddress.Text = Globals.rm.GetString("lbAddress")
        lbAddressNo.Text = Globals.rm.GetString("lbAddressNo")
        lbCity.Text = Globals.rm.GetString("lbCity")
        lbPostal.Text = Globals.rm.GetString("lbPostal")
        lbPhone.Text = Globals.rm.GetString("lbPhone")
        lbPesel.Text = Globals.rm.GetString("lbPESEL") & " (*)"

        'bank
        tbBank.Text = Globals.rm.GetString("lbBankDetails")
        lbAccountNo.Text = Globals.rm.GetString("lbAccountNO")
        lbBankAddress.Text = Globals.rm.GetString("lbBankAddress")


        rtbSellerName.Text = Globals.asSettings.Settings("sellerName").Value
        Address_1.Text = Globals.asSettings.Settings("address").Value
        Address_2.Text = Globals.asSettings.Settings("buildingNo").Value
        Address_3.Text = Globals.asSettings.Settings("city").Value
        Address_4.Text = Globals.asSettings.Settings("postalCode").Value
        Phone.Text = Globals.asSettings.Settings("phone").Value
        Pesel.Text = Globals.asSettings.Settings("pesel").Value

        AccountNo.Text = Globals.asSettings.Settings("accountNo").Value
        BankAddress.Text = Globals.asSettings.Settings("bankAddress").Value

        rtbFooterText.Text = Globals.asSettings.Settings("footerText").Value
        Headline_info.Text = Globals.asSettings.Settings("headlineInfo").Value


        Me.Text = Globals.rm.GetString("lbInfo")
        btnSave.Text = Globals.rm.GetString("lbSave")
        Me.Refresh()

    End Sub


    Private Sub SaveSettings(sender As Object, e As EventArgs) Handles btnSave.Click

        'Header info

        Globals.asSettings.Settings.Item("headlineInfo").Value = Headline_info.Text

        'footerInfo
        Globals.asSettings.Settings.Item("footerText").Value = rtbFooterText.Text

        'Seller info
        Globals.asSettings.Settings.Item("sellerName").Value = rtbSellerName.Text
        Globals.asSettings.Settings.Item("address").Value = Address_1.Text
        Globals.asSettings.Settings.Item("buildingNo").Value = Address_2.Text
        Globals.asSettings.Settings.Item("city").Value = Address_3.Text
        Globals.asSettings.Settings.Item("postalCode").Value = Address_4.Text
        Globals.asSettings.Settings.Item("phone").Value = Phone.Text
        Globals.asSettings.Settings.Item("pesel").Value = Pesel.Text

        'Bank info

        If AccountNo.Text IsNot Nothing And BankAddress.Text IsNot Nothing Then
            Globals.asSettings.Settings.Item("accountNo").Value = AccountNo.Text
            Globals.asSettings.Settings.Item("bankAddress").Value = BankAddress.Text
        End If
        If rtbFooterText.Text <> "" Then
            Globals.asSettings.Settings("footerText").Value = rtbFooterText.Text
        Else
            Globals.asSettings.Settings("footerText").Value = ""
        End If
        If Headline_info.Text <> "" Then
            Globals.asSettings.Settings("headlineInfo").Value = Headline_info.Text
        Else
            Globals.asSettings.Settings("headlineInfo").Value = ""
        End If
        Globals.cAppConfig.Save(ConfigurationSaveMode.Modified)
        MsgBox("Information updated")
        Me.Close()
    End Sub

    Private Sub FormLoads(sender As Object, e As EventArgs) Handles MyBase.Load
        setLanguage()


        ToolTip1.ToolTipTitle = Globals.rm.GetString("lbWarning")
        ToolTip1.SetToolTip(lbPesel, Globals.rm.GetString("msgNotRequired"))
        ToolTip1.SetToolTip(Pesel, Globals.rm.GetString("msgNotRequired"))

        Headline_info.Text = Globals.asSettings.Settings.Item("headlineInfo").Value

        rtbFooterText.Text = Globals.asSettings.Settings.Item("footerText").Value

        rtbSellerName.Text = Globals.asSettings.Settings.Item("sellerName").Value
        Address_1.Text = Globals.asSettings.Settings.Item("address").Value
        Address_2.Text = Globals.asSettings.Settings.Item("buildingNo").Value
        Address_3.Text = Globals.asSettings.Settings.Item("city").Value
        Address_4.Text = Globals.asSettings.Settings.Item("postalCode").Value
        Phone.Text = Globals.asSettings.Settings.Item("phone").Value
        Pesel.Text = Globals.asSettings.Settings.Item("pesel").Value

        AccountNo.Text = Globals.asSettings.Settings.Item("accountNo").Value
        BankAddress.Text = Globals.asSettings.Settings.Item("bankAddress").Value
    End Sub

    Private Sub Informations_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class