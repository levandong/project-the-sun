<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlDGVLoaiSanPham
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSoDong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvLoaiSanPham = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colMaLoaiSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLoaiSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoTa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsLoaiSanPham = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvLoaiSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoaiSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoDong, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 284)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(663, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblSoDong
        '
        Me.lblSoDong.Name = "lblSoDong"
        Me.lblSoDong.Size = New System.Drawing.Size(38, 22)
        Me.lblSoDong.Text = "0 loại."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'dgvLoaiSanPham
        '
        Me.dgvLoaiSanPham.AllowUserToAddRows = False
        Me.dgvLoaiSanPham.AllowUserToDeleteRows = False
        Me.dgvLoaiSanPham.AllowUserToResizeRows = False
        Me.dgvLoaiSanPham.AutoGenerateColumns = False
        Me.dgvLoaiSanPham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.Chon, Me.colMaLoaiSanPham, Me.TenLoaiSanPham, Me.MoTa})
        Me.dgvLoaiSanPham.DataSource = Me.bsLoaiSanPham
        Me.dgvLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLoaiSanPham.Location = New System.Drawing.Point(0, 0)
        Me.dgvLoaiSanPham.Name = "dgvLoaiSanPham"
        Me.dgvLoaiSanPham.RowHeadersWidth = 10
        Me.dgvLoaiSanPham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLoaiSanPham.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLoaiSanPham.Size = New System.Drawing.Size(663, 284)
        Me.dgvLoaiSanPham.TabIndex = 2
        Me.dgvLoaiSanPham.VirtualMode = True
        '
        'STT
        '
        Me.STT.DataPropertyName = "STT"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STT.DefaultCellStyle = DataGridViewCellStyle1
        Me.STT.Frozen = True
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 40
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.MinimumWidth = 40
        Me.Chon.Name = "Chon"
        Me.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chon.Visible = False
        Me.Chon.Width = 40
        '
        'colMaLoaiSanPham
        '
        Me.colMaLoaiSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMaLoaiSanPham.DataPropertyName = "MaLoaiSanPham"
        Me.colMaLoaiSanPham.HeaderText = "Mã loại"
        Me.colMaLoaiSanPham.Name = "colMaLoaiSanPham"
        Me.colMaLoaiSanPham.ReadOnly = True
        Me.colMaLoaiSanPham.Width = 75
        '
        'TenLoaiSanPham
        '
        Me.TenLoaiSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenLoaiSanPham.DataPropertyName = "TenLoaiSanPham"
        Me.TenLoaiSanPham.HeaderText = "Tên loại"
        Me.TenLoaiSanPham.Name = "TenLoaiSanPham"
        Me.TenLoaiSanPham.ReadOnly = True
        Me.TenLoaiSanPham.Width = 78
        '
        'MoTa
        '
        Me.MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MoTa.DataPropertyName = "MoTa"
        Me.MoTa.HeaderText = "Mô tả"
        Me.MoTa.MinimumWidth = 100
        Me.MoTa.Name = "MoTa"
        Me.MoTa.ReadOnly = True
        '
        'bsLoaiSanPham
        '
        Me.bsLoaiSanPham.DataSource = GetType(PhanMemBanHang.tbLoaiSanPham)
        '
        'ctrlDGVLoaiSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvLoaiSanPham)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlDGVLoaiSanPham"
        Me.Size = New System.Drawing.Size(663, 309)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvLoaiSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoaiSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblSoDong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvLoaiSanPham As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsLoaiSanPham As System.Windows.Forms.BindingSource
    Friend WithEvents STT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colMaLoaiSanPham As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenLoaiSanPham As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoTa As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
