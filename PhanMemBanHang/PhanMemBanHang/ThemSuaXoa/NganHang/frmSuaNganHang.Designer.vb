
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSuaNganHang
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
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
    'Khai báo control

    Friend WithEvents pnlMain As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnSua As ComponentFactory.Krypton.Toolkit.KryptonButton
    ' khai báo
    Friend WithEvents txtTenNganHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTenNganHang As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSoTaiKhoan As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblSoTaiKhoan As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtChiNhanh As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblChiNhanh As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtGhiChu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblGhiChu As ComponentFactory.Krypton.Toolkit.KryptonLabel

    'InitializeComponent
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlMain = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.cmbLoaiNganHang = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTenTaiKhoan = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSoDienThoai = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTenChuTaiKhoan = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtDiaChi = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.vndTienChu = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.vndNoiDung = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtRDLC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnChonDuongDan = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.pctLogo = New System.Windows.Forms.PictureBox()
        Me.nudSoDuDauKy = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMaNganHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTenNganHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtSoTaiKhoan = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtChiNhanh = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtGhiChu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnSua = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblTenNganHang = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSoTaiKhoan = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblChiNhanh = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblGhiChu = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpNgayNhap = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.cmbLoaiNganHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.dtpNgayNhap)
        Me.pnlMain.Controls.Add(Me.cmbLoaiNganHang)
        Me.pnlMain.Controls.Add(Me.KryptonLabel8)
        Me.pnlMain.Controls.Add(Me.txtTenTaiKhoan)
        Me.pnlMain.Controls.Add(Me.KryptonLabel10)
        Me.pnlMain.Controls.Add(Me.txtSoDienThoai)
        Me.pnlMain.Controls.Add(Me.KryptonLabel7)
        Me.pnlMain.Controls.Add(Me.txtTenChuTaiKhoan)
        Me.pnlMain.Controls.Add(Me.txtDiaChi)
        Me.pnlMain.Controls.Add(Me.KryptonLabel5)
        Me.pnlMain.Controls.Add(Me.KryptonLabel6)
        Me.pnlMain.Controls.Add(Me.KryptonLabel4)
        Me.pnlMain.Controls.Add(Me.KryptonLabel3)
        Me.pnlMain.Controls.Add(Me.vndTienChu)
        Me.pnlMain.Controls.Add(Me.vndNoiDung)
        Me.pnlMain.Controls.Add(Me.KryptonLabel2)
        Me.pnlMain.Controls.Add(Me.txtRDLC)
        Me.pnlMain.Controls.Add(Me.pctLogo)
        Me.pnlMain.Controls.Add(Me.nudSoDuDauKy)
        Me.pnlMain.Controls.Add(Me.KryptonLabel9)
        Me.pnlMain.Controls.Add(Me.txtMaNganHang)
        Me.pnlMain.Controls.Add(Me.KryptonLabel1)
        Me.pnlMain.Controls.Add(Me.txtTenNganHang)
        Me.pnlMain.Controls.Add(Me.txtSoTaiKhoan)
        Me.pnlMain.Controls.Add(Me.txtChiNhanh)
        Me.pnlMain.Controls.Add(Me.txtGhiChu)
        Me.pnlMain.Controls.Add(Me.btnSua)
        Me.pnlMain.Controls.Add(Me.lblTenNganHang)
        Me.pnlMain.Controls.Add(Me.lblSoTaiKhoan)
        Me.pnlMain.Controls.Add(Me.lblChiNhanh)
        Me.pnlMain.Controls.Add(Me.lblGhiChu)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(426, 421)
        Me.pnlMain.TabIndex = 0
        '
        'cmbLoaiNganHang
        '
        Me.cmbLoaiNganHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoaiNganHang.DropDownWidth = 351
        Me.cmbLoaiNganHang.Location = New System.Drawing.Point(108, 301)
        Me.cmbLoaiNganHang.Name = "cmbLoaiNganHang"
        Me.cmbLoaiNganHang.Size = New System.Drawing.Size(312, 24)
        Me.cmbLoaiNganHang.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoaiNganHang.TabIndex = 12
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(10, 305)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(103, 19)
        Me.KryptonLabel8.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel8.TabIndex = 125
        Me.KryptonLabel8.Values.Text = "Loại ngân hàng"
        '
        'txtTenTaiKhoan
        '
        Me.txtTenTaiKhoan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenTaiKhoan.Location = New System.Drawing.Point(108, 6)
        Me.txtTenTaiKhoan.MaxLength = 1300
        Me.txtTenTaiKhoan.Name = "txtTenTaiKhoan"
        Me.txtTenTaiKhoan.Size = New System.Drawing.Size(312, 23)
        Me.txtTenTaiKhoan.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenTaiKhoan.TabIndex = 0
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(10, 10)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(92, 19)
        Me.KryptonLabel10.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel10.TabIndex = 123
        Me.KryptonLabel10.Values.Text = "Tên tài khoản"
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoDienThoai.Location = New System.Drawing.Point(108, 167)
        Me.txtSoDienThoai.MaxLength = 1000
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(312, 23)
        Me.txtSoDienThoai.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtSoDienThoai.TabIndex = 6
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(10, 174)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(71, 19)
        Me.KryptonLabel7.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel7.TabIndex = 121
        Me.KryptonLabel7.Values.Text = "Điện thoại"
        '
        'txtTenChuTaiKhoan
        '
        Me.txtTenChuTaiKhoan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenChuTaiKhoan.Location = New System.Drawing.Point(108, 34)
        Me.txtTenChuTaiKhoan.MaxLength = 13000
        Me.txtTenChuTaiKhoan.Name = "txtTenChuTaiKhoan"
        Me.txtTenChuTaiKhoan.Size = New System.Drawing.Size(312, 23)
        Me.txtTenChuTaiKhoan.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenChuTaiKhoan.TabIndex = 1
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiaChi.Location = New System.Drawing.Point(108, 62)
        Me.txtDiaChi.MaxLength = 19000
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(312, 23)
        Me.txtDiaChi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDiaChi.TabIndex = 2
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(10, 37)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(93, 19)
        Me.KryptonLabel5.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel5.TabIndex = 118
        Me.KryptonLabel5.Values.Text = "Chủ tài khoản"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(10, 65)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel6.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel6.TabIndex = 119
        Me.KryptonLabel6.Values.Text = "Địa chỉ"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(142, 392)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(65, 19)
        Me.KryptonLabel4.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel4.TabIndex = 115
        Me.KryptonLabel4.Values.Text = "Tiền Chữ"
        Me.KryptonLabel4.Visible = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(142, 362)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel3.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel3.TabIndex = 114
        Me.KryptonLabel3.Values.Text = "Nội Dung"
        Me.KryptonLabel3.Visible = False
        '
        'vndTienChu
        '
        Me.vndTienChu.Location = New System.Drawing.Point(215, 387)
        Me.vndTienChu.Name = "vndTienChu"
        Me.vndTienChu.Size = New System.Drawing.Size(71, 24)
        Me.vndTienChu.StateCommon.Content.Color1 = System.Drawing.Color.Red
        Me.vndTienChu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vndTienChu.TabIndex = 11
        Me.vndTienChu.Tag = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndTienChu.Text = "0"
        Me.vndTienChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vndTienChu.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndTienChu.Visible = False
        '
        'vndNoiDung
        '
        Me.vndNoiDung.Location = New System.Drawing.Point(215, 357)
        Me.vndNoiDung.Name = "vndNoiDung"
        Me.vndNoiDung.Size = New System.Drawing.Size(71, 24)
        Me.vndNoiDung.StateCommon.Content.Color1 = System.Drawing.Color.Red
        Me.vndNoiDung.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vndNoiDung.TabIndex = 10
        Me.vndNoiDung.Tag = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndNoiDung.Text = "0"
        Me.vndNoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vndNoiDung.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndNoiDung.Visible = False
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(10, 282)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel2.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel2.TabIndex = 110
        Me.KryptonLabel2.Values.Text = "Đường dẫn"
        '
        'txtRDLC
        '
        Me.txtRDLC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRDLC.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnChonDuongDan})
        Me.txtRDLC.Location = New System.Drawing.Point(108, 274)
        Me.txtRDLC.Name = "txtRDLC"
        Me.txtRDLC.ReadOnly = True
        Me.txtRDLC.Size = New System.Drawing.Size(312, 26)
        Me.txtRDLC.TabIndex = 11
        '
        'btnChonDuongDan
        '
        Me.btnChonDuongDan.Text = "..."
        Me.btnChonDuongDan.UniqueName = "E7A2838CBF50462156AB0BA053D5B6EA"
        '
        'pctLogo
        '
        Me.pctLogo.BackColor = System.Drawing.Color.Transparent
        Me.pctLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctLogo.Location = New System.Drawing.Point(5, 340)
        Me.pctLogo.Name = "pctLogo"
        Me.pctLogo.Size = New System.Drawing.Size(128, 78)
        Me.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLogo.TabIndex = 109
        Me.pctLogo.TabStop = False
        Me.pctLogo.Visible = False
        '
        'nudSoDuDauKy
        '
        Me.nudSoDuDauKy.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudSoDuDauKy.Location = New System.Drawing.Point(108, 195)
        Me.nudSoDuDauKy.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.nudSoDuDauKy.Minimum = New Decimal(New Integer() {1874919423, 2328306, 0, -2147483648})
        Me.nudSoDuDauKy.Name = "nudSoDuDauKy"
        Me.nudSoDuDauKy.Size = New System.Drawing.Size(178, 25)
        Me.nudSoDuDauKy.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nudSoDuDauKy.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSoDuDauKy.TabIndex = 7
        Me.nudSoDuDauKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSoDuDauKy.ThousandsSeparator = True
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(10, 201)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(88, 19)
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 106
        Me.KryptonLabel9.Values.Text = "Số dư đầu kỳ"
        '
        'txtMaNganHang
        '
        Me.txtMaNganHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaNganHang.Location = New System.Drawing.Point(108, 247)
        Me.txtMaNganHang.MaxLength = 10
        Me.txtMaNganHang.Name = "txtMaNganHang"
        Me.txtMaNganHang.Size = New System.Drawing.Size(312, 23)
        Me.txtMaNganHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMaNganHang.TabIndex = 10
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(10, 253)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(58, 19)
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel1.TabIndex = 104
        Me.KryptonLabel1.Values.Text = "Ký Hiệu"
        '
        'txtTenNganHang
        '
        Me.txtTenNganHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenNganHang.Location = New System.Drawing.Point(108, 89)
        Me.txtTenNganHang.MaxLength = 130
        Me.txtTenNganHang.Name = "txtTenNganHang"
        Me.txtTenNganHang.Size = New System.Drawing.Size(312, 23)
        Me.txtTenNganHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenNganHang.TabIndex = 3
        '
        'txtSoTaiKhoan
        '
        Me.txtSoTaiKhoan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoTaiKhoan.Location = New System.Drawing.Point(108, 114)
        Me.txtSoTaiKhoan.MaxLength = 30
        Me.txtSoTaiKhoan.Name = "txtSoTaiKhoan"
        Me.txtSoTaiKhoan.Size = New System.Drawing.Size(312, 23)
        Me.txtSoTaiKhoan.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtSoTaiKhoan.TabIndex = 4
        '
        'txtChiNhanh
        '
        Me.txtChiNhanh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChiNhanh.Location = New System.Drawing.Point(108, 139)
        Me.txtChiNhanh.MaxLength = 1000
        Me.txtChiNhanh.Name = "txtChiNhanh"
        Me.txtChiNhanh.Size = New System.Drawing.Size(312, 23)
        Me.txtChiNhanh.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtChiNhanh.TabIndex = 5
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGhiChu.Location = New System.Drawing.Point(108, 221)
        Me.txtGhiChu.MaxLength = 10
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(312, 23)
        Me.txtGhiChu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtGhiChu.TabIndex = 9
        '
        'btnSua
        '
        Me.btnSua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSua.Location = New System.Drawing.Point(308, 371)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(114, 45)
        Me.btnSua.TabIndex = 13
        Me.btnSua.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua16
        Me.btnSua.Values.Text = "&SỬA [F2]"
        '
        'lblTenNganHang
        '
        Me.lblTenNganHang.Location = New System.Drawing.Point(10, 91)
        Me.lblTenNganHang.Name = "lblTenNganHang"
        Me.lblTenNganHang.Size = New System.Drawing.Size(105, 19)
        Me.lblTenNganHang.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTenNganHang.TabIndex = 0
        Me.lblTenNganHang.Values.Text = "Tên Ngân Hàng"
        '
        'lblSoTaiKhoan
        '
        Me.lblSoTaiKhoan.Location = New System.Drawing.Point(10, 116)
        Me.lblSoTaiKhoan.Name = "lblSoTaiKhoan"
        Me.lblSoTaiKhoan.Size = New System.Drawing.Size(92, 19)
        Me.lblSoTaiKhoan.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSoTaiKhoan.TabIndex = 1
        Me.lblSoTaiKhoan.Values.Text = "Số Tài Khoản"
        '
        'lblChiNhanh
        '
        Me.lblChiNhanh.Location = New System.Drawing.Point(10, 142)
        Me.lblChiNhanh.Name = "lblChiNhanh"
        Me.lblChiNhanh.Size = New System.Drawing.Size(72, 19)
        Me.lblChiNhanh.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblChiNhanh.TabIndex = 2
        Me.lblChiNhanh.Values.Text = "Chi nhánh"
        '
        'lblGhiChu
        '
        Me.lblGhiChu.Location = New System.Drawing.Point(10, 227)
        Me.lblGhiChu.Name = "lblGhiChu"
        Me.lblGhiChu.Size = New System.Drawing.Size(60, 19)
        Me.lblGhiChu.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblGhiChu.TabIndex = 3
        Me.lblGhiChu.Values.Text = "Ghi Chú"
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayNhap.Location = New System.Drawing.Point(292, 195)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(128, 25)
        Me.dtpNgayNhap.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayNhap.TabIndex = 8
        '
        'frmSuaNganHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 421)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuaNganHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.StateCommon.Header.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Sửa Ngân Hàng"
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.cmbLoaiNganHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMaNganHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudSoDuDauKy As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRDLC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnChonDuongDan As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents pctLogo As PictureBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents vndTienChu As VNDTextBox
    Friend WithEvents vndNoiDung As VNDTextBox
    Friend WithEvents txtTenChuTaiKhoan As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDiaChi As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSoDienThoai As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTenTaiKhoan As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbLoaiNganHang As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpNgayNhap As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
End Class
