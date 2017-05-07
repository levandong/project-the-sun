Public Class frmSuaLoaiPhieuChi
    Event SuaLoaiPhieuChiThanhCong(LoaiPhieuChi As tbLoaiPhieuChi)
    Public LoaiPhieuChi As tbLoaiPhieuChi
    Public LoaiPhieuChiBanDau As String

    Private Sub frmSuaLoaiPhieuChi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtLoaiPhieuChi.Text = LoaiPhieuChi.LoaiChi
        txtGhiChu.Text = LoaiPhieuChi.MoTa
        txtLoaiPhieuChi.Focus()
    End Sub

    Private Sub frmSuaLoaiPhieuChi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        undoChange()
    End Sub

    Private Sub frmSuaSamPham_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub txtLoaiPhieuChi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoaiPhieuChi.KeyPress, txtGhiChu.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then 'Hoặc Convert.ToChar(Keys.Enter)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtLoaiPhieuChi.Focus()
        If txtLoaiPhieuChi.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập loại phiếu chi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtLoaiPhieuChi.Text <> LoaiPhieuChiBanDau Then
            If dt.tbLoaiPhieuChis.Where(Function(s) s.LoaiChi = txtLoaiPhieuChi.Text.Trim).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Loại phiếu chi " + txtLoaiPhieuChi.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        With LoaiPhieuChi
            .LoaiChi = txtLoaiPhieuChi.Text.Trim
            .MoTa = txtGhiChu.Text.Trim
        End With
        Try
            dt.SubmitChanges()
            RaiseEvent SuaLoaiPhieuChiThanhCong(LoaiPhieuChi)
            Me.Close()
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm loại phiếu chi thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        undoChange()
        Me.Close()
    End Sub
End Class