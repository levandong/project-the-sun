Public Class frmThemPhieuChiTheoLoai
    Event ThemPhieuThanhCong()
    Private _PhieuChi As tbPhieuChi
    Private _isSuaPhieu As Boolean
    Public NganHang As tbNganHang
    Property PhieuChi As tbPhieuChi
        Get
            Return _PhieuChi
        End Get
        Set(value As tbPhieuChi)
            _PhieuChi = value
            CapNhatPhieuUyNhiemChi(PhieuChi)
        End Set
    End Property
    Sub CapNhatPhieuUyNhiemChi(PhieuChi As tbPhieuChi)
        _isSuaPhieu = True
        cmbLoaiPhieuChi.DataSource = From itm In dt.tbLoaiPhieuChis
                                     Where itm.Loai > 0
                                     Select itm
        cmbLoaiPhieuChi.SelectedItem = PhieuChi.tbLoaiPhieuChi
        cmbNganHang.DataSource = From itm In dt.tbNganHangs
                                 Select itm
        cmbNganHang.SelectedItem = PhieuChi.tbNganHang
        dtpNgayChi.Value = PhieuChi.NgayLap
        vndSoTien.Value = PhieuChi.SoTien
        txtLyDo.Text = PhieuChi.LyDo
        txtSoPhieu.Tag = PhieuChi.SoPhieu
        vndPhi.Value = PhieuChi.MucPhi
        txtSoPhieu.Text = dtpNgayChi.Value.ToString("MMyy") + "C" + txtSoPhieu.Tag.ToString.PadLeft(3, "0")
        Me.Text = "SỬA PHIẾU CHI "
        btnThem.Text = "LƯU [F2]"
    End Sub
    Private Sub myComboBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLoaiPhieuChi.GotFocus, cmbNganHang.GotFocus
        sender.DroppedDown = True
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If vndSoTien.Value = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Số tiền chi phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If _isSuaPhieu = False Then
            btnLaySoPhieu_Click(Nothing, Nothing)
            Dim newPhieu As New tbPhieuChi
            With newPhieu
                .HinhThucThanhToan = ""
                .NgayLap = dtpNgayChi.Value
                .SoTien = vndSoTien.Value
                .TenNguoiNhan = ""
                .DiaChi = ""
                .NguoiChiTien = ""
                .ChungTuKemTheo = ""
                .LyDo = txtLyDo.Text
                .idNganHang = cmbNganHang.SelectedItem.id
                .SoPhieu = txtSoPhieu.Tag
                .MucPhi = vndPhi.Value
                .idLoaiPhieuChi = cmbLoaiPhieuChi.SelectedItem.id
                .idNhanVien = loginNhanVien.id
            End With
            dt.tbPhieuChis.InsertOnSubmit(newPhieu)
        Else
            With PhieuChi
                .HinhThucThanhToan = ""
                .NgayLap = dtpNgayChi.Value
                .SoTien = vndSoTien.Value
                .TenNguoiNhan = ""
                .DiaChi = ""
                .NguoiChiTien = ""
                .ChungTuKemTheo = ""
                .LyDo = txtLyDo.Text
                .tbNganHang = cmbNganHang.SelectedItem
                .SoPhieu = txtSoPhieu.Tag
                .MucPhi = vndPhi.Value
                .tbLoaiPhieuChi = cmbLoaiPhieuChi.SelectedItem
                .idNhanVien = loginNhanVien.id
            End With
        End If
        dt.SubmitChanges()
        RaiseEvent ThemPhieuThanhCong()
        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Private Function LaySoHoaDonMoiNhat() As Integer
        Dim NganHang = CType(cmbNganHang.SelectedItem, tbNganHang)
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuChis
                            Where pn.NgayLap.Year = dtpNgayChi.Value.Year
                            Where pn.idNganHang = NganHang.id
                            Order By pn.id Descending
                            Select pn).FirstOrDefault
        Dim SoPhieu = (From itm In dt.tbPhieuUyNhiemChis
                       Where itm.isPhieuThu = False
                       Where itm.NgayLap.Year = dtpNgayChi.Value.Year
                       Where itm.idNganHang = NganHang.id
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
    Sub CapNhatLoaiPhieuChi()
        cmbLoaiPhieuChi.DataSource = From itm In dt.tbLoaiPhieuChis
                                     Where itm.Loai > 0
    End Sub
    Private Sub frmThemPhieuChi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub frmThemPhieuChi_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmThemPhieuChi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        If _isSuaPhieu Then Exit Sub
        cmbNganHang.DataSource = From itm In dt.tbNganHangs Order By itm.TenNganHang
        cmbNganHang.SelectedItem = NganHang
        btnLaySoPhieu_Click(Nothing, Nothing)
        CapNhatLoaiPhieuChi()
    End Sub

    Private Sub btnLaySoPhieu_Click(sender As Object, e As EventArgs) Handles btnLaySoPhieu.Click
        txtSoPhieu.Text = dtpNgayChi.Value.ToString("MMyy") + "C" + LaySoHoaDonMoiNhat.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
    End Sub

    Private Sub txtMaVach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vndSoTien.KeyPress, txtLyDo.KeyPress, dtpNgayChi.KeyPress, cmbLoaiPhieuChi.KeyPress, cmbNganHang.KeyPress, vndPhi.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then 'Hoặc Convert.ToChar(Keys.Enter)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    'fotmat ngày tháng năm thành dd/MM/yy nếu không thêm 1 điều kiện
    Dim i As Integer = 0
    Private Sub dtpNgayNiemYet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpNgayChi.KeyPress
        i += 1
        If i = 2 Then
            SendKeys.Send("{DIVIDE}")
            i = -1
        End If
    End Sub
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class