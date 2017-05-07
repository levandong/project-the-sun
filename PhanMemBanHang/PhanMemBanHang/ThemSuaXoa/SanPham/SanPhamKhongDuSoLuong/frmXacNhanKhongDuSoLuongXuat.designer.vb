<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXacNhanKhongDuSoLuongXuat
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXacNhanKhongDuSoLuongXuat))
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnHuy = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnVanXuat = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblThongBao = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.bsSanPhamKhongDuSoLuongXuat = New System.Windows.Forms.BindingSource(Me.components)
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSanPham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongTonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongXuatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSanPhamKhongDuSoLuongXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnHuy)
        Me.KryptonPanel1.Controls.Add(Me.btnVanXuat)
        Me.KryptonPanel1.Controls.Add(Me.lblThongBao)
        Me.KryptonPanel1.Controls.Add(Me.dgvMain)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(663, 243)
        Me.KryptonPanel1.TabIndex = 0
        '
        'btnHuy
        '
        Me.btnHuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHuy.Location = New System.Drawing.Point(372, 206)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(141, 34)
        Me.btnHuy.TabIndex = 0
        Me.btnHuy.Values.Text = "HỦY"
        '
        'btnVanXuat
        '
        Me.btnVanXuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVanXuat.Location = New System.Drawing.Point(519, 206)
        Me.btnVanXuat.Name = "btnVanXuat"
        Me.btnVanXuat.Size = New System.Drawing.Size(141, 34)
        Me.btnVanXuat.TabIndex = 1
        Me.btnVanXuat.Values.Text = "VẪN XUẤT"
        '
        'lblThongBao
        '
        Me.lblThongBao.Location = New System.Drawing.Point(3, 4)
        Me.lblThongBao.Name = "lblThongBao"
        Me.lblThongBao.Size = New System.Drawing.Size(241, 20)
        Me.lblThongBao.TabIndex = 3
        Me.lblThongBao.Values.Text = "Những sản phẩm không đủ số lượng xuất:"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaSanPham, Me.TenSanPham, Me.SoLuongTonDataGridViewTextBoxColumn, Me.SoLuongXuatDataGridViewTextBoxColumn, Me.SoLuongConDataGridViewTextBoxColumn})
        Me.dgvMain.DataSource = Me.bsSanPhamKhongDuSoLuongXuat
        Me.dgvMain.Location = New System.Drawing.Point(3, 30)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMain.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        Me.dgvMain.Size = New System.Drawing.Size(657, 170)
        Me.dgvMain.TabIndex = 2
        Me.dgvMain.VirtualMode = True
        '
        'bsSanPhamKhongDuSoLuongXuat
        '
        Me.bsSanPhamKhongDuSoLuongXuat.DataSource = GetType(PhanMemBanHang.clsSanPhamKhongDuSoLuong)
        '
        'STT
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STT.DefaultCellStyle = DataGridViewCellStyle1
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 40
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'MaSanPham
        '
        Me.MaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MaSanPham.DataPropertyName = "MaSanPham"
        Me.MaSanPham.HeaderText = "Mã sản phẩm"
        Me.MaSanPham.MinimumWidth = 90
        Me.MaSanPham.Name = "MaSanPham"
        Me.MaSanPham.ReadOnly = True
        Me.MaSanPham.Width = 108
        '
        'TenSanPham
        '
        Me.TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenSanPham.DataPropertyName = "TenSanPham"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        Me.TenSanPham.DefaultCellStyle = DataGridViewCellStyle2
        Me.TenSanPham.HeaderText = "Tên sản phẩm"
        Me.TenSanPham.MinimumWidth = 150
        Me.TenSanPham.Name = "TenSanPham"
        Me.TenSanPham.ReadOnly = True
        '
        'SoLuongTonDataGridViewTextBoxColumn
        '
        Me.SoLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle3.Format = "###,###,###,##0.###,###"
        Me.SoLuongTonDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SoLuongTonDataGridViewTextBoxColumn.HeaderText = "Tồn"
        Me.SoLuongTonDataGridViewTextBoxColumn.MinimumWidth = 60
        Me.SoLuongTonDataGridViewTextBoxColumn.Name = "SoLuongTonDataGridViewTextBoxColumn"
        Me.SoLuongTonDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongTonDataGridViewTextBoxColumn.Width = 60
        '
        'SoLuongXuatDataGridViewTextBoxColumn
        '
        Me.SoLuongXuatDataGridViewTextBoxColumn.DataPropertyName = "SoLuongXuat"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Format = "###,###,###,##0.###,###"
        Me.SoLuongXuatDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SoLuongXuatDataGridViewTextBoxColumn.HeaderText = "Xuất"
        Me.SoLuongXuatDataGridViewTextBoxColumn.MinimumWidth = 60
        Me.SoLuongXuatDataGridViewTextBoxColumn.Name = "SoLuongXuatDataGridViewTextBoxColumn"
        Me.SoLuongXuatDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongXuatDataGridViewTextBoxColumn.Width = 60
        '
        'SoLuongConDataGridViewTextBoxColumn
        '
        Me.SoLuongConDataGridViewTextBoxColumn.DataPropertyName = "SoLuongCon"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Format = "###,###,###,##0.###,###"
        Me.SoLuongConDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SoLuongConDataGridViewTextBoxColumn.HeaderText = "Còn"
        Me.SoLuongConDataGridViewTextBoxColumn.MinimumWidth = 60
        Me.SoLuongConDataGridViewTextBoxColumn.Name = "SoLuongConDataGridViewTextBoxColumn"
        Me.SoLuongConDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoLuongConDataGridViewTextBoxColumn.Width = 60
        '
        'frmXacNhanKhongDuSoLuongXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 243)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmXacNhanKhongDuSoLuongXuat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xác nhận không đủ số lượng xuất"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSanPhamKhongDuSoLuongXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnHuy As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnVanXuat As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblThongBao As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsSanPhamKhongDuSoLuongXuat As System.Windows.Forms.BindingSource
    Friend WithEvents MaVach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaSanPham As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSanPham As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuongTonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuongXuatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuongConDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
