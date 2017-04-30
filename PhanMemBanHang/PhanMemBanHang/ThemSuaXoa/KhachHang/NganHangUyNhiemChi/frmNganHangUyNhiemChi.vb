Public Class frmNganHangUyNhiemChi
    Public KhachHang As tbKhachHang
    Private Sub frmNganHangUyNhiemChi_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F2 Then
            CtrlThemSuaXoaNganHangUyNhiemChi1.btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            CtrlThemSuaXoaNganHangUyNhiemChi1.btnSua_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            CtrlThemSuaXoaNganHangUyNhiemChi1.btnXoa_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub frmNganHangUyNhiemChi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Ngân hàng UNC " + KhachHang.TenRutGon
    End Sub
End Class