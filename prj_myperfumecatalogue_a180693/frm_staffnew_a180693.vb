Public Class frm_staffnew_a180693


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_id.Text.Length < 4 Then
            Beep()
            MsgBox("Invalid staff ID." & vbCrLf & vbCrLf & "Please ensure the staff ID is in the format 'S000'")
            Exit Sub
        ElseIf txt_name.Text.Length < 1 Then
            Beep()
            MsgBox("Please enter staff name.")
            Exit Sub
        End If
        run_sql_command("INSERT INTO TBL_STAFF_A180693" &
                        " (FLD_STAFF_ID, FLD_STAFF_NAME) VALUES" &
                        " ('" & txt_id.Text & "', '" & txt_name.Text & "')", "Data saved!")
        Me.Close()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        refresh_text()
    End Sub

    Private Sub refresh_text()
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A180693").Rows(0).Item("LASTID")
        Dim nextnum As Integer = Mid(lastid, 2) + 1
        txt_id.Text = Format(nextnum, "S00#")

        txt_name.Text = ""
    End Sub

    Private Sub frm_staffnew_a180693_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id.Mask = "S000"
        refresh_text()
    End Sub
End Class