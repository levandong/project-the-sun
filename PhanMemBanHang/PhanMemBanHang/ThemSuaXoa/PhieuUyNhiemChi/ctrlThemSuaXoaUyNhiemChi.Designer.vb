<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThemSuaXoaUyNhiemChi
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
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.txtTuKhoa = New PhanMemBanHang.clsTextbox()
        Me.dtpDenLuc = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpTuLuc = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.pnlQuanLy = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.btnXoa = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSua = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnThem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThuImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MaPhieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhachHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoTienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MucPhiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChungTuKemTheoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhachHangUNC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoiDungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsUyNhiemChi = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClsTextbox1 = New PhanMemBanHang.clsTextbox()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        CType(Me.pnlQuanLy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlQuanLy.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQuanLy.Panel.SuspendLayout()
        Me.pnlQuanLy.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUyNhiemChi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.pnlQuanLy)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvMain)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(995, 523)
        Me.KryptonSplitContainer1.SplitterDistance = 77
        Me.KryptonSplitContainer1.SplitterWidth = 2
        Me.KryptonSplitContainer1.TabIndex = 38
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.CaptionEdge = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(160, 0)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.ClsTextbox1)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTuKhoa)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDenLuc)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpTuLuc)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnTimKiem)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(434, 77)
        Me.KryptonGroupBox1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonGroupBox1.StateCommon.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroupBox1.StateCommon.Border.Rounding = 0
        Me.KryptonGroupBox1.StateCommon.Border.Width = 1
        Me.KryptonGroupBox1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonGroupBox1.TabIndex = 9
        Me.KryptonGroupBox1.Values.Heading = "Tìm kiếm"
        '
        'txtTuKhoa
        '
        Me.txtTuKhoa.Location = New System.Drawing.Point(165, 18)
        Me.txtTuKhoa.Name = "txtTuKhoa"
        Me.txtTuKhoa.Size = New System.Drawing.Size(202, 24)
        Me.txtTuKhoa.StateCommon.Content.Color1 = System.Drawing.Color.Gray
        Me.txtTuKhoa.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtTuKhoa.TabIndex = 11
        Me.txtTuKhoa.Text = "<Từ khóa>"
        Me.txtTuKhoa.TextGoiY = "<Từ khóa>"
        '
        'dtpDenLuc
        '
        Me.dtpDenLuc.CustomFormat = "dd/MM/yyyy"
        Me.dtpDenLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDenLuc.Location = New System.Drawing.Point(35, 29)
        Me.dtpDenLuc.Name = "dtpDenLuc"
        Me.dtpDenLuc.Size = New System.Drawing.Size(124, 25)
        Me.dtpDenLuc.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDenLuc.TabIndex = 9
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 30)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(33, 20)
        Me.KryptonLabel2.TabIndex = 10
        Me.KryptonLabel2.Values.Text = "Đến"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(24, 20)
        Me.KryptonLabel1.TabIndex = 8
        Me.KryptonLabel1.Values.Text = "Từ"
        '
        'dtpTuLuc
        '
        Me.dtpTuLuc.CustomFormat = "dd/MM/yyyy"
        Me.dtpTuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTuLuc.Location = New System.Drawing.Point(35, 2)
        Me.dtpTuLuc.Name = "dtpTuLuc"
        Me.dtpTuLuc.Size = New System.Drawing.Size(124, 25)
        Me.dtpTuLuc.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTuLuc.TabIndex = 7
        '
        'btnTimKiem
        '
        Me.btnTimKiem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.btnTimKiem.Location = New System.Drawing.Point(378, 4)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(48, 48)
        Me.btnTimKiem.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnTimKiem.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnTimKiem.TabIndex = 1
        Me.btnTimKiem.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem32
        Me.btnTimKiem.Values.Text = "Tìm"
        '
        'pnlQuanLy
        '
        Me.pnlQuanLy.CaptionEdge = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.pnlQuanLy.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlQuanLy.Location = New System.Drawing.Point(0, 0)
        Me.pnlQuanLy.Name = "pnlQuanLy"
        '
        'pnlQuanLy.Panel
        '
        Me.pnlQuanLy.Panel.Controls.Add(Me.btnXoa)
        Me.pnlQuanLy.Panel.Controls.Add(Me.btnSua)
        Me.pnlQuanLy.Panel.Controls.Add(Me.btnThem)
        Me.pnlQuanLy.Size = New System.Drawing.Size(160, 77)
        Me.pnlQuanLy.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.pnlQuanLy.StateCommon.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.pnlQuanLy.StateCommon.Border.Rounding = 0
        Me.pnlQuanLy.StateCommon.Border.Width = 1
        Me.pnlQuanLy.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.pnlQuanLy.TabIndex = 8
        Me.pnlQuanLy.Values.Heading = "Quản lý"
        '
        'btnXoa
        '
        Me.btnXoa.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.btnXoa.Location = New System.Drawing.Point(107, 4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(45, 50)
        Me.btnXoa.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnXoa.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Delete24
        Me.btnXoa.Values.Text = "Xóa"
        '
        'btnSua
        '
        Me.btnSua.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.btnSua.Location = New System.Drawing.Point(58, 4)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(45, 50)
        Me.btnSua.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnSua.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnSua.TabIndex = 2
        Me.btnSua.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Edit24
        Me.btnSua.Values.Text = "Sửa"
        '
        'btnThem
        '
        Me.btnThem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.btnThem.Location = New System.Drawing.Point(7, 4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(45, 50)
        Me.btnThem.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnThem.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnThem.TabIndex = 1
        Me.btnThem.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Add24
        Me.btnThem.Values.Text = "Thêm"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.ThuImage, Me.MaPhieu, Me.NgayLapDataGridViewTextBoxColumn, Me.TenKhachHang, Me.SoTienDataGridViewTextBoxColumn, Me.MucPhiDataGridViewTextBoxColumn, Me.ChungTuKemTheoDataGridViewTextBoxColumn, Me.TenKhachHangUNC, Me.NoiDungDataGridViewTextBoxColumn})
        Me.dgvMain.DataSource = Me.bsUyNhiemChi
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.RowHeadersWidth = 5
        Me.dgvMain.Size = New System.Drawing.Size(995, 444)
        Me.dgvMain.TabIndex = 0
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.Width = 35
        '
        'ThuImage
        '
        Me.ThuImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ThuImage.DataPropertyName = "ThuImage"
        Me.ThuImage.HeaderText = " "
        Me.ThuImage.Name = "ThuImage"
        Me.ThuImage.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ThuImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ThuImage.Width = 39
        '
        'MaPhieu
        '
        Me.MaPhieu.DataPropertyName = "MaPhieu"
        Me.MaPhieu.HeaderText = "Mã Phiếu"
        Me.MaPhieu.Name = "MaPhieu"
        '
        'NgayLapDataGridViewTextBoxColumn
        '
        Me.NgayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap"
        Me.NgayLapDataGridViewTextBoxColumn.HeaderText = "Ngày Lập"
        Me.NgayLapDataGridViewTextBoxColumn.Name = "NgayLapDataGridViewTextBoxColumn"
        '
        'TenKhachHang
        '
        Me.TenKhachHang.DataPropertyName = "TenKhachHang"
        Me.TenKhachHang.HeaderText = "Tên Khách Hàng"
        Me.TenKhachHang.Name = "TenKhachHang"
        '
        'SoTienDataGridViewTextBoxColumn
        '
        Me.SoTienDataGridViewTextBoxColumn.DataPropertyName = "SoTien"
        Me.SoTienDataGridViewTextBoxColumn.HeaderText = "Số Tiền"
        Me.SoTienDataGridViewTextBoxColumn.Name = "SoTienDataGridViewTextBoxColumn"
        '
        'MucPhiDataGridViewTextBoxColumn
        '
        Me.MucPhiDataGridViewTextBoxColumn.DataPropertyName = "MucPhi"
        Me.MucPhiDataGridViewTextBoxColumn.HeaderText = "Phí Chuyển"
        Me.MucPhiDataGridViewTextBoxColumn.Name = "MucPhiDataGridViewTextBoxColumn"
        '
        'ChungTuKemTheoDataGridViewTextBoxColumn
        '
        Me.ChungTuKemTheoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ChungTuKemTheoDataGridViewTextBoxColumn.DataPropertyName = "ChungTuKemTheo"
        Me.ChungTuKemTheoDataGridViewTextBoxColumn.HeaderText = "Chứng Từ Kèm Theo"
        Me.ChungTuKemTheoDataGridViewTextBoxColumn.Name = "ChungTuKemTheoDataGridViewTextBoxColumn"
        Me.ChungTuKemTheoDataGridViewTextBoxColumn.Width = 146
        '
        'TenKhachHangUNC
        '
        Me.TenKhachHangUNC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenKhachHangUNC.DataPropertyName = "TenKhachHangUNC"
        Me.TenKhachHangUNC.HeaderText = "Khách Hàng UNC"
        Me.TenKhachHangUNC.Name = "TenKhachHangUNC"
        Me.TenKhachHangUNC.Width = 129
        '
        'NoiDungDataGridViewTextBoxColumn
        '
        Me.NoiDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung"
        Me.NoiDungDataGridViewTextBoxColumn.HeaderText = "Nội Dung UNC"
        Me.NoiDungDataGridViewTextBoxColumn.Name = "NoiDungDataGridViewTextBoxColumn"
        '
        'bsUyNhiemChi
        '
        Me.bsUyNhiemChi.DataSource = GetType(PhanMemBanHang.tbPhieuUyNhiemChi)
        '
        'ClsTextbox1
        '
        Me.ClsTextbox1.Location = New System.Drawing.Point(173, 26)
        Me.ClsTextbox1.Name = "ClsTextbox1"
        Me.ClsTextbox1.Size = New System.Drawing.Size(100, 24)
        Me.ClsTextbox1.StateCommon.Content.Color1 = System.Drawing.Color.Gray
        Me.ClsTextbox1.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.ClsTextbox1.TabIndex = 12
        Me.ClsTextbox1.Text = "ClsTextbox1"
        Me.ClsTextbox1.TextGoiY = "Nhập nội dung ở đây..."
        '
        'ctrlThemSuaXoaUyNhiemChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctrlThemSuaXoaUyNhiemChi"
        Me.Size = New System.Drawing.Size(995, 523)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        CType(Me.pnlQuanLy.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQuanLy.Panel.ResumeLayout(False)
        CType(Me.pnlQuanLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQuanLy.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUyNhiemChi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents txtTuKhoa As clsTextbox
    Friend WithEvents dtpDenLuc As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpTuLuc As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents pnlQuanLy As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents btnXoa As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSua As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnThem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsUyNhiemChi As BindingSource
    Friend WithEvents IsPhieuThuDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SoPhieuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbNganHangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbKhachHangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbNganHangUyNhiemChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents ThuImage As DataGridViewImageColumn
    Friend WithEvents MaPhieu As DataGridViewTextBoxColumn
    Friend WithEvents NgayLapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenKhachHang As DataGridViewTextBoxColumn
    Friend WithEvents SoTienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MucPhiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChungTuKemTheoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenKhachHangUNC As DataGridViewTextBoxColumn
    Friend WithEvents NoiDungDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClsTextbox1 As clsTextbox
End Class
