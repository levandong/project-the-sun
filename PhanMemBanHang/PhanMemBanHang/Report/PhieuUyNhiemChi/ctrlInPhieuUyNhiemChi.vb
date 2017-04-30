Imports Microsoft.Reporting.WinForms

Public Class ctrlInPhieuUyNhiemChi
    Public PhieuUyNhiemChi As tbPhieuUyNhiemChi
    Public isDieuChuyen As Boolean = False
    Private Sub ctrlInPhieuUyNhiemChi_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PhieuUyNhiemChi Is Nothing Then Exit Sub

        Dim strReport As String = ""
        Dim flag As Boolean = False
        'PhieuUyNhiemChi.tbNganHang.DuongDanFileReport.Substring(1)
        If Not String.IsNullOrEmpty(PhieuUyNhiemChi.tbNganHang.DuongDanFileReport) Then
            flag = True
            strReport = Application.StartupPath + PhieuUyNhiemChi.tbNganHang.DuongDanFileReport.Substring(1)
        Else
            flag = False
            strReport = Application.StartupPath + "\Report\PhieuUyNhiemChi\rptPhieuUNCNganHang.rdlc"
        End If
        If PhieuUyNhiemChi.isThuTienMat Then
            strReport = Application.StartupPath + "\Report\PhieuUyNhiemChi\rptPhieuUNCTienMat.rdlc"
        End If
        If isDieuChuyen Then
            strReport = Application.StartupPath + "\Report\PhieuUyNhiemChi\rptPhieuUNCDieuChuyen.rdlc"
        End If
        If PhieuUyNhiemChi.isPhieuThu And PhieuUyNhiemChi.isThuTienMat = False Then
            strReport = Application.StartupPath + "\Report\PhieuUyNhiemChi\rptPhieuUNCThuTien.rdlc"
        End If
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        ReportViewer1.LocalReport.EnableExternalImages = True

        Dim ds As New ReportDataSource
        ds.Name = "dsUyNhiemChi"
        ds.Value = dt.tbPhieuUyNhiemChis.Where(Function(s) s.ID = PhieuUyNhiemChi.ID).ToList
        Me.ReportViewer1.LocalReport.ReportPath = strReport
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(ds)
        If isDieuChuyen = False Then
            If PhieuUyNhiemChi.isThuTienMat Then
                ReportViewer1.LocalReport.SetParameters(DanhSachThamSo(PhieuUyNhiemChi))
            ElseIf PhieuUyNhiemChi.isPhieuThu = False Then
                ReportViewer1.LocalReport.SetParameters(DanhSachThamSo(PhieuUyNhiemChi, flag))
            Else
                ReportViewer1.LocalReport.SetParameters(DanhSachThamSoThu(PhieuUyNhiemChi))
            End If

        Else
            ReportViewer1.LocalReport.SetParameters(DanhSachThamSoDieuChuyen(PhieuUyNhiemChi))
        End If
        ReportViewer1.RefreshReport()
    End Sub
    Public Function DanhSachThamSo(PhieuUyNhiemChi As tbPhieuUyNhiemChi, flag As Boolean)
        Dim lstParameter As New ReportParameterCollection
        With lstParameter
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("MaPhieu", PhieuUyNhiemChi.MaPhieu))
            .Add(New ReportParameter("NgayLap", PhieuUyNhiemChi.NgayLap))
            If flag Then
                .Add(New ReportParameter("DuongDanAnh", "file:" + PhieuUyNhiemChi.tbNganHang.DuongDanAnh))
            Else
                .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
            End If
            .Add(New ReportParameter("TenDonViChuyen", My.Settings.TenCongTy))
            .Add(New ReportParameter("SoTaiKhoanChuyen", PhieuUyNhiemChi.tbNganHang.SoTaiKhoan.Trim))
            .Add(New ReportParameter("SoTaiKhoanNhan", PhieuUyNhiemChi.tbNganHangUyNhiemChi.SoTaiKhoan.Trim))
            .Add(New ReportParameter("TongTien", PhieuUyNhiemChi.SoTien.ToString("N0")))
            .Add(New ReportParameter("TenDonViNhan", PhieuUyNhiemChi.tbKhachHang1.TenRutGon.Trim))
            '.Add(New ReportParameter("TienChu", Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString)))
            .Add(New ReportParameter("TaiNganHangNhan", PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenNganHang.Trim + " " + PhieuUyNhiemChi.tbNganHangUyNhiemChi.ChiNhanh.Trim))
            .Add(New ReportParameter("TaiNganHangChuyen", PhieuUyNhiemChi.tbNganHang.TenNganHang.Trim + " " + PhieuUyNhiemChi.tbNganHang.ChiNhanh.Trim))
            '.Add(New ReportParameter("NoiDungUyNhiemChi", PhieuUyNhiemChi.NoiDung))
            Label1.Font = New Font("Times New Roman", 11)
            Dim TienChu = Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString)
            Label1.Text = TienChu
            If Label1.Size.Width > PhieuUyNhiemChi.tbNganHang.ChieuDaiTienChu Then
                Dim str1 As String = ""
                Dim str2 As String = ""
                For Each itm In TienChu.Split(" ")
                    Label1.Text = str1 + itm
                    If Label1.Size.Width <= PhieuUyNhiemChi.tbNganHang.ChieuDaiTienChu Then
                        str1 += itm + " "
                        Continue For
                    Else
                        str1 = str1.Trim
                        str2 = TienChu.Substring(str1.Length, TienChu.Length - str1.Length)
                        Exit For
                    End If
                Next
                .Add(New ReportParameter("TienChu", str1.Trim))
                .Add(New ReportParameter("TienChu2", str2))
            Else
                .Add(New ReportParameter("TienChu", TienChu))
                .Add(New ReportParameter("TienChu2", ""))
            End If
            .Add(New ReportParameter("DiaChiNhan", PhieuUyNhiemChi.tbKhachHang1.DiaChi))
            .Add(New ReportParameter("DiaChiChuyen", My.Settings.DiaChi))
            '.Add(New ReportParameter("NoiDungUyNhiemChi2", ""))
            Dim NoiDung = PhieuUyNhiemChi.NoiDung
            Label1.Text = NoiDung
            If Label1.Size.Width > PhieuUyNhiemChi.tbNganHang.ChieuDaiNoiDung Then
                Dim str1 As String = ""
                Dim str2 As String = ""
                For Each itm In NoiDung.Split(" ")
                    Label1.Text = str1 + itm
                    If Label1.Size.Width <= PhieuUyNhiemChi.tbNganHang.ChieuDaiNoiDung Then
                        str1 += itm + " "
                        Continue For
                    Else
                        str1 = str1.Trim
                        str2 = NoiDung.Substring(str1.Length, NoiDung.Length - str1.Length)
                        Exit For
                    End If
                Next
                .Add(New ReportParameter("NoiDungUyNhiemChi", str1.Trim))
                .Add(New ReportParameter("NoiDungUyNhiemChi2", str2.Trim))
            Else
                .Add(New ReportParameter("NoiDungUyNhiemChi", NoiDung.Trim))
                .Add(New ReportParameter("NoiDungUyNhiemChi2", ""))
            End If
            .Add(New ReportParameter("TenTaiKhoanChuyen", PhieuUyNhiemChi.tbNganHang.TenNganHang.Trim))
            .Add(New ReportParameter("TenDonViTruNo", PhieuUyNhiemChi.tbKhachHang.TenRutGon.Trim))
            .Add(New ReportParameter("SoDienThoaiNhan", PhieuUyNhiemChi.tbKhachHang1.SoDienThoai.Trim))
            'NoiDungUyNhiemChi
            .Add(New ReportParameter("isPhieuThu", PhieuUyNhiemChi.isPhieuThu))
            .Add(New ReportParameter("LyDo", PhieuUyNhiemChi.NoiDung))
            .Add(New ReportParameter("ChungTuKemTheo", PhieuUyNhiemChi.ChungTuKemTheo))
            If PhieuUyNhiemChi.isPhieuThu Then
                .Add(New ReportParameter("TenPhieu", "PHIẾU THU"))
            Else
                .Add(New ReportParameter("TenPhieu", "PHIẾU CHI"))
            End If
        End With
        Return lstParameter
    End Function
    Public Function DanhSachThamSo(PhieuUyNhiemChi As tbPhieuUyNhiemChi)
        Dim lstParameter As New ReportParameterCollection
        With lstParameter
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("MaPhieu", PhieuUyNhiemChi.MaPhieu))
            .Add(New ReportParameter("NgayLap", PhieuUyNhiemChi.NgayLap))
            .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
            .Add(New ReportParameter("TenDonViChuyen", My.Settings.TenCongTy))
            '.Add(New ReportParameter("SoTaiKhoanChuyen", PhieuUyNhiemChi.tbNganHang.SoTaiKhoan.Trim))
            '.Add(New ReportParameter("SoTaiKhoanNhan", PhieuUyNhiemChi.tbNganHangUyNhiemChi.SoTaiKhoan.Trim))
            .Add(New ReportParameter("TongTien", PhieuUyNhiemChi.SoTien.ToString("N0")))
            '.Add(New ReportParameter("TenDonViNhan", PhieuUyNhiemChi.tbKhachHang1.TenRutGon.Trim))
            '.Add(New ReportParameter("TienChu", Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString)))
            '.Add(New ReportParameter("TaiNganHangNhan", PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenNganHang.Trim + " " + PhieuUyNhiemChi.tbNganHangUyNhiemChi.ChiNhanh.Trim))
            .Add(New ReportParameter("TaiNganHangChuyen", PhieuUyNhiemChi.tbNganHang.TenNganHang.Trim + " " + PhieuUyNhiemChi.tbNganHang.ChiNhanh.Trim))
            '.Add(New ReportParameter("NoiDungUyNhiemChi", PhieuUyNhiemChi.NoiDung))
            Label1.Font = New Font("Times New Roman", 11)
            Dim TienChu = Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString)
            Label1.Text = TienChu
            If Label1.Size.Width > PhieuUyNhiemChi.tbNganHang.ChieuDaiTienChu Then
                Dim str1 As String = ""
                Dim str2 As String = ""
                For Each itm In TienChu.Split(" ")
                    Label1.Text = str1 + itm
                    If Label1.Size.Width <= PhieuUyNhiemChi.tbNganHang.ChieuDaiTienChu Then
                        str1 += itm + " "
                        Continue For
                    Else
                        str1 = str1.Trim
                        str2 = TienChu.Substring(str1.Length, TienChu.Length - str1.Length)
                        Exit For
                    End If
                Next
                .Add(New ReportParameter("TienChu", str1.Trim))
                .Add(New ReportParameter("TienChu2", str2))
            Else
                .Add(New ReportParameter("TienChu", TienChu))
                .Add(New ReportParameter("TienChu2", ""))
            End If
            '.Add(New ReportParameter("DiaChiNhan", PhieuUyNhiemChi.tbKhachHang1.DiaChi))
            .Add(New ReportParameter("DiaChiChuyen", My.Settings.DiaChi))
            '.Add(New ReportParameter("NoiDungUyNhiemChi2", ""))
            Dim NoiDung = PhieuUyNhiemChi.NoiDung
            Label1.Text = NoiDung
            If Label1.Size.Width > PhieuUyNhiemChi.tbNganHang.ChieuDaiNoiDung Then
                Dim str1 As String = ""
                Dim str2 As String = ""
                For Each itm In NoiDung.Split(" ")
                    Label1.Text = str1 + itm
                    If Label1.Size.Width <= PhieuUyNhiemChi.tbNganHang.ChieuDaiNoiDung Then
                        str1 += itm + " "
                        Continue For
                    Else
                        str1 = str1.Trim
                        str2 = NoiDung.Substring(str1.Length, NoiDung.Length - str1.Length)
                        Exit For
                    End If
                Next
                .Add(New ReportParameter("NoiDungUyNhiemChi", str1.Trim))
                .Add(New ReportParameter("NoiDungUyNhiemChi2", str2.Trim))
            Else
                .Add(New ReportParameter("NoiDungUyNhiemChi", NoiDung.Trim))
                .Add(New ReportParameter("NoiDungUyNhiemChi2", ""))
            End If
            .Add(New ReportParameter("TenTaiKhoanChuyen", PhieuUyNhiemChi.tbNganHang.TenNganHang.Trim))
            .Add(New ReportParameter("TenDonViTruNo", PhieuUyNhiemChi.tbKhachHang.TenRutGon.Trim))
            '.Add(New ReportParameter("SoDienThoaiNhan", PhieuUyNhiemChi.tbKhachHang1.SoDienThoai.Trim))
            'NoiDungUyNhiemChi
            .Add(New ReportParameter("isPhieuThu", PhieuUyNhiemChi.isPhieuThu))
            .Add(New ReportParameter("LyDo", PhieuUyNhiemChi.ChungTuKemTheo))
            .Add(New ReportParameter("ChungTuKemTheo", PhieuUyNhiemChi.NoiDung))
            If PhieuUyNhiemChi.isPhieuThu Then
                .Add(New ReportParameter("TenPhieu", "PHIẾU THU"))
            Else
                .Add(New ReportParameter("TenPhieu", "PHIẾU CHI"))
            End If
        End With
        Return lstParameter
    End Function
    Public Function DanhSachThamSoThu(PhieuUyNhiemChi As tbPhieuUyNhiemChi)
        Dim lstParameter As New ReportParameterCollection
        With lstParameter
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("MaPhieu", PhieuUyNhiemChi.MaPhieu))
            .Add(New ReportParameter("NgayLap", PhieuUyNhiemChi.NgayLap))
            .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
            .Add(New ReportParameter("TenDonViChuyen", My.Settings.TenCongTy))
            '.Add(New ReportParameter("SoTaiKhoanChuyen", PhieuUyNhiemChi.tbNganHang.SoTaiKhoan.Trim))
            '.Add(New ReportParameter("SoTaiKhoanNhan", PhieuUyNhiemChi.tbNganHangUyNhiemChi.SoTaiKhoan.Trim))
            .Add(New ReportParameter("TongTien", PhieuUyNhiemChi.SoTien.ToString("N0")))
            .Add(New ReportParameter("TenDonViNhan", PhieuUyNhiemChi.tbKhachHang1.TenRutGon.Trim))
            '.Add(New ReportParameter("TienChu", Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString)))
            '.Add(New ReportParameter("TaiNganHangNhan", PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenNganHang.Trim + " " + PhieuUyNhiemChi.tbNganHangUyNhiemChi.ChiNhanh.Trim))
            .Add(New ReportParameter("TaiNganHangChuyen", PhieuUyNhiemChi.tbNganHang.TenNganHang.Trim + " " + PhieuUyNhiemChi.tbNganHang.ChiNhanh.Trim))
            '.Add(New ReportParameter("NoiDungUyNhiemChi", PhieuUyNhiemChi.NoiDung))
            Label1.Font = New Font("Times New Roman", 11)
            Dim TienChu = Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString)
            Label1.Text = TienChu
            If Label1.Size.Width > PhieuUyNhiemChi.tbNganHang.ChieuDaiTienChu Then
                Dim str1 As String = ""
                Dim str2 As String = ""
                For Each itm In TienChu.Split(" ")
                    Label1.Text = str1 + itm
                    If Label1.Size.Width <= PhieuUyNhiemChi.tbNganHang.ChieuDaiTienChu Then
                        str1 += itm + " "
                        Continue For
                    Else
                        str1 = str1.Trim
                        str2 = TienChu.Substring(str1.Length, TienChu.Length - str1.Length)
                        Exit For
                    End If
                Next
                .Add(New ReportParameter("TienChu", str1.Trim))
                .Add(New ReportParameter("TienChu2", str2))
            Else
                .Add(New ReportParameter("TienChu", TienChu))
                .Add(New ReportParameter("TienChu2", ""))
            End If
            '.Add(New ReportParameter("DiaChiNhan", PhieuUyNhiemChi.tbKhachHang1.DiaChi))
            .Add(New ReportParameter("DiaChiChuyen", My.Settings.DiaChi))
            '.Add(New ReportParameter("NoiDungUyNhiemChi2", ""))
            Dim NoiDung = PhieuUyNhiemChi.NoiDung
            Label1.Text = NoiDung
            If Label1.Size.Width > PhieuUyNhiemChi.tbNganHang.ChieuDaiNoiDung Then
                Dim str1 As String = ""
                Dim str2 As String = ""
                For Each itm In NoiDung.Split(" ")
                    Label1.Text = str1 + itm
                    If Label1.Size.Width <= PhieuUyNhiemChi.tbNganHang.ChieuDaiNoiDung Then
                        str1 += itm + " "
                        Continue For
                    Else
                        str1 = str1.Trim
                        str2 = NoiDung.Substring(str1.Length, NoiDung.Length - str1.Length)
                        Exit For
                    End If
                Next
                .Add(New ReportParameter("NoiDungUyNhiemChi", str1.Trim))
                .Add(New ReportParameter("NoiDungUyNhiemChi2", str2.Trim))
            Else
                .Add(New ReportParameter("NoiDungUyNhiemChi", NoiDung.Trim))
                .Add(New ReportParameter("NoiDungUyNhiemChi2", ""))
            End If
            .Add(New ReportParameter("TenTaiKhoanChuyen", PhieuUyNhiemChi.tbNganHang.TenNganHang.Trim))
            .Add(New ReportParameter("TenDonViTruNo", PhieuUyNhiemChi.tbKhachHang.TenRutGon.Trim))
            '.Add(New ReportParameter("SoDienThoaiNhan", PhieuUyNhiemChi.tbKhachHang1.SoDienThoai.Trim))
            'NoiDungUyNhiemChi
            .Add(New ReportParameter("isPhieuThu", PhieuUyNhiemChi.isPhieuThu))
            .Add(New ReportParameter("LyDo", PhieuUyNhiemChi.ChungTuKemTheo))
            .Add(New ReportParameter("ChungTuKemTheo", PhieuUyNhiemChi.NoiDung))
            If PhieuUyNhiemChi.isPhieuThu Then
                .Add(New ReportParameter("TenPhieu", "PHIẾU THU"))
            Else
                .Add(New ReportParameter("TenPhieu", "PHIẾU CHI"))
            End If
        End With
        Return lstParameter
    End Function
    Public Function DanhSachThamSoDieuChuyen(PhieuUyNhiemChi As tbPhieuUyNhiemChi)
        Dim lstParameter As New ReportParameterCollection
        With lstParameter
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("MaPhieu", PhieuUyNhiemChi.MaPhieu))
            .Add(New ReportParameter("NgayLap", PhieuUyNhiemChi.NgayLap))
            .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
            .Add(New ReportParameter("TenDonViChuyen", My.Settings.TenCongTy))
            .Add(New ReportParameter("TongTien", PhieuUyNhiemChi.SoTien.ToString("N0")))
            .Add(New ReportParameter("TaiNganHangChuyen", PhieuUyNhiemChi.tbNganHang.TenNganHang.Trim + " " + PhieuUyNhiemChi.tbNganHang.ChiNhanh.Trim))
            '.Add(New ReportParameter("NoiDungUyNhiemChi", PhieuUyNhiemChi.NoiDung))
            Label1.Font = New Font("Times New Roman", 11)
            Dim TienChu = Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString)
            Label1.Text = TienChu
            If Label1.Size.Width > PhieuUyNhiemChi.tbNganHang.ChieuDaiTienChu Then
                Dim str1 As String = ""
                Dim str2 As String = ""
                For Each itm In TienChu.Split(" ")
                    Label1.Text = str1 + itm
                    If Label1.Size.Width <= PhieuUyNhiemChi.tbNganHang.ChieuDaiTienChu Then
                        str1 += itm + " "
                        Continue For
                    Else
                        str1 = str1.Trim
                        str2 = TienChu.Substring(str1.Length, TienChu.Length - str1.Length)
                        Exit For
                    End If
                Next
                .Add(New ReportParameter("TienChu", str1.Trim))
                .Add(New ReportParameter("TienChu2", str2))
            Else
                .Add(New ReportParameter("TienChu", TienChu))
                .Add(New ReportParameter("TienChu2", ""))
            End If
            '.Add(New ReportParameter("DiaChiNhan", PhieuUyNhiemChi.tbKhachHang1.DiaChi))
            .Add(New ReportParameter("DiaChiChuyen", My.Settings.DiaChi))
            '.Add(New ReportParameter("NoiDungUyNhiemChi2", ""))
            Dim NoiDung = PhieuUyNhiemChi.NoiDung
            Label1.Text = NoiDung
            If Label1.Size.Width > PhieuUyNhiemChi.tbNganHang.ChieuDaiNoiDung Then
                Dim str1 As String = ""
                Dim str2 As String = ""
                For Each itm In NoiDung.Split(" ")
                    Label1.Text = str1 + itm
                    If Label1.Size.Width <= PhieuUyNhiemChi.tbNganHang.ChieuDaiNoiDung Then
                        str1 += itm + " "
                        Continue For
                    Else
                        str1 = str1.Trim
                        str2 = NoiDung.Substring(str1.Length, NoiDung.Length - str1.Length)
                        Exit For
                    End If
                Next
                .Add(New ReportParameter("NoiDungUyNhiemChi", str1.Trim))
                .Add(New ReportParameter("NoiDungUyNhiemChi2", str2.Trim))
            Else
                .Add(New ReportParameter("NoiDungUyNhiemChi", NoiDung.Trim))
                .Add(New ReportParameter("NoiDungUyNhiemChi2", ""))
            End If
            .Add(New ReportParameter("TenTaiKhoanChuyen", PhieuUyNhiemChi.tbNganHang.TenNganHang.Trim))
            '.Add(New ReportParameter("SoDienThoaiNhan", PhieuUyNhiemChi.tbKhachHang1.SoDienThoai.Trim))
            'NoiDungUyNhiemChi
            .Add(New ReportParameter("isPhieuThu", PhieuUyNhiemChi.isPhieuThu))
            .Add(New ReportParameter("LyDo", PhieuUyNhiemChi.ChungTuKemTheo))
            .Add(New ReportParameter("ChungTuKemTheo", PhieuUyNhiemChi.NoiDung))
            .Add(New ReportParameter("TenTaiKhoanNhanDieuChuyen", PhieuUyNhiemChi.tbPhieuUyNhiemChi.TenNganHang))
        End With
        Return lstParameter
    End Function
End Class
