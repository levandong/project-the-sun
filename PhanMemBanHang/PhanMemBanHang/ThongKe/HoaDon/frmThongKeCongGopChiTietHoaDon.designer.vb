<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKeCongGopChiTietHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongKeCongGopChiTietHoaDon))
        Me.CtrlDGVSanPhamCongGop1 = New PhanMemBanHang.ctrlDGVSanPhamCongGop()
        Me.SuspendLayout()
        '
        'CtrlDGVSanPhamCongGop1
        '
        Me.CtrlDGVSanPhamCongGop1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlDGVSanPhamCongGop1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlDGVSanPhamCongGop1.Name = "CtrlDGVSanPhamCongGop1"
        Me.CtrlDGVSanPhamCongGop1.Size = New System.Drawing.Size(784, 562)
        Me.CtrlDGVSanPhamCongGop1.TabIndex = 0
        '
        'frmThongKeCongGopChiTietHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.CtrlDGVSanPhamCongGop1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThongKeCongGopChiTietHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cộng gộp sản phẩm bán"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlDGVSanPhamCongGop1 As PhanMemBanHang.ctrlDGVSanPhamCongGop
End Class
