<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInBangBaoGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInBangBaoGia))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.chkMauBaoGia1 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.chkMauBaoGia2 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 50)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(734, 347)
        Me.ReportViewer1.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.chkMauBaoGia2)
        Me.KryptonPanel1.Controls.Add(Me.chkMauBaoGia1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(734, 50)
        Me.KryptonPanel1.TabIndex = 1
        '
        'chkMauBaoGia1
        '
        Me.chkMauBaoGia1.Location = New System.Drawing.Point(122, 15)
        Me.chkMauBaoGia1.Name = "chkMauBaoGia1"
        Me.chkMauBaoGia1.Size = New System.Drawing.Size(98, 20)
        Me.chkMauBaoGia1.TabIndex = 0
        Me.chkMauBaoGia1.Values.Text = "In theo mẫu 1"
        '
        'chkMauBaoGia2
        '
        Me.chkMauBaoGia2.Location = New System.Drawing.Point(258, 15)
        Me.chkMauBaoGia2.Name = "chkMauBaoGia2"
        Me.chkMauBaoGia2.Size = New System.Drawing.Size(98, 20)
        Me.chkMauBaoGia2.TabIndex = 1
        Me.chkMauBaoGia2.Values.Text = "In theo mẫu 2"
        '
        'frmInBangBaoGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 397)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmInBangBaoGia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In bảng báo giá"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents chkMauBaoGia2 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents chkMauBaoGia1 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
End Class
