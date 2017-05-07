Public Class ctrlThongKeKhachHangDatHang
    Private _isNhapHang As Boolean
    Property isNhapHang As Boolean
        Get
            Return _isNhapHang
        End Get
        Set(value As Boolean)
            _isNhapHang = value
            If isNhapHang Then
                lblTenHienThi.Text = "ĐẶT HÀNG NCC"
            Else
                lblTenHienThi.Text = "KHÁCH HÀNG ĐẶT HÀNG"
            End If
        End Set
    End Property
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
                    PhanQuyenLenDoiTuong(TẠOHÓAĐƠNToolStripMenuItem, qc1.HinhThuc, TrangThai)
            End Select
        Next
    End Sub

    Dim TuNgay, DenNgay As DateTime
    Private Sub ctrlThongKeKhachHangDatHangMoi_Load(sender As Object, e As EventArgs) Handles Me.Load
        'cmbTrangThai.SelectedIndex = 0
        btnCapNhatKhachHang_Click(Nothing, Nothing)
        btnCapNhatNhanVien_Click(Nothing, Nothing)
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 1).AddDays(-30)
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 0)
        btnTimKiem_Click(Nothing, Nothing)
    End Sub


    Dim rlsDatHang As List(Of vwKhachHangDatHang)
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim idKH As Integer = 0
        Dim idNV As Integer = 0
        TuNgay = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        DenNgay = CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value

        If chkTheoNhanVien.Checked Then
            If cmbNhanVien.SelectedItem Is Nothing Then
                lblThongBao.Text = "[Chưa chọn nhân viên]"
                lblThongBao.Visible = True
                Exit Sub
            Else
                lblThongBao.Visible = False
                idNV = cmbNhanVien.SelectedItem.id
            End If
        End If

        If chkTheoKhachHang.Checked Then
            If cmbKhachHang.SelectedItem Is Nothing Then
                lblThongBao.Text = "[Chưa chọn khách hàng]"
                lblThongBao.Visible = True
                Exit Sub
            Else
                lblThongBao.Visible = False
                idKH = cmbKhachHang.SelectedItem.id
            End If
        End If


        rlsDatHang = (From hd In dt.vwKhachHangDatHangs
                      Where (rdoNgayDuKienGiao.Checked And (hd.NgayDuKienGiaoHang >= TuNgay And hd.NgayDuKienGiaoHang <= DenNgay)) Or (rdoNgayLapPhieu.Checked And (hd.NgayLap >= TuNgay And hd.NgayLap <= DenNgay))
                      Where (Not chkTheoKhachHang.Checked) Or (hd.idKhachHang = idKH)
                      Where (Not chkTheoNhanVien.Checked) Or (hd.idNhanVien = idNV)
                      Where hd.isNhapHang = isNhapHang
                      Select hd Order By hd.NgayLap Descending).ToList

        bsKhachHangDatHang.DataSource = rlsDatHang
        If bsKhachHangDatHang.Count > 0 Then
            lblThongBao.Visible = False
            lblCong.Text = rlsDatHang.Sum(Function(s) s.CongTien).ToString("N0") + "đ"
            lblChietKhau.Text = rlsDatHang.Sum(Function(s) s.TongTienChietKhau).ToString("N0") + "đ"
            lblVAT.Text = rlsDatHang.Sum(Function(s) s.TongTienVAT).ToString("N0") + "đ"
            lblTongTien.Text = rlsDatHang.Sum(Function(s) s.TongTien).ToString("N0") + "đ"
            lblSoLuong.Text = bsKhachHangDatHang.Count.ToString + " phiếu"
        Else
            lblThongBao.Text = "[Không tìm thấy dữ liệu phù hợp]"
            lblThongBao.Visible = True
            lblCong.Text = "0đ"
            lblChietKhau.Text = "0đ"
            lblVAT.Text = "0đ"
            lblTongTien.Text = "0đ"
            lblSoLuong.Text = "0 phiếu"
        End If
        For i As Integer = 0 To dgvMain.RowCount - 1
            If dgvMain.Rows(i).Cells("isGiaoHangXong").Value = 1 Then
                dgvMain.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue
            End If
        Next
    End Sub

#Region "CẬP NHẬT - TÌM KIẾM KHÁCH HÀNG"
    Private Sub chkTheoKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoKhachHang.CheckedChanged
        cmbKhachHang.Enabled = chkTheoKhachHang.Checked
    End Sub

    Private Sub btnCapNhatKhachHang_Click(sender As Object, e As EventArgs) Handles btnCapNhatKhachHang.Click
        Dim rls = From nv In dt.tbKhachHangs
                  Select nv
        cmbKhachHang.DataSource = rls
    End Sub


    Public Sub btnTimKiemKhachHang_Click(sender As Object, e As EventArgs) Handles btnTimKiemKhachHang.Click
        Dim frm As New frmTimKiemKhachHang
        AddHandler frm.ChonKhachHangThanhCong, AddressOf ChonKhachHang
        frm.ShowDialog()
    End Sub

    Private Sub ChonKhachHang(khachHang As tbKhachHang)
        Try
            cmbKhachHang.SelectedItem = khachHang
        Catch ex As Exception
            btnCapNhatKhachHang_Click(Nothing, Nothing)
            cmbKhachHang.SelectedItem = khachHang
        End Try
    End Sub
#End Region

#Region "KHÁC"
    Private Sub dgvMain_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMain.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Dim rowSelected As Integer = e.RowIndex
            If (e.RowIndex <> -1) Then
                Me.dgvMain.ClearSelection()
                Me.dgvMain.Rows(rowSelected).Selected = True
                bsKhachHangDatHang.Position = e.RowIndex
            End If
        End If
    End Sub
    Public Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        cmbNhanVien.DataSource = From nv In dt.tbNhanViens
                                 Select nv
    End Sub

    Private Sub chkTheoNhanVien_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhanVien.CheckedChanged
        cmbNhanVien.Enabled = chkTheoNhanVien.Checked
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

#End Region

#Region "TẠO HÓA ĐƠN BÁN HÀNG - SỬA - XÓA PHIẾU"
    Private Sub btnTaoHoaDon_Click(sender As Object, e As EventArgs)
        If bsKhachHangDatHang.Current Is Nothing Then Exit Sub
        Dim vKHDH As vwKhachHangDatHang = bsKhachHangDatHang.Current
        Dim DonDatHang As tbKhachHangDatHang = dt.tbKhachHangDatHangs.First(Function(s) s.id = vKHDH.id)
        dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, DonDatHang)
        'If DonDatHang.DaLapHoaDon Then
        '    If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Đơn hàng số " + DonDatHang.MaDatHang + " đã được tạo phiếu." + vbNewLine + "Bạn muốn tiếp tục xuất hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
        '        Exit Sub
        '    End If
        'End If
        If DonDatHang.isNhapHang Then
            If dt.SanPhamChuaNhapKho(vKHDH.id).Where(Function(s) s.SoLuongConLai > 0).Count > 0 Then
                Dim frm As New frmPhieuNhap
                frm.DonDatHang = DonDatHang
                If frm.ShowDialog = DialogResult.OK Then
                    btnTimKiem_Click(Nothing, Nothing)
                End If
            Else
                ThongBao("Đã nhập đủ (hoặc dư) phiếu này.")
                Exit Sub
            End If

        Else
            If dt.SanPhamChuaXuatKho(vKHDH.id).Where(Function(s) s.SoLuongConLai > 0).Count > 0 Then
                Dim frm As New frmPhieuXuat
                frm.ChuyenDatHangThanhPhieuXuat(DonDatHang)
                frm.ShowDialog()
            Else
                ThongBao("Đã xuất đủ (hoặc dư) phiếu này.")
                Exit Sub
            End If
        End If


    End Sub

    Private Sub btnXoaKhachHangDatHang_Click(sender As Object, e As EventArgs) Handles btnXoaDonDatHang.Click
        If bsKhachHangDatHang.Current Is Nothing Then Exit Sub
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa đơn đặt hàng " + bsKhachHangDatHang.Current.MaDatHang.ToString + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then

            Dim vKhachHangDatHang As vwKhachHangDatHang = bsKhachHangDatHang.Current
            Dim KhachHangDatHang = dt.tbKhachHangDatHangs.First(Function(s) s.id = vKhachHangDatHang.id)

            dt.tbKhachHangDatHangs.DeleteOnSubmit(KhachHangDatHang)

            'Xóa idKhachHangDatHang trong tbHoaDon
            Dim HoaDon As tbHoaDon = dt.tbHoaDons.FirstOrDefault(Function(s) s.idKhachHangDatHang = KhachHangDatHang.id)
            If HoaDon IsNot Nothing Then
                HoaDon.tbKhachHangDatHang = Nothing
            End If

            Try
                dt.SubmitChanges()
                btnTimKiem_Click(Nothing, Nothing)
            Catch ex As Exception
                undoChange()
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không xóa được phiếu đặt hàng!" + vbNewLine + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSuaDonDatHang_Click(sender As Object, e As EventArgs) Handles btnSuaDonDatHang.Click
        'If bsKhachHangDatHang.Current Is Nothing Then Exit Sub
        'Dim frm As New frmSuaKhachHangDatHang
        'Dim vwDH As vwKhachHangDatHang = bsKhachHangDatHang.Current
        'frm.KhachHangDatHang = dt.tbKhachHangDatHangs.First(Function(s) s.id = vwDH.id)
        'If frm.ShowDialog() = DialogResult.OK Then
        '    btnTimKiem_Click(Nothing, Nothing)
        'End If
    End Sub

    Private Sub TẠOHÓAĐƠNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TẠOHÓAĐƠNToolStripMenuItem.Click, btnTaoHoaDon.Click
        btnTaoHoaDon_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "IN PHIEU - IN DANH SACH"



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

    Private Sub DanhSáchMặtHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchMặtHàngToolStripMenuItem.Click
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

    Private Sub XóaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XóaToolStripMenuItem.Click
        btnXoaKhachHangDatHang_Click(Nothing, Nothing)
    End Sub

    Private Sub btnInKhachHangDatHang_Click(sender As Object, e As EventArgs) Handles btnInKhachHangDatHang.Click
        If bsKhachHangDatHang.Current Is Nothing Then Exit Sub
        Dim vKhachHangDatHang As vwKhachHangDatHang = bsKhachHangDatHang.Current
        If vKhachHangDatHang.isNhapHang Then
            TaoPhieuDatHangExcel(Application.StartupPath + "\UyNhiemChi\PhieuDatHang.xlsx", vKhachHangDatHang)
        Else
            TaoDonDatHangExcel(Application.StartupPath + "\UyNhiemChi\DonDatHang.xlsx", vKhachHangDatHang)
        End If
    End Sub

    'Private Sub InPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InPhiếuToolStripMenuItem.Click
    '    If bsKhachHangDatHang.Current Is Nothing Then Exit Sub
    '    Dim vKhachHangDatHang As vwKhachHangDatHang = bsKhachHangDatHang.Current
    '    Dim KhachHangDatHang = dt.tbKhachHangDatHangs.First(Function(s) s.id = vKhachHangDatHang.id)
    '    Dim frm As New frmInKhachHangDatHang
    '    frm.DatHang = KhachHangDatHang
    '    frm.Show()
    'End Sub

    Public Sub F3_btnThemDonDatHang_Click(sender As Object, e As EventArgs) Handles btnThemDonDatHang.Click
        Dim DonDatHang As New ctrlKhachHangDatHang
        DonDatHang.lblTenKhachHangDatHang.Text = "Đơn Đặt Hàng"
        RaiseEvent ThemTabpageMoi("Đơn Đặt Hàng", "DH" + Now.ToString("dd/MM/yy HH:ss"), DonDatHang)
    End Sub


#End Region
End Class
