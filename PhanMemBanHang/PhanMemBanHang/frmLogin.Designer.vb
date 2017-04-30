<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.kryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.textPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.textUserName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.buttonLogin = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.checkRememberMe = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox1.Panel.SuspendLayout()
        Me.kryptonGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'kryptonLabel2
        '
        Me.kryptonLabel2.Location = New System.Drawing.Point(203, 67)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(99, 26)
        Me.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.White
        Me.kryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel2.TabIndex = 15
        Me.kryptonLabel2.Values.Text = "Mật khẩu:"
        '
        'kryptonLabel1
        '
        Me.kryptonLabel1.Location = New System.Drawing.Point(48, 163)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(257, 26)
        Me.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White
        Me.kryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel1.TabIndex = 14
        Me.kryptonLabel1.Values.Text = "Ghi nhớ tài khoản, mật khẩu"
        '
        'textPassword
        '
        Me.textPassword.Location = New System.Drawing.Point(203, 99)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.textPassword.Size = New System.Drawing.Size(180, 41)
        Me.textPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.textPassword.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.textPassword.StateCommon.Border.Rounding = 10
        Me.textPassword.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.TabIndex = 12
        Me.textPassword.UseSystemPasswordChar = True
        '
        'textUserName
        '
        Me.textUserName.Location = New System.Drawing.Point(17, 99)
        Me.textUserName.Name = "textUserName"
        Me.textUserName.Size = New System.Drawing.Size(180, 41)
        Me.textUserName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.textUserName.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.textUserName.StateCommon.Border.Rounding = 10
        Me.textUserName.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textUserName.TabIndex = 11
        '
        'buttonLogin
        '
        Me.buttonLogin.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster
        Me.buttonLogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.buttonLogin.Location = New System.Drawing.Point(389, 0)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(108, 220)
        Me.buttonLogin.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonLogin.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.buttonLogin.TabIndex = 13
        Me.buttonLogin.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.Login_64
        Me.buttonLogin.Values.Text = "GO"
        '
        'kryptonLabel3
        '
        Me.kryptonLabel3.Location = New System.Drawing.Point(5, 11)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(129, 26)
        Me.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.White
        Me.kryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel3.TabIndex = 6
        Me.kryptonLabel3.Values.Text = "ĐĂNG NHẬP"
        '
        'kryptonLabel4
        '
        Me.kryptonLabel4.Location = New System.Drawing.Point(17, 67)
        Me.kryptonLabel4.Name = "kryptonLabel4"
        Me.kryptonLabel4.Size = New System.Drawing.Size(104, 26)
        Me.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.White
        Me.kryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel4.TabIndex = 18
        Me.kryptonLabel4.Values.Text = "Tài khoản:"
        '
        'checkRememberMe
        '
        Me.checkRememberMe.Location = New System.Drawing.Point(17, 164)
        Me.checkRememberMe.Name = "checkRememberMe"
        Me.checkRememberMe.Size = New System.Drawing.Size(25, 25)
        Me.checkRememberMe.StateCheckedNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.checkRememberMe.StateCheckedNormal.Border.Rounding = 100
        Me.checkRememberMe.StateCheckedPressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.checkRememberMe.StateCheckedPressed.Border.Rounding = 100
        Me.checkRememberMe.StateCheckedTracking.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.checkRememberMe.StateCheckedTracking.Border.Rounding = 100
        Me.checkRememberMe.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.checkRememberMe.StateCommon.Border.Rounding = 100
        Me.checkRememberMe.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.checkRememberMe.StateNormal.Border.Rounding = 100
        Me.checkRememberMe.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.checkRememberMe.StatePressed.Border.Rounding = 100
        Me.checkRememberMe.StateTracking.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.checkRememberMe.StateTracking.Border.Rounding = 100
        Me.checkRememberMe.TabIndex = 17
        Me.checkRememberMe.Values.Text = ""
        '
        'kryptonGroupBox1
        '
        Me.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonGroupBox1.Name = "kryptonGroupBox1"
        '
        'kryptonGroupBox1.Panel
        '
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonLabel3)
        Me.kryptonGroupBox1.Size = New System.Drawing.Size(389, 50)
        Me.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.kryptonGroupBox1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.kryptonGroupBox1.TabIndex = 16
        Me.kryptonGroupBox1.Values.Heading = ""
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(497, 220)
        Me.Controls.Add(Me.kryptonGroupBox1)
        Me.Controls.Add(Me.kryptonLabel2)
        Me.Controls.Add(Me.kryptonLabel1)
        Me.Controls.Add(Me.textPassword)
        Me.Controls.Add(Me.textUserName)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.kryptonLabel4)
        Me.Controls.Add(Me.checkRememberMe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.StateCommon.Border.Rounding = 20
        Me.Text = "frmLogin"
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.Panel.ResumeLayout(False)
        Me.kryptonGroupBox1.Panel.PerformLayout()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents kryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents kryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents textPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents textUserName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents buttonLogin As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents kryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents kryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents checkRememberMe As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Private WithEvents kryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
End Class
