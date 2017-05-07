<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlNghiepVuChuanBiHangHoa
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.grdData = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChọnTấtCảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChuyểnBáoGiáToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsSanPhanCanNhap = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdViewData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaSanPham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTenSanPham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTonKho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTonKhoToiThieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoLuongChuanBiNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoLuongChuanBiXuat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoLuongCan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoLuongMua = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTenKhachHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTenCongTrinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkIsSelect = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.chkActiveItem = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.chkSystemItem = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chon = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.MaSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TonKho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TonKhoToiThieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongChuanBiNhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongChuanBiXuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongCan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongMua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhachHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenCongTrinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.btnCapNhatLaiSoThuTu = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnTinhToanTonKhoHienTai = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnRefresh = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.bsSanPhanCanNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActiveItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSystemItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.grdData)
        Me.KryptonPanel1.Controls.Add(Me.dgvMain)
        Me.KryptonPanel1.Controls.Add(Me.KryptonHeader1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1145, 438)
        Me.KryptonPanel1.TabIndex = 0
        '
        'grdData
        '
        Me.grdData.ContextMenuStrip = Me.ContextMenuStrip1
        Me.grdData.DataSource = Me.bsSanPhanCanNhap
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.grdData.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdData.Location = New System.Drawing.Point(0, 31)
        Me.grdData.MainView = Me.grdViewData
        Me.grdData.Name = "grdData"
        Me.grdData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkIsSelect, Me.chkActiveItem, Me.chkSystemItem})
        Me.grdData.Size = New System.Drawing.Size(1145, 407)
        Me.grdData.TabIndex = 3
        Me.grdData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewData})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChọnTấtCảToolStripMenuItem, Me.ChuyểnBáoGiáToolStripMenuItem, Me.XToolStripMenuItem, Me.ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem, Me.ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(241, 114)
        '
        'ChọnTấtCảToolStripMenuItem
        '
        Me.ChọnTấtCảToolStripMenuItem.Name = "ChọnTấtCảToolStripMenuItem"
        Me.ChọnTấtCảToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ChọnTấtCảToolStripMenuItem.Text = "Chọn tất cả"
        '
        'ChuyểnBáoGiáToolStripMenuItem
        '
        Me.ChuyểnBáoGiáToolStripMenuItem.Name = "ChuyểnBáoGiáToolStripMenuItem"
        Me.ChuyểnBáoGiáToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ChuyểnBáoGiáToolStripMenuItem.Text = "Chuyển báo giá"
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.XToolStripMenuItem.Text = "Chuyển phiếu đặt hàng"
        '
        'ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem
        '
        Me.ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem.Name = "ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem"
        Me.ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem.Text = "Chi tiết các phiếu yêu cầu nhập"
        Me.ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem.Visible = False
        '
        'ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem
        '
        Me.ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem.Name = "ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem"
        Me.ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem.Text = "Chi tiết các phiếu yêu cầu xuất"
        Me.ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem.Visible = False
        '
        'bsSanPhanCanNhap
        '
        Me.bsSanPhanCanNhap.DataSource = GetType(PhanMemBanHang.clsSanPhamCanNhap)
        '
        'grdViewData
        '
        Me.grdViewData.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdViewData.Appearance.FocusedRow.Options.UseFont = True
        Me.grdViewData.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdViewData.Appearance.FooterPanel.Options.UseFont = True
        Me.grdViewData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdViewData.Appearance.HeaderPanel.Options.UseFont = True
        Me.grdViewData.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grdViewData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdViewData.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.grdViewData.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdViewData.Appearance.Preview.Options.UseFont = True
        Me.grdViewData.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdViewData.Appearance.Row.Options.UseFont = True
        Me.grdViewData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMaSanPham, Me.colTenSanPham, Me.colTonKho, Me.colTonKhoToiThieu, Me.colSoLuongChuanBiNhap, Me.colSoLuongChuanBiXuat, Me.colSoLuongCan, Me.colSoLuongMua, Me.colTenKhachHang, Me.colTenCongTrinh})
        Me.grdViewData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grdViewData.GridControl = Me.grdData
        Me.grdViewData.IndicatorWidth = 50
        Me.grdViewData.Name = "grdViewData"
        Me.grdViewData.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = False
        Me.grdViewData.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.grdViewData.OptionsNavigation.UseTabKey = False
        Me.grdViewData.OptionsView.ColumnAutoWidth = False
        Me.grdViewData.OptionsView.ShowAutoFilterRow = True
        Me.grdViewData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.grdViewData.OptionsView.ShowFooter = True
        Me.grdViewData.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 40
        '
        'colMaSanPham
        '
        Me.colMaSanPham.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaSanPham.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaSanPham.Caption = "Mã sản phẩm"
        Me.colMaSanPham.FieldName = "MaSanPham"
        Me.colMaSanPham.Name = "colMaSanPham"
        Me.colMaSanPham.OptionsColumn.AllowEdit = False
        Me.colMaSanPham.OptionsColumn.ReadOnly = True
        Me.colMaSanPham.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", "Tổng cộng: {0:n0}")})
        Me.colMaSanPham.Visible = True
        Me.colMaSanPham.VisibleIndex = 1
        Me.colMaSanPham.Width = 120
        '
        'colTenSanPham
        '
        Me.colTenSanPham.Caption = "Tên sản phẩm"
        Me.colTenSanPham.FieldName = "TenSanPham"
        Me.colTenSanPham.Name = "colTenSanPham"
        Me.colTenSanPham.OptionsColumn.AllowEdit = False
        Me.colTenSanPham.OptionsColumn.ReadOnly = True
        Me.colTenSanPham.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTenSanPham.Visible = True
        Me.colTenSanPham.VisibleIndex = 2
        Me.colTenSanPham.Width = 300
        '
        'colTonKho
        '
        Me.colTonKho.Caption = "Tồn kho"
        Me.colTonKho.FieldName = "TonKho"
        Me.colTonKho.Name = "colTonKho"
        Me.colTonKho.OptionsColumn.AllowEdit = False
        Me.colTonKho.OptionsColumn.ReadOnly = True
        Me.colTonKho.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TonKho", "{0:n0}")})
        Me.colTonKho.Visible = True
        Me.colTonKho.VisibleIndex = 3
        Me.colTonKho.Width = 90
        '
        'colTonKhoToiThieu
        '
        Me.colTonKhoToiThieu.Caption = "Tồn tối thiểu"
        Me.colTonKhoToiThieu.FieldName = "TonKhoToiThieu"
        Me.colTonKhoToiThieu.Name = "colTonKhoToiThieu"
        Me.colTonKhoToiThieu.OptionsColumn.AllowEdit = False
        Me.colTonKhoToiThieu.OptionsColumn.ReadOnly = True
        Me.colTonKhoToiThieu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TonKhoToiThieu", "{0:n0}")})
        Me.colTonKhoToiThieu.Visible = True
        Me.colTonKhoToiThieu.VisibleIndex = 4
        Me.colTonKhoToiThieu.Width = 90
        '
        'colSoLuongChuanBiNhap
        '
        Me.colSoLuongChuanBiNhap.Caption = "SL C.B Nhập"
        Me.colSoLuongChuanBiNhap.FieldName = "SoLuongChuanBiNhap"
        Me.colSoLuongChuanBiNhap.Name = "colSoLuongChuanBiNhap"
        Me.colSoLuongChuanBiNhap.OptionsColumn.AllowEdit = False
        Me.colSoLuongChuanBiNhap.OptionsColumn.ReadOnly = True
        Me.colSoLuongChuanBiNhap.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongChuanBiNhap", "{0:n0}")})
        Me.colSoLuongChuanBiNhap.Visible = True
        Me.colSoLuongChuanBiNhap.VisibleIndex = 5
        Me.colSoLuongChuanBiNhap.Width = 90
        '
        'colSoLuongChuanBiXuat
        '
        Me.colSoLuongChuanBiXuat.Caption = "SL C.B Xuất"
        Me.colSoLuongChuanBiXuat.FieldName = "SoLuongChuanBiXuat"
        Me.colSoLuongChuanBiXuat.Name = "colSoLuongChuanBiXuat"
        Me.colSoLuongChuanBiXuat.OptionsColumn.AllowEdit = False
        Me.colSoLuongChuanBiXuat.OptionsColumn.ReadOnly = True
        Me.colSoLuongChuanBiXuat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongChuanBiXuat", "{0:n0}")})
        Me.colSoLuongChuanBiXuat.Visible = True
        Me.colSoLuongChuanBiXuat.VisibleIndex = 6
        Me.colSoLuongChuanBiXuat.Width = 90
        '
        'colSoLuongCan
        '
        Me.colSoLuongCan.Caption = "SL Cần"
        Me.colSoLuongCan.FieldName = "SoLuongCan"
        Me.colSoLuongCan.Name = "colSoLuongCan"
        Me.colSoLuongCan.OptionsColumn.AllowEdit = False
        Me.colSoLuongCan.OptionsColumn.ReadOnly = True
        Me.colSoLuongCan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongCan", "{0:n0}")})
        Me.colSoLuongCan.Visible = True
        Me.colSoLuongCan.VisibleIndex = 7
        Me.colSoLuongCan.Width = 90
        '
        'colSoLuongMua
        '
        Me.colSoLuongMua.Caption = "SL Mua"
        Me.colSoLuongMua.FieldName = "SoLuongMua"
        Me.colSoLuongMua.Name = "colSoLuongMua"
        Me.colSoLuongMua.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongMua", "{0:n0}")})
        Me.colSoLuongMua.Visible = True
        Me.colSoLuongMua.VisibleIndex = 8
        Me.colSoLuongMua.Width = 90
        '
        'colTenKhachHang
        '
        Me.colTenKhachHang.Caption = "Tên khách hàng"
        Me.colTenKhachHang.FieldName = "TenKhachHang"
        Me.colTenKhachHang.Name = "colTenKhachHang"
        Me.colTenKhachHang.OptionsColumn.AllowEdit = False
        Me.colTenKhachHang.OptionsColumn.ReadOnly = True
        Me.colTenKhachHang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTenKhachHang.Visible = True
        Me.colTenKhachHang.VisibleIndex = 9
        Me.colTenKhachHang.Width = 200
        '
        'colTenCongTrinh
        '
        Me.colTenCongTrinh.Caption = "Tên công trình"
        Me.colTenCongTrinh.FieldName = "TenCongTrinh"
        Me.colTenCongTrinh.Name = "colTenCongTrinh"
        Me.colTenCongTrinh.OptionsColumn.AllowEdit = False
        Me.colTenCongTrinh.OptionsColumn.ReadOnly = True
        Me.colTenCongTrinh.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTenCongTrinh.Visible = True
        Me.colTenCongTrinh.VisibleIndex = 10
        Me.colTenCongTrinh.Width = 200
        '
        'chkIsSelect
        '
        Me.chkIsSelect.AutoHeight = False
        Me.chkIsSelect.Name = "chkIsSelect"
        '
        'chkActiveItem
        '
        Me.chkActiveItem.AutoHeight = False
        Me.chkActiveItem.Name = "chkActiveItem"
        Me.chkActiveItem.ValueChecked = CType(1, Short)
        Me.chkActiveItem.ValueUnchecked = CType(0, Short)
        '
        'chkSystemItem
        '
        Me.chkSystemItem.AutoHeight = False
        Me.chkSystemItem.Name = "chkSystemItem"
        Me.chkSystemItem.ValueChecked = CType(1, Short)
        Me.chkSystemItem.ValueUnchecked = CType(0, Short)
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.Chon, Me.MaSanPham, Me.TenSanPham, Me.TonKho, Me.TonKhoToiThieu, Me.SoLuongChuanBiNhap, Me.SoLuongChuanBiXuat, Me.SoLuongCan, Me.SoLuongMua, Me.TenKhachHang, Me.TenCongTrinh, Me.Fill})
        Me.dgvMain.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvMain.DataSource = Me.bsSanPhanCanNhap
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 31)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.RowHeadersWidth = 5
        Me.dgvMain.Size = New System.Drawing.Size(1145, 407)
        Me.dgvMain.TabIndex = 1
        Me.dgvMain.VirtualMode = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.Chon.DefaultCellStyle = DataGridViewCellStyle1
        Me.Chon.FalseValue = Nothing
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.IndeterminateValue = Nothing
        Me.Chon.Name = "Chon"
        Me.Chon.TrueValue = Nothing
        Me.Chon.Width = 40
        '
        'MaSanPham
        '
        Me.MaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaSanPham.DataPropertyName = "MaSanPham"
        Me.MaSanPham.HeaderText = "Mã sản phẩm"
        Me.MaSanPham.Name = "MaSanPham"
        Me.MaSanPham.ReadOnly = True
        Me.MaSanPham.Width = 108
        '
        'TenSanPham
        '
        Me.TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenSanPham.DataPropertyName = "TenSanPham"
        Me.TenSanPham.HeaderText = "Tên sản phẩm"
        Me.TenSanPham.Name = "TenSanPham"
        Me.TenSanPham.ReadOnly = True
        Me.TenSanPham.Width = 110
        '
        'TonKho
        '
        Me.TonKho.DataPropertyName = "TonKho"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "###,###,###,##0.####"
        Me.TonKho.DefaultCellStyle = DataGridViewCellStyle2
        Me.TonKho.HeaderText = "Tồn"
        Me.TonKho.Name = "TonKho"
        Me.TonKho.ReadOnly = True
        Me.TonKho.Width = 70
        '
        'TonKhoToiThieu
        '
        Me.TonKhoToiThieu.DataPropertyName = "TonKhoToiThieu"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "###,###,###,##0.####"
        Me.TonKhoToiThieu.DefaultCellStyle = DataGridViewCellStyle3
        Me.TonKhoToiThieu.HeaderText = "Tồn tối thiểu"
        Me.TonKhoToiThieu.Name = "TonKhoToiThieu"
        Me.TonKhoToiThieu.ReadOnly = True
        '
        'SoLuongChuanBiNhap
        '
        Me.SoLuongChuanBiNhap.DataPropertyName = "SoLuongChuanBiNhap"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "###,###,###,##0.####"
        Me.SoLuongChuanBiNhap.DefaultCellStyle = DataGridViewCellStyle4
        Me.SoLuongChuanBiNhap.HeaderText = "S.L C.B Nhập"
        Me.SoLuongChuanBiNhap.Name = "SoLuongChuanBiNhap"
        Me.SoLuongChuanBiNhap.ReadOnly = True
        '
        'SoLuongChuanBiXuat
        '
        Me.SoLuongChuanBiXuat.DataPropertyName = "SoLuongChuanBiXuat"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "###,###,###,##0.####"
        Me.SoLuongChuanBiXuat.DefaultCellStyle = DataGridViewCellStyle5
        Me.SoLuongChuanBiXuat.HeaderText = "SL C.B Xuất"
        Me.SoLuongChuanBiXuat.Name = "SoLuongChuanBiXuat"
        Me.SoLuongChuanBiXuat.ReadOnly = True
        '
        'SoLuongCan
        '
        Me.SoLuongCan.DataPropertyName = "SoLuongCan"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "###,###,###,##0.####"
        Me.SoLuongCan.DefaultCellStyle = DataGridViewCellStyle6
        Me.SoLuongCan.HeaderText = "S.L cần nhập"
        Me.SoLuongCan.Name = "SoLuongCan"
        Me.SoLuongCan.ReadOnly = True
        '
        'SoLuongMua
        '
        Me.SoLuongMua.DataPropertyName = "SoLuongMua"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SoLuongMua.DefaultCellStyle = DataGridViewCellStyle7
        Me.SoLuongMua.HeaderText = "S.L Mua"
        Me.SoLuongMua.Name = "SoLuongMua"
        Me.SoLuongMua.Width = 80
        '
        'TenKhachHang
        '
        Me.TenKhachHang.DataPropertyName = "TenKhachHang"
        Me.TenKhachHang.HeaderText = "Tên Khách Hàng"
        Me.TenKhachHang.Name = "TenKhachHang"
        Me.TenKhachHang.Width = 160
        '
        'TenCongTrinh
        '
        Me.TenCongTrinh.DataPropertyName = "TenCongTrinh"
        Me.TenCongTrinh.HeaderText = "Tên Công Trình"
        Me.TenCongTrinh.Name = "TenCongTrinh"
        Me.TenCongTrinh.Width = 220
        '
        'Fill
        '
        Me.Fill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Fill.HeaderText = " "
        Me.Fill.Name = "Fill"
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatLaiSoThuTu, Me.btnTinhToanTonKhoHienTai, Me.btnRefresh})
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(1145, 31)
        Me.KryptonHeader1.TabIndex = 0
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Chuẩn bị hàng hóa cho phiếu đặt hàng"
        Me.KryptonHeader1.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Ban_Hang_16
        '
        'btnCapNhatLaiSoThuTu
        '
        Me.btnCapNhatLaiSoThuTu.Image = Global.PhanMemBanHang.My.Resources.Resources.Cap_Nhat_16
        Me.btnCapNhatLaiSoThuTu.Text = "Cập nhật STT"
        Me.btnCapNhatLaiSoThuTu.UniqueName = "382126860723450A7A989C9D9404FEF2"
        Me.btnCapNhatLaiSoThuTu.Visible = False
        '
        'btnTinhToanTonKhoHienTai
        '
        Me.btnTinhToanTonKhoHienTai.Image = Global.PhanMemBanHang.My.Resources.Resources.calculator16x16
        Me.btnTinhToanTonKhoHienTai.Text = "Tính lại tồn kho hiện tại"
        Me.btnTinhToanTonKhoHienTai.UniqueName = "2023801DBC9C40CB978ED10359741BDC"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh1616
        Me.btnRefresh.Text = "Làm mới"
        Me.btnRefresh.UniqueName = "475A0F3FA94C4F64CCA62DF5C115D3C6"
        '
        'ctrlNghiepVuChuanBiHangHoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlNghiepVuChuanBiHangHoa"
        Me.Size = New System.Drawing.Size(1145, 438)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.bsSanPhanCanNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActiveItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSystemItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTinhToanTonKhoHienTai As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnRefresh As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsSanPhanCanNhap As BindingSource
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ChọnTấtCảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChuyểnBáoGiáToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCapNhatLaiSoThuTu As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents Chon As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents MaSanPham As DataGridViewTextBoxColumn
    Friend WithEvents TenSanPham As DataGridViewTextBoxColumn
    Friend WithEvents TonKho As DataGridViewTextBoxColumn
    Friend WithEvents TonKhoToiThieu As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongChuanBiNhap As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongChuanBiXuat As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongCan As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongMua As DataGridViewTextBoxColumn
    Friend WithEvents TenKhachHang As DataGridViewTextBoxColumn
    Friend WithEvents TenCongTrinh As DataGridViewTextBoxColumn
    Friend WithEvents Fill As DataGridViewTextBoxColumn
    Private WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Private WithEvents grdData As DevExpress.XtraGrid.GridControl
    Private WithEvents grdViewData As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents chkIsSelect As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents chkActiveItem As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents chkSystemItem As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoLuongMua As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTenCongTrinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTenKhachHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTenSanPham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaSanPham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTonKho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTonKhoToiThieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoLuongChuanBiNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoLuongChuanBiXuat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoLuongCan As DevExpress.XtraGrid.Columns.GridColumn
End Class
