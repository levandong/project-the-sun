Public Class frmNhapKhachHangExcel

    Event NhapXongKhachHang()
    Private Sub CtrlNhapKhachHangTuFileExcel1_NhapKhachHangThanhCong() Handles CtrlNhapKhachHangTuFileExcel1.NhapKhachHangThanhCong
        RaiseEvent NhapXongKhachHang()
    End Sub
End Class