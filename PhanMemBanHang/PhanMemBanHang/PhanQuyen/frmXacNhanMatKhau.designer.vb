<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXacNhanMatKhau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXacNhanMatKhau))
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblThongBao = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnXacNhan = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtMatKhau = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnXemMatKhau = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.lblThongBao)
        Me.KryptonPanel1.Controls.Add(Me.btnXacNhan)
        Me.KryptonPanel1.Controls.Add(Me.txtMatKhau)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(384, 107)
        Me.KryptonPanel1.TabIndex = 0
        '
        'lblThongBao
        '
        Me.lblThongBao.Location = New System.Drawing.Point(12, 53)
        Me.lblThongBao.Name = "lblThongBao"
        Me.lblThongBao.Size = New System.Drawing.Size(178, 23)
        Me.lblThongBao.StateCommon.ShortText.Color1 = System.Drawing.Color.Red
        Me.lblThongBao.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThongBao.TabIndex = 2
        Me.lblThongBao.Values.Text = "Mật khẩu không hợp lệ"
        Me.lblThongBao.Visible = False
        '
        'btnXacNhan
        '
        Me.btnXacNhan.Location = New System.Drawing.Point(221, 53)
        Me.btnXacNhan.Name = "btnXacNhan"
        Me.btnXacNhan.Size = New System.Drawing.Size(151, 47)
        Me.btnXacNhan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacNhan.TabIndex = 1
        Me.btnXacNhan.Values.Text = "Xác nhận"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnXemMatKhau})
        Me.txtMatKhau.Location = New System.Drawing.Point(12, 12)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtMatKhau.Size = New System.Drawing.Size(360, 35)
        Me.txtMatKhau.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatKhau.TabIndex = 0
        Me.txtMatKhau.UseSystemPasswordChar = True
        '
        'btnXemMatKhau
        '
        Me.btnXemMatKhau.Image = Global.PhanMemBanHang.My.Resources.Resources.ConMat16
        Me.btnXemMatKhau.UniqueName = "8F284D417B4048EC28A10F77945679FF"
        '
        'frmXacNhanMatKhau
        '
        Me.AcceptButton = Me.btnXacNhan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 107)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmXacNhanMatKhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xác nhận mật khẩu"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtMatKhau As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnXacNhan As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblThongBao As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnXemMatKhau As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
End Class
