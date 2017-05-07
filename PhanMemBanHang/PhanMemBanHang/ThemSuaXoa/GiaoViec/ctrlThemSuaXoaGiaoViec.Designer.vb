<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlThemSuaXoaGiaoViec
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnThem = New System.Windows.Forms.ToolStripButton()
        Me.btnSua = New System.Windows.Forms.ToolStripButton()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCapNhat = New System.Windows.Forms.ToolStripButton()
        Me.btnTimKiem = New System.Windows.Forms.ToolStripButton()
        Me.txtTuKhoa = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnIn = New System.Windows.Forms.ToolStripButton()
        Me.lblSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbNhanVien1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayHoanThanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoiDungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KhachHangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NhanVienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoUuTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrangThai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KetQua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CotFill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ĐangTiếnHànhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐãHoànThànhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbGiaoViecBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TbGiaoViecBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThem, Me.btnSua, Me.btnXoa, Me.ToolStripSeparator1, Me.btnCapNhat, Me.btnTimKiem, Me.txtTuKhoa})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(676, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnThem
        '
        Me.btnThem.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(78, 22)
        Me.btnThem.Text = "[F2]&Thêm"
        '
        'btnSua
        '
        Me.btnSua.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua16
        Me.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(66, 22)
        Me.btnSua.Text = "[F3]&Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.PhanMemBanHang.My.Resources.Resources.XoaTatCa16
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(67, 22)
        Me.btnXoa.Text = "[F4]&Xoá"
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
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIn, Me.lblSoLuong})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 407)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.ShowItemToolTips = False
        Me.ToolStrip2.Size = New System.Drawing.Size(676, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnIn
        '
        Me.btnIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnIn.Image = Global.PhanMemBanHang.My.Resources.Resources.In_16
        Me.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(94, 22)
        Me.btnIn.Text = "&In danh sách"
        Me.btnIn.Visible = False
        '
        'lblSoLuong
        '
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(64, 22)
        Me.lblSoLuong.Text = "0 Giao việc"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.tbNhanVien1, Me.NgayHoanThanh, Me.NoiDungDataGridViewTextBoxColumn, Me.KhachHangDataGridViewTextBoxColumn, Me.NhanVienDataGridViewTextBoxColumn, Me.DoUuTien, Me.TrangThai, Me.KetQua, Me.GhiChuDataGridViewTextBoxColumn, Me.CotFill})
        Me.dgvMain.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvMain.DataSource = Me.TbGiaoViecBindingSource
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 25)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.Size = New System.Drawing.Size(676, 382)
        Me.dgvMain.TabIndex = 2
        Me.dgvMain.VirtualMode = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 35
        '
        'tbNhanVien1
        '
        Me.tbNhanVien1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tbNhanVien1.DataPropertyName = "tbNhanVien1"
        Me.tbNhanVien1.HeaderText = "Nhân viên giao"
        Me.tbNhanVien1.Name = "tbNhanVien1"
        Me.tbNhanVien1.ReadOnly = True
        Me.tbNhanVien1.Width = 116
        '
        'NgayHoanThanh
        '
        Me.NgayHoanThanh.DataPropertyName = "NgayHoanThanh"
        Me.NgayHoanThanh.HeaderText = "Ngày kết thúc"
        Me.NgayHoanThanh.Name = "NgayHoanThanh"
        Me.NgayHoanThanh.ReadOnly = True
        '
        'NoiDungDataGridViewTextBoxColumn
        '
        Me.NoiDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NoiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung"
        Me.NoiDungDataGridViewTextBoxColumn.HeaderText = "Nội dung"
        Me.NoiDungDataGridViewTextBoxColumn.Name = "NoiDungDataGridViewTextBoxColumn"
        Me.NoiDungDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoiDungDataGridViewTextBoxColumn.Width = 86
        '
        'KhachHangDataGridViewTextBoxColumn
        '
        Me.KhachHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KhachHangDataGridViewTextBoxColumn.DataPropertyName = "tbKhachHang"
        Me.KhachHangDataGridViewTextBoxColumn.HeaderText = "Khách hàng"
        Me.KhachHangDataGridViewTextBoxColumn.Name = "KhachHangDataGridViewTextBoxColumn"
        Me.KhachHangDataGridViewTextBoxColumn.ReadOnly = True
        Me.KhachHangDataGridViewTextBoxColumn.Width = 99
        '
        'NhanVienDataGridViewTextBoxColumn
        '
        Me.NhanVienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NhanVienDataGridViewTextBoxColumn.DataPropertyName = "tbNhanVien"
        Me.NhanVienDataGridViewTextBoxColumn.HeaderText = "Nhân viên"
        Me.NhanVienDataGridViewTextBoxColumn.Name = "NhanVienDataGridViewTextBoxColumn"
        Me.NhanVienDataGridViewTextBoxColumn.ReadOnly = True
        Me.NhanVienDataGridViewTextBoxColumn.Width = 90
        '
        'DoUuTien
        '
        Me.DoUuTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DoUuTien.DataPropertyName = "DoUuTien"
        Me.DoUuTien.HeaderText = "Độ ưu tiên"
        Me.DoUuTien.Name = "DoUuTien"
        Me.DoUuTien.ReadOnly = True
        Me.DoUuTien.Width = 91
        '
        'TrangThai
        '
        Me.TrangThai.DataPropertyName = "TrangThaiString"
        Me.TrangThai.HeaderText = "Trạng thái"
        Me.TrangThai.Name = "TrangThai"
        Me.TrangThai.ReadOnly = True
        '
        'KetQua
        '
        Me.KetQua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KetQua.DataPropertyName = "KetQua"
        Me.KetQua.HeaderText = "Kết quả"
        Me.KetQua.Name = "KetQua"
        Me.KetQua.ReadOnly = True
        Me.KetQua.Width = 76
        '
        'GhiChuDataGridViewTextBoxColumn
        '
        Me.GhiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GhiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu"
        Me.GhiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú"
        Me.GhiChuDataGridViewTextBoxColumn.Name = "GhiChuDataGridViewTextBoxColumn"
        Me.GhiChuDataGridViewTextBoxColumn.ReadOnly = True
        Me.GhiChuDataGridViewTextBoxColumn.Width = 77
        '
        'CotFill
        '
        Me.CotFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CotFill.HeaderText = ""
        Me.CotFill.Name = "CotFill"
        Me.CotFill.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐangTiếnHànhToolStripMenuItem, Me.ĐãHoànThànhToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 48)
        '
        'ĐangTiếnHànhToolStripMenuItem
        '
        Me.ĐangTiếnHànhToolStripMenuItem.Name = "ĐangTiếnHànhToolStripMenuItem"
        Me.ĐangTiếnHànhToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ĐangTiếnHànhToolStripMenuItem.Text = "Đang tiến hành"
        '
        'ĐãHoànThànhToolStripMenuItem
        '
        Me.ĐãHoànThànhToolStripMenuItem.Name = "ĐãHoànThànhToolStripMenuItem"
        Me.ĐãHoànThànhToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ĐãHoànThànhToolStripMenuItem.Text = "Đã hoàn thành"
        '
        'TbGiaoViecBindingSource
        '
        Me.TbGiaoViecBindingSource.DataSource = GetType(PhanMemBanHang.tbGiaoViec)
        '
        'ctrlThemSuaXoaGiaoViec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlThemSuaXoaGiaoViec"
        Me.Size = New System.Drawing.Size(676, 432)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TbGiaoViecBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TbGiaoViecBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblSoLuong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents tbNhanVien1 As DataGridViewTextBoxColumn
    Friend WithEvents NgayHoanThanh As DataGridViewTextBoxColumn
    Friend WithEvents NoiDungDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KhachHangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NhanVienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoUuTien As DataGridViewTextBoxColumn
    Friend WithEvents TrangThai As DataGridViewTextBoxColumn
    Friend WithEvents KetQua As DataGridViewTextBoxColumn
    Friend WithEvents GhiChuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CotFill As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ĐangTiếnHànhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐãHoànThànhToolStripMenuItem As ToolStripMenuItem
End Class