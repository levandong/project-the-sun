<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlTimKiemSanPham
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lblSoDong = New System.Windows.Forms.ToolStripLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtSearch = New PhanMemBanHang.clsTextbox()
        Me.nudDonVi = New ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown()
        Me.cmbTimKiemTheo = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.txtSoLuong = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnChon = New ComponentFactory.Krypton.Toolkit.KryptonDropButton()
        Me.KryptonContextMenu1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenu()
        Me.KryptonContextMenuItems1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.ctmThemSanPhamMoi = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.ctmCapNhat = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.ctmCauHinhTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.KryptonContextMenuHeading1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.ctmTimKiemChuaTrong = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.ctmTimKiemBatDau = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.bsSanPham = New System.Windows.Forms.BindingSource(Me.components)
        Me.KryptonContextMenuRadioButton2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.KryptonContextMenuItems2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuSeparator1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.KryptonContextMenuRadioButton1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.KryptonContextMenuRadioButton6 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.KryptonContextMenuHeading2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.KryptonContextMenuRadioButton7 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.KryptonContextMenuSeparator2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.KryptonContextMenuHeading3 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.KryptonContextMenuHeading4 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.KryptonContextMenuRadioButton5 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.KryptonContextMenuRadioButton8 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.KryptonContextMenuRadioButton9 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.KryptonContextMenuHeading6 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.KryptonContextMenuHeading7 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.KryptonContextMenuHeading8 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.KryptonContextMenuItems4 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuItems5 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuRadioButton4 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaVachSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSanPhamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPhamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonViDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuyCach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaNiemYet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGiaNhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGiaBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayNiemYet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaQuyCach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CanhBao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.cmbTimKiemTheo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoDong})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 467)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(821, 25)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'lblSoDong
        '
        Me.lblSoDong.Name = "lblSoDong"
        Me.lblSoDong.Size = New System.Drawing.Size(68, 22)
        Me.lblSoDong.Text = "0 sản phẩm"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.txtSearch)
        Me.KryptonPanel1.Controls.Add(Me.nudDonVi)
        Me.KryptonPanel1.Controls.Add(Me.cmbTimKiemTheo)
        Me.KryptonPanel1.Controls.Add(Me.txtSoLuong)
        Me.KryptonPanel1.Controls.Add(Me.btnChon)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(821, 30)
        Me.KryptonPanel1.TabIndex = 5
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Location = New System.Drawing.Point(85, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(503, 28)
        Me.txtSearch.StateCommon.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.Gray
        Me.txtSearch.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "Tìm kiếm [F2]..."
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSearch.TextGoiY = "Tìm kiếm [F2]..."
        '
        'nudDonVi
        '
        Me.nudDonVi.Dock = System.Windows.Forms.DockStyle.Right
        Me.nudDonVi.Items.Add("ĐVT 1")
        Me.nudDonVi.Items.Add("ĐVT 2")
        Me.nudDonVi.Location = New System.Drawing.Point(588, 0)
        Me.nudDonVi.Name = "nudDonVi"
        Me.nudDonVi.ReadOnly = True
        Me.nudDonVi.Size = New System.Drawing.Size(80, 30)
        Me.nudDonVi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDonVi.TabIndex = 7
        Me.nudDonVi.Visible = False
        '
        'cmbTimKiemTheo
        '
        Me.cmbTimKiemTheo.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbTimKiemTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimKiemTheo.DropDownWidth = 76
        Me.cmbTimKiemTheo.Items.AddRange(New Object() {"MÃ", "TÊN", "VẠCH"})
        Me.cmbTimKiemTheo.Location = New System.Drawing.Point(0, 0)
        Me.cmbTimKiemTheo.Name = "cmbTimKiemTheo"
        Me.cmbTimKiemTheo.Size = New System.Drawing.Size(85, 30)
        Me.cmbTimKiemTheo.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimKiemTheo.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimKiemTheo.TabIndex = 5
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtSoLuong.Location = New System.Drawing.Point(668, 0)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(70, 28)
        Me.txtSoLuong.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSoLuong.StateCommon.Border.Color2 = System.Drawing.Color.Transparent
        Me.txtSoLuong.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right
        Me.txtSoLuong.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoLuong.TabIndex = 3
        Me.txtSoLuong.Text = "1"
        Me.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSoLuong.Visible = False
        '
        'btnChon
        '
        Me.btnChon.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnChon.KryptonContextMenu = Me.KryptonContextMenu1
        Me.btnChon.Location = New System.Drawing.Point(738, 0)
        Me.btnChon.Name = "btnChon"
        Me.btnChon.Size = New System.Drawing.Size(83, 30)
        Me.btnChon.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnChon.StateCommon.Border.Rounding = 0
        Me.btnChon.StateCommon.Border.Width = 0
        Me.btnChon.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChon.TabIndex = 4
        Me.btnChon.Values.Text = "CHỌN"
        '
        'KryptonContextMenu1
        '
        Me.KryptonContextMenu1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItems1, Me.KryptonContextMenuHeading1, Me.ctmTimKiemChuaTrong, Me.ctmTimKiemBatDau})
        '
        'KryptonContextMenuItems1
        '
        Me.KryptonContextMenuItems1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.ctmThemSanPhamMoi, Me.ctmCapNhat, Me.ctmCauHinhTimKiem})
        '
        'ctmThemSanPhamMoi
        '
        Me.ctmThemSanPhamMoi.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.ctmThemSanPhamMoi.Text = "Thêm sản phẩm mới"
        '
        'ctmCapNhat
        '
        Me.ctmCapNhat.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.ctmCapNhat.Text = "Cập nhật"
        '
        'ctmCauHinhTimKiem
        '
        Me.ctmCauHinhTimKiem.Image = Global.PhanMemBanHang.My.Resources.Resources.CaiDat16
        Me.ctmCauHinhTimKiem.Text = "Cấu hình tìm kiếm"
        '
        'KryptonContextMenuHeading1
        '
        Me.KryptonContextMenuHeading1.ExtraText = ""
        Me.KryptonContextMenuHeading1.Text = "Kiểu tìm kiếm"
        '
        'ctmTimKiemChuaTrong
        '
        Me.ctmTimKiemChuaTrong.ExtraText = ""
        Me.ctmTimKiemChuaTrong.Text = "Tìm kiếm chứa trong"
        '
        'ctmTimKiemBatDau
        '
        Me.ctmTimKiemBatDau.ExtraText = ""
        Me.ctmTimKiemBatDau.Text = "Tìm kiếm bắt đầu"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.colMaVachSanPham, Me.MaSanPhamDataGridViewTextBoxColumn, Me.TenSanPhamDataGridViewTextBoxColumn, Me.DonViDataGridViewTextBoxColumn, Me.QuyCach, Me.GiaNiemYet, Me.colGiaNhap, Me.colGiaBan, Me.SoLuongDataGridViewTextBoxColumn, Me.NgayNiemYet, Me.GiaQuyCach, Me.CanhBao})
        Me.dgvMain.DataSource = Me.bsSanPham
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 30)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMain.Size = New System.Drawing.Size(821, 437)
        Me.dgvMain.TabIndex = 6
        Me.dgvMain.VirtualMode = True
        '
        'bsSanPham
        '
        Me.bsSanPham.DataSource = GetType(PhanMemBanHang.vwSanPham)
        '
        'KryptonContextMenuRadioButton2
        '
        Me.KryptonContextMenuRadioButton2.ExtraText = ""
        '
        'KryptonContextMenuRadioButton1
        '
        Me.KryptonContextMenuRadioButton1.ExtraText = ""
        '
        'KryptonContextMenuRadioButton6
        '
        Me.KryptonContextMenuRadioButton6.ExtraText = ""
        '
        'KryptonContextMenuHeading2
        '
        Me.KryptonContextMenuHeading2.ExtraText = ""
        '
        'KryptonContextMenuRadioButton7
        '
        Me.KryptonContextMenuRadioButton7.ExtraText = ""
        '
        'KryptonContextMenuHeading3
        '
        Me.KryptonContextMenuHeading3.ExtraText = ""
        Me.KryptonContextMenuHeading3.Text = "Giá theo nhóm"
        '
        'KryptonContextMenuHeading4
        '
        Me.KryptonContextMenuHeading4.ExtraText = ""
        Me.KryptonContextMenuHeading4.Text = "Giá theo lựa chọn dưới"
        '
        'KryptonContextMenuRadioButton5
        '
        Me.KryptonContextMenuRadioButton5.ExtraText = ""
        '
        'KryptonContextMenuRadioButton8
        '
        Me.KryptonContextMenuRadioButton8.ExtraText = ""
        '
        'KryptonContextMenuRadioButton9
        '
        Me.KryptonContextMenuRadioButton9.ExtraText = ""
        '
        'KryptonContextMenuHeading6
        '
        Me.KryptonContextMenuHeading6.ExtraText = ""
        '
        'KryptonContextMenuHeading7
        '
        Me.KryptonContextMenuHeading7.ExtraText = ""
        '
        'KryptonContextMenuHeading8
        '
        Me.KryptonContextMenuHeading8.ExtraText = ""
        '
        'KryptonContextMenuRadioButton4
        '
        Me.KryptonContextMenuRadioButton4.ExtraText = ""
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
        'colMaVachSanPham
        '
        Me.colMaVachSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMaVachSanPham.DataPropertyName = "MaVachSanPham"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        Me.colMaVachSanPham.DefaultCellStyle = DataGridViewCellStyle2
        Me.colMaVachSanPham.HeaderText = "Mã vạch"
        Me.colMaVachSanPham.Name = "colMaVachSanPham"
        Me.colMaVachSanPham.ReadOnly = True
        Me.colMaVachSanPham.Visible = False
        Me.colMaVachSanPham.Width = 81
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
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy
        Me.TenSanPhamDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
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
        'QuyCach
        '
        Me.QuyCach.DataPropertyName = "QuyCach"
        Me.QuyCach.HeaderText = "QC"
        Me.QuyCach.MinimumWidth = 40
        Me.QuyCach.Name = "QuyCach"
        Me.QuyCach.ReadOnly = True
        Me.QuyCach.Width = 40
        '
        'GiaNiemYet
        '
        Me.GiaNiemYet.DataPropertyName = "GiaNiemYet"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.NullValue = "###,###,###,##0.###"
        Me.GiaNiemYet.DefaultCellStyle = DataGridViewCellStyle4
        Me.GiaNiemYet.HeaderText = "Giá niêm yết"
        Me.GiaNiemYet.Name = "GiaNiemYet"
        Me.GiaNiemYet.ReadOnly = True
        '
        'colGiaNhap
        '
        Me.colGiaNhap.DataPropertyName = "PhanTramNhap"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colGiaNhap.DefaultCellStyle = DataGridViewCellStyle5
        Me.colGiaNhap.HeaderText = "CK Nhập"
        Me.colGiaNhap.Name = "colGiaNhap"
        Me.colGiaNhap.ReadOnly = True
        '
        'colGiaBan
        '
        Me.colGiaBan.DataPropertyName = "PhanTramBan"
        Me.colGiaBan.HeaderText = "CK Xuất"
        Me.colGiaBan.Name = "colGiaBan"
        Me.colGiaBan.ReadOnly = True
        '
        'SoLuongDataGridViewTextBoxColumn
        '
        Me.SoLuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle6.Format = "###,###,###,##0.###,###"
        Me.SoLuongDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SoLuongDataGridViewTextBoxColumn.HeaderText = "Tồn"
        Me.SoLuongDataGridViewTextBoxColumn.MinimumWidth = 50
        Me.SoLuongDataGridViewTextBoxColumn.Name = "SoLuongDataGridViewTextBoxColumn"
        Me.SoLuongDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongDataGridViewTextBoxColumn.Width = 57
        '
        'NgayNiemYet
        '
        Me.NgayNiemYet.DataPropertyName = "NgayNiemYet"
        Me.NgayNiemYet.HeaderText = "Ngày niêm yết"
        Me.NgayNiemYet.Name = "NgayNiemYet"
        Me.NgayNiemYet.ReadOnly = True
        '
        'GiaQuyCach
        '
        Me.GiaQuyCach.DataPropertyName = "GiaQuyCach"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Format = "N0"
        Me.GiaQuyCach.DefaultCellStyle = DataGridViewCellStyle7
        Me.GiaQuyCach.HeaderText = "Giá QC"
        Me.GiaQuyCach.Name = "GiaQuyCach"
        Me.GiaQuyCach.ReadOnly = True
        '
        'CanhBao
        '
        Me.CanhBao.DataPropertyName = "CanhBao"
        Me.CanhBao.HeaderText = "CanhBao"
        Me.CanhBao.Name = "CanhBao"
        Me.CanhBao.ReadOnly = True
        Me.CanhBao.Visible = False
        '
        'ctrlTimKiemSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "ctrlTimKiemSanPham"
        Me.Size = New System.Drawing.Size(821, 492)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.cmbTimKiemTheo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents bsSanPham As System.Windows.Forms.BindingSource
    Friend WithEvents lblSoDong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtSearch As PhanMemBanHang.clsTextbox
    Friend WithEvents txtSoLuong As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnChon As ComponentFactory.Krypton.Toolkit.KryptonDropButton
    Friend WithEvents KryptonContextMenu1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents KryptonContextMenuItems1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents ctmCapNhat As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents ctmThemSanPhamMoi As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents ctmCauHinhTimKiem As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonContextMenuRadioButton2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents KryptonContextMenuItems2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuSeparator1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents ctmTimKiemChuaTrong As ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents ctmTimKiemBatDau As ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents KryptonContextMenuRadioButton1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents KryptonContextMenuRadioButton6 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents KryptonContextMenuHeading2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents KryptonContextMenuRadioButton7 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents KryptonContextMenuSeparator2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents KryptonContextMenuHeading1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents cmbTimKiemTheo As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonContextMenuHeading3 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents KryptonContextMenuHeading4 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents KryptonContextMenuRadioButton5 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents KryptonContextMenuRadioButton8 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents KryptonContextMenuRadioButton9 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents KryptonContextMenuHeading6 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents KryptonContextMenuHeading7 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents KryptonContextMenuHeading8 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents KryptonContextMenuItems4 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuItems5 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuRadioButton4 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents nudDonVi As ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents colMaVachSanPham As DataGridViewTextBoxColumn
    Friend WithEvents MaSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonViDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuyCach As DataGridViewTextBoxColumn
    Friend WithEvents GiaNiemYet As DataGridViewTextBoxColumn
    Friend WithEvents colGiaNhap As DataGridViewTextBoxColumn
    Friend WithEvents colGiaBan As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayNiemYet As DataGridViewTextBoxColumn
    Friend WithEvents GiaQuyCach As DataGridViewTextBoxColumn
    Friend WithEvents CanhBao As DataGridViewTextBoxColumn
End Class
