Public Class ctrlBangBaoGia
    Public lstChiTietBaoGia As New List(Of tbChiTietBaoGia)
    Dim lstLuuTam As New List(Of tbChiTietBaoGia)
    Dim isSua As Boolean = False
    Public BaoGia As tbBaoGia
    Dim _isNhapHang As Boolean = False
    Property isNhapHang As Boolean
        Get
            Return _isNhapHang
        End Get
        Set(value As Boolean)
            _isNhapHang = value
            If _isNhapHang Then ' Nhập
                CtrlTimKiemSanPham1.colGiaBan.Visible = False
                CtrlTimKiemSanPham1.colGiaNhap.Visible = True
                'btnCapNhatNhaCungCap_Click(Nothing, Nothing)
                isNhaCungCap = 1
                lblSoLuongSanSang.Visible = False
                nudGiaVon.Visible = False
                nudTienVon.Visible = False
                lblGiaVon.Visible = False
                lblTienVon.Visible = False
                lblKhachHang.Text = "Nhà cung cấp"
                lblNhanVien.Text = "Nhân viên đề nghị"
            Else 'Bán
                CtrlTimKiemSanPham1.colGiaBan.Visible = True
                CtrlTimKiemSanPham1.colGiaNhap.Visible = False
                isNhaCungCap = 0
                'btnCapNhatKhachHang_Click(Nothing, Nothing)
                lblSoLuongSanSang.Visible = True
                If loginNhanVien.CapBat = 3 Then
                    nudGiaVon.Visible = True
                    nudTienVon.Visible = True
                    lblGiaVon.Visible = True
                    lblTienVon.Visible = True
                End If
            End If
        End Set
    End Property
    Private Sub ctrlBangBaoGiaMoi_Load(sender As Object, e As EventArgs) Handles Me.Load
        If isSua = False Then
            btnCapNhapSoPhieu_Click(Nothing, Nothing)
            btnCapNhatLoaiBaoGia_Click(Nothing, Nothing)
            txtNhanVien.Text = loginNhanVien.TenNhanVien
            cmbLoaiBaoGia.SelectedIndex = 1
        End If
        'cmbLoaiBaoGia.DataSource = From itm In dt.tbLoaiBaoGias
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height + ToolStrip1.Size.Height)
        Me.Controls.Add(ctrl)
        If lstChiTietBaoGia.Count > 0 Then
            bsChiTietBaoGia.DataSource = From itm In lstChiTietBaoGia
            cmbLoaiBaoGia.SelectedIndex = 0
        End If
        If loginNhanVien.CapBat <> 3 Then
            nudGiaVon.Visible = False
            nudTienVon.Visible = False
            lblGiaVon.Visible = False
            lblTienVon.Visible = False
        End If
        txtKhachHang.Text = ""
        txtKhachHang.Tag = Nothing
        txtKhachHang.Focus()
        cmbNguoiLienHe.SelectedItem = Nothing
    End Sub
    Public Sub SuaPhieuBaoGia(BaoGia As tbBaoGia)
        isSua = True
        Dim rls = (From itm In dt.tbChiTietBaoGias Where itm.idBaoGia = BaoGia.id)
        lstChiTietBaoGia = rls.ToList
        For Each itm In lstChiTietBaoGia
            itm.iSTT = iSTT
            iSTT += 1
        Next
        For Each itm In lstChiTietBaoGia
            Dim S As Decimal = itm.GiaNiemYet * (100 - itm.ChietKhau) / 10000
            itm.DonGia = Math.Round(S, 0, MidpointRounding.AwayFromZero) * 100
        Next
        'Lưu lại file tạm
        For Each itm In rls
            Dim ChiTiet As New tbChiTietBaoGia
            With ChiTiet
                .id = itm.id
                .idSanPham = itm.idSanPham
                .DonGia = itm.DonGia
                .GhiChu = itm.GhiChu
                .idBaoGia = itm.idBaoGia
                .SoLuong = itm.SoLuong
                .ChietKhau = itm.ChietKhau
                .NgayNiemYet = itm.NgayNiemYet
            End With
            lstLuuTam.Add(ChiTiet)
        Next
        cmbLoaiBaoGia.DataSource = (From itm In dt.tbLoaiBaoGias Where itm.id = BaoGia.idLoaiBaoGia)
        ChonKhachHang(BaoGia.tbKhachHang)
        cmbNguoiLienHe.DataSource = From itm In dt.tbChiTietLienHes
                                    Where itm.id = BaoGia.idNguoiLienHe
        bsChiTietBaoGia.DataSource = From itm In lstChiTietBaoGia
                                     Order By itm.iSTT Descending
        txtGhiChu.Text = BaoGia.GhiChu.Trim
        txtSoPhieuNhap.Text = BaoGia.MaPhieu
        txtSoPhieuNhap.Tag = BaoGia.SoPhieu
        dtpNgayNhap.Value = BaoGia.NgayLap
        txtNhanVien.Text = BaoGia.tbNhanVien.TenNhanVien
        panelThongTin.Enabled = False
    End Sub
    Public Sub F4_MoTheKho()
        If bsChiTietBaoGia.Count = 0 Or bsChiTietBaoGia.Current Is Nothing Then Exit Sub
        Dim ChiTietBaoGia As tbChiTietBaoGia = bsChiTietBaoGia.Current
        Dim frm As New frmChiTietTonKho
        frm.TuNgay = Now.AddDays(-30)
        frm.DenNgay = Now
        frm.TheoNgay = True
        frm.idSanPham = ChiTietBaoGia.idSanPham
        frm.Text = "THẺ KHO - " + ChiTietBaoGia.TenSanPham
        frm.ShowDialog()
    End Sub
    Private Sub btnCapNhatLoaiBaoGia_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoaiBaoGia.Click
        cmbLoaiBaoGia.DataSource = From itm In dt.tbLoaiBaoGias
                                   Order By itm.id
    End Sub

#Region "CẬP NHẬT SỐ PHIẾU"
    Private Sub btnCapNhapSoPhieu_Click(sender As Object, e As EventArgs) Handles btnCapNhapSoPhieu.Click
        txtSoPhieuNhap.Tag = LaySoPhieuHoaDonMoi()
        If isNhapHang Then
            txtSoPhieuNhap.Text = dtpNgayNhap.Value.ToString("MMyy") + "ĐNBG" + txtSoPhieuNhap.Tag.ToString.PadLeft(4, "0")
        Else
            txtSoPhieuNhap.Text = dtpNgayNhap.Value.ToString("MMyy") + "B" + txtSoPhieuNhap.Tag.ToString.PadLeft(4, "0")
        End If

    End Sub

    Private Function LaySoPhieuHoaDonMoi() As Integer
        If dt.tbBaoGias.Count = 0 Then Return 1
        Dim PhieuCuNhatTrongNgay = (From px In dt.tbBaoGias
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
    Public Sub CtrlTimKiemSanPham1_ChonSanPhamThanhCong(SanPham As tbSanPham, SoLuong As Double, TheoDonVi As Boolean) Handles CtrlTimKiemSanPham1.ChonSanPhamThanhCong
        If txtKhachHang.Tag Is Nothing Then
        End If
        Dim value = dt.tbSanPhams.Where(Function(s) s.idLoaiSanPham = SanPham.idLoaiSanPham).Max(Function(s) s.NgayNiemYet.Date)
        If SanPham.NgayNiemYet.Date < value Then
            ThongBao("Sản phẩm này chưa cập nhật giá niêm yết")
        End If
        Dim idKhachHang = 0
        If txtKhachHang.Tag IsNot Nothing Then
            idKhachHang = CType(txtKhachHang.Tag, tbKhachHang).id
        End If
        Dim Loai = 1
        Dim ChiTietBaoGia As vwChiTietBaoGia = (From itm In dt.vwChiTietBaoGias
                                                Where itm.idSanPham = SanPham.id
                                                Where itm.idKhachHang = idKhachHang
                                                Where itm.Loai = Loai
                                                Order By itm.id Descending).FirstOrDefault
        Dim spChiecKhau As Double = -1
        Dim spGia As Double = -1
        If isNhapHang Then
            Dim ChiTietPhieuNhap = dt.vwChiTietPhieuNhaps.Where(Function(s) s.idSanPham = SanPham.id And s.idKhachHang = idKhachHang).OrderByDescending(Function(S) S.id).FirstOrDefault
            If ChiTietPhieuNhap IsNot Nothing Then
                If ChiTietPhieuNhap.NgayNiemYet = SanPham.NgayNiemYet Then
                    spChiecKhau = ChiTietPhieuNhap.ChietKhau
                    spGia = ChiTietPhieuNhap.GiaBan
                End If
            End If
        Else
            Dim ChiTietPhieuXuat = dt.vwChiTietPhieuXuats.Where(Function(s) s.idSanPham = SanPham.id And s.idKhachHang = idKhachHang).OrderByDescending(Function(S) S.id).FirstOrDefault
            If ChiTietPhieuXuat IsNot Nothing Then
                If ChiTietPhieuXuat.NgayNiemYet = SanPham.NgayNiemYet Then
                    spChiecKhau = ChiTietPhieuXuat.ChietKhau
                    spGia = ChiTietPhieuXuat.GiaBan
                End If
            End If
        End If
        Dim newChiTietBaoGia As New tbChiTietBaoGia
        With newChiTietBaoGia
            .DonVi = SanPham.DonVi

            If SanPham.GiaNiemYet = 0 And dt.tbChiTietPhieuNhaps.Where(Function(s) s.idSanPham = SanPham.id).Count <> 0 Then
                Dim GiaNhap = dt.tbChiTietPhieuNhaps.Where(Function(s) s.idSanPham = SanPham.id).Max(Function(s) s.id)
                .GiaNiemYet = dt.tbChiTietPhieuNhaps.OrderByDescending(Function(s) s.id).First(Function(s) s.id = GiaNhap).DonGia
            Else
                .GiaNiemYet = SanPham.GiaNiemYet
            End If
            If isNhapHang Then
                If spChiecKhau > 0 Then
                    .ChietKhau = spChiecKhau
                    .DonGia = spGia
                Else
                    .ChietKhau = SanPham.PhanTramNhap
                    Dim s1 As Decimal = .GiaNiemYet * (100 - .ChietKhau) / 1000
                    .DonGia = Math.Round(s1, 0, MidpointRounding.AwayFromZero) * 10
                End If
            Else
                If spChiecKhau >= 0 Then
                    .ChietKhau = spChiecKhau
                    .DonGia = spGia
                Else
                    .ChietKhau = SanPham.PhanTramBan
                    Dim s1 As Decimal = .GiaNiemYet * (100 - .ChietKhau) / 1000
                    .DonGia = Math.Round(s1, 0, MidpointRounding.AwayFromZero) * 10
                End If

            End If
            .NgayNiemYet = SanPham.NgayNiemYet
            .SoLuong = SoLuong
            .KhoiLuongRieng = SanPham.KhoiLuongRieng
            .idSanPham = SanPham.id
            .TonKho = SanPham.SoLuong
            .MaSanPham = SanPham.MaSanPham
            .TenSanPham = SanPham.TenSanPham
            If ChiTietBaoGia IsNot Nothing Then
                .ChietKhau = ChiTietBaoGia.ChietKhau
                .DonGia = ChiTietBaoGia.DonGia
            End If
            .iSTT = iSTT
            iSTT += 1
            .STT = lstChiTietBaoGia.Count + 1
        End With
        Dim flag = False
        For Each itm In lstChiTietBaoGia
            If itm.idSanPham = newChiTietBaoGia.idSanPham Then
                For Each row As DataGridViewRow In dgvMain.Rows

                    If CType(row.DataBoundItem, tbChiTietBaoGia).idSanPham = newChiTietBaoGia.idSanPham Then
                        Dim dialog = MessageBox.Show(CType(row.DataBoundItem, tbChiTietBaoGia).TenSanPham + ": đã tồn tại ở STT- " + row.Cells(0).Value.ToString(), "Cảnh báo", MessageBoxButtons.YesNoCancel)
                        If dialog = DialogResult.No Then
                            txtSearch.Text = ""
                            'row.Selected = True
                            dgvMain.Focus()
                            dgvMain.CurrentCell = dgvMain.Item("SoLuong", row.Index)
                            dgvMain.BeginEdit(True)
                        ElseIf dialog = DialogResult.Cancel Then
                            Exit Sub
                        Else
                            newChiTietBaoGia.DonGia = CType(row.DataBoundItem, tbChiTietBaoGia).DonGia
                            newChiTietBaoGia.ChietKhau = CType(row.DataBoundItem, tbChiTietBaoGia).ChietKhau
                            flag = True
                        End If
                    End If
                Next
                If flag Then
                    Exit For
                Else
                    Exit Sub
                End If
            End If
        Next
        lstChiTietBaoGia.Add(newChiTietBaoGia)
        CapNhatChiTietDatHang()
        txtSearch.Text = ""
        Try
            dgvMain.Focus()
            dgvMain.CurrentCell = dgvMain.Item("SoLuong", 0)
            dgvMain.BeginEdit(True)
        Catch
        End Try
    End Sub
    Sub CapNhatChiTietDatHang()
        Dim count = 0
        For Each itm In lstChiTietBaoGia.OrderBy((Function(s) s.STT))
            count += 1
            itm.STT = count
        Next
        bsChiTietBaoGia.DataSource = From sp In lstChiTietBaoGia Select sp
                                     Order By sp.STT Descending
    End Sub
    Dim idBaoGia As Integer = 0
    Public Sub btnDongY_Click(sender As Object, e As EventArgs) Handles btnDongY.Click
        If DaTao = True Then Exit Sub
        If isSua = False Then
            Dim BaoGiaMoiTao As tbBaoGia = DongYBaoGia()
            If BaoGiaMoiTao IsNot Nothing Then
                'If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tạo bảng báo giá thành công. Bạn có muốn in bảng báo giá không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                '    Dim frm As New frmInBangBaoGia
                '    frm.BangBaoGia = BaoGiaMoiTao
                '    frm.ShowDialog()
                'End If
                idBaoGia = BaoGiaMoiTao.id
            End If
        Else
            'Xóa sản phẩm trước đó
            For Each itm In lstLuuTam
                dt.tbChiTietBaoGias.DeleteOnSubmit(dt.tbChiTietBaoGias.FirstOrDefault(Function(s) s.id = itm.id))
            Next
            'Thêm lại danh sách sản phẩm
            For Each itm In lstChiTietBaoGia
                itm.idBaoGia = BaoGia.id
                dt.tbChiTietBaoGias.InsertOnSubmit(itm)
            Next
            Try
                dt.SubmitChanges()
                ThongBaoInfo("Sửa phiếu thành công")
            Catch
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Sửa phiếu thất bại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                undoChange()
            End Try
        End If
    End Sub
    Dim DaTao As Boolean = False
    Private Function DongYBaoGia() As tbBaoGia
        btnCapNhapSoPhieu_Click(Nothing, Nothing)
        If lstChiTietBaoGia.Count = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Danh sách sản phẩm báo giá rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If
        If txtKhachHang.Tag Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If
        btnCapNhapSoPhieu_Click(Nothing, Nothing)
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xác nhận tạo bảng báo giá " + txtSoPhieuNhap.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return Nothing
        End If
        Dim newBaoGia As New tbBaoGia
        With newBaoGia
            .NgayLap = dtpNgayNhap.Value
            .idNhanVien = loginNhanVien.id
            .ModeHienThi = cmbLoaiBaoGia.SelectedIndex
            .SoPhieu = txtSoPhieuNhap.Tag
            .GhiChu = txtGhiChu.Text
            .isNhapHang = isNhapHang
            .idTrangThai = 1
            .idKhachHang = txtKhachHang.Tag.id
            .tbChiTietBaoGias.AddRange(lstChiTietBaoGia)
            .idLoaiBaoGia = cmbLoaiBaoGia.SelectedItem.id
            .VAT = nudVAT.Value
            .isHuy = False
            If cmbNguoiLienHe.SelectedItem Is Nothing Then
                .idNguoiLienHe = Nothing
            Else
                .idNguoiLienHe = cmbNguoiLienHe.SelectedItem.id
            End If
        End With
        dt.tbBaoGias.InsertOnSubmit(newBaoGia)
        Try
            dt.SubmitChanges()
            'lstChiTietBaoGia.Clear()
            btnDongY.Enabled = False
            bsChiTietBaoGia.DataSource = lstChiTietBaoGia
            'btnCapNhapSoPhieu_Click(Nothing, Nothing)
            txtSearch.ReadOnly = True
            dgvMain.ReadOnly = True
            panelThongTin.Enabled = False
            DaTao = True
            btnInPhieuNhaCungCap.Enabled = True
            btnInPhieuNoiBo.Enabled = True
            Return newBaoGia
        Catch ex As Exception
            undoChange()
            Return Nothing
        End Try
    End Function

    Private Sub bsChiTietBaoGia_DataMemberChanged(sender As Object, e As EventArgs) Handles bsChiTietBaoGia.DataMemberChanged
        bsChiTietBaoGia.DataSource = From sp In lstChiTietBaoGia Select sp
    End Sub

    Private Sub btnChuyenDonDatHang_Click(sender As Object, e As EventArgs) Handles btnChuyenDonDatHang.Click
        btnCapNhapSoPhieu_Click(Nothing, Nothing)
        If lstChiTietBaoGia.Count = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Danh sách sản phẩm rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
            'Return Nothing
        End If
        btnCapNhapSoPhieu_Click(Nothing, Nothing)
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xác nhận tạo bảng đơn đặt hàng " + txtSoPhieuNhap.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Exit Sub
            'Return Nothing
        End If
        Dim newBaoGia As New tbBaoGia
        With newBaoGia
            .NgayLap = dtpNgayNhap.Value
            .idNhanVien = loginNhanVien.id
            .ModeHienThi = cmbLoaiBaoGia.SelectedIndex
            .SoPhieu = txtSoPhieuNhap.Tag
            .GhiChu = txtGhiChu.Text
            .isNhapHang = isNhapHang
            If cmbNguoiLienHe.SelectedItem IsNot Nothing Then
                .idNguoiLienHe = cmbNguoiLienHe.SelectedItem.id
            End If
            .idTrangThai = 2
            .idKhachHang = txtKhachHang.Tag.id
            .tbChiTietBaoGias.AddRange(lstChiTietBaoGia)
            .idLoaiBaoGia = cmbLoaiBaoGia.SelectedItem.id
        End With
        dt.tbBaoGias.InsertOnSubmit(newBaoGia)
        Try
            dt.SubmitChanges()
            lstChiTietBaoGia.Clear()
            bsChiTietBaoGia.DataSource = lstChiTietBaoGia
            btnCapNhapSoPhieu_Click(Nothing, Nothing)
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tạo đơn xác nhận đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Return newBaoGia
        Catch ex As Exception
            undoChange()
            'Return Nothing
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        dgvMain.EndEdit()
        Dim ChiTietBaoGia As tbChiTietBaoGia = bsChiTietBaoGia.Current
        lstChiTietBaoGia.Remove(ChiTietBaoGia)
        bsChiTietBaoGia.DataSource = From itm In lstChiTietBaoGia
    End Sub

    Private Sub btnXoaTatCa_Click(sender As Object, e As EventArgs) Handles btnXoaTatCa.Click
        iSTT = 0
        lstChiTietBaoGia.Clear()
        bsChiTietBaoGia.DataSource = From itm In lstChiTietBaoGia
    End Sub

    Private Sub dgvSanPham_CellValidating(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvSanPham.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STTcol.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
    Private Sub dgvMain_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvMain.CellValidating
        If bsChiTietBaoGia.Current Is Nothing Then Exit Sub
        If dgvMain.Columns(e.ColumnIndex).Name = "GiaNiemYet" Or dgvMain.Columns(e.ColumnIndex).Name = "colChietKhau" Or dgvMain.Columns(e.ColumnIndex).Name = "GiaChietKhau" Or dgvMain.Columns(e.ColumnIndex).Name = "SoLuong" Then
            dgvMain.InvalidateRow(e.RowIndex)
        End If
    End Sub

    'Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
    '        e.Value = e.RowIndex + 1
    '    End If
    'End Sub
    Private Sub dgvMain_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellValueChanged
        If e.RowIndex >= 0 Then
            If dgvMain.Columns(e.ColumnIndex).Name = "colChietKhau" Or dgvMain.Columns(e.ColumnIndex).Name = "GiaNiemYet" Then
                Dim ChiTietBaoGia As tbChiTietBaoGia = dgvMain.Rows(e.RowIndex).DataBoundItem
                'Dim S As Decimal = ChiTietBaoGia.GiaNiemYet * (100 - ChiTietBaoGia.ChietKhau) / 100
                ChiTietBaoGia.DonGia = ChiTietBaoGia.GiaNiemYet * (100 - ChiTietBaoGia.ChietKhau) / 1000
                ChiTietBaoGia.DonGia = Math.Round(ChiTietBaoGia.DonGia, 0, MidpointRounding.AwayFromZero) * 10
                bsChiTietBaoGia_ListChanged(Nothing, Nothing)
            ElseIf dgvMain.Columns(e.ColumnIndex).Name = "GiaChietKhau" Then
                Dim ChiTietBaoGia As tbChiTietBaoGia = dgvMain.Rows(e.RowIndex).DataBoundItem
                If ChiTietBaoGia.GiaNiemYet = 0 Then
                    ChiTietBaoGia.ChietKhau = 0
                    ChiTietBaoGia.GiaNiemYet = ChiTietBaoGia.DonGia
                Else
                    ChiTietBaoGia.ChietKhau = (1 - ChiTietBaoGia.DonGia / ChiTietBaoGia.GiaNiemYet) * 100
                End If
                bsChiTietBaoGia_ListChanged(Nothing, Nothing)
            End If
        End If
    End Sub
#End Region
    Sub TinhKhoiLuongRieng()
        nudKhoiLuongRieng.Value = lstChiTietBaoGia.Sum(Function(s) s.SoLuong * s.KhoiLuongRieng)
    End Sub
    Sub TinhTongTienVon()
        Dim i As Integer = 0
        Dim TienVon As Decimal = 0
        For Each itm In lstChiTietBaoGia
            If itm.GiaNiemYet <> 0 Then
                Dim SP = dt.tbSanPhams.First(Function(s) s.id = itm.idSanPham)
                TienVon += SP.GiaNiemYet * (1 - SP.PhanTramNhap / 100) * itm.SoLuong
            Else
                Dim Nhap = dt.tbChiTietPhieuNhaps.Where(Function(s) s.idSanPham = itm.idSanPham).OrderBy(Function(s) s.id).ThenByDescending(Function(s) s.id).FirstOrDefault
                If Nhap IsNot Nothing Then
                    TienVon += Nhap.DonGia * itm.SoLuong
                Else
                    TienVon += itm.DonGia * itm.SoLuong
                End If
            End If
            If itm.TonKho >= itm.SoLuong Then
                i += 1
            End If
        Next
        'lblTongVon.Text = TienVon.ToString("###,###,###,##0.##đ")
        nudCongTien.Value = lstChiTietBaoGia.Sum(Function(s) s.ThanhTien)
        'lblTongTien.Text = nudCongTien.Value.ToString("###,###,###,##0.##đ")
        nudTienVAT.Value = nudCongTien.Value * nudVAT.Value / 100
        nudTongTien.Value = nudCongTien.Value * (1 + nudVAT.Value / 100)
        nudTienVon.Value = lstChiTietBaoGia.Sum(Function(s) s.ThanhTien) - TienVon
        nudGiaVon.Value = TienVon
        If i = lstChiTietBaoGia.Count Then
            lblSoLuongSanSang.Text = "Toàn bộ đơn hàng sẵn sàng"
        Else
            lblSoLuongSanSang.Text = (lstChiTietBaoGia.Count - i).ToString() + " sản phẩm chưa sẵn sàng/ " + i.ToString + " sản phẩm sẵn sàng"
        End If
    End Sub
    Private Sub bsChiTietBaoGia_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietBaoGia.ListChanged
        lblSoDong.Text = bsChiTietBaoGia.Count.ToString + " sản phẩm"
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
            If txtSearch.Text = "" Then
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
    Dim isNhaCungCap As Boolean = True

    Dim KeyTimKiem As String
    Dim isTimKiem As Boolean = True

    Private Sub cmbNguoiLienHe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNguoiLienHe.SelectedIndexChanged
        If cmbNguoiLienHe.SelectedItem IsNot Nothing Then
            txtSoDienThoai.Text = cmbNguoiLienHe.SelectedItem.SoDienThoai.Trim
            txtEmail.Text = cmbNguoiLienHe.SelectedItem.Email
        Else
            txtSoDienThoai.Text = ""
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub dgvMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMain.SelectionChanged
        If bsChiTietBaoGia.Count <= 1 Then
            Exit Sub
        End If
        If reset Then
            reset = False
            If rowindex > 0 Then
                Exit Sub
            End If
            Dim columnIndex = dgvMain.CurrentCell.ColumnIndex
            Dim i = dgvMain.CurrentCell.RowIndex
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
        End If
    End Sub
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

    Private Sub txtGhiChu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGhiChu.KeyPress, cmbNguoiLienHe.KeyPress, txtKhachHang.KeyPress, cmbLoaiBaoGia.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtKhachHang_Enter(sender As Object, e As EventArgs) Handles txtKhachHang.Enter
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
                                    Where itm.idKhachHang = CType(txtKhachHang.Tag, tbKhachHang).id
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

    Private Sub txtKhachHang_Leave(sender As Object, e As EventArgs) Handles txtKhachHang.Leave
        If txtKhachHang.Tag IsNot Nothing Then
            txtKhachHang.Text = txtKhachHang.Tag.TenKhachHang
        End If
    End Sub

    Private Sub txtGhiChu_Enter(sender As Object, e As EventArgs) Handles txtGhiChu.Enter
        CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox).SelectAll()
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles btnInPhieuNhaCungCap.Click
        If idBaoGia <> 0 Then
            Dim vBaoGia As vwBaoGia = dt.vwBaoGias.Single(Function(s) s.id = idBaoGia)
            TaoBaoGiaXuatExcel1(Application.StartupPath + "\UyNhiemChi\BaoGia1.xlsx", vBaoGia, False)
        End If
    End Sub

    Private Sub btnInPhieuNoiBo_Click(sender As Object, e As EventArgs) Handles btnInPhieuNoiBo.Click
        If idBaoGia <> 0 Then
            Dim vBaoGia As vwBaoGia = dt.vwBaoGias.Single(Function(s) s.id = idBaoGia)
            TaoBaoGiaXuatExcel1(Application.StartupPath + "\UyNhiemChi\BaoGia1.xlsx", vBaoGia, True)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        dgvMain.EndEdit()
        CapNhatChiTietDatHang()
    End Sub
End Class
