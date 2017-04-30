<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThemSuaXoaNguoiLam
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNguoiLamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNguoiLamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhString = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDienThoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMNDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayVaoLamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsNguoiLam = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lblSoDong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnThem = New System.Windows.Forms.ToolStripButton()
        Me.btnSua = New System.Windows.Forms.ToolStripButton()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        Me.btnCapNhat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuayLai = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnTimKiem = New System.Windows.Forms.ToolStripButton()
        Me.txtTuKhoa = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNguoiLam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dgvMain)
        Me.KryptonPanel1.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel1.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1112, 565)
        Me.KryptonPanel1.TabIndex = 0
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaNguoiLamDataGridViewTextBoxColumn, Me.TenNguoiLamDataGridViewTextBoxColumn, Me.GioiTinhString, Me.SoDienThoaiDataGridViewTextBoxColumn, Me.CMNDDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.NgayVaoLamDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn})
        Me.dgvMain.DataSource = Me.bsNguoiLam
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 25)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMain.Size = New System.Drawing.Size(1112, 515)
        Me.dgvMain.TabIndex = 4
        Me.dgvMain.VirtualMode = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 40
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'MaNguoiLamDataGridViewTextBoxColumn
        '
        Me.MaNguoiLamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaNguoiLamDataGridViewTextBoxColumn.DataPropertyName = "MaNguoiLam"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        Me.MaNguoiLamDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MaNguoiLamDataGridViewTextBoxColumn.HeaderText = "Mã"
        Me.MaNguoiLamDataGridViewTextBoxColumn.Name = "MaNguoiLamDataGridViewTextBoxColumn"
        Me.MaNguoiLamDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaNguoiLamDataGridViewTextBoxColumn.Width = 53
        '
        'TenNguoiLamDataGridViewTextBoxColumn
        '
        Me.TenNguoiLamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenNguoiLamDataGridViewTextBoxColumn.DataPropertyName = "TenNguoiLam"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        Me.TenNguoiLamDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TenNguoiLamDataGridViewTextBoxColumn.HeaderText = "Họ tên"
        Me.TenNguoiLamDataGridViewTextBoxColumn.Name = "TenNguoiLamDataGridViewTextBoxColumn"
        Me.TenNguoiLamDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenNguoiLamDataGridViewTextBoxColumn.Width = 72
        '
        'GioiTinhString
        '
        Me.GioiTinhString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GioiTinhString.DataPropertyName = "GioiTinhString"
        Me.GioiTinhString.HeaderText = "Giới tính"
        Me.GioiTinhString.Name = "GioiTinhString"
        Me.GioiTinhString.ReadOnly = True
        Me.GioiTinhString.Width = 81
        '
        'SoDienThoaiDataGridViewTextBoxColumn
        '
        Me.SoDienThoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai"
        Me.SoDienThoaiDataGridViewTextBoxColumn.HeaderText = "Điện thoại"
        Me.SoDienThoaiDataGridViewTextBoxColumn.Name = "SoDienThoaiDataGridViewTextBoxColumn"
        Me.SoDienThoaiDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoDienThoaiDataGridViewTextBoxColumn.Width = 90
        '
        'CMNDDataGridViewTextBoxColumn
        '
        Me.CMNDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND"
        Me.CMNDDataGridViewTextBoxColumn.HeaderText = "CMND"
        Me.CMNDDataGridViewTextBoxColumn.Name = "CMNDDataGridViewTextBoxColumn"
        Me.CMNDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CMNDDataGridViewTextBoxColumn.Width = 72
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.NgaySinhDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh"
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        Me.NgaySinhDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgaySinhDataGridViewTextBoxColumn.Width = 89
        '
        'NgayVaoLamDataGridViewTextBoxColumn
        '
        Me.NgayVaoLamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NgayVaoLamDataGridViewTextBoxColumn.DataPropertyName = "NgayVaoLam"
        DataGridViewCellStyle4.Format = "dd/MM/yyyyy"
        Me.NgayVaoLamDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.NgayVaoLamDataGridViewTextBoxColumn.HeaderText = "Ngày vào làm"
        Me.NgayVaoLamDataGridViewTextBoxColumn.Name = "NgayVaoLamDataGridViewTextBoxColumn"
        Me.NgayVaoLamDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgayVaoLamDataGridViewTextBoxColumn.Width = 109
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ"
        Me.DiaChiDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        Me.DiaChiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsNguoiLam
        '
        Me.bsNguoiLam.DataSource = GetType(PhanMemBanHang.tbNguoiLam)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoDong, Me.ToolStripSeparator1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 540)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.ShowItemToolTips = False
        Me.ToolStrip2.Size = New System.Drawing.Size(1112, 25)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'lblSoDong
        '
        Me.lblSoDong.Name = "lblSoDong"
        Me.lblSoDong.Size = New System.Drawing.Size(71, 22)
        Me.lblSoDong.Text = "0 nhân viên."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThem, Me.btnSua, Me.btnXoa, Me.btnCapNhat, Me.ToolStripSeparator4, Me.btnQuayLai, Me.ToolStripSeparator5, Me.btnTimKiem, Me.txtTuKhoa})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1112, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnThem
        '
        Me.btnThem.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(58, 22)
        Me.btnThem.Text = "Thêm"
        '
        'btnSua
        '
        Me.btnSua.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua16
        Me.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(46, 22)
        Me.btnSua.Text = "Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.PhanMemBanHang.My.Resources.Resources.Huy16
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(47, 22)
        Me.btnXoa.Text = "Xoá"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCapNhat.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 22)
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnQuayLai
        '
        Me.btnQuayLai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnQuayLai.Image = Global.PhanMemBanHang.My.Resources.Resources.Undo16
        Me.btnQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(70, 22)
        Me.btnQuayLai.Text = "Quay lại"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnTimKiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnTimKiem.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(23, 22)
        Me.btnTimKiem.Text = "Tìm kiếm"
        '
        'txtTuKhoa
        '
        Me.txtTuKhoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTuKhoa.Name = "txtTuKhoa"
        Me.txtTuKhoa.Size = New System.Drawing.Size(130, 25)
        '
        'ctrlThemSuaXoaNguoiLam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlThemSuaXoaNguoiLam"
        Me.Size = New System.Drawing.Size(1112, 565)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNguoiLam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnThem As ToolStripButton
    Friend WithEvents btnSua As ToolStripButton
    Friend WithEvents btnXoa As ToolStripButton
    Friend WithEvents btnCapNhat As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnQuayLai As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents txtTuKhoa As ToolStripTextBox
    Friend WithEvents btnTimKiem As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents lblSoDong As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsNguoiLam As BindingSource
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents MaNguoiLamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenNguoiLamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhString As DataGridViewTextBoxColumn
    Friend WithEvents SoDienThoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CMNDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayVaoLamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
