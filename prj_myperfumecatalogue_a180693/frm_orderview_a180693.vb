Public Class frm_orderview_a180693
    Dim order As DataTable = run_sql_query("SELECT * FROM TBL_ORDER_A180693")

    Private Sub frm_orderview_a180693_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_table.Columns.Add("FLD_PRODUCT_ID", "Product ID")
        grd_table.Columns.Add("FLD_PRODUCT_NAME", "Perfume Name")
        grd_table.Columns.Add("FLD_QUANTITY", "Quantity")
        grd_table.Columns.Add("FLD_PRICE", "Unit Price (RM)")
        grd_table.Columns.Add("TOTAL", "Total (RM)")
        refresh_text()
    End Sub

    Private Sub refresh_text()
        txt_customer.Text = ""
        txt_staff.Text = ""

        cmb_id.DataSource = order
        cmb_id.DisplayMember = "FLD_ORDER_ID"
        cmb_id.SelectedIndex = -1

        grd_table.Rows.Clear()

        txt_total.Text = ""

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub frm_orderview_a180693_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        refresh_text()
    End Sub

    Private Sub cmb_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_id.SelectedIndexChanged
        grd_table.Rows.Clear()
        Try
            txt_customer.Text = run_sql_query("SELECT FLD_CUSTOMER_NAME FROM TBL_CUSTOMER_A180693 WHERE FLD_CUSTOMER_ID='" & order.Rows(cmb_id.SelectedIndex).Field(Of String)("FLD_CUSTOMER_ID") & "'").Rows(0).Field(Of String)(0)
            txt_staff.Text = run_sql_query("SELECT FLD_STAFF_NAME FROM TBL_STAFF_A180693 WHERE FLD_STAFF_ID='" & order.Rows(cmb_id.SelectedIndex).Field(Of String)("FLD_STAFF_ID") & "'").Rows(0).Field(Of String)(0)

            Dim orderItem As DataTable = run_sql_query("SELECT * FROM TBL_ORDERITEM_A180693 WHERE FLD_ORDER_ID='" & cmb_id.Text & "'")
            For Each x As DataRow In orderItem.Rows
                Dim perfumeData As DataTable = run_sql_query("SELECT FLD_PRODUCT_NAME, FLD_PRICE FROM TBL_PRODUCTS_A180693 WHERE FLD_PRODUCT_ID='" & x.Field(Of String)("FLD_PRODUCT_ID") & "'")
                Dim price As Decimal = perfumeData.Rows(0).Field(Of Decimal)("FLD_PRICE")
                Dim quantity As Decimal = x.Field(Of Integer)("FLD_QUANTITY")
                Dim subtotal As Decimal = price * quantity
                grd_table.Rows.Add(New String() {
                               x.Field(Of String)("FLD_PRODUCT_ID"),
                               perfumeData.Rows(0).Field(Of String)("FLD_PRODUCT_NAME"),
                               quantity,
                               Format(price, "0,00"),
                               Format(subtotal, "0.00")
                               })
            Next
            calculate_total()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub calculate_total()
        Dim total As Decimal
        For i As Integer = 0 To grd_table.RowCount - 1
            total += Val(grd_table.Rows(i).Cells("TOTAL").Value)
        Next
        txt_total.Text = Format(total, "RM0.00")
    End Sub

    Private Sub frm_orderview_a180693_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
End Class