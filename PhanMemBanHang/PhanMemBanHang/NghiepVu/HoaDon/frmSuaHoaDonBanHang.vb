Public Class frmSuaHoaDonBanHang
    Public HoaDon As tbHoaDon

    Private Sub frmHoaDonBanHang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub txtMaVach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKhachHang.KeyPress, txtVAT.KeyPress, txtTienVAT.KeyPress, txtTienTruocThue.KeyPress, txtTienSauThue.KeyPress, txtTienPhi.KeyPress, txtSoHD.KeyPress, txtMucPhi.KeyPress, txtMatHang.KeyPress, txtMaCongTy.KeyPress, txtKyHieu.KeyPress, txtKhachHangTinhCongNo.KeyPress, txtGhiChu.KeyPress, dtpNgayLap.KeyPress, dtpNgayHoaDon.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then 'Hoặc Convert.ToChar(Keys.Enter)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub frmSuaHoaDonBanHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpNgayLap.Value = HoaDon.NgayLap
        dtpNgayHoaDon.Value = HoaDon.NgayInHoaDon
        CapNhatSoHoaDon()
        ChonKhachHang(dt.tbKhachHangs.Single(Function(s) s.id = HoaDon.idKhachHangHD), txtKhachHang)
        ChonKhachHang(dt.tbKhachHangs.Single(Function(s) s.id = HoaDon.idKhachHangHD), txtKhachHangTinhCongNo)
        txtGhiChu.Text = HoaDon.GhiChu
        txtKyHieu.Text = HoaDon.KyHieuHD
        txtSoHD.Text = HoaDon.SoHD.ToString.PadLeft(7, "0")
        txtMatHang.Text = HoaDon.MatHang
        txtTienTruocThue.Text = HoaDon.TienTruocThue
        txtVAT.Text = HoaDon.VAT
        txtMucPhi.Text = HoaDon.MucPhi
    End Sub
    Private Sub txtTienTruocThue_TextChanged(sender As Object, e As EventArgs) Handles txtTienTruocThue.TextChanged
        Dim TienTruocThue As Decimal, VAT As Decimal, MucPhi As Decimal
        If txtTienTruocThue.Text = "" Then
            TienTruocThue = 0
        Else
            TienTruocThue = CDec(txtTienTruocThue.Text)
        End If
        If txtVAT.Text = "" Then
            VAT = 0
        Else
            VAT = CDec(txtVAT.Text)
        End If
        If txtMucPhi.Text = "" Then
            MucPhi = 0
        Else
            MucPhi = CDec(txtMucPhi.Text)
        End If
        txtTienVAT.Text = (TienTruocThue * (VAT / 100)).ToString("###,###,###,##0.###")
        txtTienSauThue.Text = (TienTruocThue * ((VAT + 100) / 100)).ToString("###,###,###,##0.###")
        txtTienPhi.Text = ((TienTruocThue * ((VAT + 100) / 100)) * MucPhi / 100).ToString("###,###,###,##0.###")
    End Sub
    Sub CapNhatSoHoaDon()
        txtSoPhieu.Tag = HoaDon.SoHoaDon
        txtSoPhieu.Text = dtpNgayLap.Value.ToString("MMyy") + "H" + txtSoPhieu.Tag.ToString.PadLeft(3, "0")
    End Sub
    Dim i = 0
    Private Sub dtpNgayLap_Enter(sender As Object, e As EventArgs) Handles dtpNgayLap.Enter, dtpNgayHoaDon.Enter
        i = 0
    End Sub
    Dim ctrl As New ctrlDGVKhachHang
    Private Sub txtKhachHangTinhCongNo_Enter(sender As Object, e As EventArgs) Handles txtKhachHangTinhCongNo.Enter, txtKhachHang.Enter
        Dim textBox = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        ctrl.Location = New Point(textBox.Location.X, textBox.Location.Y + textBox.Size.Height + 40 + KryptonGroupBox1.Height)
    End Sub
    Private Sub txtKhachHang_Enter(sender As Object, e As EventArgs) Handles txtKhachHang.Enter
        Dim textBox = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        ctrl.Location = New Point(textBox.Location.X, textBox.Location.Y + textBox.Size.Height + 30)
    End Sub
    Sub ChonKhachHang(KhachHang As tbKhachHang, TextBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox)
        TextBox.Tag = KhachHang
        TextBox.Text = KhachHang.TenRutGon
        If txtKhachHangTinhCongNo.Tag IsNot Nothing Then
            txtKhachHangTinhCongNo.Text = KhachHang.TenRutGon
            txtKhachHangTinhCongNo.Tag = KhachHang
        End If
        If TextBox.Name = "txtKhachHang" Then
            txtMaKhachHang.Text = KhachHang.MaKhachHang.Trim
        Else
            txtMaCongTy.Text = KhachHang.MaKhachHang.Trim
        End If
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
        Dim key = BoDauTiengViet(CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Text.Trim)
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
            ctrl.Size = New Size(txtKhachHang.Size.Width, 380)
        Else
            ctrl.Visible = False
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtKhachHang.Tag Is Nothing Then
            ThongBao("Chưa nhập thông tin khách hàng trên hóa đơn")
            Exit Sub
        End If
        If txtKhachHangTinhCongNo.Tag Is Nothing Then
            ThongBao("Chưa nhập thông tin công ty tính công nợ")
            Exit Sub
        End If
        If txtTienTruocThue.Text = "" Then
            ThongBao("Chưa nhập tiền thuế")
            Exit Sub
        End If
        With HoaDon
            .NgayLap = dtpNgayLap.Value
            .idKhachHang = txtKhachHang.Tag.id
            .idNhanVien = loginNhanVien.id
            .ChietKhau = 0
            .SoHoaDon = txtSoPhieu.Tag
            .VAT = CDec(txtVAT.Text)
            .GhiChu = txtGhiChu.Text.Trim
            .SoTienKhachDua = 0
            .SoTienGiam = 0
            .NgayInHoaDon = dtpNgayHoaDon.Value
            .KyHieuHD = txtKyHieu.Text.Trim
            .SoHD = CDec(txtSoHD.Text)
            .MatHang = txtMatHang.Text.Trim
            .TienTruocThue = CDec(txtTienTruocThue.Text)
            .MucPhi = CDec(txtMucPhi.Text)
            .idKhachHangHD = txtKhachHangTinhCongNo.Tag.id
        End With
        Try
            dt.SubmitChanges()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class