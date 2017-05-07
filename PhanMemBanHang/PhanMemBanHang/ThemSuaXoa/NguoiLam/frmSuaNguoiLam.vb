Public Class frmSuaNguoiLam
    Public NguoiLam As New tbNguoiLam
    Public MaNguoiLamBanDau As String

    Private Sub frmSuaNguoiLam_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnLuu_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSuaNguoiLam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        txtHoTen.Text = NguoiLam.TenNguoiLam
        txtMaNguoiLam.Text = NguoiLam.MaNguoiLam
        MaNguoiLamBanDau = NguoiLam.MaNguoiLam
        txtCMND.Text = NguoiLam.CMND
        txtSoDienThoai.Text = NguoiLam.SoDienThoai
        txtDiaChi.Text = NguoiLam.DiaChi
        dtpNgayVaoLam.Value = NguoiLam.NgayVaoLam
        rdoNam.Checked = NguoiLam.GioiTinh
        rdoNu.Checked = Not NguoiLam.GioiTinh
        If NguoiLam.NgaySinh IsNot Nothing Then
            dtpNgaySinh.Checked = True
            dtpNgaySinh.Value = NguoiLam.NgaySinh
        End If
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

        If txtMaNguoiLam.Text.Trim <> MaNguoiLamBanDau Then
            If dt.tbNguoiLams.Count(Function(s) s.MaNguoiLam = txtMaNguoiLam.Text.Trim) > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã người làm '" + txtMaNguoiLam.Text + "' đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        With NguoiLam
            .TenNguoiLam = txtHoTen.Text
            .TenNguoiLamString = mdlGlobals.BoDauTiengViet(txtHoTen.Text.Trim)
            .MaNguoiLam = txtMaNguoiLam.Text
            .MaNguoiLamString = mdlGlobals.BoDauTiengViet(txtMaNguoiLam.Text.Trim)
            .CMND = txtCMND.Text
            .SoDienThoai = txtSoDienThoai.Text
            .DiaChi = txtDiaChi.Text
            .GioiTinh = rdoNam.Checked
            .NgayVaoLam = dtpNgayVaoLam.Value.Date
            If dtpNgaySinh.Checked Then
                .NgaySinh = dtpNgaySinh.Value.Date
            Else
                .NgaySinh = Nothing
            End If
        End With

        Try
            dt.SubmitChanges()
            Me.DialogResult = DialogResult.OK
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

End Class