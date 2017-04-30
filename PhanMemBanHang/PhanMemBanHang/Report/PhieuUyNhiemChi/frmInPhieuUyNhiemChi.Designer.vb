<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInPhieuUyNhiemChi
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
        Me.CtrlInPhieuUyNhiemChi1 = New PhanMemBanHang.ctrlInPhieuUyNhiemChi()
        Me.SuspendLayout()
        '
        'CtrlInPhieuUyNhiemChi1
        '
        Me.CtrlInPhieuUyNhiemChi1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlInPhieuUyNhiemChi1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlInPhieuUyNhiemChi1.Name = "CtrlInPhieuUyNhiemChi1"
        Me.CtrlInPhieuUyNhiemChi1.Size = New System.Drawing.Size(284, 261)
        Me.CtrlInPhieuUyNhiemChi1.TabIndex = 0
        '
        'frmInPhieuUyNhiemChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CtrlInPhieuUyNhiemChi1)
        Me.Name = "frmInPhieuUyNhiemChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IN PHIẾU ỦY NHIỆM CHI"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CtrlInPhieuUyNhiemChi1 As ctrlInPhieuUyNhiemChi
End Class
