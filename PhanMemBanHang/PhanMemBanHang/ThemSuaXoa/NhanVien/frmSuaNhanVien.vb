Public Class frmSuaNhanVien
    Event SuaThanhCongNhanVien()
    Public NhanVien As New tbNhanVien
    Public TenDangNhapBanDau As String

    Private Sub frmSuaNhanVien_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnLuu_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSuaNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        txtHoTen.Text = NhanVien.TenNhanVien
        txtTenDangNhap.Text = NhanVien.TenDangNhap
        txtMatKhau.Text = NhanVien.MatKhau
        txtSoDienThoai.Text = NhanVien.SoDienThoai
        txtChucVu.Text = NhanVien.ChucVu
        chkHopLe.Checked = NhanVien.HopLe
        chkToanQuyen.Checked = NhanVien.isToanQuyen
        txtEmail.Text = NhanVien.Email
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtTenDangNhap.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenDangNhap.Focus()
            Exit Sub
        End If
        If txtMatKhau.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMatKhau.Focus()
            Exit Sub
        End If
        If txtHoTen.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập họ tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHoTen.Focus()
            Exit Sub
        End If
        If txtTenDangNhap.Text <> TenDangNhapBanDau Then
            If dt.tbNhanViens.Count(Function(s) s.TenDangNhap = txtTenDangNhap.Text) > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tên đăng nhập " + txtTenDangNhap.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        With NhanVien
            .TenNhanVien = txtHoTen.Text
            .TenDangNhap = txtTenDangNhap.Text
            .MatKhau = txtMatKhau.Text
            .SoDienThoai = txtSoDienThoai.Text
            .ChucVu = txtChucVu.Text
            .HopLe = chkHopLe.Checked
            .isToanQuyen = chkToanQuyen.Checked
            .CapBat = cmbCapBat.SelectedIndex + 1
            .Email = txtEmail.Text
            If cmbCapBat.SelectedIndex = 2 Then
                .isToanQuyen = True
            End If
        End With

        Try
            dt.SubmitChanges()
            RaiseEvent SuaThanhCongNhanVien()
            Me.Close()
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Sửa nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        undoChange()
        Me.Close()
    End Sub

    Private Sub btnXemMatKhau_Click(sender As Object, e As EventArgs) Handles btnXemMatKhau.Click
        If txtMatKhau.UseSystemPasswordChar = True Then
            txtMatKhau.UseSystemPasswordChar = False
            txtMatKhau.PasswordChar = ""
        Else
            txtMatKhau.UseSystemPasswordChar = True
            txtMatKhau.PasswordChar = "*"
        End If
    End Sub
    Private Sub chkToanQuyen_CheckedChanged(sender As Object, e As EventArgs) Handles chkToanQuyen.CheckedChanged
        If chkToanQuyen.Checked Then
            cmbCapBat.SelectedIndex = 2
        End If
    End Sub

    Private Sub cmbCapBat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCapBat.SelectedIndexChanged
        If cmbCapBat.SelectedIndex = 2 Then
            chkToanQuyen.Checked = True
        End If
    End Sub

    Private Sub txtTenDangNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenDangNhap.KeyPress, txtSoDienThoai.KeyPress, txtMatKhau.KeyPress, txtHoTen.KeyPress, txtEmail.KeyPress, txtChucVu.KeyPress, cmbCapBat.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class