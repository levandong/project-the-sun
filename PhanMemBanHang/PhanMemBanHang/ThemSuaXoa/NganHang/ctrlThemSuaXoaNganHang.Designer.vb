﻿ <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ctrlThemSuaXoaNganHang
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnThem = New System.Windows.Forms.ToolStripButton()
        Me.btnSua = New System.Windows.Forms.ToolStripButton()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCapNhat = New System.Windows.Forms.ToolStripButton()
        Me.btnTimKiem = New System.Windows.Forms.ToolStripButton()
        Me.txtTuKhoa = New System.Windows.Forms.ToolStripTextBox()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridViewData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuItemExportExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThem, Me.btnSua, Me.btnXoa, Me.ToolStripSeparator1, Me.btnCapNhat, Me.btnTimKiem, Me.txtTuKhoa})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1067, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnThem
        '
        Me.btnThem.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(58, 22)
        Me.btnThem.Text = "&Thêm"
        '
        'btnSua
        '
        Me.btnSua.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua16
        Me.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(46, 22)
        Me.btnSua.Text = "&Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.PhanMemBanHang.My.Resources.Resources.XoaTatCa16
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(47, 22)
        Me.btnXoa.Text = "&Xoá"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 22)
        Me.btnCapNhat.Text = "&Cập nhật"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnTimKiem.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(77, 22)
        Me.btnTimKiem.Text = "Tìm &kiếm"
        '
        'txtTuKhoa
        '
        Me.txtTuKhoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTuKhoa.Name = "txtTuKhoa"
        Me.txtTuKhoa.Size = New System.Drawing.Size(100, 25)
        '
        'gridControl
        '
        Me.gridControl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 25)
        Me.gridControl.MainView = Me.gridViewData
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1067, 471)
        Me.gridControl.TabIndex = 7
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewData})
        '
        'gridViewData
        '
        Me.gridViewData.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridViewData.Appearance.FooterPanel.Options.UseFont = True
        Me.gridViewData.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.gridViewData.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
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
        Me.gridViewData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn10, Me.GridColumn9, Me.GridColumn11, Me.GridColumn12})
        Me.gridViewData.GridControl = Me.gridControl
        Me.gridViewData.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", Me.GridColumn1, "Cộng: {0:n0}")})
        Me.gridViewData.IndicatorWidth = 50
        Me.gridViewData.Name = "gridViewData"
        Me.gridViewData.OptionsBehavior.Editable = False
        Me.gridViewData.OptionsDetail.EnableMasterViewMode = False
        Me.gridViewData.OptionsView.ColumnAutoWidth = False
        Me.gridViewData.OptionsView.ShowAutoFilterRow = True
        Me.gridViewData.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tên ngân hàng"
        Me.GridColumn1.FieldName = "TenNganHang"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", "Tổng cộng: {0:n0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 250
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Số tài khoản"
        Me.GridColumn2.FieldName = "SoTaiKhoan"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 150
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Chi nhánh"
        Me.GridColumn3.FieldName = "ChiNhanh"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 200
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn10.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn10.Caption = "Dư đầu kỳ"
        Me.GridColumn10.DisplayFormat.FormatString = "###,##0"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "SoDuDauKy"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 110
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ngày nhập"
        Me.GridColumn9.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "NgayNhap"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 4
        Me.GridColumn9.Width = 130
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Ghi chú"
        Me.GridColumn11.FieldName = "GhiChu"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        Me.GridColumn11.Width = 300
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "id"
        Me.GridColumn12.FieldName = "id"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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
        'ctrlThemSuaXoaNganHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlThemSuaXoaNganHang"
        Me.Size = New System.Drawing.Size(1067, 496)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents btnCapNhat As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnThem As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnSua As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnXoa As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents txtTuKhoa As System.Windows.Forms.ToolStripTextBox
        Friend WithEvents btnTimKiem As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents mnuItemExportExcel As ToolStripMenuItem
End Class