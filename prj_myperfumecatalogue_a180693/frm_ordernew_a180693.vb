Imports System.Text.RegularExpressions

Public Class frm_ordernew_a180693

    Dim anInteger As Regex = New Regex("\d*")
    Dim perfumeData As DataTable
    Dim price As Decimal
    Dim quantity As Decimal
    Dim subtotal As Decimal

    Private Sub frm_ordernew_a180693_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_table.Columns.Add("FLD_PRODUCT_ID", "Product ID")
        grd_table.Columns.Add("FLD_PRODUCT_NAME", "Perfume Name")
        grd_table.Columns.Add("FLD_QUANTITY", "Quantity")
        grd_table.Columns.Add("FLD_PRICE", "Unit Price (RM)")
        grd_table.Columns.Add("TOTAL", "Total (RM)")
        refresh_text()
    End Sub

    Private Sub refresh_text()
        cmb_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A180693")
        cmb_customer.DisplayMember = "FLD_CUSTOMER_NAME"
        cmb_customer.ValueMember = "FLD_CUSTOMER_ID"
        cmb_customer.Text = ""

        cmb_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A180693")
        cmb_staff.DisplayMember = "FLD_STAFF_NAME"
        cmb_staff.ValueMember = "FLD_STAFF_ID"
        cmb_staff.SelectedIndex = -1

        Dim last As Object = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A180693").Rows(0).Item("LASTID")
        Dim nextnum As Integer = 1
        If Not IsDBNull(last) Then
            Dim lastid As String = last
            nextnum = Mid(lastid, 2) + 1
        End If
        txt_id.Text = Format(nextnum, "R00#")

        perfumeData = run_sql_query("SELECT * FROM TBL_PRODUCTS_A180693")
        cmb_perfume.DataSource = perfumeData
        cmb_perfume.DisplayMember = "FLD_PRODUCT_NAME"
        cmb_perfume.SelectedIndex = -1

        txt_quantity.Enabled = False
        txt_quantity.Text = ""
        txt_price.Text = ""
        txt_subtotal.Text = ""

        grd_table.Rows.Clear()

        txt_total.Text = ""

        btn_delete.Enabled = False
    End Sub

    Private Sub txt_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_quantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_quantity_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_quantity.KeyUp
        Try
            Dim quantity As Decimal = Decimal.Parse(txt_quantity.Text)
            subtotal = price * quantity
            txt_subtotal.Text = Format(subtotal, "RM0.00")
        Catch ex As Exception
            txt_subtotal.Text = ""
            txt_quantity.Text = ""
        End Try

    End Sub

    Private Sub txt_quantity_LostFocus(sender As Object, e As EventArgs) Handles txt_quantity.LostFocus
        Try
            Dim quantity As Integer = anInteger.Match(txt_quantity.Text).Value
            subtotal = price * quantity
            txt_subtotal.Text = Format(subtotal, "RM0.00")
            txt_quantity.Text = quantity
        Catch ex As Exception
            btn_add.Enabled = False
            txt_subtotal.Text = ""
            txt_quantity.Text = ""
        End Try
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        refresh_text()
    End Sub

    Private Sub cmb_perfume_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_perfume.SelectedIndexChanged
        Try
            txt_quantity.Enabled = True
            price = perfumeData.Rows(cmb_perfume.SelectedIndex).Field(Of Decimal)("FLD_PRICE")
            txt_price.Text = Format(price, "RM0.00")
            quantity = Decimal.Parse(txt_quantity.Text)
            subtotal = price * quantity
            txt_subtotal.Text = Format(subtotal, "RM0.00")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_subtotal_TextChanged(sender As Object, e As EventArgs) Handles txt_subtotal.TextChanged
        If subtotal > 0.0 Then
            btn_add.Enabled = True
        Else
            btn_add.Enabled = False
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If subtotal > 0.0 Then
            grd_table.Rows.Add(New String() {
                               perfumeData.Rows(cmb_perfume.SelectedIndex).Field(Of String)("FLD_PRODUCT_ID"),
                               cmb_perfume.Text,
                               txt_quantity.Text,
                               Format(price, "0.00"),
                               Format(subtotal, "0.00")
            })

            calculate_total()

            cmb_perfume.SelectedIndex = -1

            clear_picker()

        End If
    End Sub

    Private Sub clear_picker()
        txt_quantity.Enabled = False
        txt_quantity.Text = ""
        txt_price.Text = ""
        txt_subtotal.Text = ""
        btn_add.Enabled = False
    End Sub

    Private Sub calculate_total()
        Dim total As Decimal
        For i As Integer = 0 To grd_table.RowCount - 1
            total += Val(grd_table.Rows(i).Cells("TOTAL").Value)
        Next
        txt_total.Text = Format(total, "RM0.00")
    End Sub

    Private Sub grd_table_SelectionChanged(sender As Object, e As EventArgs) Handles grd_table.SelectionChanged
        If grd_table.SelectedRows.Count = 1 Then
            btn_delete.Enabled = True
            btn_delete.Text = "Delete"
        ElseIf grd_table.SelectedRows.Count > 1 Then
            btn_delete.Enabled = True
            btn_delete.Text = "Delete All"
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If grd_table.SelectedRows.Count = 1 Then
            grd_table.Rows.Remove(grd_table.SelectedRows(0))
        ElseIf grd_table.SelectedRows.Count > 1 Then
            For Each x As DataGridViewRow In grd_table.SelectedRows
                grd_table.Rows.Remove(x)
            Next
        End If
        grd_table.Refresh()
        calculate_total()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        If String.IsNullOrEmpty(cmb_customer.Text) Then
            Beep()
            MsgBox("Please enter customer's name")
            Exit Sub
        ElseIf String.IsNullOrEmpty(cmb_staff.Text) Then
            Beep()
            MsgBox("Please enter the staff in charge of the receipt.")
            Exit Sub
        ElseIf grd_table.Rows.Count < 1 Then
            Beep()
            MsgBox("No perfumes selected.")
        ElseIf Not String.IsNullOrEmpty(cmb_perfume.Text) Then
            Beep()
            Dim result As DialogResult = MsgBox("The perfume '" & cmb_perfume.Text & "' has not yet been selected. Are you sure you want to proceed?", vbYesNo, "Unselected Perfume")
            If result = vbNo Then
                Exit Sub
            End If
        End If

        Dim mysql As New List(Of String)()


        'Insert new customer if it doesn't exist'
        Dim cust_id As String
        If run_sql_query("SELECT * FROM TBL_CUSTOMER_A180693 WHERE FLD_CUSTOMER_NAME='" & cmb_customer.Text & "'").Rows.Count < 1 Then
            Dim last As Object = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A180693").Rows(0).Item("LASTID")
            Dim nextnum As Integer = 1
            If Not IsDBNull(last) Then
                Dim lastid As String = last
                nextnum = Mid(lastid, 2) + 1
            End If
            cust_id = Format(nextnum, "C00#")

            mysql.Add("INSERT INTO TBL_CUSTOMER_A180693 (FLD_CUSTOMER_ID, FLD_CUSTOMER_NAME) VALUES ('" & cust_id & "', '" & cmb_customer.Text & "');")

        Else
            cust_id = cmb_customer.SelectedValue

        End If

        mysql.Add("INSERT INTO TBL_ORDER_A180693" &
            " (FLD_ORDER_ID, FLD_CUSTOMER_ID, FLD_STAFF_ID) VALUES" &
            " ('" & txt_id.Text & "', '" & cust_id & "', '" & cmb_staff.SelectedValue & "');")

        For Each x As DataGridViewRow In grd_table.Rows
            mysql.Add("INSERT INTO TBL_ORDERITEM_A180693" &
                " (FLD_ORDER_ID, FLD_PRODUCT_ID, FLD_QUANTITY) VALUES" &
                " ('" & txt_id.Text & "', '" & x.Cells("FLD_PRODUCT_ID").Value & "', " & x.Cells("FLD_QUANTITY").Value & ");")
        Next


        Dim mytransaction As OleDb.OleDbTransaction
        dbupdate.Open()
        mytransaction = dbupdate.BeginTransaction
        Try
            For Each x As String In mysql
                Dim mywriter As New OleDb.OleDbCommand(x, dbupdate, mytransaction)
                mywriter.ExecuteNonQuery()
            Next

            mytransaction.Commit()
            dbupdate.Close()


            MsgBox("Order saved!")
            refresh_text()
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            dbupdate.Close()
        End Try
    End Sub

    Private Sub frm_ordernew_a180693_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180693.Show()
        Me.Hide()
    End Sub
End Class