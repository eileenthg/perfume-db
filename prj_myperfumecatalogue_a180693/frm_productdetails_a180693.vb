Public Class frm_productdetails_a180693
    Private Sub frm_productdetails_a180693_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_text()
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub frm_productdetails_a180693_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub


    Private Sub refresh_details(id As String)
        Dim product = run_sql_query("SELECT * FROM TBL_PRODUCTS_A180693 WHERE FLD_PRODUCT_ID='" & id & "'")
        txt_id.Text = product.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = product.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = "RM" & product.Rows(0).Item("FLD_PRICE")
        txt_type.Text = product.Rows(0).Item("FLD_TYPE")
        txt_fragrance.Text = product.Rows(0).Item("FLD_FRAGRANCE")
        txt_desc.Text = product.Rows(0).Item("FLD_DESCRIPTION")
        txt_quantity.Text = product.Rows(0).Item("FLD_QUANTITY") & "mL"
        txt_brand.Text = product.Rows(0).Item("FLD_BRAND")

        Try
            pic_perfume.BackgroundImage = Image.FromFile("pictures/" & id & ".jpg")

        Catch
            pic_perfume.BackgroundImage = Image.FromFile("assets/default.jpg")
        End Try

    End Sub

    Private Sub refresh_text()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A180693"
        lst_perfume.DataSource = run_sql_query(mysql)
        lst_perfume.DisplayMember = "FLD_PRODUCT_NAME"
        lst_perfume.ValueMember = "FLD_PRODUCT_ID"
        lst_perfume.SelectedIndex = -1

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_type.Text = ""
        txt_fragrance.Text = ""
        txt_desc.Text = ""
        txt_quantity.Text = ""
        txt_brand.Text = ""

        pic_perfume.BackgroundImage = Nothing
    End Sub

    Private Sub lst_perfume_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_perfume.SelectedIndexChanged
        Try
            refresh_details(lst_perfume.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_productdetails_a180693_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        refresh_text()
    End Sub
End Class