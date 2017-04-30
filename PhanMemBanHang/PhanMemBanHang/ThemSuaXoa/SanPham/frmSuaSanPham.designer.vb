<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuaSanPham))
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.ClsGroupbox1 = New PhanMemBanHang.clsGroupbox()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudBaoHanh = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudKhoiLuongRieng = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.txtKyHieuKho = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMaSanPham = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpNgayNiemYet = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDonVi = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudGiaNiemYet = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTenTrenHoaDon = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudTonMin = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudPhanTramGiaBan = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.nudPhanTramGiaNhap = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.chkisGiaCong = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkisSeri = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.btnDong = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSua = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMaSanPham = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTenSanPham = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.cmbLoaiSanPham = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatLoai = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtMaVach = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkIsKhongTinhTonKho = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkIsDanhMuc = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.ClsGroupbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsGroupbox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClsGroupbox1.Panel.SuspendLayout()
        Me.ClsGroupbox1.SuspendLayout()
        CType(Me.cmbLoaiSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.ClsGroupbox1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(510, 414)
        Me.KryptonPanel1.TabIndex = 0
        '
        'ClsGroupbox1
        '
        Me.ClsGroupbox1.BanDauThuNho = False
        Me.ClsGroupbox1.ChieuCaoMacDinh = 0
        Me.ClsGroupbox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ClsGroupbox1.DockFill = False
        Me.ClsGroupbox1.KhongMoRong = True
        Me.ClsGroupbox1.LeftHayTop = False
        Me.ClsGroupbox1.Location = New System.Drawing.Point(0, 0)
        Me.ClsGroupbox1.Name = "ClsGroupbox1"
        '
        'ClsGroupbox1.Panel
        '
        Me.ClsGroupbox1.Panel.Controls.Add(Me.chkIsKhongTinhTonKho)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.chkIsDanhMuc)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel14)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.nudBaoHanh)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel10)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.nudKhoiLuongRieng)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtKyHieuKho)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.lblMaSanPham)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.dtpNgayNiemYet)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtDonVi)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.nudGiaNiemYet)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel13)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtTenTrenHoaDon)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel11)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.nudTonMin)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.nudPhanTramGiaBan)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.nudPhanTramGiaNhap)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.chkisGiaCong)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.chkisSeri)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.btnDong)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.btnSua)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtMaSanPham)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtTenSanPham)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.cmbLoaiSanPham)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtMaVach)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel12)
        Me.ClsGroupbox1.Size = New System.Drawing.Size(510, 411)
        Me.ClsGroupbox1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top
        Me.ClsGroupbox1.TabIndex = 0
        Me.ClsGroupbox1.Values.Heading = "THÔNG TIN CHÍNH"
        Me.ClsGroupbox1.Values.Image = CType(resources.GetObject("ClsGroupbox1.Values.Image"), System.Drawing.Image)
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(3, 228)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(68, 19)
        Me.KryptonLabel14.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel14.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel14.TabIndex = 49
        Me.KryptonLabel14.Values.Text = "Bảo hành"
        '
        'nudBaoHanh
        '
        Me.nudBaoHanh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudBaoHanh.Location = New System.Drawing.Point(111, 224)
        Me.nudBaoHanh.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.nudBaoHanh.Minimum = New Decimal(New Integer() {-1530494977, 232830, 0, -2147483648})
        Me.nudBaoHanh.Name = "nudBaoHanh"
        Me.nudBaoHanh.Size = New System.Drawing.Size(153, 25)
        Me.nudBaoHanh.StateCommon.Content.Color1 = System.Drawing.Color.Black
        Me.nudBaoHanh.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBaoHanh.TabIndex = 13
        Me.nudBaoHanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudBaoHanh.ThousandsSeparator = True
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(3, 117)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(70, 19)
        Me.KryptonLabel10.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.TabIndex = 47
        Me.KryptonLabel10.Values.Text = "K.L Riêng"
        '
        'nudKhoiLuongRieng
        '
        Me.nudKhoiLuongRieng.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudKhoiLuongRieng.DecimalPlaces = 3
        Me.nudKhoiLuongRieng.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudKhoiLuongRieng.Location = New System.Drawing.Point(111, 112)
        Me.nudKhoiLuongRieng.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudKhoiLuongRieng.Name = "nudKhoiLuongRieng"
        Me.nudKhoiLuongRieng.Size = New System.Drawing.Size(153, 25)
        Me.nudKhoiLuongRieng.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nudKhoiLuongRieng.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudKhoiLuongRieng.TabIndex = 5
        Me.nudKhoiLuongRieng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudKhoiLuongRieng.ThousandsSeparator = True
        '
        'txtKyHieuKho
        '
        Me.txtKyHieuKho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKyHieuKho.Location = New System.Drawing.Point(355, 112)
        Me.txtKyHieuKho.Name = "txtKyHieuKho"
        Me.txtKyHieuKho.Size = New System.Drawing.Size(153, 26)
        Me.txtKyHieuKho.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtKyHieuKho.TabIndex = 6
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(262, 116)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(61, 19)
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 46
        Me.KryptonLabel8.Values.Text = "K.H Kho"
        '
        'lblMaSanPham
        '
        Me.lblMaSanPham.Location = New System.Drawing.Point(111, 29)
        Me.lblMaSanPham.Name = "lblMaSanPham"
        Me.lblMaSanPham.Size = New System.Drawing.Size(6, 2)
        Me.lblMaSanPham.TabIndex = 43
        Me.lblMaSanPham.Values.Text = ""
        '
        'dtpNgayNiemYet
        '
        Me.dtpNgayNiemYet.CustomFormat = "dd/MM/yy"
        Me.dtpNgayNiemYet.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayNiemYet.Location = New System.Drawing.Point(356, 193)
        Me.dtpNgayNiemYet.Name = "dtpNgayNiemYet"
        Me.dtpNgayNiemYet.Size = New System.Drawing.Size(152, 25)
        Me.dtpNgayNiemYet.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayNiemYet.TabIndex = 12
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(265, 198)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(96, 19)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 42
        Me.KryptonLabel5.Values.Text = "Ngày niêm yết"
        '
        'txtDonVi
        '
        Me.txtDonVi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDonVi.Location = New System.Drawing.Point(111, 140)
        Me.txtDonVi.Name = "txtDonVi"
        Me.txtDonVi.Size = New System.Drawing.Size(151, 26)
        Me.txtDonVi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDonVi.TabIndex = 7
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(268, 143)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 41
        Me.KryptonLabel6.Values.Text = "Giá gốc"
        '
        'nudGiaNiemYet
        '
        Me.nudGiaNiemYet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudGiaNiemYet.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudGiaNiemYet.Location = New System.Drawing.Point(355, 139)
        Me.nudGiaNiemYet.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.nudGiaNiemYet.Name = "nudGiaNiemYet"
        Me.nudGiaNiemYet.Size = New System.Drawing.Size(153, 25)
        Me.nudGiaNiemYet.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nudGiaNiemYet.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudGiaNiemYet.TabIndex = 8
        Me.nudGiaNiemYet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudGiaNiemYet.ThousandsSeparator = True
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(4, 89)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(83, 19)
        Me.KryptonLabel13.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel13.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel13.TabIndex = 40
        Me.KryptonLabel13.Values.Text = "Tên trên HĐ"
        '
        'txtTenTrenHoaDon
        '
        Me.txtTenTrenHoaDon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenTrenHoaDon.Location = New System.Drawing.Point(111, 85)
        Me.txtTenTrenHoaDon.Name = "txtTenTrenHoaDon"
        Me.txtTenTrenHoaDon.Size = New System.Drawing.Size(392, 26)
        Me.txtTenTrenHoaDon.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenTrenHoaDon.TabIndex = 4
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(3, 198)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(59, 19)
        Me.KryptonLabel11.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel11.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel11.TabIndex = 39
        Me.KryptonLabel11.Values.Text = "Tồn Min"
        '
        'nudTonMin
        '
        Me.nudTonMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudTonMin.Location = New System.Drawing.Point(111, 195)
        Me.nudTonMin.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.nudTonMin.Minimum = New Decimal(New Integer() {-1530494977, 232830, 0, -2147483648})
        Me.nudTonMin.Name = "nudTonMin"
        Me.nudTonMin.Size = New System.Drawing.Size(153, 25)
        Me.nudTonMin.StateCommon.Content.Color1 = System.Drawing.Color.Black
        Me.nudTonMin.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTonMin.TabIndex = 11
        Me.nudTonMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTonMin.ThousandsSeparator = True
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(4, 142)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(56, 19)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 38
        Me.KryptonLabel3.Values.Text = "Đơn Vị*"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(262, 169)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(72, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 36
        Me.KryptonLabel4.Values.Text = "CK % Bán"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(4, 169)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(80, 19)
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 37
        Me.KryptonLabel9.Values.Text = "CK % Nhập"
        '
        'nudPhanTramGiaBan
        '
        Me.nudPhanTramGiaBan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPhanTramGiaBan.DecimalPlaces = 2
        Me.nudPhanTramGiaBan.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPhanTramGiaBan.Location = New System.Drawing.Point(355, 166)
        Me.nudPhanTramGiaBan.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.nudPhanTramGiaBan.Minimum = New Decimal(New Integer() {1874919423, 2328306, 0, -2147483648})
        Me.nudPhanTramGiaBan.Name = "nudPhanTramGiaBan"
        Me.nudPhanTramGiaBan.Size = New System.Drawing.Size(153, 25)
        Me.nudPhanTramGiaBan.StateCommon.Content.Color1 = System.Drawing.Color.Green
        Me.nudPhanTramGiaBan.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPhanTramGiaBan.TabIndex = 10
        Me.nudPhanTramGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudPhanTramGiaBan.ThousandsSeparator = True
        '
        'nudPhanTramGiaNhap
        '
        Me.nudPhanTramGiaNhap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPhanTramGiaNhap.DecimalPlaces = 2
        Me.nudPhanTramGiaNhap.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPhanTramGiaNhap.Location = New System.Drawing.Point(111, 166)
        Me.nudPhanTramGiaNhap.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudPhanTramGiaNhap.Minimum = New Decimal(New Integer() {1215752191, 23, 0, -2147483648})
        Me.nudPhanTramGiaNhap.Name = "nudPhanTramGiaNhap"
        Me.nudPhanTramGiaNhap.Size = New System.Drawing.Size(153, 25)
        Me.nudPhanTramGiaNhap.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nudPhanTramGiaNhap.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPhanTramGiaNhap.TabIndex = 9
        Me.nudPhanTramGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudPhanTramGiaNhap.ThousandsSeparator = True
        '
        'chkisGiaCong
        '
        Me.chkisGiaCong.Location = New System.Drawing.Point(300, 256)
        Me.chkisGiaCong.Name = "chkisGiaCong"
        Me.chkisGiaCong.Size = New System.Drawing.Size(155, 19)
        Me.chkisGiaCong.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkisGiaCong.TabIndex = 15
        Me.chkisGiaCong.Values.Text = "Là sản phẩm gia công"
        '
        'chkisSeri
        '
        Me.chkisSeri.Location = New System.Drawing.Point(111, 256)
        Me.chkisSeri.Name = "chkisSeri"
        Me.chkisSeri.Size = New System.Drawing.Size(162, 19)
        Me.chkisSeri.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkisSeri.TabIndex = 14
        Me.chkisSeri.Values.Text = "Là sản phẩm có số seri"
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Location = New System.Drawing.Point(417, 347)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(90, 30)
        Me.btnDong.TabIndex = 19
        Me.btnDong.Values.Text = "ĐÓNG [F3]"
        '
        'btnSua
        '
        Me.btnSua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSua.Location = New System.Drawing.Point(323, 347)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(90, 30)
        Me.btnSua.TabIndex = 18
        Me.btnSua.Values.Text = "LƯU [F2]"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(3, 7)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(107, 19)
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 17
        Me.KryptonLabel7.Values.Text = "Loại Sản Phẩm*"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 60)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(105, 19)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 19
        Me.KryptonLabel1.Values.Text = "Tên Sản Phẩm*"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 33)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(101, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 18
        Me.KryptonLabel2.Values.Text = "Mã Sản Phẩm*"
        '
        'txtMaSanPham
        '
        Me.txtMaSanPham.Location = New System.Drawing.Point(144, 31)
        Me.txtMaSanPham.Name = "txtMaSanPham"
        Me.txtMaSanPham.Size = New System.Drawing.Size(112, 26)
        Me.txtMaSanPham.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMaSanPham.TabIndex = 1
        '
        'txtTenSanPham
        '
        Me.txtTenSanPham.Location = New System.Drawing.Point(111, 58)
        Me.txtTenSanPham.Name = "txtTenSanPham"
        Me.txtTenSanPham.Size = New System.Drawing.Size(387, 26)
        Me.txtTenSanPham.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenSanPham.TabIndex = 3
        '
        'cmbLoaiSanPham
        '
        Me.cmbLoaiSanPham.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatLoai})
        Me.cmbLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoaiSanPham.DropDownWidth = 260
        Me.cmbLoaiSanPham.Location = New System.Drawing.Point(111, 4)
        Me.cmbLoaiSanPham.Name = "cmbLoaiSanPham"
        Me.cmbLoaiSanPham.Size = New System.Drawing.Size(385, 24)
        Me.cmbLoaiSanPham.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoaiSanPham.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoaiSanPham.TabIndex = 0
        '
        'btnCapNhatLoai
        '
        Me.btnCapNhatLoai.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatLoai.UniqueName = "244F0B110D294F199ABA339D9F3F61D9"
        '
        'txtMaVach
        '
        Me.txtMaVach.Location = New System.Drawing.Point(353, 31)
        Me.txtMaVach.Name = "txtMaVach"
        Me.txtMaVach.Size = New System.Drawing.Size(150, 26)
        Me.txtMaVach.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMaVach.TabIndex = 2
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(265, 35)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(64, 19)
        Me.KryptonLabel12.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.TabIndex = 16
        Me.KryptonLabel12.Values.Text = "Mã Vạch"
        '
        'chkIsKhongTinhTonKho
        '
        Me.chkIsKhongTinhTonKho.Location = New System.Drawing.Point(300, 289)
        Me.chkIsKhongTinhTonKho.Name = "chkIsKhongTinhTonKho"
        Me.chkIsKhongTinhTonKho.Size = New System.Drawing.Size(135, 19)
        Me.chkIsKhongTinhTonKho.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsKhongTinhTonKho.TabIndex = 17
        Me.chkIsKhongTinhTonKho.Values.Text = "Không tính tồn kho"
        '
        'chkIsDanhMuc
        '
        Me.chkIsDanhMuc.Location = New System.Drawing.Point(111, 289)
        Me.chkIsDanhMuc.Name = "chkIsDanhMuc"
        Me.chkIsDanhMuc.Size = New System.Drawing.Size(163, 19)
        Me.chkIsDanhMuc.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsDanhMuc.TabIndex = 16
        Me.chkIsDanhMuc.Values.Text = "Là sản phẩm danh mục"
        '
        'frmSuaSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 414)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuaSanPham"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sửa thông tin sản phẩm"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.ClsGroupbox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClsGroupbox1.Panel.ResumeLayout(False)
        Me.ClsGroupbox1.Panel.PerformLayout()
        CType(Me.ClsGroupbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClsGroupbox1.ResumeLayout(False)
        CType(Me.cmbLoaiSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtMaVach As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbLoaiSanPham As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatLoai As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtTenSanPham As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMaSanPham As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnDong As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSua As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ClsGroupbox1 As PhanMemBanHang.clsGroupbox
    Friend WithEvents chkisGiaCong As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkisSeri As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudGiaNiemYet As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTenTrenHoaDon As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudTonMin As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudPhanTramGiaBan As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents txtDonVi As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudPhanTramGiaNhap As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents dtpNgayNiemYet As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents lblMaSanPham As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudKhoiLuongRieng As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents txtKyHieuKho As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudBaoHanh As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents chkIsKhongTinhTonKho As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkIsDanhMuc As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
