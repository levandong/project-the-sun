<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlDGVReport
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvMain = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMayInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeWidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeHeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarginTopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarginBotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarginLeftDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarginRightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PixelWidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PixelHeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileRDLCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsReport = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSoLuong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.IdDataGridViewTextBoxColumn, Me.TenReportDataGridViewTextBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.TenMayInDataGridViewTextBoxColumn, Me.SizeWidthDataGridViewTextBoxColumn, Me.SizeHeightDataGridViewTextBoxColumn, Me.MarginTopDataGridViewTextBoxColumn, Me.MarginBotDataGridViewTextBoxColumn, Me.MarginLeftDataGridViewTextBoxColumn, Me.MarginRightDataGridViewTextBoxColumn, Me.PixelWidthDataGridViewTextBoxColumn, Me.PixelHeightDataGridViewTextBoxColumn, Me.FileRDLCDataGridViewTextBoxColumn})
        Me.dgvMain.DataSource = Me.bsReport
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersWidth = 10
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMain.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMain.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        Me.dgvMain.Size = New System.Drawing.Size(645, 298)
        Me.dgvMain.TabIndex = 3
        Me.dgvMain.VirtualMode = True
        '
        'STT
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STT.DefaultCellStyle = DataGridViewCellStyle3
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 40
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'TenReportDataGridViewTextBoxColumn
        '
        Me.TenReportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenReportDataGridViewTextBoxColumn.DataPropertyName = "TenReport"
        Me.TenReportDataGridViewTextBoxColumn.HeaderText = "Tên Report"
        Me.TenReportDataGridViewTextBoxColumn.Name = "TenReportDataGridViewTextBoxColumn"
        Me.TenReportDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenReportDataGridViewTextBoxColumn.Width = 94
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "Kích Thước"
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        Me.SizeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SizeDataGridViewTextBoxColumn.Width = 96
        '
        'TenMayInDataGridViewTextBoxColumn
        '
        Me.TenMayInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TenMayInDataGridViewTextBoxColumn.DataPropertyName = "TenMayIn"
        Me.TenMayInDataGridViewTextBoxColumn.HeaderText = "Máy In Mặc Định"
        Me.TenMayInDataGridViewTextBoxColumn.Name = "TenMayInDataGridViewTextBoxColumn"
        Me.TenMayInDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenMayInDataGridViewTextBoxColumn.Width = 126
        '
        'SizeWidthDataGridViewTextBoxColumn
        '
        Me.SizeWidthDataGridViewTextBoxColumn.DataPropertyName = "SizeWidth"
        Me.SizeWidthDataGridViewTextBoxColumn.HeaderText = "SizeWidth"
        Me.SizeWidthDataGridViewTextBoxColumn.Name = "SizeWidthDataGridViewTextBoxColumn"
        Me.SizeWidthDataGridViewTextBoxColumn.ReadOnly = True
        Me.SizeWidthDataGridViewTextBoxColumn.Visible = False
        '
        'SizeHeightDataGridViewTextBoxColumn
        '
        Me.SizeHeightDataGridViewTextBoxColumn.DataPropertyName = "SizeHeight"
        Me.SizeHeightDataGridViewTextBoxColumn.HeaderText = "SizeHeight"
        Me.SizeHeightDataGridViewTextBoxColumn.Name = "SizeHeightDataGridViewTextBoxColumn"
        Me.SizeHeightDataGridViewTextBoxColumn.ReadOnly = True
        Me.SizeHeightDataGridViewTextBoxColumn.Visible = False
        '
        'MarginTopDataGridViewTextBoxColumn
        '
        Me.MarginTopDataGridViewTextBoxColumn.DataPropertyName = "MarginTop"
        Me.MarginTopDataGridViewTextBoxColumn.HeaderText = "MarginTop"
        Me.MarginTopDataGridViewTextBoxColumn.Name = "MarginTopDataGridViewTextBoxColumn"
        Me.MarginTopDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarginTopDataGridViewTextBoxColumn.Visible = False
        '
        'MarginBotDataGridViewTextBoxColumn
        '
        Me.MarginBotDataGridViewTextBoxColumn.DataPropertyName = "MarginBot"
        Me.MarginBotDataGridViewTextBoxColumn.HeaderText = "MarginBot"
        Me.MarginBotDataGridViewTextBoxColumn.Name = "MarginBotDataGridViewTextBoxColumn"
        Me.MarginBotDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarginBotDataGridViewTextBoxColumn.Visible = False
        '
        'MarginLeftDataGridViewTextBoxColumn
        '
        Me.MarginLeftDataGridViewTextBoxColumn.DataPropertyName = "MarginLeft"
        Me.MarginLeftDataGridViewTextBoxColumn.HeaderText = "MarginLeft"
        Me.MarginLeftDataGridViewTextBoxColumn.Name = "MarginLeftDataGridViewTextBoxColumn"
        Me.MarginLeftDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarginLeftDataGridViewTextBoxColumn.Visible = False
        '
        'MarginRightDataGridViewTextBoxColumn
        '
        Me.MarginRightDataGridViewTextBoxColumn.DataPropertyName = "MarginRight"
        Me.MarginRightDataGridViewTextBoxColumn.HeaderText = "MarginRight"
        Me.MarginRightDataGridViewTextBoxColumn.Name = "MarginRightDataGridViewTextBoxColumn"
        Me.MarginRightDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarginRightDataGridViewTextBoxColumn.Visible = False
        '
        'PixelWidthDataGridViewTextBoxColumn
        '
        Me.PixelWidthDataGridViewTextBoxColumn.DataPropertyName = "PixelWidth"
        Me.PixelWidthDataGridViewTextBoxColumn.HeaderText = "PixelWidth"
        Me.PixelWidthDataGridViewTextBoxColumn.Name = "PixelWidthDataGridViewTextBoxColumn"
        Me.PixelWidthDataGridViewTextBoxColumn.ReadOnly = True
        Me.PixelWidthDataGridViewTextBoxColumn.Visible = False
        '
        'PixelHeightDataGridViewTextBoxColumn
        '
        Me.PixelHeightDataGridViewTextBoxColumn.DataPropertyName = "PixelHeight"
        Me.PixelHeightDataGridViewTextBoxColumn.HeaderText = "PixelHeight"
        Me.PixelHeightDataGridViewTextBoxColumn.Name = "PixelHeightDataGridViewTextBoxColumn"
        Me.PixelHeightDataGridViewTextBoxColumn.ReadOnly = True
        Me.PixelHeightDataGridViewTextBoxColumn.Visible = False
        '
        'FileRDLCDataGridViewTextBoxColumn
        '
        Me.FileRDLCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FileRDLCDataGridViewTextBoxColumn.DataPropertyName = "FileRDLC"
        Me.FileRDLCDataGridViewTextBoxColumn.HeaderText = "FileRDLC"
        Me.FileRDLCDataGridViewTextBoxColumn.MinimumWidth = 200
        Me.FileRDLCDataGridViewTextBoxColumn.Name = "FileRDLCDataGridViewTextBoxColumn"
        Me.FileRDLCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsReport
        '
        Me.bsReport.DataSource = GetType(PhanMemBanHang.tbReport)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoLuong, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 298)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(645, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(51, 22)
        Me.lblSoLuong.Text = "0 report."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ctrlDGVReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ctrlDGVReport"
        Me.Size = New System.Drawing.Size(645, 323)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsReport As System.Windows.Forms.BindingSource
    Friend WithEvents dgvMain As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblSoLuong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DonGia As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DonVi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn
    Friend WithEvents GiaNhap As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn
    Friend WithEvents MoTa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaReport As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenReport As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaDeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenDeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenReportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenMayInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SizeWidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SizeHeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarginTopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarginBotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarginLeftDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarginRightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PixelWidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PixelHeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileRDLCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
