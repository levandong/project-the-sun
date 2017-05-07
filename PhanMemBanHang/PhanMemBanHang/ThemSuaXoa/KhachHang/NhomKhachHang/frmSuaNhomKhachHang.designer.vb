<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaNhomKhachHang
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtGhiChu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnDong = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnThem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtNhomKhachHang = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.txtGhiChu)
        Me.KryptonPanel1.Controls.Add(Me.btnDong)
        Me.KryptonPanel1.Controls.Add(Me.btnThem)
        Me.KryptonPanel1.Controls.Add(Me.txtNhomKhachHang)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(404, 141)
        Me.KryptonPanel1.TabIndex = 0
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 32)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 4
        Me.KryptonLabel1.Values.Text = "Ghi chú"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(89, 32)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(310, 66)
        Me.txtGhiChu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtGhiChu.TabIndex = 1
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Location = New System.Drawing.Point(309, 105)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(90, 30)
        Me.btnDong.TabIndex = 3
        Me.btnDong.Values.Text = "ĐÓNG [F3]"
        '
        'btnThem
        '
        Me.btnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThem.Location = New System.Drawing.Point(215, 105)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(90, 30)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Values.Text = "LƯU [F2]"
        '
        'txtNhomKhachHang
        '
        Me.txtNhomKhachHang.Location = New System.Drawing.Point(89, 3)
        Me.txtNhomKhachHang.Name = "txtNhomKhachHang"
        Me.txtNhomKhachHang.Size = New System.Drawing.Size(310, 23)
        Me.txtNhomKhachHang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNhomKhachHang.TabIndex = 0
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 3)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(80, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 5
        Me.KryptonLabel2.Values.Text = "Tên nhóm *"
        '
        'frmSuaNhomKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 141)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuaNhomKhachHang"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sửa nhóm khách hàng"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtNhomKhachHang As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnDong As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnThem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtGhiChu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
