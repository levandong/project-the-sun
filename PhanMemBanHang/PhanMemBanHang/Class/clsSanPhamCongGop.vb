Public Class clsSanPhamCongGop
    Private _idSanPham As Integer
    Public Property idSanPham As Integer
        Get
            Return _idSanPham
        End Get
        Set(ByVal value As Integer)
            _idSanPham = value
        End Set
    End Property


    Private _TenSanPham As String
    Public Property TenSanPham As String
        Get
            Return _TenSanPham
        End Get
        Set(ByVal value As String)
            _TenSanPham = value
        End Set
    End Property

    Private _MaSanPham As String
    Public Property MaSanPham As String
        Get
            Return _MaSanPham
        End Get
        Set(ByVal value As String)
            _MaSanPham = value
        End Set
    End Property


    Private _DonVi As String
    Public Property DonVi As String
        Get
            Return _DonVi
        End Get
        Set(ByVal value As String)
            _DonVi = value
        End Set
    End Property

    Private _TenLoaiSanPham As String
    Public Property TenLoaiSanPham As String
        Get
            Return _TenLoaiSanPham
        End Get
        Set(ByVal value As String)
            _TenLoaiSanPham = value
        End Set
    End Property

    Private _idLoaiSanPham As Integer
    Public Property idLoaiSanPham As Integer
        Get
            Return _idLoaiSanPham
        End Get
        Set(ByVal value As Integer)
            _idLoaiSanPham = value
        End Set
    End Property

    Private _SoLuong As Double
    Public Property SoLuong As Double
        Get
            Return _SoLuong
        End Get
        Set(ByVal value As Double)
            _SoLuong = value
        End Set
    End Property

    Private _ThanhTien As Decimal
    Public Property ThanhTien As Decimal
        Get
            Return _ThanhTien
        End Get
        Set(ByVal value As Decimal)
            _ThanhTien = value
        End Set
    End Property
End Class

