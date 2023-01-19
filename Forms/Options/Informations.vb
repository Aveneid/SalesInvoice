Imports System.Configuration
Imports System.Collections.Specialized
Imports SalesInvoice.Utils
Imports System.Data.SqlServerCe

Public Class Informations
    Public fromNewDBWindow As Boolean = False

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
        lbPhone.Text = Globals.rm.GetString("lbPhone")
        lbID.Text = Globals.rm.GetString("lbPESEL") & " (*)"

        'bank
        tbBank.Text = Globals.rm.GetString("lbBankDetails")
        lbAccountNo.Text = Globals.rm.GetString("lbAccountNO")
        lbBankAddress.Text = Globals.rm.GetString("lbBankAddress")



        'get data from database
        'fields order: sellerName, sellerAddress, sellerHeader,sellerFooter,sellerAccountNo,sellerBankInfo,sellerPhone,sellerID
        Globals.DB.cmd = "SELECT config_key,config_value FROM config ORDER BY id"
        Using rd As SqlCeDataReader = Globals.DB.executeQuery()
            While rd.Read()
                Select Case rd.GetValue(0)
                    Case "sellerName"
                        Me.rtbSellerName = rd.GetValue(1)
                    Case "sellerAddress"
                        Me.rtbSellerAddress = rd.GetValue(1)
                    Case "sellerHeader"
                        Me.rtbHeaderText = rd.GetValue(1)
                    Case "sellerFooter"
                        Me.rtbFooterText = rd.GetValue(1)
                    Case "sellerAccountNo"
                        Me.txtAccountNo = rd.GetValue(1)
                    Case "sellerBankInfo"
                        Me.txtBankAddress = rd.GetValue(1)
                    Case "sellerPhone"
                        Me.txtPhone = rd.GetValue(1)
                    Case "sellerID"
                        Me.txtID = rd.GetValue(1)
                End Select
            End While
        End Using



        Me.Text = Globals.rm.GetString("lbInfo")
        btnSave.Text = Globals.rm.GetString("lbSave")
        Me.Refresh()

    End Sub
    Function checkFields()
        For Each c In Me.Controls
            If TypeOf c Is TextBox Or TypeOf c Is RichTextBox Then
                If c.text.TextLength < 5 Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function


    Private Sub SaveSettings(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Not checkFields() Then


                'insert data into database

                Globals.DB.cmd = "UPDATE config SET config_value=""" & rtbSellerName.Text & """ WHERE config_key=""sellerName"""
                Globals.DB.executeNonQuery()
                Globals.DB.cmd = "UPDATE config SET config_value=""" & rtbSellerAddress.Text & """ WHERE config_key=""sellerAddress"""
                Globals.DB.executeNonQuery()
                Globals.DB.cmd = "UPDATE config SET config_value=""" & txtPhone.Text & """ WHERE config_key=""sellerPhone"""
                Globals.DB.executeNonQuery()
                Globals.DB.cmd = "UPDATE config SET config_value=""" & txtID.Text & """ WHERE config_key=""sellerID"""
                Globals.DB.executeNonQuery()
                Globals.DB.cmd = "UPDATE config SET config_value=""" & rtbHeaderText.Text & """ WHERE config_key=""sellerHeader"""
                Globals.DB.executeNonQuery()

                If txtAccountNo.Text IsNot Nothing And txtBankAddress.Text IsNot Nothing Then
                    Globals.DB.cmd = "UPDATE config SET config_value=""" & txtAccountNo.Text & """ WHERE config_key=""sellerAccountNo"""
                    Globals.DB.executeNonQuery()
                    Globals.DB.cmd = "UPDATE config SET config_value=""" & txtBankAddress.Text & """ WHERE config_key=""sellerBankInfo"""
                    Globals.DB.executeNonQuery()

                End If
            Else
                MsgBox(Globals.rm.GetString("msgNotEnoughData"))

            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace & vbCrLf & ex.Source)
        End Try
    End Sub

    Private Sub FormLoads(sender As Object, e As EventArgs) Handles MyBase.Load
        setLanguage()

        ToolTip1.ToolTipTitle = Globals.rm.GetString("lbWarning")
        ToolTip1.SetToolTip(lbID, Globals.rm.GetString("msgNotRequired"))
        ToolTip1.SetToolTip(txtID, Globals.rm.GetString("msgNotRequired"))

        'get all data from db

    End Sub

    Private Sub Informations_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Informations_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing And fromNewDBWindow = True Then

            'check all fields 
            If Not checkFields() Then

            End If

            e.Cancel = True

        End If
    End Sub
End Class