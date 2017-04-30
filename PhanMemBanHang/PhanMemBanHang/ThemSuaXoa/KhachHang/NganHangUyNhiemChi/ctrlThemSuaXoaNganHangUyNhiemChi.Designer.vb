<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlThemSuaXoaNganHangUyNhiemChi
        Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnThem = New System.Windows.Forms.ToolStripButton()
        Me.btnSua = New System.Windows.Forms.ToolStripButton()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenChuTaiKhoanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoTaiKhoanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNganHangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChiNhanhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KhachHangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CotFill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbNganHangUyNhiemChiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbNganHangUyNhiemChiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThem, Me.btnSua, Me.btnXoa, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(676, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnThem
        '
        Me.btnThem.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(78, 22)
        Me.btnThem.Text = "&Thêm[F4]"
        '
        'btnSua
        '
        Me.btnSua.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua_16
        Me.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(66, 22)
        Me.btnSua.Text = "&Sửa[F5]"
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.PhanMemBanHang.My.Resources.Resources.Xoa_16
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(67, 22)
        Me.btnXoa.Text = "&Xoá[F6]"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.TenChuTaiKhoanDataGridViewTextBoxColumn, Me.SoTaiKhoanDataGridViewTextBoxColumn, Me.TenNganHangDataGridViewTextBoxColumn, Me.ChiNhanhDataGridViewTextBoxColumn, Me.TinhDataGridViewTextBoxColumn, Me.KhachHangDataGridViewTextBoxColumn, Me.CotFill})
        Me.dgvMain.DataSource = Me.TbNganHangUyNhiemChiBindingSource
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 25)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.Size = New System.Drawing.Size(676, 407)
        Me.dgvMain.TabIndex = 2
        Me.dgvMain.VirtualMode = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 35
        '
        'TenChuTaiKhoanDataGridViewTextBoxColumn
        '
        Me.TenChuTaiKhoanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenChuTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "TenChuTaiKhoan"
        Me.TenChuTaiKhoanDataGridViewTextBoxColumn.HeaderText = "Tên chủ tài khoản"
        Me.TenChuTaiKhoanDataGridViewTextBoxColumn.Name = "TenChuTaiKhoanDataGridViewTextBoxColumn"
        Me.TenChuTaiKhoanDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenChuTaiKhoanDataGridViewTextBoxColumn.Width = 131
        '
        'SoTaiKhoanDataGridViewTextBoxColumn
        '
        Me.SoTaiKhoanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "SoTaiKhoan"
        Me.SoTaiKhoanDataGridViewTextBoxColumn.HeaderText = "Số tài khoản"
        Me.SoTaiKhoanDataGridViewTextBoxColumn.Name = "SoTaiKhoanDataGridViewTextBoxColumn"
        Me.SoTaiKhoanDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoTaiKhoanDataGridViewTextBoxColumn.Width = 101
        '
        'TenNganHangDataGridViewTextBoxColumn
        '
        Me.TenNganHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenNganHangDataGridViewTextBoxColumn.DataPropertyName = "TenNganHang"
        Me.TenNganHangDataGridViewTextBoxColumn.HeaderText = "Tên ngân hàng"
        Me.TenNganHangDataGridViewTextBoxColumn.Name = "TenNganHangDataGridViewTextBoxColumn"
        Me.TenNganHangDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenNganHangDataGridViewTextBoxColumn.Width = 116
        '
        'ChiNhanhDataGridViewTextBoxColumn
        '
        Me.ChiNhanhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ChiNhanhDataGridViewTextBoxColumn.DataPropertyName = "ChiNhanh"
        Me.ChiNhanhDataGridViewTextBoxColumn.HeaderText = "Chi nhánh/PGD"
        Me.ChiNhanhDataGridViewTextBoxColumn.Name = "ChiNhanhDataGridViewTextBoxColumn"
        Me.ChiNhanhDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChiNhanhDataGridViewTextBoxColumn.Width = 119
        '
        'TinhDataGridViewTextBoxColumn
        '
        Me.TinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TinhDataGridViewTextBoxColumn.DataPropertyName = "Tinh"
        Me.TinhDataGridViewTextBoxColumn.HeaderText = "Tỉnh/TP"
        Me.TinhDataGridViewTextBoxColumn.Name = "TinhDataGridViewTextBoxColumn"
        Me.TinhDataGridViewTextBoxColumn.ReadOnly = True
        Me.TinhDataGridViewTextBoxColumn.Width = 79
        '
        'KhachHangDataGridViewTextBoxColumn
        '
        Me.KhachHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KhachHangDataGridViewTextBoxColumn.DataPropertyName = "tbKhachHang"
        Me.KhachHangDataGridViewTextBoxColumn.HeaderText = "Khách hàng"
        Me.KhachHangDataGridViewTextBoxColumn.Name = "KhachHangDataGridViewTextBoxColumn"
        Me.KhachHangDataGridViewTextBoxColumn.ReadOnly = True
        Me.KhachHangDataGridViewTextBoxColumn.Width = 99
        '
        'CotFill
        '
        Me.CotFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CotFill.HeaderText = ""
        Me.CotFill.Name = "CotFill"
        Me.CotFill.ReadOnly = True
        '
        'TbNganHangUyNhiemChiBindingSource
        '
        Me.TbNganHangUyNhiemChiBindingSource.DataSource = GetType(PhanMemBanHang.tbNganHangUyNhiemChi)
        '
        'ctrlThemSuaXoaNganHangUyNhiemChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlThemSuaXoaNganHangUyNhiemChi"
        Me.Size = New System.Drawing.Size(676, 432)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbNganHangUyNhiemChiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSua As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TbNganHangUyNhiemChiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CotFill As System.Windows.Forms.DataGridViewTextBoxColumn
    'khai báo các cột
    Friend WithEvents TenChuTaiKhoanDataGridViewTextBoxColumn As  System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents SoTaiKhoanDataGridViewTextBoxColumn As  System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents TenNganHangDataGridViewTextBoxColumn As  System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents ChiNhanhDataGridViewTextBoxColumn As  System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents TinhDataGridViewTextBoxColumn As  System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents KhachHangDataGridViewTextBoxColumn As  System.Windows.Forms.DataGridViewTextBoxColumn

End Class