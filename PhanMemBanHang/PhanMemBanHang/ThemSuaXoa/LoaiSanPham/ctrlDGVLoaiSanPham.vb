Public Class ctrlDGVLoaiSanPham
    Event ChonLoaiSanPham(LoaiSanPham As tbLoaiSanPham)

    Private Sub gridControl_DoubleClick(sender As Object, e As EventArgs) Handles gridControl.DoubleClick
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim LoaiSanPham As tbLoaiSanPham = gridViewData.GetRow(gridViewData.FocusedRowHandle)
        RaiseEvent ChonLoaiSanPham(LoaiSanPham)
    End Sub

    Event LoaiSanPhamThayDoi()

    Private Sub dgvLoaiSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        RaiseEvent LoaiSanPhamThayDoi()
    End Sub

    Private Sub dgvLoaiSanPham_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
        'If dgvLoaiSanPham.IsCurrentCellDirty Then
        '    dgvLoaiSanPham.CommitEdit(DataGridViewDataErrorContexts.Commit)
        'End If
    End Sub

    Private Sub gridViewData_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridViewData.CustomDrawRowIndicator
        If (e.Info.IsRowIndicator) Then
            If e.RowHandle < 0 Then
                e.Info.ImageIndex = 0
                e.Info.DisplayText = ""
            Else
                e.Info.ImageIndex = 1
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
        End If
    End Sub

    Private Sub gridViewData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewData.FocusedRowChanged
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim LoaiSanPham As tbLoaiSanPham = gridViewData.GetRow(gridViewData.FocusedRowHandle)
        RaiseEvent ChonLoaiSanPham(LoaiSanPham)
    End Sub


    Private Sub gridViewData_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gridViewData.RowClick
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim LoaiSanPham As tbLoaiSanPham = gridViewData.GetRow(gridViewData.FocusedRowHandle)
        RaiseEvent ChonLoaiSanPham(LoaiSanPham)
    End Sub
End Class
