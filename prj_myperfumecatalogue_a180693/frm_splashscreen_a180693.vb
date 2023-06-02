

Public Class frm_splashscreen_a180693
    Private Sub frm_splashscreen_a180693_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pic_title.BackgroundImage = Image.FromFile("assets/Title (Small) (Custom).png")
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        frm_mainmenu_a180693.Show()
        Me.Hide()
    End Sub
End Class