<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ordernew_a180693
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ordernew_a180693))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_table = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_add = New System.Windows.Forms.Label()
        Me.cmb_perfume = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Location = New System.Drawing.Point(34, 491)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 44
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.Location = New System.Drawing.Point(29, 255)
        Me.lbl_order.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(176, 25)
        Me.lbl_order.TabIndex = 43
        Me.lbl_order.Text = "Selected perfumes:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(323, 9)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(181, 31)
        Me.lbl_title.TabIndex = 41
        Me.lbl_title.Text = "Make an Order"
        '
        'grd_table
        '
        Me.grd_table.AllowUserToAddRows = False
        Me.grd_table.AllowUserToDeleteRows = False
        Me.grd_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_table.Location = New System.Drawing.Point(34, 282)
        Me.grd_table.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_table.Name = "grd_table"
        Me.grd_table.ReadOnly = True
        Me.grd_table.RowHeadersWidth = 51
        Me.grd_table.RowTemplate.Height = 24
        Me.grd_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_table.Size = New System.Drawing.Size(725, 204)
        Me.grd_table.TabIndex = 40
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(11, 529)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(56, 19)
        Me.btn_back.TabIndex = 39
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(33, 114)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(73, 18)
        Me.lbl_id.TabIndex = 46
        Me.lbl_id.Text = "Order ID:"
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.Location = New System.Drawing.Point(63, 87)
        Me.lbl_staff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(43, 18)
        Me.lbl_staff.TabIndex = 47
        Me.lbl_staff.Text = "Staff:"
        '
        'btn_order
        '
        Me.btn_order.Location = New System.Drawing.Point(733, 529)
        Me.btn_order.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(56, 19)
        Me.btn_order.TabIndex = 48
        Me.btn_order.Text = "Order"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'cmb_staff
        '
        Me.cmb_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(112, 87)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(642, 21)
        Me.cmb_staff.TabIndex = 49
        '
        'cmb_customer
        '
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(112, 60)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(642, 21)
        Me.cmb_customer.TabIndex = 51
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(31, 60)
        Me.lbl_customer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(76, 18)
        Me.lbl_customer.TabIndex = 50
        Me.lbl_customer.Text = "Customer:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(112, 114)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 52
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(673, 529)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(56, 19)
        Me.btn_reset.TabIndex = 53
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(628, 494)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(126, 20)
        Me.txt_total.TabIndex = 55
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(575, 494)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(48, 18)
        Me.lbl_total.TabIndex = 54
        Me.lbl_total.Text = "Total:"
        '
        'lbl_add
        '
        Me.lbl_add.AutoSize = True
        Me.lbl_add.BackColor = System.Drawing.Color.Transparent
        Me.lbl_add.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_add.Location = New System.Drawing.Point(29, 153)
        Me.lbl_add.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_add.Name = "lbl_add"
        Me.lbl_add.Size = New System.Drawing.Size(151, 25)
        Me.lbl_add.TabIndex = 56
        Me.lbl_add.Text = "Pick a perfume:"
        '
        'cmb_perfume
        '
        Me.cmb_perfume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_perfume.FormattingEnabled = True
        Me.cmb_perfume.Location = New System.Drawing.Point(34, 199)
        Me.cmb_perfume.Name = "cmb_perfume"
        Me.cmb_perfume.Size = New System.Drawing.Size(393, 21)
        Me.cmb_perfume.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Perfume name:"
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_qty.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty.Location = New System.Drawing.Point(429, 178)
        Me.lbl_qty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(72, 18)
        Me.lbl_qty.TabIndex = 59
        Me.lbl_qty.Text = "Quantity:"
        '
        'txt_quantity
        '
        Me.txt_quantity.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(432, 199)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(78, 23)
        Me.txt_quantity.TabIndex = 60
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(511, 178)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(79, 18)
        Me.lbl_price.TabIndex = 61
        Me.lbl_price.Text = "Unit price:"
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.SystemColors.Control
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(514, 199)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(111, 23)
        Me.txt_price.TabIndex = 62
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtotal.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(627, 178)
        Me.lbl_subtotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(67, 18)
        Me.lbl_subtotal.TabIndex = 63
        Me.lbl_subtotal.Text = "Subtotal:"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BackColor = System.Drawing.SystemColors.Control
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(630, 199)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(126, 23)
        Me.txt_subtotal.TabIndex = 64
        '
        'btn_add
        '
        Me.btn_add.Enabled = False
        Me.btn_add.Location = New System.Drawing.Point(681, 227)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 65
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'frm_ordernew_a180693
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 562)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.lbl_subtotal)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.lbl_qty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_perfume)
        Me.Controls.Add(Me.lbl_add)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.cmb_customer)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.cmb_staff)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.lbl_order)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_table)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_ordernew_a180693"
        Me.Text = "Make an Order"
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_delete As Button
    Friend WithEvents lbl_order As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_table As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_staff As Label
    Friend WithEvents btn_order As Button
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents lbl_customer As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents txt_total As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_add As Label
    Friend WithEvents cmb_perfume As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_qty As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents btn_add As Button
End Class
