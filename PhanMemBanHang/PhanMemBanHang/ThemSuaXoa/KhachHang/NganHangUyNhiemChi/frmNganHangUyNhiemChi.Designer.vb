<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNganHangUyNhiemChi
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
        Me.CtrlThemSuaXoaNganHangUyNhiemChi1 = New PhanMemBanHang.ctrlThemSuaXoaNganHangUyNhiemChi()
        Me.SuspendLayout()
        '
        'CtrlThemSuaXoaNganHangUyNhiemChi1
        '
        Me.CtrlThemSuaXoaNganHangUyNhiemChi1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlThemSuaXoaNganHangUyNhiemChi1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlThemSuaXoaNganHangUyNhiemChi1.Name = "CtrlThemSuaXoaNganHangUyNhiemChi1"
        Me.CtrlThemSuaXoaNganHangUyNhiemChi1.Size = New System.Drawing.Size(670, 507)
        Me.CtrlThemSuaXoaNganHangUyNhiemChi1.TabIndex = 0
        '
        'frmNganHangUyNhiemChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 507)
        Me.Controls.Add(Me.CtrlThemSuaXoaNganHangUyNhiemChi1)
        Me.KeyPreview = True
        Me.Name = "frmNganHangUyNhiemChi"
        Me.Text = "Ngân hàng ủy nhiệm chi"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CtrlThemSuaXoaNganHangUyNhiemChi1 As ctrlThemSuaXoaNganHangUyNhiemChi
End Class
