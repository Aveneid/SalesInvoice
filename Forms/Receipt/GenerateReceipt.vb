Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.Text.RegularExpressions
Imports System.Data.SqlServerCe
Imports SalesInvoice.Utils

Public Class GenerateReceipt
    Dim receiptNo As String = ""
    Dim filename As String = ""
    Public Sub New(ByVal iReceiptNo As String)
        receiptNo = iReceiptNo
    End Sub

    Public Sub generateReceipt()
        Dim docSrc As String = ""
        If Globals.asSettings.Settings.Item("defaultPrintTemplate").Value <> "none" And Globals.asSettings.Settings.Item("defaultPrintTemplate").Value.Length > 5 Then
            docSrc = Application.StartupPath & "\Resources\" & Globals.asSettings.Settings.Item("defaultPrintTemplate").Value
        Else
            Using chooseTmp = New ChooseReceiptTemplate
                If DialogResult.OK = chooseTmp.ShowDialog() Then
                    docSrc = Application.StartupPath & "\resources\" & chooseTmp.cbTemplate.SelectedItem
                End If
            End Using
        End If
        If docSrc.Length > 0 Then
            Dim doc As New Document(docSrc)

            doc.Replace(New Regex("{{SELLER_TITLE}}"), Globals.asSettings.Settings.Item("headlineInfo").Value)
            doc.Replace(New Regex("{{SELLER_NAME}}"), Globals.asSettings.Settings.Item("sellerName").Value)
            If Globals.asSettings.Settings.Item("address").Value.Length > 2 Then
                doc.Replace(New Regex("{{SELLER_ADDRESS1}}"), Globals.asSettings.Settings.Item("address").Value & " " & Globals.asSettings.Settings.Item("buildingNo").Value)
            Else
                doc.Replace(New Regex("{{SELLER_ADDRESS1}}"), Globals.asSettings.Settings.Item("city").Value & " " & Globals.asSettings.Settings.Item("buildingNo").Value)
            End If
            doc.Replace(New Regex("{{SELLER_ADDRESS2}}"), Globals.asSettings.Settings.Item("postalCode").Value & " " & Globals.asSettings.Settings.Item("city").Value)
            doc.Replace(New Regex("{{SELLER_PHONE}}"), "tel." & Globals.asSettings.Settings.Item("phone").Value)
            doc.Replace(New Regex("{{RECEIPT_NO}}"), receiptNo)



            Using rd As SqlCeDataReader = Globals.DB.executeQuery("SELECT ddate FROM receipts where receipt_id = '" & receiptNo & "'")
                If rd.Read() Then
                    doc.Replace(New Regex("{{DATE}}"), rd.GetValue(0))
                End If
            End Using


            Using rd As SqlCeDataReader = Globals.DB.executeQuery("SELECT TOP 1 * FROM clients INNER JOIN receipts ON clients.id = receipts.client_id WHERE receipt_id = '" & receiptNo & "'")
                If rd.Read() Then
                    Dim tmp = rd.GetValue(1)
                    If rd.GetValue(4).ToString.Length > 0 Then
                        tmp &= "\r\n" & rd.GetValue(4)
                    End If


                    doc.Replace(New Regex("{{BUYER_NAME}}"), rd.GetValue(1).ToString)
                    Dim buyerAddress = rd.GetValue(3).ToString.Split(vbLf)
                    If buyerAddress.Length > 1 Then
                        doc.Replace(New Regex("{{BUYER_ADDRESS1}}"), buyerAddress(0))
                        doc.Replace(New Regex("{{BUYER_ADDRESS2}}"), buyerAddress(1))
                    Else
                        doc.Replace(New Regex("{{BUYER_ADDRESS1}}"), buyerAddress(0))
                        doc.Replace(New Regex("{{BUYER_ADDRESS2}}"), "")

                    End If

                    If rd.GetValue(2).ToString.Length > 2 Then
                        doc.Replace(New Regex("{{BUYER_PHONE}}"), "tel. " & rd.GetValue(2))
                    Else
                        doc.Replace(New Regex("{{BUYER_PHONE}}"), "")
                    End If

                End If
            End Using

            'items
            Dim receiptItemsTable As Table = doc.Sections(0).Tables(0)
            receiptItemsTable.Rows.RemoveAt(1)
            Dim dri As TableRow
            Dim itemsInReceiptCount = 0
            Dim SumAll As Double = 0

            Globals.DB.cmd = "SELECT items.name, SUM(receipts_data.amount) AS Expr3, units.name AS Expr2, items.price, SUM(receipts_data.amount * items.price) " &
                             "AS Expr1 FROM receipts INNER JOIN ReceiptsDetails On receipts.receipt_id = ReceiptsDetails.receipt_id INNER JOIN items On ReceiptsDetails.code " &
                             "= items.id INNER JOIN units On items.unit = units.id WHERE (receipts.receipt_id = '" & receiptNo & "') GROUP BY units.name, items.name, " &
                             "items.price"

            Using rd As SqlCeDataReader = Globals.DB.executeQuery()
                While rd.Read()
                    dri = receiptItemsTable.AddRow(6)
                    For Each i As TableCell In dri.Cells
                        i.AddParagraph()
                        'i.CellFormat.Borders.Top.BorderType = Spire.Doc.Documents.BorderStyle.Single
                        i.CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single
                        i.CellFormat.Borders.Top.BorderType = Spire.Doc.Documents.BorderStyle.None
                    Next
                    itemsInReceiptCount += 1

                    dri.Cells(0).FirstParagraph.Text = itemsInReceiptCount 'LP
                    dri.Cells(1).FirstParagraph.Text = rd.GetValue(0) 'ITEM_NAME
                    dri.Cells(2).FirstParagraph.Text = rd.GetValue(1) 'QTY
                    dri.Cells(3).FirstParagraph.Text = rd.GetValue(2) 'JM
                    dri.Cells(4).FirstParagraph.Text = rd.GetValue(3) 'VALUE
                    dri.Cells(5).FirstParagraph.Text = rd.GetValue(4) 'SUMITEM

                    receiptItemsTable.Rows.Insert(receiptItemsTable.Rows.Count - 1, dri)
                    For Each c As TableCell In dri.Cells
                        c = New TableCell(doc)
                    Next
                    SumAll += rd.GetValue(4)
                    'dri = 
                End While
            End Using

            doc.Replace(New Regex("{{SUM_ALL}}"), SumAll)
            doc.Replace(New Regex("{{FOOTER_TEXT}}"), Globals.asSettings.Settings.Item("footerText").Value)

            '        doc.SaveToFile("receipts/" & receiptNo.Replace("/", "_") & DatabaseHelper.currentDatabase & ".pdf", FileFormat.PDF)
            ' Try
            'doc.SaveToFile("receipts/" & receiptNo.Replace("/", "_") & ".pdf", FileFormat.PDF)
            filename = "receipts/" & receiptNo.Replace("/", "_") & "_" & Globals.DB.currentDatabase & ".pdf"
            doc.SaveToFile(filename, FileFormat.PDF)
            ' Catch ex As Exception
            '    MsgBox(Globals.rm.GetString("msgFileError"))
            ' End Try
        End If
    End Sub
    Public Sub PreviewReceipt()
        If filename.Length > 0 Then
            Dim print As New PrintingWindow
            'print.PdfViewer1.LoadFromFile(Application.StartupPath & "/" & filename)
            print.Show()
        End If
    End Sub
End Class
