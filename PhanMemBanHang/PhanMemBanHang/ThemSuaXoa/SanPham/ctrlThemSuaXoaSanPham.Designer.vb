<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThemSuaXoaSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlThemSuaXoaSanPham))
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.CtrlDGVLoaiSanPham1 = New PhanMemBanHang.ctrlDGVLoaiSanPham()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnChonTatCa = New System.Windows.Forms.ToolStripButton()
        Me.btnThemLoaiSanPham = New System.Windows.Forms.ToolStripButton()
        Me.btnSuaLoaiSanPham = New System.Windows.Forms.ToolStripButton()
        Me.btnXoaLoaiSanPham = New System.Windows.Forms.ToolStripButton()
        Me.btnCapNhatLoaiSanPham = New System.Windows.Forms.ToolStripButton()
        Me.txtTimKiemLoai = New System.Windows.Forms.ToolStripTextBox()
        Me.CtrlDGVSanPham1 = New PhanMemBanHang.ctrlDGVSanPham()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnThemSanPham = New System.Windows.Forms.ToolStripButton()
        Me.btnSuaSanPham = New System.Windows.Forms.ToolStripButton()
        Me.btnXoaSanPham = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCapNhatSanPham = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuayLai = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLoaiTimKiemSanPham = New System.Windows.Forms.ToolStripSplitButton()
        Me.HủyTìmKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTimKiemSanPham = New System.Windows.Forms.ToolStripTextBox()
        Me.btnInMaVachSanPham = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnChiTietNhapXuat = New System.Windows.Forms.ToolStripButton()
        Me.btnTinhToanTonKho = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CKNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CKXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.CtrlDGVLoaiSanPham1)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.CtrlDGVSanPham1)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1465, 370)
        Me.KryptonSplitContainer1.SplitterDistance = 350
        Me.KryptonSplitContainer1.SplitterWidth = 3
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'CtrlDGVLoaiSanPham1
        '
        Me.CtrlDGVLoaiSanPham1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlDGVLoaiSanPham1.Location = New System.Drawing.Point(0, 25)
        Me.CtrlDGVLoaiSanPham1.Name = "CtrlDGVLoaiSanPham1"
        Me.CtrlDGVLoaiSanPham1.Size = New System.Drawing.Size(350, 345)
        Me.CtrlDGVLoaiSanPham1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChonTatCa, Me.btnThemLoaiSanPham, Me.btnSuaLoaiSanPham, Me.btnXoaLoaiSanPham, Me.btnCapNhatLoaiSanPham, Me.txtTimKiemLoai})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(350, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnChonTatCa
        '
        Me.btnChonTatCa.Image = Global.PhanMemBanHang.My.Resources.Resources.Checked
        Me.btnChonTatCa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChonTatCa.Name = "btnChonTatCa"
        Me.btnChonTatCa.Size = New System.Drawing.Size(88, 22)
        Me.btnChonTatCa.Text = "Chọn tất cả"
        '
        'btnThemLoaiSanPham
        '
        Me.btnThemLoaiSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnThemLoaiSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.btnThemLoaiSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemLoaiSanPham.Name = "btnThemLoaiSanPham"
        Me.btnThemLoaiSanPham.Size = New System.Drawing.Size(23, 22)
        Me.btnThemLoaiSanPham.Text = "Thêm"
        '
        'btnSuaLoaiSanPham
        '
        Me.btnSuaLoaiSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSuaLoaiSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua16
        Me.btnSuaLoaiSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSuaLoaiSanPham.Name = "btnSuaLoaiSanPham"
        Me.btnSuaLoaiSanPham.Size = New System.Drawing.Size(23, 22)
        Me.btnSuaLoaiSanPham.Text = "Sửa"
        '
        'btnXoaLoaiSanPham
        '
        Me.btnXoaLoaiSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnXoaLoaiSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.Huy16
        Me.btnXoaLoaiSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoaLoaiSanPham.Name = "btnXoaLoaiSanPham"
        Me.btnXoaLoaiSanPham.Size = New System.Drawing.Size(23, 22)
        Me.btnXoaLoaiSanPham.Text = "Xoá"
        '
        'btnCapNhatLoaiSanPham
        '
        Me.btnCapNhatLoaiSanPham.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCapNhatLoaiSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCapNhatLoaiSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatLoaiSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapNhatLoaiSanPham.Name = "btnCapNhatLoaiSanPham"
        Me.btnCapNhatLoaiSanPham.Size = New System.Drawing.Size(23, 22)
        Me.btnCapNhatLoaiSanPham.Text = "Cập nhật"
        Me.btnCapNhatLoaiSanPham.Visible = False
        '
        'txtTimKiemLoai
        '
        Me.txtTimKiemLoai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTimKiemLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimKiemLoai.Name = "txtTimKiemLoai"
        Me.txtTimKiemLoai.Size = New System.Drawing.Size(100, 25)
        '
        'CtrlDGVSanPham1
        '
        Me.CtrlDGVSanPham1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlDGVSanPham1.Location = New System.Drawing.Point(0, 25)
        Me.CtrlDGVSanPham1.Name = "CtrlDGVSanPham1"
        Me.CtrlDGVSanPham1.Size = New System.Drawing.Size(1112, 345)
        Me.CtrlDGVSanPham1.TabIndex = 8
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThemSanPham, Me.btnSuaSanPham, Me.btnXoaSanPham, Me.ToolStripSeparator4, Me.btnCapNhatSanPham, Me.ToolStripSeparator5, Me.btnQuayLai, Me.ToolStripSeparator6, Me.btnLoaiTimKiemSanPham, Me.txtTimKiemSanPham, Me.btnInMaVachSanPham, Me.ToolStripSeparator1, Me.btnChiTietNhapXuat, Me.btnTinhToanTonKho, Me.ToolStripButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1112, 25)
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip1"
        '
        'btnThemSanPham
        '
        Me.btnThemSanPham.Image = CType(resources.GetObject("btnThemSanPham.Image"), System.Drawing.Image)
        Me.btnThemSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThemSanPham.Name = "btnThemSanPham"
        Me.btnThemSanPham.Size = New System.Drawing.Size(47, 22)
        Me.btnThemSanPham.Text = "[F2]"
        '
        'btnSuaSanPham
        '
        Me.btnSuaSanPham.Image = CType(resources.GetObject("btnSuaSanPham.Image"), System.Drawing.Image)
        Me.btnSuaSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSuaSanPham.Name = "btnSuaSanPham"
        Me.btnSuaSanPham.Size = New System.Drawing.Size(47, 22)
        Me.btnSuaSanPham.Text = "[F3]"
        '
        'btnXoaSanPham
        '
        Me.btnXoaSanPham.Image = CType(resources.GetObject("btnXoaSanPham.Image"), System.Drawing.Image)
        Me.btnXoaSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoaSanPham.Name = "btnXoaSanPham"
        Me.btnXoaSanPham.Size = New System.Drawing.Size(47, 22)
        Me.btnXoaSanPham.Text = "[F4]"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnCapNhatSanPham
        '
        Me.btnCapNhatSanPham.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCapNhatSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapNhatSanPham.Name = "btnCapNhatSanPham"
        Me.btnCapNhatSanPham.Size = New System.Drawing.Size(77, 22)
        Me.btnCapNhatSanPham.Text = "&Cập Nhật"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnQuayLai
        '
        Me.btnQuayLai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnQuayLai.Image = Global.PhanMemBanHang.My.Resources.Resources.Undo16
        Me.btnQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(73, 22)
        Me.btnQuayLai.Text = "&Quay Lại"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnLoaiTimKiemSanPham
        '
        Me.btnLoaiTimKiemSanPham.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnLoaiTimKiemSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLoaiTimKiemSanPham.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HủyTìmKiếmToolStripMenuItem})
        Me.btnLoaiTimKiemSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnLoaiTimKiemSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLoaiTimKiemSanPham.Name = "btnLoaiTimKiemSanPham"
        Me.btnLoaiTimKiemSanPham.Size = New System.Drawing.Size(32, 22)
        Me.btnLoaiTimKiemSanPham.Text = "Chọn Loại Tìm Kiếm"
        Me.btnLoaiTimKiemSanPham.ToolTipText = "Tìm Kiếm"
        '
        'HủyTìmKiếmToolStripMenuItem
        '
        Me.HủyTìmKiếmToolStripMenuItem.Name = "HủyTìmKiếmToolStripMenuItem"
        Me.HủyTìmKiếmToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.HủyTìmKiếmToolStripMenuItem.Text = "Hủy tìm kiếm"
        '
        'txtTimKiemSanPham
        '
        Me.txtTimKiemSanPham.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTimKiemSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimKiemSanPham.Name = "txtTimKiemSanPham"
        Me.txtTimKiemSanPham.Size = New System.Drawing.Size(150, 25)
        '
        'btnInMaVachSanPham
        '
        Me.btnInMaVachSanPham.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnInMaVachSanPham.Image = Global.PhanMemBanHang.My.Resources.Resources.MaVach
        Me.btnInMaVachSanPham.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInMaVachSanPham.Name = "btnInMaVachSanPham"
        Me.btnInMaVachSanPham.Size = New System.Drawing.Size(87, 22)
        Me.btnInMaVachSanPham.Text = "In mã vạch"
        Me.btnInMaVachSanPham.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator1.Visible = False
        '
        'btnChiTietNhapXuat
        '
        Me.btnChiTietNhapXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnChiTietNhapXuat.Image = Global.PhanMemBanHang.My.Resources.Resources.DanhSach16
        Me.btnChiTietNhapXuat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChiTietNhapXuat.Name = "btnChiTietNhapXuat"
        Me.btnChiTietNhapXuat.Size = New System.Drawing.Size(71, 22)
        Me.btnChiTietNhapXuat.Text = "Thẻ Kho"
        '
        'btnTinhToanTonKho
        '
        Me.btnTinhToanTonKho.Image = Global.PhanMemBanHang.My.Resources.Resources.calculator16x16
        Me.btnTinhToanTonKho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTinhToanTonKho.Name = "btnTinhToanTonKho"
        Me.btnTinhToanTonKho.Size = New System.Drawing.Size(256, 22)
        Me.btnTinhToanTonKho.Text = "Tính toán lại tồn kho đến thời điểm hiện tại"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CKNhậpToolStripMenuItem, Me.CKXuấtToolStripMenuItem})
        Me.ToolStripButton1.Image = Global.PhanMemBanHang.My.Resources.Resources.CaiDat16
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripButton1.Text = "Chỉnh sửa"
        '
        'CKNhậpToolStripMenuItem
        '
        Me.CKNhậpToolStripMenuItem.Name = "CKNhậpToolStripMenuItem"
        Me.CKNhậpToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CKNhậpToolStripMenuItem.Text = "CK Nhập"
        '
        'CKXuấtToolStripMenuItem
        '
        Me.CKXuấtToolStripMenuItem.Name = "CKXuấtToolStripMenuItem"
        Me.CKXuấtToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CKXuấtToolStripMenuItem.Text = "CK Xuất"
        '
        'ctrlThemSuaXoaSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctrlThemSuaXoaSanPham"
        Me.Size = New System.Drawing.Size(1465, 370)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents CtrlDGVLoaiSanPham1 As PhanMemBanHang.ctrlDGVLoaiSanPham
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThemLoaiSanPham As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSuaLoaiSanPham As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoaLoaiSanPham As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCapNhatLoaiSanPham As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThemSanPham As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSuaSanPham As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoaSanPham As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCapNhatSanPham As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuayLai As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLoaiTimKiemSanPham As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents HủyTìmKiếmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTimKiemSanPham As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnInMaVachSanPham As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTimKiemLoai As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnChonTatCa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnChiTietNhapXuat As ToolStripButton
    Friend WithEvents CtrlDGVSanPham1 As ctrlDGVSanPham
    Friend WithEvents btnTinhToanTonKho As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripDropDownButton
    Friend WithEvents CKNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CKXuấtToolStripMenuItem As ToolStripMenuItem
End Class
