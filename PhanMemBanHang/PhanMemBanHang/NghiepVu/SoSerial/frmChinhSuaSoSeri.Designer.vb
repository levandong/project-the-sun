<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChinhSuaSeri
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
        Me.cmsSoSeri = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.XóaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsChiTietSoSeri = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlMain = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonDataGridView1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TenSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSeriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        Me.btnBoQua = New System.Windows.Forms.ToolStripButton()
        Me.btnXacNhan = New System.Windows.Forms.ToolStripButton()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtSoSeri = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnThemSoSeri = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonDataGridView2 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.MaSeriDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsChiTietXacNhan = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btnSuaSeri = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtTextSua = New System.Windows.Forms.ToolStripTextBox()
        Me.cmsSoSeri.SuspendLayout()
        CType(Me.bsChiTietSoSeri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMain.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.Panel1.SuspendLayout()
        CType(Me.pnlMain.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.Panel2.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChiTietXacNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsSoSeri
        '
        Me.cmsSoSeri.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmsSoSeri.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XóaToolStripMenuItem})
        Me.cmsSoSeri.Name = "cmsSoSeri"
        Me.cmsSoSeri.Size = New System.Drawing.Size(95, 26)
        '
        'XóaToolStripMenuItem
        '
        Me.XóaToolStripMenuItem.Image = Global.PhanMemBanHang.My.Resources.Resources.Huy16
        Me.XóaToolStripMenuItem.Name = "XóaToolStripMenuItem"
        Me.XóaToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.XóaToolStripMenuItem.Text = "Xóa"
        '
        'bsChiTietSoSeri
        '
        Me.bsChiTietSoSeri.DataSource = GetType(PhanMemBanHang.tbChiTietSeri)
        '
        'pnlMain
        '
        Me.pnlMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        '
        'pnlMain.Panel1
        '
        Me.pnlMain.Panel1.Controls.Add(Me.KryptonPanel1)
        '
        'pnlMain.Panel2
        '
        Me.pnlMain.Panel2.Controls.Add(Me.KryptonDataGridView2)
        Me.pnlMain.Panel2.Controls.Add(Me.ToolStrip3)
        Me.pnlMain.Panel2.Controls.Add(Me.ToolStrip2)
        Me.pnlMain.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.pnlMain.Size = New System.Drawing.Size(548, 423)
        Me.pnlMain.SplitterDistance = 241
        Me.pnlMain.SplitterWidth = 2
        Me.pnlMain.TabIndex = 1
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonDataGridView1)
        Me.KryptonPanel1.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel1.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(241, 423)
        Me.KryptonPanel1.TabIndex = 1
        '
        'KryptonDataGridView1
        '
        Me.KryptonDataGridView1.AllowUserToAddRows = False
        Me.KryptonDataGridView1.AllowUserToDeleteRows = False
        Me.KryptonDataGridView1.AutoGenerateColumns = False
        Me.KryptonDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenSanPham, Me.MaSeriDataGridViewTextBoxColumn})
        Me.KryptonDataGridView1.ContextMenuStrip = Me.cmsSoSeri
        Me.KryptonDataGridView1.DataSource = Me.bsChiTietSoSeri
        Me.KryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonDataGridView1.Location = New System.Drawing.Point(0, 30)
        Me.KryptonDataGridView1.Name = "KryptonDataGridView1"
        Me.KryptonDataGridView1.ReadOnly = True
        Me.KryptonDataGridView1.RowHeadersWidth = 5
        Me.KryptonDataGridView1.Size = New System.Drawing.Size(241, 368)
        Me.KryptonDataGridView1.TabIndex = 1
        '
        'TenSanPham
        '
        Me.TenSanPham.DataPropertyName = "TenSanPham"
        Me.TenSanPham.HeaderText = "Tên Sản Phẩm"
        Me.TenSanPham.Name = "TenSanPham"
        Me.TenSanPham.ReadOnly = True
        Me.TenSanPham.Width = 110
        '
        'MaSeriDataGridViewTextBoxColumn
        '
        Me.MaSeriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaSeriDataGridViewTextBoxColumn.DataPropertyName = "MaSeri"
        Me.MaSeriDataGridViewTextBoxColumn.HeaderText = "Mã Seri"
        Me.MaSeriDataGridViewTextBoxColumn.Name = "MaSeriDataGridViewTextBoxColumn"
        Me.MaSeriDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoLuong, Me.btnXoa, Me.btnBoQua, Me.btnXacNhan})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 398)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(241, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(69, 22)
        Me.lblSoLuong.Text = "0 Sản phẩm"
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.PhanMemBanHang.My.Resources.Resources.Huy16
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(47, 22)
        Me.btnXoa.Text = "Xóa"
        '
        'btnBoQua
        '
        Me.btnBoQua.Image = Global.PhanMemBanHang.My.Resources.Resources.Dang_Xuat_16
        Me.btnBoQua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBoQua.Name = "btnBoQua"
        Me.btnBoQua.Size = New System.Drawing.Size(71, 22)
        Me.btnBoQua.Text = "BỎ QUA"
        '
        'btnXacNhan
        '
        Me.btnXacNhan.Image = Global.PhanMemBanHang.My.Resources.Resources.tick216
        Me.btnXacNhan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXacNhan.Name = "btnXacNhan"
        Me.btnXacNhan.Size = New System.Drawing.Size(76, 20)
        Me.btnXacNhan.Text = "Xác nhận"
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.txtSoSeri)
        Me.KryptonPanel2.Controls.Add(Me.btnThemSoSeri)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(241, 30)
        Me.KryptonPanel2.TabIndex = 0
        '
        'txtSoSeri
        '
        Me.txtSoSeri.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSoSeri.Location = New System.Drawing.Point(0, 0)
        Me.txtSoSeri.Name = "txtSoSeri"
        Me.txtSoSeri.Size = New System.Drawing.Size(151, 26)
        Me.txtSoSeri.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoSeri.TabIndex = 0
        '
        'btnThemSoSeri
        '
        Me.btnThemSoSeri.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnThemSoSeri.Location = New System.Drawing.Point(151, 0)
        Me.btnThemSoSeri.Name = "btnThemSoSeri"
        Me.btnThemSoSeri.Size = New System.Drawing.Size(90, 30)
        Me.btnThemSoSeri.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemSoSeri.TabIndex = 1
        Me.btnThemSoSeri.Values.Text = "Thêm"
        '
        'KryptonDataGridView2
        '
        Me.KryptonDataGridView2.AllowUserToAddRows = False
        Me.KryptonDataGridView2.AllowUserToDeleteRows = False
        Me.KryptonDataGridView2.AutoGenerateColumns = False
        Me.KryptonDataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSeriDataGridViewTextBoxColumn1})
        Me.KryptonDataGridView2.ContextMenuStrip = Me.cmsSoSeri
        Me.KryptonDataGridView2.DataSource = Me.bsChiTietXacNhan
        Me.KryptonDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonDataGridView2.Location = New System.Drawing.Point(0, 25)
        Me.KryptonDataGridView2.Name = "KryptonDataGridView2"
        Me.KryptonDataGridView2.ReadOnly = True
        Me.KryptonDataGridView2.RowHeadersWidth = 5
        Me.KryptonDataGridView2.Size = New System.Drawing.Size(305, 373)
        Me.KryptonDataGridView2.TabIndex = 2
        '
        'MaSeriDataGridViewTextBoxColumn1
        '
        Me.MaSeriDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaSeriDataGridViewTextBoxColumn1.DataPropertyName = "MaSeri"
        Me.MaSeriDataGridViewTextBoxColumn1.HeaderText = "Mã Seri"
        Me.MaSeriDataGridViewTextBoxColumn1.Name = "MaSeriDataGridViewTextBoxColumn1"
        Me.MaSeriDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'bsChiTietXacNhan
        '
        Me.bsChiTietXacNhan.DataSource = GetType(PhanMemBanHang.tbChiTietSeri)
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSuaSeri})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 398)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(305, 25)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btnSuaSeri
        '
        Me.btnSuaSeri.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua16
        Me.btnSuaSeri.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSuaSeri.Name = "btnSuaSeri"
        Me.btnSuaSeri.Size = New System.Drawing.Size(46, 22)
        Me.btnSuaSeri.Text = "Sửa"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtTextSua})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(305, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripLabel1.Text = "DANH SÁCH ĐÃ THÊM"
        '
        'txtTextSua
        '
        Me.txtTextSua.Name = "txtTextSua"
        Me.txtTextSua.Size = New System.Drawing.Size(140, 25)
        '
        'frmChinhSuaSeri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 423)
        Me.Controls.Add(Me.pnlMain)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChinhSuaSeri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tạo Số Seri"
        Me.cmsSoSeri.ResumeLayout(False)
        CType(Me.bsChiTietSoSeri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMain.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.Panel1.ResumeLayout(False)
        CType(Me.pnlMain.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.Panel2.ResumeLayout(False)
        Me.pnlMain.Panel2.PerformLayout()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.KryptonDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChiTietXacNhan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsChiTietSoSeri As BindingSource
    Friend WithEvents cmsSoSeri As ContextMenuStrip
    Friend WithEvents XóaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlMain As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonDataGridView1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TenSanPham As DataGridViewTextBoxColumn
    Friend WithEvents MaSeriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lblSoLuong As ToolStripLabel
    Friend WithEvents btnXoa As ToolStripButton
    Friend WithEvents btnBoQua As ToolStripButton
    Friend WithEvents btnXacNhan As ToolStripButton
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtSoSeri As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnThemSoSeri As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonDataGridView2 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents btnSuaSeri As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents bsChiTietXacNhan As BindingSource
    Friend WithEvents MaSeriDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents txtTextSua As ToolStripTextBox
End Class
