<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlSaoLuuPhucHoi
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlSaoLuuPhucHoi))
        Me.btnPhucHoi = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblThongBao = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.a = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDuongDanPhucHoi = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnChonFile = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnBackup = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtTenFile = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonHeader2 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.txtDuongDanSaoLuu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnOpenFolder = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonHeader3 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.KryptonSplitContainer3 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.CtrlSaoLuuDuLieu1 = New PhanMemBanHang.ctrlSaoLuuDuLieu()
        Me.KryptonHeader4 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayThucHienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoiDungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsLichSu = New System.Windows.Forms.BindingSource(Me.components)
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lblSoDong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnXoaTatCa = New System.Windows.Forms.ToolStripButton()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel2.SuspendLayout()
        Me.KryptonSplitContainer2.SuspendLayout()
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel2.SuspendLayout()
        Me.KryptonSplitContainer3.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLichSu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPhucHoi
        '
        Me.btnPhucHoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPhucHoi.Location = New System.Drawing.Point(229, 85)
        Me.btnPhucHoi.Name = "btnPhucHoi"
        Me.btnPhucHoi.Size = New System.Drawing.Size(108, 37)
        Me.btnPhucHoi.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPhucHoi.StateCommon.Border.Rounding = 0
        Me.btnPhucHoi.StateCommon.Border.Width = 1
        Me.btnPhucHoi.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhucHoi.TabIndex = 18
        Me.btnPhucHoi.Values.Text = "Phục Hồi"
        '
        'lblThongBao
        '
        Me.lblThongBao.Location = New System.Drawing.Point(3, 60)
        Me.lblThongBao.Name = "lblThongBao"
        Me.lblThongBao.Size = New System.Drawing.Size(70, 20)
        Me.lblThongBao.StateCommon.ShortText.Color1 = System.Drawing.Color.Red
        Me.lblThongBao.TabIndex = 14
        Me.lblThongBao.Values.Text = "Thong bao"
        Me.lblThongBao.Visible = False
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(4, 4)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(199, 20)
        Me.a.TabIndex = 11
        Me.a.Values.Text = "Chọn file *.bak để phục hồi dữ liệu"
        '
        'txtDuongDanPhucHoi
        '
        Me.txtDuongDanPhucHoi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDuongDanPhucHoi.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnChonFile})
        Me.txtDuongDanPhucHoi.Location = New System.Drawing.Point(3, 28)
        Me.txtDuongDanPhucHoi.Multiline = True
        Me.txtDuongDanPhucHoi.Name = "txtDuongDanPhucHoi"
        Me.txtDuongDanPhucHoi.ReadOnly = True
        Me.txtDuongDanPhucHoi.Size = New System.Drawing.Size(334, 27)
        Me.txtDuongDanPhucHoi.TabIndex = 12
        '
        'btnChonFile
        '
        Me.btnChonFile.Text = "..."
        Me.btnChonFile.UniqueName = "E78D6A194CF94252F094DCF20A25FF15"
        '
        'btnBackup
        '
        Me.btnBackup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackup.Location = New System.Drawing.Point(229, 85)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(108, 37)
        Me.btnBackup.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnBackup.StateCommon.Border.Rounding = 0
        Me.btnBackup.StateCommon.Border.Width = 1
        Me.btnBackup.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.TabIndex = 17
        Me.btnBackup.Values.Text = "Sao Lưu"
        '
        'txtTenFile
        '
        Me.txtTenFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenFile.Enabled = False
        Me.txtTenFile.Location = New System.Drawing.Point(4, 60)
        Me.txtTenFile.Name = "txtTenFile"
        Me.txtTenFile.ReadOnly = True
        Me.txtTenFile.Size = New System.Drawing.Size(333, 19)
        Me.txtTenFile.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTenFile.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenFile.TabIndex = 16
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(58, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 15
        Me.KryptonLabel4.Values.Text = "Tên file:"
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.IsSplitterFixed = True
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonSplitContainer2)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonSplitContainer3)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(685, 380)
        Me.KryptonSplitContainer1.SplitterDistance = 129
        Me.KryptonSplitContainer1.SplitterWidth = 2
        Me.KryptonSplitContainer1.TabIndex = 20
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        '
        'KryptonSplitContainer2.Panel1
        '
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.KryptonHeader2)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.btnBackup)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.txtTenFile)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.a)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.txtDuongDanSaoLuu)
        '
        'KryptonSplitContainer2.Panel2
        '
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.KryptonHeader3)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.KryptonLabel4)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.txtDuongDanPhucHoi)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.lblThongBao)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.btnPhucHoi)
        Me.KryptonSplitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.KryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(685, 129)
        Me.KryptonSplitContainer2.SplitterDistance = 340
        Me.KryptonSplitContainer2.TabIndex = 20
        '
        'KryptonHeader2
        '
        Me.KryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader2.Name = "KryptonHeader2"
        Me.KryptonHeader2.Size = New System.Drawing.Size(340, 22)
        Me.KryptonHeader2.TabIndex = 19
        Me.KryptonHeader2.Values.Description = ""
        Me.KryptonHeader2.Values.Heading = "SAO LƯU"
        Me.KryptonHeader2.Values.Image = Nothing
        '
        'txtDuongDanSaoLuu
        '
        Me.txtDuongDanSaoLuu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDuongDanSaoLuu.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnOpenFolder})
        Me.txtDuongDanSaoLuu.Location = New System.Drawing.Point(4, 28)
        Me.txtDuongDanSaoLuu.Name = "txtDuongDanSaoLuu"
        Me.txtDuongDanSaoLuu.ReadOnly = True
        Me.txtDuongDanSaoLuu.Size = New System.Drawing.Size(333, 26)
        Me.txtDuongDanSaoLuu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuongDanSaoLuu.TabIndex = 19
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Text = "..."
        Me.btnOpenFolder.UniqueName = "D388E8DA2AD84796E1BEBB52A0D07E58"
        '
        'KryptonHeader3
        '
        Me.KryptonHeader3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader3.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader3.Name = "KryptonHeader3"
        Me.KryptonHeader3.Size = New System.Drawing.Size(340, 22)
        Me.KryptonHeader3.TabIndex = 20
        Me.KryptonHeader3.Values.Description = ""
        Me.KryptonHeader3.Values.Heading = "PHỤC HỒI"
        Me.KryptonHeader3.Values.Image = Nothing
        '
        'KryptonSplitContainer3
        '
        Me.KryptonSplitContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer3.Name = "KryptonSplitContainer3"
        '
        'KryptonSplitContainer3.Panel1
        '
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.CtrlSaoLuuDuLieu1)
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.KryptonHeader4)
        '
        'KryptonSplitContainer3.Panel2
        '
        Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.dgvMain)
        Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.KryptonHeader1)
        Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.ToolStrip2)
        Me.KryptonSplitContainer3.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer3.Size = New System.Drawing.Size(685, 249)
        Me.KryptonSplitContainer3.SplitterDistance = 340
        Me.KryptonSplitContainer3.TabIndex = 21
        '
        'CtrlSaoLuuDuLieu1
        '
        Me.CtrlSaoLuuDuLieu1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlSaoLuuDuLieu1.Location = New System.Drawing.Point(0, 22)
        Me.CtrlSaoLuuDuLieu1.Name = "CtrlSaoLuuDuLieu1"
        Me.CtrlSaoLuuDuLieu1.Size = New System.Drawing.Size(340, 227)
        Me.CtrlSaoLuuDuLieu1.TabIndex = 22
        '
        'KryptonHeader4
        '
        Me.KryptonHeader4.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader4.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader4.Name = "KryptonHeader4"
        Me.KryptonHeader4.Size = New System.Drawing.Size(340, 22)
        Me.KryptonHeader4.TabIndex = 21
        Me.KryptonHeader4.Values.Description = ""
        Me.KryptonHeader4.Values.Heading = "CÀI ĐẶT"
        Me.KryptonHeader4.Values.Image = Nothing
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.NgayThucHienDataGridViewTextBoxColumn, Me.NoiDungDataGridViewTextBoxColumn})
        Me.dgvMain.DataSource = Me.bsLichSu
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 22)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMain.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMain.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        Me.dgvMain.Size = New System.Drawing.Size(340, 202)
        Me.dgvMain.TabIndex = 2
        Me.dgvMain.VirtualMode = True
        '
        'STT
        '
        Me.STT.DataPropertyName = "STT"
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 40
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'NgayThucHienDataGridViewTextBoxColumn
        '
        Me.NgayThucHienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NgayThucHienDataGridViewTextBoxColumn.DataPropertyName = "NgayThucHien"
        DataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm:ss"
        Me.NgayThucHienDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.NgayThucHienDataGridViewTextBoxColumn.HeaderText = "Ngày Thực Hiện"
        Me.NgayThucHienDataGridViewTextBoxColumn.Name = "NgayThucHienDataGridViewTextBoxColumn"
        Me.NgayThucHienDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgayThucHienDataGridViewTextBoxColumn.Width = 122
        '
        'NoiDungDataGridViewTextBoxColumn
        '
        Me.NoiDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung"
        Me.NoiDungDataGridViewTextBoxColumn.HeaderText = "Nội Dung"
        Me.NoiDungDataGridViewTextBoxColumn.Name = "NoiDungDataGridViewTextBoxColumn"
        Me.NoiDungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsLichSu
        '
        Me.bsLichSu.DataSource = GetType(PhanMemBanHang.tbLogBackup)
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(340, 22)
        Me.KryptonHeader1.TabIndex = 20
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "LỊCH SỬ SAO LƯU - PHỤC HỒI"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoDong, Me.ToolStripSeparator3, Me.btnXoaTatCa, Me.btnXoa})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 224)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.ShowItemToolTips = False
        Me.ToolStrip2.Size = New System.Drawing.Size(340, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'lblSoDong
        '
        Me.lblSoDong.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSoDong.Name = "lblSoDong"
        Me.lblSoDong.Size = New System.Drawing.Size(16, 22)
        Me.lblSoDong.Text = "0."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnXoaTatCa
        '
        Me.btnXoaTatCa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnXoaTatCa.Image = CType(resources.GetObject("btnXoaTatCa.Image"), System.Drawing.Image)
        Me.btnXoaTatCa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoaTatCa.Name = "btnXoaTatCa"
        Me.btnXoaTatCa.Size = New System.Drawing.Size(79, 22)
        Me.btnXoaTatCa.Text = "Xoá tất cả"
        '
        'btnXoa
        '
        Me.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(47, 22)
        Me.btnXoa.Text = "Xoá"
        '
        'ctrlSaoLuuPhucHoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctrlSaoLuuPhucHoi"
        Me.Size = New System.Drawing.Size(685, 380)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer2.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer2.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer3.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer3.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLichSu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblThongBao As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents a As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDuongDanPhucHoi As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnChonFile As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnBackup As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtTenFile As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnPhucHoi As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonHeader2 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsLichSu As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblSoDong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnXoaTatCa As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoa As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonHeader3 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonSplitContainer3 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonHeader4 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents CtrlSaoLuuDuLieu1 As PhanMemBanHang.ctrlSaoLuuDuLieu
    Friend WithEvents STT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayThucHienDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoiDungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDuongDanSaoLuu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnOpenFolder As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
