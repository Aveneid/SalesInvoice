Imports System.Net
Imports System.IO
Imports System.Xml
Public Class DownloadDataFromGUS
    Public NIPToSearch As String = "none"

    Private Sub DownloadDataFromGUS_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dim client As DataStoreProvider201901Client = New DataStoreProvider201901Client("BasicHttpBinding_IDataStoreProvider201901")
        'Dim v As String() = {Nothing}
        'client.Open()
        'Dim xmlDoc As New XmlDocument
        'Dim nsMgr As XmlNamespaceManager
        'xmlDoc.LoadXml(client.GetMigrationData201901(System.Text.ASCIIEncoding.ASCII.GetString(
        '                                             System.convert.FromBase64String(
        '                                             System.Text.ASCIIEncoding.ASCII.GetString(
        '                                             System.convert.FromBase64String("api_key")))), {NIPToSearch}, {}, {}, {}, {}, {}, {},
        '                                             {}, {}, {}, {}, New Date(1970, 1, 1), Date.Now, {}, {1}, {}, New Date(1970, 1, 1), Date.Now()))
        'nsMgr = New XmlNamespaceManager(xmlDoc.NameTable)
        'If xmlDoc.SelectSingleNode("WynikWyszukiwania/InformacjaOWpisie", nsMgr) IsNot Nothing Then
        '    Dim company = xmlDoc.SelectSingleNode("WynikWyszukiwania/InformacjaOWpisie/DanePodstawowe/Firma", nsMgr).InnerText
        '    Dim address = xmlDoc.SelectSingleNode("WynikWyszukiwania/InformacjaOWpisie/DaneAdresowe/AdresGlownegoMiejscaWykonywaniaDzialalnosci/Ulica", nsMgr).InnerText & " " &
        '            xmlDoc.SelectSingleNode("WynikWyszukiwania/InformacjaOWpisie/DaneAdresowe/AdresGlownegoMiejscaWykonywaniaDzialalnosci/Budynek", nsMgr).InnerText & Environment.NewLine &
        '            xmlDoc.SelectSingleNode("WynikWyszukiwania/InformacjaOWpisie/DaneAdresowe/AdresGlownegoMiejscaWykonywaniaDzialalnosci/KodPocztowy", nsMgr).InnerText & " " &
        '            xmlDoc.SelectSingleNode("WynikWyszukiwania/InformacjaOWpisie/DaneAdresowe/AdresGlownegoMiejscaWykonywaniaDzialalnosci/Miejscowosc", nsMgr).InnerText
        '    AddClientWindow.NAMEDATA.Text = company
        '    AddClientWindow.ADDRESSDATA.Text = address
        'Else
        '    MsgBox("Not found")
        'End If
        'client.Close()
        'Me.Hide()
        'Me.Close()
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.PerformStep()
    End Sub
End Class