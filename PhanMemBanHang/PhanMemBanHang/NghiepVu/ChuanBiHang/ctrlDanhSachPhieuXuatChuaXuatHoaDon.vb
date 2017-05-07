Public Class ctrlDanhSachPhieuXuatChuaXuatHoaDon
    Private Sub ctrlDanhSachPhieuXuatChuaXuatHoaDon_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim rls = From itm In dt.vwPhieuXuats
                  Where itm.isHoaDon = False
                  Order By itm.NgayLap
    End Sub
End Class
