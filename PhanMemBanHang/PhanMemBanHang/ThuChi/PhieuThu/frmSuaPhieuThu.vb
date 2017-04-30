Public Class frmSuaPhieuThu

    Private _PhieuThu As tbPhieuThu
    Property PhieuThu As tbPhieuThu
        Get
            Return _PhieuThu
        End Get
        Set(value As tbPhieuThu)
            _PhieuThu = value
            If value IsNot Nothing Then
                cmbHinhThucThanhToan.DataSource = From itm In dt.tbHinhThucThanhToans

                cmbHinhThucThanhToan.Text = PhieuThu.HinhThucThanhToan
                txtSoPhieu.Text = PhieuThu.MaPhieu
                txtChungTuKem.Text = PhieuThu.ChungTuKemTheo
                txtDiaChi.Text = PhieuThu.DiaChi
                txtLyDo.Text = PhieuThu.LyDo
                txtTenNguoiNop.Text = PhieuThu.TenNguoiNop
                txtNguoiNhanTien.Text = PhieuThu.NguoiNhanTien
                vndSoTien.Value = PhieuThu.SoTien
                txtSoPhieu.Tag = PhieuThu.SoPhieu
                dtpNgayThu.Value = PhieuThu.NgayLap
            End If
        End Set
    End Property


    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If vndSoTien.Value = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Số tiền phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        With PhieuThu
            .HinhThucThanhToan = cmbHinhThucThanhToan.Text.Trim
            .SoPhieu = txtSoPhieu.Tag
            .SoTien = vndSoTien.Value
            .TenNguoiNop = txtTenNguoiNop.Text
            .NguoiNhanTien = txtNguoiNhanTien.Text
            .DiaChi = txtDiaChi.Text
            .LyDo = txtLyDo.Text
            .ChungTuKemTheo = txtChungTuKem.Text
            .NgayLap = dtpNgayThu.Value
        End With
        dt.SubmitChanges()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnLaySoPhieu_Click(sender As Object, e As EventArgs)
        txtSoPhieu.Text = "PT/" + dtpNgayThu.Value.ToString("MMyy") + "/" + LaySoHoaDonMoiNhat.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
    End Sub


    Private Function LaySoHoaDonMoiNhat() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuThus
                            Where pn.NgayLap.Year = dtpNgayThu.Value.Year
                               Where pn.NgayLap.Month = dtpNgayThu.Value.Month
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

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmSuaPhieuThu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub frmSuaPhieuThu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class