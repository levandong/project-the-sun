<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuXuat
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuXuat))
        Me.bsChiTietPhieuXuat = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvSanPham = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.colMaVachSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSanPhamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPhamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonViDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayNiemYet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGiaNhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGiaBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STTcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsSanPham = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.lblSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New PhanMemBanHang.clsTextbox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgvMain = New PhanMemBanHang.CustomDatagridview()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonVi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TonKho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongXuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChietKhau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaChietKhau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.nudTongTien = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.nudTienVAT = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.nudVAT = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.nudTienCK = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.nudCK = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnXemTruoc = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnDongY = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCongTrinh = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudHanThanhToan = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.cmbLoaiPhieuXuat = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatLoaiPhieuXuat = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.nudCongTien = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.dtpNgayLap = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.btnTickThoiGian = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtGhiChu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtMaPhieuXuat = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnCapNhatSoPhieu = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.bsChiTietPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.cmbLoaiPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bsChiTietPhieuXuat
        '
        Me.bsChiTietPhieuXuat.DataSource = GetType(PhanMemBanHang.tbChiTietPhieuXuat)
        '
        'dgvSanPham
        '
        Me.dgvSanPham.AllowUserToAddRows = False
        Me.dgvSanPham.AllowUserToDeleteRows = False
        Me.dgvSanPham.AllowUserToResizeRows = False
        Me.dgvSanPham.AutoGenerateColumns = False
        Me.dgvSanPham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaVachSanPham, Me.MaSanPhamDataGridViewTextBoxColumn, Me.TenSanPhamDataGridViewTextBoxColumn, Me.DonViDataGridViewTextBoxColumn, Me.NgayNiemYet, Me.DataGridViewTextBoxColumn2, Me.colGiaNhap, Me.colGiaBan, Me.SoLuongDataGridViewTextBoxColumn, Me.STTcol})
        Me.dgvSanPham.DataSource = Me.bsSanPham
        Me.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSanPham.Location = New System.Drawing.Point(0, 52)
        Me.dgvSanPham.Name = "dgvSanPham"
        Me.dgvSanPham.ReadOnly = True
        Me.dgvSanPham.RowHeadersWidth = 10
        Me.dgvSanPham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSanPham.Size = New System.Drawing.Size(1129, 431)
        Me.dgvSanPham.TabIndex = 13
        Me.dgvSanPham.VirtualMode = True
        Me.dgvSanPham.Visible = False
        '
        'colMaVachSanPham
        '
        Me.colMaVachSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMaVachSanPham.DataPropertyName = "MaVachSanPham"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        Me.colMaVachSanPham.DefaultCellStyle = DataGridViewCellStyle1
        Me.colMaVachSanPham.HeaderText = "Mã vạch"
        Me.colMaVachSanPham.Name = "colMaVachSanPham"
        Me.colMaVachSanPham.ReadOnly = True
        Me.colMaVachSanPham.Visible = False
        '
        'MaSanPhamDataGridViewTextBoxColumn
        '
        Me.MaSanPhamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham"
        Me.MaSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm"
        Me.MaSanPhamDataGridViewTextBoxColumn.Name = "MaSanPhamDataGridViewTextBoxColumn"
        Me.MaSanPhamDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaSanPhamDataGridViewTextBoxColumn.Width = 108
        '
        'TenSanPhamDataGridViewTextBoxColumn
        '
        Me.TenSanPhamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        Me.TenSanPhamDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm"
        Me.TenSanPhamDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.TenSanPhamDataGridViewTextBoxColumn.Name = "TenSanPhamDataGridViewTextBoxColumn"
        Me.TenSanPhamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DonViDataGridViewTextBoxColumn
        '
        Me.DonViDataGridViewTextBoxColumn.DataPropertyName = "DonVi"
        Me.DonViDataGridViewTextBoxColumn.HeaderText = "ĐVT"
        Me.DonViDataGridViewTextBoxColumn.MinimumWidth = 50
        Me.DonViDataGridViewTextBoxColumn.Name = "DonViDataGridViewTextBoxColumn"
        Me.DonViDataGridViewTextBoxColumn.ReadOnly = True
        Me.DonViDataGridViewTextBoxColumn.Width = 50
        '
        'NgayNiemYet
        '
        Me.NgayNiemYet.DataPropertyName = "NgayNiemYet"
        Me.NgayNiemYet.HeaderText = "Ngày niêm yết"
        Me.NgayNiemYet.Name = "NgayNiemYet"
        Me.NgayNiemYet.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GiaNiemYet"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.NullValue = "###,###,###,##0.###"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Giá niêm yết"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'colGiaNhap
        '
        Me.colGiaNhap.DataPropertyName = "PhanTramNhap"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colGiaNhap.DefaultCellStyle = DataGridViewCellStyle4
        Me.colGiaNhap.HeaderText = "Tỉ giá nhập"
        Me.colGiaNhap.Name = "colGiaNhap"
        Me.colGiaNhap.ReadOnly = True
        '
        'colGiaBan
        '
        Me.colGiaBan.DataPropertyName = "PhanTramBan"
        Me.colGiaBan.HeaderText = "Tỉ giá xuất"
        Me.colGiaBan.Name = "colGiaBan"
        Me.colGiaBan.ReadOnly = True
        '
        'SoLuongDataGridViewTextBoxColumn
        '
        Me.SoLuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.Format = "###,###,###,##0.###,###"
        Me.SoLuongDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SoLuongDataGridViewTextBoxColumn.HeaderText = "Tồn"
        Me.SoLuongDataGridViewTextBoxColumn.MinimumWidth = 50
        Me.SoLuongDataGridViewTextBoxColumn.Name = "SoLuongDataGridViewTextBoxColumn"
        Me.SoLuongDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongDataGridViewTextBoxColumn.Width = 57
        '
        'STTcol
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STTcol.DefaultCellStyle = DataGridViewCellStyle6
        Me.STTcol.HeaderText = "STT"
        Me.STTcol.MinimumWidth = 40
        Me.STTcol.Name = "STTcol"
        Me.STTcol.ReadOnly = True
        Me.STTcol.Width = 40
        '
        'bsSanPham
        '
        Me.bsSanPham.DataSource = GetType(PhanMemBanHang.vwSanPham)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 27)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1129, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripLabel2.Text = "DANH MỤC SẢN PHẨM"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoLuong})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 483)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1129, 25)
        Me.ToolStrip3.TabIndex = 2
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(71, 22)
        Me.lblSoLuong.Text = "0 sản phẩm."
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearch.Location = New System.Drawing.Point(0, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(1129, 27)
        Me.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.txtSearch.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtSearch.StateCommon.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.Gray
        Me.txtSearch.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic)
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSearch.TextGoiY = ""
        Me.txtSearch.Visible = False
        '
        'Timer1
        '
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaSanPham, Me.TenSanPham, Me.DonVi, Me.TonKho, Me.SoLuong, Me.SoLuongXuat, Me.DonGia, Me.colChietKhau, Me.GiaChietKhau, Me.ThanhTien, Me.GhiChu})
        Me.dgvMain.DataSource = Me.bsChiTietPhieuXuat
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Editing = False
        Me.dgvMain.Location = New System.Drawing.Point(0, 52)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.Size = New System.Drawing.Size(1129, 431)
        Me.dgvMain.TabIndex = 1
        Me.dgvMain.VirtualMode = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 40
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'MaSanPham
        '
        Me.MaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaSanPham.DataPropertyName = "MaSanPham"
        Me.MaSanPham.HeaderText = "Mã"
        Me.MaSanPham.Name = "MaSanPham"
        Me.MaSanPham.ReadOnly = True
        Me.MaSanPham.Width = 53
        '
        'TenSanPham
        '
        Me.TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenSanPham.DataPropertyName = "TenSanPham"
        Me.TenSanPham.HeaderText = "Tên Sản Phẩm"
        Me.TenSanPham.Name = "TenSanPham"
        Me.TenSanPham.ReadOnly = True
        Me.TenSanPham.Width = 112
        '
        'DonVi
        '
        Me.DonVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DonVi.DataPropertyName = "DonVi"
        Me.DonVi.HeaderText = "Đơn Vị"
        Me.DonVi.Name = "DonVi"
        Me.DonVi.ReadOnly = True
        Me.DonVi.Width = 71
        '
        'TonKho
        '
        Me.TonKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TonKho.DataPropertyName = "TonKho"
        Me.TonKho.HeaderText = "Tồn kho"
        Me.TonKho.Name = "TonKho"
        Me.TonKho.ReadOnly = True
        Me.TonKho.Width = 80
        '
        'SoLuong
        '
        Me.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoLuong.DataPropertyName = "SoLuong"
        Me.SoLuong.HeaderText = "SL Yêu cầu"
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.ReadOnly = True
        Me.SoLuong.Width = 93
        '
        'SoLuongXuat
        '
        Me.SoLuongXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoLuongXuat.DataPropertyName = "SoLuongXuat"
        Me.SoLuongXuat.HeaderText = "SL Xuất"
        Me.SoLuongXuat.Name = "SoLuongXuat"
        Me.SoLuongXuat.Width = 75
        '
        'DonGia
        '
        Me.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DonGia.DataPropertyName = "DonGia"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Format = "N0"
        Me.DonGia.DefaultCellStyle = DataGridViewCellStyle7
        Me.DonGia.HeaderText = "Giá niêm yết"
        Me.DonGia.Name = "DonGia"
        Me.DonGia.ReadOnly = True
        Me.DonGia.Width = 102
        '
        'colChietKhau
        '
        Me.colChietKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colChietKhau.DataPropertyName = "ChietKhau"
        DataGridViewCellStyle8.Format = "##0.###"
        Me.colChietKhau.DefaultCellStyle = DataGridViewCellStyle8
        Me.colChietKhau.HeaderText = "CK(%)"
        Me.colChietKhau.Name = "colChietKhau"
        Me.colChietKhau.ReadOnly = True
        Me.colChietKhau.Width = 69
        '
        'GiaChietKhau
        '
        Me.GiaChietKhau.DataPropertyName = "GiaBan"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Format = "###,###,###,##0.###"
        DataGridViewCellStyle9.NullValue = "0"
        Me.GiaChietKhau.DefaultCellStyle = DataGridViewCellStyle9
        Me.GiaChietKhau.HeaderText = "Đơn giá"
        Me.GiaChietKhau.Name = "GiaChietKhau"
        Me.GiaChietKhau.ReadOnly = True
        '
        'ThanhTien
        '
        Me.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ThanhTien.DataPropertyName = "ThanhTien"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.Format = "N0"
        Me.ThanhTien.DefaultCellStyle = DataGridViewCellStyle10
        Me.ThanhTien.HeaderText = "Thành Tiền"
        Me.ThanhTien.MinimumWidth = 90
        Me.ThanhTien.Name = "ThanhTien"
        Me.ThanhTien.ReadOnly = True
        Me.ThanhTien.Width = 96
        '
        'GhiChu
        '
        Me.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChu.DataPropertyName = "GhiChu"
        Me.GhiChu.HeaderText = "Ghi Chú"
        Me.GhiChu.MinimumWidth = 150
        Me.GhiChu.Name = "GhiChu"
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.IsSplitterFixed = True
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.nudTongTien)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.nudTienVAT)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.nudVAT)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.nudTienCK)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.nudCK)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnXemTruoc)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnDongY)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtKhachHang)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel11)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtCongTrinh)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel15)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.nudHanThanhToan)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbLoaiPhieuXuat)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.nudCongTien)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dtpNgayLap)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtGhiChu)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtMaPhieuXuat)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel3)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvMain)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvSanPham)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip3)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1129, 661)
        Me.KryptonSplitContainer1.SplitterDistance = 150
        Me.KryptonSplitContainer1.SplitterWidth = 3
        Me.KryptonSplitContainer1.TabIndex = 9
        '
        'nudTongTien
        '
        Me.nudTongTien.Enabled = False
        Me.nudTongTien.Location = New System.Drawing.Point(667, 60)
        Me.nudTongTien.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.nudTongTien.Name = "nudTongTien"
        Me.nudTongTien.Size = New System.Drawing.Size(189, 25)
        Me.nudTongTien.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nudTongTien.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTongTien.TabIndex = 100
        Me.nudTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTongTien.ThousandsSeparator = True
        '
        'nudTienVAT
        '
        Me.nudTienVAT.Enabled = False
        Me.nudTienVAT.Location = New System.Drawing.Point(726, 33)
        Me.nudTienVAT.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.nudTienVAT.Name = "nudTienVAT"
        Me.nudTienVAT.Size = New System.Drawing.Size(130, 25)
        Me.nudTienVAT.StateCommon.Content.Color1 = System.Drawing.Color.Navy
        Me.nudTienVAT.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTienVAT.TabIndex = 101
        Me.nudTienVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTienVAT.ThousandsSeparator = True
        '
        'nudVAT
        '
        Me.nudVAT.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudVAT.Location = New System.Drawing.Point(667, 33)
        Me.nudVAT.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.nudVAT.Name = "nudVAT"
        Me.nudVAT.Size = New System.Drawing.Size(53, 25)
        Me.nudVAT.StateCommon.Content.Color1 = System.Drawing.Color.Navy
        Me.nudVAT.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudVAT.TabIndex = 99
        Me.nudVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudVAT.ThousandsSeparator = True
        Me.nudVAT.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nudTienCK
        '
        Me.nudTienCK.Enabled = False
        Me.nudTienCK.Location = New System.Drawing.Point(726, 34)
        Me.nudTienCK.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.nudTienCK.Name = "nudTienCK"
        Me.nudTienCK.Size = New System.Drawing.Size(130, 25)
        Me.nudTienCK.StateCommon.Content.Color1 = System.Drawing.Color.Green
        Me.nudTienCK.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTienCK.TabIndex = 102
        Me.nudTienCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTienCK.ThousandsSeparator = True
        Me.nudTienCK.Visible = False
        '
        'nudCK
        '
        Me.nudCK.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudCK.Location = New System.Drawing.Point(667, 34)
        Me.nudCK.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.nudCK.Name = "nudCK"
        Me.nudCK.Size = New System.Drawing.Size(53, 25)
        Me.nudCK.StateCommon.Content.Color1 = System.Drawing.Color.Green
        Me.nudCK.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCK.TabIndex = 103
        Me.nudCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCK.ThousandsSeparator = True
        Me.nudCK.Visible = False
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(586, 63)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(71, 19)
        Me.KryptonLabel10.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.TabIndex = 96
        Me.KryptonLabel10.Values.Text = "Tổng Tiền"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(586, 36)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(37, 19)
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 97
        Me.KryptonLabel9.Values.Text = "VAT"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(586, 37)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(29, 19)
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 98
        Me.KryptonLabel8.Values.Text = "CK"
        Me.KryptonLabel8.Visible = False
        '
        'btnXemTruoc
        '
        Me.btnXemTruoc.Location = New System.Drawing.Point(983, 54)
        Me.btnXemTruoc.Name = "btnXemTruoc"
        Me.btnXemTruoc.Size = New System.Drawing.Size(134, 34)
        Me.btnXemTruoc.TabIndex = 95
        Me.btnXemTruoc.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.XemTruoc16
        Me.btnXemTruoc.Values.Text = "XEM TRƯỚC"
        Me.btnXemTruoc.Visible = False
        '
        'btnDongY
        '
        Me.btnDongY.Location = New System.Drawing.Point(983, 12)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(134, 34)
        Me.btnDongY.TabIndex = 94
        Me.btnDongY.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.tick216
        Me.btnDongY.Values.Text = "[F5]ĐỒNG Ý"
        '
        'txtKhachHang
        '
        Me.txtKhachHang.Location = New System.Drawing.Point(134, 62)
        Me.txtKhachHang.Name = "txtKhachHang"
        Me.txtKhachHang.Size = New System.Drawing.Size(438, 23)
        Me.txtKhachHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKhachHang.TabIndex = 90
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(7, 67)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(89, 19)
        Me.KryptonLabel11.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel11.TabIndex = 91
        Me.KryptonLabel11.Values.Text = "NCC/KH [F4]"
        '
        'txtCongTrinh
        '
        Me.txtCongTrinh.Location = New System.Drawing.Point(134, 91)
        Me.txtCongTrinh.Name = "txtCongTrinh"
        Me.txtCongTrinh.Size = New System.Drawing.Size(439, 23)
        Me.txtCongTrinh.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCongTrinh.TabIndex = 89
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(7, 96)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(73, 19)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 88
        Me.KryptonLabel1.Values.Text = "Công trình"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(590, 93)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel15.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel15.TabIndex = 87
        Me.KryptonLabel15.Values.Text = "Hạn TT"
        '
        'nudHanThanhToan
        '
        Me.nudHanThanhToan.Location = New System.Drawing.Point(667, 90)
        Me.nudHanThanhToan.Name = "nudHanThanhToan"
        Me.nudHanThanhToan.Size = New System.Drawing.Size(189, 25)
        Me.nudHanThanhToan.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHanThanhToan.TabIndex = 86
        Me.nudHanThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbLoaiPhieuXuat
        '
        Me.cmbLoaiPhieuXuat.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatLoaiPhieuXuat})
        Me.cmbLoaiPhieuXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoaiPhieuXuat.DropDownWidth = 189
        Me.cmbLoaiPhieuXuat.Location = New System.Drawing.Point(134, 33)
        Me.cmbLoaiPhieuXuat.Name = "cmbLoaiPhieuXuat"
        Me.cmbLoaiPhieuXuat.Size = New System.Drawing.Size(438, 24)
        Me.cmbLoaiPhieuXuat.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoaiPhieuXuat.TabIndex = 2
        '
        'btnCapNhatLoaiPhieuXuat
        '
        Me.btnCapNhatLoaiPhieuXuat.Image = CType(resources.GetObject("btnCapNhatLoaiPhieuXuat.Image"), System.Drawing.Image)
        Me.btnCapNhatLoaiPhieuXuat.UniqueName = "35B4AE6F6EA148D6708A23CB439204E9"
        Me.btnCapNhatLoaiPhieuXuat.Visible = False
        '
        'nudCongTien
        '
        Me.nudCongTien.Enabled = False
        Me.nudCongTien.Location = New System.Drawing.Point(667, 5)
        Me.nudCongTien.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.nudCongTien.Name = "nudCongTien"
        Me.nudCongTien.Size = New System.Drawing.Size(189, 25)
        Me.nudCongTien.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nudCongTien.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCongTien.TabIndex = 6
        Me.nudCongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCongTien.ThousandsSeparator = True
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnTickThoiGian})
        Me.dtpNgayLap.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLap.Location = New System.Drawing.Point(383, 4)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(189, 26)
        Me.dtpNgayLap.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayLap.TabIndex = 5
        '
        'btnTickThoiGian
        '
        Me.btnTickThoiGian.Image = CType(resources.GetObject("btnTickThoiGian.Image"), System.Drawing.Image)
        Me.btnTickThoiGian.UniqueName = "74157B4A612245AB71835E5C2C99ADBA"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(134, 118)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(439, 23)
        Me.txtGhiChu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhiChu.TabIndex = 7
        '
        'txtMaPhieuXuat
        '
        Me.txtMaPhieuXuat.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatSoPhieu})
        Me.txtMaPhieuXuat.Enabled = False
        Me.txtMaPhieuXuat.Location = New System.Drawing.Point(134, 5)
        Me.txtMaPhieuXuat.Name = "txtMaPhieuXuat"
        Me.txtMaPhieuXuat.ReadOnly = True
        Me.txtMaPhieuXuat.Size = New System.Drawing.Size(168, 24)
        Me.txtMaPhieuXuat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMaPhieuXuat.StateCommon.Content.Color1 = System.Drawing.Color.Maroon
        Me.txtMaPhieuXuat.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaPhieuXuat.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMaPhieuXuat.StateDisabled.Content.Color1 = System.Drawing.Color.Maroon
        Me.txtMaPhieuXuat.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaPhieuXuat.TabIndex = 1
        Me.txtMaPhieuXuat.Text = "000000"
        Me.txtMaPhieuXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCapNhatSoPhieu
        '
        Me.btnCapNhatSoPhieu.Image = CType(resources.GetObject("btnCapNhatSoPhieu.Image"), System.Drawing.Image)
        Me.btnCapNhatSoPhieu.UniqueName = "4ECBE69011874BF2F4823132B2E7CD1A"
        Me.btnCapNhatSoPhieu.Visible = False
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(586, 8)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(73, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 0
        Me.KryptonLabel4.Values.Text = "Cộng Tiền"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(308, 8)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(68, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 0
        Me.KryptonLabel2.Values.Text = "Ngày Lập"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(6, 36)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(74, 19)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 0
        Me.KryptonLabel5.Values.Text = "Loại Phiếu"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(7, 123)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(60, 19)
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 0
        Me.KryptonLabel7.Values.Text = "Ghi Chú"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(6, 8)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(98, 19)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 0
        Me.KryptonLabel3.Values.Text = "Mã Phiếu Xuất"
        '
        'frmPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 661)
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "frmPhieuXuat"
        Me.Text = "PHIẾU XUẤT"
        CType(Me.bsChiTietPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.cmbLoaiPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsChiTietPhieuXuat As BindingSource
    Friend WithEvents dgvSanPham As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents colMaVachSanPham As DataGridViewTextBoxColumn
    Friend WithEvents MaSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonViDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayNiemYet As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents colGiaNhap As DataGridViewTextBoxColumn
    Friend WithEvents colGiaBan As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STTcol As DataGridViewTextBoxColumn
    Friend WithEvents bsSanPham As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents lblSoLuong As ToolStripLabel
    Friend WithEvents txtSearch As clsTextbox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dgvMain As CustomDatagridview
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents txtKhachHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCongTrinh As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudHanThanhToan As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents cmbLoaiPhieuXuat As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatLoaiPhieuXuat As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents nudCongTien As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents dtpNgayLap As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents btnTickThoiGian As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtGhiChu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMaPhieuXuat As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnCapNhatSoPhieu As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnDongY As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnXemTruoc As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents nudTongTien As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nudTienVAT As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nudVAT As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nudTienCK As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nudCK As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents MaSanPham As DataGridViewTextBoxColumn
    Friend WithEvents TenSanPham As DataGridViewTextBoxColumn
    Friend WithEvents DonVi As DataGridViewTextBoxColumn
    Friend WithEvents TonKho As DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongXuat As DataGridViewTextBoxColumn
    Friend WithEvents DonGia As DataGridViewTextBoxColumn
    Friend WithEvents colChietKhau As DataGridViewTextBoxColumn
    Friend WithEvents GiaChietKhau As DataGridViewTextBoxColumn
    Friend WithEvents ThanhTien As DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
End Class
