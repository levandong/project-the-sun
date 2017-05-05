<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlThongKePhieuNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlThongKePhieuNhap))
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.cmbTheoKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnTimKiemKhachHang = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnCapNhatKhachHang = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.cmbTheoLoaiPhieuNhap = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatLoaiPhieuNhap = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.cmbNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatNhanVien = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.chkTheoKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.chkTheoLoaiPhieuNhap = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.chkTheoNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.CtrlTimKiemTheoThoiGian1 = New TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.XóaPhiếuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SửaPhiếuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InPhiếuNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridViewData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblSoPhieuNhap222 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnThemPhieuNhap = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.PhiếuXuấtKkhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnIn = New System.Windows.Forms.ToolStripButton()
        Me.btnXemNhanh = New System.Windows.Forms.ToolStripButton()
        Me.btnSuaPhieu = New System.Windows.Forms.ToolStripButton()
        Me.btnXoaPhieu = New System.Windows.Forms.ToolStripButton()
        Me.btnInPhieu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NhậpCóKýHiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhiếuNhậpKhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.cmbTheoKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTheoLoaiPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbTheoKhachHang)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbTheoLoaiPhieuNhap)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbNhanVien)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnTimKiem)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoKhachHang)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoLoaiPhieuNhap)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoNhanVien)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.CtrlTimKiemTheoThoiGian1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.gridControl)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1458, 378)
        Me.KryptonSplitContainer1.SplitterDistance = 255
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'cmbTheoKhachHang
        '
        Me.cmbTheoKhachHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTheoKhachHang.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnTimKiemKhachHang, Me.btnCapNhatKhachHang})
        Me.cmbTheoKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTheoKhachHang.DropDownWidth = 226
        Me.cmbTheoKhachHang.Enabled = False
        Me.cmbTheoKhachHang.Location = New System.Drawing.Point(3, 158)
        Me.cmbTheoKhachHang.Name = "cmbTheoKhachHang"
        Me.cmbTheoKhachHang.Size = New System.Drawing.Size(249, 24)
        Me.cmbTheoKhachHang.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTheoKhachHang.TabIndex = 3
        '
        'btnTimKiemKhachHang
        '
        Me.btnTimKiemKhachHang.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnTimKiemKhachHang.UniqueName = "95BAF1CA9C5643E1C29CBCFEC265DF90"
        '
        'btnCapNhatKhachHang
        '
        Me.btnCapNhatKhachHang.Image = CType(resources.GetObject("btnCapNhatKhachHang.Image"), System.Drawing.Image)
        Me.btnCapNhatKhachHang.UniqueName = "39620113A4864BD866A59B8270DEE81C"
        '
        'cmbTheoLoaiPhieuNhap
        '
        Me.cmbTheoLoaiPhieuNhap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTheoLoaiPhieuNhap.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatLoaiPhieuNhap})
        Me.cmbTheoLoaiPhieuNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTheoLoaiPhieuNhap.DropDownWidth = 226
        Me.cmbTheoLoaiPhieuNhap.Enabled = False
        Me.cmbTheoLoaiPhieuNhap.Location = New System.Drawing.Point(3, 97)
        Me.cmbTheoLoaiPhieuNhap.Name = "cmbTheoLoaiPhieuNhap"
        Me.cmbTheoLoaiPhieuNhap.Size = New System.Drawing.Size(249, 24)
        Me.cmbTheoLoaiPhieuNhap.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTheoLoaiPhieuNhap.TabIndex = 3
        '
        'btnCapNhatLoaiPhieuNhap
        '
        Me.btnCapNhatLoaiPhieuNhap.Image = CType(resources.GetObject("btnCapNhatLoaiPhieuNhap.Image"), System.Drawing.Image)
        Me.btnCapNhatLoaiPhieuNhap.UniqueName = "39620113A4864BD866A59B8270DEE81C"
        '
        'cmbNhanVien
        '
        Me.cmbNhanVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNhanVien.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatNhanVien})
        Me.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhanVien.DropDownWidth = 226
        Me.cmbNhanVien.Enabled = False
        Me.cmbNhanVien.Location = New System.Drawing.Point(3, 221)
        Me.cmbNhanVien.Name = "cmbNhanVien"
        Me.cmbNhanVien.Size = New System.Drawing.Size(249, 24)
        Me.cmbNhanVien.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhanVien.TabIndex = 3
        '
        'btnCapNhatNhanVien
        '
        Me.btnCapNhatNhanVien.Image = CType(resources.GetObject("btnCapNhatNhanVien.Image"), System.Drawing.Image)
        Me.btnCapNhatNhanVien.UniqueName = "39620113A4864BD866A59B8270DEE81C"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimKiem.Location = New System.Drawing.Point(3, 256)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(249, 44)
        Me.btnTimKiem.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.TabIndex = 2
        Me.btnTimKiem.Values.Text = "TÌM KIẾM"
        '
        'chkTheoKhachHang
        '
        Me.chkTheoKhachHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoKhachHang.Location = New System.Drawing.Point(3, 127)
        Me.chkTheoKhachHang.Name = "chkTheoKhachHang"
        Me.chkTheoKhachHang.Size = New System.Drawing.Size(249, 25)
        Me.chkTheoKhachHang.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTheoKhachHang.TabIndex = 1
        Me.chkTheoKhachHang.Values.Text = "Theo Khách Hàng"
        '
        'chkTheoLoaiPhieuNhap
        '
        Me.chkTheoLoaiPhieuNhap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoLoaiPhieuNhap.Location = New System.Drawing.Point(3, 66)
        Me.chkTheoLoaiPhieuNhap.Name = "chkTheoLoaiPhieuNhap"
        Me.chkTheoLoaiPhieuNhap.Size = New System.Drawing.Size(249, 25)
        Me.chkTheoLoaiPhieuNhap.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTheoLoaiPhieuNhap.TabIndex = 1
        Me.chkTheoLoaiPhieuNhap.Values.Text = "Theo Loại Phiếu Nhập"
        '
        'chkTheoNhanVien
        '
        Me.chkTheoNhanVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoNhanVien.Location = New System.Drawing.Point(3, 190)
        Me.chkTheoNhanVien.Name = "chkTheoNhanVien"
        Me.chkTheoNhanVien.Size = New System.Drawing.Size(249, 25)
        Me.chkTheoNhanVien.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTheoNhanVien.TabIndex = 1
        Me.chkTheoNhanVien.Values.Text = "Theo Nhân Viên Lập"
        '
        'CtrlTimKiemTheoThoiGian1
        '
        Me.CtrlTimKiemTheoThoiGian1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlTimKiemTheoThoiGian1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlTimKiemTheoThoiGian1.Name = "CtrlTimKiemTheoThoiGian1"
        Me.CtrlTimKiemTheoThoiGian1.Size = New System.Drawing.Size(255, 94)
        Me.CtrlTimKiemTheoThoiGian1.TabIndex = 0
        Me.CtrlTimKiemTheoThoiGian1.TheoChinhXacGio = False
        Me.CtrlTimKiemTheoThoiGian1.TMTNow = New Date(2017, 2, 14, 10, 31, 57, 472)
        Me.CtrlTimKiemTheoThoiGian1.ToiLuc = New Date(2014, 2, 24, 0, 0, 0, 0)
        Me.CtrlTimKiemTheoThoiGian1.TuLuc = New Date(2014, 2, 24, 0, 0, 0, 0)
        '
        'gridControl
        '
        Me.gridControl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 0)
        Me.gridControl.MainView = Me.gridViewData
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1198, 378)
        Me.gridControl.TabIndex = 7
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewData})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XóaPhiếuToolStripMenuItem, Me.SửaPhiếuToolStripMenuItem, Me.ToolStripSeparator2, Me.InPhiếuNhậpToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(148, 76)
        '
        'XóaPhiếuToolStripMenuItem
        '
        Me.XóaPhiếuToolStripMenuItem.Image = Global.PhanMemBanHang.My.Resources.Resources.Xoa_16
        Me.XóaPhiếuToolStripMenuItem.Name = "XóaPhiếuToolStripMenuItem"
        Me.XóaPhiếuToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.XóaPhiếuToolStripMenuItem.Text = "Xóa phiếu"
        '
        'SửaPhiếuToolStripMenuItem
        '
        Me.SửaPhiếuToolStripMenuItem.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua_16
        Me.SửaPhiếuToolStripMenuItem.Name = "SửaPhiếuToolStripMenuItem"
        Me.SửaPhiếuToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SửaPhiếuToolStripMenuItem.Text = "Sửa phiếu"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(144, 6)
        '
        'InPhiếuNhậpToolStripMenuItem
        '
        Me.InPhiếuNhậpToolStripMenuItem.Image = Global.PhanMemBanHang.My.Resources.Resources.In_16
        Me.InPhiếuNhậpToolStripMenuItem.Name = "InPhiếuNhậpToolStripMenuItem"
        Me.InPhiếuNhậpToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.InPhiếuNhậpToolStripMenuItem.Text = "In phiếu nhập"
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
        Me.gridViewData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn9, Me.GridColumn3, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn13, Me.GridColumn8, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
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
        Me.GridColumn1.FieldName = "MaPhieu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", "Tổng cộng: {0:n0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 120
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
        Me.GridColumn9.Width = 110
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Loại"
        Me.GridColumn3.FieldName = "LoaiPhieuNhap"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 150
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Khách hàng/Nhà cung cấp"
        Me.GridColumn2.FieldName = "KhachHangNhaCungCap"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 250
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
        Me.GridColumn4.VisibleIndex = 4
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
        Me.GridColumn5.VisibleIndex = 5
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
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
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
        Me.GridColumn7.VisibleIndex = 7
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
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienVAT", "{0:n0}")})
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 8
        Me.GridColumn13.Width = 120
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn8.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn8.Caption = "Thành tiền"
        Me.GridColumn8.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "TongTienPhieuNhap"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienPhieuNhap", "{0:n0}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 9
        Me.GridColumn8.Width = 120
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nhân viên lập"
        Me.GridColumn10.FieldName = "TenNhanVien"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        Me.GridColumn10.Width = 100
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
        'lblSoPhieuNhap222
        '
        Me.lblSoPhieuNhap222.Name = "lblSoPhieuNhap222"
        Me.lblSoPhieuNhap222.Size = New System.Drawing.Size(23, 23)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThemPhieuNhap, Me.ToolStripLabel2, Me.PhiếuXuấtKkhoToolStripMenuItem, Me.btnIn, Me.btnXemNhanh, Me.btnSuaPhieu, Me.btnXoaPhieu, Me.btnInPhieu})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.ShowItemToolTips = False
        Me.ToolStrip2.Size = New System.Drawing.Size(1458, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnThemPhieuNhap
        '
        Me.btnThemPhieuNhap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnThemPhieuNhap.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThemPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemPhieuNhap.Name = "btnThemPhieuNhap"
        Me.btnThemPhieuNhap.Size = New System.Drawing.Size(143, 22)
        Me.btnThemPhieuNhap.Text = "[F3]Thêm Phiếu Nhập"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripLabel2.Text = "DANH SÁCH PHIẾU NHẬP"
        '
        'PhiếuXuấtKkhoToolStripMenuItem
        '
        Me.PhiếuXuấtKkhoToolStripMenuItem.Name = "PhiếuXuấtKkhoToolStripMenuItem"
        Me.PhiếuXuấtKkhoToolStripMenuItem.Size = New System.Drawing.Size(102, 25)
        Me.PhiếuXuấtKkhoToolStripMenuItem.Text = "Phiếu nhập kho"
        '
        'btnIn
        '
        Me.btnIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnIn.Image = CType(resources.GetObject("btnIn.Image"), System.Drawing.Image)
        Me.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(37, 22)
        Me.btnIn.Text = "In"
        '
        'btnXemNhanh
        '
        Me.btnXemNhanh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnXemNhanh.Image = CType(resources.GetObject("btnXemNhanh.Image"), System.Drawing.Image)
        Me.btnXemNhanh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXemNhanh.Name = "btnXemNhanh"
        Me.btnXemNhanh.Size = New System.Drawing.Size(88, 22)
        Me.btnXemNhanh.Text = "Xem nhanh"
        '
        'btnSuaPhieu
        '
        Me.btnSuaPhieu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSuaPhieu.Image = CType(resources.GetObject("btnSuaPhieu.Image"), System.Drawing.Image)
        Me.btnSuaPhieu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSuaPhieu.Name = "btnSuaPhieu"
        Me.btnSuaPhieu.Size = New System.Drawing.Size(46, 22)
        Me.btnSuaPhieu.Text = "Sửa"
        '
        'btnXoaPhieu
        '
        Me.btnXoaPhieu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnXoaPhieu.Image = CType(resources.GetObject("btnXoaPhieu.Image"), System.Drawing.Image)
        Me.btnXoaPhieu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoaPhieu.Name = "btnXoaPhieu"
        Me.btnXoaPhieu.Size = New System.Drawing.Size(47, 22)
        Me.btnXoaPhieu.Text = "Xóa"
        '
        'btnInPhieu
        '
        Me.btnInPhieu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnInPhieu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NhậpCóKýHiệuToolStripMenuItem, Me.PhiếuNhậpKhoToolStripMenuItem})
        Me.btnInPhieu.Image = CType(resources.GetObject("btnInPhieu.Image"), System.Drawing.Image)
        Me.btnInPhieu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInPhieu.Name = "btnInPhieu"
        Me.btnInPhieu.Size = New System.Drawing.Size(79, 22)
        Me.btnInPhieu.Text = "In phiếu"
        '
        'NhậpCóKýHiệuToolStripMenuItem
        '
        Me.NhậpCóKýHiệuToolStripMenuItem.Name = "NhậpCóKýHiệuToolStripMenuItem"
        Me.NhậpCóKýHiệuToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.NhậpCóKýHiệuToolStripMenuItem.Text = "Nhập có ký hiệu kho"
        '
        'PhiếuNhậpKhoToolStripMenuItem
        '
        Me.PhiếuNhậpKhoToolStripMenuItem.Name = "PhiếuNhậpKhoToolStripMenuItem"
        Me.PhiếuNhậpKhoToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.PhiếuNhậpKhoToolStripMenuItem.Text = "Phiếu nhập kho"
        '
        'ctrlThongKePhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "ctrlThongKePhieuNhap"
        Me.Size = New System.Drawing.Size(1458, 403)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.cmbTheoKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTheoLoaiPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblSoPhieuNhap222 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NgayTaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenDangNhapDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaPhieuNhap As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmbNhanVien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatNhanVien As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents chkTheoNhanVien As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents cmbTheoLoaiPhieuNhap As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatLoaiPhieuNhap As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents chkTheoLoaiPhieuNhap As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents TongTienDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbTheoKhachHang As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatKhachHang As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents chkTheoKhachHang As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents btnTimKiemKhachHang As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btnThemPhieuNhap As ToolStripButton
    Friend WithEvents XóaPhiếuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SửaPhiếuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents InPhiếuNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents PhiếuXuấtKkhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnXemNhanh As ToolStripButton
    Friend WithEvents btnSuaPhieu As ToolStripButton
    Friend WithEvents btnXoaPhieu As ToolStripButton
    Friend WithEvents btnIn As ToolStripButton
    Friend WithEvents btnInPhieu As ToolStripDropDownButton
    Friend WithEvents NhậpCóKýHiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhiếuNhậpKhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
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
End Class
