Public Class frmSuaKhachHang
    Event SuaKhachHangThanhCong(KhachHang As tbKhachHang)
    Public KhachHang As tbKhachHang
    Public MaKhachHangBanDau As String
    Public TenKhachHangBanDau As String
    Public TenRutGonBanDau As String
    Public MaSoThueBanDau As String
    Public SoDuDauKyBanDau As Double
    Dim lstLuuTam As New List(Of tbChiTietLienHe)
    Dim lstLuuTamNganHang As New List(Of tbNganHangUyNhiemChi)
    Private Sub frmSuaKhachHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        cmbNhomKhachHang.DataSource = From itm In dt.tbNhomKhachHangs
                                      Order By itm.TenNhomKhachHang
        If KhachHang IsNot Nothing Then
            txtTenRutGon.Text = KhachHang.TenRutGon
            cmbNhomKhachHang.SelectedItem = KhachHang.tbNhomKhachHang
            txtMaKhachHang.Text = KhachHang.MaKhachHang
            txtTenKhachHang.Text = KhachHang.TenKhachHang
            txtSoDienThoai.Text = KhachHang.SoDienThoai
            txtDiaChi.Text = KhachHang.DiaChi
            If KhachHang.CongNoDauKy > 0 Then
                nudCongNoDauKy.Value = KhachHang.CongNoDauKy
            Else
                nudNoKhachHang.Value = -KhachHang.CongNoDauKy
            End If
            txtMaSoThue.Text = KhachHang.MaSoThue
            txtSoFax.Text = KhachHang.SoFAX
            txtEmail.Text = KhachHang.Email
            nudCongNoMax.Value = KhachHang.CongNoMax
            nudSoNgayNo.Value = KhachHang.NgayTraNo
            dtpNgayNhap.Value = KhachHang.NgayNhap
            If KhachHang.isNhaCungCap Then
                chkNhaCungCap.Checked = True
            ElseIf KhachHang.isNhaCungCap = False Then
                chkKhachHang.Checked = True
            Else
                chkKhachHang.Checked = True
                chkNhaCungCap.Checked = True
            End If
            lstChiTietLienHe = (From itm In dt.tbChiTietLienHes Where itm.idKhachHang = KhachHang.id).ToList
            For Each itm In lstChiTietLienHe
                Dim Tam As New tbChiTietLienHe
                With Tam
                    .id = itm.id
                    .idKhachHang = itm.idKhachHang
                    .TenNguoiLienHe = itm.TenNguoiLienHe
                    .SoDienThoai = itm.SoDienThoai
                    .Email = itm.Email
                End With
                lstLuuTam.Add(Tam)
            Next
            bsChiTietLienHe.DataSource = From itm In lstChiTietLienHe
        End If
        txtMaKhachHang.Focus()
        pnlChiTietLienHe.Visible = chkChiTietLienHe.Checked
        pnlNganHangUyNhiemChi.Visible = Not chkChiTietLienHe.Checked
        pnlNganHangUyNhiemChi.KhachHang = KhachHang
        pnlNganHangUyNhiemChi.lstNganHangUyNhiemChi = (From itm In dt.tbNganHangUyNhiemChis Where itm.idKhachHang = KhachHang.id).ToList
        For Each itm In pnlNganHangUyNhiemChi.lstNganHangUyNhiemChi
            Dim Tam As New tbNganHangUyNhiemChi
            Tam.id = itm.id
            lstLuuTamNganHang.Add(Tam)
        Next
    End Sub

    Private Sub frmSuaKhachHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
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
    Private Sub frmSuaSamPham_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnSua_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            btnDong_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            If pnlChiTietLienHe.Visible = True Then
                lnkThemChiTietLienHe_LinkClicked(Nothing, Nothing)
            Else
                pnlNganHangUyNhiemChi.btnThem_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F5 Then
            If pnlChiTietLienHe.Visible = True Then
                linkXoaChiTietLienHe_LinkClicked(Nothing, Nothing)
            Else
                pnlNganHangUyNhiemChi.btnSua_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            If pnlChiTietLienHe.Visible = True Then
                'linkXoaChiTietLienHe_LinkClicked(Nothing, Nothing)
            Else
                pnlNganHangUyNhiemChi.btnXoa_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        undoChange()
        Me.Close()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        txtMaKhachHang.Focus()

        If txtMaKhachHang.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtTenKhachHang.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tên khách hàng không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If cmbNhomKhachHang.SelectedItem Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhóm khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If

        If txtMaKhachHang.Text.Trim <> MaKhachHangBanDau Then
            If dt.tbKhachHangs.Where(Function(s) s.MaKhachHang = txtMaKhachHang.Text.Trim).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã khách hàng " + txtMaKhachHang.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        If txtTenKhachHang.Text.Trim.ToLower <> TenKhachHangBanDau.ToLower.Trim Then
            If dt.tbKhachHangs.Where(Function(s) s.TenKhachHang = txtTenKhachHang.Text.Trim).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tên rút gọn " + txtTenKhachHang.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        If txtTenRutGon.Text.Trim.ToLower <> TenRutGonBanDau.ToLower.Trim Then
            If dt.tbKhachHangs.Where(Function(s) s.TenRutGon = txtTenRutGon.Text.Trim).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tên khách hàng " + txtTenRutGon.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        If txtMaSoThue.Text.Trim <> "" Then
            If txtMaSoThue.Text.Trim.ToLower <> MaSoThueBanDau.ToLower.Trim Then
                If dt.tbKhachHangs.Where(Function(s) s.MaSoThue = txtMaSoThue.Text.Trim).Count > 0 Then
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tên khách hàng " + txtMaSoThue.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        End If
        Dim newLichSuCongViec = New tbLichSuCongViec
        With newLichSuCongViec
            .idNhanvien = loginNhanVien.id
            .NgayThayDoi = Now
            .NoiDung = "Sửa với mã khách hàng cũ(" + KhachHang.MaKhachHang + ") mới: " + txtMaKhachHang.Text
            .NoiDungString = BoDauTiengViet(.NoiDung)
        End With
        dt.tbLichSuCongViecs.InsertOnSubmit(newLichSuCongViec)
        With KhachHang
            .tbNhomKhachHang = CType(cmbNhomKhachHang.SelectedItem, tbNhomKhachHang)
            .MaKhachHang = txtMaKhachHang.Text.Trim
            .TenKhachHang = txtTenKhachHang.Text
            .TenKhachHangString = mdlGlobals.BoDauTiengViet(txtTenKhachHang.Text.Trim)
            .SoDienThoai = txtSoDienThoai.Text.Trim
            .DiaChi = txtDiaChi.Text.Trim
            If nudCongNoDauKy.Value > 0 Then
                .CongNoDauKy = nudCongNoDauKy.Value
            Else
                .CongNoDauKy = -nudNoKhachHang.Value
            End If
            .MaSoThue = txtMaSoThue.Text.Trim
            .SoFAX = txtSoFax.Text.Trim
            .Email = txtEmail.Text.Trim
            .TenRutGon = txtTenRutGon.Text.Trim
            If chkKhachHang.Checked And chkNhaCungCap.Checked = False Then
                .isNhaCungCap = False
            ElseIf chkNhaCungCap.Checked And chkKhachHang.Checked = False Then
                .isNhaCungCap = True
            ElseIf chkKhachHang.Checked And chkKhachHang.Checked Then
                .isNhaCungCap = Nothing
            End If
            .NgayTraNo = nudSoNgayNo.Value
            .CongNoMax = nudCongNoMax.Value
            .NgayNhap = dtpNgayNhap.Value
            For Each itm In lstChiTietLienHe
                itm.idKhachHang = KhachHang.id
            Next
            For Each itm In pnlNganHangUyNhiemChi.lstNganHangUyNhiemChi
                itm.idKhachHang = KhachHang.id
            Next
            For Each itm In lstLuuTam
                dt.tbChiTietLienHes.DeleteOnSubmit(dt.tbChiTietLienHes.First(Function(s) s.id = itm.id))
            Next
            dt.tbChiTietLienHes.InsertAllOnSubmit(lstChiTietLienHe)
            For Each itm In lstLuuTamNganHang
                dt.tbNganHangUyNhiemChis.DeleteOnSubmit(dt.tbNganHangUyNhiemChis.First(Function(s) s.id = itm.id))
            Next
            dt.tbNganHangUyNhiemChis.InsertAllOnSubmit(pnlNganHangUyNhiemChi.lstNganHangUyNhiemChi)
        End With

        Try
            dt.SubmitChanges()
            RaiseEvent SuaKhachHangThanhCong(KhachHang)
            Me.Close()
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Sửa khách hàng thất bại." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
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
    Sub CapNhatThongTin()
        bsChiTietLienHe.DataSource = From itm In lstChiTietLienHe
    End Sub
    Private Sub lblSua_LinkClicked(sender As Object, e As EventArgs) Handles lblSua.LinkClicked
        If bsChiTietLienHe.Current Is Nothing Then
            ThongBao("Chọn thông tin liên hệ")
        End If
        Dim frm As New frmSuaThongTinLienHe
        frm.ChiTietLienHe = bsChiTietLienHe.Current
        AddHandler frm.ThemThongTinLienHeThanhCong, AddressOf CapNhatThongTin
        frm.ShowDialog()
    End Sub

    Private Sub txtTenRutGon_TextChanged(sender As Object, e As EventArgs) Handles txtTenRutGon.TextChanged
        txtTenKhachHang.Text = txtTenRutGon.Text
    End Sub
    Private Sub txtTenRutGon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenRutGon.KeyPress, txtTenKhachHang.KeyPress, txtSoFax.KeyPress, txtSoDienThoai.KeyPress, chkKhachHang.KeyPress, chkNhaCungCap.KeyPress, txtDiaChi.KeyPress, nudCongNoDauKy.KeyPress, nudCongNoMax.KeyPress, nudSoNgayNo.KeyPress, txtMaKhachHang.KeyPress, txtMaSoThue.KeyPress, nudNoKhachHang.KeyPress, txtEmail.KeyPress
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

End Class