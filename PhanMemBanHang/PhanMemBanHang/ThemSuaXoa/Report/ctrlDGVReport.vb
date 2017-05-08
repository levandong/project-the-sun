Public Class ctrlDGVReport
    Event _ReportThayDoi(Report As tbReport)

    Event ChonReport(nl As tbReport)

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
            Dim Report As tbReport = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            RaiseEvent ChonReport(Report)
        End If
    End Sub

    Private Sub gridViewData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewData.FocusedRowChanged
        If gridViewData.FocusedRowHandle >= 0 Then
            Dim Report As tbReport = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            RaiseEvent _ReportThayDoi(Report)
        End If
    End Sub

    Private Sub mnuItemExportExcel_Click(sender As Object, e As EventArgs) Handles mnuItemExportExcel.Click
        If gridViewData.DataRowCount > 0 Then
            ExportExcelFromGridView(gridControl)
        End If
    End Sub
End Class
