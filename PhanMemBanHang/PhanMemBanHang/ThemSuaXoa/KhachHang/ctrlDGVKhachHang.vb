Public Class ctrlDGVKhachHang
    Private Sub bsKhachHang_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsKhachHang.ListChanged
        lblSoLuong.Text = bsKhachHang.Count.ToString + " khách hàng."
    End Sub

    Event ChonKhachHang(nl As tbKhachHang)
    Public Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        If bsKhachHang.Current Is Nothing Then Exit Sub
        Dim vKhachHang As vwKhachHang = bsKhachHang.Current
        Dim KhachHang = dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id)
        RaiseEvent ChonKhachHang(KhachHang)
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Event InDanhSachKhachHang()
    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        If bsKhachHang.Count > 0 Then
            RaiseEvent InDanhSachKhachHang()
        End If
    End Sub
    Private Sub dgvMain_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMain.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Dim rowSelected As Integer = e.RowIndex
            If (e.RowIndex <> -1) Then
                Me.dgvMain.ClearSelection()
                Me.dgvMain.Rows(rowSelected).Selected = True
                bsKhachHang.Position = e.RowIndex
            End If
        End If
    End Sub

    Private Sub XemThôngTinLiênHệToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemThôngTinLiênHệToolStripMenuItem.Click
        If bsKhachHang.Current Is Nothing Then
            Exit Sub
        End If
        Dim idKhachHang As Integer = bsKhachHang.Current.id
        Dim frm As New frmDanhSachThongTinLienHe
        frm.idKhachHang = idKhachHang
        frm.ShowDialog()
    End Sub

    Private Sub dgvMain_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvMain.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvMain_CellDoubleClick(Nothing, Nothing)
        End If
    End Sub
End Class
