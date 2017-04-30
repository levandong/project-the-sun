<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlNhapSanPhamTuFileExcel
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
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.chkNhapHangTonKho = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.nudSheet = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lnkFileMau = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.cmbLoaiSanPham = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonRichTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dudNgonNgu = New ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown()
        Me.btnNhapSanPham = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.nudSoDongCanNhap = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudDongBatDau = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lstBoxCotTuongUng = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.txtDuongDanFile = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnChonFileExcel = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.cmbLoaiSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.chkNhapHangTonKho)
        Me.KryptonPanel2.Controls.Add(Me.nudSheet)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel2.Controls.Add(Me.lnkFileMau)
        Me.KryptonPanel2.Controls.Add(Me.cmbLoaiSanPham)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel2.Controls.Add(Me.KryptonRichTextBox1)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel2.Controls.Add(Me.dudNgonNgu)
        Me.KryptonPanel2.Controls.Add(Me.btnNhapSanPham)
        Me.KryptonPanel2.Controls.Add(Me.nudSoDongCanNhap)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel2.Controls.Add(Me.nudDongBatDau)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel2.Controls.Add(Me.lstBoxCotTuongUng)
        Me.KryptonPanel2.Controls.Add(Me.txtDuongDanFile)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(904, 458)
        Me.KryptonPanel2.TabIndex = 0
        '
        'chkNhapHangTonKho
        '
        Me.chkNhapHangTonKho.Location = New System.Drawing.Point(208, 335)
        Me.chkNhapHangTonKho.Name = "chkNhapHangTonKho"
        Me.chkNhapHangTonKho.Size = New System.Drawing.Size(150, 20)
        Me.chkNhapHangTonKho.TabIndex = 28
        Me.chkNhapHangTonKho.Values.Text = "Nhập số lượng tồn kho"
        '
        'nudSheet
        '
        Me.nudSheet.Location = New System.Drawing.Point(364, 167)
        Me.nudSheet.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudSheet.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSheet.Name = "nudSheet"
        Me.nudSheet.Size = New System.Drawing.Size(77, 25)
        Me.nudSheet.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSheet.TabIndex = 27
        Me.nudSheet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSheet.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(208, 169)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel9.TabIndex = 26
        Me.KryptonLabel9.Values.Text = "Chọn Sheet"
        '
        'lnkFileMau
        '
        Me.lnkFileMau.Location = New System.Drawing.Point(335, 35)
        Me.lnkFileMau.Name = "lnkFileMau"
        Me.lnkFileMau.Size = New System.Drawing.Size(87, 20)
        Me.lnkFileMau.TabIndex = 25
        Me.lnkFileMau.Values.Text = "File Excel mẫu"
        '
        'cmbLoaiSanPham
        '
        Me.cmbLoaiSanPham.DisplayMember = "TenLoaiKhachHang"
        Me.cmbLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoaiSanPham.DropDownWidth = 319
        Me.cmbLoaiSanPham.Location = New System.Drawing.Point(208, 290)
        Me.cmbLoaiSanPham.Name = "cmbLoaiSanPham"
        Me.cmbLoaiSanPham.Size = New System.Drawing.Size(233, 24)
        Me.cmbLoaiSanPham.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoaiSanPham.TabIndex = 24
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(206, 264)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(92, 20)
        Me.KryptonLabel8.TabIndex = 23
        Me.KryptonLabel8.Values.Text = "Loại sản phẩm:"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(471, 6)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(96, 20)
        Me.KryptonLabel7.TabIndex = 21
        Me.KryptonLabel7.Values.Text = "Tiến trình nhập:"
        '
        'KryptonRichTextBox1
        '
        Me.KryptonRichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonRichTextBox1.Location = New System.Drawing.Point(471, 32)
        Me.KryptonRichTextBox1.Name = "KryptonRichTextBox1"
        Me.KryptonRichTextBox1.ReadOnly = True
        Me.KryptonRichTextBox1.Size = New System.Drawing.Size(418, 411)
        Me.KryptonRichTextBox1.TabIndex = 20
        Me.KryptonRichTextBox1.Text = ""
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(208, 142)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel6.TabIndex = 15
        Me.KryptonLabel6.Values.Text = "Ngôn ngữ"
        '
        'dudNgonNgu
        '
        Me.dudNgonNgu.Items.Add("en-US")
        Me.dudNgonNgu.Items.Add("vi-VN")
        Me.dudNgonNgu.Location = New System.Drawing.Point(364, 140)
        Me.dudNgonNgu.Name = "dudNgonNgu"
        Me.dudNgonNgu.ReadOnly = True
        Me.dudNgonNgu.Size = New System.Drawing.Size(77, 25)
        Me.dudNgonNgu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dudNgonNgu.TabIndex = 14
        Me.dudNgonNgu.Text = "en-US"
        Me.dudNgonNgu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNhapSanPham
        '
        Me.btnNhapSanPham.Location = New System.Drawing.Point(208, 217)
        Me.btnNhapSanPham.Name = "btnNhapSanPham"
        Me.btnNhapSanPham.Size = New System.Drawing.Size(233, 41)
        Me.btnNhapSanPham.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhapSanPham.TabIndex = 13
        Me.btnNhapSanPham.Values.Text = "NHẬP SẢN PHẨM"
        '
        'nudSoDongCanNhap
        '
        Me.nudSoDongCanNhap.Location = New System.Drawing.Point(364, 114)
        Me.nudSoDongCanNhap.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudSoDongCanNhap.Name = "nudSoDongCanNhap"
        Me.nudSoDongCanNhap.Size = New System.Drawing.Size(77, 25)
        Me.nudSoDongCanNhap.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSoDongCanNhap.TabIndex = 11
        Me.nudSoDongCanNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSoDongCanNhap.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(208, 116)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel5.TabIndex = 10
        Me.KryptonLabel5.Values.Text = "Nhập tới dòng"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(208, 90)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(152, 20)
        Me.KryptonLabel4.TabIndex = 9
        Me.KryptonLabel4.Values.Text = "Bắt đầu nhập từ dòng thứ"
        '
        'nudDongBatDau
        '
        Me.nudDongBatDau.Location = New System.Drawing.Point(364, 88)
        Me.nudDongBatDau.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudDongBatDau.Name = "nudDongBatDau"
        Me.nudDongBatDau.Size = New System.Drawing.Size(77, 25)
        Me.nudDongBatDau.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDongBatDau.TabIndex = 8
        Me.nudDongBatDau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudDongBatDau.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(208, 62)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel3.TabIndex = 6
        Me.KryptonLabel3.Values.Text = "Cấu hình khác:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 62)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(94, 20)
        Me.KryptonLabel2.TabIndex = 5
        Me.KryptonLabel2.Values.Text = "Cột tương ứng:"
        '
        'lstBoxCotTuongUng
        '
        Me.lstBoxCotTuongUng.Items.AddRange(New Object() {"A>Mã Sản Phẩm", "B>Mã Vạch", "C>Tên Sản Phẩm", "D>Đơn Vị", "E>Giá Nhập", "F>Giá Nhập QC", "G>Giá Bán", "H>Giá Bán QC", "I>Quy Cách", "J>Giới Hạn Tồn", "K>Mô Tả", "L>Mã Loại Sản Phẩm", "M>Tồn Kho"})
        Me.lstBoxCotTuongUng.Location = New System.Drawing.Point(26, 88)
        Me.lstBoxCotTuongUng.Name = "lstBoxCotTuongUng"
        Me.lstBoxCotTuongUng.Size = New System.Drawing.Size(163, 267)
        Me.lstBoxCotTuongUng.TabIndex = 4
        '
        'txtDuongDanFile
        '
        Me.txtDuongDanFile.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnChonFileExcel})
        Me.txtDuongDanFile.Location = New System.Drawing.Point(26, 32)
        Me.txtDuongDanFile.Name = "txtDuongDanFile"
        Me.txtDuongDanFile.ReadOnly = True
        Me.txtDuongDanFile.Size = New System.Drawing.Size(303, 26)
        Me.txtDuongDanFile.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuongDanFile.TabIndex = 1
        '
        'btnChonFileExcel
        '
        Me.btnChonFileExcel.Text = "..."
        Me.btnChonFileExcel.UniqueName = "304B4EAB054944270C98B8E326FEF908"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 6)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(143, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Chọn file excel (xls, xlsx):"
        '
        'ctrlNhapSanPhamTuFileExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel2)
        Me.Name = "ctrlNhapSanPhamTuFileExcel"
        Me.Size = New System.Drawing.Size(904, 458)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.cmbLoaiSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDuongDanFile As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lstBoxCotTuongUng As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudSoDongCanNhap As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudDongBatDau As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents btnNhapSanPham As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dudNgonNgu As ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonRichTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents MaVachDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaSanPhamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSanPhamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonViDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuongHeThongDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuongHienTaiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChenhLech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayLamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GioVaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GioRaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbLoaiSanPham As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lnkFileMau As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents btnChonFileExcel As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents nudSheet As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkNhapHangTonKho As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    '  Friend WithEvents cmLoaiSanPham As ComponentFactory.Krypton.Toolkit.KryptonComboBox

End Class
