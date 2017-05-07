<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.CtrlMain1 = New PhanMemBanHang.ctrlMain()
        Me.CtrlDangNhap1 = New PhanMemBanHang.ctrlDangNhap()
        Me.btnHoTroTeamviewer = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btnKetNoiMayChu = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'CtrlMain1
        '
        Me.CtrlMain1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlMain1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlMain1.Name = "CtrlMain1"
        Me.CtrlMain1.Size = New System.Drawing.Size(1008, 661)
        Me.CtrlMain1.TabIndex = 0
        '
        'CtrlDangNhap1
        '
        Me.CtrlDangNhap1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlDangNhap1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlDangNhap1.Name = "CtrlDangNhap1"
        Me.CtrlDangNhap1.Size = New System.Drawing.Size(1008, 661)
        Me.CtrlDangNhap1.TabIndex = 1
        '
        'btnHoTroTeamviewer
        '
        Me.btnHoTroTeamviewer.Image = Global.PhanMemBanHang.My.Resources.Resources.teamviewer16
        Me.btnHoTroTeamviewer.Text = "Hổ trợ Teamviewer"
        Me.btnHoTroTeamviewer.UniqueName = "9FB4284469C6451BA485CE4EA7F59E26"
        '
        'btnKetNoiMayChu
        '
        Me.btnKetNoiMayChu.Image = Global.PhanMemBanHang.My.Resources.Resources.CaiDat16
        Me.btnKetNoiMayChu.Text = "Kết nối máy chủ"
        Me.btnKetNoiMayChu.UniqueName = "2FEB8D67F8CC4342739EBC421CC874F6"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnHoTroTeamviewer, Me.btnKetNoiMayChu})
        Me.ClientSize = New System.Drawing.Size(1008, 661)
        Me.Controls.Add(Me.CtrlDangNhap1)
        Me.Controls.Add(Me.CtrlMain1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: Phần mềm bán hàng chuyên nghiệp ::."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlMain1 As PhanMemBanHang.ctrlMain
    Friend WithEvents CtrlDangNhap1 As PhanMemBanHang.ctrlDangNhap
    Friend WithEvents btnHoTroTeamviewer As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnKetNoiMayChu As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents Timer1 As Timer
End Class
