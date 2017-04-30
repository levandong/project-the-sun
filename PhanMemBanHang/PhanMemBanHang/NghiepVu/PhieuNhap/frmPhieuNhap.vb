Public Class frmPhieuNhap
    Dim lstChiTietPhieuNhap As New List(Of tbChiTietPhieuNhap)
    Public DonDatHang As New tbKhachHangDatHang
    Dim lst As New List(Of tbChiTietPhieuNhap)
    Dim idNguoiLienHe As Integer
    'Public lstSanPham As New List(Of tbChiTietKhachHangDatHang)
    Private Sub txtMaVach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCongTrinh.KeyPress, txtGhiChu.KeyPress, nudVAT.KeyPress, cmbLoaiPhieuNhap.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then 'Hoặc Convert.ToChar(Keys.Enter)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub frmPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbNhanVienNhan.DataSource = From itm In dt.tbNhanViens
                                     Order By itm.TenNhanVien
        With CtrlTimKiemSanPham1
            .colGiaBan.Visible = False
            .GiaQuyCach.Visible = False
            .colGiaNhap.Visible = True
        End With
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height + ToolStrip1.Size.Height)
        ctrl.ToolStrip1.Visible = False
        Me.Controls.Add(ctrl)
        btnCapNhatSoPhieu_Click(Nothing, Nothing)
        btnCapNhatLoaiPhieuNhap_Click(Nothing, Nothing)
        'btnCapNhatNhaCungCap_Click(Nothing, Nothing)
        cmbLoaiPhieuNhap_SelectedIndexChanged(Nothing, Nothing)
        cmbLoaiPhieuNhap.SelectedIndex = 0
        cmbLoaiPhieuNhap.Enabled = False
        txtCongTrinh.Text = DonDatHang.CongTrinh
        'Dim lstSanPham = From itm In dt.tbChiTietKhachHangDatHangs.Where(Function(s) s.idKhachHangDatHang = DonDatHang.id)
        ChonKhachHang((From itm In dt.tbKhachHangs Where itm.id = DonDatHang.idKhachHang).Single)
        chkXuatHoaDon.Checked = DonDatHang.isHoaDon
        If DonDatHang.idNguoiLienHe IsNot Nothing Then
            idNguoiLienHe = DonDatHang.idNguoiLienHe
        End If
        For Each itm In dt.SanPhamChuaNhapKho(DonDatHang.id)
            Dim SanPham As tbSanPham = dt.tbSanPhams.Single(Function(s) s.id = itm.idSanPham)
            Dim newChiTietXuatNhap As New tbChiTietPhieuNhap
            With newChiTietXuatNhap
                If itm.SoLuongConLai = 0 Then
                    Continue For
                End If
                .SoLuong = itm.SoLuongConLai
                .DonGia = itm.DonGia
                .DonVi = SanPham.DonVi
                .ChietKhau = itm.ChietKhau
                .idSanPham = itm.idSanPham
                .TonKho = SanPham.SoLuong
                .MaSanPham = itm.MaSanPham
                .QuyCach = 1
                .TheoDonVi = 1
                .GiaBan = itm.GiaBan
                .TenSanPham = itm.TenSanPham
                .GhiChu = itm.GhiChu
                .NgayNiemYet = itm.NgayNiemYet
            End With
            lstChiTietPhieuNhap.Add(newChiTietXuatNhap)
        Next
        CapNhat()
    End Sub
    Sub CapNhat()
        bsChiTietPhieuNhap.DataSource = From itm In lstChiTietPhieuNhap
    End Sub
#Region "TỔNG TIỀN PHIẾU NHẬP"
    Private Sub nudCongTien_ValueChanged(sender As Object, e As EventArgs) Handles nudVAT.ValueChanged, nudCongTien.ValueChanged, nudCK.ValueChanged
        nudTienCK.Value = nudCongTien.Value * nudCK.Value / 100
        Dim TienDaTruChietKhau As Decimal = nudCongTien.Value - nudTienCK.Value
        nudTienVAT.Value = TienDaTruChietKhau * nudVAT.Value / 100
        nudTongTien.Value = Math.Round(TienDaTruChietKhau * (100 + nudVAT.Value) / 100)
        'nudTongCongNo.Value = nudNoCu.Value + nudTongTien.Value
    End Sub


#End Region

#Region "CHỌN SẢN PHẨM"
    Private Sub CtrlTimKiemSanPham1_ChonSanPhamThanhCong(SanPham As tbSanPham, SoLuong As Double, TheoDonVi As Boolean) Handles CtrlTimKiemSanPham1.ChonSanPhamThanhCong
        Dim LoaiPhieu As tbLoaiPhieuNhap = cmbLoaiPhieuNhap.SelectedItem
        Dim newChiTietXuatNhap As New tbChiTietPhieuNhap
        With newChiTietXuatNhap
            .QuyCach = SanPham.QuyCach
            .SoLuong = SoLuong
            If LoaiPhieu.Loai = ELoaiPhieuNhap.NhapThuHoi Then
                If txtKhachHang.Tag Is Nothing Then
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn khách hàng trước khi chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtKhachHang.Focus()
                    Exit Sub
                End If
                Dim idKhachHang As Integer = txtKhachHang.Tag.id
                .DonGia = dt.LayGiaBanTraHang(SanPham.id, idKhachHang, dtpNgayLap.Value, TheoDonVi)
            Else
                If TheoDonVi Then
                    .DonGia = SanPham.GiaNiemYet
                Else
                    .DonGia = SanPham.GiaNhapQuyCach
                End If
            End If

            .TheoDonVi = TheoDonVi
            If TheoDonVi Then
                .GiaBan = SanPham.GiaQuyCach
                .DonVi = SanPham.DonVi
            Else
                .GiaBan = SanPham.GiaNhapQuyCach
                .DonVi = SanPham.DonViQuyCach
            End If

            .idSanPham = SanPham.id
            .ChietKhau = 0
            .MaSanPham = SanPham.MaSanPham
            .TenSanPham = SanPham.TenSanPham
        End With

        lstChiTietPhieuNhap.Add(newChiTietXuatNhap)
        bsChiTietPhieuNhap.DataSource = From sp In lstChiTietPhieuNhap Select sp
        bsChiTietPhieuNhap.MoveLast()
    End Sub
#End Region

#Region "CẬP NHẬT SỐ PHIẾU"
    Private Function LaySoTraNoMoiNhat() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbTraNoNhaCungCaps
                            Where pn.NgayTra.Year = dtpNgayLap.Value.Year
                            Where pn.NgayTra.Month = dtpNgayLap.Value.Month
                            Order By pn.id Descending
                            Select pn).FirstOrDefault
        If HoaDonCuNhat Is Nothing Then
            Return 1
        Else
            Return HoaDonCuNhat.SoPhieu + 1
        End If
    End Function
    Private Sub btnCapNhatSoPhieu_Click(sender As Object, e As EventArgs) Handles btnCapNhatSoPhieu.Click
        txtMaPhieuNhap.Tag = CapNhatSoPhieu()
        txtMaPhieuNhap.Text = dtpNgayLap.Value.ToString("MMyy") + "N" + txtMaPhieuNhap.Tag.ToString.PadLeft(4, "0")
    End Sub

    Private Function CapNhatSoPhieu() As Integer
        If dt.tbPhieuNhaps.Count = 0 Then Return 1
        Dim PhieuNhapCuNhat = (From itm In dt.tbPhieuNhaps
                               Where itm.NgayLap.Year = dtpNgayLap.Value.Year
                               Where itm.NgayLap.Month = dtpNgayLap.Value.Month
                               Select itm Order By itm.id Descending).FirstOrDefault
        If PhieuNhapCuNhat Is Nothing Then Return 1
        Return PhieuNhapCuNhat.SoPhieu + 1
    End Function

    Private Function LaySoPhieuThuNo() As Integer
        If dt.tbThuNoKhachHangs.Count = 0 Then Return 1
        Dim PhieuCuNhatTrongNgay = (From px In dt.tbThuNoKhachHangs
                                    Where px.NgayThu.Year = dtpNgayLap.Value.Year
                                    Where px.NgayThu.Month = dtpNgayLap.Value.Month
                                    Order By px.id Descending).FirstOrDefault
        If PhieuCuNhatTrongNgay Is Nothing Then
            Return 1
        Else
            Return PhieuCuNhatTrongNgay.SoPhieu + 1
        End If
    End Function

    Private Function LaySoPhieuChi() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuChis
                            Where pn.NgayLap.Year = dtpNgayLap.Value.Year
                            Where pn.NgayLap.Month = dtpNgayLap.Value.Month
                            Order By pn.id Descending
                            Select pn).FirstOrDefault
        If HoaDonCuNhat Is Nothing Then
            Return 1
        Else
            Return HoaDonCuNhat.SoPhieu + 1
        End If
    End Function
#End Region

#Region "Tăng / Giảm / Xoá / Xoá Tất Cả"
    Private Sub btnTangSanPham_Click(sender As Object, e As EventArgs) Handles btnTangSanPham.Click
        If bsChiTietPhieuNhap.Current Is Nothing Then Exit Sub
        Dim ChiTiet As tbChiTietPhieuNhap = bsChiTietPhieuNhap.Current
        ChiTiet.SoLuong += 1
    End Sub

    Private Sub btnGiamSanPham_Click(sender As Object, e As EventArgs) Handles btnGiamSanPham.Click
        If bsChiTietPhieuNhap.Current Is Nothing Then Exit Sub
        Dim ChiTiet As tbChiTietPhieuNhap = bsChiTietPhieuNhap.Current
        ChiTiet.SoLuong -= 1
        If ChiTiet.SoLuong = 0 Then
            lstChiTietPhieuNhap.Remove(bsChiTietPhieuNhap.Current)
            bsChiTietPhieuNhap.RemoveCurrent()
        End If
    End Sub

    Private Sub btnXoaSanPham_Click(sender As Object, e As EventArgs) Handles btnXoaSanPham.Click
        If bsChiTietPhieuNhap.Current Is Nothing Then Exit Sub
        lstChiTietPhieuNhap.Remove(bsChiTietPhieuNhap.Current)
        bsChiTietPhieuNhap.RemoveCurrent()
    End Sub

    Private Sub btnXoaTatCa_Click(sender As Object, e As EventArgs) Handles btnXoaTatCa.Click
        lstChiTietPhieuNhap.Clear()
        bsChiTietPhieuNhap.DataSource = From itm In lstChiTietPhieuNhap Select itm
    End Sub
#End Region

#Region "ĐỒNG Ý TẠO PHIẾU NHẬP XUẤT"

    Public Sub btnDongY_Click(sender As Object, e As EventArgs) Handles btnDongY.Click
        Dim PhieuNhap = DongYTaoPhieu()
        If PhieuNhap IsNot Nothing Then
            ThongBaoInfo("Tạo phiếu nhập " + PhieuNhap.MaPhieu + " thành công")
            btnDongY.Enabled = False
        End If
    End Sub

    Dim newPhieuNhap As tbPhieuNhap
    Private Function DongYTaoPhieu() As tbPhieuNhap
        bsChiTietPhieuNhap.EndEdit()
        dgvMain.EndEdit()

        If lstChiTietPhieuNhap.Count = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Danh sách sản phẩm xuất trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If

        If txtMaPhieuNhap.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Chưa có số phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If

        btnCapNhatSoPhieu_Click(Nothing, Nothing)
        If My.Settings.LuonXacNhanHoaDon Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xác nhận tạo phiếu " + txtMaPhieuNhap.Text.Trim, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return Nothing
            End If
        End If

        newPhieuNhap = New tbPhieuNhap
        Dim LoaiPhieuNhap = CType(cmbLoaiPhieuNhap.SelectedItem, tbLoaiPhieuNhap)
        With newPhieuNhap
            If LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapHangMoi Then
                .idKhachHang = CType(txtKhachHang.Tag, tbKhachHang).id
                .SoNgayNo = nudHanThanhToan.Value
                .TenCongTrinh = txtCongTrinh.Text
            ElseIf LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapDieuChinh Then
                ' Nhap dieu chinh kho
                .SoNgayNo = nudHanThanhToan.Value
            ElseIf LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapThuHoi Then
                ' Nhap thu hoi
                .SoNgayNo = nudHanThanhToan.Value
                .idKhachHang = CType(txtKhachHang.Tag, tbKhachHang).id
            End If
            If idNguoiLienHe <> 0 Then
                .idNguoiLienHe = idNguoiLienHe
            End If
            .idKhachHangDatHang = DonDatHang.id
            .HanThanhToan = dtpNgayLap.Value.Date.AddDays(nudHanThanhToan.Value)
            .tbChiTietPhieuNhaps.AddRange(lstChiTietPhieuNhap)
            .idNhanVienNhanHang = cmbNhanVienNhan.SelectedItem.id
            Dim rlsChiTiet = From itm In lstChiTietPhieuNhap
                             Group By itm.idSanPham Into SoLuong = Sum(itm.SoLuongNhap)

            'Cộng số lượng vào kho
            For Each ChiTiet In rlsChiTiet
                Dim SanPham = dt.tbSanPhams.First(Function(s) s.id = ChiTiet.idSanPham)
                dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, SanPham)
                SanPham.SoLuong += ChiTiet.SoLuong
            Next

            ' Neu là nhap thu hồi. Thì lấy giá vốn gần nhất, de sau nay tinh doanh thu, loi nhuan
            If LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapThuHoi Then
                For Each itm In lstChiTietPhieuNhap
                    itm.GiaVon = dt.LayGiaVonTraHang(itm.idSanPham, .idKhachHang, dtpNgayLap.Value)
                    itm.GiaBan = dt.LayGiaBanTraHang(itm.idSanPham, .idKhachHang, dtpNgayLap.Value, itm.TheoDonVi)
                Next
            End If
            .HanThanhToan = Now.AddDays(CType(txtKhachHang.Tag, tbKhachHang).NgayTraNo)
            .isThanhToan = False
            .NgayLap = dtpNgayLap.Value
            .idNhanVien = loginNhanVien.id
            .GhiChu = txtGhiChu.Text.Trim
            .idLoaiPhieuNhap = LoaiPhieuNhap.id
            .SoTienThanhToan = 0
            .SoPhieu = CapNhatSoPhieu()
            .VAT = nudVAT.Value
            .ChietKhau = nudCK.Value
        End With

        Try
            dt.tbPhieuNhaps.InsertOnSubmit(newPhieuNhap)
            dt.SubmitChanges()
            For Each itm In lstChiTietPhieuNhap
                If itm.tbSanPham.isSeri Then
                    Dim frm As New frmThemSoSeri
                    frm.idPhieuNhap = itm.idPhieuNhap
                    frm.idSanPham = itm.idSanPham
                    frm.SoLuong = itm.SoLuong
                    frm.ShowDialog()
                End If
            Next
            ' Tra lai tien hoac chuyen vao cong no cho khach hang
            'If LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapThuHoi Then
            '    Dim frm As New frmChonHinhThucThanhToanKhiTraHang
            '    If frm.ShowDialog = DialogResult.OK Then
            '        If frm.chkChiTietMat.Checked Then
            '            Dim newPhieuChi As New tbPhieuChi
            '            With newPhieuChi
            '                .HinhThucThanhToan = "TM"
            '                .SoPhieu = LaySoPhieuChi()
            '                .idNhanVien = loginNhanVien.id
            '                .idPhieuNhap = newPhieuNhap.id
            '                .NgayLap = dtpNgayLap.Value
            '                .DiaChi = newPhieuNhap.tbKhachHang.DiaChi
            '                .TenNguoiNhan = newPhieuNhap.tbKhachHang.TenKhachHang
            '                .LyDo = "Chi tiền cho khách trả lại hàng."
            '                .ChungTuKemTheo = "Phiếu nhập: " + txtMaPhieuNhap.Text
            '                .SoTien = nudTongTien.Value
            '            End With
            '            dt.tbPhieuChis.InsertOnSubmit(newPhieuChi)
            '        Else
            '            ' Tao phieu thu no âm cho khach hang
            '            Dim newThuNo As New tbThuNoKhachHang
            '            With newThuNo
            '                .SoPhieu = LaySoPhieuThuNo()
            '                .idKhachHang = newPhieuNhap.idKhachHang
            '                .NgayThu = dtpNgayLap.Value
            '                .idNhanVien = loginNhanVien.id
            '                .idPhieuNhap = newPhieuNhap.id
            '                .SoTien = nudTongTien.Value
            '                .idHinhThucThanhToan = 4 ' 4=> Công nợ
            '                .GhiChu = "Khách trả lại hàng theo phiếu nhập " + txtMaPhieuNhap.Text
            '            End With
            '            dt.tbThuNoKhachHangs.InsertOnSubmit(newThuNo)
            '        End If
            '    End If
            '    dt.SubmitChanges()
            'End If

            ' trả lại nguyên dạng
            Return newPhieuNhap
            btnDongY.Enabled = False
        Catch ex As Exception
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tạo phiếu thất bại. Vui lòng thử lại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            undoChange()
            Return Nothing
        End Try
    End Function
    Public Sub btnXemTruoc_Click(sender As Object, e As EventArgs)
        bsChiTietPhieuNhap.EndEdit()
        dgvMain.EndEdit()
        If bsChiTietPhieuNhap.Count > 0 Then
            Dim frm As New frmInPhieuNhap
            Dim PhieuNhap As New tbPhieuNhap
            Dim LoaiPhieuNhap = CType(cmbLoaiPhieuNhap.SelectedItem, tbLoaiPhieuNhap)
            With PhieuNhap
                .NgayLap = dtpNgayLap.Value
                .idNhanVien = loginNhanVien.id
                .GhiChu = txtGhiChu.Text.Trim
                .idLoaiPhieuNhap = LoaiPhieuNhap.id
                .SoPhieu = txtMaPhieuNhap.Tag
                .SoTienThanhToan = 0
                .VAT = nudVAT.Value
                .ChietKhau = nudCK.Value
                If LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapHangMoi Then
                    .tbKhachHang1 = CType(txtKhachHang.Tag, tbKhachHang)
                    .tbKhachHang = Nothing
                ElseIf LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapDieuChinh Then
                    .tbKhachHang = Nothing
                    .tbKhachHang1 = Nothing
                ElseIf LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapThuHoi Then
                    .tbKhachHang1 = Nothing
                    .tbKhachHang = CType(txtKhachHang.Tag, tbKhachHang)
                End If
            End With
            frm.PhieuNhap = PhieuNhap
            frm.TongTien = nudTongTien.Value
            frm.bsData = bsChiTietPhieuNhap
            frm.XemTruoc = True
            frm.ShowDialog()
            undoChange()
        End If
    End Sub
    Private Sub bsChiTietPhieuNhap_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietPhieuNhap.ListChanged
        lblSoLuong.Text = bsChiTietPhieuNhap.Count.ToString + " sản phẩm."
        Dim Tong As Decimal = 0
        For Each itm In bsChiTietPhieuNhap
            Tong += itm.ThanhTien
        Next
        nudCongTien.Value = Math.Round(Tong)
    End Sub

    Private Sub dgvChiTietPhieuNhap_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dtpNgayLap.Value = Now
    End Sub

    Private checkAutoTimer As Boolean
    Private Sub btnTickThoiGian_Click(sender As Object, e As EventArgs) Handles btnTickThoiGian.Click
        Timer1.Enabled = checkAutoTimer
        checkAutoTimer = Not checkAutoTimer
        If checkAutoTimer Then
            btnTickThoiGian.Image = My.Resources.unchecked
        Else
            btnTickThoiGian.Image = My.Resources.Checked
        End If
    End Sub
#End Region

#Region "LOẠI PHIẾU NHẬP"
    Private Sub cmbLoaiPhieuNhap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoaiPhieuNhap.SelectedIndexChanged
        If cmbLoaiPhieuNhap.SelectedItem Is Nothing Then Exit Sub
        Dim LoaiPhieuNhap = CType(cmbLoaiPhieuNhap.SelectedItem, tbLoaiPhieuNhap)
        If LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapHangMoi Then
            ' Nhap hang moi tu nha cung cap
            CtrlTimKiemSanPham1.colGiaBan.Visible = False
            CtrlTimKiemSanPham1.colGiaNhap.Visible = True
        ElseIf LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapDieuChinh Then
            ' Nhap dieu chinh kho


        ElseIf LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapThuHoi Then
            ' Nhap trả hàng từ khách hang = 3
            CtrlTimKiemSanPham1.colGiaBan.Visible = True
            CtrlTimKiemSanPham1.colGiaNhap.Visible = False
        End If
    End Sub

    Private Sub btnCapNhatLoaiPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoaiPhieuNhap.Click
        cmbLoaiPhieuNhap.DataSource = From itm In dt.tbLoaiPhieuNhaps Select itm
    End Sub

#End Region



    Private Sub dgvMain_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellValueChanged
        If e.RowIndex >= 0 Then
            If dgvMain.Columns(e.ColumnIndex).Name = "colChietKhau" Then
                Dim ChiTietBaoGia As tbChiTietPhieuNhap = dgvMain.Rows(e.RowIndex).DataBoundItem
                ChiTietBaoGia.GiaBan = ChiTietBaoGia.DonGia * (100 - ChiTietBaoGia.ChietKhau) / 100
            ElseIf dgvMain.Columns(e.ColumnIndex).Name = "GiaChietKhau" Then
                Dim ChiTietBaoGia As tbChiTietPhieuNhap = dgvMain.Rows(e.RowIndex).DataBoundItem
                If ChiTietBaoGia.GiaBan = 0 Then
                    ChiTietBaoGia.ChietKhau = 100
                Else
                    ChiTietBaoGia.ChietKhau = (1 - ChiTietBaoGia.DonGia / ChiTietBaoGia.GiaBan) * 100
                End If
            End If
        End If
    End Sub
    Private Sub dgvMain_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvMain.CellValidating
        If bsChiTietPhieuNhap.Current Is Nothing Then Exit Sub
        If dgvMain.Columns(e.ColumnIndex).Name = "colChietKhau" Or dgvMain.Columns(e.ColumnIndex).Name = "GiaChietKhau" Or dgvMain.Columns(e.ColumnIndex).Name = "SoLuong" Then
            dgvMain.InvalidateRow(e.RowIndex)
        End If
    End Sub

    Private Sub frmPhieuNhap_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 And btnDongY.Enabled = True Then
            btnDongY_Click(Nothing, Nothing)
        End If
    End Sub
    Dim ctrl As New ctrlDGVKhachHang
    Dim i As Integer = 0
    'fotmat ngày tháng năm thành dd/MM/yy nếu không thêm 1 điều kiện
    Private Sub dtpNgayNiemYet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpNgayLap.KeyPress
        i += 1
        If i = 2 Then
            SendKeys.Send("{DIVIDE}")
            i = -1
        End If
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
#Region "Chọn khách hàng"
    Private Sub txtKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKhachHang.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vKhachHang As vwKhachHang = ctrl.bsKhachHang.Current
            If vKhachHang Is Nothing Then
                Exit Sub
            End If
            Dim Khachhang As tbKhachHang = dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id)
            ChonKhachHang(Khachhang)
            ctrl.Visible = False
        ElseIf e.KeyCode = Keys.Down Then
            If ctrl.dgvMain.CurrentCell.RowIndex = ctrl.dgvMain.RowCount - 1 Then
                ctrl.dgvMain.CurrentCell = ctrl.dgvMain.Rows(0).Cells(ctrl.dgvMain.CurrentCell.ColumnIndex)
            Else
                ctrl.dgvMain.CurrentCell = ctrl.dgvMain.Rows(ctrl.dgvMain.CurrentCell.RowIndex + 1).Cells(ctrl.dgvMain.CurrentCell.ColumnIndex)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If ctrl.dgvMain.CurrentCell.RowIndex = 0 Then
                ctrl.dgvMain.CurrentCell = ctrl.dgvMain.Rows(ctrl.dgvMain.RowCount - 1).Cells(ctrl.dgvMain.CurrentCell.ColumnIndex)
            Else
                ctrl.dgvMain.CurrentCell = ctrl.dgvMain.Rows(ctrl.dgvMain.CurrentCell.RowIndex - 1).Cells(ctrl.dgvMain.CurrentCell.ColumnIndex)
            End If
        End If
    End Sub
    Private Sub ChonKhachHang(khachHang As tbKhachHang)
        txtKhachHang.Text = khachHang.TenKhachHang
        txtKhachHang.Tag = khachHang
    End Sub
    Private Sub txtKhachHang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKhachHang.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

#End Region
End Class