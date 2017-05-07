Public Class frmThemNhanVien
    Event ThemThanhCongNhanVien()
    Private newNhanVien As New tbNhanVien
    Private luuTamNhanVien As New tbNhanVien

    Private Sub frmThemNhanVien_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmThemNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        newNhanVien.HopLe = True
        newNhanVien.isToanQuyen = True
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
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
        If dt.tbNhanViens.Count(Function(s) s.TenDangNhap = txtTenDangNhap.Text) > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tên đăng nhập " + txtTenDangNhap.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        With newNhanVien
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

        dt.tbNhanViens.InsertOnSubmit(newNhanVien)

        Try
            dt.SubmitChanges()
            'Thêm quyền cho nhân viên
            For Each qn In dt.tbQuyens
                Dim newPhanQuyen As New tbPhanQuyen
                newPhanQuyen.idQuyen = qn.id
                newPhanQuyen.idNhanVien = newNhanVien.id
                newPhanQuyen.TrangThai = True
                dt.tbPhanQuyens.InsertOnSubmit(newPhanQuyen)
                dt.SubmitChanges()
            Next
            RaiseEvent ThemThanhCongNhanVien()
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

        If chkCopyNhanVien.Checked Then
            luuTamNhanVien = newNhanVien
        End If

        newNhanVien = New tbNhanVien

        If chkCopyNhanVien.Checked Then
            newNhanVien.TenDangNhap = luuTamNhanVien.TenDangNhap
            newNhanVien.MatKhau = luuTamNhanVien.MatKhau
            newNhanVien.TenNhanVien = luuTamNhanVien.TenNhanVien
            newNhanVien.ChucVu = luuTamNhanVien.ChucVu
            newNhanVien.HopLe = luuTamNhanVien.HopLe
            newNhanVien.SoDienThoai = luuTamNhanVien.SoDienThoai
            newNhanVien.isToanQuyen = luuTamNhanVien.isToanQuyen
        Else
            newNhanVien.HopLe = True
        End If

        txtTenDangNhap.Focus()
    End Sub
    Private Sub txtMaVach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChucVu.KeyPress, txtTenDangNhap.KeyPress, txtSoDienThoai.KeyPress, txtMatKhau.KeyPress, txtHoTen.KeyPress, txtEmail.KeyPress, cmbCapBat.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then 'Hoặc Convert.ToChar(Keys.Enter)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
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

End Class