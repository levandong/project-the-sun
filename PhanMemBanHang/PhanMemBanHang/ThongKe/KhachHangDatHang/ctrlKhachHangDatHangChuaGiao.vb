Public Class ctrlKhachHangDatHangChuaGiao
    Public Sub PhanQuyen(QuyenCha As tbQuyen)
        For Each qc1 In dt.tbQuyens.Where(Function(s) s.idQuyenCha = QuyenCha.id)
            Dim TrangThai As Boolean
            Dim PhanQuyenCap1 = dt.vwPhanQuyens.SingleOrDefault(Function(s) s.idQuyen = qc1.id And s.idNhanVien = loginNhanVien.id)
            If PhanQuyenCap1 Is Nothing Then
                CapNhatQuyen(loginNhanVien.id)
                PhanQuyenCap1 = dt.vwPhanQuyens.Single(Function(s) s.idQuyen = qc1.id And s.idNhanVien = loginNhanVien.id)
            End If
            TrangThai = PhanQuyenCap1.TrangThai
            Select Case qc1.TenControl
                Case "btnXoaDonDatHang"
                    PhanQuyenLenDoiTuong(btnXoaDonDatHang, qc1.HinhThuc, TrangThai)
                Case "btnSuaDonDatHang"
                    PhanQuyenLenDoiTuong(btnSuaDonDatHang, qc1.HinhThuc, TrangThai)
                Case "btnTaoHoaDon"
                    PhanQuyenLenDoiTuong(btnTaoHoaDon, qc1.HinhThuc, TrangThai)
            End Select
        Next
    End Sub

    Dim TuNgay, DenNgay As DateTime
    Private Sub ctrlThongKeKhachHangDatHangMoi_Load(sender As Object, e As EventArgs) Handles Me.Load
        CapNhat()
    End Sub
    Sub CapNhat()
        bsKhachHangDatHang.DataSource = From itm In dt.vwKhachHangDatHangs
                                        Where itm.isGiaoHangXong = False
                                        Where itm.isNhapHang = chkPhieuDatHang.Checked
    End Sub

    Dim rlsDatHang As List(Of vwKhachHangDatHang)


#Region "KHÁC"
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

#End Region


#Region "IN PHIEU - IN DANH SACH"

    Private Sub XemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemToolStripMenuItem.Click
        If bsKhachHangDatHang.Current Is Nothing Then Exit Sub
        Dim vKhachHangDatHang As vwKhachHangDatHang = bsKhachHangDatHang.Current
        Dim KhachHangDatHang = dt.tbKhachHangDatHangs.First(Function(s) s.id = vKhachHangDatHang.id)
        'Dim frm As New frmInKhachHangDatHang
        'frm.DatHang = KhachHangDatHang
        'frm.Show()
    End Sub

    Private Sub btnXemVaInTuDong_Click(sender As Object, e As EventArgs) Handles btnXemVaInTuDong.Click
        If bsKhachHangDatHang.Current Is Nothing Then Exit Sub
        Dim vKhachHangDatHang As vwKhachHangDatHang = bsKhachHangDatHang.Current
        Dim KhachHangDatHang = dt.tbKhachHangDatHangs.First(Function(s) s.id = vKhachHangDatHang.id)
        'mdlGlobals.InKhachHangDatHang(KhachHangDatHang)
    End Sub

    Private Sub btnInDanhSach_Click(sender As Object, e As EventArgs) Handles btnInDanhSach.Click
        If bsKhachHangDatHang.Count > 0 Then
            Dim frm As New frmInDanhSach
            frm.Text = "DANH SÁCH ĐƠN ĐẶT HÀNG"
            frm.rptName = ".\Report\KhachHangDatHang\rptDanhSachKhachHangDatHang.rdlc"
            frm.dsName = "dsDanhSachKhachHangDatHang"
            frm._bs = bsKhachHangDatHang
            If TuNgay.Date = DenNgay.Date Then
                frm.ThoiGianTimKiem = "Ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay)
            Else
                frm.ThoiGianTimKiem = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
            End If
            frm.timkiemtheo = ""
            frm.Show()
        End If
    End Sub

    Private Sub DanhSáchMặtHàngToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If bsKhachHangDatHang.Count > 0 Then
            Dim rlsidPhieu = From itm In rlsDatHang
                             Select itm.id
            Dim rlsSanPham = From itm In dt.vwChiTietKhachHangDatHangs
                             Where rlsidPhieu.Any(Function(s) s = itm.idKhachHangDatHang)

            Dim frm As New frmInDanhSach
            frm.Text = "DANH SÁCH MẶT HÀNG"
            frm.rptName = ".\Report\KhachHangDatHang\rptDanhSachChiTietKhachHangDatHang.rdlc"
            frm.dsName = "dsDanhSachChiTietKhachHangDatHang"
            frm._bs.DataSource = rlsSanPham
            frm.timkiemtheo = ""
            If TuNgay.Date = DenNgay.Date Then
                frm.ThoiGianTimKiem = "Ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay)
            Else
                frm.ThoiGianTimKiem = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
            End If
            frm.Show()
        End If
    End Sub
    Event ThemTabpageMoi(TenHienThi As String, Ten As String, control As Control)


    Private Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        If bsKhachHangDatHang.Current Is Nothing Then Exit Sub
        Dim ctrlKhachHangDatHang As New ctrlSuaKhachHangDatHang
        ctrlKhachHangDatHang.btnDongY.Enabled = False
        Dim KhachHangDatHang As vwKhachHangDatHang = bsKhachHangDatHang.Current
        ctrlKhachHangDatHang.XemPhieu(dt.tbKhachHangDatHangs.First(Function(s) s.id = KhachHangDatHang.id))
        ctrlKhachHangDatHang.DonDatHang = dt.tbKhachHangDatHangs.First(Function(s) s.id = KhachHangDatHang.id)
        If KhachHangDatHang.isNhapHang Then
            ctrlKhachHangDatHang.TenKhachHangDatHang = "Đơn đặt hàng"
        Else
            ctrlKhachHangDatHang.TenKhachHangDatHang = "Phiếu đặt hàng"
        End If
        RaiseEvent ThemTabpageMoi("DH/" + bsKhachHangDatHang.Current.MaDatHang.ToString(), bsKhachHangDatHang.Current.MaDatHang.ToString(), ctrlKhachHangDatHang)
    End Sub

    Private Sub btnDonDatHang_CheckedChanged(sender As Object, e As EventArgs) Handles btnDonDatHang.CheckedChanged
        chkPhieuDatHang.Checked = Not btnDonDatHang.Checked
        CapNhat()
    End Sub
    Private Sub chkPhieuDatHang_CheckedChanged(sender As Object, e As EventArgs) Handles chkPhieuDatHang.CheckedChanged
        btnDonDatHang.Checked = Not chkPhieuDatHang.Checked
        CapNhat()
    End Sub
    Public Sub F3_btnThemDonDatHang_Click(sender As Object, e As EventArgs)
        Dim DonDatHang As New ctrlKhachHangDatHang
        DonDatHang.lblTenKhachHangDatHang.Text = "Phiếu Đặt Hàng"
        RaiseEvent ThemTabpageMoi("Phiếu Đặt Hàng", "DH" + Now.ToString("dd/MM/yy HH:ss"), DonDatHang)
    End Sub


#End Region
End Class
