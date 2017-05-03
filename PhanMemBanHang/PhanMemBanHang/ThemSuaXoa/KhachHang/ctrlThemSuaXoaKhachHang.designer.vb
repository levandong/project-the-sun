<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlThemSuaXoaKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlThemSuaXoaKhachHang))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnThem = New System.Windows.Forms.ToolStripButton()
        Me.btnSua = New System.Windows.Forms.ToolStripButton()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        Me.btnCapNhat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuayLai = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLoaiTimKiem = New System.Windows.Forms.ToolStripSplitButton()
        Me.HủyTìmKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTimKiem = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNhapSanPhamTuExcel = New System.Windows.Forms.ToolStripButton()
        Me.cmbSoDong = New System.Windows.Forms.ToolStripComboBox()
        Me.btnSetKhachHangMacDinh = New System.Windows.Forms.ToolStripButton()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dgvNhomKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TenNhomKhachHangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsNhomKhachHang = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnThemNhomKhachHang = New System.Windows.Forms.ToolStripButton()
        Me.btnSuaNhomKhachHang = New System.Windows.Forms.ToolStripButton()
        Me.btnXoaNhomKhachHang = New System.Windows.Forms.ToolStripButton()
        Me.btnCapNhatNhom = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.lblSoNhom = New System.Windows.Forms.ToolStripLabel()
        Me.CtrlDGVKhachHang1 = New PhanMemBanHang.ctrlDGVKhachHang()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgvNhomKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNhomKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThem, Me.btnSua, Me.btnXoa, Me.btnCapNhat, Me.ToolStripSeparator5, Me.btnQuayLai, Me.ToolStripSeparator6, Me.btnLoaiTimKiem, Me.txtTimKiem, Me.ToolStripSeparator3, Me.btnNhapSanPhamTuExcel, Me.cmbSoDong, Me.btnSetKhachHangMacDinh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1098, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnThem
        '
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(78, 22)
        Me.btnThem.Text = "&Thêm[F2]"
        '
        'btnSua
        '
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(66, 22)
        Me.btnSua.Text = "&Sửa[F3]"
        '
        'btnXoa
        '
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(67, 22)
        Me.btnXoa.Text = "&Xóa[F4]"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCapNhat.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(77, 22)
        Me.btnCapNhat.Text = "&Cập Nhật"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnQuayLai
        '
        Me.btnQuayLai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnQuayLai.Image = Global.PhanMemBanHang.My.Resources.Resources.Undo16
        Me.btnQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(73, 22)
        Me.btnQuayLai.Text = "&Quay Lại"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnLoaiTimKiem
        '
        Me.btnLoaiTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnLoaiTimKiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLoaiTimKiem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HủyTìmKiếmToolStripMenuItem})
        Me.btnLoaiTimKiem.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnLoaiTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLoaiTimKiem.Name = "btnLoaiTimKiem"
        Me.btnLoaiTimKiem.Size = New System.Drawing.Size(32, 22)
        Me.btnLoaiTimKiem.Text = "Chọn Loại Tìm Kiếm"
        Me.btnLoaiTimKiem.ToolTipText = "Tìm Kiếm"
        '
        'HủyTìmKiếmToolStripMenuItem
        '
        Me.HủyTìmKiếmToolStripMenuItem.Name = "HủyTìmKiếmToolStripMenuItem"
        Me.HủyTìmKiếmToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.HủyTìmKiếmToolStripMenuItem.Text = "Hủy tìm kiếm"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnNhapSanPhamTuExcel
        '
        Me.btnNhapSanPhamTuExcel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNhapSanPhamTuExcel.Image = Global.PhanMemBanHang.My.Resources.Resources.Excel16
        Me.btnNhapSanPhamTuExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNhapSanPhamTuExcel.Name = "btnNhapSanPhamTuExcel"
        Me.btnNhapSanPhamTuExcel.Size = New System.Drawing.Size(104, 22)
        Me.btnNhapSanPhamTuExcel.Text = "Nhập từ Excel"
        Me.btnNhapSanPhamTuExcel.Visible = False
        '
        'cmbSoDong
        '
        Me.cmbSoDong.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmbSoDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSoDong.Items.AddRange(New Object() {"20 dòng", "50 dòng", "100 dòng", "500 dòng", "1000 dòng", "<tất cả>"})
        Me.cmbSoDong.Name = "cmbSoDong"
        Me.cmbSoDong.Size = New System.Drawing.Size(100, 25)
        '
        'btnSetKhachHangMacDinh
        '
        Me.btnSetKhachHangMacDinh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSetKhachHangMacDinh.Image = Global.PhanMemBanHang.My.Resources.Resources.Default16
        Me.btnSetKhachHangMacDinh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSetKhachHangMacDinh.Name = "btnSetKhachHangMacDinh"
        Me.btnSetKhachHangMacDinh.Size = New System.Drawing.Size(124, 22)
        Me.btnSetKhachHangMacDinh.Text = "Đặt làm mặc định"
        Me.btnSetKhachHangMacDinh.Visible = False
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgvNhomKhachHang)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.ToolStrip2)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.ToolStrip3)
        Me.KryptonSplitContainer1.Panel1Collapsed = True
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.CtrlDGVKhachHang1)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1098, 429)
        Me.KryptonSplitContainer1.SplitterDistance = 366
        Me.KryptonSplitContainer1.TabIndex = 7
        '
        'dgvNhomKhachHang
        '
        Me.dgvNhomKhachHang.AllowUserToAddRows = False
        Me.dgvNhomKhachHang.AllowUserToDeleteRows = False
        Me.dgvNhomKhachHang.AllowUserToResizeRows = False
        Me.dgvNhomKhachHang.AutoGenerateColumns = False
        Me.dgvNhomKhachHang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenNhomKhachHangDataGridViewTextBoxColumn, Me.GhiChuDataGridViewTextBoxColumn, Me.STT})
        Me.dgvNhomKhachHang.DataSource = Me.bsNhomKhachHang
        Me.dgvNhomKhachHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNhomKhachHang.Location = New System.Drawing.Point(0, 25)
        Me.dgvNhomKhachHang.Name = "dgvNhomKhachHang"
        Me.dgvNhomKhachHang.ReadOnly = True
        Me.dgvNhomKhachHang.RowHeadersWidth = 10
        Me.dgvNhomKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvNhomKhachHang.Size = New System.Drawing.Size(100, 50)
        Me.dgvNhomKhachHang.TabIndex = 11
        Me.dgvNhomKhachHang.VirtualMode = True
        '
        'TenNhomKhachHangDataGridViewTextBoxColumn
        '
        Me.TenNhomKhachHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenNhomKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenNhomKhachHang"
        Me.TenNhomKhachHangDataGridViewTextBoxColumn.HeaderText = "Tên nhóm"
        Me.TenNhomKhachHangDataGridViewTextBoxColumn.Name = "TenNhomKhachHangDataGridViewTextBoxColumn"
        Me.TenNhomKhachHangDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenNhomKhachHangDataGridViewTextBoxColumn.Width = 90
        '
        'GhiChuDataGridViewTextBoxColumn
        '
        Me.GhiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu"
        Me.GhiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú"
        Me.GhiChuDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.GhiChuDataGridViewTextBoxColumn.Name = "GhiChuDataGridViewTextBoxColumn"
        Me.GhiChuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 40
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Visible = False
        Me.STT.Width = 40
        '
        'bsNhomKhachHang
        '
        Me.bsNhomKhachHang.DataSource = GetType(PhanMemBanHang.tbNhomKhachHang)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThemNhomKhachHang, Me.btnSuaNhomKhachHang, Me.btnXoaNhomKhachHang, Me.btnCapNhatNhom})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(100, 25)
        Me.ToolStrip2.TabIndex = 9
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnThemNhomKhachHang
        '
        Me.btnThemNhomKhachHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnThemNhomKhachHang.Image = CType(resources.GetObject("btnThemNhomKhachHang.Image"), System.Drawing.Image)
        Me.btnThemNhomKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemNhomKhachHang.Name = "btnThemNhomKhachHang"
        Me.btnThemNhomKhachHang.Size = New System.Drawing.Size(23, 22)
        Me.btnThemNhomKhachHang.Text = "&Thêm"
        '
        'btnSuaNhomKhachHang
        '
        Me.btnSuaNhomKhachHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSuaNhomKhachHang.Image = CType(resources.GetObject("btnSuaNhomKhachHang.Image"), System.Drawing.Image)
        Me.btnSuaNhomKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSuaNhomKhachHang.Name = "btnSuaNhomKhachHang"
        Me.btnSuaNhomKhachHang.Size = New System.Drawing.Size(23, 22)
        Me.btnSuaNhomKhachHang.Text = "&Sửa"
        '
        'btnXoaNhomKhachHang
        '
        Me.btnXoaNhomKhachHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnXoaNhomKhachHang.Image = CType(resources.GetObject("btnXoaNhomKhachHang.Image"), System.Drawing.Image)
        Me.btnXoaNhomKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoaNhomKhachHang.Name = "btnXoaNhomKhachHang"
        Me.btnXoaNhomKhachHang.Size = New System.Drawing.Size(23, 22)
        Me.btnXoaNhomKhachHang.Text = "&Xóa"
        '
        'btnCapNhatNhom
        '
        Me.btnCapNhatNhom.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCapNhatNhom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCapNhatNhom.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatNhom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapNhatNhom.Name = "btnCapNhatNhom"
        Me.btnCapNhatNhom.Size = New System.Drawing.Size(23, 20)
        Me.btnCapNhatNhom.Text = "&Cập Nhật"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoNhom})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 75)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.ShowItemToolTips = False
        Me.ToolStrip3.Size = New System.Drawing.Size(100, 25)
        Me.ToolStrip3.TabIndex = 10
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'lblSoNhom
        '
        Me.lblSoNhom.Name = "lblSoNhom"
        Me.lblSoNhom.Size = New System.Drawing.Size(48, 22)
        Me.lblSoNhom.Text = "0 nhóm"
        '
        'CtrlDGVKhachHang1
        '
        Me.CtrlDGVKhachHang1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlDGVKhachHang1.Location = New System.Drawing.Point(0, 25)
        Me.CtrlDGVKhachHang1.Name = "CtrlDGVKhachHang1"
        Me.CtrlDGVKhachHang1.Size = New System.Drawing.Size(1098, 404)
        Me.CtrlDGVKhachHang1.TabIndex = 6
        '
        'ctrlThemSuaXoaKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctrlThemSuaXoaKhachHang"
        Me.Size = New System.Drawing.Size(1098, 429)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgvNhomKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNhomKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSua As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoa As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCapNhat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuayLai As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLoaiTimKiem As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents txtTimKiem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CtrlDGVKhachHang1 As PhanMemBanHang.ctrlDGVKhachHang
    Friend WithEvents HủyTìmKiếmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNhapSanPhamTuExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbSoDong As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnSetKhachHangMacDinh As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dgvNhomKhachHang As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsNhomKhachHang As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThemNhomKhachHang As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSuaNhomKhachHang As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoaNhomKhachHang As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCapNhatNhom As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblSoNhom As System.Windows.Forms.ToolStripLabel
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents TenNhomKhachHangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhiChuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
