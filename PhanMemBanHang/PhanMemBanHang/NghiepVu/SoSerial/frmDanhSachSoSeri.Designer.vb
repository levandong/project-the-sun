<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachSoSeri
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dgvSanPham = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.MaSeriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbPhieuNhapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayNhapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsDanhSachSoSeri = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonDataGridView2 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsDanhSachChon = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnXacNhan = New System.Windows.Forms.ToolStripButton()
        Me.btnBoQua = New System.Windows.Forms.ToolStripButton()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDanhSachSoSeri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDanhSachChon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(601, 469)
        Me.KryptonPanel1.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgvSanPham)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtSearch)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonDataGridView2)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(601, 469)
        Me.KryptonSplitContainer1.SplitterDistance = 288
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'dgvSanPham
        '
        Me.dgvSanPham.AllowUserToAddRows = False
        Me.dgvSanPham.AllowUserToDeleteRows = False
        Me.dgvSanPham.AutoGenerateColumns = False
        Me.dgvSanPham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSeriDataGridViewTextBoxColumn, Me.TbPhieuNhapDataGridViewTextBoxColumn, Me.NgayNhapDataGridViewTextBoxColumn})
        Me.dgvSanPham.DataSource = Me.bsDanhSachSoSeri
        Me.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSanPham.Location = New System.Drawing.Point(0, 26)
        Me.dgvSanPham.Name = "dgvSanPham"
        Me.dgvSanPham.ReadOnly = True
        Me.dgvSanPham.RowHeadersWidth = 5
        Me.dgvSanPham.Size = New System.Drawing.Size(288, 443)
        Me.dgvSanPham.TabIndex = 1
        '
        'MaSeriDataGridViewTextBoxColumn
        '
        Me.MaSeriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaSeriDataGridViewTextBoxColumn.DataPropertyName = "MaSeri"
        Me.MaSeriDataGridViewTextBoxColumn.HeaderText = "Mã"
        Me.MaSeriDataGridViewTextBoxColumn.Name = "MaSeriDataGridViewTextBoxColumn"
        Me.MaSeriDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaSeriDataGridViewTextBoxColumn.Width = 53
        '
        'TbPhieuNhapDataGridViewTextBoxColumn
        '
        Me.TbPhieuNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TbPhieuNhapDataGridViewTextBoxColumn.DataPropertyName = "tbPhieuNhap"
        Me.TbPhieuNhapDataGridViewTextBoxColumn.HeaderText = "Phiếu nhập"
        Me.TbPhieuNhapDataGridViewTextBoxColumn.Name = "TbPhieuNhapDataGridViewTextBoxColumn"
        Me.TbPhieuNhapDataGridViewTextBoxColumn.ReadOnly = True
        Me.TbPhieuNhapDataGridViewTextBoxColumn.Width = 96
        '
        'NgayNhapDataGridViewTextBoxColumn
        '
        Me.NgayNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NgayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap"
        Me.NgayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập"
        Me.NgayNhapDataGridViewTextBoxColumn.Name = "NgayNhapDataGridViewTextBoxColumn"
        Me.NgayNhapDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsDanhSachSoSeri
        '
        Me.bsDanhSachSoSeri.DataSource = GetType(PhanMemBanHang.tbChiTietSeri)
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearch.Location = New System.Drawing.Point(0, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(288, 26)
        Me.txtSearch.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.TabIndex = 0
        '
        'KryptonDataGridView2
        '
        Me.KryptonDataGridView2.AllowUserToAddRows = False
        Me.KryptonDataGridView2.AllowUserToDeleteRows = False
        Me.KryptonDataGridView2.AutoGenerateColumns = False
        Me.KryptonDataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.KryptonDataGridView2.DataSource = Me.bsDanhSachChon
        Me.KryptonDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonDataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonDataGridView2.Name = "KryptonDataGridView2"
        Me.KryptonDataGridView2.ReadOnly = True
        Me.KryptonDataGridView2.RowHeadersWidth = 5
        Me.KryptonDataGridView2.Size = New System.Drawing.Size(308, 469)
        Me.KryptonDataGridView2.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MaSeri"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 53
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tbPhieuNhap"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Phiếu nhập"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 96
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NgayNhap"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ngày nhập"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'bsDanhSachChon
        '
        Me.bsDanhSachChon.DataSource = GetType(PhanMemBanHang.tbChiTietSeri)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnXacNhan, Me.btnBoQua})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(601, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnXacNhan
        '
        Me.btnXacNhan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnXacNhan.Image = Global.PhanMemBanHang.My.Resources.Resources.tick216
        Me.btnXacNhan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXacNhan.Name = "btnXacNhan"
        Me.btnXacNhan.Size = New System.Drawing.Size(88, 22)
        Me.btnXacNhan.Text = "XÁC NHẬN"
        '
        'btnBoQua
        '
        Me.btnBoQua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBoQua.Image = Global.PhanMemBanHang.My.Resources.Resources.Dang_Xuat_16
        Me.btnBoQua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBoQua.Name = "btnBoQua"
        Me.btnBoQua.Size = New System.Drawing.Size(71, 22)
        Me.btnBoQua.Text = "BỎ QUA"
        '
        'frmDanhSachSoSeri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 494)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmDanhSachSoSeri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách chọn số seri"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDanhSachSoSeri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDanhSachChon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bsDanhSachSoSeri As BindingSource
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents dgvSanPham As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonDataGridView2 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents bsDanhSachChon As BindingSource
    Friend WithEvents btnXacNhan As ToolStripButton
    Friend WithEvents btnBoQua As ToolStripButton
    Friend WithEvents MaSeriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbPhieuNhapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayNhapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
