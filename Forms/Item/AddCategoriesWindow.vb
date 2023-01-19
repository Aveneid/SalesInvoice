Imports SalesInvoice.Utils
Imports System.Data.SqlServerCe
Public Class AddCategoriesWindow
    Public Sub refreshListBox()
        ListBox1.Items.Clear()

        Using rd As SqlCeDataReader = Globals.DB.executeQuery("select name from Categories")
            While rd.Read()
                ListBox1.Items.Add(rd.GetValue(0))
            End While
        End Using
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If TextBox1.Text IsNot Nothing Then

            Dim d As SqlCeDataReader = Globals.DB.executeQuery("SELECT name FROM  Categories WHERE name = '" & TextBox1.Text & "';")
            If Not d.Read() Then
                Globals.DB.executeNonQuery("INSERT Categories(name) values('" & TextBox1.Text & "');")
                refreshListBox()
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        refreshListBox()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim d As SqlCeDataReader = Globals.DB.executeQuery("SELECT * Categories where name = '" & ListBox1.SelectedItem.ToString & "'")
            If Not d.Read() Then
                Globals.DB.executeNonQuery("DELETE FROM Categories WHERE name = '" & ListBox1.SelectedItem.ToString & "'")
            Else
                MsgBox(Globals.rm.GetString("msgCategoryDelError"))
            End If
            refreshListBox()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode.ToString.ToLower = "return" Then
            btnAdd.PerformClick()
        End If
    End Sub

    Private Sub AddCategoriesWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshListBox()
        setLanguage()
        TextBox1.Focus()
    End Sub

    Private Sub AddCategoriesWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.ResetText()

    End Sub
    Sub setLanguage()
        btnAdd.Text = Globals.rm.GetString("lbAdd")
        btnDelete.Text = Globals.rm.GetString("lbDelete")
        btnOk.Text = Globals.rm.GetString("lbOk")
        lbCategories.Text = Globals.rm.GetString("lbCategories")
        Me.Text = Globals.rm.GetString("lbAddCategory")

    End Sub
End Class