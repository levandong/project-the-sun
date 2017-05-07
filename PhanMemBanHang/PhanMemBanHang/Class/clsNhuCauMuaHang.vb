Public Class clsNhuCauMuaHang
    ' idSanPham
    Private _idSanPham As Integer
    Property idSanPham As Integer
        Get
            Return _idSanPham
        End Get
        Set(value As Integer)
            _idSanPham = value
        End Set
    End Property


    ' MaSanPham
    Private _MaSanPham As String
    Property MaSanPham As String
        Get
            Return _MaSanPham
        End Get
        Set(value As String)
            _MaSanPham = value
        End Set
    End Property
    ' TonKho
    Private _TonKho As Integer
    Property TonKho As Integer
        Get
            Return _TonKho
        End Get
        Set(value As Integer)
            _TonKho = value
        End Set
    End Property
    ' SoLuongMua
    Private _SoLuongMua As Integer
    Property SoLuongMua As Integer
        Get
            Return _SoLuongMua
        End Get
        Set(value As Integer)
            _SoLuongMua = value
        End Set
    End Property


    ' TenSanPham
    Private _TenSanPham As String
    Property TenSanPham As String
        Get
            Return _TenSanPham
        End Get
        Set(value As String)
            _TenSanPham = value
        End Set
    End Property

    ' DonVi
    Private _DonVi As String
    Property DonVi As String
        Get
            Return _DonVi
        End Get
        Set(value As String)
            _DonVi = value
        End Set
    End Property

    ' SoLuong
    Private _SoLuong As Integer
    Property SoLuong As Integer
        Get
            Return _SoLuong
        End Get
        Set(value As Integer)
            _SoLuong = value
        End Set
    End Property

    ' GiaNiemYet
    Private _GiaNiemYet As Decimal
    Property GiaNiemYet As Decimal
        Get
            Return _GiaNiemYet
        End Get
        Set(value As Decimal)
            _GiaNiemYet = value
        End Set
    End Property

    ' NgayNiemYet
    Private _NgayNiemYet As Date
    Property NgayNiemYet As Date
        Get
            Return _NgayNiemYet
        End Get
        Set(value As Date)
            _NgayNiemYet = value
        End Set
    End Property

    ' GhiChu
    Private _GhiChu As String
    Property GhiChu As String
        Get
            Return _GhiChu
        End Get
        Set(value As String)
            _GhiChu = value
        End Set
    End Property

    ' Chon
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
