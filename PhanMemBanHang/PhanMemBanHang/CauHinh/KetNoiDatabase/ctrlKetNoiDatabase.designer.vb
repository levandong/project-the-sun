<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlKetNoiDatabase
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.chkSaveSetting = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkCopyClipboard = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.lnkLuuThongTinKetNoi = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.txtLoi = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.btnTestKetNoi = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUser = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDatabase = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtServer = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.chkSaveSetting)
        Me.KryptonPanel1.Controls.Add(Me.chkCopyClipboard)
        Me.KryptonPanel1.Controls.Add(Me.lnkLuuThongTinKetNoi)
        Me.KryptonPanel1.Controls.Add(Me.txtLoi)
        Me.KryptonPanel1.Controls.Add(Me.btnTestKetNoi)
        Me.KryptonPanel1.Controls.Add(Me.txtPassword)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.txtUser)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.txtDatabase)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.txtServer)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(295, 273)
        Me.KryptonPanel1.TabIndex = 0
        '
        'chkSaveSetting
        '
        Me.chkSaveSetting.Checked = True
        Me.chkSaveSetting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSaveSetting.Location = New System.Drawing.Point(175, 207)
        Me.chkSaveSetting.Name = "chkSaveSetting"
        Me.chkSaveSetting.Size = New System.Drawing.Size(95, 20)
        Me.chkSaveSetting.TabIndex = 14
        Me.chkSaveSetting.Values.Text = "Save settings"
        '
        'chkCopyClipboard
        '
        Me.chkCopyClipboard.Location = New System.Drawing.Point(175, 185)
        Me.chkCopyClipboard.Name = "chkCopyClipboard"
        Me.chkCopyClipboard.Size = New System.Drawing.Size(106, 20)
        Me.chkCopyClipboard.TabIndex = 14
        Me.chkCopyClipboard.Values.Text = "Copy clipboard"
        '
        'lnkLuuThongTinKetNoi
        '
        Me.lnkLuuThongTinKetNoi.Enabled = False
        Me.lnkLuuThongTinKetNoi.Location = New System.Drawing.Point(167, 162)
        Me.lnkLuuThongTinKetNoi.Name = "lnkLuuThongTinKetNoi"
        Me.lnkLuuThongTinKetNoi.Size = New System.Drawing.Size(125, 20)
        Me.lnkLuuThongTinKetNoi.TabIndex = 10
        Me.lnkLuuThongTinKetNoi.Values.Text = "Lưu thông tin kết nối"
        '
        'txtLoi
        '
        Me.txtLoi.Location = New System.Drawing.Point(94, 230)
        Me.txtLoi.Name = "txtLoi"
        Me.txtLoi.ReadOnly = True
        Me.txtLoi.Size = New System.Drawing.Size(198, 36)
        Me.txtLoi.TabIndex = 9
        Me.txtLoi.Text = ""
        '
        'btnTestKetNoi
        '
        Me.btnTestKetNoi.Location = New System.Drawing.Point(158, 111)
        Me.btnTestKetNoi.Name = "btnTestKetNoi"
        Me.btnTestKetNoi.Size = New System.Drawing.Size(132, 42)
        Me.btnTestKetNoi.TabIndex = 8
        Me.btnTestKetNoi.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Checked
        Me.btnTestKetNoi.Values.Text = "Kiểm tra kết nối"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(92, 81)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(198, 27)
        Me.txtPassword.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Text = "tmt123123"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(3, 83)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(65, 20)
        Me.KryptonLabel4.TabIndex = 6
        Me.KryptonLabel4.Values.Text = "Password: "
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(92, 55)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(198, 27)
        Me.txtUser.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.TabIndex = 5
        Me.txtUser.Text = "sa"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 57)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(38, 20)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Values.Text = "User: "
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(92, 29)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(198, 27)
        Me.txtDatabase.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatabase.TabIndex = 3
        Me.txtDatabase.Text = "QLCanXe"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 33)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Values.Text = "Database: "
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(92, 3)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(198, 27)
        Me.txtServer.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServer.TabIndex = 1
        Me.txtServer.Text = ".\SQLEXPRESS"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(83, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Server Name: "
        '
        'ctrlKetNoiDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlKetNoiDatabase"
        Me.Size = New System.Drawing.Size(295, 273)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtDatabase As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtServer As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUser As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnTestKetNoi As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtLoi As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents lnkLuuThongTinKetNoi As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents chkCopyClipboard As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkSaveSetting As ComponentFactory.Krypton.Toolkit.KryptonCheckBox

End Class
