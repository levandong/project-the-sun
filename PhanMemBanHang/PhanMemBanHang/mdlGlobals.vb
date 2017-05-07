Imports System.Data.Linq
Imports System.Text.RegularExpressions
Imports System.Text
Imports Microsoft.Reporting.WinForms
Imports Tmt.Toolkit
Imports System.IO
Imports System.Data.SqlClient
Imports TMTSecuritys
Imports System.IO.Ports
Imports System.Net
Imports System.Web
Imports System.ComponentModel
Imports Microsoft.Office.Interop

Module mdlGlobals

    ' LÊ VĂN ĐÔNG - 30/04/2017 d
    Public mh As New clsMaHoa

    Public ChuoiConnectString As String = mh.Decrypt(My.Settings.ThongTinKetNoi, "tmt6364")
    Public dt As New dcQLDataContext(ChuoiConnectString)

    Public loginNhanVien As tbNhanVien
    Public CuaHang As tbCuaHang
    Public isLoad As Boolean = False

    Public port As New SerialPort
    Public regex As Regex = New Regex(My.Settings.PatermCan)

    Public TMT_GioHeThong As DateTime



    Public Sub BatTatCan()
        Try
            If port.IsOpen Then
                port.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub TaoPhieuUyChiDongA(fileName As String, PhieuUyNhiemChi As tbPhieuUyNhiemChi)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        xlWorkSheet.Cells(5, 4) = PhieuUyNhiemChi.tbNganHang.TenChuTaiKhoan
        xlWorkSheet.Cells(6, 4) = PhieuUyNhiemChi.tbNganHang.DiaChi
        xlWorkSheet.Cells(7, 4) = "'" + PhieuUyNhiemChi.tbNganHang.SoTaiKhoan
        xlWorkSheet.Cells(8, 4) = PhieuUyNhiemChi.tbNganHang.TenNganHang
        xlWorkSheet.Cells(8, 8) = PhieuUyNhiemChi.tbNganHang.ChiNhanh
        xlWorkSheet.Cells(9, 4) = PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenChuTaiKhoan
        xlWorkSheet.Cells(10, 4) = PhieuUyNhiemChi.tbKhachHang1.DiaChi
        xlWorkSheet.Cells(11, 4) = "'" + PhieuUyNhiemChi.tbNganHangUyNhiemChi.SoTaiKhoan
        xlWorkSheet.Cells(12, 4) = PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenNganHang
        xlWorkSheet.Cells(12, 8) = PhieuUyNhiemChi.tbNganHangUyNhiemChi.ChiNhanh
        xlWorkSheet.Cells(13, 2) = "Số tiền bằng chữ: " + Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString())
        xlWorkSheet.Cells(15, 2) = "Nội dung thanh toán: " + PhieuUyNhiemChi.NoiDung
        xlWorkSheet.Cells(14, 11) = PhieuUyNhiemChi.SoTien
        xlWorkSheet.Cells(1, 11) = PhieuUyNhiemChi.MaPhieu
        xlWorkSheet.Cells(2, 10) = "Ngày " + PhieuUyNhiemChi.NgayLap.ToString("dd") + " tháng " + PhieuUyNhiemChi.NgayLap.ToString("MM") + " năm " + PhieuUyNhiemChi.NgayLap.ToString("yyyy")
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If PhieuUyNhiemChi.NoiDung.Trim.Length > 100 Then
            NoiDungTenFile = PhieuUyNhiemChi.NoiDung.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = PhieuUyNhiemChi.NoiDung.Trim
        End If
        sfd.FileName = (PhieuUyNhiemChi.TenKhachHang + "_" + PhieuUyNhiemChi.NgayLap.ToString("dd.MM.yyyy") + "_" + PhieuUyNhiemChi.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoPhieuUyNhiemChiAgribank(fileName As String, PhieuUyNhiemChi As tbPhieuUyNhiemChi)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        'Liên 2
        xlWorkSheet.Cells(79, 5) = PhieuUyNhiemChi.tbNganHang.TenChuTaiKhoan
        xlWorkSheet.Cells(81, 13) = PhieuUyNhiemChi.tbNganHang.DienThoai
        xlWorkSheet.Cells(81, 4) = "'" + PhieuUyNhiemChi.tbNganHang.SoTaiKhoan
        xlWorkSheet.Cells(85, 5) = PhieuUyNhiemChi.tbNganHang.TenNganHang + " " + PhieuUyNhiemChi.tbNganHang.ChiNhanh
        xlWorkSheet.Cells(87, 6) = PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenChuTaiKhoan
        xlWorkSheet.Cells(95, 4) = "'" + PhieuUyNhiemChi.tbNganHangUyNhiemChi.SoTaiKhoan
        xlWorkSheet.Cells(97, 5) = PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenNganHang + " - " + PhieuUyNhiemChi.tbNganHangUyNhiemChi.ChiNhanh
        xlWorkSheet.Cells(101, 6) = Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString())
        xlWorkSheet.Cells(104, 3) = PhieuUyNhiemChi.NoiDung
        xlWorkSheet.Cells(98, 20) = PhieuUyNhiemChi.SoTien
        xlWorkSheet.Cells(73, 21) = PhieuUyNhiemChi.MaPhieu
        xlWorkSheet.Cells(76, 13) = PhieuUyNhiemChi.NgayLap.ToString("MM/dd/yyyy")
        'Liên 1
        xlWorkSheet.Cells(7, 5) = PhieuUyNhiemChi.tbNganHang.TenChuTaiKhoan
        xlWorkSheet.Cells(9, 13) = PhieuUyNhiemChi.tbNganHang.DienThoai
        xlWorkSheet.Cells(9, 4) = "'" + PhieuUyNhiemChi.tbNganHang.SoTaiKhoan
        xlWorkSheet.Cells(13, 5) = PhieuUyNhiemChi.tbNganHang.TenNganHang + " " + PhieuUyNhiemChi.tbNganHang.ChiNhanh
        xlWorkSheet.Cells(15, 6) = PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenChuTaiKhoan
        xlWorkSheet.Cells(23, 4) = "'" + PhieuUyNhiemChi.tbNganHangUyNhiemChi.SoTaiKhoan
        xlWorkSheet.Cells(25, 5) = PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenNganHang + " - " + PhieuUyNhiemChi.tbNganHangUyNhiemChi.ChiNhanh
        xlWorkSheet.Cells(29, 6) = Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString())
        xlWorkSheet.Cells(32, 3) = PhieuUyNhiemChi.NoiDung
        xlWorkSheet.Cells(26, 20) = PhieuUyNhiemChi.SoTien
        xlWorkSheet.Cells(1, 19) = PhieuUyNhiemChi.MaPhieu
        xlWorkSheet.Cells(4, 13) = PhieuUyNhiemChi.NgayLap.ToString("MM/dd/yyyy")
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If PhieuUyNhiemChi.NoiDung.Trim.Length > 100 Then
            NoiDungTenFile = PhieuUyNhiemChi.NoiDung.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = PhieuUyNhiemChi.NoiDung.Trim
        End If
        sfd.FileName = (PhieuUyNhiemChi.TenKhachHang + "_" + PhieuUyNhiemChi.NgayLap.ToString("dd.MM.yyyy") + "_" + PhieuUyNhiemChi.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoPhieuUyNhiemChiVietinBank(fileName As String, PhieuUyNhiemChi As tbPhieuUyNhiemChi)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        'Liên 1
        xlWorkSheet.Cells(6, 3) = PhieuUyNhiemChi.tbNganHang.TenChuTaiKhoan
        xlWorkSheet.Cells(7, 3) = "'" + PhieuUyNhiemChi.tbNganHang.SoTaiKhoan
        xlWorkSheet.Cells(8, 3) = PhieuUyNhiemChi.tbNganHang.TenNganHang + " - " + PhieuUyNhiemChi.tbNganHang.ChiNhanh
        xlWorkSheet.Cells(11, 3) = PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenChuTaiKhoan
        xlWorkSheet.Cells(12, 3) = "'" + PhieuUyNhiemChi.tbNganHangUyNhiemChi.SoTaiKhoan
        xlWorkSheet.Cells(13, 3) = PhieuUyNhiemChi.tbNganHangUyNhiemChi.TenNganHang + " - " + PhieuUyNhiemChi.tbNganHangUyNhiemChi.ChiNhanh
        xlWorkSheet.Cells(9, 1) = "Số tiền bằng chữ Amount in words:  " + Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString())
        xlWorkSheet.Cells(14, 3) = PhieuUyNhiemChi.NoiDung
        xlWorkSheet.Cells(9, 6) = PhieuUyNhiemChi.SoTien
        xlWorkSheet.Cells(4, 5) = PhieuUyNhiemChi.MaPhieu
        xlWorkSheet.Cells(4, 7) = PhieuUyNhiemChi.NgayLap.ToString("MM/dd/yyyy")
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If PhieuUyNhiemChi.NoiDung.Trim.Length > 100 Then
            NoiDungTenFile = PhieuUyNhiemChi.NoiDung.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = PhieuUyNhiemChi.NoiDung.Trim
        End If
        sfd.FileName = (PhieuUyNhiemChi.TenKhachHang + "_" + PhieuUyNhiemChi.NgayLap.ToString("dd.MM.yyyy") + "_" + PhieuUyNhiemChi.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoPhieuThuTienMat(fileName As String, PhieuThu As tbPhieuUyNhiemChi)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        'Liên 1
        Dim KhachHang As vwKhachHang = dt.vwKhachHangs.Single(Function(s) s.id = PhieuThu.idKhachHangTinhCongNo)
        xlWorkSheet.Cells(6, 3) = KhachHang.TenRutGon
        xlWorkSheet.Cells(7, 3) = "'" + PhieuThu.ChungTuKemTheo
        xlWorkSheet.Cells(8, 3) = "'" + PhieuThu.SoTien.ToString("N0")
        xlWorkSheet.Cells(9, 3) = Number2Text.Number2Text.Num2Text(PhieuThu.SoTien.ToString())
        xlWorkSheet.Cells(10, 3) = PhieuThu.NoiDung
        'xlWorkSheet.Cells(14, 3) = PhieuUyNhiemChi.NoiDung
        'xlWorkSheet.Cells(9, 6) = PhieuUyNhiemChi.SoTien
        xlWorkSheet.Cells(4, 2) = PhieuThu.MaPhieu
        xlWorkSheet.Cells(4, 6) = PhieuThu.NgayLap.ToString("MM/dd/yyyy")
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If PhieuThu.NoiDung.Trim.Length > 100 Then
            NoiDungTenFile = PhieuThu.NoiDung.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = PhieuThu.NoiDung.Trim
        End If
        sfd.FileName = (KhachHang.TenKhachHang + "_" + PhieuThu.NgayLap.ToString("dd.MM.yyyy") + "_" + PhieuThu.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoPhieuChiTienMat(fileName As String, PhieuThu As tbPhieuUyNhiemChi)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        'Liên 1
        Dim KhachHang As vwKhachHang = dt.vwKhachHangs.Single(Function(s) s.id = PhieuThu.idKhachHangTinhCongNo)
        xlWorkSheet.Cells(6, 3) = KhachHang.TenRutGon
        xlWorkSheet.Cells(7, 3) = "'" + PhieuThu.NoiDung
        xlWorkSheet.Cells(8, 3) = "'" + PhieuThu.SoTien.ToString("N0")
        xlWorkSheet.Cells(9, 3) = Number2Text.Number2Text.Num2Text(PhieuThu.SoTien.ToString())
        xlWorkSheet.Cells(10, 3) = PhieuThu.ChungTuKemTheo
        'xlWorkSheet.Cells(14, 3) = PhieuUyNhiemChi.NoiDung
        'xlWorkSheet.Cells(9, 6) = PhieuUyNhiemChi.SoTien
        xlWorkSheet.Cells(4, 2) = PhieuThu.MaPhieu
        xlWorkSheet.Cells(4, 6) = PhieuThu.NgayLap.ToString("MM/dd/yyyy")
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If PhieuThu.NoiDung.Trim.Length > 100 Then
            NoiDungTenFile = PhieuThu.NoiDung.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = PhieuThu.NoiDung.Trim
        End If
        sfd.FileName = (KhachHang.TenKhachHang + "_" + PhieuThu.NgayLap.ToString("dd.MM.yyyy") + "_" + PhieuThu.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoPhieuDieuChuyenTien(fileName As String, PhieuThu As tbPhieuUyNhiemChi)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        'Liên 1
        Dim KhachHang As vwKhachHang = dt.vwKhachHangs.Single(Function(s) s.id = PhieuThu.idKhachHangTinhCongNo)
        xlWorkSheet.Cells(6, 3) = PhieuThu.TenNganHang
        xlWorkSheet.Cells(6, 5) = "'" + PhieuThu.MucPhi.ToString("N0")
        xlWorkSheet.Cells(7, 3) = PhieuThu.tbPhieuUyNhiemChi.TenNganHang
        xlWorkSheet.Cells(8, 2) = "'" + PhieuThu.SoTien.ToString("N0")
        xlWorkSheet.Cells(9, 3) = Number2Text.Number2Text.Num2Text(PhieuThu.SoTien.ToString())
        xlWorkSheet.Cells(10, 2) = PhieuThu.ChungTuKemTheo
        xlWorkSheet.Cells(11, 3) = "'" + PhieuThu.NoiDung
        xlWorkSheet.Cells(4, 2) = PhieuThu.MaPhieu
        xlWorkSheet.Cells(4, 6) = PhieuThu.NgayLap.ToString("MM/dd/yyyy")
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If PhieuThu.NoiDung.Trim.Length > 100 Then
            NoiDungTenFile = PhieuThu.NoiDung.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = PhieuThu.NoiDung.Trim
        End If
        sfd.FileName = ("ĐCT" + "_" + PhieuThu.NgayLap.ToString("dd.MM.yyyy") + "_" + PhieuThu.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoPhieuUyNhiemChiKhac(fileName As String, PhieuUyNhiemChi As tbPhieuUyNhiemChi)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        'Liên 1
        xlWorkSheet.Cells(7, 3) = PhieuUyNhiemChi.tbKhachHang.TenRutGon
        xlWorkSheet.Cells(6, 3) = PhieuUyNhiemChi.tbKhachHang1.TenRutGon
        'xlWorkSheet.Cells(8, 3) = PhieuUyNhiemChi.tbNganHang.TenNganHang + " - " + PhieuUyNhiemChi.tbNganHang.ChiNhanh
        xlWorkSheet.Cells(10, 3) = Number2Text.Number2Text.Num2Text(PhieuUyNhiemChi.SoTien.ToString())
        xlWorkSheet.Cells(11, 3) = PhieuUyNhiemChi.tbNganHang.TenTaiKhoan + " chi từ tài khoản ngân hàng" + PhieuUyNhiemChi.tbNganHang.TenNganHang + " - " + PhieuUyNhiemChi.tbNganHang.SoTaiKhoan
        xlWorkSheet.Cells(8, 3) = PhieuUyNhiemChi.NoiDung
        xlWorkSheet.Cells(9, 3) = PhieuUyNhiemChi.SoTien
        xlWorkSheet.Cells(4, 2) = PhieuUyNhiemChi.MaPhieu
        xlWorkSheet.Cells(4, 6) = PhieuUyNhiemChi.NgayLap.ToString("MM/dd/yyyy")
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If PhieuUyNhiemChi.NoiDung.Trim.Length > 100 Then
            NoiDungTenFile = PhieuUyNhiemChi.NoiDung.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = PhieuUyNhiemChi.NoiDung.Trim
        End If
        sfd.FileName = (PhieuUyNhiemChi.TenKhachHang + "_" + PhieuUyNhiemChi.NgayLap.ToString("dd.MM.yyyy") + "_" + PhieuUyNhiemChi.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoPhieuXuatExcel(fileName As String, PhieuXuat As vwPhieuXuat, flag As Boolean)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim tPhieuXuat As tbPhieuXuat = dt.tbPhieuXuats.Single(Function(s) s.id = PhieuXuat.id)
        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        '
        xlWorkSheet.Cells(5, 2) = tPhieuXuat.MaPhieu
        xlWorkSheet.Cells(5, 8) = tPhieuXuat.NgayLap.ToString("MM/dd/yyyy")
        xlWorkSheet.Cells(7, 3) = tPhieuXuat.tbKhachHang.TenRutGon
        xlWorkSheet.Cells(7, 8) = PhieuXuat.GhiTrenFileExcel
        If tPhieuXuat.tbChiTietLienHe IsNot Nothing Then
            xlWorkSheet.Cells(8, 3) = tPhieuXuat.tbChiTietLienHe.TenNguoiLienHe
            xlWorkSheet.Cells(8, 6) = "'" + tPhieuXuat.tbChiTietLienHe.SoDienThoai
            xlWorkSheet.Cells(9, 3) = tPhieuXuat.tbKhachHangDatHang.DiaChiGiaoHang
        End If
        xlWorkSheet.Cells(10, 3) = tPhieuXuat.TenCongTrinh
        Dim rls = From itm In dt.vwChiTietPhieuXuats.Where(Function(s) s.idPhieuXuat = PhieuXuat.id)
        Dim SoDong As Integer = 12
        Dim count As Integer = 1
        For Each itm In rls.OrderBy(Function(s) s.id)
            xlWorkSheet.Cells(SoDong, 1) = count
            xlWorkSheet.Cells(SoDong, 2) = itm.MaSanPham
            xlWorkSheet.Cells(SoDong, 3) = itm.TenSanPham
            xlWorkSheet.Cells(SoDong, 4) = itm.DonVi
            xlWorkSheet.Cells(SoDong, 5) = itm.SoLuong
            xlWorkSheet.Cells(SoDong, 6) = itm.GiaBan
            xlWorkSheet.Cells(SoDong, 8) = itm.KyHieuKho
            xlWorkSheet.Cells(SoDong, 9) = itm.GhiChu
            SoDong += 1
            count += 1
        Next
        AnCacDongTrongExcel(xlWorkSheet, SoDong, 212)
        xlWorkSheet.Cells(215, 1) = "Bằng chữ: " + Number2Text.Number2Text.Num2Text((tPhieuXuat.TongTien * 1.1).ToString())
        '
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If PhieuXuat.TenCongTrinh.Trim.Length > 100 Then
            NoiDungTenFile = PhieuXuat.TenCongTrinh.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = PhieuXuat.TenCongTrinh.Trim
        End If
        sfd.FileName = (PhieuXuat.TenNhaCungCap + "_" + PhieuXuat.NgayLap.ToString("dd.MM.yyyy") + "_" + PhieuXuat.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoBaoGiaXuatExcel1(fileName As String, BaoGia As vwBaoGia, flag As Boolean)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim tBaoGia As tbBaoGia = dt.tbBaoGias.Single(Function(s) s.id = BaoGia.id)
        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        '
        xlWorkSheet.Cells(5, 2) = tBaoGia.MaPhieu
        xlWorkSheet.Cells(5, 7) = tBaoGia.NgayLap.ToString("MM/dd/yyyy")
        If tBaoGia.isNhapHang Then
            xlWorkSheet.Cells(6, 1) = "ĐỀ NGHỊ BÁO GIÁ"
        Else
            xlWorkSheet.Cells(6, 1) = "THƯ CHÀO GIÁ"
        End If
        xlWorkSheet.Cells(7, 1) = "Kính gởi: " + tBaoGia.tbKhachHang.TenRutGon
        InDam(xlWorkSheet.Cells(7, 1), tBaoGia.tbKhachHang.TenRutGon)
        InNghieng(xlWorkSheet.Cells(7, 1), "Kính gởi:")
        GachChan(xlWorkSheet.Cells(7, 1), "Kính gởi:")
        xlWorkSheet.Cells(8, 1) = "Người gởi:  " + BaoGia.TenNhanVien
        InDam(xlWorkSheet.Cells(8, 1), BaoGia.TenNhanVien)
        xlWorkSheet.Cells(9, 1) = "ĐT:  " + tBaoGia.tbNhanVien.SoDienThoai
        InDam(xlWorkSheet.Cells(9, 1), tBaoGia.tbNhanVien.SoDienThoai)
        xlWorkSheet.Cells(10, 1) = "Email:  " + tBaoGia.tbNhanVien.Email
        InDam(xlWorkSheet.Cells(10, 1), tBaoGia.tbNhanVien.Email)
        If tBaoGia.tbChiTietLienHe IsNot Nothing Then
            xlWorkSheet.Cells(8, 5) = "Người nhận:  " + tBaoGia.tbChiTietLienHe.TenNguoiLienHe
            InDam(xlWorkSheet.Cells(8, 5), tBaoGia.tbChiTietLienHe.TenNguoiLienHe)
            xlWorkSheet.Cells(9, 5) = "ĐT:  " + tBaoGia.tbChiTietLienHe.SoDienThoai
            InDam(xlWorkSheet.Cells(9, 5), tBaoGia.tbChiTietLienHe.SoDienThoai)
            xlWorkSheet.Cells(10, 5) = "Email:  " + tBaoGia.tbChiTietLienHe.Email
            InDam(xlWorkSheet.Cells(10, 5), tBaoGia.tbChiTietLienHe.Email)
        End If
        xlWorkSheet.Cells(11, 2) = tBaoGia.GhiChu
        Dim CoSanPhamDanhMuc = False
        Dim rls = From itm In dt.vwChiTietBaoGias.Where(Function(s) s.idBaoGia = BaoGia.id)
        If rls.Where(Function(s) s.isDanhMuc = True).Count > 1 Then
            CoSanPhamDanhMuc = True
        End If
        Dim SoDong As Integer = 13
        Dim count As Integer = 1
        Dim STT As Integer = 0
        For Each itm In rls.OrderBy(Function(s) s.id)
            If CoSanPhamDanhMuc Then
                If itm.isDanhMuc Then
                    STT += 1
                    xlWorkSheet.Cells(SoDong, 1) = "'" + STT.ToString() + "."
                    InDam(xlWorkSheet.Cells(SoDong, 1), "'" + STT.ToString() + ".")
                    count = 1
                Else
                    xlWorkSheet.Cells(SoDong, 1) = "'" + STT.ToString() + "." + count.ToString() + "."
                End If
            Else
                xlWorkSheet.Cells(SoDong, 1) = count
            End If
            xlWorkSheet.Cells(SoDong, 2) = itm.TenSanPham

            If itm.isDanhMuc Then
                InDam(xlWorkSheet.Cells(SoDong, 2), itm.TenSanPham)
                SoDong += 1
                Continue For
            End If
            xlWorkSheet.Cells(SoDong, 3) = itm.DonVi
            xlWorkSheet.Cells(SoDong, 4) = itm.SoLuong
            If flag Then
                xlWorkSheet.Cells(SoDong, 5) = itm.DonGia
            Else
                xlWorkSheet.Cells(SoDong, 5) = ""
                xlWorkSheet.Cells(SoDong, 6) = ""
            End If
            'xlWorkSheet.Cells(SoDong, 6) = itm.ThanhTien
            xlWorkSheet.Cells(SoDong, 7) = itm.GhiChu
            SoDong += 1
            count += 1
        Next
        AnCacDongTrongExcel(xlWorkSheet, SoDong, 213)
        ' xlWorkSheet.Cells(215, 1) = "Bằng chữ: " + Number2Text.Number2Text.Num2Text((tBaoGia.TongTien * 1.1).ToString())
        '
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If BaoGia.GhiChu.Trim.Length > 100 Then
            NoiDungTenFile = BaoGia.GhiChu.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = BaoGia.GhiChu.Trim
        End If
        sfd.FileName = (BaoGia.KhachHangNhaCungCap + "_" + BaoGia.NgayLap.ToString("dd.MM.yyyy") + "_" + BaoGia.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoDonDatHangExcel(fileName As String, KhachHangDatHang As vwKhachHangDatHang)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim tKhachHangDatHang As tbKhachHangDatHang = dt.tbKhachHangDatHangs.Single(Function(s) s.id = KhachHangDatHang.id)
        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        '
        xlWorkSheet.Cells(5, 2) = tKhachHangDatHang.MaDatHang
        xlWorkSheet.Cells(5, 7) = tKhachHangDatHang.NgayLap.ToString("MM/dd/yyyy")
        xlWorkSheet.Cells(7, 1) = "Khách hàng: " + tKhachHangDatHang.tbKhachHang.TenRutGon
        InDam(xlWorkSheet.Cells(7, 1), tKhachHangDatHang.tbKhachHang.TenRutGon)
        InNghieng(xlWorkSheet.Cells(7, 1), "Khách hàng:")
        xlWorkSheet.Cells(7, 7) = tKhachHangDatHang.NgayDuKienGiaoHang
        xlWorkSheet.Cells(8, 1) = "Người báo giá:  " + KhachHangDatHang.TenNhanVien
        InDam(xlWorkSheet.Cells(8, 1), KhachHangDatHang.TenNhanVien)
        If tKhachHangDatHang.tbChiTietLienHe IsNot Nothing Then
            xlWorkSheet.Cells(9, 1) = "Người liên hệ:  " + tKhachHangDatHang.tbChiTietLienHe.TenNguoiLienHe
            InDam(xlWorkSheet.Cells(9, 1), tKhachHangDatHang.tbChiTietLienHe.TenNguoiLienHe)
            xlWorkSheet.Cells(9, 5) = "ĐT:  " + tKhachHangDatHang.tbChiTietLienHe.SoDienThoai
            InDam(xlWorkSheet.Cells(9, 5), tKhachHangDatHang.tbChiTietLienHe.SoDienThoai)
        End If
        xlWorkSheet.Cells(10, 1) = "Địa chỉ giao hàng: " + tKhachHangDatHang.DiaChiGiaoHang
        InNghieng(xlWorkSheet.Cells(10, 1), "Địa chỉ giao hàng:")
        Dim rls = From itm In dt.vwChiTietKhachHangDatHangs.Where(Function(s) s.idKhachHangDatHang = tKhachHangDatHang.id)
        Dim SoDong As Integer = 13
        Dim count As Integer = 1
        For Each itm In rls.OrderBy(Function(s) s.id)
            xlWorkSheet.Cells(SoDong, 1) = count
            xlWorkSheet.Cells(SoDong, 2) = itm.TenSanPham
            xlWorkSheet.Cells(SoDong, 3) = itm.DonVi
            xlWorkSheet.Cells(SoDong, 4) = itm.SoLuong
            xlWorkSheet.Cells(SoDong, 5) = itm.GiaBan
            'xlWorkSheet.Cells(SoDong, 6) = itm.ThanhTien
            xlWorkSheet.Cells(SoDong, 7) = itm.GhiChu
            SoDong += 1
            count += 1
        Next
        AnCacDongTrongExcel(xlWorkSheet, SoDong, 213)
        ' xlWorkSheet.Cells(215, 1) = "Bằng chữ: " + Number2Text.Number2Text.Num2Text((tBaoGia.TongTien * 1.1).ToString())
        '
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If KhachHangDatHang.CongTrinh.Trim.Length > 100 Then
            NoiDungTenFile = KhachHangDatHang.CongTrinh.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = KhachHangDatHang.CongTrinh.Trim
        End If
        sfd.FileName = (KhachHangDatHang.TenKhachHang + "_" + KhachHangDatHang.NgayLap.ToString("dd.MM.yyyy") + "_" + KhachHangDatHang.MaDatHang + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoPhieuDatHangExcel(fileName As String, KhachHangDatHang As vwKhachHangDatHang)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim tKhachHangDatHang As tbKhachHangDatHang = dt.tbKhachHangDatHangs.Single(Function(s) s.id = KhachHangDatHang.id)
        xlApp = New Excel.ApplicationClass()

        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        '
        xlWorkSheet.Cells(5, 2) = tKhachHangDatHang.MaDatHang
        xlWorkSheet.Cells(5, 7) = tKhachHangDatHang.NgayLap.ToString("MM/dd/yyyy")
        xlWorkSheet.Cells(7, 1) = "Kính gởi: " + tKhachHangDatHang.tbKhachHang.TenRutGon
        InDam(xlWorkSheet.Cells(7, 1), tKhachHangDatHang.tbKhachHang.TenRutGon)
        InNghieng(xlWorkSheet.Cells(7, 1), "Kính gởi:")
        GachChan(xlWorkSheet.Cells(7, 1), "Kính gởi:")
        xlWorkSheet.Cells(8, 1) = "Người gởi:  " + KhachHangDatHang.TenNhanVien
        InDam(xlWorkSheet.Cells(8, 1), KhachHangDatHang.TenNhanVien)
        xlWorkSheet.Cells(9, 1) = "ĐT:  " + tKhachHangDatHang.tbNhanVien.SoDienThoai
        InDam(xlWorkSheet.Cells(9, 1), tKhachHangDatHang.tbNhanVien.SoDienThoai)
        xlWorkSheet.Cells(10, 1) = "Email:  " + tKhachHangDatHang.tbNhanVien.Email
        InDam(xlWorkSheet.Cells(10, 1), tKhachHangDatHang.tbNhanVien.Email)
        If tKhachHangDatHang.tbChiTietLienHe IsNot Nothing Then
            xlWorkSheet.Cells(8, 5) = "Người nhận:  " + tKhachHangDatHang.tbChiTietLienHe.TenNguoiLienHe
            InDam(xlWorkSheet.Cells(8, 5), tKhachHangDatHang.tbChiTietLienHe.TenNguoiLienHe)
            xlWorkSheet.Cells(9, 5) = "ĐT:  " + tKhachHangDatHang.tbChiTietLienHe.SoDienThoai
            InDam(xlWorkSheet.Cells(9, 5), tKhachHangDatHang.tbChiTietLienHe.SoDienThoai)
            xlWorkSheet.Cells(10, 5) = "Email:  " + tKhachHangDatHang.tbChiTietLienHe.Email
            InDam(xlWorkSheet.Cells(10, 5), tKhachHangDatHang.tbChiTietLienHe.Email)
        End If
        xlWorkSheet.Cells(11, 2) = tKhachHangDatHang.GhiChu
        Dim rls = From itm In dt.vwChiTietKhachHangDatHangs.Where(Function(s) s.idKhachHangDatHang = tKhachHangDatHang.id)
        Dim SoDong As Integer = 13
        Dim count As Integer = 1
        For Each itm In rls.OrderBy(Function(s) s.id)
            xlWorkSheet.Cells(SoDong, 1) = count
            xlWorkSheet.Cells(SoDong, 2) = itm.TenSanPham
            xlWorkSheet.Cells(SoDong, 3) = itm.DonVi
            xlWorkSheet.Cells(SoDong, 4) = itm.SoLuong
            xlWorkSheet.Cells(SoDong, 5) = itm.GiaBan
            'xlWorkSheet.Cells(SoDong, 6) = itm.ThanhTien
            xlWorkSheet.Cells(SoDong, 7) = itm.GhiChu
            SoDong += 1
            count += 1
        Next
        AnCacDongTrongExcel(xlWorkSheet, SoDong, 213)
        ' xlWorkSheet.Cells(215, 1) = "Bằng chữ: " + Number2Text.Number2Text.Num2Text((tBaoGia.TongTien * 1.1).ToString())
        '
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If KhachHangDatHang.CongTrinh.Trim.Length > 100 Then
            NoiDungTenFile = KhachHangDatHang.CongTrinh.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = KhachHangDatHang.CongTrinh.Trim
        End If
        sfd.FileName = (KhachHangDatHang.TenKhachHang + "_" + KhachHangDatHang.NgayLap.ToString("dd.MM.yyyy") + "_" + KhachHangDatHang.MaDatHang + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Private Sub InDam(rng As Microsoft.Office.Interop.Excel.Range, wordsSeparator As String)
        If wordsSeparator.Trim = "" Then Exit Sub
        Dim cellString As String = rng.Text
        Dim firstWordEndIdx As Integer = cellString.IndexOf(wordsSeparator)
        InDamKyTu(rng, firstWordEndIdx, wordsSeparator.Trim.Length + 1)
    End Sub

    Private Sub InDamKyTu(rng As Microsoft.Office.Interop.Excel.Range, boldStartIndex As Integer, boldEndIndex As Integer)
        rng.Characters(boldStartIndex, boldEndIndex).Font.Bold = 1
    End Sub
    Private Sub InNghieng(rng As Microsoft.Office.Interop.Excel.Range, wordsSeparator As String)
        If wordsSeparator.Trim = "" Then Exit Sub
        Dim cellString As String = rng.Text
        Dim firstWordEndIdx As Integer = cellString.IndexOf(wordsSeparator)
        InNghiengKyTu(rng, firstWordEndIdx, wordsSeparator.Trim.Length + 1)
    End Sub

    Private Sub InNghiengKyTu(rng As Microsoft.Office.Interop.Excel.Range, boldStartIndex As Integer, boldEndIndex As Integer)
        rng.Characters(boldStartIndex - 1, boldEndIndex).Font.Italic = 1
    End Sub
    Private Sub GachChan(rng As Microsoft.Office.Interop.Excel.Range, wordsSeparator As String)
        If wordsSeparator.Trim = "" Then Exit Sub
        Dim cellString As String = rng.Text
        Dim firstWordEndIdx As Integer = cellString.IndexOf(wordsSeparator)
        GachChanKyTu(rng, firstWordEndIdx, wordsSeparator.Trim.Length)
    End Sub

    Private Sub GachChanKyTu(rng As Microsoft.Office.Interop.Excel.Range, boldStartIndex As Integer, boldEndIndex As Integer)
        rng.Characters(boldStartIndex, boldEndIndex).Font.Underline = True
    End Sub
    Public Sub TaoPhieuNhapExcel2(fileName As String, PhieuNhap As vwPhieuNhap)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim tPhieuNhap As tbPhieuNhap = dt.tbPhieuNhaps.Single(Function(s) s.id = PhieuNhap.id)
        xlApp = New Excel.ApplicationClass()
        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        '
        xlWorkSheet.Cells(4, 2) = tPhieuNhap.MaPhieu
        xlWorkSheet.Cells(4, 8) = tPhieuNhap.NgayLap.ToString("MM/dd/yyyy")
        xlWorkSheet.Cells(6, 3) = tPhieuNhap.tbKhachHang.TenRutGon
        xlWorkSheet.Cells(6, 8) = PhieuNhap.GhiTrenFileExcel
        If tPhieuNhap.tbNhanVien1 IsNot Nothing Then
            xlWorkSheet.Cells(7, 3) = tPhieuNhap.tbNhanVien1.TenNhanVien
            'xlWorkSheet.Cells(7, 6) = "'" + tPhieuNhap.tbChiTietLienHe.SoDienThoai
        End If
        xlWorkSheet.Cells(8, 3) = tPhieuNhap.tbKhachHangDatHang.DiaChiGiaoHang
        xlWorkSheet.Cells(9, 3) = tPhieuNhap.TenCongTrinh
        Dim rls = From itm In dt.vwChiTietPhieuNhaps.Where(Function(s) s.idPhieuNhap = PhieuNhap.id)
        Dim SoDong As Integer = 11
        Dim count As Integer = 1
        For Each itm In rls.OrderBy(Function(s) s.id)
            xlWorkSheet.Cells(SoDong, 1) = count
            xlWorkSheet.Cells(SoDong, 2) = itm.TenSanPham
            xlWorkSheet.Cells(SoDong, 3) = itm.DonVi
            xlWorkSheet.Cells(SoDong, 4) = itm.SoLuong
            xlWorkSheet.Cells(SoDong, 5) = itm.DonGia
            xlWorkSheet.Cells(SoDong, 6) = itm.ChietKhau
            xlWorkSheet.Cells(SoDong, 7) = itm.GiaBan
            'xlWorkSheet.Cells(SoDong, 8) = itm.ThanhTien
            xlWorkSheet.Cells(SoDong, 9) = itm.GhiChu
            SoDong += 1
            count += 1
        Next
        AnCacDongTrongExcel(xlWorkSheet, SoDong, 211)
        xlWorkSheet.Cells(215, 1) = "Bằng chữ: " + Number2Text.Number2Text.Num2Text((PhieuNhap.CongTien * 1.1).ToString())
        '
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If tPhieuNhap.TenCongTrinh.Trim.Length > 100 Then
            NoiDungTenFile = tPhieuNhap.TenCongTrinh.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = tPhieuNhap.TenCongTrinh.Trim
        End If
        sfd.FileName = (PhieuNhap.TenKhachHang + "_" + PhieuNhap.NgayLap.ToString("dd.MM.yyyy") + "_" + PhieuNhap.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Public Sub TaoPhieuNhapExcel1(fileName As String, PhieuNhap As vwPhieuNhap, flag As Boolean)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim tPhieuNhap As tbPhieuNhap = dt.tbPhieuNhaps.Single(Function(s) s.id = PhieuNhap.id)
        xlApp = New Excel.ApplicationClass()
        xlWorkBook = xlApp.Workbooks.Open(fileName, 0, True, 5, "", "", True, Excel.XlPlatform.xlWindows, vbTab, False, False, 0, True, 1, 0)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets(1), Excel.Worksheet)
        '
        xlWorkSheet.Cells(5, 2) = tPhieuNhap.MaPhieu
        xlWorkSheet.Cells(5, 8) = tPhieuNhap.NgayLap.ToString("MM/dd/yyyy")
        xlWorkSheet.Cells(7, 3) = tPhieuNhap.tbKhachHang.TenRutGon
        xlWorkSheet.Cells(7, 8) = PhieuNhap.GhiTrenFileExcel
        If tPhieuNhap.tbNhanVien1 IsNot Nothing Then
            xlWorkSheet.Cells(8, 3) = tPhieuNhap.tbNhanVien1.TenNhanVien
            'xlWorkSheet.Cells(7, 6) = "'" + tPhieuNhap.tbChiTietLienHe.SoDienThoai
        End If
        xlWorkSheet.Cells(9, 3) = tPhieuNhap.tbKhachHangDatHang.DiaChiGiaoHang
        xlWorkSheet.Cells(10, 3) = tPhieuNhap.TenCongTrinh
        Dim rls = From itm In dt.vwChiTietPhieuNhaps.Where(Function(s) s.idPhieuNhap = PhieuNhap.id)
        Dim SoDong As Integer = 12
        Dim count As Integer = 1
        For Each itm In rls.OrderBy(Function(s) s.id)
            xlWorkSheet.Cells(SoDong, 1) = count
            xlWorkSheet.Cells(SoDong, 2) = itm.MaSanPham
            xlWorkSheet.Cells(SoDong, 3) = itm.TenSanPham
            xlWorkSheet.Cells(SoDong, 4) = itm.DonVi
            xlWorkSheet.Cells(SoDong, 5) = itm.SoLuong
            xlWorkSheet.Cells(SoDong, 6) = itm.GiaBan
            If flag Then
                xlWorkSheet.Cells(SoDong, 8) = itm.KyHieuKho
                xlWorkSheet.Cells(SoDong, 9) = itm.GhiChu
            Else
                xlWorkSheet.Cells(SoDong, 8) = itm.GhiChu
            End If
            SoDong += 1
            count += 1
        Next
        AnCacDongTrongExcel(xlWorkSheet, SoDong, 212)
        xlWorkSheet.Cells(216, 1) = "Bằng chữ: " + Number2Text.Number2Text.Num2Text((PhieuNhap.CongTien * 1.1).ToString())
        '
        Dim sfd = New SaveFileDialog
        sfd.InitialDirectory = My.Settings.DuongDanLuuExcel
        sfd.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(.xls)|*.xls| Excel Files(*.xlsm)|*.xlsm"
        Dim NoiDungTenFile As String = ""
        If tPhieuNhap.TenCongTrinh.Trim.Length > 100 Then
            NoiDungTenFile = tPhieuNhap.TenCongTrinh.Trim.Substring(0, 100)
        Else
            NoiDungTenFile = tPhieuNhap.TenCongTrinh.Trim
        End If
        sfd.FileName = (PhieuNhap.TenKhachHang + "_" + PhieuNhap.NgayLap.ToString("dd.MM.yyyy") + "_" + PhieuNhap.MaPhieu + "_" + NoiDungTenFile).Replace(":", "").Replace("/", ".")
        If sfd.ShowDialog = DialogResult.OK Then
            xlWorkSheet.SaveAs(sfd.FileName)
        End If
        xlWorkBook.Close(False, misValue, misValue)
        xlApp.Quit()
    End Sub
    Sub AnCacDongTrongExcel(xlWorkSheet As Excel.Worksheet, DongBatDau As Integer, DongKetThuc As Integer)
        Dim hiddenRange = xlWorkSheet.Range(xlWorkSheet.Cells(DongBatDau, 1), xlWorkSheet.Cells(DongKetThuc, 13))
        hiddenRange.EntireRow.Hidden = True
    End Sub
    Public Function IndexOf(s As StringBuilder, c As Char) As Integer
        For i = 0 To s.Length - 1
            If s(i) = c Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function IsNumber(pText As String) As Boolean
        Dim regex As New Regex("^[-+]?[0-9]*\.?[0-9]+$")
        Return regex.IsMatch(pText)
    End Function

#Region "UPDATE PHẦN MỀM"
    Private clientDownload As WebClient
    Public MaPhanMem As String = Application.ProductName + "_MatTroi_TP"
    Public Sub UpdatePhanMem(isCoThongBao As Boolean)
        Dim ConnectSTring As String = ""
        Using wcf As New com.hayketnoi.iclickupdater.UpdateIClick
            Dim strUpdater As String = wcf.CheckUpdate(MaPhanMem, Application.ProductVersion)
            If strUpdater.StartsWith("NO") Then
                ' đã là phiên bản mới nhất
                If isCoThongBao Then
                    ThongBaoInfo("Phiên bản hiện tại là hiên bản mới nhất.")
                End If
            Else
                Dim strPathFileUpdate = Application.StartupPath + "\TMTUpdater.exe"
                Dim strPathNewtonsoftJson = Application.StartupPath + "\Newtonsoft.Json.dll"
                If Not File.Exists(strPathNewtonsoftJson) Then
                    If clientDownload Is Nothing Then
                        clientDownload = New WebClient
                    End If
                    clientDownload.DownloadFile("http://hayketnoi.com/LinkPhanMem/TMT/Updater/TMT/Newtonsoft.Json.dll", strPathNewtonsoftJson)
                End If
                If Not File.Exists(strPathFileUpdate) Then
                    Try
                        If clientDownload Is Nothing Then
                            clientDownload = New WebClient
                        End If
                        AddHandler clientDownload.DownloadFileCompleted, AddressOf client_DownloadFileCompleted
                        clientDownload.DownloadFileAsync(New Uri("http://hayketnoi.com/LinkPhanMem/TMT/Updater/TMT/TMTUpdater.exe"), strPathFileUpdate)
                    Catch ex As Exception
                        If isCoThongBao Then
                            ThongBaoErrorVoiException("Tải file Updater không được. Vui lòng liên hệ nhà cung cấp phần mềm.", ex)
                        End If
                    End Try
                Else
                    Try
                        Process.Start(strPathFileUpdate, Base64Encode(strUpdater) + " " + Application.ProductName + " 1 " + Base64Encode(ConnectSTring))
                    Catch ex As Exception
                        If isCoThongBao Then
                            ThongBaoErrorVoiException("Không khởi động được tiến trình cập nhật.", ex)
                        End If
                    End Try
                End If

            End If
        End Using
    End Sub

    Private Sub client_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)
        UpdatePhanMem(False)
    End Sub

    Public Function Base64Encode(plainText As String) As String
        Dim plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText)
        Return System.Convert.ToBase64String(plainTextBytes)
    End Function

#End Region

#Region "ENUM"
    Public Enum THEOLOAICHITIETHOADON
        HANGHOA = 0
        GIAMTIEN = 1
        CHIETKHAUPHANTRAM = 2
        CONGTIEN = 3
        GHICHU = 4
        THANHTIEN = 5
        TIENSAUTHUE = 6
        TENSANPHAMDACBIET = 7
    End Enum
    Public Enum THEONGANHANG
        DONGA = 1
        AGRIBANK = 2
        VIETTINBANK = 3
        KHAC = 10
    End Enum
    Enum ELoaiPhieuNhap
        NhapHangMoi = 1
        NhapDieuChinh = 2
        NhapThuHoi = 3
    End Enum

    Enum ELoaiPhieuXuat
        XuatTraHang = 1
        XuatDieuChinh = 2
    End Enum

    Public Enum EXACNHANCONGNO
        CONGNOCU = 0
        SANPHAM = 1
        CONGTIEN = 2
        SANPHAMTRAHANG = 3
        CONGTIENTRAHANG = 4
        PHIEUTHU = 5
        CONGTIENPHIEUTHU = 6
        PHIEUCHI = 7
        CONGTIENPHIEUCHI = 8
    End Enum

    Public Enum ETheLoai
        BinhThuong = 0
        DongCongTien = 1
        ChietKhauPhanTram = 2
        GiamTien = 3
        DongGhiChu = 4
        ThanhTien = 5
        TienTruocThue = 6
        DongTenSPQuaDai = 7
    End Enum

    Public Enum ELoaiTem
        MotTem = 1
        BaTem = 2
    End Enum

    Public Enum ETrangThaiThe
        ChuaCapThe = 0
        KichHoat = 1
        KhoaThe = 2
    End Enum
#End Region

#Region "Undo change"
    Public Sub undoChange()
        ClearUpdateChanges()
        ClearInsertChanges()
        ClearDeleteChanges()
    End Sub

    Public Sub ClearUpdateChanges()
        Dim changes As ChangeSet = dt.GetChangeSet()
        For Each update In changes.Updates
            dt.Refresh(RefreshMode.OverwriteCurrentValues, update)
        Next
    End Sub

    Public Sub ClearInsertChanges()
        For Each insertion In dt.GetChangeSet.Inserts
            dt.GetTable(insertion.[GetType]()).DeleteOnSubmit(insertion)
        Next
    End Sub

    Public Sub ClearDeleteChanges()
        Try
            For Each insertion In dt.GetChangeSet.Deletes
                dt.GetTable(insertion.[GetType]()).InsertOnSubmit(insertion)
            Next
        Catch
        End Try
    End Sub
#End Region

#Region "BỎ DẤU TIẾNG VIỆT"
    ''' <summary>
    ''' Bỏ dấu tiếng việt
    ''' </summary>
    ''' <remarks></remarks>
    Public Function BoDauTiengViet(accented As String) As String
        If accented Is Nothing Then Return ""
        Dim regex As New Regex("\p{IsCombiningDiacriticalMarks}+")
        Dim strFormD As String = accented.Normalize(NormalizationForm.FormD)
        Return regex.Replace(strFormD, [String].Empty).Replace("đ"c, "d"c).Replace("Đ"c, "D"c).ToLower
    End Function
#End Region

#Region "Danh sách tham số"

    Public Sub InPhieuXuat(PhieuXuat As tbPhieuXuat, TongTien As Decimal)
        Dim frm As New ProgressingDialog
        frm.Animation = ProgressingDialog.AnimationStyle.Waiting
        frm.Caption = "Đang in phiếu xuất..."
        frm.Message = "Vui lòng chờ"
        frm.DialogStyle = ProgressingDialog.ProgressingDialogStyle.ContinuingDialog
        frm.Show()
        Dim rp As tbReport
        Try
            rp = dt.tbReports.ToList(My.Settings.KieuPhieuXuat)
        Catch ex As Exception
            frm.Dismiss()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không tìm thấy mẫu phiếu. Vui lòng kiểm tra tại mục Quản Lý Biểu Mẫu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

        Dim rls = dt.tbChiTietPhieuXuats.Where(Function(s) s.idPhieuXuat = PhieuXuat.id)
        Dim ds As New ReportDataSource
        ds.Name = "dsChiTietPhieuXuat"
        ds.Value = rls

        ' in ra file rồi in file
        Dim printReport As New mdlPrintReport
        Dim report As New LocalReport
        report.ReportPath = Application.StartupPath + rp.FileRDLC.Substring(1)
        report.DataSources.Clear()
        report.DataSources.Add(ds)
        report.EnableExternalImages = True

        report.SetParameters(DanhSachThamSo(PhieuXuat, TongTien))
        Try
            printReport.Run(report, rp)
        Catch
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không in được phiếu xuất tổng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            frm.Dismiss()
        End Try
    End Sub
    'DANH SÁCH THAM SỐ PHIẾU XUẤT
    Public Function DanhSachThamSo(px As tbPhieuXuat, TongTien As Decimal) As ReportParameterCollection
        Dim SoLanString As String
        Dim SoLan As Integer
        Dim DiaChiGiaoHang As String = ""
        Dim TenNguoiLienHe As String = ""
        Dim SoDienThoaiNguoiLienHe As String = ""
        If px.tbKhachHangDatHang Is Nothing Then
            SoLanString = "1 lần"
            DiaChiGiaoHang = ""
            TenNguoiLienHe = ""
        Else
            Dim vKhachHangDatHang = dt.vwKhachHangDatHangs.Single(Function(s) s.id = px.idKhachHangDatHang)
            SoLan = px.tbKhachHangDatHang.tbPhieuXuats.Where(Function(s) s.id <= px.id).Count.ToString
            If vKhachHangDatHang.isGiaoHangXong = 1 Then
                If SoLan < dt.tbPhieuXuats.Where(Function(s) s.idKhachHangDatHang = px.idKhachHangDatHang).Count Then
                    SoLanString = SoLan.ToString + " (còn)"
                Else
                    SoLanString = SoLan.ToString + " (hết)"
                End If
            Else
                SoLanString = SoLan.ToString + " (còn)"
            End If
            DiaChiGiaoHang = px.tbKhachHangDatHang.DiaChiGiaoHang
            If px.tbKhachHangDatHang.tbChiTietLienHe IsNot Nothing Then
                TenNguoiLienHe = px.tbKhachHangDatHang.tbChiTietLienHe.TenNguoiLienHe
                SoDienThoaiNguoiLienHe = px.tbKhachHangDatHang.tbChiTietLienHe.TenNguoiLienHe
            End If
        End If
        Dim lstParameters As New ReportParameterCollection
        With lstParameters
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
            .Add(New ReportParameter("HienAnh", My.Settings.HienAnhTrenHoaDon))
            .Add(New ReportParameter("MaPhieu", px.MaPhieu))
            .Add(New ReportParameter("NgayLap", px.NgayLap))
            .Add(New ReportParameter("TienChu", Number2Text.Number2Text.Num2Text((TongTien * 1.1).ToString)))
            .Add(New ReportParameter("NgayIn", Now))
            .Add(New ReportParameter("GhiChu", px.GhiChu))
            .Add(New ReportParameter("SoLan", SoLanString))
            .Add(New ReportParameter("DiaChiGiaoHang", DiaChiGiaoHang))
            .Add(New ReportParameter("TenNguoiLienHe", TenNguoiLienHe))
            .Add(New ReportParameter("SoDienThoaiNguoiLienHe", SoDienThoaiNguoiLienHe))
            If px.tbKhachHang IsNot Nothing Then
                .Add(New ReportParameter("TieuDe", "PHIẾU XUẤT KHO"))
                .Add(New ReportParameter("TenNhaCungCap", px.tbKhachHang.TenRutGon))
                .Add(New ReportParameter("SoDienThoai", px.tbKhachHang.SoDienThoai))
                .Add(New ReportParameter("DiaChi", px.tbKhachHang.DiaChi))
            Else
                .Add(New ReportParameter("TieuDe", "PHIẾU XUẤT ĐIỀU CHỈNH"))
            End If
        End With
        Return lstParameters
    End Function
    Public Function DanhSachThamSo(NgayLap As DateTime, TongTien As Decimal) As ReportParameterCollection
        Dim lstParameters As New ReportParameterCollection
        With lstParameters
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
            .Add(New ReportParameter("HienAnh", My.Settings.HienAnhTrenHoaDon))
            .Add(New ReportParameter("NgayLap", NgayLap))
            .Add(New ReportParameter("TienChu", Number2Text.Number2Text.Num2Text(TongTien.ToString)))
            .Add(New ReportParameter("NgayIn", Now))
            .Add(New ReportParameter("TieuDe", "CHI TIẾT HÀNG XUẤT KHO"))
        End With
        Return lstParameters
    End Function
    'DANH SÁCH THAM SỐ PHIẾU NHẬP
    Public Function DanhSachThamSo(pn As tbPhieuNhap, TongTien As Decimal) As ReportParameterCollection
        Dim lstParameters As New ReportParameterCollection
        With lstParameters
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("HienAnh", My.Settings.HienAnhTrenHoaDon))
            .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
            .Add(New ReportParameter("MaPhieu", pn.MaPhieu))
            .Add(New ReportParameter("NgayLap", pn.NgayLap))
            .Add(New ReportParameter("TienChu", Number2Text.Number2Text.Num2Text(TongTien.ToString)))
            .Add(New ReportParameter("NgayIn", Now))

            If pn.tbLoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapHangMoi Then
                .Add(New ReportParameter("TieuDe", "PHIẾU NHẬP KHO"))
                .Add(New ReportParameter("TenNhaCungCap", pn.tbKhachHang.TenRutGon))
                .Add(New ReportParameter("DienThoai", pn.tbKhachHang.TenKhachHang))
                .Add(New ReportParameter("DiaChi", pn.tbKhachHang.DiaChi))

                .Add(New ReportParameter("HienCongNo", True))
                .Add(New ReportParameter("CongNoCu", dt.LayCongNoCuNhaCungCap(pn.NgayLap, pn.tbKhachHang.id)))
                .Add(New ReportParameter("SoTienThanhToan", pn.SoTienThanhToan))
            ElseIf pn.tbLoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapThuHoi Then
                .Add(New ReportParameter("TieuDe", "PHIẾU NHẬP TRẢ HÀNG"))
                .Add(New ReportParameter("TenNhaCungCap", pn.tbKhachHang.TenKhachHang))
                .Add(New ReportParameter("DienThoai", pn.tbKhachHang.SoDienThoai))
                .Add(New ReportParameter("DiaChi", pn.tbKhachHang.DiaChi))
            Else
                .Add(New ReportParameter("TieuDe", "PHIẾU NHẬP ĐIỀU CHỈNH"))
            End If

            .Add(New ReportParameter("VAT", pn.VAT))
            .Add(New ReportParameter("ChietKhau", pn.ChietKhau))
            .Add(New ReportParameter("GhiChu", pn.GhiChu))
        End With
        Return lstParameters
    End Function
    Public Function DanhSachThamSo(pn As tbPhieuNhap, TongTien As Decimal, i As Integer) As ReportParameterCollection
        Dim lstParameters As New ReportParameterCollection
        With lstParameters
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("HienAnh", My.Settings.HienAnhTrenHoaDon))
            .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
            .Add(New ReportParameter("MaPhieu", pn.MaPhieu))
            .Add(New ReportParameter("NgayLap", pn.NgayLap))
            .Add(New ReportParameter("TienChu", Number2Text.Number2Text.Num2Text(TongTien.ToString)))
            .Add(New ReportParameter("NgayIn", Now))


            .Add(New ReportParameter("TieuDe", "CHI TIẾT HÀNG NHẬP KHO"))

            .Add(New ReportParameter("VAT", pn.VAT))
            .Add(New ReportParameter("ChietKhau", pn.ChietKhau))
            .Add(New ReportParameter("GhiChu", pn.GhiChu))
        End With
        Return lstParameters
    End Function
    Public Function DanhSachThamSo(dh As tbKhachHangDatHang, TongTien As Decimal) As ReportParameterCollection
        Dim NhanVien = dt.tbNhanViens.FirstOrDefault(Function(s) s.id = dh.idNhanVien)
        If NhanVien Is Nothing Then
            NhanVien = loginNhanVien
        End If
        Dim NguoiLienHe = dt.tbChiTietLienHes.FirstOrDefault(Function(s) s.id = dh.idNguoiLienHe)
        If NguoiLienHe Is Nothing Then
            NguoiLienHe = New tbChiTietLienHe
        End If
        Dim lstParameters As New ReportParameterCollection
        With lstParameters
            .Add(New ReportParameter("HienAnh", My.Settings.HienAnhTrenHoaDon))
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))

            .Add(New ReportParameter("TenKhachHang", dh.tbKhachHang.TenKhachHang))
            .Add(New ReportParameter("DiaChi", dh.tbKhachHang.DiaChi))
            .Add(New ReportParameter("DienThoai", dh.tbKhachHang.SoDienThoai))
            .Add(New ReportParameter("SoFax", dh.tbKhachHang.SoFAX))
            .Add(New ReportParameter("MaSoThue", dh.tbKhachHang.MaSoThue))

            .Add(New ReportParameter("NguoiGui", dh.tbNhanVien.TenNhanVien))
            .Add(New ReportParameter("SoPhieu", dh.SoPhieu))
            .Add(New ReportParameter("MaHoaDon", dh.MaDatHang))
            .Add(New ReportParameter("NgayLap", dh.NgayLap.ToString("dd/MM/yyyy")))
            .Add(New ReportParameter("NgayDuKienGiao", dh.NgayDuKienGiaoHang))
            .Add(New ReportParameter("GhiChu", dh.GhiChu))
            .Add(New ReportParameter("NhacNho", My.Settings.NhacNho))
            .Add(New ReportParameter("ChietKhauDatHang", dh.ChietKhau))
            .Add(New ReportParameter("VAT", dh.VAT))
            .Add(New ReportParameter("NgayIn", DateTime.Now))
            Dim CongNoCu As Decimal? = dt.LayCongNoCuKhachHang(dh.NgayLap, dh.tbKhachHang.id)
            .Add(New ReportParameter("CongNoCu", CongNoCu.GetValueOrDefault))
            .Add(New ReportParameter("TienChu", Number2Text.Number2Text.Num2Text(Math.Round((TongTien), 0, MidpointRounding.AwayFromZero).ToString))) '
            .Add(New ReportParameter("DiaChiGiaoHang", dh.DiaChiGiaoHang))
            .Add(New ReportParameter("TenNhanVien", NhanVien.TenNhanVien))
            '.Add(New ReportParameter("SoDienThoaiNhanVien", NhanVien.SoDienThoai))
            '.Add(New ReportParameter("EmailNhanVien", ""))
            .Add(New ReportParameter("TenNguoiLienHe", NguoiLienHe.TenNguoiLienHe))
            .Add(New ReportParameter("SoDienThoaiNguoiLienHe", NguoiLienHe.SoDienThoai))
            '.Add(New ReportParameter("EmailNguoiLienHe", NguoiLienHe.Email))
        End With
        Return lstParameters
    End Function

    Public Function DanhSachThamSo(BangBaoGia As tbBaoGia, isHienNhieuBaoGia As Boolean)
        Dim NhanVien = dt.tbNhanViens.FirstOrDefault(Function(s) s.id = BangBaoGia.idNhanVien)
        If NhanVien Is Nothing Then
            NhanVien = loginNhanVien
        End If
        Dim NguoiLienHe = dt.tbChiTietLienHes.FirstOrDefault(Function(s) s.id = BangBaoGia.idNguoiLienHe)
        If NguoiLienHe Is Nothing Then
            NguoiLienHe = New tbChiTietLienHe
        End If
        Dim lstParameter As New ReportParameterCollection
        With lstParameter
            .Add(New ReportParameter("TenCongTy", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
            .Add(New ReportParameter("HienAnh", My.Settings.HienAnhTrenHoaDon))
            .Add(New ReportParameter("NgayIn", Now))
            If BangBaoGia.tbLoaiBaoGia.Loai = 1 Then
                .Add(New ReportParameter("TenBaoCao", "THƯ CHÀO GIÁ"))
            Else
                .Add(New ReportParameter("TenBaoCao", "BẢNG BÁO GIÁ"))
            End If
            .Add(New ReportParameter("MaPhieu", BangBaoGia.MaPhieu))
            .Add(New ReportParameter("GhiChu", BangBaoGia.GhiChu))
            .Add(New ReportParameter("NgayLap", BangBaoGia.NgayLap))
            .Add(New ReportParameter("KieuHienThi", BangBaoGia.ModeHienThi))
            .Add(New ReportParameter("TenNhanVien", NhanVien.TenNhanVien))
            .Add(New ReportParameter("SoDienThoaiNhanVien", NhanVien.SoDienThoai))
            .Add(New ReportParameter("EmailNhanVien", ""))
            .Add(New ReportParameter("TenKhachHang", BangBaoGia.tbKhachHang.TenRutGon))
            .Add(New ReportParameter("TenNguoiLienHe", NguoiLienHe.TenNguoiLienHe))
            .Add(New ReportParameter("SoDienThoaiNguoiLienHe", NguoiLienHe.SoDienThoai))
            .Add(New ReportParameter("EmailNguoiLienHe", NguoiLienHe.Email))
            .Add(New ReportParameter("isHienNhieuBaoGia", isHienNhieuBaoGia))
        End With
        Return lstParameter
    End Function
    Public Function DanhSachThamSo(PhieuThu As vwPhieuThu)
        Dim iPhieuThu = dt.tbPhieuThus.Single(Function(s) s.id = PhieuThu.id)
        Dim lstParameter As New ReportParameterCollection
        With lstParameter
            .Add(New ReportParameter("TenCuaHang", My.Settings.TenCongTy))
            .Add(New ReportParameter("ThongTinLienHe", My.Settings.ThongTinLienHe))
            .Add(New ReportParameter("MaPhieu", PhieuThu.MaPhieu))
            .Add(New ReportParameter("SoPhieu", PhieuThu.SoPhieu))
            .Add(New ReportParameter("NgayLap", PhieuThu.NgayLap))
            .Add(New ReportParameter("TenNguoiNop", PhieuThu.TenNguoiNop))
            .Add(New ReportParameter("DiaChi", PhieuThu.DiaChi))
            .Add(New ReportParameter("SoTien", PhieuThu.SoTien))
            .Add(New ReportParameter("LyDo", PhieuThu.LyDo))
            .Add(New ReportParameter("DuongDanAnh", "file:" + My.Settings.DuongDanAnh))
            .Add(New ReportParameter("ChungTuKemTheo", PhieuThu.ChungTuKemTheo))
            .Add(New ReportParameter("TienChu", Number2Text.Number2Text.Num2Text(PhieuThu.SoTien)))
            .Add(New ReportParameter("NgayIn", Now))
            .Add(New ReportParameter("TenNhanVien", PhieuThu.TenNhanVien))
            .Add(New ReportParameter("NguoiNhanTien", PhieuThu.NguoiNhanTien))
            .Add(New ReportParameter("LoaiPhieuThu", iPhieuThu.tbLoaiPhieuThu.LoaiThu.Trim))
            .Add(New ReportParameter("TenNganHang", iPhieuThu.tbNganHang.TenNganHang))
        End With
        Return lstParameter
    End Function
#End Region

#Region "BACKUP DỮ LIỆU"
    Public Function ConnectionData() As SqlConnection
        Dim cn As SqlConnection = New SqlConnection(ChuoiConnectString)
        cn.Open()
        Return cn
    End Function

    Public Sub BackupDatabase()
        If Directory.Exists(My.Settings.DuongDanFileBackup) = False Then Exit Sub
        Dim ThoiGianSaoLuu As DateTime = Now
        Dim cn As SqlConnection = ConnectionData()
        Dim chuoiConnect As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(ChuoiConnectString)
        Dim tenFile As String = My.Application.Info.ProductName + ThoiGianSaoLuu.ToString("ddMMyy_HHmmss.bak")
        Dim sqlBackup As String = "BACKUP DATABASE " + chuoiConnect.InitialCatalog +
                                    " TO DISK ='" + My.Settings.DuongDanFileBackup + "\" +
                                    tenFile + "'" + " WITH FORMAT;"

        Dim cmd As SqlCommand = New SqlCommand(sqlBackup, cn)
        Try
            cmd.ExecuteNonQuery()

            If dt IsNot Nothing Then
                ' Ghi lịch sử backup
                Dim news As New tbLogBackup
                With news
                    .NgayThucHien = ThoiGianSaoLuu
                    .NoiDung = "Sao lưu toàn bộ dữ liệu. Tên file backup: " + tenFile +
                        ", đường dẫn chứa file: '" + My.Settings.DuongDanFileBackup + "' ."
                End With
                dt.tbLogBackups.InsertOnSubmit(news)
                dt.SubmitChanges()
            End If
        Catch ex As Exception
        End Try
        cn.Close()
    End Sub


    Private Function GetBakFile(ThuMuc As String) As List(Of clsBackFile)
        Dim lstBakFile As New List(Of clsBackFile)
        If Directory.Exists(ThuMuc) Then
            Dim bakList As String() = Directory.GetFiles(ThuMuc, "*.bak")
            Dim bakFileInfo As FileInfo
            Dim newBakFile As clsBackFile
            For Each fle As String In bakList
                bakFileInfo = New FileInfo(fle)
                newBakFile = New clsBackFile
                newBakFile.CreatedDate = bakFileInfo.CreationTime
                newBakFile.FilePath = fle
                lstBakFile.Add(newBakFile)
            Next
        End If
        Return lstBakFile
    End Function


    Public Sub XoaBakFile(NgayXoa As Date, ThuMuc As String)
        If Directory.Exists(ThuMuc) = False Then Exit Sub
        Dim lst = GetBakFile(ThuMuc)

        If lst.Where(Function(s) s.CreatedDate < NgayXoa).Count > 5 Then
            For Each itm In lst.Where(Function(s) s.CreatedDate < NgayXoa).OrderByDescending(Function(s) s.CreatedDate).Skip(5)
                Try
                    File.Delete(itm.FilePath)

                    If dt IsNot Nothing Then
                        ' Ghi lịch sử backup
                        Dim news As New tbLogBackup
                        With news
                            .NgayThucHien = TMT_GioHeThong
                            .NoiDung = "Xoá file backup: " + itm.FilePath + " ."
                        End With
                        dt.tbLogBackups.InsertOnSubmit(news)
                        dt.SubmitChanges()
                    End If

                Catch ex As Exception
                End Try
            Next
        End If
    End Sub
#End Region

#Region "XÓA FILE TẠM"
    Private Function GetEMFFile(ThuMuc As String) As List(Of clsBackFile)
        Dim lstBakFile As New List(Of clsBackFile)
        If Directory.Exists(ThuMuc) Then
            Dim bakList As String() = Directory.GetFiles(ThuMuc, "*.EMF")
            Dim bakFileInfo As FileInfo
            Dim newBakFile As clsBackFile
            For Each fle As String In bakList
                bakFileInfo = New FileInfo(fle)
                newBakFile = New clsBackFile
                newBakFile.CreatedDate = bakFileInfo.CreationTime
                newBakFile.FilePath = fle
                lstBakFile.Add(newBakFile)
            Next
        End If
        Return lstBakFile
    End Function

    Public Sub XoaFileTam()
        Dim ThuMuc As String = Application.StartupPath + "\FileTam"
        If Directory.Exists(ThuMuc) = False Then Exit Sub
        Dim lst = GetEMFFile(ThuMuc)

        For Each itm In lst.Where(Function(s) s.CreatedDate.Date < Now.AddDays(-3).Date)
            Try
                File.Delete(itm.FilePath)
            Catch ex As Exception
            End Try
        Next
    End Sub
#End Region

#Region "PHÂN QUYỀN"
    Public Sub CapNhatQuyen(idNhanVien As Integer)
        For Each q In dt.tbQuyens
            If dt.tbPhanQuyens.SingleOrDefault(Function(s) s.idNhanVien = idNhanVien And s.idQuyen = q.id) Is Nothing Then
                Dim newPhanQUyen As New tbPhanQuyen
                newPhanQUyen.idNhanVien = idNhanVien
                newPhanQUyen.idQuyen = q.id
                newPhanQUyen.TrangThai = True
                dt.tbPhanQuyens.InsertOnSubmit(newPhanQUyen)
                dt.SubmitChanges()
            End If
        Next
    End Sub

    Public Sub PhanQuyenLenDoiTuong(ctr As Object, HinhThuc As Integer, TrangThaiQuyen As Boolean)
        If HinhThuc = 0 Then
            ctr.Visible = TrangThaiQuyen
        ElseIf HinhThuc = 1 Then
            ctr.Enabled = TrangThaiQuyen
        ElseIf HinhThuc = 2 Then
            ctr.ReadOnly = Not TrangThaiQuyen
        End If
    End Sub

    Public Sub CapNhatQuyenTheoId(idQuyen As Integer)
        For Each q In dt.tbQuyens.Where(Function(s) s.id >= idQuyen)
            For Each nv In dt.tbNhanViens
                If dt.tbPhanQuyens.SingleOrDefault(Function(s) s.idNhanVien = nv.id And s.idQuyen = q.id) Is Nothing Then
                    Dim newPhanQUyen As New tbPhanQuyen
                    newPhanQUyen.idNhanVien = nv.id
                    newPhanQUyen.idQuyen = q.id
                    newPhanQUyen.TrangThai = False
                    dt.tbPhanQuyens.InsertOnSubmit(newPhanQUyen)
                    dt.SubmitChanges()
                End If
            Next
        Next
    End Sub
#End Region

#Region "THÔNG BÁO MESSAGE"
    Public Sub ThongBao(str As String)
        ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Public Sub ThongBaoInfo(str As String)
        ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub ThongBaoError(str As String)
        ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function XacNhanYesNo(str As String) As DialogResult
        Return frmMessageBox.Show(str, "Xác nhận") ', MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function

    Public Sub ThongBaoErrorVoiException(str As String, ex As Exception)
        ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(str + vbNewLine + "Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
#End Region

    '#Region "GHI LOG NHÂN VIÊN"
    '    Public Sub GhiLogNhanVien(strNoiDung As String)
    '        ' Ghi log nhân viên
    '        Try
    '            Dim newLogNhanVien As New tbLichSuThayDoi
    '            newLogNhanVien.idNhanVien = loginNhanVien.id
    '            newLogNhanVien.NgayThayDoi = TMT_GioHeThong
    '            newLogNhanVien.NoiDung = strNoiDung
    '            newLogNhanVien.NoiDungString = BoDauTiengViet(strNoiDung)
    '            dt.tbLichSuThayDois.InsertOnSubmit(newLogNhanVien)
    '            dt.SubmitChanges()
    '        Catch ex As Exception
    '            undoChange()
    '        End Try
    '    End Sub
    '#End Region

#Region "XUẤT FILE EXCEL"
    Public Sub XuatFileExcel(dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
        Dim savefiledialog As New SaveFileDialog
        savefiledialog.Title = "Xuất dữ liệu ra Excel"
        savefiledialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 workbook (*xls)|*xls"
        If savefiledialog.ShowDialog = DialogResult.OK Then
            Dim frm As New ProgressingDialog
            frm.Animation = ProgressingDialog.AnimationStyle.Waiting
            frm.Caption = "Đang xuất dữ liệu..."
            frm.Message = "Vui lòng chờ"
            frm.DialogStyle = ProgressingDialog.ProgressingDialogStyle.ContinuingDialog
            frm.Show()

            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Dim i, j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")

            Dim formatRange As Microsoft.Office.Interop.Excel.Range
            formatRange = xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, dgv.ColumnCount))
            formatRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Navy)
            formatRange.Font.Bold = True
            formatRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.AliceBlue)
            Dim border As Microsoft.Office.Interop.Excel.Borders = formatRange.Borders
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            border.Weight = 2.0


            Dim k As Integer
            For k = 0 To dgv.ColumnCount - 1
                If dgv.Columns(k).Visible Then
                    xlWorkSheet.Cells(1, k + 1) = dgv.Columns(k).HeaderText
                End If

            Next
            For i = 0 To dgv.RowCount - 1
                For j = 0 To dgv.ColumnCount - 1
                    If dgv.Columns(j).Visible Then
                        formatRange = xlWorkSheet.Range(xlWorkSheet.Cells(i + 2, j + 1), xlWorkSheet.Cells(i + 2, j + 1))
                        If dgv.Columns(j).DefaultCellStyle.Format = "N0" Or dgv.Columns(j).DefaultCellStyle.Format = "n0" Then
                            formatRange.NumberFormat = "###,###,###,###,##0"
                        ElseIf dgv.Columns(j).DefaultCellStyle.Format = "N1" Or dgv.Columns(j).DefaultCellStyle.Format = "n1" Then
                            formatRange.NumberFormat = "###,###,###,###,##0.#"
                        ElseIf dgv.Columns(j).DefaultCellStyle.Format = "N2" Or dgv.Columns(j).DefaultCellStyle.Format = "n2" Then
                            formatRange.NumberFormat = "###,###,###,###,##0.##"
                        ElseIf dgv.Columns(j).DefaultCellStyle.Format = "N3" Or dgv.Columns(j).DefaultCellStyle.Format = "n3" Then
                            formatRange.NumberFormat = "###,###,###,###,##0.###"
                        ElseIf dgv.Columns(j).DefaultCellStyle.Format = "" Then
                            formatRange.NumberFormat = "@" ' Format TEXT
                        Else
                            formatRange.NumberFormat = dgv.Columns(j).DefaultCellStyle.Format
                        End If
                        xlWorkSheet.Cells(i + 2, j + 1) = dgv(j, i).Value
                    End If
                Next
            Next

            xlWorkSheet.SaveAs(savefiledialog.FileName)
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            frm.Dismiss()
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub ExportExcelFromGridView(gridControl As DevExpress.XtraGrid.GridControl)
        Dim filename As String
        Dim SaveFileDialog As New SaveFileDialog()
        SaveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
        SaveFileDialog.FilterIndex = 2
        SaveFileDialog.RestoreDirectory = True
        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            filename = SaveFileDialog.FileName
            Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView = gridControl.ViewCollection(0)
            gridview.OptionsPrint.AutoWidth = False
            gridControl.ExportToXlsx(filename)
            If System.IO.File.Exists(filename) Then
                Dim DialogResult As DialogResult = MessageBox.Show("Đã xuất " & filename & vbNewLine & "Bạn có muốn mở file Excel vừa tạo?", "Export...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DialogResult = Windows.Forms.DialogResult.Yes Then
                    System.Diagnostics.Process.Start(filename)
                End If
            End If
        End If
    End Sub

#End Region
End Module
