Public Class frmThemKhachHang
    Event ThemKhachHangThanhCong(KhachHang As tbKhachHang)
    Public ThemXongDong As Boolean
    Private KhachHang As New tbKhachHang
    Private newKhachHang As tbKhachHang
    Public NhomKhachHang As tbNhomKhachHang
    Private Sub frmThemKhachHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        txtMaKhachHang.Focus()
        txtTenKhachHang.Focus()
        nudSoNgayNo.Value = 90
        LayMaKhachHang()
        pnlChiTietLienHe.Visible = chkChiTietLienHe.Checked
        pnlNganHangUyNhiemChi.Visible = Not chkChiTietLienHe.Checked
        CtrlThemSuaXoaNganHangUyNhiemChi1.KhachHang = KhachHang
    End Sub
    Dim i As Integer = 0
    Private Sub dtpNgayNiemYet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpNgayNhap.KeyPress
        i += 1
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
        If i = 2 Then
            SendKeys.Send("{DIVIDE}")
            i = -1
        End If
    End Sub
    Private Sub LayMaKhachHang()
        Try
            Dim KhachHangMoiNhat As tbKhachHang = (From itm In dt.tbKhachHangs
                                                   Order By CInt(itm.MaKhachHang) Descending).FirstOrDefault
            If KhachHangMoiNhat IsNot Nothing Then
                txtMaKhachHang.Text = (CInt(KhachHangMoiNhat.MaKhachHang) + 1).ToString.PadLeft(7, "0")
            Else
                txtMaKhachHang.Text = "0000001"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmThemKhachHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub frmThemKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            btnDong_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            If pnlChiTietLienHe.Visible = True Then
                lnkThemChiTietLienHe_LinkClicked(Nothing, Nothing)
            Else
                CtrlThemSuaXoaNganHangUyNhiemChi1.btnThem_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F5 Then
            If pnlChiTietLienHe.Visible = True Then
                linkXoaChiTietLienHe_LinkClicked(Nothing, Nothing)
            Else
                CtrlThemSuaXoaNganHangUyNhiemChi1.btnSua_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            If pnlChiTietLienHe.Visible = True Then
                'linkXoaChiTietLienHe_LinkClicked(Nothing, Nothing)
            Else
                CtrlThemSuaXoaNganHangUyNhiemChi1.btnXoa_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtMaKhachHang.Focus()
        If txtMaKhachHang.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtTenKhachHang.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If dt.tbKhachHangs.Where(Function(s) s.MaKhachHang = txtMaKhachHang.Text.Trim).Count > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã khách hàng " + txtMaKhachHang.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If dt.tbKhachHangs.Where(Function(s) s.TenRutGon = txtTenRutGon.Text.Trim).Count > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tên khách hàng " + txtTenRutGon.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If dt.tbKhachHangs.Where(Function(s) s.TenKhachHang = txtTenKhachHang.Text.Trim).Count > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tên rút gọn " + txtTenKhachHang.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtMaSoThue.Text.Trim <> "" Then
            If dt.tbKhachHangs.Where(Function(s) s.MaSoThue = txtMaSoThue.Text.Trim).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã số thuế " + txtMaSoThue.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        If chkNhaCungCap.Checked = False And chkKhachHang.Checked = False Then
            ThongBao("Vui lòng chọn loại khách hàng")
            Exit Sub
        End If
        newKhachHang = New tbKhachHang
        With newKhachHang
            .idNhomKhachHang = CType(dt.tbNhomKhachHangs.First, tbNhomKhachHang).id
            .MaKhachHang = txtMaKhachHang.Text.Trim
            .TenKhachHang = txtTenKhachHang.Text
            .TenKhachHangString = mdlGlobals.BoDauTiengViet(txtTenKhachHang.Text.Trim).ToLower
            .SoDienThoai = txtSoDienThoai.Text
            .DiaChi = txtDiaChi.Text
            If nudCongNoDauKy.Value > 0 Then
                .CongNoDauKy = nudCongNoDauKy.Value
            ElseIf nudNoKhachHang.Value > 0 Then
                .CongNoDauKy = -nudNoKhachHang.Value
            End If
            .MaSoThue = txtMaSoThue.Text
            If chkKhachHang.Checked Then
                If chkNhaCungCap.Checked Then
                    .isNhaCungCap = Nothing
                Else
                    .isNhaCungCap = False
                End If
            Else
                .isNhaCungCap = True
            End If
            .SoFAX = txtSoFax.Text
            .Email = txtEmail.Text
            .NgayNhap = dtpNgayNhap.Value
            .NgayTraNo = nudSoNgayNo.Value
            .CongNoMax = nudCongNoMax.Value
            .DiaChiGiaoHang = txtDiaChi.Text.Trim
            .TenRutGon = txtTenRutGon.Text.Trim
            .tbChiTietLienHes.AddRange(lstChiTietLienHe)
            .tbNganHangUyNhiemChis.AddRange(CtrlThemSuaXoaNganHangUyNhiemChi1.lstNganHangUyNhiemChi)
        End With
        Dim newLichSuCongViec = New tbLichSuCongViec
        With newLichSuCongViec
            .idNhanvien = loginNhanVien.id
            .NgayThayDoi = Now
            .NoiDung = "Thêm khách hàng với mã khách hàng " + txtMaKhachHang.Text
            .NoiDungString = BoDauTiengViet(.NoiDung)
        End With
        dt.tbLichSuCongViecs.InsertOnSubmit(newLichSuCongViec)
        dt.tbKhachHangs.InsertOnSubmit(newKhachHang)
        Try
            dt.SubmitChanges()
            RaiseEvent ThemKhachHangThanhCong(newKhachHang)
            '  LayMaKhachHang()
            If chkCopyKhachHang.Checked = False Then
                Me.Close()
            End If
            If ThemXongDong = True Then
                Me.Close()
            End If
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm khách hàng thất bại." +
                                                                    vbNewLine + "Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        txtTenKhachHang.Focus()
        txtTenKhachHang.SelectAll()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub ClsGroupbox2_ThayDoiChieuCao(DentalHeight As Integer)
        Me.Height -= DentalHeight
    End Sub
    Dim lstChiTietLienHe As New List(Of tbChiTietLienHe)
    Private Sub ThemChiTietLienHe(LienHe As tbChiTietLienHe)
        lstChiTietLienHe.Add(LienHe)
        bsChiTietLienHe.DataSource = From itm In lstChiTietLienHe
    End Sub
    Private Sub lnkThemChiTietLienHe_LinkClicked(sender As Object, e As EventArgs) Handles lnkThemChiTietLienHe.LinkClicked
        Dim frmThemChiTietLienHe = New frmThemThongTinLienHe
        AddHandler frmThemChiTietLienHe.ThemThongTinLienHeThanhCong, AddressOf ThemChiTietLienHe
        frmThemChiTietLienHe.ShowDialog()
    End Sub

    Private Sub linkXoaChiTietLienHe_LinkClicked(sender As Object, e As EventArgs) Handles linkXoaChiTietLienHe.LinkClicked
        Dim ChiTiet As tbChiTietLienHe = bsChiTietLienHe.Current
        lstChiTietLienHe.Remove(ChiTiet)
        bsChiTietLienHe.DataSource = From itm In lstChiTietLienHe
    End Sub

    Private Sub txtTenRutGon_TextChanged(sender As Object, e As EventArgs) Handles txtTenRutGon.TextChanged
        txtTenKhachHang.Text = txtTenRutGon.Text
    End Sub

    Private Sub txtTenRutGon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenRutGon.KeyPress, txtTenKhachHang.KeyPress, txtSoFax.KeyPress, txtSoDienThoai.KeyPress, chkCopyKhachHang.KeyPress, chkKhachHang.KeyPress, chkNhaCungCap.KeyPress, txtDiaChi.KeyPress, nudCongNoDauKy.KeyPress, nudCongNoMax.KeyPress, nudSoNgayNo.KeyPress, txtMaKhachHang.KeyPress, txtMaSoThue.KeyPress, txtEmail.KeyPress, nudNoKhachHang.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub nudCongNoDauKy_Enter(sender As Object, e As EventArgs) Handles nudCongNoDauKy.Enter, nudCongNoMax.Enter, nudSoNgayNo.Enter, nudNoKhachHang.Enter
        Dim nud = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown)
        nud.Select(0, nud.Text.Length)
    End Sub

    Private Sub nudNoKhachHang_ValueChanged(sender As Object, e As EventArgs) Handles nudNoKhachHang.ValueChanged, nudCongNoDauKy.ValueChanged
        If nudNoKhachHang.Value > 0 Then
            nudCongNoDauKy.Value = 0
        ElseIf nudCongNoDauKy.Value > 0 Then
            nudNoKhachHang.Value = 0
        End If
    End Sub

    Private Sub frmThemKhachHang_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtTenRutGon.Focus()
    End Sub

    Private Sub chkChiTietLienHe_CheckedChanged(sender As Object, e As EventArgs) Handles chkChiTietLienHe.CheckedChanged, chkNganHangUyNhiemChi.CheckedChanged
        pnlChiTietLienHe.Visible = chkChiTietLienHe.Checked
        pnlNganHangUyNhiemChi.Visible = Not chkChiTietLienHe.Checked
    End Sub

    Private Sub txtTenRutGon_Leave(sender As Object, e As EventArgs) Handles txtTenRutGon.Leave, txtTenKhachHang.Leave, txtMaKhachHang.Leave
        With KhachHang
            .MaKhachHang = txtMaKhachHang.Text.Trim
            .TenKhachHang = txtTenKhachHang.Text
            .TenKhachHangString = mdlGlobals.BoDauTiengViet(txtTenKhachHang.Text.Trim).ToLower
            .SoDienThoai = txtSoDienThoai.Text
            .DiaChi = txtDiaChi.Text
            .TenRutGon = txtTenRutGon.Text.Trim
        End With
    End Sub
End Class