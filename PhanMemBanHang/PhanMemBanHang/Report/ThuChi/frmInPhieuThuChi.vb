Imports Microsoft.Reporting.WinForms

Public Class frmInPhieuThuChi
    Public PhieuThu As vwPhieuThu
    Public PhieuChi As vwPhieuChi

    Private Sub frmInPhieuThuChi_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmInPhieuThuChi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Dim rp As New ReportParameterCollection

        Dim report As tbReport


        If PhieuThu IsNot Nothing Then
            report = dt.tbReports.First(Function(s) s.FileRDLC = ".\Report\ThuChi\rptPhieuThuA4.rdlc")
            Me.Text = "Phiếu thu " + PhieuThu.MaPhieu
            Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + report.FileRDLC.Substring(1)
            Me.ReportViewer1.LocalReport.SetParameters(DanhSachThamSo(PhieuThu))
        Else

            report = dt.tbReports.First(Function(s) s.FileRDLC = ".\Report\ThuChi\rptPhieuChiA4.rdlc")
            Me.Text = "Phiếu chi " + PhieuChi.MaPhieu
            Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + report.FileRDLC.Substring(1)
            Dim iPhieuChi As tbPhieuChi = dt.tbPhieuChis.Single(Function(s) s.id = PhieuChi.id)
            With rp
                .Add(New ReportParameter("TenCuaHang", My.Settings.TenCongTy))
                .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
                .Add(New ReportParameter("MaPhieu", PhieuChi.MaPhieu))
                .Add(New ReportParameter("SoPhieu", PhieuChi.SoPhieu))
                .Add(New ReportParameter("NgayLap", PhieuChi.NgayLap))
                .Add(New ReportParameter("TenNguoiNhan", PhieuChi.TenNguoiNhan))
                .Add(New ReportParameter("DiaChi", PhieuChi.DiaChi))
                .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
                .Add(New ReportParameter("SoTien", PhieuChi.SoTien))
                .Add(New ReportParameter("LyDo", PhieuChi.LyDo))
                .Add(New ReportParameter("ChungTuKemTheo", PhieuChi.ChungTuKemTheo))
                .Add(New ReportParameter("TienChu", Number2Text.Number2Text.Num2Text(PhieuChi.SoTien)))
                .Add(New ReportParameter("NgayIn", Now))
                .Add(New ReportParameter("TenNhanVien", PhieuChi.TenNhanVien))
                .Add(New ReportParameter("NguoiChiTien", PhieuChi.NguoiChiTien))
                .Add(New ReportParameter("LoaiPhieuChi", iPhieuChi.tbLoaiPhieuChi.LoaiChi.Trim))
                .Add(New ReportParameter("TenNganHang", iPhieuChi.tbNganHang.TenNganHang.Trim))
            End With
        End If

        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()

        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = My.Settings.ZoomReport
    End Sub
End Class