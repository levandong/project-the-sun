<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlThongKeBaoGia
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.pnlPhieuDatHang = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.txtCongTrinh = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.chkTheoCongTrinh = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.txtKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.chkTheoKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtTheoMaPhieu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.chkTheoMaPhieu = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.chkTheoNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.cmbNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatNhanVien = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.CtrlTimKiemTheoThoiGian1 = New TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.lblSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.btnQuaTraiTatCa = New System.Windows.Forms.ToolStripButton()
        Me.btnQuaTrai1 = New System.Windows.Forms.ToolStripButton()
        Me.txtSoTrang = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTongSoTrang = New System.Windows.Forms.ToolStripTextBox()
        Me.btnQuaPhai1 = New System.Windows.Forms.ToolStripButton()
        Me.btnQuaPhaiTatCa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtSoDongTrenMotTrang = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTongSoTrang2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTongSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SửaPhiếuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InPhiếuBáoGiáToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HủyPhiếuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHuyPhieu = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsBaoGia = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lblTieuDe = New System.Windows.Forms.ToolStripLabel()
        Me.btnThemTabPageMoi = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbTrangThai = New System.Windows.Forms.ToolStripComboBox()
        Me.btnCapNhat = New System.Windows.Forms.ToolStripButton()
        Me.bsChiTietDatHang = New System.Windows.Forms.BindingSource(Me.components)
        Me.STTcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NgayLapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPhieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbNhanVien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KhachHangNhaCungCap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrangThai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TienChuaThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TienThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.pnlPhieuDatHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel2.SuspendLayout()
        Me.KryptonSplitContainer2.SuspendLayout()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.bsBaoGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.bsChiTietDatHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1083, 615)
        Me.KryptonPanel1.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.pnlPhieuDatHang)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.ToolStrip4)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.Panel1Collapsed = True
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonSplitContainer2)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1083, 615)
        Me.KryptonSplitContainer1.SplitterDistance = 361
        Me.KryptonSplitContainer1.SplitterWidth = 2
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'pnlPhieuDatHang
        '
        Me.pnlPhieuDatHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPhieuDatHang.Location = New System.Drawing.Point(0, 25)
        Me.pnlPhieuDatHang.Name = "pnlPhieuDatHang"
        Me.pnlPhieuDatHang.Size = New System.Drawing.Size(100, 50)
        Me.pnlPhieuDatHang.TabIndex = 2
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 75)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(100, 25)
        Me.ToolStrip4.TabIndex = 1
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel3.Text = "0 Phiếu"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripLabel2.Text = "DANH SÁCH"
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 25)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        '
        'KryptonSplitContainer2.Panel1
        '
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.txtCongTrinh)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.chkTheoCongTrinh)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.txtKhachHang)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.chkTheoKhachHang)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.btnTimKiem)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.txtTheoMaPhieu)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.chkTheoMaPhieu)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.chkTheoNhanVien)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.cmbNhanVien)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.CtrlTimKiemTheoThoiGian1)
        '
        'KryptonSplitContainer2.Panel2
        '
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.ToolStrip3)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.dgvMain)
        Me.KryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(1083, 590)
        Me.KryptonSplitContainer2.SplitterDistance = 216
        Me.KryptonSplitContainer2.SplitterWidth = 3
        Me.KryptonSplitContainer2.TabIndex = 2
        '
        'txtCongTrinh
        '
        Me.txtCongTrinh.Enabled = False
        Me.txtCongTrinh.Location = New System.Drawing.Point(3, 213)
        Me.txtCongTrinh.Name = "txtCongTrinh"
        Me.txtCongTrinh.Size = New System.Drawing.Size(207, 23)
        Me.txtCongTrinh.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCongTrinh.TabIndex = 64
        '
        'chkTheoCongTrinh
        '
        Me.chkTheoCongTrinh.Location = New System.Drawing.Point(3, 182)
        Me.chkTheoCongTrinh.Name = "chkTheoCongTrinh"
        Me.chkTheoCongTrinh.Size = New System.Drawing.Size(207, 25)
        Me.chkTheoCongTrinh.TabIndex = 63
        Me.chkTheoCongTrinh.Values.Text = "Theo công trình"
        '
        'txtKhachHang
        '
        Me.txtKhachHang.Enabled = False
        Me.txtKhachHang.Location = New System.Drawing.Point(4, 153)
        Me.txtKhachHang.Name = "txtKhachHang"
        Me.txtKhachHang.Size = New System.Drawing.Size(207, 23)
        Me.txtKhachHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKhachHang.TabIndex = 62
        '
        'chkTheoKhachHang
        '
        Me.chkTheoKhachHang.Location = New System.Drawing.Point(4, 122)
        Me.chkTheoKhachHang.Name = "chkTheoKhachHang"
        Me.chkTheoKhachHang.Size = New System.Drawing.Size(207, 25)
        Me.chkTheoKhachHang.TabIndex = 61
        Me.chkTheoKhachHang.Values.Text = "Theo khách hàng"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimKiem.Location = New System.Drawing.Point(3, 308)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(207, 44)
        Me.btnTimKiem.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.TabIndex = 60
        Me.btnTimKiem.Values.Text = "TÌM KIẾM"
        '
        'txtTheoMaPhieu
        '
        Me.txtTheoMaPhieu.Enabled = False
        Me.txtTheoMaPhieu.Location = New System.Drawing.Point(3, 279)
        Me.txtTheoMaPhieu.Name = "txtTheoMaPhieu"
        Me.txtTheoMaPhieu.Size = New System.Drawing.Size(207, 23)
        Me.txtTheoMaPhieu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTheoMaPhieu.TabIndex = 59
        '
        'chkTheoMaPhieu
        '
        Me.chkTheoMaPhieu.Location = New System.Drawing.Point(3, 248)
        Me.chkTheoMaPhieu.Name = "chkTheoMaPhieu"
        Me.chkTheoMaPhieu.Size = New System.Drawing.Size(207, 25)
        Me.chkTheoMaPhieu.TabIndex = 57
        Me.chkTheoMaPhieu.Values.Text = "Theo Mã Phiếu"
        '
        'chkTheoNhanVien
        '
        Me.chkTheoNhanVien.Location = New System.Drawing.Point(4, 61)
        Me.chkTheoNhanVien.Name = "chkTheoNhanVien"
        Me.chkTheoNhanVien.Size = New System.Drawing.Size(207, 25)
        Me.chkTheoNhanVien.TabIndex = 58
        Me.chkTheoNhanVien.Values.Text = "Theo Nhân Viên"
        '
        'cmbNhanVien
        '
        Me.cmbNhanVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNhanVien.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatNhanVien})
        Me.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhanVien.DropDownWidth = 121
        Me.cmbNhanVien.Enabled = False
        Me.cmbNhanVien.Location = New System.Drawing.Point(4, 92)
        Me.cmbNhanVien.Name = "cmbNhanVien"
        Me.cmbNhanVien.Size = New System.Drawing.Size(207, 24)
        Me.cmbNhanVien.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhanVien.TabIndex = 56
        '
        'btnCapNhatNhanVien
        '
        Me.btnCapNhatNhanVien.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatNhanVien.UniqueName = "5D7526322F654BC56A87E646A6C068FE"
        '
        'CtrlTimKiemTheoThoiGian1
        '
        Me.CtrlTimKiemTheoThoiGian1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtrlTimKiemTheoThoiGian1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlTimKiemTheoThoiGian1.Name = "CtrlTimKiemTheoThoiGian1"
        Me.CtrlTimKiemTheoThoiGian1.Size = New System.Drawing.Size(216, 60)
        Me.CtrlTimKiemTheoThoiGian1.TabIndex = 55
        Me.CtrlTimKiemTheoThoiGian1.TheoChinhXacGio = False
        Me.CtrlTimKiemTheoThoiGian1.TMTNow = New Date(2017, 2, 8, 11, 3, 33, 874)
        Me.CtrlTimKiemTheoThoiGian1.ToiLuc = New Date(2013, 8, 13, 0, 0, 0, 0)
        Me.CtrlTimKiemTheoThoiGian1.TuLuc = New Date(2013, 8, 13, 0, 0, 0, 0)
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoLuong, Me.ToolStripSeparator3, Me.ToolStripLabel4, Me.btnQuaTraiTatCa, Me.btnQuaTrai1, Me.txtSoTrang, Me.ToolStripLabel5, Me.lblTongSoTrang, Me.btnQuaPhai1, Me.btnQuaPhaiTatCa, Me.ToolStripSeparator4, Me.txtSoDongTrenMotTrang, Me.ToolStripLabel6, Me.lblTongSoTrang2, Me.ToolStripLabel7, Me.lblTongSoLuong})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 565)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.ShowItemToolTips = False
        Me.ToolStrip3.Size = New System.Drawing.Size(864, 25)
        Me.ToolStrip3.TabIndex = 4
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.AutoSize = False
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(70, 22)
        Me.lblSoLuong.Text = "..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripLabel4.Text = "Trang:"
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
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel5.Text = "/"
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'txtSoDongTrenMotTrang
        '
        Me.txtSoDongTrenMotTrang.Name = "txtSoDongTrenMotTrang"
        Me.txtSoDongTrenMotTrang.Size = New System.Drawing.Size(30, 25)
        Me.txtSoDongTrenMotTrang.Text = "30"
        Me.txtSoDongTrenMotTrang.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel6.Text = "x"
        '
        'lblTongSoTrang2
        '
        Me.lblTongSoTrang2.Name = "lblTongSoTrang2"
        Me.lblTongSoTrang2.Size = New System.Drawing.Size(13, 22)
        Me.lblTongSoTrang2.Text = "0"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(15, 22)
        Me.ToolStripLabel7.Text = "="
        '
        'lblTongSoLuong
        '
        Me.lblTongSoLuong.Name = "lblTongSoLuong"
        Me.lblTongSoLuong.Size = New System.Drawing.Size(13, 22)
        Me.lblTongSoLuong.Text = "0"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STTcol, Me.Chon, Me.NgayLapDataGridViewTextBoxColumn, Me.MaPhieu, Me.tbNhanVien, Me.KhachHangNhaCungCap, Me.TrangThai, Me.TienChuaThue, Me.TienThue, Me.TongTien, Me.GhiChu})
        Me.dgvMain.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvMain.DataSource = Me.bsBaoGia
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.RowHeadersWidth = 5
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(864, 590)
        Me.dgvMain.TabIndex = 0
        Me.dgvMain.VirtualMode = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SửaPhiếuToolStripMenuItem, Me.InPhiếuBáoGiáToolStripMenuItem, Me.ToolStripSeparator2, Me.HủyPhiếuToolStripMenuItem, Me.btnHuyPhieu})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 98)
        '
        'SửaPhiếuToolStripMenuItem
        '
        Me.SửaPhiếuToolStripMenuItem.Name = "SửaPhiếuToolStripMenuItem"
        Me.SửaPhiếuToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SửaPhiếuToolStripMenuItem.Text = "Sửa phiếu"
        '
        'InPhiếuBáoGiáToolStripMenuItem
        '
        Me.InPhiếuBáoGiáToolStripMenuItem.Name = "InPhiếuBáoGiáToolStripMenuItem"
        Me.InPhiếuBáoGiáToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.InPhiếuBáoGiáToolStripMenuItem.Text = "In Phiếu Báo Giá"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'HủyPhiếuToolStripMenuItem
        '
        Me.HủyPhiếuToolStripMenuItem.Name = "HủyPhiếuToolStripMenuItem"
        Me.HủyPhiếuToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.HủyPhiếuToolStripMenuItem.Text = "Xóa phiếu"
        '
        'btnHuyPhieu
        '
        Me.btnHuyPhieu.Name = "btnHuyPhieu"
        Me.btnHuyPhieu.Size = New System.Drawing.Size(160, 22)
        Me.btnHuyPhieu.Text = "Hủy phiếu"
        '
        'bsBaoGia
        '
        Me.bsBaoGia.DataSource = GetType(PhanMemBanHang.vwBaoGia)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTieuDe, Me.btnThemTabPageMoi, Me.ToolStripSeparator1, Me.cmbTrangThai, Me.btnCapNhat})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1083, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'lblTieuDe
        '
        Me.lblTieuDe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(119, 22)
        Me.lblTieuDe.Text = "THỐNG KÊ BÁO GIÁ"
        '
        'btnThemTabPageMoi
        '
        Me.btnThemTabPageMoi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnThemTabPageMoi.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThemTabPageMoi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemTabPageMoi.Name = "btnThemTabPageMoi"
        Me.btnThemTabPageMoi.Size = New System.Drawing.Size(155, 22)
        Me.btnThemTabPageMoi.Text = "[F3]THÊM BÁO GIÁ MỚI"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmbTrangThai
        '
        Me.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrangThai.Name = "cmbTrangThai"
        Me.cmbTrangThai.Size = New System.Drawing.Size(121, 25)
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 22)
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.Visible = False
        '
        'bsChiTietDatHang
        '
        Me.bsChiTietDatHang.DataSource = GetType(PhanMemBanHang.tbChiTietKhachHangDatHang)
        '
        'STTcol
        '
        Me.STTcol.HeaderText = "STT"
        Me.STTcol.MinimumWidth = 35
        Me.STTcol.Name = "STTcol"
        Me.STTcol.Width = 40
        '
        'Chon
        '
        Me.Chon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.Width = 46
        '
        'NgayLapDataGridViewTextBoxColumn
        '
        Me.NgayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.NgayLapDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.NgayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lập"
        Me.NgayLapDataGridViewTextBoxColumn.Name = "NgayLapDataGridViewTextBoxColumn"
        '
        'MaPhieu
        '
        Me.MaPhieu.DataPropertyName = "MaPhieu"
        Me.MaPhieu.HeaderText = "Mã phiếu"
        Me.MaPhieu.Name = "MaPhieu"
        '
        'tbNhanVien
        '
        Me.tbNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tbNhanVien.DataPropertyName = "TenNhanVien"
        Me.tbNhanVien.HeaderText = "Nhân viên"
        Me.tbNhanVien.Name = "tbNhanVien"
        Me.tbNhanVien.Width = 90
        '
        'KhachHangNhaCungCap
        '
        Me.KhachHangNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KhachHangNhaCungCap.DataPropertyName = "KhachHangNhaCungCap"
        Me.KhachHangNhaCungCap.HeaderText = "KH/NCC"
        Me.KhachHangNhaCungCap.MinimumWidth = 100
        Me.KhachHangNhaCungCap.Name = "KhachHangNhaCungCap"
        '
        'TrangThai
        '
        Me.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TrangThai.DataPropertyName = "TrangThai"
        Me.TrangThai.HeaderText = "Trạng thái"
        Me.TrangThai.Name = "TrangThai"
        Me.TrangThai.Width = 90
        '
        'TienChuaThue
        '
        Me.TienChuaThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TienChuaThue.DataPropertyName = "TongTienTruocVAT"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Format = "N0"
        Me.TienChuaThue.DefaultCellStyle = DataGridViewCellStyle2
        Me.TienChuaThue.HeaderText = "Chưa thuế"
        Me.TienChuaThue.Name = "TienChuaThue"
        Me.TienChuaThue.Width = 91
        '
        'TienThue
        '
        Me.TienThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TienThue.DataPropertyName = "TongTienVAT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Format = "N0"
        Me.TienThue.DefaultCellStyle = DataGridViewCellStyle3
        Me.TienThue.HeaderText = "Tiền thuế"
        Me.TienThue.Name = "TienThue"
        Me.TienThue.Width = 86
        '
        'TongTien
        '
        Me.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TongTien.DataPropertyName = "TongTien"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Format = "N0"
        Me.TongTien.DefaultCellStyle = DataGridViewCellStyle4
        Me.TongTien.HeaderText = "Tổng tiền"
        Me.TongTien.Name = "TongTien"
        Me.TongTien.Width = 87
        '
        'GhiChu
        '
        Me.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChu.DataPropertyName = "GhiChu"
        Me.GhiChu.HeaderText = "Ghi chú"
        Me.GhiChu.MinimumWidth = 100
        Me.GhiChu.Name = "GhiChu"
        '
        'ctrlThongKeBaoGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlThongKeBaoGia"
        Me.Size = New System.Drawing.Size(1083, 615)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.pnlPhieuDatHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer2.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer2.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.bsBaoGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.bsChiTietDatHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents pnlPhieuDatHang As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents bsChiTietDatHang As BindingSource
    Friend WithEvents DonGiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GiaBanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GiaNhapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents IdNhanVienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdKhachHangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsBaoGia As BindingSource
    Friend WithEvents TrangThaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SửaPhiếuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents HủyPhiếuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnHuyPhieu As ToolStripMenuItem
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtTheoMaPhieu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkTheoMaPhieu As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents chkTheoNhanVien As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents cmbNhanVien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatNhanVien As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents CtrlTimKiemTheoThoiGian1 As TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian
    Friend WithEvents TenSanPham As DataGridViewTextBoxColumn
    Friend WithEvents DonGia As DataGridViewTextBoxColumn
    Friend WithEvents GiaChietKhau As DataGridViewTextBoxColumn
    Friend WithEvents ThanhTien As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents lblSoLuong As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents btnQuaTraiTatCa As ToolStripButton
    Friend WithEvents btnQuaTrai1 As ToolStripButton
    Friend WithEvents txtSoTrang As ToolStripTextBox
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents lblTongSoTrang As ToolStripTextBox
    Friend WithEvents btnQuaPhai1 As ToolStripButton
    Friend WithEvents btnQuaPhaiTatCa As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents txtSoDongTrenMotTrang As ToolStripTextBox
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents lblTongSoTrang2 As ToolStripLabel
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents lblTongSoLuong As ToolStripLabel
    Friend WithEvents chkTheoKhachHang As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents txtKhachHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCongTrinh As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkTheoCongTrinh As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents InPhiếuBáoGiáToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents lblTieuDe As ToolStripLabel
    Friend WithEvents btnThemTabPageMoi As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnCapNhat As ToolStripButton
    Friend WithEvents cmbTrangThai As ToolStripComboBox
    Friend WithEvents STTcol As DataGridViewTextBoxColumn
    Friend WithEvents Chon As DataGridViewCheckBoxColumn
    Friend WithEvents NgayLapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaPhieu As DataGridViewTextBoxColumn
    Friend WithEvents tbNhanVien As DataGridViewTextBoxColumn
    Friend WithEvents KhachHangNhaCungCap As DataGridViewTextBoxColumn
    Friend WithEvents TrangThai As DataGridViewTextBoxColumn
    Friend WithEvents TienChuaThue As DataGridViewTextBoxColumn
    Friend WithEvents TienThue As DataGridViewTextBoxColumn
    Friend WithEvents TongTien As DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
End Class
