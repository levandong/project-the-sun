<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlDGVKhachHang
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnIn = New System.Windows.Forms.ToolStripButton()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.XemThôngTinLiênHệToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsKhachHang = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKhachHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhachHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Loai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDienThoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSoThue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoFAX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CongNoDauKy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayNhapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CongNoMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HanTraNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNhomKhachHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.bsKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoLuong, Me.ToolStripSeparator1, Me.btnIn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 389)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(877, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(78, 22)
        Me.lblSoLuong.Text = "0 khách hàng"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnIn
        '
        Me.btnIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnIn.Image = Global.PhanMemBanHang.My.Resources.Resources.Print16
        Me.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(37, 22)
        Me.btnIn.Text = "In"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaKhachHang, Me.TenKhachHang, Me.Loai, Me.SoDienThoai, Me.DiaChi, Me.MaSoThue, Me.Email, Me.SoFAX, Me.CongNoDauKy, Me.NgayNhapDataGridViewTextBoxColumn, Me.CongNoMax, Me.HanTraNo, Me.TenNhomKhachHang})
        Me.dgvMain.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvMain.DataSource = Me.bsKhachHang
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMain.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMain.Size = New System.Drawing.Size(877, 389)
        Me.dgvMain.TabIndex = 5
        Me.dgvMain.VirtualMode = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XemThôngTinLiênHệToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(189, 26)
        '
        'XemThôngTinLiênHệToolStripMenuItem
        '
        Me.XemThôngTinLiênHệToolStripMenuItem.Image = Global.PhanMemBanHang.My.Resources.Resources.BaoGia
        Me.XemThôngTinLiênHệToolStripMenuItem.Name = "XemThôngTinLiênHệToolStripMenuItem"
        Me.XemThôngTinLiênHệToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.XemThôngTinLiênHệToolStripMenuItem.Text = "Xem thông tin liên hệ"
        '
        'bsKhachHang
        '
        Me.bsKhachHang.DataSource = GetType(PhanMemBanHang.vwKhachHang)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tbNhomKhachHang"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nhóm Sản Phẩm"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tbLoaiKhachHang"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Loại Sản Phẩm"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'STT
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STT.DefaultCellStyle = DataGridViewCellStyle1
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 40
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'MaKhachHang
        '
        Me.MaKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaKhachHang.DataPropertyName = "MaKhachHang"
        Me.MaKhachHang.HeaderText = "Mã"
        Me.MaKhachHang.MinimumWidth = 60
        Me.MaKhachHang.Name = "MaKhachHang"
        Me.MaKhachHang.ReadOnly = True
        Me.MaKhachHang.Width = 60
        '
        'TenKhachHang
        '
        Me.TenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenKhachHang.DataPropertyName = "TenKhachHang"
        Me.TenKhachHang.HeaderText = "Tên khách hàng/Nhà CC"
        Me.TenKhachHang.Name = "TenKhachHang"
        Me.TenKhachHang.ReadOnly = True
        Me.TenKhachHang.Width = 167
        '
        'Loai
        '
        Me.Loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Loai.DataPropertyName = "Loai"
        Me.Loai.HeaderText = "KH/NCC"
        Me.Loai.Name = "Loai"
        Me.Loai.ReadOnly = True
        Me.Loai.Width = 82
        '
        'SoDienThoai
        '
        Me.SoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoDienThoai.DataPropertyName = "SoDienThoai"
        Me.SoDienThoai.HeaderText = "Điện thoại"
        Me.SoDienThoai.Name = "SoDienThoai"
        Me.SoDienThoai.ReadOnly = True
        Me.SoDienThoai.Width = 90
        '
        'DiaChi
        '
        Me.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DiaChi.DataPropertyName = "DiaChi"
        Me.DiaChi.HeaderText = "Địa Chỉ"
        Me.DiaChi.MinimumWidth = 150
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.ReadOnly = True
        Me.DiaChi.Width = 150
        '
        'MaSoThue
        '
        Me.MaSoThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaSoThue.DataPropertyName = "MaSoThue"
        Me.MaSoThue.HeaderText = "Mã Số Thuế"
        Me.MaSoThue.Name = "MaSoThue"
        Me.MaSoThue.ReadOnly = True
        Me.MaSoThue.Width = 99
        '
        'Email
        '
        Me.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 65
        '
        'SoFAX
        '
        Me.SoFAX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoFAX.DataPropertyName = "SoFAX"
        Me.SoFAX.HeaderText = "Fax"
        Me.SoFAX.Name = "SoFAX"
        Me.SoFAX.ReadOnly = True
        Me.SoFAX.Width = 53
        '
        'CongNoDauKy
        '
        Me.CongNoDauKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CongNoDauKy.DataPropertyName = "CongNoDauKy"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Format = "N0"
        Me.CongNoDauKy.DefaultCellStyle = DataGridViewCellStyle2
        Me.CongNoDauKy.HeaderText = "Nợ đầu kỳ"
        Me.CongNoDauKy.Name = "CongNoDauKy"
        Me.CongNoDauKy.ReadOnly = True
        Me.CongNoDauKy.Visible = False
        Me.CongNoDauKy.Width = 90
        '
        'NgayNhapDataGridViewTextBoxColumn
        '
        Me.NgayNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NgayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap"
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.NgayNhapDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.NgayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày Tạo"
        Me.NgayNhapDataGridViewTextBoxColumn.Name = "NgayNhapDataGridViewTextBoxColumn"
        Me.NgayNhapDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgayNhapDataGridViewTextBoxColumn.Width = 87
        '
        'CongNoMax
        '
        Me.CongNoMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CongNoMax.DataPropertyName = "CongNoMax"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.Format = "N0"
        Me.CongNoMax.DefaultCellStyle = DataGridViewCellStyle4
        Me.CongNoMax.HeaderText = "Công nợ Max"
        Me.CongNoMax.Name = "CongNoMax"
        Me.CongNoMax.ReadOnly = True
        Me.CongNoMax.Width = 107
        '
        'HanTraNo
        '
        Me.HanTraNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HanTraNo.DataPropertyName = "HanTraNo"
        DataGridViewCellStyle5.Format = "dd/MM/yyyy"
        Me.HanTraNo.DefaultCellStyle = DataGridViewCellStyle5
        Me.HanTraNo.HeaderText = "Hạn thanh toán"
        Me.HanTraNo.Name = "HanTraNo"
        Me.HanTraNo.ReadOnly = True
        Me.HanTraNo.Visible = False
        Me.HanTraNo.Width = 119
        '
        'TenNhomKhachHang
        '
        Me.TenNhomKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenNhomKhachHang.DataPropertyName = "TenRutGon"
        Me.TenNhomKhachHang.HeaderText = "Tên Đầy Đủ"
        Me.TenNhomKhachHang.MinimumWidth = 150
        Me.TenNhomKhachHang.Name = "TenNhomKhachHang"
        Me.TenNhomKhachHang.ReadOnly = True
        '
        'ctrlDGVKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlDGVKhachHang"
        Me.Size = New System.Drawing.Size(877, 414)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.bsKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsKhachHang As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblSoLuong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbLoaiKhachHang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaVachKhachHang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonVi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents XemThôngTinLiênHệToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents MaKhachHang As DataGridViewTextBoxColumn
    Friend WithEvents TenKhachHang As DataGridViewTextBoxColumn
    Friend WithEvents Loai As DataGridViewTextBoxColumn
    Friend WithEvents SoDienThoai As DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As DataGridViewTextBoxColumn
    Friend WithEvents MaSoThue As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents SoFAX As DataGridViewTextBoxColumn
    Friend WithEvents CongNoDauKy As DataGridViewTextBoxColumn
    Friend WithEvents NgayNhapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CongNoMax As DataGridViewTextBoxColumn
    Friend WithEvents HanTraNo As DataGridViewTextBoxColumn
    Friend WithEvents TenNhomKhachHang As DataGridViewTextBoxColumn
End Class
