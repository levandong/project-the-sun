Public Class ctrlPhieuNhap
    Dim lstChiTietPhieuNhap As New List(Of tbChiTietPhieuNhap)
    Dim lstLuuTam As New List(Of tbChiTietPhieuNhap)
    Dim isSua As Boolean = False
    Public SuaPhieuNhap As tbPhieuNhap
    Public DonDatHang As tbKhachHangDatHang
    Private Sub ctrlBangBaoGiaMoi_Load(sender As Object, e As EventArgs) Handles Me.Load
        If isSua = False Then
            btnCapNhapSoPhieu_Click(Nothing, Nothing)
            btnCapNhatLoaiBaoGia_Click(Nothing, Nothing)
            txtNhanVien.Text = loginNhanVien.TenNhanVien
            cmbLoaiBaoGia.SelectedIndex = 0
            cmbNhanVienNhan.DataSource = From itm In dt.tbNhanViens
                                         Order By itm.TenNhanVien
        End If
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height + ToolStrip1.Size.Height)
        Me.Controls.Add(ctrl)
    End Sub
    Public Sub SuaPhieuBaoGia(PhieuNhap As tbPhieuNhap)
        SuaPhieuNhap = PhieuNhap
        isSua = True
        Dim rls = (From itm In dt.tbChiTietPhieuNhaps Where itm.idPhieuNhap = PhieuNhap.id)
        lstChiTietPhieuNhap = rls.ToList
        For Each itm In lstChiTietPhieuNhap
            itm.iSTT = iSTT
            iSTT += 1
        Next
        'For Each itm In lstChiTietPhieuNhap
        '    Dim S As Decimal = itm.DonGia * (100 - itm.ChietKhau) / 10000
        '    itm.GiaBan = Math.Round(S, 0, MidpointRounding.AwayFromZero) * 100
        'Next
        'Lưu lại file tạm
        For Each itm In rls
            Dim ChiTiet As New tbChiTietPhieuNhap
            With ChiTiet
                .id = itm.id
                .idSanPham = itm.idSanPham
                .GiaBan = itm.GiaBan
                .DonGia = itm.DonGia
                .GhiChu = itm.GhiChu
                .idPhieuNhap = itm.idPhieuNhap
                .SoLuong = itm.SoLuong
                .ChietKhau = itm.ChietKhau
                .NgayNiemYet = itm.NgayNiemYet
            End With
            lstLuuTam.Add(ChiTiet)
        Next
        cmbLoaiBaoGia.DataSource = (From itm In dt.tbLoaiPhieuNhaps Where itm.id = PhieuNhap.idLoaiPhieuNhap)
        If PhieuNhap.tbKhachHang IsNot Nothing Then
            ChonKhachHang(PhieuNhap.tbKhachHang)
        End If
        bsChiTietPhieuNhap.DataSource = From itm In lstChiTietPhieuNhap
                                        Order By itm.iSTT Descending
        cmbNhanVienNhan.DataSource = From itm In dt.tbNhanViens
                                     Order By itm.TenNhanVien
        cmbNhanVienNhan.SelectedItem = PhieuNhap.tbNhanVien1
        txtGhiChu.Text = PhieuNhap.GhiChu.Trim
        txtMaPhieuNhap.Text = PhieuNhap.MaPhieu
        txtMaPhieuNhap.Tag = PhieuNhap.SoPhieu
        dtpNgayNhap.Value = PhieuNhap.NgayLap
        txtNhanVien.Text = PhieuNhap.tbNhanVien.TenNhanVien
        panelThongTin.Enabled = False
    End Sub

    Private Sub btnCapNhatLoaiBaoGia_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoaiBaoGia.Click
        cmbLoaiBaoGia.DataSource = From itm In dt.tbLoaiPhieuNhaps
                                   Order By itm.id
    End Sub

#Region "CẬP NHẬT SỐ PHIẾU"
    Private Sub btnCapNhapSoPhieu_Click(sender As Object, e As EventArgs) Handles btnCapNhapSoPhieu.Click
        txtMaPhieuNhap.Tag = LaySoPhieuHoaDonMoi()
        txtMaPhieuNhap.Text = dtpNgayNhap.Value.ToString("MMyy") + "N" + txtMaPhieuNhap.Tag.ToString.PadLeft(4, "0")
    End Sub

    Private Function LaySoPhieuHoaDonMoi() As Integer
        If dt.tbPhieuNhaps.Count = 0 Then Return 1
        Dim PhieuCuNhatTrongNgay = (From px In dt.tbPhieuNhaps
                                    Where px.NgayLap.Year = dtpNgayNhap.Value.Year
                                    Where px.NgayLap.Month = dtpNgayNhap.Value.Month
                                    Order By px.id Descending).FirstOrDefault
        If PhieuCuNhatTrongNgay Is Nothing Then
            Return 1
        Else
            Return PhieuCuNhatTrongNgay.SoPhieu + 1
        End If
    End Function


    Private Function LaySoPhieuThuNo() As Integer
        If dt.tbThuNoKhachHangs.Count = 0 Then Return 1
        Dim PhieuCuNhatTrongNgay = (From px In dt.tbThuNoKhachHangs
                                    Where px.NgayThu.Year = dtpNgayNhap.Value.Year
                                    Where px.NgayThu.Month = dtpNgayNhap.Value.Month
                                    Order By px.id Descending).FirstOrDefault
        If PhieuCuNhatTrongNgay Is Nothing Then
            Return 1
        Else
            Return PhieuCuNhatTrongNgay.SoPhieu + 1
        End If
    End Function

    Private Function LaySoPhieuDonDatHangMoi() As Integer
        If dt.tbKhachHangDatHangs.Count = 0 Then Return 1
        Dim PhieuCuNhatTrongNgay = (From px In dt.tbKhachHangDatHangs
                                    Where px.NgayLap.Year = dtpNgayNhap.Value.Year
                                    Where px.NgayLap.Month = dtpNgayNhap.Value.Month
                                    Order By px.id Descending).FirstOrDefault
        If PhieuCuNhatTrongNgay Is Nothing Then
            Return 1
        Else
            Return PhieuCuNhatTrongNgay.SoPhieu + 1
        End If
    End Function

    Private Function LaySoPhieuChi() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuChis
                            Where pn.NgayLap.Year = dtpNgayNhap.Value.Year
                            Where pn.NgayLap.Month = dtpNgayNhap.Value.Month
                            Order By pn.id Descending
                            Select pn).FirstOrDefault

        If HoaDonCuNhat Is Nothing Then
            Return 1
        Else
            Return HoaDonCuNhat.SoPhieu + 1
        End If
    End Function
    Dim iSTT = 0
    Private Sub CtrlTimKiemSanPham1_ChonSanPhamThanhCong(SanPham As tbSanPham, SoLuong As Double, TheoDonVi As Boolean) Handles CtrlTimKiemSanPham1.ChonSanPhamThanhCong
        Dim value = dt.tbSanPhams.Where(Function(s) s.idLoaiSanPham = SanPham.idLoaiSanPham).Max(Function(s) s.NgayNiemYet.Date)
        If SanPham.NgayNiemYet.Date < value Then
            ThongBao("Sản phẩm này chưa cập nhật giá niêm yết")
        End If

        Dim newChiTietBaoGia As New tbChiTietPhieuNhap
        With newChiTietBaoGia
            .DonVi = SanPham.DonVi
            If SanPham.GiaNiemYet = 0 And dt.tbChiTietPhieuNhaps.Where(Function(s) s.idSanPham = SanPham.id).Count <> 0 Then
                Dim GiaNhap = dt.tbChiTietPhieuNhaps.Where(Function(s) s.idSanPham = SanPham.id).Max(Function(s) s.id)
                .DonGia = dt.tbChiTietPhieuNhaps.First(Function(s) s.id = GiaNhap).DonGia
            Else
                .DonGia = SanPham.GiaNiemYet
            End If
            If cmbLoaiBaoGia.SelectedIndex = 0 Then
                .ChietKhau = SanPham.PhanTramNhap
            Else
                .ChietKhau = SanPham.PhanTramBan
            End If
            .NgayNiemYet = SanPham.NgayNiemYet
            .SoLuong = SoLuong
            .KhoiLuongRieng = SanPham.KhoiLuongRieng
            .idSanPham = SanPham.id
            .TonKho = SanPham.SoLuong
            .MaSanPham = SanPham.MaSanPham
            .TenSanPham = SanPham.TenSanPham
            .GiaBan = .DonGia * (100 - .ChietKhau) / 100
            .GiaBan = Math.Round(.GiaBan / 100, 0, MidpointRounding.AwayFromZero) * 100
            .iSTT = iSTT
            iSTT += 1
        End With
        For Each itm In lstChiTietPhieuNhap
            If itm.idSanPham = newChiTietBaoGia.idSanPham Then
                Exit Sub
            End If
        Next
        lstChiTietPhieuNhap.Add(newChiTietBaoGia)
        bsChiTietPhieuNhap.DataSource = From sp In lstChiTietPhieuNhap
                                        Order By sp.iSTT Descending
                                        Select sp
        txtSearch.Text = ""
        dgvMain.Focus()
        dgvMain.CurrentCell = dgvMain.Item("SoLuong", 0)
        dgvMain.BeginEdit(True)
    End Sub

    Public Sub btnDongY_Click(sender As Object, e As EventArgs) Handles btnDongY.Click
        If isSua = False Then
            Dim PhieuNhapDaTao = DongYTaoPhieu()
            If PhieuNhapDaTao IsNot Nothing Then
                ' tạo phiếu thành công
                If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tạo phiếu " + PhieuNhapDaTao.MaPhieu + " thành công." + vbNewLine + "Bạn có muốn in phiếu?", "In phiếu?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    ' hiện form in phiếu
                    Dim frm As New frmInPhieuNhap
                    frm.PhieuNhap = PhieuNhapDaTao
                    frm.TongTien = PhieuNhapDaTao.TongTien
                    frm.XemTruoc = False
                    frm.ShowDialog()
                End If
            End If
        Else
            Dim PhieuNhapDaTao = DongYSuaPhieu()
            If PhieuNhapDaTao IsNot Nothing Then
                ' tạo phiếu thành công
                If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Sửa phiếu " + PhieuNhapDaTao.MaPhieu + " thành công." + vbNewLine + "Bạn có muốn in phiếu?", "In phiếu?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    ' hiện form in phiếu
                    Dim frm As New frmInPhieuNhap
                    frm.PhieuNhap = PhieuNhapDaTao
                    frm.TongTien = PhieuNhapDaTao.TongTien
                    frm.XemTruoc = False
                    frm.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub btnCapNhatSoPhieu_Click(sender As Object, e As EventArgs)
        txtMaPhieuNhap.Tag = CapNhatSoPhieu()
        txtMaPhieuNhap.Text = dtpNgayNhap.Value.ToString("MMyy") + "N" + txtMaPhieuNhap.Tag.ToString.PadLeft(My.Settings.SoSoKhongPhieuXuatNhap, "0")
    End Sub
    Private Function CapNhatSoPhieu() As Integer
        If dt.tbPhieuNhaps.Count = 0 Then Return 1
        Dim PhieuNhapCuNhat = (From itm In dt.tbPhieuNhaps
                               Where itm.NgayLap.Year = dtpNgayNhap.Value.Year
                               Where itm.NgayLap.Month = dtpNgayNhap.Value.Month
                               Select itm Order By itm.id Descending).FirstOrDefault
        If PhieuNhapCuNhat Is Nothing Then Return 1
        Return PhieuNhapCuNhat.SoPhieu + 1
    End Function
    Dim newPhieuNhap As tbPhieuNhap
    Private Function DongYSuaPhieu() As tbPhieuNhap
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

        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xác nhận sửa phiếu " + txtMaPhieuNhap.Text.Trim, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return Nothing
        End If

        Dim LoaiPhieuNhap = CType(cmbLoaiBaoGia.SelectedItem, tbLoaiPhieuNhap)
        With SuaPhieuNhap
            .NgayLap = dtpNgayNhap.Value
            .GhiChu = txtGhiChu.Text.Trim
            .SoPhieu = txtMaPhieuNhap.Tag
            .VAT = 10
            .ChietKhau = 0
            .tbLoaiPhieuNhap = LoaiPhieuNhap

            If LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapDieuChinh Then
                ' dieu chinh kho
                .tbKhachHang = Nothing
            Else
                .tbKhachHang = CType(txtKhachHang.Tag, tbKhachHang)
            End If

            Dim rlsTruoc = From itm In lstLuuTam
                           Group By itm.idSanPham Into SoLuong = Sum(itm.SoLuongNhap)

            Dim rlsSau = From itm In lstChiTietPhieuNhap
                         Group By itm.idSanPham Into SoLuong = Sum(itm.SoLuongNhap)

            ' Cong vao kho
            For Each itm In rlsTruoc
                If rlsSau.Where(Function(s) s.idSanPham = itm.idSanPham).Count = 0 Then
                    Dim sanPham = dt.tbSanPhams.Single(Function(s) s.id = itm.idSanPham)
                    dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, sanPham)
                    With sanPham
                        .SoLuong -= itm.SoLuong
                    End With
                End If
            Next

            For Each itm In rlsSau
                Dim sanPham = dt.tbSanPhams.Single(Function(s) s.id = itm.idSanPham)
                dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, sanPham)
                If rlsTruoc.Where(Function(s) s.idSanPham = itm.idSanPham).Count = 0 Then
                    With sanPham
                        .SoLuong += itm.SoLuong
                    End With
                Else
                    Dim spTruoc = rlsTruoc.First(Function(s) s.idSanPham = itm.idSanPham)
                    With sanPham
                        .SoLuong -= (spTruoc.SoLuong - itm.SoLuong)
                    End With
                End If
            Next

            ' Xoa nhung san pham truoc do
            For Each itm In lstLuuTam
                dt.tbChiTietPhieuNhaps.DeleteOnSubmit(dt.tbChiTietPhieuNhaps.First(Function(s) s.id = itm.id))
            Next
            ' Them lai san pham cu hoac nhung san pham moi
            For Each itm In lstChiTietPhieuNhap
                itm.idPhieuNhap = SuaPhieuNhap.id
                dt.tbChiTietPhieuNhaps.InsertOnSubmit(itm)
            Next
        End With
        Try
            dt.SubmitChanges()
            Return SuaPhieuNhap
        Catch
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Sửa phiếu thất bại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            undoChange()
            Return Nothing
        End Try
    End Function
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
        If txtKhachHang.Tag Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If
        btnCapNhatSoPhieu_Click(Nothing, Nothing)
        If My.Settings.LuonXacNhanHoaDon Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xác nhận tạo phiếu " + txtMaPhieuNhap.Text.Trim, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return Nothing
            End If
        End If

        newPhieuNhap = New tbPhieuNhap
        Dim LoaiPhieuNhap = CType(cmbLoaiBaoGia.SelectedItem, tbLoaiPhieuNhap)
        With newPhieuNhap
            If LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapHangMoi Then
                .idKhachHang = CType(txtKhachHang.Tag, tbKhachHang).id
                .SoNgayNo = 0
            ElseIf LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapDieuChinh Then
                ' Nhap dieu chinh kho
                .SoNgayNo = 0
            ElseIf LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapThuHoi Then
                ' Nhap thu hoi
                .SoNgayNo = 0
                .idKhachHang = CType(txtKhachHang.Tag, tbKhachHang).id
            End If
            .idNhanVienNhanHang = cmbNhanVienNhan.SelectedItem.id
            .tbChiTietPhieuNhaps.AddRange(lstChiTietPhieuNhap)

            Dim rlsChiTiet = From itm In lstChiTietPhieuNhap
                             Group By itm.idSanPham Into SoLuong = Sum(itm.SoLuong)

            'Cộng số lượng vào kho
            For Each ChiTiet In rlsChiTiet
                Dim SanPham = dt.tbSanPhams.First(Function(s) s.id = ChiTiet.idSanPham)
                dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, SanPham)
                SanPham.SoLuong += ChiTiet.SoLuong
            Next

            ' Neu là nhap thu hồi. Thì lấy giá vốn gần nhất, de sau nay tinh doanh thu, loi nhuan
            If LoaiPhieuNhap.Loai = ELoaiPhieuNhap.NhapThuHoi Then
                For Each itm In lstChiTietPhieuNhap
                    itm.GiaVon = dt.LayGiaVonTraHang(itm.idSanPham, .idKhachHang, dtpNgayNhap.Value)
                    itm.GiaBan = dt.LayGiaBanTraHang(itm.idSanPham, .idKhachHang, dtpNgayNhap.Value, itm.TheoDonVi)
                Next
            End If
            .NgayLap = dtpNgayNhap.Value
            .idNhanVien = loginNhanVien.id
            .GhiChu = txtGhiChu.Text.Trim
            .idLoaiPhieuNhap = LoaiPhieuNhap.id
            .SoTienThanhToan = 0
            .SoPhieu = CapNhatSoPhieu()
            .VAT = nudVAT.Value
            .ChietKhau = 0
            If DonDatHang Is Nothing Then
            Else
                .idKhachHangDatHang = DonDatHang.id
            End If
            If cmbNguoiLienHe.SelectedItem IsNot Nothing Then
                .idNguoiLienHe = cmbNguoiLienHe.SelectedItem.id
            End If
            .isHoaDon = chkXuatHoaDon.Checked
        End With

        Try
            dt.tbPhieuNhaps.InsertOnSubmit(newPhieuNhap)
            dt.SubmitChanges()
            For Each itm In lstChiTietPhieuNhap
                Dim SanPham = dt.tbSanPhams.FirstOrDefault(Function(s) s.id = itm.idSanPham)
                If SanPham.isSeri Then
                    Dim frm = New frmThemSoSeri
                    frm.idPhieuNhap = newPhieuNhap.id
                    frm.SoLuong = itm.SoLuong
                    frm.idSanPham = itm.idSanPham
                    frm.Text = itm.SoLuong.ToString() + " Số seri - " + itm.TenSanPham
                    frm.ShowDialog()
                End If
            Next
            ' trả lại nguyên dạng
            lstChiTietPhieuNhap.Clear()
            bsChiTietPhieuNhap.Clear()
            btnCapNhatSoPhieu_Click(Nothing, Nothing)
            CtrlTimKiemSanPham1.CapNhatDanhSachSanPham()
            CtrlTimKiemSanPham1.txtSearch.Focus()
            txtGhiChu.Clear()
            btnTickThoiGian_Click(Nothing, Nothing)
            dtpNgayNhap.Value = Now
            txtKhachHang.Text = ""
            txtKhachHang.Tag = Nothing
            SuaPhieuBaoGia(newPhieuNhap)
            Return newPhieuNhap
        Catch
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tạo phiếu thất bại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            undoChange()
            Return Nothing
        End Try
    End Function

    Private Sub bsChiTietPhieuNhap_DataMemberChanged(sender As Object, e As EventArgs) Handles bsChiTietPhieuNhap.DataMemberChanged, bsChiTietPhieuNhap.DataMemberChanged
        bsChiTietPhieuNhap.DataSource = From sp In lstChiTietPhieuNhap Select sp
    End Sub

    Private Sub cmbLoaiBaoGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoaiBaoGia.SelectedIndexChanged
        If cmbLoaiBaoGia.SelectedIndex = 0 Then
            CtrlTimKiemSanPham1.colGiaBan.Visible = False
            CtrlTimKiemSanPham1.colGiaNhap.Visible = True
            txtKhachHang.Enabled = True
            isNhaCungCap = 1
        ElseIf cmbLoaiBaoGia.SelectedIndex = 1 Then
            txtKhachHang.Enabled = False
            CtrlTimKiemSanPham1.colGiaBan.Visible = True
            CtrlTimKiemSanPham1.colGiaNhap.Visible = False
            isNhaCungCap = 0
        Else
            txtKhachHang.Enabled = True
            CtrlTimKiemSanPham1.colGiaBan.Visible = True
            CtrlTimKiemSanPham1.colGiaNhap.Visible = False
            isNhaCungCap = 0
        End If
        txtKhachHang.Text = ""
        txtKhachHang.Tag = Nothing
        txtKhachHang.Focus()
    End Sub

    'Private Sub btnChuyenDonDatHang_Click(sender As Object, e As EventArgs)
    '    btnCapNhapSoPhieu_Click(Nothing, Nothing)
    '    If lstChiTietPhieuNhap.Count = 0 Then
    '        ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Danh sách sản phẩm rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Exit Sub
    '        'Return Nothing
    '    End If
    '    btnCapNhapSoPhieu_Click(Nothing, Nothing)
    '    If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xác nhận tạo bảng đơn đặt hàng " + txtMaPhieuNhap.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
    '        Exit Sub
    '        'Return Nothing
    '    End If
    '    Dim newBaoGia As New tbBaoGia
    '    With newBaoGia
    '        .NgayLap = dtpNgayNhap.Value
    '        .idNhanVien = loginNhanVien.id
    '        .ModeHienThi = cmbLoaiBaoGia.SelectedIndex
    '        .SoPhieu = txtMaPhieuNhap.Tag
    '        .GhiChu = txtGhiChu.Text
    '        If cmbLoaiBaoGia.SelectedIndex = 0 Then
    '            .isNhapHang = True
    '        Else
    '            .isNhapHang = False
    '        End If
    '        .idTrangThai = 2
    '        .idKhachHang = txtKhachHang.Tag.id
    '        .tbChiTietBaoGias.AddRange(lstChiTietPhieuNhap)
    '        .idLoaiBaoGia = cmbLoaiBaoGia.SelectedItem.id
    '    End With
    '    dt.tbBaoGias.InsertOnSubmit(newBaoGia)
    '    Try
    '        dt.SubmitChanges()
    '        lstChiTietPhieuNhap.Clear()
    '        bsChiTietPhieuNhap.DataSource = lstChiTietPhieuNhap
    '        btnCapNhapSoPhieu_Click(Nothing, Nothing)
    '        ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tạo đơn xác nhận đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        'Return newBaoGia
    '    Catch ex As Exception
    '        undoChange()
    '        'Return Nothing
    '    End Try
    'End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        dgvMain.EndEdit()
        Dim ChiTietBaoGia As tbChiTietPhieuNhap = bsChiTietPhieuNhap.Current
        lstChiTietPhieuNhap.Remove(ChiTietBaoGia)
        bsChiTietPhieuNhap.DataSource = From itm In lstChiTietPhieuNhap
    End Sub

    Private Sub btnXoaTatCa_Click(sender As Object, e As EventArgs) Handles btnXoaTatCa.Click
        iSTT = 0
        lstChiTietPhieuNhap.Clear()
        bsChiTietPhieuNhap.DataSource = From itm In lstChiTietPhieuNhap
    End Sub

    Private Sub dgvSanPham_CellValidating(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvSanPham.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STTcol.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
    Private Sub dgvMain_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvMain.CellValidating
        If bsChiTietPhieuNhap.Current Is Nothing Then Exit Sub
        If dgvMain.Columns(e.ColumnIndex).Name = "GiaNiemYet" Or dgvMain.Columns(e.ColumnIndex).Name = "colChietKhau" Or dgvMain.Columns(e.ColumnIndex).Name = "GiaChietKhau" Or dgvMain.Columns(e.ColumnIndex).Name = "SoLuong" Then
            dgvMain.InvalidateRow(e.RowIndex)
        End If
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
    Private Sub dgvMain_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellValueChanged
        If e.RowIndex >= 0 Then
            If dgvMain.Columns(e.ColumnIndex).Name = "colChietKhau" Or dgvMain.Columns(e.ColumnIndex).Name = "GiaNiemYet" Then
                Dim ChiTietBaoGia As tbChiTietPhieuNhap = dgvMain.Rows(e.RowIndex).DataBoundItem
                Dim S As Decimal = ChiTietBaoGia.DonGia * (100 - ChiTietBaoGia.ChietKhau) / 100
                ChiTietBaoGia.GiaBan = ChiTietBaoGia.DonGia * (100 - ChiTietBaoGia.ChietKhau) / 10000
                ChiTietBaoGia.GiaBan = Math.Round(ChiTietBaoGia.GiaBan, 0, MidpointRounding.AwayFromZero) * 100
                bsChiTietPhieuNhap_ListChanged(Nothing, Nothing)
            ElseIf dgvMain.Columns(e.ColumnIndex).Name = "GiaBan" Then
                Dim ChiTietBaoGia As tbChiTietPhieuNhap = dgvMain.Rows(e.RowIndex).DataBoundItem
                If ChiTietBaoGia.DonGia = 0 Then
                    ChiTietBaoGia.ChietKhau = 0
                    ChiTietBaoGia.DonGia = ChiTietBaoGia.GiaBan
                Else
                    ChiTietBaoGia.ChietKhau = (1 - ChiTietBaoGia.GiaBan / ChiTietBaoGia.DonGia) * 100
                End If
                bsChiTietPhieuNhap_ListChanged(Nothing, Nothing)
            End If
        End If
    End Sub
#End Region
    Sub TinhKhoiLuongRieng()
        nudKhoiLuongRieng.Value = lstChiTietPhieuNhap.Sum(Function(s) s.SoLuong * s.KhoiLuongRieng)
    End Sub
    Sub TinhTongTienVon()
        Dim TienVon As Decimal = 0
        For Each itm In lstChiTietPhieuNhap
            If itm.DonGia <> 0 Then
                Dim SP = dt.tbSanPhams.First(Function(s) s.id = itm.idSanPham)
                TienVon += SP.GiaNiemYet * (1 - SP.PhanTramNhap / 100) * itm.SoLuong
            Else
                Dim Nhap = dt.tbChiTietPhieuNhaps.Where(Function(s) s.idSanPham = itm.idSanPham).OrderBy(Function(s) s.id).ThenByDescending(Function(s) s.id).FirstOrDefault
                If Nhap IsNot Nothing Then
                    TienVon += Nhap.DonGia * itm.SoLuong
                Else
                    TienVon += itm.GiaBan * itm.SoLuong
                End If
            End If
        Next
        lblTongVon.Text = TienVon.ToString("###,###,###,##0.##đ")
        lblTongTien.Text = lstChiTietPhieuNhap.Sum(Function(s) s.ThanhTien).ToString("###,###,###,##0.##đ")
    End Sub
    Private Sub bsChiTietPhieuNhap_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietPhieuNhap.ListChanged
        lblSoDong.Text = bsChiTietPhieuNhap.Count.ToString + " sản phẩm."
        Dim Tong As Decimal = 0
        For Each itm In bsChiTietPhieuNhap
            Tong += itm.ThanhTien
        Next
        nudCongTien.Value = Math.Round(Tong)
        TinhKhoiLuongRieng()
        TinhTongTienVon()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim key = txtSearch.Text
        If txtSearch.Text = "" Then
            dgvSanPham.Visible = False
            ToolStrip4.Visible = True
            ToolStrip5.Visible = True
            dgvMain.Visible = True
        Else
            dgvSanPham.Visible = True
            ToolStrip4.Visible = False
            ToolStrip5.Visible = False
            dgvMain.Visible = False
            bsSanPham.DataSource = (From s In dt.vwSanPhams
                                    Where (s.TenSanPhamString.Contains(key))
                                    Where s.HetBan = False).Take(My.Settings.SoDongTimKiemSanPham).OrderBy(Function(s) s.MaSanPham)
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vSanPham As vwSanPham = bsSanPham.Current
            If vSanPham Is Nothing Then
                Exit Sub
            End If
            Dim sanPham As tbSanPham = dt.tbSanPhams.First(Function(s) s.id = vSanPham.id)
            CtrlTimKiemSanPham1_ChonSanPhamThanhCong(sanPham, 1, 0)
        ElseIf e.KeyCode = Keys.Down Then
            If dgvSanPham.CurrentCell.RowIndex = dgvSanPham.RowCount - 1 Then
                dgvSanPham.CurrentCell = dgvSanPham.Rows(0).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            Else
                dgvSanPham.CurrentCell = dgvSanPham.Rows(dgvSanPham.CurrentCell.RowIndex + 1).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If dgvSanPham.CurrentCell.RowIndex = 0 Then
                dgvSanPham.CurrentCell = dgvSanPham.Rows(dgvSanPham.RowCount - 1).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            Else
                dgvSanPham.CurrentCell = dgvSanPham.Rows(dgvSanPham.CurrentCell.RowIndex - 1).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            End If
        End If
    End Sub
    Dim isNhaCungCap As Boolean
    Dim reset = False
    Dim rowindex = 0
    Dim isChuyen = True
    Private Sub dgvMain_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellEndEdit
        If isChuyen = False Then
            isChuyen = True
            Exit Sub
        End If
        reset = True
        rowindex = e.RowIndex
        Dim columnIndex = dgvMain.CurrentCell.ColumnIndex
        Dim i = dgvMain.CurrentCell.RowIndex
        Try
            Dim columnName = dgvMain.Columns(columnIndex).Name
            If columnName = "GiaChietKhau" Then
                dgvMain.CurrentCell = dgvMain.Item("GhiChu", rowindex)
                dgvMain.BeginEdit(True)
            ElseIf columnName = "colChietKhau" Then
                dgvMain.CurrentCell = dgvMain.Item("GiaChietKhau", rowindex)
                dgvMain.BeginEdit(True)
            ElseIf columnName = "SoLuong" Then
                dgvMain.CurrentCell = dgvMain.Item("colChietKhau", rowindex)
                dgvMain.BeginEdit(True)
            ElseIf columnName = "GhiChu" Then
                txtSearch.Text = ""
                txtSearch.Focus()
            End If
            isChuyen = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvSanPham_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSanPham.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vSanPham As vwSanPham = bsSanPham.Current
            If vSanPham Is Nothing Then
                Exit Sub
            End If
            Dim sanPham As tbSanPham = dt.tbSanPhams.First(Function(s) s.id = vSanPham.id)
            CtrlTimKiemSanPham1_ChonSanPhamThanhCong(sanPham, 1, 0)
        End If
    End Sub

    Public Sub chkAn_Click(sender As Object, e As EventArgs) Handles chkAn.CheckedChanged
        KryptonSplitContainer1.Panel1Collapsed = chkAn.Checked
    End Sub

    Private Sub dgvSanPham_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellDoubleClick
        Dim vSanPham As vwSanPham = bsSanPham.Current
        If vSanPham Is Nothing Then
            Exit Sub
        End If
        Dim sanPham As tbSanPham = dt.tbSanPhams.First(Function(s) s.id = vSanPham.id)
        CtrlTimKiemSanPham1_ChonSanPhamThanhCong(sanPham, 1, 0)
    End Sub

    Private Sub txtGhiChu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGhiChu.KeyPress, txtKhachHang.KeyPress, cmbLoaiBaoGia.KeyPress, nudKhoiLuongRieng.KeyPress, cmbNguoiLienHe.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtKhachHang_Enter(sender As Object, e As EventArgs) Handles txtKhachHang.Enter, txtGhiChu.Enter
        CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Text = ""
    End Sub
    Dim ctrl As New ctrlDGVKhachHang
    Private Sub txtKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtKhachHang.TextChanged
        Dim key = BoDauTiengViet(txtKhachHang.Text.Trim)
        ctrl.BringToFront()
        If key <> "" Then
            ctrl.Visible = True
            ctrl.gridControl.DataSource = From itm In dt.vwKhachHangs
                                          Where itm.isNhaCungCap = isNhaCungCap Or Not itm.isNhaCungCap.HasValue
                                          Where itm.MaKhachHang.Contains(key) Or itm.TenKhachHangString.Contains(key) Or itm.MaSoThue.StartsWith(key)

            ctrl.gridViewData.RefreshData()
            If ctrl.gridViewData.DataRowCount = 0 Then
                ctrl.Visible = False
            End If
            ctrl.Size = New Size(txtKhachHang.Size.Width, 380)
        Else
            ctrl.Visible = False
        End If
    End Sub
    Sub ChonKhachHang(KhachHang As tbKhachHang)
        txtKhachHang.Tag = KhachHang
        txtKhachHang.Text = KhachHang.TenKhachHang
        cmbNguoiLienHe.DataSource = From itm In dt.tbChiTietLienHes
                                    Where itm.idKhachHang = KhachHang.id
        If cmbNguoiLienHe.Items.Count > 0 Then

        End If
    End Sub

    Private Sub txtKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKhachHang.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ctrl.gridViewData.FocusedRowHandle < 0 Then
                Exit Sub
            End If
            Dim vKhachHang As vwKhachHang = ctrl.gridViewData.GetRow(ctrl.gridViewData.FocusedRowHandle)
            Dim Khachhang As tbKhachHang = dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id)
            ChonKhachHang(Khachhang)
            ctrl.Visible = False
        ElseIf e.KeyCode = Keys.Down Then
            If ctrl.gridViewData.FocusedRowHandle = ctrl.gridViewData.DataRowCount - 1 Then
                ctrl.gridViewData.FocusedRowHandle = 0
            Else
                ctrl.gridViewData.FocusedRowHandle += 1
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If ctrl.gridViewData.FocusedRowHandle = 0 Then
                ctrl.gridViewData.FocusedRowHandle = ctrl.gridViewData.DataRowCount - 1
            Else
                ctrl.gridViewData.FocusedRowHandle -= 1
            End If
        End If
    End Sub

    Private Sub btnTickThoiGian_Click(sender As Object, e As EventArgs) Handles btnTickThoiGian.Click

    End Sub
    Private Function LaySoTraNoMoiNhat() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbTraNoNhaCungCaps
                            Where pn.NgayTra.Year = dtpNgayNhap.Value.Year
                            Where pn.NgayTra.Month = dtpNgayNhap.Value.Month
                            Order By pn.id Descending
                            Select pn).FirstOrDefault
        If HoaDonCuNhat Is Nothing Then
            Return 1
        Else
            Return HoaDonCuNhat.SoPhieu + 1
        End If
    End Function
    Private Sub btnAnHiencol_Click(sender As Object, e As EventArgs) Handles btnAnHiencol.Click
        btnAnHiencol.Checked = Not btnAnHiencol.Checked
        KhoiLuongRieng.Visible = btnAnHiencol.Checked
    End Sub

    Private Sub dgvMain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellClick
        isChuyen = False
    End Sub
    Private Sub Bamenter() Handles dgvMain.BamEnter
        isChuyen = True
    End Sub

    Private Sub cmbNguoiLienHe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNguoiLienHe.SelectedIndexChanged
        If cmbNguoiLienHe.SelectedItem IsNot Nothing Then
            txtEmail.Text = CType(cmbNguoiLienHe.SelectedItem, tbChiTietLienHe).Email
        End If
    End Sub


    Private Sub nudCongTien_ValueChanged_1(sender As Object, e As EventArgs) Handles nudCongTien.ValueChanged, nudVAT.ValueChanged
        nudTienThue.Value = nudCongTien.Value * nudVAT.Value / 100
        nudTongTien.Value = nudCongTien.Value * (1 + nudVAT.Value / 100)
    End Sub
End Class
