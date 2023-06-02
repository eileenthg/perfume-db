Imports System.Text.RegularExpressions

Public Class frm_productedit_a180693
    Dim aPrice As Regex = New Regex("\d+(\.?\d+|)")
    Dim anInteger As Regex = New Regex("\d*")

    Private Sub frm_productedit_a180693_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id.Mask = "P000"
        refresh_text()
    End Sub

    Private Sub refresh_text()

        Dim data = run_sql_query("SELECT * FROM TBL_PRODUCTS_A180693 WHERE FLD_PRODUCT_ID = '" & itemID & "'")

        cmb_brand.DataSource = run_sql_query("SELECT FLD_BRAND FROM TBL_PRODUCTS_A180693 GROUP BY FLD_BRAND")
        cmb_brand.DisplayMember = "FLD_BRAND"
        cmb_brand.Text = data.Rows(0).Item("FLD_BRAND")

        cmb_fragrance.DataSource = run_sql_query("SELECT FLD_FRAGRANCE FROM TBL_PRODUCTS_A180693 GROUP BY FLD_FRAGRANCE")
        cmb_fragrance.DisplayMember = "FLD_FRAGRANCE"
        cmb_fragrance.Text = data.Rows(0).Item("FLD_FRAGRANCE")

        cmb_type.DataSource = run_sql_query("SELECT FLD_TYPE FROM TBL_PRODUCTS_A180693 GROUP BY FLD_TYPE")
        cmb_type.DisplayMember = "FLD_TYPE"
        cmb_type.Text = data.Rows(0).Item("FLD_TYPE")

        txt_id.Text = itemID
        Try
            pic_perfume.BackgroundImage = Image.FromFile("pictures/" & itemID & ".jpg")

        Catch
            pic_perfume.BackgroundImage = Image.FromFile("assets/default.jpg")
        End Try

        txt_desc.Text = data.Rows(0).Item("FLD_DESCRIPTION")
        txt_name.Text = data.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = data.Rows(0).Item("FLD_PRICE")
        txt_quantity.Text = data.Rows(0).Item("FLD_QUANTITY")

    End Sub

    Private Sub txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_price.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_price_LostFocus(sender As Object, e As EventArgs) Handles txt_price.LostFocus
        txt_price.Text = aPrice.Match(txt_price.Text).Value
    End Sub

    Private Sub txt_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_quantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_quantity_LostFocus(sender As Object, e As EventArgs) Handles txt_quantity.LostFocus
        txt_quantity.Text = anInteger.Match(txt_quantity.Text).Value
    End Sub

    Private Sub frm_productedit_a180693_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        txt_price.Text = aPrice.Match(txt_price.Text).Value
        txt_quantity.Text = anInteger.Match(txt_quantity.Text).Value
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        itemID = ""
        Me.Close()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        refresh_text()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not String.Equals(txt_id.Text, itemID) Then
            Beep()
            MsgBox("Invalid perfume ID." & vbCrLf & vbCrLf & "Please ensure the perfume ID is in the format 'P000'")
            Exit Sub
        ElseIf txt_name.Text.Length < 1 Then
            Beep()
            MsgBox("Please name your perfume.")
            Exit Sub
        End If

        If txt_price.Text.Length < 1 Then
            txt_price.Text = "0"
        End If

        If txt_quantity.Text.Length < 1 Then
            txt_quantity.Text = "0"
        End If

        Dim mysql As String = "UPDATE TBL_PRODUCTS_A180693 SET" &
            " FLD_PRODUCT_NAME = '" & txt_name.Text & "'," &
            " FLD_PRICE = '" & txt_price.Text & "'," &
            " FLD_TYPE = '" & cmb_type.Text & "'," &
            "FLD_FRAGRANCE = '" & cmb_fragrance.Text & "'," &
            " FLD_DESCRIPTION = '" & txt_desc.Text & "'," &
            " FLD_QUANTITY = '" & txt_quantity.Text & "'," &
            " FLD_BRAND = '" & cmb_brand.Text & "'" &
            " WHERE FLD_PRODUCT_ID ='" & itemID & "'"


        Dim mywriter As New OleDb.OleDbCommand(mysql, dbupdate)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            MsgBox("Data saved!")
            itemID = ""
            Me.Close()
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)


            mywriter.Connection.Close()
        End Try
    End Sub


End Class