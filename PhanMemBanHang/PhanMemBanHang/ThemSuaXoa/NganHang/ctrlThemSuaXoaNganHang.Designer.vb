 <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.TbNganHangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNganHangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoTaiKhoanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChiNhanhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDuDauKy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayNhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbNganHangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnIn.Image = Global.PhanMemBanHang.My.Resources.Resources.Print16
        Me.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(94, 22)
        Me.btnIn.Text = "&In danh sách"
        Me.btnIn.Visible = False
        '
        'lblSoLuong
        '
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(79, 22)
        Me.lblSoLuong.Text = "0 NganHang_"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.TenNganHangDataGridViewTextBoxColumn, Me.SoTaiKhoanDataGridViewTextBoxColumn, Me.ChiNhanhDataGridViewTextBoxColumn, Me.SoDuDauKy, Me.NgayNhap, Me.GhiChuDataGridViewTextBoxColumn})
        Me.dgvMain.DataSource = Me.TbNganHangBindingSource
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 25)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.Size = New System.Drawing.Size(676, 382)
        Me.dgvMain.TabIndex = 2
        Me.dgvMain.VirtualMode = True
        '
        'TbNganHangBindingSource
        '
        Me.TbNganHangBindingSource.DataSource = GetType(PhanMemBanHang.tbNganHang)
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 35
        '
        'TenNganHangDataGridViewTextBoxColumn
        '
        Me.TenNganHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenNganHangDataGridViewTextBoxColumn.DataPropertyName = "TenNganHang"
        Me.TenNganHangDataGridViewTextBoxColumn.HeaderText = "Tên Ngân Hàng"
        Me.TenNganHangDataGridViewTextBoxColumn.Name = "TenNganHangDataGridViewTextBoxColumn"
        Me.TenNganHangDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenNganHangDataGridViewTextBoxColumn.Width = 120
        '
        'SoTaiKhoanDataGridViewTextBoxColumn
        '
        Me.SoTaiKhoanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "SoTaiKhoan"
        Me.SoTaiKhoanDataGridViewTextBoxColumn.HeaderText = "Số Tài Khoản"
        Me.SoTaiKhoanDataGridViewTextBoxColumn.Name = "SoTaiKhoanDataGridViewTextBoxColumn"
        Me.SoTaiKhoanDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoTaiKhoanDataGridViewTextBoxColumn.Width = 105
        '
        'ChiNhanhDataGridViewTextBoxColumn
        '
        Me.ChiNhanhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ChiNhanhDataGridViewTextBoxColumn.DataPropertyName = "ChiNhanh"
        Me.ChiNhanhDataGridViewTextBoxColumn.HeaderText = "Chi nhánh"
        Me.ChiNhanhDataGridViewTextBoxColumn.Name = "ChiNhanhDataGridViewTextBoxColumn"
        Me.ChiNhanhDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChiNhanhDataGridViewTextBoxColumn.Width = 91
        '
        'SoDuDauKy
        '
        Me.SoDuDauKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoDuDauKy.DataPropertyName = "SoDuDauKy"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.Format = "N0"
        Me.SoDuDauKy.DefaultCellStyle = DataGridViewCellStyle1
        Me.SoDuDauKy.HeaderText = "Dư Đầu Kỳ"
        Me.SoDuDauKy.Name = "SoDuDauKy"
        Me.SoDuDauKy.ReadOnly = True
        Me.SoDuDauKy.Width = 91
        '
        'NgayNhap
        '
        Me.NgayNhap.DataPropertyName = "NgayNhap"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        Me.NgayNhap.DefaultCellStyle = DataGridViewCellStyle2
        Me.NgayNhap.HeaderText = "Ngày nhập"
        Me.NgayNhap.Name = "NgayNhap"
        Me.NgayNhap.ReadOnly = True
        '
        'GhiChuDataGridViewTextBoxColumn
        '
        Me.GhiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu"
        Me.GhiChuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú"
        Me.GhiChuDataGridViewTextBoxColumn.Name = "GhiChuDataGridViewTextBoxColumn"
        Me.GhiChuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ctrlThemSuaXoaNganHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlThemSuaXoaNganHang"
        Me.Size = New System.Drawing.Size(676, 432)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbNganHangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents TbNganHangBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents btnIn As System.Windows.Forms.ToolStripButton
        Friend WithEvents lblSoLuong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents TenNganHangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoTaiKhoanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChiNhanhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoDuDauKy As DataGridViewTextBoxColumn
    Friend WithEvents NgayNhap As DataGridViewTextBoxColumn
    Friend WithEvents GhiChuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class