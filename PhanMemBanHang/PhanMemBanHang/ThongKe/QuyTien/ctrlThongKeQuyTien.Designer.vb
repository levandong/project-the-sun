<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlThongKeQuyTien
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.bsQuyTien = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsQL = New PhanMemBanHang.dsQL()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.pnTheoNgay = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dtpTuNgay = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpDenNgay = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.pnTheoNam = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpThang = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonHeader2 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.nudQuyDauKy = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.btnLuu = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSoDong = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblDauKy = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTongThu = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTongChi = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCuoiKy = New System.Windows.Forms.ToolStripLabel()
        Me.btnTimKiem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.rdoTheoNgay = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rdoTheoThang = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        CType(Me.bsQuyTien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.pnTheoNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnTheoNgay.SuspendLayout()
        CType(Me.pnTheoNam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnTheoNam.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bsQuyTien
        '
        Me.bsQuyTien.DataMember = "prThongKeQuyTienMat"
        Me.bsQuyTien.DataSource = Me.dsQL
        '
        'dsQL
        '
        Me.dsQL.DataSetName = "dsQL"
        Me.dsQL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonPanel2)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonHeader2)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonPanel1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(746, 357)
        Me.KryptonSplitContainer1.SplitterDistance = 225
        Me.KryptonSplitContainer1.SplitterWidth = 2
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.rdoTheoThang)
        Me.KryptonPanel2.Controls.Add(Me.rdoTheoNgay)
        Me.KryptonPanel2.Controls.Add(Me.btnTimKiem)
        Me.KryptonPanel2.Controls.Add(Me.pnTheoNgay)
        Me.KryptonPanel2.Controls.Add(Me.pnTheoNam)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 82)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(225, 275)
        Me.KryptonPanel2.TabIndex = 23
        '
        'pnTheoNgay
        '
        Me.pnTheoNgay.Controls.Add(Me.dtpTuNgay)
        Me.pnTheoNgay.Controls.Add(Me.dtpDenNgay)
        Me.pnTheoNgay.Controls.Add(Me.KryptonLabel1)
        Me.pnTheoNgay.Controls.Add(Me.KryptonLabel2)
        Me.pnTheoNgay.Location = New System.Drawing.Point(23, 29)
        Me.pnTheoNgay.Name = "pnTheoNgay"
        Me.pnTheoNgay.Size = New System.Drawing.Size(192, 61)
        Me.pnTheoNgay.TabIndex = 15
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTuNgay.Location = New System.Drawing.Point(75, 1)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(111, 25)
        Me.dtpTuNgay.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTuNgay.TabIndex = 8
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDenNgay.Location = New System.Drawing.Point(75, 29)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(111, 25)
        Me.dtpDenNgay.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDenNgay.TabIndex = 9
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(61, 19)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 6
        Me.KryptonLabel1.Values.Text = "Từ Ngày"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 32)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(70, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 7
        Me.KryptonLabel2.Values.Text = "Đến Ngày"
        '
        'pnTheoNam
        '
        Me.pnTheoNam.Controls.Add(Me.KryptonLabel3)
        Me.pnTheoNam.Controls.Add(Me.dtpThang)
        Me.pnTheoNam.Location = New System.Drawing.Point(23, 122)
        Me.pnTheoNam.Name = "pnTheoNam"
        Me.pnTheoNam.Size = New System.Drawing.Size(192, 33)
        Me.pnTheoNam.TabIndex = 18
        Me.pnTheoNam.Visible = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(4, 6)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(49, 19)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 14
        Me.KryptonLabel3.Values.Text = "Tháng"
        '
        'dtpThang
        '
        Me.dtpThang.CustomFormat = "MM/yyyy"
        Me.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThang.Location = New System.Drawing.Point(75, 3)
        Me.dtpThang.Name = "dtpThang"
        Me.dtpThang.ShowUpDown = True
        Me.dtpThang.Size = New System.Drawing.Size(111, 25)
        Me.dtpThang.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpThang.TabIndex = 13
        '
        'KryptonHeader2
        '
        Me.KryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader2.Location = New System.Drawing.Point(0, 60)
        Me.KryptonHeader2.Name = "KryptonHeader2"
        Me.KryptonHeader2.Size = New System.Drawing.Size(225, 22)
        Me.KryptonHeader2.TabIndex = 22
        Me.KryptonHeader2.Values.Description = ""
        Me.KryptonHeader2.Values.Heading = "THỐNG KÊ"
        Me.KryptonHeader2.Values.Image = Nothing
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonHeader1)
        Me.KryptonPanel1.Controls.Add(Me.nudQuyDauKy)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(225, 60)
        Me.KryptonPanel1.TabIndex = 21
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(225, 22)
        Me.KryptonHeader1.TabIndex = 19
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "QUỸ TIỀN ĐẦU VÀO"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'nudQuyDauKy
        '
        Me.nudQuyDauKy.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnLuu})
        Me.nudQuyDauKy.Location = New System.Drawing.Point(9, 28)
        Me.nudQuyDauKy.Maximum = New Decimal(New Integer() {-469762049, -590869294, 5421010, 0})
        Me.nudQuyDauKy.Minimum = New Decimal(New Integer() {-469762049, -590869294, 5421010, -2147483648})
        Me.nudQuyDauKy.Name = "nudQuyDauKy"
        Me.nudQuyDauKy.Size = New System.Drawing.Size(206, 25)
        Me.nudQuyDauKy.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuyDauKy.TabIndex = 20
        Me.nudQuyDauKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudQuyDauKy.ThousandsSeparator = True
        '
        'btnLuu
        '
        Me.btnLuu.Image = Global.PhanMemBanHang.My.Resources.Resources.Luu16
        Me.btnLuu.UniqueName = "4E3E0480F28E41651BB404DC43EA5BDB"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsQuyTien"
        ReportDataSource1.Value = Me.bsQuyTien
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemBanHang.rptQuyTien.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(519, 357)
        Me.ReportViewer1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSoDong, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.lblDauKy, Me.ToolStripSeparator1, Me.ToolStripLabel6, Me.lblTongThu, Me.ToolStripSeparator4, Me.ToolStripLabel4, Me.lblTongChi, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.lblCuoiKy})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 332)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(514, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'lblSoDong
        '
        Me.lblSoDong.Name = "lblSoDong"
        Me.lblSoDong.Size = New System.Drawing.Size(13, 22)
        Me.lblSoDong.Text = "0"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripLabel1.Text = "DƯ ĐẦU KỲ:"
        '
        'lblDauKy
        '
        Me.lblDauKy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDauKy.Name = "lblDauKy"
        Me.lblDauKy.Size = New System.Drawing.Size(19, 22)
        Me.lblDauKy.Text = "0"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(34, 22)
        Me.ToolStripLabel6.Text = "THU:"
        '
        'lblTongThu
        '
        Me.lblTongThu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTongThu.Name = "lblTongThu"
        Me.lblTongThu.Size = New System.Drawing.Size(19, 22)
        Me.lblTongThu.Text = "0"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(30, 22)
        Me.ToolStripLabel4.Text = "CHI:"
        '
        'lblTongChi
        '
        Me.lblTongChi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTongChi.Name = "lblTongChi"
        Me.lblTongChi.Size = New System.Drawing.Size(19, 22)
        Me.lblTongChi.Text = "0"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripLabel2.Text = "DƯ CUỐI KỲ:"
        '
        'lblCuoiKy
        '
        Me.lblCuoiKy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCuoiKy.Name = "lblCuoiKy"
        Me.lblCuoiKy.Size = New System.Drawing.Size(19, 22)
        Me.lblCuoiKy.Text = "0"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.btnTimKiem.Location = New System.Drawing.Point(11, 161)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(207, 40)
        Me.btnTimKiem.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.btnTimKiem.StateCommon.Back.Color2 = System.Drawing.Color.Transparent
        Me.btnTimKiem.StateCommon.Border.Color1 = System.Drawing.Color.Transparent
        Me.btnTimKiem.StateCommon.Border.Color2 = System.Drawing.Color.Transparent
        Me.btnTimKiem.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnTimKiem.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnTimKiem.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnTimKiem.TabIndex = 48
        Me.btnTimKiem.Values.Image = Global.PhanMemBanHang.My.Resources.Resources.TimKiem32
        Me.btnTimKiem.Values.Text = "BÁO CÁO"
        '
        'rdoTheoNgay
        '
        Me.rdoTheoNgay.Checked = True
        Me.rdoTheoNgay.Location = New System.Drawing.Point(11, 7)
        Me.rdoTheoNgay.Name = "rdoTheoNgay"
        Me.rdoTheoNgay.Size = New System.Drawing.Size(86, 20)
        Me.rdoTheoNgay.TabIndex = 49
        Me.rdoTheoNgay.Values.Text = "Theo NGÀY"
        '
        'rdoTheoThang
        '
        Me.rdoTheoThang.Checked = True
        Me.rdoTheoThang.Location = New System.Drawing.Point(11, 99)
        Me.rdoTheoThang.Name = "rdoTheoThang"
        Me.rdoTheoThang.Size = New System.Drawing.Size(94, 20)
        Me.rdoTheoThang.TabIndex = 50
        Me.rdoTheoThang.Values.Text = "Theo THÁNG"
        '
        'ctrlThongKeQuyTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctrlThongKeQuyTien"
        Me.Size = New System.Drawing.Size(746, 357)
        CType(Me.bsQuyTien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.pnTheoNgay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnTheoNgay.ResumeLayout(False)
        Me.pnTheoNgay.PerformLayout()
        CType(Me.pnTheoNam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnTheoNam.ResumeLayout(False)
        Me.pnTheoNam.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents pnTheoNam As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dtpThang As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents pnTheoNgay As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dtpTuNgay As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dtpDenNgay As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblDauKy As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblTongThu As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblTongChi As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblCuoiKy As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblSoDong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents bsQuyTien As System.Windows.Forms.BindingSource
    Friend WithEvents dsQL As PhanMemBanHang.dsQL
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents nudQuyDauKy As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents btnLuu As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonHeader2 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnTimKiem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents rdoTheoThang As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rdoTheoNgay As ComponentFactory.Krypton.Toolkit.KryptonRadioButton

End Class
