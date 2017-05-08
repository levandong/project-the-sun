Public Class ctrlDGVLoaiPhieuNhap


    Event ChonLoaiPhieuNhap(nl As tbLoaiPhieuNhap)

    Private Sub gridViewData_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridViewData.CustomDrawRowIndicator
        If (e.Info.IsRowIndicator) Then
            If e.RowHandle < 0 Then
                
                e.Info.DisplayText = ""
            Else
                
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
        End If
    End Sub

    Private Sub gridControl_DoubleClick(sender As Object, e As EventArgs) Handles gridControl.DoubleClick
        If gridViewData.FocusedRowHandle >= 0 Then
            Dim LoaiPhieuXuat As tbLoaiPhieuNhap = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            RaiseEvent ChonLoaiPhieuNhap(LoaiPhieuXuat)
        End If
    End Sub

    Private Sub mnuItemExportExcel_Click(sender As Object, e As EventArgs) Handles mnuItemExportExcel.Click
        If gridViewData.DataRowCount > 0 Then
            ExportExcelFromGridView(gridControl)
        End If
    End Sub
End Class
