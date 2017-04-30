Public Class frmThemPhieuThuUyNhiemChi
    Private _PhieuUyNhiemChi As tbPhieuUyNhiemChi
    Private _isSuaPhieu As Boolean
    Public NganHang As tbNganHang
    Property PhieuUyNhiemChi As tbPhieuUyNhiemChi
        Get
            Return _PhieuUyNhiemChi
        End Get
        Set(value As tbPhieuUyNhiemChi)
            _PhieuUyNhiemChi = value
            CapNhatPhieuUyNhiemChi(PhieuUyNhiemChi)
        End Set
    End Property
    Sub CapNhatPhieuUyNhiemChi(PhieuUyNhiemChi As tbPhieuUyNhiemChi)
        _isSuaPhieu = True
        CapNhatNganHang()
        cmbNganHang.SelectedItem = PhieuUyNhiemChi.tbNganHang
        ChonKhachHang(PhieuUyNhiemChi.tbKhachHang, txtKhachHang)
        ChonKhachHang(PhieuUyNhiemChi.tbKhachHang1, txtKhachHangUyNhiemChi)
        cmbNganHangUyNhiemChi.DataSource = From itm In dt.tbNganHangUyNhiemChis
                                           Where itm.idKhachHang = PhieuUyNhiemChi.tbKhachHang1.id
        cmbNganHangUyNhiemChi.SelectedItem = PhieuUyNhiemChi.tbNganHangUyNhiemChi
        vndMucPhi.Value = PhieuUyNhiemChi.MucPhi
        dtpNgayLap.Value = PhieuUyNhiemChi.NgayLap
        vndSoTien.Value = PhieuUyNhiemChi.SoTien
        txtChungTuKem.Text = PhieuUyNhiemChi.ChungTuKemTheo
        txtSoPhieu.Tag = PhieuUyNhiemChi.SoPhieu
        txtNoiDung.Text = PhieuUyNhiemChi.NoiDung
        txtSoPhieu.Text = txtSoPhieu.Tag.ToString.PadLeft(3, "0") + dtpNgayLap.Value.ToString("/yy") + cmbNganHang.SelectedItem.MaNganHang
        Me.Text = "SỬA LẬP ỦY NHIỆM CHI"
        btnThem.Text = "LƯU [F2]"
    End Sub
    Function CapNhatSoPhieu() As Integer
        If dt.tbPhieuUyNhiemChis.Count = 0 Then
            Return 1
        Else
            Dim SoPhieu = (From itm In dt.tbPhieuUyNhiemChis
                           Where itm.isPhieuThu = True
                           Where itm.NgayLap.Year = dtpNgayLap.Value.Year
                           Order By itm.ID Descending).FirstOrDefault
            If SoPhieu Is Nothing Then
                Return 1
            Else
                Return SoPhieu.SoPhieu + 1
            End If
        End If
    End Function
    Dim i As Integer = 0
    'fotmat ngày tháng năm thành dd/MM/yy nếu không thêm 1 điều kiện
    Private Sub dtpNgayNiemYet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpNgayLap.KeyPress
        i += 1
        If i = 2 Then
            SendKeys.Send("{DIVIDE}")
            i = -1
        End If
    End Sub
    Dim ctrl As New ctrlDGVKhachHang
    Private Sub txtKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtKhachHang.TextChanged, txtKhachHangUyNhiemChi.TextChanged
        Dim key = BoDauTiengViet(sender.Text.Trim)
        ctrl.BringToFront()
        If key <> "" Then
            ctrl.Visible = True
            ctrl.bsKhachHang.DataSource = From itm In dt.vwKhachHangs
                                          Where itm.MaKhachHang.Contains(key) Or itm.TenKhachHangString.Contains(key) Or itm.MaSoThue.StartsWith(key)
            If ctrl.bsKhachHang.Count = 0 Then
                ctrl.Visible = False
            End If
            ctrl.Size = New Size(txtKhachHang.Size.Width, 380)
        Else
            ctrl.Visible = False
        End If
    End Sub
    Sub ChonKhachHang(KhachHang As tbKhachHang, sender As ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        sender.Text = KhachHang.TenKhachHang
        sender.Tag = KhachHang
        If sender.Name = "txtKhachHang" Then
            txtKhachHangUyNhiemChi.Text = KhachHang.TenKhachHang
            txtKhachHangUyNhiemChi.Tag = KhachHang
        Else
            cmbNganHangUyNhiemChi.DataSource = From itm In dt.tbNganHangUyNhiemChis
                                               Where itm.idKhachHang = KhachHang.id
        End If

    End Sub
    Private Sub txtKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKhachHang.KeyDown, txtKhachHangUyNhiemChi.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vKhachHang As vwKhachHang = ctrl.bsKhachHang.Current
            If vKhachHang Is Nothing Then
                Exit Sub
            End If
            Dim Khachhang As tbKhachHang = dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id)
            ChonKhachHang(Khachhang, CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox))
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
    Private Sub txtKhachHang_Leave(sender As Object, e As EventArgs) Handles txtKhachHang.Leave, txtKhachHangUyNhiemChi.Leave
        If txtKhachHang.Tag IsNot Nothing Then
            txtKhachHang.Text = txtKhachHang.Tag.TenKhachHang
        End If
        If txtKhachHangUyNhiemChi.Tag IsNot Nothing Then
            txtKhachHangUyNhiemChi.Text = txtKhachHangUyNhiemChi.Tag.TenKhachHang
        End If
    End Sub
    Private Sub txtTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vndSoTien.KeyPress, txtChungTuKem.KeyPress, txtNoiDung.KeyPress, txtKhachHang.KeyPress, dtpNgayLap.KeyPress, vndMucPhi.KeyPress, txtKhachHangUyNhiemChi.KeyPress, cmbNganHang.KeyPress, cmbNganHangUyNhiemChi.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then 'Hoặc Convert.ToChar(Keys.Enter)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Event ThemPhieuThanhCong()
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtKhachHang.Tag Is Nothing Then
            ThongBao("Nhập đơn vị thu tiền")
            txtKhachHang.Focus()
            Exit Sub
        End If
        If vndSoTien.Value = 0 Then
            ThongBao("Tiền chi phải lớn hơn 0")
            vndSoTien.Focus()
            Exit Sub
        End If
        If cmbNganHang.SelectedItem Is Nothing Then
            ThongBao("Chưa chọn ngân hàng")
            cmbNganHang.Focus()
            Exit Sub
        End If
        If cmbNganHangUyNhiemChi.SelectedItem Is Nothing Then
            ThongBao("Chưa chọn ngân hàng nhận tiền")
            cmbNganHang.Focus()
            Exit Sub
        End If
        If _isSuaPhieu = False Then
            CapNhatSoPhieu()
            Dim newPhieuChi As New tbPhieuUyNhiemChi
            With newPhieuChi
                .isPhieuThu = False
                .SoPhieu = txtSoPhieu.Tag
                .idNganHang = cmbNganHang.SelectedItem.id
                .idNganHangUyNhiemChi = cmbNganHangUyNhiemChi.SelectedItem.id
                .idKhachHangTinhCongNo = txtKhachHang.Tag.id
                .SoTien = vndSoTien.Value
                .MucPhi = vndMucPhi.Value
                .NgayLap = dtpNgayLap.Value
                .idKhachHangUyNhiemChi = txtKhachHangUyNhiemChi.Tag.id
                .NoiDung = txtNoiDung.Text
                .ChungTuKemTheo = txtChungTuKem.Text
            End With
            dt.tbPhieuUyNhiemChis.InsertOnSubmit(newPhieuChi)
        Else
            With PhieuUyNhiemChi
                If .tbNganHang.id <> cmbNganHang.SelectedItem.id Then
                    .SoPhieu = LaySoPhieuUyNhiemChi(cmbNganHang.SelectedItem)
                End If
                .tbNganHang = cmbNganHang.SelectedItem
                .tbNganHangUyNhiemChi = cmbNganHangUyNhiemChi.SelectedItem
                .tbKhachHang = txtKhachHang.Tag
                .SoTien = vndSoTien.Value
                .MucPhi = vndMucPhi.Value
                .NgayLap = dtpNgayLap.Value
                .tbKhachHang1 = txtKhachHangUyNhiemChi.Tag
                .NoiDung = txtNoiDung.Text
                .ChungTuKemTheo = txtChungTuKem.Text
            End With
        End If
        Try
            dt.SubmitChanges()
            RaiseEvent ThemPhieuThanhCong()
            Me.Close()
        Catch ex As Exception
            ThongBao("Thêm phiếu thất bại" + vbNewLine + ex.Message)
            undoChange()
        End Try
    End Sub
    Private Sub frmThemKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub frmThemPhieuThuTienMat_Load(sender As Object, e As EventArgs) Handles Me.Load
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height)
        Me.Controls.Add(ctrl)
        If _isSuaPhieu Then Exit Sub
        txtKhachHang.Focus()
        CapNhatNganHang()
        cmbNganHang.SelectedItem = NganHang
    End Sub

    Private Sub txtKhachHang_Enter(sender As Object, e As EventArgs) Handles vndSoTien.Enter, txtNoiDung.Enter, txtChungTuKem.Enter
        Dim textbox = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        textbox.SelectAll() ' txtKhachHang.Text.Length
    End Sub
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
    Sub CapNhatUyNhiemChi(KhachHang As tbKhachHang)
        cmbNganHangUyNhiemChi.DataSource = From itm In dt.tbNganHangUyNhiemChis
                                           Where itm.idKhachHang = KhachHang.id
    End Sub
    Sub CapNhatNganHang()
        cmbNganHang.DataSource = From itm In dt.tbNganHangs
                                 Where itm.isTienMat <> True
                                 Select itm
    End Sub
    Sub CapNhatMaPhieuUyNhiemChi(NganHang As tbNganHang)
        If NganHang Is Nothing Then
            Exit Sub
        End If
        txtSoPhieu.Text = LaySoPhieuUyNhiemChi(NganHang).ToString().PadLeft(3, "0") + Now.ToString("/yy") + NganHang.MaNganHang
    End Sub
    Function LaySoPhieuUyNhiemChi(NganHang As tbNganHang)
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuUyNhiemChis
                            Where pn.NgayLap.Year = Now.Year
                            Where pn.idNganHang = NganHang.id
                            Where pn.isPhieuThu = False
                            Where pn.idPhieuChuyenTien.HasValue = False
                            Where pn.tbPhieuUyNhiemChi Is Nothing
                            Order By pn.ID Descending
                            Select pn).FirstOrDefault
        If HoaDonCuNhat Is Nothing Then
            txtSoPhieu.Tag = 1
            Return 1
        Else
            txtSoPhieu.Tag = HoaDonCuNhat.SoPhieu + 1
            Return HoaDonCuNhat.SoPhieu + 1
        End If
    End Function
    Private Sub cmbNganHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNganHang.SelectedIndexChanged
        If cmbNganHang.SelectedItem Is Nothing Then
            Exit Sub
        End If
        CapNhatMaPhieuUyNhiemChi(cmbNganHang.SelectedItem)
    End Sub
    Private Sub txtKhachHangUyNhiemChi_Enter(sender As Object, e As EventArgs) Handles txtKhachHangUyNhiemChi.Enter, txtKhachHang.Enter
        Dim textbox = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        ctrl.Location = New Point(textbox.Location.X, textbox.Location.Y + textbox.Size.Height)
    End Sub

    Private Sub cmbNganHangUyNhiemChi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNganHangUyNhiemChi.SelectedIndexChanged
        lblChuTaiKhoan.Text = CType(cmbNganHangUyNhiemChi.SelectedItem, tbNganHangUyNhiemChi).TenChuTaiKhoan
    End Sub
End Class