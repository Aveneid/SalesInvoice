Imports System.Windows.Forms
Imports SalesInvoice.Utils
Public Class ReportsRange

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ReportsRange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Globals.rm.GetString("lbPickRange")
        MonthCalendar1.TodayDate = Date.Now

        lbPickRange.Text = Globals.rm.GetString("lbPickRange")
        MonthCalendar1.MaxDate = Date.Now.AddDays(1)
    End Sub
End Class
