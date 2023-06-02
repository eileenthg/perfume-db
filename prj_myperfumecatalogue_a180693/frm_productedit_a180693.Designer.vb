<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productedit_a180693
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productedit_a180693))
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.lbl_currency = New System.Windows.Forms.Label()
        Me.lbl_unit = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_fragrance = New System.Windows.Forms.ComboBox()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.cmb_brand = New System.Windows.Forms.ComboBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_fragrance = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.pic_perfume = New System.Windows.Forms.PictureBox()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.pic_perfume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(536, 399)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 88
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(445, 399)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_reset.TabIndex = 87
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'lbl_currency
        '
        Me.lbl_currency.AutoSize = True
        Me.lbl_currency.BackColor = System.Drawing.Color.Transparent
        Me.lbl_currency.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currency.Location = New System.Drawing.Point(63, 129)
        Me.lbl_currency.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_currency.Name = "lbl_currency"
        Me.lbl_currency.Size = New System.Drawing.Size(34, 18)
        Me.lbl_currency.TabIndex = 86
        Me.lbl_currency.Text = "RM"
        '
        'lbl_unit
        '
        Me.lbl_unit.AutoSize = True
        Me.lbl_unit.BackColor = System.Drawing.Color.Transparent
        Me.lbl_unit.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unit.Location = New System.Drawing.Point(399, 129)
        Me.lbl_unit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_unit.Name = "lbl_unit"
        Me.lbl_unit.Size = New System.Drawing.Size(31, 18)
        Me.lbl_unit.TabIndex = 85
        Me.lbl_unit.Text = "mL"
        '
        'txt_quantity
        '
        Me.txt_quantity.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(320, 127)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(78, 23)
        Me.txt_quantity.TabIndex = 84
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(97, 128)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(136, 23)
        Me.txt_price.TabIndex = 83
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(320, 98)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(109, 23)
        Me.txt_id.TabIndex = 82
        '
        'cmb_fragrance
        '
        Me.cmb_fragrance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_fragrance.FormattingEnabled = True
        Me.cmb_fragrance.Location = New System.Drawing.Point(100, 227)
        Me.cmb_fragrance.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_fragrance.Name = "cmb_fragrance"
        Me.cmb_fragrance.Size = New System.Drawing.Size(329, 25)
        Me.cmb_fragrance.TabIndex = 81
        '
        'cmb_type
        '
        Me.cmb_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(100, 198)
        Me.cmb_type.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(329, 25)
        Me.cmb_type.TabIndex = 80
        '
        'cmb_brand
        '
        Me.cmb_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_brand.FormattingEnabled = True
        Me.cmb_brand.Location = New System.Drawing.Point(100, 167)
        Me.cmb_brand.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_brand.Name = "cmb_brand"
        Me.cmb_brand.Size = New System.Drawing.Size(329, 25)
        Me.cmb_brand.TabIndex = 78
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(21, 280)
        Me.txt_desc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_desc.Size = New System.Drawing.Size(408, 110)
        Me.txt_desc.TabIndex = 77
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(69, 97)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(164, 23)
        Me.txt_name.TabIndex = 76
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(245, 128)
        Me.lbl_quantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(76, 18)
        Me.lbl_quantity.TabIndex = 75
        Me.lbl_quantity.Text = "Quantity: "
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(17, 169)
        Me.lbl_brand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(56, 18)
        Me.lbl_brand.TabIndex = 74
        Me.lbl_brand.Text = "Brand: "
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(245, 98)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(30, 18)
        Me.lbl_id.TabIndex = 73
        Me.lbl_id.Text = "ID:"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(18, 128)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(50, 18)
        Me.lbl_price.TabIndex = 72
        Me.lbl_price.Text = "Price: "
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desc.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.Location = New System.Drawing.Point(18, 257)
        Me.lbl_desc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(89, 18)
        Me.lbl_desc.TabIndex = 71
        Me.lbl_desc.Text = "Description:"
        '
        'lbl_fragrance
        '
        Me.lbl_fragrance.AutoSize = True
        Me.lbl_fragrance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fragrance.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fragrance.Location = New System.Drawing.Point(18, 228)
        Me.lbl_fragrance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_fragrance.Name = "lbl_fragrance"
        Me.lbl_fragrance.Size = New System.Drawing.Size(84, 18)
        Me.lbl_fragrance.TabIndex = 70
        Me.lbl_fragrance.Text = "Fragrance: "
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(18, 198)
        Me.lbl_type.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(46, 18)
        Me.lbl_type.TabIndex = 69
        Me.lbl_type.Text = "Type:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(18, 99)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(55, 18)
        Me.lbl_name.TabIndex = 68
        Me.lbl_name.Text = "Name: "
        '
        'pic_perfume
        '
        Me.pic_perfume.BackColor = System.Drawing.Color.Transparent
        Me.pic_perfume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_perfume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_perfume.Location = New System.Drawing.Point(445, 98)
        Me.pic_perfume.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_perfume.Name = "pic_perfume"
        Me.pic_perfume.Size = New System.Drawing.Size(166, 223)
        Me.pic_perfume.TabIndex = 67
        Me.pic_perfume.TabStop = False
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instruction.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction.Location = New System.Drawing.Point(17, 53)
        Me.lbl_instruction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(411, 25)
        Me.lbl_instruction.TabIndex = 66
        Me.lbl_instruction.Text = "Fill in the details of the new perfume below:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(239, 9)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(159, 31)
        Me.lbl_title.TabIndex = 65
        Me.lbl_title.Text = "Edit Perfume"
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(22, 399)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 64
        Me.btn_back.Text = "Cancel"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_productedit_a180693
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(628, 435)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.lbl_currency)
        Me.Controls.Add(Me.lbl_unit)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.cmb_fragrance)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.cmb_brand)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.lbl_fragrance)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.pic_perfume)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_productedit_a180693"
        Me.Text = "Edit Perfume"
        CType(Me.pic_perfume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_save As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents lbl_currency As Label
    Friend WithEvents lbl_unit As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_id As MaskedTextBox
    Friend WithEvents cmb_fragrance As ComboBox
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents cmb_brand As ComboBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_desc As Label
    Friend WithEvents lbl_fragrance As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents pic_perfume As PictureBox
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_back As Button
End Class
