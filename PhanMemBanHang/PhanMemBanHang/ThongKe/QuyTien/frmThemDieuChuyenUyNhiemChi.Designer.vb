<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemDieuChuyenUyNhiemChi
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNoiDung = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.vndMucPhi = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbNganHangNhanTien = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbNganHang = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnDong = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnThem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtChungTuKem = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.vndSoTien = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSoPhieu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnLaySoPhieu = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.dtpNgayLap = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.cmbNganHangNhanTien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNganHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.txtNoiDung)
        Me.KryptonPanel1.Controls.Add(Me.vndMucPhi)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.cmbNganHangNhanTien)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel1.Controls.Add(Me.cmbNganHang)
        Me.KryptonPanel1.Controls.Add(Me.btnDong)
        Me.KryptonPanel1.Controls.Add(Me.btnThem)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.txtChungTuKem)
        Me.KryptonPanel1.Controls.Add(Me.vndSoTien)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.txtSoPhieu)
        Me.KryptonPanel1.Controls.Add(Me.dtpNgayLap)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(469, 275)
        Me.KryptonPanel1.TabIndex = 0
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(6, 188)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(68, 19)
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 46
        Me.KryptonLabel6.Values.Text = "Kèm theo"
        '
        'txtNoiDung
        '
        Me.txtNoiDung.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoiDung.Location = New System.Drawing.Point(102, 184)
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.Size = New System.Drawing.Size(363, 23)
        Me.txtNoiDung.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoiDung.TabIndex = 7
        '
        'vndMucPhi
        '
        Me.vndMucPhi.Location = New System.Drawing.Point(102, 123)
        Me.vndMucPhi.Name = "vndMucPhi"
        Me.vndMucPhi.Size = New System.Drawing.Size(363, 24)
        Me.vndMucPhi.StateCommon.Content.Color1 = System.Drawing.Color.Red
        Me.vndMucPhi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vndMucPhi.TabIndex = 5
        Me.vndMucPhi.Tag = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndMucPhi.Text = "0"
        Me.vndMucPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vndMucPhi.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(6, 128)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(59, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 40
        Me.KryptonLabel4.Values.Text = "Mức Phí"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(6, 68)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 38
        Me.KryptonLabel2.Values.Text = "Ngân hàng"
        '
        'cmbNganHangNhanTien
        '
        Me.cmbNganHangNhanTien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNganHangNhanTien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNganHangNhanTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNganHangNhanTien.DropDownWidth = 322
        Me.cmbNganHangNhanTien.Location = New System.Drawing.Point(102, 63)
        Me.cmbNganHangNhanTien.Name = "cmbNganHangNhanTien"
        Me.cmbNganHangNhanTien.Size = New System.Drawing.Size(363, 24)
        Me.cmbNganHangNhanTien.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNganHangNhanTien.TabIndex = 3
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(6, 38)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 36
        Me.KryptonLabel8.Values.Text = "Ngân hàng"
        '
        'cmbNganHang
        '
        Me.cmbNganHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNganHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNganHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNganHang.DropDownWidth = 322
        Me.cmbNganHang.Location = New System.Drawing.Point(102, 33)
        Me.cmbNganHang.Name = "cmbNganHang"
        Me.cmbNganHang.Size = New System.Drawing.Size(363, 24)
        Me.cmbNganHang.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNganHang.TabIndex = 2
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Location = New System.Drawing.Point(379, 226)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(86, 37)
        Me.btnDong.TabIndex = 9
        Me.btnDong.Values.Text = "ĐÓNG [F3]"
        '
        'btnThem
        '
        Me.btnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThem.Location = New System.Drawing.Point(292, 226)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(81, 37)
        Me.btnThem.TabIndex = 8
        Me.btnThem.Values.Text = "THÊM [F2]"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(6, 159)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(66, 19)
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 30
        Me.KryptonLabel7.Values.Text = "Lý do NB"
        '
        'txtChungTuKem
        '
        Me.txtChungTuKem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChungTuKem.Location = New System.Drawing.Point(102, 155)
        Me.txtChungTuKem.Name = "txtChungTuKem"
        Me.txtChungTuKem.Size = New System.Drawing.Size(363, 23)
        Me.txtChungTuKem.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChungTuKem.TabIndex = 6
        '
        'vndSoTien
        '
        Me.vndSoTien.Location = New System.Drawing.Point(102, 93)
        Me.vndSoTien.Name = "vndSoTien"
        Me.vndSoTien.Size = New System.Drawing.Size(363, 24)
        Me.vndSoTien.StateCommon.Content.Color1 = System.Drawing.Color.Red
        Me.vndSoTien.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vndSoTien.TabIndex = 4
        Me.vndSoTien.Tag = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndSoTien.Text = "0"
        Me.vndSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vndSoTien.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(6, 98)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 28
        Me.KryptonLabel5.Values.Text = "Số Tiền"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(306, 8)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(42, 19)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 23
        Me.KryptonLabel3.Values.Text = "Ngày"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(6, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 24
        Me.KryptonLabel1.Values.Text = "Mã Phiếu"
        '
        'txtSoPhieu
        '
        Me.txtSoPhieu.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnLaySoPhieu})
        Me.txtSoPhieu.Enabled = False
        Me.txtSoPhieu.Location = New System.Drawing.Point(102, 6)
        Me.txtSoPhieu.Name = "txtSoPhieu"
        Me.txtSoPhieu.ReadOnly = True
        Me.txtSoPhieu.Size = New System.Drawing.Size(163, 23)
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
        'dtpNgayLap
        '
        Me.dtpNgayLap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpNgayLap.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLap.Location = New System.Drawing.Point(351, 4)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(115, 25)
        Me.dtpNgayLap.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayLap.TabIndex = 1
        '
        'frmThemDieuChuyenUyNhiemChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 275)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.KeyPreview = True
        Me.Name = "frmThemDieuChuyenUyNhiemChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "THÊM ĐIỀU CHUYỂN TIỀN"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.cmbNganHangNhanTien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNganHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSoPhieu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnLaySoPhieu As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents dtpNgayLap As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents vndSoTien As VNDTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtChungTuKem As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnDong As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnThem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmbNganHang As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents vndMucPhi As VNDTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbNganHangNhanTien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNoiDung As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
