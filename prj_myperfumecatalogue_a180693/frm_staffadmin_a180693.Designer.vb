<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_staffadmin_a180693
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staffadmin_a180693))
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_table = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Enabled = False
        Me.btn_update.Location = New System.Drawing.Point(623, 352)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 45
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Location = New System.Drawing.Point(704, 352)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 44
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instruction.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction.Location = New System.Drawing.Point(49, 46)
        Me.lbl_instruction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(314, 25)
        Me.lbl_instruction.TabIndex = 43
        Me.lbl_instruction.Text = "Select a staff from the list below: "
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(54, 381)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(125, 23)
        Me.btn_new.TabIndex = 42
        Me.btn_new.Text = "Add New Staff..."
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(283, 10)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(260, 31)
        Me.lbl_title.TabIndex = 41
        Me.lbl_title.Text = "Staff Database: Admin"
        '
        'grd_table
        '
        Me.grd_table.AllowUserToAddRows = False
        Me.grd_table.AllowUserToDeleteRows = False
        Me.grd_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_table.Location = New System.Drawing.Point(54, 73)
        Me.grd_table.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_table.Name = "grd_table"
        Me.grd_table.ReadOnly = True
        Me.grd_table.RowHeadersWidth = 51
        Me.grd_table.RowTemplate.Height = 24
        Me.grd_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_table.Size = New System.Drawing.Size(725, 254)
        Me.grd_table.TabIndex = 40
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(21, 421)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(56, 19)
        Me.btn_back.TabIndex = 39
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(54, 352)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 46
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(160, 352)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(457, 20)
        Me.txt_name.TabIndex = 47
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(51, 336)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(46, 13)
        Me.lbl_id.TabIndex = 48
        Me.lbl_id.Text = "Staff ID:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(157, 336)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(38, 13)
        Me.lbl_name.TabIndex = 49
        Me.lbl_name.Text = "Name:"
        '
        'frm_staffadmin_a180693
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_table)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_staffadmin_a180693"
        Me.Text = "Staff Database: Admin"
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents btn_new As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_table As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
End Class
