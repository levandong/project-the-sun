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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPhieuXuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNhaCungCapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenCongTrinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTienTruocVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTienVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTienPhieuXuatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNhanVienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InPhiếuXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XuấtHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsPhieuXuat = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSoDong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTienTruocThue = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblVAT = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTongTien = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblSoPhieuXuat222 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnXoaPhieu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MaPhieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSuaPhieu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PhiếuXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CóKýHiệuKhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.cmbTheoNhaCungCap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTheoLoaiPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.bsPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvMain)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
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
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaPhieuXuat, Me.NgayLapDataGridViewTextBoxColumn, Me.TenNhaCungCapDataGridViewTextBoxColumn, Me.TenCongTrinhDataGridViewTextBoxColumn, Me.TongTienTruocVATDataGridViewTextBoxColumn, Me.TongTienVATDataGridViewTextBoxColumn, Me.TongTienPhieuXuatDataGridViewTextBoxColumn, Me.TenNhanVienDataGridViewTextBoxColumn, Me.GhiChuDataGridViewTextBoxColumn})
        Me.dgvMain.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvMain.DataSource = Me.bsPhieuXuat
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 5
        Me.dgvMain.Size = New System.Drawing.Size(813, 353)
        Me.dgvMain.TabIndex = 2
        Me.dgvMain.VirtualMode = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 35
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'MaPhieuXuat
        '
        Me.MaPhieuXuat.DataPropertyName = "MaPhieu"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Navy
        Me.MaPhieuXuat.DefaultCellStyle = DataGridViewCellStyle11
        Me.MaPhieuXuat.HeaderText = "Mã phiếu"
        Me.MaPhieuXuat.Name = "MaPhieuXuat"
        Me.MaPhieuXuat.ReadOnly = True
        '
        'NgayLapDataGridViewTextBoxColumn
        '
        Me.NgayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "dd/MM/yy"
        Me.NgayLapDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.NgayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lập"
        Me.NgayLapDataGridViewTextBoxColumn.MinimumWidth = 75
        Me.NgayLapDataGridViewTextBoxColumn.Name = "NgayLapDataGridViewTextBoxColumn"
        Me.NgayLapDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgayLapDataGridViewTextBoxColumn.Width = 80
        '
        'TenNhaCungCapDataGridViewTextBoxColumn
        '
        Me.TenNhaCungCapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "TenNhaCungCap"
        Me.TenNhaCungCapDataGridViewTextBoxColumn.HeaderText = "Nhà cung cấp"
        Me.TenNhaCungCapDataGridViewTextBoxColumn.Name = "TenNhaCungCapDataGridViewTextBoxColumn"
        Me.TenNhaCungCapDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenNhaCungCapDataGridViewTextBoxColumn.Width = 110
        '
        'TenCongTrinhDataGridViewTextBoxColumn
        '
        Me.TenCongTrinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenCongTrinhDataGridViewTextBoxColumn.DataPropertyName = "TenCongTrinh"
        Me.TenCongTrinhDataGridViewTextBoxColumn.HeaderText = "Công trình"
        Me.TenCongTrinhDataGridViewTextBoxColumn.MinimumWidth = 60
        Me.TenCongTrinhDataGridViewTextBoxColumn.Name = "TenCongTrinhDataGridViewTextBoxColumn"
        Me.TenCongTrinhDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenCongTrinhDataGridViewTextBoxColumn.Width = 93
        '
        'TongTienTruocVATDataGridViewTextBoxColumn
        '
        Me.TongTienTruocVATDataGridViewTextBoxColumn.DataPropertyName = "TongTienTruocVAT"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle13.Format = "N0"
        Me.TongTienTruocVATDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.TongTienTruocVATDataGridViewTextBoxColumn.HeaderText = "Tiền trước thuế"
        Me.TongTienTruocVATDataGridViewTextBoxColumn.Name = "TongTienTruocVATDataGridViewTextBoxColumn"
        Me.TongTienTruocVATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TongTienVATDataGridViewTextBoxColumn
        '
        Me.TongTienVATDataGridViewTextBoxColumn.DataPropertyName = "TongTienVAT"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle14.Format = "N0"
        Me.TongTienVATDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.TongTienVATDataGridViewTextBoxColumn.HeaderText = "VAT"
        Me.TongTienVATDataGridViewTextBoxColumn.Name = "TongTienVATDataGridViewTextBoxColumn"
        Me.TongTienVATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TongTienPhieuXuatDataGridViewTextBoxColumn
        '
        Me.TongTienPhieuXuatDataGridViewTextBoxColumn.DataPropertyName = "TongTienPhieuXuat"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle15.Format = "N0"
        Me.TongTienPhieuXuatDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.TongTienPhieuXuatDataGridViewTextBoxColumn.HeaderText = "Tiền sau thuế"
        Me.TongTienPhieuXuatDataGridViewTextBoxColumn.Name = "TongTienPhieuXuatDataGridViewTextBoxColumn"
        Me.TongTienPhieuXuatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TenNhanVienDataGridViewTextBoxColumn
        '
        Me.TenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien"
        Me.TenNhanVienDataGridViewTextBoxColumn.HeaderText = "Nhân viên"
        Me.TenNhanVienDataGridViewTextBoxColumn.Name = "TenNhanVienDataGridViewTextBoxColumn"
        Me.TenNhanVienDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenNhanVienDataGridViewTextBoxColumn.Width = 120
        '
        'GhiChuDataGridViewTextBoxColumn
        '
        Me.GhiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu"
        Me.GhiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú"
        Me.GhiChuDataGridViewTextBoxColumn.Name = "GhiChuDataGridViewTextBoxColumn"
        Me.GhiChuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InPhiếuXuấtToolStripMenuItem, Me.XuấtHóaĐơnToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(146, 48)
        '
        'InPhiếuXuấtToolStripMenuItem
        '
        Me.InPhiếuXuấtToolStripMenuItem.Image = Global.PhanMemBanHang.My.Resources.Resources.In_16
        Me.InPhiếuXuấtToolStripMenuItem.Name = "InPhiếuXuấtToolStripMenuItem"
        Me.InPhiếuXuấtToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.InPhiếuXuấtToolStripMenuItem.Text = "In phiếu xuất"
        '
        'XuấtHóaĐơnToolStripMenuItem
        '
        Me.XuấtHóaĐơnToolStripMenuItem.Image = Global.PhanMemBanHang.My.Resources.Resources.Bill16
        Me.XuấtHóaĐơnToolStripMenuItem.Name = "XuấtHóaĐơnToolStripMenuItem"
        Me.XuấtHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.XuấtHóaĐơnToolStripMenuItem.Text = "Xuất hóa đơn"
        '
        'bsPhieuXuat
        '
        Me.bsPhieuXuat.DataSource = GetType(PhanMemBanHang.vwPhieuXuat)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoDong, Me.ToolStripSeparator1, Me.ToolStripLabel5, Me.lblTienTruocThue, Me.ToolStripLabel1, Me.lblVAT, Me.ToolStripLabel3, Me.lblTongTien, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 353)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(813, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblSoDong
        '
        Me.lblSoDong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSoDong.Name = "lblSoDong"
        Me.lblSoDong.Size = New System.Drawing.Size(51, 22)
        Me.lblSoDong.Text = "0 phiếu."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripLabel5.Text = "Tiền trước thuế:"
        '
        'lblTienTruocThue
        '
        Me.lblTienTruocThue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTienTruocThue.Name = "lblTienTruocThue"
        Me.lblTienTruocThue.Size = New System.Drawing.Size(22, 22)
        Me.lblTienTruocThue.Text = "0đ"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripLabel1.Text = "VAT:"
        '
        'lblVAT
        '
        Me.lblVAT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(22, 22)
        Me.lblVAT.Text = "0đ"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel3.Text = "Tổng tiền:"
        '
        'lblTongTien
        '
        Me.lblTongTien.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTongTien.Name = "lblTongTien"
        Me.lblTongTien.Size = New System.Drawing.Size(22, 22)
        Me.lblTongTien.Text = "0đ"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        'MaPhieu
        '
        Me.MaPhieu.Name = "MaPhieu"
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
        Me.PhiếuXuấtToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.PhiếuXuấtToolStripMenuItem.Text = "Phiếu Xuất"
        '
        'CóKýHiệuKhoToolStripMenuItem
        '
        Me.CóKýHiệuKhoToolStripMenuItem.Name = "CóKýHiệuKhoToolStripMenuItem"
        Me.CóKýHiệuKhoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CóKýHiệuKhoToolStripMenuItem.Text = "Có Ký Hiệu Kho"
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
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.cmbTheoNhaCungCap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTheoLoaiPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.bsPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents CtrlTimKiemTheoThoiGian1 As TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTongTien As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblSoPhieuXuat222 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bsPhieuXuat As System.Windows.Forms.BindingSource
    Friend WithEvents NgayTaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaPhieuXuat As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmbNhanVien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatNhanVien As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents chkTheoNhanVien As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents lblSoDong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbTheoLoaiPhieuXuat As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatLoaiPhieuXuat As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents chkTheoLoaiPhieuXuat As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents TongTienDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkTheoNhaCungCap As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TongTienPhieuXuat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents SoPhieuXuatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents MaPhieuXuat As DataGridViewTextBoxColumn
    Friend WithEvents NgayLapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenNhaCungCapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenCongTrinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TongTienTruocVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TongTienVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TongTienPhieuXuatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenNhanVienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhiChuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblTienTruocThue As ToolStripLabel
    Friend WithEvents lblVAT As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents btnSuaPhieu As ToolStripDropDownButton
    Friend WithEvents PhiếuXuấtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CóKýHiệuKhoToolStripMenuItem As ToolStripMenuItem
End Class
