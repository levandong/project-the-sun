<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemThongTinKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXemThongTinKhachHang))
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.ClsGroupbox1 = New PhanMemBanHang.clsGroupbox()
        Me.lblSua = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.nudCongNoDauKy = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudCongNoMax = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmail = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtMaSoThue = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtSoFax = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.nudSoNgayNo = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.chkNhaCungCap = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtTenRutGon = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.linkXoaChiTietLienHe = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.lnkThemChiTietLienHe = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbNhomKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMaKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtDiaChi = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtSoDienThoai = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTenKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.bsChiTietLienHe = New System.Windows.Forms.BindingSource(Me.components)
        Me.KryptonDataGridView1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TenNguoiLienHeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDienThoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDong = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.ClsGroupbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsGroupbox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClsGroupbox1.Panel.SuspendLayout()
        Me.ClsGroupbox1.SuspendLayout()
        CType(Me.cmbNhomKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChiTietLienHe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.ClsGroupbox1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(468, 588)
        Me.KryptonPanel1.TabIndex = 0
        '
        'ClsGroupbox1
        '
        Me.ClsGroupbox1.BanDauThuNho = False
        Me.ClsGroupbox1.ChieuCaoMacDinh = 0
        Me.ClsGroupbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClsGroupbox1.DockFill = False
        Me.ClsGroupbox1.KhongMoRong = True
        Me.ClsGroupbox1.LeftHayTop = False
        Me.ClsGroupbox1.Location = New System.Drawing.Point(0, 0)
        Me.ClsGroupbox1.Name = "ClsGroupbox1"
        '
        'ClsGroupbox1.Panel
        '
        Me.ClsGroupbox1.Panel.Controls.Add(Me.btnDong)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonDataGridView1)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.lblSua)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.nudCongNoDauKy)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.nudCongNoMax)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtEmail)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtMaSoThue)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtSoFax)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.nudSoNgayNo)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.chkNhaCungCap)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.chkKhachHang)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtTenRutGon)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel14)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel13)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.linkXoaChiTietLienHe)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.lnkThemChiTietLienHe)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel15)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel10)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.cmbNhomKhachHang)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtMaKhachHang)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtDiaChi)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtSoDienThoai)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.txtTenKhachHang)
        Me.ClsGroupbox1.Panel.Controls.Add(Me.KryptonLabel12)
        Me.ClsGroupbox1.Size = New System.Drawing.Size(468, 588)
        Me.ClsGroupbox1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top
        Me.ClsGroupbox1.TabIndex = 2
        Me.ClsGroupbox1.Values.Heading = "THÔNG TIN CHÍNH"
        Me.ClsGroupbox1.Values.Image = CType(resources.GetObject("ClsGroupbox1.Values.Image"), System.Drawing.Image)
        '
        'lblSua
        '
        Me.lblSua.Location = New System.Drawing.Point(186, 301)
        Me.lblSua.Name = "lblSua"
        Me.lblSua.Size = New System.Drawing.Size(31, 20)
        Me.lblSua.TabIndex = 17
        Me.lblSua.Values.Text = "Sửa"
        Me.lblSua.Visible = False
        '
        'nudCongNoDauKy
        '
        Me.nudCongNoDauKy.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCongNoDauKy.Location = New System.Drawing.Point(91, 219)
        Me.nudCongNoDauKy.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.nudCongNoDauKy.Minimum = New Decimal(New Integer() {1874919423, 2328306, 0, -2147483648})
        Me.nudCongNoDauKy.Name = "nudCongNoDauKy"
        Me.nudCongNoDauKy.Size = New System.Drawing.Size(146, 25)
        Me.nudCongNoDauKy.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nudCongNoDauKy.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCongNoDauKy.TabIndex = 9
        Me.nudCongNoDauKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCongNoDauKy.ThousandsSeparator = True
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(6, 222)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(71, 19)
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 69
        Me.KryptonLabel9.Values.Text = "Nợ đầu kỳ"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(243, 247)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(81, 19)
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 64
        Me.KryptonLabel6.Values.Text = "Hạn T.Toán"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(243, 217)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 65
        Me.KryptonLabel7.Values.Text = "Nợ Max"
        '
        'nudCongNoMax
        '
        Me.nudCongNoMax.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCongNoMax.Location = New System.Drawing.Point(327, 217)
        Me.nudCongNoMax.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.nudCongNoMax.Name = "nudCongNoMax"
        Me.nudCongNoMax.Size = New System.Drawing.Size(131, 25)
        Me.nudCongNoMax.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nudCongNoMax.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCongNoMax.TabIndex = 10
        Me.nudCongNoMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCongNoMax.ThousandsSeparator = True
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(6, 247)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(77, 19)
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 67
        Me.KryptonLabel8.Values.Text = "Mã số thuế"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(6, 276)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 66
        Me.KryptonLabel4.Values.Text = "Email"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(243, 276)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(53, 19)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 63
        Me.KryptonLabel5.Values.Text = "Số Fax"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(91, 274)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(145, 23)
        Me.txtEmail.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtEmail.TabIndex = 13
        '
        'txtMaSoThue
        '
        Me.txtMaSoThue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaSoThue.Location = New System.Drawing.Point(91, 245)
        Me.txtMaSoThue.Name = "txtMaSoThue"
        Me.txtMaSoThue.Size = New System.Drawing.Size(145, 23)
        Me.txtMaSoThue.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMaSoThue.TabIndex = 11
        '
        'txtSoFax
        '
        Me.txtSoFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoFax.Location = New System.Drawing.Point(326, 275)
        Me.txtSoFax.Name = "txtSoFax"
        Me.txtSoFax.Size = New System.Drawing.Size(132, 23)
        Me.txtSoFax.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtSoFax.TabIndex = 14
        '
        'nudSoNgayNo
        '
        Me.nudSoNgayNo.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudSoNgayNo.Location = New System.Drawing.Point(326, 246)
        Me.nudSoNgayNo.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.nudSoNgayNo.Name = "nudSoNgayNo"
        Me.nudSoNgayNo.Size = New System.Drawing.Size(131, 25)
        Me.nudSoNgayNo.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nudSoNgayNo.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSoNgayNo.TabIndex = 12
        Me.nudSoNgayNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSoNgayNo.ThousandsSeparator = True
        '
        'chkNhaCungCap
        '
        Me.chkNhaCungCap.Location = New System.Drawing.Point(283, 111)
        Me.chkNhaCungCap.Name = "chkNhaCungCap"
        Me.chkNhaCungCap.Size = New System.Drawing.Size(119, 21)
        Me.chkNhaCungCap.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNhaCungCap.TabIndex = 5
        Me.chkNhaCungCap.Values.Text = "Nhà cung cấp"
        '
        'chkKhachHang
        '
        Me.chkKhachHang.Location = New System.Drawing.Point(91, 111)
        Me.chkKhachHang.Name = "chkKhachHang"
        Me.chkKhachHang.Size = New System.Drawing.Size(107, 21)
        Me.chkKhachHang.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKhachHang.TabIndex = 4
        Me.chkKhachHang.Values.Text = "Khách hàng"
        '
        'txtTenRutGon
        '
        Me.txtTenRutGon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenRutGon.Location = New System.Drawing.Point(91, 27)
        Me.txtTenRutGon.Name = "txtTenRutGon"
        Me.txtTenRutGon.Size = New System.Drawing.Size(367, 23)
        Me.txtTenRutGon.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenRutGon.TabIndex = 1
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(3, 54)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(79, 19)
        Me.KryptonLabel14.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel14.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel14.TabIndex = 50
        Me.KryptonLabel14.Values.Text = "Tên rút gọn"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(3, 109)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(36, 19)
        Me.KryptonLabel13.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel13.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel13.TabIndex = 44
        Me.KryptonLabel13.Values.Text = "Loại"
        '
        'linkXoaChiTietLienHe
        '
        Me.linkXoaChiTietLienHe.Location = New System.Drawing.Point(149, 301)
        Me.linkXoaChiTietLienHe.Name = "linkXoaChiTietLienHe"
        Me.linkXoaChiTietLienHe.Size = New System.Drawing.Size(31, 20)
        Me.linkXoaChiTietLienHe.TabIndex = 16
        Me.linkXoaChiTietLienHe.Values.Text = "Xóa"
        Me.linkXoaChiTietLienHe.Visible = False
        '
        'lnkThemChiTietLienHe
        '
        Me.lnkThemChiTietLienHe.Location = New System.Drawing.Point(102, 301)
        Me.lnkThemChiTietLienHe.Name = "lnkThemChiTietLienHe"
        Me.lnkThemChiTietLienHe.Size = New System.Drawing.Size(41, 20)
        Me.lnkThemChiTietLienHe.TabIndex = 15
        Me.lnkThemChiTietLienHe.Values.Text = "Thêm"
        Me.lnkThemChiTietLienHe.Visible = False
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(1, 302)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(95, 19)
        Me.KryptonLabel15.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel15.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel15.TabIndex = 41
        Me.KryptonLabel15.Values.Text = "Chi tiết liên hệ"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(5, 195)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(47, 19)
        Me.KryptonLabel10.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.TabIndex = 10
        Me.KryptonLabel10.Values.Text = "Nhóm"
        Me.KryptonLabel10.Visible = False
        '
        'cmbNhomKhachHang
        '
        Me.cmbNhomKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhomKhachHang.DropDownWidth = 368
        Me.cmbNhomKhachHang.Location = New System.Drawing.Point(91, 192)
        Me.cmbNhomKhachHang.Name = "cmbNhomKhachHang"
        Me.cmbNhomKhachHang.Size = New System.Drawing.Size(368, 24)
        Me.cmbNhomKhachHang.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhomKhachHang.TabIndex = 8
        Me.cmbNhomKhachHang.Visible = False
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(5, 3)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(38, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 15
        Me.KryptonLabel2.Values.Text = "Mã *"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 134)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 12
        Me.KryptonLabel1.Values.Text = "Địa Chỉ"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(5, 81)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 13
        Me.KryptonLabel3.Values.Text = "Điện Thoại"
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaKhachHang.Location = New System.Drawing.Point(91, 3)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(367, 23)
        Me.txtMaKhachHang.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMaKhachHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMaKhachHang.TabIndex = 0
        Me.txtMaKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiaChi.Location = New System.Drawing.Point(91, 134)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(367, 54)
        Me.txtDiaChi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDiaChi.TabIndex = 6
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoDienThoai.Location = New System.Drawing.Point(91, 81)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(367, 23)
        Me.txtSoDienThoai.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtSoDienThoai.TabIndex = 3
        '
        'txtTenKhachHang
        '
        Me.txtTenKhachHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenKhachHang.Location = New System.Drawing.Point(91, 54)
        Me.txtTenKhachHang.Name = "txtTenKhachHang"
        Me.txtTenKhachHang.Size = New System.Drawing.Size(367, 23)
        Me.txtTenKhachHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenKhachHang.TabIndex = 2
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(5, 27)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(43, 19)
        Me.KryptonLabel12.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.TabIndex = 14
        Me.KryptonLabel12.Values.Text = "Tên *"
        '
        'bsChiTietLienHe
        '
        Me.bsChiTietLienHe.DataSource = GetType(PhanMemBanHang.tbChiTietLienHe)
        '
        'KryptonDataGridView1
        '
        Me.KryptonDataGridView1.AllowUserToAddRows = False
        Me.KryptonDataGridView1.AllowUserToDeleteRows = False
        Me.KryptonDataGridView1.AutoGenerateColumns = False
        Me.KryptonDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenNguoiLienHeDataGridViewTextBoxColumn, Me.SoDienThoaiDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.Fill})
        Me.KryptonDataGridView1.DataSource = Me.bsChiTietLienHe
        Me.KryptonDataGridView1.Location = New System.Drawing.Point(1, 327)
        Me.KryptonDataGridView1.Name = "KryptonDataGridView1"
        Me.KryptonDataGridView1.ReadOnly = True
        Me.KryptonDataGridView1.RowHeadersWidth = 5
        Me.KryptonDataGridView1.Size = New System.Drawing.Size(462, 199)
        Me.KryptonDataGridView1.TabIndex = 70
        '
        'TenNguoiLienHeDataGridViewTextBoxColumn
        '
        Me.TenNguoiLienHeDataGridViewTextBoxColumn.DataPropertyName = "TenNguoiLienHe"
        Me.TenNguoiLienHeDataGridViewTextBoxColumn.HeaderText = "Người liên hệ"
        Me.TenNguoiLienHeDataGridViewTextBoxColumn.Name = "TenNguoiLienHeDataGridViewTextBoxColumn"
        Me.TenNguoiLienHeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoDienThoaiDataGridViewTextBoxColumn
        '
        Me.SoDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai"
        Me.SoDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại"
        Me.SoDienThoaiDataGridViewTextBoxColumn.Name = "SoDienThoaiDataGridViewTextBoxColumn"
        Me.SoDienThoaiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Fill
        '
        Me.Fill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Fill.HeaderText = " "
        Me.Fill.Name = "Fill"
        Me.Fill.ReadOnly = True
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(348, 538)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(90, 25)
        Me.btnDong.TabIndex = 71
        Me.btnDong.Values.Text = "ĐÓNG [F3]"
        '
        'frmXemThongTinKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 588)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.KeyPreview = True
        Me.Name = "frmXemThongTinKhachHang"
        Me.Text = "Thông tin khách hàng"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.ClsGroupbox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClsGroupbox1.Panel.ResumeLayout(False)
        Me.ClsGroupbox1.Panel.PerformLayout()
        CType(Me.ClsGroupbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClsGroupbox1.ResumeLayout(False)
        CType(Me.cmbNhomKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChiTietLienHe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents ClsGroupbox1 As clsGroupbox
    Friend WithEvents lblSua As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents nudCongNoDauKy As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudCongNoMax As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmail As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMaSoThue As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtSoFax As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents nudSoNgayNo As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents chkNhaCungCap As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkKhachHang As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtTenRutGon As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents linkXoaChiTietLienHe As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents lnkThemChiTietLienHe As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbNhomKhachHang As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMaKhachHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDiaChi As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtSoDienThoai As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTenKhachHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bsChiTietLienHe As BindingSource
    Friend WithEvents KryptonDataGridView1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TenNguoiLienHeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoDienThoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Fill As DataGridViewTextBoxColumn
    Friend WithEvents btnDong As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
