Public Class frmPhieuXuat
    Dim lstChiTietPhieuXuat As New List(Of tbChiTietPhieuXuat)
    Dim lstLuuTam As New List(Of tbChiTietPhieuXuat)
    Dim idKhachHangDatHang As Integer
    Dim isSua = False
    Dim ctrl As New ctrlDGVKhachHang
    Dim SuaPhieuXuat As tbPhieuXuat
    Dim idNguoiLienHe As Integer
#Region "Chọn sản phẩm"
    Public Sub ChuyenDatHangThanhPhieuXuat(KhachHangDatHang As tbKhachHangDatHang)
        btnCapNhatSoPhieu_Click(Nothing, Nothing)
        btnCapNhatLoaiPhieuXuat_Click(Nothing, Nothing)
        txtKhachHang.Tag = KhachHangDatHang.tbKhachHang
        txtKhachHang.Text = KhachHangDatHang.tbKhachHang.TenKhachHang
        txtCongTrinh.Text = KhachHangDatHang.CongTrinh
        txtGhiChu.Text = KhachHangDatHang.GhiChu
        idKhachHangDatHang = KhachHangDatHang.id
        If KhachHangDatHang.idNguoiLienHe IsNot Nothing Then
            idNguoiLienHe = KhachHangDatHang.idNguoiLienHe
        End If

        For Each itm In dt.SanPhamChuaXuatKho(KhachHangDatHang.id).OrderBy(Function(s) s.STT)
            Dim SanPham = dt.tbSanPhams.Single(Function(s) s.id = itm.idSanPham)
            If itm.SoLuongConLai = 0 Then
                Continue For
            ElseIf SanPham.SoLuong <= 0 Then
                Continue For
            End If
            Dim newChiTietPhieuXuat As New tbChiTietPhieuXuat
            With newChiTietPhieuXuat
                .idSanPham = itm.idSanPham
                .TenSanPham = itm.TenSanPham
                .DonVi = itm.DonVi
                .MaSanPham = itm.MaSanPham
                .SoLuong = itm.SoLuong
                .TonKho = SanPham.SoLuong
                .KhoiLuongRieng = SanPham.KhoiLuongRieng
                .DonGia = itm.DonGia
                .NgayNiemYet = itm.NgayNiemYet
                .GiaBan = itm.GiaBan
                .ChietKhau = itm.ChietKhau
                .TheoDonVi = True
                .SoLuongXuat = If(SanPham.SoLuong > itm.SoLuongConLai, itm.SoLuongConLai, SanPham.SoLuong)
                .QuyCach = 1
                .GhiChu = itm.GhiChu
            End With
            lstChiTietPhieuXuat.Add(newChiTietPhieuXuat)
        Next
        If lstChiTietPhieuXuat.Count = 0 Then
            Me.Close()
            ThongBao("Không thể xuất vì danh sách sản phẩm chưa sẵn sàng")
        End If
        bsChiTietPhieuXuat.DataSource = From itm In lstChiTietPhieuXuat
    End Sub
    Private Sub CtrlTimKiemSanPham1_ChonSanPhamThanhCong(SanPham As tbSanPham, SoLuong As Double, TheoDonVi As Boolean)
        Dim newChiTietXuatNhap As New tbChiTietPhieuXuat
        With newChiTietXuatNhap
            .idSanPham = SanPham.id
            .TheoDonVi = TheoDonVi
            .QuyCach = SanPham.QuyCach
            .SoLuong = SoLuong
            .MaSanPham = SanPham.MaSanPham
            .TenSanPham = SanPham.TenSanPham
            If TheoDonVi Then
                .DonVi = SanPham.DonVi
                .DonGia = SanPham.GiaNiemYet
            Else
                .DonVi = SanPham.DonViQuyCach
                .DonGia = SanPham.GiaNhapQuyCach
            End If

            If isNhaCungCap = True Then
                If txtKhachHang.Tag IsNot Nothing Then
                    Dim ncc As tbKhachHang = txtKhachHang.Tag
                    .DonGia = dt.LayDonGiaNhapSanPham(SanPham.id, ncc.id, dtpNgayLap.Value, TheoDonVi)
                End If
            End If
        End With
        dgvSanPham.Visible = False
        txtSearch.Text = ""
        lstChiTietPhieuXuat.Add(newChiTietXuatNhap)
        bsChiTietPhieuXuat.DataSource = From sp In lstChiTietPhieuXuat Select sp
        bsChiTietPhieuXuat.MoveLast()
        Dim rowindex = dgvMain.CurrentCell.RowIndex
        dgvMain.Focus()
        dgvMain.CurrentCell = dgvMain.Item("SoLuongXuat", rowindex)
        dgvMain.BeginEdit(True)
    End Sub
#End Region
    Sub CapNhatPhieuXuat(PhieuXuat As tbPhieuXuat, ChiTietPhieuXuat As List(Of tbChiTietPhieuXuat))
        For Each itm In ChiTietPhieuXuat
            Dim ChiTiet As New tbChiTietPhieuXuat
            With ChiTiet
                .idSanPham = itm.idSanPham
                .SoLuong = itm.SoLuong
                .DonGia = itm.DonGia
                .TenSanPham = itm.TenSanPham
                .TonKho = itm.TonKho
                .MaSanPham = itm.MaSanPham
                .ChietKhau = itm.ChietKhau
                .DonVi = itm.DonVi
                .GiaBan = itm.GiaBan
                .TheoDonVi = True
                .GhiChu = itm.GhiChu
                .QuyCach = 1
                .SoLuongXuat = .SoLuong
            End With
            lstChiTietPhieuXuat.Add(ChiTiet)
        Next
        bsChiTietPhieuXuat.DataSource = From itm In lstChiTietPhieuXuat
        PhieuXuat.tbChiTietPhieuXuats.AddRange(lstChiTietPhieuXuat)
        btnCapNhatSoPhieu_Click(Nothing, Nothing)
        PhieuXuat.SoPhieuXuat = txtMaPhieuXuat.Tag
        txtCongTrinh.Text = PhieuXuat.TenCongTrinh
        btnCapNhatLoaiPhieuXuat_Click(Nothing, Nothing)
        cmbLoaiPhieuXuat.SelectedItem = (From itm In dt.tbLoaiPhieuXuats Where itm.id = PhieuXuat.idLoaiPhieuXuat).FirstOrDefault
        ChonKhachHang((From itm In dt.tbKhachHangs
                       Where itm.id = PhieuXuat.idKhachHang).Single)
        nudHanThanhToan.Value = (From itm In dt.tbKhachHangs
                                 Where itm.id = PhieuXuat.idKhachHang).Single.NgayTraNo
        cmbLoaiPhieuXuat.Enabled = False
        idKhachHangDatHang = PhieuXuat.idKhachHangDatHang
    End Sub
    Sub CapNhatPhieuXuat(PhieuXuat As tbPhieuXuat)
        isSua = True
        SuaPhieuXuat = PhieuXuat
        lstChiTietPhieuXuat = (From itm In dt.tbChiTietPhieuXuats Where itm.idPhieuXuat = PhieuXuat.id).ToList
        ' Lưu tạm lại danh sách sản phẩm ban đầu để so sánh khi có thay đổi
        For Each itm In lstChiTietPhieuXuat
            Dim ChiTiet As New tbChiTietPhieuXuat
            With ChiTiet
                .id = itm.id
                .idPhieuXuat = itm.idPhieuXuat
                .idSanPham = itm.idSanPham
                .SoLuong = itm.SoLuong
                .TheoDonVi = itm.TheoDonVi
                .QuyCach = itm.QuyCach
                .DonGia = itm.DonGia
                .GhiChu = itm.GhiChu
                .MaSanPham = itm.MaSanPham
                .TenSanPham = itm.TenSanPham
                .DonVi = itm.DonVi
                .SoLuongXuat = itm.SoLuong
                .GiaBan = itm.GiaBan
            End With
            itm.SoLuongXuat = itm.SoLuong
            lstLuuTam.Add(ChiTiet)
        Next
        bsChiTietPhieuXuat.DataSource = From itm In lstChiTietPhieuXuat
        PhieuXuat.tbChiTietPhieuXuats.AddRange(lstChiTietPhieuXuat)
        btnCapNhatSoPhieu_Click(Nothing, Nothing)
        PhieuXuat.SoPhieuXuat = txtMaPhieuXuat.Tag
        txtCongTrinh.Text = PhieuXuat.TenCongTrinh
        btnCapNhatLoaiPhieuXuat_Click(Nothing, Nothing)
        cmbLoaiPhieuXuat.SelectedItem = (From itm In dt.tbLoaiPhieuXuats Where itm.id = PhieuXuat.idLoaiPhieuXuat).FirstOrDefault
        ChonKhachHang((From itm In dt.tbKhachHangs
                       Where itm.id = PhieuXuat.idKhachHang).Single)
        nudHanThanhToan.Value = (From itm In dt.tbKhachHangs
                                 Where itm.id = PhieuXuat.idKhachHang).Single.NgayTraNo
        cmbLoaiPhieuXuat.Enabled = False
        idKhachHangDatHang = PhieuXuat.idKhachHangDatHang
    End Sub
    Sub ChonKhachHang(KhachHang As tbKhachHang)
        txtKhachHang.Text = KhachHang.TenKhachHang
        txtKhachHang.Tag = KhachHang
    End Sub
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
    Private Sub txtKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtKhachHang.TextChanged
        Dim key = BoDauTiengViet(txtKhachHang.Text.Trim)
        ctrl.BringToFront()
        If key <> "" Then
            ctrl.Visible = True
            ctrl.bsKhachHang.DataSource = From itm In dt.vwKhachHangs
                                          Where itm.isNhaCungCap = isNhaCungCap Or Not itm.isNhaCungCap.HasValue
                                          Where itm.MaKhachHang.Contains(key) Or itm.TenKhachHangString.Contains(key) Or itm.MaSoThue.StartsWith(key)
            If ctrl.bsKhachHang.Count = 0 Then
                ctrl.Visible = False
            End If
            ctrl.Size = New Size(txtKhachHang.Size.Width, 380)
        Else
            ctrl.Visible = False
        End If
    End Sub
#Region "CẬP NHẬT SỐ PHIẾU"
    Private Sub btnCapNhatSoPhieu_Click(sender As Object, e As EventArgs) Handles btnCapNhatSoPhieu.Click
        txtMaPhieuXuat.Tag = CapNhatSoPhieu()
        txtMaPhieuXuat.Text = dtpNgayLap.Value.ToString("MMyy") + "X" + txtMaPhieuXuat.Tag.ToString.PadLeft(4, "0")
    End Sub

    Private Function CapNhatSoPhieu() As Integer
        If dt.tbPhieuXuats.Count = 0 Then Return 1
        Dim PhieuNhapCuNhat = (From itm In dt.tbPhieuXuats
                               Where itm.NgayLap.Year = dtpNgayLap.Value.Year
                               Where itm.NgayLap.Month = dtpNgayLap.Value.Month
                               Select itm Order By itm.id Descending).FirstOrDefault
        If PhieuNhapCuNhat Is Nothing Then Return 1
        Return PhieuNhapCuNhat.SoPhieuXuat + 1
    End Function


    Private Function LaySoPhieuTraNo() As Integer
        If dt.tbTraNoNhaCungCaps.Count = 0 Then Return 1
        Dim PhieuCuNhatTrongNgay = (From px In dt.tbTraNoNhaCungCaps
                                    Where px.NgayTra.Year = dtpNgayLap.Value.Year
                                    Where px.NgayTra.Month = dtpNgayLap.Value.Month
                                    Order By px.id Descending).FirstOrDefault
        If PhieuCuNhatTrongNgay Is Nothing Then
            Return 1
        Else
            Return PhieuCuNhatTrongNgay.SoPhieu + 1
        End If
    End Function

    Private Function LaySoPhieuThu() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuThus
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
    Private Sub btnTangSanPham_Click(sender As Object, e As EventArgs)
        If bsChiTietPhieuXuat.Current Is Nothing Then Exit Sub
        Dim ChiTiet As tbChiTietPhieuXuat = bsChiTietPhieuXuat.Current
        ChiTiet.SoLuong += 1
    End Sub

    Private Sub btnGiamSanPham_Click(sender As Object, e As EventArgs)
        If bsChiTietPhieuXuat.Current Is Nothing Then Exit Sub
        Dim ChiTiet As tbChiTietPhieuXuat = bsChiTietPhieuXuat.Current
        ChiTiet.SoLuong -= 1
        If ChiTiet.SoLuong = 0 Then
            lstChiTietPhieuXuat.Remove(bsChiTietPhieuXuat.Current)
            bsChiTietPhieuXuat.RemoveCurrent()
        End If
    End Sub

    Private Sub btnXoaSanPham_Click(sender As Object, e As EventArgs)
        If bsChiTietPhieuXuat.Current Is Nothing Then Exit Sub
        lstChiTietPhieuXuat.Remove(bsChiTietPhieuXuat.Current)
        bsChiTietPhieuXuat.RemoveCurrent()
    End Sub

    Private Sub btnXoaTatCa_Click(sender As Object, e As EventArgs)
        lstChiTietPhieuXuat.Clear()
        bsChiTietPhieuXuat.DataSource = From itm In lstChiTietPhieuXuat Select itm
    End Sub
#End Region

#Region "ĐỒNG Ý TẠO PHIẾU NHẬP XUẤT"
    Public Sub btnDongYVaIn_Click(sender As Object, e As EventArgs)
        Dim PhieuXuatDaTao = DongYTaoPhieu()
        If PhieuXuatDaTao IsNot Nothing Then
            ' in trực tiếp phiếu ra
            mdlGlobals.InPhieuXuat(PhieuXuatDaTao, PhieuXuatDaTao.TongTien)
        End If
    End Sub

    Public Sub btnDongY_Click(sender As Object, e As EventArgs) Handles btnDongY.Click
        Dim PhieuXuatDaTao = DongYTaoPhieu()
        If PhieuXuatDaTao IsNot Nothing Then
            ' tạo phiếu thành công
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tạo phiếu " + PhieuXuatDaTao.MaPhieu + " thành công." + vbNewLine + "Bạn có muốn in phiếu?", "In phiếu?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ' hiện form in phiếu
                Dim frm As New frmInPhieuXuat
                frm.PhieuXuat = PhieuXuatDaTao
                frm.TongTien = PhieuXuatDaTao.TongTien
                frm.XemTruoc = False
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Function DongYSuaPhieu() As tbPhieuXuat
        bsChiTietPhieuXuat.EndEdit()
        dgvMain.EndEdit()

        If lstChiTietPhieuXuat.Count = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Danh sách sản phẩm xuất trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If

        If txtMaPhieuXuat.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Chưa có số phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If
        btnCapNhatSoPhieu_Click(Nothing, Nothing)
        If My.Settings.LuonXacNhanHoaDon Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xác nhận tạo phiếu " + txtMaPhieuXuat.Text.Trim, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return Nothing
            End If
        End If
        Dim LoaiPhieuXuat = CType(cmbLoaiPhieuXuat.SelectedItem, tbLoaiPhieuXuat)
        With SuaPhieuXuat
            .SoPhieuXuat = txtMaPhieuXuat.Tag
            .NgayLap = dtpNgayLap.Value
            .GhiChu = txtGhiChu.Text.Trim
            .tbLoaiPhieuXuat = LoaiPhieuXuat
            If LoaiPhieuXuat.Loai = 1 Then
                .tbKhachHang = CType(txtKhachHang.Tag, tbKhachHang)
            Else
                .tbKhachHang = Nothing
            End If

            Dim rlsTruoc = From itm In lstLuuTam
                           Group By itm.idSanPham Into SoLuong = Sum(itm.SoLuongXuat)

            Dim rlsSau = From itm In lstChiTietPhieuXuat
                         Group By itm.idSanPham Into SoLuong = Sum(itm.SoLuongXuat)

            ' Cong vao kho
            For Each itm In rlsTruoc
                If rlsSau.Where(Function(s) s.idSanPham = itm.idSanPham).Count = 0 Then
                    Dim sanPham = dt.tbSanPhams.Single(Function(s) s.id = itm.idSanPham)
                    dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, sanPham)
                    With sanPham
                        .SoLuong += itm.SoLuong
                    End With
                End If
            Next

            For Each itm In rlsSau
                Dim sanPham = dt.tbSanPhams.Single(Function(s) s.id = itm.idSanPham)
                dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, sanPham)
                If rlsTruoc.Where(Function(s) s.idSanPham = itm.idSanPham).Count = 0 Then
                    With sanPham
                        .SoLuong -= itm.SoLuong
                    End With
                Else
                    Dim spTruoc = rlsTruoc.First(Function(s) s.idSanPham = itm.idSanPham)
                    With sanPham
                        .SoLuong += (spTruoc.SoLuong - itm.SoLuong)
                    End With
                End If
            Next

            ' Xoa nhung san pham truoc do
            For Each itm In lstLuuTam
                dt.tbChiTietPhieuXuats.DeleteOnSubmit(dt.tbChiTietPhieuXuats.First(Function(s) s.id = itm.id))
            Next

            ' Them lai san pham cu hoac nhung san pham moi
            For Each itm In lstChiTietPhieuXuat
                itm.idPhieuXuat = SuaPhieuXuat.id
                dt.tbChiTietPhieuXuats.InsertOnSubmit(itm)
            Next
        End With
        Try
            dt.SubmitChanges()
            Return newPhieuXuat
            KryptonSplitContainer1.Enabled = False
        Catch
            undoChange()
            ThongBao("Sửa phiếu thất bại")
            Return Nothing
        End Try
    End Function
    Dim newPhieuXuat As tbPhieuXuat
    Private Function DongYTaoPhieu() As tbPhieuXuat
        bsChiTietPhieuXuat.EndEdit()
        dgvMain.EndEdit()

        If lstChiTietPhieuXuat.Count = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Danh sách sản phẩm xuất trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If

        If txtMaPhieuXuat.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Chưa có số phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If

        btnCapNhatSoPhieu_Click(Nothing, Nothing)
        If My.Settings.LuonXacNhanHoaDon Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xác nhận tạo phiếu " + txtMaPhieuXuat.Text.Trim, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return Nothing
            End If
        End If

        newPhieuXuat = New tbPhieuXuat
        Dim LoaiPhieuXuat = CType(cmbLoaiPhieuXuat.SelectedItem, tbLoaiPhieuXuat)
        With newPhieuXuat
            .SoPhieuXuat = txtMaPhieuXuat.Tag
            .NgayLap = dtpNgayLap.Value
            .idNhanVien = loginNhanVien.id
            .idLoaiPhieuXuat = LoaiPhieuXuat.id
            .HanThanhToan = dtpNgayLap.Value.AddDays(nudHanThanhToan.Value)
            .isThanhToan = False
            .GhiChu = txtGhiChu.Text.Trim
            .TenCongTrinh = txtCongTrinh.Text.Trim
            .VAT = nudVAT.Value
            .idKhachHangDatHang = idKhachHangDatHang
            If idNguoiLienHe <> 0 Then
                .idNguoiLienHe = idNguoiLienHe
            End If
            If LoaiPhieuXuat.Loai = 3 Then
                ' Xuất 3
                .idKhachHang = CType(txtKhachHang.Tag, tbKhachHang).id
            End If

            For Each itm In lstChiTietPhieuXuat
                If itm.SoLuongXuat > 0 Then
                    itm.SoLuong = itm.SoLuongXuat
                Else
                    lstChiTietPhieuXuat.Remove(itm)
                End If
            Next
            .tbChiTietPhieuXuats.AddRange(lstChiTietPhieuXuat)

            'Xuất kho
            Dim lstSanPhamKhongDuSoLuong As New List(Of clsSanPhamKhongDuSoLuong)
            ' Trừ kho
            Dim rlsTruoc = From itm In lstChiTietPhieuXuat
                           Group By itm.idSanPham Into SoLuong = Sum(itm.SoLuongXuat)

            For Each ChiTiet In rlsTruoc
                Dim SanPham = dt.tbSanPhams.First(Function(s) s.id = ChiTiet.idSanPham)
                dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, SanPham)
                SanPham.SoLuong -= ChiTiet.SoLuong
                If SanPham.SoLuong < 0 Then
                    lstSanPhamKhongDuSoLuong.Add(New clsSanPhamKhongDuSoLuong(SanPham.TenSanPham, SanPham.MaSanPham, SanPham.SoLuong + ChiTiet.SoLuong, ChiTiet.SoLuong, SanPham.SoLuong))
                End If
            Next

            ' Xác nhận những sản phẩm không du so luong xuat
            If lstSanPhamKhongDuSoLuong.Count > 0 Then
                Dim frm As New frmXacNhanKhongDuSoLuongXuat
                frm.bsSanPhamKhongDuSoLuongXuat.DataSource = From sp In lstSanPhamKhongDuSoLuong Select sp
                If frm.ShowDialog <> DialogResult.OK Then
                    undoChange()
                    Return Nothing
                End If
            End If
        End With
        Try
            newPhieuXuat.SoPhieuXuat = CapNhatSoPhieu()
            dt.tbPhieuXuats.InsertOnSubmit(newPhieuXuat)
            dt.SubmitChanges()
            'For Each itm In lstChiTietPhieuXuat
            '    If itm.tbSanPham.isSeri Then
            '        Dim frm As New frmDanhSachSoSeri
            '        frm.Text = "Chọn số seri xuất hàng"
            '        frm.ChiTietPhieuXuat = itm
            '        frm.ShowDialog()
            '    End If
            'Next
            ' trả lại nguyên dạng
            btnDongY.Enabled = False
            Return newPhieuXuat
        Catch ex As Exception
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tạo phiếu thất bại. Vui lòng thử lại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            undoChange()
            Return Nothing
        End Try
    End Function

    Public Sub btnXemTruoc_Click(sender As Object, e As EventArgs) Handles btnXemTruoc.Click
        bsChiTietPhieuXuat.EndEdit()
        dgvMain.EndEdit()

        If lstChiTietPhieuXuat.Count = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Danh sách sản phẩm xuất trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If bsChiTietPhieuXuat.Count > 0 Then
            Dim frm As New frmInPhieuXuat
            Dim PhieuXuat As New tbPhieuXuat
            Dim LoaiPhieuXuat = CType(cmbLoaiPhieuXuat.SelectedItem, tbLoaiPhieuXuat)
            With PhieuXuat
                .SoPhieuXuat = txtMaPhieuXuat.Tag
                .NgayLap = dtpNgayLap.Value
                .idNhanVien = loginNhanVien.id
                .idLoaiPhieuXuat = LoaiPhieuXuat.id
                .GhiChu = txtGhiChu.Text.Trim
                If LoaiPhieuXuat.Loai = 1 Then
                    .tbKhachHang = CType(txtKhachHang.Tag, tbKhachHang)
                Else
                    .tbKhachHang = Nothing
                End If
                .TongTien = nudCongTien.Value
            End With
            frm.PhieuXuat = PhieuXuat
            frm.bsData = bsChiTietPhieuXuat
            frm.TongTien = nudCongTien.Value
            frm.XemTruoc = True
            frm.ShowDialog()
            undoChange()
        End If
    End Sub
#End Region

    Private Sub bsChiTietPhieuXuat_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietPhieuXuat.ListChanged
        lblSoLuong.Text = bsChiTietPhieuXuat.Count.ToString + " sản phẩm."
        Dim Tong As Decimal = 0
        For Each itm In bsChiTietPhieuXuat
            Tong += itm.ThanhTien
        Next
        nudCongTien.Value = Math.Round(Tong)
    End Sub

    Private Sub dgvChiTietPhieuXuat_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
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

    Private Sub ctrlPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height + ToolStrip1.Size.Height)
        ctrl.ToolStrip1.Visible = False
        Me.Controls.Add(ctrl)
        'btnCapNhatSoPhieu_Click(Nothing, Nothing)
        'btnCapNhatLoaiPhieuXuat_Click(Nothing, Nothing)
        'btnCapNhatNhaCungCap_Click(Nothing, Nothing)
        'cmbLoaiPhieuXuat_SelectedIndexChanged(Nothing, Nothing)
    End Sub
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgvSanPham.Visible = False Then
                Exit Sub
            End If
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
            ElseIf columnName = "SoLuongXuat" Then
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

    Private Sub cmbLoaiPhieuXuat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoaiPhieuXuat.SelectedIndexChanged
        If cmbLoaiPhieuXuat.SelectedItem Is Nothing Then Exit Sub
        Dim LoaiPhieuXuat = CType(cmbLoaiPhieuXuat.SelectedItem, tbLoaiPhieuXuat)
        If LoaiPhieuXuat.Loai = 1 Then ' Xuat tra nha cung cap
            isNhaCungCap = True
        Else ' Xuat dieu chinh
            isNhaCungCap = False
        End If
    End Sub

    Private Sub btnCapNhatLoaiPhieuXuat_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoaiPhieuXuat.Click
        cmbLoaiPhieuXuat.DataSource = From itm In dt.tbLoaiPhieuXuats Select itm
                                      Where itm.Loai = 3
    End Sub

    Private Sub dgvMain_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvMain.CellValidating
        If bsChiTietPhieuXuat.Current Is Nothing Then Exit Sub
        If dgvMain.Columns(e.ColumnIndex).Name = "DonGia" Or dgvMain.Columns(e.ColumnIndex).Name = "SoLuongXuat" Or dgvMain.Columns(e.ColumnIndex).Name = "colChietKhau" Then
            dgvMain.InvalidateRow(e.RowIndex)
        End If
    End Sub
    Private Sub dgvMain_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellValueChanged
        If e.RowIndex >= 0 Then
            If dgvMain.Columns(e.ColumnIndex).Name = "colChietKhau" Then
                Dim ChiTietBaoGia As tbChiTietPhieuXuat = dgvMain.Rows(e.RowIndex).DataBoundItem
                ChiTietBaoGia.GiaBan = ChiTietBaoGia.DonGia * (100 - ChiTietBaoGia.ChietKhau) / 100
            ElseIf dgvMain.Columns(e.ColumnIndex).Name = "GiaChietKhau" Then
                Dim ChiTietBaoGia As tbChiTietPhieuXuat = dgvMain.Rows(e.RowIndex).DataBoundItem
                If ChiTietBaoGia.GiaBan = 0 Then
                    ChiTietBaoGia.ChietKhau = 100
                Else
                    ChiTietBaoGia.ChietKhau = (1 - ChiTietBaoGia.DonGia / ChiTietBaoGia.GiaBan) * 100
                End If
            End If
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim key = txtSearch.Text
        If txtSearch.Text = "" Then
            dgvSanPham.Visible = False
            ToolStrip1.Visible = True
            ToolStrip3.Visible = True
            dgvMain.Visible = True
        Else
            dgvSanPham.Visible = True
            ToolStrip1.Visible = False
            ToolStrip3.Visible = False
            dgvMain.Visible = False
            bsSanPham.DataSource = (From s In dt.vwSanPhams
                                    Where (s.TenSanPhamString.Contains(key))
                                    Where s.HetBan = False).Take(My.Settings.SoDongTimKiemSanPham).OrderBy(Function(s) s.MaSanPham)
        End If
    End Sub

    Private Sub dgvMain_BamEnter() Handles dgvMain.BamEnter
        isChuyen = True
    End Sub

    Private Sub nudTongTien_ValueChanged(sender As Object, e As EventArgs) Handles nudCongTien.ValueChanged, nudVAT.ValueChanged
        nudTienVAT.Value = nudCongTien.Value * nudVAT.Value / 100
        nudTongTien.Value = nudTienVAT.Value + nudCongTien.Value
    End Sub

    Private Sub frmPhieuXuat_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            If btnDongY.Visible = False Then Exit Sub
            btnDongY_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            undoChange()
            Me.Close()
        End If
    End Sub
End Class