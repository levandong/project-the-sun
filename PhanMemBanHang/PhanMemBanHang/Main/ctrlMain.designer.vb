<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlMain
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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.CtrlTabPanel1 = New PhanMemBanHang.ctrlTabPanel()
        Me.KryptonPanel3 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.CtrlRibbon1 = New PhanMemBanHang.ctrlRibbon()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.CtrlTabPanel1)
        Me.KryptonPanel1.Controls.Add(Me.KryptonPanel3)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1045, 529)
        Me.KryptonPanel1.TabIndex = 0
        '
        'CtrlTabPanel1
        '
        Me.CtrlTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlTabPanel1.Location = New System.Drawing.Point(0, 117)
        Me.CtrlTabPanel1.Name = "CtrlTabPanel1"
        Me.CtrlTabPanel1.Size = New System.Drawing.Size(1045, 412)
        Me.CtrlTabPanel1.TabIndex = 8
        '
        'KryptonPanel3
        '
        Me.KryptonPanel3.Controls.Add(Me.CtrlRibbon1)
        Me.KryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel3.Name = "KryptonPanel3"
        Me.KryptonPanel3.Size = New System.Drawing.Size(1045, 117)
        Me.KryptonPanel3.TabIndex = 7
        '
        'CtrlRibbon1
        '
        Me.CtrlRibbon1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlRibbon1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlRibbon1.Name = "CtrlRibbon1"
        Me.CtrlRibbon1.Size = New System.Drawing.Size(1045, 117)
        Me.CtrlRibbon1.TabIndex = 19
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ctrlMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "ctrlMain"
        Me.Size = New System.Drawing.Size(1045, 529)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents KryptonPanel3 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents CtrlRibbon1 As PhanMemBanHang.ctrlRibbon
    Friend WithEvents CtrlTabPanel1 As PhanMemBanHang.ctrlTabPanel

End Class
