<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlDGVLoaiSanPham
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
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridViewData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMaLoaiSanPham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenLoaiSanPham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoTa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuItemExportExcel = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 0)
        Me.gridControl.MainView = Me.gridViewData
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gridControl.Size = New System.Drawing.Size(883, 628)
        Me.gridControl.TabIndex = 8
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
        Me.gridViewData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMaLoaiSanPham, Me.TenLoaiSanPham, Me.colMoTa, Me.GridColumn12})
        Me.gridViewData.GridControl = Me.gridControl
        Me.gridViewData.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", Me.colMaLoaiSanPham, "Cộng: {0:n0}")})
        Me.gridViewData.IndicatorWidth = 35
        Me.gridViewData.Name = "gridViewData"
        Me.gridViewData.OptionsDetail.EnableMasterViewMode = False
        Me.gridViewData.OptionsView.ColumnAutoWidth = False
        Me.gridViewData.OptionsView.ShowAutoFilterRow = True
        Me.gridViewData.OptionsView.ShowFooter = True
        Me.gridViewData.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 50
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colMaLoaiSanPham
        '
        Me.colMaLoaiSanPham.Caption = "Mã loại"
        Me.colMaLoaiSanPham.FieldName = "MaLoaiSanPham"
        Me.colMaLoaiSanPham.Name = "colMaLoaiSanPham"
        Me.colMaLoaiSanPham.OptionsColumn.AllowEdit = False
        Me.colMaLoaiSanPham.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colMaLoaiSanPham.Visible = True
        Me.colMaLoaiSanPham.VisibleIndex = 1
        Me.colMaLoaiSanPham.Width = 80
        '
        'TenLoaiSanPham
        '
        Me.TenLoaiSanPham.Caption = "Tên loại"
        Me.TenLoaiSanPham.FieldName = "TenLoaiSanPham"
        Me.TenLoaiSanPham.Name = "TenLoaiSanPham"
        Me.TenLoaiSanPham.OptionsColumn.AllowEdit = False
        Me.TenLoaiSanPham.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.TenLoaiSanPham.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", "Tổng cộng: {0:n0}")})
        Me.TenLoaiSanPham.Visible = True
        Me.TenLoaiSanPham.VisibleIndex = 2
        Me.TenLoaiSanPham.Width = 250
        '
        'colMoTa
        '
        Me.colMoTa.Caption = "Mô tả"
        Me.colMoTa.FieldName = "MoTa"
        Me.colMoTa.Name = "colMoTa"
        Me.colMoTa.OptionsColumn.AllowEdit = False
        Me.colMoTa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colMoTa.Visible = True
        Me.colMoTa.VisibleIndex = 3
        Me.colMoTa.Width = 200
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
        'ctrlDGVLoaiSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Name = "ctrlDGVLoaiSanPham"
        Me.Size = New System.Drawing.Size(883, 628)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMaLoaiSanPham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenLoaiSanPham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoTa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents mnuItemExportExcel As ToolStripMenuItem
End Class
