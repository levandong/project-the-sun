Public Class ctrlMain
    Private Sub ctrlMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadControlToList(CtrlRibbon1.pnlHeader)
    End Sub

    Private Sub CtrlRibbon1_ThuNhoRibbon(isThuNho As Boolean) Handles CtrlRibbon1.ThuNhoRibbon
        If isThuNho = False Then
            KryptonPanel3.Height += CtrlRibbon1.KryptonGroup1.Height
        Else
            KryptonPanel3.Height -= CtrlRibbon1.KryptonGroup1.Height
        End If
    End Sub

#Region "PHÂN QUYỀN"
    Dim lstControl As New List(Of Control)
    Private lstPhanQuyen As New List(Of tbQuyen)
    Private Sub LoadControlToList(ctrl As Control)
        If (ctrl.Tag IsNot Nothing) Then
            lstControl.Add(ctrl)
        End If
        For Each itm As Control In ctrl.Controls
            LoadControlToList(itm)
        Next
    End Sub

    Private Sub LoadQuyenToList(phanQuyen As tbQuyen)
        lstPhanQuyen.Add(phanQuyen)
        For Each itm As tbQuyen In phanQuyen.tbQuyens
            If itm.TheLoai <= 1 Then
                LoadQuyenToList(itm)
            End If
        Next
    End Sub
    Public Sub PhanQuyen()
        Exit Sub
        If loginNhanVien IsNot Nothing And dt.tbPhanQuyens.Count > 0 Then
            lstPhanQuyen.Clear()
            LoadQuyenToList(dt.tbQuyens.Single(Function(s) s.idQuyenCha Is Nothing))
            Dim j As Integer
            For j = 0 To lstPhanQuyen.Count - 1
                Dim PhanQuyen As vwPhanQuyen = dt.vwPhanQuyens.Single(Function(s) s.idQuyen = lstPhanQuyen(j).id And s.idNhanVien = loginNhanVien.id)
                If PhanQuyen.HinhThuc = 0 And PhanQuyen.TheLoai <> 1 Then
                    lstControl(j).Visible = PhanQuyen.TrangThai
                ElseIf PhanQuyen.HinhThuc = 1 Then
                    lstControl(j).Enabled = PhanQuyen.TrangThai
                End If
            Next
        End If
    End Sub
#End Region

    '#Region "HỆ THỐNG"
    Event DangXuatChuongTrinh()
    '    Private Sub CtrlRibbon1_BamHeThongPhanQuyen() Handles CtrlRibbon1.BamHeThongPhanQuyen
    '        Dim PhanQuyen As New ctrlPhanQuyen
    '        CtrlTabPanel1.ThemTabpageMoi("Phân quyền", "PhanQuyen", PhanQuyen)
    '    End Sub

    Private Sub CtrlRibbon1_BamHeThongSaoLuuPhucHoiDuLieu() Handles CtrlRibbon1.BamHeThongSaoLuuPhucHoiDuLieu
        Dim SaoLuuPhucHoi As New ctrlSaoLuuPhucHoi
        CtrlTabPanel1.ThemTabpageMoi("Backup/Restore", "SaoLuuPhucHoi", SaoLuuPhucHoi)
    End Sub

    Private Sub CtrlRibbon1_DangXuatChuongTrinh() Handles CtrlRibbon1.DangXuatChuongTrinh
        RaiseEvent DangXuatChuongTrinh()
    End Sub

    Private Sub ĐóngChươngTrìnhToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub CtrlRibbon1_BamHeThongCauHinhBieuMau() Handles CtrlRibbon1.BamHeThongCauHinhBieuMau
        Dim CauHinhBieuMau As New ctrlCauHinhThongTin
        CtrlTabPanel1.ThemTabpageMoi("Cấu hình biểu mẫu", "CauHinhBieuMau", CauHinhBieuMau)
    End Sub

    '    Private Sub CtrlRibbon1_BamXemLichSuNhanVien() Handles CtrlRibbon1.BamXemLichSuNhanVien
    '        Dim BamXemLichSuNhanVien As New ctrlThongKeLichSuNhanVien
    '        BamXemLichSuNhanVien.PhanQuyen(dt.tbQuyens.First(Function(s) s.TenControl = "btnXemLichSuNhanVien"))
    '        CtrlTabPanel1.ThemTabpageMoi("Xem lịch sử nhân viên", "BamXemLichSuNhanVien", BamXemLichSuNhanVien)
    '    End Sub


#Region "CHỨC NĂNG"
    Private Sub CtrlRibbon1_BamChucNangThuChiTien() Handles CtrlRibbon1.BamChucNangThuChiTien
        Dim ThongKeTienNganHang As New ctrlThongKeTienNganHang
        CtrlTabPanel1.ThemTabpageMoi("Thu chi tiền", "ThongKeTienNganHang", ThongKeTienNganHang)
    End Sub
    Private Sub CtrlRibbon1_ThongKeGiaCongSanPham() Handles CtrlRibbon1.BamChucNangGiaCong
        Dim BamChucNangGiaCong As New ctrlThongKeGiaCongSanPham
        AddHandler BamChucNangGiaCong.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("Gia công sản phẩm", "BamChucNangGiaCong", BamChucNangGiaCong)
    End Sub
    Private Sub CtrlRibbon1_BamChucNangNhuCauMuaHang() Handles CtrlRibbon1.BamChucNangNhuCauMuaHang
        Dim NghiepVuChuanBiHangHoa As New ctrlNghiepVuChuanBiHangHoa
        AddHandler NghiepVuChuanBiHangHoa.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("Nhu cầu mua hàng", "NghiepVuChuanBiHangHoa", NghiepVuChuanBiHangHoa)
    End Sub
    Private Sub CtrlRibbon1_BamChucNangChuaGiaoHang() Handles CtrlRibbon1.BamChucNangChuaGiaoHang
        Dim KhachHangDatHangChuaGiao As New ctrlKhachHangDatHangChuaGiao
        AddHandler KhachHangDatHangChuaGiao.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("Danh sách chưa giao", "KhachHangDatHangChuaGiao", KhachHangDatHangChuaGiao)
    End Sub
    Private Sub CtrlRibbon1_BamChucNangNhapKho() Handles CtrlRibbon1.BamChucNangNhapKho
        Dim ThongKePhieuNhap As New ctrlThongKePhieuNhap
        AddHandler ThongKePhieuNhap.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("T.K PHIẾU NHẬP", "ThongKePhieuNhap", ThongKePhieuNhap)
    End Sub
    Private Sub CtrlRibbon1_BamChucNangKhachHangDatHang() Handles CtrlRibbon1.BamChucNangKhachHangDatHang
        Dim ThongKeKhachHangDatHang As New ctrlThongKeKhachHangDatHang
        ThongKeKhachHangDatHang.isNhapHang = False
        AddHandler ThongKeKhachHangDatHang.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("TK KH ĐẶT HÀNG", "ThongKeKhachHangDatHang", ThongKeKhachHangDatHang)
    End Sub
    Private Sub CtrlRibbon1_BamChucNangDatHangNhaCungCap() Handles CtrlRibbon1.BamChucNangDatHangNhaCungCap
        Dim ThongKeKhachHangDatHang As New ctrlThongKeKhachHangDatHang
        ThongKeKhachHangDatHang.isNhapHang = True
        AddHandler ThongKeKhachHangDatHang.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("TK ĐẶT HÀNG NCC", "ThongKeDatHangNhaCungCap", ThongKeKhachHangDatHang)
    End Sub
    Private Sub CtrlRibbon1_BamChucNangXuatKho() Handles CtrlRibbon1.BamChucNangXuatKho
        Dim ThongKePhieuXuat As New ctrlThongKePhieuXuat
        AddHandler ThongKePhieuXuat.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("T.K PHIẾU XUẤT", "ThongKePhieuXuat", ThongKePhieuXuat)
    End Sub
    Private Sub CtrlRibbon1_BamChucNangBaoGiaDi() Handles CtrlRibbon1.BamChucNangBaoGiaDi
        Dim ThongKeBangBaoGia As New ctrlThongKeBaoGia
        ThongKeBangBaoGia.isNhapHang = False
        AddHandler ThongKeBangBaoGia.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("T.K BÁO GIÁ ĐI", "ThongKeBangBaoGiaDi", ThongKeBangBaoGia)
    End Sub
    Private Sub CtrlRibbon1_BamChucNangBaoGiaDen() Handles CtrlRibbon1.BamChucNangBaoGiaDen
        Dim ThongKeBangBaoGia As New ctrlThongKeBaoGia
        ThongKeBangBaoGia.isNhapHang = True
        AddHandler ThongKeBangBaoGia.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("T.K BÁO GIÁ ĐẾN", "ThongKeBangBaoGiaDen", ThongKeBangBaoGia)
    End Sub
    Private Sub CtrlRibbon1_BamChucNangHoaDon() Handles CtrlRibbon1.BamChucNangHoaDonDauRa
        Dim ThongKeHoaDon As New ctrlThongKeHoaDon
        ThongKeHoaDon.isNhapHang = False
        AddHandler ThongKeHoaDon.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("T.K HÓA ĐƠN ĐẦU RA", "ThongKeHoaDonRa", ThongKeHoaDon)
    End Sub
    Private Sub CtrlRibbon1_BamChucNangHoaDonDauVao() Handles CtrlRibbon1.BamChucNangHoaDonDauVao
        Dim ThongKeHoaDon As New ctrlThongKeHoaDon
        ThongKeHoaDon.isNhapHang = True
        AddHandler ThongKeHoaDon.ThemTabpageMoi, AddressOf CtrlTabPanel1.ThemTabpageMoi
        CtrlTabPanel1.ThemTabpageMoi("T.K HÓA ĐƠN ĐẦU VÀO", "ThongKeHoaDonVao", ThongKeHoaDon)
    End Sub
#End Region

#Region "QUẢN LÝ"
    Private Sub CtrlRibbon1_BamQuanLyTaiKhoan() Handles CtrlRibbon1.BamQuanLyTaiKhoan
        Dim QuanLyTaiKhoan As New ctrlThemSuaXoaNhanVien
        'QuanLyTaiKhoan.PhanQuyen(dt.tbQuyens.First(Function(s) s.TenControl = "btnQuanLyTaiKhoan"))
        CtrlTabPanel1.ThemTabpageMoi("Tài khoản", "QuanLyTaiKhoan", QuanLyTaiKhoan)
    End Sub

    Private Sub CtrlRibbon1_BamQuanLySanPham() Handles CtrlRibbon1.BamQuanLySanPham
        Dim QuanLySanPham As New ctrlThemSuaXoaSanPham
        QuanLySanPham.PhanQuyen(dt.tbQuyens.First(Function(s) s.TenControl = "btnQuanLySanPham"))
        CtrlTabPanel1.ThemTabpageMoi("Sản phẩm", "QuanLySanPham", QuanLySanPham)
    End Sub

    Private Sub CtrlRibbon1_BamQuanLyLoaiPhieuThu() Handles CtrlRibbon1.BamQuanLyLoaiPhieuThu
        Dim BamQuanLyLoaiPhieuThu As New ctrlThemSuaXoaLoaiPhieuThu
        CtrlTabPanel1.ThemTabpageMoi("Loại phiếu thu", "BamQuanLyLoaiPhieuThu", BamQuanLyLoaiPhieuThu)
    End Sub


    Private Sub CtrlRibbon1_BamQuanLyLoaiPhieuChi() Handles CtrlRibbon1.BamQuanLyLoaiPhieuChi
        Dim BamQuanLyLoaiPhieuChi As New ctrlThemSuaXoaLoaiPhieuChi
        CtrlTabPanel1.ThemTabpageMoi("Loại phiếu chi", "BamQuanLyLoaiPhieuChi", BamQuanLyLoaiPhieuChi)
    End Sub
    Private Sub CtrlRibbon1_BamQuanLyKhachHang() Handles CtrlRibbon1.BamQuanLyKhachHang
        Dim QuanLyKhachHang As New ctrlThemSuaXoaKhachHang
        CtrlTabPanel1.ThemTabpageMoi("Khách hàng", "QuanLyKhachHang", QuanLyKhachHang)
    End Sub

    Private Sub CtrlRibbon1_BamQuanLyLoaiPhieuNhap() Handles CtrlRibbon1.BamQuanLyLoaiPhieuNhap
        Dim QuanLyLoaiPhieuNhap As New ctrlThemSuaXoaLoaiPhieuNhap
        CtrlTabPanel1.ThemTabpageMoi("Loại phiếu nhập", "QuanLyLoaiPhieuNhap", QuanLyLoaiPhieuNhap)
    End Sub

    Private Sub CtrlRibbon1_BamQuanLyLoaiPhieuXuat() Handles CtrlRibbon1.BamQuanLyLoaiPhieuXuat
        Dim QuanLyLoaiPhieuXuat As New ctrlThemSuaXoaLoaiPhieuXuat
        CtrlTabPanel1.ThemTabpageMoi("Loại phiếu xuất", "QuanLyLoaiPhieuXuat", QuanLyLoaiPhieuXuat)
    End Sub

    Private Sub CtrlRibbon1_BamQuanLySeri() Handles CtrlRibbon1.BamQuanLySoSeri
        Dim BamQuanLySoSeri As New ctrlTraCuuSoSeri
        CtrlTabPanel1.ThemTabpageMoi("Số serial", "BamQuanLySoSeri", BamQuanLySoSeri)
    End Sub
    Private Sub CtrlRibbon1_BamQuanLyNganHang() Handles CtrlRibbon1.BamQuanLyNganHang
        Dim BamQuanLyNganHang As New ctrlThemSuaXoaNganHang
        CtrlTabPanel1.ThemTabpageMoi("Ngân hàng", "BamQuanLyNganHang", BamQuanLyNganHang)
    End Sub
    Private Sub CtrlRibbon1_BamQuanLyReport() Handles CtrlRibbon1.BamQuanLyReport
        Dim QuanLyReport As New ctrlThemSuaXoaReport
        'QuanLyReport.PhanQuyen(dt.tbQuyens.First(Function(s) s.TenControl = "btnQuanLyReport"))
        CtrlTabPanel1.ThemTabpageMoi("Biểu mẫu", "QuanLyReport", QuanLyReport)
    End Sub






#End Region

    '#Region "THONG KE"
    '    Private Sub CtrlRibbon1_BamThongKeThuChi() Handles CtrlRibbon1.BamThongKeThuChi
    '        Dim ThongKeThuChi As New ctrlThongKeThuChi
    '        CtrlTabPanel1.ThemTabpageMoi("TK Thu chi", "ThongKeThuChi", ThongKeThuChi)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeNhapXuatChiTiet(Loai As Boolean) Handles CtrlRibbon1.BamThongKeNhapXuatChiTiet
    '        If Loai Then
    '            'Nhập
    '            Dim ThongKeChiTietPhieuNhap As New ctrlThongKeChiTietPhieuNhap
    '            CtrlTabPanel1.ThemTabpageMoi("TK chi tiết phiếu nhập", "ThongKeChiTietPhieuNhap", ThongKeChiTietPhieuNhap)
    '        Else
    '            'Xuất
    '            Dim ThongKeChiTietPhieuXuat As New ctrlThongKeChiTietPhieuXuat
    '            CtrlTabPanel1.ThemTabpageMoi("TK chi tiết phiếu xuất", "ThongKeChiTietPhieuXuat", ThongKeChiTietPhieuXuat)
    '        End If
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeNhapXuatTongHop(Loai As Boolean) Handles CtrlRibbon1.BamThongKeNhapXuatTongHop
    '        If Loai Then
    '            '  Nhập
    '            Dim ThongKePhieuNhap As New ctrlThongKePhieuNhap
    '            ThongKePhieuNhap.PhanQuyen(dt.tbQuyens.First(Function(s) s.TenControl = "chkThongKeNhapKho"))
    '            CtrlTabPanel1.ThemTabpageMoi("TK phiếu nhập", "ThongKePhieuNhap", ThongKePhieuNhap)
    '        Else
    '            ' Xuất
    '            Dim ThongKePhieuXuat As New ctrlThongKePhieuXuat
    '            ThongKePhieuXuat.PhanQuyen(dt.tbQuyens.First(Function(s) s.TenControl = "chkThongKeXuatKho"))
    '            CtrlTabPanel1.ThemTabpageMoi("TK phiếu xuất", "ThongKePhieuXuat", ThongKePhieuXuat)
    '        End If
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeHoaDon() Handles CtrlRibbon1.BamThongKeHoaDon
    '        Dim ThongKeHoaDon As New ctrlThongKeHoaDonMoi
    '        ThongKeHoaDon.PhanQuyen(dt.tbQuyens.First(Function(s) s.TenControl = "btnThongKeHoaDon"))
    '        CtrlTabPanel1.ThemTabpageMoi("TK hóa đơn", "ThongKeHoaDon", ThongKeHoaDon)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeChiTietHoaDon() Handles CtrlRibbon1.BamThongKeChiTietHoaDon
    '        Dim ThongKeChiTietHoaDon As New ctrlThongKeChiTietHoaDon
    '        CtrlTabPanel1.ThemTabpageMoi("TK chi tiết hóa đơn", "ThongKeChiTietHoaDon", ThongKeChiTietHoaDon)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeDoiTra() Handles CtrlRibbon1.BamThongKeDoiTra
    '        Dim ThongKePhieuDoiTra As New ctrlThongKePhieuDoiTra
    '        ThongKePhieuDoiTra.PhanQuyen(dt.tbQuyens.First(Function(s) s.TenControl = "btnThongKeDoiTra"))
    '        CtrlTabPanel1.ThemTabpageMoi("TK đổi trả", "ThongKePhieuDoiTra", ThongKePhieuDoiTra)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeCongNoNhaCungCap() Handles CtrlRibbon1.BamThongKeCongNoNhaCungCap
    '        Dim CongNoNhaCungCap As New ctrlThongKeCongNoNhaCungCap
    '        CtrlTabPanel1.ThemTabpageMoi("Công nợ nhà cung cấp", "CongNoNhaCungCap", CongNoNhaCungCap)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamChucNangCongNoKhachHang() Handles CtrlRibbon1.BamChucNangCongNoKhachHang
    '        Dim CongNoKhachHang As New ctrlThongKeCongNoKhachHang
    '        CtrlTabPanel1.ThemTabpageMoi("Công nợ khách hàng", "CongNoKhachHang", CongNoKhachHang)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeDoanhSo() Handles CtrlRibbon1.BamThongKeDoanhSo
    '        Dim DoanhSo As New ctrlViewThongKeDoanhSo
    '        CtrlTabPanel1.ThemTabpageMoi("TK doanh số", "DoanhSo", DoanhSo)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeDoanhThu() Handles CtrlRibbon1.BamThongKeDoanhThu
    '        Dim ThongKeDoanhThu As New ctrlThongKeDoanhThuCuaHang
    '        CtrlTabPanel1.ThemTabpageMoi("TK doanh thu", "ThongKeDoanhThu", ThongKeDoanhThu)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeLoiNhuan() Handles CtrlRibbon1.BamThongKeLoiNhuan
    '        Dim ThongKeLoiNhuan As New ctrlThongKeLoiNhuanCuaHang
    '        CtrlTabPanel1.ThemTabpageMoi("TK lợi nhuận", "ThongKeLoiNhuan", ThongKeLoiNhuan)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeQuyTien() Handles CtrlRibbon1.BamThongKeQuyTien
    '        Dim ThongKeQuyTien As New ctrlThongKeQuyTien
    '        CtrlTabPanel1.ThemTabpageMoi("TK quỹ tiền", "ThongKeQuyTien", ThongKeQuyTien)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeHoaDonGTGT() Handles CtrlRibbon1.BamThongKeHoaDonGTGT
    '        Dim ThongKeHoaDonGTGT As New ctrlThongKeHoaDonGTGT
    '        ThongKeHoaDonGTGT.PhanQuyen(dt.tbQuyens.First(Function(s) s.TenControl = "btnThongKeHoaDonGTGT"))
    '        CtrlTabPanel1.ThemTabpageMoi("TK Hóa đơn GTGT", "ThongKeHoaDonGTGT", ThongKeHoaDonGTGT)
    '    End Sub

    '    Private Sub CtrlRibbon1_BamThongKeChiTietHoaDonGTGT() Handles CtrlRibbon1.BamThongKeChiTietHoaDonGTGT
    '        Dim BamThongKeChiTietHoaDonGTGT As New ctrlThongKeChiTietHoaDonGTGT
    '        CtrlTabPanel1.ThemTabpageMoi("TK chi tiết HĐGTGT", "BamThongKeChiTietHoaDonGTGT", BamThongKeChiTietHoaDonGTGT)
    '    End Sub
    '#End Region

End Class
