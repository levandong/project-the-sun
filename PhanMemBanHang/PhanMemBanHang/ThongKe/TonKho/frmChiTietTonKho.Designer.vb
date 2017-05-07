<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChiTietTonKho
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPhieuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoiTuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongNhapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaNhapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongXuatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaXuatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongTonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LyDoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsChiTietTonKho = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpTuNgay = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpDenNgay = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.chkTheoKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkTheoThoiGian = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChiTietTonKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 97)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(995, 22)
        Me.KryptonHeader1.TabIndex = 1
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Thông tin"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.NgayDataGridViewTextBoxColumn, Me.MaPhieuDataGridViewTextBoxColumn, Me.DoiTuong, Me.SoLuongNhapDataGridViewTextBoxColumn, Me.DonGiaNhapDataGridViewTextBoxColumn, Me.SoLuongXuatDataGridViewTextBoxColumn, Me.DonGiaXuatDataGridViewTextBoxColumn, Me.SoLuongTonDataGridViewTextBoxColumn, Me.LyDoDataGridViewTextBoxColumn})
        Me.dgvMain.DataSource = Me.bsChiTietTonKho
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 119)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 5
        Me.dgvMain.Size = New System.Drawing.Size(995, 503)
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
        'NgayDataGridViewTextBoxColumn
        '
        Me.NgayDataGridViewTextBoxColumn.DataPropertyName = "Ngay"
        Me.NgayDataGridViewTextBoxColumn.HeaderText = "Ngày"
        Me.NgayDataGridViewTextBoxColumn.Name = "NgayDataGridViewTextBoxColumn"
        Me.NgayDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgayDataGridViewTextBoxColumn.Width = 70
        '
        'MaPhieuDataGridViewTextBoxColumn
        '
        Me.MaPhieuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaPhieuDataGridViewTextBoxColumn.DataPropertyName = "MaPhieu"
        Me.MaPhieuDataGridViewTextBoxColumn.HeaderText = "Số Phiếu "
        Me.MaPhieuDataGridViewTextBoxColumn.Name = "MaPhieuDataGridViewTextBoxColumn"
        Me.MaPhieuDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaPhieuDataGridViewTextBoxColumn.Width = 85
        '
        'DoiTuong
        '
        Me.DoiTuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DoiTuong.DataPropertyName = "DoiTuong"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DoiTuong.DefaultCellStyle = DataGridViewCellStyle1
        Me.DoiTuong.HeaderText = "Đơn Vị"
        Me.DoiTuong.Name = "DoiTuong"
        Me.DoiTuong.ReadOnly = True
        Me.DoiTuong.Width = 71
        '
        'SoLuongNhapDataGridViewTextBoxColumn
        '
        Me.SoLuongNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNhap"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Format = "N0"
        Me.SoLuongNhapDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SoLuongNhapDataGridViewTextBoxColumn.HeaderText = "S.L Nhập"
        Me.SoLuongNhapDataGridViewTextBoxColumn.Name = "SoLuongNhapDataGridViewTextBoxColumn"
        Me.SoLuongNhapDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongNhapDataGridViewTextBoxColumn.Width = 83
        '
        'DonGiaNhapDataGridViewTextBoxColumn
        '
        Me.DonGiaNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DonGiaNhapDataGridViewTextBoxColumn.DataPropertyName = "DonGiaNhap"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Format = "N0"
        Me.DonGiaNhapDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DonGiaNhapDataGridViewTextBoxColumn.HeaderText = "Đ.Giá Nhập"
        Me.DonGiaNhapDataGridViewTextBoxColumn.Name = "DonGiaNhapDataGridViewTextBoxColumn"
        Me.DonGiaNhapDataGridViewTextBoxColumn.ReadOnly = True
        Me.DonGiaNhapDataGridViewTextBoxColumn.Width = 96
        '
        'SoLuongXuatDataGridViewTextBoxColumn
        '
        Me.SoLuongXuatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoLuongXuatDataGridViewTextBoxColumn.DataPropertyName = "SoLuongXuat"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Format = "N0"
        Me.SoLuongXuatDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SoLuongXuatDataGridViewTextBoxColumn.HeaderText = "S.L Xuất"
        Me.SoLuongXuatDataGridViewTextBoxColumn.Name = "SoLuongXuatDataGridViewTextBoxColumn"
        Me.SoLuongXuatDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongXuatDataGridViewTextBoxColumn.Width = 78
        '
        'DonGiaXuatDataGridViewTextBoxColumn
        '
        Me.DonGiaXuatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DonGiaXuatDataGridViewTextBoxColumn.DataPropertyName = "DonGiaXuat"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        Me.DonGiaXuatDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DonGiaXuatDataGridViewTextBoxColumn.HeaderText = "Đ.Giá Xuất"
        Me.DonGiaXuatDataGridViewTextBoxColumn.Name = "DonGiaXuatDataGridViewTextBoxColumn"
        Me.DonGiaXuatDataGridViewTextBoxColumn.ReadOnly = True
        Me.DonGiaXuatDataGridViewTextBoxColumn.Width = 91
        '
        'SoLuongTonDataGridViewTextBoxColumn
        '
        Me.SoLuongTonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Format = "N0"
        Me.SoLuongTonDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SoLuongTonDataGridViewTextBoxColumn.HeaderText = "S.L Tồn"
        Me.SoLuongTonDataGridViewTextBoxColumn.Name = "SoLuongTonDataGridViewTextBoxColumn"
        Me.SoLuongTonDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongTonDataGridViewTextBoxColumn.Width = 75
        '
        'LyDoDataGridViewTextBoxColumn
        '
        Me.LyDoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LyDoDataGridViewTextBoxColumn.DataPropertyName = "LyDo"
        Me.LyDoDataGridViewTextBoxColumn.HeaderText = "Ghi chú"
        Me.LyDoDataGridViewTextBoxColumn.Name = "LyDoDataGridViewTextBoxColumn"
        Me.LyDoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsChiTietTonKho
        '
        Me.bsChiTietTonKho.DataSource = GetType(PhanMemBanHang.clsChiTietTonKho)
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.CalendarTodayDate = New Date(2014, 5, 13, 0, 0, 0, 0)
        Me.dtpTuNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTuNgay.Location = New System.Drawing.Point(176, 12)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(106, 21)
        Me.dtpTuNgay.TabIndex = 51
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.CalendarTodayDate = New Date(2014, 5, 13, 0, 0, 0, 0)
        Me.dtpDenNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDenNgay.Location = New System.Drawing.Point(334, 13)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(106, 21)
        Me.dtpDenNgay.TabIndex = 52
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(754, 12)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(85, 46)
        Me.btnTimKiem.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnTimKiem.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnTimKiem.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnTimKiem.TabIndex = 50
        Me.btnTimKiem.Values.ExtraText = "[F5]"
        Me.btnTimKiem.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem32
        Me.btnTimKiem.Values.Text = ""
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.chkTheoKhachHang)
        Me.KryptonPanel1.Controls.Add(Me.txtKhachHang)
        Me.KryptonPanel1.Controls.Add(Me.KryptonButton1)
        Me.KryptonPanel1.Controls.Add(Me.dtpDenNgay)
        Me.KryptonPanel1.Controls.Add(Me.dtpTuNgay)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.btnTimKiem)
        Me.KryptonPanel1.Controls.Add(Me.chkTheoThoiGian)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(995, 97)
        Me.KryptonPanel1.TabIndex = 53
        '
        'chkTheoKhachHang
        '
        Me.chkTheoKhachHang.Location = New System.Drawing.Point(3, 40)
        Me.chkTheoKhachHang.Name = "chkTheoKhachHang"
        Me.chkTheoKhachHang.Size = New System.Drawing.Size(117, 20)
        Me.chkTheoKhachHang.TabIndex = 57
        Me.chkTheoKhachHang.Values.Text = "Theo khách hàng"
        '
        'txtKhachHang
        '
        Me.txtKhachHang.Enabled = False
        Me.txtKhachHang.Location = New System.Drawing.Point(127, 39)
        Me.txtKhachHang.Name = "txtKhachHang"
        Me.txtKhachHang.Size = New System.Drawing.Size(448, 23)
        Me.txtKhachHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKhachHang.TabIndex = 56
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(857, 12)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(85, 46)
        Me.KryptonButton1.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonButton1.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonButton1.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonButton1.TabIndex = 53
        Me.KryptonButton1.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Print32
        Me.KryptonButton1.Values.Text = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(297, 13)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(31, 20)
        Me.KryptonLabel3.TabIndex = 51
        Me.KryptonLabel3.Values.Text = "đến"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(146, 13)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(24, 20)
        Me.KryptonLabel2.TabIndex = 50
        Me.KryptonLabel2.Values.Text = "Từ"
        '
        'chkTheoThoiGian
        '
        Me.chkTheoThoiGian.Checked = True
        Me.chkTheoThoiGian.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTheoThoiGian.Location = New System.Drawing.Point(3, 14)
        Me.chkTheoThoiGian.Name = "chkTheoThoiGian"
        Me.chkTheoThoiGian.Size = New System.Drawing.Size(103, 20)
        Me.chkTheoThoiGian.TabIndex = 49
        Me.chkTheoThoiGian.Values.Text = "Theo thời gian"
        '
        'frmChiTietTonKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 622)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.KryptonHeader1)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.KeyPreview = True
        Me.Name = "frmChiTietTonKho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "THẺ KHO"
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChiTietTonKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsChiTietTonKho As BindingSource
    Friend WithEvents dtpTuNgay As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dtpDenNgay As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkTheoThoiGian As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents NgayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaPhieuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoiTuong As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongNhapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonGiaNhapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongXuatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonGiaXuatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongTonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LyDoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtKhachHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkTheoKhachHang As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
