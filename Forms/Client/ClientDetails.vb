Imports SalesInvoice.Utils
Imports System.Data.SqlServerCe
Public Class ClientDetails
    Dim cID As String
    Dim clientData(3) As String

    Public Sub New(ByVal id As String)
        InitializeComponent()
        cID = id
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ClientPhone.Text <> clientData(0) Or ClientId.Text <> clientData(1) Or ClientAddress.Text <> clientData(2) Then
            Globals.DB.cmd = "UPDATE clients set phone = '" & ClientPhone.Text & "', address = '" &
                                   ClientAddress.Text & "', identificator = '" & ClientId.Text & "' where id = " & cID

            If Globals.DB.executeNonQuery() Then
                MsgBox(Globals.rm.GetString("msgEditOk"))
            Else
                MsgBox(Globals.rm.GetString("msgGeneralError"))
            End If
        End If
        Me.Close()
    End Sub
    Sub updateLang()
        ClientNameLabel.Text = Globals.rm.GetString("lbItemName")
        ClientPhoneLabel.Text = Globals.rm.GetString("lbPhone")
        ClientIdLabel.Text = Globals.rm.GetString("lbID")
        ClientAddressLabel.Text = Globals.rm.GetString("lbAddress")
        Me.Text = Globals.rm.GetString("lbClientDetails")
        Button1.Text = Globals.rm.GetString("lbClose")
    End Sub

    Private Sub ClientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateLang()
        Globals.DB.cmd = "SELECT  name,phone,address,identificator from Clients where id = " & cID
        Using rd As SqlCeDataReader = Globals.DB.executeQuery()
            While rd.Read()
                ClientName.Text = rd.GetValue(0)
                ClientPhone.Text = rd.GetValue(1)
                ClientId.Text = rd.GetValue(3)
                ClientAddress.Text = rd.GetValue(2)
                clientData(0) = rd.GetValue(1)
                clientData(1) = rd.GetValue(3)
                clientData(2) = rd.GetValue(2)
            End While
        End Using
    End Sub

    Private Sub ClientDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class