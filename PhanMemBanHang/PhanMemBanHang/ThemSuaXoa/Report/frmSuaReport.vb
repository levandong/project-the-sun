Public Class frmSuaReport

    Event SuaReportThanhCong()
    Private _Report As tbReport
    Property Report As tbReport
        Get
            Return _Report
        End Get
        Set(value As tbReport)
            _Report = value
            If value IsNot Nothing Then
                TenReportBanDau = Report.TenReport

                txtTenReport.Text = Report.TenReport
                txtCoGiay.Text = Report.Size
                txtRDLC.Text = Report.FileRDLC
                txtMayInMacDinh.Text = Report.TenMayIn
                txtMoTa.Text = Report.MoTa

                nudTop.Value = Report.MarginTop
                nudBottom.Value = Report.MarginBot
                nudLeft.Value = Report.MarginLeft
                nudRight.Value = Report.MarginRight

                nudRong.Value = Report.SizeWidth
                nudDai.Value = Report.SizeHeight
                nudPRong.Value = Report.PixelWidth
                nudPDai.Value = Report.PixelHeight
            End If
        End Set
    End Property

    Public TenReportBanDau As String

    Private Sub frmThemReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtTenReport.Focus()
    End Sub

    Private Sub frmSuaReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtTenReport.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập tên biểu mẫu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtCoGiay.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập cỡ giấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtRDLC.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn file report(RDLC)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtMayInMacDinh.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn máy in mặc định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtTenReport.Text.Trim <> TenReportBanDau Then
            If dt.tbReports.Where(Function(s) s.TenReport = txtTenReport.Text.Trim).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Report " + txtTenReport.Text.Trim + " đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        With Report
            .TenReport = txtTenReport.Text.Trim
            .Size = txtCoGiay.Text.Trim
            .FileRDLC = txtRDLC.Text.Trim
            .TenMayIn = txtMayInMacDinh.Text.Trim
            .MoTa = txtMoTa.Text.Trim

            .MarginTop = nudTop.Value
            .MarginBot = nudBottom.Value
            .MarginLeft = nudLeft.Value
            .MarginRight = nudRight.Value

            .SizeWidth = nudRong.Value
            .SizeHeight = nudDai.Value
            .PixelWidth = nudPRong.Value
            .PixelHeight = nudPDai.Value
        End With

        Try
            dt.SubmitChanges()
            RaiseEvent SuaReportThanhCong()
            Me.Close()
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Sửa biểu mẫu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        undoChange()
        Me.Close()
    End Sub

    Private Sub btnChonMayIn_Click(sender As Object, e As EventArgs) Handles btnChonMayIn.Click
        Dim frm As New frmChonMayIn
        If frm.ShowDialog = DialogResult.OK Then
            txtMayInMacDinh.Text = frm.TenMayIn
        End If
    End Sub

    Private Sub btnChonDuongDan_Click(sender As Object, e As EventArgs) Handles btnChonDuongDan.Click
        Dim openFile As New OpenFileDialog
        openFile.InitialDirectory = Application.StartupPath + "\Report"
        openFile.Filter = "Report files (*.rdlc)|*.rdlc"
        If (openFile.ShowDialog) = DialogResult.OK Then
            txtRDLC.Text = "." + openFile.FileName.Substring(Application.StartupPath.Length)
        End If
    End Sub

    Private Sub frmSuaReport_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnSua_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub
End Class