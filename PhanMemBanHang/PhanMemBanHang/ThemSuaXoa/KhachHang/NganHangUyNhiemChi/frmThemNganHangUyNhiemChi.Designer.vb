
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemNganHangUyNhiemChi
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
    Friend WithEvents btnThem As ComponentFactory.Krypton.Toolkit.KryptonButton
        'Khai báo
        Friend WithEvents txtTenChuTaiKhoan As ComponentFactory.Krypton.Toolkit.KryptonTextBox
Friend WithEvents lblTenChuTaiKhoan As ComponentFactory.Krypton.Toolkit.KryptonLabel
Friend WithEvents txtSoTaiKhoan As ComponentFactory.Krypton.Toolkit.KryptonTextBox
Friend WithEvents lblSoTaiKhoan As ComponentFactory.Krypton.Toolkit.KryptonLabel
Friend WithEvents txtTenNganHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
Friend WithEvents lblTenNganHang As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblChiNhanh As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTinh As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTinh As ComponentFactory.Krypton.Toolkit.KryptonLabel

    'InitializeComponent
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtChiNhanh = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTenChuTaiKhoan = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtSoTaiKhoan = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTenNganHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTinh = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnThem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblTenChuTaiKhoan = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSoTaiKhoan = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTenNganHang = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblChiNhanh = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTinh = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.txtChiNhanh)
        Me.pnlMain.Controls.Add(Me.txtTenChuTaiKhoan)
        Me.pnlMain.Controls.Add(Me.txtSoTaiKhoan)
        Me.pnlMain.Controls.Add(Me.txtTenNganHang)
        Me.pnlMain.Controls.Add(Me.txtTinh)
        Me.pnlMain.Controls.Add(Me.btnThem)
        Me.pnlMain.Controls.Add(Me.lblTenChuTaiKhoan)
        Me.pnlMain.Controls.Add(Me.lblSoTaiKhoan)
        Me.pnlMain.Controls.Add(Me.lblTenNganHang)
        Me.pnlMain.Controls.Add(Me.lblChiNhanh)
        Me.pnlMain.Controls.Add(Me.lblTinh)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(598, 205)
        Me.pnlMain.TabIndex = 0
        '
        'txtChiNhanh
        '
        Me.txtChiNhanh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChiNhanh.Location = New System.Drawing.Point(128, 96)
        Me.txtChiNhanh.MaxLength = 50
        Me.txtChiNhanh.Name = "txtChiNhanh"
        Me.txtChiNhanh.Size = New System.Drawing.Size(466, 23)
        Me.txtChiNhanh.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtChiNhanh.TabIndex = 3
        '
        'txtTenChuTaiKhoan
        '
        Me.txtTenChuTaiKhoan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenChuTaiKhoan.Location = New System.Drawing.Point(128, 5)
        Me.txtTenChuTaiKhoan.MaxLength = 150
        Me.txtTenChuTaiKhoan.Name = "txtTenChuTaiKhoan"
        Me.txtTenChuTaiKhoan.Size = New System.Drawing.Size(466, 23)
        Me.txtTenChuTaiKhoan.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenChuTaiKhoan.TabIndex = 0
        '
        'txtSoTaiKhoan
        '
        Me.txtSoTaiKhoan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoTaiKhoan.Location = New System.Drawing.Point(128, 36)
        Me.txtSoTaiKhoan.MaxLength = 20
        Me.txtSoTaiKhoan.Name = "txtSoTaiKhoan"
        Me.txtSoTaiKhoan.Size = New System.Drawing.Size(466, 23)
        Me.txtSoTaiKhoan.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtSoTaiKhoan.TabIndex = 1
        '
        'txtTenNganHang
        '
        Me.txtTenNganHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenNganHang.Location = New System.Drawing.Point(128, 67)
        Me.txtTenNganHang.MaxLength = 50
        Me.txtTenNganHang.Name = "txtTenNganHang"
        Me.txtTenNganHang.Size = New System.Drawing.Size(466, 23)
        Me.txtTenNganHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenNganHang.TabIndex = 2
        '
        'txtTinh
        '
        Me.txtTinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTinh.Location = New System.Drawing.Point(128, 125)
        Me.txtTinh.MaxLength = 50
        Me.txtTinh.Name = "txtTinh"
        Me.txtTinh.Size = New System.Drawing.Size(466, 23)
        Me.txtTinh.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTinh.TabIndex = 4
        '
        'btnThem
        '
        Me.btnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThem.Location = New System.Drawing.Point(480, 157)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(114, 45)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Add24
        Me.btnThem.Values.Text = "&THÊM [F2]"
        '
        'lblTenChuTaiKhoan
        '
        Me.lblTenChuTaiKhoan.Location = New System.Drawing.Point(5, 5)
        Me.lblTenChuTaiKhoan.Name = "lblTenChuTaiKhoan"
        Me.lblTenChuTaiKhoan.Size = New System.Drawing.Size(117, 19)
        Me.lblTenChuTaiKhoan.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTenChuTaiKhoan.TabIndex = 0
        Me.lblTenChuTaiKhoan.Values.Text = "Tên chủ tài khoản"
        '
        'lblSoTaiKhoan
        '
        Me.lblSoTaiKhoan.Location = New System.Drawing.Point(5, 36)
        Me.lblSoTaiKhoan.Name = "lblSoTaiKhoan"
        Me.lblSoTaiKhoan.Size = New System.Drawing.Size(85, 19)
        Me.lblSoTaiKhoan.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSoTaiKhoan.TabIndex = 1
        Me.lblSoTaiKhoan.Values.Text = "Số tài khoản"
        '
        'lblTenNganHang
        '
        Me.lblTenNganHang.Location = New System.Drawing.Point(5, 67)
        Me.lblTenNganHang.Name = "lblTenNganHang"
        Me.lblTenNganHang.Size = New System.Drawing.Size(101, 19)
        Me.lblTenNganHang.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTenNganHang.TabIndex = 2
        Me.lblTenNganHang.Values.Text = "Tên ngân hàng"
        '
        'lblChiNhanh
        '
        Me.lblChiNhanh.Location = New System.Drawing.Point(5, 98)
        Me.lblChiNhanh.Name = "lblChiNhanh"
        Me.lblChiNhanh.Size = New System.Drawing.Size(105, 19)
        Me.lblChiNhanh.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblChiNhanh.TabIndex = 3
        Me.lblChiNhanh.Values.Text = "Chi nhánh/PGD"
        '
        'lblTinh
        '
        Me.lblTinh.Location = New System.Drawing.Point(5, 125)
        Me.lblTinh.Name = "lblTinh"
        Me.lblTinh.Size = New System.Drawing.Size(58, 19)
        Me.lblTinh.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTinh.TabIndex = 4
        Me.lblTinh.Values.Text = "Tỉnh/TP"
        '
        'frmThemNganHangUyNhiemChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 205)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmThemNganHangUyNhiemChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.StateCommon.Header.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Thêm Ngân hàng ủy nhiệm chi"
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtChiNhanh As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
