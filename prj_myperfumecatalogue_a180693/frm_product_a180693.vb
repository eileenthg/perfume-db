﻿Public Class frm_product_a180693

    Private Sub frm_product_a180693_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub frm_product_a180693_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A180693"
        grd_table.DataSource = run_sql_query(mysql)
    End Sub

    Private Sub frm_product_a180693_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        refresh_grid()
    End Sub
End Class