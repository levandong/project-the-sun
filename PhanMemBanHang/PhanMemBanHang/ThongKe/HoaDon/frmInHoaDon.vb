Public Class frmInHoaDon
    Private Sub frmInHoaDon_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            CtrlInHoaDon1.btnCapNhat_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.P Then
            'CtrlInHoaDon1.ReportViewer1.PrintDialog()
        End If
    End Sub
End Class