Public Class tbChiTietBaoGia
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
    Private _ThanhTien As Decimal
    ReadOnly Property ThanhTien As Decimal
        Get
            If Me.DonGia = 0 Then
                Dim s As Double = (SoLuong * Me.GiaNiemYet * (100 - Me.ChietKhau) / 10000)
                Return Math.Round(s, 0, MidpointRounding.AwayFromZero) * 100
            Else
                Return (SoLuong * Me.DonGia)
            End If
        End Get
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
    Private _TonKho As Double
    Property TonKho As Double
        Get
            If Me.tbSanPham IsNot Nothing Then
                Return Me.tbSanPham.SoLuong
            End If
            Return _TonKho
        End Get
        Set(value As Double)
            _TonKho = value
        End Set
    End Property
    Private _KhoiLuongRieng As Double
    Property KhoiLuongRieng As Double
        Get
            If Me.tbSanPham IsNot Nothing Then
                Return Me.tbSanPham.KhoiLuongRieng
            End If
            Return _KhoiLuongRieng
        End Get
        Set(value As Double)
            _KhoiLuongRieng = value
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
    Private _iSTT As Integer
    Property iSTT As Integer
        Get
            Return _iSTT
        End Get
        Set(value As Integer)
            _iSTT = value
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
End Class
