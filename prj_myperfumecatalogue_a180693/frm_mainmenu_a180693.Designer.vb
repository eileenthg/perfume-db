<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mainmenu_a180693
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_a180693))
        Me.btn_product = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.pic_title = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_perfumedetail = New System.Windows.Forms.Button()
        Me.btn_editstaff = New System.Windows.Forms.Button()
        Me.btn_editcustomer = New System.Windows.Forms.Button()
        Me.btn_editproduct = New System.Windows.Forms.Button()
        Me.btn_dummy = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_neworder = New System.Windows.Forms.Button()
        Me.btn_vieworder = New System.Windows.Forms.Button()
        CType(Me.pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_product
        '
        Me.btn_product.Location = New System.Drawing.Point(170, 324)
        Me.btn_product.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(137, 19)
        Me.btn_product.TabIndex = 1
        Me.btn_product.Text = "View Perfume List"
        Me.btn_product.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.Location = New System.Drawing.Point(170, 348)
        Me.btn_customer.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(137, 19)
        Me.btn_customer.TabIndex = 2
        Me.btn_customer.Text = "View Customer List"
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_staff
        '
        Me.btn_staff.Location = New System.Drawing.Point(170, 371)
        Me.btn_staff.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(137, 19)
        Me.btn_staff.TabIndex = 3
        Me.btn_staff.Text = "View Staff List"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.Location = New System.Drawing.Point(171, 417)
        Me.btn_order.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(273, 21)
        Me.btn_order.TabIndex = 4
        Me.btn_order.Text = "Order Table (Debug)"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'pic_title
        '
        Me.pic_title.BackColor = System.Drawing.Color.Transparent
        Me.pic_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_title.ImageLocation = ""
        Me.pic_title.InitialImage = Nothing
        Me.pic_title.Location = New System.Drawing.Point(170, 10)
        Me.pic_title.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_title.Name = "pic_title"
        Me.pic_title.Size = New System.Drawing.Size(273, 220)
        Me.pic_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic_title.TabIndex = 0
        Me.pic_title.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(111, 232)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(416, 54)
        Me.lbl_title.TabIndex = 5
        Me.lbl_title.Text = "Management System"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_perfumedetail
        '
        Me.btn_perfumedetail.Location = New System.Drawing.Point(170, 300)
        Me.btn_perfumedetail.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_perfumedetail.Name = "btn_perfumedetail"
        Me.btn_perfumedetail.Size = New System.Drawing.Size(273, 19)
        Me.btn_perfumedetail.TabIndex = 9
        Me.btn_perfumedetail.Text = "View Pefumes"
        Me.btn_perfumedetail.UseVisualStyleBackColor = True
        '
        'btn_editstaff
        '
        Me.btn_editstaff.Location = New System.Drawing.Point(311, 371)
        Me.btn_editstaff.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_editstaff.Name = "btn_editstaff"
        Me.btn_editstaff.Size = New System.Drawing.Size(133, 19)
        Me.btn_editstaff.TabIndex = 8
        Me.btn_editstaff.Text = "Edit Staff"
        Me.btn_editstaff.UseVisualStyleBackColor = True
        '
        'btn_editcustomer
        '
        Me.btn_editcustomer.Location = New System.Drawing.Point(311, 348)
        Me.btn_editcustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_editcustomer.Name = "btn_editcustomer"
        Me.btn_editcustomer.Size = New System.Drawing.Size(133, 19)
        Me.btn_editcustomer.TabIndex = 7
        Me.btn_editcustomer.Text = "Edit Customers"
        Me.btn_editcustomer.UseVisualStyleBackColor = True
        '
        'btn_editproduct
        '
        Me.btn_editproduct.Location = New System.Drawing.Point(311, 324)
        Me.btn_editproduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_editproduct.Name = "btn_editproduct"
        Me.btn_editproduct.Size = New System.Drawing.Size(133, 19)
        Me.btn_editproduct.TabIndex = 6
        Me.btn_editproduct.Text = "Edit Perfumes"
        Me.btn_editproduct.UseVisualStyleBackColor = True
        '
        'btn_dummy
        '
        Me.btn_dummy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dummy.Location = New System.Drawing.Point(0, 0)
        Me.btn_dummy.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_dummy.Name = "btn_dummy"
        Me.btn_dummy.Size = New System.Drawing.Size(1, 1)
        Me.btn_dummy.TabIndex = 10
        Me.btn_dummy.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(290, 453)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(56, 19)
        Me.btn_exit.TabIndex = 11
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_neworder
        '
        Me.btn_neworder.Location = New System.Drawing.Point(310, 394)
        Me.btn_neworder.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_neworder.Name = "btn_neworder"
        Me.btn_neworder.Size = New System.Drawing.Size(133, 19)
        Me.btn_neworder.TabIndex = 13
        Me.btn_neworder.Text = "Make New Order"
        Me.btn_neworder.UseVisualStyleBackColor = True
        '
        'btn_vieworder
        '
        Me.btn_vieworder.Location = New System.Drawing.Point(169, 394)
        Me.btn_vieworder.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_vieworder.Name = "btn_vieworder"
        Me.btn_vieworder.Size = New System.Drawing.Size(137, 19)
        Me.btn_vieworder.TabIndex = 12
        Me.btn_vieworder.Text = "View Orders"
        Me.btn_vieworder.UseVisualStyleBackColor = True
        '
        'frm_mainmenu_a180693
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(600, 489)
        Me.Controls.Add(Me.btn_neworder)
        Me.Controls.Add(Me.btn_vieworder)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_dummy)
        Me.Controls.Add(Me.btn_perfumedetail)
        Me.Controls.Add(Me.btn_editstaff)
        Me.Controls.Add(Me.btn_editcustomer)
        Me.Controls.Add(Me.btn_editproduct)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_product)
        Me.Controls.Add(Me.pic_title)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_mainmenu_a180693"
        Me.Text = "My Perfume Catalogue"
        CType(Me.pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_product As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents pic_title As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_editstaff As Button
    Friend WithEvents btn_editcustomer As Button
    Friend WithEvents btn_editproduct As Button
    Friend WithEvents btn_perfumedetail As Button
    Friend WithEvents btn_dummy As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_neworder As Button
    Friend WithEvents btn_vieworder As Button
End Class
