<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productdetails_a180693
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productdetails_a180693))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lst_perfume = New System.Windows.Forms.ListBox()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.pic_perfume = New System.Windows.Forms.PictureBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_fragrance = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_fragrance = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        CType(Me.pic_perfume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(209, 19)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(190, 31)
        Me.lbl_title.TabIndex = 11
        Me.lbl_title.Text = "Perfume Details"
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(28, 406)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(56, 19)
        Me.btn_back.TabIndex = 9
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lst_perfume
        '
        Me.lst_perfume.FormattingEnabled = True
        Me.lst_perfume.HorizontalScrollbar = True
        Me.lst_perfume.Location = New System.Drawing.Point(28, 60)
        Me.lst_perfume.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_perfume.Name = "lst_perfume"
        Me.lst_perfume.Size = New System.Drawing.Size(102, 329)
        Me.lst_perfume.TabIndex = 13
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instruction.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction.Location = New System.Drawing.Point(140, 60)
        Me.lbl_instruction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(372, 25)
        Me.lbl_instruction.TabIndex = 14
        Me.lbl_instruction.Text = "Select a perfume from the list to the left"
        '
        'pic_perfume
        '
        Me.pic_perfume.BackColor = System.Drawing.Color.Transparent
        Me.pic_perfume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_perfume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_perfume.Location = New System.Drawing.Point(444, 106)
        Me.pic_perfume.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_perfume.Name = "pic_perfume"
        Me.pic_perfume.Size = New System.Drawing.Size(166, 223)
        Me.pic_perfume.TabIndex = 15
        Me.pic_perfume.TabStop = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(141, 106)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(55, 18)
        Me.lbl_name.TabIndex = 16
        Me.lbl_name.Text = "Name: "
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(141, 167)
        Me.lbl_type.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(46, 18)
        Me.lbl_type.TabIndex = 17
        Me.lbl_type.Text = "Type:"
        '
        'lbl_fragrance
        '
        Me.lbl_fragrance.AutoSize = True
        Me.lbl_fragrance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fragrance.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fragrance.Location = New System.Drawing.Point(141, 197)
        Me.lbl_fragrance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_fragrance.Name = "lbl_fragrance"
        Me.lbl_fragrance.Size = New System.Drawing.Size(84, 18)
        Me.lbl_fragrance.TabIndex = 18
        Me.lbl_fragrance.Text = "Fragrance: "
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desc.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.Location = New System.Drawing.Point(141, 257)
        Me.lbl_desc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(89, 18)
        Me.lbl_desc.TabIndex = 19
        Me.lbl_desc.Text = "Description:"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(458, 368)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(50, 18)
        Me.lbl_price.TabIndex = 20
        Me.lbl_price.Text = "Price: "
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(459, 341)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(30, 18)
        Me.lbl_id.TabIndex = 21
        Me.lbl_id.Text = "ID:"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(141, 227)
        Me.lbl_quantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(76, 18)
        Me.lbl_quantity.TabIndex = 23
        Me.lbl_quantity.Text = "Quantity: "
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(141, 136)
        Me.lbl_brand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(56, 18)
        Me.lbl_brand.TabIndex = 22
        Me.lbl_brand.Text = "Brand: "
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(216, 104)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(198, 23)
        Me.txt_name.TabIndex = 24
        '
        'txt_brand
        '
        Me.txt_brand.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(216, 134)
        Me.txt_brand.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(198, 23)
        Me.txt_brand.TabIndex = 25
        '
        'txt_type
        '
        Me.txt_type.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(216, 164)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(198, 23)
        Me.txt_type.TabIndex = 26
        '
        'txt_fragrance
        '
        Me.txt_fragrance.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_fragrance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fragrance.Location = New System.Drawing.Point(216, 194)
        Me.txt_fragrance.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fragrance.Name = "txt_fragrance"
        Me.txt_fragrance.ReadOnly = True
        Me.txt_fragrance.Size = New System.Drawing.Size(198, 23)
        Me.txt_fragrance.TabIndex = 27
        '
        'txt_quantity
        '
        Me.txt_quantity.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(216, 224)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.ReadOnly = True
        Me.txt_quantity.Size = New System.Drawing.Size(198, 23)
        Me.txt_quantity.TabIndex = 28
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(501, 364)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(87, 23)
        Me.txt_price.TabIndex = 29
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(501, 339)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(87, 22)
        Me.txt_id.TabIndex = 30
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(144, 280)
        Me.txt_desc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.ReadOnly = True
        Me.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_desc.Size = New System.Drawing.Size(270, 110)
        Me.txt_desc.TabIndex = 31
        '
        'frm_productdetails_a180693
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(628, 435)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_fragrance)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_brand)
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
        Me.Controls.Add(Me.lst_perfume)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_productdetails_a180693"
        Me.Text = "My Perfume Catalogue: Perfume Details"
        CType(Me.pic_perfume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lst_perfume As ListBox
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents pic_perfume As PictureBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_fragrance As Label
    Friend WithEvents lbl_desc As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_fragrance As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_desc As TextBox
End Class
