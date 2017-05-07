Public Class frmSuaLoaiSanPham
    Event SuaThanhCongLoaiSanPham()
    Public LoaiSanPham As tbLoaiSanPham
    Public MaLoaiBanDau As String

    Private Sub frmSuaLoaiSanPham_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub frmSuaLoaiSanPham_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnLuu_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSuaLoaiSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        MaLoaiBanDau = LoaiSanPham.MaLoaiSanPham
        txtMaLoaiSanPham.Text = LoaiSanPham.MaLoaiSanPham
        txtTenLoaiSanPham.Text = LoaiSanPham.TenLoaiSanPham
        txtGhiChu.Text = LoaiSanPham.MoTa
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
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

        If txtMaLoaiSanPham.Text <> MaLoaiBanDau Then
            If dt.tbLoaiSanPhams.Count(Function(s) s.MaLoaiSanPham = txtMaLoaiSanPham.Text) > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã loại sản phẩm " + txtMaLoaiSanPham.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        LoaiSanPham.MaLoaiSanPham = txtMaLoaiSanPham.Text
        LoaiSanPham.TenLoaiSanPham = txtTenLoaiSanPham.Text
        LoaiSanPham.MoTa = txtGhiChu.Text

        Try
            dt.SubmitChanges()
            RaiseEvent SuaThanhCongLoaiSanPham()
            Me.Close()
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Sửa loại sản phẩm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class