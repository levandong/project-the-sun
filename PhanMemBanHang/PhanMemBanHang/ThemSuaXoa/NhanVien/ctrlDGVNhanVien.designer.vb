<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlDGVNhanVien
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
        Me.dgvNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenDangNhapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNhanVienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChucVuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDienThoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isToanQuyen = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HopLeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bsNhanVien = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
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
        Me.lblSoDong.Size = New System.Drawing.Size(70, 22)
        Me.lblSoDong.Text = "0 nhân viên."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'dgvNhanVien
        '
        Me.dgvNhanVien.AllowUserToAddRows = False
        Me.dgvNhanVien.AllowUserToDeleteRows = False
        Me.dgvNhanVien.AllowUserToResizeRows = False
        Me.dgvNhanVien.AutoGenerateColumns = False
        Me.dgvNhanVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.TenDangNhapDataGridViewTextBoxColumn, Me.TenNhanVienDataGridViewTextBoxColumn, Me.ChucVuDataGridViewTextBoxColumn, Me.SoDienThoai, Me.isToanQuyen, Me.HopLeDataGridViewCheckBoxColumn})
        Me.dgvNhanVien.DataSource = Me.bsNhanVien
        Me.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNhanVien.Location = New System.Drawing.Point(0, 0)
        Me.dgvNhanVien.Name = "dgvNhanVien"
        Me.dgvNhanVien.ReadOnly = True
        Me.dgvNhanVien.RowHeadersWidth = 10
        Me.dgvNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvNhanVien.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNhanVien.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        Me.dgvNhanVien.Size = New System.Drawing.Size(663, 284)
        Me.dgvNhanVien.TabIndex = 2
        Me.dgvNhanVien.VirtualMode = True
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
        'TenDangNhapDataGridViewTextBoxColumn
        '
        Me.TenDangNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap"
        Me.TenDangNhapDataGridViewTextBoxColumn.Frozen = True
        Me.TenDangNhapDataGridViewTextBoxColumn.HeaderText = "Tên Đăng Nhập"
        Me.TenDangNhapDataGridViewTextBoxColumn.Name = "TenDangNhapDataGridViewTextBoxColumn"
        Me.TenDangNhapDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenDangNhapDataGridViewTextBoxColumn.Width = 116
        '
        'TenNhanVienDataGridViewTextBoxColumn
        '
        Me.TenNhanVienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien"
        Me.TenNhanVienDataGridViewTextBoxColumn.HeaderText = "Tên Nhân Viên"
        Me.TenNhanVienDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.TenNhanVienDataGridViewTextBoxColumn.Name = "TenNhanVienDataGridViewTextBoxColumn"
        Me.TenNhanVienDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChucVuDataGridViewTextBoxColumn
        '
        Me.ChucVuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ChucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu"
        Me.ChucVuDataGridViewTextBoxColumn.HeaderText = "Chức Vụ"
        Me.ChucVuDataGridViewTextBoxColumn.Name = "ChucVuDataGridViewTextBoxColumn"
        Me.ChucVuDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChucVuDataGridViewTextBoxColumn.Width = 79
        '
        'SoDienThoai
        '
        Me.SoDienThoai.DataPropertyName = "SoDienThoai"
        Me.SoDienThoai.HeaderText = "Điện Thoại"
        Me.SoDienThoai.MinimumWidth = 80
        Me.SoDienThoai.Name = "SoDienThoai"
        Me.SoDienThoai.ReadOnly = True
        '
        'isToanQuyen
        '
        Me.isToanQuyen.DataPropertyName = "isToanQuyen"
        Me.isToanQuyen.HeaderText = "Toàn Quyền"
        Me.isToanQuyen.MinimumWidth = 80
        Me.isToanQuyen.Name = "isToanQuyen"
        Me.isToanQuyen.ReadOnly = True
        Me.isToanQuyen.Width = 80
        '
        'HopLeDataGridViewCheckBoxColumn
        '
        Me.HopLeDataGridViewCheckBoxColumn.DataPropertyName = "HopLe"
        Me.HopLeDataGridViewCheckBoxColumn.HeaderText = "Hợp Lệ"
        Me.HopLeDataGridViewCheckBoxColumn.MinimumWidth = 60
        Me.HopLeDataGridViewCheckBoxColumn.Name = "HopLeDataGridViewCheckBoxColumn"
        Me.HopLeDataGridViewCheckBoxColumn.ReadOnly = True
        Me.HopLeDataGridViewCheckBoxColumn.Width = 60
        '
        'bsNhanVien
        '
        Me.bsNhanVien.DataSource = GetType(PhanMemBanHang.tbNhanVien)
        '
        'ctrlDGVNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvNhanVien)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlDGVNhanVien"
        Me.Size = New System.Drawing.Size(663, 309)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblSoDong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvNhanVien As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsNhanVien As System.Windows.Forms.BindingSource
    Friend WithEvents STT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenDangNhapDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenNhanVienDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChucVuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoDienThoai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isToanQuyen As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HopLeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
