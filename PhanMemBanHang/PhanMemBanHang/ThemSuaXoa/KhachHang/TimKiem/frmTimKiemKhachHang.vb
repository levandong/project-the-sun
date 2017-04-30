Public Class frmTimKiemKhachHang
    Event ChonKhachHangThanhCong(khachHang As tbKhachHang)
    Private _isNhaCungCap As Integer
    Property isNhaCungCap As Integer
        Get
            Return _isNhaCungCap
        End Get
        Set(value As Integer)
            _isNhaCungCap = value
        End Set
    End Property
    Private Sub CtrlTimKiemKhachHang1_ChonKhachHangThanhCong(KhachHang As tbKhachHang) Handles CtrlTimKiemKhachHang1.ChonKhachHangThanhCong
        RaiseEvent ChonKhachHangThanhCong(KhachHang)
        Me.Close()
    End Sub


    Private Sub frmTimKiemKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
      If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmTimKiemKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        CtrlTimKiemKhachHang1.isNhaCungCap = isNhaCungCap
        CtrlTimKiemKhachHang1.txtSearch.Focus()
    End Sub

End Class