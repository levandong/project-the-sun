<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlDGVLoaiPhieuXuat
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.bsLoaiPhieuXuat = New System.Windows.Forms.BindingSource(Me.components)
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiPhieuXuatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoTaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoaiPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoLuong, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 208)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(496, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(93, 22)
        Me.lblSoLuong.Text = "0 loại phiếu xuất"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.LoaiPhieuXuatDataGridViewTextBoxColumn, Me.MoTaDataGridViewTextBoxColumn, Me.LoaiDataGridViewTextBoxColumn})
        Me.dgvMain.DataSource = Me.bsLoaiPhieuXuat
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMain.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMain.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        Me.dgvMain.Size = New System.Drawing.Size(496, 208)
        Me.dgvMain.TabIndex = 5
        Me.dgvMain.VirtualMode = True
        '
        'bsLoaiPhieuXuat
        '
        Me.bsLoaiPhieuXuat.DataSource = GetType(PhanMemBanHang.tbLoaiPhieuXuat)
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
        'LoaiPhieuXuatDataGridViewTextBoxColumn
        '
        Me.LoaiPhieuXuatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LoaiPhieuXuatDataGridViewTextBoxColumn.DataPropertyName = "LoaiPhieuXuat"
        Me.LoaiPhieuXuatDataGridViewTextBoxColumn.HeaderText = "Loại phiếu xuất"
        Me.LoaiPhieuXuatDataGridViewTextBoxColumn.Name = "LoaiPhieuXuatDataGridViewTextBoxColumn"
        Me.LoaiPhieuXuatDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoaiPhieuXuatDataGridViewTextBoxColumn.Width = 116
        '
        'MoTaDataGridViewTextBoxColumn
        '
        Me.MoTaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MoTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa"
        Me.MoTaDataGridViewTextBoxColumn.HeaderText = "Mô tả"
        Me.MoTaDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.MoTaDataGridViewTextBoxColumn.Name = "MoTaDataGridViewTextBoxColumn"
        Me.MoTaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoaiDataGridViewTextBoxColumn
        '
        Me.LoaiDataGridViewTextBoxColumn.DataPropertyName = "Loai"
        Me.LoaiDataGridViewTextBoxColumn.HeaderText = "Loai"
        Me.LoaiDataGridViewTextBoxColumn.Name = "LoaiDataGridViewTextBoxColumn"
        Me.LoaiDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoaiDataGridViewTextBoxColumn.Visible = False
        '
        'ctrlDGVLoaiPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlDGVLoaiPhieuXuat"
        Me.Size = New System.Drawing.Size(496, 233)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoaiPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsLoaiPhieuXuat As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents lblSoLuong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents STT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoaiPhieuXuatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoTaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoaiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
