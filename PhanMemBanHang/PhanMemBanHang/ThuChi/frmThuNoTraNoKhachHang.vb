Public Class frmThuNoTraNoKhachHang
    Dim ctrl As New ctrlDGVKhachHang
    Private _DongSauKhiThem As Boolean
    Dim _PhieuUyNhiemChi As tbPhieuUyNhiemChi
    Dim isSua As Boolean
    Property SuaPhieuUyNhiemChi As tbPhieuUyNhiemChi
        Get
            Return _PhieuUyNhiemChi
        End Get
        Set(value As tbPhieuUyNhiemChi)
            _PhieuUyNhiemChi = value
            CapNhatSuaPhieuUyNhiemChi()
        End Set
    End Property
    Sub CapNhatSuaPhieuUyNhiemChi()
        isSua = True
        txtMaPhieu.Text = SuaPhieuUyNhiemChi.MaPhieu
        txtMaPhieu.Tag = SuaPhieuUyNhiemChi.SoPhieu
        txtKhachHangTinhCongNo.Text = SuaPhieuUyNhiemChi.TenKhachHang
        txtKhachHangTinhCongNo.Tag = SuaPhieuUyNhiemChi.tbKhachHang
        txtKhachHang.Text = SuaPhieuUyNhiemChi.tbNganHangUyNhiemChi.tbKhachHang.TenKhachHang
        txtKhachHang.Tag = SuaPhieuUyNhiemChi.tbNganHangUyNhiemChi.tbKhachHang
        cmbNganHang.DataSource = From itm In dt.tbNganHangs
        cmbNganHangUyNhiemChi.DataSource = From itm In dt.tbNganHangUyNhiemChis
                                           Where itm.idKhachHang = CType(txtKhachHang.Tag, tbKhachHang).id
        If SuaPhieuUyNhiemChi.tbNganHang IsNot Nothing Then
            cmbNganHang.SelectedItem = dt.tbNganHangs.Single(Function(s) s.id = SuaPhieuUyNhiemChi.idNganHang)
        End If
        If SuaPhieuUyNhiemChi.tbNganHangUyNhiemChi IsNot Nothing Then
            cmbNganHang.SelectedItem = dt.tbNganHangUyNhiemChis.Single(Function(s) s.id = SuaPhieuUyNhiemChi.idNganHangUyNhiemChi)
        End If
        txtKhachHang.Text = SuaPhieuUyNhiemChi.tbNganHangUyNhiemChi.tbKhachHang.TenKhachHang
        txtKhachHang.Tag = SuaPhieuUyNhiemChi.tbNganHangUyNhiemChi.tbKhachHang
        txtGhiChu.Text = SuaPhieuUyNhiemChi.NoiDung
        txtChungTuKemTheo.Text = SuaPhieuUyNhiemChi.ChungTuKemTheo
        vndSoTienThu.Value = SuaPhieuUyNhiemChi.SoTien
        vndPhiChuyen.Value = SuaPhieuUyNhiemChi.MucPhi
        If SuaPhieuUyNhiemChi.isPhieuThu Then
            chkPhieuChi.Checked = False
            chkPhieuThu.Checked = True
        Else
            chkPhieuChi.Checked = True
            chkPhieuThu.Checked = False
        End If
    End Sub
    Property DongSauKhiThem As Boolean
        Get
            Return _DongSauKhiThem
        End Get
        Set(value As Boolean)
            _DongSauKhiThem = value
        End Set
    End Property
    Sub CapNhatUyNhiemChi(KhachHang As tbKhachHang)
        cmbNganHangUyNhiemChi.DataSource = From itm In dt.tbNganHangUyNhiemChis
                                           Where itm.idKhachHang = KhachHang.id
    End Sub
    Sub ChonKhachHang(KhachHang As tbKhachHang, sender As ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        sender.Text = KhachHang.TenKhachHang
        sender.Tag = KhachHang
        If sender.Name = "txtKhachHang" Then
            CapNhapPhieuXuatNhap(KhachHang)
            If isNhaCungCap Then
                vndTongTienHoaDon.Value = dt.LayCongNoCuNhaCungCap(Now, KhachHang.id)
                bsPhieuNhap.DataSource = From itm In dt.vwPhieuNhaps
                                         Where itm.idKhachHang = KhachHang.id
                                         Where Not itm.isThanhToan = True
            Else
                vndTongTienHoaDon.Value = dt.LayCongNoCuKhachHang(Now, KhachHang.id)
                bsPhieuXuat.DataSource = From itm In dt.vwPhieuXuats
                                         Where itm.idKhachHang = KhachHang.id
                                         Where Not itm.isThanhToan = True
            End If
            CapNhatUyNhiemChi(KhachHang)
            cmbNganHangUyNhiemChi.DataSource = From itm In dt.tbNganHangUyNhiemChis
                                               Where itm.idKhachHang = KhachHang.id
        Else
            vndTongTienHoaDon.Value = dt.LayCongNoCuNhaCungCap(Now, KhachHang.id)
        End If
    End Sub
    Dim rls As New List(Of clsPhieuNhapXuat)
    Sub CapNhapPhieuXuatNhap(KhachHang As tbKhachHang)
        Dim rlsPhieuNhap = From itm In dt.tbPhieuNhaps
                           Where itm.idKhachHang = KhachHang.id Or itm.idNhaCungCap = KhachHang.id
                           Where itm.isThanhToan = False Or itm.isThanhToan Is Nothing
                           Select New clsPhieuNhapXuat With {
                               .id = itm.id,
                               .MaPhieu = itm.MaPhieu,
                               .Loai = 1,
                               .idNhanVien = itm.idNhanVien,
                               .idNhaCungCap = itm.idNhaCungCap,
                               .idKhachHang = itm.idKhachHang,
                               .TenCongTrinh = itm.TenCongTrinh
                               }
        rls.AddRange(rls)
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
        Dim textbox = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        Dim key = BoDauTiengViet(textbox.Text.Trim)
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
            ctrl.Size = New Size(textbox.Size.Width, 380)
        Else
            ctrl.Visible = False
        End If
    End Sub

    Private Sub frmThuNoTraNoKhachHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height)
        Me.Controls.Add(ctrl)
        CapNhatNganHang()
        CapNhapSoPhieuChi()
        dgvPhieuNhap.BringToFront()
        chkUyNhiemChi.Focus()
        cmbNganHang_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub chkPhieuThu_CheckedChanged(sender As Object, e As EventArgs) Handles chkPhieuThu.CheckedChanged, chkPhieuChi.CheckedChanged
        If chkPhieuThu.Checked Then
            dgvPhieuXuat.BringToFront()
            If chkTienMat.Checked Then
                CapNhapSoPhieuThu()
            Else
                CapNhatSoPhieuUyNhiemChi()
            End If
            isNhaCungCap = False
            If txtKhachHang.Tag IsNot Nothing Then
                Dim idKhachHang As Integer = txtKhachHang.Tag.id
                bsPhieuXuat.DataSource = From itm In dt.vwPhieuXuats
                                         Where itm.idKhachHang = idKhachHang
                                         Where Not itm.isThanhToan = True
            Else
                bsPhieuXuat.DataSource = From itm In dt.vwPhieuXuats
                                         Where Not itm.isThanhToan = True
            End If

        Else
            dgvPhieuNhap.BringToFront()
            If chkTienMat.Checked Then
                CapNhapSoPhieuChi()
            Else
                CapNhatSoPhieuUyNhiemChi()
            End If
            isNhaCungCap = True
            If txtKhachHang.Tag IsNot Nothing Then
                Dim idKhachHang As Integer = txtKhachHang.Tag.id
                bsPhieuNhap.DataSource = From itm In dt.vwPhieuNhaps
                                         Where itm.idKhachHang = idKhachHang
                                         Where Not itm.isThanhToan = True
            Else
                bsPhieuNhap.DataSource = From itm In dt.vwPhieuNhaps
                                         Where Not itm.isThanhToan = True
            End If

        End If
    End Sub
    Private Function DongYSuaPhieuUyNhiemChi() As tbPhieuUyNhiemChi
        If txtKhachHang.Tag Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhà cung cấp,", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKhachHang.Focus()
            Return Nothing
        End If
        If chkUyNhiemChi.Checked Then
            If cmbNganHang.SelectedItem Is Nothing Then
                ThongBao("VUi lòng nhập ngân hàng chuyển tiền đi")
                Return Nothing
            End If
            If cmbNganHangUyNhiemChi.SelectedItem Is Nothing Then
                ThongBao("Vui lòng nhập ngân hàng của khách hàng")
            End If
        End If
        With SuaPhieuUyNhiemChi
            .tbNganHang = cmbNganHang.SelectedItem
            .tbNganHangUyNhiemChi = cmbNganHangUyNhiemChi.SelectedItem
            .tbKhachHang = txtKhachHang.Tag
            .SoTien = vndSoTienThu.Value
            .MucPhi = vndPhiChuyen.Value
            .NoiDung = txtGhiChu.Text
            .ChungTuKemTheo = txtChungTuKemTheo.Text
            .isPhieuThu = chkPhieuThu.Checked
        End With
        Try
            dt.SubmitChanges()
            'Trả lại trại thái ban đầu
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            ThongBao("Sửa phiếu ủy nhiệm chi thất bại" + ex.Message)
            undoChange()
        End Try
        Return SuaPhieuUyNhiemChi
    End Function
    Private Function DongYPhieuUyNhiemChi() As tbPhieuUyNhiemChi
        If txtKhachHang.Tag Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhà cung cấp,", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKhachHang.Focus()
            Return Nothing
        End If

        If vndSoTienThu.Value = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập số tiền trả nợ cho nhà cung cấp,", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            vndSoTienThu.Focus()
            Return Nothing
        End If
        If chkPhieuChi.Checked Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn xác nhận trả cho KH/NCC " + txtKhachHang.Text + " " + vndSoTienThu.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                Return Nothing
            End If
        Else
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn xác nhận thu cho KH/NCC " + txtKhachHang.Text + " " + vndSoTienThu.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                Return Nothing
            End If
        End If
        If chkUyNhiemChi.Checked Then
            If cmbNganHang.SelectedItem Is Nothing Then
                ThongBao("VUi lòng nhập ngân hàng chuyển tiền đi")
                Return Nothing
            End If
            If cmbNganHangUyNhiemChi.SelectedItem Is Nothing Then
                ThongBao("Vui lòng nhập ngân hàng của khách hàng")
            End If
        End If
        Dim newPhieuUyNhiemChi As New tbPhieuUyNhiemChi
        With newPhieuUyNhiemChi
            .SoPhieu = txtMaPhieu.Tag
            .NgayLap = Now.Date
            .idNganHang = cmbNganHang.SelectedItem.id
            .idNganHangUyNhiemChi = cmbNganHangUyNhiemChi.SelectedItem.id
            .idKhachHangTinhCongNo = txtKhachHang.Tag.id
            .SoTien = vndSoTienThu.Value
            .MucPhi = vndPhiChuyen.Value
            .NoiDung = txtGhiChu.Text
            .ChungTuKemTheo = txtChungTuKemTheo.Text
            .isPhieuThu = chkPhieuThu.Checked
        End With
        dt.tbPhieuUyNhiemChis.InsertOnSubmit(newPhieuUyNhiemChi)
        Try
            dt.SubmitChanges()
            'Trả lại trại thái ban đầu
            txtKhachHang.Tag = Nothing
            txtKhachHang.Text = ""
            txtKhachHangTinhCongNo.Text = ""
            txtKhachHangTinhCongNo.Tag = Nothing
            txtGhiChu.Text = ""
            txtChungTuKemTheo.Text = ""
            vndSoTienThu.Text = 0
            vndTongTienHoaDon.Text = 0
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            ThongBao("Tạo phiếu ủy nhiệm chi thất bại" + ex.Message)
            undoChange()
        End Try
        Return newPhieuUyNhiemChi
    End Function
    Private Sub btnDongY_Click(sender As Object, e As EventArgs) Handles btnDongY.Click
        If isSua = True Then
            DongYSuaPhieuUyNhiemChi()
        Else
            If chkTienMat.Checked Then
                If chkPhieuChi.Checked Then
                    Dim PhieuChi = DongYPhieuChi()
                    If PhieuChi IsNot Nothing Then
                        ThongBao("Đã tạo phiếu " + PhieuChi.MaPhieu + " thành công")
                    End If
                Else
                    Dim PhieuThu = DongYPhieuThu()
                    If PhieuThu IsNot Nothing Then
                        ThongBao("Đã tạo phiếu " + PhieuThu.MaPhieu + " thành công")
                    End If
                End If
            ElseIf chkUyNhiemChi.Checked Then
                Dim PhieuChi = DongYPhieuUyNhiemChi()
                If PhieuChi IsNot Nothing Then
                    ThongBao("Đã tạo phiếu " + PhieuChi.MaPhieu.Trim + " thành công")
                End If
            End If
        End If
    End Sub
    Function LaySoPhieuChiMoiNhat() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbTraNoNhaCungCaps
                            Where pn.NgayTra.Year = Now.Year
                            Order By pn.id Descending
                            Select pn).FirstOrDefault
        If HoaDonCuNhat Is Nothing Then
            txtMaPhieu.Tag = 1
            Return 1
        Else
            txtMaPhieu.Tag = HoaDonCuNhat.SoPhieu + 1
            Return HoaDonCuNhat.SoPhieu + 1
        End If
    End Function
    Function LaySoPhieuThuMoiNhat() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbThuNoKhachHangs
                            Where pn.NgayThu.Year = Now.Year
                            Order By pn.id Descending
                            Select pn).FirstOrDefault
        If HoaDonCuNhat Is Nothing Then
            txtMaPhieu.Tag = 1
            Return 1
        Else
            txtMaPhieu.Tag = HoaDonCuNhat.SoPhieu + 1
            Return HoaDonCuNhat.SoPhieu + 1
        End If
    End Function
    Sub CapNhapSoPhieuChi()
        txtMaPhieu.Text = Now.ToString("MMyy") + "C" + LaySoPhieuChiMoiNhat.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
    End Sub
    Sub CapNhatSoPhieuUyNhiemChi()
        txtMaPhieu.Text = Now.ToString("MMyy") + "C" + LaySoPhieuChiMoiNhat.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
    End Sub
    Sub CapNhapSoPhieuThu()
        txtMaPhieu.Text = Now.ToString("MMyy") + "T" + LaySoPhieuThuMoiNhat.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
    End Sub
    Event ThemPhieuThanhCong()
    Function DongYPhieuChi() As tbTraNoNhaCungCap
        If txtKhachHang.Tag Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhà cung cấp,", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKhachHang.Focus()
            Return Nothing
        End If

        If vndSoTienThu.Value = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập số tiền trả nợ cho nhà cung cấp,", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            vndSoTienThu.Focus()
            Return Nothing
        End If

        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn xác nhận trả cho nhà cung cấp " + txtKhachHang.Text + " " + vndSoTienThu.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
            Return Nothing
        End If
        CapNhapSoPhieuChi()
        Dim newThuNo As New tbTraNoNhaCungCap
        newThuNo.idKhachHang = txtKhachHang.Tag.id
        newThuNo.NgayTra = Now.Date
        newThuNo.SoTien = vndSoTienThu.Value
        newThuNo.idNhanVien = loginNhanVien.id
        newThuNo.GhiChu = txtGhiChu.Text
        newThuNo.SoPhieu = txtMaPhieu.Tag
        newThuNo.ChungTuKemTheo = txtChungTuKemTheo.Text
        dt.tbTraNoNhaCungCaps.InsertOnSubmit(newThuNo)
        Try
            dt.SubmitChanges()
            RaiseEvent ThemPhieuThanhCong()
            txtKhachHang.Text = ""
            txtKhachHang.Tag = Nothing
            CapNhapSoPhieuChi()
            vndSoTienThu.Value = 0
            If DongSauKhiThem Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            Return newThuNo
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm phiếu trả nợ nhà cung cấp thất bại." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End Try
    End Function
    Function DongYPhieuThu() As tbThuNoKhachHang
        If txtKhachHang.Tag Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKhachHang.Focus()
            Return Nothing
        End If

        If vndSoTienThu.Value = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập số tiền khách hàng trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            vndSoTienThu.Focus()
            Return Nothing
        End If

        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn xác nhận thu nợ khách hàng " + txtKhachHang.Text + " " + vndSoTienThu.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
            Return Nothing
        End If
        CapNhapSoPhieuThu()
        Dim newThuNo As New tbThuNoKhachHang
        With newThuNo
            'Do
            .idKhachHang = txtKhachHang.Tag.id
            .NgayThu = Now.Date
            .SoTien = vndSoTienThu.Value
            .GhiChu = txtGhiChu.Text
            .idNhanVien = loginNhanVien.id
            .SoPhieu = txtMaPhieu.Tag
            .ChungTuKemTheo = txtChungTuKemTheo.Text
            dt.tbThuNoKhachHangs.InsertOnSubmit(newThuNo)
        End With
        Try
            dt.SubmitChanges()
            RaiseEvent ThemPhieuThanhCong()
            If DongSauKhiThem Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            CapNhapSoPhieuThu()
            txtKhachHang.Text = ""
            txtKhachHang.Tag = Nothing
            vndTongTienHoaDon.Value = 0
            vndSoTienThu.Value = 0
            Return newThuNo
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm phiếu thu nợ khách hàng thất bại." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        End Try
    End Function
    Private Sub vndSoTienThu_TextChanged(sender As Object, e As EventArgs) Handles vndSoTienThu.TextChanged, vndPhiChuyen.TextChanged
        vndSoTienConLai.Value = vndTongTienHoaDon.Value - vndSoTienThu.Value - vndPhiChuyen.Value
    End Sub
    Sub CapNhatNganHang()
        cmbNganHang.DataSource = From itm In dt.tbNganHangs
                                 Order By itm.TenNganHang
    End Sub


    Private Sub chkUyNhiemChi_CheckedChanged(sender As Object, e As EventArgs) Handles chkUyNhiemChi.CheckedChanged
        If chkUyNhiemChi.Checked Then
            cmbNganHang.Enabled = True
            cmbNganHangUyNhiemChi.Enabled = True
            txtKhachHangTinhCongNo.Enabled = True
            CapNhatMaPhieuUyNhiemChi(cmbNganHang.SelectedItem)
        Else
            cmbNganHang.Enabled = False
            cmbNganHangUyNhiemChi.Enabled = False
            txtKhachHangTinhCongNo.Enabled = False
        End If
    End Sub
    Function LaySoPhieuUyNhiemChi(NganHang As tbNganHang)
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuUyNhiemChis
                            Where pn.NgayLap.Year = Now.Year
                            Where pn.idNganHang = NganHang.id
                            Order By pn.ID Descending
                            Select pn).FirstOrDefault
        If HoaDonCuNhat Is Nothing Then
            txtMaPhieu.Tag = 1
            Return 1
        Else
            txtMaPhieu.Tag = HoaDonCuNhat.SoPhieu + 1
            Return HoaDonCuNhat.SoPhieu + 1
        End If
    End Function
    Sub CapNhatMaPhieuUyNhiemChi(NganHang As tbNganHang)
        If NganHang Is Nothing Then
            Exit Sub
        End If
        txtMaPhieu.Text = LaySoPhieuUyNhiemChi(NganHang).ToString().PadLeft(3, "0") + Now.ToString("/yy") + NganHang.MaNganHang
    End Sub
    Private Sub cmbNganHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNganHang.SelectedIndexChanged
        If cmbNganHang.SelectedItem Is Nothing Then
            Exit Sub
        End If
        CapNhatMaPhieuUyNhiemChi(cmbNganHang.SelectedItem)
    End Sub

    Private Sub txtKhachHang_Enter(sender As Object, e As EventArgs) Handles txtKhachHang.Enter, txtKhachHangTinhCongNo.Enter
        Dim txtText = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        ctrl.Location = New Point(txtText.Location.X, txtText.Location.Y + txtText.Size.Height)
    End Sub

    Private Sub chkTienMat_CheckedChanged(sender As Object, e As EventArgs) Handles chkTienMat.CheckedChanged
        If chkTienMat.Checked Then
            chkPhieuThu_CheckedChanged(Nothing, Nothing)
        Else
            chkUyNhiemChi_CheckedChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub vndSoTienThu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vndSoTienThu.KeyPress, vndPhiChuyen.KeyPress, txtChungTuKemTheo.KeyPress, txtGhiChu.KeyPress, txtKhachHang.KeyPress, txtKhachHangTinhCongNo.KeyPress, cmbNganHangUyNhiemChi.KeyPress, cmbNganHang.KeyPress, chkUyNhiemChi.KeyPress, chkTienMat.KeyPress, chkPhieuThu.KeyPress, chkPhieuChi.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkUyNhiemChi_BamEnter() Handles chkUyNhiemChi.BamEnter, chkPhieuChi.BamEnter, chkTienMat.BamEnter, chkPhieuThu.BamEnter
        SendKeys.Send("{TAB}")
    End Sub

End Class