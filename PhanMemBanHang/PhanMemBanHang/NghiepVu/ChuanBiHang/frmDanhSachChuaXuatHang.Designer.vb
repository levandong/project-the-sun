<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachChuaXuatHang
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayDuKienGiaoHangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhachHangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPhamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonViDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CongTrinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsChiTietKhachHangDatHang = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChiTietKhachHangDatHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dgvMain)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1154, 650)
        Me.KryptonPanel1.TabIndex = 0
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.NgayLapDataGridViewTextBoxColumn, Me.NgayDuKienGiaoHangDataGridViewTextBoxColumn, Me.TenKhachHangDataGridViewTextBoxColumn, Me.TenSanPhamDataGridViewTextBoxColumn, Me.DonViDataGridViewTextBoxColumn, Me.SoLuongDataGridViewTextBoxColumn, Me.CongTrinh, Me.GhiChuDataGridViewTextBoxColumn})
        Me.dgvMain.DataSource = Me.bsChiTietKhachHangDatHang
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 5
        Me.dgvMain.Size = New System.Drawing.Size(1154, 650)
        Me.dgvMain.TabIndex = 0
        Me.dgvMain.VirtualMode = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'NgayLapDataGridViewTextBoxColumn
        '
        Me.NgayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap"
        Me.NgayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lập"
        Me.NgayLapDataGridViewTextBoxColumn.Name = "NgayLapDataGridViewTextBoxColumn"
        Me.NgayLapDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NgayDuKienGiaoHangDataGridViewTextBoxColumn
        '
        Me.NgayDuKienGiaoHangDataGridViewTextBoxColumn.DataPropertyName = "NgayDuKienGiaoHang"
        Me.NgayDuKienGiaoHangDataGridViewTextBoxColumn.HeaderText = "Ngày D.Kiến giao"
        Me.NgayDuKienGiaoHangDataGridViewTextBoxColumn.Name = "NgayDuKienGiaoHangDataGridViewTextBoxColumn"
        Me.NgayDuKienGiaoHangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TenKhachHangDataGridViewTextBoxColumn
        '
        Me.TenKhachHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang"
        Me.TenKhachHangDataGridViewTextBoxColumn.HeaderText = "KH/NCC"
        Me.TenKhachHangDataGridViewTextBoxColumn.Name = "TenKhachHangDataGridViewTextBoxColumn"
        Me.TenKhachHangDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenKhachHangDataGridViewTextBoxColumn.Width = 82
        '
        'TenSanPhamDataGridViewTextBoxColumn
        '
        Me.TenSanPhamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham"
        Me.TenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm"
        Me.TenSanPhamDataGridViewTextBoxColumn.Name = "TenSanPhamDataGridViewTextBoxColumn"
        Me.TenSanPhamDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenSanPhamDataGridViewTextBoxColumn.Width = 111
        '
        'DonViDataGridViewTextBoxColumn
        '
        Me.DonViDataGridViewTextBoxColumn.DataPropertyName = "DonVi"
        Me.DonViDataGridViewTextBoxColumn.HeaderText = "Đơn vị"
        Me.DonViDataGridViewTextBoxColumn.Name = "DonViDataGridViewTextBoxColumn"
        Me.DonViDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoLuongDataGridViewTextBoxColumn
        '
        Me.SoLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong"
        Me.SoLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng"
        Me.SoLuongDataGridViewTextBoxColumn.Name = "SoLuongDataGridViewTextBoxColumn"
        Me.SoLuongDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongDataGridViewTextBoxColumn.Width = 80
        '
        'CongTrinh
        '
        Me.CongTrinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CongTrinh.DataPropertyName = "CongTrinh"
        Me.CongTrinh.HeaderText = "Tên Công Trình"
        Me.CongTrinh.Name = "CongTrinh"
        Me.CongTrinh.ReadOnly = True
        Me.CongTrinh.Width = 119
        '
        'GhiChuDataGridViewTextBoxColumn
        '
        Me.GhiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu"
        Me.GhiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú"
        Me.GhiChuDataGridViewTextBoxColumn.Name = "GhiChuDataGridViewTextBoxColumn"
        Me.GhiChuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsChiTietKhachHangDatHang
        '
        Me.bsChiTietKhachHangDatHang.DataSource = GetType(PhanMemBanHang.vwChiTietKhachHangDatHang)
        '
        'frmDanhSachChuaXuatHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 650)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "frmDanhSachChuaXuatHang"
        Me.Text = "DANH SÁCH CHI TIẾT SẢN PHẨM CHƯA XUẤT HÀNG"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChiTietKhachHangDatHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsChiTietKhachHangDatHang As BindingSource
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents SoPhieuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayLapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayDuKienGiaoHangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenKhachHangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonViDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CongTrinh As DataGridViewTextBoxColumn
    Friend WithEvents GhiChuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
