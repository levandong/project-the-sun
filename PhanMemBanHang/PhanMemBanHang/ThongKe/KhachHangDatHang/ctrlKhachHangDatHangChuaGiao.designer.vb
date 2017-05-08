<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlKhachHangDatHangChuaGiao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlKhachHangDatHangChuaGiao))
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridViewData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDonDatHang = New System.Windows.Forms.ToolStripButton()
        Me.chkPhieuDatHang = New System.Windows.Forms.ToolStripButton()
        Me.btnInDanhSach = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInKhachHangDatHang = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnXemVaInTuDong = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuItemExportExcel = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Panel1Collapsed = True
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.gridControl)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1443, 485)
        Me.KryptonSplitContainer1.SplitterDistance = 481
        Me.KryptonSplitContainer1.TabIndex = 2
        '
        'gridControl
        '
        Me.gridControl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 0)
        Me.gridControl.MainView = Me.gridViewData
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gridControl.Size = New System.Drawing.Size(1443, 485)
        Me.gridControl.TabIndex = 11
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewData})
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
        Me.gridViewData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn1, Me.GridColumn9, Me.GridColumn2, Me.GridColumn15, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn13, Me.GridColumn8, Me.GridColumn3, Me.GridColumn10, Me.GridColumn14, Me.GridColumn11, Me.GridColumn12})
        Me.gridViewData.GridControl = Me.gridControl
        Me.gridViewData.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", Me.GridColumn1, "Cộng: {0:n0}")})
        Me.gridViewData.IndicatorWidth = 50
        Me.gridViewData.Name = "gridViewData"
        Me.gridViewData.OptionsBehavior.Editable = False
        Me.gridViewData.OptionsView.ColumnAutoWidth = False
        Me.gridViewData.OptionsView.ShowAutoFilterRow = True
        Me.gridViewData.OptionsView.ShowFooter = True
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "N/X"
        Me.GridColumn16.FieldName = "Loai"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 0
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Đã xong"
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn17.FieldName = "isGiaoHangXong"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn17.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 1
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Đã xuất"
        Me.GridColumn18.FieldName = "DaLapHoaDon"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 2
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã phiếu"
        Me.GridColumn1.FieldName = "MaDatHang"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", "Cộng: {0:n0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 100
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ngày dự kiến"
        Me.GridColumn9.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "NgayDuKienGiaoHang"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 4
        Me.GridColumn9.Width = 110
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Khách hàng"
        Me.GridColumn2.FieldName = "TenKhachHang"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 300
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Công trình"
        Me.GridColumn15.FieldName = "CongTrinh"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 6
        Me.GridColumn15.Width = 200
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn4.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn4.Caption = "Cộng tiền"
        Me.GridColumn4.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "CongTien"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CongTien", "{0:n0}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 7
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
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 8
        Me.GridColumn5.Width = 60
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn6.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn6.Caption = "Chiết khấu"
        Me.GridColumn6.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "TongTienChietKhau"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienChietKhau", "{0:n0}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 9
        Me.GridColumn6.Width = 120
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "VAT"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "VAT"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 10
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
        Me.GridColumn13.VisibleIndex = 11
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
        Me.GridColumn8.VisibleIndex = 12
        Me.GridColumn8.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Địa chỉ"
        Me.GridColumn3.FieldName = "DiaChi"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 13
        Me.GridColumn3.Width = 200
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nhân viên lập"
        Me.GridColumn10.FieldName = "TenNhanVien"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 14
        Me.GridColumn10.Width = 150
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Ngày lập"
        Me.GridColumn14.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn14.FieldName = "NgayLap"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 15
        Me.GridColumn14.Width = 110
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Ghi chú"
        Me.GridColumn11.FieldName = "GhiChu"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 16
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
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator8, Me.btnDonDatHang, Me.chkPhieuDatHang, Me.btnInDanhSach, Me.ToolStripSeparator6, Me.btnInKhachHangDatHang})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1443, 25)
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(276, 22)
        Me.ToolStripLabel1.Text = "DANH SÁCH ĐƠN ĐẶT HÀNG/PHIẾU ĐẶT HÀNG"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btnDonDatHang
        '
        Me.btnDonDatHang.Checked = True
        Me.btnDonDatHang.CheckOnClick = True
        Me.btnDonDatHang.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnDonDatHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDonDatHang.Image = CType(resources.GetObject("btnDonDatHang.Image"), System.Drawing.Image)
        Me.btnDonDatHang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDonDatHang.Name = "btnDonDatHang"
        Me.btnDonDatHang.Size = New System.Drawing.Size(100, 22)
        Me.btnDonDatHang.Text = "ĐƠN ĐẶT HÀNG"
        '
        'chkPhieuDatHang
        '
        Me.chkPhieuDatHang.CheckOnClick = True
        Me.chkPhieuDatHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.chkPhieuDatHang.Image = CType(resources.GetObject("chkPhieuDatHang.Image"), System.Drawing.Image)
        Me.chkPhieuDatHang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.chkPhieuDatHang.Name = "chkPhieuDatHang"
        Me.chkPhieuDatHang.Size = New System.Drawing.Size(107, 22)
        Me.chkPhieuDatHang.Text = "PHIẾU ĐẶT HÀNG"
        '
        'btnInDanhSach
        '
        Me.btnInDanhSach.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnInDanhSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInDanhSach.Image = Global.PhanMemBanHang.My.Resources.Resources.Print16
        Me.btnInDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInDanhSach.Name = "btnInDanhSach"
        Me.btnInDanhSach.Size = New System.Drawing.Size(38, 22)
        Me.btnInDanhSach.Text = "In"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnInKhachHangDatHang
        '
        Me.btnInKhachHangDatHang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnInKhachHangDatHang.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnXemVaInTuDong, Me.XemToolStripMenuItem})
        Me.btnInKhachHangDatHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInKhachHangDatHang.Image = Global.PhanMemBanHang.My.Resources.Resources.Print16
        Me.btnInKhachHangDatHang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInKhachHangDatHang.Name = "btnInKhachHangDatHang"
        Me.btnInKhachHangDatHang.Size = New System.Drawing.Size(83, 22)
        Me.btnInKhachHangDatHang.Text = "In phiếu"
        '
        'btnXemVaInTuDong
        '
        Me.btnXemVaInTuDong.Image = Global.PhanMemBanHang.My.Resources.Resources.Print16
        Me.btnXemVaInTuDong.Name = "btnXemVaInTuDong"
        Me.btnXemVaInTuDong.Size = New System.Drawing.Size(173, 22)
        Me.btnXemVaInTuDong.Text = "In lại đơn đặt hàng"
        '
        'XemToolStripMenuItem
        '
        Me.XemToolStripMenuItem.Image = Global.PhanMemBanHang.My.Resources.Resources.TuyChinhTimKiem16
        Me.XemToolStripMenuItem.Name = "XemToolStripMenuItem"
        Me.XemToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.XemToolStripMenuItem.Text = "Xem nhanh"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemExportExcel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'mnuItemExportExcel
        '
        Me.mnuItemExportExcel.Image = Global.PhanMemBanHang.My.Resources.Resources.Excel16
        Me.mnuItemExportExcel.Name = "mnuItemExportExcel"
        Me.mnuItemExportExcel.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemExportExcel.Text = "Xuất Excel"
        '
        'ctrlKhachHangDatHangChuaGiao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "ctrlKhachHangDatHangChuaGiao"
        Me.Size = New System.Drawing.Size(1443, 510)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents btnXoaDonDatHang As ToolStripButton
    Friend WithEvents btnSuaDonDatHang As ToolStripButton
    Friend WithEvents btnTaoHoaDon As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents btnDonDatHang As ToolStripButton
    Friend WithEvents chkPhieuDatHang As ToolStripButton
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
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnInDanhSach As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btnInKhachHangDatHang As ToolStripDropDownButton
    Friend WithEvents btnXemVaInTuDong As ToolStripMenuItem
    Friend WithEvents XemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents mnuItemExportExcel As ToolStripMenuItem
End Class
