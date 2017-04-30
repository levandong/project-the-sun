Public Class frmChiTietTonKho
    Dim TonKho As TinhTonKhoSanPhamResult
    Public TheoNgay As Boolean
    Public TuNgay, DenNgay As DateTime
    Dim lstChiTietTonKho As New List(Of clsChiTietTonKho)
    Public idSanPham As Integer

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        TuNgay = dtpTuNgay.Value
        DenNgay = dtpDenNgay.Value
        TheoNgay = chkTheoThoiGian.Checked
        TonKho = dt.TinhTonKhoSanPham(idSanPham, chkTheoThoiGian.Checked, TuNgay, DenNgay).FirstOrDefault
        Dim rlsPhieuNhap = From itm In dt.vwChiTietPhieuNhaps
                           Where (Not TheoNgay) Or (TuNgay.Date <= itm.NgayLap.Date And itm.NgayLap.Date <= DenNgay.Date)
                           Where itm.idSanPham = idSanPham
                           Select New clsChiTietTonKho With
                                  {
                                      .Loai = 0,
                                      .idPhieu = itm.idPhieuNhap,
                                      .SoPhieu = itm.SoPhieu,
                                      .Ngay = itm.NgayLap,
                                      .LyDo = itm.LoaiPhieuNhap,
                                      .DoiTuong = itm.KhachHangNhaCungCap.Trim,
                                      .SoLuongNhap = itm.SoLuong,
                                      .DonGiaNhap = itm.GiaBan}

        Dim rlsPhieuXuat = From itm In dt.vwChiTietPhieuXuats
                           Where (Not TheoNgay) Or (TuNgay.Date <= itm.NgayLap.Date And itm.NgayLap.Date <= DenNgay.Date)
                           Where itm.idSanPham = idSanPham
                           Select New clsChiTietTonKho With
                                  {
                                      .Loai = 1,
                                      .idPhieu = itm.idPhieuXuat,
                                      .SoPhieu = itm.SoPhieuXuat,
                                      .Ngay = itm.NgayLap,
                                      .LyDo = itm.LoaiPhieuXuat,
                                      .DoiTuong = itm.TenNhaCungCap,
                                      .SoLuongXuat = itm.SoLuong,
                                      .DonGiaXuat = itm.GiaBan
                                  }
        Dim rls As New List(Of clsChiTietTonKho)
        rls.AddRange(rlsPhieuNhap)
        rls.AddRange(rlsPhieuXuat)
        Dim lstTam = From itm In rls Order By itm.Ngay
        lstChiTietTonKho = lstTam.ToList
        Dim i As Integer
        For i = 0 To lstChiTietTonKho.Count - 1
            If i = 0 Then
                lstChiTietTonKho(i).SoLuongTon = TonKho.SoLuongDauKy + lstChiTietTonKho(i).SoLuongNhap - lstChiTietTonKho(i).SoLuongXuat
            Else
                lstChiTietTonKho(i).SoLuongTon = lstChiTietTonKho(i - 1).SoLuongTon + lstChiTietTonKho(i).SoLuongNhap - lstChiTietTonKho(i).SoLuongXuat
            End If
        Next
        If chkTheoKhachHang.Checked Then
            bsChiTietTonKho.DataSource = From itm In lstChiTietTonKho Order By itm.Ngay
                                         Where itm.DoiTuong = txtKhachHang.Tag.TenKhachHang
        Else
            bsChiTietTonKho.DataSource = From itm In lstChiTietTonKho Order By itm.Ngay
        End If

    End Sub
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        Dim frm As New frmThongKeChiTietTonKho
        frm.TonKho = TonKho
        frm.TheoNgay = TheoNgay
        frm.TuNgay = TuNgay
        frm.DenNgay = DenNgay
        frm.Show()
    End Sub

    Private Sub frmChiTietTonKho_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnTimKiem_Click(Nothing, Nothing)
        End If
    End Sub
    Dim ctrl As New ctrlDGVKhachHang
    Private Sub frmChiTietTonKho_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpTuNgay.Value = TuNgay
        dtpDenNgay.Value = DenNgay
        chkTheoThoiGian.Checked = TheoNgay
        btnTimKiem_Click(Nothing, Nothing)
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height)
        Me.Controls.Add(ctrl)
    End Sub
    Sub ChonKhachHang(KhachHang As tbKhachHang)
        txtKhachHang.Tag = KhachHang
        txtKhachHang.Text = KhachHang.TenKhachHang
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

    Private Sub chkTheoThoiGian_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoThoiGian.CheckedChanged
        dtpDenNgay.Enabled = chkTheoThoiGian.Checked
        dtpTuNgay.Enabled = chkTheoThoiGian.Checked
    End Sub

    Private Sub chkTheoKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoKhachHang.CheckedChanged
        txtKhachHang.Enabled = chkTheoKhachHang.Checked
    End Sub

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
End Class