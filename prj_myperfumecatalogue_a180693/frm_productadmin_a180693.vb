Public Class frm_productadmin_a180693
    Private Sub frm_productadmin_a180693_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_text()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub frm_productadmin_a180693_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub refresh_text()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A180693"
        grd_table.DataSource = run_sql_query(mysql)
        grd_table.ClearSelection()
        grd_table.Columns(0).HeaderText = "Perfume ID"
        grd_table.Columns(1).HeaderText = "Perfume Name"
        grd_table.Columns(2).HeaderText = "Price"
        grd_table.Columns(3).HeaderText = "Type"
        grd_table.Columns(4).HeaderText = "Fragrance"
        grd_table.Columns(5).HeaderText = "Description"
        grd_table.Columns(6).HeaderText = "Quantity"
        grd_table.Columns(7).HeaderText = "Brand"

        btn_edit.Enabled = False
        btn_delete.Enabled = False
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        frm_productnew_a180693.ShowDialog()
        refresh_text()
    End Sub

    Private Sub grd_table_SelectionChanged(sender As Object, e As EventArgs) Handles grd_table.SelectionChanged
        If grd_table.SelectedRows.Count = 1 Then
            btn_edit.Enabled = True
            btn_delete.Enabled = True
            btn_delete.Text = "Delete"
        ElseIf grd_table.SelectedRows.Count > 1 Then
            btn_edit.Enabled = False
            btn_delete.Enabled = True
            btn_delete.Text = "Delete All"
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        itemID = grd_table.SelectedRows(0).Cells.Item(0).Value
        frm_productedit_a180693.ShowDialog()
        refresh_text()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If grd_table.SelectedRows.Count = 1 Then
            Dim result As DialogResult = MsgBox("Are you sure you want to delete the perfume '" & grd_table.SelectedRows(0).Cells.Item("FLD_PRODUCT_NAME").Value & "'?", vbYesNo, "Delete Perfume")
            If result = vbYes Then
                Dim id = grd_table.SelectedRows(0).Cells.Item(0).Value
                System.IO.File.Delete("pictures/" & id & ".jpg")
                run_sql_command("DELETE FROM TBL_PRODUCTS_A180693 WHERE FLD_PRODUCT_ID = '" & id & "'", "Deletion successful.")
                refresh_text()
            End If
        ElseIf grd_table.SelectedRows.Count > 1 Then
            Dim result As DialogResult = MsgBox("Are you sure you want to delete the perfume all selected perfumes?", vbYesNo, "Delete Perfumes")
            If result = vbYes Then
                For Each x As DataGridViewRow In grd_table.SelectedRows
                    run_sql_command("DELETE FROM TBL_PRODUCTS_A180693 WHERE FLD_PRODUCT_ID = '" & x.Cells.Item(0).Value & "'", "")
                Next
                MsgBox("Deletion successful.")
                refresh_text()

            End If
        End If
    End Sub
End Class