<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongTinPhanMem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongTinPhanMem))
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblCopyRight = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkTuDongKiemTraCapNhat = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lnkCapNhat = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPhienBanCu = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.lblCopyRight)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.chkTuDongKiemTraCapNhat)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.lnkCapNhat)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.lblPhienBanCu)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(459, 192)
        Me.KryptonPanel1.TabIndex = 0
        '
        'lblCopyRight
        '
        Me.lblCopyRight.Location = New System.Drawing.Point(138, 57)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(81, 20)
        Me.lblCopyRight.TabIndex = 12
        Me.lblCopyRight.Values.Text = "lblCopyRight"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonLabel2.Location = New System.Drawing.Point(72, 3)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(307, 29)
        Me.KryptonLabel2.TabIndex = 11
        Me.KryptonLabel2.Values.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG"
        '
        'chkTuDongKiemTraCapNhat
        '
        Me.chkTuDongKiemTraCapNhat.Location = New System.Drawing.Point(143, 161)
        Me.chkTuDongKiemTraCapNhat.Name = "chkTuDongKiemTraCapNhat"
        Me.chkTuDongKiemTraCapNhat.Size = New System.Drawing.Size(246, 20)
        Me.chkTuDongKiemTraCapNhat.TabIndex = 10
        Me.chkTuDongKiemTraCapNhat.Values.Text = "Tự động kiểm tra cập nhật khi khởi động"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(138, 135)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(252, 20)
        Me.KryptonLabel7.TabIndex = 9
        Me.KryptonLabel7.Values.Text = "(kết nối Internet để cập nhật phiên bản mới)"
        '
        'lnkCapNhat
        '
        Me.lnkCapNhat.Location = New System.Drawing.Point(138, 109)
        Me.lnkCapNhat.Name = "lnkCapNhat"
        Me.lnkCapNhat.Size = New System.Drawing.Size(67, 20)
        Me.lnkCapNhat.TabIndex = 8
        Me.lnkCapNhat.Values.Text = "(Cập nhật)"
        Me.lnkCapNhat.Visible = False
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 109)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(92, 20)
        Me.KryptonLabel6.TabIndex = 6
        Me.KryptonLabel6.Values.Text = "Phiên bản mới:"
        '
        'lblPhienBanCu
        '
        Me.lblPhienBanCu.Location = New System.Drawing.Point(138, 83)
        Me.lblPhienBanCu.Name = "lblPhienBanCu"
        Me.lblPhienBanCu.Size = New System.Drawing.Size(65, 20)
        Me.lblPhienBanCu.TabIndex = 5
        Me.lblPhienBanCu.Values.Text = "lblVersion"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 83)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(67, 20)
        Me.KryptonLabel5.TabIndex = 4
        Me.KryptonLabel5.Values.Text = "Phiên bản:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(138, 38)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(224, 20)
        Me.KryptonLabel4.TabIndex = 3
        Me.KryptonLabel4.Values.Text = "Công ty phần mềm Trường Minh Thịnh"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 38)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(71, 20)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Values.Text = "Bản quyền:"
        '
        'frmThongTinPhanMem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 192)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(467, 226)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(467, 226)
        Me.Name = "frmThongTinPhanMem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin phần mềm"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPhienBanCu As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lnkCapNhat As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkTuDongKiemTraCapNhat As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCopyRight As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
