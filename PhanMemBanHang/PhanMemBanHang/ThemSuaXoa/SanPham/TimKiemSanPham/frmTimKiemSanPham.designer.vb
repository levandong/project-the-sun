<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimKiemSanPham))
        Me.CtrlTimKiemSanPhamMoi1 = New PhanMemBanHang.ctrlTimKiemSanPham()
        Me.SuspendLayout()
        '
        'CtrlTimKiemSanPhamMoi1
        '
        Me.CtrlTimKiemSanPhamMoi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CtrlTimKiemSanPhamMoi1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlTimKiemSanPhamMoi1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlTimKiemSanPhamMoi1.Name = "CtrlTimKiemSanPhamMoi1"
        Me.CtrlTimKiemSanPhamMoi1.Size = New System.Drawing.Size(739, 361)
        Me.CtrlTimKiemSanPhamMoi1.TabIndex = 0
        '
        'frmTimKiemSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 361)
        Me.Controls.Add(Me.CtrlTimKiemSanPhamMoi1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTimKiemSanPham"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm Kiếm Sản Phẩm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlTimKiemSanPhamMoi1 As PhanMemBanHang.ctrlTimKiemSanPham
End Class
