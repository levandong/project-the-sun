Public Class frmSuaPhieuChi
    Private _PhieuChi As tbPhieuChi
    Property PhieuChi As tbPhieuChi
        Get
            Return _PhieuChi
        End Get
        Set(value As tbPhieuChi)
            _PhieuChi = value
            If value IsNot Nothing Then
                cmbHinhThucThanhToan.DataSource = From itm In dt.tbHinhThucThanhToans

                cmbHinhThucThanhToan.Text = PhieuChi.HinhThucThanhToan
                txtSoPhieu.Text = PhieuChi.MaPhieu
                txtChungTuKem.Text = PhieuChi.ChungTuKemTheo
                txtDiaChi.Text = PhieuChi.DiaChi
                txtLyDo.Text = PhieuChi.LyDo
                txtTenNguoiNop.Text = PhieuChi.TenNguoiNhan
                txtNguoiChiTien.Text = PhieuChi.NguoiChiTien
                vndSoTien.Value = PhieuChi.SoTien
                txtSoPhieu.Tag = PhieuChi.SoPhieu
                dtpNgayChi.Value = PhieuChi.NgayLap
            End If
        End Set
    End Property

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        If vndSoTien.Value = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Số tiền phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        With PhieuChi
            .HinhThucThanhToan = cmbHinhThucThanhToan.Text.Trim
            .SoPhieu = txtSoPhieu.Tag
            .NgayLap = dtpNgayChi.Value
            .SoTien = vndSoTien.Value
            .TenNguoiNhan = txtTenNguoiNop.Text
            .NguoiChiTien = txtNguoiChiTien.Text
            .DiaChi = txtDiaChi.Text
            .LyDo = txtLyDo.Text
            .ChungTuKemTheo = txtChungTuKem.Text
        End With
        dt.SubmitChanges()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function LaySoHoaDonMoiNhat() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuChis
                               Where pn.NgayLap.Year = dtpNgayChi.Value.Year
                               Where pn.NgayLap.Month = dtpNgayChi.Value.Month
                               Order By pn.id Descending
                               Select pn).FirstOrDefault
        If HoaDonCuNhat Is Nothing Then
            txtSoPhieu.Tag = 1
            Return 1
        Else
            txtSoPhieu.Tag = HoaDonCuNhat.SoPhieu + 1
            Return HoaDonCuNhat.SoPhieu + 1
        End If
    End Function

    Private Sub frmSuaPhieuChi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        undoChange()
    End Sub

    Private Sub frmSuaPhieuChi_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmSuaPhieuChi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class