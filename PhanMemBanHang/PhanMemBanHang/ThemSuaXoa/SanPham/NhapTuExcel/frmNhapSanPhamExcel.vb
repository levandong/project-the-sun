Public Class frmNhapSanPhamExcel
    Event NhapXongSanPham()
    Private Sub CtrlNhapSanPhamTuFileExcel1_NhapSanPhamThanhCong() Handles CtrlNhapSanPhamTuFileExcel1.NhapSanPhamThanhCong
        RaiseEvent NhapXongSanPham()
    End Sub

    Private Sub CtrlNhapSanPhamTuFileExcel1_Load(sender As Object, e As EventArgs)

    End Sub
End Class