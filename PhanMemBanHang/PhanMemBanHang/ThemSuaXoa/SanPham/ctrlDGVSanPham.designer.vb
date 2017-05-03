<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlDGVSanPham
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuItemPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemExportExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridViewData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGiaNiemYet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNgayNiemYet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTonKho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGiaBinhQuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGiaTriHienTai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTonMin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gridViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tbNhomSanPham"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nhóm Sản Phẩm"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TenLoaiSanPham"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Loại Sản Phẩm"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'gridControl
        '
        Me.gridControl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 0)
        Me.gridControl.MainView = Me.gridViewData
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1171, 547)
        Me.gridControl.TabIndex = 7
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewData})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemPrint, Me.mnuItemExportExcel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(142, 48)
        '
        'mnuItemPrint
        '
        Me.mnuItemPrint.Image = Global.PhanMemBanHang.My.Resources.Resources.Print16
        Me.mnuItemPrint.Name = "mnuItemPrint"
        Me.mnuItemPrint.Size = New System.Drawing.Size(141, 22)
        Me.mnuItemPrint.Text = "In danh sách"
        '
        'mnuItemExportExcel
        '
        Me.mnuItemExportExcel.Image = Global.PhanMemBanHang.My.Resources.Resources.Excel16
        Me.mnuItemExportExcel.Name = "mnuItemExportExcel"
        Me.mnuItemExportExcel.Size = New System.Drawing.Size(141, 22)
        Me.mnuItemExportExcel.Text = "Xuất Excel"
        '
        'gridViewData
        '
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
        Me.gridViewData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colGiaNiemYet, Me.colNgayNiemYet, Me.colTonKho, Me.colGiaBinhQuan, Me.colGiaTriHienTai, Me.GridColumn13, Me.GridColumn14, Me.colTonMin, Me.GridColumn6, Me.GridColumn4, Me.GridColumn7, Me.GridColumn9, Me.GridColumn8, Me.GridColumn11, Me.GridColumn12})
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
        Me.GridColumn1.Caption = "Mã"
        Me.GridColumn1.FieldName = "MaSanPham"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", "Tổng cộng: {0:n0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 150
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên sản phẩm"
        Me.GridColumn2.FieldName = "TenSanPham"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 250
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ĐVT"
        Me.GridColumn3.FieldName = "DonVi"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 70
        '
        'colGiaNiemYet
        '
        Me.colGiaNiemYet.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colGiaNiemYet.AppearanceCell.Options.UseForeColor = True
        Me.colGiaNiemYet.Caption = "Giá gốc"
        Me.colGiaNiemYet.DisplayFormat.FormatString = "###,##0"
        Me.colGiaNiemYet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGiaNiemYet.FieldName = "GiaNiemYet"
        Me.colGiaNiemYet.MinWidth = 60
        Me.colGiaNiemYet.Name = "colGiaNiemYet"
        Me.colGiaNiemYet.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colGiaNiemYet.Visible = True
        Me.colGiaNiemYet.VisibleIndex = 3
        Me.colGiaNiemYet.Width = 100
        '
        'colNgayNiemYet
        '
        Me.colNgayNiemYet.Caption = "Ngày N/Y"
        Me.colNgayNiemYet.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgayNiemYet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgayNiemYet.FieldName = "NgayNiemYet"
        Me.colNgayNiemYet.MinWidth = 50
        Me.colNgayNiemYet.Name = "colNgayNiemYet"
        Me.colNgayNiemYet.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colNgayNiemYet.Visible = True
        Me.colNgayNiemYet.VisibleIndex = 4
        Me.colNgayNiemYet.Width = 90
        '
        'colTonKho
        '
        Me.colTonKho.Caption = "Tồn kho"
        Me.colTonKho.DisplayFormat.FormatString = "###,##0.##"
        Me.colTonKho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTonKho.FieldName = "SoLuong"
        Me.colTonKho.Name = "colTonKho"
        Me.colTonKho.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTonKho.Visible = True
        Me.colTonKho.VisibleIndex = 5
        '
        'colGiaBinhQuan
        '
        Me.colGiaBinhQuan.Caption = "Giá B.Quân"
        Me.colGiaBinhQuan.DisplayFormat.FormatString = "###,##0"
        Me.colGiaBinhQuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGiaBinhQuan.FieldName = "GiaBinhQuan"
        Me.colGiaBinhQuan.MinWidth = 60
        Me.colGiaBinhQuan.Name = "colGiaBinhQuan"
        Me.colGiaBinhQuan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colGiaBinhQuan.Visible = True
        Me.colGiaBinhQuan.VisibleIndex = 6
        Me.colGiaBinhQuan.Width = 90
        '
        'colGiaTriHienTai
        '
        Me.colGiaTriHienTai.Caption = "Giá trị"
        Me.colGiaTriHienTai.DisplayFormat.FormatString = "###,##0"
        Me.colGiaTriHienTai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGiaTriHienTai.FieldName = "GiaTriHienTai"
        Me.colGiaTriHienTai.MinWidth = 60
        Me.colGiaTriHienTai.Name = "colGiaTriHienTai"
        Me.colGiaTriHienTai.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colGiaTriHienTai.Visible = True
        Me.colGiaTriHienTai.VisibleIndex = 7
        Me.colGiaTriHienTai.Width = 100
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "% bán"
        Me.GridColumn13.DisplayFormat.FormatString = "##0.##"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "PhanTramBan"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 8
        Me.GridColumn13.Width = 70
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "% nhập"
        Me.GridColumn14.DisplayFormat.FormatString = "##0.##"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "PhanTramNhap"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 9
        Me.GridColumn14.Width = 70
        '
        'colTonMin
        '
        Me.colTonMin.Caption = "Tồn min"
        Me.colTonMin.DisplayFormat.FormatString = "###,##0.##"
        Me.colTonMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTonMin.FieldName = "TonMin"
        Me.colTonMin.Name = "colTonMin"
        Me.colTonMin.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTonMin.Visible = True
        Me.colTonMin.VisibleIndex = 10
        Me.colTonMin.Width = 60
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "KL riêng"
        Me.GridColumn6.FieldName = "KhoiLuongRieng"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 11
        Me.GridColumn6.Width = 100
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "KH Kho"
        Me.GridColumn4.FieldName = "KyHieuKho"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 12
        Me.GridColumn4.Width = 100
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Loại"
        Me.GridColumn7.FieldName = "TenLoaiSanPham"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 13
        Me.GridColumn7.Width = 150
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ngày tạo"
        Me.GridColumn9.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "NgayTao"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 14
        Me.GridColumn9.Width = 120
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Bảo hành"
        Me.GridColumn8.DisplayFormat.FormatString = "0 tháng"
        Me.GridColumn8.FieldName = "ThoiGianBaoHanh"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 15
        Me.GridColumn8.Width = 100
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Mô tả"
        Me.GridColumn11.FieldName = "MoTa"
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
        'ctrlDGVSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Name = "ctrlDGVSanPham"
        Me.Size = New System.Drawing.Size(1171, 547)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gridViewData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents mnuItemPrint As ToolStripMenuItem
    Friend WithEvents mnuItemExportExcel As ToolStripMenuItem
    Friend WithEvents gridViewData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTonMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiaNiemYet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgayNiemYet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTonKho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiaBinhQuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiaTriHienTai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
End Class
