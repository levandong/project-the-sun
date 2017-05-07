Public Class ctrlThongKePhieuNhap
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
                Case "btnSuaPhieuNhap"
                    PhanQuyenLenDoiTuong(btnSuaPhieu, qc1.HinhThuc, TrangThai)
                Case "btnXoaPhieuNhap"
                    PhanQuyenLenDoiTuong(btnXoaPhieu, qc1.HinhThuc, TrangThai)
            End Select
        Next
    End Sub

    Dim TuNgay As DateTime
    Dim DenNgay As DateTime
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        TuNgay = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        DenNgay = CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value

        Dim idNV As Integer = 0
        If chkTheoNhanVien.Checked Then
            If cmbNhanVien.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhân viên cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbNhanVien.Focus()
                Exit Sub
            Else
                idNV = cmbNhanVien.SelectedItem.id
            End If
        End If

        Dim idLoaiPhieuNhap As Integer
        If chkTheoLoaiPhieuNhap.Checked Then
            If cmbTheoLoaiPhieuNhap.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn loại phiếu nhập cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbTheoLoaiPhieuNhap.Focus()
                Exit Sub
            Else
                idLoaiPhieuNhap = cmbTheoLoaiPhieuNhap.SelectedItem.id
            End If
        End If

        Dim idKhachHang As Integer
        If chkTheoKhachHang.Checked Then
            If cmbTheoKhachHang.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn khách hàng cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbTheoKhachHang.Focus()
                Exit Sub
            Else
                idKhachHang = cmbTheoKhachHang.SelectedItem.id
            End If
        End If


        Dim rls = From itm In dt.vwPhieuNhaps
                  Where itm.NgayLap >= TuNgay And itm.NgayLap <= DenNgay
                  Where (Not chkTheoNhanVien.Checked) Or (itm.idNhanVien = idNV)
                  Where (Not chkTheoLoaiPhieuNhap.Checked) Or (itm.idLoaiPhieuNhap = idLoaiPhieuNhap)
                  Where (Not chkTheoKhachHang.Checked) Or (itm.idKhachHang = idKhachHang)
                  Where itm.SoPhieu <> 0
                  Order By itm.NgayLap

        gridControl.DataSource = rls
        gridViewData.RefreshData()
    End Sub

    Private Sub ctrlThongKePhieuNhapNguyenLieu_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnCapNhatLoaiPhieuNhap_Click(Nothing, Nothing)
        btnCapNhatNhanVien_Click(Nothing, Nothing)
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = New Date(Now.Date.AddDays(-30).Year, Now.Date.AddDays(-30).Month, Now.Date.AddDays(-30).Day)
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New Date(Now.Date.Year, Now.Date.Month, Now.Day, 23, 59, 59)
        btnTimKiem_Click(Nothing, Nothing)
    End Sub
    Event ThemTabpageMoi(TenHienThi As String, Ten As String, control As Control)

#Region "SỬA - XÓA PHIẾU NHẬP"
    Private Sub btnSuaPhieu_Click(sender As Object, e As EventArgs) Handles btnSuaPhieu.Click
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vwPhieuNhap As vwPhieuNhap = gridViewData.GetRow(gridViewData.FocusedRowHandle)
        Dim PhieuNhap = dt.tbPhieuNhaps.First(Function(s) s.id = vwPhieuNhap.id)
        Dim ctrlPhieuNhap As New ctrlSuaPhieuNhap
        ctrlPhieuNhap.SuaPhieuBaoGia(PhieuNhap)
        RaiseEvent ThemTabpageMoi("PN/" + PhieuNhap.MaPhieu, PhieuNhap.MaPhieu, ctrlPhieuNhap)
    End Sub

    Private Sub btnXoaPhieu_Click(sender As Object, e As EventArgs) Handles btnXoaPhieu.Click
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vwPhieuNhap As vwPhieuNhap = gridViewData.GetRow(gridViewData.FocusedRowHandle)
        If frmMessageBox.Show("Bạn muốn xóa phiếu " + vwPhieuNhap.MaPhieu + "?" + vbNewLine + "Và cập nhật số lượng vào kho?", "Xác nhận") = DialogResult.No Then Exit Sub
        Dim PhieuNhap = dt.tbPhieuNhaps.First(Function(s) s.id = vwPhieuNhap.id)
        Dim rls = From itm In dt.tbChiTietPhieuNhaps
                  Where itm.idPhieuNhap = PhieuNhap.id
        Dim rlsi = From itm In rls.ToList
                   Group By itm.idSanPham Into SoLuong = Sum(itm.SoLuongNhap)
        For Each itm In rlsi
            Dim SanPham = dt.tbSanPhams.First(Function(s) s.id = itm.idSanPham)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, SanPham)
            ' Trừ số lượng trong kho
            SanPham.SoLuong -= itm.SoLuong
        Next

        dt.tbPhieuNhaps.DeleteOnSubmit(PhieuNhap)
        Try
            dt.SubmitChanges()
            btnTimKiem_Click(Nothing, Nothing)
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xóa phiếu thất bại." + vbNewLine + "Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region

#Region "IN DANH SÁCH - IN PHIẾU"
    'Private Sub btnInPhieu_Click(sender As Object, e As EventArgs) Handles btnInPhieu.Click
    '    If bsPhieuNhap.Current Is Nothing Then Exit Sub
    '    Dim vwPhieuNhap As vwPhieuNhap = bsPhieuNhap.Current
    '    Dim PhieuNhap = dt.tbPhieuNhaps.First(Function(s) s.id = vwPhieuNhap.id)
    '    mdlGlobals.InPhieuNhap(PhieuNhap, PhieuNhap.TongTien)
    'End Sub

    'Private Sub btnXemNhanh_Click(sender As Object, e As EventArgs) Handles btnXemNhanh.Click
    '    If bsPhieuNhap.Current Is Nothing Then Exit Sub
    '    Dim frm As New frmInPhieuNhap
    '    Dim vwPhieuNhap As vwPhieuNhap = bsPhieuNhap.Current
    '    Dim PhieuNhap = dt.tbPhieuNhaps.First(Function(s) s.id = vwPhieuNhap.id)
    '    frm.PhieuNhap = PhieuNhap
    '    frm.TongTien = PhieuNhap.TongTien
    '    frm.XemTruoc = False
    '    frm.Show()
    'End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        If gridViewData.DataRowCount = 0 Then Exit Sub
        Dim frm As New frmInDanhSach
        frm.rptName = ".\Report\PhieuNhap\rptDanhSachPhieuNhap.rdlc"
        frm.dsName = "dsPhieuNhap"
        frm._bs.DataSource = gridControl.DataSource
        If TuNgay.Date = DenNgay.Date Then
            frm.ThoiGianTimKiem = "Ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay)
        Else
            frm.ThoiGianTimKiem = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
        End If
        frm.Text = "THỐNG KÊ PHIẾU NHẬP"
        frm.Show()
    End Sub
#End Region

#Region "CẬP NHẬT - TIM KIẾM KHÁCH HÀNG"
    Private Sub btnCapNhatKhachHang_Click(sender As Object, e As EventArgs) Handles btnCapNhatKhachHang.Click
        cmbTheoKhachHang.DataSource = From itm In dt.tbKhachHangs Select itm Order By itm.TenKhachHang
    End Sub

    Private Sub btnTimKiemKhachHang_Click(sender As Object, e As EventArgs) Handles btnTimKiemKhachHang.Click
        Dim frm As New frmTimKiemKhachHang
        AddHandler frm.ChonKhachHangThanhCong, AddressOf ChonKhachHang
        frm.ShowDialog()
    End Sub

    Private Sub ChonKhachHang(kh As tbKhachHang)
        cmbTheoKhachHang.DataSource = From itm In dt.tbKhachHangs
                                      Where itm.id = kh.id
    End Sub


    Private Sub chkTheoKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoKhachHang.CheckedChanged
        cmbTheoKhachHang.Enabled = chkTheoKhachHang.Checked
        cmbTheoKhachHang.Focus()
    End Sub
#End Region

#Region "KHÁC"
    Private Sub gridViewData_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridViewData.CustomDrawRowIndicator
        If (e.Info.IsRowIndicator) Then
            If e.RowHandle < 0 Then
                e.Info.ImageIndex = 0
                e.Info.DisplayText = ""
            Else
                e.Info.ImageIndex = 1
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
        End If
    End Sub

    Public Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        cmbNhanVien.DataSource = From itm In dt.tbNhanViens Order By itm.TenDangNhap
    End Sub

    Private Sub chkTheoLoaiPhieuNhap_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoLoaiPhieuNhap.CheckedChanged
        cmbTheoLoaiPhieuNhap.Enabled = chkTheoLoaiPhieuNhap.Checked
        cmbTheoLoaiPhieuNhap.Focus()
    End Sub

    Private Sub chkTheoNhanVien_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhanVien.CheckedChanged
        cmbNhanVien.Enabled = chkTheoNhanVien.Checked
        cmbNhanVien.Focus()
    End Sub

    Private Sub btnCapNhatLoaiPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoaiPhieuNhap.Click
        cmbTheoLoaiPhieuNhap.DataSource = From itm In dt.tbLoaiPhieuNhaps Select itm
    End Sub

    Private Sub chkTheoLoaiPhieuNhap_Click(sender As Object, e As EventArgs) Handles chkTheoLoaiPhieuNhap.Click
        cmbTheoLoaiPhieuNhap.Enabled = chkTheoLoaiPhieuNhap.Checked
        cmbTheoLoaiPhieuNhap.Focus()
    End Sub
#End Region

#Region "THANH TOÁN PHIẾU NHẬP"
    Private Sub ThanhToánPhiếuNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If gridViewData.FocusedRowHandle >= 0 Then
            Dim vPhieuNhap As vwPhieuNhap = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            Dim PhieuNhap = dt.tbPhieuNhaps.Single(Function(s) s.id = vPhieuNhap.id)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, PhieuNhap)
            PhieuNhap.isThanhToan = True
            dt.SubmitChanges()
        End If
    End Sub


    Private Sub gridControl_DoubleClick(sender As Object, e As EventArgs) Handles gridControl.DoubleClick
        btnSuaPhieu_Click(Nothing, Nothing)
    End Sub

    Public Sub F3_btnThemPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnThemPhieuNhap.Click
        Dim PhieuNhap As New ctrlPhieuNhap
        RaiseEvent ThemTabpageMoi("Phiếu Nhập", "PN" + Now.ToString("dd/MM/yy HH:ss"), PhieuNhap)
    End Sub

    Private Sub XóaPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XóaPhiếuToolStripMenuItem.Click
        btnXoaPhieu_Click(Nothing, Nothing)
    End Sub

    Private Sub SửaPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SửaPhiếuToolStripMenuItem.Click
        btnSuaPhieu_Click(Nothing, Nothing)
    End Sub


    Private Sub NhậpCóKýHiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhậpCóKýHiệuToolStripMenuItem.Click
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vPhieuXuat As vwPhieuNhap = gridViewData.GetRow(gridViewData.FocusedRowHandle)
        TaoPhieuNhapExcel1(Application.StartupPath + "\UyNhiemChi\PhieuNhapKyHieuKho.xlsx", vPhieuXuat, True)
    End Sub

    Private Sub PhiếuXuấtKkhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuNhậpKhoToolStripMenuItem.Click
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vPhieuXuat As vwPhieuNhap = gridViewData.GetRow(gridViewData.FocusedRowHandle)
        TaoPhieuNhapExcel1(Application.StartupPath + "\UyNhiemChi\PhieuNhap1.xlsx", vPhieuXuat, False)
    End Sub



#End Region
End Class
