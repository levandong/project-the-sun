Public Class ctrlThongKeGiaCongSanPham
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim idSanPham As Integer = 0
        If chkTheoSanPham.Checked AndAlso cmbSanPham.SelectedItem Is Nothing Then
            ThongBao("Vui lòng chọn sản phẩm cần lọc")
            cmbSanPham.Focus()
            Exit Sub
        Else
            idSanPham = cmbSanPham.SelectedItem.id
        End If
        bsGiaCong.DataSource = From itm In dt.vwGiaCongs
                               Where Not chkTheoSanPham.Checked Or itm.idSanPham = idSanPham
                               Order By itm.SoPhieu
    End Sub

    Private Sub ctrlThongKeGiaCongSanPham_Load(sender As Object, e As EventArgs) Handles Me.Load
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = New Date(Now.Date.AddDays(-30).Year, Now.Date.AddDays(-30).Month, Now.Date.AddDays(-30).Day)
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New Date(Now.Date.Year, Now.Date.Month, Now.Day, 23, 59, 59)
        cmbSanPham.DataSource = From itm In dt.tbSanPhams
                                Where itm.isGiaCong = True
        btnTimKiem_Click(Nothing, Nothing)
    End Sub
    Event ThemTabpageMoi(TenHienThi As String, Ten As String, control As Control)
    Public Sub F3_btnThemPhieuGiaCong_Click(sender As Object, e As EventArgs) Handles btnThemPhieuGiaCong.Click
        Dim DonDatHang As New ctrlGiaCong
        RaiseEvent ThemTabpageMoi("Đơn Đặt Hàng", "DH" + Now.ToString("dd/MM/yy HH:ss"), DonDatHang)
    End Sub
End Class
