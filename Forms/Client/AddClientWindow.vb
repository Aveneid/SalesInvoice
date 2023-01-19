Imports System.Data.SqlServerCe
Imports SalesInvoice.Utils
Public Class AddClientWindow
    Private Sub AddClientToDatabase(sender As Object, e As EventArgs) Handles btnAdd.Click
        If NAMEDATA.Text.Length > 0 And ADDRESSDATA.Text.Length > 0 Then

            Globals.DB.cmd = "SELECT * FROM clients WHERE identificator = '" & NIPDATA.Text.Replace("-", "") & "' or name = '" & NAMEDATA.Text & "'"


            Dim d As SqlCeDataReader = Globals.DB.executeQuery
            If Not d.Read() Then
                Dim persondata As String = Nothing
                If PESELRADIO.Checked Then persondata = PESELDATA.Text
                If NIPRADIO.Checked Then persondata = NIPDATA.Text
                If NOTHINGRADIO.Checked Then persondata = 0
                Globals.DB.cmd = "INSERT clients(name,phone,identificator,address) values('" & NAMEDATA.Text & "','" & IIf(PHONEDATA.Text.Length < 1, "0", PHONEDATA.Text) & "','" & persondata & "','" & ADDRESSDATA.Text & "');"
                Globals.DB.executeNonQuery()
                Me.Close()
            Else
                MsgBox("Client already in database!")
            End If
        Else
            MsgBox(Globals.rm.GetString("msgNnotEnoughData"))
        End If

    End Sub
    Private Sub KeyListener(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode.ToString = "Escape" Then
            Me.Close()
        End If
    End Sub

    Private Sub FormClosedEvent(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.ResetText()
        Me.KeyPreview = False
    End Sub

    Private Sub FormLoadEvent(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.Focus()
        Me.BringToFront()
        setLanguage()
    End Sub
    Sub setLanguage()
        lbAddress.Text = Globals.rm.GetString("lbAddress")
        lbDownloadGUS.Text = Globals.rm.GetString("lbDataFromCEIDG")
        lbName.Text = Globals.rm.GetString("lbItemName")
        lbPhone.Text = Globals.rm.GetString("lbPhone")
        btnAdd.Text = Globals.rm.GetString("lbAdd")
        Me.Text = Globals.rm.GetString("lbAddClient")
    End Sub


    Private Sub NipRadioChanged(sender As Object, e As EventArgs) Handles NIPRADIO.CheckedChanged
        NIPDATA.Enabled = True
        PESELDATA.Text = ""
        PESELDATA.Enabled = False
        lbDownloadGUS.Enabled = True
        NIPDATA.Focus()
    End Sub

    Private Sub PeselRadioChanged(sender As Object, e As EventArgs) Handles PESELRADIO.CheckedChanged
        PESELDATA.Enabled = True
        NIPDATA.Text = ""
        NIPDATA.Enabled = False
        lbDownloadGUS.Enabled = False
        PESELDATA.Focus()
    End Sub

    Private Sub NothingRadioChanged(sender As Object, e As EventArgs) Handles NOTHINGRADIO.CheckedChanged
        NIPDATA.Enabled = False
        PESELDATA.Enabled = False
        NIPDATA.Text = ""
        PESELDATA.Text = ""
        lbDownloadGUS.Enabled = False
    End Sub

    Private Sub DownloadGusClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbDownloadGUS.LinkClicked
        If NIPDATA.Text.Replace("-", "").Replace(" ", "") IsNot "" Then
            DownloadDataFromGUS.NIPToSearch = NIPDATA.Text.Replace("-", "").Replace(" ", "")
            '    MsgBox(DownloadDataFromGUS.NIPToSearch)
            DownloadDataFromGUS.ShowDialog()
        End If
    End Sub

    Private Sub NipDataKeydown(sender As Object, e As KeyEventArgs) Handles NIPDATA.KeyDown
        If e.KeyCode.ToString.ToLower = "return" Then
            DownloadGusClicked(lbDownloadGUS, New Windows.Forms.LinkLabelLinkClickedEventArgs(lbDownloadGUS.Links(0), Windows.Forms.MouseButtons.Left))
        End If
    End Sub
End Class