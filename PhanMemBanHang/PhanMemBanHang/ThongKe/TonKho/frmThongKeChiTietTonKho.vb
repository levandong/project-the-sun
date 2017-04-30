Imports Microsoft.Reporting.WinForms

Public Class frmThongKeChiTietTonKho
    Public TonKho As New TinhTonKhoSanPhamResult
    Public TheoNgay As Boolean
    Public TuNgay, DenNgay As DateTime
    Dim lstChiTietTonKho As New List(Of clsChiTietTonKho)

    Private Sub frmThongKeChiTietTonKho_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim rlsPhieuNhap = From itm In dt.vwChiTietPhieuNhaps
                           Where (Not TheoNgay) Or (TuNgay.Date <= itm.NgayLap.Date And itm.NgayLap.Date <= DenNgay.Date)
                           Where itm.idSanPham = TonKho.id
                           Select New clsChiTietTonKho With
                                  {
                                      .Loai = 0,
                                      .idPhieu = itm.idPhieuNhap,
                                      .SoPhieu = itm.SoPhieu,
                                      .Ngay = itm.NgayLap,
                                      .LyDo = itm.LoaiPhieuNhap,
                                      .DoiTuong = itm.KhachHangNhaCungCap,
                                      .SoLuongNhap = itm.SoLuong,
                                      .DonGiaNhap = itm.GiaBan}

        Dim rlsPhieuXuat = From itm In dt.vwChiTietPhieuXuats
                           Where (Not TheoNgay) Or (TuNgay.Date <= itm.NgayLap.Date And itm.NgayLap.Date <= DenNgay.Date)
                           Where itm.idSanPham = TonKho.id
                           Select New clsChiTietTonKho With
                                  {
                                      .Loai = 1,
                                      .idPhieu = itm.idPhieuXuat,
                                      .SoPhieu = itm.SoPhieuXuat,
                                      .Ngay = itm.NgayLap,
                                      .LyDo = itm.LoaiPhieuXuat,
                                      .DoiTuong = itm.TenNhaCungCap,
                                      .SoLuongXuat = itm.SoLuong,
                                      .DonGiaXuat = itm.GiaBan
                                  }

        Dim rls As New List(Of clsChiTietTonKho)
        rls.AddRange(rlsPhieuNhap)
        rls.AddRange(rlsPhieuXuat)
        Dim lstTam = From itm In rls Order By itm.Ngay
        lstChiTietTonKho = lstTam.ToList
        Dim i As Integer
        For i = 0 To lstChiTietTonKho.Count - 1
            If i = 0 Then
                lstChiTietTonKho(i).SoLuongTon = TonKho.SoLuongDauKy + lstChiTietTonKho(i).SoLuongNhap - lstChiTietTonKho(i).SoLuongXuat
            Else
                lstChiTietTonKho(i).SoLuongTon = lstChiTietTonKho(i - 1).SoLuongTon + lstChiTietTonKho(i).SoLuongNhap - lstChiTietTonKho(i).SoLuongXuat
            End If
        Next
        bsChiTietTonKho.DataSource = From itm In lstChiTietTonKho Order By itm.Ngay
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Dim rp As New ReportParameterCollection
        With rp
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("DuongDanAnh", "File:" + My.Settings.DuongDanAnh))
            .Add(New ReportParameter("TenBaoCao", "SỔ CHI TIẾT SẢN PHẨM"))
            .Add(New ReportParameter("MaSanPham", TonKho.MaSanPham))
            .Add(New ReportParameter("TenSanPham", TonKho.TenSanPham))
            .Add(New ReportParameter("DonVi", TonKho.DonVi))
            .Add(New ReportParameter("NgayIn", Now))
            If TheoNgay Then
                .Add(New ReportParameter("ThoiGian", "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + _
                " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)))
            Else
                .Add(New ReportParameter("ThoiGian", "<Tất cả>"))
            End If
            .Add(New ReportParameter("SoLuongDauKy", TonKho.SoLuongDauKy))
            .Add(New ReportParameter("TongTienDauKy", TonKho.TongTienDauKy))
            .Add(New ReportParameter("SoLuongCuoiKy", TonKho.SoLuongCuoiKy))
        End With
        Dim a = Me.ReportViewer1.LocalReport.ReportPath
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = My.Settings.ZoomReport
    End Sub
End Class