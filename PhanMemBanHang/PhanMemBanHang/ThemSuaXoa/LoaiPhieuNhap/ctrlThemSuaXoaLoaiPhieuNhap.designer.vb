<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThemSuaXoaLoaiPhieuNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlThemSuaXoaLoaiPhieuNhap))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnThem = New System.Windows.Forms.ToolStripButton()
        Me.btnSua = New System.Windows.Forms.ToolStripButton()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        Me.btnCapNhat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuayLai = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLoaiTimKiem = New System.Windows.Forms.ToolStripSplitButton()
        Me.txtTimKiem = New System.Windows.Forms.ToolStripTextBox()
        Me.CtrlDGVLoaiPhieuNhap1 = New PhanMemBanHang.ctrlDGVLoaiPhieuNhap()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThem, Me.btnSua, Me.btnXoa, Me.btnCapNhat, Me.ToolStripSeparator5, Me.btnQuayLai, Me.ToolStripSeparator6, Me.btnLoaiTimKiem, Me.txtTimKiem})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(936, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnThem
        '
        Me.btnThem.Enabled = False
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(58, 22)
        Me.btnThem.Text = "&Thêm"
        '
        'btnSua
        '
        Me.btnSua.Enabled = False
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(46, 22)
        Me.btnSua.Text = "&Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Enabled = False
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(47, 22)
        Me.btnXoa.Text = "&Xóa"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCapNhat.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(77, 22)
        Me.btnCapNhat.Text = "&Cập Nhật"
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
        'btnLoaiTimKiem
        '
        Me.btnLoaiTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnLoaiTimKiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLoaiTimKiem.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnLoaiTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLoaiTimKiem.Name = "btnLoaiTimKiem"
        Me.btnLoaiTimKiem.Size = New System.Drawing.Size(32, 22)
        Me.btnLoaiTimKiem.Text = "Chọn Loại Tìm Kiếm"
        Me.btnLoaiTimKiem.ToolTipText = "Tìm Kiếm"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(150, 25)
        '
        'CtrlDGVLoaiPhieuNhap1
        '
        Me.CtrlDGVLoaiPhieuNhap1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlDGVLoaiPhieuNhap1.Location = New System.Drawing.Point(0, 25)
        Me.CtrlDGVLoaiPhieuNhap1.Name = "CtrlDGVLoaiPhieuNhap1"
        Me.CtrlDGVLoaiPhieuNhap1.Size = New System.Drawing.Size(936, 404)
        Me.CtrlDGVLoaiPhieuNhap1.TabIndex = 6
        '
        'ctrlThemSuaXoaLoaiPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CtrlDGVLoaiPhieuNhap1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlThemSuaXoaLoaiPhieuNhap"
        Me.Size = New System.Drawing.Size(936, 429)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSua As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnXoa As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCapNhat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuayLai As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLoaiTimKiem As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents txtTimKiem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CtrlDGVLoaiPhieuNhap1 As PhanMemBanHang.ctrlDGVLoaiPhieuNhap

End Class
