Public Class frmSuaNhomKhachHang
    Event ThemNhomKhachHangThanhCong(NhomKhachHang As tbNhomKhachHang)
    Public NhomKhachHang As tbNhomKhachHang
    Private TenNhomBanDau As String

    Private Sub frmSuaNhomKhachHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        txtNhomKhachHang.Text = NhomKhachHang.TenNhomKhachHang
        TenNhomBanDau = NhomKhachHang.TenNhomKhachHang
        txtGhiChu.Text = NhomKhachHang.GhiChu
        txtNhomKhachHang.Focus()
    End Sub

    Private Sub frmThemNhomKhachHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub frmThemNhomKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtNhomKhachHang.Focus()
        If txtNhomKhachHang.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập tên nhóm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If TenNhomBanDau <> txtNhomKhachHang.Text.Trim Then
            If dt.tbNhomKhachHangs.Where(Function(s) s.TenNhomKhachHang = txtNhomKhachHang.Text.Trim).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Nhóm " + txtNhomKhachHang.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        With NhomKhachHang
            .TenNhomKhachHang = txtNhomKhachHang.Text.Trim
            .GhiChu = txtGhiChu.Text.Trim
        End With
        Try
            dt.SubmitChanges()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Sửa nhóm khách hàng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class