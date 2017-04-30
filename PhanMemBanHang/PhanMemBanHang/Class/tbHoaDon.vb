Public Class tbHoaDon

    Public Overrides Function ToString() As String
        Return Me.MaHoaDon
    End Function


    Private _CongTien As Decimal
    Public Property CongTien As Decimal
        Get
            Dim rls = dt.tbChiTietHoaDons.Where(Function(s) s.idHoaDon = Me.id)
            If rls.Count = 0 Then
                Return _CongTien
            End If
            Return rls.Sum(Function(s) s.SoLuong * s.DonGia * (100 - s.ChietKhau) / 100) - rls.Sum(Function(s) s.SoLuong * s.GiamGia)
        End Get
        Set(ByVal value As Decimal)
            _CongTien = value
        End Set
    End Property


    Private _TongTienDaGiamGia As Decimal
    Public Property TongTienDaGiamGia() As Decimal
        Get
            Dim rls = dt.tbChiTietHoaDons.Where(Function(s) s.idHoaDon = Me.id)
            If rls.Count = 0 Then
                Return _TongTienDaGiamGia
            End If
            Return Math.Round((CongTien * (100 - Me.ChietKhau) / 100 * (100 + Me.VAT) / 100), 0, MidpointRounding.AwayFromZero) - Me.SoTienGiam
        End Get
        Set(ByVal value As Decimal)
            _TongTienDaGiamGia = value
        End Set
    End Property


    ReadOnly Property MaHoaDon As String
        Get
            Return "HD/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoHoaDon.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
        End Get
    End Property

    Private _SoTienThoiLai As Decimal
    Property SoTienThoiLai As Decimal
        Get
            If Me.SoTienKhachDua >= TongTienDaGiamGia Then
                Return Me.SoTienKhachDua - TongTienDaGiamGia
            End If
            Return 0
        End Get
        Set(value As Decimal)
            _SoTienThoiLai = value
        End Set
    End Property


    ReadOnly Property SoTienThanhToan As Decimal
        Get
            Dim rls = dt.tbThuNoKhachHangs.Where(Function(s) s.idHoaDon = Me.id)
            If rls.Count = 0 Then
                Return Me.SoTienKhachDua
            Else
                Return rls.Sum(Function(s) s.SoTien)
            End If
        End Get
    End Property

    ReadOnly Property TenNhanVien As String
        Get
            Dim nhanvien As tbNhanVien = dt.tbNhanViens.Single(Function(s) s.id = Me._idNhanVien)
            Return nhanvien.TenNhanVien
        End Get
    End Property

    ReadOnly Property TenKhachHang As String
        Get
            Dim khachhang As tbKhachHang = dt.tbKhachHangs.Single(Function(s) s.id = Me._idKhachHang)
            Return khachhang.TenKhachHang
        End Get
    End Property
End Class
