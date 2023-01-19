Imports SalesInvoice.Utils
Imports System.Data.SqlServerCe
Public Class AddUnitsWindow
    Private Sub AddUnitsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshListBox()
        setLanguage()
        TextBox1.Focus()
    End Sub
    Sub setLanguage()
        btnAdd.Text = Globals.rm.GetString("lbAdd")
        btnDelete.Text = Globals.rm.GetString("lbDelete")
        btnOk.Text = Globals.rm.GetString("lbOk")
        lbUnits.Text = Globals.rm.GetString("lbUnit")
        Me.Text = Globals.rm.GetString("lbAddUnits")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListBox1.SelectedItem IsNot Nothing Then
            'MsgBox(ListBox1.SelectedItem & vbNewLine & ListBox1.SelectedValue)
            Dim d As SqlCeDataReader = Globals.DB.executeQuery("select * from items WHERE unit = '" & ListBox1.SelectedItem.ToString & "'")
            If Not d.Read() Then
                Globals.DB.executeNonQuery("DELETE FROM units WHERE name = '" & ListBox1.SelectedItem.ToString & "'")
            Else
                MsgBox(Globals.rm.GetString("msgCategoryDelError"))

            End If
            refreshListBox()
        End If

    End Sub
    Public Sub refreshListBox()
        ListBox1.Items.Clear()
        Using rd As SqlCeDataReader = Globals.DB.ExecuteQuery("select name as c from units")
            While rd.Read()
                ListBox1.Items.Add(rd.GetValue(0))
            End While
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If TextBox1.Text IsNot Nothing Then

            Dim d As SqlCeDataReader = Globals.DB.executeQuery("SELECT name FROM  units WHERE name = '" & TextBox1.Text & "';")
            If Not d.Read() Then
                Globals.DB.executeNonQuery("INSERT Units(name) values('" & TextBox1.Text & "');")
                refreshListBox()
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        refreshListBox()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode.ToString.ToLower = "return" Then
            btnAdd.PerformClick()
        End If
    End Sub

    Private Sub AddUnitsWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.ResetText()
    End Sub
End Class