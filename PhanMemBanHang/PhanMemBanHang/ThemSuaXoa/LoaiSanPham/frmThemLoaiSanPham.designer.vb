<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemLoaiSanPham
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
        Me.btnDong = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnThem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtGhiChu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTenLoaiSanPham = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMaLoaiSanPham = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkCopyLoaiSanPham = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnDong)
        Me.KryptonPanel1.Controls.Add(Me.btnThem)
        Me.KryptonPanel1.Controls.Add(Me.txtGhiChu)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.txtTenLoaiSanPham)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.txtMaLoaiSanPham)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.chkCopyLoaiSanPham)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(434, 153)
        Me.KryptonPanel1.TabIndex = 0
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Location = New System.Drawing.Point(332, 117)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(90, 30)
        Me.btnDong.TabIndex = 6
        Me.btnDong.Values.Text = "ĐÓNG [F3]"
        '
        'btnThem
        '
        Me.btnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThem.Location = New System.Drawing.Point(238, 117)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(90, 30)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Values.Text = "THÊM [F2]"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGhiChu.Location = New System.Drawing.Point(81, 60)
        Me.txtGhiChu.MaxLength = 100
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(350, 23)
        Me.txtGhiChu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtGhiChu.TabIndex = 3
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(3, 62)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(60, 19)
        Me.KryptonLabel4.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 24
        Me.KryptonLabel4.Values.Text = "Ghi Chú"
        '
        'txtTenLoaiSanPham
        '
        Me.txtTenLoaiSanPham.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenLoaiSanPham.Location = New System.Drawing.Point(81, 34)
        Me.txtTenLoaiSanPham.Name = "txtTenLoaiSanPham"
        Me.txtTenLoaiSanPham.Size = New System.Drawing.Size(350, 23)
        Me.txtTenLoaiSanPham.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTenLoaiSanPham.TabIndex = 2
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 36)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(72, 19)
        Me.KryptonLabel3.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 25
        Me.KryptonLabel3.Values.Text = "Tên Loại *"
        '
        'txtMaLoaiSanPham
        '
        Me.txtMaLoaiSanPham.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaLoaiSanPham.Location = New System.Drawing.Point(81, 8)
        Me.txtMaLoaiSanPham.Name = "txtMaLoaiSanPham"
        Me.txtMaLoaiSanPham.Size = New System.Drawing.Size(350, 23)
        Me.txtMaLoaiSanPham.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMaLoaiSanPham.TabIndex = 1
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 11)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel2.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 26
        Me.KryptonLabel2.Values.Text = "Mã Loại *"
        '
        'chkCopyLoaiSanPham
        '
        Me.chkCopyLoaiSanPham.Location = New System.Drawing.Point(81, 89)
        Me.chkCopyLoaiSanPham.Name = "chkCopyLoaiSanPham"
        Me.chkCopyLoaiSanPham.Size = New System.Drawing.Size(177, 19)
        Me.chkCopyLoaiSanPham.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCopyLoaiSanPham.TabIndex = 4
        Me.chkCopyLoaiSanPham.Values.Text = "Lặp lại thông tin vừa thêm"
        '
        'frmThemLoaiSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 153)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmThemLoaiSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm loại sản phẩm"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents chkCopyLoaiSanPham As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtGhiChu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTenLoaiSanPham As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMaLoaiSanPham As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnDong As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnThem As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
