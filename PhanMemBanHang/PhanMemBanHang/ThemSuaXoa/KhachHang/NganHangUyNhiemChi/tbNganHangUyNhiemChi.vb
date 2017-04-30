Public Class tbNganHangUyNhiemChi
    Public Overrides Function ToString() As String
        Return Me.TenNganHang.Trim + "/" + Me.SoTaiKhoan.Trim
    End Function
End Class
