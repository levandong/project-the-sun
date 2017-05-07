<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThayDoiMatKhau
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtMKNhapLai = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtMKMoi = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtMKHienTai = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTaiKhoan = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblThongBao = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnLuuLai = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnDong = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.txtMKNhapLai)
        Me.KryptonPanel1.Controls.Add(Me.txtMKMoi)
        Me.KryptonPanel1.Controls.Add(Me.txtMKHienTai)
        Me.KryptonPanel1.Controls.Add(Me.lblTaiKhoan)
        Me.KryptonPanel1.Controls.Add(Me.lblThongBao)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.btnLuuLai)
        Me.KryptonPanel1.Controls.Add(Me.btnDong)
        Me.KryptonPanel1.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(384, 282)
        Me.KryptonPanel1.TabIndex = 0
        '
        'txtMKNhapLai
        '
        Me.txtMKNhapLai.Location = New System.Drawing.Point(123, 171)
        Me.txtMKNhapLai.Name = "txtMKNhapLai"
        Me.txtMKNhapLai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtMKNhapLai.Size = New System.Drawing.Size(254, 23)
        Me.txtMKNhapLai.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMKNhapLai.TabIndex = 2
        Me.txtMKNhapLai.UseSystemPasswordChar = True
        '
        'txtMKMoi
        '
        Me.txtMKMoi.Location = New System.Drawing.Point(123, 145)
        Me.txtMKMoi.Name = "txtMKMoi"
        Me.txtMKMoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtMKMoi.Size = New System.Drawing.Size(254, 23)
        Me.txtMKMoi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMKMoi.TabIndex = 1
        Me.txtMKMoi.UseSystemPasswordChar = True
        '
        'txtMKHienTai
        '
        Me.txtMKHienTai.Location = New System.Drawing.Point(123, 119)
        Me.txtMKHienTai.Name = "txtMKHienTai"
        Me.txtMKHienTai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtMKHienTai.Size = New System.Drawing.Size(254, 23)
        Me.txtMKHienTai.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMKHienTai.TabIndex = 0
        Me.txtMKHienTai.UseSystemPasswordChar = True
        '
        'lblTaiKhoan
        '
        Me.lblTaiKhoan.Location = New System.Drawing.Point(123, 82)
        Me.lblTaiKhoan.Name = "lblTaiKhoan"
        Me.lblTaiKhoan.Size = New System.Drawing.Size(21, 23)
        Me.lblTaiKhoan.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaiKhoan.TabIndex = 7
        Me.lblTaiKhoan.Values.Text = "#"
        '
        'lblThongBao
        '
        Me.lblThongBao.Location = New System.Drawing.Point(123, 205)
        Me.lblThongBao.Name = "lblThongBao"
        Me.lblThongBao.Size = New System.Drawing.Size(25, 19)
        Me.lblThongBao.StateCommon.ShortText.Color1 = System.Drawing.Color.Red
        Me.lblThongBao.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThongBao.TabIndex = 3
        Me.lblThongBao.Values.Text = "(*) "
        Me.lblThongBao.Visible = False
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(8, 176)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(122, 19)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 10
        Me.KryptonLabel5.Values.Text = "Nhập lại mật khẩu:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(8, 150)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(95, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 9
        Me.KryptonLabel4.Values.Text = "Mật khẩu mới:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(8, 124)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(116, 19)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 8
        Me.KryptonLabel3.Values.Text = "Mật khẩu hiện tại:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(8, 86)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(73, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 6
        Me.KryptonLabel2.Values.Text = "Tài khoản:"
        '
        'btnLuuLai
        '
        Me.btnLuuLai.Location = New System.Drawing.Point(275, 230)
        Me.btnLuuLai.Name = "btnLuuLai"
        Me.btnLuuLai.Size = New System.Drawing.Size(102, 40)
        Me.btnLuuLai.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuuLai.TabIndex = 4
        Me.btnLuuLai.Values.Text = "LƯU [F2]"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(167, 230)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(102, 40)
        Me.btnDong.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.TabIndex = 5
        Me.btnDong.Values.Text = "ĐÓNG [F3]"
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(384, 64)
        Me.KryptonPanel2.StateCommon.Color1 = System.Drawing.Color.PowderBlue
        Me.KryptonPanel2.StateCommon.Image = Global.PhanMemBanHang.My.Resources.Resources.Matkhau
        Me.KryptonPanel2.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft
        Me.KryptonPanel2.TabIndex = 11
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonLabel1.Location = New System.Drawing.Point(123, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(205, 29)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "THAY ĐỔI MẬT KHẨU"
        '
        'frmThayDoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 282)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmThayDoiMatKhau"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thay đổi mật khẩu"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnLuuLai As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnDong As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTaiKhoan As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMKNhapLai As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMKMoi As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMKHienTai As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblThongBao As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
