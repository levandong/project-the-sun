Imports System.Threading

Public Class frmMain
    Private timerTMT As Threading.Timer
    Private tcb As TimerCallback = AddressOf NhayThoiGian
    Private autoEvent As New AutoResetEvent(False)
    Public DaStartTimerTMTBayGio As Boolean

    Public Sub NhayThoiGian()
        TMT_GioHeThong = TMT_GioHeThong.AddSeconds(1)
        CtrlMain1.CtrlRibbon1.lblGioHeThong.Text = String.Format("{0:dddd, dd/MM/yyyy HH:mm:ss}", TMT_GioHeThong)
    End Sub
    Public Sub ChangeLanguage()
        Dim usLang As InputLanguage = GetLanguage("US")
        InputLanguage.CurrentInputLanguage = usLang
    End Sub

    Public Function GetLanguage(language As String) As Windows.Forms.InputLanguage
        language = language.ToLower()
        For Each lang As System.Windows.Forms.InputLanguage In System.Windows.Forms.InputLanguage.InstalledInputLanguages
            If lang.LayoutName.ToLower() = language Then
                Return lang
            End If
        Next
        Return Nothing
    End Function
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeLanguage()
        CtrlDangNhap1.txtTaiKhoan.Focus()
        Me.Text = ".:: Phần mềm quản lý bán hàng chuyên nghiệp ::. v." + Application.ProductVersion
    End Sub



    Private Sub CtrlMain1_DangXuatChuongTrinh() Handles CtrlMain1.DangXuatChuongTrinh
        Timer1.Stop()

        CtrlDangNhap1.BringToFront()
        loginNhanVien = Nothing
        Me.KeyPreview = False
        undoChange()
    End Sub

    Private Sub CtrlDangNhap1_DangNhapThanhCong() Handles CtrlDangNhap1.DangNhapThanhCong
        TMT_GioHeThong = Now
        If DaStartTimerTMTBayGio = False Then
            timerTMT = New Threading.Timer(tcb, autoEvent, 1000, 1000)
            DaStartTimerTMTBayGio = True
        End If

        CtrlMain1.PhanQuyen()
        CtrlMain1.CtrlRibbon1.pnlHeThongTaiKhoan.Values.Heading = loginNhanVien.TenDangNhap
        CtrlMain1.BringToFront()
        Me.KeyPreview = True

        'CapNhatQuyenTheoId(133)
    End Sub

    Private Sub frmMainMoi_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If CtrlMain1.CtrlTabPanel1.chkSet.CheckedButton Is Nothing Then Exit Sub
        Dim ActiveControl As Control = CType(CtrlMain1.CtrlTabPanel1.chkSet.CheckedButton.Parent.Parent, ctrlTabHeader).tabPanel
        If e.KeyCode = Keys.F2 Then
            If TypeOf ActiveControl Is ctrlThemSuaXoaKhachHang Then
                CType(ActiveControl, ctrlThemSuaXoaKhachHang).btnThem_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThemSuaXoaGiaoViec Then
                CType(ActiveControl, ctrlThemSuaXoaGiaoViec).btnThem_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThemSuaXoaNganHang Then
                CType(ActiveControl, ctrlThemSuaXoaNganHang).btnThem_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThemSuaXoaSanPham Then
                CType(ActiveControl, ctrlThemSuaXoaSanPham).btnThemSanPham_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThongKeTienNganHang Then
                CType(ActiveControl, ctrlThongKeTienNganHang).frmThemPhieuThuTienMat_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlHoaDon Then
                CType(ActiveControl, ctrlHoaDon).btnThemSanPham_Click(Nothing, Nothing)
            End If

        ElseIf e.KeyCode = Keys.F3 Then
            If TypeOf ActiveControl Is ctrlThemSuaXoaKhachHang Then
                CType(ActiveControl, ctrlThemSuaXoaKhachHang).btnSua_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThemSuaXoaGiaoViec Then
                CType(ActiveControl, ctrlThemSuaXoaGiaoViec).btnSua_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThongKeBaoGia Then
                CType(ActiveControl, ctrlThongKeBaoGia).btnThemTabPageMoi_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThemSuaXoaNganHang Then
                CType(ActiveControl, ctrlThemSuaXoaNganHang).btnSua_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThemSuaXoaSanPham Then
                CType(ActiveControl, ctrlThemSuaXoaSanPham).btnSuaSanPham_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThongKeTienNganHang Then
                CType(ActiveControl, ctrlThongKeTienNganHang).btnThemPhieuChiTienMat_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThongKeKhachHangDatHang Then
                CType(ActiveControl, ctrlThongKeKhachHangDatHang).F3_btnThemDonDatHang_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThongKePhieuNhap Then
                CType(ActiveControl, ctrlThongKePhieuNhap).F3_btnThemPhieuNhap_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThongKeHoaDon Then
                CType(ActiveControl, ctrlThongKeHoaDon).F3_btnThemHoaDonDauVao_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThongKeGiaCongSanPham Then
                CType(ActiveControl, ctrlThongKeGiaCongSanPham).F3_btnThemPhieuGiaCong_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            If TypeOf ActiveControl Is ctrlThemSuaXoaKhachHang Then
                CType(ActiveControl, ctrlThemSuaXoaKhachHang).btnXoa_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThemSuaXoaGiaoViec Then
                CType(ActiveControl, ctrlThemSuaXoaGiaoViec).btnXoa_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThemSuaXoaNganHang Then
                CType(ActiveControl, ctrlThemSuaXoaNganHang).btnXoa_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThemSuaXoaSanPham Then
                CType(ActiveControl, ctrlThemSuaXoaSanPham).btnXoaSanPham_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlThongKeTienNganHang Then
                CType(ActiveControl, ctrlThongKeTienNganHang).btnThemPhieuThuUyNhiemChi_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlBangBaoGia Then
                CType(ActiveControl, ctrlBangBaoGia).F4_MoTheKho()
            ElseIf TypeOf ActiveControl Is ctrlSuaBangBaoGia Then
                CType(ActiveControl, ctrlSuaBangBaoGia).F4_MoTheKho()
            ElseIf TypeOf ActiveControl Is ctrlKhachHangDatHang Then
                CType(ActiveControl, ctrlKhachHangDatHang).F4_MoTheKho()
            ElseIf TypeOf ActiveControl Is ctrlSuaKhachHangDatHang Then
                CType(ActiveControl, ctrlSuaKhachHangDatHang).F4_MoTheKho()
            ElseIf TypeOf ActiveControl Is ctrlThongKeHoaDon Then
                CType(ActiveControl, ctrlThongKeHoaDon).F4_btnThemHoaDonDauRa_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F5 Then

            If TypeOf ActiveControl Is ctrlThemSuaXoaKhachHang Then
            ElseIf TypeOf ActiveControl Is ctrlThongKeTienNganHang Then
                CType(ActiveControl, ctrlThongKeTienNganHang).btnThemPhieuChiUyNhiemChi_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlSuaBangBaoGia Then
                CType(ActiveControl, ctrlSuaBangBaoGia).btnDongY_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlPhieuXuat Then
                CType(ActiveControl, ctrlPhieuXuat).btnDongY_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlKhachHangDatHang Then
                CType(ActiveControl, ctrlKhachHangDatHang).btnDongY_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlSuaKhachHangDatHang Then
                CType(ActiveControl, ctrlSuaKhachHangDatHang).btnDongY_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlPhieuNhap Then
                CType(ActiveControl, ctrlPhieuNhap).btnDongY_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlSuaPhieuNhap Then
                CType(ActiveControl, ctrlSuaPhieuNhap).btnDongY_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlBangBaoGia Then
                CType(ActiveControl, ctrlBangBaoGia).btnDongY_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            'If TypeOf ActiveControl Is ctrlBanHang Then
            '    CType(ActiveControl, ctrlBanHang).btnDongYVaIn_Click(Nothing, Nothing)
            'ElseIf TypeOf ActiveControl Is ctrlPhieuNhap Then
            '    CType(ActiveControl, ctrlPhieuNhap).btnDongYVaIn_Click(Nothing, Nothing)
            'ElseIf TypeOf ActiveControl Is ctrlPhieuXuat Then
            '    CType(ActiveControl, ctrlPhieuXuat).btnDongYVaIn_Click(Nothing, Nothing)
            If TypeOf ActiveControl Is ctrlThongKeTienNganHang Then
                CType(ActiveControl, ctrlThongKeTienNganHang).btnThemPhieuDieuChuyenTien_Click(Nothing, Nothing)
                'ElseIf TypeOf ActiveControl Is ctrlKhachHangDatHang Then
                '    CType(ActiveControl, ctrlKhachHangDatHang).btnDongYVaIn_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F7 Then
            'ElseIf TypeOf ActiveControl Is ctrlPhieuNhap Then
            '    CType(ActiveControl, ctrlPhieuNhap).btnXemTruoc_Click(Nothing, Nothing)
            'ElseIf TypeOf ActiveControl Is ctrlPhieuXuat Then
            '    CType(ActiveControl, ctrlPhieuXuat).btnXemTruoc_Click(Nothing, Nothing)
            'ElseIf TypeOf ActiveControl Is ctrlKhachHangDatHang Then
            '    CType(ActiveControl, ctrlKhachHangDatHang).btnXemTruoc_Click(Nothing, Nothing)
            If TypeOf ActiveControl Is ctrlThongKeTienNganHang Then
                CType(ActiveControl, ctrlThongKeTienNganHang).btnThemPhieuChiLuong_Click(Nothing, Nothing)
            ElseIf TypeOf ActiveControl Is ctrlBangBaoGia Then
                CType(ActiveControl, ctrlBangBaoGia).chkAn.Checked = Not CType(ActiveControl, ctrlBangBaoGia).chkAn.Checked
            ElseIf TypeOf ActiveControl Is ctrlSuaBangBaoGia Then
                CType(ActiveControl, ctrlSuaBangBaoGia).chkAn.Checked = Not CType(ActiveControl, ctrlBangBaoGia).chkAn.Checked
            ElseIf TypeOf ActiveControl Is ctrlKhachHangDatHang Then
                CType(ActiveControl, ctrlKhachHangDatHang).chkAn.Checked = Not CType(ActiveControl, ctrlBangBaoGia).chkAn.Checked
            ElseIf TypeOf ActiveControl Is ctrlSuaKhachHangDatHang Then
                CType(ActiveControl, ctrlSuaKhachHangDatHang).chkAn.Checked = Not CType(ActiveControl, ctrlBangBaoGia).chkAn.Checked
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            'If TypeOf ActiveControl Is ctrlBanHang Then
            '    CType(ActiveControl, ctrlBanHang).CtrlTimKiemSanPham1.ChuyenDoiKieuTimKiem()
            'ElseIf TypeOf ActiveControl Is ctrlPhieuNhap Then
            '    CType(ActiveControl, ctrlPhieuNhap).CtrlTimKiemSanPham1.ChuyenDoiKieuTimKiem()
            'ElseIf TypeOf ActiveControl Is ctrlKhachHangDatHang Then
            '    CType(ActiveControl, ctrlKhachHangDatHang).CtrlTimKiemSanPham1.ChuyenDoiKieuTimKiem()
            If TypeOf ActiveControl Is ctrlThongKeTienNganHang Then
                CType(ActiveControl, ctrlThongKeTienNganHang).btnThemPhieuChiKhac_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            'If TypeOf ActiveControl Is ctrlBanHang Then
            '    CType(ActiveControl, ctrlBanHang).CtrlTimKiemSanPham1.ChuyenDoiDonViTinh()
            'ElseIf TypeOf ActiveControl Is ctrlPhieuNhap Then
            '    CType(ActiveControl, ctrlPhieuNhap).CtrlTimKiemSanPham1.ChuyenDoiDonViTinh()
            'ElseIf TypeOf ActiveControl Is ctrlKhachHangDatHang Then
            '    CType(ActiveControl, ctrlKhachHangDatHang).CtrlTimKiemSanPham1.ChuyenDoiDonViTinh()
            If TypeOf ActiveControl Is ctrlThongKeTienNganHang Then
                CType(ActiveControl, ctrlThongKeTienNganHang).btnThemPhieuThuKhac_Click(Nothing, Nothing)
            End If
        End If

    End Sub
    Private Sub btnKetNoiMayChu_Click(sender As Object, e As EventArgs) Handles btnKetNoiMayChu.Click
        frmKetNoiDatabase.ShowDialog()
    End Sub

End Class