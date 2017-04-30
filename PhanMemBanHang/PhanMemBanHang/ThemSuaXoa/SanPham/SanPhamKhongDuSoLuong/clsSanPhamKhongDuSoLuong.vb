Public Class clsSanPhamKhongDuSoLuong
    Private _TenSanPham As String
    Property TenSanPham As String
        Get
            Return _TenSanPham
        End Get
        Set(value As String)
            _TenSanPham = value
        End Set
    End Property

    Private _MaSanPham As String
    Property MaSanPham As String
        Get
            Return _MaSanPham
        End Get
        Set(value As String)
            _MaSanPham = value
        End Set
    End Property

    Private _SoLuongCon As Double
    Property SoLuongCon As Double
        Get
            Return _SoLuongCon
        End Get
        Set(value As Double)
            _SoLuongCon = value
        End Set
    End Property

    Private _SoLuongXuat As Double
    Property SoLuongXuat As Double
        Get
            Return _SoLuongXuat
        End Get
        Set(value As Double)
            _SoLuongXuat = value
        End Set
    End Property

    Private _SoLuongTon As Double
    Property SoLuongTon As Double
        Get
            Return _SoLuongTon
        End Get
        Set(value As Double)
            _SoLuongTon = value
        End Set
    End Property
    Sub New(tsp As String, msp As String, slt As Double, slx As Double, slc As Double)
        TenSanPham = tsp
        MaSanPham = msp
        SoLuongXuat = slx
        SoLuongCon = slc
        SoLuongTon = slt
    End Sub
End Class
