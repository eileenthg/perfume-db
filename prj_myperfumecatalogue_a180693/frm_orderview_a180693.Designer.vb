<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderview_a180693
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderview_a180693))
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_table = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_customer = New System.Windows.Forms.TextBox()
        Me.txt_staff = New System.Windows.Forms.TextBox()
        Me.cmb_id = New System.Windows.Forms.ComboBox()
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(626, 387)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(126, 20)
        Me.txt_total.TabIndex = 80
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(573, 387)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(48, 18)
        Me.lbl_total.TabIndex = 79
        Me.lbl_total.Text = "Total:"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(34, 63)
        Me.lbl_customer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(76, 18)
        Me.lbl_customer.TabIndex = 75
        Me.lbl_customer.Text = "Customer:"
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.Location = New System.Drawing.Point(66, 90)
        Me.lbl_staff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(43, 18)
        Me.lbl_staff.TabIndex = 72
        Me.lbl_staff.Text = "Staff:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(36, 117)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(73, 18)
        Me.lbl_id.TabIndex = 71
        Me.lbl_id.Text = "Order ID:"
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.Location = New System.Drawing.Point(27, 148)
        Me.lbl_order.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(176, 25)
        Me.lbl_order.TabIndex = 69
        Me.lbl_order.Text = "Selected perfumes:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(326, 12)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(151, 31)
        Me.lbl_title.TabIndex = 68
        Me.lbl_title.Text = "View Orders"
        '
        'grd_table
        '
        Me.grd_table.AllowUserToAddRows = False
        Me.grd_table.AllowUserToDeleteRows = False
        Me.grd_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_table.Location = New System.Drawing.Point(32, 175)
        Me.grd_table.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_table.Name = "grd_table"
        Me.grd_table.ReadOnly = True
        Me.grd_table.RowHeadersWidth = 51
        Me.grd_table.RowTemplate.Height = 24
        Me.grd_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_table.Size = New System.Drawing.Size(725, 204)
        Me.grd_table.TabIndex = 67
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(9, 422)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(56, 19)
        Me.btn_back.TabIndex = 66
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_customer
        '
        Me.txt_customer.Location = New System.Drawing.Point(115, 64)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.ReadOnly = True
        Me.txt_customer.Size = New System.Drawing.Size(642, 20)
        Me.txt_customer.TabIndex = 81
        '
        'txt_staff
        '
        Me.txt_staff.Location = New System.Drawing.Point(115, 91)
        Me.txt_staff.Name = "txt_staff"
        Me.txt_staff.ReadOnly = True
        Me.txt_staff.Size = New System.Drawing.Size(642, 20)
        Me.txt_staff.TabIndex = 82
        '
        'cmb_id
        '
        Me.cmb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_id.FormattingEnabled = True
        Me.cmb_id.Location = New System.Drawing.Point(114, 117)
        Me.cmb_id.Name = "cmb_id"
        Me.cmb_id.Size = New System.Drawing.Size(121, 21)
        Me.cmb_id.TabIndex = 83
        '
        'frm_orderview_a180693
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmb_id)
        Me.Controls.Add(Me.txt_staff)
        Me.Controls.Add(Me.txt_customer)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_order)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_table)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_orderview_a180693"
        Me.Text = "View Orders"
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_total As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_customer As Label
    Friend WithEvents lbl_staff As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_order As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_table As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_customer As TextBox
    Friend WithEvents txt_staff As TextBox
    Friend WithEvents cmb_id As ComboBox
End Class
