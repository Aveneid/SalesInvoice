Imports SalesInvoice.Utils
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Resources
Imports System.Threading
Imports System.IO
Imports System.GC
Imports System.Data.SqlServerCe

Public Class MainWindow

    Dim prevLang As String
    Private Property CultureInfo As CultureInfo

    Sub OpenDatabase()
        Try
            DatabaseHelper.con = New SqlCeConnection("Data Source=""" & Application.StartupPath & "\databases\" & DatabaseHelper.currentDatabase & """")
            DatabaseHelper.con.Open()
        Catch ex As Exception
            MsgBox(Globals.rm.GetString("msgGeneralError") & vbNewLine & Globals.rm.GetString("msgDatabaseError"))
            Application.Exit()
        End Try
    End Sub
    Private Sub MainWindow_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If Not prevLang Is Globals.asSettings.Settings.Item("lang").Value Then
            setLanguage()
        End If
    End Sub
    Sub loadRecents()
        Ribbon1.OrbDropDown.RecentItems.Clear()
        Dim files() As String
        If Directory.Exists(Application.StartupPath & "\receipts") Then
            files = Directory.GetFiles(Application.StartupPath & "\receipts", "*.pdf", SearchOption.TopDirectoryOnly)
            For Each FileName As String In files
                Dim r As New RibbonOrbRecentItem()
                r.Text = Path.GetFileName(FileName)
                AddHandler r.Click, AddressOf OpenRecent
                Ribbon1.OrbDropDown.RecentItems.Add(r)
            Next
        End If
    End Sub
    Sub OpenRecent(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, RibbonOrbRecentItem)
        Dim print As New PrintingWindow
        print.PdfViewer1.LoadFromFile(Application.StartupPath & "\receipts\" & btn.Text)
        print.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prevLang = Globals.asSettings.Settings.Item("lang").Value
        'Me.Text = "Records of the sale of undeclared activities - " & DatabaseHelper.currentDatabase & " - Sales "
        Me.Text = Globals.rm.GetString("titleMain") & " - " & DatabaseHelper.currentDatabase & " - " & Globals.rm.GetString("titleSales")
        Me.CenterToScreen()
        checkAllSettings()
        setLanguage()
        loadRecents()
    End Sub
    Public Sub setLanguage()
        Me.Text = Globals.rm.GetString("titleMain") & " - " & DatabaseHelper.currentDatabase & " - " & Globals.rm.GetString("titleSales")
        RibbonMainTab.Text = Globals.rm.GetString("lbMainTab")

        RibbonNewPanel.Text = Globals.rm.GetString("lbNew")
        NewClientBtn.Text = Globals.rm.GetString("lbAddClient")
        NewItemBtn.Text = Globals.rm.GetString("lbAddItem")
        NewReceiptBtn.Text = Globals.rm.GetString("lbNewReceipt")

        RibbonDatabasePanel.Text = Globals.rm.GetString("lbDatabase")
        ShowClientsBtn.Text = Globals.rm.GetString("lbShowClients")
        ShowItemsBtn.Text = Globals.rm.GetString("lbShowItems")
        ShowReceiptsBtn.Text = Globals.rm.GetString("lbShowReceipts")

        RibbonSettingsBtn.Text = Globals.rm.GetString("lbSettings")
        RibbonInfoBtn.Text = Globals.rm.GetString("lbInfo")
        RaportsTab.Text = Globals.rm.GetString("lbRaports")

        RibbonExitBtn.Text = Globals.rm.GetString("lbExit")


        repItems.Text = Globals.rm.GetString("lbItems")
        repCategories.Text = Globals.rm.GetString("lbCategory")
        repMonth.Text = Globals.rm.GetString("lbMonthly")
        repRange.Text = Globals.rm.GetString("lbInRange")
        RaportsVar.Text = Globals.rm.GetString("lbRaportsVar")
        RaportsRanged.Text = Globals.rm.GetString("lbRaportsRange")


    End Sub

    Sub checkAllSettings()
        'If Globals.asSettings.Settings.Item("enable_scanner_service").Value.ToLower = "true" Then
        '    Dim proc As New System.Diagnostics.Process()
        '    If Globals.fileExists(".\bin\BarcodeScannerListener.exe") Then proc = Process.Start(".\bin\BarcodeScannerListener.exe", "")
        'End If
    End Sub
    Sub updateconnection()
        Try
            DatabaseHelper.con = New SqlCeConnection("Data Source=""" & Application.StartupPath & ".\databases\" & DatabaseHelper.currentDatabase & """")
            DatabaseHelper.con.Open()
        Catch ex As Exception
            MsgBox(Globals.rm.GetString("msgGeneralError") & vbNewLine & Globals.rm.GetString("msgDatabaseError"))
            Application.Exit()
        End Try
    End Sub
    Private Sub NewClientBtn_Click(sender As Object, e As EventArgs) Handles NewClientBtn.Click
        AddClientWindow.ShowDialog()
    End Sub
    Private Sub NewReceiptBtn_Click(sender As Object, e As EventArgs) Handles NewReceiptBtn.Click
        AddReceiptWindow.ShowDialog()
    End Sub
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Dim id = MainGridView.CurrentRow.Cells("id").Value

        DatabaseHelper.cmd = New SqlCeCommand("DELETE FROM " & DatabaseHelper.currentSet & " WHERE id= " & id, DatabaseHelper.con)
        If DatabaseHelper.con.State = ConnectionState.Closed Then DatabaseHelper.con.Open()
        DatabaseHelper.cmd.ExecuteNonQuery()
        updateDataView()
        DatabaseHelper.con.Close()
    End Sub

    Private Sub RibbonOrbMenuItem4_Click(sender As Object, e As EventArgs) Handles RibbonExitBtn.Click
        Me.Close()
    End Sub

    Private Sub RibbonButton1_Click(sender As Object, e As EventArgs) Handles RibbonSettingsBtn.Click
        Dim old = DatabaseHelper.currentDatabase
        OptionsAndDatabaseWindow.StartPosition = FormStartPosition.CenterParent
        OptionsAndDatabaseWindow.ShowDialog(Me)
        If Not old.ToString.Equals(DatabaseHelper.currentDatabase.ToString) Then
            MainGridView.DataSource = Nothing
            MainGridView.Rows.Clear()
            Me.Text = Globals.rm.GetString("titleMain") & " - " & DatabaseHelper.currentDatabase & " - " & Globals.rm.GetString("titleSales")
            updateconnection()
        End If
    End Sub
    Private Sub RibbonButton9_Click(sender As Object, e As EventArgs) Handles NewItemBtn.Click
        AddItemWindow.ShowDialog()
    End Sub

    Private Sub RibbonButton11_Click(sender As Object, e As EventArgs) Handles ShowItemsBtn.Click
        DatabaseHelper.currentSet = "items"
        'DatabaseHelper.cmd = New SqlCeCommand("select items.id,name,code,category_name,service,amount,price from items inner join items_categories on items.category = items_categories.id", DatabaseHelper.con)
        DatabaseHelper.cmd = New SqlCeCommand("SELECT items.id,items.name,items.price,categories.name from items inner join categories on items.category = categories.id", DatabaseHelper.con)
        updateDataView()

        MainGridView.Columns(0).HeaderText = Globals.rm.GetString("lbCode")
        MainGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        MainGridView.Columns(1).HeaderText = Globals.rm.GetString("lbItemName")

        MainGridView.Columns(3).HeaderText = Globals.rm.GetString("lbCategory")
        MainGridView.Columns(2).HeaderText = Globals.rm.GetString("lbPrice")
        MainGridView.Sort(MainGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)


    End Sub
    Private Sub ShowReceiptsBtn_Click(sender As Object, e As EventArgs) Handles ShowReceiptsBtn.Click
        DatabaseHelper.currentSet = "receipts"
        DatabaseHelper.cmd = New SqlCeCommand("select clients.name,receipt_id,date from receipts inner join clients on clients.id = receipts.client_id", DatabaseHelper.con)
        updateDataView()

        MainGridView.Columns(0).HeaderText = Globals.rm.GetString("lbClient")
        MainGridView.Columns(1).HeaderText = Globals.rm.GetString("lbDocumentNo")
        MainGridView.Columns(2).HeaderText = Globals.rm.GetString("lbDate")
        MainGridView.Sort(MainGridView.Columns(1), System.ComponentModel.ListSortDirection.Descending)

    End Sub
    Private Sub ShowClientsBtn_Click(sender As Object, e As EventArgs) Handles ShowClientsBtn.Click
        DatabaseHelper.currentSet = "clients"
        DatabaseHelper.cmd = New SqlCeCommand("select id,name,phone,identificator from Clients", DatabaseHelper.con)
        updateDataView()

        MainGridView.Columns(0).HeaderText = Globals.rm.GetString("lbID")
        MainGridView.Columns(1).HeaderText = Globals.rm.GetString("lbItemName")
        MainGridView.Columns(2).HeaderText = Globals.rm.GetString("lbPhone")
        MainGridView.Columns(3).HeaderText = Globals.rm.GetString("lbIdData")
        For i = 0 To 3
            MainGridView.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        MainGridView.Sort(MainGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)


    End Sub
    Sub updateDataView()

        Select Case DatabaseHelper.currentSet
            Case "items"
                DatabaseHelper.cmd = New SqlCeCommand("SELECT items.id,items.name,items.price,categories.name from items inner join categories on items.category = categories.id", DatabaseHelper.con)
            Case "clients"
                DatabaseHelper.cmd = New SqlCeCommand("select id,name,phone,identificator from Clients", DatabaseHelper.con)
            Case "receipts"
                DatabaseHelper.cmd = New SqlCeCommand("select clients.name,receipt_id,ddate from receipts inner join clients on clients.id = receipts.client_id", DatabaseHelper.con)
        End Select
        If DatabaseHelper.con.State = ConnectionState.Closed Then DatabaseHelper.con.Open()
        DatabaseHelper.cmd.ExecuteNonQuery()

        DatabaseHelper.myDA = New SqlCeDataAdapter(DatabaseHelper.cmd)
        DatabaseHelper.myDataSet = New DataSet()

        DatabaseHelper.myDA.Fill(DatabaseHelper.myDataSet, DatabaseHelper.currentSet)
        MainGridView.DataSource = DatabaseHelper.myDataSet.Tables(DatabaseHelper.currentSet).DefaultView

        DatabaseHelper.con.Close()
        MainGridView.Focus()
    End Sub
    Private Sub RibbonButton6_Click(sender As Object, e As EventArgs) Handles RibbonInfoBtn.Click
        Informations.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MainGridView.CellDoubleClick
        If DatabaseHelper.currentSet = "receipts" Then
            'currentSet = "receipts_data"

            AddReceiptWindow.ShowDialog()
            AddReceiptWindow.Text = Globals.rm.GetString("lbReceipt") & MainGridView.CurrentRow.Cells(1).Value & " - " & MainGridView.CurrentRow.Cells(0).Value
            AddReceiptWindow.prepareData(MainGridView.CurrentRow.Cells(0).Value, MainGridView.CurrentRow.Cells(1).Value)

            'Dim index As String = MainGridView.CurrentRow.Cells(1).Value
            'Dim client As String = MainGridView.CurrentRow.Cells(0).Value
            'DatabaseHelper.cmd = New SqlCeCommand("SELECT  items.name, receipts_data.amount, units.name, items.price, items.price * receipts_data.amount AS suma " & _
            '                        "FROM receipts_data " & _
            '                        "INNER JOIN items ON items.id = receipts_data.code " & _
            '                        "INNER JOIN units ON items.unit = units.id " & _
            '                        "WHERE receipts_data.receipt_id = '" & index & "' ", DatabaseHelper.con)

            'updateDataView()
            'MainGridView.Columns(0).HeaderText = Globals.rm.GetString("lbItemName")
            'MainGridView.Columns(1).HeaderText = Globals.rm.GetString("lbAmount")
            'MainGridView.Columns(2).HeaderText = Globals.rm.GetString("lbUnit")
            'MainGridView.Columns(3).HeaderText = Globals.rm.GetString("lbPrice")
            'MainGridView.Columns(4).HeaderText = Globals.rm.GetString("lbCost")
            'DatabaseHelper.con.Close()
        End If
        If DatabaseHelper.currentSet = "items" Then
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow = MainGridView.Rows(e.RowIndex)
                Dim itemDetails As New ItemDetails(selectedRow.Cells(0).Value)
                itemDetails.ShowDialog()
            End If
        End If
        If DatabaseHelper.currentSet = "clients" Then
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow = MainGridView.Rows(e.RowIndex)
                Dim clientDetails As New ClientDetails(selectedRow.Cells(0).Value)
                clientDetails.ShowDialog()
            End If
        End If
    End Sub
    Private Sub RibbonOrbMenuItem2_Click(sender As Object, e As EventArgs)
        FirstRunWizard.Show()
    End Sub

    Private Sub MainGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles MainGridView.RowPostPaint
        ' This fragment of code belongs to: devcomponents
        ' Source: https://www.devcomponents.com/kb2/?p=1230
        '

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

    Private Sub MainWindow_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        OpenDatabase()
    End Sub

    Private Sub repRange_Click(sender As Object, e As EventArgs) Handles repRange.Click
        Using chooseDate = New ReportsRange
            If DialogResult.OK = chooseDate.ShowDialog() Then
                Dim report As New CustomReportGenerator("customRange", chooseDate.MonthCalendar1.SelectionStart, chooseDate.MonthCalendar1.SelectionEnd)
                report.ShowDialog()
            End If
        End Using
    End Sub

    Private Sub repItems_Click(sender As Object, e As EventArgs) Handles repItems.Click
        Dim report As New CustomReportGenerator("items")
        report.ShowDialog()
    End Sub

    Private Sub repCategories_Click(sender As Object, e As EventArgs) Handles repCategories.Click
        Dim report As New CustomReportGenerator("categories")
        report.ShowDialog()
    End Sub

    Private Sub repMonth_Click(sender As Object, e As EventArgs) Handles repMonth.Click
        Dim report As New CustomReportGenerator("monthly")
        report.Show()
    End Sub

    Private Sub MainGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles MainGridView.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If DatabaseHelper.currentSet = "receipts" Then
                Dim hit As DataGridView.HitTestInfo = MainGridView.HitTest(e.X, e.Y)
                MainGridView.CurrentCell = MainGridView.Rows(hit.RowIndex).Cells(1)
                Dim printBtn As New ToolStripMenuItem()
                printBtn.Text = Globals.rm.GetString("lbPrint")
                contextMenuStrip1.Items.Clear()
                contextMenuStrip1.Items.Add(printBtn)
                AddHandler printBtn.Click, AddressOf PrintBtnHandler
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
            End If
        End If
    End Sub
    Sub PrintBtnHandler(sender As Object, e As EventArgs)
        Dim srcCell = MainGridView.SelectedCells(0).RowIndex()
        Dim receiptNo = MainGridView.Rows(srcCell).Cells(1).Value
        Dim genRec As New GenerateReceipt(receiptNo)
        genRec.generateReceipt()
        genRec.PreviewReceipt()

    End Sub

    Private Sub MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DatabaseHelper.con.Close()
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub GCTimer_Tick(sender As Object, e As EventArgs) Handles GCTimer.Tick
        Dim before As Long = GC.GetTotalMemory(False)
        GC.Collect()
        Dim after As Long = GC.GetTotalMemory(False)
        Dim res As Integer = (before - after) / 1024
        StatusGC.Text = "Released: " & res & "kB"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimeTimer.Tick
        StatusTime.Text = TimeOfDay.ToString("hh:mm:ss") & " " & Date.Now().ToShortDateString
    End Sub
End Class
