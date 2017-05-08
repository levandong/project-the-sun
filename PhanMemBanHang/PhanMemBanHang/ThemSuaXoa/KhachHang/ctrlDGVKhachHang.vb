Public Class ctrlDGVKhachHang
    Event ChonKhachHang(nl As tbKhachHang)

    Event InDanhSachKhachHang()

    Private Sub mnuItemViewContact_Click(sender As Object, e As EventArgs) Handles mnuItemViewContact.Click
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vKhachHang As vwKhachHang = gridViewData.GetRow(gridViewData.FocusedRowHandle)
        Dim frm As New frmDanhSachThongTinLienHe
        frm.idKhachHang = vKhachHang.id
        frm.ShowDialog()
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

    Private Sub mnuItemExportExcel_Click(sender As Object, e As EventArgs) Handles mnuItemExportExcel.Click
        If gridViewData.DataRowCount > 0 Then
            ExportExcelFromGridView(gridControl)
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        mnuItemExportExcel.Enabled = gridViewData.DataRowCount > 0
        mnuItemPrint.Enabled = gridViewData.DataRowCount > 0
    End Sub

    Private Sub mnuItemPrint_Click(sender As Object, e As EventArgs) Handles mnuItemPrint.Click
        RaiseEvent InDanhSachKhachHang()
    End Sub

    Private Sub gridControl_KeyDown(sender As Object, e As KeyEventArgs) Handles gridControl.KeyDown
        If e.KeyCode = Keys.Enter Then
            If gridViewData.FocusedRowHandle < 0 Then
                Exit Sub
            End If
            Dim vKhachHang As vwKhachHang = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            RaiseEvent ChonKhachHang(dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id))
        End If
    End Sub

    Private Sub gridControl_DoubleClick(sender As Object, e As EventArgs) Handles gridControl.DoubleClick
        mnuItemViewContact_Click(Nothing, Nothing)
    End Sub
End Class
