<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSuaLoaiPhieuThu
          Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    'Khai báo control

    Friend WithEvents pnlMain As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnSua As ComponentFactory.Krypton.Toolkit.KryptonButton
    ' khai báo
    Friend WithEvents txtLoaiThu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
Friend WithEvents lblLoaiThu As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMoTa As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblMoTa As ComponentFactory.Krypton.Toolkit.KryptonLabel

    'InitializeComponent
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtLoaiThu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtMoTa = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnSua = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblLoaiThu = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMoTa = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.txtLoaiThu)
        Me.pnlMain.Controls.Add(Me.txtMoTa)
        Me.pnlMain.Controls.Add(Me.btnSua)
        Me.pnlMain.Controls.Add(Me.lblLoaiThu)
        Me.pnlMain.Controls.Add(Me.lblMoTa)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(424, 127)
        Me.pnlMain.TabIndex = 0
        '
        'txtLoaiThu
        '
        Me.txtLoaiThu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoaiThu.Location = New System.Drawing.Point(100, 5)
        Me.txtLoaiThu.MaxLength = 150
        Me.txtLoaiThu.Name = "txtLoaiThu"
        Me.txtLoaiThu.Size = New System.Drawing.Size(320, 23)
        Me.txtLoaiThu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtLoaiThu.TabIndex = 0
        '
        'txtMoTa
        '
        Me.txtMoTa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMoTa.Location = New System.Drawing.Point(100, 36)
        Me.txtMoTa.MaxLength = 350
        Me.txtMoTa.Name = "txtMoTa"
        Me.txtMoTa.Size = New System.Drawing.Size(320, 23)
        Me.txtMoTa.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMoTa.TabIndex = 1
        '
        'btnSua
        '
        Me.btnSua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSua.Location = New System.Drawing.Point(306, 77)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(114, 45)
        Me.btnSua.TabIndex = 100
        Me.btnSua.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Sua16
        Me.btnSua.Values.Text = "&SỬA [F2]"
        '
        'lblLoaiThu
        '
        Me.lblLoaiThu.Location = New System.Drawing.Point(5, 5)
        Me.lblLoaiThu.Name = "lblLoaiThu"
        Me.lblLoaiThu.Size = New System.Drawing.Size(89, 19)
        Me.lblLoaiThu.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblLoaiThu.TabIndex = 0
        Me.lblLoaiThu.Values.Text = "Tên Loại Thu"
        '
        'lblMoTa
        '
        Me.lblMoTa.Location = New System.Drawing.Point(5, 36)
        Me.lblMoTa.Name = "lblMoTa"
        Me.lblMoTa.Size = New System.Drawing.Size(49, 19)
        Me.lblMoTa.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblMoTa.TabIndex = 1
        Me.lblMoTa.Values.Text = "Mô Tả"
        '
        'frmSuaLoaiPhieuThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 127)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuaLoaiPhieuThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.StateCommon.Header.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Sửa Loại Phiếu Thu"
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
