<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlSaoLuuDuLieu
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnLuu = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonGroupBox4 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkXoa30Ngay = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkXoa10Ngay = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.txtDuongDan = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnOpenFolder = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.chkSaoLuuKhiDangNhap = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.cmbThuSaoLuu = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.chkSaoLuuKhiTat = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkSaoLuuHangTuan = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox4.Panel.SuspendLayout()
        Me.KryptonGroupBox4.SuspendLayout()
        CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox3.Panel.SuspendLayout()
        Me.KryptonGroupBox3.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        CType(Me.cmbThuSaoLuu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnLuu)
        Me.KryptonPanel1.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonPanel1.Controls.Add(Me.KryptonGroupBox3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonGroupBox4)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(582, 225)
        Me.KryptonPanel1.TabIndex = 0
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(466, 183)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(108, 37)
        Me.btnLuu.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnLuu.StateCommon.Border.Rounding = 0
        Me.btnLuu.StateCommon.Border.Width = 1
        Me.btnLuu.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.TabIndex = 2
        Me.btnLuu.Values.Text = "Lưu"
        '
        'KryptonGroupBox4
        '
        Me.KryptonGroupBox4.Location = New System.Drawing.Point(299, 3)
        Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
        '
        'KryptonGroupBox4.Panel
        '
        Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox4.Panel.Controls.Add(Me.chkXoa30Ngay)
        Me.KryptonGroupBox4.Panel.Controls.Add(Me.chkXoa10Ngay)
        Me.KryptonGroupBox4.Size = New System.Drawing.Size(275, 178)
        Me.KryptonGroupBox4.TabIndex = 6
        Me.KryptonGroupBox4.Values.Heading = "Định kỳ xoá dữ liệu"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(51, 54)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(223, 68)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Values.Text = "* Lưu ý" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    - Luôn giữ lại 05 phiên bản gần nhất" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    - Xoá khi " & _
    "mở chương trình"
        '
        'chkXoa30Ngay
        '
        Me.chkXoa30Ngay.Location = New System.Drawing.Point(16, 29)
        Me.chkXoa30Ngay.Name = "chkXoa30Ngay"
        Me.chkXoa30Ngay.Size = New System.Drawing.Size(197, 20)
        Me.chkXoa30Ngay.TabIndex = 1
        Me.chkXoa30Ngay.Values.Text = "Xoá các phiên bản cách 1 tháng"
        '
        'chkXoa10Ngay
        '
        Me.chkXoa10Ngay.Location = New System.Drawing.Point(16, 3)
        Me.chkXoa10Ngay.Name = "chkXoa10Ngay"
        Me.chkXoa10Ngay.Size = New System.Drawing.Size(198, 20)
        Me.chkXoa10Ngay.TabIndex = 0
        Me.chkXoa10Ngay.Values.Text = "Xoá các phiên bản cách 10 ngày"
        '
        'KryptonGroupBox3
        '
        Me.KryptonGroupBox3.Location = New System.Drawing.Point(3, 119)
        Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
        '
        'KryptonGroupBox3.Panel
        '
        Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDuongDan)
        Me.KryptonGroupBox3.Size = New System.Drawing.Size(290, 62)
        Me.KryptonGroupBox3.TabIndex = 5
        Me.KryptonGroupBox3.Values.Heading = "Vị trí sao lưu"
        '
        'txtDuongDan
        '
        Me.txtDuongDan.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnOpenFolder})
        Me.txtDuongDan.Location = New System.Drawing.Point(13, 6)
        Me.txtDuongDan.Name = "txtDuongDan"
        Me.txtDuongDan.ReadOnly = True
        Me.txtDuongDan.Size = New System.Drawing.Size(265, 26)
        Me.txtDuongDan.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuongDan.TabIndex = 15
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Text = "..."
        Me.btnOpenFolder.UniqueName = "D388E8DA2AD84796E1BEBB52A0D07E58"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkSaoLuuKhiDangNhap)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbThuSaoLuu)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkSaoLuuKhiTat)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkSaoLuuHangTuan)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(290, 110)
        Me.KryptonGroupBox1.TabIndex = 4
        Me.KryptonGroupBox1.Values.Heading = "Thời điểm sao lưu"
        '
        'chkSaoLuuKhiDangNhap
        '
        Me.chkSaoLuuKhiDangNhap.Location = New System.Drawing.Point(16, 3)
        Me.chkSaoLuuKhiDangNhap.Name = "chkSaoLuuKhiDangNhap"
        Me.chkSaoLuuKhiDangNhap.Size = New System.Drawing.Size(217, 20)
        Me.chkSaoLuuKhiDangNhap.TabIndex = 0
        Me.chkSaoLuuKhiDangNhap.Values.Text = "Sao lưu khi khởi động chương trình"
        '
        'cmbThuSaoLuu
        '
        Me.cmbThuSaoLuu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThuSaoLuu.DropDownWidth = 91
        Me.cmbThuSaoLuu.Items.AddRange(New Object() {"Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật"})
        Me.cmbThuSaoLuu.Location = New System.Drawing.Point(190, 54)
        Me.cmbThuSaoLuu.Name = "cmbThuSaoLuu"
        Me.cmbThuSaoLuu.Size = New System.Drawing.Size(91, 21)
        Me.cmbThuSaoLuu.TabIndex = 3
        '
        'chkSaoLuuKhiTat
        '
        Me.chkSaoLuuKhiTat.Location = New System.Drawing.Point(16, 29)
        Me.chkSaoLuuKhiTat.Name = "chkSaoLuuKhiTat"
        Me.chkSaoLuuKhiTat.Size = New System.Drawing.Size(176, 20)
        Me.chkSaoLuuKhiTat.TabIndex = 1
        Me.chkSaoLuuKhiTat.Values.Text = "Sao lưu khi tắt chương trình"
        '
        'chkSaoLuuHangTuan
        '
        Me.chkSaoLuuHangTuan.Location = New System.Drawing.Point(16, 55)
        Me.chkSaoLuuHangTuan.Name = "chkSaoLuuHangTuan"
        Me.chkSaoLuuHangTuan.Size = New System.Drawing.Size(168, 20)
        Me.chkSaoLuuHangTuan.TabIndex = 2
        Me.chkSaoLuuHangTuan.Values.Text = "Sao lưu hàng tuần vào thứ"
        '
        'ctrlSaoLuuDuLieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlSaoLuuDuLieu"
        Me.Size = New System.Drawing.Size(582, 225)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox4.Panel.ResumeLayout(False)
        Me.KryptonGroupBox4.Panel.PerformLayout()
        CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox4.ResumeLayout(False)
        CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox3.Panel.ResumeLayout(False)
        Me.KryptonGroupBox3.Panel.PerformLayout()
        CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox3.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        CType(Me.cmbThuSaoLuu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnLuu As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents chkSaoLuuKhiDangNhap As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cmbThuSaoLuu As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents chkSaoLuuKhiTat As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkSaoLuuHangTuan As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonGroupBox3 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonGroupBox4 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkXoa30Ngay As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkXoa10Ngay As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtDuongDan As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnOpenFolder As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
