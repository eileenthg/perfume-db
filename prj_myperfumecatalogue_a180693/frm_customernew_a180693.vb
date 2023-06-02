Public Class frm_customernew_a180693
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_id.Text.Length < 4 Then
            Beep()
            MsgBox("Invalid customer ID." & vbCrLf & vbCrLf & "Please ensure the customer ID is in the format 'C000'")
            Exit Sub
        ElseIf txt_name.Text.Length < 1 Then
            Beep()
            MsgBox("Please enter customer name.")
            Exit Sub
        End If
        run_sql_command("INSERT INTO TBL_CUSTOMER_A180693" &
                        " (FLD_CUSTOMER_ID, FLD_CUSTOMER_NAME) VALUES" &
                        " ('" & txt_id.Text & "', '" & txt_name.Text & "')", "Data saved!")
        Me.Close()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        refresh_text()
    End Sub

    Private Sub refresh_text()
        Dim last As Object = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A180693").Rows(0).Item("LASTID")
        Dim nextnum As Integer = 1
        If Not IsDBNull(last) Then
            Dim lastid As String = last
            nextnum = Mid(lastid, 2) + 1
        End If
        txt_id.Text = Format(nextnum, "C00#")

        txt_name.Text = ""
    End Sub

    Private Sub frm_staffnew_a180693_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id.Mask = "C000"
        refresh_text()
    End Sub
End Class