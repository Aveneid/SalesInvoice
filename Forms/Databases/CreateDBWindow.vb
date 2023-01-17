Imports SalesInvoice.Utils
Imports System.Data.SqlServerCe

Public Class CreateDBWindow

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            Dim connectionString = "Data Source=""" & Application.StartupPath & "\databases\" & DATABASENAME.Text & ".sdf"""
            Dim en = New SqlCeEngine(connectionString)

            en.CreateDatabase()
            Dim conTest = New SqlCeConnection("Data Source=""" & Application.StartupPath & "\databases\" & DATABASENAME.Text & ".sdf""")
            conTest.Open()
            If conTest.State = ConnectionState.Open Then
                Dim cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableCategories"), conTest)
                cmdTest.ExecuteNonQuery()
                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableClients"), conTest)
                cmdTest.ExecuteNonQuery()
                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableItems"), conTest)
                cmdTest.ExecuteNonQuery()
                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableReceipts"), conTest)
                cmdTest.ExecuteNonQuery()
                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("tableReceipts_data"), conTest)
                cmdTest.ExecuteNonQuery()
                cmdTest = New SqlCeCommand(Globals.DBobjects.getString("table_units"), conTest)
                cmdTest.ExecuteNonQuery()

                Dim query As String() = Globals.DBobjects.getString("table_alters").Split(New Char() {";"c})

                For Each w As String In query
                    If w.Length > 0 Then
                        cmdTest = New SqlCeCommand(w, conTest)
                        cmdTest.ExecuteNonQuery()
                    End If
                Next

                query = Globals.DBobjects.getString("tableUnits_data").Split(New Char() {";"c})

                For Each w As String In query
                    If w.Length > 0 Then
                        cmdTest = New SqlCeCommand(w, conTest)
                        cmdTest.ExecuteNonQuery()
                    End If
                Next



                MessageBox.Show(Globals.rm.GetString("msgDatabaseCreatedSuccess"),
                               "Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                conTest.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Me.Close()
    End Sub

    Private Sub CreateDBWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCreate.PerformClick()
        End If
    End Sub

    Private Sub CreateDBWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        setLanguage()
    End Sub
    Sub setLanguage()
        btnCancel.Text = Globals.rm.GetString("lbCancel")
        btnCreate.Text = Globals.rm.GetString("lbCreate")
        lbName.Text = Globals.rm.GetString("lbItemName")
        Me.Text = Globals.rm.GetString("lbCreateDB")
        Me.Refresh()
    End Sub

    Private Sub CreateDBWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.ResetText()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox(Globals.rm.GetString("lbAreYouSure"), MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Me.Dispose()
            Me.Close()
        End If

    End Sub
End Class