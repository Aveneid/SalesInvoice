Imports System.Windows.Forms
Imports SalesInvoice.Utils
Imports System.Data.SqlServerCe



Public Class EditCategory

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Globals.rm.GetString("lbEdit")
        lbCatName.Text = Globals.rm.GetString("lbCategory")
        Using rd As SqlCeDataReader = Globals.DB.executeQuery("select name as c from Categories")
            While rd.Read()
                cbCategories.Items.Add(rd.GetValue(0))
            End While
        End Using
        cbCategories.SelectedIndex = 0
    End Sub
End Class
