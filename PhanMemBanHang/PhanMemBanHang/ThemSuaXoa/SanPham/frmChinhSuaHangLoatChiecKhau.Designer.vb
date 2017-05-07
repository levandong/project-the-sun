<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChinhSuaHangLoatChiecKhau
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
        Me.lblLoaiSanPham = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnXacNhan = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblLoai = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudChiecKhau = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.nudChiecKhau)
        Me.KryptonPanel1.Controls.Add(Me.lblLoaiSanPham)
        Me.KryptonPanel1.Controls.Add(Me.btnXacNhan)
        Me.KryptonPanel1.Controls.Add(Me.lblLoai)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(450, 191)
        Me.KryptonPanel1.TabIndex = 0
        '
        'lblLoaiSanPham
        '
        Me.lblLoaiSanPham.Location = New System.Drawing.Point(12, 12)
        Me.lblLoaiSanPham.MaximumSize = New System.Drawing.Size(400, 0)
        Me.lblLoaiSanPham.Name = "lblLoaiSanPham"
        Me.lblLoaiSanPham.Size = New System.Drawing.Size(118, 23)
        Me.lblLoaiSanPham.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoaiSanPham.TabIndex = 3
        Me.lblLoaiSanPham.Values.Text = "KryptonLabel2"
        '
        'btnXacNhan
        '
        Me.btnXacNhan.Location = New System.Drawing.Point(251, 128)
        Me.btnXacNhan.Name = "btnXacNhan"
        Me.btnXacNhan.Size = New System.Drawing.Size(164, 51)
        Me.btnXacNhan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacNhan.TabIndex = 2
        Me.btnXacNhan.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.DongY24
        Me.btnXacNhan.Values.Text = "XÁC NHẬN"
        '
        'lblLoai
        '
        Me.lblLoai.Location = New System.Drawing.Point(39, 76)
        Me.lblLoai.Name = "lblLoai"
        Me.lblLoai.Size = New System.Drawing.Size(144, 29)
        Me.lblLoai.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai.TabIndex = 1
        Me.lblLoai.Values.Text = "CHIẾT KHẤU"
        '
        'nudChiecKhau
        '
        Me.nudChiecKhau.DecimalPlaces = 2
        Me.nudChiecKhau.Location = New System.Drawing.Point(295, 75)
        Me.nudChiecKhau.Name = "nudChiecKhau"
        Me.nudChiecKhau.Size = New System.Drawing.Size(120, 30)
        Me.nudChiecKhau.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudChiecKhau.TabIndex = 4
        Me.nudChiecKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmChinhSuaHangLoatChiecKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 191)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "frmChinhSuaHangLoatChiecKhau"
        Me.Text = "CHỈNH SỬA CHIẾT KHẤU HÀNG LOẠT"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblLoaiSanPham As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnXacNhan As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblLoai As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudChiecKhau As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
End Class
