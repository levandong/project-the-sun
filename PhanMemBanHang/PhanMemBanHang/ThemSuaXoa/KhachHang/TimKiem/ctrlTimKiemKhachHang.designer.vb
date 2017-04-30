<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlTimKiemKhachHang

    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.btnChon = New ComponentFactory.Krypton.Toolkit.KryptonDropButton()
        Me.KryptonContextMenu1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenu()
        Me.KryptonContextMenuItems1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.ctmThemKhachHangMoi = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.ctmCapNhat = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.ctmCauHinhTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtSearch = New PhanMemBanHang.clsTextbox()
        Me.CtrlDGVKhachHang1 = New PhanMemBanHang.ctrlDGVKhachHang()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChon
        '
        Me.btnChon.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnChon.KryptonContextMenu = Me.KryptonContextMenu1
        Me.btnChon.Location = New System.Drawing.Point(454, 0)
        Me.btnChon.Name = "btnChon"
        Me.btnChon.Size = New System.Drawing.Size(83, 30)
        Me.btnChon.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnChon.StateCommon.Border.Rounding = 0
        Me.btnChon.StateCommon.Border.Width = 0
        Me.btnChon.TabIndex = 2
        Me.btnChon.Values.Text = "CHỌN"
        '
        'KryptonContextMenu1
        '
        Me.KryptonContextMenu1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItems1})
        '
        'KryptonContextMenuItems1
        '
        Me.KryptonContextMenuItems1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.ctmThemKhachHangMoi, Me.ctmCapNhat, Me.ctmCauHinhTimKiem})
        '
        'ctmThemKhachHangMoi
        '
        Me.ctmThemKhachHangMoi.Image = Global.PhanMemBanHang.My.Resources.Resources.Them16x16
        Me.ctmThemKhachHangMoi.Text = "Thêm khách hàng mới"
        '
        'ctmCapNhat
        '
        Me.ctmCapNhat.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.ctmCapNhat.Text = "Cập nhật"
        '
        'ctmCauHinhTimKiem
        '
        Me.ctmCauHinhTimKiem.Image = Global.PhanMemBanHang.My.Resources.Resources.CaiDat16
        Me.ctmCauHinhTimKiem.Text = "Cấu hình tìm kiếm"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.txtSearch)
        Me.KryptonPanel1.Controls.Add(Me.btnChon)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(537, 30)
        Me.KryptonPanel1.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Location = New System.Drawing.Point(0, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(454, 28)
        Me.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.txtSearch.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtSearch.StateCommon.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.Gray
        Me.txtSearch.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "Tìm kiếm..."
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSearch.TextGoiY = "Tìm kiếm..."
        '
        'CtrlDGVKhachHang1
        '
        Me.CtrlDGVKhachHang1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlDGVKhachHang1.Location = New System.Drawing.Point(0, 30)
        Me.CtrlDGVKhachHang1.Name = "CtrlDGVKhachHang1"
        Me.CtrlDGVKhachHang1.Size = New System.Drawing.Size(537, 272)
        Me.CtrlDGVKhachHang1.TabIndex = 1
        '
        'ctrlTimKiemKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CtrlDGVKhachHang1)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlTimKiemKhachHang"
        Me.Size = New System.Drawing.Size(537, 302)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlDGVKhachHang1 As PhanMemBanHang.ctrlDGVKhachHang
    Friend WithEvents txtSearch As PhanMemBanHang.clsTextbox
    Friend WithEvents btnChon As ComponentFactory.Krypton.Toolkit.KryptonDropButton
    Friend WithEvents KryptonContextMenu1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents KryptonContextMenuItems1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents ctmThemKhachHangMoi As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents ctmCapNhat As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents ctmCauHinhTimKiem As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel

End Class
