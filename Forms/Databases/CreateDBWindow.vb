Imports SalesInvoice.Utils
Imports System.Data.SqlServerCe

Public Class CreateDBWindow

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not Globals.fileExists(Application.StartupPath & "\databases\" & DATABASENAME.Text & ".sdf") Then
            Try

                Globals.DB.currentDatabase = DATABASENAME.Text
                Globals.DB.createDatabase(False)

                If Globals.DB.checkDBConnection Then
                    Globals.DB.executeNonQuery(Globals.DBobjects.getString("tableCategories"))
                    Globals.DB.executeNonQuery(Globals.DBobjects.getString("tableCategories_data"))
                    Globals.DB.executeNonQuery(Globals.DBobjects.getString("tableClients"))
                    Globals.DB.executeNonQuery(Globals.DBobjects.getString("tableItems"))
                    Globals.DB.executeNonQuery(Globals.DBobjects.getString("tableReceipts"))
                    Globals.DB.executeNonQuery(Globals.DBobjects.getString("tableReceipts_data"))
                    Globals.DB.executeNonQuery(Globals.DBobjects.getString("tableUnits"))
                    Globals.DB.executeNonQuery(Globals.DBobjects.getstring("tableConfig"))
                    Globals.DB.executeNonQuery(Globals.DBobjects.getstring("tableConfig_data"))

                    Dim query As String() = Globals.DBobjects.getString("table_alters").Split(New Char() {";"c})

                    For Each w As String In query
                        If w.Length > 0 Then
                            Globals.DB.executeNonQuery(w)
                        End If
                    Next

                    query = Globals.DBobjects.getString("tableUnits_data").Split(New Char() {";"c})

                    For Each w As String In query
                        If w.Length > 0 Then
                            Globals.DB.executeNonQuery(w)
                        End If
                    Next

                    MessageBox.Show(Globals.rm.GetString("msgDatabaseCreatedSuccess"),
                                   "Info", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                Else
                    MsgBox(Globals.rm.GetString("msgDatabaseConnectionError"))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        Else
            MsgBox(Globals.rm.GetString("msgFileExists"))
        End If
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