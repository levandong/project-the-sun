Public Class frmTimKiemSanPham

    Private Sub frmTimKiemSanPham_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmTimKiemSanPham_Load(sender As Object, e As EventArgs) Handles Me.Load
        With CtrlTimKiemSanPhamMoi1
            .txtSoLuong.Visible = False
            .nudDonVi.Visible = False
        End With
        Me.KeyPreview = True
    End Sub

    Public SanPhamDuocChon As New tbSanPham
    Private Sub CtrlTimKiemSanPhamMoi1_ChonSanPhamThanhCong(SanPham As tbSanPham, SoLuong As Double, TheoDonVi As Boolean) Handles CtrlTimKiemSanPhamMoi1.ChonSanPhamThanhCong
        SanPhamDuocChon = dt.tbSanPhams.Single(Function(s) s.id = SanPham.id)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class