<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSuaGiaoViec
          Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    'Khai báo control

    Friend WithEvents pnlMain As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnSua As ComponentFactory.Krypton.Toolkit.KryptonButton
    ' khai báo
    Friend WithEvents rtxtNoiDung As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
Friend WithEvents lblNoiDung As ComponentFactory.Krypton.Toolkit.KryptonLabel
Friend WithEvents rtxtGhiChu As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
Friend WithEvents lblGhiChu As ComponentFactory.Krypton.Toolkit.KryptonLabel
Friend WithEvents cmbKhachHang As ComponentFactory.Krypton.Toolkit.KryptonCombobox
Friend WithEvents btnKhongDatKhachHang As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblKhachHang As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbNhanVien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblNhanVien As ComponentFactory.Krypton.Toolkit.KryptonLabel

    'InitializeComponent
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.cmbDoUuTien = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpNgayHoanThanh = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.rtxtNoiDung = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.rtxtGhiChu = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.cmbKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnKhongDatKhachHang = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnTimKiemKhachHang = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.cmbNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnTimKiemNhanVien = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnSua = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblNoiDung = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblGhiChu = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.cmbDoUuTien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.cmbDoUuTien)
        Me.pnlMain.Controls.Add(Me.KryptonLabel2)
        Me.pnlMain.Controls.Add(Me.KryptonLabel1)
        Me.pnlMain.Controls.Add(Me.dtpNgayHoanThanh)
        Me.pnlMain.Controls.Add(Me.rtxtNoiDung)
        Me.pnlMain.Controls.Add(Me.rtxtGhiChu)
        Me.pnlMain.Controls.Add(Me.cmbKhachHang)
        Me.pnlMain.Controls.Add(Me.cmbNhanVien)
        Me.pnlMain.Controls.Add(Me.btnSua)
        Me.pnlMain.Controls.Add(Me.lblNoiDung)
        Me.pnlMain.Controls.Add(Me.lblGhiChu)
        Me.pnlMain.Controls.Add(Me.lblKhachHang)
        Me.pnlMain.Controls.Add(Me.lblNhanVien)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(503, 266)
        Me.pnlMain.TabIndex = 0
        '
        'cmbDoUuTien
        '
        Me.cmbDoUuTien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDoUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDoUuTien.DropDownWidth = 176
        Me.cmbDoUuTien.Items.AddRange(New Object() {"Thấp", "Trung Bình", "Cao"})
        Me.cmbDoUuTien.Location = New System.Drawing.Point(328, 64)
        Me.cmbDoUuTien.Name = "cmbDoUuTien"
        Me.cmbDoUuTien.Size = New System.Drawing.Size(169, 22)
        Me.cmbDoUuTien.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoUuTien.TabIndex = 3
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(250, 67)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(72, 19)
        Me.KryptonLabel2.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel2.TabIndex = 107
        Me.KryptonLabel2.Values.Text = "Độ ưu tiên"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 67)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(42, 19)
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.KryptonLabel1.TabIndex = 106
        Me.KryptonLabel1.Values.Text = "Ngày"
        '
        'dtpNgayHoanThanh
        '
        Me.dtpNgayHoanThanh.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpNgayHoanThanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayHoanThanh.Location = New System.Drawing.Point(90, 64)
        Me.dtpNgayHoanThanh.Name = "dtpNgayHoanThanh"
        Me.dtpNgayHoanThanh.Size = New System.Drawing.Size(154, 23)
        Me.dtpNgayHoanThanh.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayHoanThanh.TabIndex = 2
        '
        'rtxtNoiDung
        '
        Me.rtxtNoiDung.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtNoiDung.Location = New System.Drawing.Point(89, 92)
        Me.rtxtNoiDung.MaxLength = 350
        Me.rtxtNoiDung.Name = "rtxtNoiDung"
        Me.rtxtNoiDung.Size = New System.Drawing.Size(408, 58)
        Me.rtxtNoiDung.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rtxtNoiDung.TabIndex = 4
        Me.rtxtNoiDung.Text = ""
        '
        'rtxtGhiChu
        '
        Me.rtxtGhiChu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtGhiChu.Location = New System.Drawing.Point(89, 155)
        Me.rtxtGhiChu.MaxLength = 200
        Me.rtxtGhiChu.Name = "rtxtGhiChu"
        Me.rtxtGhiChu.Size = New System.Drawing.Size(408, 58)
        Me.rtxtGhiChu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rtxtGhiChu.TabIndex = 5
        Me.rtxtGhiChu.Text = ""
        '
        'cmbKhachHang
        '
        Me.cmbKhachHang.AllowButtonSpecToolTips = True
        Me.cmbKhachHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKhachHang.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnKhongDatKhachHang, Me.btnTimKiemKhachHang})
        Me.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhachHang.DropDownWidth = 260
        Me.cmbKhachHang.Location = New System.Drawing.Point(89, 3)
        Me.cmbKhachHang.Name = "cmbKhachHang"
        Me.cmbKhachHang.Size = New System.Drawing.Size(408, 24)
        Me.cmbKhachHang.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKhachHang.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKhachHang.TabIndex = 0
        '
        'btnKhongDatKhachHang
        '
        Me.btnKhongDatKhachHang.Image = Global.PhanMemBanHang.My.Resources.Resources.KhachHang16
        Me.btnKhongDatKhachHang.ToolTipBody = "Không quan tâm Khách hàng."
        Me.btnKhongDatKhachHang.ToolTipImage = Global.PhanMemBanHang.My.Resources.Resources.TuyChinhTimKiem16
        Me.btnKhongDatKhachHang.ToolTipTitle = "Chỉ dẫn:"
        Me.btnKhongDatKhachHang.UniqueName = "39764493-cd1d-4ab2-a61d-63b67b3ebdc3"
        '
        'btnTimKiemKhachHang
        '
        Me.btnTimKiemKhachHang.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnTimKiemKhachHang.UniqueName = "C7EEB90D3FC54A7AA8AFC5D87D701590"
        '
        'cmbNhanVien
        '
        Me.cmbNhanVien.AllowButtonSpecToolTips = True
        Me.cmbNhanVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNhanVien.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnTimKiemNhanVien})
        Me.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhanVien.DropDownWidth = 260
        Me.cmbNhanVien.Location = New System.Drawing.Point(89, 32)
        Me.cmbNhanVien.Name = "cmbNhanVien"
        Me.cmbNhanVien.Size = New System.Drawing.Size(408, 24)
        Me.cmbNhanVien.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhanVien.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhanVien.TabIndex = 1
        '
        'btnTimKiemNhanVien
        '
        Me.btnTimKiemNhanVien.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem16
        Me.btnTimKiemNhanVien.UniqueName = "F16D4FE72F0C4B1C1681454F558B1010"
        Me.btnTimKiemNhanVien.Visible = False
        '
        'btnSua
        '
        Me.btnSua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSua.Location = New System.Drawing.Point(385, 216)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(114, 45)
        Me.btnSua.TabIndex = 6
        Me.btnSua.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Edit24
        Me.btnSua.Values.Text = "&SỬA [F2]"
        '
        'lblNoiDung
        '
        Me.lblNoiDung.Location = New System.Drawing.Point(3, 92)
        Me.lblNoiDung.Name = "lblNoiDung"
        Me.lblNoiDung.Size = New System.Drawing.Size(64, 19)
        Me.lblNoiDung.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNoiDung.TabIndex = 0
        Me.lblNoiDung.Values.Text = "Nội dung"
        '
        'lblGhiChu
        '
        Me.lblGhiChu.Location = New System.Drawing.Point(3, 155)
        Me.lblGhiChu.Name = "lblGhiChu"
        Me.lblGhiChu.Size = New System.Drawing.Size(57, 19)
        Me.lblGhiChu.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblGhiChu.TabIndex = 1
        Me.lblGhiChu.Values.Text = "Ghi chú"
        '
        'lblKhachHang
        '
        Me.lblKhachHang.Location = New System.Drawing.Point(3, 3)
        Me.lblKhachHang.Name = "lblKhachHang"
        Me.lblKhachHang.Size = New System.Drawing.Size(82, 19)
        Me.lblKhachHang.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblKhachHang.TabIndex = 2
        Me.lblKhachHang.Values.Text = "Khách hàng"
        '
        'lblNhanVien
        '
        Me.lblNhanVien.Location = New System.Drawing.Point(3, 32)
        Me.lblNhanVien.Name = "lblNhanVien"
        Me.lblNhanVien.Size = New System.Drawing.Size(71, 19)
        Me.lblNhanVien.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNhanVien.TabIndex = 3
        Me.lblNhanVien.Values.Text = "Nhân viên"
        '
        'frmSuaGiaoViec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 266)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuaGiaoViec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.StateCommon.Header.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Sửa Giao việc"
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.cmbDoUuTien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbDoUuTien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpNgayHoanThanh As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents btnTimKiemKhachHang As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnTimKiemNhanVien As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
End Class
