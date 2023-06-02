Public Class frm_mainmenu_a180693
    Private Sub frm_mainmenu_a180693_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pic_title.BackgroundImage = Image.FromFile("assets/Title (Small) (Custom).png")
        btn_dummy.Select()
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_product_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customer_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_orders_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub frm_mainmenu_a180693_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub btn_perfumedetail_Click(sender As Object, e As EventArgs) Handles btn_perfumedetail.Click
        frm_productdetails_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub btn_editproduct_Click(sender As Object, e As EventArgs) Handles btn_editproduct.Click
        frm_productadmin_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub btn_editcustomer_Click(sender As Object, e As EventArgs) Handles btn_editcustomer.Click
        frm_customeradmin_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub btn_editstaff_Click(sender As Object, e As EventArgs) Handles btn_editstaff.Click
        frm_staffadmin_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_dummy.Click

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click
        frm_orderview_a180693.Show()
        Me.Hide()
    End Sub

    Private Sub btn_neworder_Click(sender As Object, e As EventArgs) Handles btn_neworder.Click
        frm_ordernew_a180693.Show()
        Me.Hide()
    End Sub
End Class
