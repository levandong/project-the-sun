Public Class frmThemThongTinLienHe
    Event ThemThongTinLienHeThanhCong(LienHe As tbChiTietLienHe)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtTenKhachHang.Text.Trim = "" Then
            ThongBao("Vui lòng nhập tên khách hàng")
        End If
        If txtEmail.Text.Trim = "" And txtSoDienThoai.Text.Trim = "" Then
            ThongBao("Vui lòng nhập số điện thoại hoặc email liên hệ")
        End If
        Dim newChiTietLienHe As New tbChiTietLienHe
        With newChiTietLienHe
            .TenNguoiLienHe = txtTenKhachHang.Text.Trim
            .SoDienThoai = txtSoDienThoai.Text.Trim
            .Email = txtEmail.Text.Trim
        End With
        RaiseEvent ThemThongTinLienHeThanhCong(newChiTietLienHe)
        Me.Close()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
    Private Sub frmSuaSamPham_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub txtTenKhachHang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenKhachHang.KeyPress, txtSoDienThoai.KeyPress, txtEmail.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class