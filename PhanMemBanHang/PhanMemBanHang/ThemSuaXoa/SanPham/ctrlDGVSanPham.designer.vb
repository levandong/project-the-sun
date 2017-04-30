<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlDGVSanPham
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnIn = New System.Windows.Forms.ToolStripButton()
        Me.btnInKemGia = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnQuaTraiTatCa = New System.Windows.Forms.ToolStripButton()
        Me.btnQuaTrai1 = New System.Windows.Forms.ToolStripButton()
        Me.txtSoTrang = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTongSoTrang = New System.Windows.Forms.ToolStripTextBox()
        Me.btnQuaPhai1 = New System.Windows.Forms.ToolStripButton()
        Me.btnQuaPhaiTatCa = New System.Windows.Forms.ToolStripButton()
        Me.txtSoDongTrenMotTrang = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTongSoTrang2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTongSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvMain = New PhanMemBanHang.CustomDatagridview()
        Me.bsSanPham = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaVachSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonVi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayNiemYet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaBinhQuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaTriHienTai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhanTramBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhanTramNhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TonMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KhoiLuongRieng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KyHieuKho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbLoaiSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayTao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThoiGianBaoHanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoTa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CanhBao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HetBan = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoLuong, Me.ToolStripSeparator1, Me.btnIn, Me.btnInKemGia, Me.ToolStripLabel2, Me.btnQuaTraiTatCa, Me.btnQuaTrai1, Me.txtSoTrang, Me.ToolStripLabel3, Me.lblTongSoTrang, Me.btnQuaPhai1, Me.btnQuaPhaiTatCa, Me.txtSoDongTrenMotTrang, Me.ToolStripSeparator4, Me.ToolStripLabel4, Me.lblTongSoTrang2, Me.ToolStripLabel5, Me.lblTongSoLuong, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 522)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(1171, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(68, 22)
        Me.lblSoLuong.Text = "0 sản phẩm"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnIn
        '
        Me.btnIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnIn.Image = Global.PhanMemBanHang.My.Resources.Resources.Print16
        Me.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(94, 22)
        Me.btnIn.Text = "In danh sách"
        '
        'btnInKemGia
        '
        Me.btnInKemGia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnInKemGia.CheckOnClick = True
        Me.btnInKemGia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInKemGia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInKemGia.Name = "btnInKemGia"
        Me.btnInKemGia.Size = New System.Drawing.Size(66, 22)
        Me.btnInKemGia.Text = "In kèm giá"
        Me.btnInKemGia.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripLabel2.Text = "Trang:"
        '
        'btnQuaTraiTatCa
        '
        Me.btnQuaTraiTatCa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnQuaTraiTatCa.Image = Global.PhanMemBanHang.My.Resources.Resources.Qua_Trai_Tat_Ca_16
        Me.btnQuaTraiTatCa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuaTraiTatCa.Name = "btnQuaTraiTatCa"
        Me.btnQuaTraiTatCa.Size = New System.Drawing.Size(23, 22)
        Me.btnQuaTraiTatCa.Text = "Trang đầu tiên"
        '
        'btnQuaTrai1
        '
        Me.btnQuaTrai1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnQuaTrai1.Image = Global.PhanMemBanHang.My.Resources.Resources.Qua_Trai_161
        Me.btnQuaTrai1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuaTrai1.Name = "btnQuaTrai1"
        Me.btnQuaTrai1.Size = New System.Drawing.Size(23, 22)
        Me.btnQuaTrai1.Text = "Trang trước"
        '
        'txtSoTrang
        '
        Me.txtSoTrang.Name = "txtSoTrang"
        Me.txtSoTrang.Size = New System.Drawing.Size(30, 25)
        Me.txtSoTrang.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel3.Text = "/"
        '
        'lblTongSoTrang
        '
        Me.lblTongSoTrang.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblTongSoTrang.Name = "lblTongSoTrang"
        Me.lblTongSoTrang.ReadOnly = True
        Me.lblTongSoTrang.Size = New System.Drawing.Size(30, 25)
        Me.lblTongSoTrang.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnQuaPhai1
        '
        Me.btnQuaPhai1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnQuaPhai1.Image = Global.PhanMemBanHang.My.Resources.Resources.Qua_Phai_16
        Me.btnQuaPhai1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuaPhai1.Name = "btnQuaPhai1"
        Me.btnQuaPhai1.Size = New System.Drawing.Size(23, 22)
        Me.btnQuaPhai1.Text = "Trang sau"
        '
        'btnQuaPhaiTatCa
        '
        Me.btnQuaPhaiTatCa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnQuaPhaiTatCa.Image = Global.PhanMemBanHang.My.Resources.Resources.Qua_Phai_Tat_Ca_16
        Me.btnQuaPhaiTatCa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuaPhaiTatCa.Name = "btnQuaPhaiTatCa"
        Me.btnQuaPhaiTatCa.Size = New System.Drawing.Size(23, 22)
        Me.btnQuaPhaiTatCa.Text = "Trang cuối"
        '
        'txtSoDongTrenMotTrang
        '
        Me.txtSoDongTrenMotTrang.Name = "txtSoDongTrenMotTrang"
        Me.txtSoDongTrenMotTrang.Size = New System.Drawing.Size(30, 25)
        Me.txtSoDongTrenMotTrang.Text = "30"
        Me.txtSoDongTrenMotTrang.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel4.Text = "x"
        '
        'lblTongSoTrang2
        '
        Me.lblTongSoTrang2.Name = "lblTongSoTrang2"
        Me.lblTongSoTrang2.Size = New System.Drawing.Size(13, 22)
        Me.lblTongSoTrang2.Text = "0"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(15, 22)
        Me.ToolStripLabel5.Text = "="
        '
        'lblTongSoLuong
        '
        Me.lblTongSoLuong.Name = "lblTongSoLuong"
        Me.lblTongSoLuong.Size = New System.Drawing.Size(13, 22)
        Me.lblTongSoLuong.Text = "0"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaVachSanPham, Me.MaSanPham, Me.TenSanPham, Me.DonVi, Me.GiaBan, Me.NgayNiemYet, Me.SoLuong, Me.GiaBinhQuan, Me.GiaTriHienTai, Me.PhanTramBan, Me.PhanTramNhap, Me.TonMin, Me.KhoiLuongRieng, Me.KyHieuKho, Me.tbLoaiSanPham, Me.NgayTao, Me.ThoiGianBaoHanh, Me.MoTa, Me.CanhBao, Me.HetBan})
        Me.dgvMain.DataSource = Me.bsSanPham
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Editing = False
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMain.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(1171, 522)
        Me.dgvMain.TabIndex = 5
        Me.dgvMain.VirtualMode = True
        '
        'bsSanPham
        '
        Me.bsSanPham.DataSource = GetType(PhanMemBanHang.vwSanPham)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tbNhomSanPham"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nhóm Sản Phẩm"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TenLoaiSanPham"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Loại Sản Phẩm"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'STT
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STT.DefaultCellStyle = DataGridViewCellStyle1
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 40
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'MaVachSanPham
        '
        Me.MaVachSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaVachSanPham.DataPropertyName = "MaVachSanPham"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red
        Me.MaVachSanPham.DefaultCellStyle = DataGridViewCellStyle2
        Me.MaVachSanPham.HeaderText = "Mã vạch"
        Me.MaVachSanPham.Name = "MaVachSanPham"
        Me.MaVachSanPham.ReadOnly = True
        Me.MaVachSanPham.Visible = False
        Me.MaVachSanPham.Width = 81
        '
        'MaSanPham
        '
        Me.MaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaSanPham.DataPropertyName = "MaSanPham"
        Me.MaSanPham.HeaderText = "Mã "
        Me.MaSanPham.Name = "MaSanPham"
        Me.MaSanPham.ReadOnly = True
        Me.MaSanPham.Width = 53
        '
        'TenSanPham
        '
        Me.TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenSanPham.DataPropertyName = "TenSanPham"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue
        Me.TenSanPham.DefaultCellStyle = DataGridViewCellStyle3
        Me.TenSanPham.HeaderText = "Tên sản phẩm"
        Me.TenSanPham.MinimumWidth = 100
        Me.TenSanPham.Name = "TenSanPham"
        Me.TenSanPham.ReadOnly = True
        Me.TenSanPham.Width = 111
        '
        'DonVi
        '
        Me.DonVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DonVi.DataPropertyName = "DonVi"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DonVi.DefaultCellStyle = DataGridViewCellStyle4
        Me.DonVi.HeaderText = "ĐVT"
        Me.DonVi.MinimumWidth = 40
        Me.DonVi.Name = "DonVi"
        Me.DonVi.ReadOnly = True
        Me.DonVi.Width = 58
        '
        'GiaBan
        '
        Me.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GiaBan.DataPropertyName = "GiaNiemYet"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Format = "N0"
        Me.GiaBan.DefaultCellStyle = DataGridViewCellStyle5
        Me.GiaBan.HeaderText = "Giá gốc"
        Me.GiaBan.MinimumWidth = 60
        Me.GiaBan.Name = "GiaBan"
        Me.GiaBan.ReadOnly = True
        Me.GiaBan.Width = 76
        '
        'NgayNiemYet
        '
        Me.NgayNiemYet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NgayNiemYet.DataPropertyName = "NgayNiemYet"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "dd/MM/yy"
        Me.NgayNiemYet.DefaultCellStyle = DataGridViewCellStyle6
        Me.NgayNiemYet.HeaderText = "Ngày N.Y"
        Me.NgayNiemYet.Name = "NgayNiemYet"
        Me.NgayNiemYet.ReadOnly = True
        Me.NgayNiemYet.Width = 86
        '
        'SoLuong
        '
        Me.SoLuong.DataPropertyName = "SoLuong"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        Me.SoLuong.DefaultCellStyle = DataGridViewCellStyle7
        Me.SoLuong.HeaderText = "Tồn kho"
        Me.SoLuong.MinimumWidth = 40
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.ReadOnly = True
        Me.SoLuong.Width = 60
        '
        'GiaBinhQuan
        '
        Me.GiaBinhQuan.DataPropertyName = "GiaBinhQuan"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.Format = "N0"
        Me.GiaBinhQuan.DefaultCellStyle = DataGridViewCellStyle8
        Me.GiaBinhQuan.HeaderText = "Giá B.Quân"
        Me.GiaBinhQuan.MinimumWidth = 50
        Me.GiaBinhQuan.Name = "GiaBinhQuan"
        Me.GiaBinhQuan.ReadOnly = True
        Me.GiaBinhQuan.Visible = False
        Me.GiaBinhQuan.Width = 80
        '
        'GiaTriHienTai
        '
        Me.GiaTriHienTai.DataPropertyName = "GiaTriHienTai"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Format = "N0"
        Me.GiaTriHienTai.DefaultCellStyle = DataGridViewCellStyle9
        Me.GiaTriHienTai.HeaderText = "Giá trị hiện tại"
        Me.GiaTriHienTai.MinimumWidth = 50
        Me.GiaTriHienTai.Name = "GiaTriHienTai"
        Me.GiaTriHienTai.ReadOnly = True
        Me.GiaTriHienTai.Visible = False
        Me.GiaTriHienTai.Width = 90
        '
        'PhanTramBan
        '
        Me.PhanTramBan.DataPropertyName = "PhanTramBan"
        Me.PhanTramBan.HeaderText = "CK Bán"
        Me.PhanTramBan.Name = "PhanTramBan"
        Me.PhanTramBan.ReadOnly = True
        '
        'PhanTramNhap
        '
        Me.PhanTramNhap.DataPropertyName = "PhanTramNhap"
        Me.PhanTramNhap.HeaderText = "CK Nhập"
        Me.PhanTramNhap.Name = "PhanTramNhap"
        Me.PhanTramNhap.ReadOnly = True
        '
        'TonMin
        '
        Me.TonMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TonMin.DataPropertyName = "TonMin"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TonMin.DefaultCellStyle = DataGridViewCellStyle10
        Me.TonMin.HeaderText = "Tồn Min"
        Me.TonMin.Name = "TonMin"
        Me.TonMin.ReadOnly = True
        Me.TonMin.Width = 81
        '
        'KhoiLuongRieng
        '
        Me.KhoiLuongRieng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KhoiLuongRieng.DataPropertyName = "KhoiLuongRieng"
        Me.KhoiLuongRieng.HeaderText = "KL Riêng"
        Me.KhoiLuongRieng.Name = "KhoiLuongRieng"
        Me.KhoiLuongRieng.ReadOnly = True
        Me.KhoiLuongRieng.Width = 82
        '
        'KyHieuKho
        '
        Me.KyHieuKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KyHieuKho.DataPropertyName = "KyHieuKho"
        Me.KyHieuKho.HeaderText = "K.H Kho"
        Me.KyHieuKho.Name = "KyHieuKho"
        Me.KyHieuKho.ReadOnly = True
        Me.KyHieuKho.Width = 79
        '
        'tbLoaiSanPham
        '
        Me.tbLoaiSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tbLoaiSanPham.DataPropertyName = "TenLoaiSanPham"
        Me.tbLoaiSanPham.HeaderText = "Loại"
        Me.tbLoaiSanPham.MinimumWidth = 50
        Me.tbLoaiSanPham.Name = "tbLoaiSanPham"
        Me.tbLoaiSanPham.ReadOnly = True
        Me.tbLoaiSanPham.Width = 58
        '
        'NgayTao
        '
        Me.NgayTao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NgayTao.DataPropertyName = "NgayTao"
        DataGridViewCellStyle11.Format = "dd/MM/yyyy HH:mm"
        Me.NgayTao.DefaultCellStyle = DataGridViewCellStyle11
        Me.NgayTao.HeaderText = "Ngày Tạo"
        Me.NgayTao.Name = "NgayTao"
        Me.NgayTao.ReadOnly = True
        Me.NgayTao.Width = 87
        '
        'ThoiGianBaoHanh
        '
        Me.ThoiGianBaoHanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ThoiGianBaoHanh.DataPropertyName = "ThoiGianBaoHanh"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Format = "0 tháng"
        Me.ThoiGianBaoHanh.DefaultCellStyle = DataGridViewCellStyle12
        Me.ThoiGianBaoHanh.HeaderText = "Bảo hành"
        Me.ThoiGianBaoHanh.Name = "ThoiGianBaoHanh"
        Me.ThoiGianBaoHanh.ReadOnly = True
        Me.ThoiGianBaoHanh.Width = 86
        '
        'MoTa
        '
        Me.MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MoTa.DataPropertyName = "MoTa"
        Me.MoTa.HeaderText = "Mô Tả"
        Me.MoTa.MinimumWidth = 200
        Me.MoTa.Name = "MoTa"
        Me.MoTa.ReadOnly = True
        '
        'CanhBao
        '
        Me.CanhBao.DataPropertyName = "CanhBao"
        Me.CanhBao.HeaderText = "CanhBao"
        Me.CanhBao.Name = "CanhBao"
        Me.CanhBao.ReadOnly = True
        Me.CanhBao.Visible = False
        '
        'HetBan
        '
        Me.HetBan.DataPropertyName = "HetBan"
        Me.HetBan.HeaderText = "HetBan"
        Me.HetBan.Name = "HetBan"
        Me.HetBan.ReadOnly = True
        Me.HetBan.Visible = False
        '
        'ctrlDGVSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlDGVSanPham"
        Me.Size = New System.Drawing.Size(1171, 547)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsSanPham As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblSoLuong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvMain As CustomDatagridview
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnInKemGia As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents btnQuaTraiTatCa As ToolStripButton
    Friend WithEvents btnQuaTrai1 As ToolStripButton
    Friend WithEvents txtSoTrang As ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents lblTongSoTrang As ToolStripTextBox
    Friend WithEvents btnQuaPhai1 As ToolStripButton
    Friend WithEvents btnQuaPhaiTatCa As ToolStripButton
    Friend WithEvents txtSoDongTrenMotTrang As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents lblTongSoTrang2 As ToolStripLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents lblTongSoLuong As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents MaVachSanPham As DataGridViewTextBoxColumn
    Friend WithEvents MaSanPham As DataGridViewTextBoxColumn
    Friend WithEvents TenSanPham As DataGridViewTextBoxColumn
    Friend WithEvents DonVi As DataGridViewTextBoxColumn
    Friend WithEvents GiaBan As DataGridViewTextBoxColumn
    Friend WithEvents NgayNiemYet As DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As DataGridViewTextBoxColumn
    Friend WithEvents GiaBinhQuan As DataGridViewTextBoxColumn
    Friend WithEvents GiaTriHienTai As DataGridViewTextBoxColumn
    Friend WithEvents PhanTramBan As DataGridViewTextBoxColumn
    Friend WithEvents PhanTramNhap As DataGridViewTextBoxColumn
    Friend WithEvents TonMin As DataGridViewTextBoxColumn
    Friend WithEvents KhoiLuongRieng As DataGridViewTextBoxColumn
    Friend WithEvents KyHieuKho As DataGridViewTextBoxColumn
    Friend WithEvents tbLoaiSanPham As DataGridViewTextBoxColumn
    Friend WithEvents NgayTao As DataGridViewTextBoxColumn
    Friend WithEvents ThoiGianBaoHanh As DataGridViewTextBoxColumn
    Friend WithEvents MoTa As DataGridViewTextBoxColumn
    Friend WithEvents CanhBao As DataGridViewTextBoxColumn
    Friend WithEvents HetBan As DataGridViewCheckBoxColumn
End Class
