<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orders_a180693
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orders_a180693))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_table = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_table2 = New System.Windows.Forms.DataGridView()
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_table2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(349, 27)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(110, 38)
        Me.lbl_title.TabIndex = 8
        Me.lbl_title.Text = "Orders"
        '
        'grd_table
        '
        Me.grd_table.AllowUserToAddRows = False
        Me.grd_table.AllowUserToDeleteRows = False
        Me.grd_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_table.Location = New System.Drawing.Point(38, 89)
        Me.grd_table.Name = "grd_table"
        Me.grd_table.ReadOnly = True
        Me.grd_table.RowHeadersWidth = 51
        Me.grd_table.RowTemplate.Height = 24
        Me.grd_table.Size = New System.Drawing.Size(356, 304)
        Me.grd_table.TabIndex = 7
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(38, 399)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'grd_table2
        '
        Me.grd_table2.AllowUserToAddRows = False
        Me.grd_table2.AllowUserToDeleteRows = False
        Me.grd_table2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_table2.Location = New System.Drawing.Point(417, 89)
        Me.grd_table2.Name = "grd_table2"
        Me.grd_table2.ReadOnly = True
        Me.grd_table2.RowHeadersWidth = 51
        Me.grd_table2.RowTemplate.Height = 24
        Me.grd_table2.Size = New System.Drawing.Size(342, 304)
        Me.grd_table2.TabIndex = 9
        '
        'frm_orders_a180693
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grd_table2)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_table)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_orders_a180693"
        Me.Text = "My Perfume Catalogue: Orders"
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_table2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_table As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents grd_table2 As DataGridView
End Class
