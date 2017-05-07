Public Class ctrlGiaCong
    Private Sub btnTimKiemSanPham_Click(sender As Object, e As EventArgs) Handles btnTimKiemSanPham.Click
        Dim frm As New frmTimKiemSanPham
        If frm.ShowDialog = DialogResult.OK Then
            cmbSanPhamGiaCong.SelectedItem = frm.SanPhamDuocChon
        End If
    End Sub

    Private Sub btnThemSanPham_Click(sender As Object, e As EventArgs) Handles btnThemSanPham.Click
        Dim frm As New frmThemSanPham
        AddHandler frm.ThemSanPhamThanhCong, AddressOf ChonSanPham
        frm.ShowDialog()

    End Sub
    Sub ChonSanPham(SanPham As tbSanPham)
        cmbSanPhamGiaCong.SelectedItem = SanPham
    End Sub
    Private Function CapNhatSoPhieu() As Integer
        If dt.tbPhieuNhaps.Count = 0 Then Return 1
        Dim PhieuNhapCuNhat = (From itm In dt.tbGiaCongs
                               Where itm.NgayLap.Year = dtpNgayNhap.Value.Year
                               Where itm.NgayLap.Month = dtpNgayNhap.Value.Month
                               Select itm Order By itm.id Descending).FirstOrDefault
        If PhieuNhapCuNhat Is Nothing Then Return 1
        Return PhieuNhapCuNhat.SoPhieu + 1
    End Function
    Sub LaySoPhieuMoiNhat()
        txtMaPhieuNhap.Tag = CapNhatSoPhieu()
        txtMaPhieuNhap.Text = dtpNgayNhap.Value.ToString("MM/yy") + "GC" + txtMaPhieuNhap.Tag.ToString().PadLeft(3, "0")
    End Sub
    Private Sub btnCapNhapDanhSach_Click(sender As Object, e As EventArgs) Handles btnCapNhapDanhSach.Click
        cmbSanPhamGiaCong.DataSource = From itm In dt.tbSanPhams
                                       Where itm.isGiaCong = True
    End Sub
    Dim lstChiTietGiaCong As New List(Of tbGiaCongSanPham)
    Private Sub CtrlTimKiemSanPham1_ChonSanPhamThanhCong(SanPham As tbSanPham, SoLuong As Double, TheoDonVi As Boolean)
        Dim newChiTietGiaCong As New tbGiaCongSanPham
        With newChiTietGiaCong
            .idSanPham = SanPham.id
            .MaSanPham = SanPham.MaSanPham
            .SoLuong = CInt(SoLuong)
            .TenSanPham = SanPham.TenSanPham
            .DonVi = SanPham.DonVi
            Dim SanPhamNhap As tbChiTietPhieuNhap = dt.tbChiTietPhieuNhaps.Where(Function(s) s.idSanPham = SanPham.id).OrderByDescending(Function(s) s.id).FirstOrDefault
            If SanPhamNhap Is Nothing Then
                .DonGia = SanPham.GiaNiemYet
            Else
                .DonGia = SanPhamNhap.GiaBan
            End If
            .STT = lstChiTietGiaCong.Count
        End With
        lstChiTietGiaCong.Add(newChiTietGiaCong)
        bsChiTietGiaCong.DataSource = From itm In lstChiTietGiaCong
                                      Order By itm.STT Descending
        Try
            dgvMain.Focus()
            dgvMain.CurrentCell = dgvMain.Item("SoLuong", 0)
            dgvMain.BeginEdit(True)
        Catch
        End Try
    End Sub
    Private Sub dgvMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMain.SelectionChanged
        If bsChiTietGiaCong.Count <= 1 Then
            Exit Sub
        End If
        If reset Then
            reset = False
            If rowindex > 0 Then
                Exit Sub
            End If
            Dim columnIndex = dgvMain.CurrentCell.ColumnIndex
            Dim i = dgvMain.CurrentCell.RowIndex
            Dim columnName = dgvMain.Columns(columnIndex).Name
            If columnName = "SoLuong" Then
                dgvMain.CurrentCell = dgvMain.Item("DonGia", rowindex)
                dgvMain.BeginEdit(True)
            ElseIf columnName = "DonGia" Then
                txtSearch.Text = ""
                txtSearch.Focus()
            End If
            isChuyen = False
        End If
    End Sub
    Dim reset = False
    Dim rowindex = 0
    Dim isChuyen = True
    Private Sub Bamenter() Handles dgvMain.BamEnter
        isChuyen = True
    End Sub
    Private Sub dgvMain_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellEndEdit
        If isChuyen = False Then
            isChuyen = True

            Exit Sub
        End If
        reset = True
        rowindex = e.RowIndex
        Dim columnIndex = dgvMain.CurrentCell.ColumnIndex
        Dim i = dgvMain.CurrentCell.RowIndex
        Try
            Dim columnName = dgvMain.Columns(columnIndex).Name
            If columnName = "SoLuong" Then
                dgvMain.CurrentCell = dgvMain.Item("DonGia", rowindex)
                dgvMain.BeginEdit(True)
            ElseIf columnName = "DonGia" Then
                txtSearch.Text = ""
                txtSearch.Focus()
            End If
            isChuyen = False
        Catch ex As Exception

        End Try

    End Sub
    Dim flag = False
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        flag = True
        If lstChiTietGiaCong.Count = 0 Then
            ThongBao("Chưa chọn các linh kiện gia công")
            Exit Sub
        End If
        If lstChiTietGiaCong.Count = 0 Then
            ThongBao("Chưa chọn sản phẩm cần gia công")
            Exit Sub
        End If
        Dim newGiaCong As New tbGiaCong
        With newGiaCong
            .NgayLap = dtpNgayNhap.Value
            .idSanPham = cmbSanPhamGiaCong.SelectedItem.id
            .tbGiaCongSanPhams.AddRange(lstChiTietGiaCong)
            .ChiPhiKhac = nudChiPhiKhac.Value
            .idNhanVien = loginNhanVien.id
            .SoLuong = nudSoLuong.Value
            .SoPhieu = CapNhatSoPhieu()
        End With
        Dim rlsChiTiet = From itm In lstChiTietGiaCong
                         Group By itm.idSanPham Into SoLuong = Sum(itm.SoLuong)

        'Trừ số lượng vào kho
        Dim rlsChiTietPhieuXuat As New List(Of tbChiTietPhieuXuat)
        For Each ChiTiet In rlsChiTiet
            Dim SanPham = dt.tbSanPhams.First(Function(s) s.id = ChiTiet.idSanPham)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, SanPham)
            SanPham.SoLuong -= ChiTiet.SoLuong * nudSoLuong.Value
            'ChiTietPhieuXuat
            Dim ChiTietXuat As New tbChiTietPhieuXuat
            With ChiTietXuat
                .idSanPham = ChiTiet.idSanPham
                .SoLuong = ChiTiet.SoLuong * nudSoLuong.Value
                .DonGia = 0
                .ChietKhau = 0
                .TheoDonVi = 1
                .QuyCach = 1
            End With
            rlsChiTietPhieuXuat.Add(ChiTietXuat)
        Next
        ''Tạo phiếu xuất kho
        'Phieu Xuat
        Dim newPhieuXuat As New tbPhieuXuat
        With newPhieuXuat
            .SoPhieuXuat = 0
            .NgayLap = Now
            .idNhanVien = loginNhanVien.id
            .idLoaiPhieuXuat = 20
            .GhiChu = "Xuất gia công sản phẩm" + cmbSanPhamGiaCong.SelectedItem.TenSanPham
            .TenCongTrinh = "Gia công sản phẩm" + cmbSanPhamGiaCong.SelectedItem.TenSanPham
        End With
        newPhieuXuat.tbChiTietPhieuXuats.AddRange(rlsChiTietPhieuXuat)
        Dim idSanPhamGiaCong As Integer = cmbSanPhamGiaCong.SelectedItem.id
        Dim SanPhamGiaCong = dt.tbSanPhams.FirstOrDefault(Function(s) s.id = idSanPhamGiaCong)
        dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, SanPhamGiaCong)
        SanPhamGiaCong.SoLuong += nudSoLuong.Value
        Dim ChiTietNhap = New tbChiTietPhieuNhap
        With ChiTietNhap
            .idSanPham = idSanPhamGiaCong
            .DonGia = 0
            .SoLuong = nudSoLuong.Value
            .GiaBan = nudTongTien.Value
            .ChietKhau = 0
            .GiaVon = nudTongTien.Value
            .TheoDonVi = 1
            .GhiChu = ""
            .QuyCach = 1
        End With
        Dim newPhieuNhap = New tbPhieuNhap
        With newPhieuNhap
            .NgayLap = Now
            .idNhanVien = loginNhanVien.id
            .GhiChu = "Gia công sản phẩm ngày " + Now.ToShortDateString
            .idLoaiPhieuNhap = 21
            .VAT = 0
            .ChietKhau = 0
            .SoPhieu = 0
            .SoNgayNo = 0
            .tbChiTietPhieuNhaps.Add(ChiTietNhap)
        End With
        newGiaCong.tbPhieuNhap = newPhieuNhap
        newGiaCong.tbPhieuXuat = newPhieuXuat
        Try
            dt.tbGiaCongs.InsertOnSubmit(newGiaCong)
            dt.SubmitChanges()
            lstChiTietGiaCong.Clear()
            bsChiTietGiaCong.DataSource = From itm In lstChiTietGiaCong
            flag = True
        Catch ex As Exception
            ThongBao("Thêm sản phẩm gia công thất bại" + ex.ToString)
        End Try
    End Sub
    Private Sub bsChiTietGiaCong_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietGiaCong.ListChanged
        nudTienLinhKien.Value = lstChiTietGiaCong.Sum(Function(s) s.ThanhTien)
        nudTongTien.Value = nudTienLinhKien.Value + nudChiPhiKhac.Value
    End Sub

    Private Sub nudChiPhiKhac_ValueChanged(sender As Object, e As EventArgs) Handles nudChiPhiKhac.ValueChanged
        nudTongTien.Value = lstChiTietGiaCong.Sum(Function(s) s.ThanhTien) + CDec(nudChiPhiKhac.Value)
    End Sub

    Private Sub nudTongTien_ValueChanged(sender As Object, e As EventArgs) Handles nudTongTien.ValueChanged, nudSoLuong.ValueChanged
        nudThanhTien.Value = nudTongTien.Value * nudSoLuong.Value
    End Sub

    Private Sub cmbSanPhamGiaCong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSanPhamGiaCong.SelectedIndexChanged
        If flag Then
            Exit Sub
        End If
        Dim idSanPhamGiaCong As Integer = cmbSanPhamGiaCong.SelectedItem.id
        Dim GiaCong = (From itm In dt.tbGiaCongs
                       Where itm.idSanPham = idSanPhamGiaCong
                       Order By itm.id Descending).FirstOrDefault
        If GiaCong Is Nothing Then
            Exit Sub
        End If
        If lstChiTietGiaCong.Count > 0 Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Có muốn hủy chi tiết gia công vừa tạo?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                lstChiTietGiaCong.Clear()
            Else
                Exit Sub
            End If
        End If
        Dim rls = (From itm In dt.tbGiaCongSanPhams
                   Where itm.idSanPhamGiaCong = GiaCong.id).ToList
        For Each itm In rls
            Dim newChiTietGiaCong As New tbGiaCongSanPham
            With newChiTietGiaCong
                .idSanPham = itm.idSanPham
                .MaSanPham = itm.MaSanPham
                .SoLuong = CInt(itm.SoLuong)
                .TenSanPham = itm.TenSanPham
                .DonVi = itm.DonVi
                .DonGia = itm.DonGia
            End With
            lstChiTietGiaCong.Add(newChiTietGiaCong)
        Next
        bsChiTietGiaCong.DataSource = From itm In lstChiTietGiaCong
    End Sub
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vSanPham As vwSanPham = bsSanPham.Current
            Dim sanPham As tbSanPham = dt.tbSanPhams.First(Function(s) s.id = vSanPham.id)
            txtSearch.Text = ""
            CtrlTimKiemSanPham1_ChonSanPhamThanhCong(sanPham, 1, 0)
        ElseIf e.KeyCode = Keys.Down Then
            If dgvSanPham.CurrentCell.RowIndex = dgvSanPham.RowCount - 1 Then
                dgvSanPham.CurrentCell = dgvSanPham.Rows(0).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            Else
                dgvSanPham.CurrentCell = dgvSanPham.Rows(dgvSanPham.CurrentCell.RowIndex + 1).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If dgvSanPham.CurrentCell.RowIndex = 0 Then
                dgvSanPham.CurrentCell = dgvSanPham.Rows(dgvSanPham.RowCount - 1).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            Else
                dgvSanPham.CurrentCell = dgvSanPham.Rows(dgvSanPham.CurrentCell.RowIndex - 1).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            End If
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim key = txtSearch.Text
        If txtSearch.Text = "" Then
            dgvSanPham.Visible = False
            ToolStrip2.Visible = True
            dgvMain.Visible = True
        Else
            dgvSanPham.Visible = True
            ToolStrip2.Visible = False
            dgvMain.Visible = False
            bsSanPham.DataSource = (From s In dt.vwSanPhams
                                    Where (s.TenSanPhamString.Contains(key))
                                    Where s.HetBan = False).Take(My.Settings.SoDongTimKiemSanPham).OrderBy(Function(s) s.MaSanPham)
        End If
    End Sub
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
    Private Sub ctrlGiaCong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCapNhapDanhSach_Click(Nothing, Nothing)
        LaySoPhieuMoiNhat()
    End Sub

    Private Sub txtMaPhieuNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaPhieuNhap.KeyPress, nudTongTien.KeyPress, nudTienLinhKien.KeyPress, nudThanhTien.KeyPress, nudSoLuong.KeyPress, nudChiPhiKhac.KeyPress, cmbSanPhamGiaCong.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
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

    Private Sub dtpNgayNhap_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayNhap.ValueChanged
        LaySoPhieuMoiNhat()
    End Sub
End Class
