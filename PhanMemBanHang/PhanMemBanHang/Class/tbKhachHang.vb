Public Class tbKhachHang
    Public Overrides Function ToString() As String
        Return Me.MaKhachHang + "-" + Me.TenKhachHang
    End Function

    ReadOnly Property CongNoHienTai As Decimal
        Get
            If vKhachHang IsNot Nothing Then
                Return Me.CongNoDauKy + vKhachHang.TongTienHoaDon - vKhachHang.TongTienDaTra
            Else
                Return Me.CongNoDauKy
            End If
        End Get
    End Property

    ReadOnly Property vKhachHang As vwKhachHang
        Get
            Return dt.vwKhachHangs.First(Function(s) s.id = Me.id)
        End Get
    End Property
    ReadOnly Property Loai As String
        Get
            If Me.isNhaCungCap Is Nothing Then
                Return "KH/NCC"
            ElseIf Me.isNhaCungCap = False Then
                Return "KH"
            Else
                Return "NCC"
            End If
        End Get
    End Property
End Class
