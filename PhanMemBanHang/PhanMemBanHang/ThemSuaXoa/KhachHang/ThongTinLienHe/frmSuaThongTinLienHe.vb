Public Class frmSuaThongTinLienHe
    Public ChiTietLienHe As tbChiTietLienHe
    Event ThemThongTinLienHeThanhCong(ChiTiet As tbChiTietLienHe)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtTenKhachHang.Text.Trim = "" Then
            ThongBao("Tên khách hàng không được bỏ trống.")
        End If
        With ChiTietLienHe
            .SoDienThoai = txtSoDienThoai.Text.Trim
            .Email = txtEmail.Text.Trim
            .TenNguoiLienHe = txtTenKhachHang.Text.Trim
        End With
        'dt.SubmitChanges()
        RaiseEvent ThemThongTinLienHeThanhCong(ChiTietLienHe)
        Me.Close()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmSuaThongTinLienHe_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtEmail.Text = ChiTietLienHe.Email.Trim
        txtTenKhachHang.Text = ChiTietLienHe.TenNguoiLienHe.Trim
        txtSoDienThoai.Text = ChiTietLienHe.SoDienThoai.Trim
    End Sub
    Private Sub frmSuaSamPham_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtTenKhachHang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenKhachHang.KeyPress, txtSoDienThoai.KeyPress, txtTenKhachHang.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class