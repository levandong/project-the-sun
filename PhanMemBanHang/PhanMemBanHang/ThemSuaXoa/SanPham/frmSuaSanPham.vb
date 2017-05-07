Imports System.IO

Public Class frmSuaSanPham
    Event SuaSanPhamThanhCong(SanPham As tbSanPham)
    Public SanPham As tbSanPham

    Dim GiaNiemYetCu As Double
    Public MaSanPhamBanDau As String
    Public MaVachSanPhamBanDau As String

    Private Sub frmSuaSanPham_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        txtMaSanPham.Focus()
        btnCapNhatLoai_Click(Nothing, Nothing)
        If SanPham IsNot Nothing Then
            cmbLoaiSanPham.SelectedItem = SanPham.tbLoaiSanPham
            Try
                txtMaSanPham.Text = SanPham.MaSanPham.Substring(3, 3).Trim
                lblMaSanPham.Text = SanPham.MaSanPham.Substring(0, 3).Trim
            Catch ex As Exception
                lblMaSanPham.Text = cmbLoaiSanPham.SelectedItem.MaLoaiSanPham.ToString.Substring(0, 3)
                txtMaSanPham.Text = SanPham.MaSanPham.Substring(0, 3).Trim
            End Try
            txtMaVach.Text = SanPham.MaVachSanPham
            txtTenSanPham.Text = SanPham.TenSanPham
            txtTenTrenHoaDon.Text = SanPham.TenTrenHoaDon
            txtDonVi.Text = SanPham.DonVi
            nudPhanTramGiaBan.Value = SanPham.PhanTramBan
            nudTonMin.Value = SanPham.TonMin
            chkisSeri.Checked = SanPham.isSeri
            chkisGiaCong.Checked = SanPham.isGiaCong
            nudPhanTramGiaNhap.Text = SanPham.PhanTramNhap
            nudGiaNiemYet.Value = SanPham.GiaNiemYet
            GiaNiemYetCu = SanPham.GiaNiemYet
            nudKhoiLuongRieng.Value = SanPham.KhoiLuongRieng
            txtKyHieuKho.Text = SanPham.KyHieuKho
            dtpNgayNiemYet.Value = SanPham.NgayNiemYet
            nudBaoHanh.Value = SanPham.ThoiGianBaoHanh
            chkIsDanhMuc.Checked = SanPham.isDanhMuc
            chkIsKhongTinhTonKho.Checked = SanPham.isKhongTinhTonKho
        End If
    End Sub

    Private Sub frmSuaSanPham_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub frmSuaSamPham_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnSua_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCapNhatLoai_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoai.Click
        cmbLoaiSanPham.DataSource = From itm In dt.tbLoaiSanPhams Select itm Order By itm.TenLoaiSanPham
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        txtMaSanPham.Focus()
        If cmbLoaiSanPham.SelectedItem Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtMaSanPham.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtTenSanPham.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tên sản phẩm không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtDonVi.Text.Trim = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If (lblMaSanPham.Text.Trim + txtMaSanPham.Text) <> MaSanPhamBanDau Then
            If dt.tbSanPhams.Where(Function(s) s.MaSanPham = (lblMaSanPham.Text.Trim + txtMaSanPham.Text.Trim)).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã sản phẩm " + txtMaSanPham.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        If txtMaVach.Text <> MaVachSanPhamBanDau And txtMaVach.Text.Trim <> "" Then
            If dt.tbSanPhams.Where(Function(s) s.MaVachSanPham = txtMaVach.Text.Trim).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã vạch sản phẩm " + txtMaVach.Text + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        Dim newLichSuCongViec = New tbLichSuCongViec
        With newLichSuCongViec
            .idNhanvien = loginNhanVien.id
            .NgayThayDoi = Now
            .NoiDung = "Sửa với mã sản phẩm cũ (" + SanPham.MaSanPham + ") " + txtMaSanPham.Text
            .NoiDungString = BoDauTiengViet(.NoiDung)
        End With
        With SanPham
            .tbLoaiSanPham = cmbLoaiSanPham.SelectedItem
            .MaSanPham = lblMaSanPham.Text.Trim + txtMaSanPham.Text.Trim
            .MaSanPhamString = mdlGlobals.BoDauTiengViet(txtMaSanPham.Text.Trim).ToLower
            .MaVachSanPham = txtMaVach.Text
            .TenSanPham = txtTenSanPham.Text
            .TenSanPhamString = mdlGlobals.BoDauTiengViet(txtTenSanPham.Text.Trim).ToLower
            .DonVi = txtDonVi.Text
            .DonViQuyCach = ""
            .TenTrenHoaDon = txtTenTrenHoaDon.Text
            .PhanTramBan = nudPhanTramGiaBan.Value
            .PhanTramNhap = CDbl(nudPhanTramGiaNhap.Text)
            .GiaNiemYet = nudGiaNiemYet.Value
            .KyHieuKho = txtKyHieuKho.Text
            .KhoiLuongRieng = nudKhoiLuongRieng.Value
            .ThoiGianBaoHanh = nudBaoHanh.Value
            .GiaQuyCach = 0
            .GiaNhapQuyCach = 0
            .QuyCach = 0
            If GiaNiemYetCu <> nudGiaNiemYet.Value Then
                .NgayNiemYet = Now
            End If
            .NgayNiemYet = dtpNgayNiemYet.Value.Date
            .HetBan = False
            .MoTa = ""
            .TonMin = nudTonMin.Value
            .isGiaCong = chkisGiaCong.Checked
            .isSeri = chkisSeri.Checked
            .isKhongTinhTonKho = chkIsKhongTinhTonKho.Checked
            .isDanhMuc = chkIsDanhMuc.Checked
        End With
        Try
            dt.SubmitChanges()
            RaiseEvent SuaSanPhamThanhCong(SanPham)
            Me.Close()
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Sửa sản phẩm thất bại." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        undoChange()
        Me.Close()
    End Sub
    Private Sub txtMaVach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaVach.KeyPress, txtMaSanPham.KeyPress, txtTenSanPham.KeyPress, txtTenTrenHoaDon.KeyPress, nudGiaNiemYet.KeyPress, nudPhanTramGiaBan.KeyPress, nudTonMin.KeyPress, chkisGiaCong.KeyPress, chkisSeri.KeyPress, txtDonVi.KeyPress, nudPhanTramGiaNhap.KeyPress, nudBaoHanh.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub nudGiaNiemYet_Enter(sender As Object, e As EventArgs) Handles nudGiaNiemYet.Enter, nudPhanTramGiaBan.Enter, nudTonMin.Enter, nudPhanTramGiaNhap.Enter, nudBaoHanh.Enter
        Dim nud = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown)
        nud.Select(0, nud.Text.Length)
    End Sub
    Dim i = 0
    Private Sub dtpNgayNiemYet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpNgayNiemYet.KeyPress
        i += 1
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
        If i = 2 Then
            SendKeys.Send("{DIVIDE}")
            i = -1
        End If
    End Sub

    Private Sub txtTenSanPham_TextChanged(sender As Object, e As EventArgs) Handles txtTenSanPham.TextChanged
        txtTenTrenHoaDon.Text = txtTenSanPham.Text
    End Sub
    Private Function LayMaSanPham() As String
        lblMaSanPham.Text = cmbLoaiSanPham.SelectedItem.MaLoaiSanPham.ToString.Substring(0, 3)
        Try
            Dim idLoaiSanPham As Integer = cmbLoaiSanPham.SelectedItem.id
            Dim SanPham = (From itm In dt.tbSanPhams
                           Where itm.idLoaiSanPham = idLoaiSanPham Order By CInt(itm.MaSanPham.Substring(3, 3)) Descending).FirstOrDefault
            If SanPham Is Nothing Then
                txtMaSanPham.Text = "001"
                Return "001"
            End If
            Dim SoMaVach = CInt(SanPham.MaSanPham.Substring(3, 3))
            txtMaSanPham.Text = (SoMaVach + 1).ToString.PadLeft(3, "0")
            Return (SoMaVach + 1).ToString.PadLeft(3, "0")
        Catch
            txtMaSanPham.Text = "001"
            Return "001"
        End Try
    End Function
    Private Sub cmbLoaiSanPham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoaiSanPham.SelectedIndexChanged
        If CType(cmbLoaiSanPham.SelectedItem, tbLoaiSanPham).id <> SanPham.idLoaiSanPham Then
            LayMaSanPham()
            Dim SanPham = dt.tbSanPhams.FirstOrDefault(Function(s) s.idLoaiSanPham = CType(cmbLoaiSanPham.SelectedItem, tbLoaiSanPham).id)
            If SanPham Is Nothing Then
                dtpNgayNiemYet.Value = Now
            Else
                dtpNgayNiemYet.Value = SanPham.NgayNiemYet
            End If
        Else
            Try
                txtMaSanPham.Text = SanPham.MaSanPham.Substring(3, 3).Trim
                lblMaSanPham.Text = SanPham.MaSanPham.Substring(0, 3).Trim
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub chkIsDanhMuc_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class