Public Class frmThemPhieuThu
    Public NganHang As tbNganHang
    Private Sub frmThemPhieuThu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            Me.Close()
        End If
    End Sub
    Dim i As Integer = 0
    'fotmat ngày tháng năm thành dd/MM/yy nếu không thêm 1 điều kiện
    Private Sub dtpNgayNiemYet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpNgayChi.KeyPress
        i += 1
        If i = 2 Then
            SendKeys.Send("{DIVIDE}")
            i = -1
        End If
    End Sub
    Private Sub frmThemPhieuThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        cmbHinhThucThanhToan.DataSource = From itm In dt.tbHinhThucThanhToans
        btnLaySoPhieu_Click(Nothing, Nothing)
        cmbNganHang.DataSource = From itm In dt.tbNganHangs Order By itm.TenNganHang
        cmbNganHang.SelectedItem = NganHang
    End Sub
    Private Sub txtTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vndSoTien.KeyPress, txtChungTuKem.KeyPress, txtTenNguoiNop.KeyPress, txtNguoiNhanTien.KeyPress, txtLyDo.KeyPress, txtDiaChi.KeyPress, cmbNganHang.KeyPress, cmbHinhThucThanhToan.KeyPress, dtpNgayChi.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then 'Hoặc Convert.ToChar(Keys.Enter)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dtpNgayChi.Value = DateTime.Now
    End Sub

    Private Sub chkTickThoiGian_CheckedChanged(sender As Object, e As EventArgs) Handles chkTickThoiGian.CheckedChanged
        Timer1.Enabled = chkTickThoiGian.Checked
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Public newPhieu As New tbPhieuThu
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If vndSoTien.Value = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Số tiền thu phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        btnLaySoPhieu_Click(Nothing, Nothing)
        With newPhieu
            .HinhThucThanhToan = cmbHinhThucThanhToan.Text.Trim
            .NgayLap = dtpNgayChi.Value
            .SoTien = vndSoTien.Value
            .TenNguoiNop = txtTenNguoiNop.Text
            .NguoiNhanTien = txtNguoiNhanTien.Text
            .DiaChi = txtDiaChi.Text
            .ChungTuKemTheo = txtChungTuKem.Text
            .LyDo = txtLyDo.Text
            .idNganHang = cmbNganHang.SelectedItem.id
            .SoPhieu = txtSoPhieu.Tag
            .idNhanVien = loginNhanVien.id
        End With

        dt.tbPhieuThus.InsertOnSubmit(newPhieu)
        dt.SubmitChanges()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnLaySoPhieu_Click(sender As Object, e As EventArgs)
        txtSoPhieu.Text = "PT/" + dtpNgayChi.Value.ToString("MMyy") + "/" + LaySoHoaDonMoiNhat.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
    End Sub


    Private Function LaySoHoaDonMoiNhat() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuThus
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

    Private Sub cmbHinhThucThanhToan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHinhThucThanhToan.SelectedIndexChanged
        If cmbHinhThucThanhToan.SelectedIndex = 1 Then
            cmbNganHang.Enabled = True
        Else
            cmbNganHang.Enabled = False
        End If
    End Sub
End Class