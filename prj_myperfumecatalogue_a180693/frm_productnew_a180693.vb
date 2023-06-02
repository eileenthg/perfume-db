Imports System.Text.RegularExpressions

Public Class frm_productnew_a180693
    Dim aPrice As Regex = New Regex("\d+(\.?\d+|)")
    Dim anInteger As Regex = New Regex("\d*")
    Dim imagePath As String = ""
    Private Sub frm_productnew_a180693_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id.Mask = "P000"
        refresh_text()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'frm_mainmenu_a180693.Show()
        'Me.Hide()
        Me.Close()
    End Sub

    Private Sub refresh_text()

        cmb_brand.DataSource = run_sql_query("SELECT FLD_BRAND FROM TBL_PRODUCTS_A180693 GROUP BY FLD_BRAND")
        cmb_brand.DisplayMember = "FLD_BRAND"
        cmb_brand.Text = ""

        cmb_fragrance.DataSource = run_sql_query("SELECT FLD_FRAGRANCE FROM TBL_PRODUCTS_A180693 GROUP BY FLD_FRAGRANCE")
        cmb_fragrance.DisplayMember = "FLD_FRAGRANCE"
        cmb_fragrance.Text = ""

        cmb_type.DataSource = run_sql_query("SELECT FLD_TYPE FROM TBL_PRODUCTS_A180693 GROUP BY FLD_TYPE")
        cmb_type.DisplayMember = "FLD_TYPE"
        cmb_type.Text = ""

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A180693").Rows(0).Item("LASTID")
        Dim nextnum As Integer = Mid(lastid, 2) + 1
        txt_id.Text = Format(nextnum, "P00#")

        pic_perfume.BackgroundImage = Image.FromFile("assets\default.jpg")

        txt_desc.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_quantity.Text = ""

    End Sub

    Private Sub txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_price.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_price_LostFocus(sender As Object, e As EventArgs) Handles txt_price.LostFocus
        txt_price.Text = aPrice.Match(txt_price.Text).Value
    End Sub

    Private Sub frm_productnew_a180693_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        txt_price.Text = aPrice.Match(txt_price.Text).Value
        txt_quantity.Text = anInteger.Match(txt_quantity.Text).Value
    End Sub

    Private Sub btn_pickimage_Click(sender As Object, e As EventArgs) Handles btn_pickimage.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        If Not String.IsNullOrEmpty(OpenFileDialog1.FileName) Then
            Try
                pic_perfume.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                imagePath = OpenFileDialog1.FileName
            Catch ex As Exception
                Beep()
                MsgBox("Error opening image." & vbCrLf & vbCrLf & "Please make sure the image format is correct, and the image is not corrupted.")
            End Try

        End If

    End Sub

    Private Sub txt_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_quantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_quantity_LostFocus(sender As Object, e As EventArgs) Handles txt_quantity.LostFocus
        txt_quantity.Text = anInteger.Match(txt_quantity.Text).Value
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        refresh_text()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_id.Text.Length < 4 Then
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

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A180693" &
            " (FLD_PRODUCT_ID, FLD_PRODUCT_NAME, FLD_PRICE, FLD_TYPE, FLD_FRAGRANCE, FLD_DESCRIPTION, FLD_QUANTITY, FLD_BRAND) VALUES" &
            " ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "', '" & cmb_type.Text & "', '" & cmb_fragrance.Text & "', '" & txt_desc.Text & "', '" & txt_quantity.Text & "', '" & cmb_brand.Text & "')"


        Dim mywriter As New OleDb.OleDbCommand(mysql, dbupdate)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            If Not String.IsNullOrEmpty(imagePath) Then
                My.Computer.FileSystem.CopyFile(imagePath, "pictures\" & txt_id.Text & ".jpg")
            End If

            MsgBox("Data saved!")
            refresh_text()
        Catch ex As Exception
            Beep()
            If String.Equals(ex.Message, "The changes you requested to the table were not successful because they would create duplicate values in the index, primary key, or relationship. Change the data in the field or fields that contain duplicate data, remove the index, or redefine the index to permit duplicate entries and try again.") Then
                Dim data As DataTable = run_sql_query("SELECT * FROM TBL_PRODUCTS_A180693 WHERE FLD_PRODUCT_ID = '" & txt_id.Text & "'")
                MsgBox("Perfume ID already exists." & vbCrLf & vbCrLf & data.Rows(0).Item("FLD_PRODUCT_NAME") & " from " & data.Rows(0).Item("FLD_BRAND"))
            Else
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            End If

            mywriter.Connection.Close()
        End Try

    End Sub
End Class