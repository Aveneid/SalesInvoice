Imports System.Data.SqlServerCe
Imports SalesInvoice.Utils
Public Class AddItemWindow
    Dim i As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ITEMNAME.Text IsNot Nothing And ITEMCATEGORY.SelectedItem IsNot Nothing And UNITCOMBO.SelectedItem IsNot Nothing Then
            If ITEMCATEGORY.SelectedItem = Globals.rm.GetString("lbEditCategories") Or ITEMCATEGORY.SelectedItem = "- - - - -" Then
                ToolTip1.Show(Globals.rm.GetString("lbIncorrectCategory"), ITEMCATEGORY, 3000)
            Else
                If UNITCOMBO.SelectedItem = Globals.rm.GetString("lbEditUnits") Or UNITCOMBO.SelectedItem = "- - - - -" Then
                    ToolTip1.Show(Globals.rm.GetString("lbIncorrectCategory"), UNITCOMBO, 3000)
                Else
                    Dim cat_id = 0
                    Dim unit_id = 0


                    'DatabaseHelper.cmd = New SqlCeCommand("Select top 1 id from Categories where name = '" & ITEMCATEGORY.SelectedItem & "'", DatabaseHelper.con)
                    'If DatabaseHelper.con.State = ConnectionState.Closed Then DatabaseHelper.con.Open()
                    'DatabaseHelper.cmd.ExecuteNonQuery()

                    Using ird As SqlCeDataReader = Globals.DB.executeQuery("SELECT top 1 id FROM categories WHERE name = '" & ITEMCATEGORY.SelectedItem & "'")
                        While ird.Read()
                            cat_id = ird.GetValue(0)
                        End While
                    End Using

                    'DatabaseHelper.cmd = New SqlCeCommand("select id from Units where name = '" & UNITCOMBO.SelectedItem & "'", DatabaseHelper.con)
                    'If DatabaseHelper.con.State = ConnectionState.Closed Then DatabaseHelper.con.Open()
                    'DatabaseHelper.cmd.ExecuteNonQuery()

                    Using ird As SqlCeDataReader = Globals.DB.executeQuery("SELECT id FROM units WHERE name = '" & UNITCOMBO.SelectedItem & "'")
                        While ird.Read()
                            unit_id = ird.GetValue(0)
                        End While
                    End Using



                    ' DatabaseHelper.cmd = New SqlCeCommand("INSERT items(name,code,category,amount,price,service,unit) values('" & ITEMNAME.Text & "','" & ITEMEANCODE.Text & "'," & _
                    ' cat_id & "," & ITEMQUANTITY.Value & ",'" & ITEMPRICE.Text & "'," & If(CHKASSERVICE.Checked, 1, 0) & "," & unit_id & ")", DatabaseHelper.con)
                    ' ITEMPRICE.Text = ITEMPRICE.Text.Replace(",", ".")
                    ' DatabaseHelper.cmd = New SqlCeCommand("INSERT Items(name,price,category,unit) values('" &
                    ' ITEMNAME.Text & "'," & ITEMPRICE.Text & "," & cat_id & "," & unit_id & ")", DatabaseHelper.con)
                    ' If DatabaseHelper.con.State = ConnectionState.Closed Then DatabaseHelper.con.Open()

                    Globals.DB.executeNonQuery("INSERT Items(name,price,category,unit) VALUES('" & ITEMNAME.Text & "'," & ITEMPRICE.Text & "," & cat_id & "," & unit_id & ")")


                    'DatabaseHelper.cmd = New SqlCeCommand("select count(*) as c from Items", DatabaseHelper.con)
                    Using rd As SqlCeDataReader = Globals.DB.executeQuery("SELECT count(*) FROM Items")
                        rd.Read()
                        If rd.GetValue(0).ToString IsNot "0" Then
                            ToolStripStatusLabel1.Text = Globals.rm.GetString("lbItemsInDb") & rd.GetValue(0)
                        Else
                            ToolStripStatusLabel1.Text = Globals.rm.GetString("lbItemsInDb") & "0"
                        End If
                    End Using
                    ITEMNAME.Text = Nothing
                    ITEMPRICE.Text = Nothing
                    ITEMCATEGORY.SelectedItem = "- - - - -"
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub AddItemWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ITEMNAME.Text = Nothing
    End Sub

    Private Sub AddItemWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setLanguage()

        ITEMNAME.Focus()
        ITEMCATEGORY.Items.Clear()
        UNITCOMBO.Items.Clear()

        Using rd As SqlCeDataReader = Globals.DB.executeQuery("SELECT name FROM Categories")
            While rd.Read()
                ITEMCATEGORY.Items.Add(rd.GetValue(0))
            End While
        End Using
        ITEMCATEGORY.Items.Add("- - - - -")
        ITEMCATEGORY.SelectedItem = "- - - - -"
        ITEMCATEGORY.Items.Add(Globals.rm.GetString("lbEditCategories"))


        Using rd As SqlCeDataReader = Globals.DB.executeQuery("SELECT name FROM Units")
            While rd.Read()
                UNITCOMBO.Items.Add(rd.GetValue(0))
            End While
        End Using
        UNITCOMBO.Items.Add("- - - - -")
        UNITCOMBO.SelectedItem = "- - - - -"
        UNITCOMBO.Items.Add(Globals.rm.GetString("lbEditUnits"))


        Using rd As SqlCeDataReader = Globals.DB.executeQuery("SELECT count(*) FROM Items")
            rd.Read()
            If rd.GetValue(0).ToString IsNot "0" Then
                ToolStripStatusLabel1.Text = Globals.rm.GetString("lbItemsInDb") & rd.GetValue(0)
            Else
                ToolStripStatusLabel1.Text = Globals.rm.GetString("lbItemsInDb") & "0"
            End If
        End Using

    End Sub
    Sub setLanguage()
        lbCategories.Text = Globals.rm.GetString("lbCategory")
        lbName.Text = Globals.rm.GetString("lbItemName")
        lbPrice.Text = Globals.rm.GetString("lbPrice")
        Label1.Text = Globals.rm.GetString("lbUnit")

        btnAdd.Text = Globals.rm.GetString("lbAdd")
        btnClose.Text = Globals.rm.GetString("lbClose")

        Me.Text = Globals.rm.GetString("lbAddItem")

        Me.Refresh()

    End Sub

    Private Sub AddItemWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode.ToString.ToLower = "insert" Or e.KeyCode.ToString.ToLower = "return" Then
            btnAdd.PerformClick()
        End If
    End Sub
    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ITEMCATEGORY.SelectedValueChanged
        If ITEMCATEGORY.SelectedItem = Globals.rm.GetString("lbEditCategories") Then
            If AddCategoriesWindow.ShowDialog() Then
                ITEMCATEGORY.Items.Clear()

                Using rd As SqlCeDataReader = Globals.DB.executeQuery("SELECT name FROM Categories")
                    While rd.Read()
                        ITEMCATEGORY.Items.Add(rd.GetValue(0))
                    End While
                End Using
                ITEMCATEGORY.Items.Add("- - - - -")
                ITEMCATEGORY.Items.Add(Globals.rm.GetString("lbEditCategories"))
                'ComboBox1.SelectedIndex = ComboBox1.Items.Count / ComboBox1.Items.Count
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ITEMPRICE.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                         Asc(e.KeyChar) = 8 Or
                         (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub UNITCOMBO_SelectedValueChanged(sender As Object, e As EventArgs) Handles UNITCOMBO.SelectedValueChanged
        If UNITCOMBO.SelectedItem = Globals.rm.GetString("lbEditUnits") Then
            If AddUnitsWindow.ShowDialog() Then
                UNITCOMBO.Items.Clear()


                Using rd As SqlCeDataReader = Globals.DB.executeQuery("SELECT name FROM Units")
                    While rd.Read()
                        UNITCOMBO.Items.Add(rd.GetValue(0))
                    End While
                End Using
                UNITCOMBO.Items.Add("- - - - -")
                UNITCOMBO.Items.Add(Globals.rm.GetString("lbEditUnits"))
                'ComboBox1.SelectedIndex = ComboBox1.Items.Count / ComboBox1.Items.Count
            End If
        End If
    End Sub
End Class