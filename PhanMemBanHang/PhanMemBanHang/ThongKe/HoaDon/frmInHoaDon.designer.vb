<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInHoaDon))
        Me.CtrlInHoaDon1 = New PhanMemBanHang.ctrlInHoaDon()
        Me.SuspendLayout()
        '
        'CtrlInHoaDon1
        '
        Me.CtrlInHoaDon1.Dock = System.Windows.Forms.DockStyle.Fill



        Me.CtrlInHoaDon1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlInHoaDon1.Name = "CtrlInHoaDon1"
        Me.CtrlInHoaDon1.Size = New System.Drawing.Size(694, 465)
        Me.CtrlInHoaDon1.TabIndex = 0
        '
        'frmInHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 465)
        Me.Controls.Add(Me.CtrlInHoaDon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmInHoaDon"
        Me.Text = "In Hóa Đơn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlInHoaDon1 As PhanMemBanHang.ctrlInHoaDon
End Class
