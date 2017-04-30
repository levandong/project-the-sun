<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemBieuDo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXemBieuDo))
        Me.CtrlBieuDoThuChi1 = New PhanMemBanHang.ctrlBieuDoThuChi()
        Me.SuspendLayout()
        '
        'CtrlBieuDoThuChi1
        '
        Me.CtrlBieuDoThuChi1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlBieuDoThuChi1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlBieuDoThuChi1.Name = "CtrlBieuDoThuChi1"
        Me.CtrlBieuDoThuChi1.Size = New System.Drawing.Size(821, 378)
        Me.CtrlBieuDoThuChi1.TabIndex = 0
        '
        'frmXemBieuDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 378)
        Me.Controls.Add(Me.CtrlBieuDoThuChi1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmXemBieuDo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xem biểu đồ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlBieuDoThuChi1 As PhanMemBanHang.ctrlBieuDoThuChi
End Class
