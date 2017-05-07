Public Class frmSuaLoaiPhieuXuat
    Event SuaLoaiPhieuXuatThanhCong(LoaiPhieuXuat As tbLoaiPhieuXuat)
    Public LoaiPhieuXuat As tbLoaiPhieuXuat
    Public LoaiPhieuXuatBanDau As String

    Private Sub frmSuaLoaiPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtLoaiPhieuXuat.Text = LoaiPhieuXuat.LoaiPhieuXuat
        txtGhiChu.Text = LoaiPhieuXuat.MoTa
        txtLoaiPhieuXuat.Focus()
    End Sub

    Private Sub frmSuaLoaiPhieuXuat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
        txtLoaiPhieuXuat.Focus()
        If txtLoaiPhieuXuat.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập loại phiếu xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtLoaiPhieuXuat.Text <> LoaiPhieuXuatBanDau Then
            If dt.tbLoaiPhieuXuats.Where(Function(s) s.LoaiPhieuXuat = txtLoaiPhieuXuat.Text).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Loại phiếu xuất " + txtLoaiPhieuXuat.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        With LoaiPhieuXuat
            .LoaiPhieuXuat = txtLoaiPhieuXuat.Text.Trim
            .MoTa = txtGhiChu.Text.Trim
        End With
        Try
            dt.SubmitChanges()
            RaiseEvent SuaLoaiPhieuXuatThanhCong(LoaiPhieuXuat)
            Me.Close()
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm loại phiếu xuất thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        undoChange()
        Me.Close()
    End Sub
End Class