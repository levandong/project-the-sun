Public Class frmThemPhieuChiTienMat
    Private _PhieuUyNhiemChi As tbPhieuUyNhiemChi
    Private _isSuaPhieu As Boolean
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
        ChonKhachHang(PhieuUyNhiemChi.tbKhachHang)
        dtpNgayLap.Value = PhieuUyNhiemChi.NgayLap
        vndSoTien.Value = PhieuUyNhiemChi.SoTien
        txtChungTuKem.Text = PhieuUyNhiemChi.ChungTuKemTheo
        txtSoPhieu.Tag = PhieuUyNhiemChi.SoPhieu
        txtNoiDung.Text = PhieuUyNhiemChi.NoiDung
        txtSoPhieu.Text = dtpNgayLap.Value.ToString("MMyy") + "T" + txtSoPhieu.Tag.ToString.PadLeft(3, "0")
        Me.Text = "SỬA PHIẾU CHI TIỀN MẶT"
        btnThem.Text = "LƯU [F2]"
    End Sub
    Function CapNhatSoPhieu() As Integer
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuChis
                            Where pn.NgayLap.Year = dtpNgayLap.Value.Year
                            Where pn.idNganHang = dt.tbNganHangs.Single(Function(s) s.isTienMat = True).id
                            Order By pn.id Descending
                            Select pn).FirstOrDefault
        Dim SoPhieu = (From itm In dt.tbPhieuUyNhiemChis
                       Where itm.isPhieuThu = False
                       Where itm.NgayLap.Year = dtpNgayLap.Value.Year
                       Where itm.idNganHang = dt.tbNganHangs.Single(Function(s) s.isTienMat = True).id
                       Order By itm.ID Descending).FirstOrDefault
        If HoaDonCuNhat Is Nothing Then
            If SoPhieu IsNot Nothing Then
                txtSoPhieu.Tag = SoPhieu.SoPhieu + 1
                Return SoPhieu.SoPhieu + 1
            Else
                txtSoPhieu.Tag = 1
                Return 1
            End If
        Else
            If SoPhieu IsNot Nothing Then
                If SoPhieu.SoPhieu > HoaDonCuNhat.SoPhieu Then
                    txtSoPhieu.Tag = SoPhieu.SoPhieu + 1
                    Return SoPhieu.SoPhieu + 1
                Else
                    txtSoPhieu.Tag = HoaDonCuNhat.SoPhieu + 1
                    Return HoaDonCuNhat.SoPhieu + 1
                End If
            Else
                txtSoPhieu.Tag = HoaDonCuNhat.SoPhieu + 1
                Return HoaDonCuNhat.SoPhieu + 1
            End If
        End If
    End Function
    Sub CapNhatMaPhieu()
        txtSoPhieu.Tag = CapNhatSoPhieu()
        txtSoPhieu.Text = dtpNgayLap.Value.ToString("MMyy") + "C" + txtSoPhieu.Tag.ToString.PadLeft(3, "0")
    End Sub
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
    Private Sub txtKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtKhachHang.TextChanged
        Dim key = BoDauTiengViet(txtKhachHang.Text.Trim)
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
    Private Sub txtKhachHang_Leave(sender As Object, e As EventArgs) Handles txtKhachHang.Leave
        If txtKhachHang.Tag IsNot Nothing Then
            txtKhachHang.Text = txtKhachHang.Tag.TenKhachHang
        End If
    End Sub
    Private Sub txtTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vndSoTien.KeyPress, txtChungTuKem.KeyPress, txtKhachHang.KeyPress, dtpNgayLap.KeyPress, txtNoiDung.KeyPress
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
        If _isSuaPhieu = False Then
            CapNhatMaPhieu()
            Dim newPhieuChi As New tbPhieuUyNhiemChi
            With newPhieuChi
                .NgayLap = dtpNgayLap.Value
                .isPhieuThu = False
                .SoPhieu = txtSoPhieu.Tag
                .idNganHang = dt.tbNganHangs.Single(Function(s) s.isTienMat = True).id
                .idKhachHangTinhCongNo = txtKhachHang.Tag.id
                .SoTien = vndSoTien.Value
                .MucPhi = 0
                .NoiDung = txtNoiDung.Text
                .ChungTuKemTheo = txtChungTuKem.Text
            End With
            dt.tbPhieuUyNhiemChis.InsertOnSubmit(newPhieuChi)
        Else
            With PhieuUyNhiemChi
                .SoPhieu = txtSoPhieu.Tag
                .NgayLap = dtpNgayLap.Value
                .tbKhachHang = txtKhachHang.Tag
                .SoTien = vndSoTien.Value
                .MucPhi = 0
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

    Private Sub frmThemPhieuThuTienMat_Load(sender As Object, e As EventArgs) Handles Me.Load
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height)
        Me.Controls.Add(ctrl)
        If _isSuaPhieu = False Then
            CapNhatMaPhieu()
        End If
    End Sub

    Private Sub txtKhachHang_Enter(sender As Object, e As EventArgs) Handles txtKhachHang.Enter, vndSoTien.Enter, txtChungTuKem.Enter
        Dim textbox = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        textbox.SelectAll() ' txtKhachHang.Text.Length
    End Sub
    Private Sub frmThemKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmThemPhieuChiTienMat_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtKhachHang.Focus()
    End Sub

    Private Sub nudSoPhieu_ValueChanged(sender As Object, e As EventArgs)
        txtSoPhieu.Tag = txtSoPhieu.Tag
        txtSoPhieu.Text = dtpNgayLap.Value.ToString("MMyy") + "C" + txtSoPhieu.Tag.ToString.PadLeft(3, "0")
    End Sub
End Class