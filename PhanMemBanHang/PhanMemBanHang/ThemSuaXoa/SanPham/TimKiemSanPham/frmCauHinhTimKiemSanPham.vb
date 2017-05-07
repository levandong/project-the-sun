Public Class frmCauHinhTimKiemSanPham


    Private Sub btnApDung_Click(sender As Object, e As EventArgs) Handles btnApDung.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmCauHinhTimKiemSanPham_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnApDung_Click(Nothing, Nothing)
        End If
    End Sub
End Class