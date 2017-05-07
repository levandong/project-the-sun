<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlHoaDon
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.sss = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.txtSoTaiKhoan = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbHinhThucThanhToan = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.chkCoVAT = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.nudPhi = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.nudVAT = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.btnXemPhieu = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnDongY = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.dtpNgayLap = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.txtKhachHangTinhCongNo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblDonVi = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtGhiChu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.vndTongCong = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.vndPhi = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.vndTienThue = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDiaChi = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMaSoThue = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSoHoaDon = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.vndTongTien = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dgvChiTietPhieuXuat = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPhamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThanhTienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsChiTietPhieuXuat = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvMain = New PhanMemBanHang.CustomDatagridview()
        Me.STTcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isHienSTT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MaSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isHienDonVi = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DonVi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isHienSoLuong = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isHienDonGia = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isHienThanhTien = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsChiTietHoaDon = New System.Windows.Forms.BindingSource(Me.components)
        Me.KryptonHeader2 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.btnXemCotAnHien = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnThemSanPham = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnXoaTatCa = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnXoa = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.sss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sss.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sss.Panel1.SuspendLayout()
        CType(Me.sss.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sss.Panel2.SuspendLayout()
        Me.sss.SuspendLayout()
        CType(Me.cmbHinhThucThanhToan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel2.SuspendLayout()
        Me.KryptonSplitContainer2.SuspendLayout()
        CType(Me.dgvChiTietPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChiTietPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChiTietHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.sss)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1298, 615)
        Me.KryptonPanel1.TabIndex = 0
        '
        'sss
        '
        Me.sss.Cursor = System.Windows.Forms.Cursors.Default
        Me.sss.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sss.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.sss.Location = New System.Drawing.Point(0, 0)
        Me.sss.Name = "sss"
        Me.sss.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'sss.Panel1
        '
        Me.sss.Panel1.Controls.Add(Me.txtSoTaiKhoan)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel12)
        Me.sss.Panel1.Controls.Add(Me.cmbHinhThucThanhToan)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel11)
        Me.sss.Panel1.Controls.Add(Me.KryptonBorderEdge1)
        Me.sss.Panel1.Controls.Add(Me.chkCoVAT)
        Me.sss.Panel1.Controls.Add(Me.nudPhi)
        Me.sss.Panel1.Controls.Add(Me.nudVAT)
        Me.sss.Panel1.Controls.Add(Me.btnXemPhieu)
        Me.sss.Panel1.Controls.Add(Me.btnDongY)
        Me.sss.Panel1.Controls.Add(Me.dtpNgayLap)
        Me.sss.Panel1.Controls.Add(Me.txtKhachHangTinhCongNo)
        Me.sss.Panel1.Controls.Add(Me.lblDonVi)
        Me.sss.Panel1.Controls.Add(Me.txtGhiChu)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.sss.Panel1.Controls.Add(Me.vndTongCong)
        Me.sss.Panel1.Controls.Add(Me.vndPhi)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.sss.Panel1.Controls.Add(Me.vndTienThue)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.sss.Panel1.Controls.Add(Me.KryptonBorderEdge2)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.sss.Panel1.Controls.Add(Me.txtDiaChi)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.sss.Panel1.Controls.Add(Me.txtMaSoThue)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.sss.Panel1.Controls.Add(Me.txtKhachHang)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.sss.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.sss.Panel1.Controls.Add(Me.txtSoHoaDon)
        Me.sss.Panel1.Controls.Add(Me.vndTongTien)
        Me.sss.Panel1.Controls.Add(Me.KryptonHeader1)
        '
        'sss.Panel2
        '
        Me.sss.Panel2.Controls.Add(Me.KryptonSplitContainer2)
        Me.sss.Panel2.Controls.Add(Me.KryptonHeader2)
        Me.sss.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.sss.Size = New System.Drawing.Size(1298, 615)
        Me.sss.SplitterDistance = 197
        Me.sss.SplitterWidth = 2
        Me.sss.TabIndex = 0
        '
        'txtSoTaiKhoan
        '
        Me.txtSoTaiKhoan.Location = New System.Drawing.Point(609, 57)
        Me.txtSoTaiKhoan.Name = "txtSoTaiKhoan"
        Me.txtSoTaiKhoan.Size = New System.Drawing.Size(157, 26)
        Me.txtSoTaiKhoan.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoTaiKhoan.TabIndex = 32
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(513, 60)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(85, 19)
        Me.KryptonLabel12.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.TabIndex = 33
        Me.KryptonLabel12.Values.Text = "Số tài khoản"
        '
        'cmbHinhThucThanhToan
        '
        Me.cmbHinhThucThanhToan.DropDownWidth = 157
        Me.cmbHinhThucThanhToan.Items.AddRange(New Object() {"TM/CK", "TM", "CK", "Tiền mặt", "Chuyển khoản"})
        Me.cmbHinhThucThanhToan.Location = New System.Drawing.Point(609, 27)
        Me.cmbHinhThucThanhToan.Name = "cmbHinhThucThanhToan"
        Me.cmbHinhThucThanhToan.Size = New System.Drawing.Size(157, 24)
        Me.cmbHinhThucThanhToan.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHinhThucThanhToan.TabIndex = 31
        Me.cmbHinhThucThanhToan.Text = "TM/CK"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(516, 32)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(87, 19)
        Me.KryptonLabel11.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel11.TabIndex = 30
        Me.KryptonLabel11.Values.Text = "Hình thức TT"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.AutoSize = False
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(509, 33)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 146)
        Me.KryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'chkCoVAT
        '
        Me.chkCoVAT.Location = New System.Drawing.Point(785, 61)
        Me.chkCoVAT.Name = "chkCoVAT"
        Me.chkCoVAT.Size = New System.Drawing.Size(19, 13)
        Me.chkCoVAT.TabIndex = 27
        Me.chkCoVAT.Values.Text = ""
        Me.chkCoVAT.Visible = False
        '
        'nudPhi
        '
        Me.nudPhi.Location = New System.Drawing.Point(876, 105)
        Me.nudPhi.Name = "nudPhi"
        Me.nudPhi.Size = New System.Drawing.Size(46, 23)
        Me.nudPhi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPhi.TabIndex = 7
        Me.nudPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudPhi.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nudVAT
        '
        Me.nudVAT.Location = New System.Drawing.Point(876, 53)
        Me.nudVAT.Name = "nudVAT"
        Me.nudVAT.Size = New System.Drawing.Size(46, 23)
        Me.nudVAT.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudVAT.TabIndex = 6
        Me.nudVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudVAT.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnXemPhieu
        '
        Me.btnXemPhieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXemPhieu.Location = New System.Drawing.Point(1148, 25)
        Me.btnXemPhieu.Name = "btnXemPhieu"
        Me.btnXemPhieu.Size = New System.Drawing.Size(131, 49)
        Me.btnXemPhieu.TabIndex = 9
        Me.btnXemPhieu.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.edit_find_replace_32X32
        Me.btnXemPhieu.Values.Text = "XEM TRƯỚC"
        '
        'btnDongY
        '
        Me.btnDongY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDongY.Location = New System.Drawing.Point(1148, 78)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(131, 49)
        Me.btnDongY.TabIndex = 10
        Me.btnDongY.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.check_24x24
        Me.btnDongY.Values.Text = "ĐỒNG Ý"
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLap.Location = New System.Drawing.Point(329, 26)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(164, 23)
        Me.dtpNgayLap.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpNgayLap.StateCommon.Content.Color1 = System.Drawing.Color.DarkRed
        Me.dtpNgayLap.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayLap.TabIndex = 1
        '
        'txtKhachHangTinhCongNo
        '
        Me.txtKhachHangTinhCongNo.Location = New System.Drawing.Point(527, 166)
        Me.txtKhachHangTinhCongNo.Name = "txtKhachHangTinhCongNo"
        Me.txtKhachHangTinhCongNo.Size = New System.Drawing.Size(582, 26)
        Me.txtKhachHangTinhCongNo.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtKhachHangTinhCongNo.StateCommon.Content.Color1 = System.Drawing.Color.Black
        Me.txtKhachHangTinhCongNo.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKhachHangTinhCongNo.TabIndex = 8
        Me.txtKhachHangTinhCongNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDonVi
        '
        Me.lblDonVi.Location = New System.Drawing.Point(527, 145)
        Me.lblDonVi.Name = "lblDonVi"
        Me.lblDonVi.Size = New System.Drawing.Size(125, 19)
        Me.lblDonVi.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonVi.TabIndex = 25
        Me.lblDonVi.Values.Text = "Đơn vị tính công nợ"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(85, 167)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(408, 26)
        Me.txtGhiChu.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtGhiChu.StateCommon.Content.Color1 = System.Drawing.Color.Black
        Me.txtGhiChu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhiChu.TabIndex = 5
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(3, 169)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel10.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.TabIndex = 23
        Me.KryptonLabel10.Values.Text = "Ghi chú"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(781, 83)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(93, 19)
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 22
        Me.KryptonLabel9.Values.Text = "TỔNG CỘNG"
        '
        'vndTongCong
        '
        Me.vndTongCong.Enabled = False
        Me.vndTongCong.Location = New System.Drawing.Point(876, 79)
        Me.vndTongCong.Name = "vndTongCong"
        Me.vndTongCong.Size = New System.Drawing.Size(233, 27)
        Me.vndTongCong.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.vndTongCong.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vndTongCong.TabIndex = 7
        Me.vndTongCong.Tag = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndTongCong.Text = "0"
        Me.vndTongCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vndTongCong.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'vndPhi
        '
        Me.vndPhi.Enabled = False
        Me.vndPhi.Location = New System.Drawing.Point(928, 105)
        Me.vndPhi.Name = "vndPhi"
        Me.vndPhi.Size = New System.Drawing.Size(181, 27)
        Me.vndPhi.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.vndPhi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vndPhi.TabIndex = 20
        Me.vndPhi.Tag = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndPhi.Text = "0"
        Me.vndPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vndPhi.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(785, 108)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(33, 19)
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 18
        Me.KryptonLabel8.Values.Text = "PHÍ"
        '
        'vndTienThue
        '
        Me.vndTienThue.Enabled = False
        Me.vndTienThue.Location = New System.Drawing.Point(928, 53)
        Me.vndTienThue.Name = "vndTienThue"
        Me.vndTienThue.Size = New System.Drawing.Size(181, 27)
        Me.vndTienThue.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.vndTienThue.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vndTienThue.TabIndex = 17
        Me.vndTienThue.Tag = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndTienThue.Text = "0"
        Me.vndTienThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vndTienThue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(833, 58)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(37, 19)
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 15
        Me.KryptonLabel7.Values.Text = "VAT"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(781, 32)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 14
        Me.KryptonLabel6.Values.Text = "Tổng tiền"
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.AutoSize = False
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(774, 25)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(1, 130)
        Me.KryptonBorderEdge2.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(264, 28)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(42, 19)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 11
        Me.KryptonLabel5.Values.Text = "Ngày"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Enabled = False
        Me.txtDiaChi.Location = New System.Drawing.Point(85, 108)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(408, 56)
        Me.txtDiaChi.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtDiaChi.StateCommon.Content.Color1 = System.Drawing.Color.Black
        Me.txtDiaChi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.TabIndex = 4
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(3, 109)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 8
        Me.KryptonLabel4.Values.Text = "Địa chỉ"
        '
        'txtMaSoThue
        '
        Me.txtMaSoThue.Enabled = False
        Me.txtMaSoThue.Location = New System.Drawing.Point(85, 81)
        Me.txtMaSoThue.Name = "txtMaSoThue"
        Me.txtMaSoThue.Size = New System.Drawing.Size(408, 26)
        Me.txtMaSoThue.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtMaSoThue.StateCommon.Content.Color1 = System.Drawing.Color.Black
        Me.txtMaSoThue.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSoThue.TabIndex = 3
        Me.txtMaSoThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 82)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(77, 19)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 6
        Me.KryptonLabel3.Values.Text = "Mã số thuế"
        '
        'txtKhachHang
        '
        Me.txtKhachHang.Location = New System.Drawing.Point(85, 53)
        Me.txtKhachHang.Name = "txtKhachHang"
        Me.txtKhachHang.Size = New System.Drawing.Size(408, 26)
        Me.txtKhachHang.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtKhachHang.StateCommon.Content.Color1 = System.Drawing.Color.Black
        Me.txtKhachHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKhachHang.TabIndex = 2
        Me.txtKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 57)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(82, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 4
        Me.KryptonLabel2.Values.Text = "Khách hàng"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 29)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(79, 19)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Values.Text = "Số hóa đơn"
        '
        'txtSoHoaDon
        '
        Me.txtSoHoaDon.Location = New System.Drawing.Point(85, 26)
        Me.txtSoHoaDon.Name = "txtSoHoaDon"
        Me.txtSoHoaDon.Size = New System.Drawing.Size(173, 27)
        Me.txtSoHoaDon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSoHoaDon.StateCommon.Content.Color1 = System.Drawing.Color.Maroon
        Me.txtSoHoaDon.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoHoaDon.TabIndex = 0
        Me.txtSoHoaDon.Text = "0000000"
        Me.txtSoHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'vndTongTien
        '
        Me.vndTongTien.Enabled = False
        Me.vndTongTien.Location = New System.Drawing.Point(876, 26)
        Me.vndTongTien.Name = "vndTongTien"
        Me.vndTongTien.Size = New System.Drawing.Size(233, 27)
        Me.vndTongTien.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.vndTongTien.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vndTongTien.TabIndex = 1
        Me.vndTongTien.Tag = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndTongTien.Text = "0"
        Me.vndTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vndTongTien.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(1298, 22)
        Me.KryptonHeader1.TabIndex = 0
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "THÔNG TIN XUẤT HÓA ĐƠN"
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer2.IsSplitterFixed = True
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 28)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        '
        'KryptonSplitContainer2.Panel1
        '
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.dgvChiTietPhieuXuat)
        '
        'KryptonSplitContainer2.Panel2
        '
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.dgvMain)
        Me.KryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(1298, 388)
        Me.KryptonSplitContainer2.SplitterDistance = 448
        Me.KryptonSplitContainer2.SplitterWidth = 3
        Me.KryptonSplitContainer2.TabIndex = 3
        '
        'dgvChiTietPhieuXuat
        '
        Me.dgvChiTietPhieuXuat.AllowUserToAddRows = False
        Me.dgvChiTietPhieuXuat.AllowUserToDeleteRows = False
        Me.dgvChiTietPhieuXuat.AutoGenerateColumns = False
        Me.dgvChiTietPhieuXuat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.TenSanPhamDataGridViewTextBoxColumn, Me.SoLuongDataGridViewTextBoxColumn, Me.DonGiaDataGridViewTextBoxColumn, Me.ThanhTienDataGridViewTextBoxColumn})
        Me.dgvChiTietPhieuXuat.DataSource = Me.bsChiTietPhieuXuat
        Me.dgvChiTietPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvChiTietPhieuXuat.Location = New System.Drawing.Point(0, 0)
        Me.dgvChiTietPhieuXuat.Name = "dgvChiTietPhieuXuat"
        Me.dgvChiTietPhieuXuat.ReadOnly = True
        Me.dgvChiTietPhieuXuat.RowHeadersWidth = 5
        Me.dgvChiTietPhieuXuat.Size = New System.Drawing.Size(448, 388)
        Me.dgvChiTietPhieuXuat.TabIndex = 0
        Me.dgvChiTietPhieuXuat.VirtualMode = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 35
        '
        'TenSanPhamDataGridViewTextBoxColumn
        '
        Me.TenSanPhamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham"
        Me.TenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm"
        Me.TenSanPhamDataGridViewTextBoxColumn.Name = "TenSanPhamDataGridViewTextBoxColumn"
        Me.TenSanPhamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoLuongDataGridViewTextBoxColumn
        '
        Me.SoLuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong"
        Me.SoLuongDataGridViewTextBoxColumn.HeaderText = "SL"
        Me.SoLuongDataGridViewTextBoxColumn.Name = "SoLuongDataGridViewTextBoxColumn"
        Me.SoLuongDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongDataGridViewTextBoxColumn.Width = 48
        '
        'DonGiaDataGridViewTextBoxColumn
        '
        Me.DonGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.Format = "N0"
        Me.DonGiaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DonGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá"
        Me.DonGiaDataGridViewTextBoxColumn.Name = "DonGiaDataGridViewTextBoxColumn"
        Me.DonGiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ThanhTienDataGridViewTextBoxColumn
        '
        Me.ThanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Format = "N0"
        Me.ThanhTienDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ThanhTienDataGridViewTextBoxColumn.HeaderText = "Thành tiền"
        Me.ThanhTienDataGridViewTextBoxColumn.Name = "ThanhTienDataGridViewTextBoxColumn"
        Me.ThanhTienDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsChiTietPhieuXuat
        '
        Me.bsChiTietPhieuXuat.DataSource = GetType(PhanMemBanHang.vwChiTietPhieuXuat)
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STTcol, Me.isHienSTT, Me.MaSanPham, Me.TenSanPham, Me.isHienDonVi, Me.DonVi, Me.SoLuong, Me.isHienSoLuong, Me.DonGia, Me.isHienDonGia, Me.ThanhTien, Me.isHienThanhTien, Me.GhiChu})
        Me.dgvMain.DataSource = Me.bsChiTietHoaDon
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Editing = False
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMain.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvMain.Size = New System.Drawing.Size(847, 388)
        Me.dgvMain.TabIndex = 2
        Me.dgvMain.VirtualMode = True
        '
        'STTcol
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STTcol.DefaultCellStyle = DataGridViewCellStyle3
        Me.STTcol.HeaderText = "STT"
        Me.STTcol.MinimumWidth = 40
        Me.STTcol.Name = "STTcol"
        Me.STTcol.ReadOnly = True
        Me.STTcol.Width = 40
        '
        'isHienSTT
        '
        Me.isHienSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.isHienSTT.DataPropertyName = "isHienSTT"
        Me.isHienSTT.HeaderText = "STT"
        Me.isHienSTT.Name = "isHienSTT"
        Me.isHienSTT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.isHienSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.isHienSTT.Visible = False
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
        Me.TenSanPham.HeaderText = "Tên sản phẩm"
        Me.TenSanPham.MinimumWidth = 10
        Me.TenSanPham.Name = "TenSanPham"
        Me.TenSanPham.Width = 110
        '
        'isHienDonVi
        '
        Me.isHienDonVi.DataPropertyName = "isHienDonVi"
        Me.isHienDonVi.HeaderText = "ĐVT"
        Me.isHienDonVi.Name = "isHienDonVi"
        Me.isHienDonVi.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.isHienDonVi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.isHienDonVi.Visible = False
        '
        'DonVi
        '
        Me.DonVi.DataPropertyName = "DonVi"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DonVi.DefaultCellStyle = DataGridViewCellStyle4
        Me.DonVi.HeaderText = "ĐVT"
        Me.DonVi.MinimumWidth = 50
        Me.DonVi.Name = "DonVi"
        Me.DonVi.ReadOnly = True
        Me.DonVi.Width = 70
        '
        'SoLuong
        '
        Me.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoLuong.DataPropertyName = "SoLuong"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "###,###,###,##0.##"
        Me.SoLuong.DefaultCellStyle = DataGridViewCellStyle5
        Me.SoLuong.HeaderText = "SL"
        Me.SoLuong.MinimumWidth = 50
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.Width = 50
        '
        'isHienSoLuong
        '
        Me.isHienSoLuong.DataPropertyName = "isHienSoLuong"
        Me.isHienSoLuong.HeaderText = "S.L"
        Me.isHienSoLuong.Name = "isHienSoLuong"
        Me.isHienSoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.isHienSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.isHienSoLuong.Visible = False
        '
        'DonGia
        '
        Me.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DonGia.DataPropertyName = "DonGia"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        Me.DonGia.DefaultCellStyle = DataGridViewCellStyle6
        Me.DonGia.HeaderText = "Đơn Giá"
        Me.DonGia.MinimumWidth = 60
        Me.DonGia.Name = "DonGia"
        Me.DonGia.Width = 78
        '
        'isHienDonGia
        '
        Me.isHienDonGia.DataPropertyName = "isHienDonGia"
        Me.isHienDonGia.HeaderText = "DG"
        Me.isHienDonGia.Name = "isHienDonGia"
        Me.isHienDonGia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.isHienDonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.isHienDonGia.Visible = False
        '
        'ThanhTien
        '
        Me.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ThanhTien.DataPropertyName = "ThanhTien"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle7.Format = "N0"
        Me.ThanhTien.DefaultCellStyle = DataGridViewCellStyle7
        Me.ThanhTien.HeaderText = "Thành Tiền"
        Me.ThanhTien.MinimumWidth = 80
        Me.ThanhTien.Name = "ThanhTien"
        Me.ThanhTien.ReadOnly = True
        Me.ThanhTien.Width = 96
        '
        'isHienThanhTien
        '
        Me.isHienThanhTien.DataPropertyName = "isHienThanhTien"
        Me.isHienThanhTien.HeaderText = "T.T"
        Me.isHienThanhTien.Name = "isHienThanhTien"
        Me.isHienThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.isHienThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.isHienThanhTien.Visible = False
        '
        'GhiChu
        '
        Me.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChu.DataPropertyName = "GhiChu"
        Me.GhiChu.HeaderText = "Ghi Chú"
        Me.GhiChu.MinimumWidth = 100
        Me.GhiChu.Name = "GhiChu"
        '
        'bsChiTietHoaDon
        '
        Me.bsChiTietHoaDon.DataSource = GetType(PhanMemBanHang.tbChiTietHoaDon)
        '
        'KryptonHeader2
        '
        Me.KryptonHeader2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnXemCotAnHien, Me.btnThemSanPham, Me.btnXoaTatCa, Me.btnXoa})
        Me.KryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader2.Name = "KryptonHeader2"
        Me.KryptonHeader2.Size = New System.Drawing.Size(1298, 28)
        Me.KryptonHeader2.TabIndex = 2
        Me.KryptonHeader2.Values.Description = ""
        Me.KryptonHeader2.Values.Heading = "DANH MỤC HÀNG HÓA"
        '
        'btnXemCotAnHien
        '
        Me.btnXemCotAnHien.Image = Global.PhanMemBanHang.My.Resources.Resources.XemTruoc16
        Me.btnXemCotAnHien.Text = "[HIỆN]Nội dung ẩn/hiện"
        Me.btnXemCotAnHien.UniqueName = "B1A4C16176C14BFDD4BDEECDA2912FD0"
        '
        'btnThemSanPham
        '
        Me.btnThemSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThemSanPham.Text = "Sản phẩm [F2]"
        Me.btnThemSanPham.UniqueName = "09996042FA4D4E7425BEA9127881881E"
        '
        'btnXoaTatCa
        '
        Me.btnXoaTatCa.Image = Global.PhanMemBanHang.My.Resources.Resources.XoaTatCa16
        Me.btnXoaTatCa.Text = "Xóa tất cả"
        Me.btnXoaTatCa.UniqueName = "73AFCB30893F4421809C63BAF8737FFC"
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.PhanMemBanHang.My.Resources.Resources.Huy16
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UniqueName = "0973401179D94A034E80056185AD1A29"
        '
        'ctrlHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlHoaDon"
        Me.Size = New System.Drawing.Size(1298, 615)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.sss.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sss.Panel1.ResumeLayout(False)
        Me.sss.Panel1.PerformLayout()
        CType(Me.sss.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sss.Panel2.ResumeLayout(False)
        Me.sss.Panel2.PerformLayout()
        CType(Me.sss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sss.ResumeLayout(False)
        CType(Me.cmbHinhThucThanhToan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        CType(Me.dgvChiTietPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChiTietPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChiTietHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents sss As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader2 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents vndTongTien As VNDTextBox
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dgvChiTietPhieuXuat As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsChiTietPhieuXuat As BindingSource
    Friend WithEvents dgvMain As CustomDatagridview
    Friend WithEvents bsChiTietHoaDon As BindingSource
    Friend WithEvents txtSoHoaDon As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtKhachHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMaSoThue As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDiaChi As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents vndTienThue As VNDTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents vndPhi As VNDTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents vndTongCong As VNDTextBox
    Friend WithEvents txtGhiChu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtKhachHangTinhCongNo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDonVi As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpNgayLap As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents btnThemSanPham As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnXoaTatCa As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnDongY As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnXemPhieu As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents nudPhi As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nudVAT As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents TenSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonGiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThanhTienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnXoa As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnXemCotAnHien As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents chkCoVAT As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cmbHinhThucThanhToan As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents txtSoTaiKhoan As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents STTcol As DataGridViewTextBoxColumn
    Friend WithEvents isHienSTT As DataGridViewCheckBoxColumn
    Friend WithEvents MaSanPham As DataGridViewTextBoxColumn
    Friend WithEvents TenSanPham As DataGridViewTextBoxColumn
    Friend WithEvents isHienDonVi As DataGridViewCheckBoxColumn
    Friend WithEvents DonVi As DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As DataGridViewTextBoxColumn
    Friend WithEvents isHienSoLuong As DataGridViewCheckBoxColumn
    Friend WithEvents DonGia As DataGridViewTextBoxColumn
    Friend WithEvents isHienDonGia As DataGridViewCheckBoxColumn
    Friend WithEvents ThanhTien As DataGridViewTextBoxColumn
    Friend WithEvents isHienThanhTien As DataGridViewCheckBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
End Class
