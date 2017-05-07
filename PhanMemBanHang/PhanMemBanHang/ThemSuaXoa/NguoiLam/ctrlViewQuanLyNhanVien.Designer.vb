<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlViewQuanLyNhanVien
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
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.CtrlThemSuaXoaNguoiLam1 = New PhanMemBanHang.ctrlThemSuaXoaNguoiLam()
        Me.CtrlThemSuaXoaNhanVien1 = New PhanMemBanHang.ctrlThemSuaXoaNhanVien()
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.KryptonHeader2 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.CtrlThemSuaXoaNhanVien1)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonHeader1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.CtrlThemSuaXoaNguoiLam1)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeader2)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1140, 608)
        Me.KryptonSplitContainer1.SplitterDistance = 285
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'CtrlThemSuaXoaNguoiLam1
        '
        Me.CtrlThemSuaXoaNguoiLam1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlThemSuaXoaNguoiLam1.Location = New System.Drawing.Point(22, 0)
        Me.CtrlThemSuaXoaNguoiLam1.Name = "CtrlThemSuaXoaNguoiLam1"
        Me.CtrlThemSuaXoaNguoiLam1.Size = New System.Drawing.Size(1118, 318)
        Me.CtrlThemSuaXoaNguoiLam1.TabIndex = 0
        '
        'CtrlThemSuaXoaNhanVien1
        '
        Me.CtrlThemSuaXoaNhanVien1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlThemSuaXoaNhanVien1.Location = New System.Drawing.Point(22, 0)
        Me.CtrlThemSuaXoaNhanVien1.Name = "CtrlThemSuaXoaNhanVien1"
        Me.CtrlThemSuaXoaNhanVien1.Size = New System.Drawing.Size(1118, 285)
        Me.CtrlThemSuaXoaNhanVien1.TabIndex = 0
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Left
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.KryptonHeader1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.KryptonHeader1.Size = New System.Drawing.Size(22, 285)
        Me.KryptonHeader1.TabIndex = 1
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "    TÀI KHOẢN ĐĂNG NHẬP"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'KryptonHeader2
        '
        Me.KryptonHeader2.Dock = System.Windows.Forms.DockStyle.Left
        Me.KryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader2.Name = "KryptonHeader2"
        Me.KryptonHeader2.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.KryptonHeader2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.KryptonHeader2.Size = New System.Drawing.Size(22, 318)
        Me.KryptonHeader2.TabIndex = 2
        Me.KryptonHeader2.Values.Description = ""
        Me.KryptonHeader2.Values.Heading = "    NHÂN VIÊN - NGƯỜI LÀM"
        Me.KryptonHeader2.Values.Image = Nothing
        '
        'ctrlViewQuanLyNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctrlViewQuanLyNhanVien"
        Me.Size = New System.Drawing.Size(1140, 608)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents CtrlThemSuaXoaNhanVien1 As ctrlThemSuaXoaNhanVien
    Friend WithEvents CtrlThemSuaXoaNguoiLam1 As ctrlThemSuaXoaNguoiLam
    Friend WithEvents KryptonHeader2 As ComponentFactory.Krypton.Toolkit.KryptonHeader
End Class
