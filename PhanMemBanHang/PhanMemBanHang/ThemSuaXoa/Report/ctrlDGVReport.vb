Public Class ctrlDGVReport
    Private Sub bsReport_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsReport.ListChanged
        lblSoLuong.Text = bsReport.Count.ToString + " report."
    End Sub

    Event _ReportThayDoi(Report As tbReport)
    Private Sub bsReport_CurrentChanged(sender As Object, e As EventArgs) Handles bsReport.CurrentChanged
        If bsReport.Current IsNot Nothing Then
            RaiseEvent _ReportThayDoi(bsReport.Current)
        End If
    End Sub

    Event ChonReport(nl As tbReport)
    Private Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        If bsReport.Current Is Nothing Then Exit Sub
        RaiseEvent ChonReport(bsReport.Current)
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

End Class
