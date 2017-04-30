<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlNhapKhachHangTuFileExcel
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
        Me.lnkFileMau = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonRichTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dudNgonNgu = New ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown()
        Me.btnNhapKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.nudSoDongCanNhap = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudDongBatDau = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lstBoxCotTuongUng = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.txtDuongDanFile = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnChonFielExcel = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbNhomKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.nudSheet = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.cmbNhomKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.nudSheet)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel2.Controls.Add(Me.cmbNhomKhachHang)
        Me.KryptonPanel2.Controls.Add(Me.lnkFileMau)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel2.Controls.Add(Me.KryptonRichTextBox1)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel2.Controls.Add(Me.dudNgonNgu)
        Me.KryptonPanel2.Controls.Add(Me.btnNhapKhachHang)
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
        Me.KryptonPanel2.Size = New System.Drawing.Size(904, 353)
        Me.KryptonPanel2.TabIndex = 0
        '
        'lnkFileMau
        '
        Me.lnkFileMau.Location = New System.Drawing.Point(335, 35)
        Me.lnkFileMau.Name = "lnkFileMau"
        Me.lnkFileMau.Size = New System.Drawing.Size(87, 20)
        Me.lnkFileMau.TabIndex = 22
        Me.lnkFileMau.Values.Text = "File Excel mẫu"
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
        Me.KryptonRichTextBox1.Location = New System.Drawing.Point(471, 31)
        Me.KryptonRichTextBox1.Name = "KryptonRichTextBox1"
        Me.KryptonRichTextBox1.ReadOnly = True
        Me.KryptonRichTextBox1.Size = New System.Drawing.Size(418, 302)
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
        '
        'btnNhapKhachHang
        '
        Me.btnNhapKhachHang.Location = New System.Drawing.Point(208, 215)
        Me.btnNhapKhachHang.Name = "btnNhapKhachHang"
        Me.btnNhapKhachHang.Size = New System.Drawing.Size(233, 41)
        Me.btnNhapKhachHang.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhapKhachHang.TabIndex = 13
        Me.btnNhapKhachHang.Values.Text = "NHẬP KHÁCH HÀNG"
        '
        'nudSoDongCanNhap
        '
        Me.nudSoDongCanNhap.Location = New System.Drawing.Point(364, 114)
        Me.nudSoDongCanNhap.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudSoDongCanNhap.Name = "nudSoDongCanNhap"
        Me.nudSoDongCanNhap.Size = New System.Drawing.Size(77, 25)
        Me.nudSoDongCanNhap.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSoDongCanNhap.TabIndex = 11
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
        Me.KryptonLabel2.Size = New System.Drawing.Size(179, 20)
        Me.KryptonLabel2.TabIndex = 5
        Me.KryptonLabel2.Values.Text = "Cột tương ứng trong File Excel:"
        '
        'lstBoxCotTuongUng
        '
        Me.lstBoxCotTuongUng.Items.AddRange(New Object() {"A>Mã Khách Hàng", "B>Tên Khách Hàng", "C>Số Điện Thoại", "D>Địa Chỉ", "E>Công Nợ Đầu Kỳ", "F>Mã Số Thuế", "G>Fax", "H>Email", "I>Công Nợ Max", "J>Nhóm Khách Hàng"})
        Me.lstBoxCotTuongUng.Location = New System.Drawing.Point(26, 88)
        Me.lstBoxCotTuongUng.Name = "lstBoxCotTuongUng"
        Me.lstBoxCotTuongUng.Size = New System.Drawing.Size(156, 213)
        Me.lstBoxCotTuongUng.TabIndex = 4
        '
        'txtDuongDanFile
        '
        Me.txtDuongDanFile.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnChonFielExcel})
        Me.txtDuongDanFile.Location = New System.Drawing.Point(26, 32)
        Me.txtDuongDanFile.Name = "txtDuongDanFile"
        Me.txtDuongDanFile.ReadOnly = True
        Me.txtDuongDanFile.Size = New System.Drawing.Size(303, 26)
        Me.txtDuongDanFile.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuongDanFile.TabIndex = 1
        '
        'btnChonFielExcel
        '
        Me.btnChonFielExcel.Text = "..."
        Me.btnChonFielExcel.UniqueName = "87ED1AD146C9420AF8B71FC322419AA4"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 6)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(143, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Chọn file excel (xls, xlsx):"
        '
        'cmbNhomKhachHang
        '
        Me.cmbNhomKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhomKhachHang.DropDownWidth = 233
        Me.cmbNhomKhachHang.Location = New System.Drawing.Point(208, 262)
        Me.cmbNhomKhachHang.Name = "cmbNhomKhachHang"
        Me.cmbNhomKhachHang.Size = New System.Drawing.Size(233, 21)
        Me.cmbNhomKhachHang.TabIndex = 23
        '
        'nudSheet
        '
        Me.nudSheet.Location = New System.Drawing.Point(364, 168)
        Me.nudSheet.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudSheet.Name = "nudSheet"
        Me.nudSheet.Size = New System.Drawing.Size(77, 25)
        Me.nudSheet.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSheet.TabIndex = 25
        Me.nudSheet.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(208, 170)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel8.TabIndex = 24
        Me.KryptonLabel8.Values.Text = "Chọn Sheet"
        '
        'ctrlNhapKhachHangTuFileExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel2)
        Me.Name = "ctrlNhapKhachHangTuFileExcel"
        Me.Size = New System.Drawing.Size(904, 353)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.cmbNhomKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnNhapKhachHang As ComponentFactory.Krypton.Toolkit.KryptonButton
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
    Friend WithEvents lnkFileMau As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents btnChonFielExcel As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents cmbNhomKhachHang As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents nudSheet As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    '  Friend WithEvents cmLoaiSanPham As ComponentFactory.Krypton.Toolkit.KryptonComboBox

End Class
