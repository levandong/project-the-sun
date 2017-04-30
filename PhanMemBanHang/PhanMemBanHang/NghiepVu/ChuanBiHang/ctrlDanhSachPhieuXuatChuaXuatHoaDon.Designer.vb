<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlDanhSachPhieuXuatChuaXuatHoaDon
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.bsPhieuXuat = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPhieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiPhieuXuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CongTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNhaCungCap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNhanVien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.bsPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dgvMain)
        Me.KryptonPanel1.Controls.Add(Me.KryptonHeader1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1035, 565)
        Me.KryptonPanel1.TabIndex = 0
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(1035, 31)
        Me.KryptonHeader1.TabIndex = 0
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "DANH SÁCH SẢN PHẨM XUẤT KHO"
        Me.KryptonHeader1.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Xuat16
        '
        'bsPhieuXuat
        '
        Me.bsPhieuXuat.DataSource = GetType(PhanMemBanHang.vwPhieuXuat)
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaPhieu, Me.NgayLap, Me.LoaiPhieuXuat, Me.CongTien, Me.TenNhaCungCap, Me.TenNhanVien, Me.GhiChuDataGridViewTextBoxColumn})
        Me.dgvMain.DataSource = Me.bsPhieuXuat
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 31)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMain.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMain.Size = New System.Drawing.Size(1035, 534)
        Me.dgvMain.TabIndex = 1
        Me.dgvMain.VirtualMode = True
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
        'MaPhieu
        '
        Me.MaPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaPhieu.DataPropertyName = "MaPhieu"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MaPhieu.DefaultCellStyle = DataGridViewCellStyle2
        Me.MaPhieu.HeaderText = "Mã Phiếu"
        Me.MaPhieu.Name = "MaPhieu"
        Me.MaPhieu.ReadOnly = True
        Me.MaPhieu.Width = 86
        '
        'NgayLap
        '
        Me.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NgayLap.DataPropertyName = "NgayLap"
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.NgayLap.DefaultCellStyle = DataGridViewCellStyle3
        Me.NgayLap.HeaderText = "Ngày Lập"
        Me.NgayLap.Name = "NgayLap"
        Me.NgayLap.ReadOnly = True
        Me.NgayLap.Width = 86
        '
        'LoaiPhieuXuat
        '
        Me.LoaiPhieuXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LoaiPhieuXuat.DataPropertyName = "LoaiPhieuXuat"
        Me.LoaiPhieuXuat.HeaderText = "Loại"
        Me.LoaiPhieuXuat.Name = "LoaiPhieuXuat"
        Me.LoaiPhieuXuat.ReadOnly = True
        Me.LoaiPhieuXuat.Width = 58
        '
        'CongTien
        '
        Me.CongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CongTien.DataPropertyName = "TongTien"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Format = "N0"
        Me.CongTien.DefaultCellStyle = DataGridViewCellStyle4
        Me.CongTien.HeaderText = "Tổng Tiền"
        Me.CongTien.Name = "CongTien"
        Me.CongTien.ReadOnly = True
        Me.CongTien.Width = 90
        '
        'TenNhaCungCap
        '
        Me.TenNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenNhaCungCap.DataPropertyName = "TenNhaCungCap"
        Me.TenNhaCungCap.HeaderText = "Tên NCC"
        Me.TenNhaCungCap.Name = "TenNhaCungCap"
        Me.TenNhaCungCap.ReadOnly = True
        Me.TenNhaCungCap.Width = 83
        '
        'TenNhanVien
        '
        Me.TenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenNhanVien.DataPropertyName = "TenNhanVien"
        Me.TenNhanVien.HeaderText = "Tên NV"
        Me.TenNhanVien.Name = "TenNhanVien"
        Me.TenNhanVien.ReadOnly = True
        Me.TenNhanVien.Width = 74
        '
        'GhiChuDataGridViewTextBoxColumn
        '
        Me.GhiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu"
        Me.GhiChuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú"
        Me.GhiChuDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.GhiChuDataGridViewTextBoxColumn.Name = "GhiChuDataGridViewTextBoxColumn"
        Me.GhiChuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ctrlDanhSachPhieuXuatChuaXuatHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlDanhSachPhieuXuatChuaXuatHoaDon"
        Me.Size = New System.Drawing.Size(1035, 565)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.bsPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents MaPhieu As DataGridViewTextBoxColumn
    Friend WithEvents NgayLap As DataGridViewTextBoxColumn
    Friend WithEvents LoaiPhieuXuat As DataGridViewTextBoxColumn
    Friend WithEvents CongTien As DataGridViewTextBoxColumn
    Friend WithEvents TenNhaCungCap As DataGridViewTextBoxColumn
    Friend WithEvents TenNhanVien As DataGridViewTextBoxColumn
    Friend WithEvents GhiChuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsPhieuXuat As BindingSource
End Class
