Public Class tbChiTietPhieuXuat

    Private _ThanhTien As Decimal
    ReadOnly Property ThanhTien As Decimal
        Get
            Return SoLuong * Me.GiaBan
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
    ' SoLuongXuat
    Private _SoLuongXuat As Integer
    Property SoLuongXuat As Integer
        Get
            Return _SoLuongXuat
        End Get
        Set(value As Integer)
            _SoLuongXuat = value
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

    Private _DonVi As String
    Property DonVi As String
        Get
            If Me.tbSanPham IsNot Nothing Then
                If Me.TheoDonVi Then
                    _DonVi = Me.tbSanPham.DonVi
                Else
                    _DonVi = Me.tbSanPham.DonViQuyCach
                End If
            End If
            Return _DonVi
        End Get
        Set(value As String)
            _DonVi = value
        End Set
    End Property
End Class
