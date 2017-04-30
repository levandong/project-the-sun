Public Class ctrlDGVLoaiSanPham
    Event ChonLoaiSanPham(LoaiSanPham As tbLoaiSanPham)
    Private Sub dgvLoaiSanPham_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiSanPham.CellDoubleClick
        If bsLoaiSanPham.Current IsNot Nothing Then
            RaiseEvent ChonLoaiSanPham(bsLoaiSanPham.Current)
            dgvLoaiSanPham.InvalidateRow(e.RowIndex)
        End If
    End Sub

    Private Sub dgvLoaiSanPham_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvLoaiSanPham.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Event LoaiSanPhamThayDoi()
    Private Sub bsLoaiSanPham_CurrentChanged(sender As Object, e As EventArgs) Handles bsLoaiSanPham.CurrentChanged
        RaiseEvent LoaiSanPhamThayDoi()
    End Sub

    Private Sub bsLoaiSanPham_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsLoaiSanPham.ListChanged
        lblSoDong.Text = bsLoaiSanPham.Count.ToString + " loại."
    End Sub

    Private Sub dgvLoaiSanPham_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiSanPham.CellValueChanged
        RaiseEvent LoaiSanPhamThayDoi()
    End Sub


    Private Sub dgvLoaiSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiSanPham.CellClick
        RaiseEvent LoaiSanPhamThayDoi()
    End Sub

    Private Sub dgvLoaiSanPham_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvLoaiSanPham.CurrentCellDirtyStateChanged
        If dgvLoaiSanPham.IsCurrentCellDirty Then
            dgvLoaiSanPham.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class
