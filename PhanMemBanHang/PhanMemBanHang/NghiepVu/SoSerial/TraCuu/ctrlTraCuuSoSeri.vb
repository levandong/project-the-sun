Public Class ctrlTraCuuSoSeri
    Private Sub ctrlTraCuuSoSeri_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnCapNhatSanPham_Click(Nothing, Nothing)
        Dim rls = From itm In dt.tbChiTietSeris Where itm.isDanhSo = False Or itm.isDanhSo.HasValue = False
        btnChuaTaoSeri.Text = "Có " + rls.ToList.Count.ToString + " sản phẩm chưa tạo số seri"

    End Sub

    Private Sub chkTheoThoiGian_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoThoiGian.CheckedChanged
        dtpDenNgay.Enabled = chkTheoThoiGian.Checked
        dtpTuNgay.Enabled = chkTheoThoiGian.Checked
    End Sub

    Private Sub chkTheoSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoSanPham.CheckedChanged
        cmbSanPham.Enabled = chkTheoSanPham.Checked
        txtTimKiem.Enabled = Not chkTheoSanPham.Checked
    End Sub
    Private Sub dgvMain_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMain.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Dim rowSelected As Integer = e.RowIndex
            If (e.RowIndex <> -1) Then
                Me.dgvMain.ClearSelection()
                Me.dgvMain.Rows(rowSelected).Selected = True
                bsChiTietSoSeri.Position = e.RowIndex
            End If
        End If
    End Sub
    Private Sub btnChuaXacNhanSoSeri_Click(sender As Object, e As EventArgs) Handles btnChuaXacNhanSoSeri.Click
        Dim idSanPham As Integer = 0
        If chkTheoSanPham.Checked Then
            If cmbSanPham.SelectedItem Is Nothing Then
                ThongBao("Chưa chọn số seri")
            Else
                idSanPham = cmbSanPham.SelectedItem.id
            End If
        End If
        bsChiTietSoSeri.DataSource = From itm In dt.tbChiTietSeris
                                     Where itm.isDanhSo = False Or itm.isDanhSo.HasValue = False
                                     Where Not chkTheoThoiGian.Checked Or (itm.NgayNhap >= dtpTuNgay.Value.Date And itm.NgayNhap >= dtpDenNgay.Value.Date)
                                     Where Not chkTheoSanPham.Checked Or itm.idSanPham = idSanPham
                                     Where chkTheoSanPham.Checked Or itm.MaSeri.Trim.Contains(txtTimKiem.Text.Trim)
    End Sub

    Private Sub btnCapNhatSanPham_Click(sender As Object, e As EventArgs) Handles btnCapNhatSanPham.Click
        cmbSanPham.DataSource = From itm In dt.tbSanPhams
                                Where itm.isSeri = True
    End Sub
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim idSanPham As Integer = 0
        If chkTheoSanPham.Checked Then
            If cmbSanPham.SelectedItem Is Nothing Then
                ThongBao("")
            Else
                idSanPham = cmbSanPham.SelectedItem.id
            End If
        End If
        bsChiTietSoSeri.DataSource = From itm In dt.tbChiTietSeris
                                     Where Not chkTheoThoiGian.Checked Or (itm.NgayNhap >= dtpTuNgay.Value.Date And itm.NgayNhap >= dtpDenNgay.Value.Date)
                                     Where Not chkTheoSanPham.Checked Or itm.idSanPham = idSanPham
                                     Where itm.isDanhSo = True
                                     Where chkTheoSanPham.Checked Or itm.MaSeri.Trim.Contains(txtTimKiem.Text.Trim)
    End Sub

    Private Sub btnChuaTaoSeri_Click(sender As Object, e As EventArgs) Handles btnChuaTaoSeri.Click
        bsChiTietSoSeri.DataSource = From itm In dt.tbChiTietSeris
                                     Where chkTheoSanPham.Checked Or itm.MaSeri.Trim.Contains("*")
    End Sub

    Private Sub btnDieuChinh_Click(sender As Object, e As EventArgs) Handles btnDieuChinh.Click
        Dim ChiTiet As tbChiTietSeri = bsChiTietSoSeri.Current
        Dim ChiTietPhieuNhap As tbChiTietPhieuNhap = (From itm In dt.tbChiTietPhieuNhaps
                                                      Where itm.idSanPham = ChiTiet.idSanPham And itm.idPhieuNhap = ChiTiet.idPhieuNhap).FirstOrDefault
        Dim frm = New frmChinhSuaSeri
        frm.idPhieuNhap = ChiTiet.idPhieuNhap
        frm.idSanPham = ChiTiet.idSanPham
        frm.pnlMain.Panel1Collapsed = False
        frm.ShowDialog()
    End Sub

    Private Sub ĐiềuChỉnhSeriPhiếuNhậpNàyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐiềuChỉnhSeriPhiếuNhậpNàyToolStripMenuItem.Click
        btnDieuChinh_Click(Nothing, Nothing)
    End Sub
End Class
