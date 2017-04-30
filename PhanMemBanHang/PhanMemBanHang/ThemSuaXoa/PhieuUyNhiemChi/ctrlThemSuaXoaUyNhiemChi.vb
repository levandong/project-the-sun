Public Class ctrlThemSuaXoaUyNhiemChi
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThuNoTraNoKhachHang
        If frm.ShowDialog() = DialogResult.OK Then
            btnTimKiem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        bsUyNhiemChi.DataSource = From itm In dt.tbPhieuUyNhiemChis
                                  Where dtpTuLuc.Value.Date <= itm.NgayLap And dtpDenLuc.Value.Date >= itm.NgayLap
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim PhieuUyNhiemChi As tbPhieuUyNhiemChi = bsUyNhiemChi.Current
        Dim frm As New frmThuNoTraNoKhachHang
        frm.SuaPhieuUyNhiemChi = PhieuUyNhiemChi
        If frm.ShowDialog() = DialogResult.OK Then
            btnTimKiem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim PhieuUyNhiemChi As tbPhieuUyNhiemChi = bsUyNhiemChi.Current
        If XacNhanYesNo("Bạn có muốn xóa phiếu UNC: " + PhieuUyNhiemChi.MaPhieu.Trim + " Số tiền thu: " + PhieuUyNhiemChi.SoTien.ToString("N0")) = DialogResult.Yes Then
            dt.tbPhieuUyNhiemChis.DeleteOnSubmit(dt.tbPhieuUyNhiemChis.Single(Function(s) s.ID = PhieuUyNhiemChi.ID))
            Try
                dt.SubmitChanges()
            Catch ex As Exception
                undoChange()
            End Try
        End If
    End Sub

    Private Sub ctrlThemSuaXoaUyNhiemChi_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpTuLuc.Value = Now.Date.AddDays(-Now.Date.Day + 1).AddMonths(-1)
        dtpDenLuc.Value = Now.Date.AddMinutes(-1)
        btnTimKiem_Click(Nothing, Nothing)
    End Sub
End Class
