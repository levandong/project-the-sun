Public Class frmKhachHangDatHang
    Private _BaoGia As tbBaoGia
    Property BaoGia As tbBaoGia
        Get
            Return _BaoGia
        End Get
        Set(value As tbBaoGia)
            _BaoGia = value
            CapNhatPhieuDatHang(_BaoGia)
        End Set
    End Property
    Public DonDatHang As tbKhachHangDatHang
    Public lstChiTietDatHang As New List(Of tbChiTietKhachHangDatHang)
    Dim ctrl As New ctrlDGVKhachHang
    Private _TenKhachHangDatHang As String
    Property TenKhachHangDatHang As String
        Get
            Return _TenKhachHangDatHang
        End Get
        Set(value As String)
            _TenKhachHangDatHang = value
            Me.lblTenKhachHangDatHang.Text = value
            Me.Text = value
        End Set
    End Property
    Private Sub ctrlDatHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        With CtrlTimKiemSanPham1
            .colGiaBan.Visible = True
            .GiaQuyCach.Visible = True
            .colGiaNhap.Visible = False
        End With
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height + ToolStrip1.Size.Height)

        Me.Controls.Add(ctrl)
        btnCapNhapSoPhieu_Click(Nothing, Nothing)
        btnCapNhatNhanVien_Click(Nothing, Nothing)
        txtKhachHang.Focus()
    End Sub
    Dim lstChiTietPhieuNhap As New List(Of tbChiTietPhieuNhap)
    Dim lstChiTietPhieuXuat As New List(Of tbChiTietPhieuXuat)
    Private Sub cmbNguoiLienHe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNguoiLienHe.SelectedIndexChanged
        If cmbNguoiLienHe.SelectedItem IsNot Nothing Then
            txtSoDienThoai.Text = cmbNguoiLienHe.SelectedItem.SoDienThoai.Trim
            txtEmail.Text = cmbNguoiLienHe.SelectedItem.Email
        Else
            txtSoDienThoai.Text = ""
            txtEmail.Text = ""
        End If
    End Sub
    Dim isNhapHang As Boolean = True
    Dim isNhaCungCap As Boolean = True
    Private Sub CapNhatPhieuDatHang(BaoGia As tbBaoGia)
        isNhaCungCap = BaoGia.isNhapHang
        Dim rlsChiTietBaoGia = From itm In dt.tbChiTietBaoGias
                               Where itm.idBaoGia = BaoGia.id
        txtKhachHang.Tag = dt.tbKhachHangs.First(Function(s) s.id = BaoGia.idKhachHang)
        txtKhachHang.Text = txtKhachHang.Tag.TenKhachHang
        txtDiaChi.Text = txtKhachHang.Tag.DiaChi
        txtDiaChiGiaoHang.Text = txtKhachHang.Tag.DiaChiGiaoHang
        nudVAT.Value = BaoGia.VAT
        cmbNhanVien.DataSource = dt.tbNhanViens.Where(Function(s) s.id = loginNhanVien.id)
        isNhapHang = BaoGia.isNhapHang
        For Each itm In rlsChiTietBaoGia.ToList
            Dim newChiTietDatHang As New tbChiTietKhachHangDatHang
            With newChiTietDatHang
                .DonGia = itm.GiaNiemYet
                .DonVi = itm.DonVi
                .GiaBan = itm.DonGia
                .SoLuong = itm.SoLuong
                .KhoiLuongRieng = itm.tbSanPham.KhoiLuongRieng
                .idSanPham = itm.idSanPham
                .ChietKhau = itm.ChietKhau
                .MaSanPham = itm.MaSanPham
                .TenSanPham = itm.TenSanPham
                .GhiChu = itm.GhiChu
                .NgayNiemYet = itm.NgayNiemYet
                .STT = lstChiTietDatHang.Count + 1
            End With
            lstChiTietDatHang.Add(newChiTietDatHang)
        Next
        cmbNguoiLienHe.DataSource = dt.tbChiTietLienHes.Where(Function(s) s.idKhachHang = BaoGia.idKhachHang)
        cmbNguoiLienHe.SelectedItem = dt.tbChiTietLienHes.Where(Function(s) s.id = BaoGia.idNguoiLienHe)
        If cmbNguoiLienHe.SelectedItem IsNot Nothing Then
            cmbNguoiLienHe_SelectedIndexChanged(Nothing, Nothing)
        End If
        txtCongTrinh.Text = BaoGia.GhiChu
        txtKhachHang.Enabled = False
        cmbNhanVien.Enabled = False
        CapNhatChiTietDatHang()
    End Sub
    Sub CapNhatChiTietDatHang()
        Dim count = 0
        For Each itm In lstChiTietDatHang.OrderBy((Function(s) s.STT))
            count += 1
            itm.STT = count
        Next
        bsChiTietKhachHangDatHang.DataSource = From sp In lstChiTietDatHang Select sp
                                               Order By sp.STT Descending
    End Sub
#Region "THANH TOÁN"
    Private Sub nudCongTien_ValueChanged(sender As Object, e As EventArgs) Handles nudCongTien.ValueChanged, nudChietKhau.ValueChanged, nudVAT.ValueChanged, nudTienCK.ValueChanged
        If CType(sender, ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown).Name = nudChietKhau.Name Then
            nudTienCK.Value = nudCongTien.Value * nudChietKhau.Value / 100
        ElseIf CType(sender, ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown).Name = nudTienCK.Name Then
            nudChietKhau.Value = nudTienCK.Value * 100 / nudCongTien.Value
        End If
        nudTienVAT.Value = Math.Round(nudCongTien.Value * (100 - nudChietKhau.Value) / 100 * nudVAT.Value / 100)
        nudTongTien.Value = Math.Round(nudCongTien.Value * (100 - nudChietKhau.Value) / 100 * (100 + nudVAT.Value) / 100)
    End Sub
#End Region
    Dim iSTT = 0

#Region "CHỌN SẢN PHẨM"
    Public Sub CtrlTimKiemSanPham1_ChonSanPhamThanhCong(SanPham As tbSanPham, SoLuong As Double, TheoDonVi As Boolean) Handles CtrlTimKiemSanPham1.ChonSanPhamThanhCong
        iSTT = 0
        Dim newChiTietDatHang As New tbChiTietKhachHangDatHang
        With newChiTietDatHang
            .TheoDonVi = TheoDonVi
            .DonGia = SanPham.GiaNiemYet
            .DonVi = SanPham.DonVi.Trim
            .SoLuong = SoLuong
            .KhoiLuongRieng = SanPham.KhoiLuongRieng
            .idSanPham = SanPham.id
            If isNhapHang Then
                .ChietKhau = SanPham.PhanTramNhap
            Else
                .ChietKhau = SanPham.PhanTramBan
            End If
            .GiaBan = .DonGia * (1 - .ChietKhau / 100)
            .GiaBan = Math.Round(.GiaBan / 100, 0, MidpointRounding.AwayFromZero) * 100
            .QuyCach = SanPham.QuyCach
            .MaSanPham = SanPham.MaSanPham.Trim
            .TenSanPham = SanPham.TenSanPham.Trim
            .NgayNiemYet = SanPham.NgayNiemYet
            .STT = lstChiTietDatHang.Count + 1
        End With
        iSTT += 1
        lstChiTietDatHang.Add(newChiTietDatHang)
        CapNhatChiTietDatHang()
        txtSearch.Text = ""
        Try
            dgvMain.Focus()
            dgvMain.CurrentCell = dgvMain.Item("SoLuong", 0)
            dgvMain.BeginEdit(True)
        Catch
        End Try
    End Sub
#End Region

#Region "Tăng / Giảm / Xoá / Xoá Tất Cả"
    Private Sub btnTangSanPham_Click(sender As Object, e As EventArgs)
        If bsChiTietKhachHangDatHang.Current Is Nothing Then Exit Sub
        Dim ChiTiet As tbChiTietKhachHangDatHang = bsChiTietKhachHangDatHang.Current
        ChiTiet.SoLuong += 1
    End Sub

    Private Sub btnGiamSanPham_Click(sender As Object, e As EventArgs)
        If bsChiTietKhachHangDatHang.Current Is Nothing Then Exit Sub
        Dim ChiTiet As tbChiTietKhachHangDatHang = bsChiTietKhachHangDatHang.Current
        ChiTiet.SoLuong -= 1
        If ChiTiet.SoLuong = 0 Then
            lstChiTietDatHang.Remove(bsChiTietKhachHangDatHang.Current)
            bsChiTietKhachHangDatHang.RemoveCurrent()
        End If
    End Sub

    Public Sub btnXoaSanPham_Click(sender As Object, e As EventArgs) Handles btnXoaSanPham.Click
        dgvMain.EndEdit()
        Dim rls = From itm In lstChiTietDatHang
                  Where itm.Chon = True
        If rls.Count > 0 Then
            For Each itm In rls.ToList
                lstChiTietDatHang.Remove(itm)
            Next
        Else
            Exit Sub
        End If
        CapNhatChiTietDatHang()
    End Sub

    Private Sub btnXoaTatCa_Click(sender As Object, e As EventArgs) Handles btnXoaTatCa.Click
        lstChiTietDatHang.Clear()
        CapNhatChiTietDatHang()
    End Sub
#End Region

#Region "ĐỒNG Ý ĐƠN ĐẶT HÀNG"
    Dim Datao As Boolean = False
    Public Sub btnDongY_Click(sender As Object, e As EventArgs) Handles btnDongY.Click
        If Datao = True Then Exit Sub
        Dim DatHangMoi = DongYKhachHangDatHang()
        If DatHangMoi IsNot Nothing Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tạo phiếu " + DatHangMoi.MaDatHang + " thành công. Bạn có muốn in phiếu?", "In phiếu?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim frm As New frmInKhachHangDatHang
                frm.DatHang = DatHangMoi
                frm.ShowDialog()
            End If
            btnDongY.Enabled = False
        End If
    End Sub
    Public Sub F4_MoTheKho()
        If bsChiTietKhachHangDatHang.Count = 0 Or bsChiTietKhachHangDatHang.Current Is Nothing Then Exit Sub
        Dim ChiTietBaoGia As tbChiTietBaoGia = bsChiTietKhachHangDatHang.Current
        Dim frm As New frmChiTietTonKho
        frm.TuNgay = Now.AddDays(-30)
        frm.DenNgay = Now
        frm.TheoNgay = True
        frm.idSanPham = ChiTietBaoGia.idSanPham
        frm.Text = "THẺ KHO - " + ChiTietBaoGia.TenSanPham
        frm.ShowDialog()
    End Sub

    Event DonDatHangThanhCong()
    Private Function DongYKhachHangDatHang() As tbKhachHangDatHang
        bsChiTietKhachHangDatHang.EndEdit()
        dgvMain.EndEdit()
        If lstChiTietDatHang.Count = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Danh sách sản phẩm đặt hàng trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End If
        If cmbNhanVien.SelectedItem Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbNhanVien.Focus()
            Return Nothing
        End If


        If txtKhachHang.Tag Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKhachHang.Focus()
            Return Nothing
        End If

        btnCapNhapSoPhieu_Click(Nothing, Nothing)
        If My.Settings.LuonXacNhanHoaDon Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xác nhận tạo đơn đặt hàng " + txtSoPhieuNhap.Text.Trim, "Xác nhận đặt hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return Nothing
            End If
        End If

        Dim newDatHang = New tbKhachHangDatHang
        With newDatHang
            .idKhachHang = txtKhachHang.Tag.id
            .idNhanVien = cmbNhanVien.SelectedItem.id
            .NgayDuKienGiaoHang = dtpNgayDuKienGiaoHang.Value
            .NgayLap = Now
            .SoPhieu = LaySoPhieuMoi()
            .ChietKhau = nudChietKhau.Value
            .VAT = nudVAT.Value
            .GhiChu = txtGhiChu.Text
            .DaLapHoaDon = False
            .tbChiTietKhachHangDatHangs.AddRange(lstChiTietDatHang)
            .DiaChiGiaoHang = txtDiaChiGiaoHang.Text.Trim
            .CongTrinh = txtCongTrinh.Text
            .isNhapHang = BaoGia.isNhapHang
            .isHoaDon = chkXuatHoaDon.Checked
            .idBaoGia = BaoGia.id
            If cmbNguoiLienHe.SelectedItem IsNot Nothing Then
                .idNguoiLienHe = cmbNguoiLienHe.SelectedItem.id
            End If
        End With
        dt.tbKhachHangDatHangs.InsertOnSubmit(newDatHang)

        Try
            dt.SubmitChanges()
            RaiseEvent DonDatHangThanhCong()
            sss.Enabled = False
            btnDongY.Enabled = False
            txtSearch.ReadOnly = True
            dgvMain.ReadOnly = True
            Datao = True
            Return newDatHang
        Catch ex As Exception
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tạo phiếu đặt hàng thất bại. Vui lòng thử lại" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            undoChange()
            Return Nothing
        End Try
    End Function

    Public Sub btnXemTruoc_Click(sender As Object, e As EventArgs) Handles btnXemTruoc.Click
        bsChiTietKhachHangDatHang.EndEdit()
        dgvMain.EndEdit()
        If lstChiTietDatHang.Count > 0 Then
            If txtKhachHang.Tag Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim frm As New frmInKhachHangDatHang
            Dim KhachHangDatHangMoi As New tbKhachHangDatHang
            With KhachHangDatHangMoi
                .tbKhachHang = txtKhachHang.Tag
                .tbNhanVien = loginNhanVien
                .NgayLap = Now
                .NgayDuKienGiaoHang = dtpNgayDuKienGiaoHang.Value
                .SoPhieu = txtSoPhieuNhap.Tag
                .ChietKhau = nudChietKhau.Value
                .VAT = nudVAT.Value
                .GhiChu = txtGhiChu.Text
                .DiaChiGiaoHang = txtDiaChiGiaoHang.Text.Trim
            End With
            frm.DatHang = KhachHangDatHangMoi
            frm.XemTruoc = True
            frm.TongTien = Math.Round(nudTongTien.Value, 0, MidpointRounding.AwayFromZero)
            frm.bsData.DataSource = lstChiTietDatHang
            frm.ShowDialog()
            undoChange()
        Else
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Danh sách sản phẩm đặt hàng trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

#Region "CẬP NHẬT SỐ PHIẾU"
    Public Sub btnCapNhapSoPhieu_Click(sender As Object, e As EventArgs) Handles btnCapNhapSoPhieu.Click
        txtSoPhieuNhap.Tag = LaySoPhieuMoi()
        If isNhapHang = False Then
            txtSoPhieuNhap.Text = Now.ToString("MMyy") + "D" + txtSoPhieuNhap.Tag.ToString.PadLeft(4, "0")
        Else
            txtSoPhieuNhap.Text = Now.ToString("MMyy") + "P" + txtSoPhieuNhap.Tag.ToString.PadLeft(4, "0")
        End If
    End Sub

    Private Function LaySoPhieuMoi() As Integer
        If dt.tbKhachHangDatHangs.Count = 0 Then Return 1
        Dim PhieuCuNhatTrongNgay = (From px In dt.tbKhachHangDatHangs
                                    Where px.NgayLap.Year = Now.Year
                                    Where px.NgayLap.Month = Now.Month
                                    Order By px.id Descending).FirstOrDefault
        If PhieuCuNhatTrongNgay Is Nothing Then
            Return 1
        Else
            Return PhieuCuNhatTrongNgay.SoPhieu + 1
        End If
    End Function
#End Region

#Region "CAP NHAT / TIM KIEM KHÁCH HÀNG"
    'Private Sub ChonKhachHangMacDinh()
    '    cmbKhachHang.DataSource = From itm In dt.tbKhachHangs
    '                              Where itm.id = My.Settings.idKhachHangMacDinh

    '    If cmbKhachHang.SelectedItem Is Nothing Then
    '        cmbKhachHang.DataSource = From itm In dt.tbKhachHangs
    '                                  Order By itm.TenKhachHang
    '    End If
    'End Sub

    Dim KeyTimKiem As String
    Dim isTimKiem As Boolean = True


    Private Sub CapNhatKhachHang(key As String)
        Dim rls = From itm In dt.tbKhachHangs
                  Where (key = "") Or (itm.TenKhachHangString.Contains(key) Or dt.f_nosymbol(itm.MaKhachHang).ToLower.Contains(key))
                  Select itm Order By itm.TenKhachHang

        ctrl.gridControl.DataSource = rls
        ctrl.gridViewData.RefreshData()
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

    Private Sub ChonKhachHang(khachHang As tbKhachHang)
        txtKhachHang.Text = khachHang.TenKhachHang
        txtKhachHang.Tag = khachHang
        txtDiaChi.Text = khachHang.DiaChi
        txtDiaChiGiaoHang.Text = khachHang.DiaChiGiaoHang
        cmbNguoiLienHe.DataSource = From itm In dt.tbChiTietLienHes
                                    Where itm.idKhachHang = CType(txtKhachHang.Tag, tbKhachHang).id
    End Sub
#End Region

    Private TongTien As Decimal
    Private Sub bsChiTietKhachHangDatHang_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietKhachHangDatHang.ListChanged
        lblSoDong.Text = bsChiTietKhachHangDatHang.Count.ToString + " sản phẩm."
        TongTien = lstChiTietDatHang.Sum(Function(s) s.ThanhTien)
        lblTongTien.Text = "Tổng thành tiền: " + String.Format("{0:N0}", TongTien) + " đ"
        nudCongTien.Value = TongTien
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
    Private Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        cmbNhanVien.DataSource = From itm In dt.tbNhanViens
                                 Select itm
                                 Order By itm.TenNhanVien

        cmbNhanVien.SelectedItem = loginNhanVien
    End Sub

    Private Sub cmbKhachHang_SelectedIndexChanged(sender As Object, e As EventArgs)
        If txtKhachHang.Tag IsNot Nothing Then
            txtDiaChi.Text = CType(txtKhachHang.Tag, tbKhachHang).DiaChi
            txtDiaChiGiaoHang.Text = CType(txtKhachHang.Tag, tbKhachHang).DiaChiGiaoHang
        Else
            txtDiaChiGiaoHang.Text = ""
        End If
    End Sub
    Private Sub dgvMain_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellValueChanged
        If e.RowIndex >= 0 Then
            If dgvMain.Columns(e.ColumnIndex).Name = "colChietKhau" Then
                Dim ChiTietBaoGia As tbChiTietKhachHangDatHang = dgvMain.Rows(e.RowIndex).DataBoundItem
                ChiTietBaoGia.GiaBan = ChiTietBaoGia.DonGia * (100 - ChiTietBaoGia.ChietKhau) / 100
            ElseIf dgvMain.Columns(e.ColumnIndex).Name = "GiaChietKhau" Then
                Dim ChiTietBaoGia As tbChiTietKhachHangDatHang = dgvMain.Rows(e.RowIndex).DataBoundItem
                If ChiTietBaoGia.DonGia = 0 Then
                    If ChiTietBaoGia.ChietKhau <> 0 Then
                        ChiTietBaoGia.DonGia = (ChiTietBaoGia.GiaBan * 100) / (100 - ChiTietBaoGia.ChietKhau)
                    End If
                Else
                    ChiTietBaoGia.ChietKhau = (1 - ChiTietBaoGia.GiaBan / ChiTietBaoGia.DonGia) * 100
                    End If
                ElseIf dgvMain.Columns(e.ColumnIndex).Name = "SoLuong" Then
                Dim ChiTietBaoGia As tbChiTietKhachHangDatHang = dgvMain.Rows(e.RowIndex).DataBoundItem
                ChiTietBaoGia.Con = ChiTietBaoGia.SoLuong - ChiTietBaoGia.DaGiao
            End If
        End If
    End Sub
    Private Sub dgvMain_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvMain.CellValidating
        If bsChiTietKhachHangDatHang.Current Is Nothing Then Exit Sub
        If dgvMain.Columns(e.ColumnIndex).Name = "colChietKhau" Or dgvMain.Columns(e.ColumnIndex).Name = "GiaChietKhau" Or dgvMain.Columns(e.ColumnIndex).Name = "SoLuong" Then
            dgvMain.InvalidateRow(e.RowIndex)
        End If
    End Sub
    Event XoaSanPham()
    Private Sub dgvMain_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvMain.KeyDown
        If e.KeyCode = Keys.KeyCode Then
            RaiseEvent XoaSanPham()
        End If
    End Sub

    Private Sub txtCongTrinh_TextChanged(sender As Object, e As KeyPressEventArgs) Handles dtpNgayDuKienGiaoHang.KeyPress, nudTienCK.KeyPress, nudChietKhau.KeyPress, nudTienCK.KeyPress, chkXuatHoaDon.KeyPress, txtGhiChu.KeyPress, txtCongTrinh.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
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
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim key = txtSearch.Text
        If txtSearch.Text = "" Then
            dgvSanPham.Visible = False
            ToolStrip2.Visible = True
            ToolStrip3.Visible = True
            dgvMain.Visible = True
        Else
            dgvSanPham.Visible = True
            ToolStrip2.Visible = False
            ToolStrip3.Visible = False
            dgvMain.Visible = False
            bsSanPham.DataSource = (From s In dt.vwSanPhams
                                    Where (s.TenSanPhamString.Contains(key))
                                    Where s.HetBan = False).Take(My.Settings.SoDongTimKiemSanPham).OrderBy(Function(s) s.MaSanPham)
        End If
    End Sub

    Private Sub dgvMain_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvMain.EditingControlShowing
        If dgvMain.Columns(dgvMain.CurrentCell.ColumnIndex).Name = "TenSanPham" Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        Else

        End If
    End Sub
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If dgvSanPham.RowCount = 0 Or dgvSanPham.Visible = False Then
            Exit Sub
        End If
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
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If dgvMain.Columns(dgvMain.CurrentCell.ColumnIndex).Name = "TenSanPham" Then
            Dim str As String = CType(sender, TextBox).Text
        End If
    End Sub
    Private Sub dgvMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMain.SelectionChanged
        If bsChiTietKhachHangDatHang.Count <= 1 Then
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
            If txtSearch.Text = "" Then
                Exit Sub
            End If
            Dim vSanPham As vwSanPham = bsSanPham.Current
            If vSanPham Is Nothing Then
                Exit Sub
            End If
            Dim sanPham As tbSanPham = dt.tbSanPhams.First(Function(s) s.id = vSanPham.id)
            CtrlTimKiemSanPham1_ChonSanPhamThanhCong(sanPham, 1, 0)
        End If
    End Sub
    Private Sub dgvSanPham_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellDoubleClick
        Dim vSanPham As vwSanPham = bsSanPham.Current
        If vSanPham Is Nothing Then
            Exit Sub
        End If
        Dim sanPham As tbSanPham = dt.tbSanPhams.First(Function(s) s.id = vSanPham.id)
        CtrlTimKiemSanPham1_ChonSanPhamThanhCong(sanPham, 1, 0)
    End Sub
    Private Sub Bamenter() Handles dgvMain.BamEnter
        isChuyen = True
    End Sub

    Public Sub chkAn_CheckedChanged(sender As Object, e As EventArgs) Handles chkAn.CheckedChanged
        sss.Visible = Not chkAn.Checked
    End Sub

    Private Sub txtDiaChiGiaoHang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiaChiGiaoHang.KeyPress, txtSoPhieuNhap.KeyPress, txtKhachHang.KeyPress, txtDiaChi.KeyPress, nudVAT.KeyPress, dtpNgayDuKienGiaoHang.KeyPress, cmbNhanVien.KeyPress, cmbNguoiLienHe.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub nudVAT_Enter(sender As Object, e As EventArgs) Handles nudVAT.Enter
        nudVAT.Select(0, nudVAT.Text.Length)
    End Sub
    Dim i As Integer = 0
    'fomat ngày tháng năm thành dd/MM/yy nếu không thêm 1 điều kiện
    Private Sub dtpNgayNiemYet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpNgayDuKienGiaoHang.KeyPress
        i += 1
        If i = 2 Then
            SendKeys.Send("{DIVIDE}")
            i = -1
        End If
    End Sub
    Event BaoGiaThanhCong()
    Sub ChuyenThanhCong()
        RaiseEvent BaoGiaThanhCong()
        Me.Close()
    End Sub

    Private Sub frmKhachHangDatHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F7 Then
            chkAn.Checked = Not chkAn.Checked
        ElseIf e.KeyCode = Keys.F4 Then
            F4_MoTheKho()
        End If
    End Sub
    Private Sub dgvSanPham_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvSanPham.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STTcol.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CapNhatChiTietDatHang()
    End Sub
End Class