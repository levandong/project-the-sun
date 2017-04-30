<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThongKeLichSuLamViec
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
        Me.bsLichSu = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnXoaLichSu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInBaoCao = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnXemChiTiet = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnXoaTatCa = New System.Windows.Forms.ToolStripMenuItem()
        Me.CtrlTimKiemTheoThoiGian1 = New TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian()
        Me.btnCapNhatNhanVien = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtTuKhoa = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblThongBao = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.chkTheoNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.cmbNhanVien = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idNhanvien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayThayDoiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoiDungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.bsLichSu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bsLichSu
        '
        Me.bsLichSu.DataSource = GetType(PhanMemBanHang.tbLichSuCongViec)
        '
        'btnXoaLichSu
        '
        Me.btnXoaLichSu.Image = Global.PhanMemBanHang.My.Resources.Resources.Huy16
        Me.btnXoaLichSu.Name = "btnXoaLichSu"
        Me.btnXoaLichSu.Size = New System.Drawing.Size(163, 22)
        Me.btnXoaLichSu.Text = "Xóa dòng lịch sử"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'btnInBaoCao
        '
        Me.btnInBaoCao.Image = Global.PhanMemBanHang.My.Resources.Resources.Print16
        Me.btnInBaoCao.Name = "btnInBaoCao"
        Me.btnInBaoCao.Size = New System.Drawing.Size(163, 22)
        Me.btnInBaoCao.Text = "In báo cáo"
        '
        'btnXemChiTiet
        '
        Me.btnXemChiTiet.Name = "btnXemChiTiet"
        Me.btnXemChiTiet.Size = New System.Drawing.Size(163, 22)
        Me.btnXemChiTiet.Text = "Xem chi tiết"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnXemChiTiet, Me.btnInBaoCao, Me.ToolStripSeparator1, Me.btnXoaLichSu, Me.btnXoaTatCa})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 98)
        '
        'btnXoaTatCa
        '
        Me.btnXoaTatCa.Image = Global.PhanMemBanHang.My.Resources.Resources.XoaTatCa16
        Me.btnXoaTatCa.Name = "btnXoaTatCa"
        Me.btnXoaTatCa.Size = New System.Drawing.Size(163, 22)
        Me.btnXoaTatCa.Text = "Xóa tất cả lịch sử"
        '
        'CtrlTimKiemTheoThoiGian1
        '
        Me.CtrlTimKiemTheoThoiGian1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtrlTimKiemTheoThoiGian1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlTimKiemTheoThoiGian1.Name = "CtrlTimKiemTheoThoiGian1"
        Me.CtrlTimKiemTheoThoiGian1.Size = New System.Drawing.Size(250, 60)
        Me.CtrlTimKiemTheoThoiGian1.TabIndex = 25
        Me.CtrlTimKiemTheoThoiGian1.TheoChinhXacGio = False
        Me.CtrlTimKiemTheoThoiGian1.ToiLuc = New Date(2013, 8, 13, 0, 0, 0, 0)
        Me.CtrlTimKiemTheoThoiGian1.TuLuc = New Date(2013, 8, 13, 0, 0, 0, 0)
        '
        'btnCapNhatNhanVien
        '
        Me.btnCapNhatNhanVien.Image = Global.PhanMemBanHang.My.Resources.Resources.Refresh16
        Me.btnCapNhatNhanVien.UniqueName = "5D7526322F654BC56A87E646A6C068FE"
        '
        'txtTuKhoa
        '
        Me.txtTuKhoa.Location = New System.Drawing.Point(6, 136)
        Me.txtTuKhoa.Name = "txtTuKhoa"
        Me.txtTuKhoa.Size = New System.Drawing.Size(241, 20)
        Me.txtTuKhoa.TabIndex = 57
        '
        'lblThongBao
        '
        Me.lblThongBao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThongBao.Location = New System.Drawing.Point(2, 242)
        Me.lblThongBao.Name = "lblThongBao"
        Me.lblThongBao.Size = New System.Drawing.Size(247, 23)
        Me.lblThongBao.StateCommon.ShortText.Color1 = System.Drawing.Color.Red
        Me.lblThongBao.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThongBao.TabIndex = 56
        Me.lblThongBao.Values.Text = "[Không tìm thấy dữ liệu phù hợp]"
        Me.lblThongBao.Visible = False
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimKiem.Location = New System.Drawing.Point(6, 192)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(241, 44)
        Me.btnTimKiem.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.TabIndex = 55
        Me.btnTimKiem.Values.Text = "TÌM KIẾM"
        '
        'chkTheoNhanVien
        '
        Me.chkTheoNhanVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTheoNhanVien.Location = New System.Drawing.Point(6, 66)
        Me.chkTheoNhanVien.Name = "chkTheoNhanVien"
        Me.chkTheoNhanVien.Size = New System.Drawing.Size(241, 25)
        Me.chkTheoNhanVien.TabIndex = 53
        Me.chkTheoNhanVien.Values.Text = "Theo Nhân Viên"
        '
        'cmbNhanVien
        '
        Me.cmbNhanVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNhanVien.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnCapNhatNhanVien})
        Me.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhanVien.DropDownWidth = 121
        Me.cmbNhanVien.Enabled = False
        Me.cmbNhanVien.Location = New System.Drawing.Point(6, 97)
        Me.cmbNhanVien.Name = "cmbNhanVien"
        Me.cmbNhanVien.Size = New System.Drawing.Size(241, 24)
        Me.cmbNhanVien.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhanVien.TabIndex = 52
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtTuKhoa)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.lblThongBao)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnTimKiem)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.chkTheoNhanVien)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cmbNhanVien)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.CtrlTimKiemTheoThoiGian1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvMain)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(980, 601)
        Me.KryptonSplitContainer1.SplitterDistance = 250
        Me.KryptonSplitContainer1.TabIndex = 1
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.idNhanvien, Me.NgayThayDoiDataGridViewTextBoxColumn, Me.NoiDungDataGridViewTextBoxColumn})
        Me.dgvMain.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvMain.DataSource = Me.bsLichSu
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.Size = New System.Drawing.Size(725, 601)
        Me.dgvMain.TabIndex = 0
        Me.dgvMain.VirtualMode = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 40
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'idNhanvien
        '
        Me.idNhanvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.idNhanvien.DataPropertyName = "NhanVien"
        Me.idNhanvien.HeaderText = "Nhân viên"
        Me.idNhanvien.Name = "idNhanvien"
        Me.idNhanvien.ReadOnly = True
        Me.idNhanvien.Width = 90
        '
        'NgayThayDoiDataGridViewTextBoxColumn
        '
        Me.NgayThayDoiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NgayThayDoiDataGridViewTextBoxColumn.DataPropertyName = "NgayThayDoi"
        Me.NgayThayDoiDataGridViewTextBoxColumn.HeaderText = "Ngày"
        Me.NgayThayDoiDataGridViewTextBoxColumn.Name = "NgayThayDoiDataGridViewTextBoxColumn"
        Me.NgayThayDoiDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgayThayDoiDataGridViewTextBoxColumn.Width = 64
        '
        'NoiDungDataGridViewTextBoxColumn
        '
        Me.NoiDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung"
        Me.NoiDungDataGridViewTextBoxColumn.HeaderText = "Nội dung"
        Me.NoiDungDataGridViewTextBoxColumn.Name = "NoiDungDataGridViewTextBoxColumn"
        Me.NoiDungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ctrlThongKeLichSuLamViec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctrlThongKeLichSuLamViec"
        Me.Size = New System.Drawing.Size(980, 601)
        CType(Me.bsLichSu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.cmbNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bsLichSu As BindingSource
    Friend WithEvents btnXoaLichSu As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnInBaoCao As ToolStripMenuItem
    Friend WithEvents btnXemChiTiet As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnXoaTatCa As ToolStripMenuItem
    Friend WithEvents CtrlTimKiemTheoThoiGian1 As TimKiemTheoThoiGian.ctrlTimKiemTheoThoiGian
    Friend WithEvents btnCapNhatNhanVien As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtTuKhoa As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblThongBao As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents chkTheoNhanVien As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents cmbNhanVien As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TbNhanVienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents idNhanvien As DataGridViewTextBoxColumn
    Friend WithEvents NgayThayDoiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoiDungDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
