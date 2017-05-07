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

    Private Sub btnChuaXacNhanSoSeri_Click(sender As Object, e As EventArgs) Handles btnChuaXacNhanSoSeri.Click
        Dim idSanPham As Integer = 0
        If chkTheoSanPham.Checked Then
            If cmbSanPham.SelectedItem Is Nothing Then
                ThongBao("Chưa chọn số seri")
            Else
                idSanPham = cmbSanPham.SelectedItem.id
            End If
        End If
        gridControl.DataSource = From itm In dt.tbChiTietSeris
                                 Where itm.isDanhSo = False Or itm.isDanhSo.HasValue = False
                                 Where Not chkTheoThoiGian.Checked Or (itm.NgayNhap >= dtpTuNgay.Value.Date And itm.NgayNhap >= dtpDenNgay.Value.Date)
                                 Where Not chkTheoSanPham.Checked Or itm.idSanPham = idSanPham
                                 Where chkTheoSanPham.Checked Or itm.MaSeri.Trim.Contains(txtTimKiem.Text.Trim)
        gridViewData.RefreshData()
    End Sub

    Private Sub btnCapNhatSanPham_Click(sender As Object, e As EventArgs) Handles btnCapNhatSanPham.Click
        cmbSanPham.DataSource = From itm In dt.tbSanPhams
                                Where itm.isSeri = True
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
        gridControl.DataSource = From itm In dt.tbChiTietSeris
                                 Where Not chkTheoThoiGian.Checked Or (itm.NgayNhap >= dtpTuNgay.Value.Date And itm.NgayNhap >= dtpDenNgay.Value.Date)
                                 Where Not chkTheoSanPham.Checked Or itm.idSanPham = idSanPham
                                 Where itm.isDanhSo = True
                                 Where chkTheoSanPham.Checked Or itm.MaSeri.Trim.Contains(txtTimKiem.Text.Trim)

        gridViewData.RefreshData()
    End Sub

    Private Sub btnChuaTaoSeri_Click(sender As Object, e As EventArgs) Handles btnChuaTaoSeri.Click
        gridControl.DataSource = From itm In dt.tbChiTietSeris
                                 Where chkTheoSanPham.Checked Or itm.MaSeri.Trim.Contains("*")
        gridViewData.RefreshData()
    End Sub

    Private Sub btnDieuChinh_Click(sender As Object, e As EventArgs) Handles btnDieuChinh.Click
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim ChiTiet As tbChiTietSeri = gridViewData.GetRow(gridViewData.FocusedRowHandle)
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

    Private Sub gridControl_DoubleClick(sender As Object, e As EventArgs) Handles gridControl.DoubleClick

    End Sub


    Private Sub gridViewData_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridViewData.CustomDrawRowIndicator
        If (e.Info.IsRowIndicator) Then
            If e.RowHandle < 0 Then
                e.Info.DisplayText = ""
            Else
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
        End If
    End Sub
End Class
