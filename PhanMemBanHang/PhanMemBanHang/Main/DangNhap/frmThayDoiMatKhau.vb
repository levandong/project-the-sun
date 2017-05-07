Public Class frmThayDoiMatKhau
    Private Sub frmThayDoiMatKhau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        lblTaiKhoan.Text = loginNhanVien.TenDangNhap
    End Sub

    Private Sub btnLuuLai_Click(sender As Object, e As EventArgs) Handles btnLuuLai.Click
        Dim taikhoan = (From tk In dt.tbNhanViens Where tk.TenDangNhap = loginNhanVien.TenDangNhap Select tk).First
        If txtMKHienTai.Text = "" Then
            lblThongBao.Visible = True
            lblThongBao.Text = "(*) Chưa nhập mật khẩu hiện tại."
            txtMKHienTai.Focus()
            Exit Sub
        End If
        If txtMKHienTai.Text <> taikhoan.MatKhau Then
            lblThongBao.Visible = True
            lblThongBao.Text = "(*) Mật khẩu hiện tại không đúng."
            txtMKHienTai.Focus()
            Exit Sub
        End If
        If txtMKMoi.Text = "" Then
            lblThongBao.Visible = True
            lblThongBao.Text = "(*) Chưa nhập mật khẩu mới."
            txtMKMoi.Focus()
            Exit Sub
        End If
        If txtMKNhapLai.Text <> txtMKMoi.Text Then
            lblThongBao.Visible = True
            lblThongBao.Text = "(*) Mật khẩu nhập lại không khớp."
            txtMKNhapLai.Focus()
            Exit Sub
        End If
        lblThongBao.Visible = False
        With taikhoan
            .MatKhau = txtMKMoi.Text
        End With
        dt.SubmitChanges()
        Me.Close()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmThayDoiMatKhau_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        undoChange()
    End Sub

    Private Sub frmThayDoiMatKhau_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Or e.KeyCode = Keys.Enter Then
            btnLuuLai_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub
End Class