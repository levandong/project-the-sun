<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCauHinhTimKiemSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCauHinhTimKiemSanPham))
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnApDung = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudSoDong = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.nudDelay = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnApDung)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.nudSoDong)
        Me.KryptonPanel1.Controls.Add(Me.nudDelay)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(354, 123)
        Me.KryptonPanel1.TabIndex = 1
        '
        'btnApDung
        '
        Me.btnApDung.Location = New System.Drawing.Point(238, 80)
        Me.btnApDung.Name = "btnApDung"
        Me.btnApDung.Size = New System.Drawing.Size(104, 31)
        Me.btnApDung.TabIndex = 7
        Me.btnApDung.Values.Text = "ÁP DỤNG [F2]"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(209, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(104, 20)
        Me.KryptonLabel3.TabIndex = 6
        Me.KryptonLabel3.Values.Text = "Số dòng hiển thị:"
        '
        'nudSoDong
        '
        Me.nudSoDong.Location = New System.Drawing.Point(238, 38)
        Me.nudSoDong.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.nudSoDong.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSoDong.Name = "nudSoDong"
        Me.nudSoDong.Size = New System.Drawing.Size(75, 28)
        Me.nudSoDong.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSoDong.TabIndex = 5
        Me.nudSoDong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudSoDong.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'nudDelay
        '
        Me.nudDelay.Location = New System.Drawing.Point(41, 38)
        Me.nudDelay.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.nudDelay.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudDelay.Name = "nudDelay"
        Me.nudDelay.Size = New System.Drawing.Size(75, 28)
        Me.nudDelay.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDelay.TabIndex = 4
        Me.nudDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudDelay.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(152, 20)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Values.Text = "Tìm kiếm chậm (mili giây):"
        '
        'frmCauHinhTimKiemSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 123)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCauHinhTimKiemSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cấu hình tìm kiếm"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnApDung As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudSoDong As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nudDelay As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
