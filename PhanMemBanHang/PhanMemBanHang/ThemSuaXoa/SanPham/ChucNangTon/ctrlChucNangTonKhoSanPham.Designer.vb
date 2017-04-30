<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlChucNangTonKhoSanPham
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
        Me.rdoSoLuongTheo = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rdoSoLuongNhoHonTonMin = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.rdoTatCa = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.txtTuKhoa = New PhanMemBanHang.clsTextbox()
        Me.nudSoLuong = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.rdoLonHon = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.CtrlDGVLoaiSanPham1 = New PhanMemBanHang.ctrlDGVLoaiSanPham()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnChonTatCa = New System.Windows.Forms.ToolStripButton()
        Me.txtTimKiemLoai = New System.Windows.Forms.ToolStripTextBox()
        Me.CtrlDGVSanPham1 = New PhanMemBanHang.ctrlDGVSanPham()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel2.SuspendLayout()
        Me.KryptonSplitContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoSoLuongTheo
        '
        Me.rdoSoLuongTheo.Location = New System.Drawing.Point(38, 28)
        Me.rdoSoLuongTheo.Name = "rdoSoLuongTheo"
        Me.rdoSoLuongTheo.Size = New System.Drawing.Size(124, 20)
        Me.rdoSoLuongTheo.TabIndex = 13
        Me.rdoSoLuongTheo.Values.Text = "Số lượng nhỏ hơn: "
        '
        'rdoSoLuongNhoHonTonMin
        '
        Me.rdoSoLuongNhoHonTonMin.Checked = True
        Me.rdoSoLuongNhoHonTonMin.Location = New System.Drawing.Point(38, 3)
        Me.rdoSoLuongNhoHonTonMin.Name = "rdoSoLuongNhoHonTonMin"
        Me.rdoSoLuongNhoHonTonMin.Size = New System.Drawing.Size(170, 20)
        Me.rdoSoLuongNhoHonTonMin.TabIndex = 12
        Me.rdoSoLuongNhoHonTonMin.Values.Text = "Số lượng nhỏ hơn tồn MIN"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.btnTimKiem.Location = New System.Drawing.Point(485, 25)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(87, 50)
        Me.btnTimKiem.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnTimKiem.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnTimKiem.TabIndex = 1
        Me.btnTimKiem.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem32
        Me.btnTimKiem.Values.Text = ""
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.IsSplitterFixed = True
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.rdoTatCa)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtTuKhoa)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.nudSoLuong)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.rdoSoLuongTheo)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.rdoSoLuongNhoHonTonMin)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.rdoLonHon)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnTimKiem)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonSplitContainer2)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(766, 417)
        Me.KryptonSplitContainer1.SplitterDistance = 100
        Me.KryptonSplitContainer1.SplitterWidth = 2
        Me.KryptonSplitContainer1.TabIndex = 12
        '
        'rdoTatCa
        '
        Me.rdoTatCa.Location = New System.Drawing.Point(38, 76)
        Me.rdoTatCa.Name = "rdoTatCa"
        Me.rdoTatCa.Size = New System.Drawing.Size(55, 20)
        Me.rdoTatCa.TabIndex = 17
        Me.rdoTatCa.Values.Text = "Tất cả"
        '
        'txtTuKhoa
        '
        Me.txtTuKhoa.Location = New System.Drawing.Point(277, 38)
        Me.txtTuKhoa.Name = "txtTuKhoa"
        Me.txtTuKhoa.Size = New System.Drawing.Size(202, 24)
        Me.txtTuKhoa.StateCommon.Content.Color1 = System.Drawing.Color.Gray
        Me.txtTuKhoa.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtTuKhoa.TabIndex = 15
        Me.txtTuKhoa.Text = "<Từ khóa>"
        Me.txtTuKhoa.TextGoiY = "<Từ khóa>"
        '
        'nudSoLuong
        '
        Me.nudSoLuong.Enabled = False
        Me.nudSoLuong.Location = New System.Drawing.Point(168, 38)
        Me.nudSoLuong.Name = "nudSoLuong"
        Me.nudSoLuong.Size = New System.Drawing.Size(72, 25)
        Me.nudSoLuong.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSoLuong.TabIndex = 14
        Me.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdoLonHon
        '
        Me.rdoLonHon.Location = New System.Drawing.Point(38, 52)
        Me.rdoLonHon.Name = "rdoLonHon"
        Me.rdoLonHon.Size = New System.Drawing.Size(120, 20)
        Me.rdoLonHon.TabIndex = 12
        Me.rdoLonHon.Values.Text = "Số lượng lớn hơn:"
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        '
        'KryptonSplitContainer2.Panel1
        '
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.CtrlDGVLoaiSanPham1)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'KryptonSplitContainer2.Panel2
        '
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.CtrlDGVSanPham1)
        Me.KryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(766, 315)
        Me.KryptonSplitContainer2.SplitterDistance = 300
        Me.KryptonSplitContainer2.TabIndex = 12
        '
        'CtrlDGVLoaiSanPham1
        '
        Me.CtrlDGVLoaiSanPham1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlDGVLoaiSanPham1.Location = New System.Drawing.Point(0, 25)
        Me.CtrlDGVLoaiSanPham1.Name = "CtrlDGVLoaiSanPham1"
        Me.CtrlDGVLoaiSanPham1.Size = New System.Drawing.Size(300, 290)
        Me.CtrlDGVLoaiSanPham1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChonTatCa, Me.txtTimKiemLoai})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(300, 25)
        Me.ToolStrip1.TabIndex = 1
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
        Me.CtrlDGVSanPham1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlDGVSanPham1.Name = "CtrlDGVSanPham1"
        Me.CtrlDGVSanPham1.Size = New System.Drawing.Size(461, 315)
        Me.CtrlDGVSanPham1.TabIndex = 11
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(766, 417)
        Me.KryptonPanel1.TabIndex = 1
        '
        'ctrlChucNangTonKhoSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlChucNangTonKhoSanPham"
        Me.Size = New System.Drawing.Size(766, 417)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer2.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdoSoLuongTheo As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rdoSoLuongNhoHonTonMin As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents nudSoLuong As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents CtrlDGVSanPham1 As PhanMemBanHang.ctrlDGVSanPham
    Friend WithEvents rdoLonHon As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents txtTuKhoa As PhanMemBanHang.clsTextbox
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnChonTatCa As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTimKiemLoai As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CtrlDGVLoaiSanPham1 As PhanMemBanHang.ctrlDGVLoaiSanPham
    Friend WithEvents rdoTatCa As ComponentFactory.Krypton.Toolkit.KryptonRadioButton

End Class
