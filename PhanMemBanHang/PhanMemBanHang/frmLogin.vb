Public Class frmLogin
    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Dim userName As String = textUserName.Text.Trim
        Dim passWord As String = textPassword.Text.Trim

        If userName = "" Or passWord = "" Then
            ThongBao("Vui lòng nhập tài khoản, mật khẩu!")
            Exit Sub
        End If

        Dim TaiKhoan = dt.tbNhanViens.Where(Function(s) s.TenDangNhap = userName And s.MatKhau = passWord).FirstOrDefault
        If TaiKhoan Is Nothing Then
            ThongBao("Thông tin đăng nhập không đúng!")
            Exit Sub
        End If

        If Not TaiKhoan.HopLe Then
            ThongBao("Tài khoản đã bị khóa!")
            Exit Sub
        End If

        loginNhanVien = TaiKhoan
    End Sub
End Class