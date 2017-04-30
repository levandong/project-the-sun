Public Class tbNhanVien
    Public Overrides Function ToString() As String
        Return Me.TenDangNhap + "-" + Me.TenNhanVien
    End Function
End Class
