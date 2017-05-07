Public Class ctrlThongKeHoaDon
    Dim _isNhapHang As Boolean = False
    Property isNhapHang As Boolean
        Get
            Return _isNhapHang
        End Get
        Set(value As Boolean)
            _isNhapHang = value
            If _isNhapHang Then
                lblTieuDe.Text = "HÓA ĐƠN ĐẦU VÀO"
                btnThemHoaDonDauRa.Visible = False
            Else
                lblTieuDe.Text = "HÓA ĐƠN ĐẦU RA"
                btnThemHoaDonDauVao.Visible = False
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
                Case "btnXoaHoaDon"
                    PhanQuyenLenDoiTuong(btnXoaHoaDon, qc1.HinhThuc, TrangThai)
                Case "btnSuaHoaDon"
                    PhanQuyenLenDoiTuong(btnSuaHoaDon, qc1.HinhThuc, TrangThai)
            End Select
        Next
    End Sub

    Event ThemTabpageMoi(TenHienThi As String, Ten As String, control As Control)
    Dim TuNgay, DenNgay As DateTime

    Private Sub ctrlThongKeHoaDonMoi_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnCapNhatKhachHang_Click(Nothing, Nothing)
        btnCapNhatNhanVien_Click(Nothing, Nothing)
        cmbHinhThucThanhToan.DataSource = From itm In dt.tbHinhThucThanhToans
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = New Date(Now.Date.AddDays(-30).Year, Now.Date.AddDays(-30).Month, Now.Date.AddDays(-30).Day)
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New Date(Now.Date.Year, Now.Date.Month, Now.Day, 23, 59, 59)
        btnTimKiem_Click(Nothing, Nothing)
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim idKH As Integer = 0
        Dim idNV As Integer = 0
        Dim idNVBH As Integer = 0
        TuNgay = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        DenNgay = CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value

        If chkTheoNhanVien.Checked Then
            If cmbNhanVien.SelectedItem Is Nothing Then
                lblThongBao.Text = "[Chưa chọn nhân viên lập]"
                lblThongBao.Visible = True
                Exit Sub
            Else
                lblThongBao.Visible = False
                idNV = cmbNhanVien.SelectedItem.id
            End If
        End If

        'If chkTheoNhanVienBanHang.Checked Then
        '    If cmbNhanVienBanHang.SelectedItem Is Nothing Then
        '        lblThongBao.Text = "[Chưa chọn nhân viên bán hàng]"
        '        lblThongBao.Visible = True
        '        Exit Sub
        '    Else
        '        lblThongBao.Visible = False
        '        idNVBH = cmbNhanVienBanHang.SelectedItem.id
        '    End If
        'End If

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
        Dim LoaiHD As Integer = 1
        If isNhapHang Then
            LoaiHD = 0
        Else
            LoaiHD = 1
        End If
        Dim lstHoaDon = From hd In dt.vwHoaDons
                        Where hd.NgayLap >= TuNgay And hd.NgayLap <= DenNgay
                        Where (Not chkTheoKhachHang.Checked) Or (hd.idKhachHang = idKH)
                        Where (Not chkTheoNhanVien.Checked) Or (hd.idNhanVien = idNV)
                        Where hd.LoaiHD = LoaiHD
                        Order By hd.NgayLap
        Dim lst
        If (chkTheoHinhThucThanhToan.Checked) Then
            lst = From itm In lstHoaDon.ToList
                  Where itm.HinhThucThanhToan = cmbHinhThucThanhToan.Text.Trim
            bsHoaDon.DataSource = lst
        Else
            bsHoaDon.DataSource = lstHoaDon
        End If
        'Where (Not chkTheoHinhThucThanhToan.Checked) Or (hd.idHinhThucThanhToan cmbHinhThucThanhToan.Text.Trim)

        If bsHoaDon.Count > 0 Then
            lblThongBao.Visible = False

            'lblCong.Text = lstHoaDon.Sum(Function(s) s.CongTien).ToString("N0") + "đ"
            'lblChietKhau.Text = lstHoaDon.Sum(Function(s) s.TongTienChietKhau).ToString("N0") + "đ"
            'lblVAT.Text = lstHoaDon.Sum(Function(s) s.TongTienVAT).ToString("N0") + "đ"
            'lblTongTien.Text = lstHoaDon.Sum(Function(s) s.TongTien).ToString("N0") + "đ"
            lblSoLuong.Text = bsHoaDon.Count.ToString + " hóa đơn"
            lblThongBao.Visible = False
            Dim CongTien As Decimal = 0
            Dim TongTienCK As Decimal = 0
            Dim TongTienVAT As Decimal = 0
            For Each itm In bsHoaDon.List
                CongTien += itm.CongTien
                TongTienCK += itm.TongTienChietKhau
                TongTienVAT += itm.TongTienVAT
            Next
            lblCong.Text = CongTien.ToString("N0") + "đ"
            lblChietKhau.Text = TongTienCK.ToString("N0") + "đ"
            lblVAT.Text = TongTienVAT.ToString("N0") + "đ"
        Else
            lblThongBao.Text = "[Không tìm thấy dữ liệu phù hợp]"
            lblThongBao.Visible = True

            lblCong.Text = "0đ"
            lblChietKhau.Text = "0đ"
            lblVAT.Text = "0đ"
            lblTongTien.Text = "0đ"
            lblSoLuong.Text = "0 hóa đơn"
        End If

    End Sub
#Region "THANH TOÁN - SỬA - XÓA HÓA ĐƠN"
    Private Sub btnSuaHoaDon_Click(sender As Object, e As EventArgs) Handles btnSuaHoaDon.Click
        If bsHoaDon.Current Is Nothing Then Exit Sub
        Dim vwHD As vwHoaDon = bsHoaDon.Current
        If vwHD.LoaiHD <> 1 Then
            Dim frm As New frmSuaHoaDonBanHang
            frm.HoaDon = dt.tbHoaDons.First(Function(s) s.id = vwHD.id)
            If frm.ShowDialog() = DialogResult.OK Then
                btnTimKiem_Click(Nothing, Nothing)
            End If
        Else
            Dim ctrlHoaDon As New ctrlHoaDon
            ctrlHoaDon.SuaHoaDon = vwHD
            RaiseEvent ThemTabpageMoi("HD/" + bsHoaDon.Current.MaHoaDon.ToString(), bsHoaDon.Current.MaHoaDon.ToString(), ctrlHoaDon)
        End If

    End Sub

    Private Sub btnXoaHoaDon_Click(sender As Object, e As EventArgs) Handles btnXoaHoaDon.Click
        If bsHoaDon.Current Is Nothing Then Exit Sub
        Dim vHoaDon As vwHoaDon = bsHoaDon.Current
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa hóa đơn " + vHoaDon.MaHoaDon.ToString + "?" +
                                                                   vbNewLine + "Và cập nhật lại số lượng sản phẩm.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then

            ' Cập nhật số lượng sản phẩm.

            Dim HoaDon = dt.tbHoaDons.First(Function(s) s.id = vHoaDon.id)


            'Khi xóa hóa đơn được tạo từ đơn đặt hàng, cập nhật trạng thái lại DDH đó chưa dc tạo hóa đơn
            If HoaDon.tbKhachHangDatHang IsNot Nothing Then
                If HoaDon.tbKhachHangDatHang.tbHoaDons.Count = 1 Then
                    HoaDon.tbKhachHangDatHang.DaLapHoaDon = False
                End If
            End If

            dt.tbHoaDons.DeleteOnSubmit(HoaDon)
            Try
                dt.SubmitChanges()
                btnTimKiem_Click(Nothing, Nothing)
            Catch ex As Exception
                undoChange()
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xóa hóa đơn thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

#End Region

#Region "IN HOA DON - IN DANH SACH"
    Private Sub btnInDanhSach_Click(sender As Object, e As EventArgs) Handles btnInDanhSach.Click
        If bsHoaDon.Count = 0 Then Exit Sub
        Dim frm As New frmInDanhSach
        frm.Text = "THỐNG KÊ HOÁ ĐƠN"
        frm.rptName = ".\Report\HoaDon\rptDanhSachHoaDon.rdlc"
        frm.dsName = "dsDanhSachHoaDon"
        frm._bs = bsHoaDon
        If TuNgay.Date = DenNgay.Date Then
            frm.ThoiGianTimKiem = "Ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay)
        Else
            frm.ThoiGianTimKiem = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
        End If
        frm.timkiemtheo = ""
        frm.Show()
    End Sub

    Private Sub btnXemNhanh_Click(sender As Object, e As EventArgs) Handles btnXemNhanh.Click
        If bsHoaDon.Current Is Nothing Then Exit Sub
        Dim vHoaDon As vwHoaDon = bsHoaDon.Current
        Dim HoaDon = dt.tbHoaDons.First(Function(s) s.id = vHoaDon.id)
        Dim frm As New frmInHoaDon
        frm.CtrlInHoaDon1.HoaDon = HoaDon
        frm.Show()
        undoChange()
    End Sub

    'Private Sub btnInHoaDon_Click(sender As Object, e As EventArgs) Handles btnInHoaDon.Click
    '    If bsHoaDon.Current Is Nothing Then Exit Sub
    '    Dim vHoaDon As vwHoaDon = bsHoaDon.Current
    '    Dim HoaDon = dt.tbHoaDons.First(Function(s) s.id = vHoaDon.id)
    '    mdlGlobals.InHoaDon(HoaDon)
    'End Sub
#End Region

#Region "CAP NHAT - TIM KIEM KHACH HÀNG"
    Private Sub chkTheoKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoKhachHang.CheckedChanged, chkTheoMaHoaDon.CheckedChanged
        cmbKhachHang.Enabled = chkTheoKhachHang.Checked
        cmbKhachHang.Focus()
    End Sub

    Private Sub btnCapNhatKhachHang_Click(sender As Object, e As EventArgs) Handles btnCapNhatKhachHang.Click
        cmbKhachHang.DataSource = From nv In dt.tbKhachHangs
                                  Select nv
    End Sub

    Private Sub btnTimKiemKhachHang_Click(sender As Object, e As EventArgs) Handles btnTimKiemKhachHang.Click
        Dim frm As New frmTimKiemKhachHang
        AddHandler frm.ChonKhachHangThanhCong, AddressOf ChonKhachHang
        frm.ShowDialog()
    End Sub

    Private Sub ChonKhachHang(kh As tbKhachHang)
        cmbKhachHang.DataSource = From itm In dt.tbKhachHangs
                                  Where itm.id = kh.id
    End Sub
#End Region

#Region "KHÁC"
    Private Sub chkTheoHinhThucThanhToan_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoHinhThucThanhToan.CheckedChanged
        cmbHinhThucThanhToan.Enabled = chkTheoHinhThucThanhToan.Checked
        cmbHinhThucThanhToan.Focus()
    End Sub

    Private Sub chkTheoNhanVien_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhanVien.CheckedChanged
        cmbNhanVien.Enabled = chkTheoNhanVien.Checked
        cmbNhanVien.Focus()
    End Sub

    Private Sub dgvMain_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMain.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Dim rowSelected As Integer = e.RowIndex
            If (e.RowIndex <> -1) Then
                Me.dgvMain.ClearSelection()
                Me.dgvMain.Rows(rowSelected).Selected = True
                bsHoaDon.Position = e.RowIndex
            End If
        End If
    End Sub

    Public Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        cmbNhanVien.DataSource = From nv In dt.tbNhanViens
                                 Select nv
    End Sub

    Private Sub chkTheoMaHoaDon_Click(sender As Object, e As EventArgs) Handles chkTheoMaHoaDon.Click
        txtTheoMaHoaDon.Enabled = chkTheoMaHoaDon.Checked
        txtTheoMaHoaDon.Focus()
        txtTheoMaHoaDon.SelectAll()
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT2.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Public Sub F3_btnThemHoaDonDauVao_Click(sender As Object, e As EventArgs) Handles btnThemHoaDonDauVao.Click
        Dim frm As New frmHoaDonBanHang
        frm.ShowDialog()
    End Sub

    Public Sub F4_btnThemHoaDonDauRa_Click(sender As Object, e As EventArgs) Handles btnThemHoaDonDauRa.Click
        Dim HoaDon As New ctrlHoaDon
        RaiseEvent ThemTabpageMoi("Hóa Đơn", "HoaDon" + Now.ToString("dd/MM/yyyy HH:mm:ss"), HoaDon)
    End Sub

    Private Sub dgvMain_DoubleClick(sender As Object, e As EventArgs) Handles dgvMain.DoubleClick
        btnSuaHoaDon_Click(Nothing, Nothing)
    End Sub
#End Region


End Class
