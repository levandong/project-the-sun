<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlTabHeader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlTabHeader))
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnClose = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.chkCheck = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.AutoSize = True
        Me.KryptonPanel1.Controls.Add(Me.btnClose)
        Me.KryptonPanel1.Controls.Add(Me.chkCheck)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(107, 30)
        Me.KryptonPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(89, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(14, 14)
        Me.btnClose.StateCommon.Back.Image = CType(resources.GetObject("btnClose.StateCommon.Back.Image"), System.Drawing.Image)
        Me.btnClose.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch
        Me.btnClose.StateCommon.Border.Color1 = System.Drawing.Color.Red
        Me.btnClose.StateCommon.Border.Color2 = System.Drawing.Color.Red
        Me.btnClose.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnClose.StateCommon.Border.Rounding = 0
        Me.btnClose.StateCommon.Border.Width = 1
        Me.btnClose.TabIndex = 6
        Me.btnClose.Values.Image = CType(resources.GetObject("btnClose.Values.Image"), System.Drawing.Image)
        Me.btnClose.Values.Text = "KryptonButton1"
        Me.btnClose.Visible = False
        '
        'chkCheck
        '
        Me.chkCheck.AutoSize = True
        Me.chkCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.chkCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCheck.Location = New System.Drawing.Point(0, 0)
        Me.chkCheck.MinimumSize = New System.Drawing.Size(50, 30)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Size = New System.Drawing.Size(107, 30)
        Me.chkCheck.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.chkCheck.StateCommon.Border.Rounding = 0
        Me.chkCheck.StateCommon.Border.Width = 1
        Me.chkCheck.TabIndex = 5
        Me.chkCheck.Values.Text = "NameOfTab"
        '
        'ctrlTabHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlTabHeader"
        Me.Size = New System.Drawing.Size(107, 30)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents chkCheck As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents btnClose As ComponentFactory.Krypton.Toolkit.KryptonButton

End Class
