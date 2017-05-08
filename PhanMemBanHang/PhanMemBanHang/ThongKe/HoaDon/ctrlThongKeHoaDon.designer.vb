<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThongKeHoaDon
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
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.chkTheoHinhThucThanhToan = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.cmbHinhThucThanhToan = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtTheoMaHoaDon = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.chkTheoMaHoaDon = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.chkTheoKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.chkTheoNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.lblThongBao = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatNhanVien = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.cmbKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnTimKiemKhachHang = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnCapNhatKhachHang = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.CtrlTimKiemTheoThoiGian1 = New TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnXemPhieu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSuaHoaDon = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnXoaHoaDon = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInDanhSach = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnXuatExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridViewData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnThemHoaDonDauRa = New System.Windows.Forms.ToolStripButton()
        Me.btnThemHoaDonDauVao = New System.Windows.Forms.ToolStripButton()
        Me.lblTieuDe = New System.Windows.Forms.ToolStripLabel()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.cmbHinhThucThanhToan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gridViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoHinhThucThanhToan)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbHinhThucThanhToan)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnTimKiem)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtTheoMaHoaDon)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoMaHoaDon)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoKhachHang)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoNhanVien)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.lblThongBao)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbNhanVien)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbKhachHang)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.CtrlTimKiemTheoThoiGian1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.gridControl)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1299, 485)
        Me.KryptonSplitContainer1.SplitterDistance = 247
        Me.KryptonSplitContainer1.TabIndex = 2
        '
        'chkTheoHinhThucThanhToan
        '
        Me.chkTheoHinhThucThanhToan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoHinhThucThanhToan.Location = New System.Drawing.Point(3, 191)
        Me.chkTheoHinhThucThanhToan.Name = "chkTheoHinhThucThanhToan"
        Me.chkTheoHinhThucThanhToan.Size = New System.Drawing.Size(241, 25)
        Me.chkTheoHinhThucThanhToan.TabIndex = 56
        Me.chkTheoHinhThucThanhToan.Values.Text = "Theo Hình Thức TT"
        Me.chkTheoHinhThucThanhToan.Visible = False
        '
        'cmbHinhThucThanhToan
        '
        Me.cmbHinhThucThanhToan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbHinhThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHinhThucThanhToan.DropDownWidth = 121
        Me.cmbHinhThucThanhToan.Enabled = False
        Me.cmbHinhThucThanhToan.Location = New System.Drawing.Point(3, 222)
        Me.cmbHinhThucThanhToan.Name = "cmbHinhThucThanhToan"
        Me.cmbHinhThucThanhToan.Size = New System.Drawing.Size(241, 24)
        Me.cmbHinhThucThanhToan.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHinhThucThanhToan.TabIndex = 55
        Me.cmbHinhThucThanhToan.Visible = False
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimKiem.Location = New System.Drawing.Point(3, 312)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(241, 44)
        Me.btnTimKiem.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.TabIndex = 54
        Me.btnTimKiem.Values.Text = "TÌM KIẾM"
        '
        'txtTheoMaHoaDon
        '
        Me.txtTheoMaHoaDon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTheoMaHoaDon.Enabled = False
        Me.txtTheoMaHoaDon.Location = New System.Drawing.Point(3, 283)
        Me.txtTheoMaHoaDon.Name = "txtTheoMaHoaDon"
        Me.txtTheoMaHoaDon.Size = New System.Drawing.Size(241, 26)
        Me.txtTheoMaHoaDon.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTheoMaHoaDon.TabIndex = 52
        Me.txtTheoMaHoaDon.Visible = False
        '
        'chkTheoMaHoaDon
        '
        Me.chkTheoMaHoaDon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoMaHoaDon.Location = New System.Drawing.Point(3, 252)
        Me.chkTheoMaHoaDon.Name = "chkTheoMaHoaDon"
        Me.chkTheoMaHoaDon.Size = New System.Drawing.Size(241, 25)
        Me.chkTheoMaHoaDon.TabIndex = 51
        Me.chkTheoMaHoaDon.Values.Text = "Theo Mã Hóa Đơn"
        Me.chkTheoMaHoaDon.Visible = False
        '
        'chkTheoKhachHang
        '
        Me.chkTheoKhachHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoKhachHang.Location = New System.Drawing.Point(3, 130)
        Me.chkTheoKhachHang.Name = "chkTheoKhachHang"
        Me.chkTheoKhachHang.Size = New System.Drawing.Size(241, 25)
        Me.chkTheoKhachHang.TabIndex = 51
        Me.chkTheoKhachHang.Values.Text = "Theo Khách Hàng"
        '
        'chkTheoNhanVien
        '
        Me.chkTheoNhanVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoNhanVien.Location = New System.Drawing.Point(3, 69)
        Me.chkTheoNhanVien.Name = "chkTheoNhanVien"
        Me.chkTheoNhanVien.Size = New System.Drawing.Size(241, 25)
        Me.chkTheoNhanVien.TabIndex = 51
        Me.chkTheoNhanVien.Values.Text = "Theo Nhân Viên Lập"
        '
        'lblThongBao
        '
        Me.lblThongBao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThongBao.Location = New System.Drawing.Point(3, 364)
        Me.lblThongBao.Name = "lblThongBao"
        Me.lblThongBao.Size = New System.Drawing.Size(247, 23)
        Me.lblThongBao.StateCommon.ShortText.Color1 = System.Drawing.Color.Red
        Me.lblThongBao.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThongBao.TabIndex = 50
        Me.lblThongBao.Values.Text = "[Không tìm thấy dữ liệu phù hợp]"
        Me.lblThongBao.Visible = False
        '
        'cmbNhanVien
        '
        Me.cmbNhanVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNhanVien.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatNhanVien})
        Me.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhanVien.DropDownWidth = 121
        Me.cmbNhanVien.Enabled = False
        Me.cmbNhanVien.Location = New System.Drawing.Point(3, 100)
        Me.cmbNhanVien.Name = "cmbNhanVien"
        Me.cmbNhanVien.Size = New System.Drawing.Size(241, 24)
        Me.cmbNhanVien.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhanVien.TabIndex = 45
        '
        'btnCapNhatNhanVien
        '
        Me.btnCapNhatNhanVien.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatNhanVien.UniqueName = "5D7526322F654BC56A87E646A6C068FE"
        '
        'cmbKhachHang
        '
        Me.cmbKhachHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKhachHang.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnTimKiemKhachHang, Me.btnCapNhatKhachHang})
        Me.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhachHang.DropDownWidth = 121
        Me.cmbKhachHang.Enabled = False
        Me.cmbKhachHang.Location = New System.Drawing.Point(3, 161)
        Me.cmbKhachHang.Name = "cmbKhachHang"
        Me.cmbKhachHang.Size = New System.Drawing.Size(241, 24)
        Me.cmbKhachHang.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKhachHang.TabIndex = 44
        '
        'btnTimKiemKhachHang
        '
        Me.btnTimKiemKhachHang.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnTimKiemKhachHang.UniqueName = "E80EA017F6E542F2D3A1E6DFCEE8C97E"
        '
        'btnCapNhatKhachHang
        '
        Me.btnCapNhatKhachHang.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatKhachHang.UniqueName = "5D7526322F654BC56A87E646A6C068FE"
        '
        'CtrlTimKiemTheoThoiGian1
        '
        Me.CtrlTimKiemTheoThoiGian1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtrlTimKiemTheoThoiGian1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlTimKiemTheoThoiGian1.Name = "CtrlTimKiemTheoThoiGian1"
        Me.CtrlTimKiemTheoThoiGian1.Size = New System.Drawing.Size(247, 60)
        Me.CtrlTimKiemTheoThoiGian1.TabIndex = 24
        Me.CtrlTimKiemTheoThoiGian1.TheoChinhXacGio = False
        Me.CtrlTimKiemTheoThoiGian1.TMTNow = New Date(2017, 5, 6, 15, 53, 41, 444)
        Me.CtrlTimKiemTheoThoiGian1.ToiLuc = New Date(2013, 8, 13, 0, 0, 0, 0)
        Me.CtrlTimKiemTheoThoiGian1.TuLuc = New Date(2013, 8, 13, 0, 0, 0, 0)
        '
        'gridControl
        '
        Me.gridControl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 0)
        Me.gridControl.MainView = Me.gridViewData
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1047, 485)
        Me.gridControl.TabIndex = 10
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewData})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnXemPhieu, Me.btnSuaHoaDon, Me.btnXoaHoaDon, Me.ToolStripSeparator1, Me.btnInDanhSach, Me.btnXuatExcel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 142)
        '
        'btnXemPhieu
        '
        Me.btnXemPhieu.Image = Global.PhanMemBanHang.My.Resources.Resources.Xem_16
        Me.btnXemPhieu.Name = "btnXemPhieu"
        Me.btnXemPhieu.Size = New System.Drawing.Size(141, 22)
        Me.btnXemPhieu.Text = "Xem phiếu"
        '
        'btnSuaHoaDon
        '
        Me.btnSuaHoaDon.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua_16
        Me.btnSuaHoaDon.Name = "btnSuaHoaDon"
        Me.btnSuaHoaDon.Size = New System.Drawing.Size(141, 22)
        Me.btnSuaHoaDon.Text = "Sửa hóa đơn"
        '
        'btnXoaHoaDon
        '
        Me.btnXoaHoaDon.Image = Global.PhanMemBanHang.My.Resources.Resources.Huy16
        Me.btnXoaHoaDon.Name = "btnXoaHoaDon"
        Me.btnXoaHoaDon.Size = New System.Drawing.Size(141, 22)
        Me.btnXoaHoaDon.Text = "Xóa hóa đơn"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(138, 6)
        '
        'btnInDanhSach
        '
        Me.btnInDanhSach.Image = Global.PhanMemBanHang.My.Resources.Resources.Print16
        Me.btnInDanhSach.Name = "btnInDanhSach"
        Me.btnInDanhSach.Size = New System.Drawing.Size(141, 22)
        Me.btnInDanhSach.Text = "In danh sách"
        '
        'btnXuatExcel
        '
        Me.btnXuatExcel.Image = Global.PhanMemBanHang.My.Resources.Resources.Excel16
        Me.btnXuatExcel.Name = "btnXuatExcel"
        Me.btnXuatExcel.Size = New System.Drawing.Size(152, 22)
        Me.btnXuatExcel.Text = "Xuất Excel"
        '
        'gridViewData
        '
        Me.gridViewData.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridViewData.Appearance.FooterPanel.Options.UseFont = True
        Me.gridViewData.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridViewData.Appearance.GroupFooter.Options.UseFont = True
        Me.gridViewData.Appearance.GroupFooter.Options.UseTextOptions = True
        Me.gridViewData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridViewData.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridViewData.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gridViewData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridViewData.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridViewData.Appearance.Row.Options.UseFont = True
        Me.gridViewData.Appearance.Row.Options.UseTextOptions = True
        Me.gridViewData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn9, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn13, Me.GridColumn8, Me.GridColumn14, Me.GridColumn3, Me.GridColumn10, Me.GridColumn15, Me.GridColumn11, Me.GridColumn12})
        Me.gridViewData.GridControl = Me.gridControl
        Me.gridViewData.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", Me.GridColumn1, "Cộng: {0:n0}")})
        Me.gridViewData.IndicatorWidth = 50
        Me.gridViewData.Name = "gridViewData"
        Me.gridViewData.OptionsBehavior.Editable = False
        Me.gridViewData.OptionsView.ColumnAutoWidth = False
        Me.gridViewData.OptionsView.ShowAutoFilterRow = True
        Me.gridViewData.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã phiếu"
        Me.GridColumn1.FieldName = "MaHoaDon"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", "Cộng: {0:n0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ngày lập"
        Me.GridColumn9.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "NgayLap"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 130
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Khách hàng"
        Me.GridColumn2.FieldName = "TenKhachHang"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 300
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn4.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn4.Caption = "Tiền trước thuế"
        Me.GridColumn4.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "TienTruocThue"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienTruocThue", "{0:n0}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 120
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "CK"
        Me.GridColumn5.DisplayFormat.FormatString = "##0.##"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "ChietKhau"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn5.Width = 60
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn6.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn6.Caption = "Tiền CK"
        Me.GridColumn6.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "TongTienChietKhau"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienChietKhau", "{0:n0}")})
        Me.GridColumn6.Width = 100
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "VAT"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "VAT"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 60
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.ForeColor = System.Drawing.Color.Green
        Me.GridColumn13.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn13.Caption = "Tiền Thuế"
        Me.GridColumn13.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "TongTienVAT"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienVAT", "{0:n0}")})
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 5
        Me.GridColumn13.Width = 120
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn8.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn8.Caption = "Tổng tiền"
        Me.GridColumn8.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "TongTien"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTien", "{0:n0}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 120
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Tiền phí"
        Me.GridColumn14.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "TienPhi"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn14.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienPhi", "{0:n0}")})
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 7
        Me.GridColumn14.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "HTTT"
        Me.GridColumn3.FieldName = "HinhThucThanhToan"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 8
        Me.GridColumn3.Width = 100
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nhân viên lập"
        Me.GridColumn10.FieldName = "TenNhanVien"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 100
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "NV thu tiền"
        Me.GridColumn15.FieldName = "TenNhanVienThuTien"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 10
        Me.GridColumn15.Width = 100
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Ghi chú"
        Me.GridColumn11.FieldName = "GhiChu"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 11
        Me.GridColumn11.Width = 300
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "id"
        Me.GridColumn12.FieldName = "id"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThemHoaDonDauRa, Me.btnThemHoaDonDauVao, Me.lblTieuDe})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1299, 25)
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnThemHoaDonDauRa
        '
        Me.btnThemHoaDonDauRa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnThemHoaDonDauRa.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThemHoaDonDauRa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemHoaDonDauRa.Name = "btnThemHoaDonDauRa"
        Me.btnThemHoaDonDauRa.Size = New System.Drawing.Size(168, 22)
        Me.btnThemHoaDonDauRa.Text = "[F4]Thêm Hóa Đơn Đầu Ra"
        '
        'btnThemHoaDonDauVao
        '
        Me.btnThemHoaDonDauVao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnThemHoaDonDauVao.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThemHoaDonDauVao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemHoaDonDauVao.Name = "btnThemHoaDonDauVao"
        Me.btnThemHoaDonDauVao.Size = New System.Drawing.Size(174, 22)
        Me.btnThemHoaDonDauVao.Text = "[F3]Thêm Hóa Đơn Đầu Vào"
        '
        'lblTieuDe
        '
        Me.lblTieuDe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(126, 22)
        Me.lblTieuDe.Text = "THỐNG KÊ HÓA ĐƠN"
        '
        'ctrlThongKeHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "ctrlThongKeHoaDon"
        Me.Size = New System.Drawing.Size(1299, 510)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.cmbHinhThucThanhToan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gridViewData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents CtrlTimKiemTheoThoiGian1 As TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian
    Friend WithEvents cmbNhanVien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatNhanVien As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents cmbKhachHang As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatKhachHang As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnTimKiemKhachHang As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents chkTheoKhachHang As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents chkTheoNhanVien As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents txtTheoMaHoaDon As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkTheoMaHoaDon As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblThongBao As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkTheoHinhThucThanhToan As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents cmbHinhThucThanhToan As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TenNguoiLam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btnThemHoaDonDauRa As ToolStripButton
    Friend WithEvents btnThemHoaDonDauVao As ToolStripButton
    Friend WithEvents lblTieuDe As ToolStripLabel
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnXemPhieu As ToolStripMenuItem
    Friend WithEvents btnSuaHoaDon As ToolStripMenuItem
    Friend WithEvents btnXoaHoaDon As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnInDanhSach As ToolStripMenuItem
    Friend WithEvents btnXuatExcel As ToolStripMenuItem
End Class
