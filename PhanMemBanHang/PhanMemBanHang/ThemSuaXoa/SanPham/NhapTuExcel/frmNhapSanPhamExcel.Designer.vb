<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhapSanPhamExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhapSanPhamExcel))
        Me.CtrlNhapSanPhamTuFileExcel1 = New PhanMemBanHang.ctrlNhapSanPhamTuFileExcel()
        Me.SuspendLayout()
        '
        'CtrlNhapSanPhamTuFileExcel1
        '
        Me.CtrlNhapSanPhamTuFileExcel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlNhapSanPhamTuFileExcel1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlNhapSanPhamTuFileExcel1.Name = "CtrlNhapSanPhamTuFileExcel1"
        Me.CtrlNhapSanPhamTuFileExcel1.Size = New System.Drawing.Size(767, 350)
        Me.CtrlNhapSanPhamTuFileExcel1.TabIndex = 0
        '
        'frmNhapSanPhamExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 350)
        Me.Controls.Add(Me.CtrlNhapSanPhamTuFileExcel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNhapSanPhamExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập sản phẩm từ Excel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlNhapSanPhamTuFileExcel1 As PhanMemBanHang.ctrlNhapSanPhamTuFileExcel
End Class
