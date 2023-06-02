Public Class frm_staffadmin_a180693
    Private Sub frm_staffadmin_a180693_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_text()
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub frm_staffadmin_a180693_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub refresh_text()
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A180693"
        grd_table.DataSource = run_sql_query(mysql)
        grd_table.ClearSelection()
        grd_table.Columns(0).HeaderText = "Staff ID"
        grd_table.Columns(1).HeaderText = "Name"
        btn_update.Enabled = False
        btn_delete.Enabled = False
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        frm_staffnew_a180693.ShowDialog()
        refresh_text()
    End Sub

    Private Sub grd_table_SelectionChanged(sender As Object, e As EventArgs) Handles grd_table.SelectionChanged
        If grd_table.SelectedRows.Count = 0 Then
            btn_update.Enabled = False
            btn_delete.Enabled = False
            txt_id.Text = ""
            txt_name.Text = ""
            txt_name.ReadOnly = True
        ElseIf grd_table.SelectedRows.Count = 1 Then
            btn_update.Enabled = True
            btn_delete.Enabled = True
            btn_delete.Text = "Delete"
            txt_id.Text = grd_table.SelectedRows(0).Cells(0).Value
            txt_name.Text = grd_table.SelectedRows(0).Cells(1).Value
            txt_name.ReadOnly = False
        ElseIf grd_table.SelectedRows.Count > 1 Then
            btn_update.Enabled = False
            btn_delete.Enabled = True
            btn_delete.Text = "Delete All"
            txt_id.Text = ""
            txt_name.Text = ""
            txt_name.ReadOnly = True
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_name.Text.Length < 1 Then
            MsgBox("Please enter the staff name.")
            Exit Sub
        End If

        run_sql_command("UPDATE TBL_STAFF_A180693 SET FLD_STAFF_NAME = '" & txt_name.Text & "' WHERE FLD_STAFF_ID = '" & txt_id.Text & "'", "Data saved!")
        refresh_text()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If grd_table.SelectedRows.Count = 1 Then
            Dim result As DialogResult = MsgBox("Are you sure you want to delete the staff '" & grd_table.SelectedRows(0).Cells.Item("FLD_STAFF_NAME").Value & "'?", vbYesNo, "Delete Staff")
            If result = vbYes Then
                run_sql_command("DELETE FROM TBL_STAFF_A180693 WHERE FLD_STAFF_ID = '" & grd_table.SelectedRows(0).Cells.Item(0).Value & "'", "Deletion successful.")
                refresh_text()
            End If
        ElseIf grd_table.SelectedRows.Count > 1 Then
            Dim result As DialogResult = MsgBox("Are you sure you want to delete the perfume all selected staff?", vbYesNo, "Delete Staff")
            If result = vbYes Then
                For Each x As DataGridViewRow In grd_table.SelectedRows
                    run_sql_command("DELETE FROM TBL_STAFF_A180693 WHERE FLD_STAFF_ID = '" & x.Cells.Item(0).Value & "'", "")
                Next
                MsgBox("Deletion successful.")
                refresh_text()

            End If
        End If
    End Sub
End Class