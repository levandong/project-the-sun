Public Class ctrlDGVSanPhamCongGop
    Public ThoiGianTimKiem As String
    Public LoaiThongKe As String

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub bsDaBan_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsDaBan.ListChanged
        lblSoLuong.Text = dgvMain.RowCount.ToString + " sản phẩm"
        Dim tongTien As Decimal
        For Each row As DataGridViewRow In dgvMain.Rows
            tongTien += row.Cells("ThanhTien").Value
        Next
        lblTongTien.Text = String.Format("{0:N0}", tongTien) + "đ"
    End Sub

    Private Sub btnInDanhSach_Click(sender As Object, e As EventArgs) Handles btnInDanhSach.Click
        Dim frm As New frmInDanhSach
        frm.Text = LoaiThongKe
        frm.rptName = ".\Report\SanPham\rptDanhSachSanPhamCongGop.rdlc"
        frm.dsName = "dsDanhSachSanPham"
        frm._bs = bsDaBan
        frm.timkiemtheo = ""
        frm.ThoiGianTimKiem = ThoiGianTimKiem
        frm.ShowDialog()
    End Sub
End Class
