<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaNhanVien
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
        Me.btnDong = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnLuu = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.chkToanQuyen = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkHopLe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtChucVu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSoDienThoai = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtHoTen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMatKhau = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnXemMatKhau = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTenDangNhap = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtEmail = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbCapBat = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.cmbCapBat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(291, 294)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(90, 30)
        Me.btnDong.TabIndex = 10
        Me.btnDong.Values.Text = "ĐÓNG [F3]"
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(197, 294)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(90, 30)
        Me.btnLuu.TabIndex = 9
        Me.btnLuu.Values.Text = "LƯU [F2]"
        '
        'chkToanQuyen
        '
        Me.chkToanQuyen.Location = New System.Drawing.Point(110, 225)
        Me.chkToanQuyen.Name = "chkToanQuyen"
        Me.chkToanQuyen.Size = New System.Drawing.Size(94, 19)
        Me.chkToanQuyen.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkToanQuyen.TabIndex = 7
        Me.chkToanQuyen.Values.Text = "Toàn quyền"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(3, 225)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(84, 19)
        Me.KryptonLabel7.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 22
        Me.KryptonLabel7.Values.Text = "Toàn Quyền"
        '
        'chkHopLe
        '
        Me.chkHopLe.Location = New System.Drawing.Point(110, 250)
        Me.chkHopLe.Name = "chkHopLe"
        Me.chkHopLe.Size = New System.Drawing.Size(82, 19)
        Me.chkHopLe.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHopLe.TabIndex = 8
        Me.chkHopLe.Values.Text = "Cho phép"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(3, 250)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(109, 19)
        Me.KryptonLabel6.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 21
        Me.KryptonLabel6.Values.Text = "Được đăng nhập"
        '
        'txtChucVu
        '
        Me.txtChucVu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChucVu.Location = New System.Drawing.Point(110, 163)
        Me.txtChucVu.Name = "txtChucVu"
        Me.txtChucVu.Size = New System.Drawing.Size(271, 26)
        Me.txtChucVu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtChucVu.TabIndex = 5
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(3, 165)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(62, 19)
        Me.KryptonLabel5.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 23
        Me.KryptonLabel5.Values.Text = "Chức Vụ"
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoDienThoai.Location = New System.Drawing.Point(110, 99)
        Me.txtSoDienThoai.MaxLength = 100
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(271, 26)
        Me.txtSoDienThoai.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtSoDienThoai.TabIndex = 3
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(3, 101)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel4.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 24
        Me.KryptonLabel4.Values.Text = "Điện Thoại"
        '
        'txtHoTen
        '
        Me.txtHoTen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoTen.Location = New System.Drawing.Point(110, 67)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(271, 26)
        Me.txtHoTen.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHoTen.TabIndex = 2
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 69)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(63, 19)
        Me.KryptonLabel3.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 25
        Me.KryptonLabel3.Values.Text = "Họ Tên *"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMatKhau.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnXemMatKhau})
        Me.txtMatKhau.Location = New System.Drawing.Point(110, 35)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtMatKhau.Size = New System.Drawing.Size(271, 26)
        Me.txtMatKhau.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMatKhau.TabIndex = 1
        Me.txtMatKhau.UseSystemPasswordChar = True
        '
        'btnXemMatKhau
        '
        Me.btnXemMatKhau.Image = Global.PhanMemBanHang.My.Resources.Resources.ConMat16
        Me.btnXemMatKhau.UniqueName = "875978E24BE748DCB087999A599C9E56"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 38)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(77, 19)
        Me.KryptonLabel2.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 26
        Me.KryptonLabel2.Values.Text = "Mật Khẩu *"
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenDangNhap.Location = New System.Drawing.Point(110, 3)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(271, 26)
        Me.txtTenDangNhap.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenDangNhap.TabIndex = 0
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 5)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(114, 19)
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 27
        Me.KryptonLabel1.Values.Text = "Tên Đăng Nhập *"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.txtEmail)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel1.Controls.Add(Me.cmbCapBat)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel1.Controls.Add(Me.btnDong)
        Me.KryptonPanel1.Controls.Add(Me.btnLuu)
        Me.KryptonPanel1.Controls.Add(Me.chkToanQuyen)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.chkHopLe)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.txtChucVu)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.txtSoDienThoai)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.txtHoTen)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.txtMatKhau)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.txtTenDangNhap)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(384, 336)
        Me.KryptonPanel1.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(110, 131)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(271, 26)
        Me.txtEmail.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtEmail.TabIndex = 4
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(3, 133)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel9.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 33
        Me.KryptonLabel9.Values.Text = "Email"
        '
        'cmbCapBat
        '
        Me.cmbCapBat.DropDownWidth = 121
        Me.cmbCapBat.Items.AddRange(New Object() {"Cấp 1", "Cấp 2", "Cấp 3 (Chỉ dành chi người toàn quyền)"})
        Me.cmbCapBat.Location = New System.Drawing.Point(110, 195)
        Me.cmbCapBat.Name = "cmbCapBat"
        Me.cmbCapBat.Size = New System.Drawing.Size(271, 24)
        Me.cmbCapBat.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCapBat.TabIndex = 6
        Me.cmbCapBat.Text = "Cấp 1"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(3, 201)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(61, 19)
        Me.KryptonLabel8.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 30
        Me.KryptonLabel8.Values.Text = "Cấp bậc"
        '
        'frmSuaNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 336)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuaNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sửa thông tin nhân viên"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.cmbCapBat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDong As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnLuu As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents chkToanQuyen As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkHopLe As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtChucVu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSoDienThoai As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtHoTen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMatKhau As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnXemMatKhau As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTenDangNhap As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents cmbCapBat As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmail As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
