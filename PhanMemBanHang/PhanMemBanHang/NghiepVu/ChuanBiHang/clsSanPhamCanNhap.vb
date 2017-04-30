Public Class clsSanPhamCanNhap
    ' id
    Private _id As Integer
    Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    ' STT
    Private _STT As Integer
    Property STT As Integer
        Get
            Return _STT
        End Get
        Set(value As Integer)
            _STT = value
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

    ' SoLuongMua
    Private _SoLuongMua As Double
    Property SoLuongMua As Double
        Get
            Return _SoLuongMua
        End Get
        Set(value As Double)
            _SoLuongMua = value
        End Set
    End Property


    ' TenCongTrinh
    Private _TenCongTrinh As String
    Property TenCongTrinh As String
        Get
            Return _TenCongTrinh
        End Get
        Set(value As String)
            _TenCongTrinh = value
        End Set
    End Property

    ' TenKhachHang
    Private _TenKhachHang As String
    Property TenKhachHang As String
        Get
            Return _TenKhachHang
        End Get
        Set(value As String)
            _TenKhachHang = value
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
    Private _TonKho As Double
    Property TonKho As Double
        Get
            Return _TonKho
        End Get
        Set(value As Double)
            _TonKho = value
        End Set
    End Property

    ' TonKhoToiThieu
    Private _TonKhoToiThieu As Double
    Property TonKhoToiThieu As Double
        Get
            Return _TonKhoToiThieu
        End Get
        Set(value As Double)
            _TonKhoToiThieu = value
        End Set
    End Property

    ' SoLuongChuanBiNhap
    Private _SoLuongChuanBiNhap As Double
    Property SoLuongChuanBiNhap As Double
        Get
            Return _SoLuongChuanBiNhap
        End Get
        Set(value As Double)
            _SoLuongChuanBiNhap = value
        End Set
    End Property

    ' SoLuongChuanBiXuat
    Private _SoLuongChuanBiXuat As Double
    Property SoLuongChuanBiXuat As Double
        Get
            Return _SoLuongChuanBiXuat
        End Get
        Set(value As Double)
            _SoLuongChuanBiXuat = value
        End Set
    End Property

    ' SoLuongCan
    ReadOnly Property SoLuongCan As Double
        Get
            Return SoLuongChuanBiXuat - SoLuongChuanBiNhap + TonKhoToiThieu - TonKho
        End Get
    End Property
End Class
