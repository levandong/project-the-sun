<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlThemSuaXoaLoaiPhieuThu
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtTuKhoa = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lblSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TbLoaiPhieuThuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnIn = New System.Windows.Forms.ToolStripButton()
        Me.btnThem = New System.Windows.Forms.ToolStripButton()
        Me.btnSua = New System.Windows.Forms.ToolStripButton()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        Me.btnCapNhat = New System.Windows.Forms.ToolStripButton()
        Me.btnTimKiem = New System.Windows.Forms.ToolStripButton()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CotFill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ' khởi tạo các cột
        Me.LoaiThuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.MoTaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.LoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn

        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbLoaiPhieuThuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'lblSoLuong
        '
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(32, 22)
        Me.lblSoLuong.Text = "0 Loại Phiếu Thu"

        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.LoaiThuDataGridViewTextBoxColumn,Me.MoTaDataGridViewTextBoxColumn,Me.LoaiDataGridViewTextBoxColumn, Me.CotFill})
        Me.dgvMain.DataSource = Me.TbLoaiPhieuThuBindingSource
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 25)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.Size = New System.Drawing.Size(676, 382)
        Me.dgvMain.TabIndex = 2
        Me.dgvMain.VirtualMode = True
        '
        'TbLoaiPhieuThuBindingSource
        '
        Me.TbLoaiPhieuThuBindingSource.DataSource = GetType(PhanMemBanHang.tbLoaiPhieuThu)
        '
        'btnIn
        '
        Me.btnIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnIn.Image = Global.PhanMemBanHang.My.Resources.Resources.In_16
        Me.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Visible = False
        Me.btnIn.Size = New System.Drawing.Size(94, 22)
        Me.btnIn.Text = "&In danh sách"
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
        Me.btnSua.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua_16
        Me.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(46, 22)
        Me.btnSua.Text = "&Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.PhanMemBanHang.My.Resources.Resources.Xoa_16
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(47, 22)
        Me.btnXoa.Text = "&Xoá"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Image = Global.PhanMemBanHang.My.Resources.Resources.Cap_Nhat_16
        Me.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 22)
        Me.btnCapNhat.Text = "&Cập nhật"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnTimKiem.Image = Global.PhanMemBanHang.My.Resources.Resources.Tim_16
        Me.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(77, 22)
        Me.btnTimKiem.Text = "Tìm &kiếm"
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 35
        'CotFill
        '
        Me.CotFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CotFill.HeaderText = ""
        Me.CotFill.Name = "CotFill"
        Me.CotFill.ReadOnly = True
        '
        ' gán thuộc tính
        'LoaiThuDataGridViewTextBoxColumn
'
Me.LoaiThuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
Me.LoaiThuDataGridViewTextBoxColumn.DataPropertyName = "LoaiThu"
Me.LoaiThuDataGridViewTextBoxColumn.HeaderText = "Tên Loại Thu"
Me.LoaiThuDataGridViewTextBoxColumn.Name = "LoaiThuDataGridViewTextBoxColumn"
Me.LoaiThuDataGridViewTextBoxColumn.ReadOnly = True
Me.LoaiThuDataGridViewTextBoxColumn.Width = 78
'MoTaDataGridViewTextBoxColumn
'
Me.MoTaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
Me.MoTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa"
Me.MoTaDataGridViewTextBoxColumn.HeaderText = "Mô Tả"
Me.MoTaDataGridViewTextBoxColumn.Name = "MoTaDataGridViewTextBoxColumn"
Me.MoTaDataGridViewTextBoxColumn.ReadOnly = True
Me.MoTaDataGridViewTextBoxColumn.Width = 78
'LoaiDataGridViewTextBoxColumn
'
Me.LoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
Me.LoaiDataGridViewTextBoxColumn.DataPropertyName = "Loai"
Me.LoaiDataGridViewTextBoxColumn.HeaderText = "Loại"
Me.LoaiDataGridViewTextBoxColumn.Name = "LoaiDataGridViewTextBoxColumn"
Me.LoaiDataGridViewTextBoxColumn.ReadOnly = True
Me.LoaiDataGridViewTextBoxColumn.Width = 78

        '
        'ctrlThemSuaXoaLoaiPhieuThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlThemSuaXoaLoaiPhieuThu"
        Me.Size = New System.Drawing.Size(676, 432)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbLoaiPhieuThuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TbLoaiPhieuThuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblSoLuong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents STT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CotFill As System.Windows.Forms.DataGridViewTextBoxColumn
    'khai báo các cột
    Friend WithEvents LoaiThuDataGridViewTextBoxColumn As  System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents MoTaDataGridViewTextBoxColumn As  System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents LoaiDataGridViewTextBoxColumn As  System.Windows.Forms.DataGridViewTextBoxColumn

End Class