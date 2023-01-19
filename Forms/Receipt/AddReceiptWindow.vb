Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Data.SqlServerCe
Imports SalesInvoice.Utils
Imports System.Xml
Imports System.Data.Odbc
Imports Spire.Doc
Imports Spire.Doc.Document
Imports System.Text.RegularExpressions
Public Class AddReceiptWindow
    Dim receiptNo As String
    Dim currentDate As DateTime = DateTime.Now
    Dim docSrc As String = ""
    Dim buyerToolTip = ""
    Dim filename = ""
    Dim cancelled = False
    Dim newReceipt = True

    Public Sub prepareData(client As String, index As String)
        newReceipt = False
        btnSave.Enabled = False
        btnSave.Visible = False

        'Globals.DB.cmd = New SqlCeCommand("SELECT  items.code, items.name, receipts_data.amount, units.name, items.price, items.price * receipts_data.amount AS suma " &
        '                        "FROM receipts_data " &
        '                        "INNER JOIN items ON items.id = receipts_data.code " &
        '                        "INNER JOIN units ON items.unit = units.id " &
        '                        "WHERE receipts_data.receipt_id = '" & index & "' ", DatabaseHelper.con)


        'DatabaseHelper.cmd = Nothing



    End Sub

    Sub generateReceiptPrint()
        Using chooseTmp = New ChooseReceiptTemplate
            If DialogResult.OK = chooseTmp.ShowDialog() Then
                docSrc = Application.StartupPath & "\resources\" & chooseTmp.cbTemplate.SelectedItem
                Dim doc As New Document(docSrc)

                doc.Replace(New Regex("{{SELLER_TITLE}}"), Globals.asSettings.Settings.Item("headlineInfo").Value)
                doc.Replace(New Regex("{{SELLER_NAME}}"), Globals.asSettings.Settings.Item("sellerName").Value)
                doc.Replace(New Regex("{{SELLER_ADDRESS1}}"), Globals.asSettings.Settings.Item("address").Value & " " & Globals.asSettings.Settings.Item("buildingNo").Value)
                doc.Replace(New Regex("{{SELLER_ADDRESS2}}"), Globals.asSettings.Settings.Item("postalCode").Value & " " & Globals.asSettings.Settings.Item("city").Value)
                doc.Replace(New Regex("{{SELLER_PHONE}}"), "tel." & Globals.asSettings.Settings.Item("phone").Value)

                doc.Replace(New Regex("{{RECEIPT_NO}}"), receiptNo)
                doc.Replace(New Regex("{{DATE}}"), ReceiptDate.Value.Date)

                Using rd As SqlCeDataReader = Globals.DB.executeQuery("SELECT TOP 1 * FROM clients where name = '" & BuyerCombo.Text & "'")
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

                'dri = receiptItemsTable.Rows(1)
                Dim itemsInReceiptCount = 0

                For Each dr As DataGridViewRow In ItemsInReceipt.Rows
                    If itemsInReceiptCount = ItemsInReceipt.Rows.Count() - 1 Then
                        Exit For
                    End If
                    itemsInReceiptCount += 1
                    dri = receiptItemsTable.AddRow(6)
                    For Each i As TableCell In dri.Cells
                        i.AddParagraph()
                        'i.CellFormat.Borders.Top.BorderType = Spire.Doc.Documents.BorderStyle.Single
                        i.CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single
                        i.CellFormat.Borders.Top.BorderType = Spire.Doc.Documents.BorderStyle.None
                    Next


                    dri.Cells(0).FirstParagraph.Text = itemsInReceiptCount 'LP
                    dri.Cells(1).FirstParagraph.Text = dr.Cells(1).Value 'ITEM_NAME
                    dri.Cells(2).FirstParagraph.Text = dr.Cells(2).Value 'QTY
                    dri.Cells(3).FirstParagraph.Text = dr.Cells(3).Value 'JM
                    dri.Cells(4).FirstParagraph.Text = dr.Cells(4).Value 'VALUE
                    dri.Cells(5).FirstParagraph.Text = dr.Cells(5).Value 'SUMITEM


                Next


                doc.Replace(New Regex("{{SUM_ALL}}"), SumAll.Text)
                doc.Replace(New Regex("{{FOOTER_TEXT}}"), Globals.asSettings.Settings.Item("footerText").Value)

                '  Try
                'doc.SaveToFile("receipts/" & receiptNo.Replace("/", "_") & ".pdf", FileFormat.PDF)
                filename = "receipts/" & receiptNo.Replace("/", "_") & "_" & Globals.DB.currentDatabase & ".pdf"
                doc.SaveToFile(filename, FileFormat.PDF)
                ' Catch ex As Exception
                'MsgBox(Globals.rm.GetString("msgFileError"))
                ' End Try
            Else
                cancelled = True
            End If

        End Using
    End Sub
    Sub updateData()
        Globals.DB.cmd = "Select name FROM clients"
        BuyerCombo.DataSource = Globals.DB.fillDataAdapter("clients")

        BuyerCombo.ValueMember = "name"
        BuyerCombo.DisplayMember = "name"
        ReceiptDate.Format = DateTimePickerFormat.Custom
        ReceiptDate.CustomFormat = "dd/MM/yyyy"

    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateData()
        setLanguage()
        'Generate receipt id
        Dim now = DateTime.Now
        Dim starting = New DateTime(now.Year, now.Month, 1)
        Dim ending = starting.AddMonths(1).AddDays(-1)

        ReceiptDate.MinDate = starting
        ReceiptDate.MaxDate = ending
        ReceiptDate.Value = now

        Dim count = 0

        Globals.DB.cmd = "Select count(id) FROM receipts WHERE ddate BETWEEN " &
                                "'" & starting.ToString("yyyy/MM/dd").Replace("-", "/") & "' AND " &
                                "'" & ending.ToString("yyyy/MM/dd").Replace("-", "/") & "'"

        Using rd As SqlCeDataReader = Globals.DB.executeQuery()
            If rd.Read() Then count = rd.GetValue(0)
        End Using

        'wrong ordering in show receipts pane
        'receiptNo = count + 1 & "/" & MonthName(now.Month).Substring(0, 3) & "/" & now.Year()
        receiptNo = now.Year() & "/" & MonthName(now.Month).Substring(0, 3) & "/" & count + 1

        lbReceiptNoVal.Text = receiptNo
    End Sub
    Sub setLanguage()
        lbClient.Text = Globals.rm.GetString("lbClient")
        lbReceiptNo.Text = Globals.rm.GetString("lbReceiptNO")
        lbSummary.Text = Globals.rm.GetString("lbSum")

        btnGenerate.Text = Globals.rm.GetString("lbGenerate")
        btnNew.Text = Globals.rm.GetString("lbNew")
        btnSave.Text = Globals.rm.GetString("lbSave")


        ItemsInReceipt.Columns(0).HeaderText = Globals.rm.GetString("lbCode")
        ItemsInReceipt.Columns(1).HeaderText = Globals.rm.GetString("lbItem")
        ItemsInReceipt.Columns(2).HeaderText = Globals.rm.GetString("lbAmount")
        ItemsInReceipt.Columns(3).HeaderText = Globals.rm.GetString("lbUnit")
        ItemsInReceipt.Columns(4).HeaderText = Globals.rm.GetString("lbCost")
        ItemsInReceipt.Columns(5).HeaderText = Globals.rm.GetString("lbSum")

        Me.Text = Globals.rm.GetString("lbNewReceipt")


        'ItemsInReceipt.Columns(2).DefaultCellStyle.NullValue = "1.00"
        'ItemsInReceipt.Columns(3).DefaultCellStyle.NullValue = "szt."
        'ItemsInReceipt.Columns(4).DefaultCellStyle.NullValue = "0.00"
        'ItemsInReceipt.Columns(5).DefaultCellStyle.NullValue = "0.00"


    End Sub
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ItemsInReceipt.SelectAll()
        ItemsInReceipt.Rows.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If ItemsInReceipt.Rows(0).Cells(0).Value IsNot Nothing Then
            cancelled = False
        End If
        If newReceipt Then savetoDB()


        generateReceiptPrint()
        If cancelled = False Then
            Dim print As New PrintingWindow
            'print.PdfViewer1.LoadFromFile((Application.StartupPath & "/" & filename))
            print.ShowDialog()
        End If
        Me.Close()
    End Sub

    Private Sub AddClientBtn(sender As Object, e As EventArgs) Handles btnNew.Click
        AddClientWindow.ShowDialog()
        updateData()
    End Sub
    Private Sub DataGridView1_EditingcontrolShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles ItemsInReceipt.EditingControlShowing
        Dim tb As New TextBox
        Dim dt As New DataTable()
        Dim da As New SqlCeDataAdapter
        Try
            Globals.DB.cmd = "Select * FROM items where name Like '%" & ItemsInReceipt.CurrentCell.Value & "%' ORDER BY name ASC"

            Dim r As DataRow
            Dim ac As New AutoCompleteStringCollection()
            For Each r In Globals.DB.getDataTable
                If TypeOf e.Control Is TextBox Then
                    If ItemsInReceipt.CurrentCell.ColumnIndex = 1 Then
                        ac.Add(r.Item("name").ToString)
                        tb = e.Control
                        tb.AutoCompleteCustomSource = ac
                        tb.AutoCompleteMode = AutoCompleteMode.Suggest
                        tb.AutoCompleteSource = AutoCompleteSource.CustomSource
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If ItemsInReceipt.Rows(0).Cells(0).Value IsNot Nothing And newReceipt Then
            savetoDB()
            Me.Close()
        End If
    End Sub
    Sub savetoDB() 'TODO
        Dim clientID = ""
        Using rd As SqlCeDataReader = Globals.DB.executeQuery("Select top 1 id FROM clients where name ='" & BuyerCombo.Text & "'")
            If rd.Read() Then
                clientID = rd.GetValue(0)
            End If
        End Using
        Globals.DB.cmd = "INSERT receipts(client_id,receipt_id,ddate) values(" & clientID & ",'" & receiptNo & "','" & ReceiptDate.Value.ToString("MM/dd/yyyy") & "')"
        Globals.DB.executeNonQuery()

        Dim s As DataGridViewRow
        If ItemsInReceipt.Rows.Count > 0 Then
            For Each s In ItemsInReceipt.Rows
                Try
                    If Not s.IsNewRow Then
                        If s.Cells.Item(1).Value.ToString.Length > 0 Then
                            ' MsgBox(s.Cells.Item(1).Value.ToString)
                            Globals.DB.cmd = "INSERT receiptsdetails(receipt_id,amount,code) values('" &
                                                   receiptNo & "'," & s.Cells(2).Value & "," & s.Cells(0).Value & ")"
                            Globals.DB.executeNonQuery()
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next

        End If
    End Sub

    Private Sub DeleteRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRowToolStripMenuItem.Click
        If ItemsInReceipt.RowCount > 1 Then
            If Not ItemsInReceipt.CurrentRow.IsNewRow Then
                ItemsInReceipt.Rows.Remove(ItemsInReceipt.CurrentRow)
            End If
        End If
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles ItemsInReceipt.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ItemsInReceipt.CellFormatting
        'If e.ColumnIndex = 1 Then
        '    If e.Value IsNot Nothing Then
        '        Dim da As New SqlCeDataAdapter
        '        Dim dt As New DataTable
        '        Dim r As DataRow
        '        DatabaseHelper.cmd = New SqlCeCommand("Select name FROM items where id like " & e.Value & " ORDER BY name DESC", DatabaseHelper.con)
        '        'AUTOCOMPLETE

        '        'da.SelectCommand = DatabaseHelper.cmd
        '        'da.Fill(dt)
        '        'For Each r In dt.Rows
        '        '    ItemsInReceipt.Rows(e.RowIndex).Cells(2).Value = r.Item("name").ToString
        '        'Next
        '    End If
        'End If
    End Sub

    Private Sub AddReceiptWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.ResetText()
    End Sub

    Private Sub PostPaintId(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ItemsInReceipt.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub
    Private Sub ItemsInReceipt_keyDown(sender As Object, e As KeyEventArgs) Handles ItemsInReceipt.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Not ItemsInReceipt.CurrentCell.IsInEditMode And ItemsInReceipt.Rows.Count > 1 And
                   ItemsInReceipt.CurrentRow.Index <> ItemsInReceipt.Rows.Count - 1 Then
                ItemsInReceipt.Rows.Remove(ItemsInReceipt.CurrentRow)
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If ItemsInReceipt.CurrentCell.ColumnIndex < ItemsInReceipt.Columns.Count < 2 Then
                ItemsInReceipt.CurrentCell = ItemsInReceipt.Rows(ItemsInReceipt.CurrentCell.RowIndex).Cells(ItemsInReceipt.CurrentCell.ColumnIndex)
            End If

        End If
    End Sub

    Private Sub ItemsInReceipt_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsInReceipt.CellEndEdit
        If e.ColumnIndex = 1 Then
            ItemsInReceipt.Rows(e.RowIndex).Cells(5).Value = ItemsInReceipt.Rows(e.RowIndex).Cells(4).Value *
                    ItemsInReceipt.Rows(e.RowIndex).Cells(2).Value
        End If


        If e.ColumnIndex = 1 Then
            Globals.DB.cmd = "SELECT items.id, items.price, units.name " &
                                   "FROM items INNER JOIN units ON items.unit = units.id " &
                                   "WHERE items.name = '" & ItemsInReceipt.Rows(e.RowIndex).Cells(1).Value & "'"

            Using rd As SqlCeDataReader = Globals.DB.executeQuery
                If rd.Read() Then ' check if item is in db
                    ItemsInReceipt.Rows(e.RowIndex).Cells(0).Value = rd.GetValue(0) ' code
                    ItemsInReceipt.Rows(e.RowIndex).Cells(4).Value = rd.GetValue(1) ' value
                    ItemsInReceipt.Rows(e.RowIndex).Cells(3).Value = rd.GetValue(2) ' unit
                    ItemsInReceipt.Rows(e.RowIndex).Cells(2).Value = 1              ' amount
                    ItemsInReceipt.Rows(e.RowIndex).Cells(5).Value = rd.GetValue(1)
                    ' ItemsInReceipt.CurrentCell = ItemsInReceipt.Rows(e.RowIndex - 1).Cells(2)
                Else 'if not add it with defaults
                    Globals.DB.cmd = "INSERT INTO items (name, category, unit, price) " & "VALUES ('" & ItemsInReceipt.Rows(e.RowIndex).Cells(1).Value & "', 1, 1, 0)"
                    Globals.DB.executeNonQueyr()

                End If
            End Using
        End If

        'sum all
        Dim sumAllValue As Double
        sumAllValue = 0

        For i = 0 To ItemsInReceipt.Rows.Count() - 1
            sumAllValue += CDbl(ItemsInReceipt.Rows(i).Cells(2).Value) * CDbl(ItemsInReceipt.Rows(i).Cells(4).Value)
        Next
        'MsgBox(sumAllValue)
        ItemsInReceipt.CurrentRow.Cells(5).Value = Format(CDbl(ItemsInReceipt.CurrentRow.Cells(2).Value) * CDbl(ItemsInReceipt.CurrentRow.Cells(4).Value), "0.00")
        SumAll.Text = Format(sumAllValue, "0.00")


    End Sub

    Private Sub BuyerCombo_MouseHover(sender As Object, e As EventArgs) Handles BuyerCombo.MouseHover
        If buyerToolTip <> "" Then
            ToolTip1.Show(buyerToolTip, BuyerCombo, 3500)
        End If
    End Sub

    Private Sub BuyerCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BuyerCombo.SelectedIndexChanged
        Globals.DB.cmd = "SELECT TOP 1 * FROM clients where name = '" & BuyerCombo.Text & "'"

        Using rd As SqlCeDataReader = Globals.DB.executeQuery
            If rd.Read() Then
                buyerToolTip = rd.GetValue(1) & vbNewLine
                Dim buyerAddress = rd.GetValue(3).ToString.Split(vbLf)
                If buyerAddress.Length > 1 Then
                    buyerToolTip = buyerToolTip & buyerAddress(0) & vbNewLine & buyerAddress(1)
                Else
                    buyerToolTip = buyerToolTip & buyerAddress(0)
                End If
                If rd.GetValue(2).ToString.Length > 2 Then
                    buyerToolTip = buyerToolTip & vbNewLine & "tel. " & rd.GetValue(2)

                End If
            End If
        End Using
    End Sub
End Class
