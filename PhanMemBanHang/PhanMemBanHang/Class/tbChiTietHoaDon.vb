Public Class tbChiTietHoaDon
    ReadOnly Property SoLuongBan As Double
        Get
            If Me.TheoDonVi Then
                Return Me.SoLuong
            Else
                Return Me.SoLuong * Me.QuyCach
            End If
        End Get
    End Property

    Private _ThanhTien As Decimal
    ReadOnly Property ThanhTien As Decimal
        Get
            Return (SoLuong * Me.DonGia * (100 - Me.ChietKhau) / 100) - (Me.SoLuong * Me.GiamGia)
        End Get
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


End Class
