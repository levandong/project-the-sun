Public Class ctrlPhieuXuat
    Dim lstChiTietPhieuXuat As New List(Of tbChiTietPhieuXuat)
    Dim lstLuuTam As New List(Of tbChiTietPhieuXuat)
    Dim idKhachHangDatHang As Integer
    Event DongPage()
    Dim isSua = False
    Dim ctrl As New ctrlDGVKhachHang
    Dim SuaPhieuXuat As tbPhieuXuat
#Region "Chọn sản phẩm"
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
        nudVAT.Value = PhieuXuat.VAT
        bsChiTietPhieuXuat.DataSource = From itm In lstChiTietPhieuXuat
        PhieuXuat.tbChiTietPhieuXuats.AddRange(lstChiTietPhieuXuat)
        dtpNgayLap.Value = PhieuXuat.NgayLap
        txtMaPhieuXuat.Tag = PhieuXuat.SoPhieuXuat
        txtMaPhieuXuat.Text = dtpNgayLap.Value.ToString("MMyy") + "X" + txtMaPhieuXuat.Tag.ToString.PadLeft(4, "0")

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
#Region "CẬP NHẬT SỐ PHIẾU"


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
    Sub btnDongY_Click(sender As Object, e As EventArgs)
        If isSua = False Then
        Else
            Dim SuaPhieuXuat = DongYSuaPhieu()
            If SuaPhieuXuat IsNot Nothing Then
                If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Sửa phiếu " + SuaPhieuXuat.MaPhieu + " thành công." + vbNewLine + "Bạn có muốn in phiếu?", "In phiếu?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    ' hiện form in phiếu
                    Dim frm As New frmInPhieuXuat
                    frm.PhieuXuat = SuaPhieuXuat
                    frm.TongTien = SuaPhieuXuat.TongTien
                    frm.XemTruoc = False
                    frm.ShowDialog()
                End If
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
            .VAT = nudVAT.Value
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
        Catch
            undoChange()
            ThongBao("Sửa phiếu thất bại")
            Return Nothing
        End Try
    End Function
    Dim newPhieuXuat As tbPhieuXuat
#End Region

    Private Sub bsChiTietPhieuXuat_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietPhieuXuat.ListChanged
        lblSoLuong.Text = bsChiTietPhieuXuat.Count.ToString + " sản phẩm."
        Dim Tong As Decimal = 0
        For Each itm In bsChiTietPhieuXuat
            Tong += itm.ThanhTien
        Next
        nudTongTien.Value = Math.Round(Tong)
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
        Me.Controls.Add(ctrl)
        'btnCapNhatSoPhieu_Click(Nothing, Nothing)
        'btnCapNhatLoaiPhieuXuat_Click(Nothing, Nothing)
        'btnCapNhatNhaCungCap_Click(Nothing, Nothing)
        'cmbLoaiPhieuXuat_SelectedIndexChanged(Nothing, Nothing)
    End Sub
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs)
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
    Dim isChuyen = True


    Private Sub nudTongTien_ValueChanged(sender As Object, e As EventArgs) Handles nudCongTien.ValueChanged, nudVAT.ValueChanged
        nudTienVAT.Value = nudCongTien.Value * nudVAT.Value / 100
        nudTongTien.Value = nudTienVAT.Value + nudCongTien.Value
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

    Private Sub dgvMain_BamEnter() Handles dgvMain.BamEnter
        isChuyen = True
    End Sub


    Private Sub PhiếuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuXuấtToolStripMenuItem.Click
        Dim vPhieuXuat As vwPhieuXuat = dt.vwPhieuXuats.Single(Function(s) s.id = SuaPhieuXuat.id)
        TaoPhieuXuatExcel(Application.StartupPath + "\UyNhiemChi\PhieuXuat.xlsx", vPhieuXuat, False)
    End Sub

    Private Sub CóKýHiệuKhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CóKýHiệuKhoToolStripMenuItem.Click
        Dim vPhieuXuat As vwPhieuXuat = dt.vwPhieuXuats.Single(Function(s) s.id = SuaPhieuXuat.id)
        TaoPhieuXuatExcel(Application.StartupPath + "\UyNhiemChi\PhieuXuatKyHieuKho.xlsx", vPhieuXuat, True)
    End Sub
End Class

