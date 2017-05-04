Public Class ctrlDGVNhanVien
    Event ChonNhanVien(nhanVien As tbNhanVien)
    Private Sub dgvNhanVien_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellDoubleClick
        If bsNhanVien.Current IsNot Nothing Then
            RaiseEvent ChonNhanVien(bsNhanVien.Current)
        End If
    End Sub

    Private Sub dgvNhanVien_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvNhanVien.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub bsNhanVien_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsNhanVien.ListChanged
        lblSoDong.Text = bsNhanVien.Count.ToString + " tài khoản."
    End Sub
End Class
