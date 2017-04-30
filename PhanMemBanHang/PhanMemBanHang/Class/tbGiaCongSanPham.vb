Public Class tbGiaCongSanPham
    Private _TenSanPham As String
    Property TenSanPham As String
        Get
            If Me.tbSanPham IsNot Nothing Then
                _TenSanPham = Me.tbSanPham.TenSanPham
            End If
            Return _TenSanPham
        End Get
        Set(value As String)
            _TenSanPham = value
        End Set
    End Property
    Private _MaSanPham As String
    Property MaSanPham As String
        Get
            If Me.tbSanPham IsNot Nothing Then
                _MaSanPham = Me.tbSanPham.MaSanPham
            End If
            Return _MaSanPham
        End Get
        Set(value As String)
            _MaSanPham = value
        End Set
    End Property
    Private _ThanhTien As Decimal
    ReadOnly Property ThanhTien As Decimal
        Get
            Return SoLuong * Me.DonGia
        End Get
    End Property

    Private _DonVi As String
    Property DonVi As String
        Get
            If Me.tbSanPham IsNot Nothing Then
                _DonVi = Me.tbSanPham.DonVi
            End If
            Return _DonVi
        End Get
        Set(value As String)
            _DonVi = value
        End Set
    End Property

    Private _idLoaiSanPham As Integer
    Property idLoaiSanPham As Integer
        Get
            If Me.tbSanPham IsNot Nothing Then
                _idLoaiSanPham = Me.tbSanPham.tbLoaiSanPham.id
            End If
            Return _idLoaiSanPham
        End Get
        Set(value As Integer)
            _idLoaiSanPham = value
        End Set
    End Property

    Private _TenLoaiSanPham As String
    Property TenLoaiSanPham As String
        Get
            If Me.tbSanPham IsNot Nothing Then
                _TenLoaiSanPham = Me.tbSanPham.tbLoaiSanPham.TenLoaiSanPham
            End If
            Return _TenLoaiSanPham
        End Get
        Set(value As String)
            _TenLoaiSanPham = value
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


End Class
