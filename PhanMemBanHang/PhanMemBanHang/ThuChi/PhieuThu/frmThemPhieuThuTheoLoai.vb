Public Class frmThemPhieuThuTheoLoai
    Event ThemPhieuThanhCong()
    Private _PhieuThu As tbPhieuThu
    Private _isSuaPhieu As Boolean
    Public NganHang As tbNganHang
    Property PhieuThu As tbPhieuThu
        Get
            Return _PhieuThu
        End Get
        Set(value As tbPhieuThu)
            _PhieuThu = value
            CapNhatPhieuUyNhiemChi(PhieuThu)
        End Set
    End Property
    Sub CapNhatPhieuUyNhiemChi(PhieuThu As tbPhieuThu)
        _isSuaPhieu = True
        cmbLoaiPhieuThu.DataSource = From itm In dt.tbLoaiPhieuThus
                                     Where itm.Loai > 0
                                     Select itm
        cmbLoaiPhieuThu.SelectedItem = PhieuThu.tbLoaiPhieuThu
        cmbNganHang.DataSource = From itm In dt.tbNganHangs
                                 Select itm
        cmbNganHang.SelectedItem = PhieuThu.tbNganHang
        dtpNgayChi.Value = PhieuThu.NgayLap
        vndSoTien.Value = PhieuThu.SoTien
        txtLyDo.Text = PhieuThu.LyDo
        vndPhi.Value = PhieuThu.MucPhi
        txtSoPhieu.Tag = PhieuThu.SoPhieu
        txtSoPhieu.Text = dtpNgayChi.Value.ToString("MMyy") + "T" + txtSoPhieu.Tag.ToString.PadLeft(3, "0")
        Me.Text = "SỬA PHIẾU THU "
        btnThem.Text = "LƯU [F2]"
    End Sub
    Private Sub myComboBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLoaiPhieuThu.GotFocus, cmbNganHang.GotFocus
        sender.DroppedDown = True
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If vndSoTien.Value = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Số tiền chi phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If _isSuaPhieu = False Then
            btnLaySoPhieu_Click(Nothing, Nothing)
            Dim newPhieu As New tbPhieuThu
            With newPhieu
                .HinhThucThanhToan = ""
                .NgayLap = dtpNgayChi.Value
                .SoTien = vndSoTien.Value
                .TenNguoiNop = ""
                .DiaChi = ""
                .NguoiNhanTien = ""
                .ChungTuKemTheo = ""
                .MucPhi = vndPhi.Value
                .LyDo = txtLyDo.Text
                .idNganHang = cmbNganHang.SelectedItem.id
                .SoPhieu = txtSoPhieu.Tag
                .idLoaiPhieuThu = cmbLoaiPhieuThu.SelectedItem.id
                .idNhanVien = loginNhanVien.id
            End With
            dt.tbPhieuThus.InsertOnSubmit(newPhieu)
        Else
            With PhieuThu
                .HinhThucThanhToan = ""
                .NgayLap = dtpNgayChi.Value
                .SoTien = vndSoTien.Value
                .DiaChi = ""
                .ChungTuKemTheo = ""
                .MucPhi = vndPhi.Value
                .LyDo = txtLyDo.Text
                .tbNganHang = cmbNganHang.SelectedItem
                .SoPhieu = txtSoPhieu.Tag
                .tbLoaiPhieuThu = cmbLoaiPhieuThu.SelectedItem
            End With
        End If
        dt.SubmitChanges()
        RaiseEvent ThemPhieuThanhCong()
        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Function LaySoPhieuUyNhiemChi(NganHang As tbNganHang) As Integer
        If NganHang Is Nothing Then Return 0
        Dim HoaDonCuNhat = (From pn In dt.tbPhieuUyNhiemChis
                            Where pn.NgayLap.Year = Now.Year
                            Where pn.isPhieuThu = True
                            Where pn.idNganHang = NganHang.id
                            Order By pn.ID Descending
                            Select pn).FirstOrDefault
        Dim PhieuThu = (From pn In dt.tbPhieuThus
                        Where pn.NgayLap.Year = Now.Year
                        Where pn.idNganHang = NganHang.id
                        Order By pn.id Descending
                        Select pn).FirstOrDefault
        If HoaDonCuNhat Is Nothing Then
            If PhieuThu Is Nothing Then
                txtSoPhieu.Tag = 1
                Return 1
            Else
                txtSoPhieu.Tag = PhieuThu.SoPhieu + 1
                Return PhieuThu.SoPhieu + 1
            End If
        Else
            If PhieuThu Is Nothing Then
                txtSoPhieu.Tag = HoaDonCuNhat.SoPhieu + 1
                Return HoaDonCuNhat.SoPhieu + 1
            Else
                If PhieuThu.SoPhieu > HoaDonCuNhat.SoPhieu Then
                    txtSoPhieu.Tag = PhieuThu.SoPhieu + 1
                    Return PhieuThu.SoPhieu + 1
                Else
                    txtSoPhieu.Tag = HoaDonCuNhat.SoPhieu + 1
                    Return HoaDonCuNhat.SoPhieu + 1
                End If
            End If
        End If
    End Function
    Sub CapNhatLoaiPhieuThu()
        cmbLoaiPhieuThu.DataSource = From itm In dt.tbLoaiPhieuThus
                                     Where itm.Loai > 0
    End Sub
    Private Sub frmThemPhieuThu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub frmThemPhieuThu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmThemPhieuThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        If _isSuaPhieu Then Exit Sub
        cmbNganHang.DataSource = From itm In dt.tbNganHangs Order By itm.TenNganHang
        btnLaySoPhieu_Click(Nothing, Nothing)
        CapNhatLoaiPhieuThu()
        cmbNganHang.SelectedItem = NganHang
    End Sub

    Private Sub btnLaySoPhieu_Click(sender As Object, e As EventArgs) Handles btnLaySoPhieu.Click
        txtSoPhieu.Text = dtpNgayChi.Value.ToString("yy") + "T" + LaySoPhieuUyNhiemChi(cmbNganHang.SelectedItem).ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
    End Sub


    Private Sub txtMaVach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vndSoTien.KeyPress, txtLyDo.KeyPress, dtpNgayChi.KeyPress, cmbLoaiPhieuThu.KeyPress, cmbNganHang.KeyPress, vndPhi.KeyPress
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

    Private Sub cmbNganHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNganHang.SelectedIndexChanged
        btnLaySoPhieu_Click(Nothing, Nothing)
    End Sub
End Class