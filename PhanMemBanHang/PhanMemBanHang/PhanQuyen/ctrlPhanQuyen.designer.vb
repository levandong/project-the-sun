<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPhanQuyen
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
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.lnkAdministrator = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.pnlAdmin = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnXoaPhanQuyen = New System.Windows.Forms.Button()
        Me.btnXoaQuyen = New System.Windows.Forms.Button()
        Me.btnLoadTreeviewFromControl = New System.Windows.Forms.Button()
        Me.btnTaoQuyenChoNhanVien = New System.Windows.Forms.Button()
        Me.btnSaveDatabase = New System.Windows.Forms.Button()
        Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbNhanVienDuocSaoChep = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatNhanVienSaoChep = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnSaoChep = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.btnXemKetQua = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCapNhatQuyenChoNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnLuu = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnCapNhatNhanVien = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonHeader3 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.tvwQuyenRibbon = New System.Windows.Forms.TreeView()
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.btnChonTatCa = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnChonNhanhQuyenRibbon = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.CtrlRibbon1 = New PhanMemBanHang.ctrlRibbon()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.pnlAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdmin.SuspendLayout()
        CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox3.Panel.SuspendLayout()
        Me.KryptonGroupBox3.SuspendLayout()
        CType(Me.cmbNhanVienDuocSaoChep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox2.Panel.SuspendLayout()
        Me.KryptonGroupBox2.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 115)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.lnkAdministrator)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.pnlAdmin)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonGroupBox3)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonGroupBox2)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonHeader3)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.tvwQuyenRibbon)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeader1)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(920, 438)
        Me.KryptonSplitContainer1.SplitterDistance = 344
        Me.KryptonSplitContainer1.TabIndex = 29
        '
        'lnkAdministrator
        '
        Me.lnkAdministrator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkAdministrator.Location = New System.Drawing.Point(3, 365)
        Me.lnkAdministrator.Name = "lnkAdministrator"
        Me.lnkAdministrator.Size = New System.Drawing.Size(85, 20)
        Me.lnkAdministrator.TabIndex = 41
        Me.lnkAdministrator.Values.Text = "Administrator"
        '
        'pnlAdmin
        '
        Me.pnlAdmin.Controls.Add(Me.btnXoaPhanQuyen)
        Me.pnlAdmin.Controls.Add(Me.btnXoaQuyen)
        Me.pnlAdmin.Controls.Add(Me.btnLoadTreeviewFromControl)
        Me.pnlAdmin.Controls.Add(Me.btnTaoQuyenChoNhanVien)
        Me.pnlAdmin.Controls.Add(Me.btnSaveDatabase)
        Me.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAdmin.Location = New System.Drawing.Point(0, 391)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(344, 47)
        Me.pnlAdmin.TabIndex = 40
        Me.pnlAdmin.Visible = False
        '
        'btnXoaPhanQuyen
        '
        Me.btnXoaPhanQuyen.Location = New System.Drawing.Point(287, 3)
        Me.btnXoaPhanQuyen.Name = "btnXoaPhanQuyen"
        Me.btnXoaPhanQuyen.Size = New System.Drawing.Size(54, 39)
        Me.btnXoaPhanQuyen.TabIndex = 22
        Me.btnXoaPhanQuyen.Text = "Xóa P.quyền"
        Me.btnXoaPhanQuyen.UseVisualStyleBackColor = True
        '
        'btnXoaQuyen
        '
        Me.btnXoaQuyen.Location = New System.Drawing.Point(214, 3)
        Me.btnXoaQuyen.Name = "btnXoaQuyen"
        Me.btnXoaQuyen.Size = New System.Drawing.Size(71, 39)
        Me.btnXoaQuyen.TabIndex = 21
        Me.btnXoaQuyen.Text = "Xóa quyền"
        Me.btnXoaQuyen.UseVisualStyleBackColor = True
        '
        'btnLoadTreeviewFromControl
        '
        Me.btnLoadTreeviewFromControl.Location = New System.Drawing.Point(3, 3)
        Me.btnLoadTreeviewFromControl.Name = "btnLoadTreeviewFromControl"
        Me.btnLoadTreeviewFromControl.Size = New System.Drawing.Size(61, 39)
        Me.btnLoadTreeviewFromControl.TabIndex = 17
        Me.btnLoadTreeviewFromControl.Text = "Load TreeView"
        Me.btnLoadTreeviewFromControl.UseVisualStyleBackColor = True
        '
        'btnTaoQuyenChoNhanVien
        '
        Me.btnTaoQuyenChoNhanVien.Location = New System.Drawing.Point(140, 3)
        Me.btnTaoQuyenChoNhanVien.Name = "btnTaoQuyenChoNhanVien"
        Me.btnTaoQuyenChoNhanVien.Size = New System.Drawing.Size(71, 39)
        Me.btnTaoQuyenChoNhanVien.TabIndex = 20
        Me.btnTaoQuyenChoNhanVien.Text = "Tạo quyền cho nhân viên"
        Me.btnTaoQuyenChoNhanVien.UseVisualStyleBackColor = True
        '
        'btnSaveDatabase
        '
        Me.btnSaveDatabase.Location = New System.Drawing.Point(65, 3)
        Me.btnSaveDatabase.Name = "btnSaveDatabase"
        Me.btnSaveDatabase.Size = New System.Drawing.Size(74, 39)
        Me.btnSaveDatabase.TabIndex = 18
        Me.btnSaveDatabase.Text = "Save Database"
        Me.btnSaveDatabase.UseVisualStyleBackColor = True
        '
        'KryptonGroupBox3
        '
        Me.KryptonGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroupBox3.Location = New System.Drawing.Point(0, 198)
        Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
        '
        'KryptonGroupBox3.Panel
        '
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.cmbNhanVienDuocSaoChep)
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.btnSaoChep)
        Me.KryptonGroupBox3.Size = New System.Drawing.Size(344, 93)
        Me.KryptonGroupBox3.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top
        Me.KryptonGroupBox3.TabIndex = 39
        Me.KryptonGroupBox3.Values.Heading = "Sao chép quyền"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(19, 7)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(33, 20)
        Me.KryptonLabel3.TabIndex = 38
        Me.KryptonLabel3.Values.Text = "Đến"
        '
        'cmbNhanVienDuocSaoChep
        '
        Me.cmbNhanVienDuocSaoChep.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatNhanVienSaoChep})
        Me.cmbNhanVienDuocSaoChep.DisplayMember = "HienThiDayDu"
        Me.cmbNhanVienDuocSaoChep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhanVienDuocSaoChep.DropDownWidth = 219
        Me.cmbNhanVienDuocSaoChep.Location = New System.Drawing.Point(72, 3)
        Me.cmbNhanVienDuocSaoChep.Name = "cmbNhanVienDuocSaoChep"
        Me.cmbNhanVienDuocSaoChep.Size = New System.Drawing.Size(259, 24)
        Me.cmbNhanVienDuocSaoChep.TabIndex = 37
        '
        'btnCapNhatNhanVienSaoChep
        '
        Me.btnCapNhatNhanVienSaoChep.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatNhanVienSaoChep.UniqueName = "711E8D1A890A41B4C5A8276DF3252F09"
        '
        'btnSaoChep
        '
        Me.btnSaoChep.Location = New System.Drawing.Point(201, 33)
        Me.btnSaoChep.Name = "btnSaoChep"
        Me.btnSaoChep.Size = New System.Drawing.Size(130, 31)
        Me.btnSaoChep.TabIndex = 36
        Me.btnSaoChep.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Copy
        Me.btnSaoChep.Values.Text = "SAO CHÉP"
        '
        'KryptonGroupBox2
        '
        Me.KryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroupBox2.Location = New System.Drawing.Point(0, 101)
        Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
        '
        'KryptonGroupBox2.Panel
        '
        Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnXemKetQua)
        Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnCapNhatQuyenChoNhanVien)
        Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnLuu)
        Me.KryptonGroupBox2.Size = New System.Drawing.Size(344, 97)
        Me.KryptonGroupBox2.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top
        Me.KryptonGroupBox2.TabIndex = 38
        Me.KryptonGroupBox2.Values.Heading = "Phân quyền"
        '
        'btnXemKetQua
        '
        Me.btnXemKetQua.Location = New System.Drawing.Point(72, 40)
        Me.btnXemKetQua.Name = "btnXemKetQua"
        Me.btnXemKetQua.Size = New System.Drawing.Size(259, 31)
        Me.btnXemKetQua.TabIndex = 37
        Me.btnXemKetQua.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.TuyChinhTimKiem16
        Me.btnXemKetQua.Values.Text = "Xem kết quả"
        '
        'btnCapNhatQuyenChoNhanVien
        '
        Me.btnCapNhatQuyenChoNhanVien.Location = New System.Drawing.Point(72, 3)
        Me.btnCapNhatQuyenChoNhanVien.Name = "btnCapNhatQuyenChoNhanVien"
        Me.btnCapNhatQuyenChoNhanVien.Size = New System.Drawing.Size(123, 31)
        Me.btnCapNhatQuyenChoNhanVien.TabIndex = 32
        Me.btnCapNhatQuyenChoNhanVien.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatQuyenChoNhanVien.Values.Text = "Cập nhật quyền"
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(201, 3)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(130, 31)
        Me.btnLuu.TabIndex = 36
        Me.btnLuu.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Luu16
        Me.btnLuu.Values.Text = "LƯU LẠI"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 22)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbNhanVien)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(344, 79)
        Me.KryptonGroupBox1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top
        Me.KryptonGroupBox1.TabIndex = 37
        Me.KryptonGroupBox1.Values.Heading = "Nhân viên"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 19)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(68, 20)
        Me.KryptonLabel2.TabIndex = 35
        Me.KryptonLabel2.Values.Text = "Nhân viên:"
        '
        'cmbNhanVien
        '
        Me.cmbNhanVien.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatNhanVien})
        Me.cmbNhanVien.DisplayMember = "HienThiDayDu"
        Me.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhanVien.DropDownWidth = 219
        Me.cmbNhanVien.Location = New System.Drawing.Point(72, 17)
        Me.cmbNhanVien.Name = "cmbNhanVien"
        Me.cmbNhanVien.Size = New System.Drawing.Size(259, 24)
        Me.cmbNhanVien.TabIndex = 33
        '
        'btnCapNhatNhanVien
        '
        Me.btnCapNhatNhanVien.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatNhanVien.UniqueName = "711E8D1A890A41B4C5A8276DF3252F09"
        '
        'KryptonHeader3
        '
        Me.KryptonHeader3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader3.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader3.Name = "KryptonHeader3"
        Me.KryptonHeader3.Size = New System.Drawing.Size(344, 22)
        Me.KryptonHeader3.TabIndex = 30
        Me.KryptonHeader3.Values.Description = ""
        Me.KryptonHeader3.Values.Heading = "Bảng điều khiển"
        Me.KryptonHeader3.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Manager
        '
        'tvwQuyenRibbon
        '
        Me.tvwQuyenRibbon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwQuyenRibbon.Location = New System.Drawing.Point(0, 28)
        Me.tvwQuyenRibbon.Name = "tvwQuyenRibbon"
        Me.tvwQuyenRibbon.Size = New System.Drawing.Size(571, 410)
        Me.tvwQuyenRibbon.TabIndex = 15
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnChonTatCa, Me.btnChonNhanhQuyenRibbon})
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(571, 28)
        Me.KryptonHeader1.TabIndex = 16
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Quyền Ribbon"
        Me.KryptonHeader1.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.PhanLoai16
        '
        'btnChonTatCa
        '
        Me.btnChonTatCa.Image = Global.PhanMemBanHang.My.Resources.Resources.Checked
        Me.btnChonTatCa.Text = "Chọn tất cả"
        Me.btnChonTatCa.UniqueName = "DDD529C8A4FC41625BA242C37178590C"
        '
        'btnChonNhanhQuyenRibbon
        '
        Me.btnChonNhanhQuyenRibbon.Image = Global.PhanMemBanHang.My.Resources.Resources.ReNhanh16
        Me.btnChonNhanhQuyenRibbon.Text = "Chọn nhánh"
        Me.btnChonNhanhQuyenRibbon.UniqueName = "5F72BBF48C5C49C9208F16A39D0D5FD5"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.CtrlRibbon1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(920, 115)
        Me.KryptonPanel1.TabIndex = 39
        '
        'CtrlRibbon1
        '
        Me.CtrlRibbon1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlRibbon1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlRibbon1.Name = "CtrlRibbon1"
        Me.CtrlRibbon1.Size = New System.Drawing.Size(920, 115)
        Me.CtrlRibbon1.TabIndex = 16
        Me.CtrlRibbon1.Tag = ""
        '
        'ctrlPhanQuyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlPhanQuyen"
        Me.Size = New System.Drawing.Size(920, 553)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.pnlAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdmin.ResumeLayout(False)
        CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox3.Panel.ResumeLayout(False)
        Me.KryptonGroupBox3.Panel.PerformLayout()
        CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox3.ResumeLayout(False)
        CType(Me.cmbNhanVienDuocSaoChep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox2.Panel.ResumeLayout(False)
        CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox2.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlRibbon1 As PhanMemBanHang.ctrlRibbon
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents tvwQuyenRibbon As System.Windows.Forms.TreeView
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader3 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbNhanVien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatQuyenChoNhanVien As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnLuu As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSaveDatabase As System.Windows.Forms.Button
    Friend WithEvents btnTaoQuyenChoNhanVien As System.Windows.Forms.Button
    Friend WithEvents btnLoadTreeviewFromControl As System.Windows.Forms.Button
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents btnCapNhatNhanVien As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnChonTatCa As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnChonNhanhQuyenRibbon As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnXemKetQua As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonGroupBox3 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents btnSaoChep As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbNhanVienDuocSaoChep As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnCapNhatNhanVienSaoChep As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lnkAdministrator As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents pnlAdmin As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnXoaQuyen As System.Windows.Forms.Button
    Friend WithEvents btnXoaPhanQuyen As System.Windows.Forms.Button

End Class
