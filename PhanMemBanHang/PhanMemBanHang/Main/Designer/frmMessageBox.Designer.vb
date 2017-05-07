<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessageBox))
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblNoiDung = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel()
        Me.btnNo = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnYes = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.lblNoiDung)
        Me.KryptonPanel1.Controls.Add(Me.btnNo)
        Me.KryptonPanel1.Controls.Add(Me.btnYes)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(584, 101)
        Me.KryptonPanel1.TabIndex = 0
        '
        'lblNoiDung
        '
        Me.lblNoiDung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoiDung.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblNoiDung.Location = New System.Drawing.Point(12, 25)
        Me.lblNoiDung.MaximumSize = New System.Drawing.Size(560, 0)
        Me.lblNoiDung.Name = "lblNoiDung"
        Me.lblNoiDung.Size = New System.Drawing.Size(127, 16)
        Me.lblNoiDung.StateCommon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoiDung.Text = "KryptonWrapLabel1"
        '
        'btnNo
        '
        Me.btnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNo.Location = New System.Drawing.Point(391, 64)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(90, 25)
        Me.btnNo.TabIndex = 1
        Me.btnNo.Values.Text = "&NO"
        '
        'btnYes
        '
        Me.btnYes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnYes.Location = New System.Drawing.Point(99, 64)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(90, 25)
        Me.btnYes.TabIndex = 0
        Me.btnYes.Values.Text = "&YES"
        '
        'frmMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 101)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XÁC NHẬN"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnYes As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnNo As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblNoiDung As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
End Class
