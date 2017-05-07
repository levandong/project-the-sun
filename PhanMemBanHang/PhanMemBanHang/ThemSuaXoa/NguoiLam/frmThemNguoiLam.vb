Public Class frmThemNguoiLam

    Private Sub frmThemNguoiLam_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnLuu_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmThemNguoiLam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaNguoiLam.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập mã người làm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMaNguoiLam.Focus()
            Exit Sub
        End If

        If txtHoTen.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập họ tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHoTen.Focus()
            Exit Sub
        End If

        If dt.tbNguoiLams.Count(Function(s) s.MaNguoiLam = txtMaNguoiLam.Text.Trim) > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã " + txtMaNguoiLam.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim newNguoiLam As New tbNguoiLam
        With newNguoiLam
            .TenNguoiLam = txtHoTen.Text.Trim
            .TenNguoiLamString = mdlGlobals.BoDauTiengViet(txtHoTen.Text.Trim)
            .MaNguoiLam = txtMaNguoiLam.Text.Trim
            .MaNguoiLamString = mdlGlobals.BoDauTiengViet(txtMaNguoiLam.Text.Trim)
            .CMND = txtCMND.Text.Trim
            .SoDienThoai = txtSoDienThoai.Text.Trim
            .DiaChi = txtDiaChi.Text
            .GioiTinh = rdoNam.Checked
            .NgayVaoLam = dtpNgayVaoLam.Value.Date
            If dtpNgaySinh.Checked Then
                .NgaySinh = dtpNgaySinh.Value.Date
            End If
        End With

        Try
            dt.tbNguoiLams.InsertOnSubmit(newNguoiLam)
            dt.SubmitChanges()
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        undoChange()
        Me.Close()
    End Sub

End Class