<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productadmin_a180693
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productadmin_a180693))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_table = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(273, 9)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(304, 31)
        Me.lbl_title.TabIndex = 11
        Me.lbl_title.Text = "Perfume Database: Admin"
        '
        'grd_table
        '
        Me.grd_table.AllowUserToAddRows = False
        Me.grd_table.AllowUserToDeleteRows = False
        Me.grd_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_table.Location = New System.Drawing.Point(44, 72)
        Me.grd_table.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_table.Name = "grd_table"
        Me.grd_table.ReadOnly = True
        Me.grd_table.RowHeadersWidth = 51
        Me.grd_table.RowTemplate.Height = 24
        Me.grd_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_table.Size = New System.Drawing.Size(725, 304)
        Me.grd_table.TabIndex = 10
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(11, 420)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(56, 19)
        Me.btn_back.TabIndex = 9
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(44, 380)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(125, 23)
        Me.btn_new.TabIndex = 12
        Me.btn_new.Text = "Add New Perfume..."
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instruction.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction.Location = New System.Drawing.Point(39, 45)
        Me.lbl_instruction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(347, 25)
        Me.lbl_instruction.TabIndex = 36
        Me.lbl_instruction.Text = "Select a perfume from the list below: "
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Location = New System.Drawing.Point(694, 380)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 37
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Enabled = False
        Me.btn_edit.Location = New System.Drawing.Point(613, 381)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 38
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'frm_productadmin_a180693
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_table)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_productadmin_a180693"
        Me.Text = "My Perfume Catalogue: Edit perfumes"
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_table As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
End Class
