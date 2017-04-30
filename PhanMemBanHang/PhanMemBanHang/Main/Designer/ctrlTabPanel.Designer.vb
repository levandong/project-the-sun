<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlTabPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlTabPanel))
        Me.pnlHeader = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnClose = New ComponentFactory.Krypton.Toolkit.KryptonDropButton()
        Me.KryptonContextMenu1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenu()
        Me.KryptonContextMenuItems1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.cmiDongTatCaTruTabDangChon = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmiDongTabBenTrai = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmiDongTabBenPhai = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmiDongTatCaTab = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmiMoLaiTabVuaDong = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.KryptonContextMenuItems2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuItems3 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.pnlMain = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLinkLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLinkLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPhienBan = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkSet = New ComponentFactory.Krypton.Toolkit.KryptonCheckSet(Me.components)
        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(633, 30)
        Me.pnlHeader.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.KryptonContextMenu = Me.KryptonContextMenu1
        Me.btnClose.Location = New System.Drawing.Point(633, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(37, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Values.Image = CType(resources.GetObject("btnClose.Values.Image"), System.Drawing.Image)
        Me.btnClose.Values.Text = ""
        Me.btnClose.Visible = False
        '
        'KryptonContextMenu1
        '
        Me.KryptonContextMenu1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItems1, Me.KryptonContextMenuItems2, Me.KryptonContextMenuItems3})
        '
        'KryptonContextMenuItems1
        '
        Me.KryptonContextMenuItems1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.cmiDongTatCaTruTabDangChon, Me.cmiDongTabBenTrai, Me.cmiDongTabBenPhai, Me.cmiDongTatCaTab, Me.cmiMoLaiTabVuaDong})
        '
        'cmiDongTatCaTruTabDangChon
        '
        Me.cmiDongTatCaTruTabDangChon.Text = "Đóng tất cả trừ TAB đang chọn"
        '
        'cmiDongTabBenTrai
        '
        Me.cmiDongTabBenTrai.Text = "Đóng TAB bên trái"
        '
        'cmiDongTabBenPhai
        '
        Me.cmiDongTabBenPhai.Text = "Đóng TAB bên phải"
        '
        'cmiDongTatCaTab
        '
        Me.cmiDongTatCaTab.Text = "Đóng tất cả TAB"
        '
        'cmiMoLaiTabVuaDong
        '
        Me.cmiMoLaiTabVuaDong.Text = "Mở lại TAB vừa đóng"
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.KryptonSplitContainer1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(670, 299)
        Me.pnlMain.TabIndex = 1
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.IsSplitterFixed = True
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.pnlHeader)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnClose)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonPanel1)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(670, 299)
        Me.KryptonSplitContainer1.SplitterDistance = 30
        Me.KryptonSplitContainer1.SplitterWidth = 1
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.PictureBox1)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLinkLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLinkLabel1)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.lblPhienBan)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(670, 268)
        Me.KryptonPanel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PhanMemBanHang.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(17, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(449, 146)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(15, 20)
        Me.KryptonLabel1.TabIndex = 23
        Me.KryptonLabel1.Values.Text = "-"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(286, 172)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel9.TabIndex = 22
        Me.KryptonLabel9.Values.Text = "(08) 3847 1756 "
        '
        'KryptonLinkLabel2
        '
        Me.KryptonLinkLabel2.Location = New System.Drawing.Point(286, 146)
        Me.KryptonLinkLabel2.Name = "KryptonLinkLabel2"
        Me.KryptonLinkLabel2.Size = New System.Drawing.Size(159, 20)
        Me.KryptonLinkLabel2.TabIndex = 21
        Me.KryptonLinkLabel2.Values.Text = "www.truongminhthinh.com"
        '
        'KryptonLinkLabel1
        '
        Me.KryptonLinkLabel1.Location = New System.Drawing.Point(473, 146)
        Me.KryptonLinkLabel1.Name = "KryptonLinkLabel1"
        Me.KryptonLinkLabel1.Size = New System.Drawing.Size(141, 20)
        Me.KryptonLinkLabel1.TabIndex = 20
        Me.KryptonLinkLabel1.Values.Text = "www.phanmemtmt.com"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(286, 123)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(265, 16)
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 19
        Me.KryptonLabel8.Values.Text = "CTY TRƯỜNG MINH THỊNH (TMT SOLUTIONS)"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonLabel4.Location = New System.Drawing.Point(125, 60)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(307, 29)
        Me.KryptonLabel4.TabIndex = 18
        Me.KryptonLabel4.Values.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG"
        '
        'lblPhienBan
        '
        Me.lblPhienBan.Location = New System.Drawing.Point(286, 95)
        Me.lblPhienBan.Name = "lblPhienBan"
        Me.lblPhienBan.Size = New System.Drawing.Size(74, 20)
        Me.lblPhienBan.TabIndex = 18
        Me.lblPhienBan.Values.Text = "lblPhienBan"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(213, 146)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(57, 20)
        Me.KryptonLabel6.TabIndex = 17
        Me.KryptonLabel6.Values.Text = "Website:"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(213, 172)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(52, 20)
        Me.KryptonLabel5.TabIndex = 16
        Me.KryptonLabel5.Values.Text = "Liên hệ:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(213, 121)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(71, 20)
        Me.KryptonLabel3.TabIndex = 14
        Me.KryptonLabel3.Values.Text = "Bản quyền:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(213, 95)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(67, 20)
        Me.KryptonLabel2.TabIndex = 13
        Me.KryptonLabel2.Values.Text = "Phiên bản:"
        '
        'chkSet
        '
        '
        'ctrlTabPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "ctrlTabPanel"
        Me.Size = New System.Drawing.Size(670, 299)
        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnClose As ComponentFactory.Krypton.Toolkit.KryptonDropButton
    Friend WithEvents pnlMain As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents chkSet As ComponentFactory.Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents KryptonContextMenu1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents KryptonContextMenuItems1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmiDongTatCaTruTabDangChon As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmiDongTabBenTrai As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmiDongTabBenPhai As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents KryptonContextMenuItems2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuItems3 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmiMoLaiTabVuaDong As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmiDongTatCaTab As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLinkLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLinkLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPhienBan As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
