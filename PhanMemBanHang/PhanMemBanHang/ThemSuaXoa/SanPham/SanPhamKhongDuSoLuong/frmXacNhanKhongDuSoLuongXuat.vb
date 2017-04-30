Public Class frmXacNhanKhongDuSoLuongXuat

    Private Sub btnVanXuat_Click(sender As Object, e As EventArgs) Handles btnVanXuat.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub frmXacNhanKhongDuSoLuongXuat_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmXacNhanKhongDuSoLuongXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        btnVanXuat.Focus()
    End Sub
End Class