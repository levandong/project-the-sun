Public Class frmThemLoaiSanPham
    Event ThemThanhCongLoaiSanPham()
    Private newLoaiSanPham As New tbLoaiSanPham
    Private luuTamLoaiSanPham As New tbLoaiSanPham
    Private Sub frmThemLoaiSanPham_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmThemLoaiSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtMaLoaiSanPham.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập mã loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMaLoaiSanPham.Focus()
            Exit Sub
        End If
        If txtTenLoaiSanPham.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập tên loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoaiSanPham.Focus()
            Exit Sub
        End If
        If dt.tbLoaiSanPhams.Count(Function(s) s.MaLoaiSanPham = txtMaLoaiSanPham.Text) > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã loại sản phẩm " + txtMaLoaiSanPham.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        With newLoaiSanPham
            .MaLoaiSanPham = txtMaLoaiSanPham.Text
            .TenLoaiSanPham = txtTenLoaiSanPham.Text
            .MoTa = txtGhiChu.Text
        End With

        dt.tbLoaiSanPhams.InsertOnSubmit(newLoaiSanPham)

        Try
            dt.SubmitChanges()
            RaiseEvent ThemThanhCongLoaiSanPham()
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm loại sản phẩm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

        If chkCopyLoaiSanPham.Checked Then
            luuTamLoaiSanPham = newLoaiSanPham
        End If

        newLoaiSanPham = New tbLoaiSanPham

        If chkCopyLoaiSanPham.Checked Then
            newLoaiSanPham.TenLoaiSanPham = luuTamLoaiSanPham.TenLoaiSanPham
            newLoaiSanPham.MaLoaiSanPham = luuTamLoaiSanPham.MaLoaiSanPham
            newLoaiSanPham.MoTa = luuTamLoaiSanPham.MoTa
        End If

        txtMaLoaiSanPham.Focus()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

End Class