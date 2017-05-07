Public Class ctrlThongKePhieuXuat
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
                Case "btnSuaPhieuXuat"
                    PhanQuyenLenDoiTuong(btnSuaPhieu, qc1.HinhThuc, TrangThai)
                Case "btnXoaPhieuXuat"
                    PhanQuyenLenDoiTuong(btnXoaPhieu, qc1.HinhThuc, TrangThai)
            End Select
        Next
    End Sub
    Private Sub dgvMain_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMain.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Dim rowSelected As Integer = e.RowIndex
            If (e.RowIndex <> -1) Then
                Me.dgvMain.ClearSelection()
                Me.dgvMain.Rows(rowSelected).Selected = True
                bsPhieuXuat.Position = e.RowIndex
            End If
        End If
    End Sub
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
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
        Dim idLoaiPhieuXuat As Integer
        If chkTheoLoaiPhieuXuat.Checked Then
            If cmbTheoLoaiPhieuXuat.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn loại phiếu nhập cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbTheoLoaiPhieuXuat.Focus()
                Exit Sub
            Else
                idLoaiPhieuXuat = cmbTheoLoaiPhieuXuat.SelectedItem.id
            End If
        End If
        Dim idNhaCungCap As Integer
        If chkTheoNhaCungCap.Checked Then
            If cmbTheoNhaCungCap.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhà cung cấp cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbTheoNhaCungCap.Focus()
                Exit Sub
            Else
                idNhaCungCap = cmbTheoNhaCungCap.SelectedItem.id
            End If
        End If

        Dim rls = From itm In dt.vwPhieuXuats
                  Where itm.NgayLap >= TuNgay And itm.NgayLap <= DenNgay
                  Where (Not chkTheoNhanVien.Checked) Or (itm.idNhanVien = idNV)
                  Where (Not chkTheoLoaiPhieuXuat.Checked) Or (itm.idLoaiPhieuXuat = idLoaiPhieuXuat)
                  Where (Not chkTheoNhaCungCap.Checked) Or (itm.idKhachHang = idNhaCungCap)
                  Where itm.SoPhieuXuat <> 0
                  Order By itm.NgayLap

        bsPhieuXuat.DataSource = rls

        If rls.Count > 0 Then
            lblSoDong.Text = rls.Count.ToString + " phiếu."
            lblTongTien.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.TongTienPhieuXuat)) + "đ"
            lblTienTruocThue.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.TongTienTruocVAT)) + "đ"
            lblVAT.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.TongTienVAT)) + "đ"
        Else
            lblSoDong.Text = "0 phiếu."
            lblTienTruocThue.Text = "0đ"
            lblVAT.Text = "0đ"
            lblTongTien.Text = "0đ"
        End If
    End Sub


    Private Sub ctrlThongKePhieuXuatNguyenLieu_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnCapNhatLoaiPhieuXuat_Click(Nothing, Nothing)
        btnCapNhatNhanVien_Click(Nothing, Nothing)
        btnCapNhatNhaCungCap_Click(Nothing, Nothing)
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = New Date(Now.Date.AddDays(-30).Year, Now.Date.AddDays(-30).Month, Now.Date.AddDays(-30).Day)
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New Date(Now.Date.Year, Now.Date.Month, Now.Day, 23, 59, 59)
        btnTimKiem_Click(Nothing, Nothing)
    End Sub


    'Private Sub btnInPhieu_Click(sender As Object, e As EventArgs) Handles btnInPhieu.Click
    '    If bsPhieuXuat.Current Is Nothing Then Exit Sub
    '    Dim vwPhieuXuat As vwPhieuXuat = bsPhieuXuat.Current
    '    Dim PhieuXuat = dt.tbPhieuXuats.First(Function(s) s.id = vwPhieuXuat.id)
    '    mdlGlobals.InPhieuXuat(PhieuXuat, PhieuXuat.TongTien)
    'End Sub

    'Private Sub btnXemNhanh_Click(sender As Object, e As EventArgs) Handles btnXemNhanh.Click
    '    If bsPhieuXuat.Current Is Nothing Then Exit Sub
    '    Dim frm As New frmInPhieuXuat
    '    Dim vwPhieuXuat As vwPhieuXuat = bsPhieuXuat.Current
    '    Dim PhieuXuat = dt.tbPhieuXuats.First(Function(s) s.id = vwPhieuXuat.id)
    '    frm.PhieuXuat = PhieuXuat
    '    frm.TongTien = PhieuXuat.TongTien
    '    frm.XemTruoc = False
    '    frm.Show()
    'End Sub
    Event ThemTabpageMoi(TenHienThi As String, Ten As String, control As Control)
    Private Sub btnSuaPhieu_Click(sender As Object, e As EventArgs) Handles btnSuaPhieu.Click
        If bsPhieuXuat.Current Is Nothing Then Exit Sub
        Dim ctrlPhieuXuat As New ctrlPhieuXuat
        Dim vwPhieuXuat As vwPhieuXuat = bsPhieuXuat.Current
        Dim PhieuXuat = dt.tbPhieuXuats.First(Function(s) s.id = vwPhieuXuat.id)
        ctrlPhieuXuat.CapNhatPhieuXuat(PhieuXuat)
        RaiseEvent ThemTabpageMoi("PX/" + PhieuXuat.MaPhieu, PhieuXuat.MaPhieu, ctrlPhieuXuat)
    End Sub

    Private Sub btnXoaPhieu_Click(sender As Object, e As EventArgs) Handles btnXoaPhieu.Click
        If bsPhieuXuat.Current Is Nothing Then Exit Sub
        Dim vwPhieuXuat As vwPhieuXuat = bsPhieuXuat.Current
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa phiếu " + vwPhieuXuat.MaPhieu + "?" + vbNewLine +
                                                                   "Và cập nhật số lượng vào kho?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
        Dim PhieuXuat = dt.tbPhieuXuats.First(Function(s) s.id = vwPhieuXuat.id)
        'For Each itm In dt.tbChiTietSeris.Where(Function(s) s.idPhieuXuat = PhieuXuat.id)
        '    itm.idPhieuXuat = Nothing
        'Next
        'Try
        '    dt.SubmitChanges()
        'Catch ex As Exception
        '    undoChange()
        '    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xóa phiếu thất bại." + vbNewLine + "Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try
        Dim rls = dt.tbChiTietPhieuXuats.Where(Function(s) s.idPhieuXuat = PhieuXuat.id)

        Dim rlsi = From itm In rls.ToList
                   Group By itm.idSanPham Into SoLuong = Sum(itm.SoLuongXuat)

        For Each itm In rlsi
            Dim SanPham = dt.tbSanPhams.First(Function(s) s.id = itm.idSanPham)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, SanPham)
            ' Cộng số lượng vào kho
            SanPham.SoLuong += itm.SoLuong
        Next
        dt.tbPhieuXuats.DeleteOnSubmit(PhieuXuat)

        Try
            dt.SubmitChanges()
            btnTimKiem_Click(Nothing, Nothing)
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xóa phiếu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        If bsPhieuXuat.Count = 0 Then Exit Sub
        Dim frm As New frmInDanhSach
        frm.rptName = ".\Report\PhieuXuat\rptDanhSachPhieuXuatKho.rdlc"
        frm.dsName = "dsPhieuXuat"
        frm._bs = bsPhieuXuat
        If TuNgay.Date = DenNgay.Date Then
            frm.ThoiGianTimKiem = "Ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay)
        Else
            frm.ThoiGianTimKiem = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
        End If
        frm.Text = "THỐNG KÊ PHIẾU XUẤT"
        frm.Show()
    End Sub

    Private Sub btnCapNhatLoaiPhieuXuat_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoaiPhieuXuat.Click
        cmbTheoLoaiPhieuXuat.DataSource = From itm In dt.tbLoaiPhieuXuats Select itm
    End Sub


    Private Sub btnCapNhatNhaCungCap_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhaCungCap.Click
        cmbTheoNhaCungCap.DataSource = From itm In dt.tbKhachHangs Select itm Order By itm.TenKhachHang
    End Sub

    Public Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        cmbNhanVien.DataSource = From itm In dt.tbNhanViens Order By itm.TenDangNhap
    End Sub

    Private Sub chkTheoNhanVien_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhanVien.CheckedChanged
        cmbNhanVien.Enabled = chkTheoNhanVien.Checked
        cmbNhanVien.Focus()
    End Sub

    Private Sub chkTheoNhaCungCap_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhaCungCap.CheckedChanged
        cmbTheoNhaCungCap.Enabled = chkTheoNhaCungCap.Checked
        cmbTheoNhaCungCap.Focus()
    End Sub

    Private Sub chkTheoLoaiPhieuXuat_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoLoaiPhieuXuat.CheckedChanged
        cmbTheoLoaiPhieuXuat.Enabled = chkTheoLoaiPhieuXuat.Checked
        cmbTheoLoaiPhieuXuat.Focus()
    End Sub

    Private Sub btnTimKiemNhaCungCap_Click(sender As Object, e As EventArgs) Handles btnTimKiemNhaCungCap.Click
        Dim frm As New frmTimKiemKhachHang
        AddHandler frm.ChonKhachHangThanhCong, AddressOf ChonNhaCungCap
        frm.ShowDialog()
    End Sub

    Private Sub ChonNhaCungCap(kh As tbKhachHang)
        cmbTheoNhaCungCap.DataSource = From itm In dt.tbKhachHangs
                                       Where itm.id = kh.id
    End Sub
    Event XuatHoaDon(PhieuXuat As vwPhieuXuat)
    Private Sub XuấtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtHóaĐơnToolStripMenuItem.Click
        Dim vPhieuXuat As vwPhieuXuat = bsPhieuXuat.Current
        If vPhieuXuat.isHoaDon = True Then

            If vPhieuXuat.DaXuatHoaDon = 0 Then
                Dim frm As New frmHoaDon
                frm.HoaDon.CapNhatPhieuXuat(vPhieuXuat)
                frm.ShowDialog()
            Else
                If XacNhanYesNo("Đã xuất hóa đơn cho Phiếu xuất này." + vbNewLine + "Bạn muốn tiếp tục xuất hóa đơn cho phiếu xuất này?") = MsgBoxResult.Yes Then
                    Dim frm As New frmHoaDon
                    frm.HoaDon.CapNhatPhieuXuat(vPhieuXuat)
                    frm.ShowDialog()
                End If

            End If

        End If
    End Sub

    Private Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        btnSuaPhieu_Click(Nothing, Nothing)
    End Sub


    Private Sub XóaPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        btnXoaPhieu_Click(Nothing, Nothing)
    End Sub

    Private Sub PhiếuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuXuấtToolStripMenuItem.Click
        If bsPhieuXuat.Current Is Nothing Then Exit Sub
        Dim vPhieuXuat As vwPhieuXuat = bsPhieuXuat.Current
        TaoPhieuXuatExcel(Application.StartupPath + "\UyNhiemChi\PhieuXuat.xlsx", vPhieuXuat, False)
    End Sub

    Private Sub CóKýHiệuKhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CóKýHiệuKhoToolStripMenuItem.Click
        If bsPhieuXuat.Current Is Nothing Then Exit Sub
        Dim vPhieuXuat As vwPhieuXuat = bsPhieuXuat.Current
        TaoPhieuXuatExcel(Application.StartupPath + "\UyNhiemChi\PhieuXuatKyHieuKho.xlsx", vPhieuXuat, True)
    End Sub
End Class
