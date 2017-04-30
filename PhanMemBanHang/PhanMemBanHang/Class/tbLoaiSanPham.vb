Public Class tbLoaiSanPham
    Public Overrides Function ToString() As String
        Return Me.TenLoaiSanPham
    End Function

    Private _Chon As Boolean
    Property Chon As Boolean
        Get
            Return _Chon
        End Get
        Set(value As Boolean)
            _Chon = value
        End Set
    End Property
End Class
