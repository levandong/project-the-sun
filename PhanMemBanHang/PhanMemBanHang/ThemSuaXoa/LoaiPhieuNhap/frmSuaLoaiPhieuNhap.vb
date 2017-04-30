Public Class frmSuaLoaiPhieuNhap
    Event SuaLoaiPhieuNhapThanhCong(LoaiPhieuNhap As tbLoaiPhieuNhap)
    Public LoaiPhieuNhap As tbLoaiPhieuNhap
    Public LoaiPhieuNhaoBanDau As String

    Private Sub frmSuaLoaiPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtLoaiPhieuNhap.Text = LoaiPhieuNhap.LoaiPhieuNhap
        txtGhiChu.Text = LoaiPhieuNhap.MoTa
        txtLoaiPhieuNhap.Focus()
    End Sub

    Private Sub frmSuaLoaiPhieuNhap_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        undoChange()
    End Sub

    Private Sub frmSuaSamPham_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtLoaiPhieuNhap.Focus()
        If txtLoaiPhieuNhap.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập loại phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtLoaiPhieuNhap.Text <> LoaiPhieuNhaoBanDau Then
            If dt.tbLoaiPhieuNhaps.Where(Function(s) s.LoaiPhieuNhap = txtLoaiPhieuNhap.Text).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Loại phiếu nhập " + txtLoaiPhieuNhap.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        With LoaiPhieuNhap
            .LoaiPhieuNhap = txtLoaiPhieuNhap.Text.Trim
            .MoTa = txtGhiChu.Text.Trim
        End With
        Try
            dt.SubmitChanges()
            RaiseEvent SuaLoaiPhieuNhapThanhCong(LoaiPhieuNhap)
            Me.Close()
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm loại phiếu nhập thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        undoChange()
        Me.Close()
    End Sub
End Class