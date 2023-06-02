<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customernew_a180693
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customernew_a180693))
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(21, 145)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(99, 28)
        Me.btn_cancel.TabIndex = 64
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(665, 148)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(108, 28)
        Me.btn_save.TabIndex = 63
        Me.btn_save.Text = "Confirm"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(255, 11)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(279, 38)
        Me.lbl_title.TabIndex = 62
        Me.lbl_title.Text = "Add New Customer"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(160, 73)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(49, 17)
        Me.lbl_name.TabIndex = 61
        Me.lbl_name.Text = "Name:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(19, 73)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(89, 17)
        Me.lbl_id.TabIndex = 60
        Me.lbl_id.Text = "Customer ID:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(164, 92)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(608, 22)
        Me.txt_name.TabIndex = 59
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(552, 145)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(108, 28)
        Me.btn_reset.TabIndex = 65
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(12, 91)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(144, 23)
        Me.txt_id.TabIndex = 66
        '
        'frm_customernew_a180693
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(793, 187)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frm_customernew_a180693"
        Me.Text = "Add New Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents txt_id As MaskedTextBox
End Class
