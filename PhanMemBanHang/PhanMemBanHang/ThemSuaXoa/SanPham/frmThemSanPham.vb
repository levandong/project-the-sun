Public Class frmThemSanPham
    Event ThemSanPhamThanhCong(SanPham As tbSanPham)
    Private newSanPham As tbSanPham
    Public An As Boolean
    Public LoaiSanPham As tbLoaiSanPham
    Private Sub frmThemSanPham_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        btnCapNhatLoai_Click(Nothing, Nothing)
        If LoaiSanPham IsNot Nothing Then
            cmbLoaiSanPham.SelectedItem = LoaiSanPham
        Else
            LoaiSanPham = cmbLoaiSanPham.SelectedItem
        End If
        txtMaSanPham.Focus()
        Dim SanPham = dt.tbSanPhams.FirstOrDefault(Function(s) s.idLoaiSanPham = LoaiSanPham.id)
        If SanPham Is Nothing Then
            dtpNgayNiemYet.Value = Now
        Else
            dtpNgayNiemYet.Value = SanPham.NgayNiemYet
        End If
        'cmbDonVi.DataSource = From itm In dt.tbDonVis
        '                      Order By itm.DonVi

        txtDonVi.Text = "Cái"
        LayMaVachSanPham()
    End Sub

    Private Sub frmThemSanPham_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub frmThemKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnCapNhatLoai_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoai.Click
        cmbLoaiSanPham.DataSource = From itm In dt.tbLoaiSanPhams Select itm Order By itm.TenLoaiSanPham
    End Sub

    Private Sub LayMaVachSanPham()
        Try
            Dim SanPhamMoiNhat As tbSanPham = (From itm In dt.tbSanPhams
                                               Order By CInt(itm.MaVachSanPham) Descending).FirstOrDefault
            If SanPhamMoiNhat IsNot Nothing Then
                txtMaVach.Text = (CInt(SanPhamMoiNhat.MaVachSanPham) + 1).ToString.PadLeft(6, "0")
            Else
                txtMaVach.Text = "0000001"
            End If
        Catch ex As Exception
            txtMaVach.Text = "0000001"
        End Try
    End Sub



    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
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

        If dt.tbSanPhams.Where(Function(s) s.MaSanPham = txtMaSanPham.Text.Trim).Count > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã sản phẩm " + txtMaSanPham.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If dt.tbSanPhams.Where(Function(s) s.TenSanPham = txtTenSanPham.Text.Trim).Count > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tên sản phẩm " + txtTenSanPham.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtMaVach.Text.Trim <> "" Then
            If dt.tbSanPhams.Where(Function(s) s.MaVachSanPham = txtMaVach.Text.Trim).Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Mã vạch sản phẩm " + txtMaVach.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        newSanPham = New tbSanPham
        With newSanPham
            .idLoaiSanPham = cmbLoaiSanPham.SelectedItem.id
            .MaSanPham = lblMaSanPham.Text.Trim + txtMaSanPham.Text.Trim
            .MaVachSanPham = txtMaVach.Text.Trim
            .TenSanPham = txtTenSanPham.Text.Trim
            .DonVi = txtDonVi.Text.Trim
            .PhanTramNhap = nudPhanTramGiaNhap.Value
            .PhanTramBan = nudPhanTramGiaBan.Value
            .GiaQuyCach = 0
            .GiaNhapQuyCach = 0
            .QuyCach = 0
            .DonViQuyCach = ""
            .HetBan = False
            .NgayTao = Now
            .MoTa = ""
            .TonMin = nudTonMin.Value
            .GiaBinhQuan = 0
            .SoLuong = 0
            .TenSanPhamString = mdlGlobals.BoDauTiengViet(txtTenSanPham.Text.Trim).ToLower
            .MaSanPhamString = mdlGlobals.BoDauTiengViet(txtMaSanPham.Text.Trim).ToLower
            .isGiaCong = chkisGiaCong.Checked
            .isSeri = chkisSeri.Checked
            .GiaNiemYet = nudGiaNiemYet.Value
            .TenTrenHoaDon = txtTenTrenHoaDon.Text.Trim
            .KhoiLuongRieng = nudKhoiLuongRieng.Value
            .KyHieuKho = txtKyHieuKho.Text.Trim
            .ThoiGianBaoHanh = nudBaoHanh.Value
            Dim SanPham = dt.tbSanPhams.FirstOrDefault(Function(s) s.idLoaiSanPham = .idLoaiSanPham)
            .NgayNiemYet = dtpNgayNiemYet.Value
            .isDanhMuc = chkIsDanhMuc.Checked
            .isKhongTinhTonKho = chkIsKhongTinhTonKho.Checked
        End With
        Dim newLichSuCongViec = New tbLichSuCongViec
        With newLichSuCongViec
            .idNhanvien = loginNhanVien.id
            .NgayThayDoi = Now
            .NoiDung = "Thêm với mã sản phẩm " + txtMaSanPham.Text
            .NoiDungString = BoDauTiengViet(.NoiDung)
        End With
        dt.tbLichSuCongViecs.InsertOnSubmit(newLichSuCongViec)
        ' thêm sản phẩm vào dánh sách sản phẩm
        dt.tbSanPhams.InsertOnSubmit(newSanPham)
        Try
            dt.SubmitChanges()
            LayMaSanPham()
            RaiseEvent ThemSanPhamThanhCong(newSanPham)
            If chkCopySanPham.Checked = False Then
                Me.Close()
            End If

        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm sản phẩm thất bại." + ex.ToString, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        LayMaVachSanPham()
        txtMaSanPham.Focus()
        txtMaSanPham.SelectAll()
        nudGiaNiemYet.Value = 0
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub ClsGroupbox2_ThayDoiChieuCao(DentalHeight As Integer)
        Me.Height -= DentalHeight
    End Sub

    Private Sub ClsGroupbox1_ThayDoiChieuCao(DentalHeight As Integer) Handles ClsGroupbox1.ThayDoiChieuCao
        Me.Height -= DentalHeight
    End Sub


    Dim KeyTimKiemSanPham As String = ""
    Dim isTimKiemSanPham As Boolean = True
    Sub CapNhatLoaiSanPham(key As String)
        Dim rls = From itm In dt.tbLoaiSanPhams
                  Where (key = "") Or dt.f_nosymbol(itm.TenLoaiSanPham).Contains(key)
        rls.ToList
        cmbLoaiSanPham.DataSource = rls
        LayMaSanPham()
    End Sub
    Private Sub cmbLoaiSanPham_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbLoaiSanPham.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            isTimKiemSanPham = False
            KeyTimKiemSanPham = BoDauTiengViet(KeyTimKiemSanPham)
            If KeyTimKiemSanPham = "" Then
                CapNhatLoaiSanPham("")
            Else
                If cmbLoaiSanPham.DroppedDown = False Then
                    CapNhatLoaiSanPham(KeyTimKiemSanPham)
                    cmbLoaiSanPham.DroppedDown = True
                    Cursor.Current = Cursors.Default
                    e.Handled = True
                End If
            End If
            isTimKiemSanPham = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbLoaiSanPham_TextChanged(sender As Object, e As EventArgs) Handles cmbLoaiSanPham.TextChanged
        If isTimKiemSanPham Then
            KeyTimKiemSanPham = cmbLoaiSanPham.Text.Trim.ToLower
        End If
        If cmbLoaiSanPham.Text.Trim = "" And cmbLoaiSanPham.DroppedDown = True Then
            cmbLoaiSanPham.DroppedDown = False
        End If
    End Sub
#Region "Mã loại sản phẩm"
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
        LayMaSanPham()
        If LoaiSanPham Is Nothing Then LoaiSanPham = dt.tbLoaiSanPhams.First
        Dim SanPham = dt.tbSanPhams.FirstOrDefault(Function(s) s.idLoaiSanPham = LoaiSanPham.id)
        If SanPham Is Nothing Then
            dtpNgayNiemYet.Value = Now
        Else
            dtpNgayNiemYet.Value = SanPham.NgayNiemYet
        End If
    End Sub

    Private Sub txtTenSanPham_TextChanged(sender As Object, e As EventArgs) Handles txtTenSanPham.TextChanged
        txtTenTrenHoaDon.Text = txtTenSanPham.Text
    End Sub

    Private Sub txtMaVach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaVach.KeyPress, txtMaSanPham.KeyPress, txtTenSanPham.KeyPress, txtTenTrenHoaDon.KeyPress, nudGiaNiemYet.KeyPress, nudPhanTramGiaBan.KeyPress, nudPhanTramGiaNhap.KeyPress, nudTonMin.KeyPress, chkCopySanPham.KeyPress, chkisGiaCong.KeyPress, chkisSeri.KeyPress, txtDonVi.KeyPress, txtKyHieuKho.KeyPress, nudKhoiLuongRieng.KeyPress, nudBaoHanh.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub nudGiaNiemYet_Enter(sender As Object, e As EventArgs) Handles nudGiaNiemYet.Enter, nudPhanTramGiaBan.Enter, nudPhanTramGiaNhap.Enter, nudTonMin.Enter, nudKhoiLuongRieng.Enter, nudBaoHanh.Enter
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

    Private Sub txtTenSanPham_Enter(sender As Object, e As EventArgs) Handles txtTenSanPham.Enter
        txtTenSanPham.SelectAll()
    End Sub

    Private Sub chkIsDanhMuc_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsDanhMuc.CheckedChanged
        If chkIsDanhMuc.Checked Then
            chkIsKhongTinhTonKho.Checked = False
            chkIsKhongTinhTonKho.Enabled = False
        Else
            chkIsKhongTinhTonKho.Enabled = True
        End If
    End Sub

#End Region
End Class