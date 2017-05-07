<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaPhieuThu
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
        Me.txtNguoiNhanTien = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnDong = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnThem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.vndSoTien = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.txtTenNguoiNop = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSoPhieu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnLaySoPhieu = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtLyDo = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.txtDiaChi = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.txtChungTuKem = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.dtpNgayThu = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbHinhThucThanhToan = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.cmbHinhThucThanhToan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.cmbHinhThucThanhToan)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel1.Controls.Add(Me.txtNguoiNhanTien)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel1.Controls.Add(Me.btnDong)
        Me.KryptonPanel1.Controls.Add(Me.btnThem)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.vndSoTien)
        Me.KryptonPanel1.Controls.Add(Me.txtTenNguoiNop)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.txtSoPhieu)
        Me.KryptonPanel1.Controls.Add(Me.txtLyDo)
        Me.KryptonPanel1.Controls.Add(Me.txtDiaChi)
        Me.KryptonPanel1.Controls.Add(Me.txtChungTuKem)
        Me.KryptonPanel1.Controls.Add(Me.dtpNgayThu)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(464, 336)
        Me.KryptonPanel1.TabIndex = 0
        '
        'txtNguoiNhanTien
        '
        Me.txtNguoiNhanTien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNguoiNhanTien.Location = New System.Drawing.Point(129, 86)
        Me.txtNguoiNhanTien.Name = "txtNguoiNhanTien"
        Me.txtNguoiNhanTien.Size = New System.Drawing.Size(332, 23)
        Me.txtNguoiNhanTien.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNguoiNhanTien.TabIndex = 3
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(3, 88)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(111, 19)
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 16
        Me.KryptonLabel9.Values.Text = "Người Nhận Tiền"
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Location = New System.Drawing.Point(375, 294)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(86, 37)
        Me.btnDong.TabIndex = 10
        Me.btnDong.Values.Text = "ĐÓNG [F3]"
        '
        'btnThem
        '
        Me.btnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThem.Location = New System.Drawing.Point(288, 294)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(81, 37)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Values.Text = "LƯU [F2]"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(3, 267)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(72, 19)
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 11
        Me.KryptonLabel7.Values.Text = "Kèm Theo"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(3, 213)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(46, 19)
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 12
        Me.KryptonLabel6.Values.Text = "Lý Do"
        '
        'vndSoTien
        '
        Me.vndSoTien.Location = New System.Drawing.Point(129, 188)
        Me.vndSoTien.Name = "vndSoTien"
        Me.vndSoTien.Size = New System.Drawing.Size(332, 24)
        Me.vndSoTien.StateCommon.Content.Color1 = System.Drawing.Color.Red
        Me.vndSoTien.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vndSoTien.TabIndex = 6
        Me.vndSoTien.Tag = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndSoTien.Text = "0"
        Me.vndSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vndSoTien.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtTenNguoiNop
        '
        Me.txtTenNguoiNop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenNguoiNop.Location = New System.Drawing.Point(129, 111)
        Me.txtTenNguoiNop.Name = "txtTenNguoiNop"
        Me.txtTenNguoiNop.Size = New System.Drawing.Size(332, 23)
        Me.txtTenNguoiNop.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenNguoiNop.TabIndex = 4
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(3, 191)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(84, 19)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 13
        Me.KryptonLabel5.Values.Text = "Số Tiền Thu"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(3, 136)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 14
        Me.KryptonLabel4.Values.Text = "Địa Chỉ"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 34)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(106, 19)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 18
        Me.KryptonLabel3.Values.Text = "Ngày Lập Phiếu"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 113)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(104, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 15
        Me.KryptonLabel2.Values.Text = "Người Nộp Tiền"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 19
        Me.KryptonLabel1.Values.Text = "Mã Phiếu"
        '
        'txtSoPhieu
        '
        Me.txtSoPhieu.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnLaySoPhieu})
        Me.txtSoPhieu.Enabled = False
        Me.txtSoPhieu.Location = New System.Drawing.Point(129, 6)
        Me.txtSoPhieu.Name = "txtSoPhieu"
        Me.txtSoPhieu.ReadOnly = True
        Me.txtSoPhieu.Size = New System.Drawing.Size(332, 23)
        Me.txtSoPhieu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoPhieu.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSoPhieu.StateDisabled.Content.Color1 = System.Drawing.Color.Maroon
        Me.txtSoPhieu.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoPhieu.TabIndex = 0
        Me.txtSoPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLaySoPhieu
        '
        Me.btnLaySoPhieu.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnLaySoPhieu.UniqueName = "4588480FD62C43DC778B340288E989E4"
        Me.btnLaySoPhieu.Visible = False
        '
        'txtLyDo
        '
        Me.txtLyDo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLyDo.Location = New System.Drawing.Point(129, 213)
        Me.txtLyDo.Name = "txtLyDo"
        Me.txtLyDo.Size = New System.Drawing.Size(332, 50)
        Me.txtLyDo.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLyDo.TabIndex = 7
        Me.txtLyDo.Text = ""
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiaChi.Location = New System.Drawing.Point(129, 136)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(332, 50)
        Me.txtDiaChi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.TabIndex = 5
        Me.txtDiaChi.Text = ""
        '
        'txtChungTuKem
        '
        Me.txtChungTuKem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChungTuKem.Location = New System.Drawing.Point(129, 265)
        Me.txtChungTuKem.Name = "txtChungTuKem"
        Me.txtChungTuKem.Size = New System.Drawing.Size(332, 23)
        Me.txtChungTuKem.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChungTuKem.TabIndex = 8
        '
        'dtpNgayThu
        '
        Me.dtpNgayThu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpNgayThu.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayThu.Location = New System.Drawing.Point(129, 31)
        Me.dtpNgayThu.Name = "dtpNgayThu"
        Me.dtpNgayThu.Size = New System.Drawing.Size(332, 25)
        Me.dtpNgayThu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayThu.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'cmbHinhThucThanhToan
        '
        Me.cmbHinhThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHinhThucThanhToan.DropDownWidth = 260
        Me.cmbHinhThucThanhToan.Location = New System.Drawing.Point(129, 59)
        Me.cmbHinhThucThanhToan.Name = "cmbHinhThucThanhToan"
        Me.cmbHinhThucThanhToan.Size = New System.Drawing.Size(332, 24)
        Me.cmbHinhThucThanhToan.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHinhThucThanhToan.TabIndex = 2
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(3, 62)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(87, 19)
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 17
        Me.KryptonLabel8.Values.Text = "Hình thức TT"
        '
        'frmSuaPhieuThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 336)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuaPhieuThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sửa phiếu thu"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.cmbHinhThucThanhToan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents vndSoTien As PhanMemBanHang.VNDTextBox
    Friend WithEvents txtTenNguoiNop As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSoPhieu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnLaySoPhieu As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtLyDo As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents txtDiaChi As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents txtChungTuKem As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents dtpNgayThu As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnDong As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnThem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNguoiNhanTien As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbHinhThucThanhToan As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
