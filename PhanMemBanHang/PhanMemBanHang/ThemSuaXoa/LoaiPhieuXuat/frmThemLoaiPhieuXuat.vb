Public Class frmThemLoaiPhieuXuat
    Event ThemLoaiPhieuXuatThanhCong(LoaiPhieuXuat As tbLoaiPhieuXuat)
    Private newLoaiPhieuXuat As New tbLoaiPhieuXuat


    Private Sub frmThemLoaiPhieuXuat_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        txtLoaiPhieuXuat.Focus()
    End Sub

    Private Sub frmThemLoaiPhieuXuat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub frmThemLoaiPhieuXuat_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

        If dt.tbLoaiPhieuXuats.Where(Function(s) s.LoaiPhieuXuat = txtLoaiPhieuXuat.Text.Trim).Count > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Loại phiếu xuất " + txtLoaiPhieuXuat.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        With newLoaiPhieuXuat
            .LoaiPhieuXuat = txtLoaiPhieuXuat.Text.Trim
            .MoTa = txtGhiChu.Text.Trim
        End With
        ' thêm sản phẩm vào dánh sách sản phẩm
        dt.tbLoaiPhieuXuats.InsertOnSubmit(newLoaiPhieuXuat)
        Try
            dt.SubmitChanges()
            RaiseEvent ThemLoaiPhieuXuatThanhCong(newLoaiPhieuXuat)
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm loại phiếu xuất thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

        If chkCopyLoaiPhieuXuat.Checked = False Then
            txtGhiChu.Clear()
            txtLoaiPhieuXuat.Clear()
        End If

        newLoaiPhieuXuat = New tbLoaiPhieuXuat

        txtLoaiPhieuXuat.Focus()
        txtLoaiPhieuXuat.SelectAll()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class