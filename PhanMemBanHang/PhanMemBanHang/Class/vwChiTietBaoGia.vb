Public Class vwChiTietBaoGia
    ReadOnly Property MaPhieu As String
        Get
            Return NgayLap.ToString("MMyy") + "B" + Me.SoPhieu.ToString.PadLeft(4, "0")
        End Get
    End Property
    ReadOnly Property ThanhTien As Decimal
        Get
            Return Me.DonGia * Me.SoLuong
        End Get
    End Property

    ReadOnly Property KhachHangNhaCungCap As String
        Get
            Return dt.tbKhachHangs.First(Function(s) s.id = Me.idKhachHang).TenKhachHang.Trim
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
    Private _KhoiLuongRieng As Double
    Property KhoiLuongRieng As Double
        Get
            Return _KhoiLuongRieng
        End Get
        Set(value As Double)
            _KhoiLuongRieng = value
        End Set
    End Property
    ' SoAm
    Private _SoAm As Boolean
    Property SoAm As Boolean
        Get
            Return _SoAm
        End Get
        Set(value As Boolean)
            _SoAm = value
        End Set
    End Property
End Class
