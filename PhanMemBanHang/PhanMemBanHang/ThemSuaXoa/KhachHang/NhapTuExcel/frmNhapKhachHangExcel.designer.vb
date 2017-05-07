<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhapKhachHangExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhapKhachHangExcel))
        Me.CtrlNhapKhachHangTuFileExcel1 = New PhanMemBanHang.ctrlNhapKhachHangTuFileExcel()
        Me.SuspendLayout()
        '
        'CtrlNhapKhachHangTuFileExcel1
        '
        Me.CtrlNhapKhachHangTuFileExcel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlNhapKhachHangTuFileExcel1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlNhapKhachHangTuFileExcel1.Name = "CtrlNhapKhachHangTuFileExcel1"
        Me.CtrlNhapKhachHangTuFileExcel1.Size = New System.Drawing.Size(832, 477)
        Me.CtrlNhapKhachHangTuFileExcel1.TabIndex = 0
        '
        'frmNhapKhachHangExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 477)
        Me.Controls.Add(Me.CtrlNhapKhachHangTuFileExcel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNhapKhachHangExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập Khách Hàng Từ File Excel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlNhapKhachHangTuFileExcel1 As PhanMemBanHang.ctrlNhapKhachHangTuFileExcel
End Class
