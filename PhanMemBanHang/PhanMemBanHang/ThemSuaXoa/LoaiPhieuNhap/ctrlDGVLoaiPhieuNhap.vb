Public Class ctrlDGVLoaiPhieuNhap
    Property Bs As BindingSource
        Get
            Return dgvMain.DataSource
        End Get
        Set(value As BindingSource)
            dgvMain.AutoGenerateColumns = False
            dgvMain.DataSource = value
        End Set
    End Property

    Private Sub bsLoaiPhieuNhap_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsLoaiPhieuNhap.ListChanged
        lblSoLuong.Text = bsLoaiPhieuNhap.Count.ToString + " loại phiếu nhập."
    End Sub

    Event ChonLoaiPhieuNhap(nl As tbLoaiPhieuNhap)
    Private Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        If Bs.Current Is Nothing Then Exit Sub
        RaiseEvent ChonLoaiPhieuNhap(Bs.Current)
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

End Class
