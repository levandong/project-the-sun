Public Class ctrlTabHeader
    Public tabPanel As Control
    Event CloseTabpage(tabHeader As ctrlTabHeader)
    Public Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        RaiseEvent CloseTabpage(Me)
    End Sub

    Private Sub chkCheck_MouseHover(sender As Object, e As EventArgs) Handles chkCheck.MouseHover
        btnClose.Visible = True
    End Sub

    Private Sub chkCheck_MouseLeave(sender As Object, e As EventArgs) Handles chkCheck.MouseLeave
        If (CType(sender, Control).ClientRectangle.Contains(CType(sender, Control).PointToClient(Control.MousePosition))) Then
            Exit Sub
        End If
        btnClose.Visible = False
    End Sub


End Class
