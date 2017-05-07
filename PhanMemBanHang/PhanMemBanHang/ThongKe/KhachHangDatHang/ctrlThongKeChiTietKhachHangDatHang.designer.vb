<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThongKeChiTietKhachHangDatHang
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.chkTheoSanPham = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.chkTheoLoai = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.lblThongBao = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnHuyTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.CtrlTimKiemTheoThoiGian1 = New TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian()
        Me.cmbLoaiSanPham = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatLoai = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.bsLoaiSanPham = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmbSanPham = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatSanPham = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnTimKiemSanPham = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.bsSanPham = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.bsChiTietKhachHangDatHang = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.lblChietKhau = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.lblVAT = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTongCong = New System.Windows.Forms.ToolStripLabel()
        Me.btnInDanhSach = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCongGopSanPham = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaDatHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CongTienChiTiet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChietKhau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoTienChietKhauSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoTienVATChiTiet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNhanVienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhachHangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idKhachHangDatHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.cmbLoaiSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoaiSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChiTietKhachHangDatHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoSanPham)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoLoai)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.lblThongBao)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnHuyTimKiem)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.CtrlTimKiemTheoThoiGian1)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbLoaiSanPham)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnTimKiem)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbSanPham)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvMain)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1119, 494)
        Me.KryptonSplitContainer1.SplitterDistance = 247
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'chkTheoSanPham
        '
        Me.chkTheoSanPham.Location = New System.Drawing.Point(3, 132)
        Me.chkTheoSanPham.Name = "chkTheoSanPham"
        Me.chkTheoSanPham.Size = New System.Drawing.Size(241, 25)
        Me.chkTheoSanPham.TabIndex = 55
        Me.chkTheoSanPham.Values.Text = "Theo Sản Phẩm"
        '
        'chkTheoLoai
        '
        Me.chkTheoLoai.Location = New System.Drawing.Point(3, 71)
        Me.chkTheoLoai.Name = "chkTheoLoai"
        Me.chkTheoLoai.Size = New System.Drawing.Size(241, 25)
        Me.chkTheoLoai.TabIndex = 55
        Me.chkTheoLoai.Values.Text = "Theo Loại Sản Phẩm"
        '
        'lblThongBao
        '
        Me.lblThongBao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThongBao.Location = New System.Drawing.Point(0, 241)
        Me.lblThongBao.Name = "lblThongBao"
        Me.lblThongBao.Size = New System.Drawing.Size(247, 23)
        Me.lblThongBao.StateCommon.ShortText.Color1 = System.Drawing.Color.Red
        Me.lblThongBao.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThongBao.TabIndex = 52
        Me.lblThongBao.Values.Text = "[Không tìm thấy dữ liệu phù hợp]"
        Me.lblThongBao.Visible = False
        '
        'btnHuyTimKiem
        '
        Me.btnHuyTimKiem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHuyTimKiem.Enabled = False
        Me.btnHuyTimKiem.Location = New System.Drawing.Point(3, 457)
        Me.btnHuyTimKiem.Name = "btnHuyTimKiem"
        Me.btnHuyTimKiem.Size = New System.Drawing.Size(241, 34)
        Me.btnHuyTimKiem.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnHuyTimKiem.StateCommon.Border.Rounding = 0
        Me.btnHuyTimKiem.StateCommon.Border.Width = 1
        Me.btnHuyTimKiem.TabIndex = 51
        Me.btnHuyTimKiem.Values.Text = "HUỶ TÌM KIẾM"
        '
        'CtrlTimKiemTheoThoiGian1
        '
        Me.CtrlTimKiemTheoThoiGian1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtrlTimKiemTheoThoiGian1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlTimKiemTheoThoiGian1.Name = "CtrlTimKiemTheoThoiGian1"
        Me.CtrlTimKiemTheoThoiGian1.Size = New System.Drawing.Size(247, 87)
        Me.CtrlTimKiemTheoThoiGian1.TabIndex = 3
        Me.CtrlTimKiemTheoThoiGian1.ToiLuc = New Date(2013, 7, 23, 0, 0, 0, 0)
        Me.CtrlTimKiemTheoThoiGian1.TuLuc = New Date(2013, 7, 23, 0, 0, 0, 0)
        '
        'cmbLoaiSanPham
        '
        Me.cmbLoaiSanPham.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLoaiSanPham.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatLoai})
        Me.cmbLoaiSanPham.DataSource = Me.bsLoaiSanPham
        Me.cmbLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoaiSanPham.DropDownWidth = 119
        Me.cmbLoaiSanPham.Enabled = False
        Me.cmbLoaiSanPham.Location = New System.Drawing.Point(3, 102)
        Me.cmbLoaiSanPham.Name = "cmbLoaiSanPham"
        Me.cmbLoaiSanPham.Size = New System.Drawing.Size(241, 24)
        Me.cmbLoaiSanPham.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoaiSanPham.TabIndex = 21
        '
        'btnCapNhatLoai
        '
        Me.btnCapNhatLoai.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh1616
        Me.btnCapNhatLoai.UniqueName = "CB6F1617494F42A7C8AC68B712F65E99"
        '
        'bsLoaiSanPham
        '
        Me.bsLoaiSanPham.DataSource = GetType(PhanMemBanHang.tbLoaiSanPham)
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimKiem.Location = New System.Drawing.Point(3, 198)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(241, 37)
        Me.btnTimKiem.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnTimKiem.StateCommon.Border.Rounding = 0
        Me.btnTimKiem.StateCommon.Border.Width = 1
        Me.btnTimKiem.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.TabIndex = 29
        Me.btnTimKiem.Values.Text = "TÌM KIẾM"
        '
        'cmbSanPham
        '
        Me.cmbSanPham.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSanPham.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatSanPham, Me.btnTimKiemSanPham})
        Me.cmbSanPham.DataSource = Me.bsSanPham
        Me.cmbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSanPham.DropDownWidth = 119
        Me.cmbSanPham.Enabled = False
        Me.cmbSanPham.Location = New System.Drawing.Point(3, 163)
        Me.cmbSanPham.Name = "cmbSanPham"
        Me.cmbSanPham.Size = New System.Drawing.Size(241, 24)
        Me.cmbSanPham.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSanPham.TabIndex = 21
        '
        'btnCapNhatSanPham
        '
        Me.btnCapNhatSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh1616
        Me.btnCapNhatSanPham.UniqueName = "A7722BAE0DE141735EAA1006FE86185C"
        '
        'btnTimKiemSanPham
        '
        Me.btnTimKiemSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiemMoi16
        Me.btnTimKiemSanPham.UniqueName = "98845E5B67544D3662A75D7A56CF1C42"
        '
        'bsSanPham
        '
        Me.bsSanPham.DataSource = GetType(PhanMemBanHang.tbSanPham)
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.DataGridViewTextBoxColumn1, Me.MaDatHang, Me.MaSanPham, Me.TenSanPham, Me.DonGiaDataGridViewTextBoxColumn, Me.SoLuongDataGridViewTextBoxColumn, Me.CongTienChiTiet, Me.ChietKhau, Me.SoTienChietKhauSanPham, Me.VAT, Me.SoTienVATChiTiet, Me.ThanhTien, Me.TenNhanVienDataGridViewTextBoxColumn, Me.TenKhachHangDataGridViewTextBoxColumn, Me.GhiChu, Me.idKhachHangDatHang})
        Me.dgvMain.DataSource = Me.bsChiTietKhachHangDatHang
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMain.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMain.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        Me.dgvMain.Size = New System.Drawing.Size(867, 469)
        Me.dgvMain.TabIndex = 2
        Me.dgvMain.VirtualMode = True
        '
        'bsChiTietKhachHangDatHang
        '
        Me.bsChiTietKhachHangDatHang.DataSource = GetType(PhanMemBanHang.vwChiTietKhachHangDatHang)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoLuong, Me.ToolStripSeparator5, Me.ToolStripLabel7, Me.lblCong, Me.ToolStripSeparator1, Me.ToolStripLabel5, Me.lblChietKhau, Me.ToolStripSeparator7, Me.ToolStripLabel3, Me.lblVAT, Me.ToolStripSeparator9, Me.ToolStripLabel1, Me.lblTongCong, Me.btnInDanhSach, Me.ToolStripSeparator2, Me.btnCongGopSanPham, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 469)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(867, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(15, 22)
        Me.lblSoLuong.Text = "0"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel7.Text = "Cộng:"
        '
        'lblCong
        '
        Me.lblCong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCong.ForeColor = System.Drawing.Color.Red
        Me.lblCong.Name = "lblCong"
        Me.lblCong.Size = New System.Drawing.Size(25, 22)
        Me.lblCong.Text = "0đ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(28, 22)
        Me.ToolStripLabel5.Text = "CK:"
        '
        'lblChietKhau
        '
        Me.lblChietKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChietKhau.ForeColor = System.Drawing.Color.Red
        Me.lblChietKhau.Name = "lblChietKhau"
        Me.lblChietKhau.Size = New System.Drawing.Size(25, 22)
        Me.lblChietKhau.Text = "0đ"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel3.Text = "VAT:"
        '
        'lblVAT
        '
        Me.lblVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.ForeColor = System.Drawing.Color.Red
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(25, 22)
        Me.lblVAT.Text = "0đ"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel1.Text = "Tổng:"
        '
        'lblTongCong
        '
        Me.lblTongCong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTongCong.Name = "lblTongCong"
        Me.lblTongCong.Size = New System.Drawing.Size(25, 22)
        Me.lblTongCong.Text = "0đ"
        '
        'btnInDanhSach
        '
        Me.btnInDanhSach.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnInDanhSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInDanhSach.Image = Global.PhanMemBanHang.My.Resources.Resources.Print16
        Me.btnInDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInDanhSach.Name = "btnInDanhSach"
        Me.btnInDanhSach.Size = New System.Drawing.Size(103, 22)
        Me.btnInDanhSach.Text = "In danh sách"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCongGopSanPham
        '
        Me.btnCongGopSanPham.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCongGopSanPham.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCongGopSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.sum16
        Me.btnCongGopSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCongGopSanPham.Name = "btnCongGopSanPham"
        Me.btnCongGopSanPham.Size = New System.Drawing.Size(87, 22)
        Me.btnCongGopSanPham.Text = "Cộng gộp"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'STT
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STT.DefaultCellStyle = DataGridViewCellStyle1
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NgayLap"
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ngày Lập"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'MaDatHang
        '
        Me.MaDatHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaDatHang.DataPropertyName = "MaDatHang"
        Me.MaDatHang.HeaderText = "Mã ĐH"
        Me.MaDatHang.Name = "MaDatHang"
        Me.MaDatHang.ReadOnly = True
        Me.MaDatHang.Width = 73
        '
        'MaSanPham
        '
        Me.MaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaSanPham.DataPropertyName = "MaSanPham"
        Me.MaSanPham.HeaderText = "Mã hàng"
        Me.MaSanPham.Name = "MaSanPham"
        Me.MaSanPham.ReadOnly = True
        Me.MaSanPham.Width = 83
        '
        'TenSanPham
        '
        Me.TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenSanPham.DataPropertyName = "TenSanPham"
        Me.TenSanPham.HeaderText = "Tên hàng"
        Me.TenSanPham.Name = "TenSanPham"
        Me.TenSanPham.ReadOnly = True
        Me.TenSanPham.Width = 86
        '
        'DonGiaDataGridViewTextBoxColumn
        '
        Me.DonGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Format = "N0"
        Me.DonGiaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DonGiaDataGridViewTextBoxColumn.HeaderText = "Đơn Giá"
        Me.DonGiaDataGridViewTextBoxColumn.MinimumWidth = 80
        Me.DonGiaDataGridViewTextBoxColumn.Name = "DonGiaDataGridViewTextBoxColumn"
        Me.DonGiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DonGiaDataGridViewTextBoxColumn.Width = 90
        '
        'SoLuongDataGridViewTextBoxColumn
        '
        Me.SoLuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "###,###,###,##0.###,###"
        Me.SoLuongDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SoLuongDataGridViewTextBoxColumn.HeaderText = "SL"
        Me.SoLuongDataGridViewTextBoxColumn.MinimumWidth = 40
        Me.SoLuongDataGridViewTextBoxColumn.Name = "SoLuongDataGridViewTextBoxColumn"
        Me.SoLuongDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongDataGridViewTextBoxColumn.Width = 48
        '
        'CongTienChiTiet
        '
        Me.CongTienChiTiet.DataPropertyName = "CongTienChiTiet"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Format = "N0"
        Me.CongTienChiTiet.DefaultCellStyle = DataGridViewCellStyle5
        Me.CongTienChiTiet.HeaderText = "Số Tiền"
        Me.CongTienChiTiet.MinimumWidth = 90
        Me.CongTienChiTiet.Name = "CongTienChiTiet"
        Me.CongTienChiTiet.ReadOnly = True
        Me.CongTienChiTiet.Width = 90
        '
        'ChietKhau
        '
        Me.ChietKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ChietKhau.DataPropertyName = "ChietKhau"
        Me.ChietKhau.HeaderText = "CK"
        Me.ChietKhau.Name = "ChietKhau"
        Me.ChietKhau.ReadOnly = True
        Me.ChietKhau.Width = 51
        '
        'SoTienChietKhauSanPham
        '
        Me.SoTienChietKhauSanPham.DataPropertyName = "SoTienChietKhauSanPham"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        Me.SoTienChietKhauSanPham.DefaultCellStyle = DataGridViewCellStyle6
        Me.SoTienChietKhauSanPham.HeaderText = "Tiền CK"
        Me.SoTienChietKhauSanPham.MinimumWidth = 80
        Me.SoTienChietKhauSanPham.Name = "SoTienChietKhauSanPham"
        Me.SoTienChietKhauSanPham.ReadOnly = True
        Me.SoTienChietKhauSanPham.Width = 80
        '
        'VAT
        '
        Me.VAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VAT.DataPropertyName = "VAT"
        Me.VAT.HeaderText = "VAT"
        Me.VAT.Name = "VAT"
        Me.VAT.ReadOnly = True
        Me.VAT.Width = 58
        '
        'SoTienVATChiTiet
        '
        Me.SoTienVATChiTiet.DataPropertyName = "SoTienVATChiTiet"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle7.Format = "N0"
        Me.SoTienVATChiTiet.DefaultCellStyle = DataGridViewCellStyle7
        Me.SoTienVATChiTiet.HeaderText = "Tiền VAT"
        Me.SoTienVATChiTiet.MinimumWidth = 80
        Me.SoTienVATChiTiet.Name = "SoTienVATChiTiet"
        Me.SoTienVATChiTiet.ReadOnly = True
        Me.SoTienVATChiTiet.Width = 80
        '
        'ThanhTien
        '
        Me.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ThanhTien.DataPropertyName = "ThanhTien"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.Format = "N0"
        Me.ThanhTien.DefaultCellStyle = DataGridViewCellStyle8
        Me.ThanhTien.HeaderText = "Thành Tiền"
        Me.ThanhTien.Name = "ThanhTien"
        Me.ThanhTien.ReadOnly = True
        Me.ThanhTien.Width = 96
        '
        'TenNhanVienDataGridViewTextBoxColumn
        '
        Me.TenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien"
        Me.TenNhanVienDataGridViewTextBoxColumn.HeaderText = "Nhân Viên"
        Me.TenNhanVienDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.TenNhanVienDataGridViewTextBoxColumn.Name = "TenNhanVienDataGridViewTextBoxColumn"
        Me.TenNhanVienDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenNhanVienDataGridViewTextBoxColumn.Width = 120
        '
        'TenKhachHangDataGridViewTextBoxColumn
        '
        Me.TenKhachHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang"
        Me.TenKhachHangDataGridViewTextBoxColumn.HeaderText = "Khách Hàng"
        Me.TenKhachHangDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.TenKhachHangDataGridViewTextBoxColumn.Name = "TenKhachHangDataGridViewTextBoxColumn"
        Me.TenKhachHangDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenKhachHangDataGridViewTextBoxColumn.Width = 101
        '
        'GhiChu
        '
        Me.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChu.DataPropertyName = "GhiChu"
        Me.GhiChu.HeaderText = "Ghi Chú"
        Me.GhiChu.MinimumWidth = 150
        Me.GhiChu.Name = "GhiChu"
        Me.GhiChu.ReadOnly = True
        '
        'idKhachHangDatHang
        '
        Me.idKhachHangDatHang.DataPropertyName = "idKhachHangDatHang"
        Me.idKhachHangDatHang.HeaderText = "idKhachHangDatHang"
        Me.idKhachHangDatHang.Name = "idKhachHangDatHang"
        Me.idKhachHangDatHang.ReadOnly = True
        Me.idKhachHangDatHang.Visible = False
        '
        'ctrlThongKeChiTietKhachHangDatHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctrlThongKeChiTietKhachHangDatHang"
        Me.Size = New System.Drawing.Size(1119, 494)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.cmbLoaiSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoaiSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChiTietKhachHangDatHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bsChiTietKhachHangDatHang As System.Windows.Forms.BindingSource
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsSanPham As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblTongCong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnInDanhSach As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCongGopSanPham As System.Windows.Forms.ToolStripButton
    Friend WithEvents CtrlTimKiemTheoThoiGian1 As TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian
    Friend WithEvents IdSanPhamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoKhachHangDatHangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaSanPhamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSanPhamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonViDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GiaBanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThanhTienDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdKhachHangDatHangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GioVaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayLapDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GioRaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSoLuong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbSanPham As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatSanPham As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnTimKiemSanPham As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblThongBao As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnHuyTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents IdCuaHangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSanPhamCuaHangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChietKhauSanPhamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoTaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GhiChuSanPhamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bsLoaiSanPham As System.Windows.Forms.BindingSource
    Friend WithEvents chkTheoSanPham As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Public WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Public WithEvents lblCong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Public WithEvents lblChietKhau As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Public WithEvents lblVAT As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkTheoLoai As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents cmbLoaiSanPham As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatLoai As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaKhachHangDatHang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaDatHang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaSanPham As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSanPham As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CongTienChiTiet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChietKhau As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoTienChietKhauSanPham As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoTienVATChiTiet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThanhTien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenNhanVienDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenKhachHangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idKhachHangDatHang As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
