Public Class frmDanhSachThongTinLienHe
    Public idKhachHang As Integer

    Private Sub frmDanhSachThongTinLienHe_Load(sender As Object, e As EventArgs) Handles Me.Load
        bsThongTinLienHe.DataSource = From itm In dt.tbChiTietLienHes Where itm.idKhachHang = idKhachHang
    End Sub
End Class