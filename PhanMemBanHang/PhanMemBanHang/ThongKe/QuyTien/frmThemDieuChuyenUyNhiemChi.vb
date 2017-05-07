Public Class frmThemDieuChuyenUyNhiemChi
    Private isSuaPhieu As Boolean
    Private _PhieuUyNhiemChi As tbPhieuUyNhiemChi
    Public Nganhang As tbNganHang
    Property PhieuUyNhiemChi As tbPhieuUyNhiemChi
        Get
            Return _PhieuUyNhiemChi
        End Get
        Set(value As tbPhieuUyNhiemChi)
            If value.idPhieuChuyenTien Is Nothing Then
                _PhieuUyNhiemChi = dt.tbPhieuUyNhiemChis.Single(Function(s) s.idPhieuChuyenTien = value.ID)
            Else
                _PhieuUyNhiemChi = value
            End If
            CapNhatPhieu(PhieuUyNhiemChi)
        End Set
    End Property
    Sub CapNhatPhieu(PhieuUyNhiemChi As tbPhieuUyNhiemChi)
        isSuaPhieu = True
        Dim PhieuGoc As tbPhieuUyNhiemChi
        If PhieuUyNhiemChi.idPhieuChuyenTien Is Nothing Then
            PhieuGoc = dt.tbPhieuUyNhiemChis.Single(Function(s) s.idPhieuChuyenTien = PhieuUyNhiemChi.ID)
        Else
            PhieuGoc = PhieuUyNhiemChi
        End If
        dtpNgayLap.Value = PhieuUyNhiemChi.NgayLap
        vndSoTien.Value = PhieuUyNhiemChi.SoTien
        vndMucPhi.Value = PhieuGoc.MucPhi
        txtChungTuKem.Text = PhieuGoc.ChungTuKemTheo
        txtNoiDung.Text = PhieuGoc.NoiDung
        CapNhatNganHang()
        CapNhatNganHangChuyenTien()
        cmbNganHang.SelectedItem = PhieuGoc.tbNganHang
        cmbNganHangNhanTien.SelectedItem = PhieuGoc.tbPhieuUyNhiemChi.tbNganHang
        txtSoPhieu.Text = dtpNgayLap.Value.ToString("yy") + "CT" + PhieuGoc.SoPhieu.ToString.PadLeft(3, "0")
        Me.Text = "SỬA ĐIỀU CHUYỂN TIỀN"
        btnThem.Text = "LƯU [F2]"
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
    Dim isNhaCungCap As Boolean = False
    Private Sub txtTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vndSoTien.KeyPress, txtChungTuKem.KeyPress, dtpNgayLap.KeyPress, txtNoiDung.KeyPress, cmbNganHangNhanTien.KeyPress, cmbNganHang.KeyPress, vndMucPhi.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then 'Hoặc Convert.ToChar(Keys.Enter)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Event ThemPhieuThanhCong()
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If isSuaPhieu = False Then
            If vndSoTien.Value = 0 Then
                ThongBao("Tiền chi phải lớn hơn 0")
                vndSoTien.Focus()
                Exit Sub
            End If
            If cmbNganHang.SelectedItem Is Nothing Then
                ThongBao("Chưa chọn ngân hàng chuyển tiền")
                cmbNganHang.Focus()
                Exit Sub
            End If
            If cmbNganHangNhanTien.SelectedItem Is Nothing Then
                ThongBao("Chưa chọn ngân hàng nhận tiền")
                cmbNganHang.Focus()
                Exit Sub
            End If
            LaySoPhieuUyNhiemChi(cmbNganHang.SelectedItem)
            Dim newPhieuThu As New tbPhieuUyNhiemChi
            With newPhieuThu
                .isPhieuThu = True
                .NgayLap = dtpNgayLap.Value
                .SoPhieu = txtSoPhieu.Tag
                .idNganHang = cmbNganHangNhanTien.SelectedItem.id
                .SoTien = vndSoTien.Value
                .NoiDung = txtNoiDung.Text
                .ChungTuKemTheo = txtChungTuKem.Text.Trim
                .MucPhi = 0
            End With
            Dim newPhieuChi As New tbPhieuUyNhiemChi
            With newPhieuChi
                .isPhieuThu = False
                .NgayLap = dtpNgayLap.Value
                .SoPhieu = txtSoPhieu.Tag
                .idNganHang = cmbNganHang.SelectedItem.id
                .SoTien = vndSoTien.Value
                .MucPhi = vndMucPhi.Value
                .NoiDung = txtNoiDung.Text
                .ChungTuKemTheo = txtChungTuKem.Text
                .tbPhieuUyNhiemChi = newPhieuThu
            End With
            dt.tbPhieuUyNhiemChis.InsertOnSubmit(newPhieuChi)
            Try
                dt.SubmitChanges()
                RaiseEvent ThemPhieuThanhCong()
                Me.Close()
            Catch ex As Exception
                ThongBao("Thêm phiếu thất bại" + vbNewLine + ex.Message)
                undoChange()
            End Try
        Else
            'SuaPhieu
            If vndSoTien.Value = 0 Then
                ThongBao("Tiền chi phải lớn hơn 0")
                vndSoTien.Focus()
                Exit Sub
            End If
            If cmbNganHang.SelectedItem Is Nothing Then
                ThongBao("Chưa chọn ngân hàng chuyển tiền")
                cmbNganHang.Focus()
                Exit Sub
            End If
            If cmbNganHangNhanTien.SelectedItem Is Nothing Then
                ThongBao("Chưa chọn ngân hàng nhận tiền")
                cmbNganHang.Focus()
                Exit Sub
            End If
            With PhieuUyNhiemChi.tbPhieuUyNhiemChi
                '.SoPhieu = txtSoPhieu.Tag
                .isPhieuThu = True
                .NgayLap = dtpNgayLap.Value
                .tbNganHang = cmbNganHangNhanTien.SelectedItem
                .SoTien = vndSoTien.Value
                .ChungTuKemTheo = txtChungTuKem.Text.Trim
                .MucPhi = 0
            End With
            With PhieuUyNhiemChi
                '.SoPhieu = txtSoPhieu.Tag
                .isPhieuThu = False
                .NgayLap = dtpNgayLap.Value
                .tbNganHang = cmbNganHang.SelectedItem
                .SoTien = vndSoTien.Value
                .MucPhi = vndMucPhi.Value
                .ChungTuKemTheo = txtChungTuKem.Text
            End With
            Try
                dt.SubmitChanges()
                RaiseEvent ThemPhieuThanhCong()
                Me.Close()
            Catch ex As Exception
                ThongBao("Sửa phiếu thất bại" + vbNewLine + ex.Message)
                undoChange()
            End Try
        End If
    End Sub
    Private Sub frmThemKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub frmThemPhieuThuTienMat_Load(sender As Object, e As EventArgs) Handles Me.Load
        If isSuaPhieu = False Then
            CapNhatNganHang()
            CapNhatNganHangChuyenTien()
            cmbNganHang.SelectedItem = Nganhang
        End If
    End Sub

    Private Sub txtKhachHang_Enter(sender As Object, e As EventArgs) Handles vndSoTien.Enter, txtChungTuKem.Enter
        Dim textbox = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        textbox.SelectAll() ' txtKhachHang.Text.Length
    End Sub
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
    Sub CapNhatNganHang()
        cmbNganHang.DataSource = From itm In dt.tbNganHangs
                                 Select itm
    End Sub
    Sub CapNhatNganHangChuyenTien()
        cmbNganHangNhanTien.DataSource = From itm In dt.tbNganHangs
                                         Select itm
    End Sub
    Sub CapNhatMaPhieuUyNhiemChi(NganHang As tbNganHang)
        If NganHang Is Nothing Then
            Exit Sub
        End If
        txtSoPhieu.Text = LaySoPhieuUyNhiemChi(NganHang).ToString().PadLeft(3, "0") + "CT" + Now.ToString("MMyy")
    End Sub
    Function LaySoPhieuUyNhiemChi(NganHang As tbNganHang)
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuUyNhiemChis
                            Where pn.NgayLap.Year = Now.Year
                            Where pn.idPhieuChuyenTien.HasValue
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
    Private Sub txtKhachHangUyNhiemChi_Enter(sender As Object, e As EventArgs)
        Dim textbox = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        ctrl.Location = New Point(textbox.Location.X, textbox.Location.Y + textbox.Size.Height)
    End Sub

    Private Sub nudSoPhieu_ValueChanged(sender As Object, e As EventArgs)
        txtSoPhieu.Tag = txtSoPhieu.Tag
        txtSoPhieu.Text = txtSoPhieu.ToString().PadLeft(3, "0") + "CT" + Now.ToString("MMyy")
    End Sub

End Class