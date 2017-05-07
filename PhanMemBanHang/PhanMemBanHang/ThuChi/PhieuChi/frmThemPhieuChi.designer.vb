<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemPhieuChi
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
        Me.vndPhi = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtLyDo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.lblNganHang = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbNganHang = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.btnDong = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnThem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.vndSoTien = New PhanMemBanHang.VNDTextBox(Me.components)
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSoPhieu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnLaySoPhieu = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.dtpNgayChi = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNganHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.vndPhi)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.txtLyDo)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.cmbNhanVien)
        Me.KryptonPanel1.Controls.Add(Me.lblNganHang)
        Me.KryptonPanel1.Controls.Add(Me.cmbNganHang)
        Me.KryptonPanel1.Controls.Add(Me.btnDong)
        Me.KryptonPanel1.Controls.Add(Me.btnThem)
        Me.KryptonPanel1.Controls.Add(Me.vndSoTien)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.txtSoPhieu)
        Me.KryptonPanel1.Controls.Add(Me.dtpNgayChi)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(492, 221)
        Me.KryptonPanel1.TabIndex = 0
        '
        'vndPhi
        '
        Me.vndPhi.Location = New System.Drawing.Point(124, 120)
        Me.vndPhi.Name = "vndPhi"
        Me.vndPhi.Size = New System.Drawing.Size(360, 24)
        Me.vndPhi.StateCommon.Content.Color1 = System.Drawing.Color.Red
        Me.vndPhi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vndPhi.TabIndex = 5
        Me.vndPhi.Tag = New Decimal(New Integer() {0, 0, 0, 0})
        Me.vndPhi.Text = "0"
        Me.vndPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vndPhi.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(3, 125)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(59, 19)
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 28
        Me.KryptonLabel6.Values.Text = "Mức Phí"
        '
        'txtLyDo
        '
        Me.txtLyDo.Location = New System.Drawing.Point(124, 147)
        Me.txtLyDo.Name = "txtLyDo"
        Me.txtLyDo.Size = New System.Drawing.Size(360, 23)
        Me.txtLyDo.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLyDo.TabIndex = 6
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(3, 152)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(43, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 26
        Me.KryptonLabel4.Values.Text = "Lý do"
        '
        'cmbNhanVien
        '
        Me.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhanVien.DropDownWidth = 332
        Me.cmbNhanVien.Location = New System.Drawing.Point(124, 64)
        Me.cmbNhanVien.Name = "cmbNhanVien"
        Me.cmbNhanVien.Size = New System.Drawing.Size(360, 24)
        Me.cmbNhanVien.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhanVien.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhanVien.TabIndex = 3
        '
        'lblNganHang
        '
        Me.lblNganHang.Location = New System.Drawing.Point(3, 40)
        Me.lblNganHang.Name = "lblNganHang"
        Me.lblNganHang.Size = New System.Drawing.Size(76, 19)
        Me.lblNganHang.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNganHang.TabIndex = 24
        Me.lblNganHang.Values.Text = "Ngân hàng"
        '
        'cmbNganHang
        '
        Me.cmbNganHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNganHang.DropDownWidth = 332
        Me.cmbNganHang.Location = New System.Drawing.Point(124, 34)
        Me.cmbNganHang.Name = "cmbNganHang"
        Me.cmbNganHang.Size = New System.Drawing.Size(360, 24)
        Me.cmbNganHang.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNganHang.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNganHang.TabIndex = 2
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Location = New System.Drawing.Point(403, 181)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(86, 37)
        Me.btnDong.TabIndex = 8
        Me.btnDong.Values.Text = "ĐÓNG [F3]"
        '
        'btnThem
        '
        Me.btnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThem.Location = New System.Drawing.Point(316, 181)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(81, 37)
        Me.btnThem.TabIndex = 7
        Me.btnThem.Values.Text = "THÊM [F2]"
        '
        'vndSoTien
        '
        Me.vndSoTien.Location = New System.Drawing.Point(124, 92)
        Me.vndSoTien.Name = "vndSoTien"
        Me.vndSoTien.Size = New System.Drawing.Size(360, 24)
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
        Me.KryptonLabel5.Location = New System.Drawing.Point(3, 97)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(81, 19)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 14
        Me.KryptonLabel5.Values.Text = "Số Tiền Chi"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(277, 8)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(68, 19)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 19
        Me.KryptonLabel3.Values.Text = "Ngày Lập"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 67)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(71, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 16
        Me.KryptonLabel2.Values.Text = "Nhân viên"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 12)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 20
        Me.KryptonLabel1.Values.Text = "Mã Phiếu"
        '
        'txtSoPhieu
        '
        Me.txtSoPhieu.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnLaySoPhieu})
        Me.txtSoPhieu.Enabled = False
        Me.txtSoPhieu.Location = New System.Drawing.Point(124, 7)
        Me.txtSoPhieu.Name = "txtSoPhieu"
        Me.txtSoPhieu.ReadOnly = True
        Me.txtSoPhieu.Size = New System.Drawing.Size(134, 23)
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
        'dtpNgayChi
        '
        Me.dtpNgayChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpNgayChi.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayChi.Location = New System.Drawing.Point(351, 6)
        Me.dtpNgayChi.Name = "dtpNgayChi"
        Me.dtpNgayChi.Size = New System.Drawing.Size(133, 25)
        Me.dtpNgayChi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayChi.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmThemPhieuChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 221)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmThemPhieuChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "THÊM PHIẾU CHI LƯƠNG"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNganHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dtpNgayChi As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtSoPhieu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnLaySoPhieu As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents vndSoTien As PhanMemBanHang.VNDTextBox
    Friend WithEvents btnDong As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnThem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblNganHang As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbNganHang As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbNhanVien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtLyDo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents vndPhi As VNDTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
