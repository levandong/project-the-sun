<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachThongTinLienHe
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
        Me.KryptonDataGridView1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TenNguoiLienHeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDienThoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsThongTinLienHe = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsThongTinLienHe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonDataGridView1
        '
        Me.KryptonDataGridView1.AllowUserToAddRows = False
        Me.KryptonDataGridView1.AllowUserToDeleteRows = False
        Me.KryptonDataGridView1.AutoGenerateColumns = False
        Me.KryptonDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenNguoiLienHeDataGridViewTextBoxColumn, Me.SoDienThoaiDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.KryptonDataGridView1.DataSource = Me.bsThongTinLienHe
        Me.KryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonDataGridView1.Name = "KryptonDataGridView1"
        Me.KryptonDataGridView1.ReadOnly = True
        Me.KryptonDataGridView1.RowHeadersWidth = 5
        Me.KryptonDataGridView1.Size = New System.Drawing.Size(564, 361)
        Me.KryptonDataGridView1.TabIndex = 0
        '
        'TenNguoiLienHeDataGridViewTextBoxColumn
        '
        Me.TenNguoiLienHeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenNguoiLienHeDataGridViewTextBoxColumn.DataPropertyName = "TenNguoiLienHe"
        Me.TenNguoiLienHeDataGridViewTextBoxColumn.HeaderText = "Tên người liên hệ"
        Me.TenNguoiLienHeDataGridViewTextBoxColumn.Name = "TenNguoiLienHeDataGridViewTextBoxColumn"
        Me.TenNguoiLienHeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoDienThoaiDataGridViewTextBoxColumn
        '
        Me.SoDienThoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SoDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai"
        Me.SoDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại"
        Me.SoDienThoaiDataGridViewTextBoxColumn.Name = "SoDienThoaiDataGridViewTextBoxColumn"
        Me.SoDienThoaiDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoDienThoaiDataGridViewTextBoxColumn.Width = 105
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 65
        '
        'bsThongTinLienHe
        '
        Me.bsThongTinLienHe.DataSource = GetType(PhanMemBanHang.tbChiTietLienHe)
        '
        'frmDanhSachThongTinLienHe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 361)
        Me.Controls.Add(Me.KryptonDataGridView1)
        Me.Name = "frmDanhSachThongTinLienHe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DANH SÁCH THÔNG TIN LIÊN HỆ"
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsThongTinLienHe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonDataGridView1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsThongTinLienHe As BindingSource
    Friend WithEvents TenNguoiLienHeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoDienThoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
