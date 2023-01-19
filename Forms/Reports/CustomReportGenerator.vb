Imports SalesInvoice.Utils
Imports System.Data.SqlServerCe
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.IO

Public Class CustomReportGenerator
    Dim reportType As String
    Dim startDate As DateTime
    Dim endDate As DateTime
    Private Sub CustomReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Globals.rm.GetString("lbGenerating")
        lbGenerating.Text = Globals.rm.GetString("lbGenerating")
        generatePDF()
        Me.Close()
    End Sub
    Public Sub New(ByVal type As String, Optional dateStart As DateTime = Nothing, Optional dateEnd As DateTime = Nothing)
        ' This call is required by the designer.
        InitializeComponent()
        reportType = type
        If Not IsNothing(dateStart) Then startDate = dateStart
        If Not IsNothing(dateEnd) Then endDate = dateEnd
    End Sub
    Sub generatePDF()
        Dim repURI = ""
        Dim doc As New Document
        Dim sec As Section = doc.AddSection()
        Dim hea As HeaderFooter = sec.HeadersFooters.Header
        Dim foo As HeaderFooter = sec.HeadersFooters.Footer
        Dim fPara = foo.AddParagraph
        Dim sellerinfo = hea.AddParagraph()
        Dim hPara = hea.AddParagraph()
        Dim prevDate = ""
        Dim curDate = ""
        Dim par As Paragraph = Nothing
        fPara.AppendText("Strona ")
        fPara.AppendField("page number", FieldType.FieldPage)
        fPara.AppendText(" z ")
        fPara.AppendField("number of pages", FieldType.FieldSectionPages)
        fPara.Format.HorizontalAlignment = HorizontalAlignment.Right
        Dim dbinfoFoo = foo.AddParagraph()
        dbinfoFoo.AppendText("Dane z bazy: " & Globals.DB.currentDatabase).CharacterFormat.FontSize = 10
        dbinfoFoo.Format.HorizontalAlignment = HorizontalAlignment.Left


        sellerinfo.Format.HorizontalAlignment = HorizontalAlignment.Left
        sellerinfo.AppendText(Globals.asSettings.Settings.Item("headlineInfo").Value & vbNewLine).CharacterFormat.Bold = True
        sellerinfo.AppendText(Globals.asSettings.Settings.Item("sellerName").Value & vbNewLine).CharacterFormat.Bold = True
        sellerinfo.AppendText(Globals.asSettings.Settings.Item("address").Value & " " & Globals.asSettings.Settings.Item("buildingNo").Value & vbNewLine).CharacterFormat.Bold = True
        sellerinfo.AppendText(Globals.asSettings.Settings.Item("postalCode").Value & " " & Globals.asSettings.Settings.Item("city").Value & vbNewLine).CharacterFormat.Bold = True
        sellerinfo.AppendText("tel. " & Globals.asSettings.Settings.Item("phone").Value & vbNewLine).CharacterFormat.Bold = True

        If Not Directory.Exists(Application.StartupPath & "/reports") Then
            Directory.CreateDirectory(Application.StartupPath & "/reports")
        End If



        Select Case reportType
            Case "items"
                hPara.AppendText("Ilościowy raport sprzedaży wg. towarów" & vbNewLine & "Stan na dzień: " & Date.Now.ToString("dd.MM.yyyy") & vbNewLine & vbNewLine).CharacterFormat.FontSize = 20
                hPara.Format.HorizontalAlignment = HorizontalAlignment.Center
                'DatabaseHelper.cmd = New SqlCeCommand("SELECT items.name, SUM(receipts_data.amount) AS iSum, receipts.ddate FROM receipts_data INNER JOIN receipts ON receipts_data.receipt_id = receipts.receipt_id INNER JOIN items ON receipts_data.code = items.id GROUP BY items.name, receipts.ddate ORDER BY iSum DESC ", DatabaseHelper.con)
                Globals.DB.cmd = "SELECT items.name, SUM(receipts_data.amount) AS iSum, receipts.ddate FROM receipts_data INNER JOIN receipts ON receipts_data.receipt_id = receipts.receipt_id INNER JOIN items ON receipts_data.code = items.id GROUP BY items.name, receipts.ddate ORDER BY receipts.ddate DESC"

                Using rd As SqlCeDataReader = Globals.DB.executeQuery
                    While rd.Read()
                        If prevDate = "" And curDate = "" Then ' first item
                            prevDate = rd.GetValue(2)
                            curDate = rd.GetValue(2)
                            par = sec.AddParagraph()
                            par.AppendText(curDate)
                            par.AppendHTML("<center><hr><center>")
                            par.AppendText(vbNewLine)
                        End If

                        curDate = rd.GetValue(2)
                        If curDate <> prevDate Then ' different dates
                            par = sec.AddParagraph()
                            par.AppendText(curDate)
                            par.AppendHTML("<center><hr><center>")
                            par.AppendText(vbNewLine)
                        End If
                        par.AppendText(vbTab & "Towar: " & rd.GetValue(0) & vbTab & " Ilość: " & rd.GetValue(1))
                        par.AppendText(vbNewLine)

                        prevDate = curDate
                    End While
                    Try
                        doc.SaveToFile("reports/report_items_" & Date.Now.ToString("dd.MM.yyyy") & ".pdf", FileFormat.PDF)
                    Catch ex As Exception
                        MsgBox(Globals.rm.GetString("msgFileError"))
                    End Try
                    repURI = "reports/report_items_" & Date.Now.ToString("dd.MM.yyyy") & ".pdf"

                End Using
            Case "categories"
                hPara.AppendText("Ilościowy raport sprzedaży wg. kategorii towarów" & vbNewLine & "Stan na dzień: " & Date.Now.ToString("dd.MM.yyyy") & vbNewLine & vbNewLine).CharacterFormat.FontSize = 20
                hPara.Format.HorizontalAlignment = HorizontalAlignment.Center
                Globals.DB.cmd = "SELECT categories.name, SUM(receipts_data.code) AS Expr1, receipts.ddate FROM receipts INNER JOIN receipts_data ON receipts.receipt_id = receipts_data.receipt_id INNER JOIN items ON receipts_data.code = items.id INNER JOIN categories ON items.category = categories.id GROUP BY categories.name, receipts.ddate ORDER BY receipts.ddate DESC"

                Using rd As SqlCeDataReader = Globals.DB.executeQuery
                    While rd.Read()
                        If prevDate = "" And curDate = "" Then ' first item
                            prevDate = rd.GetValue(2)
                            curDate = rd.GetValue(2)
                            par = sec.AddParagraph()
                            par.AppendText(curDate)
                            par.AppendHTML("<center><hr><center>")
                            par.AppendText(vbNewLine)
                        End If

                        curDate = rd.GetValue(2)
                        If curDate <> prevDate Then ' different dates
                            par = sec.AddParagraph()
                            par.AppendText(curDate)
                            par.AppendHTML("<center><hr><center>")
                            par.AppendText(vbNewLine)
                        End If
                        par.AppendText(vbTab & "Kategoria: " & rd.GetValue(0) & vbTab & " Ilość: " & rd.GetValue(1))
                        par.AppendText(vbNewLine)

                        prevDate = curDate
                    End While
                End Using
                Try
                    doc.SaveToFile("reports/report_categories_" & Date.Now.ToString("dd.MM.yyyy") & ".pdf", FileFormat.PDF)
                Catch ex As Exception
                    MsgBox(Globals.rm.GetString("msgFileError"))
                End Try
                repURI = "reports/report_categories_" & Date.Now.ToString("dd.MM.yyyy") & ".pdf"

            Case "monthly"
                hPara.AppendText("Miesięczny raport sprzedaży towarów").CharacterFormat.FontSize = 20
                hPara.AppendText((vbNewLine & "Stan na dzień: " & Date.Now.ToString("dd.MM.yyyy") & vbNewLine & vbNewLine)).CharacterFormat.FontSize = 15
                hPara.Format.HorizontalAlignment = HorizontalAlignment.Center
                Globals.DB.cmd = "SELECT SUM(receipts_data.amount * items.price) AS iSum, receipts.ddate FROM receipts INNER JOIN receipts_data ON receipts.receipt_id = receipts_data.receipt_id INNER JOIN items ON receipts_data.code = items.id GROUP BY receipts.ddate ORDER BY receipts.ddate DESC"


                par = sec.AddParagraph()
                Using rd As SqlCeDataReader = Globals.DB.executeQuery()
                    While rd.Read()
                        par.AppendHTML("<center><hr><center>")
                        par.AppendText(vbNewLine)
                        Dim iDate = Convert.ToDateTime(rd.GetDateTime(1))
                        par.AppendText("Miesiąc: " & MonthName(iDate.Month) & " " & iDate.Year & " Kwota: " & rd.GetValue(0) & "zł")
                        par.AppendText(vbNewLine)
                    End While
                End Using

                Try
                    doc.SaveToFile("reports/report_monthly_" & Date.Now.ToString("MM.yyyy") & ".pdf", FileFormat.PDF)
                Catch ex As Exception
                    MsgBox(Globals.rm.GetString("msgFileError"))
                End Try
                repURI = "reports/report_monthly_" & Date.Now.ToString("MM.yyyy") & ".pdf"

            Case "customRange"
                startDate = startDate.ToShortDateString().Replace("-", ".")
                endDate = endDate.ToShortDateString().Replace("-", ".")
                hPara.AppendText("Raport sprzedaży towarów").CharacterFormat.FontSize = 20
                hPara.AppendText((vbNewLine & "Stan na dzień: " & Date.Now.ToString("dd.MM.yyyy"))).CharacterFormat.FontSize = 15
                hPara.AppendText((vbNewLine & "Dane z zakresu: " & startDate & " - " & endDate & vbNewLine & vbNewLine)).CharacterFormat.FontSize = 12
                hPara.Format.HorizontalAlignment = HorizontalAlignment.Center
                Globals.DB.cmd = "SELECT SUM(receipts_data.amount * items.price) AS iSum, receipts.ddate FROM receipts INNER JOIN receipts_data ON receipts.receipt_id = receipts_data.receipt_id INNER JOIN items ON receipts_data.code = items.id WHERE receipts.ddate BETWEEN '" & startDate.ToString("MM/dd/yyyy").Replace("-", "/") & "' AND '" & endDate.ToString("MM/dd/yyyy").Replace("-", "/") & "' GROUP BY receipts.ddate ORDER BY receipts.ddate DESC"

                par = sec.AddParagraph()
                Using rd As SqlCeDataReader = Globals.DB.executeQuery
                    While rd.Read()
                        par.AppendHTML("<center><hr><center>")
                        par.AppendText(vbNewLine)
                        Dim iDate = Convert.ToDateTime(rd.GetDateTime(1))
                        par.AppendText("Miesiąc: " & MonthName(iDate.Month) & " " & iDate.Year & " Kwota: " & rd.GetValue(0) & "zł")
                        par.AppendText(vbNewLine)
                    End While
                End Using
                Try
                    doc.SaveToFile("reports/report_custom_range_" & startDate & "-" & endDate & ".pdf", FileFormat.PDF)
                Catch ex As Exception
                    MsgBox(Globals.rm.GetString("msgFileError"))
                End Try
                repURI = "reports/report_custom_range_" & startDate & "-" & endDate & ".pdf"
        End Select

        Dim print As New PrintingWindow
        'print.PdfViewer1.LoadFromFile((Application.StartupPath & "/" & repURI))
        print.ShowDialog()
        Me.Close()
    End Sub
End Class