<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlInHoaDon
    Inherits UserControl

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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.chkInHoaDonMau = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.nudDoCaoDong = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudSanPham = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudTenKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.btnCapNhat = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudCoChuDiaChi = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudCoChuDonVi = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnInHoaDon = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "dsDaBan"
        ReportDataSource2.Value = Nothing
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemBanHangMoi.rptHoaDon.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1111, 728)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(927, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnInHoaDon)
        Me.KryptonPanel1.Controls.Add(Me.chkInHoaDonMau)
        Me.KryptonPanel1.Controls.Add(Me.nudDoCaoDong)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.nudSanPham)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.nudTenKhachHang)
        Me.KryptonPanel1.Controls.Add(Me.btnCapNhat)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.Label1)
        Me.KryptonPanel1.Controls.Add(Me.nudCoChuDiaChi)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.nudCoChuDonVi)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1111, 61)
        Me.KryptonPanel1.TabIndex = 0
        '
        'chkInHoaDonMau
        '
        Me.chkInHoaDonMau.Location = New System.Drawing.Point(401, 34)
        Me.chkInHoaDonMau.Name = "chkInHoaDonMau"
        Me.chkInHoaDonMau.Size = New System.Drawing.Size(139, 23)
        Me.chkInHoaDonMau.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInHoaDonMau.TabIndex = 14
        Me.chkInHoaDonMau.Values.Text = "In hóa đơn mẫu"
        Me.chkInHoaDonMau.Visible = False
        '
        'nudDoCaoDong
        '
        Me.nudDoCaoDong.DecimalPlaces = 2
        Me.nudDoCaoDong.Increment = New Decimal(New Integer() {2, 0, 0, 131072})
        Me.nudDoCaoDong.Location = New System.Drawing.Point(498, 4)
        Me.nudDoCaoDong.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudDoCaoDong.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudDoCaoDong.Name = "nudDoCaoDong"
        Me.nudDoCaoDong.Size = New System.Drawing.Size(75, 25)
        Me.nudDoCaoDong.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDoCaoDong.TabIndex = 4
        Me.nudDoCaoDong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudDoCaoDong.Value = New Decimal(New Integer() {6, 0, 0, 65536})
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(401, 8)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel5.TabIndex = 11
        Me.KryptonLabel5.Values.Text = "Độ cao 1 dòng"
        '
        'nudSanPham
        '
        Me.nudSanPham.DecimalPlaces = 2
        Me.nudSanPham.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudSanPham.Location = New System.Drawing.Point(307, 32)
        Me.nudSanPham.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nudSanPham.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudSanPham.Name = "nudSanPham"
        Me.nudSanPham.Size = New System.Drawing.Size(75, 25)
        Me.nudSanPham.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSanPham.TabIndex = 3
        Me.nudSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSanPham.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(236, 34)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(65, 20)
        Me.KryptonLabel4.TabIndex = 9
        Me.KryptonLabel4.Values.Text = "Sản Phẩm"
        '
        'nudTenKhachHang
        '
        Me.nudTenKhachHang.DecimalPlaces = 2
        Me.nudTenKhachHang.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudTenKhachHang.Location = New System.Drawing.Point(153, 4)
        Me.nudTenKhachHang.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nudTenKhachHang.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudTenKhachHang.Name = "nudTenKhachHang"
        Me.nudTenKhachHang.Size = New System.Drawing.Size(75, 25)
        Me.nudTenKhachHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTenKhachHang.TabIndex = 0
        Me.nudTenKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTenKhachHang.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(590, 4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(107, 51)
        Me.btnCapNhat.TabIndex = 5
        Me.btnCapNhat.Values.Text = "CẬP NHẬT [F5]"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 6)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(147, 20)
        Me.KryptonLabel3.TabIndex = 6
        Me.KryptonLabel3.Values.Text = "Cỡ chữ Người Mua Hàng"
        '
        'nudCoChuDiaChi
        '
        Me.nudCoChuDiaChi.DecimalPlaces = 2
        Me.nudCoChuDiaChi.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudCoChuDiaChi.Location = New System.Drawing.Point(307, 4)
        Me.nudCoChuDiaChi.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nudCoChuDiaChi.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudCoChuDiaChi.Name = "nudCoChuDiaChi"
        Me.nudCoChuDiaChi.Size = New System.Drawing.Size(75, 25)
        Me.nudCoChuDiaChi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCoChuDiaChi.TabIndex = 2
        Me.nudCoChuDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCoChuDiaChi.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(252, 6)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(49, 20)
        Me.KryptonLabel2.TabIndex = 8
        Me.KryptonLabel2.Values.Text = "Địa Chỉ"
        '
        'nudCoChuDonVi
        '
        Me.nudCoChuDonVi.DecimalPlaces = 2
        Me.nudCoChuDonVi.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudCoChuDonVi.Location = New System.Drawing.Point(153, 32)
        Me.nudCoChuDonVi.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nudCoChuDonVi.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudCoChuDonVi.Name = "nudCoChuDonVi"
        Me.nudCoChuDonVi.Size = New System.Drawing.Size(75, 25)
        Me.nudCoChuDonVi.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCoChuDonVi.TabIndex = 1
        Me.nudCoChuDonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCoChuDonVi.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(79, 34)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(71, 20)
        Me.KryptonLabel1.TabIndex = 7
        Me.KryptonLabel1.Values.Text = "Tên Đơn Vị"
        '
        'btnInHoaDon
        '
        Me.btnInHoaDon.Location = New System.Drawing.Point(703, 4)
        Me.btnInHoaDon.Name = "btnInHoaDon"
        Me.btnInHoaDon.Size = New System.Drawing.Size(107, 51)
        Me.btnInHoaDon.TabIndex = 15
        Me.btnInHoaDon.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.In_16
        Me.btnInHoaDon.Values.Text = "IN HÓA ĐƠN"
        '
        'ctrlInHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlInHoaDon"
        Me.Size = New System.Drawing.Size(1111, 789)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnCapNhat As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents nudCoChuDiaChi As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudCoChuDonVi As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudTenKhachHang As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudSanPham As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudDoCaoDong As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkInHoaDonMau As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnInHoaDon As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
