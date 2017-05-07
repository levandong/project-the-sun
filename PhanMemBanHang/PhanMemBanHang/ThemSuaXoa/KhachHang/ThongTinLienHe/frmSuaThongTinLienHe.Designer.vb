<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSuaThongTinLienHe
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnDong = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnThem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmail = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSoDienThoai = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTenKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnDong)
        Me.KryptonPanel1.Controls.Add(Me.btnThem)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.txtEmail)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.txtSoDienThoai)
        Me.KryptonPanel1.Controls.Add(Me.txtTenKhachHang)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel12)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(472, 142)
        Me.KryptonPanel1.TabIndex = 0
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Location = New System.Drawing.Point(372, 100)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(90, 30)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Values.Text = "ĐÓNG [F3]"
        '
        'btnThem
        '
        Me.btnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThem.Location = New System.Drawing.Point(276, 100)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(90, 30)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Values.Text = "SỬA [F2]"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(10, 72)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 38
        Me.KryptonLabel4.Values.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(96, 70)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(367, 23)
        Me.txtEmail.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtEmail.TabIndex = 2
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(10, 46)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 35
        Me.KryptonLabel3.Values.Text = "Điện Thoại"
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoDienThoai.Location = New System.Drawing.Point(96, 43)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(367, 23)
        Me.txtSoDienThoai.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtSoDienThoai.TabIndex = 1
        '
        'txtTenKhachHang
        '
        Me.txtTenKhachHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenKhachHang.Location = New System.Drawing.Point(96, 14)
        Me.txtTenKhachHang.Name = "txtTenKhachHang"
        Me.txtTenKhachHang.Size = New System.Drawing.Size(367, 23)
        Me.txtTenKhachHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenKhachHang.TabIndex = 0
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(9, 14)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(84, 19)
        Me.KryptonLabel12.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.TabIndex = 36
        Me.KryptonLabel12.Values.Text = "Tên Liên Hệ"
        '
        'frmSuaThongTinLienHe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 142)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.KeyPreview = True
        Me.Name = "frmSuaThongTinLienHe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SỬA THÔNG TIN NGƯỜI LIÊN HỆ"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmail As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSoDienThoai As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTenKhachHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnDong As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnThem As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
