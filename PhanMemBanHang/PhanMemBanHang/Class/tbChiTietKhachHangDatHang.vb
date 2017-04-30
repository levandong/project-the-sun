Public Class tbChiTietKhachHangDatHang
    Private _ThanhTien As Decimal
    ReadOnly Property ThanhTien As Decimal
        Get
            Return Me.SoLuong * Me.GiaBan
        End Get
    End Property
    Private _KhoiLuongRieng As Double
    Property KhoiLuongRieng As Double
        Get
            If Me.tbSanPham Is Nothing Then
                Return _KhoiLuongRieng
            Else
                Return Me.tbSanPham.KhoiLuongRieng
            End If
        End Get
        Set(value As Double)
            _KhoiLuongRieng = value
        End Set
    End Property

    Private _MaSanPham As String
    ' iSTT
    Private _iSTT As Integer
    Property iSTT As Integer
        Get
            Return _iSTT
        End Get
        Set(value As Integer)
            _iSTT = value
        End Set
    End Property

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
    ' Con
    Private _Con As Integer
    Property Con As Integer
        Get
            Return _Con
        End Get
        Set(value As Integer)
            _Con = value
        End Set
    End Property

    ' DaGiao
    Private _DaGiao As Integer
    Property DaGiao As Integer
        Get
            Return _DaGiao
        End Get
        Set(value As Integer)
            _DaGiao = value
        End Set
    End Property
    Private _GiaChietKhau As Decimal
    Property GiaChietKhau As Decimal
        Get
            Return _GiaChietKhau
        End Get
        Set(value As Decimal)
            _GiaChietKhau = value
        End Set
    End Property
    Private _TonKho As Decimal
    Property TonKho As Decimal
        Get
            If Me.tbSanPham Is Nothing Then
                Return _TonKho
            Else
                Return Me.tbSanPham.SoLuong
            End If
        End Get
        Set(value As Decimal)
            _TonKho = value
        End Set
    End Property
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
