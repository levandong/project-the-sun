Public Class ctrlHoaDon
    Dim ctrl As New ctrlDGVKhachHang
    Dim isSua = False
    Private _HoaDon As vwHoaDon
    Property SuaHoaDon As vwHoaDon
        Get
            Return _HoaDon
        End Get
        Set(value As vwHoaDon)
            _HoaDon = value
            CapNhatHoaDon()
            isSua = True
        End Set
    End Property
    Dim lstTam As New List(Of tbChiTietHoaDon)
    Sub CapNhatHoaDon()
        Dim rls = From itm In dt.tbChiTietHoaDons Where itm.idHoaDon = SuaHoaDon.id
        lstChiTietHoaDon.AddRange(rls.ToList)
        For Each itm In rls
            Dim chitiet As New tbChiTietHoaDon
            With chitiet
                .id = itm.id
                .idHoaDon = itm.idHoaDon
                .TheoDonVi = itm.TheoDonVi
                .idSanPham = itm.idSanPham
                .SoLuong = itm.SoLuong
                .DonGia = itm.DonGia
                .GhiChu = itm.GhiChu
                .GiaVon = itm.GiaVon
                .ChietKhau = itm.ChietKhau
                .QuyCach = itm.QuyCach
                .MaSanPham = itm.MaSanPham
                .TenSanPham = itm.TenSanPham
                .DonVi = itm.DonVi
            End With
            lstTam.Add(chitiet)
        Next
        bsChiTietHoaDon.DataSource = From itm In lstChiTietHoaDon
        Dim HoaDon = dt.tbHoaDons.Single(Function(s) s.id = SuaHoaDon.id)
        ChonKhachHang(HoaDon.tbKhachHang, txtKhachHang)
        ChonKhachHang(HoaDon.tbKhachHang1, txtKhachHangTinhCongNo)
        txtGhiChu.Text = HoaDon.GhiChu
        nudVAT.Value = HoaDon.VAT
        nudPhi.Value = HoaDon.MucPhi
        cmbHinhThucThanhToan.Text = HoaDon.HinhThucThanhToan
        txtSoTaiKhoan.Text = HoaDon.SoTaiKhoan
    End Sub
    Dim lstDanhSachSanPham As List(Of vwSanPham)
    Private Sub ctrlHoaDon_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpNgayLap.Text = Now.ToString("dd/MM/yyyy")
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height + KryptonHeader1.Size.Height)
        Me.Controls.Add(ctrl)
        ctrlSanPham.Visible = False
        ctrlSanPham.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height + KryptonHeader1.Size.Height)
        Me.Controls.Add(ctrlSanPham)
        txtKhachHang.Focus()
        CapNhatSoPhieu()
        lstDanhSachSanPham = (From itm In dt.vwSanPhams Order By itm.TenSanPham).ToList
        KryptonSplitContainer2.Panel1Collapsed = True
    End Sub
    Dim idPhieuXuat As Integer = 0
    Public Sub CapNhatPhieuXuat(vPhieuXuat)
        bsChiTietPhieuXuat.DataSource = From itm In dt.vwChiTietPhieuXuats
                                        Where itm.idPhieuXuat = vPhieuXuat
        idPhieuXuat = vPhieuXuat
        KryptonSplitContainer2.Panel1Collapsed = False
    End Sub
    Dim lstChiTietHoaDon As New List(Of tbChiTietHoaDon)
    Dim lstChiTietPhieuXuat As New List(Of vwChiTietPhieuXuat)

    Sub ChonSanPhamThanhCong(ChiTiet As vwChiTietPhieuXuat)
        If bsChiTietHoaDon.Count > My.Settings.SoDongToiDa Then
            ThongBao("Vượt quá số dòng của một tờ hóa đơn")
            Exit Sub
        End If
        Dim TonTai = From itm In lstChiTietPhieuXuat Where itm.id = ChiTiet.id
        If TonTai.Count > 0 Then
            Exit Sub
        End If
        lstChiTietPhieuXuat.Add(ChiTiet)
        Dim SanPham As tbSanPham = dt.tbSanPhams.Single(Function(s) s.id = ChiTiet.idSanPham)
        Dim newChiTietHoaDon As New tbChiTietHoaDon
        With newChiTietHoaDon
            .TenSanPham = SanPham.TenTrenHoaDon
            .MaSanPham = SanPham.MaSanPham
            .DonVi = SanPham.DonVi
            .SoLuong = ChiTiet.SoLuong
            .DonGia = ChiTiet.DonGia
            .idSanPham = ChiTiet.idSanPham
            .GiaVon = ChiTiet.DonGia
            .ChietKhau = 0
            .GiamGia = 0
            .TheoDonVi = 1
            .QuyCach = 1
            .isHienDonGia = True
            .isHienDonVi = True
            .isHienSoLuong = True
            .isHienSTT = True
            .isHienThanhTien = True
            .TheLoai = THEOLOAICHITIETHOADON.HANGHOA
            .SoNhanThanhTien = 1
        End With
        lstChiTietHoaDon.Add(newChiTietHoaDon)
        bsChiTietHoaDon.DataSource = From itm In lstChiTietHoaDon
    End Sub
    Private Sub dgvChiTietPhieuXuat_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChiTietPhieuXuat.CellDoubleClick
        If bsChiTietPhieuXuat.Current Is Nothing Then
            Exit Sub
        End If
        ChonSanPhamThanhCong(bsChiTietPhieuXuat.Current)
    End Sub

    Private Sub txtKhachHang_Enter(sender As Object, e As EventArgs) Handles txtKhachHang.Enter, txtKhachHangTinhCongNo.Enter
        Dim textBox = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        ctrl.Location = New Point(textBox.Location.X, textBox.Location.Y + KryptonHeader1.Height)
    End Sub
    Sub ChonKhachHang(KhachHang As tbKhachHang, TextBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        TextBox.Tag = KhachHang
        TextBox.Text = KhachHang.TenRutGon
        If txtKhachHangTinhCongNo.Tag IsNot Nothing Then
            txtKhachHangTinhCongNo.Text = KhachHang.TenRutGon
            txtKhachHangTinhCongNo.Tag = KhachHang
        End If
        If TextBox.Name = "txtKhachHang" Then
            txtMaSoThue.Text = KhachHang.MaSoThue.Trim
            txtDiaChi.Text = KhachHang.DiaChi.Trim
        End If
    End Sub
    Private Sub txtKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKhachHang.KeyDown, txtKhachHangTinhCongNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ctrl.gridViewData.FocusedRowHandle < 0 Then
                Exit Sub
            End If
            Dim vKhachHang As vwKhachHang = ctrl.gridViewData.GetRow(ctrl.gridViewData.FocusedRowHandle)
            Dim Khachhang As tbKhachHang = dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id)
            ChonKhachHang(Khachhang, CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox))
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


    Dim isNhaCungCap As Boolean = False
    Private Sub txtKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtKhachHang.TextChanged, txtKhachHangTinhCongNo.TextChanged
        Dim key = BoDauTiengViet(CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Text.Trim)
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

    Private Sub nudVAT_Enter(sender As Object, e As EventArgs)
        Dim nud = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown)
        nud.Select(0, nud.Text.Length)
    End Sub
    Private Sub CapNhatChiTietHoaDon()
        dgvMain.EndEdit()
        Dim SoThuTu = 0
        For Each itm In lstChiTietHoaDon.Where(Function(s) s.TheLoai = THEOLOAICHITIETHOADON.HANGHOA Or
                                                     s.TheLoai = THEOLOAICHITIETHOADON.THANHTIEN Or
                                                     s.TheLoai = THEOLOAICHITIETHOADON.TIENSAUTHUE _
                                                     Or s.TheLoai = THEOLOAICHITIETHOADON.TENSANPHAMDACBIET)
            SoThuTu += 1
            itm.SoThuTu = SoThuTu
        Next

        For Each itm In lstChiTietHoaDon.Where(Function(s) s.TheLoai = THEOLOAICHITIETHOADON.GIAMTIEN)
            SoThuTu += 1
            itm.SoThuTu = SoThuTu
        Next

        For Each itm In lstChiTietHoaDon.Where(Function(s) s.TheLoai = THEOLOAICHITIETHOADON.CONGTIEN)
            SoThuTu += 1
            itm.SoThuTu = SoThuTu
            Dim CongTien = lstChiTietHoaDon.Where(Function(s) s.TheLoai <> THEOLOAICHITIETHOADON.CHIETKHAUPHANTRAM).Sum(Function(s) Math.Round(s.DonGia * s.SoLuong * s.SoNhanThanhTien, 0, MidpointRounding.AwayFromZero))
            itm.DonGia = CongTien
        Next

        For Each itm In lstChiTietHoaDon.Where(Function(s) s.TheLoai = THEOLOAICHITIETHOADON.CHIETKHAUPHANTRAM)
            SoThuTu += 1
            itm.SoThuTu = SoThuTu
            Dim CongTien = lstChiTietHoaDon.Where(Function(s) s.TheLoai <> THEOLOAICHITIETHOADON.CHIETKHAUPHANTRAM).Sum(Function(s) Math.Round(s.DonGia * s.SoLuong * s.SoNhanThanhTien, 0, MidpointRounding.AwayFromZero))
            itm.DonGia = CongTien * itm.ChietKhau / 100
        Next

        For Each itm In lstChiTietHoaDon.Where(Function(s) s.TheLoai = THEOLOAICHITIETHOADON.GHICHU)
            SoThuTu += 1
            itm.SoThuTu = SoThuTu
        Next

        bsChiTietHoaDon.DataSource = (From itm In lstChiTietHoaDon
                                      Order By itm.SoThuTu).ToList
        'lblSoDongChiTiet.Text = dgvMain.RowCount.ToString + " sản phẩm."
        'TinhTongTien()
    End Sub

    Public Sub btnThemSanPham_Click(sender As Object, e As EventArgs) Handles btnThemSanPham.Click
        isChuyen = False
        dgvMain.EndEdit()
        If bsChiTietHoaDon.Count > My.Settings.SoDongToiDa Then
            ThongBao("Vượt quá số dòng của một tờ hóa đơn")
            Exit Sub
        End If
        Dim newChiTietHoaDon As New tbChiTietHoaDon
        With newChiTietHoaDon
            .TenSanPham = "Tên sản phẩm"
            .DonVi = "Cái"
            .SoLuong = 0
            .DonGia = 0
            .idSanPham = dt.tbSanPhams.First.id
            .GiaVon = 0
            .ChietKhau = 0
            .GiamGia = 0
            .TheoDonVi = 1
            .QuyCach = 1
            .SoNhanThanhTien = 1
            .TheLoai = THEOLOAICHITIETHOADON.HANGHOA
            .isHienDonGia = True
            .isHienDonVi = True
            .isHienSoLuong = True
            .isHienSTT = True
            .isHienThanhTien = True
        End With
        lstChiTietHoaDon.Add(newChiTietHoaDon)
        'CapNhatChiTietHoaDon()
        bsChiTietHoaDon.DataSource = From itm In lstChiTietHoaDon
        bsChiTietHoaDon.MoveLast()
        rowindex = dgvMain.CurrentCell.RowIndex
        dgvMain.CurrentCell = dgvMain.Item("TenSanPham", rowindex)
        dgvMain.BeginEdit(True)
    End Sub

    Private Sub bsChiTietHoaDon_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietHoaDon.ListChanged
        vndTongTien.Value = lstChiTietHoaDon.Sum(Function(s) s.ThanhTien)
    End Sub

    Function LaySoHoaDonMoiNhat() As Integer
        If dt.tbHoaDons.Count = 0 Then Return 1
        Dim PhieuCuNhatTrongNgay = (From px In dt.tbHoaDons
                                    Where px.LoaiHD = 1
                                    Order By px.id Descending).FirstOrDefault
        If PhieuCuNhatTrongNgay Is Nothing Then
            Return 1
        Else
            Return PhieuCuNhatTrongNgay.SoHD + 1
        End If
    End Function
    Function LaySoPhieuMoiNhat() As Integer
        If dt.tbHoaDons.Count = 0 Then Return 1
        Dim PhieuCuNhatTrongNgay = (From px In dt.tbHoaDons
                                    Where px.NgayLap.Year = dtpNgayLap.Value.Year
                                    Where px.NgayLap.Month = dtpNgayLap.Value.Month
                                    Where px.LoaiHD = 0
                                    Order By px.id Descending).FirstOrDefault
        If PhieuCuNhatTrongNgay Is Nothing Then
            Return 1
        Else
            Return PhieuCuNhatTrongNgay.SoHoaDon + 1
        End If
    End Function
    Sub CapNhatSoPhieu()
        txtSoHoaDon.Tag = LaySoPhieuMoiNhat()
        txtSoHoaDon.Text = LaySoHoaDonMoiNhat().ToString.PadLeft(7, "0")
    End Sub
    Private Sub btnXoaTatCa_Click(sender As Object, e As EventArgs) Handles btnXoaTatCa.Click
        lstChiTietHoaDon.Clear()
        bsChiTietHoaDon.DataSource = From itm In lstChiTietHoaDon
    End Sub
    Function DongYHoaDon() As tbHoaDon
        If txtKhachHang.Tag Is Nothing Then
            ThongBao("Chưa nhập thông tin khách hàng trên hóa đơn")
            Return Nothing
        End If
        If txtKhachHangTinhCongNo.Tag Is Nothing Then
            ThongBao("Chưa nhập thông tin công ty tính công nợ")
            Return Nothing
        End If
        If vndTongTien.Text = "" Then
            ThongBao("Chưa nhập tiền thuế")
            Return Nothing
        End If
        Dim newHoaDon As New tbHoaDon
        With newHoaDon
            .NgayLap = dtpNgayLap.Value
            .idKhachHang = txtKhachHangTinhCongNo.Tag.id
            .idNhanVien = loginNhanVien.id
            .ChietKhau = 0
            .SoHoaDon = txtSoHoaDon.Tag
            .VAT = CDec(nudVAT.Text.Trim)
            .GhiChu = txtGhiChu.Text.Trim
            .SoTienKhachDua = 0
            .SoTienGiam = 0
            .NgayInHoaDon = dtpNgayLap.Value
            .TienTruocThue = CDec(vndTongTien.Value)
            .MucPhi = CDec(nudPhi.Value)
            .idKhachHangHD = txtKhachHang.Tag.id
            .LoaiHD = 1
            .tbChiTietHoaDons.AddRange(lstChiTietHoaDon)
            .SoHD = CDec(txtSoHoaDon.Text.Trim)
            .CoVAT = True
            .HinhThucThanhToan = cmbHinhThucThanhToan.Text.Trim
            .SoTaiKhoan = txtSoTaiKhoan.Text.Trim
            .DiaChi = txtDiaChi.Text.Trim
            If idPhieuXuat <> 0 Then
                .idPhieuXuat = idPhieuXuat
            End If
        End With
        dt.tbHoaDons.InsertOnSubmit(newHoaDon)
        Try
            dt.SubmitChanges()
            txtKhachHang.Text = ""
            txtKhachHang.Tag = Nothing
            txtDiaChi.Text = ""
            txtMaSoThue.Text = ""
            txtKhachHangTinhCongNo.Text = ""
            txtKhachHangTinhCongNo.Tag = Nothing
            lstChiTietHoaDon.Clear()
            bsChiTietHoaDon.DataSource = From itm In lstChiTietHoaDon
            txtGhiChu.Text = ""
            Return newHoaDon
        Catch ex As Exception
            ThongBao("Lỗi thêm phiếu thất bại" + ex.Message)
            Return Nothing
        End Try
    End Function
    Private Sub btnDongY_Click(sender As Object, e As EventArgs) Handles btnDongY.Click
        If XacNhanYesNo("Bạn xác nhận lưu lại hóa đơn") = DialogResult.Yes And isSua = False Then
            If DongYHoaDon() IsNot Nothing Then
                ThongBao("Hóa đơn đã được tạo thành công")
            End If
        ElseIf isSua Then
            If DongYSuaHoaDon() IsNot Nothing Then
                ThongBao("Hóa đơn đã được tạo thành công")
            End If
        End If
    End Sub
    Function DongYSuaHoaDon() As tbHoaDon
        If txtKhachHang.Tag Is Nothing Then
            ThongBao("Chưa nhập thông tin khách hàng trên hóa đơn")
            Return Nothing
        End If
        If txtKhachHangTinhCongNo.Tag Is Nothing Then
            ThongBao("Chưa nhập thông tin công ty tính công nợ")
            Return Nothing
        End If
        If vndTongTien.Text = "" Then
            ThongBao("Chưa nhập tiền thuế")
            Return Nothing
        End If
        Dim HoaDon = dt.tbHoaDons.Single(Function(s) s.id = SuaHoaDon.id)
        With HoaDon
            .NgayLap = dtpNgayLap.Value
            .idKhachHang = txtKhachHangTinhCongNo.Tag.id
            .idNhanVien = loginNhanVien.id
            .ChietKhau = 0
            .SoHoaDon = txtSoHoaDon.Tag
            .VAT = CDec(nudVAT.Text.Trim)
            .GhiChu = txtGhiChu.Text.Trim
            .SoTienKhachDua = 0
            .SoTienGiam = 0
            .NgayInHoaDon = dtpNgayLap.Value
            .TienTruocThue = CDec(vndTongTien.Value)
            .MucPhi = CDec(nudPhi.Value)
            .idKhachHangHD = txtKhachHang.Tag.id
            .LoaiHD = 1
            .SoHD = CDec(txtSoHoaDon.Text.Trim)
            .CoVAT = True
            .HinhThucThanhToan = cmbHinhThucThanhToan.Text.Trim
            .SoTaiKhoan = txtSoTaiKhoan.Text.Trim
            .DiaChi = txtDiaChi.Text.Trim
        End With
        For Each itm In lstTam
            dt.tbChiTietHoaDons.DeleteAllOnSubmit(dt.tbChiTietHoaDons.Where(Function(s) s.id = itm.id))
        Next
        'Thêm lại danh sách sản phẩm
        For Each itm In lstChiTietHoaDon
            itm.idHoaDon = SuaHoaDon.id
            dt.tbChiTietHoaDons.InsertOnSubmit(itm)
        Next
        Try
            dt.SubmitChanges()
            txtKhachHang.Text = ""
            txtKhachHang.Tag = Nothing
            txtDiaChi.Text = ""
            txtMaSoThue.Text = ""
            txtKhachHangTinhCongNo.Text = ""
            txtKhachHangTinhCongNo.Tag = Nothing
            lstChiTietHoaDon.Clear()
            bsChiTietHoaDon.DataSource = From itm In lstChiTietHoaDon
            txtGhiChu.Text = ""
            Return HoaDon
        Catch ex As Exception
            ThongBao("Lỗi thêm phiếu thất bại" + ex.Message)
            Return Nothing
        End Try
    End Function
    Private Sub txtKhachHang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKhachHang.KeyPress, txtSoHoaDon.KeyPress, txtKhachHangTinhCongNo.KeyPress, txtGhiChu.KeyPress, nudVAT.KeyPress, nudPhi.KeyPress, dtpNgayLap.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vndTongTien_TextChanged(sender As Object, e As EventArgs) Handles vndTongTien.TextChanged, nudPhi.TextChanged, nudVAT.TextChanged
        vndTienThue.Value = vndTongTien.Value * nudVAT.Value / 100
        vndTongCong.Value = vndTienThue.Value + vndTongTien.Value
        vndPhi.Value = nudPhi.Value * vndTongTien.Value / 100
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        lstChiTietHoaDon.Remove(bsChiTietHoaDon.Current)
        bsChiTietHoaDon.DataSource = From itm In lstChiTietHoaDon
    End Sub
    Dim isHien As Boolean = False
    Private Sub btnXemCotAnHien_Click(sender As Object, e As EventArgs) Handles btnXemCotAnHien.Click
        If isHien = True Then
            btnXemCotAnHien.Text = "[HIỆN]Nội dung ẩn/hiện"
            isHienDonGia.Visible = False
            isHienSTT.Visible = False
            isHienDonVi.Visible = False
            isHienThanhTien.Visible = False
            isHienDonGia.Visible = False
            isHien = False
        Else
            btnXemCotAnHien.Text = "[ẨN]Nội dung ẩn/hiện"
            isHienDonGia.Visible = True
            isHienSTT.Visible = True
            isHienDonVi.Visible = True
            isHienThanhTien.Visible = True
            isHienDonGia.Visible = True
            isHien = True
        End If
    End Sub

    Private Sub dgvMain_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvMain.EditingControlShowing
        Dim textbox As TextBox = e.Control
        If dgvMain.Columns(dgvMain.CurrentCell.ColumnIndex).Name = "TenSanPham" Then
            ctrlSanPham.Location = New Point(30, sss.Panel1.Size.Height + KryptonHeader1.Size.Height * 2 + (dgvMain.CurrentCell.RowIndex + 1) * 22 + 11)
            isEdit = True
        Else
            isEdit = False
            ctrlSanPham.Visible = False
        End If
        AddHandler textbox.TextChanged, AddressOf textboxChange
    End Sub
    Dim isEdit As Boolean = False
    Dim ctrlSanPham As New ctrlDGVSanPham
    Sub textboxChange(sender As Object, e As EventArgs)
        If isEdit = False Then
            Exit Sub
        End If
        Dim txtSanPham As TextBox = sender
        Dim key = BoDauTiengViet(txtSanPham.Text.Trim)
        ctrlSanPham.BringToFront()
        If key <> "" Then
            If dgvMain.IsCurrentCellInEditMode = False Then
                Exit Sub
            End If
            ctrlSanPham.Visible = True
            dgvMain.Editing = True
            ctrlSanPham.gridControl.DataSource = From itm In lstDanhSachSanPham
                                                 Where itm.MaSanPham.Contains(key) Or itm.TenSanPhamString.Contains(key)
                                                 Take 15

            ctrlSanPham.gridViewData.RefreshData()
            If ctrlSanPham.gridViewData.DataRowCount = 0 Then
                ctrlSanPham.Visible = False
            End If
            ctrlSanPham.Size = New Size(500, 380)
        Else
            ctrlSanPham.Visible = False
            dgvMain.Editing = False
        End If

    End Sub

    Sub ChonSanPham(SanPham As vwSanPham, ChiTiet As tbChiTietHoaDon)
        rowindex = dgvMain.CurrentCell.RowIndex
        isChuyen = False
        With ChiTiet
            .TenSanPham = SanPham.TenTrenHoaDon
            .MaSanPham = SanPham.MaSanPham
            .DonVi = SanPham.DonVi
            .SoLuong = 1
            .DonGia = Math.Round(CDec(SanPham.GiaNiemYet * (1 - SanPham.PhanTramBan / 100)) / 100, 0, MidpointRounding.AwayFromZero) * 100
            .idSanPham = SanPham.id
            .GiaVon = 0
            .ChietKhau = 0
            .GiamGia = 0
            .TheoDonVi = 1
            .QuyCach = 1
            .isHienDonGia = True
            .isHienDonVi = True
            .isHienSoLuong = True
            .isHienSTT = True
            .isHienThanhTien = True
        End With
        isChuyen = True
        dgvMain.InvalidateRow(rowindex)

        dgvMain.CurrentCell = dgvMain.Item("SoLuong", rowindex)
        dgvMain.BeginEdit(True)
    End Sub
    Private Sub txtSanPham_KeyDown(keyData As Keys) Handles dgvMain.KeyUpDown
        Dim ChiTiet As tbChiTietHoaDon = bsChiTietHoaDon.Current
        If keyData = Keys.Enter Then
            If ctrlSanPham.Visible = False Then
                Exit Sub
            End If

            If ctrl.gridViewData.FocusedRowHandle < 0 Then
                Exit Sub
            End If

            Dim vSanPham As vwSanPham = ctrlSanPham.gridViewData.GetRow(ctrl.gridViewData.FocusedRowHandle)

            ChonSanPham(vSanPham, ChiTiet)
            ctrlSanPham.Visible = False
            dgvMain.Editing = False
        ElseIf keyData = Keys.Down Then
            If ctrlSanPham.gridViewData.FocusedRowHandle = ctrlSanPham.gridViewData.DataRowCount - 1 Then
                ctrlSanPham.gridViewData.FocusedRowHandle = 0
            Else
                ctrlSanPham.gridViewData.FocusedRowHandle += 1
            End If
        ElseIf keyData = Keys.Up Then
            If ctrlSanPham.gridViewData.FocusedRowHandle = 0 Then
                ctrlSanPham.gridViewData.FocusedRowHandle = ctrlSanPham.gridViewData.DataRowCount - 1
            Else
                ctrlSanPham.gridViewData.FocusedRowHandle -= 1
            End If
        End If

    End Sub
    Dim reset = False
    Dim rowindex = 0
    Dim isChuyen = True
    Private Sub dgvMain_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellEndEdit
        ctrlSanPham.Visible = False
        dgvMain.Editing = False
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
            If columnName = "TenSanPham" Then
                dgvMain.CurrentCell = dgvMain.Item("SoLuong", rowindex)
                dgvMain.BeginEdit(True)
            ElseIf columnName = "SoLuong" Then
                dgvMain.CurrentCell = dgvMain.Item("DonGia", rowindex)
                dgvMain.BeginEdit(True)
            ElseIf columnName = "DonGia" Then
                dgvMain.CurrentCell = dgvMain.Item("GhiChu", rowindex)
                dgvMain.BeginEdit(True)
            ElseIf columnName = "GhiChu" Then
                dgvMain.EndEdit()
            End If
            isChuyen = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Bamenter() Handles dgvMain.BamEnter
        isChuyen = True
    End Sub
    Private Sub dgvMain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellClick
        isChuyen = False
    End Sub
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STTcol.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
    Private Sub dgvChiTietPhieuXuat_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvChiTietPhieuXuat.CellValueNeeded, dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub btnXemPhieu_Click(sender As Object, e As EventArgs) Handles btnXemPhieu.Click
        If txtKhachHang.Tag Is Nothing Then
            ThongBao("Vui lòng chọn khách hàng")
            txtKhachHang.Focus()
            Exit Sub
        End If
        If txtKhachHangTinhCongNo.Tag Is Nothing Then
            ThongBao("Vui lòng chọn khách hàng tình công nợ")
            txtKhachHangTinhCongNo.Focus()
            Exit Sub
        End If
        Dim KhachHang As tbKhachHang = txtKhachHang.Tag
        If dgvMain.CurrentCell Is Nothing Then
            ThongBao("Vui lòng chọn sản phẩm để xuất hóa đơn")
            Exit Sub
        End If
        dgvMain.EndEdit()
        Dim newHoaDon As New tbHoaDon
        With newHoaDon
            .NgayLap = dtpNgayLap.Value
            .idNhanVien = loginNhanVien.id
            .ChietKhau = 0
            .SoHoaDon = txtSoHoaDon.Tag
            .VAT = CDec(nudVAT.Text.Trim)
            .GhiChu = txtGhiChu.Text.Trim
            .SoTienKhachDua = 0
            .SoTienGiam = 0
            .NgayInHoaDon = dtpNgayLap.Value
            .TienTruocThue = CDec(vndTongTien.Value)
            .MucPhi = CDec(vndPhi.Value)
            .idKhachHangHD = txtKhachHang.Tag.id
            .LoaiHD = 1
            .tbChiTietHoaDons.AddRange(lstChiTietHoaDon)
            .SoHD = CDec(txtSoHoaDon.Text.Trim)
            .CoVAT = True
            .HinhThucThanhToan = cmbHinhThucThanhToan.Text
            .SoTaiKhoan = txtSoTaiKhoan.Text
            .tbKhachHang = KhachHang
            .DiaChi = txtDiaChi.Text.Trim
        End With
        Dim frm As New frmInHoaDon
        frm.Text = "In hóa đơn "
        frm.CtrlInHoaDon1.tableChiTietHoaDon = lstChiTietHoaDon
        frm.CtrlInHoaDon1.HoaDon = newHoaDon
        frm.CtrlInHoaDon1.XemTruoc = True
        frm.CtrlInHoaDon1.SoDong = My.Settings.SoDongToiDa
        frm.Show()
    End Sub

    Private Sub dgvMain_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvMain.MouseClick
        Dim dgv As CustomDatagridview = sender
        dgv.EditMode = DataGridViewEditMode.EditOnEnter
    End Sub
End Class
