<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThongKeGiaCongSanPham
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.chkTheoSanPham = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.cmbSanPham = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnTimKiemSanPham = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnCapNhatSanPham = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.CtrlTimKiemTheoThoiGian1 = New TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian()
        Me.KryptonDataGridView1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoPhieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSanPhamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPhamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChiPhiKhacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsGiaCong = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnThemPhieuGiaCong = New System.Windows.Forms.ToolStripButton()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.cmbSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGiaCong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel1.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1077, 653)
        Me.KryptonPanel1.TabIndex = 0
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
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnTimKiem)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoSanPham)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbSanPham)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.CtrlTimKiemTheoThoiGian1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonDataGridView1)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1077, 628)
        Me.KryptonSplitContainer1.SplitterDistance = 236
        Me.KryptonSplitContainer1.TabIndex = 1
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimKiem.Location = New System.Drawing.Point(6, 270)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(227, 44)
        Me.btnTimKiem.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.TabIndex = 58
        Me.btnTimKiem.Values.Text = "TÌM KIẾM"
        '
        'chkTheoSanPham
        '
        Me.chkTheoSanPham.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoSanPham.Location = New System.Drawing.Point(3, 77)
        Me.chkTheoSanPham.Name = "chkTheoSanPham"
        Me.chkTheoSanPham.Size = New System.Drawing.Size(230, 25)
        Me.chkTheoSanPham.TabIndex = 57
        Me.chkTheoSanPham.Values.Text = "Theo Sản Phẩm"
        Me.chkTheoSanPham.Visible = False
        '
        'cmbSanPham
        '
        Me.cmbSanPham.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSanPham.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnTimKiemSanPham, Me.btnCapNhatSanPham})
        Me.cmbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSanPham.DropDownWidth = 119
        Me.cmbSanPham.Enabled = False
        Me.cmbSanPham.Location = New System.Drawing.Point(3, 108)
        Me.cmbSanPham.Name = "cmbSanPham"
        Me.cmbSanPham.Size = New System.Drawing.Size(230, 24)
        Me.cmbSanPham.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSanPham.TabIndex = 56
        Me.cmbSanPham.Visible = False
        '
        'btnTimKiemSanPham
        '
        Me.btnTimKiemSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnTimKiemSanPham.UniqueName = "98845E5B67544D3662A75D7A56CF1C42"
        '
        'btnCapNhatSanPham
        '
        Me.btnCapNhatSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatSanPham.UniqueName = "A7722BAE0DE141735EAA1006FE86185C"
        '
        'CtrlTimKiemTheoThoiGian1
        '
        Me.CtrlTimKiemTheoThoiGian1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtrlTimKiemTheoThoiGian1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlTimKiemTheoThoiGian1.Name = "CtrlTimKiemTheoThoiGian1"
        Me.CtrlTimKiemTheoThoiGian1.Size = New System.Drawing.Size(236, 71)
        Me.CtrlTimKiemTheoThoiGian1.TabIndex = 4
        Me.CtrlTimKiemTheoThoiGian1.TheoChinhXacGio = False
        Me.CtrlTimKiemTheoThoiGian1.TMTNow = New Date(2017, 3, 10, 9, 35, 44, 778)
        Me.CtrlTimKiemTheoThoiGian1.ToiLuc = New Date(2013, 7, 23, 0, 0, 0, 0)
        Me.CtrlTimKiemTheoThoiGian1.TuLuc = New Date(2013, 7, 23, 0, 0, 0, 0)
        '
        'KryptonDataGridView1
        '
        Me.KryptonDataGridView1.AllowUserToAddRows = False
        Me.KryptonDataGridView1.AllowUserToDeleteRows = False
        Me.KryptonDataGridView1.AutoGenerateColumns = False
        Me.KryptonDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.SoPhieu, Me.NgayLapDataGridViewTextBoxColumn, Me.MaSanPhamDataGridViewTextBoxColumn, Me.TenSanPhamDataGridViewTextBoxColumn, Me.SoLuongDataGridViewTextBoxColumn, Me.ChiPhiKhacDataGridViewTextBoxColumn, Me.GhiChu})
        Me.KryptonDataGridView1.DataSource = Me.bsGiaCong
        Me.KryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonDataGridView1.Name = "KryptonDataGridView1"
        Me.KryptonDataGridView1.ReadOnly = True
        Me.KryptonDataGridView1.RowHeadersWidth = 5
        Me.KryptonDataGridView1.Size = New System.Drawing.Size(836, 628)
        Me.KryptonDataGridView1.TabIndex = 0
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 35
        '
        'SoPhieu
        '
        Me.SoPhieu.DataPropertyName = "MaPhieu"
        Me.SoPhieu.HeaderText = "Mã phiếu"
        Me.SoPhieu.Name = "SoPhieu"
        Me.SoPhieu.ReadOnly = True
        '
        'NgayLapDataGridViewTextBoxColumn
        '
        Me.NgayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap"
        Me.NgayLapDataGridViewTextBoxColumn.HeaderText = "Ngày gia công"
        Me.NgayLapDataGridViewTextBoxColumn.Name = "NgayLapDataGridViewTextBoxColumn"
        Me.NgayLapDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaSanPhamDataGridViewTextBoxColumn
        '
        Me.MaSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham"
        Me.MaSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã SP"
        Me.MaSanPhamDataGridViewTextBoxColumn.Name = "MaSanPhamDataGridViewTextBoxColumn"
        Me.MaSanPhamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TenSanPhamDataGridViewTextBoxColumn
        '
        Me.TenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham"
        Me.TenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm"
        Me.TenSanPhamDataGridViewTextBoxColumn.Name = "TenSanPhamDataGridViewTextBoxColumn"
        Me.TenSanPhamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoLuongDataGridViewTextBoxColumn
        '
        Me.SoLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong"
        Me.SoLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng"
        Me.SoLuongDataGridViewTextBoxColumn.Name = "SoLuongDataGridViewTextBoxColumn"
        Me.SoLuongDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChiPhiKhacDataGridViewTextBoxColumn
        '
        Me.ChiPhiKhacDataGridViewTextBoxColumn.DataPropertyName = "ChiPhiKhac"
        Me.ChiPhiKhacDataGridViewTextBoxColumn.HeaderText = "Chi phí khác"
        Me.ChiPhiKhacDataGridViewTextBoxColumn.Name = "ChiPhiKhacDataGridViewTextBoxColumn"
        Me.ChiPhiKhacDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GhiChu
        '
        Me.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChu.DataPropertyName = "GhiChu"
        Me.GhiChu.HeaderText = "Ghi chú"
        Me.GhiChu.Name = "GhiChu"
        Me.GhiChu.ReadOnly = True
        '
        'bsGiaCong
        '
        Me.bsGiaCong.DataSource = GetType(PhanMemBanHang.vwGiaCong)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btnThemPhieuGiaCong})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1077, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(193, 22)
        Me.ToolStripLabel1.Text = "THỐNG KÊ GIA CÔNG SẢN PHẨM"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnThemPhieuGiaCong
        '
        Me.btnThemPhieuGiaCong.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnThemPhieuGiaCong.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThemPhieuGiaCong.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemPhieuGiaCong.Name = "btnThemPhieuGiaCong"
        Me.btnThemPhieuGiaCong.Size = New System.Drawing.Size(175, 22)
        Me.btnThemPhieuGiaCong.Text = "[F3]THÊM PHIẾU GIA CÔNG"
        '
        'ctrlThongKeGiaCongSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlThongKeGiaCongSanPham"
        Me.Size = New System.Drawing.Size(1077, 653)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.cmbSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGiaCong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents CtrlTimKiemTheoThoiGian1 As TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian
    Friend WithEvents chkTheoSanPham As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents cmbSanPham As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnTimKiemSanPham As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnCapNhatSanPham As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonDataGridView1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsGiaCong As BindingSource
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents SoPhieu As DataGridViewTextBoxColumn
    Friend WithEvents NgayLapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChiPhiKhacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnThemPhieuGiaCong As ToolStripButton
End Class
