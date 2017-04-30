
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemLoaiPhieuThu
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
    Friend WithEvents btnThem As ComponentFactory.Krypton.Toolkit.KryptonButton
        'Khai báo
        Friend WithEvents txtLoaiThu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
Friend WithEvents lblLoaiThu As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents rtxtMoTa As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblMoTa As ComponentFactory.Krypton.Toolkit.KryptonLabel

    'InitializeComponent
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtLoaiThu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.rtxtMoTa = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnThem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblLoaiThu = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMoTa = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.txtLoaiThu)
        Me.pnlMain.Controls.Add(Me.rtxtMoTa)
        Me.pnlMain.Controls.Add(Me.btnThem)
        Me.pnlMain.Controls.Add(Me.lblLoaiThu)
        Me.pnlMain.Controls.Add(Me.lblMoTa)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(419, 154)
        Me.pnlMain.TabIndex = 0
        '
        'txtLoaiThu
        '
        Me.txtLoaiThu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoaiThu.Location = New System.Drawing.Point(100, 5)
        Me.txtLoaiThu.MaxLength = 150
        Me.txtLoaiThu.Name = "txtLoaiThu"
        Me.txtLoaiThu.Size = New System.Drawing.Size(315, 23)
        Me.txtLoaiThu.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtLoaiThu.TabIndex = 0
        '
        'rtxtMoTa
        '
        Me.rtxtMoTa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtMoTa.Location = New System.Drawing.Point(100, 36)
        Me.rtxtMoTa.MaxLength = 350
        Me.rtxtMoTa.Name = "rtxtMoTa"
        Me.rtxtMoTa.Size = New System.Drawing.Size(315, 58)
        Me.rtxtMoTa.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rtxtMoTa.TabIndex = 1
        Me.rtxtMoTa.Text = ""
        '
        'btnThem
        '
        Me.btnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThem.Location = New System.Drawing.Point(301, 104)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(114, 45)
        Me.btnThem.TabIndex = 100
        Me.btnThem.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Add24
        Me.btnThem.Values.Text = "&THÊM [F2]"
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
        'frmThemLoaiPhieuThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 154)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmThemLoaiPhieuThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.StateCommon.Header.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text = "Thêm Loại Phiếu Thu"
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
