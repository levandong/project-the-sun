<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThongKePhieuXuat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlThongKePhieuXuat))
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.cmbTheoNhaCungCap = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnTimKiemNhaCungCap = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnCapNhatNhaCungCap = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.cmbTheoLoaiPhieuXuat = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatLoaiPhieuXuat = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.cmbNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatNhanVien = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.chkTheoNhaCungCap = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.chkTheoLoaiPhieuXuat = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.chkTheoNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.CtrlTimKiemTheoThoiGian1 = New TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InPhiếuXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XuấtHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridViewData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblSoPhieuXuat222 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnXoaPhieu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSuaPhieu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PhiếuXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CóKýHiệuKhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaPhieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuItemExportExcel = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.cmbTheoNhaCungCap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTheoLoaiPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbTheoNhaCungCap)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbTheoLoaiPhieuXuat)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbNhanVien)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnTimKiem)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoNhaCungCap)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoLoaiPhieuXuat)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoNhanVien)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.CtrlTimKiemTheoThoiGian1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.gridControl)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1073, 378)
        Me.KryptonSplitContainer1.SplitterDistance = 255
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'cmbTheoNhaCungCap
        '
        Me.cmbTheoNhaCungCap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTheoNhaCungCap.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnTimKiemNhaCungCap, Me.btnCapNhatNhaCungCap})
        Me.cmbTheoNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTheoNhaCungCap.DropDownWidth = 226
        Me.cmbTheoNhaCungCap.Enabled = False
        Me.cmbTheoNhaCungCap.Location = New System.Drawing.Point(3, 157)
        Me.cmbTheoNhaCungCap.Name = "cmbTheoNhaCungCap"
        Me.cmbTheoNhaCungCap.Size = New System.Drawing.Size(249, 24)
        Me.cmbTheoNhaCungCap.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTheoNhaCungCap.TabIndex = 4
        '
        'btnTimKiemNhaCungCap
        '
        Me.btnTimKiemNhaCungCap.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnTimKiemNhaCungCap.UniqueName = "CCAE403F2DAB4DFBA0A9E223CDFA9E55"
        '
        'btnCapNhatNhaCungCap
        '
        Me.btnCapNhatNhaCungCap.Image = CType(resources.GetObject("btnCapNhatNhaCungCap.Image"), System.Drawing.Image)
        Me.btnCapNhatNhaCungCap.UniqueName = "39620113A4864BD866A59B8270DEE81C"
        '
        'cmbTheoLoaiPhieuXuat
        '
        Me.cmbTheoLoaiPhieuXuat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTheoLoaiPhieuXuat.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatLoaiPhieuXuat})
        Me.cmbTheoLoaiPhieuXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTheoLoaiPhieuXuat.DropDownWidth = 226
        Me.cmbTheoLoaiPhieuXuat.Enabled = False
        Me.cmbTheoLoaiPhieuXuat.Location = New System.Drawing.Point(3, 97)
        Me.cmbTheoLoaiPhieuXuat.Name = "cmbTheoLoaiPhieuXuat"
        Me.cmbTheoLoaiPhieuXuat.Size = New System.Drawing.Size(249, 24)
        Me.cmbTheoLoaiPhieuXuat.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTheoLoaiPhieuXuat.TabIndex = 3
        '
        'btnCapNhatLoaiPhieuXuat
        '
        Me.btnCapNhatLoaiPhieuXuat.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatLoaiPhieuXuat.UniqueName = "39620113A4864BD866A59B8270DEE81C"
        '
        'cmbNhanVien
        '
        Me.cmbNhanVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNhanVien.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatNhanVien})
        Me.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhanVien.DropDownWidth = 226
        Me.cmbNhanVien.Enabled = False
        Me.cmbNhanVien.Location = New System.Drawing.Point(3, 219)
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
        Me.btnTimKiem.Location = New System.Drawing.Point(3, 254)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(249, 44)
        Me.btnTimKiem.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.TabIndex = 2
        Me.btnTimKiem.Values.Text = "TÌM KIẾM"
        '
        'chkTheoNhaCungCap
        '
        Me.chkTheoNhaCungCap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoNhaCungCap.Location = New System.Drawing.Point(3, 126)
        Me.chkTheoNhaCungCap.Name = "chkTheoNhaCungCap"
        Me.chkTheoNhaCungCap.Size = New System.Drawing.Size(249, 25)
        Me.chkTheoNhaCungCap.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTheoNhaCungCap.TabIndex = 1
        Me.chkTheoNhaCungCap.Values.Text = "Theo Nhà Cung Cấp"
        '
        'chkTheoLoaiPhieuXuat
        '
        Me.chkTheoLoaiPhieuXuat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoLoaiPhieuXuat.Location = New System.Drawing.Point(3, 66)
        Me.chkTheoLoaiPhieuXuat.Name = "chkTheoLoaiPhieuXuat"
        Me.chkTheoLoaiPhieuXuat.Size = New System.Drawing.Size(249, 25)
        Me.chkTheoLoaiPhieuXuat.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTheoLoaiPhieuXuat.TabIndex = 1
        Me.chkTheoLoaiPhieuXuat.Values.Text = "Theo Loại Phiếu Xuất"
        '
        'chkTheoNhanVien
        '
        Me.chkTheoNhanVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoNhanVien.Location = New System.Drawing.Point(3, 188)
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
        Me.CtrlTimKiemTheoThoiGian1.TMTNow = New Date(2017, 1, 23, 13, 25, 20, 42)
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
        Me.gridControl.Size = New System.Drawing.Size(813, 378)
        Me.gridControl.TabIndex = 11
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewData})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InPhiếuXuấtToolStripMenuItem, Me.XuấtHóaĐơnToolStripMenuItem, Me.ToolStripSeparator1, Me.mnuItemExportExcel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 98)
        '
        'InPhiếuXuấtToolStripMenuItem
        '
        Me.InPhiếuXuấtToolStripMenuItem.Image = Global.PhanMemBanHang.My.Resources.Resources.In_16
        Me.InPhiếuXuấtToolStripMenuItem.Name = "InPhiếuXuấtToolStripMenuItem"
        Me.InPhiếuXuấtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InPhiếuXuấtToolStripMenuItem.Text = "In phiếu xuất"
        '
        'XuấtHóaĐơnToolStripMenuItem
        '
        Me.XuấtHóaĐơnToolStripMenuItem.Image = Global.PhanMemBanHang.My.Resources.Resources.Bill16
        Me.XuấtHóaĐơnToolStripMenuItem.Name = "XuấtHóaĐơnToolStripMenuItem"
        Me.XuấtHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.XuấtHóaĐơnToolStripMenuItem.Text = "Xuất hóa đơn"
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
        Me.gridViewData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn9, Me.GridColumn2, Me.GridColumn15, Me.GridColumn4, Me.GridColumn7, Me.GridColumn13, Me.GridColumn8, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
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
        Me.GridColumn1.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.GridColumn1.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn1.Caption = "Mã phiếu"
        Me.GridColumn1.FieldName = "MaPhieu"
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
        Me.GridColumn2.Caption = "Nhà cung cấp"
        Me.GridColumn2.FieldName = "TenNhaCungCap"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 300
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Công trình"
        Me.GridColumn15.FieldName = "TenCongTrinh"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 3
        Me.GridColumn15.Width = 250
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn4.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn4.Caption = "Tiền trước thuế"
        Me.GridColumn4.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "TongTienTruocVAT"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienTruocVAT", "{0:n0}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 120
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "VAT"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "VAT"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn7.Width = 60
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.ForeColor = System.Drawing.Color.Green
        Me.GridColumn13.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn13.Caption = "VAT"
        Me.GridColumn13.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "TongTienVAT"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienVAT", "{0:n0}")})
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 5
        Me.GridColumn13.Width = 120
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn8.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn8.Caption = "Tiền sau thuế"
        Me.GridColumn8.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "TongTienPhieuXuat"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienPhieuXuat", "{0:n0}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 120
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nhân viên lập"
        Me.GridColumn10.FieldName = "TenNhanVien"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        Me.GridColumn10.Width = 150
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Ghi chú"
        Me.GridColumn11.FieldName = "GhiChu"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 8
        Me.GridColumn11.Width = 300
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "id"
        Me.GridColumn12.FieldName = "id"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'lblSoPhieuXuat222
        '
        Me.lblSoPhieuXuat222.Name = "lblSoPhieuXuat222"
        Me.lblSoPhieuXuat222.Size = New System.Drawing.Size(23, 23)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.btnIn, Me.ToolStripSeparator4, Me.btnXoaPhieu, Me.ToolStripSeparator2, Me.btnSuaPhieu})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1073, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripLabel2.Text = "DANH SÁCH CÁC PHIẾU XUẤT"
        '
        'btnIn
        '
        Me.btnIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnIn.Image = CType(resources.GetObject("btnIn.Image"), System.Drawing.Image)
        Me.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(94, 22)
        Me.btnIn.Text = "In danh sách"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnSuaPhieu
        '
        Me.btnSuaPhieu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSuaPhieu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhiếuXuấtToolStripMenuItem, Me.CóKýHiệuKhoToolStripMenuItem})
        Me.btnSuaPhieu.Image = Global.PhanMemBanHang.My.Resources.Resources.Xem_16
        Me.btnSuaPhieu.Name = "btnSuaPhieu"
        Me.btnSuaPhieu.Size = New System.Drawing.Size(79, 22)
        Me.btnSuaPhieu.Text = "In phiếu"
        '
        'PhiếuXuấtToolStripMenuItem
        '
        Me.PhiếuXuấtToolStripMenuItem.Name = "PhiếuXuấtToolStripMenuItem"
        Me.PhiếuXuấtToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.PhiếuXuấtToolStripMenuItem.Text = "Phiếu Xuất"
        '
        'CóKýHiệuKhoToolStripMenuItem
        '
        Me.CóKýHiệuKhoToolStripMenuItem.Name = "CóKýHiệuKhoToolStripMenuItem"
        Me.CóKýHiệuKhoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CóKýHiệuKhoToolStripMenuItem.Text = "Có Ký Hiệu Kho"
        '
        'MaPhieu
        '
        Me.MaPhieu.Name = "MaPhieu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuItemExportExcel
        '
        Me.mnuItemExportExcel.Image = Global.PhanMemBanHang.My.Resources.Resources.Excel16
        Me.mnuItemExportExcel.Name = "mnuItemExportExcel"
        Me.mnuItemExportExcel.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemExportExcel.Text = "Xuất Excel"
        '
        'ctrlThongKePhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "ctrlThongKePhieuXuat"
        Me.Size = New System.Drawing.Size(1073, 403)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.cmbTheoNhaCungCap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTheoLoaiPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblSoPhieuXuat222 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NgayTaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaPhieuXuat As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmbNhanVien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatNhanVien As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents chkTheoNhanVien As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents cmbTheoLoaiPhieuXuat As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatLoaiPhieuXuat As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents chkTheoLoaiPhieuXuat As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents TongTienDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkTheoNhaCungCap As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents TongTienPhieuXuat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbTheoNhaCungCap As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnTimKiemNhaCungCap As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnCapNhatNhaCungCap As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents XuấtHóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InPhiếuXuấtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents btnIn As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnXoaPhieu As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MaPhieu As DataGridViewTextBoxColumn
    Friend WithEvents SoPhieuXuatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSuaPhieu As ToolStripDropDownButton
    Friend WithEvents PhiếuXuấtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CóKýHiệuKhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuItemExportExcel As ToolStripMenuItem
End Class
