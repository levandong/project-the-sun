Public Class ctrlDGVLoaiPhieuXuat
    Property Bs As BindingSource
        Get
            Return dgvMain.DataSource
        End Get
        Set(value As BindingSource)
            dgvMain.AutoGenerateColumns = False
            dgvMain.DataSource = value
        End Set
    End Property

    Private Sub bsLoaiPhieuXuat_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsLoaiPhieuXuat.ListChanged
        lblSoLuong.Text = bsLoaiPhieuXuat.Count.ToString + " loại phiếu xuất."
    End Sub

    Event ChonLoaiPhieuXuat(nl As tbLoaiPhieuXuat)
    Private Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        If Bs.Current Is Nothing Then Exit Sub
        RaiseEvent ChonLoaiPhieuXuat(Bs.Current)
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
End Class
