Module mod_globals_a180693
    Public dbconnect As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_MYPERFUMECATALOGUE_A180693.accdb;Persist Security Info=False"
    Public dbupdate As New OleDb.OleDbConnection(dbconnect)

    Public itemID As String


    Public Function run_sql_query(mysql As String) As DataTable
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, dbconnect)
        Try
            myreader.Fill(mydatatable)
        Catch ex As Exception
            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
        End Try
        Return mydatatable
    End Function
    Public Sub run_sql_command(thissql As String, resultmsg As String)
        Dim mywriter As New OleDb.OleDbCommand(thissql, dbupdate)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            If resultmsg.Length > 0 Then
                MsgBox(resultmsg)
            End If
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub
End Module
