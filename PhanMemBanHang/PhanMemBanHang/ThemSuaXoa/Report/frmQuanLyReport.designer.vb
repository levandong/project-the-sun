<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyReport))
        Me.CtrlThemSuaXoaReport1 = New PhanMemBanHang.ctrlThemSuaXoaReport()
        Me.SuspendLayout()
        '
        'CtrlThemSuaXoaReport1
        '
        Me.CtrlThemSuaXoaReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlThemSuaXoaReport1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlThemSuaXoaReport1.Name = "CtrlThemSuaXoaReport1"
        Me.CtrlThemSuaXoaReport1.Size = New System.Drawing.Size(818, 354)
        Me.CtrlThemSuaXoaReport1.TabIndex = 0
        '
        'frmQuanLyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 354)
        Me.Controls.Add(Me.CtrlThemSuaXoaReport1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanLyReport"
        Me.Text = "Quản lý biểu mẫu và in ấn"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlThemSuaXoaReport1 As PhanMemBanHang.ctrlThemSuaXoaReport
End Class
