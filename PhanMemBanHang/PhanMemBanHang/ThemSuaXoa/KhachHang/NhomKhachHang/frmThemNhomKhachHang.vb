Public Class frmThemNhomKhachHang
    Event ThemNhomKhachHangThanhCong(NhomKhachHang As tbNhomKhachHang)
    Private newNhomKhachHang As tbNhomKhachHang


    Private Sub frmThemNhomKhachHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
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

        If dt.tbNhomKhachHangs.Where(Function(s) s.TenNhomKhachHang = txtNhomKhachHang.Text.Trim).Count > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Nhóm " + txtNhomKhachHang.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        newNhomKhachHang = New tbNhomKhachHang
        With newNhomKhachHang
            .TenNhomKhachHang = txtNhomKhachHang.Text.Trim
            .GhiChu = txtGhiChu.Text.Trim
        End With
        ' thêm sản phẩm vào dánh sách sản phẩm
        dt.tbNhomKhachHangs.InsertOnSubmit(newNhomKhachHang)
        Try
            dt.SubmitChanges()
            RaiseEvent ThemNhomKhachHangThanhCong(newNhomKhachHang)
            If chkCopyNhomKhachHang.Checked = False Then
                Me.Close()
            End If
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm nhóm khách hàng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        txtNhomKhachHang.Focus()
        txtNhomKhachHang.SelectAll()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

End Class