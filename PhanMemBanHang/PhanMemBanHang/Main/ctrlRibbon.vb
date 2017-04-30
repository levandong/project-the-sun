Public Class ctrlRibbon

    Private Sub chkSetHeader_CheckedButtonChanged(sender As Object, e As EventArgs) Handles chkSetHeader.CheckedButtonChanged
        If chkSetHeader.CheckedButton Is chkQuanLy Then
            pnlQuanLy.BringToFront()
        ElseIf chkSetHeader.CheckedButton Is chkChucNang Then
            pnlChucNang.BringToFront()
        ElseIf chkSetHeader.CheckedButton Is chkHeThong Then
            pnlHeThong.BringToFront()
        ElseIf chkSetHeader.CheckedButton Is chkThongKe Then
            pnlThongKe.BringToFront()
        ElseIf chkSetHeader.CheckedButton Is chkTroGiup Then
            pnlHoTro.BringToFront()
        End If
        If KryptonGroup1.Visible = False Then
            btnHideMenu_Click(Nothing, Nothing)
        End If
    End Sub


    Event ThuNhoRibbon(isThuNho As Boolean)
    Public Sub btnHideMenu_Click(sender As Object, e As EventArgs) Handles btnHideMenu.Click
        KryptonGroup1.Visible = Not KryptonGroup1.Visible
        If KryptonGroup1.Visible Then
            btnHideMenu.Values.Image = My.Resources.iconup
            RaiseEvent ThuNhoRibbon(False)
        Else
            btnHideMenu.Values.Image = My.Resources.icondown
            RaiseEvent ThuNhoRibbon(True)
        End If
    End Sub


#Region "HỆ THỐNG"

    Event DangXuatChuongTrinh()
    Private Sub btnDangXuat_Click(sender As Object, e As EventArgs) Handles btnDangXuat.Click
        RaiseEvent DangXuatChuongTrinh()
    End Sub

    Private Sub btnThayDoiMatKhau_Click(sender As Object, e As EventArgs) Handles btnThayDoiMatKhau.Click
        Dim frm As New frmThayDoiMatKhau
        frm.ShowDialog()
    End Sub

    Event BamHeThongPhanQuyen()
    Private Sub btnPhanQuyen_Click(sender As Object, e As EventArgs) Handles btnPhanQuyen.Click
        RaiseEvent BamHeThongPhanQuyen()
        btnHideMenu_Click(Nothing, Nothing)
    End Sub

    Event BamHeThongSaoLuuPhucHoiDuLieu()
    Private Sub btnSaoLuuPhucHoi_Click(sender As Object, e As EventArgs) Handles btnSaoLuuPhucHoi.Click
        RaiseEvent BamHeThongSaoLuuPhucHoiDuLieu()
    End Sub

    Event BamHeThongCauHinhBieuMau()
    Private Sub btnCauHinhBieuMau_Click(sender As Object, e As EventArgs) Handles btnCauHinhBieuMau.Click
        RaiseEvent BamHeThongCauHinhBieuMau()
    End Sub

    Event BamXemLichSuNhanVien()
    Private Sub btnXemLichSuNhanVien_Click(sender As Object, e As EventArgs) Handles btnXemLichSuNhanVien.Click
        RaiseEvent BamXemLichSuNhanVien()
    End Sub

    Event BamCauHinhHeThong()
    Private Sub btnCauHinhHeThong_Click(sender As Object, e As EventArgs) Handles btnCauHinhHeThong.Click
        RaiseEvent BamCauHinhHeThong()
    End Sub
#End Region

#Region "CHỨC NĂNG"
    Event BamChucNangChuaGiaoHang()
    Private Sub btnBamChucNangChuaGiaoHang_Click(sender As Object, e As EventArgs) Handles btnBamChucNangChuaGiaoHang.Click
        RaiseEvent BamChucNangChuaGiaoHang()
    End Sub
    Event BamChucNangBaoGiaDi()
    Event BamChucNangGiaCong()
    Private Sub btnGiaCongSanPham_Click(sender As Object, e As EventArgs) Handles btnGiaCongSanPham.Click
        RaiseEvent BamChucNangGiaCong()
    End Sub
    Private Sub btnChucNangBaoGiaDi_Click(sender As Object, e As EventArgs) Handles btnChucNangBaoGiaDi.Click
        RaiseEvent BamChucNangBaoGiaDi()
    End Sub
    Event BamChucNangBaoGiaDen()
    Private Sub btnChucNangBaoGiaDen_Click(sender As Object, e As EventArgs) Handles btnBamChucNangBaoGiaDen.Click
        RaiseEvent BamChucNangBaoGiaDen()
    End Sub
    Event BamChucNangHoaDonDauRa()
    Private Sub BamChucNangHoaDonDauRa_Click(sender As Object, e As EventArgs) Handles btnBamChucNangHoaDonDauRa.Click
        RaiseEvent BamChucNangHoaDonDauRa()
    End Sub
    Event BamChucNangHoaDonDauVao()
    Private Sub btnBamChucNangHoaDonDauVao_Click(sender As Object, e As EventArgs) Handles btnBamChucNangHoaDonDauVao.Click
        RaiseEvent BamChucNangHoaDonDauVao()
    End Sub
    Event BamChucNangKhachHangDatHang()
    Private Sub btnChucNangKhachHangDatHang_Click(sender As Object, e As EventArgs) Handles btnChucNangKhachHangDatHang.Click
        RaiseEvent BamChucNangKhachHangDatHang()
    End Sub

    Event BamChucNangDatHangNhaCungCap()
    Private Sub btnBamChucNangDatHangNhaCungCap_Click(sender As Object, e As EventArgs) Handles btnBamChucNangDatHangNhaCungCap.Click
        RaiseEvent BamChucNangDatHangNhaCungCap()
    End Sub

    Event BamChucNangNhapKho()
    Private Sub btnChucNangNhapKho_Click(sender As Object, e As EventArgs) Handles btnBamChucNangNhapKho.Click
        RaiseEvent BamChucNangNhapKho()
    End Sub

    Event BamChucNangXuatKho()
    Private Sub btnChucNangXuatKho_Click(sender As Object, e As EventArgs) Handles btnBamChucNangXuatKho.Click
        RaiseEvent BamChucNangXuatKho()
    End Sub

    Event BamChucNangThuChiTien()
    Private Sub btnChucNangThuChiTien_Click(sender As Object, e As EventArgs) Handles btnChucNangThuChiTien.Click
        RaiseEvent BamChucNangThuChiTien()
    End Sub


#End Region

#Region "QUẢN LÝ"

    Event BamQuanLyTaiKhoan()
    Private Sub btnQuanLyTaiKhoan_Click(sender As Object, e As EventArgs) Handles btnQuanLyTaiKhoan.Click
        RaiseEvent BamQuanLyTaiKhoan()
    End Sub

    Event BamQuanLyKhachHang()
    Private Sub btnQuanLyKhachHang_Click(sender As Object, e As EventArgs) Handles btnQuanLyKhachHang.Click
        RaiseEvent BamQuanLyKhachHang()
    End Sub

    Event BamQuanLyNhaCungCap()
    Private Sub btnQuanLyNhaCungCap_Click(sender As Object, e As EventArgs)
        RaiseEvent BamQuanLyNhaCungCap()
    End Sub

    Event BamQuanLyTheThanhVien()
    Private Sub btnQuanLyTheThanhVien_Click(sender As Object, e As EventArgs)
        RaiseEvent BamQuanLyTheThanhVien()
    End Sub

    Event BamQuanLySanPham()
    Private Sub btnQuanLySanPham_Click(sender As Object, e As EventArgs) Handles btnQuanLySanPham.Click
        RaiseEvent BamQuanLySanPham()
    End Sub

    Event BamQuanLyLoaiSanPham()
    Private Sub btnQuanLyLoaiSanPham_Click(sender As Object, e As EventArgs)
        RaiseEvent BamQuanLyLoaiSanPham()
    End Sub

    Event BamQuanLyLoaiPhieuThu()
    Private Sub btnQuanLyLoaiPhieuThu_Click(sender As Object, e As EventArgs) Handles btnQuanLyLoaiPhieuThu.Click
        RaiseEvent BamQuanLyLoaiPhieuThu()
    End Sub

    Event BamQuanLyNganHang()
    Private Sub BamQuanLyNganHang_Click(sender As Object, e As EventArgs) Handles btnQuanLyNganHang.Click
        RaiseEvent BamQuanLyNganHang()
    End Sub

    Event BamQuanLyLoaiPhieuChi()
    Private Sub btnQuanLyChuongTrinhKhuyenMai_Click(sender As Object, e As EventArgs) Handles btnQuanLyLoaiPhieuChi.Click
        RaiseEvent BamQuanLyLoaiPhieuChi()
    End Sub

    Event BamQuanLyReport()
    Private Sub btnQuanLyReport_Click(sender As Object, e As EventArgs) Handles btnQuanLyReport.Click
        RaiseEvent BamQuanLyReport()
    End Sub

    Event BamQuanLyLoaiPhieuNhap()
    Private Sub btnQuanLyLoaiPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnQuanLyLoaiPhieuNhap.Click
        RaiseEvent BamQuanLyLoaiPhieuNhap()
    End Sub
    Event BamQuanLySoSeri()
    Private Sub btnQuanLySoSeri_Click(sender As Object, e As EventArgs) Handles btnQuanLySoSeri.Click
        RaiseEvent BamQuanLySoSeri()
    End Sub
    Event BamQuanLyLoaiPhieuXuat()
    Private Sub btnQuanLyLoaiPhieuXuat_Click(sender As Object, e As EventArgs) Handles btnQuanLyLoaiPhieuXuat.Click
        RaiseEvent BamQuanLyLoaiPhieuXuat()
    End Sub
    Event BamQuanLyPhanQuyen()
    Private Sub btnQuanLyPhanQuyen_Click(sender As Object, e As EventArgs) Handles btnQuanLyPhanQuyen.Click
        RaiseEvent BamQuanLyPhanQuyen()
    End Sub
    Event BamChucNangNhuCauMuaHang()
    Private Sub btnNhuCauMuaHang_Click(sender As Object, e As EventArgs) Handles btnNhuCauMuaHang.Click
        RaiseEvent BamChucNangNhuCauMuaHang()
    End Sub
#End Region

#Region "THỐNG KÊ"
    Event BamThongKeThuChi()
    Private Sub btnThongKeThuChi_Click(sender As Object, e As EventArgs) Handles btnThongKeThuChi.Click
        RaiseEvent BamThongKeThuChi()
    End Sub

    Event BamThongKeNhapXuatTongHop(Loai As Boolean) ' True la nhap, False la xuat
    Private Sub btnThongKePhieuNhapXuatKho_Click(sender As Object, e As EventArgs) Handles btnThongKePhieuNhapXuatKho.Click
        RaiseEvent BamThongKeNhapXuatTongHop(chkThongKeNhapKho.Checked)
    End Sub

    Event BamThongKeNhapXuatChiTiet(Loai As Boolean) ' True la nhap, False la xuat
    Private Sub btnThongKeChiTietKho_Click(sender As Object, e As EventArgs) Handles btnThongKeChiTietKho.Click
        RaiseEvent BamThongKeNhapXuatChiTiet(chkThongKeNhapKho.Checked)
    End Sub

    Event BamThongKeDoanhSo()
    Private Sub btnThongKeDoanhSo_Click(sender As Object, e As EventArgs) Handles btnThongKeDoanhSo.Click
        RaiseEvent BamThongKeDoanhSo()
    End Sub

    Event BamChucNangCongNoKhachHang()
    Private Sub btnThongKeCongNoKhachHang_Click(sender As Object, e As EventArgs) Handles btnThongKeCongNoKhachHang.Click
        RaiseEvent BamChucNangCongNoKhachHang()
    End Sub

    Event BamThongKeCongNoNhaCungCap()
    Private Sub btnThongKeCongNoNhaCungCap_Click(sender As Object, e As EventArgs) Handles btnThongKeCongNoNhaCungCap.Click
        RaiseEvent BamThongKeCongNoNhaCungCap()
    End Sub

    Event BamThongKeHoaDon()
    Private Sub btnThongKeHoaDon_Click(sender As Object, e As EventArgs) Handles btnThongKeHoaDon.Click
        RaiseEvent BamThongKeHoaDon()
    End Sub

    Event BamThongKeChiTietHoaDon()
    Private Sub btnThongKeChiTietHoaDon_Click(sender As Object, e As EventArgs) Handles btnThongKeChiTietHoaDon.Click
        RaiseEvent BamThongKeChiTietHoaDon()
    End Sub

    Event BamThongKeDoiTra()
    Private Sub btnThongKeDoiTra_Click(sender As Object, e As EventArgs) Handles btnThongKeDoiTra.Click
        RaiseEvent BamThongKeDoiTra()
    End Sub

    Event BamThongKeDoanhThu()
    Private Sub btnThongKeDoanhThu_Click(sender As Object, e As EventArgs) Handles btnThongKeDoanhThu.Click
        RaiseEvent BamThongKeDoanhThu()
    End Sub

    Event BamThongKeLoiNhuan()
    Private Sub btnThongKeLoiNhuan_Click(sender As Object, e As EventArgs) Handles btnThongKeLoiNhuan.Click
        RaiseEvent BamThongKeLoiNhuan()
    End Sub

    Event BamThongKeQuyTien()
    Private Sub btnThongKeQuyTien_Click(sender As Object, e As EventArgs) Handles btnThongKeQuyTien.Click
        RaiseEvent BamThongKeQuyTien()
    End Sub

    Event BamThongKeHoaDonGTGT()
    Private Sub btnThongKeHoaDonGTGT_Click(sender As Object, e As EventArgs) 
        RaiseEvent BamThongKeHoaDonGTGT()
    End Sub


    Event BamThongKeChiTietHoaDonGTGT()
    Private Sub btnThongKeChiTietHoaDonGTGT_Click(sender As Object, e As EventArgs) 
        RaiseEvent BamThongKeChiTietHoaDonGTGT()
    End Sub
#End Region

#Region "TRỢ GIÚP"

    Private Sub btnMoFileHuongDan_Click(sender As Object, e As EventArgs) Handles btnMoFileHuongDan.Click
        Try
            Process.Start(".\HuongDanSuDung\HDSD_PhanMemBanHang.pdf")
        Catch ex As Exception
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không mở được file hướng dẫn sử dụng. Vui lòng kiểm tra thư mục 'HuongDanSuDung' trong thư mục phần mềm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnLienHe_Click(sender As Object, e As EventArgs) Handles btnLienHe.Click
    End Sub

    Private Sub btnTroGiupThongTinPhanMem_Click(sender As Object, e As EventArgs) Handles btnTroGiupThongTinPhanMem.Click
        frmThongTinPhanMem.Show()
        frmThongTinPhanMem.BringToFront()
    End Sub
#End Region


    Private Sub pnlChucNang_VisibleChanged(sender As Object, e As EventArgs) Handles pnlChucNang.VisibleChanged
        chkChucNang.Visible = pnlChucNang.Visible
    End Sub

    Private Sub pnlThongKe_VisibleChanged(sender As Object, e As EventArgs) Handles pnlThongKe.VisibleChanged
        chkThongKe.Visible = pnlThongKe.Visible
    End Sub

    Private Sub pnlQuanLy_VisibleChanged(sender As Object, e As EventArgs) Handles pnlQuanLy.VisibleChanged
        chkQuanLy.Visible = pnlQuanLy.Visible
    End Sub

    Private Sub pnlHoTro_VisibleChanged(sender As Object, e As EventArgs) Handles pnlHoTro.VisibleChanged
        chkTroGiup.Visible = pnlHoTro.Visible
    End Sub

    Private Sub pnlHeThong_VisibleChanged(sender As Object, e As EventArgs) Handles pnlHeThong.VisibleChanged
        chkHeThong.Visible = pnlHeThong.Visible
    End Sub


End Class
