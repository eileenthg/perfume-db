<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffnew_a180693
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staffnew_a180693))
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(115, 59)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(38, 13)
        Me.lbl_name.TabIndex = 53
        Me.lbl_name.Text = "Name:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(9, 59)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(46, 13)
        Me.lbl_id.TabIndex = 52
        Me.lbl_id.Text = "Staff ID:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(118, 75)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(457, 20)
        Me.txt_name.TabIndex = 51
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(208, 9)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(173, 31)
        Me.lbl_title.TabIndex = 54
        Me.lbl_title.Text = "Add New Staff"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(494, 120)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(81, 23)
        Me.btn_save.TabIndex = 56
        Me.btn_save.Text = "Confirm"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(11, 118)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(74, 23)
        Me.btn_cancel.TabIndex = 57
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(409, 120)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(81, 23)
        Me.btn_reset.TabIndex = 59
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(4, 75)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(109, 20)
        Me.txt_id.TabIndex = 60
        '
        'frm_staffnew_a180693
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(595, 152)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_staffnew_a180693"
        Me.Text = "Add New Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents txt_id As MaskedTextBox
End Class
